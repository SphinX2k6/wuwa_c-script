using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002298 RID: 8856
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyDefine : IStaticVariableResetter
{
	// Token: 0x06011465 RID: 70757 RVA: 0x00436E55 File Offset: 0x00435055
	static MotorcycleDiyDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleDiyDefine.CreateStaticDefaultValue), new Action(MotorcycleDiyDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06011466 RID: 70758 RVA: 0x00436E74 File Offset: 0x00435074
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

	// Token: 0x06011467 RID: 70759 RVA: 0x00436F06 File Offset: 0x00435106
	public static void ResetStaticDefaultValue()
	{
		MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART = null;
		MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART = null;
		MotorcycleDiyDefine.OutlookToSkinCustomizeIconMap = null;
		MotorcycleDiyDefine.OutlookToSkinCustomizeNameMap = null;
	}

	// Token: 0x04008373 RID: 33651
	public const string MOTORCYCLE_DIY_TAB_VIEW_CAMERA_CONFIG_ID = "摩托车自定义界面";

	// Token: 0x04008374 RID: 33652
	public const string MOTORCYCLE_DIY_ROOT_VIEW_CAMERA_CONFIG_ID = "摩托车贴纸界面";

	// Token: 0x04008375 RID: 33653
	public const string MOTORCYCLE_DIY_IMPORT_VIEW_CAMERA_CONFIG_ID = "摩托车预设界面";

	// Token: 0x04008376 RID: 33654
	public const string MOTORCYCLE_DIY_SKIN_VIEW_MODEL_ROTATE_CONFIG_ID = "摩托车皮肤旋转";

	// Token: 0x04008377 RID: 33655
	public const string MOTORCYCLE_DIY_NONE_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/Com/T_ComItemNoneIcon.T_ComItemNoneIcon";

	// Token: 0x04008378 RID: 33656
	public static int[] MOTORCYCLE_DIY_STICKER_PART;

	// Token: 0x04008379 RID: 33657
	public static int[] MOTORCYCLE_DIY_DECORATION_PART;

	// Token: 0x0400837A RID: 33658
	public static Dictionary<EOutlookType, string> OutlookToSkinCustomizeIconMap;

	// Token: 0x0400837B RID: 33659
	public static Dictionary<EOutlookType, string> OutlookToSkinCustomizeNameMap;
}
