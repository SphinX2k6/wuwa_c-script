using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200466F RID: 18031
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewInfo
	{
		// Token: 0x17007609 RID: 30217
		// (get) Token: 0x0602E866 RID: 190566 RVA: 0x00AC6097 File Offset: 0x00AC4297
		// (set) Token: 0x0602E867 RID: 190567 RVA: 0x00AC609F File Offset: 0x00AC429F
		[Nullable(2)]
		public ViewInfoDynamicData ExtraDynamicData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0602E868 RID: 190568 RVA: 0x00AC60A8 File Offset: 0x00AC42A8
		public void SetContainerLayerType(ELayerType? type)
		{
			if (type == null)
			{
				UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(this.Name);
				ELayerType containerType = (ELayerType)Enum.Parse(typeof(ELayerType), uiShowConfig.Value.Type);
				this.ContainerType = containerType;
				return;
			}
			this.ContainerType = type.Value;
			if (this.Type < type.Value)
			{
				this.Type = type.Value;
			}
		}

		// Token: 0x0602E869 RID: 190569 RVA: 0x00AC6124 File Offset: 0x00AC4324
		public ELayerType GetContainerLayerType()
		{
			return this.ContainerType;
		}

		// Token: 0x0602E86A RID: 190570 RVA: 0x00AC612C File Offset: 0x00AC432C
		public UiViewInfo(EUiViewName name, ELayerType type, TUiViewCtor ctor, string path, string pcPath, string[] beObstructView, string audioEvent, string openAudioEvent, string loopAudioEvent, string closeAudioEvent, bool keepLoopEvent, float timeDilation, EShowCursorType showCursorType, bool canOpenViewByShortcutKey, bool isShortKeysExitView, ESourceType sourceType, bool loadAsync, bool needGc, bool isFullScreen, int sortIndex, EUiBehaviourPopType configCommonPopBg, string commonPopBgKey, string sceneIdInternal, bool isPermanent, List<string> skipAnimActions, int functionCondition, string scenePointTag = "", EViewLockWorldRenderType lockWorldRender = EViewLockWorldRenderType.Default, bool lockFrameRate = false)
		{
			this.Name = name;
			this.Type = type;
			this.Ctor = ctor;
			this.ConfigPath = path;
			this.ConfigPcPath = pcPath;
			this.Path = this.ConfigPath;
			this.PcPath = this.ConfigPcPath;
			this.BeObstructView = beObstructView;
			this.AudioEvent = audioEvent;
			this.OpenAudioEvent = openAudioEvent;
			this.LoopAudioEvent = loopAudioEvent;
			this.CloseAudioEvent = closeAudioEvent;
			this.KeepLoopEvent = keepLoopEvent;
			this.TimeDilation = timeDilation;
			this.ShowCursorType = showCursorType;
			this.CanOpenViewByShortcutKey = canOpenViewByShortcutKey;
			this.IsShortKeysExitView = isShortKeysExitView;
			this.SourceType = sourceType;
			this.LoadAsync = loadAsync;
			this.NeedGc = needGc;
			this.IsFullScreen = isFullScreen;
			this.SortIndex = sortIndex;
			this.ConfigCommonPopBg = configCommonPopBg;
			this.CommonPopBgKey = commonPopBgKey;
			this.SceneIdInternal = sceneIdInternal;
			this.IsPermanent = isPermanent;
			this.SkipAnimActions = skipAnimActions;
			this.FunctionCondition = functionCondition;
			this.ScenePointTag = scenePointTag;
			this.LockWorldRender = lockWorldRender;
			this.LockFrameRate = lockFrameRate;
			this.ContainerType = this.Type;
			this.CommonPopBg = this.ConfigCommonPopBg;
		}

		// Token: 0x1700760A RID: 30218
		// (get) Token: 0x0602E86B RID: 190571 RVA: 0x00AC625B File Offset: 0x00AC445B
		public EUiViewName Name { get; }

		// Token: 0x1700760B RID: 30219
		// (get) Token: 0x0602E86C RID: 190572 RVA: 0x00AC6263 File Offset: 0x00AC4463
		// (set) Token: 0x0602E86D RID: 190573 RVA: 0x00AC626B File Offset: 0x00AC446B
		public ELayerType Type { get; set; }

		// Token: 0x1700760C RID: 30220
		// (get) Token: 0x0602E86E RID: 190574 RVA: 0x00AC6274 File Offset: 0x00AC4474
		public TUiViewCtor Ctor { get; }

		// Token: 0x1700760D RID: 30221
		// (get) Token: 0x0602E86F RID: 190575 RVA: 0x00AC627C File Offset: 0x00AC447C
		// (set) Token: 0x0602E870 RID: 190576 RVA: 0x00AC6284 File Offset: 0x00AC4484
		public string ConfigPath { get; set; }

		// Token: 0x1700760E RID: 30222
		// (get) Token: 0x0602E871 RID: 190577 RVA: 0x00AC628D File Offset: 0x00AC448D
		// (set) Token: 0x0602E872 RID: 190578 RVA: 0x00AC6295 File Offset: 0x00AC4495
		public string ConfigPcPath { get; set; }

		// Token: 0x1700760F RID: 30223
		// (get) Token: 0x0602E873 RID: 190579 RVA: 0x00AC629E File Offset: 0x00AC449E
		// (set) Token: 0x0602E874 RID: 190580 RVA: 0x00AC62A6 File Offset: 0x00AC44A6
		public string Path { get; set; }

		// Token: 0x17007610 RID: 30224
		// (get) Token: 0x0602E875 RID: 190581 RVA: 0x00AC62AF File Offset: 0x00AC44AF
		// (set) Token: 0x0602E876 RID: 190582 RVA: 0x00AC62B7 File Offset: 0x00AC44B7
		public string PcPath { get; set; }

		// Token: 0x17007611 RID: 30225
		// (get) Token: 0x0602E877 RID: 190583 RVA: 0x00AC62C0 File Offset: 0x00AC44C0
		public string[] BeObstructView { get; }

		// Token: 0x17007612 RID: 30226
		// (get) Token: 0x0602E878 RID: 190584 RVA: 0x00AC62C8 File Offset: 0x00AC44C8
		public string AudioEvent { get; }

		// Token: 0x17007613 RID: 30227
		// (get) Token: 0x0602E879 RID: 190585 RVA: 0x00AC62D0 File Offset: 0x00AC44D0
		public string OpenAudioEvent { get; }

		// Token: 0x17007614 RID: 30228
		// (get) Token: 0x0602E87A RID: 190586 RVA: 0x00AC62D8 File Offset: 0x00AC44D8
		public string LoopAudioEvent { get; }

		// Token: 0x17007615 RID: 30229
		// (get) Token: 0x0602E87B RID: 190587 RVA: 0x00AC62E0 File Offset: 0x00AC44E0
		public string CloseAudioEvent { get; }

		// Token: 0x17007616 RID: 30230
		// (get) Token: 0x0602E87C RID: 190588 RVA: 0x00AC62E8 File Offset: 0x00AC44E8
		public bool KeepLoopEvent { get; }

		// Token: 0x17007617 RID: 30231
		// (get) Token: 0x0602E87D RID: 190589 RVA: 0x00AC62F0 File Offset: 0x00AC44F0
		public float TimeDilation { get; }

		// Token: 0x17007618 RID: 30232
		// (get) Token: 0x0602E87E RID: 190590 RVA: 0x00AC62F8 File Offset: 0x00AC44F8
		public EShowCursorType ShowCursorType { get; }

		// Token: 0x17007619 RID: 30233
		// (get) Token: 0x0602E87F RID: 190591 RVA: 0x00AC6300 File Offset: 0x00AC4500
		public bool CanOpenViewByShortcutKey { get; }

		// Token: 0x1700761A RID: 30234
		// (get) Token: 0x0602E880 RID: 190592 RVA: 0x00AC6308 File Offset: 0x00AC4508
		public bool IsShortKeysExitView { get; }

		// Token: 0x1700761B RID: 30235
		// (get) Token: 0x0602E881 RID: 190593 RVA: 0x00AC6310 File Offset: 0x00AC4510
		public ESourceType SourceType { get; }

		// Token: 0x1700761C RID: 30236
		// (get) Token: 0x0602E882 RID: 190594 RVA: 0x00AC6318 File Offset: 0x00AC4518
		public bool LoadAsync { get; }

		// Token: 0x1700761D RID: 30237
		// (get) Token: 0x0602E883 RID: 190595 RVA: 0x00AC6320 File Offset: 0x00AC4520
		public bool NeedGc { get; }

		// Token: 0x1700761E RID: 30238
		// (get) Token: 0x0602E884 RID: 190596 RVA: 0x00AC6328 File Offset: 0x00AC4528
		public bool IsFullScreen { get; }

		// Token: 0x1700761F RID: 30239
		// (get) Token: 0x0602E885 RID: 190597 RVA: 0x00AC6330 File Offset: 0x00AC4530
		public int SortIndex { get; }

		// Token: 0x17007620 RID: 30240
		// (get) Token: 0x0602E886 RID: 190598 RVA: 0x00AC6338 File Offset: 0x00AC4538
		public EUiBehaviourPopType ConfigCommonPopBg { get; }

		// Token: 0x17007621 RID: 30241
		// (get) Token: 0x0602E887 RID: 190599 RVA: 0x00AC6340 File Offset: 0x00AC4540
		// (set) Token: 0x0602E888 RID: 190600 RVA: 0x00AC6348 File Offset: 0x00AC4548
		public string CommonPopBgKey { get; set; }

		// Token: 0x17007622 RID: 30242
		// (get) Token: 0x0602E889 RID: 190601 RVA: 0x00AC6351 File Offset: 0x00AC4551
		public string SceneIdInternal { get; }

		// Token: 0x17007623 RID: 30243
		// (get) Token: 0x0602E88A RID: 190602 RVA: 0x00AC6359 File Offset: 0x00AC4559
		public bool IsPermanent { get; }

		// Token: 0x17007624 RID: 30244
		// (get) Token: 0x0602E88B RID: 190603 RVA: 0x00AC6361 File Offset: 0x00AC4561
		public List<string> SkipAnimActions { get; }

		// Token: 0x17007625 RID: 30245
		// (get) Token: 0x0602E88C RID: 190604 RVA: 0x00AC6369 File Offset: 0x00AC4569
		public int FunctionCondition { get; }

		// Token: 0x17007626 RID: 30246
		// (get) Token: 0x0602E88D RID: 190605 RVA: 0x00AC6371 File Offset: 0x00AC4571
		public string ScenePointTag { get; }

		// Token: 0x17007627 RID: 30247
		// (get) Token: 0x0602E88E RID: 190606 RVA: 0x00AC6379 File Offset: 0x00AC4579
		public EViewLockWorldRenderType LockWorldRender { get; }

		// Token: 0x17007628 RID: 30248
		// (get) Token: 0x0602E88F RID: 190607 RVA: 0x00AC6381 File Offset: 0x00AC4581
		public bool LockFrameRate { get; }

		// Token: 0x17007629 RID: 30249
		// (get) Token: 0x0602E890 RID: 190608 RVA: 0x00AC6389 File Offset: 0x00AC4589
		public string UiPath
		{
			get
			{
				if (!Info.Instance.IsInTouch() && !string.IsNullOrEmpty(this.PcPath))
				{
					return this.PcPath;
				}
				return this.Path;
			}
		}

		// Token: 0x1700762A RID: 30250
		// (get) Token: 0x0602E891 RID: 190609 RVA: 0x00AC63B4 File Offset: 0x00AC45B4
		public string SceneId
		{
			get
			{
				if (this.Type != ELayerType.Normal)
				{
					return string.Empty;
				}
				EUiViewName name;
				if (UiScenePathResolver.UiViewToRootViewForUiScene.TryGetValue(this.Name, out name))
				{
					UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(name);
					if (uiViewInfo != null)
					{
						return uiViewInfo.SceneId;
					}
				}
				IViewInfoDynamicSceneData viewInfoDynamicSceneData = this.ExtraDynamicData as IViewInfoDynamicSceneData;
				if (viewInfoDynamicSceneData != null)
				{
					string sceneId = viewInfoDynamicSceneData.GetSceneId();
					if (!string.IsNullOrEmpty(sceneId))
					{
						return sceneId;
					}
				}
				return this.SceneIdInternal;
			}
		}

		// Token: 0x040194F1 RID: 103665
		private ELayerType ContainerType = ELayerType.Normal;

		// Token: 0x040194F2 RID: 103666
		public EUiBehaviourPopType CommonPopBg;
	}
}
