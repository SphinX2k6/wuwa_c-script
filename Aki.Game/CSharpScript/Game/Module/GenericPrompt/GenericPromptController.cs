using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x0200496B RID: 18795
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class GenericPromptController : UiControllerBase
	{
		// Token: 0x0602F221 RID: 193057 RVA: 0x00D23C48 File Offset: 0x00D21E48
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

		// Token: 0x0602F222 RID: 193058 RVA: 0x00D23CD0 File Offset: 0x00D21ED0
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

		// Token: 0x0602F223 RID: 193059 RVA: 0x00D23D58 File Offset: 0x00D21F58
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

		// Token: 0x0602F224 RID: 193060 RVA: 0x00D23D84 File Offset: 0x00D21F84
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

		// Token: 0x0602F225 RID: 193061 RVA: 0x00D23E74 File Offset: 0x00D22074
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

		// Token: 0x0602F226 RID: 193062 RVA: 0x00D23F32 File Offset: 0x00D22132
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.CreateGenericPromptView));
			EventSystem.Instance.Add(EEventName.AfterLoadMap, new Action(this.CreateGenericPromptView));
		}

		// Token: 0x0602F227 RID: 193063 RVA: 0x00D23F69 File Offset: 0x00D22169
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.UiManagerInit, new Action(this.CreateGenericPromptView));
			EventSystem.Instance.Remove(EEventName.AfterLoadMap, new Action(this.CreateGenericPromptView));
		}

		// Token: 0x0602F228 RID: 193064 RVA: 0x00D23FA0 File Offset: 0x00D221A0
		private void CreateGenericPromptView()
		{
			if (!UiManager.Instance.IsViewOpen(EUiViewName.GenericPromptView))
			{
				UiManager.Instance.OpenView(EUiViewName.GenericPromptView, null, null);
			}
		}

		// Token: 0x0602F229 RID: 193065 RVA: 0x00D23FC4 File Offset: 0x00D221C4
		public static void CancelPromptByPromptKey(string promptKey)
		{
			GenericPromptModel.Instance.RemovePromptParamHubByKey(promptKey);
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x0602F22A RID: 193066 RVA: 0x00D23FD1 File Offset: 0x00D221D1
		public static GenericPromptController Instance
		{
			get
			{
				return GenericPromptController._Instance;
			}
		}

		// Token: 0x0602F22B RID: 193067 RVA: 0x00D23FD8 File Offset: 0x00D221D8
		public static GenericPromptController GetOrCreateInstance()
		{
			if (GenericPromptController._Instance == null)
			{
				GenericPromptController.CreateInstance();
			}
			return GenericPromptController._Instance;
		}

		// Token: 0x0602F22C RID: 193068 RVA: 0x00D23FEC File Offset: 0x00D221EC
		public static bool CreateInstance()
		{
			if (GenericPromptController._Instance != null)
			{
				return true;
			}
			GenericPromptController._Instance = new GenericPromptController();
			return true;
		}

		// Token: 0x0602F22D RID: 193069 RVA: 0x00D24002 File Offset: 0x00D22202
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F22E RID: 193070 RVA: 0x00D24004 File Offset: 0x00D22204
		public static void ResetStaticDefaultValue()
		{
			GenericPromptController._Instance = null;
		}

		// Token: 0x0602F22F RID: 193071 RVA: 0x00D2400C File Offset: 0x00D2220C
		static GenericPromptController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GenericPromptController.CreateStaticDefaultValue), new Action(GenericPromptController.ResetStaticDefaultValue));
		}

		// Token: 0x04019041 RID: 102465
		[Nullable(2)]
		private static GenericPromptController _Instance;
	}
}
