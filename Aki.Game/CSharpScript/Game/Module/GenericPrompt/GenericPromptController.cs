using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x02005992 RID: 22930
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class GenericPromptController : UiControllerBase
	{
		// Token: 0x0603A2FB RID: 238331 RVA: 0x00DD47B8 File Offset: 0x00DD29B8
		public void ShowPromptByCode(string promptId, params object[] param)
		{
			GenericPrompt? promptInfoByRawId = GenericPromptConfig.Instance.GetPromptInfoByRawId(promptId);
			if (promptInfoByRawId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GenericPrompt;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "配置不存在，请检查\"t.通用提示.xlsx\"";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", promptId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			TableTextArgNew promptMainTextObjByRawId = GenericPromptConfig.Instance.GetPromptMainTextObjByRawId(promptId);
			this.ShowPromptByItsType<object>((EPromptSubViewType)promptInfoByRawId.Value.TypeId, promptMainTextObjByRawId, null, param, null, null, null, null, null, false, null);
		}

		// Token: 0x0603A2FC RID: 238332 RVA: 0x00DD4840 File Offset: 0x00DD2A40
		public void ShowPromptByCodeWithCallback(string promptId, Action callback, params object[] param)
		{
			GenericPrompt? promptInfoByRawId = GenericPromptConfig.Instance.GetPromptInfoByRawId(promptId);
			if (promptInfoByRawId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GenericPrompt;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "配置不存在，请检查\"t.通用提示.xlsx\"";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", promptId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			TableTextArgNew promptMainTextObjByRawId = GenericPromptConfig.Instance.GetPromptMainTextObjByRawId(promptId);
			this.ShowPromptByItsType<object>((EPromptSubViewType)promptInfoByRawId.Value.TypeId, promptMainTextObjByRawId, null, param, null, new int?(int.Parse(promptId)), callback, null, null, false, null);
		}

		// Token: 0x0603A2FD RID: 238333 RVA: 0x00DD48C8 File Offset: 0x00DD2AC8
		[NullableContext(2)]
		public void ShowPromptByItsType(EPromptSubViewType typeId, TableTextArgNew mainTextObj = null, TableTextArgNew extraTextObj = null, [Nullable(new byte[]
		{
			2,
			1
		})] object[] mainTextParams = null, [Nullable(new byte[]
		{
			2,
			1
		})] object[] extraTextParams = null, int? promptId = null, Action callback = null)
		{
			this.ShowPromptByItsType<object>(typeId, mainTextObj, extraTextObj, mainTextParams, extraTextParams, promptId, callback, null, null, false, null);
		}

		// Token: 0x0603A2FE RID: 238334 RVA: 0x00DD48F4 File Offset: 0x00DD2AF4
		[NullableContext(2)]
		public void ShowPromptByItsType<T>(EPromptSubViewType typeId, TableTextArgNew mainTextObj = null, TableTextArgNew extraTextObj = null, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<object> mainTextParams = null, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<object> extraTextParams = null, int? promptId = null, Action callback = null, T extraParam = default(T), int? duration = null, bool inPlot = false, string promptKey = null)
		{
			PromptParamHub<T> promptParamHub = new PromptParamHub<T>();
			promptParamHub.TypeId = (int)typeId;
			promptParamHub.PromptId = promptId;
			promptParamHub.MainTextObj = mainTextObj;
			promptParamHub.ExtraTextObj = extraTextObj;
			promptParamHub.MainTextParams = mainTextParams;
			promptParamHub.ExtraTextParams = extraTextParams;
			promptParamHub.CloseCallback = callback;
			int? num = duration;
			promptParamHub.Duration = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			promptParamHub.ExtraParam = extraParam;
			promptParamHub.PromptKey = promptKey;
			PromptParamHub<T> promptParamHub2 = promptParamHub;
			if (typeId == EPromptSubViewType.FloatLinePrompt)
			{
				GenericPromptModel.Instance.ApplyPromptParamHub(promptParamHub2);
				return;
			}
			EUiViewName name;
			if (!GenericPromptDefine.genericPromptView.TryGetValue((int)typeId, out name))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GenericPrompt;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "genericPromptView 缺少映射";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TypeId", (int)typeId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (inPlot)
			{
				UiManager.Instance.OpenViewByPlot(name, promptParamHub2, null);
				return;
			}
			UiManager.Instance.OpenView(name, promptParamHub2, null);
		}

		// Token: 0x0603A2FF RID: 238335 RVA: 0x00DD49E4 File Offset: 0x00DD2BE4
		public EUiViewName? GetViewNameByPromptId(string promptId)
		{
			GenericPrompt? promptInfoByRawId = GenericPromptConfig.Instance.GetPromptInfoByRawId(promptId);
			if (promptInfoByRawId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GenericPrompt;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "配置不存在，请检查\"t.通用提示.xlsx\"";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", promptId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			EUiViewName value;
			if (!GenericPromptDefine.genericPromptView.TryGetValue(promptInfoByRawId.Value.TypeId, out value))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.GenericPrompt;
				ELogAuthor author2 = ELogAuthor.HYF;
				string message2 = "genericPromptView 缺少映射";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("TypeId", promptInfoByRawId.Value.TypeId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			return new EUiViewName?(value);
		}

		// Token: 0x0603A300 RID: 238336 RVA: 0x00DD4AA2 File Offset: 0x00DD2CA2
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.CreateGenericPromptView));
			EventSystem.Instance.Add(EEventName.AfterLoadMap, new Action(this.CreateGenericPromptView));
		}

		// Token: 0x0603A301 RID: 238337 RVA: 0x00DD4AD9 File Offset: 0x00DD2CD9
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.UiManagerInit, new Action(this.CreateGenericPromptView));
			EventSystem.Instance.Remove(EEventName.AfterLoadMap, new Action(this.CreateGenericPromptView));
		}

		// Token: 0x0603A302 RID: 238338 RVA: 0x00DD4B10 File Offset: 0x00DD2D10
		private void CreateGenericPromptView()
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.GenericPromptView))
			{
				UiManager.Instance.OpenView(EUiViewName.GenericPromptView, null, null);
			}
		}

		// Token: 0x0603A303 RID: 238339 RVA: 0x00DD4B34 File Offset: 0x00DD2D34
		public static void CancelPromptByPromptKey(string promptKey)
		{
			GenericPromptModel.Instance.RemovePromptParamHubByKey(promptKey);
		}

		// Token: 0x17008B74 RID: 35700
		// (get) Token: 0x0603A304 RID: 238340 RVA: 0x00DD4B41 File Offset: 0x00DD2D41
		public static GenericPromptController Instance
		{
			get
			{
				return GenericPromptController._Instance;
			}
		}

		// Token: 0x0603A305 RID: 238341 RVA: 0x00DD4B48 File Offset: 0x00DD2D48
		public static GenericPromptController GetOrCreateInstance()
		{
			if (GenericPromptController._Instance == null)
			{
				GenericPromptController.CreateInstance();
			}
			return GenericPromptController._Instance;
		}

		// Token: 0x0603A306 RID: 238342 RVA: 0x00DD4B5C File Offset: 0x00DD2D5C
		public static bool CreateInstance()
		{
			if (GenericPromptController._Instance != null)
			{
				return true;
			}
			GenericPromptController._Instance = new GenericPromptController();
			return true;
		}

		// Token: 0x0603A307 RID: 238343 RVA: 0x00DD4B72 File Offset: 0x00DD2D72
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A308 RID: 238344 RVA: 0x00DD4B74 File Offset: 0x00DD2D74
		public static void ResetStaticDefaultValue()
		{
			GenericPromptController._Instance = null;
		}

		// Token: 0x0603A309 RID: 238345 RVA: 0x00DD4B7C File Offset: 0x00DD2D7C
		static GenericPromptController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GenericPromptController.CreateStaticDefaultValue), new Action(GenericPromptController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E5A3 RID: 124323
		[Nullable(2)]
		private static GenericPromptController _Instance;
	}
}
