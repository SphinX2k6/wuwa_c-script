using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200177C RID: 6012
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyDefine : IStaticVariableResetter
{
	// Token: 0x0600E8FB RID: 59643 RVA: 0x00443A61 File Offset: 0x00441C61
	static MotorcycleDiyDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleDiyDefine.CreateStaticDefaultValue), new Action(MotorcycleDiyDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600E8FC RID: 59644 RVA: 0x00443A80 File Offset: 0x00441C80
	public static void CreateStaticDefaultValue()
	{
		MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART = new int[]
		{
			1,
			2,
			3
		};
		MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART = new int[]
		{
			1,
			2
		};
		MotorcycleDiyDefine.OutlookToSkinCustomizeIconMap = new Dictionary<EOutlookType, string>
		{
			{
				EOutlookType.Frame,
				"SP_MotorSkinFrameCustomlizeIcon"
			},
			{
				EOutlookType.Sticker,
				"SP_MotorSkinStickerCustomlizeIcon"
			},
			{
				EOutlookType.Decoration,
				"SP_MotorSkinDecorationCustomlizeIcon"
			}
		};
		MotorcycleDiyDefine.OutlookToSkinCustomizeNameMap = new Dictionary<EOutlookType, string>
		{
			{
				EOutlookType.Frame,
				"MotorFrame"
			},
			{
				EOutlookType.Sticker,
				"MotorSticker"
			},
			{
				EOutlookType.Decoration,
				"MotorDecorations"
			}
		};
	}

	// Token: 0x0600E8FD RID: 59645 RVA: 0x00443B12 File Offset: 0x00441D12
	public static void ResetStaticDefaultValue()
	{
		MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART = null;
		MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART = null;
		MotorcycleDiyDefine.OutlookToSkinCustomizeIconMap = null;
		MotorcycleDiyDefine.OutlookToSkinCustomizeNameMap = null;
	}

	// Token: 0x040084B1 RID: 33969
	public const string MOTORCYCLE_DIY_TAB_VIEW_CAMERA_CONFIG_ID = "摩托车自定义界面";

	// Token: 0x040084B2 RID: 33970
	public const string MOTORCYCLE_DIY_ROOT_VIEW_CAMERA_CONFIG_ID = "摩托车贴纸界面";

	// Token: 0x040084B3 RID: 33971
	public const string MOTORCYCLE_DIY_IMPORT_VIEW_CAMERA_CONFIG_ID = "摩托车预设界面";

	// Token: 0x040084B4 RID: 33972
	public const string MOTORCYCLE_DIY_SKIN_VIEW_MODEL_ROTATE_CONFIG_ID = "摩托车皮肤旋转";

	// Token: 0x040084B5 RID: 33973
	public const string MOTORCYCLE_DIY_NONE_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/Com/T_ComItemNoneIcon.T_ComItemNoneIcon";

	// Token: 0x040084B6 RID: 33974
	public static int[] MOTORCYCLE_DIY_STICKER_PART;

	// Token: 0x040084B7 RID: 33975
	public static int[] MOTORCYCLE_DIY_DECORATION_PART;

	// Token: 0x040084B8 RID: 33976
	public static Dictionary<EOutlookType, string> OutlookToSkinCustomizeIconMap;

	// Token: 0x040084B9 RID: 33977
	public static Dictionary<EOutlookType, string> OutlookToSkinCustomizeNameMap;
}
