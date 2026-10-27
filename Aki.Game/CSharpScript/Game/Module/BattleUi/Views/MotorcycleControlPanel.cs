using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D9A RID: 23962
	public class MotorcycleControlPanel : MotorcycleControlPanelBase
	{
		// Token: 0x0603CD20 RID: 249120 RVA: 0x00E9B218 File Offset: 0x00E99418
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CD21 RID: 249121 RVA: 0x00E9B2C4 File Offset: 0x00E994C4
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD22 RID: 249122 RVA: 0x00E9B308 File Offset: 0x00E99508
		public UniTask NewAllKeyItems()
		{
			MotorcycleControlPanel.<NewAllKeyItems>d__6 <NewAllKeyItems>d__;
			<NewAllKeyItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllKeyItems>d__.<>4__this = this;
			<NewAllKeyItems>d__.<>1__state = -1;
			<NewAllKeyItems>d__.<>t__builder.Start<MotorcycleControlPanel.<NewAllKeyItems>d__6>(ref <NewAllKeyItems>d__);
			return <NewAllKeyItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD23 RID: 249123 RVA: 0x00E9B34C File Offset: 0x00E9954C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<InputMultiKeyItemGroup> NewKeyItem(AActor rootActor, int inputIndex)
		{
			MotorcycleControlPanel.<NewKeyItem>d__7 <NewKeyItem>d__;
			<NewKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<InputMultiKeyItemGroup>.Create();
			<NewKeyItem>d__.<>4__this = this;
			<NewKeyItem>d__.rootActor = rootActor;
			<NewKeyItem>d__.<>1__state = -1;
			<NewKeyItem>d__.<>t__builder.Start<MotorcycleControlPanel.<NewKeyItem>d__7>(ref <NewKeyItem>d__);
			return <NewKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD24 RID: 249124 RVA: 0x00E9B397 File Offset: 0x00E99597
		private void RefreshAllKeyItems()
		{
			this.RefreshDrift();
			this.RefreshBulletJump();
			this.RefreshGetOff();
		}

		// Token: 0x0603CD25 RID: 249125 RVA: 0x00E9B3AB File Offset: 0x00E995AB
		private void RefreshDrift()
		{
			this.RefreshKeyItem(0, ESkillButtonType.跳跃, "载具漂移", "HotKeyText_MotorDrift_Name", null, null);
		}

		// Token: 0x0603CD26 RID: 249126 RVA: 0x00E9B3C1 File Offset: 0x00E995C1
		private void RefreshBulletJump()
		{
			this.RefreshKeyItem(1, ESkillButtonType.技能1, "载具子弹跳", null, "载具子弹跳1", "HotKeyText_MotorJump_Name");
		}

		// Token: 0x0603CD27 RID: 249127 RVA: 0x00E9B3DB File Offset: 0x00E995DB
		private void RefreshGetOff()
		{
			this.RefreshKeyItem(2, ESkillButtonType.大招, "载具退场技和下车", "HotKeyText_MotorOff_Name", null, null);
		}

		// Token: 0x0603CD28 RID: 249128 RVA: 0x00E9B3F4 File Offset: 0x00E995F4
		[NullableContext(2)]
		private void RefreshKeyItem(int index, ESkillButtonType buttonType, [Nullable(1)] string actionName, string descId = null, string actionName2 = null, string descId2 = null)
		{
			InputMultiKeyItemGroup inputMultiKeyItemGroup = this.KeyItemList[index];
			InputActionOrAxisKeyItemGroup inputActionOrAxisKeyItemGroup = new InputActionOrAxisKeyItemGroup();
			inputActionOrAxisKeyItemGroup.SingleActionOrAxisKeyItem = new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = actionName,
				DescriptionId = descId,
				Index = new int?(0)
			};
			InputActionOrAxisKeyItem doubleActionOrAxisKeyItem;
			if (string.IsNullOrEmpty(actionName2))
			{
				doubleActionOrAxisKeyItem = null;
			}
			else
			{
				InputActionOrAxisKeyItem inputActionOrAxisKeyItem = new InputActionOrAxisKeyItem();
				inputActionOrAxisKeyItem.ActionOrAxisName = actionName2;
				inputActionOrAxisKeyItem.DescriptionId = descId2;
				doubleActionOrAxisKeyItem = inputActionOrAxisKeyItem;
				inputActionOrAxisKeyItem.Index = new int?(0);
			}
			inputActionOrAxisKeyItemGroup.DoubleActionOrAxisKeyItem = doubleActionOrAxisKeyItem;
			inputActionOrAxisKeyItemGroup.LinkString = "/";
			InputActionOrAxisKeyItemGroup inputActionOrAxisKeyItemGroup2 = inputActionOrAxisKeyItemGroup;
			inputMultiKeyItemGroup.Refresh(inputActionOrAxisKeyItemGroup2);
			this.RefreshKeyItemVisibleByButtonType(buttonType, index);
		}

		// Token: 0x0603CD29 RID: 249129 RVA: 0x00E9B488 File Offset: 0x00E99688
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			foreach (InputMultiKeyItemGroup inputMultiKeyItemGroup in this.KeyItemList)
			{
				inputMultiKeyItemGroup.Destroy(null);
			}
			this.KeyItemList.Clear();
			this.RemoveEvents();
		}

		// Token: 0x0603CD2A RID: 249130 RVA: 0x00E9B4F0 File Offset: 0x00E996F0
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.BattleUiMotorcycleBulletJumpChanged, new Action(this.OnMotorcycleBulletJumpChanged));
			EventSystem.Instance.Add<ESkillButtonRefreshReason>(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Add<ESkillButtonType, int>(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Add(EEventName.OnSkillButtonPanelVisibleChange, new Action(this.OnSkillButtonPanelVisibleChange));
			EventSystem.Instance.Add<int, bool>(EEventName.BattleUiMotorcycleFlyTagChanged, new Action<int, bool>(this.OnMotorFlyStateChanged));
			EventSystem.Instance.Add<int, bool>(EEventName.BattleUiMotorcycleCannonTagChanged, new Action<int, bool>(this.OnMotorCannonTagChanged));
		}

		// Token: 0x0603CD2B RID: 249131 RVA: 0x00E9B5C4 File Offset: 0x00E997C4
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleBulletJumpChanged, new Action(this.OnMotorcycleBulletJumpChanged));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonPanelVisibleChange, new Action(this.OnSkillButtonPanelVisibleChange));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleFlyTagChanged, new Action<int, bool>(this.OnMotorFlyStateChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleCannonTagChanged, new Action<int, bool>(this.OnMotorCannonTagChanged));
		}

		// Token: 0x0603CD2C RID: 249132 RVA: 0x00E9B695 File Offset: 0x00E99895
		private void OnMotorcycleBulletJumpChanged()
		{
			this.RefreshAllKeyItems();
		}

		// Token: 0x0603CD2D RID: 249133 RVA: 0x00E9B69D File Offset: 0x00E9989D
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason eSkillButtonRefreshReason)
		{
			this.RefreshAllKeyItems();
		}

		// Token: 0x0603CD2E RID: 249134 RVA: 0x00E9B6A5 File Offset: 0x00E998A5
		private void OnSkillButtonEnableRefresh(ESkillButtonType buttonType, int extendCoolDown)
		{
			this.RefreshKeyItemByButtonType(buttonType);
		}

		// Token: 0x0603CD2F RID: 249135 RVA: 0x00E9B6AE File Offset: 0x00E998AE
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			this.RefreshKeyItemByButtonType(buttonType);
		}

		// Token: 0x0603CD30 RID: 249136 RVA: 0x00E9B6B7 File Offset: 0x00E998B7
		private void OnSkillButtonPanelVisibleChange()
		{
			base.SetVisible(1, BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.SkillButton));
		}

		// Token: 0x0603CD31 RID: 249137 RVA: 0x00E9B6D1 File Offset: 0x00E998D1
		private void OnMotorFlyStateChanged(int tagId, bool tagExists)
		{
			if (tagId == GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中"])
			{
				this.IsMotorInAir = tagExists;
				this.RefreshKeyItemByButtonType(ESkillButtonType.跳跃);
			}
		}

		// Token: 0x0603CD32 RID: 249138 RVA: 0x00E9B6F3 File Offset: 0x00E998F3
		private void OnMotorCannonTagChanged(int tagId, bool tagExists)
		{
			if (tagId == GameplayTagDefine.EGameplayTagId["载具.摩托.浮游炮.自动开启"])
			{
				this.IsCanonState = tagExists;
				this.RefreshKeyItemByButtonType(ESkillButtonType.技能1);
			}
		}

		// Token: 0x0603CD33 RID: 249139 RVA: 0x00E9B715 File Offset: 0x00E99915
		private void RefreshKeyItemByButtonType(ESkillButtonType buttonType)
		{
			if (buttonType == ESkillButtonType.跳跃)
			{
				this.RefreshKeyItemVisibleByButtonType(buttonType, 0);
				return;
			}
			if (buttonType == ESkillButtonType.技能1)
			{
				this.RefreshKeyItemVisibleByButtonType(buttonType, 1);
				return;
			}
			if (buttonType == ESkillButtonType.大招)
			{
				this.RefreshKeyItemVisibleByButtonType(buttonType, 2);
			}
		}

		// Token: 0x0603CD34 RID: 249140 RVA: 0x00E9B740 File Offset: 0x00E99940
		private void RefreshKeyItemVisibleByButtonType(ESkillButtonType buttonType, int index)
		{
			bool active;
			if (!BattleUiModel.Instance.MotorcycleData.IsShowBulletJumpLeftClick)
			{
				active = false;
			}
			else if (buttonType == ESkillButtonType.跳跃 && this.IsMotorInAir)
			{
				active = false;
			}
			else if (buttonType == ESkillButtonType.技能1 && this.IsCanonState)
			{
				active = false;
			}
			else
			{
				SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(buttonType);
				active = (skillButtonDataByButton != null && skillButtonDataByButton.IsEnable());
			}
			this.KeyItemList[index].SetActive(active);
		}

		// Token: 0x0401FAEA RID: 129770
		[Nullable(1)]
		private readonly List<InputMultiKeyItemGroup> KeyItemList = new List<InputMultiKeyItemGroup>();

		// Token: 0x0401FAEB RID: 129771
		private bool IsMotorInAir;

		// Token: 0x0401FAEC RID: 129772
		private bool IsCanonState;

		// Token: 0x0200C068 RID: 49256
		private enum EChildType
		{
			// Token: 0x0403A0EB RID: 237803
			LayoutItem,
			// Token: 0x0403A0EC RID: 237804
			Item1,
			// Token: 0x0403A0ED RID: 237805
			Item2,
			// Token: 0x0403A0EE RID: 237806
			Item3
		}
	}
}
