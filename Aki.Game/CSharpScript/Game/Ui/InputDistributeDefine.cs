using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A7 RID: 13735
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeDefine
	{
		// Token: 0x0602303A RID: 143418 RVA: 0x009F4C5C File Offset: 0x009F2E5C
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

		// Token: 0x04013BC1 RID: 80833
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

		// Token: 0x04013BC2 RID: 80834
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, string> touchTagMap;

		// Token: 0x04013BC3 RID: 80835
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, string> keyTagMap;

		// Token: 0x04013BC4 RID: 80836
		[StaticVariableRuleIgnore]
		public static readonly EEventName[] inputDistributeEvents;

		// Token: 0x04013BC5 RID: 80837
		[StaticVariableRuleIgnore]
		public const float AXIS_TOLERANCE = 0.02f;

		// Token: 0x020092A4 RID: 37540
		[Nullable(0)]
		public static class InputDistributeTagDefine
		{
			// Token: 0x0402DE4A RID: 187978
			public const string FightInputRootTag = "FightInputRoot";

			// Token: 0x0402DE4B RID: 187979
			public const string InteractionRootTag = "InteractionRoot";

			// Token: 0x0402DE4C RID: 187980
			public const string UiInputRootTag = "UiInputRoot";

			// Token: 0x0402DE4D RID: 187981
			public const string BlockAllInputTag = "BlockAllInputTag";

			// Token: 0x0200BCCC RID: 48332
			[Nullable(0)]
			public static class FightInputRoot
			{
				// Token: 0x04039FD9 RID: 237529
				public const string ActionInputTag = "FightInputRoot.FightInput.ActionInput";

				// Token: 0x04039FDA RID: 237530
				public const string AxisInputTag = "FightInputRoot.FightInput.AxisInput";

				// Token: 0x0200BD9C RID: 48540
				[Nullable(0)]
				public static class ActionInput
				{
					// Token: 0x0403A337 RID: 238391
					public const string CharacterSkillInputTag = "FightInputRoot.FightInput.ActionInput.CharacterSkillInput";

					// Token: 0x0403A338 RID: 238392
					public const string VehicleMusicInputTag = "FightInputRoot.FightInput.ActionInput.VehicleMusicInputTag";
				}

				// Token: 0x0200BD9D RID: 48541
				[Nullable(0)]
				public static class AxisInput
				{
					// Token: 0x0403A339 RID: 238393
					public const string CameraInputTag = "FightInputRoot.FightInput.AxisInput.CameraInput";

					// Token: 0x0403A33A RID: 238394
					public const string MoveInputTag = "FightInputRoot.FightInput.AxisInput.MoveInput";

					// Token: 0x0200BD9E RID: 48542
					[Nullable(0)]
					public static class CameraInput
					{
						// Token: 0x0403A33B RID: 238395
						public const string CameraRotationTag = "FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation";

						// Token: 0x0403A33C RID: 238396
						public const string CameraZoomTag = "FightInputRoot.FightInput.AxisInput.CameraInput.CameraZoom";
					}
				}
			}

			// Token: 0x0200BCCD RID: 48333
			[Nullable(0)]
			public static class UiInputRoot
			{
				// Token: 0x04039FDB RID: 237531
				public const string ShortcutKeyTag = "UiInputRoot.ShortcutKeyTag";

				// Token: 0x04039FDC RID: 237532
				public const string NavigationTag = "UiInputRoot.Navigation";

				// Token: 0x04039FDD RID: 237533
				public const string MouseInputTag = "UiInputRoot.MouseInputTag";
			}
		}

		// Token: 0x020092A5 RID: 37541
		[NullableContext(0)]
		public enum EActionType
		{
			// Token: 0x0402DE4F RID: 187983
			Press,
			// Token: 0x0402DE50 RID: 187984
			Release
		}

		// Token: 0x020092A6 RID: 37542
		[NullableContext(0)]
		public enum ETouchType
		{
			// Token: 0x0402DE52 RID: 187986
			TouchBegin,
			// Token: 0x0402DE53 RID: 187987
			TouchEnd,
			// Token: 0x0402DE54 RID: 187988
			TouchMove
		}

		// Token: 0x020092A7 RID: 37543
		public interface ITouchData
		{
			// Token: 0x170078DF RID: 30943
			// (get) Token: 0x06043AB0 RID: 277168
			// (set) Token: 0x06043AB1 RID: 277169
			InputDistributeDefine.ETouchType TouchType { get; set; }

			// Token: 0x170078E0 RID: 30944
			// (get) Token: 0x06043AB2 RID: 277170
			// (set) Token: 0x06043AB3 RID: 277171
			int TouchId { get; set; }

			// Token: 0x170078E1 RID: 30945
			// (get) Token: 0x06043AB4 RID: 277172
			// (set) Token: 0x06043AB5 RID: 277173
			Vector TouchPosition { get; set; }
		}

		// Token: 0x020092A8 RID: 37544
		[Nullable(0)]
		public class TouchData : InputDistributeDefine.ITouchData
		{
			// Token: 0x170078E2 RID: 30946
			// (get) Token: 0x06043AB6 RID: 277174 RVA: 0x01402F2A File Offset: 0x0140112A
			// (set) Token: 0x06043AB7 RID: 277175 RVA: 0x01402F32 File Offset: 0x01401132
			public InputDistributeDefine.ETouchType TouchType { get; set; }

			// Token: 0x170078E3 RID: 30947
			// (get) Token: 0x06043AB8 RID: 277176 RVA: 0x01402F3B File Offset: 0x0140113B
			// (set) Token: 0x06043AB9 RID: 277177 RVA: 0x01402F43 File Offset: 0x01401143
			public int TouchId { get; set; }

			// Token: 0x170078E4 RID: 30948
			// (get) Token: 0x06043ABA RID: 277178 RVA: 0x01402F4C File Offset: 0x0140114C
			// (set) Token: 0x06043ABB RID: 277179 RVA: 0x01402F54 File Offset: 0x01401154
			public Vector TouchPosition { get; set; }
		}
	}
}
