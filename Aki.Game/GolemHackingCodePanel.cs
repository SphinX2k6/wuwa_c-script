using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001015 RID: 4117
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingCodePanel : UiPanelBase
{
	// Token: 0x0600699E RID: 27038 RVA: 0x0015176A File Offset: 0x0014F96A
	public GolemHackingCodePanel(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x0600699F RID: 27039 RVA: 0x00151780 File Offset: 0x0014F980
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickedHelp));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickedReset));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060069A0 RID: 27040 RVA: 0x00151999 File Offset: 0x0014FB99
	protected override void OnStart()
	{
		this.InitLayout();
		this.InitGamePlay();
		this.InitInfo();
	}

	// Token: 0x060069A1 RID: 27041 RVA: 0x001519B0 File Offset: 0x0014FBB0
	protected void InitLayout()
	{
		this.CodeLayout = new GenericLayout<GolemHackingCodeKeyListItem, List<GolemHackingCodeGridInfo>>(base.GetVerticalLayout(0), new Func<GolemHackingCodeKeyListItem>(this.CreateCodePanelItem), null, false, true);
		this.IconLayout = new GenericLayout<GolemHackingCodeIconItem, EGolemHackingBarState>(base.GetVerticalLayout(3), new Func<GolemHackingCodeIconItem>(this.CreateIconItem), null, false, true);
		this.BarLayout = new GenericLayout<GolemHackingCodeKeyBarItem, EGolemHackingBarState>(base.GetVerticalLayout(5), new Func<GolemHackingCodeKeyBarItem>(this.CreateBarItem), null, false, true);
		this.InputLayout = new GenericLayout<GolemHackingCodeInputItem, GolemHackingInputInfo>(base.GetHorizontalLayout(8), new Func<GolemHackingCodeInputItem>(this.CreateInputItem), null, false, true);
	}

	// Token: 0x060069A2 RID: 27042 RVA: 0x00151A44 File Offset: 0x0014FC44
	protected void InitGamePlay()
	{
		this.Proxy.ResetCodeCallback = new Action(this.OnResetCallBack);
		this.Proxy.HoverMatrixCallback = new Action<int, string>(this.OnMatrixHoverCallBack);
		this.Proxy.UnHoverMatrixCallback = new Action(this.OnMatrixUnHoverCallBack);
		this.Proxy.EnterCodeCallback = new Action<List<string>, List<GolemHackingCodeEnterResult>>(this.OnMatrixEnterCallBack);
	}

	// Token: 0x060069A3 RID: 27043 RVA: 0x00151AB0 File Offset: 0x0014FCB0
	protected void InitInfo()
	{
		UUIButtonComponent button = base.GetButton(10);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(this.Proxy.NeedHelpBtn());
		}
		this.Proxy.InitCodePanelInfo();
	}

	// Token: 0x060069A4 RID: 27044 RVA: 0x00151AF4 File Offset: 0x0014FCF4
	protected void RefreshEnterPanel(List<string> inputList, List<GolemHackingCodeEnterResult> codeParam)
	{
		int maxLength = this.Proxy.GetMaxLength();
		UUIText text = base.GetText(7);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(inputList.Count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(maxLength);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		int num = Math.Min(inputList.Count, maxLength - 1);
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetAnchorOffsetX((float)(9 + num * 133));
		}
		List<GolemHackingInputInfo> inputDataList = this.GetInputDataList(inputList, codeParam);
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixUnHover();
		}
		this.InputLayout.RefreshByData(inputDataList, null, false);
	}

	// Token: 0x060069A5 RID: 27045 RVA: 0x00151BE0 File Offset: 0x0014FDE0
	protected List<GolemHackingInputInfo> GetInputDataList(List<string> inputList, List<GolemHackingCodeEnterResult> codeParam)
	{
		int maxLength = this.Proxy.GetMaxLength();
		List<GolemHackingInputInfo> list = new List<GolemHackingInputInfo>();
		bool isReset = this.Proxy.IsRestart && inputList.Count == 0;
		bool isFail = false;
		int num = 0;
		foreach (GolemHackingCodeEnterResult golemHackingCodeEnterResult in codeParam)
		{
			if (golemHackingCodeEnterResult.State == EGolemHackingBarState.Success)
			{
				num++;
			}
			else if (golemHackingCodeEnterResult.State == EGolemHackingBarState.Fail)
			{
				isFail = true;
				break;
			}
		}
		bool isSuccess = num == codeParam.Count;
		int animCount = 0;
		Action<GolemHackingInputInfo, int> action = delegate(GolemHackingInputInfo data, int index)
		{
			if (isSuccess | isFail | isReset)
			{
				data.AnimIndex = index + 1;
				if (isReset)
				{
					data.AnimName = "Reset";
					return;
				}
				int animCount;
				if (isSuccess)
				{
					animCount = animCount;
					animCount++;
					data.AnimName = "Success";
					return;
				}
				if (isFail)
				{
					animCount = animCount;
					animCount++;
					data.AnimName = "Fail";
				}
			}
		};
		for (int i = 0; i < 9; i++)
		{
			GolemHackingInputInfo golemHackingInputInfo = new GolemHackingInputInfo
			{
				Code = "",
				State = EGolemHackingInputState.Block,
				AnimIndex = 0,
				AnimName = ""
			};
			if (i < inputList.Count)
			{
				golemHackingInputInfo.Code = inputList[i];
				golemHackingInputInfo.State = EGolemHackingInputState.Occupy;
				action(golemHackingInputInfo, i);
			}
			else if (i == inputList.Count && i < maxLength)
			{
				golemHackingInputInfo.State = EGolemHackingInputState.Enterring;
				action(golemHackingInputInfo, i);
			}
			else if (i < maxLength)
			{
				golemHackingInputInfo.State = EGolemHackingInputState.Empty;
				action(golemHackingInputInfo, i);
			}
			list.Add(golemHackingInputInfo);
		}
		if (animCount > 0)
		{
			this.BarAnimCount = animCount;
		}
		return list;
	}

	// Token: 0x060069A6 RID: 27046 RVA: 0x00151D7C File Offset: 0x0014FF7C
	protected void RefreshCodePanel(List<GolemHackingCodeEnterResult> codeParam, bool needAnim)
	{
		List<EGolemHackingBarState> list = new List<EGolemHackingBarState>();
		List<List<GolemHackingCodeGridInfo>> list2 = new List<List<GolemHackingCodeGridInfo>>();
		int num = 0;
		int num2 = 0;
		foreach (GolemHackingCodeEnterResult golemHackingCodeEnterResult in codeParam)
		{
			list.Add(golemHackingCodeEnterResult.State);
			if (golemHackingCodeEnterResult.State != EGolemHackingBarState.Default)
			{
				num++;
			}
			if (golemHackingCodeEnterResult.State == EGolemHackingBarState.Fail)
			{
				num2++;
			}
			if (needAnim)
			{
				for (int i = 0; i < golemHackingCodeEnterResult.Code.Count; i++)
				{
					golemHackingCodeEnterResult.Code[i].AnimIndex = i + 1;
				}
			}
			list2.Add(golemHackingCodeEnterResult.Code);
		}
		if (num == codeParam.Count || num2 > 0)
		{
			if (this.BarAnimCount == -1)
			{
				this.BarAnimCount = 0;
			}
			this.BarAnimCount += ((num2 > 0) ? num2 : num);
			if (num2 > 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("IntrusionProtocol_InsufficientBufferTips", Array.Empty<object>());
			}
			UiLayer.Instance.SetShowNormalMaskLayer(true, "");
		}
		else
		{
			this.BarAnimCount = -1;
		}
		this.CodeLayout.RefreshByData(list2, null, false);
		this.BarLayout.RefreshByData(list, null, false);
		this.IconLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060069A7 RID: 27047 RVA: 0x00151ECC File Offset: 0x001500CC
	private void OnClickedHelp()
	{
		List<GolemHackingTipsGirdInfo> helpTipsInfo = this.Proxy.GetHelpTipsInfo();
		UiManager.Instance.OpenView(EUiViewName.GolemHackingGameTipsPopView, helpTipsInfo, null);
	}

	// Token: 0x060069A8 RID: 27048 RVA: 0x00151EF8 File Offset: 0x001500F8
	private void OnClickedReset()
	{
		double now = Time.Instance.Now;
		if (now - this.ResetTimeRecord < 400.0)
		{
			return;
		}
		this.ResetTimeRecord = now;
		this.Proxy.Reset();
	}

	// Token: 0x060069A9 RID: 27049 RVA: 0x00151F38 File Offset: 0x00150138
	private void OnMatrixHoverCallBack(int curIndex, string code)
	{
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixHover(curIndex, code);
		}
		GolemHackingCodeInputItem layoutItemByIndex = this.InputLayout.GetLayoutItemByIndex(curIndex);
		if (layoutItemByIndex == null)
		{
			return;
		}
		layoutItemByIndex.EnterInputCode(code);
	}

	// Token: 0x060069AA RID: 27050 RVA: 0x00151FA8 File Offset: 0x001501A8
	private void OnMatrixUnHoverCallBack()
	{
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixUnHover();
		}
		foreach (GolemHackingCodeInputItem golemHackingCodeInputItem in this.InputLayout.GetLayoutItemList())
		{
			golemHackingCodeInputItem.ClearInputCode();
		}
	}

	// Token: 0x060069AB RID: 27051 RVA: 0x00152044 File Offset: 0x00150244
	private void OnMatrixEnterCallBack(List<string> curEnter, List<GolemHackingCodeEnterResult> codeParam)
	{
		this.RefreshEnterPanel(curEnter, codeParam);
		this.RefreshCodePanel(codeParam, curEnter.Count == 0);
	}

	// Token: 0x060069AC RID: 27052 RVA: 0x00152060 File Offset: 0x00150260
	private void OnResetCallBack()
	{
		UUIButtonComponent button = base.GetButton(10);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(this.Proxy.NeedHelpBtn());
		}
		this.Proxy.InitCodePanelInfo();
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetAnchorOffsetX(9f);
		}
		foreach (GolemHackingCodeKeyListItem golemHackingCodeKeyListItem in this.CodeLayout.GetLayoutItemList())
		{
			golemHackingCodeKeyListItem.OnMatrixUnHover();
		}
	}

	// Token: 0x060069AD RID: 27053 RVA: 0x00152104 File Offset: 0x00150304
	private void OnBarAnimEnd()
	{
		if (this.BarAnimCount == -1)
		{
			return;
		}
		this.BarAnimCount--;
		if (this.BarAnimCount == 0)
		{
			this.Proxy.OnOneTurnEndAfterAnim();
			UiLayer.Instance.SetShowNormalMaskLayer(false, "");
			this.BarAnimCount = -1;
		}
	}

	// Token: 0x060069AE RID: 27054 RVA: 0x00152153 File Offset: 0x00150353
	private GolemHackingCodeKeyListItem CreateCodePanelItem()
	{
		return new GolemHackingCodeKeyListItem(this.Proxy);
	}

	// Token: 0x060069AF RID: 27055 RVA: 0x00152160 File Offset: 0x00150360
	private GolemHackingCodeIconItem CreateIconItem()
	{
		return new GolemHackingCodeIconItem();
	}

	// Token: 0x060069B0 RID: 27056 RVA: 0x00152167 File Offset: 0x00150367
	private GolemHackingCodeKeyBarItem CreateBarItem()
	{
		return new GolemHackingCodeKeyBarItem
		{
			OnAnimEndCallback = new Action(this.OnBarAnimEnd)
		};
	}

	// Token: 0x060069B1 RID: 27057 RVA: 0x00152180 File Offset: 0x00150380
	private GolemHackingCodeInputItem CreateInputItem()
	{
		return new GolemHackingCodeInputItem
		{
			OnBarAnimEnd = new Action(this.OnBarAnimEnd)
		};
	}

	// Token: 0x060069B2 RID: 27058 RVA: 0x00152199 File Offset: 0x00150399
	[NullableContext(2)]
	public GolemHackingCodeKeyListItem GetHorizontalPanelByIndex(int index)
	{
		if (this.CodeLayout.IsLock)
		{
			return null;
		}
		return this.CodeLayout.GetLayoutItemByIndex(index);
	}

	// Token: 0x040030B4 RID: 12468
	private const int SCAN_INTERNAL = 133;

	// Token: 0x040030B5 RID: 12469
	private const int SCAN_START = 9;

	// Token: 0x040030B6 RID: 12470
	private const int RESET_COOLDOWN = 400;

	// Token: 0x040030B7 RID: 12471
	protected GenericLayout<GolemHackingCodeKeyListItem, List<GolemHackingCodeGridInfo>> CodeLayout;

	// Token: 0x040030B8 RID: 12472
	protected GenericLayout<GolemHackingCodeIconItem, EGolemHackingBarState> IconLayout;

	// Token: 0x040030B9 RID: 12473
	protected GenericLayout<GolemHackingCodeKeyBarItem, EGolemHackingBarState> BarLayout;

	// Token: 0x040030BA RID: 12474
	protected GenericLayout<GolemHackingCodeInputItem, GolemHackingInputInfo> InputLayout;

	// Token: 0x040030BB RID: 12475
	protected int BarAnimCount = -1;

	// Token: 0x040030BC RID: 12476
	private double ResetTimeRecord;

	// Token: 0x040030BD RID: 12477
	protected GolemHackingGameProxy Proxy;

	// Token: 0x0200760E RID: 30222
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026FFB RID: 159739
		PanelKeyList,
		// Token: 0x04026FFC RID: 159740
		TexBgSelectFrame,
		// Token: 0x04026FFD RID: 159741
		PanelHackingKeyGroup,
		// Token: 0x04026FFE RID: 159742
		PanelLevelIcon,
		// Token: 0x04026FFF RID: 159743
		SpriteLevel,
		// Token: 0x04027000 RID: 159744
		PanelStateList,
		// Token: 0x04027001 RID: 159745
		PanelStateBar,
		// Token: 0x04027002 RID: 159746
		TxtKeyCount,
		// Token: 0x04027003 RID: 159747
		PanelCodeGrid,
		// Token: 0x04027004 RID: 159748
		CodeItem,
		// Token: 0x04027005 RID: 159749
		BtnHelp,
		// Token: 0x04027006 RID: 159750
		BtnReset
	}
}
