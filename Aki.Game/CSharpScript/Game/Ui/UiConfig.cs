using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using CSharpScript.Game.InputSetting;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003590 RID: 13712
	[NullableContext(1)]
	[Nullable(0)]
	public class UiConfig : Singleton
	{
		// Token: 0x06022F79 RID: 143225 RVA: 0x009ECC68 File Offset: 0x009EAE68
		[NullableContext(2)]
		public unsafe UiViewInfo TryGetViewInfo(EUiViewName name)
		{
			UiViewInfo uiViewInfo;
			if (!this.UiViewInfoMap.TryGetValue(name, out uiViewInfo))
			{
				UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(name);
				if (uiShowConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCore;
					ELogAuthor author = ELogAuthor.TL;
					string message = "[UiConfig.TryGetViewInfo] 未拿到UiShowConfig";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
				UiTsInfo uiTsInfo = UiViewStorage.Instance.GetUiTsInfo(name);
				if (uiTsInfo == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiCore;
					ELogAuthor author2 = ELogAuthor.TL;
					string message2 = "[UiConfig.TryGetViewInfo] 未在UiViewManager中注册";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("name", name);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return null;
				}
				string resourceId = uiTsInfo.ResourceId;
				string text;
				string pcPath;
				if (this.CheckIfNotInPackageView(name))
				{
					text = (CommonConfig.Instance.GetDebugGmViewPath(name) ?? string.Empty);
					pcPath = text;
				}
				else
				{
					UiResource? uiResource = string.IsNullOrEmpty(resourceId) ? null : UiResourceConfig.Instance.GetResourceConfig(resourceId);
					if (uiResource == null)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.UiCore;
						ELogAuthor author3 = ELogAuthor.TL;
						string message3 = "[UiConfig.TryGetViewInfo] 找不到界面配置";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("resourceId", resourceId);
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return null;
					}
					text = uiResource.Value.Path;
					pcPath = uiResource.Value.PcPath;
				}
				List<string> list = new List<string>();
				if (uiShowConfig.Value.SkipAnim)
				{
					if (!uiShowConfig.Value.IsShortKeysExitView)
					{
						Log.Instance.Error(ELogModule.UiCore, ELogAuthor.YYZ, "[UiConfig.TryGetViewInfo] 配置错误,跳过动画功能前提为IsShortKeysExitView=True", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						foreach (KeyValuePair<string, EUiViewName> keyValuePair in InputDefine.openViewActionsMap)
						{
							string key = keyValuePair.Key;
							EUiViewName value = keyValuePair.Value;
							if (name == value)
							{
								InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(key);
								InputKey inputKey = (actionBinding != null) ? actionBinding.GetPcKey() : null;
								if (((inputKey != null) ? inputKey.GetKeyName() : null) == EKey.Escape)
								{
									break;
								}
								list.Add(key);
								break;
							}
						}
						list.Add("UI返回");
					}
				}
				ELayerType elayerType = (ELayerType)Enum.Parse(typeof(ELayerType), uiShowConfig.Value.Type);
				string[] array = new string[uiShowConfig.Value.ObstructUiLength];
				for (int i = 0; i < uiShowConfig.Value.ObstructUiLength; i++)
				{
					array[i] = uiShowConfig.Value.ObstructUi(i);
				}
				uiViewInfo = new UiViewInfo(name, elayerType, uiTsInfo.Ctor, text, pcPath, array, uiShowConfig.Value.AudioEvent, uiShowConfig.Value.OpenAudioEvent, uiShowConfig.Value.LoopAudioEvent, uiShowConfig.Value.CloseAudioEvent, uiShowConfig.Value.KeepLoopEvent, uiShowConfig.Value.TimeDilation, (EShowCursorType)uiShowConfig.Value.ShowCursorType, uiShowConfig.Value.CanOpenViewByShortcutKey, uiShowConfig.Value.IsShortKeysExitView, uiTsInfo.SourceType, uiShowConfig.Value.LoadAsync, uiShowConfig.Value.NeedGC, uiShowConfig.Value.IsFullScreen, (((ELayerType.Normal | ELayerType.CG) & elayerType) != (ELayerType)0) ? UiViewConfig.Instance.GetUiNormalConfig(name).Value.SortIndex : -1, (EUiBehaviourPopType)uiShowConfig.Value.CommonPopBg, uiShowConfig.Value.CommonPopBgKey, uiShowConfig.Value.SceneId, uiShowConfig.Value.IsPermanent, list, uiShowConfig.Value.FunctionCondition, uiShowConfig.Value.ScenePointTag, (EViewLockWorldRenderType)uiShowConfig.Value.LockWorldRender, uiShowConfig.Value.LockFrameRate);
				if (uiTsInfo.DynamicDataCtor != null)
				{
					uiViewInfo.ExtraDynamicData = uiTsInfo.DynamicDataCtor();
				}
				this.UiViewInfoMap[name] = uiViewInfo;
			}
			return uiViewInfo;
		}

		// Token: 0x06022F7A RID: 143226 RVA: 0x009ED108 File Offset: 0x009EB308
		private bool CheckIfNotInPackageView(EUiViewName name)
		{
			return name == EUiViewName.GmView || name == EUiViewName.LoginDebugView;
		}

		// Token: 0x06022F7B RID: 143227 RVA: 0x009ED128 File Offset: 0x009EB328
		[NullableContext(2)]
		public unsafe void RewritePath([Nullable(1)] UiViewInfo viewInfo, IUiViewResource resInterface, object param = null)
		{
			if (resInterface == null || new <>f__AnonymousDelegate10<object, string>(resInterface.GetExtraResourceId) == null)
			{
				viewInfo.Path = viewInfo.ConfigPath;
				viewInfo.PcPath = viewInfo.ConfigPcPath;
				return;
			}
			string extraResourceId = resInterface.GetExtraResourceId(param);
			if (string.IsNullOrEmpty(extraResourceId))
			{
				viewInfo.Path = viewInfo.ConfigPath;
				viewInfo.PcPath = viewInfo.ConfigPcPath;
				return;
			}
			UiResource? resourceConfig = UiResourceConfig.Instance.GetResourceConfig(extraResourceId);
			if (resourceConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[UiConfig.RewritePath] 找不到界面配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", viewInfo.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("resourceId", extraResourceId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				viewInfo.Path = viewInfo.ConfigPath;
				viewInfo.PcPath = viewInfo.ConfigPcPath;
				return;
			}
			viewInfo.Path = resourceConfig.Value.Path;
			viewInfo.PcPath = resourceConfig.Value.PcPath;
		}

		// Token: 0x06022F7C RID: 143228 RVA: 0x009ED240 File Offset: 0x009EB440
		[NullableContext(2)]
		public void RewritePopFrameType([Nullable(1)] UiViewInfo viewInfo, IExtraUiPopFrameType popTypeInterface, object param = null)
		{
			EUiBehaviourPopType? euiBehaviourPopType = (popTypeInterface != null) ? popTypeInterface.GetExtraPopFrameType(param) : null;
			if (euiBehaviourPopType == null)
			{
				viewInfo.CommonPopBg = viewInfo.ConfigCommonPopBg;
				return;
			}
			viewInfo.CommonPopBg = euiBehaviourPopType.Value;
		}

		// Token: 0x06022F7D RID: 143229 RVA: 0x009ED288 File Offset: 0x009EB488
		public string GetMemoryTag(EUiViewName name)
		{
			UiShow value = UiViewConfig.Instance.GetUiShowConfig(name).Value;
			if (!string.IsNullOrEmpty(value.MemoryModuleTag))
			{
				this.StringBuilder.Clear();
				this.StringBuilder.Append(value.MemoryModuleTag);
				this.StringBuilder.Append('.');
				this.StringBuilder.Append(name);
				return this.StringBuilder.ToString();
			}
			return name;
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x06022F7E RID: 143230 RVA: 0x009ED308 File Offset: 0x009EB508
		public static UiConfig Instance
		{
			get
			{
				if (UiConfig._instance == null)
				{
					UiConfig._instance = new UiConfig();
					UiConfig._instance.OnInit();
				}
				return UiConfig._instance;
			}
		}

		// Token: 0x06022F7F RID: 143231 RVA: 0x009ED32B File Offset: 0x009EB52B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022F80 RID: 143232 RVA: 0x009ED32D File Offset: 0x009EB52D
		public static void ResetStaticDefaultValue()
		{
			UiConfig instance = UiConfig._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiConfig._instance = null;
		}

		// Token: 0x06022F81 RID: 143233 RVA: 0x009ED346 File Offset: 0x009EB546
		static UiConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiConfig.CreateStaticDefaultValue), new Action(UiConfig.ResetStaticDefaultValue));
		}

		// Token: 0x06022F82 RID: 143234 RVA: 0x009ED368 File Offset: 0x009EB568
		public UiConfig()
		{
			HashSet<EUiViewName> hashSet = new HashSet<EUiViewName>();
			foreach (EUiViewName item in LoadingDefine.loadingViewList)
			{
				hashSet.Add(item);
			}
			this.CanOpenWhileClearSceneViewNameSet = hashSet;
			base..ctor();
		}

		// Token: 0x0401349F RID: 79007
		private StringBuilder StringBuilder = new StringBuilder();

		// Token: 0x040134A0 RID: 79008
		private readonly Dictionary<EUiViewName, UiViewInfo> UiViewInfoMap = new Dictionary<EUiViewName, UiViewInfo>();

		// Token: 0x040134A1 RID: 79009
		public readonly HashSet<EUiViewName> CanOpenWhileClearSceneViewNameSet;

		// Token: 0x040134A2 RID: 79010
		[Nullable(2)]
		private static UiConfig _instance;
	}
}
