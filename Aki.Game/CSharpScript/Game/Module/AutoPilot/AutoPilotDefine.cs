using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E50 RID: 20048
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotDefine
	{
		// Token: 0x0401ABE9 RID: 109545
		public static readonly string STARTPOPINT_ICONPATH = "/Game/Aki/UI/UIResources/UiWorldMap/Atlas/Motorcycle/SP_IconWorldEnterPoint.SP_IconWorldEnterPoint";

		// Token: 0x0401ABEA RID: 109546
		public static readonly string ENDPOINT_ICONPATH = "/Game/Aki/UI/UIResources/UiWorldMap/Atlas/Motorcycle/SP_IconWorldEndPoint.SP_IconWorldEndPoint";

		// Token: 0x0401ABEB RID: 109547
		public static readonly int HIGHLIGHTLINEDISTANCEINTERVAL = 1250;

		// Token: 0x0401ABEC RID: 109548
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

		// Token: 0x0401ABED RID: 109549
		public static readonly int SUMMONMOTOR_SKILLID = 800001;

		// Token: 0x0401ABEE RID: 109550
		public static readonly string HIGHLIGHT_TAG_NAME = "角色.Common.技能通用标识.探索技能高亮黄色";

		// Token: 0x0401ABEF RID: 109551
		public static readonly int FINDPATH_TICK_INTERVAL = 30;

		// Token: 0x0401ABF0 RID: 109552
		public static readonly float MOVIEMODE_UIVISIBLE_ANIM_TIME = 0.5f;

		// Token: 0x0401ABF1 RID: 109553
		public static readonly int autoPilotTag = GameplayTagDefine.EGameplayTagId["载具.摩托.自动巡航"];

		// Token: 0x0200ABF1 RID: 44017
		[NullableContext(0)]
		[EnumExtensions]
		public enum EAutoPilotResourceId
		{
			// Token: 0x04035376 RID: 217974
			[EnumStringMember("UiItem_AutocruiseNavBtn")]
			AutoPilotNavBtn,
			// Token: 0x04035377 RID: 217975
			[EnumStringMember("PnlSetOutBtn")]
			AutoPilotGoBtnGroup,
			// Token: 0x04035378 RID: 217976
			[EnumStringMember("UiItem_AutoPilot_Line")]
			AutoPilotLineComp,
			// Token: 0x04035379 RID: 217977
			[EnumStringMember("UiItem_AutocruiseMark")]
			AutoPilotTrackMark,
			// Token: 0x0403537A RID: 217978
			[EnumStringMember("UiView_MotorcycleAutoCruise")]
			AutoPilotView,
			// Token: 0x0403537B RID: 217979
			[EnumStringMember("UiItem_MotorAutoCruise")]
			AutoPilotState
		}

		// Token: 0x0200ABF2 RID: 44018
		[Nullable(0)]
		public class EAutoPilotTextId
		{
			// Token: 0x0403537C RID: 217980
			public static readonly string TextAutoPilotTrack = "AutoPilot_NavigationConfirm";

			// Token: 0x0403537D RID: 217981
			public static readonly string TextAutoPilotTrackOff = "AutoPilot_NavigationCancel";

			// Token: 0x0403537E RID: 217982
			public static readonly string TextAutoPilotActivated = "AutoPilot_AreaNotSupported";

			// Token: 0x0403537F RID: 217983
			public static readonly string TextAutoPilotForbidden = "AutoPilot_NavigationForbidden";

			// Token: 0x04035380 RID: 217984
			public static readonly string TextCanAutoPilot = "AutoPilot_RoutePointTips";

			// Token: 0x04035381 RID: 217985
			public static readonly string TextNotInAutoPilotArea = "AutoPilot_NotPermitted";

			// Token: 0x04035382 RID: 217986
			public static readonly string TextNoCirclePath = "AutoPilot_LoopNotSupported";

			// Token: 0x04035383 RID: 217987
			public static readonly string TextNotNearRoad = "AutoPilot_NotPermitted";

			// Token: 0x04035384 RID: 217988
			public static readonly string TextQuitTips = "AutoPilot_QuitTips";

			// Token: 0x04035385 RID: 217989
			public static readonly string TextMarkToGuide = "AutoPilot_MarkToGuide";

			// Token: 0x04035386 RID: 217990
			public static readonly string TextDestState = "AutoPilot_PilotMode";

			// Token: 0x04035387 RID: 217991
			public static readonly string TextLoopState = "AutoPilot_LoopPilotMode";

			// Token: 0x04035388 RID: 217992
			public static readonly string TextNotValidRole = "AutoPilot_NotPermitted";

			// Token: 0x04035389 RID: 217993
			public static readonly string TextInAutoPilot = "AutoPilot_NotPermitted";

			// Token: 0x0403538A RID: 217994
			public static readonly string TextNoDest = "AutoPilot_NotPermitted";

			// Token: 0x0403538B RID: 217995
			public static readonly string TextNoHighLightLine = "AutoPilot_NotPermitted";

			// Token: 0x0403538C RID: 217996
			public static readonly string TextAutoPilotAreaIsolatedTips = "AutoPilot_AreaIsolatedTips";

			// Token: 0x0403538D RID: 217997
			public static readonly string TextAutoPilotUnValidTooNearTips = "AutoPilot_OverCloseTips_1";

			// Token: 0x0403538E RID: 217998
			public static readonly string TextCancelAutoPilotTooNearTips = "AutoPilot_OverCloseTips_2";
		}

		// Token: 0x0200ABF3 RID: 44019
		public interface IAutoPilotTrackingData
		{
			// Token: 0x17007A06 RID: 31238
			// (get) Token: 0x06046A61 RID: 289377
			// (set) Token: 0x06046A62 RID: 289378
			Vector TargetPos { get; set; }

			// Token: 0x17007A07 RID: 31239
			// (get) Token: 0x06046A63 RID: 289379
			// (set) Token: 0x06046A64 RID: 289380
			int MapId { get; set; }
		}

		// Token: 0x0200ABF4 RID: 44020
		[Nullable(0)]
		[RequiredMember]
		public class AutoPilotTrackingData : AutoPilotDefine.IAutoPilotTrackingData
		{
			// Token: 0x17007A08 RID: 31240
			// (get) Token: 0x06046A65 RID: 289381 RVA: 0x01552ECF File Offset: 0x015510CF
			// (set) Token: 0x06046A66 RID: 289382 RVA: 0x01552ED7 File Offset: 0x015510D7
			[RequiredMember]
			public Vector TargetPos { get; set; }

			// Token: 0x17007A09 RID: 31241
			// (get) Token: 0x06046A67 RID: 289383 RVA: 0x01552EE0 File Offset: 0x015510E0
			// (set) Token: 0x06046A68 RID: 289384 RVA: 0x01552EE8 File Offset: 0x015510E8
			[RequiredMember]
			public int MapId { get; set; }

			// Token: 0x06046A69 RID: 289385 RVA: 0x01552EF1 File Offset: 0x015510F1
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public AutoPilotTrackingData()
			{
			}
		}

		// Token: 0x0200ABF5 RID: 44021
		[NullableContext(0)]
		public enum EDisableAutoPilotReason
		{
			// Token: 0x04035392 RID: 218002
			NoCirclePath,
			// Token: 0x04035393 RID: 218003
			NotInAutoPilotArea,
			// Token: 0x04035394 RID: 218004
			NotNearRoad,
			// Token: 0x04035395 RID: 218005
			NotValidRole,
			// Token: 0x04035396 RID: 218006
			InAutoPilot,
			// Token: 0x04035397 RID: 218007
			NoDest,
			// Token: 0x04035398 RID: 218008
			NoHighLightLine
		}

		// Token: 0x0200ABF6 RID: 44022
		public interface IEnableAutoPilot
		{
			// Token: 0x17007A0A RID: 31242
			// (get) Token: 0x06046A6A RID: 289386
			// (set) Token: 0x06046A6B RID: 289387
			AutoPilotDefine.EEnableAutoPilot Value { get; set; }

			// Token: 0x17007A0B RID: 31243
			// (get) Token: 0x06046A6C RID: 289388
			// (set) Token: 0x06046A6D RID: 289389
			AutoPilotDefine.EDisableAutoPilotReason? DisableReason { get; set; }
		}

		// Token: 0x0200ABF7 RID: 44023
		[NullableContext(0)]
		[RequiredMember]
		public class EnableAutoPilot : AutoPilotDefine.IEnableAutoPilot
		{
			// Token: 0x17007A0C RID: 31244
			// (get) Token: 0x06046A6E RID: 289390 RVA: 0x01552EF9 File Offset: 0x015510F9
			// (set) Token: 0x06046A6F RID: 289391 RVA: 0x01552F01 File Offset: 0x01551101
			[RequiredMember]
			public AutoPilotDefine.EEnableAutoPilot Value { get; set; }

			// Token: 0x17007A0D RID: 31245
			// (get) Token: 0x06046A70 RID: 289392 RVA: 0x01552F0A File Offset: 0x0155110A
			// (set) Token: 0x06046A71 RID: 289393 RVA: 0x01552F12 File Offset: 0x01551112
			public AutoPilotDefine.EDisableAutoPilotReason? DisableReason { get; set; }

			// Token: 0x06046A72 RID: 289394 RVA: 0x01552F1B File Offset: 0x0155111B
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public EnableAutoPilot()
			{
			}
		}

		// Token: 0x0200ABF8 RID: 44024
		public interface IAutoPilotCircles
		{
			// Token: 0x17007A0E RID: 31246
			// (get) Token: 0x06046A73 RID: 289395
			// (set) Token: 0x06046A74 RID: 289396
			List<int> RoadBuildIdArray { get; set; }

			// Token: 0x17007A0F RID: 31247
			// (get) Token: 0x06046A75 RID: 289397
			// (set) Token: 0x06046A76 RID: 289398
			List<int> CircleIds { get; set; }
		}

		// Token: 0x0200ABF9 RID: 44025
		[Nullable(0)]
		[RequiredMember]
		public class AutoPilotCircles : AutoPilotDefine.IAutoPilotCircles
		{
			// Token: 0x17007A10 RID: 31248
			// (get) Token: 0x06046A77 RID: 289399 RVA: 0x01552F23 File Offset: 0x01551123
			// (set) Token: 0x06046A78 RID: 289400 RVA: 0x01552F2B File Offset: 0x0155112B
			[RequiredMember]
			public List<int> RoadBuildIdArray { get; set; }

			// Token: 0x17007A11 RID: 31249
			// (get) Token: 0x06046A79 RID: 289401 RVA: 0x01552F34 File Offset: 0x01551134
			// (set) Token: 0x06046A7A RID: 289402 RVA: 0x01552F3C File Offset: 0x0155113C
			[RequiredMember]
			public List<int> CircleIds { get; set; }

			// Token: 0x06046A7B RID: 289403 RVA: 0x01552F45 File Offset: 0x01551145
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public AutoPilotCircles()
			{
			}
		}

		// Token: 0x0200ABFA RID: 44026
		[NullableContext(0)]
		public enum EAutoPilotState
		{
			// Token: 0x0403539E RID: 218014
			None,
			// Token: 0x0403539F RID: 218015
			Dest,
			// Token: 0x040353A0 RID: 218016
			Loop
		}

		// Token: 0x0200ABFB RID: 44027
		[NullableContext(0)]
		public enum EEnableAutoPilot
		{
			// Token: 0x040353A2 RID: 218018
			Disable,
			// Token: 0x040353A3 RID: 218019
			Dest,
			// Token: 0x040353A4 RID: 218020
			Loop
		}
	}
}
