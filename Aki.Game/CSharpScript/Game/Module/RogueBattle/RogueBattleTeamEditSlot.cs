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
	// Token: 0x02003E78 RID: 15992
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleTeamEditSlot : UiPanelBase, IDraggableSlot
	{
		// Token: 0x06028A3A RID: 166458 RVA: 0x00B68421 File Offset: 0x00B66621
		public RogueBattleTeamEditSlot(int index)
		{
			this.Index = index;
		}

		// Token: 0x06028A3B RID: 166459 RVA: 0x00B68430 File Offset: 0x00B66630
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

		// Token: 0x06028A3C RID: 166460 RVA: 0x00B685D2 File Offset: 0x00B667D2
		private void OnBtnSelf()
		{
			Action<int> onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack(this.Index);
		}

		// Token: 0x06028A3D RID: 166461 RVA: 0x00B685EC File Offset: 0x00B667EC
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleTeamEditSlot.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTeamEditSlot.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028A3E RID: 166462 RVA: 0x00B68630 File Offset: 0x00B66830
		protected override void OnStart()
		{
			UUIDraggableComponent draggable = base.GetDraggable(17);
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			this.RoleItem = base.GetItem(1);
		}

		// Token: 0x06028A3F RID: 166463 RVA: 0x00B686AD File Offset: 0x00B668AD
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.RogueResNewRoleFlagChange, new Action(this.RefreshRedDot));
			EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}

		// Token: 0x06028A40 RID: 166464 RVA: 0x00B686E7 File Offset: 0x00B668E7
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.RogueResNewRoleFlagChange, new Action(this.RefreshRedDot));
			EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		}

		// Token: 0x06028A41 RID: 166465 RVA: 0x00B68724 File Offset: 0x00B66924
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

		// Token: 0x06028A42 RID: 166466 RVA: 0x00B68764 File Offset: 0x00B66964
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

		// Token: 0x06028A43 RID: 166467 RVA: 0x00B687E6 File Offset: 0x00B669E6
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

		// Token: 0x06028A44 RID: 166468 RVA: 0x00B68805 File Offset: 0x00B66A05
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

		// Token: 0x06028A45 RID: 166469 RVA: 0x00B68845 File Offset: 0x00B66A45
		public int? GetConfigId()
		{
			return new int?(this.ConfigId);
		}

		// Token: 0x06028A46 RID: 166470 RVA: 0x00B68852 File Offset: 0x00B66A52
		public void Reset()
		{
			this.NeedTick = false;
			this.StartDrag = false;
			this.StartDragTime = 0f;
		}

		// Token: 0x06028A47 RID: 166471 RVA: 0x00B68870 File Offset: 0x00B66A70
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

		// Token: 0x06028A48 RID: 166472 RVA: 0x00B68908 File Offset: 0x00B66B08
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

		// Token: 0x06028A49 RID: 166473 RVA: 0x00B68992 File Offset: 0x00B66B92
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

		// Token: 0x06028A4A RID: 166474 RVA: 0x00B689CC File Offset: 0x00B66BCC
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

		// Token: 0x06028A4B RID: 166475 RVA: 0x00B68A53 File Offset: 0x00B66C53
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

		// Token: 0x06028A4C RID: 166476 RVA: 0x00B68A80 File Offset: 0x00B66C80
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

		// Token: 0x06028A4D RID: 166477 RVA: 0x00B68ABA File Offset: 0x00B66CBA
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

		// Token: 0x06028A4E RID: 166478 RVA: 0x00B68AEF File Offset: 0x00B66CEF
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

		// Token: 0x06028A4F RID: 166479 RVA: 0x00B68B2C File Offset: 0x00B66D2C
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

		// Token: 0x06028A50 RID: 166480 RVA: 0x00B68B84 File Offset: 0x00B66D84
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

		// Token: 0x06028A51 RID: 166481 RVA: 0x00B68BD6 File Offset: 0x00B66DD6
		[NullableContext(1)]
		private void OnInputAnyKey(bool bPress, FKey key)
		{
			if (this.StartDrag && bPress && !Info.Instance.IsInGamepad())
			{
				this.MouseCancelDrag();
			}
		}

		// Token: 0x06028A52 RID: 166482 RVA: 0x00B68BF4 File Offset: 0x00B66DF4
		public int GetPlayerId()
		{
			return PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		}

		// Token: 0x06028A53 RID: 166483 RVA: 0x00B68C14 File Offset: 0x00B66E14
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

		// Token: 0x06028A54 RID: 166484 RVA: 0x00B68E84 File Offset: 0x00B67084
		private void RefreshRedDot()
		{
			bool flag = this.Index == 0;
			bool rogueResNewRoleFlag = RogueBattleModel.Instance.GetRogueResNewRoleFlag();
			base.GetItem(10).SetUIActive(flag && rogueResNewRoleFlag);
		}

		// Token: 0x06028A55 RID: 166485 RVA: 0x00B68EB8 File Offset: 0x00B670B8
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

		// Token: 0x040161A9 RID: 90537
		public Action<ULGUIPointerEventData, int, int, int> OnPointDown;

		// Token: 0x040161AA RID: 90538
		public Action OnDragStart;

		// Token: 0x040161AB RID: 90539
		public Action<ULGUIPointerEventData> OnDragMove;

		// Token: 0x040161AC RID: 90540
		[Nullable(1)]
		public Action<bool> OnDragEnd;

		// Token: 0x040161AD RID: 90541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<UUIItem, int, int, int> OnGamePadDown;

		// Token: 0x040161AE RID: 90542
		private int? SkinId;

		// Token: 0x040161AF RID: 90543
		private FormationRoleDragStateItem DragStateItem;

		// Token: 0x040161B0 RID: 90544
		private UUIItem RoleItem;

		// Token: 0x040161B1 RID: 90545
		private bool NeedTick;

		// Token: 0x040161B2 RID: 90546
		private bool StartDrag;

		// Token: 0x040161B3 RID: 90547
		private float StartDragTime;

		// Token: 0x040161B4 RID: 90548
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040161B5 RID: 90549
		private LevelSequencePlayer CircleInLevelSequencePlayer;

		// Token: 0x040161B6 RID: 90550
		private LevelSequencePlayer CircleOutLevelSequencePlayer;

		// Token: 0x040161B7 RID: 90551
		public int ConfigId;

		// Token: 0x040161B8 RID: 90552
		public int Index;

		// Token: 0x040161B9 RID: 90553
		public RogueBattleTokenElement ElementItem;

		// Token: 0x040161BA RID: 90554
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RogueBattleTeamEditFetterIconItem, IRogueBattleRoleBondUpdateInfo> FetterLayout;

		// Token: 0x040161BB RID: 90555
		public Action<int> OnClickCallBack;

		// Token: 0x040161BC RID: 90556
		private bool HaveCustomShield;

		// Token: 0x040161BD RID: 90557
		private bool IsPlayingCircleIn;

		// Token: 0x02009A50 RID: 39504
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403019A RID: 197018
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IRogueBattleRoleBondUpdateInfo> <0>__SortRogueBattleRoleBondUpdateInfo;
		}
	}
}
