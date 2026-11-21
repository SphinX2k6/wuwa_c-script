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
	// Token: 0x02004D7C RID: 19836
	public class MotorcycleControlPanel : MotorcycleControlPanelBase
	{
		// Token: 0x06031C7D RID: 203901 RVA: 0x00DEBAD0 File Offset: 0x00DE9CD0
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

		// Token: 0x06031C7E RID: 203902 RVA: 0x00DEBB7C File Offset: 0x00DE9D7C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C7F RID: 203903 RVA: 0x00DEBBC0 File Offset: 0x00DE9DC0
		public UniTask NewAllKeyItems()
		{
			MotorcycleControlPanel.<NewAllKeyItems>d__6 <NewAllKeyItems>d__;
			<NewAllKeyItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllKeyItems>d__.<>4__this = this;
			<NewAllKeyItems>d__.<>1__state = -1;
			<NewAllKeyItems>d__.<>t__builder.Start<MotorcycleControlPanel.<NewAllKeyItems>d__6>(ref <NewAllKeyItems>d__);
			return <NewAllKeyItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031C80 RID: 203904 RVA: 0x00DEBC04 File Offset: 0x00DE9E04
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

		// Token: 0x06031C81 RID: 203905 RVA: 0x00DEBC4F File Offset: 0x00DE9E4F
		private void RefreshAllKeyItems()
		{
			this.RefreshDrift();
			this.RefreshBulletJump();
			this.RefreshGetOff();
		}

		// Token: 0x06031C82 RID: 203906 RVA: 0x00DEBC63 File Offset: 0x00DE9E63
		private void RefreshDrift()
		{
			this.RefreshKeyItem(0, ESkillButtonType.跳跃, "载具漂移", "HotKeyText_MotorDrift_Name", null, null);
		}

		// Token: 0x06031C83 RID: 203907 RVA: 0x00DEBC79 File Offset: 0x00DE9E79
		private void RefreshBulletJump()
		{
			this.RefreshKeyItem(1, ESkillButtonType.技能1, "载具子弹跳", null, "载具子弹跳1", "HotKeyText_MotorJump_Name");
		}

		// Token: 0x06031C84 RID: 203908 RVA: 0x00DEBC93 File Offset: 0x00DE9E93
		private void RefreshGetOff()
		{
			this.RefreshKeyItem(2, ESkillButtonType.大招, "载具退场技和下车", "HotKeyText_MotorOff_Name", null, null);
		}

		// Token: 0x06031C85 RID: 203909 RVA: 0x00DEBCAC File Offset: 0x00DE9EAC
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

		// Token: 0x06031C86 RID: 203910 RVA: 0x00DEBD40 File Offset: 0x00DE9F40
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

		// Token: 0x06031C87 RID: 203911 RVA: 0x00DEBDA8 File Offset: 0x00DE9FA8
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

		// Token: 0x06031C88 RID: 203912 RVA: 0x00DEBE7C File Offset: 0x00DEA07C
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

		// Token: 0x06031C89 RID: 203913 RVA: 0x00DEBF4D File Offset: 0x00DEA14D
		private void OnMotorcycleBulletJumpChanged()
		{
			this.RefreshAllKeyItems();
		}

		// Token: 0x06031C8A RID: 203914 RVA: 0x00DEBF55 File Offset: 0x00DEA155
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason eSkillButtonRefreshReason)
		{
			this.RefreshAllKeyItems();
		}

		// Token: 0x06031C8B RID: 203915 RVA: 0x00DEBF5D File Offset: 0x00DEA15D
		private void OnSkillButtonEnableRefresh(ESkillButtonType buttonType, int extendCoolDown)
		{
			this.RefreshKeyItemByButtonType(buttonType);
		}

		// Token: 0x06031C8C RID: 203916 RVA: 0x00DEBF66 File Offset: 0x00DEA166
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			this.RefreshKeyItemByButtonType(buttonType);
		}

		// Token: 0x06031C8D RID: 203917 RVA: 0x00DEBF6F File Offset: 0x00DEA16F
		private void OnSkillButtonPanelVisibleChange()
		{
			base.SetVisible(1, BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.SkillButton));
		}

		// Token: 0x06031C8E RID: 203918 RVA: 0x00DEBF89 File Offset: 0x00DEA189
		private void OnMotorFlyStateChanged(int tagId, bool tagExists)
		{
			if (tagId == GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中"])
			{
				this.IsMotorInAir = tagExists;
				this.RefreshKeyItemByButtonType(ESkillButtonType.跳跃);
			}
		}

		// Token: 0x06031C8F RID: 203919 RVA: 0x00DEBFAB File Offset: 0x00DEA1AB
		private void OnMotorCannonTagChanged(int tagId, bool tagExists)
		{
			if (tagId == GameplayTagDefine.EGameplayTagId["载具.摩托.浮游炮.自动开启"])
			{
				this.IsCanonState = tagExists;
				this.RefreshKeyItemByButtonType(ESkillButtonType.技能1);
			}
		}

		// Token: 0x06031C90 RID: 203920 RVA: 0x00DEBFCD File Offset: 0x00DEA1CD
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

		// Token: 0x06031C91 RID: 203921 RVA: 0x00DEBFF8 File Offset: 0x00DEA1F8
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

		// Token: 0x0401A5A2 RID: 107938
		[Nullable(1)]
		private readonly List<InputMultiKeyItemGroup> KeyItemList = new List<InputMultiKeyItemGroup>();

		// Token: 0x0401A5A3 RID: 107939
		private bool IsMotorInAir;

		// Token: 0x0401A5A4 RID: 107940
		private bool IsCanonState;

		// Token: 0x0200AA6E RID: 43630
		private enum EChildType
		{
			// Token: 0x04034AAE RID: 215726
			LayoutItem,
			// Token: 0x04034AAF RID: 215727
			Item1,
			// Token: 0x04034AB0 RID: 215728
			Item2,
			// Token: 0x04034AB1 RID: 215729
			Item3
		}
	}
}
