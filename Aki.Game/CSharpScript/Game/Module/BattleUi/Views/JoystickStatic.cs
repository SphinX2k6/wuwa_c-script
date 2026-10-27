using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D5F RID: 23903
	public class JoystickStatic : Joystick, IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x0603CAEF RID: 248559 RVA: 0x00E91E9C File Offset: 0x00E9009C
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
		}

		// Token: 0x0603CAF0 RID: 248560 RVA: 0x00E91EDC File Offset: 0x00E900DC
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

		// Token: 0x0603CAF1 RID: 248561 RVA: 0x00E91FBC File Offset: 0x00E901BC
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

		// Token: 0x0603CAF2 RID: 248562 RVA: 0x00E920DC File Offset: 0x00E902DC
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

		// Token: 0x0603CAF3 RID: 248563 RVA: 0x00E9217C File Offset: 0x00E9037C
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

		// Token: 0x0603CAF4 RID: 248564 RVA: 0x00E921E1 File Offset: 0x00E903E1
		public override void OnDynamicChanged(bool isDynamic)
		{
		}

		// Token: 0x0603CAF5 RID: 248565 RVA: 0x00E921E4 File Offset: 0x00E903E4
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

		// Token: 0x0603CAF6 RID: 248566 RVA: 0x00E92234 File Offset: 0x00E90434
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

		// Token: 0x0603CAF7 RID: 248567 RVA: 0x00E92284 File Offset: 0x00E90484
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

		// Token: 0x0603CAF8 RID: 248568 RVA: 0x00E922D8 File Offset: 0x00E904D8
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

		// Token: 0x0603CAF9 RID: 248569 RVA: 0x00E9232C File Offset: 0x00E9052C
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

		// Token: 0x0603CAFA RID: 248570 RVA: 0x00E9243C File Offset: 0x00E9063C
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

		// Token: 0x0603CAFB RID: 248571 RVA: 0x00E92470 File Offset: 0x00E90670
		public override void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			this.JoystickVisible = bVisible;
		}

		// Token: 0x0603CAFC RID: 248572 RVA: 0x00E92479 File Offset: 0x00E90679
		protected override void UpdateJoystickVisible()
		{
		}

		// Token: 0x0401F9D8 RID: 129496
		private const float INIT_TARGET_VECTOR_Y = 200f;

		// Token: 0x0401F9D9 RID: 129497
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> AnimHoverItem;

		// Token: 0x0401F9DA RID: 129498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> AnimNormalItem;

		// Token: 0x0401F9DB RID: 129499
		[Nullable(2)]
		private int[] TagIdVisible;

		// Token: 0x0200C00E RID: 49166
		private enum EChildType
		{
			// Token: 0x04039F4B RID: 237387
			AnimOnHover = 8,
			// Token: 0x04039F4C RID: 237388
			AnimNormal
		}
	}
}
