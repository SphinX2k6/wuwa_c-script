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
	// Token: 0x02004F40 RID: 20288
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class QtaModel : ModelBase
	{
		// Token: 0x06034037 RID: 213047 RVA: 0x00C321A6 File Offset: 0x00C303A6
		protected override bool OnInit()
		{
			this.LoadBaseResources().Forget<bool>();
			return true;
		}

		// Token: 0x06034038 RID: 213048 RVA: 0x00C321B4 File Offset: 0x00C303B4
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

		// Token: 0x06034039 RID: 213049 RVA: 0x00C321EC File Offset: 0x00C303EC
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

		// Token: 0x0603403A RID: 213050 RVA: 0x00C32285 File Offset: 0x00C30485
		public void SetCurrentQta(QtaContextBase context)
		{
			this.HandleId = context.HandleId;
			if (this.Contexts == null)
			{
				this.Contexts = new Dictionary<int, QtaContextBase>();
			}
			this.Contexts[context.HandleId] = context;
		}

		// Token: 0x0603403B RID: 213051 RVA: 0x00C322B8 File Offset: 0x00C304B8
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

		// Token: 0x0603403C RID: 213052 RVA: 0x00C322FC File Offset: 0x00C304FC
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

		// Token: 0x0603403D RID: 213053 RVA: 0x00C32373 File Offset: 0x00C30573
		public int GetQtaHandleId()
		{
			return this.HandleId;
		}

		// Token: 0x0603403E RID: 213054 RVA: 0x00C3237C File Offset: 0x00C3057C
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

		// Token: 0x0603403F RID: 213055 RVA: 0x00C3240F File Offset: 0x00C3060F
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

		// Token: 0x06034040 RID: 213056 RVA: 0x00C32424 File Offset: 0x00C30624
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

		// Token: 0x06034041 RID: 213057 RVA: 0x00C32490 File Offset: 0x00C30690
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

		// Token: 0x06034042 RID: 213058 RVA: 0x00C3255C File Offset: 0x00C3075C
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

		// Token: 0x06034043 RID: 213059 RVA: 0x00C32604 File Offset: 0x00C30804
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

		// Token: 0x06034044 RID: 213060 RVA: 0x00C32645 File Offset: 0x00C30845
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IQtaPromptResource> GetQtaPromptObj(int qtaId)
		{
			return this.QtaPromptResources.GetValueOrDefault(qtaId);
		}

		// Token: 0x06034045 RID: 213061 RVA: 0x00C32654 File Offset: 0x00C30854
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

		// Token: 0x06034046 RID: 213062 RVA: 0x00C326C8 File Offset: 0x00C308C8
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

		// Token: 0x06034047 RID: 213063 RVA: 0x00C326F8 File Offset: 0x00C308F8
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

		// Token: 0x06034048 RID: 213064 RVA: 0x00C32A88 File Offset: 0x00C30C88
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

		// Token: 0x06034049 RID: 213065 RVA: 0x00C32ADC File Offset: 0x00C30CDC
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

		// Token: 0x0603404A RID: 213066 RVA: 0x00C32B40 File Offset: 0x00C30D40
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

		// Token: 0x17007F47 RID: 32583
		// (get) Token: 0x0603404B RID: 213067 RVA: 0x00C32BB1 File Offset: 0x00C30DB1
		public static QtaModel Instance
		{
			get
			{
				return QtaModel._Instance;
			}
		}

		// Token: 0x0603404C RID: 213068 RVA: 0x00C32BB8 File Offset: 0x00C30DB8
		public static QtaModel GetOrCreateInstance()
		{
			if (QtaModel._Instance == null)
			{
				QtaModel.CreateInstance();
			}
			return QtaModel._Instance;
		}

		// Token: 0x0603404D RID: 213069 RVA: 0x00C32BCC File Offset: 0x00C30DCC
		public static bool CreateInstance()
		{
			if (QtaModel._Instance != null)
			{
				return true;
			}
			QtaModel._Instance = new QtaModel();
			return true;
		}

		// Token: 0x0603404E RID: 213070 RVA: 0x00C32BE2 File Offset: 0x00C30DE2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603404F RID: 213071 RVA: 0x00C32BE4 File Offset: 0x00C30DE4
		public static void ResetStaticDefaultValue()
		{
			QtaModel._Instance = null;
		}

		// Token: 0x06034050 RID: 213072 RVA: 0x00C32BEC File Offset: 0x00C30DEC
		static QtaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QtaModel.CreateStaticDefaultValue), new Action(QtaModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401BA09 RID: 113161
		private const string DT_QTA_PATH = "/Game/Aki/Data/QuickTimeAction/DT_Qta.DT_Qta";

		// Token: 0x0401BA0A RID: 113162
		private const string UI_EDITOR_PATH = "UIEditor";

		// Token: 0x0401BA0B RID: 113163
		private const string UI_RESOURCES_PATH = "UIResources";

		// Token: 0x0401BA0C RID: 113164
		private int HandleId = -1;

		// Token: 0x0401BA0D RID: 113165
		private int HandleIdCounter;

		// Token: 0x0401BA0E RID: 113166
		[Nullable(2)]
		private UDataTable QtaDt;

		// Token: 0x0401BA0F RID: 113167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, QtaContextBase> Contexts;

		// Token: 0x0401BA10 RID: 113168
		private readonly Dictionary<int, IQtaUiResource> QtaUiResources = new Dictionary<int, IQtaUiResource>();

		// Token: 0x0401BA11 RID: 113169
		private readonly Dictionary<int, Dictionary<int, IQtaPromptResource>> QtaPromptResources = new Dictionary<int, Dictionary<int, IQtaPromptResource>>();

		// Token: 0x0401BA12 RID: 113170
		private readonly Dictionary<int, SQta> QtaConfigCache = new Dictionary<int, SQta>();

		// Token: 0x0401BA13 RID: 113171
		[Nullable(2)]
		private static QtaModel _Instance;
	}
}
