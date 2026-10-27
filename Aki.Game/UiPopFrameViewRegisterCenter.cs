using System;
using CSharpScript.Game.Ui;

// Token: 0x02000EF7 RID: 3831
public static class UiPopFrameViewRegisterCenter
{
	// Token: 0x06006031 RID: 24625 RVA: 0x00121404 File Offset: 0x0011F604
	public static void Init()
	{
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(1, new UiPopFrameViewInfo("UiView_PopupB", () => new PopupTypeBigItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(4, new UiPopFrameViewInfo("UiView_PopupL", () => new PopupTypeLargeItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(3, new UiPopFrameViewInfo("UiView_PopupM", () => new PopupTypeMiddleItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(2, new UiPopFrameViewInfo("UiView_PopupS", () => new PopupTypeSmallItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(5, new UiPopFrameViewInfo("UiView_PopupL1", () => new NpcSystemViewItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(6, new UiPopFrameViewInfo("UiView_PopupL2", () => new InteractSystemViewItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(7, new UiPopFrameViewInfo("UiView_PopupFullScreen", () => new FullScreenViewItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(8, new UiPopFrameViewInfo("UiView_SoundRemnantArenaPopupB", () => new PopupTypeBigItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(9, new UiPopFrameViewInfo("UiView_SoundRemnantArenaPopupM", () => new PopupTypeMiddleItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(10, new UiPopFrameViewInfo("UiView_SoundRemnantArenaPopupS", () => new PopupTypeSmallItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(11, new UiPopFrameViewInfo("UiView_PasturePopupHelp", () => new PopupTypeMiddleItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(12, new UiPopFrameViewInfo("UiView_PopupR", () => new PopupTypeRightItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(13, new UiPopFrameViewInfo("UiView_CatapultStoryPopupB", () => new PopupTypeBigItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(14, new UiPopFrameViewInfo("UiView_CatapultStoryPopupM", () => new PopupTypeMiddleItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(15, new UiPopFrameViewInfo("UiView_CatapultStoryPopupS", () => new PopupTypeSmallItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(16, new UiPopFrameViewInfo("UiView_PopupB", () => new PopupTypeBigItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(17, new UiPopFrameViewInfo("UiView_PopupS", () => new PopupTypeSmallItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(18, new UiPopFrameViewInfo("UiView_DangoBrawlPopupB", () => new PopupTypeDangoBrawlItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(19, new UiPopFrameViewInfo("UiView_DangoBrawlPopupM", () => new PopupTypeDangoBrawlItem()));
		UiPopFrameViewStorage.Instance.RegisterUiBehaviourPop(20, new UiPopFrameViewInfo("UiView_DangoBrawlPopupS", () => new PopupTypeDangoBrawlItem()));
	}
}
