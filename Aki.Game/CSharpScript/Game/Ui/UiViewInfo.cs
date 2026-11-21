using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A0 RID: 13728
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewInfo
	{
		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x06022FB0 RID: 143280 RVA: 0x009F3BF7 File Offset: 0x009F1DF7
		// (set) Token: 0x06022FB1 RID: 143281 RVA: 0x009F3BFF File Offset: 0x009F1DFF
		[Nullable(2)]
		public ViewInfoDynamicData ExtraDynamicData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06022FB2 RID: 143282 RVA: 0x009F3C08 File Offset: 0x009F1E08
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

		// Token: 0x06022FB3 RID: 143283 RVA: 0x009F3C84 File Offset: 0x009F1E84
		public ELayerType GetContainerLayerType()
		{
			return this.ContainerType;
		}

		// Token: 0x06022FB4 RID: 143284 RVA: 0x009F3C8C File Offset: 0x009F1E8C
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

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x06022FB5 RID: 143285 RVA: 0x009F3DBB File Offset: 0x009F1FBB
		public EUiViewName Name { get; }

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x06022FB6 RID: 143286 RVA: 0x009F3DC3 File Offset: 0x009F1FC3
		// (set) Token: 0x06022FB7 RID: 143287 RVA: 0x009F3DCB File Offset: 0x009F1FCB
		public ELayerType Type { get; set; }

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x06022FB8 RID: 143288 RVA: 0x009F3DD4 File Offset: 0x009F1FD4
		public TUiViewCtor Ctor { get; }

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x06022FB9 RID: 143289 RVA: 0x009F3DDC File Offset: 0x009F1FDC
		// (set) Token: 0x06022FBA RID: 143290 RVA: 0x009F3DE4 File Offset: 0x009F1FE4
		public string ConfigPath { get; set; }

		// Token: 0x170048CA RID: 18634
		// (get) Token: 0x06022FBB RID: 143291 RVA: 0x009F3DED File Offset: 0x009F1FED
		// (set) Token: 0x06022FBC RID: 143292 RVA: 0x009F3DF5 File Offset: 0x009F1FF5
		public string ConfigPcPath { get; set; }

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x06022FBD RID: 143293 RVA: 0x009F3DFE File Offset: 0x009F1FFE
		// (set) Token: 0x06022FBE RID: 143294 RVA: 0x009F3E06 File Offset: 0x009F2006
		public string Path { get; set; }

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x06022FBF RID: 143295 RVA: 0x009F3E0F File Offset: 0x009F200F
		// (set) Token: 0x06022FC0 RID: 143296 RVA: 0x009F3E17 File Offset: 0x009F2017
		public string PcPath { get; set; }

		// Token: 0x170048CD RID: 18637
		// (get) Token: 0x06022FC1 RID: 143297 RVA: 0x009F3E20 File Offset: 0x009F2020
		public string[] BeObstructView { get; }

		// Token: 0x170048CE RID: 18638
		// (get) Token: 0x06022FC2 RID: 143298 RVA: 0x009F3E28 File Offset: 0x009F2028
		public string AudioEvent { get; }

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x06022FC3 RID: 143299 RVA: 0x009F3E30 File Offset: 0x009F2030
		public string OpenAudioEvent { get; }

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x06022FC4 RID: 143300 RVA: 0x009F3E38 File Offset: 0x009F2038
		public string LoopAudioEvent { get; }

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x06022FC5 RID: 143301 RVA: 0x009F3E40 File Offset: 0x009F2040
		public string CloseAudioEvent { get; }

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x06022FC6 RID: 143302 RVA: 0x009F3E48 File Offset: 0x009F2048
		public bool KeepLoopEvent { get; }

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x06022FC7 RID: 143303 RVA: 0x009F3E50 File Offset: 0x009F2050
		public float TimeDilation { get; }

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x06022FC8 RID: 143304 RVA: 0x009F3E58 File Offset: 0x009F2058
		public EShowCursorType ShowCursorType { get; }

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x06022FC9 RID: 143305 RVA: 0x009F3E60 File Offset: 0x009F2060
		public bool CanOpenViewByShortcutKey { get; }

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x06022FCA RID: 143306 RVA: 0x009F3E68 File Offset: 0x009F2068
		public bool IsShortKeysExitView { get; }

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x06022FCB RID: 143307 RVA: 0x009F3E70 File Offset: 0x009F2070
		public ESourceType SourceType { get; }

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x06022FCC RID: 143308 RVA: 0x009F3E78 File Offset: 0x009F2078
		public bool LoadAsync { get; }

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x06022FCD RID: 143309 RVA: 0x009F3E80 File Offset: 0x009F2080
		public bool NeedGc { get; }

		// Token: 0x170048DA RID: 18650
		// (get) Token: 0x06022FCE RID: 143310 RVA: 0x009F3E88 File Offset: 0x009F2088
		public bool IsFullScreen { get; }

		// Token: 0x170048DB RID: 18651
		// (get) Token: 0x06022FCF RID: 143311 RVA: 0x009F3E90 File Offset: 0x009F2090
		public int SortIndex { get; }

		// Token: 0x170048DC RID: 18652
		// (get) Token: 0x06022FD0 RID: 143312 RVA: 0x009F3E98 File Offset: 0x009F2098
		public EUiBehaviourPopType ConfigCommonPopBg { get; }

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x06022FD1 RID: 143313 RVA: 0x009F3EA0 File Offset: 0x009F20A0
		// (set) Token: 0x06022FD2 RID: 143314 RVA: 0x009F3EA8 File Offset: 0x009F20A8
		public string CommonPopBgKey { get; set; }

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x06022FD3 RID: 143315 RVA: 0x009F3EB1 File Offset: 0x009F20B1
		public string SceneIdInternal { get; }

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x06022FD4 RID: 143316 RVA: 0x009F3EB9 File Offset: 0x009F20B9
		public bool IsPermanent { get; }

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x06022FD5 RID: 143317 RVA: 0x009F3EC1 File Offset: 0x009F20C1
		public List<string> SkipAnimActions { get; }

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x06022FD6 RID: 143318 RVA: 0x009F3EC9 File Offset: 0x009F20C9
		public int FunctionCondition { get; }

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x06022FD7 RID: 143319 RVA: 0x009F3ED1 File Offset: 0x009F20D1
		public string ScenePointTag { get; }

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x06022FD8 RID: 143320 RVA: 0x009F3ED9 File Offset: 0x009F20D9
		public EViewLockWorldRenderType LockWorldRender { get; }

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x06022FD9 RID: 143321 RVA: 0x009F3EE1 File Offset: 0x009F20E1
		public bool LockFrameRate { get; }

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x06022FDA RID: 143322 RVA: 0x009F3EE9 File Offset: 0x009F20E9
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

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x06022FDB RID: 143323 RVA: 0x009F3F14 File Offset: 0x009F2114
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

		// Token: 0x04013B98 RID: 80792
		private ELayerType ContainerType = ELayerType.Normal;

		// Token: 0x04013B99 RID: 80793
		public EUiBehaviourPopType CommonPopBg;
	}
}
