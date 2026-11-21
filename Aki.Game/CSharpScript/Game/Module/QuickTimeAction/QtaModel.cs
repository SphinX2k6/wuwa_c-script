using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02003F09 RID: 16137
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class QtaModel : ModelBase
	{
		// Token: 0x06028EA5 RID: 167589 RVA: 0x00B7B946 File Offset: 0x00B79B46
		protected override bool OnInit()
		{
			this.LoadBaseResources().Forget<bool>();
			return true;
		}

		// Token: 0x06028EA6 RID: 167590 RVA: 0x00B7B954 File Offset: 0x00B79B54
		protected override bool OnLeaveLevel()
		{
			this.HandleIdCounter = 0;
			this.ClearPreloadCache(null);
			Dictionary<int, QtaContextBase> contexts = this.Contexts;
			if (contexts != null)
			{
				contexts.Clear();
			}
			return true;
		}

		// Token: 0x06028EA7 RID: 167591 RVA: 0x00B7B98C File Offset: 0x00B79B8C
		[NullableContext(2)]
		public QtaContextBase CreateQtaContext(int qtaId, TQtaCallback onResult = null, EQtaSource source = EQtaSource.Battle, IQtaExtraParams extraParams = null)
		{
			SQta qtaConfig = this.GetQtaConfig(qtaId);
			if (qtaConfig == null)
			{
				return null;
			}
			if (qtaConfig.BaseConfig.QtaType == 0)
			{
				QtaContextBase qtaContextBase = new QtaCustomizationContext();
				qtaContextBase.QtaId = qtaId;
				qtaContextBase.Source = new EQtaSource?(source);
				QtaContextBase qtaContextBase2 = qtaContextBase;
				int num = this.HandleIdCounter + 1;
				this.HandleIdCounter = num;
				qtaContextBase2.HandleId = num;
				qtaContextBase.ResultCallback = onResult;
				qtaContextBase.ExtraParams = extraParams;
				qtaContextBase.SetConfig(qtaConfig);
				if (extraParams != null && extraParams.IsPendingExternalCompletion.GetValueOrDefault())
				{
					qtaContextBase.EnableExternalConditionMet(EQtaExternalReason.Default);
				}
				return qtaContextBase;
			}
			return null;
		}

		// Token: 0x06028EA8 RID: 167592 RVA: 0x00B7BA25 File Offset: 0x00B79C25
		public void SetCurrentQta(QtaContextBase context)
		{
			this.HandleId = context.HandleId;
			if (this.Contexts == null)
			{
				this.Contexts = new Dictionary<int, QtaContextBase>();
			}
			this.Contexts[context.HandleId] = context;
		}

		// Token: 0x06028EA9 RID: 167593 RVA: 0x00B7BA58 File Offset: 0x00B79C58
		[NullableContext(0)]
		private UniTask<bool> LoadBaseResources()
		{
			QtaModel.<LoadBaseResources>d__14 <LoadBaseResources>d__;
			<LoadBaseResources>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadBaseResources>d__.<>4__this = this;
			<LoadBaseResources>d__.<>1__state = -1;
			<LoadBaseResources>d__.<>t__builder.Start<QtaModel.<LoadBaseResources>d__14>(ref <LoadBaseResources>d__);
			return <LoadBaseResources>d__.<>t__builder.Task;
		}

		// Token: 0x06028EAA RID: 167594 RVA: 0x00B7BA9C File Offset: 0x00B79C9C
		[NullableContext(2)]
		public SQta GetQtaConfig(int qtaId)
		{
			SQta result;
			if (this.QtaConfigCache.TryGetValue(qtaId, out result))
			{
				return result;
			}
			SQta dataTableRow = DataTableUtil.GetDataTableRow<SQta>(this.QtaDt, qtaId.ToString());
			if (dataTableRow != null)
			{
				this.QtaConfigCache[qtaId] = dataTableRow;
				return dataTableRow;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HWR;
			string message = "找不到Qta配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QtaId", qtaId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06028EAB RID: 167595 RVA: 0x00B7BB13 File Offset: 0x00B79D13
		public int GetQtaHandleId()
		{
			return this.HandleId;
		}

		// Token: 0x06028EAC RID: 167596 RVA: 0x00B7BB1C File Offset: 0x00B79D1C
		public void ClearQtaHandleId(int? qtaHandleId = null)
		{
			int key = qtaHandleId ?? this.HandleId;
			Dictionary<int, QtaContextBase> contexts = this.Contexts;
			int? num;
			if (contexts == null)
			{
				num = null;
			}
			else
			{
				QtaContextBase valueOrDefault = contexts.GetValueOrDefault(key);
				num = ((valueOrDefault != null) ? new int?(valueOrDefault.QtaId) : null);
			}
			int? num2 = num;
			if (num2.GetValueOrDefault() != 0)
			{
				this.QtaConfigCache.Remove(num2.Value);
				this.QtaPromptResources.Remove(num2.Value);
			}
			this.HandleId = -1;
		}

		// Token: 0x06028EAD RID: 167597 RVA: 0x00B7BBAF File Offset: 0x00B79DAF
		[NullableContext(2)]
		public QtaContextBase GetQtaContext(int qtaHandleId)
		{
			Dictionary<int, QtaContextBase> contexts = this.Contexts;
			if (contexts == null)
			{
				return null;
			}
			return contexts.GetValueOrDefault(qtaHandleId);
		}

		// Token: 0x06028EAE RID: 167598 RVA: 0x00B7BBC4 File Offset: 0x00B79DC4
		public void GetQtaDa(int qtaId, List<string> daPaths)
		{
			SQta qtaConfig = this.GetQtaConfig(qtaId);
			if (qtaConfig == null)
			{
				return;
			}
			if (qtaConfig.BaseConfig.QtaType == EQtaType.定制型 && qtaConfig.BaseConfig.CustomizationConfig.DaConfig != null)
			{
				daPaths.Add(qtaConfig.BaseConfig.CustomizationConfig.DaConfig.ToAssetPathName());
			}
		}

		// Token: 0x06028EAF RID: 167599 RVA: 0x00B7BC30 File Offset: 0x00B79E30
		[NullableContext(2)]
		public unsafe string GetQtaItemName(int qtaId)
		{
			SQta qtaConfig = this.GetQtaConfig(qtaId);
			if (qtaConfig == null)
			{
				return null;
			}
			if (qtaConfig.BaseConfig.QtaType == EQtaType.定制型)
			{
				SQtaCustomization customizationConfig = qtaConfig.BaseConfig.CustomizationConfig;
				if (customizationConfig.ViewType == EQtaCustomizationViewType.限次长按洛瑟菈技能交互指示器界面)
				{
					if (customizationConfig.ViewName.Length > 4)
					{
						QtaContextBase qtaContext = null;
						string message = "使用配置指定的ui";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("", customizationConfig.ViewName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("qtaId", qtaId);
						QtaLog.Info(qtaContext, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return customizationConfig.ViewName;
					}
					return "UiItem_CircularLimitedLongPress";
				}
			}
			return null;
		}

		// Token: 0x06028EB0 RID: 167600 RVA: 0x00B7BCFC File Offset: 0x00B79EFC
		public EUiViewName? GetQtaViewName(int qtaId)
		{
			SQta qtaConfig = this.GetQtaConfig(qtaId);
			if (qtaConfig == null)
			{
				return null;
			}
			if (qtaConfig.BaseConfig.QtaType == EQtaType.定制型)
			{
				SQtaCustomization customizationConfig = qtaConfig.BaseConfig.CustomizationConfig;
				if (customizationConfig.ViewType == EQtaCustomizationViewType.拍照并收集物品)
				{
					return new EUiViewName?(EUiViewName.CaptureCollectView);
				}
				if (customizationConfig.ViewType == EQtaCustomizationViewType.打开指定界面 && customizationConfig.ViewName.Length > 4)
				{
					return new EUiViewName?((EUiViewName)customizationConfig.ViewName);
				}
			}
			return null;
		}

		// Token: 0x06028EB1 RID: 167601 RVA: 0x00B7BDA4 File Offset: 0x00B79FA4
		[NullableContext(2)]
		public IQtaUiResource GetQtaUiResource(int qtaId, bool init = false)
		{
			if (!init)
			{
				return this.QtaUiResources.GetValueOrDefault(qtaId);
			}
			IQtaUiResource qtaUiResource = this.QtaUiResources.GetValueOrDefault(qtaId);
			if (qtaUiResource == null)
			{
				qtaUiResource = new IQtaUiResource();
				this.QtaUiResources[qtaId] = qtaUiResource;
			}
			return qtaUiResource;
		}

		// Token: 0x06028EB2 RID: 167602 RVA: 0x00B7BDE5 File Offset: 0x00B79FE5
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IQtaPromptResource> GetQtaPromptObj(int qtaId)
		{
			return this.QtaPromptResources.GetValueOrDefault(qtaId);
		}

		// Token: 0x06028EB3 RID: 167603 RVA: 0x00B7BDF4 File Offset: 0x00B79FF4
		[NullableContext(2)]
		public IQtaPromptResource GetQtaPromptResource(int qtaId, EQtaPromptType px, bool init = false)
		{
			if (init)
			{
				Dictionary<int, IQtaPromptResource> dictionary = this.QtaPromptResources.GetValueOrDefault(qtaId);
				if (dictionary == null)
				{
					dictionary = new Dictionary<int, IQtaPromptResource>();
					this.QtaPromptResources[qtaId] = dictionary;
				}
				IQtaPromptResource qtaPromptResource = dictionary.GetValueOrDefault((int)px);
				if (qtaPromptResource == null)
				{
					qtaPromptResource = new IQtaPromptResource();
					dictionary[(int)px] = qtaPromptResource;
				}
				qtaPromptResource.CueIds = new List<long>();
				return qtaPromptResource;
			}
			Dictionary<int, IQtaPromptResource> valueOrDefault = this.QtaPromptResources.GetValueOrDefault(qtaId);
			if (valueOrDefault == null)
			{
				return null;
			}
			return valueOrDefault.GetValueOrDefault((int)px);
		}

		// Token: 0x06028EB4 RID: 167604 RVA: 0x00B7BE68 File Offset: 0x00B7A068
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public List<UniTask<bool>> LoadQtaResource(int qtaId)
		{
			if (this.QtaPromptResources.ContainsKey(qtaId))
			{
				return new List<UniTask<bool>>();
			}
			List<UniTask<bool>> list = new List<UniTask<bool>>();
			this.TryLoadQtaResource(list, qtaId);
			return list;
		}

		// Token: 0x06028EB5 RID: 167605 RVA: 0x00B7BE98 File Offset: 0x00B7A098
		private void TryLoadQtaResource([Nullable(new byte[]
		{
			1,
			0
		})] List<UniTask<bool>> promises, int qtaId)
		{
			QtaModel.<>c__DisplayClass26_0 CS$<>8__locals1 = new QtaModel.<>c__DisplayClass26_0();
			CS$<>8__locals1.promises = promises;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.qtaId = qtaId;
			SQta qtaConfig = this.GetQtaConfig(CS$<>8__locals1.qtaId);
			if (qtaConfig == null)
			{
				return;
			}
			for (int i = 0; i < qtaConfig.BaseConfig.InputConfig.Num(); i++)
			{
				string text = qtaConfig.BaseConfig.InputConfig.Get(i).Icon.ToAssetPathName();
				if (!string.IsNullOrEmpty(text) && text != "None")
				{
					if (text.Contains("UIEditor"))
					{
						text = text.Replace("UIEditor", "UIResources");
					}
					CS$<>8__locals1.promises.Add(this.LoadUiAssetToCache(CS$<>8__locals1.qtaId, text));
				}
			}
			for (int j = 0; j < qtaConfig.Prompt.Num(); j++)
			{
				SQtaPrompt sqtaPrompt = qtaConfig.Prompt.Get(j);
				if (sqtaPrompt.PromptContent != null)
				{
					QtaModel.<>c__DisplayClass26_1 CS$<>8__locals2 = new QtaModel.<>c__DisplayClass26_1();
					CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
					CS$<>8__locals2.px = sqtaPrompt.PromptType;
					IQtaPromptResource qtaPromptResource = this.GetQtaPromptResource(CS$<>8__locals2.CS$<>8__locals1.qtaId, CS$<>8__locals2.px, true);
					if (qtaPromptResource != null)
					{
						qtaPromptResource.Audio = sqtaPrompt.PromptContent.Audio.ToAssetPathName();
						for (int k = 0; k < sqtaPrompt.PromptContent.Cue.Num(); k++)
						{
							long num = sqtaPrompt.PromptContent.Cue.Get(k);
							if (num > 0L)
							{
								qtaPromptResource.CueIds.Add(num);
							}
						}
					}
					string text = sqtaPrompt.PromptContent.ScreenEffectType1.ToAssetPathName();
					if (!string.IsNullOrEmpty(text) && text != "None")
					{
						CS$<>8__locals2.CS$<>8__locals1.promises.Add(this.LoadPromptAssetToCache(CS$<>8__locals2.CS$<>8__locals1.qtaId, (int)CS$<>8__locals2.px, text, EffectScreenPlayData_C.StaticClass().ToUClass()));
					}
					text = sqtaPrompt.PromptContent.ScreenEffectType2.ToAssetPathName();
					if (!string.IsNullOrEmpty(text) && text != "None")
					{
						CS$<>8__locals2.screenEffectPath = text;
						ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.EffectModelPostProcess_C.ToEnumString(), new Action(CS$<>8__locals2.<TryLoadQtaResource>g__LoadEffect|0), "js_undefined");
					}
					text = sqtaPrompt.PromptContent.CameraShake.ToAssetPathName();
					if (!string.IsNullOrEmpty(text) && text != "None")
					{
						CS$<>8__locals2.CS$<>8__locals1.promises.Add(this.LoadPromptAssetToCache(CS$<>8__locals2.CS$<>8__locals1.qtaId, (int)CS$<>8__locals2.px, text, UClass.StaticClass().ToUClass()));
					}
					text = sqtaPrompt.PromptContent.GamepadShake.ToAssetPathName();
					if (!string.IsNullOrEmpty(text) && text != "None")
					{
						CS$<>8__locals2.CS$<>8__locals1.promises.Add(this.LoadPromptAssetToCache(CS$<>8__locals2.CS$<>8__locals1.qtaId, (int)CS$<>8__locals2.px, text, UKuroForceFeedbackEffect.StaticClass().ToUClass()));
					}
				}
			}
			if (qtaConfig.BaseConfig.QtaType == EQtaType.定制型)
			{
				SQtaCustomization customizationConfig = qtaConfig.BaseConfig.CustomizationConfig;
				TSoftObjectPtr<BP_QtaCustomizationBase_C> tsoftObjectPtr = (customizationConfig != null) ? customizationConfig.DaConfig : null;
				if (tsoftObjectPtr != null)
				{
					string text2 = tsoftObjectPtr.ToAssetPathName();
					if (!string.IsNullOrEmpty(text2) && text2 != "None")
					{
						CS$<>8__locals1.promises.Add(this.LoadUiAssetToCache(CS$<>8__locals1.qtaId, text2));
					}
				}
			}
		}

		// Token: 0x06028EB6 RID: 167606 RVA: 0x00B7C228 File Offset: 0x00B7A428
		[NullableContext(0)]
		private UniTask<bool> LoadUiAssetToCache(int qtaId, [Nullable(1)] string path)
		{
			QtaModel.<LoadUiAssetToCache>d__27 <LoadUiAssetToCache>d__;
			<LoadUiAssetToCache>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadUiAssetToCache>d__.<>4__this = this;
			<LoadUiAssetToCache>d__.qtaId = qtaId;
			<LoadUiAssetToCache>d__.path = path;
			<LoadUiAssetToCache>d__.<>1__state = -1;
			<LoadUiAssetToCache>d__.<>t__builder.Start<QtaModel.<LoadUiAssetToCache>d__27>(ref <LoadUiAssetToCache>d__);
			return <LoadUiAssetToCache>d__.<>t__builder.Task;
		}

		// Token: 0x06028EB7 RID: 167607 RVA: 0x00B7C27C File Offset: 0x00B7A47C
		[return: Nullable(0)]
		private UniTask<bool> LoadPromptAssetToCache(int qtaId, int px, string path, UClass type)
		{
			QtaModel.<LoadPromptAssetToCache>d__28 <LoadPromptAssetToCache>d__;
			<LoadPromptAssetToCache>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadPromptAssetToCache>d__.<>4__this = this;
			<LoadPromptAssetToCache>d__.qtaId = qtaId;
			<LoadPromptAssetToCache>d__.px = px;
			<LoadPromptAssetToCache>d__.path = path;
			<LoadPromptAssetToCache>d__.type = type;
			<LoadPromptAssetToCache>d__.<>1__state = -1;
			<LoadPromptAssetToCache>d__.<>t__builder.Start<QtaModel.<LoadPromptAssetToCache>d__28>(ref <LoadPromptAssetToCache>d__);
			return <LoadPromptAssetToCache>d__.<>t__builder.Task;
		}

		// Token: 0x06028EB8 RID: 167608 RVA: 0x00B7C2E0 File Offset: 0x00B7A4E0
		public void ClearPreloadCache(int? qtaId = null)
		{
			if (qtaId != null)
			{
				this.QtaConfigCache.Remove(qtaId.Value);
				this.QtaUiResources.Remove(qtaId.Value);
				this.QtaPromptResources.Remove(qtaId.Value);
				return;
			}
			this.QtaConfigCache.Clear();
			this.QtaUiResources.Clear();
			this.QtaPromptResources.Clear();
		}

		// Token: 0x170052F7 RID: 21239
		// (get) Token: 0x06028EB9 RID: 167609 RVA: 0x00B7C351 File Offset: 0x00B7A551
		public static QtaModel Instance
		{
			get
			{
				return QtaModel._Instance;
			}
		}

		// Token: 0x06028EBA RID: 167610 RVA: 0x00B7C358 File Offset: 0x00B7A558
		public static QtaModel GetOrCreateInstance()
		{
			if (QtaModel._Instance == null)
			{
				QtaModel.CreateInstance();
			}
			return QtaModel._Instance;
		}

		// Token: 0x06028EBB RID: 167611 RVA: 0x00B7C36C File Offset: 0x00B7A56C
		public static bool CreateInstance()
		{
			if (QtaModel._Instance != null)
			{
				return true;
			}
			QtaModel._Instance = new QtaModel();
			return true;
		}

		// Token: 0x06028EBC RID: 167612 RVA: 0x00B7C382 File Offset: 0x00B7A582
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028EBD RID: 167613 RVA: 0x00B7C384 File Offset: 0x00B7A584
		public static void ResetStaticDefaultValue()
		{
			QtaModel._Instance = null;
		}

		// Token: 0x06028EBE RID: 167614 RVA: 0x00B7C38C File Offset: 0x00B7A58C
		static QtaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QtaModel.CreateStaticDefaultValue), new Action(QtaModel.ResetStaticDefaultValue));
		}

		// Token: 0x040163DE RID: 91102
		private const string DT_QTA_PATH = "/Game/Aki/Data/QuickTimeAction/DT_Qta.DT_Qta";

		// Token: 0x040163DF RID: 91103
		private const string UI_EDITOR_PATH = "UIEditor";

		// Token: 0x040163E0 RID: 91104
		private const string UI_RESOURCES_PATH = "UIResources";

		// Token: 0x040163E1 RID: 91105
		private int HandleId = -1;

		// Token: 0x040163E2 RID: 91106
		private int HandleIdCounter;

		// Token: 0x040163E3 RID: 91107
		[Nullable(2)]
		private UDataTable QtaDt;

		// Token: 0x040163E4 RID: 91108
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, QtaContextBase> Contexts;

		// Token: 0x040163E5 RID: 91109
		private readonly Dictionary<int, IQtaUiResource> QtaUiResources = new Dictionary<int, IQtaUiResource>();

		// Token: 0x040163E6 RID: 91110
		private readonly Dictionary<int, Dictionary<int, IQtaPromptResource>> QtaPromptResources = new Dictionary<int, Dictionary<int, IQtaPromptResource>>();

		// Token: 0x040163E7 RID: 91111
		private readonly Dictionary<int, SQta> QtaConfigCache = new Dictionary<int, SQta>();

		// Token: 0x040163E8 RID: 91112
		[Nullable(2)]
		private static QtaModel _Instance;
	}
}
