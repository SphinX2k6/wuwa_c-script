using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E6B RID: 24171
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotDefine
	{
		// Token: 0x04020122 RID: 131362
		public static readonly string STARTPOPINT_ICONPATH = "/Game/Aki/UI/UIResources/UiWorldMap/Atlas/Motorcycle/SP_IconWorldEnterPoint.SP_IconWorldEnterPoint";

		// Token: 0x04020123 RID: 131363
		public static readonly string ENDPOINT_ICONPATH = "/Game/Aki/UI/UIResources/UiWorldMap/Atlas/Motorcycle/SP_IconWorldEndPoint.SP_IconWorldEndPoint";

		// Token: 0x04020124 RID: 131364
		public static readonly int HIGHLIGHTLINEDISTANCEINTERVAL = 1250;

		// Token: 0x04020125 RID: 131365
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<AutoPilotDefine.EDisableAutoPilotReason, string> failReasonTxt = new Dictionary<AutoPilotDefine.EDisableAutoPilotReason, string>
		{
			{
				AutoPilotDefine.EDisableAutoPilotReason.NoCirclePath,
				AutoPilotDefine.EAutoPilotTextId.TextNoCirclePath
			},
			{
				AutoPilotDefine.EDisableAutoPilotReason.NotInAutoPilotArea,
				AutoPilotDefine.EAutoPilotTextId.TextNotInAutoPilotArea
			},
			{
				AutoPilotDefine.EDisableAutoPilotReason.NotNearRoad,
				AutoPilotDefine.EAutoPilotTextId.TextNotNearRoad
			},
			{
				AutoPilotDefine.EDisableAutoPilotReason.NotValidRole,
				AutoPilotDefine.EAutoPilotTextId.TextNotValidRole
			},
			{
				AutoPilotDefine.EDisableAutoPilotReason.InAutoPilot,
				AutoPilotDefine.EAutoPilotTextId.TextInAutoPilot
			},
			{
				AutoPilotDefine.EDisableAutoPilotReason.NoDest,
				AutoPilotDefine.EAutoPilotTextId.TextNoDest
			},
			{
				AutoPilotDefine.EDisableAutoPilotReason.NoHighLightLine,
				AutoPilotDefine.EAutoPilotTextId.TextNoHighLightLine
			}
		};

		// Token: 0x04020126 RID: 131366
		public static readonly int SUMMONMOTOR_SKILLID = 800001;

		// Token: 0x04020127 RID: 131367
		public static readonly string HIGHLIGHT_TAG_NAME = "角色.Common.技能通用标识.探索技能高亮黄色";

		// Token: 0x04020128 RID: 131368
		public static readonly int FINDPATH_TICK_INTERVAL = 30;

		// Token: 0x04020129 RID: 131369
		public static readonly float MOVIEMODE_UIVISIBLE_ANIM_TIME = 0.5f;

		// Token: 0x0402012A RID: 131370
		public static readonly int autoPilotTag = GameplayTagDefine.EGameplayTagId["载具.摩托.自动巡航"];

		// Token: 0x0200C1E2 RID: 49634
		[NullableContext(0)]
		[EnumExtensions]
		public enum EAutoPilotResourceId
		{
			// Token: 0x0403A984 RID: 240004
			[EnumStringMember("UiItem_AutocruiseNavBtn")]
			AutoPilotNavBtn,
			// Token: 0x0403A985 RID: 240005
			[EnumStringMember("PnlSetOutBtn")]
			AutoPilotGoBtnGroup,
			// Token: 0x0403A986 RID: 240006
			[EnumStringMember("UiItem_AutoPilot_Line")]
			AutoPilotLineComp,
			// Token: 0x0403A987 RID: 240007
			[EnumStringMember("UiItem_AutocruiseMark")]
			AutoPilotTrackMark,
			// Token: 0x0403A988 RID: 240008
			[EnumStringMember("UiView_MotorcycleAutoCruise")]
			AutoPilotView,
			// Token: 0x0403A989 RID: 240009
			[EnumStringMember("UiItem_MotorAutoCruise")]
			AutoPilotState
		}

		// Token: 0x0200C1E3 RID: 49635
		[Nullable(0)]
		public class EAutoPilotTextId
		{
			// Token: 0x0403A98A RID: 240010
			public static readonly string TextAutoPilotTrack = "AutoPilot_NavigationConfirm";

			// Token: 0x0403A98B RID: 240011
			public static readonly string TextAutoPilotTrackOff = "AutoPilot_NavigationCancel";

			// Token: 0x0403A98C RID: 240012
			public static readonly string TextAutoPilotActivated = "AutoPilot_AreaNotSupported";

			// Token: 0x0403A98D RID: 240013
			public static readonly string TextAutoPilotForbidden = "AutoPilot_NavigationForbidden";

			// Token: 0x0403A98E RID: 240014
			public static readonly string TextCanAutoPilot = "AutoPilot_RoutePointTips";

			// Token: 0x0403A98F RID: 240015
			public static readonly string TextNotInAutoPilotArea = "AutoPilot_NotPermitted";

			// Token: 0x0403A990 RID: 240016
			public static readonly string TextNoCirclePath = "AutoPilot_LoopNotSupported";

			// Token: 0x0403A991 RID: 240017
			public static readonly string TextNotNearRoad = "AutoPilot_NotPermitted";

			// Token: 0x0403A992 RID: 240018
			public static readonly string TextQuitTips = "AutoPilot_QuitTips";

			// Token: 0x0403A993 RID: 240019
			public static readonly string TextMarkToGuide = "AutoPilot_MarkToGuide";

			// Token: 0x0403A994 RID: 240020
			public static readonly string TextDestState = "AutoPilot_PilotMode";

			// Token: 0x0403A995 RID: 240021
			public static readonly string TextLoopState = "AutoPilot_LoopPilotMode";

			// Token: 0x0403A996 RID: 240022
			public static readonly string TextNotValidRole = "AutoPilot_NotPermitted";

			// Token: 0x0403A997 RID: 240023
			public static readonly string TextInAutoPilot = "AutoPilot_NotPermitted";

			// Token: 0x0403A998 RID: 240024
			public static readonly string TextNoDest = "AutoPilot_NotPermitted";

			// Token: 0x0403A999 RID: 240025
			public static readonly string TextNoHighLightLine = "AutoPilot_NotPermitted";

			// Token: 0x0403A99A RID: 240026
			public static readonly string TextAutoPilotAreaIsolatedTips = "AutoPilot_AreaIsolatedTips";

			// Token: 0x0403A99B RID: 240027
			public static readonly string TextAutoPilotUnValidTooNearTips = "AutoPilot_OverCloseTips_1";

			// Token: 0x0403A99C RID: 240028
			public static readonly string TextCancelAutoPilotTooNearTips = "AutoPilot_OverCloseTips_2";
		}

		// Token: 0x0200C1E4 RID: 49636
		public interface IAutoPilotTrackingData
		{
			// Token: 0x1700A269 RID: 41577
			// (get) Token: 0x06050514 RID: 328980
			// (set) Token: 0x06050515 RID: 328981
			Vector TargetPos { get; set; }

			// Token: 0x1700A26A RID: 41578
			// (get) Token: 0x06050516 RID: 328982
			// (set) Token: 0x06050517 RID: 328983
			int MapId { get; set; }
		}

		// Token: 0x0200C1E5 RID: 49637
		[Nullable(0)]
		[RequiredMember]
		public class AutoPilotTrackingData : AutoPilotDefine.IAutoPilotTrackingData
		{
			// Token: 0x1700A26B RID: 41579
			// (get) Token: 0x06050518 RID: 328984 RVA: 0x015995D3 File Offset: 0x015977D3
			// (set) Token: 0x06050519 RID: 328985 RVA: 0x015995DB File Offset: 0x015977DB
			[RequiredMember]
			public Vector TargetPos { get; set; }

			// Token: 0x1700A26C RID: 41580
			// (get) Token: 0x0605051A RID: 328986 RVA: 0x015995E4 File Offset: 0x015977E4
			// (set) Token: 0x0605051B RID: 328987 RVA: 0x015995EC File Offset: 0x015977EC
			[RequiredMember]
			public int MapId { get; set; }

			// Token: 0x0605051C RID: 328988 RVA: 0x015995F5 File Offset: 0x015977F5
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public AutoPilotTrackingData()
			{
			}
		}

		// Token: 0x0200C1E6 RID: 49638
		[NullableContext(0)]
		public enum EDisableAutoPilotReason
		{
			// Token: 0x0403A9A0 RID: 240032
			NoCirclePath,
			// Token: 0x0403A9A1 RID: 240033
			NotInAutoPilotArea,
			// Token: 0x0403A9A2 RID: 240034
			NotNearRoad,
			// Token: 0x0403A9A3 RID: 240035
			NotValidRole,
			// Token: 0x0403A9A4 RID: 240036
			InAutoPilot,
			// Token: 0x0403A9A5 RID: 240037
			NoDest,
			// Token: 0x0403A9A6 RID: 240038
			NoHighLightLine
		}

		// Token: 0x0200C1E7 RID: 49639
		public interface IEnableAutoPilot
		{
			// Token: 0x1700A26D RID: 41581
			// (get) Token: 0x0605051D RID: 328989
			// (set) Token: 0x0605051E RID: 328990
			AutoPilotDefine.EEnableAutoPilot Value { get; set; }

			// Token: 0x1700A26E RID: 41582
			// (get) Token: 0x0605051F RID: 328991
			// (set) Token: 0x06050520 RID: 328992
			AutoPilotDefine.EDisableAutoPilotReason? DisableReason { get; set; }
		}

		// Token: 0x0200C1E8 RID: 49640
		[NullableContext(0)]
		[RequiredMember]
		public class EnableAutoPilot : AutoPilotDefine.IEnableAutoPilot
		{
			// Token: 0x1700A26F RID: 41583
			// (get) Token: 0x06050521 RID: 328993 RVA: 0x015995FD File Offset: 0x015977FD
			// (set) Token: 0x06050522 RID: 328994 RVA: 0x01599605 File Offset: 0x01597805
			[RequiredMember]
			public AutoPilotDefine.EEnableAutoPilot Value { get; set; }

			// Token: 0x1700A270 RID: 41584
			// (get) Token: 0x06050523 RID: 328995 RVA: 0x0159960E File Offset: 0x0159780E
			// (set) Token: 0x06050524 RID: 328996 RVA: 0x01599616 File Offset: 0x01597816
			public AutoPilotDefine.EDisableAutoPilotReason? DisableReason { get; set; }

			// Token: 0x06050525 RID: 328997 RVA: 0x0159961F File Offset: 0x0159781F
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public EnableAutoPilot()
			{
			}
		}

		// Token: 0x0200C1E9 RID: 49641
		public interface IAutoPilotCircles
		{
			// Token: 0x1700A271 RID: 41585
			// (get) Token: 0x06050526 RID: 328998
			// (set) Token: 0x06050527 RID: 328999
			List<int> RoadBuildIdArray { get; set; }

			// Token: 0x1700A272 RID: 41586
			// (get) Token: 0x06050528 RID: 329000
			// (set) Token: 0x06050529 RID: 329001
			List<int> CircleIds { get; set; }
		}

		// Token: 0x0200C1EA RID: 49642
		[Nullable(0)]
		[RequiredMember]
		public class AutoPilotCircles : AutoPilotDefine.IAutoPilotCircles
		{
			// Token: 0x1700A273 RID: 41587
			// (get) Token: 0x0605052A RID: 329002 RVA: 0x01599627 File Offset: 0x01597827
			// (set) Token: 0x0605052B RID: 329003 RVA: 0x0159962F File Offset: 0x0159782F
			[RequiredMember]
			public List<int> RoadBuildIdArray { get; set; }

			// Token: 0x1700A274 RID: 41588
			// (get) Token: 0x0605052C RID: 329004 RVA: 0x01599638 File Offset: 0x01597838
			// (set) Token: 0x0605052D RID: 329005 RVA: 0x01599640 File Offset: 0x01597840
			[RequiredMember]
			public List<int> CircleIds { get; set; }

			// Token: 0x0605052E RID: 329006 RVA: 0x01599649 File Offset: 0x01597849
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public AutoPilotCircles()
			{
			}
		}

		// Token: 0x0200C1EB RID: 49643
		[NullableContext(0)]
		public enum EAutoPilotState
		{
			// Token: 0x0403A9AC RID: 240044
			None,
			// Token: 0x0403A9AD RID: 240045
			Dest,
			// Token: 0x0403A9AE RID: 240046
			Loop
		}

		// Token: 0x0200C1EC RID: 49644
		[NullableContext(0)]
		public enum EEnableAutoPilot
		{
			// Token: 0x0403A9B0 RID: 240048
			Disable,
			// Token: 0x0403A9B1 RID: 240049
			Dest,
			// Token: 0x0403A9B2 RID: 240050
			Loop
		}
	}
}
