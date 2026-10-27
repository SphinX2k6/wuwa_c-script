using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EAF RID: 20143
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleTeamEditSlot : UiPanelBase, IDraggableSlot
	{
		// Token: 0x06033BCF RID: 211919 RVA: 0x00C1EF09 File Offset: 0x00C1D109
		public RogueBattleTeamEditSlot(int index)
		{
			this.Index = index;
		}

		// Token: 0x06033BD0 RID: 211920 RVA: 0x00C1EF18 File Offset: 0x00C1D118
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnSelf))
			};
		}

		// Token: 0x06033BD1 RID: 211921 RVA: 0x00C1F0BA File Offset: 0x00C1D2BA
		private void OnBtnSelf()
		{
			Action<int> onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack(this.Index);
		}

		// Token: 0x06033BD2 RID: 211922 RVA: 0x00C1F0D4 File Offset: 0x00C1D2D4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleTeamEditSlot.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTeamEditSlot.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033BD3 RID: 211923 RVA: 0x00C1F118 File Offset: 0x00C1D318
		protected override void OnStart()
		{
			UUIDraggableComponent draggable = base.GetDraggable(17);
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			this.RoleItem = base.GetItem(1);
		}

		// Token: 0x06033BD4 RID: 211924 RVA: 0x00C1F195 File Offset: 0x00C1D395
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RogueResNewRoleFlagChange, new Action(this.RefreshRedDot));
			EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}

		// Token: 0x06033BD5 RID: 211925 RVA: 0x00C1F1CF File Offset: 0x00C1D3CF
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RogueResNewRoleFlagChange, new Action(this.RefreshRedDot));
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}

		// Token: 0x06033BD6 RID: 211926 RVA: 0x00C1F20C File Offset: 0x00C1D40C
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (FormationViewDragController.DraggingIndex != this.Index + 1)
			{
				return;
			}
			FormationViewDragController.DraggingIndex = 0;
			this.NeedTick = false;
			this.EndShowDragItem();
			this.StopMove(null);
		}

		// Token: 0x06033BD7 RID: 211927 RVA: 0x00C1F24C File Offset: 0x00C1D44C
		private void OnPointerDown(ULGUIPointerEventData eventData)
		{
			if (this.ConfigId == 0)
			{
				return;
			}
			if (FormationViewDragController.DraggingIndex != 0)
			{
				Log.Instance.Info(ELogModule.Formation, ELogAuthor.LJQ, "RogueBattleTeamEditSlot-CanDragStart-false", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FormationViewDragController.DraggingIndex = this.Index + 1;
			this.NeedTick = true;
			this.StartDragTime = 0f;
			Action<ULGUIPointerEventData, int, int, int> onPointDown = this.OnPointDown;
			if (onPointDown == null)
			{
				return;
			}
			onPointDown(eventData, this.ConfigId, this.SkinId.GetValueOrDefault(), this.Index + 1);
		}

		// Token: 0x06033BD8 RID: 211928 RVA: 0x00C1F2CE File Offset: 0x00C1D4CE
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null || !this.StartDrag)
			{
				return;
			}
			Action<ULGUIPointerEventData> onDragMove = this.OnDragMove;
			if (onDragMove == null)
			{
				return;
			}
			onDragMove(eventData);
		}

		// Token: 0x06033BD9 RID: 211929 RVA: 0x00C1F2ED File Offset: 0x00C1D4ED
		public void OnTick(float delta)
		{
			if (!this.NeedTick)
			{
				return;
			}
			this.StartDragTime += delta;
			if (this.StartDragTime > 750f)
			{
				this.StartMoveDragItem();
				return;
			}
			if (this.StartDragTime > 250f)
			{
				this.StartShowDragItem();
			}
		}

		// Token: 0x06033BDA RID: 211930 RVA: 0x00C1F32D File Offset: 0x00C1D52D
		public int? GetConfigId()
		{
			return new int?(this.ConfigId);
		}

		// Token: 0x06033BDB RID: 211931 RVA: 0x00C1F33A File Offset: 0x00C1D53A
		public void Reset()
		{
			this.NeedTick = false;
			this.StartDrag = false;
			this.StartDragTime = 0f;
		}

		// Token: 0x06033BDC RID: 211932 RVA: 0x00C1F358 File Offset: 0x00C1D558
		private void StartShowDragItem()
		{
			if (this.IsPlayingCircleIn)
			{
				LevelSequencePlayer circleInLevelSequencePlayer = this.CircleInLevelSequencePlayer;
				if (circleInLevelSequencePlayer != null)
				{
					circleInLevelSequencePlayer.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer circleOutLevelSequencePlayer = this.CircleOutLevelSequencePlayer;
				if (circleOutLevelSequencePlayer != null)
				{
					circleOutLevelSequencePlayer.PlaySequencePurely("CircleOut", false, false, null, null, false);
				}
				this.IsPlayingCircleIn = false;
			}
			if (!this.HaveCustomShield)
			{
				FormationViewDragController.SetCustomShield(false);
				this.HaveCustomShield = true;
			}
			base.GetItem(20).SetUIActive(false);
			FormationRoleDragStateItem dragStateItem = this.DragStateItem;
			if (dragStateItem == null)
			{
				return;
			}
			dragStateItem.SetBarFill((this.StartDragTime - 250f) / 500f);
		}

		// Token: 0x06033BDD RID: 211933 RVA: 0x00C1F3F0 File Offset: 0x00C1D5F0
		public void EndShowDragItem()
		{
			if (this.IsPlayingCircleIn)
			{
				LevelSequencePlayer circleInLevelSequencePlayer = this.CircleInLevelSequencePlayer;
				if (circleInLevelSequencePlayer != null)
				{
					circleInLevelSequencePlayer.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer circleOutLevelSequencePlayer = this.CircleOutLevelSequencePlayer;
				if (circleOutLevelSequencePlayer != null)
				{
					circleOutLevelSequencePlayer.PlaySequencePurely("CircleOut", false, false, null, null, false);
				}
				this.IsPlayingCircleIn = false;
			}
			if (this.HaveCustomShield)
			{
				FormationViewDragController.SetCustomShield(true);
				this.HaveCustomShield = false;
			}
			base.GetItem(20).SetUIActive(false);
			FormationRoleDragStateItem dragStateItem = this.DragStateItem;
			if (dragStateItem == null)
			{
				return;
			}
			dragStateItem.SetBarFill(0f);
		}

		// Token: 0x06033BDE RID: 211934 RVA: 0x00C1F47A File Offset: 0x00C1D67A
		public void GamePadUp(bool isCancel = false)
		{
			if (this.ConfigId == 0)
			{
				return;
			}
			if (FormationViewDragController.DraggingIndex != this.Index + 1)
			{
				return;
			}
			FormationViewDragController.DraggingIndex = 0;
			this.NeedTick = false;
			this.EndShowDragItem();
			this.StopMove(new bool?(isCancel));
		}

		// Token: 0x06033BDF RID: 211935 RVA: 0x00C1F4B4 File Offset: 0x00C1D6B4
		public void GamePadPress()
		{
			if (this.ConfigId == 0)
			{
				return;
			}
			if (FormationViewDragController.DraggingIndex != 0)
			{
				Log.Instance.Info(ELogModule.Formation, ELogAuthor.LJQ, "FormationRoleView-CanDragStart-false", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FormationViewDragController.DraggingIndex = this.Index + 1;
			this.NeedTick = true;
			this.StartDragTime = 0f;
			Action<UUIItem, int, int, int> onGamePadDown = this.OnGamePadDown;
			if (onGamePadDown == null)
			{
				return;
			}
			onGamePadDown(this.RootItem, this.ConfigId, this.SkinId.GetValueOrDefault(), this.Index + 1);
		}

		// Token: 0x06033BE0 RID: 211936 RVA: 0x00C1F53B File Offset: 0x00C1D73B
		public void GamePadRelease()
		{
			if (!this.StartDrag)
			{
				if (this.OnClickCallBack != null)
				{
					this.OnClickCallBack(this.Index + 1);
				}
				this.GamePadUp(false);
				return;
			}
		}

		// Token: 0x06033BE1 RID: 211937 RVA: 0x00C1F568 File Offset: 0x00C1D768
		public void MouseCancelDrag()
		{
			if (this.ConfigId == 0)
			{
				return;
			}
			if (FormationViewDragController.DraggingIndex != this.Index + 1)
			{
				return;
			}
			FormationViewDragController.DraggingIndex = 0;
			this.NeedTick = false;
			this.EndShowDragItem();
			this.StopMove(new bool?(true));
		}

		// Token: 0x06033BE2 RID: 211938 RVA: 0x00C1F5A2 File Offset: 0x00C1D7A2
		private void StartMoveDragItem()
		{
			if (this.StartDrag)
			{
				return;
			}
			this.StartDrag = true;
			this.EndShowDragItem();
			Action onDragStart = this.OnDragStart;
			if (onDragStart != null)
			{
				onDragStart();
			}
			this.RoleItem.SetUIActive(false);
		}

		// Token: 0x06033BE3 RID: 211939 RVA: 0x00C1F5D7 File Offset: 0x00C1D7D7
		private void StopMove(bool? isCancel = null)
		{
			if (this.ConfigId == 0 || !this.StartDrag)
			{
				return;
			}
			this.StartDrag = false;
			this.RoleItem.SetUIActive(true);
			Action<bool> onDragEnd = this.OnDragEnd;
			if (onDragEnd == null)
			{
				return;
			}
			onDragEnd(isCancel.GetValueOrDefault());
		}

		// Token: 0x06033BE4 RID: 211940 RVA: 0x00C1F614 File Offset: 0x00C1D814
		public void ShowOtherItemUpState()
		{
			if (!this.IsPlayingCircleIn && !this.StartDrag)
			{
				LevelSequencePlayer circleInLevelSequencePlayer = this.CircleInLevelSequencePlayer;
				if (circleInLevelSequencePlayer != null)
				{
					circleInLevelSequencePlayer.PlaySequencePurely("CircleIn", false, false, null, null, false);
				}
				this.IsPlayingCircleIn = true;
				base.GetItem(20).SetUIActive(true);
			}
		}

		// Token: 0x06033BE5 RID: 211941 RVA: 0x00C1F66C File Offset: 0x00C1D86C
		public void RefreshLockItemState(bool isDrag)
		{
			if (!isDrag)
			{
				base.GetItem(19).SetUIActive(false);
				base.GetItem(21).SetUIActive(true);
				return;
			}
			if (this.ConfigId <= 0)
			{
				base.GetItem(19).SetUIActive(true);
				base.GetItem(21).SetUIActive(false);
			}
		}

		// Token: 0x06033BE6 RID: 211942 RVA: 0x00C1F6BE File Offset: 0x00C1D8BE
		[NullableContext(1)]
		private void OnInputAnyKey(bool bPress, FKey key)
		{
			if (this.StartDrag && bPress && !Info.Instance.IsInGamepad())
			{
				this.MouseCancelDrag();
			}
		}

		// Token: 0x06033BE7 RID: 211943 RVA: 0x00C1F6DC File Offset: 0x00C1D8DC
		public int GetPlayerId()
		{
			return PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		}

		// Token: 0x06033BE8 RID: 211944 RVA: 0x00C1F6FC File Offset: 0x00C1D8FC
		public void UpdateRoleInfo(int configId, int formationIndex)
		{
			RogueBattleTeamEditSlot.<>c__DisplayClass46_0 CS$<>8__locals1 = new RogueBattleTeamEditSlot.<>c__DisplayClass46_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.formationData = RogueBattleModel.Instance.GetFormationDataByIndex(formationIndex);
			this.RefreshRedDot();
			base.GetText(6).SetText((this.Index + 1).ToString(), true);
			if (configId == 0)
			{
				UUIItem item = base.GetItem(1);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				this.SetAnimState(configId);
				this.ConfigId = configId;
				return;
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(configId, true);
			CS$<>8__locals1.roleConfig = roleDataById.GetRoleConfig();
			int incIdByRoleId = RogueBattleModel.Instance.GetIncIdByRoleId(configId);
			RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(incIdByRoleId);
			int roleSkinId = roleDataById.GetRoleSkinId();
			this.SkinId = new int?(roleSkinId);
			RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId);
			CS$<>8__locals1.roleSpine = base.GetSpine(2);
			CS$<>8__locals1.roleItem = (UUIItem)CS$<>8__locals1.roleSpine.GetOwner().GetComponentByClass(UUIItem.StaticClass());
			CS$<>8__locals1.roleItem.SetAlpha(0f);
			string atlasPath = (roleSkinConfig != null) ? roleSkinConfig.Value.FormationSpineAtlas : CS$<>8__locals1.roleConfig.FormationSpineAtlas;
			string skeletonPath = (roleSkinConfig != null) ? roleSkinConfig.Value.FormationSpineSkeletonData : CS$<>8__locals1.roleConfig.FormationSpineSkeletonData;
			RogueBattleTeamEditSlot.<>c__DisplayClass46_0 CS$<>8__locals2 = CS$<>8__locals1;
			float[] param;
			if (roleSkinConfig == null)
			{
				(param = new float[3])[2] = 1f;
			}
			else
			{
				param = roleSkinConfig.Value.SpineParam();
			}
			CS$<>8__locals2.param = param;
			base.SetSpineAssetByPath(atlasPath, skeletonPath, CS$<>8__locals1.roleSpine).ContinueWith(delegate()
			{
				CS$<>8__locals1.roleItem.SetAlpha(1f);
				CS$<>8__locals1.roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
				CS$<>8__locals1.roleItem.SetAnchorOffsetX(CS$<>8__locals1.param[0]);
				CS$<>8__locals1.roleItem.SetAnchorOffsetY(CS$<>8__locals1.param[1]);
				CS$<>8__locals1.roleItem.SetUIItemScale(new FVector(CS$<>8__locals1.param[2], CS$<>8__locals1.param[2], CS$<>8__locals1.param[2]));
			});
			RogueBattleTokenElement elementItem = this.ElementItem;
			if (elementItem != null)
			{
				elementItem.Refresh(CS$<>8__locals1.roleConfig.ElementId, false, 0);
			}
			base.GetText(3).SetText(roleDataById.GetName(null), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RogueRes_FightFormation_RoleLevel", new <>z__ReadOnlySingleElementList<object>(MapRogueModel.Instance.GetRogueRoleLevel()));
			base.GetText(9).SetText(roleInfoById.Level.ToString(), true);
			UiAsyncTask task = new UiAsyncTask("RogueBattleTeamEditSlot.UpdateRoleInfo", delegate()
			{
				RogueBattleTeamEditSlot.<>c__DisplayClass46_0.<<UpdateRoleInfo>b__1>d <<UpdateRoleInfo>b__1>d;
				<<UpdateRoleInfo>b__1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<UpdateRoleInfo>b__1>d.<>4__this = CS$<>8__locals1;
				<<UpdateRoleInfo>b__1>d.<>1__state = -1;
				<<UpdateRoleInfo>b__1>d.<>t__builder.Start<RogueBattleTeamEditSlot.<>c__DisplayClass46_0.<<UpdateRoleInfo>b__1>d>(ref <<UpdateRoleInfo>b__1>d);
				return <<UpdateRoleInfo>b__1>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
			this.SetAnimState(configId);
			this.ConfigId = configId;
		}

		// Token: 0x06033BE9 RID: 211945 RVA: 0x00C1F96C File Offset: 0x00C1DB6C
		private void RefreshRedDot()
		{
			bool flag = this.Index == 0;
			bool rogueResNewRoleFlag = RogueBattleModel.Instance.GetRogueResNewRoleFlag();
			base.GetItem(10).SetUIActive(flag && rogueResNewRoleFlag);
		}

		// Token: 0x06033BEA RID: 211946 RVA: 0x00C1F9A0 File Offset: 0x00C1DBA0
		private void SetAnimState(int configId)
		{
			if (this.ConfigId == configId)
			{
				return;
			}
			if (configId == 0)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopSequenceByKey("PlayerIn", false, false);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null && levelSequencePlayer2.IsPlayingSequence("PlayerOut"))
				{
					this.LevelSequencePlayer.ReplaySequenceByKey("PlayerOut");
					return;
				}
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 == null)
				{
					return;
				}
				levelSequencePlayer3.PlayLevelSequenceByName("PlayerOut", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
				if (levelSequencePlayer4 != null)
				{
					levelSequencePlayer4.StopSequenceByKey("PlayerOut", false, false);
				}
				LevelSequencePlayer levelSequencePlayer5 = this.LevelSequencePlayer;
				if (levelSequencePlayer5 != null && levelSequencePlayer5.IsPlayingSequence("PlayerIn"))
				{
					this.LevelSequencePlayer.ReplaySequenceByKey("PlayerIn");
					return;
				}
				LevelSequencePlayer levelSequencePlayer6 = this.LevelSequencePlayer;
				if (levelSequencePlayer6 == null)
				{
					return;
				}
				levelSequencePlayer6.PlayLevelSequenceByName("PlayerIn", false, null, false);
				return;
			}
		}

		// Token: 0x0401B7D6 RID: 112598
		public Action<ULGUIPointerEventData, int, int, int> OnPointDown;

		// Token: 0x0401B7D7 RID: 112599
		public Action OnDragStart;

		// Token: 0x0401B7D8 RID: 112600
		public Action<ULGUIPointerEventData> OnDragMove;

		// Token: 0x0401B7D9 RID: 112601
		[Nullable(1)]
		public Action<bool> OnDragEnd;

		// Token: 0x0401B7DA RID: 112602
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<UUIItem, int, int, int> OnGamePadDown;

		// Token: 0x0401B7DB RID: 112603
		private int? SkinId;

		// Token: 0x0401B7DC RID: 112604
		private FormationRoleDragStateItem DragStateItem;

		// Token: 0x0401B7DD RID: 112605
		private UUIItem RoleItem;

		// Token: 0x0401B7DE RID: 112606
		private bool NeedTick;

		// Token: 0x0401B7DF RID: 112607
		private bool StartDrag;

		// Token: 0x0401B7E0 RID: 112608
		private float StartDragTime;

		// Token: 0x0401B7E1 RID: 112609
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B7E2 RID: 112610
		private LevelSequencePlayer CircleInLevelSequencePlayer;

		// Token: 0x0401B7E3 RID: 112611
		private LevelSequencePlayer CircleOutLevelSequencePlayer;

		// Token: 0x0401B7E4 RID: 112612
		public int ConfigId;

		// Token: 0x0401B7E5 RID: 112613
		public int Index;

		// Token: 0x0401B7E6 RID: 112614
		public RogueBattleTokenElement ElementItem;

		// Token: 0x0401B7E7 RID: 112615
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RogueBattleTeamEditFetterIconItem, IRogueBattleRoleBondUpdateInfo> FetterLayout;

		// Token: 0x0401B7E8 RID: 112616
		public Action<int> OnClickCallBack;

		// Token: 0x0401B7E9 RID: 112617
		private bool HaveCustomShield;

		// Token: 0x0401B7EA RID: 112618
		private bool IsPlayingCircleIn;

		// Token: 0x0200B01E RID: 45086
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403576A RID: 218986
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IRogueBattleRoleBondUpdateInfo> <0>__SortRogueBattleRoleBondUpdateInfo;
		}
	}
}
