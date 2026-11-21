using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002118 RID: 8472
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class TermExplanationController : ControllerBase
{
	// Token: 0x17001F81 RID: 8065
	// (get) Token: 0x06014C39 RID: 85049 RVA: 0x006097E1 File Offset: 0x006079E1
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06014C3A RID: 85050 RVA: 0x006097E4 File Offset: 0x006079E4
	protected override bool OnInit()
	{
		EventSystem.Instance.Add(EEventName.OnTermExplanationViewClosed, new Action(this.OnTermExplanationViewClosed));
		EventSystem.Instance.Add(EEventName.OnTermExplanationViewBeforeStart, new Action<int>(this.OnTermExplanationViewBeforeStart));
		EventSystem.Instance.Add(EEventName.OnResetToBattleView, new Action(this.OnResetToBattleView));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnTermExplanationRegisteredTextContentChange, new Action<IReadOnlyList<int>>(this.OnTextChange));
		return true;
	}

	// Token: 0x06014C3B RID: 85051 RVA: 0x00609864 File Offset: 0x00607A64
	protected override bool OnClear()
	{
		foreach (KeyValuePair<int, TermTextRegistryHandle> keyValuePair in this.RegistryMap)
		{
			this.HandlePool.Put(keyValuePair.Value);
		}
		this.RegistryId = 0;
		this.UsingHandle = null;
		this.RegistryMap.Clear();
		this.HandlePool.Clear();
		this.GroupList.Clear();
		this.CurGroup = ETermExplanationGroup.Default;
		EventSystem.Instance.Remove(EEventName.OnTermExplanationViewClosed, new Action(this.OnTermExplanationViewClosed));
		EventSystem.Instance.Remove(EEventName.OnTermExplanationViewBeforeStart, new Action<int>(this.OnTermExplanationViewBeforeStart));
		EventSystem.Instance.Remove(EEventName.OnResetToBattleView, new Action(this.OnResetToBattleView));
		EventSystem.Instance.Remove(EEventName.OnTermExplanationRegisteredTextContentChange, new Action<IReadOnlyList<int>>(this.OnTextChange));
		return true;
	}

	// Token: 0x06014C3C RID: 85052 RVA: 0x0060996C File Offset: 0x00607B6C
	protected override void OnTick(float delta)
	{
		bool flag = false;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, TermTextRegistryHandle> keyValuePair in this.RegistryMap)
		{
			TermTextRegistryHandle value = keyValuePair.Value;
			if (value.UiText != null && value.UiText.IsValid() && value.UiText.IsUIActiveInHierarchy())
			{
				if (value.LastText != value.UiText.text)
				{
					value.LastText = value.UiText.text;
					flag = true;
					list.Add(value.Id);
				}
				if (value.IsEnableStateDirty)
				{
					value.IsEnableStateDirty = false;
					flag = true;
					list.Add(value.Id);
				}
				if (!value.LastHierarchyActive)
				{
					value.LastHierarchyActive = true;
					flag = true;
					this.UseGroup(value.Group);
					list.Add(value.Id);
				}
			}
			TermTextRegistryHandle termTextRegistryHandle = value;
			UUIText uiText = value.UiText;
			termTextRegistryHandle.LastHierarchyActive = (uiText != null && uiText.IsUIActiveInHierarchy());
		}
		if (flag)
		{
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnTermExplanationRegisteredTextContentChange, list);
		}
	}

	// Token: 0x06014C3D RID: 85053 RVA: 0x00609AB4 File Offset: 0x00607CB4
	public int RegisterTextHyperlinkByParam(ITermExplanationRegistryParam param)
	{
		return this.RegisterTextHyperlink(param.UiText, param.ViewType, param.ReportType, (param.AttachDirection != null) ? param.AttachDirection.Value : ETermExplanationViewAttachDirection.None, param.AttachItem, param.OnDisableClick, param.CustomOffset, (param.Group != null) ? param.Group.Value : ETermExplanationGroup.Default, (param.Priority != null) ? param.Priority.Value : 0, (param.Style != null) ? param.Style.Value : ETermExplanationViewStyle.Default);
	}

	// Token: 0x06014C3E RID: 85054 RVA: 0x00609B70 File Offset: 0x00607D70
	[NullableContext(2)]
	public int RegisterTextHyperlink([Nullable(1)] UUIText uiText, ETermExplanationViewType type, ETermExplanationReportType reportType, ETermExplanationViewAttachDirection attachDir = ETermExplanationViewAttachDirection.None, UUIItem attachItem = null, Action onDisableClick = null, [Nullable(0)] ValueTuple<float, float>? customOffset = null, ETermExplanationGroup group = ETermExplanationGroup.Default, int priority = 0, ETermExplanationViewStyle style = ETermExplanationViewStyle.Default)
	{
		TermExplanationController.<>c__DisplayClass14_0 CS$<>8__locals1 = new TermExplanationController.<>c__DisplayClass14_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.uiText = uiText;
		if (this.GetIdByUiText(CS$<>8__locals1.uiText) != 0)
		{
			Log.Instance.Warn(ELogModule.TermExplanation, ELogAuthor.HYF, "术语解释文本控件注册失败: 控件重复注册", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		this.OnAddGroup(group);
		if (this.CurGroup != group)
		{
			this.UseGroup(group);
		}
		CS$<>8__locals1.handle = (this.HandlePool.Get() ?? this.HandlePool.Create());
		CS$<>8__locals1.handle.SetUiText(CS$<>8__locals1.uiText);
		CS$<>8__locals1.handle.SetType(type);
		CS$<>8__locals1.handle.OnDisableClick = onDisableClick;
		CS$<>8__locals1.handle.AttachDir = attachDir;
		CS$<>8__locals1.handle.AttachItem = (attachItem ?? CS$<>8__locals1.uiText);
		CS$<>8__locals1.handle.Group = group;
		CS$<>8__locals1.handle.Priority = priority;
		CS$<>8__locals1.handle.Style = style;
		CS$<>8__locals1.handle.ReportType = new ETermExplanationReportType?(reportType);
		if (customOffset != null)
		{
			CS$<>8__locals1.handle.Offset = customOffset.Value;
		}
		Dictionary<int, TermTextRegistryHandle> registryMap = this.RegistryMap;
		int num = this.RegistryId + 1;
		this.RegistryId = num;
		registryMap[num] = CS$<>8__locals1.handle;
		CS$<>8__locals1.handle.Id = this.RegistryId;
		CS$<>8__locals1.uiText.OnHyperLinkClickCallBack.Bind(new Func<string, bool>(CS$<>8__locals1.<RegisterTextHyperlink>g__OnHyperLink|0));
		CS$<>8__locals1.uiText.SetRichText(true);
		CS$<>8__locals1.uiText.SetEnableHyperLinksHighlight(true);
		CS$<>8__locals1.uiText.HyperLinksHoverColor = FColor.FromHex("FED93E4C");
		CS$<>8__locals1.uiText.bFilterHyperLinks = false;
		(CS$<>8__locals1.uiText.GetOwner() as AUIBaseActor).OnPreDestroyed.Add(delegate(AActor _)
		{
			Log.Instance.Info(ELogModule.TermExplanation, ELogAuthor.HYF, "存在文本控件销毁前未解注册!", default(ReadOnlySpan<ValueTuple<string, object>>));
			CS$<>8__locals1.<>4__this.UnRegisterTextHyperlink(CS$<>8__locals1.uiText);
		});
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnTermExplanationRegisteredTextContentChange, new <>z__ReadOnlySingleElementList<int>(CS$<>8__locals1.handle.Id));
		return this.RegistryId;
	}

	// Token: 0x06014C3F RID: 85055 RVA: 0x00609D70 File Offset: 0x00607F70
	public void UnRegisterTextHyperlink(UUIText uiText)
	{
		int idByUiText = this.GetIdByUiText(uiText);
		if (idByUiText == 0)
		{
			Log.Instance.Info(ELogModule.TermExplanation, ELogAuthor.HYF, "解注册失败: 未注册的text控件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.UnRegisterTextHyperlinkById(idByUiText);
	}

	// Token: 0x06014C40 RID: 85056 RVA: 0x00609DB0 File Offset: 0x00607FB0
	public void UnRegisterTextHyperlinkById(int id)
	{
		TermTextRegistryHandle termTextRegistryHandle;
		if (!this.RegistryMap.TryGetValue(id, out termTextRegistryHandle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TermExplanation;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "解注册失败: 不存在此id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.OnRemoveGroup(termTextRegistryHandle.Group);
		termTextRegistryHandle.Clear();
		this.RegistryMap.Remove(id);
		this.HandlePool.Put(termTextRegistryHandle);
	}

	// Token: 0x06014C41 RID: 85057 RVA: 0x00609E2C File Offset: 0x0060802C
	public void SetEnableHyperLink(UUIText uiText, bool enable)
	{
		int idByUiText = this.GetIdByUiText(uiText);
		if (idByUiText == 0)
		{
			Log.Instance.Error(ELogModule.TermExplanation, ELogAuthor.HYF, "设置启禁用失败: 未注册的text控件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SetEnableHyperLinkById(idByUiText, enable);
	}

	// Token: 0x06014C42 RID: 85058 RVA: 0x00609E6C File Offset: 0x0060806C
	public void SetEnableHyperLinkById(int id, bool enable)
	{
		TermTextRegistryHandle termTextRegistryHandle;
		if (!this.RegistryMap.TryGetValue(id, out termTextRegistryHandle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TermExplanation;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "设置启禁用失败: 不存在此id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (termTextRegistryHandle.Enable == enable)
		{
			return;
		}
		termTextRegistryHandle.SetEnable(enable);
	}

	// Token: 0x06014C43 RID: 85059 RVA: 0x00609ECC File Offset: 0x006080CC
	public bool OpenTermExplanationView(UUIText uiText)
	{
		int idByUiText = this.GetIdByUiText(uiText);
		if (idByUiText == 0)
		{
			Log.Instance.Error(ELogModule.TermExplanation, ELogAuthor.HYF, "术语解释打开失败: 未注册的text控件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		TermTextRegistryHandle handle;
		if (!this.RegistryMap.TryGetValue(idByUiText, out handle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TermExplanation;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "术语解释打开失败: 不存在此id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", idByUiText);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		List<string> list = this.ParseText2HyperLinkList(uiText.text, true);
		if (list.Count == 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.TermExplanation;
			ELogAuthor author2 = ELogAuthor.HYF;
			string message2 = "术语解释打开失败: 文本中无超链接";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", idByUiText);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		return this.OpenTermExplanationViewImp(handle, list[0]);
	}

	// Token: 0x06014C44 RID: 85060 RVA: 0x00609F9C File Offset: 0x0060819C
	public void OpenTermExplanationViewDirectly()
	{
		List<string> list = new List<string>();
		TermTextRegistryHandle termTextRegistryHandle = null;
		foreach (TermTextRegistryHandle termTextRegistryHandle2 in this.GetHandlesByGroup(this.CurGroup, true))
		{
			List<string> list2 = this.ParseText2HyperLinkList(termTextRegistryHandle2.UiText.text, false);
			foreach (string item in list2)
			{
				list.Add(item);
			}
			if (list2.Count > 0 && termTextRegistryHandle == null)
			{
				termTextRegistryHandle = termTextRegistryHandle2;
			}
		}
		if (list.Count == 0 || termTextRegistryHandle == null)
		{
			Log.Instance.Error(ELogModule.TermExplanation, ELogAuthor.HYF, "术语解释打开失败: 当前文本中无超链接", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!termTextRegistryHandle.Enable)
		{
			Log.Instance.Error(ELogModule.TermExplanation, ELogAuthor.HYF, "术语解释打开失败: 当前文本术语功能已被手动设为失效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		termTextRegistryHandle.NeedHighlight = false;
		if (termTextRegistryHandle.ReportType != null)
		{
			this.ReportClickTermExplanation(termTextRegistryHandle.ReportType.Value);
		}
		this.UsingHandle = termTextRegistryHandle;
		TermExplanationViewParam param = new TermExplanationViewParam
		{
			HyperLinkList = new List<string>(new HashSet<string>(list))
		};
		EUiViewName termViewName = this.GetTermViewName(termTextRegistryHandle);
		EventSystem.Instance.Emit<ETermExplanationViewType>(EEventName.OnTermExplanationViewOpening, termTextRegistryHandle.Type);
		UiManager.Instance.OpenView(termViewName, param, null);
	}

	// Token: 0x06014C45 RID: 85061 RVA: 0x0060A124 File Offset: 0x00608324
	public bool HasAnyTermInCurrentTexts()
	{
		foreach (KeyValuePair<int, TermTextRegistryHandle> keyValuePair in this.RegistryMap)
		{
			TermTextRegistryHandle value = keyValuePair.Value;
			if (value.UiText != null && value.UiText.IsValid() && value.UiText.IsUIActiveInHierarchy() && value.Enable && value.Group == this.CurGroup && this.ParseText2HyperLinkList(value.UiText.text, true).Count > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014C46 RID: 85062 RVA: 0x0060A1D4 File Offset: 0x006083D4
	public bool IsUiTextRegistered(UUIText uiText)
	{
		return this.GetIdByUiText(uiText) != 0;
	}

	// Token: 0x06014C47 RID: 85063 RVA: 0x0060A1E0 File Offset: 0x006083E0
	private void OnAddGroup(ETermExplanationGroup inGroup)
	{
		int num = -1;
		for (int i = 0; i < this.GroupList.Count; i++)
		{
			if (this.GroupList[i].Item1 == inGroup)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			this.GroupList.Add(new ValueTuple<ETermExplanationGroup, int>(inGroup, 1));
			return;
		}
		int item = this.GroupList[num].Item2 + 1;
		this.GroupList.RemoveAt(num);
		this.GroupList.Add(new ValueTuple<ETermExplanationGroup, int>(inGroup, item));
	}

	// Token: 0x06014C48 RID: 85064 RVA: 0x0060A268 File Offset: 0x00608468
	private void OnRemoveGroup(ETermExplanationGroup inGroup)
	{
		int num = -1;
		for (int i = 0; i < this.GroupList.Count; i++)
		{
			if (this.GroupList[i].Item1 == inGroup)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return;
		}
		int num2 = this.GroupList[num].Item2 - 1;
		if (num2 <= 0)
		{
			this.GroupList.RemoveAt(num);
			if (this.CurGroup == inGroup)
			{
				if (this.GroupList.Count == 0)
				{
					this.CurGroup = ETermExplanationGroup.Default;
					return;
				}
				this.UseGroup(this.GroupList[this.GroupList.Count - 1].Item1);
				return;
			}
		}
		else
		{
			this.GroupList[num] = new ValueTuple<ETermExplanationGroup, int>(this.GroupList[num].Item1, num2);
		}
	}

	// Token: 0x06014C49 RID: 85065 RVA: 0x0060A334 File Offset: 0x00608534
	private void UseGroup(ETermExplanationGroup inGroup)
	{
		int num = -1;
		for (int i = 0; i < this.GroupList.Count; i++)
		{
			if (this.GroupList[i].Item1 == inGroup)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TermExplanation;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "术语解释组不存在: ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Group", inGroup);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.CurGroup = inGroup;
		ValueTuple<ETermExplanationGroup, int> item = this.GroupList[num];
		this.GroupList.RemoveAt(num);
		this.GroupList.Add(item);
	}

	// Token: 0x06014C4A RID: 85066 RVA: 0x0060A3D4 File Offset: 0x006085D4
	private List<TermTextRegistryHandle> GetHandlesByGroup(ETermExplanationGroup group, bool checkVisible = true)
	{
		List<TermTextRegistryHandle> list = new List<TermTextRegistryHandle>();
		foreach (KeyValuePair<int, TermTextRegistryHandle> keyValuePair in this.RegistryMap)
		{
			TermTextRegistryHandle value = keyValuePair.Value;
			if (value.Group == group && value.UiText != null && value.UiText.IsValid() && (!checkVisible || value.UiText.IsUIActiveInHierarchy()))
			{
				list.Add(value);
			}
		}
		list.Sort(delegate(TermTextRegistryHandle a, TermTextRegistryHandle b)
		{
			int num = a.Priority - b.Priority;
			if (num == 0)
			{
				return a.Id - b.Id;
			}
			return num;
		});
		return list;
	}

	// Token: 0x06014C4B RID: 85067 RVA: 0x0060A48C File Offset: 0x0060868C
	private int GetIdByUiText(UUIText uiText)
	{
		foreach (KeyValuePair<int, TermTextRegistryHandle> keyValuePair in this.RegistryMap)
		{
			if (keyValuePair.Value.UiText == uiText)
			{
				return keyValuePair.Key;
			}
		}
		return 0;
	}

	// Token: 0x06014C4C RID: 85068 RVA: 0x0060A4F4 File Offset: 0x006086F4
	private bool OpenTermExplanationViewImp(TermTextRegistryHandle handle, string hyperLinkId)
	{
		if (handle.ReportType != null)
		{
			this.ReportClickTermExplanation(handle.ReportType.Value);
		}
		if (!handle.Enable)
		{
			if (handle.OnDisableClick != null)
			{
				handle.OnDisableClick();
			}
			return true;
		}
		if (!this.IsHyperLinkValid(hyperLinkId))
		{
			return true;
		}
		handle.NeedHighlight = true;
		this.UseGroup(handle.Group);
		this.UsingHandle = handle;
		EUiViewName termViewName = this.GetTermViewName(handle);
		List<string> list = new List<string>();
		foreach (TermTextRegistryHandle termTextRegistryHandle in this.GetHandlesByGroup(this.CurGroup, true))
		{
			foreach (string text in this.ParseText2HyperLinkList(termTextRegistryHandle.UiText.text, false))
			{
				if (this.IsHyperLinkValid(text))
				{
					list.Add(text);
				}
			}
		}
		TermExplanationViewParam param = new TermExplanationViewParam
		{
			HyperLinkList = new List<string>(new HashSet<string>(list)),
			FocusedHyperLink = hyperLinkId
		};
		UiManager.Instance.OpenView(termViewName, param, null);
		EventSystem.Instance.Emit<ETermExplanationViewType>(EEventName.OnTermExplanationViewOpening, handle.Type);
		return true;
	}

	// Token: 0x06014C4D RID: 85069 RVA: 0x0060A654 File Offset: 0x00608854
	private List<string> ParseText2HyperLinkList(string text, bool unique = true)
	{
		MatchCollection matchCollection = new Regex("href\\s*=\\s*([\"]?)([^\"'\\s>]+)\\1", RegexOptions.IgnoreCase).Matches(text);
		List<string> list = new List<string>();
		foreach (object obj in matchCollection)
		{
			Match match = (Match)obj;
			if (match.Groups.Count > 2 && match.Groups[2].Success)
			{
				list.Add(match.Groups[2].Value);
			}
		}
		if (!unique)
		{
			return list;
		}
		return new List<string>(new HashSet<string>(list));
	}

	// Token: 0x06014C4E RID: 85070 RVA: 0x0060A700 File Offset: 0x00608900
	private void OnViewOpen(TermTextRegistryHandle handle)
	{
		if (handle.AttachDir == ETermExplanationViewAttachDirection.None)
		{
			return;
		}
		if (handle.Type == ETermExplanationViewType.Side)
		{
			this.HandleSideViewAttach(handle);
		}
		else if (handle.Type == ETermExplanationViewType.Center)
		{
			this.HandleCenterViewAttach(handle);
		}
		this.HandleOffset(handle);
	}

	// Token: 0x06014C4F RID: 85071 RVA: 0x0060A734 File Offset: 0x00608934
	private bool IsHyperLinkValid(string hyperLink)
	{
		int p0Id;
		if (!int.TryParse(hyperLink, out p0Id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TermExplanation;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "超链接id无法转换为数字id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", hyperLink);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (ConfigTermConfigById.GetConfig(p0Id, true) == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.TermExplanation;
			ELogAuthor author2 = ELogAuthor.HYF;
			string message2 = "词条未在表s.术语中注册";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("词条", hyperLink);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		return true;
	}

	// Token: 0x06014C50 RID: 85072 RVA: 0x0060A7B8 File Offset: 0x006089B8
	private void HandleSideViewAttach(TermTextRegistryHandle handle)
	{
		TermExplanationView termExplanationView = UiManager.Instance.GetView(handle.ViewId) as TermExplanationView;
		if (termExplanationView == null)
		{
			return;
		}
		if (handle.AttachDir != ETermExplanationViewAttachDirection.Left && handle.AttachDir != ETermExplanationViewAttachDirection.Right)
		{
			Log.Instance.Warn(ELogModule.TermExplanation, ELogAuthor.HYF, "界面吸附失败: 吸附方向与界面类型不匹配", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = (handle.AttachDir == ETermExplanationViewAttachDirection.Left) ? -1 : 1;
		UUIItem tipItem = termExplanationView.GetTipItem();
		FVector lguispaceAbsolutePosition = tipItem.GetLGUISpaceAbsolutePosition();
		UUIItem attachItem = handle.AttachItem;
		float num2 = attachItem.GetLGUISpaceAbsolutePosition().X;
		float x = attachItem.K2_GetComponentScale().X;
		float x2 = tipItem.K2_GetComponentScale().X;
		float x3 = attachItem.GetPivot().X;
		num2 += (0.5f - x3) * attachItem.Width * x;
		UUIItem uuiitem = tipItem;
		FVector fvector = new FVector(num2 + (float)num * (attachItem.Width * x + tipItem.Width * x2) / 2f, lguispaceAbsolutePosition.Y, lguispaceAbsolutePosition.Z);
		uuiitem.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x06014C51 RID: 85073 RVA: 0x0060A8C0 File Offset: 0x00608AC0
	private void HandleCenterViewAttach(TermTextRegistryHandle handle)
	{
		TermExplanationView termExplanationView = UiManager.Instance.GetView(handle.ViewId) as TermExplanationView;
		if (termExplanationView == null)
		{
			return;
		}
		if (handle.AttachDir != ETermExplanationViewAttachDirection.Up && handle.AttachDir != ETermExplanationViewAttachDirection.Down)
		{
			Log.Instance.Warn(ELogModule.TermExplanation, ELogAuthor.HYF, "界面吸附失败: 吸附方向与界面类型不匹配", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = (handle.AttachDir == ETermExplanationViewAttachDirection.Up) ? 1 : -1;
		UUIItem tipItem = termExplanationView.GetTipItem();
		UUIItem parentAsUIItem = tipItem.GetParentAsUIItem();
		FVector lguispaceAbsolutePosition = parentAsUIItem.GetLGUISpaceAbsolutePosition();
		UUIItem attachItem = handle.AttachItem;
		float num2 = attachItem.GetLGUISpaceAbsolutePosition().Y;
		float y = attachItem.K2_GetComponentScale().Y;
		float y2 = tipItem.K2_GetComponentScale().Y;
		float y3 = attachItem.GetPivot().Y;
		num2 += (0.5f - y3) * attachItem.Height * y;
		FVector fvector = new FVector(lguispaceAbsolutePosition.X, num2 + (float)num * (attachItem.Height * y + tipItem.Height * y2) / 2f, lguispaceAbsolutePosition.Z);
		parentAsUIItem.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x06014C52 RID: 85074 RVA: 0x0060A9D0 File Offset: 0x00608BD0
	private void HandleOffset(TermTextRegistryHandle handle)
	{
		TermExplanationView termExplanationView = UiManager.Instance.GetView(handle.ViewId) as TermExplanationView;
		if (termExplanationView == null)
		{
			return;
		}
		UUIItem tipItem = termExplanationView.GetTipItem();
		FVector lguispaceAbsolutePosition = tipItem.GetLGUISpaceAbsolutePosition();
		FVector fvector = new FVector(lguispaceAbsolutePosition.X + handle.Offset.Item1, lguispaceAbsolutePosition.Y + handle.Offset.Item2, lguispaceAbsolutePosition.Z);
		tipItem.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x06014C53 RID: 85075 RVA: 0x0060AA3C File Offset: 0x00608C3C
	private EUiViewName GetTermViewName(TermTextRegistryHandle handle)
	{
		ETermExplanationViewType type = handle.Type;
		ETermExplanationViewStyle style = handle.Style;
		TermExplanationViewStyle? config = ConfigTermExplanationViewStyleById.GetConfig((int)style, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TermExplanation;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "术语解释风格化配置不存在: ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", style);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return this.Type2ViewName[type];
		}
		TermExplanationViewStyle value = config.Value;
		return (EUiViewName)((type == ETermExplanationViewType.Center) ? value.CenterView : value.SideView);
	}

	// Token: 0x06014C54 RID: 85076 RVA: 0x0060AAC4 File Offset: 0x00608CC4
	private void ReportEnterViewWithTerms(ETermExplanationReportType type)
	{
		EnterViewWithTermsEvent enterViewWithTermsEvent = new EnterViewWithTermsEvent();
		enterViewWithTermsEvent.i_scene = (int)type;
		LogReportController.Instance.LogReport(enterViewWithTermsEvent);
	}

	// Token: 0x06014C55 RID: 85077 RVA: 0x0060AAEC File Offset: 0x00608CEC
	private void ReportClickTermExplanation(ETermExplanationReportType type)
	{
		ClickTermExplanationEvent clickTermExplanationEvent = new ClickTermExplanationEvent();
		clickTermExplanationEvent.i_scene = (int)type;
		LogReportController.Instance.LogReport(clickTermExplanationEvent);
	}

	// Token: 0x06014C56 RID: 85078 RVA: 0x0060AB14 File Offset: 0x00608D14
	private void OnTextChange(IReadOnlyList<int> changeList)
	{
		foreach (int key in changeList)
		{
			TermTextRegistryHandle termTextRegistryHandle;
			if (this.RegistryMap.TryGetValue(key, out termTextRegistryHandle) && this.ParseText2HyperLinkList(termTextRegistryHandle.UiText.text, true).Count > 0)
			{
				this.ReportEnterViewWithTerms(termTextRegistryHandle.ReportType.Value);
			}
		}
	}

	// Token: 0x06014C57 RID: 85079 RVA: 0x0060AB90 File Offset: 0x00608D90
	private void OnTermExplanationViewClosed()
	{
		foreach (KeyValuePair<int, TermTextRegistryHandle> keyValuePair in this.RegistryMap)
		{
			TermTextRegistryHandle value = keyValuePair.Value;
			if (value.UiText != null && value.UiText.IsValid())
			{
				value.UiText.SetHyperLinksHoverSpiteActive(false);
				value.UiText.SetEnableHyperLinksHighlight(true);
			}
		}
	}

	// Token: 0x06014C58 RID: 85080 RVA: 0x0060AC14 File Offset: 0x00608E14
	private void OnTermExplanationViewBeforeStart(int viewId)
	{
		if (this.UsingHandle == null)
		{
			return;
		}
		this.UsingHandle.ViewId = viewId;
		if (this.UsingHandle.NeedHighlight)
		{
			UUIText uiText = this.UsingHandle.UiText;
			if (uiText != null)
			{
				uiText.SetEnableHyperLinksHighlight(false);
			}
			UUIText uiText2 = this.UsingHandle.UiText;
			if (uiText2 != null)
			{
				uiText2.SetHyperLinksHoverSpiteActive(true);
			}
		}
		this.OnViewOpen(this.UsingHandle);
	}

	// Token: 0x06014C59 RID: 85081 RVA: 0x0060AC7D File Offset: 0x00608E7D
	private void OnResetToBattleView()
	{
		UiManager.Instance.CloseView(EUiViewName.TermExplanationSideView, null);
		UiManager.Instance.CloseView(EUiViewName.TermExplanationCenterView, null);
		UiManager.Instance.CloseView(EUiViewName.FloroRanchTermExplanationCenterView, null);
	}

	// Token: 0x17001F82 RID: 8066
	// (get) Token: 0x06014C5A RID: 85082 RVA: 0x0060ACAF File Offset: 0x00608EAF
	public static TermExplanationController Instance
	{
		get
		{
			return TermExplanationController._Instance;
		}
	}

	// Token: 0x06014C5B RID: 85083 RVA: 0x0060ACB6 File Offset: 0x00608EB6
	public static TermExplanationController GetOrCreateInstance()
	{
		if (TermExplanationController._Instance == null)
		{
			TermExplanationController.CreateInstance();
		}
		return TermExplanationController._Instance;
	}

	// Token: 0x06014C5C RID: 85084 RVA: 0x0060ACCA File Offset: 0x00608ECA
	public static bool CreateInstance()
	{
		if (TermExplanationController._Instance != null)
		{
			return true;
		}
		TermExplanationController._Instance = new TermExplanationController();
		return true;
	}

	// Token: 0x06014C5D RID: 85085 RVA: 0x0060ACE0 File Offset: 0x00608EE0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014C5E RID: 85086 RVA: 0x0060ACE2 File Offset: 0x00608EE2
	public static void ResetStaticDefaultValue()
	{
		TermExplanationController._Instance = null;
	}

	// Token: 0x06014C5F RID: 85087 RVA: 0x0060ACEA File Offset: 0x00608EEA
	static TermExplanationController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TermExplanationController.CreateStaticDefaultValue), new Action(TermExplanationController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B106 RID: 45318
	private const int POOL_CAPACITY = 5;

	// Token: 0x0400B107 RID: 45319
	private int RegistryId;

	// Token: 0x0400B108 RID: 45320
	[Nullable(2)]
	private TermTextRegistryHandle UsingHandle;

	// Token: 0x0400B109 RID: 45321
	private ETermExplanationGroup CurGroup;

	// Token: 0x0400B10A RID: 45322
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<ETermExplanationGroup, int>> GroupList = new List<ValueTuple<ETermExplanationGroup, int>>();

	// Token: 0x0400B10B RID: 45323
	private readonly Dictionary<ETermExplanationViewType, EUiViewName> Type2ViewName = new Dictionary<ETermExplanationViewType, EUiViewName>
	{
		{
			ETermExplanationViewType.Center,
			EUiViewName.TermExplanationCenterView
		},
		{
			ETermExplanationViewType.Side,
			EUiViewName.TermExplanationSideView
		}
	};

	// Token: 0x0400B10C RID: 45324
	private readonly Dictionary<int, TermTextRegistryHandle> RegistryMap = new Dictionary<int, TermTextRegistryHandle>();

	// Token: 0x0400B10D RID: 45325
	private readonly Pool<TermTextRegistryHandle> HandlePool = new Pool<TermTextRegistryHandle>(5, () => new TermTextRegistryHandle(), delegate(TermTextRegistryHandle handle)
	{
		handle.Clear();
	});

	// Token: 0x0400B10E RID: 45326
	[Nullable(2)]
	private static TermExplanationController _Instance;
}
