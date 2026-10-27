using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004676 RID: 18038
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeDefine
	{
		// Token: 0x0602E8F0 RID: 190704 RVA: 0x00AC70FC File Offset: 0x00AC52FC
		// Note: this type is marked as 'beforefieldinit'.
		static InputDistributeDefine()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[0] = null;
			dictionary[1] = null;
			dictionary[2] = null;
			dictionary[3] = null;
			dictionary[4] = null;
			dictionary[5] = null;
			dictionary[6] = null;
			dictionary[7] = null;
			dictionary[8] = null;
			dictionary[9] = null;
			InputDistributeDefine.touchTagMap = dictionary;
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2["Android_Back"] = null;
			dictionary2["C"] = null;
			InputDistributeDefine.keyTagMap = dictionary2;
			InputDistributeDefine.inputDistributeEvents = new EEventName[]
			{
				EEventName.OnAddNotAllowFightInputViewName,
				EEventName.OnRemoveNotAllowFightInputViewName,
				EEventName.OnClearNotAllowFightInputViewName,
				EEventName.ShowHUD,
				EEventName.HideHUD,
				EEventName.ReConnectBegin,
				EEventName.ReConnectSuccess,
				EEventName.LogOut,
				EEventName.OnShowMouseCursor,
				EEventName.OnStartLoadingState,
				EEventName.OnFinishLoadingState,
				EEventName.WorldDone,
				EEventName.ResetModuleByResetToBattleView,
				EEventName.SdkKick,
				EEventName.CharOnRoleDrown,
				EEventName.OnPlotWaitViewDone,
				EEventName.ShowTypeChange,
				EEventName.OnCameraSequenceSetUiVisible,
				EEventName.OnEnterTransitionMap,
				EEventName.OnSequenceCameraStatus,
				EEventName.OnOnlyAllowFightInputStateChanged
			};
		}

		// Token: 0x0401951A RID: 103706
		[TupleElementNames(new string[]
		{
			"Tag",
			"ParentTag"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		public static readonly List<ValueTuple<string, string>> InitializeInputDistributeTagDefine = new List<ValueTuple<string, string>>
		{
			new ValueTuple<string, string>("FightInputRoot", null),
			new ValueTuple<string, string>("FightInputRoot.FightInput.ActionInput", "FightInputRoot"),
			new ValueTuple<string, string>("FightInputRoot.FightInput.ActionInput.CharacterSkillInput", "FightInputRoot.FightInput.ActionInput"),
			new ValueTuple<string, string>("FightInputRoot.FightInput.ActionInput.VehicleMusicInputTag", "FightInputRoot.FightInput.ActionInput"),
			new ValueTuple<string, string>("FightInputRoot.FightInput.AxisInput", "FightInputRoot"),
			new ValueTuple<string, string>("FightInputRoot.FightInput.AxisInput.CameraInput", "FightInputRoot.FightInput.AxisInput"),
			new ValueTuple<string, string>("FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation", "FightInputRoot.FightInput.AxisInput.CameraInput"),
			new ValueTuple<string, string>("FightInputRoot.FightInput.AxisInput.CameraInput.CameraZoom", "FightInputRoot.FightInput.AxisInput.CameraInput"),
			new ValueTuple<string, string>("FightInputRoot.FightInput.AxisInput.MoveInput", "FightInputRoot.FightInput.AxisInput"),
			new ValueTuple<string, string>("InteractionRoot", null),
			new ValueTuple<string, string>("UiInputRoot", null),
			new ValueTuple<string, string>("UiInputRoot.ShortcutKeyTag", "UiInputRoot"),
			new ValueTuple<string, string>("UiInputRoot.MouseInputTag", "UiInputRoot"),
			new ValueTuple<string, string>("UiInputRoot.Navigation", "UiInputRoot"),
			new ValueTuple<string, string>("BlockAllInputTag", null)
		};

		// Token: 0x0401951B RID: 103707
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, string> touchTagMap;

		// Token: 0x0401951C RID: 103708
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, string> keyTagMap;

		// Token: 0x0401951D RID: 103709
		[StaticVariableRuleIgnore]
		public static readonly EEventName[] inputDistributeEvents;

		// Token: 0x0401951E RID: 103710
		[StaticVariableRuleIgnore]
		public const float AXIS_TOLERANCE = 0.02f;

		// Token: 0x0200A8E9 RID: 43241
		[Nullable(0)]
		public static class InputDistributeTagDefine
		{
			// Token: 0x040336B6 RID: 210614
			public const string FightInputRootTag = "FightInputRoot";

			// Token: 0x040336B7 RID: 210615
			public const string InteractionRootTag = "InteractionRoot";

			// Token: 0x040336B8 RID: 210616
			public const string UiInputRootTag = "UiInputRoot";

			// Token: 0x040336B9 RID: 210617
			public const string BlockAllInputTag = "BlockAllInputTag";

			// Token: 0x0200D0EE RID: 53486
			[Nullable(0)]
			public static class FightInputRoot
			{
				// Token: 0x0403EB91 RID: 256913
				public const string ActionInputTag = "FightInputRoot.FightInput.ActionInput";

				// Token: 0x0403EB92 RID: 256914
				public const string AxisInputTag = "FightInputRoot.FightInput.AxisInput";

				// Token: 0x0200D1B9 RID: 53689
				[Nullable(0)]
				public static class ActionInput
				{
					// Token: 0x0403EEDA RID: 257754
					public const string CharacterSkillInputTag = "FightInputRoot.FightInput.ActionInput.CharacterSkillInput";

					// Token: 0x0403EEDB RID: 257755
					public const string VehicleMusicInputTag = "FightInputRoot.FightInput.ActionInput.VehicleMusicInputTag";
				}

				// Token: 0x0200D1BA RID: 53690
				[Nullable(0)]
				public static class AxisInput
				{
					// Token: 0x0403EEDC RID: 257756
					public const string CameraInputTag = "FightInputRoot.FightInput.AxisInput.CameraInput";

					// Token: 0x0403EEDD RID: 257757
					public const string MoveInputTag = "FightInputRoot.FightInput.AxisInput.MoveInput";

					// Token: 0x0200D1BB RID: 53691
					[Nullable(0)]
					public static class CameraInput
					{
						// Token: 0x0403EEDE RID: 257758
						public const string CameraRotationTag = "FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation";

						// Token: 0x0403EEDF RID: 257759
						public const string CameraZoomTag = "FightInputRoot.FightInput.AxisInput.CameraInput.CameraZoom";
					}
				}
			}

			// Token: 0x0200D0EF RID: 53487
			[Nullable(0)]
			public static class UiInputRoot
			{
				// Token: 0x0403EB93 RID: 256915
				public const string ShortcutKeyTag = "UiInputRoot.ShortcutKeyTag";

				// Token: 0x0403EB94 RID: 256916
				public const string NavigationTag = "UiInputRoot.Navigation";

				// Token: 0x0403EB95 RID: 256917
				public const string MouseInputTag = "UiInputRoot.MouseInputTag";
			}
		}

		// Token: 0x0200A8EA RID: 43242
		[NullableContext(0)]
		public enum EActionType
		{
			// Token: 0x040336BB RID: 210619
			Press,
			// Token: 0x040336BC RID: 210620
			Release
		}

		// Token: 0x0200A8EB RID: 43243
		[NullableContext(0)]
		public enum ETouchType
		{
			// Token: 0x040336BE RID: 210622
			TouchBegin,
			// Token: 0x040336BF RID: 210623
			TouchEnd,
			// Token: 0x040336C0 RID: 210624
			TouchMove
		}

		// Token: 0x0200A8EC RID: 43244
		public interface ITouchData
		{
			// Token: 0x1700A149 RID: 41289
			// (get) Token: 0x0604D583 RID: 316803
			// (set) Token: 0x0604D584 RID: 316804
			InputDistributeDefine.ETouchType TouchType { get; set; }

			// Token: 0x1700A14A RID: 41290
			// (get) Token: 0x0604D585 RID: 316805
			// (set) Token: 0x0604D586 RID: 316806
			int TouchId { get; set; }

			// Token: 0x1700A14B RID: 41291
			// (get) Token: 0x0604D587 RID: 316807
			// (set) Token: 0x0604D588 RID: 316808
			Vector TouchPosition { get; set; }
		}

		// Token: 0x0200A8ED RID: 43245
		[Nullable(0)]
		public class TouchData : InputDistributeDefine.ITouchData
		{
			// Token: 0x1700A14C RID: 41292
			// (get) Token: 0x0604D589 RID: 316809 RVA: 0x01454A82 File Offset: 0x01452C82
			// (set) Token: 0x0604D58A RID: 316810 RVA: 0x01454A8A File Offset: 0x01452C8A
			public InputDistributeDefine.ETouchType TouchType { get; set; }

			// Token: 0x1700A14D RID: 41293
			// (get) Token: 0x0604D58B RID: 316811 RVA: 0x01454A93 File Offset: 0x01452C93
			// (set) Token: 0x0604D58C RID: 316812 RVA: 0x01454A9B File Offset: 0x01452C9B
			public int TouchId { get; set; }

			// Token: 0x1700A14E RID: 41294
			// (get) Token: 0x0604D58D RID: 316813 RVA: 0x01454AA4 File Offset: 0x01452CA4
			// (set) Token: 0x0604D58E RID: 316814 RVA: 0x01454AAC File Offset: 0x01452CAC
			public Vector TouchPosition { get; set; }
		}
	}
}
