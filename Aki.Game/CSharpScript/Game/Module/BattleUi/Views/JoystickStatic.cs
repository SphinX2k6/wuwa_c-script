using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D41 RID: 19777
	public class JoystickStatic : Joystick, IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x06031A4A RID: 203338 RVA: 0x00DE2689 File Offset: 0x00DE0889
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
		}

		// Token: 0x06031A4B RID: 203339 RVA: 0x00DE26C8 File Offset: 0x00DE08C8
		protected override void OnAfterShow()
		{
			this.TagIdVisible = BattleUiModel.Instance.GetTagIdJoystickStaticVisible();
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null)
			{
				if (this.TagIdVisible != null)
				{
					BaseTagComponent gameplayTagComponent = curRoleData.GameplayTagComponent;
					if (gameplayTagComponent == null)
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "Initialize gamePlayTag 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					if (gameplayTagComponent.HasAnyTag(this.TagIdVisible))
					{
						UUIItem rootItem = this.RootItem;
						if (rootItem != null)
						{
							rootItem.SetUIActive(false);
						}
						curRoleData.MorphShowSpecialEnergyBar = true;
						return;
					}
					curRoleData.MorphShowSpecialEnergyBar = false;
					foreach (int tagId in this.TagIdVisible)
					{
						gameplayTagComponent.AddTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagAddOrRemove), null);
					}
					return;
				}
			}
			else
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "Initialize roleData 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06031A4C RID: 203340 RVA: 0x00DE27A8 File Offset: 0x00DE09A8
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.AnimHoverItem = new List<ULGUIPlayTweenComponent>();
			UUIItem item = base.GetItem(8);
			TArray<UActorComponent> tarray;
			if (item == null)
			{
				tarray = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				tarray = ((owner != null) ? owner.K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
			}
			TArray<UActorComponent> tarray2 = tarray;
			int num = tarray2.Num();
			for (int i = 0; i < num; i++)
			{
				this.AnimHoverItem.Add((ULGUIPlayTweenComponent)tarray2.Get(i));
			}
			this.AnimNormalItem = new List<ULGUIPlayTweenComponent>();
			UUIItem item2 = base.GetItem(9);
			TArray<UActorComponent> tarray3;
			if (item2 == null)
			{
				tarray3 = null;
			}
			else
			{
				AActor owner2 = item2.GetOwner();
				tarray3 = ((owner2 != null) ? owner2.K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
			}
			tarray2 = tarray3;
			num = tarray2.Num();
			for (int j = 0; j < num; j++)
			{
				this.AnimNormalItem.Add((ULGUIPlayTweenComponent)tarray2.Get(j));
			}
			this.TargetVector.Set(0.0, 200.0, 0.0);
			this.SetHandleOffset(this.TargetVector);
			base.SetInputAxis(this.TargetVector, true);
			this.SetUiOnDrag(false);
			this.IsDynamicJoystick = false;
		}

		// Token: 0x06031A4D RID: 203341 RVA: 0x00DE28C8 File Offset: 0x00DE0AC8
		protected override void OnHideBattleChildView()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null)
			{
				curRoleData.MorphShowSpecialEnergyBar = true;
				if (this.TagIdVisible != null)
				{
					BaseTagComponent gameplayTagComponent = curRoleData.GameplayTagComponent;
					if (gameplayTagComponent != null)
					{
						foreach (int tagId in this.TagIdVisible)
						{
							gameplayTagComponent.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagAddOrRemove));
						}
						return;
					}
					Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "OnHideBattleChildView gamePlayTag 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
			}
			else
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "OnHideBattleChildView roleData 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06031A4E RID: 203342 RVA: 0x00DE2968 File Offset: 0x00DE0B68
		private void OnTagAddOrRemove(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
				if (curRoleData != null)
				{
					curRoleData.MorphShowSpecialEnergyBar = true;
				}
				else
				{
					Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "OnTagAddOrRemove roleData 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				EventSystem.Instance.Emit<bool>(EEventName.BattleUiEnergyBarVisible, true);
				UUIItem rootItem = this.RootItem;
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetUIActive(false);
			}
		}

		// Token: 0x06031A4F RID: 203343 RVA: 0x00DE29CD File Offset: 0x00DE0BCD
		public override void OnDynamicChanged(bool isDynamic)
		{
		}

		// Token: 0x06031A50 RID: 203344 RVA: 0x00DE29D0 File Offset: 0x00DE0BD0
		protected override void OnWalk()
		{
			if (this.CurrentJoystickType == EJoystickType.Walk)
			{
				return;
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "控制角色行走", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.SetUiOnDrag(true);
			this.CurrentJoystickType = EJoystickType.Walk;
		}

		// Token: 0x06031A51 RID: 203345 RVA: 0x00DE2A20 File Offset: 0x00DE0C20
		protected override void OnRun()
		{
			if (this.CurrentJoystickType == EJoystickType.Run)
			{
				return;
			}
			if (BattleUiModel.Instance.IsOpenJoystickLog)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "控制角色奔跑", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.SetUiOnDrag(true);
			this.CurrentJoystickType = EJoystickType.Run;
		}

		// Token: 0x06031A52 RID: 203346 RVA: 0x00DE2A70 File Offset: 0x00DE0C70
		protected override void OnStand()
		{
			if (this.CurrentJoystickType != EJoystickType.Stand)
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "松开摇杆时控制角色站立", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				if (this.CurrentJoystickType != EJoystickType.StandInTouch)
				{
					this.SetUiOnDrag(false);
				}
				this.CurrentJoystickType = EJoystickType.Stand;
			}
		}

		// Token: 0x06031A53 RID: 203347 RVA: 0x00DE2AC4 File Offset: 0x00DE0CC4
		protected override void OnStandInTouch()
		{
			if (this.CurrentJoystickType != EJoystickType.StandInTouch)
			{
				if (BattleUiModel.Instance.IsOpenJoystickLog)
				{
					Log.Instance.Info(ELogModule.Battle, ELogAuthor.XXJ, "按下摇杆时控制角色站立", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				if (this.CurrentJoystickType != EJoystickType.Stand)
				{
					this.SetUiOnDrag(false);
				}
				this.CurrentJoystickType = EJoystickType.StandInTouch;
			}
		}

		// Token: 0x06031A54 RID: 203348 RVA: 0x00DE2B18 File Offset: 0x00DE0D18
		protected void SetUiOnDrag(bool onDrag)
		{
			if (onDrag)
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.AnimNormalItem)
				{
					ulguiplayTweenComponent.Stop();
				}
				using (List<ULGUIPlayTweenComponent>.Enumerator enumerator = this.AnimHoverItem.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ULGUIPlayTweenComponent ulguiplayTweenComponent2 = enumerator.Current;
						ulguiplayTweenComponent2.Play();
					}
					return;
				}
			}
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent3 in this.AnimHoverItem)
			{
				ulguiplayTweenComponent3.Stop();
			}
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent4 in this.AnimNormalItem)
			{
				ulguiplayTweenComponent4.Play();
			}
		}

		// Token: 0x06031A55 RID: 203349 RVA: 0x00DE2C28 File Offset: 0x00DE0E28
		[NullableContext(1)]
		protected override void SetHandleOffset(Vector targetVector)
		{
			FRotator? rotatorMoveArrow = base.GetRotatorMoveArrow(targetVector);
			if (rotatorMoveArrow == null)
			{
				return;
			}
			UUIItem walkBgItem = this.WalkBgItem;
			FRotator value = rotatorMoveArrow.Value;
			walkBgItem.SetUIRelativeRotation(value);
		}

		// Token: 0x06031A56 RID: 203350 RVA: 0x00DE2C5C File Offset: 0x00DE0E5C
		public override void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			this.JoystickVisible = bVisible;
		}

		// Token: 0x06031A57 RID: 203351 RVA: 0x00DE2C65 File Offset: 0x00DE0E65
		protected override void UpdateJoystickVisible()
		{
		}

		// Token: 0x0401A490 RID: 107664
		private const float INIT_TARGET_VECTOR_Y = 200f;

		// Token: 0x0401A491 RID: 107665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> AnimHoverItem;

		// Token: 0x0401A492 RID: 107666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> AnimNormalItem;

		// Token: 0x0401A493 RID: 107667
		[Nullable(2)]
		private int[] TagIdVisible;

		// Token: 0x0200AA14 RID: 43540
		private enum EChildType
		{
			// Token: 0x0403490D RID: 215309
			AnimOnHover = 8,
			// Token: 0x0403490E RID: 215310
			AnimNormal
		}
	}
}
