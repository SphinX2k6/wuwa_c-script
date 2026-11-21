using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FirstPersonTurret.View
{
	// Token: 0x02004A61 RID: 19041
	[NullableContext(1)]
	[Nullable(0)]
	public class FirstPersonTurretView : UiTickViewBase
	{
		// Token: 0x0602FA51 RID: 195153 RVA: 0x00D4A878 File Offset: 0x00D48A78
		public FirstPersonTurretView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FA52 RID: 195154 RVA: 0x00D4A898 File Offset: 0x00D48A98
		protected unsafe override void OnRegisterComponent()
		{
			int num;
			Span<ValueTuple<int, Type>> span;
			int num2;
			if (Info.Instance.IsInTouch())
			{
				num = 8;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				return;
			}
			num2 = 7;
			List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
			num = 0;
			*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num++;
			*span[num] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num++;
			*span[num] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num++;
			*span[num] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num++;
			*span[num] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list2;
		}

		// Token: 0x0602FA53 RID: 195155 RVA: 0x00D4AAD8 File Offset: 0x00D48CD8
		protected override UniTask OnBeforeStartAsync()
		{
			FirstPersonTurretView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FirstPersonTurretView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA54 RID: 195156 RVA: 0x00D4AB1C File Offset: 0x00D48D1C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<ESkillButtonRefreshReason>(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Add<ESkillButtonType, int>(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonVisibleRefresh, new Action<ESkillButtonType>(this.OnSkillButtonVisibleRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonDynamicEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonDynamicEffectRefresh));
			EventSystem.Instance.Add<ESkillButtonType, int, int>(EEventName.OnSkillButtonCustomRefresh, new Action<ESkillButtonType, int, int>(this.OnSkillButtonCustomRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonIconPathRefresh, new Action<ESkillButtonType>(this.OnSkillButtonIconPathRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonLongPressRefresh, new Action<ESkillButtonType>(this.OnSkillButtonLongPressRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonExtraEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonExtraEffectRefresh));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x0602FA55 RID: 195157 RVA: 0x00D4AC7C File Offset: 0x00D48E7C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonVisibleRefresh, new Action<ESkillButtonType>(this.OnSkillButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDynamicEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCustomRefresh, new Action<ESkillButtonType, int, int>(this.OnSkillButtonCustomRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonIconPathRefresh, new Action<ESkillButtonType>(this.OnSkillButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonLongPressRefresh, new Action<ESkillButtonType>(this.OnSkillButtonLongPressRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonExtraEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonExtraEffectRefresh));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x0602FA56 RID: 195158 RVA: 0x00D4ADD9 File Offset: 0x00D48FD9
		protected override void OnAfterShow()
		{
			this.RefreshGamepadPsFeedback();
		}

		// Token: 0x0602FA57 RID: 195159 RVA: 0x00D4ADE4 File Offset: 0x00D48FE4
		protected override void OnTick(float delta)
		{
			this.InitPlayerData();
			this.RefreshKscPlayerHp();
			FirstPersonTurretRoleHpPanel roleHpPanel = this.RoleHpPanel;
			if (roleHpPanel != null)
			{
				roleHpPanel.Tick(delta);
			}
			foreach (FirstPersonTurretSkillItem firstPersonTurretSkillItem in this.SkillItemList)
			{
				firstPersonTurretSkillItem.Tick(delta);
			}
		}

		// Token: 0x0602FA58 RID: 195160 RVA: 0x00D4AE54 File Offset: 0x00D49054
		protected override void OnBeforeDestroy()
		{
			GamepadController.Instance.RemoveFeedbackReason(EGamepadPsFeedbackReason.FirstPersonTurret);
			this.RoleHpPanel = null;
			foreach (FirstPersonTurretSkillItem firstPersonTurretSkillItem in this.SkillItemList)
			{
				firstPersonTurretSkillItem.RestoreActionInput();
				firstPersonTurretSkillItem.Destroy(null);
			}
			this.SkillItemList.Clear();
			this.SkillItemMap.Clear();
			this.ClearKscPlayerData();
		}

		// Token: 0x0602FA59 RID: 195161 RVA: 0x00D4AEDC File Offset: 0x00D490DC
		private UniTask CreateRoleHpPanelAsync()
		{
			FirstPersonTurretView.<CreateRoleHpPanelAsync>d__17 <CreateRoleHpPanelAsync>d__;
			<CreateRoleHpPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRoleHpPanelAsync>d__.<>4__this = this;
			<CreateRoleHpPanelAsync>d__.<>1__state = -1;
			<CreateRoleHpPanelAsync>d__.<>t__builder.Start<FirstPersonTurretView.<CreateRoleHpPanelAsync>d__17>(ref <CreateRoleHpPanelAsync>d__);
			return <CreateRoleHpPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA5A RID: 195162 RVA: 0x00D4AF1F File Offset: 0x00D4911F
		private void ClearKscPlayerData()
		{
			this.AttrMap = null;
			this.LastSyncHp = null;
			this.LastSyncMaxHp = null;
		}

		// Token: 0x0602FA5B RID: 195163 RVA: 0x00D4AF40 File Offset: 0x00D49140
		private void InitPlayerData()
		{
			KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
			AKSC_Entity aksc_Entity = (curSubModel != null) ? curSubModel.KscPlayerEntity : null;
			if (aksc_Entity == null)
			{
				this.AttrMap = null;
				return;
			}
			UKSC_SkillComp skillComp = aksc_Entity.GetSkillComp();
			TMap<EKSC_AttrType, int> tmap;
			if (skillComp == null)
			{
				tmap = null;
			}
			else
			{
				UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
				tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
			}
			TMap<EKSC_AttrType, int> tmap2 = tmap;
			if (tmap2 == null)
			{
				this.AttrMap = null;
				return;
			}
			this.AttrMap = tmap2;
		}

		// Token: 0x0602FA5C RID: 195164 RVA: 0x00D4AFA0 File Offset: 0x00D491A0
		private void RefreshKscPlayerHp()
		{
			if (this.AttrMap == null)
			{
				return;
			}
			int num;
			int hp = this.AttrMap.TryGetValue(EKSC_AttrType.Life, out num) ? num : 0;
			int num2;
			int maxHp = this.AttrMap.TryGetValue(EKSC_AttrType.LifeMax, out num2) ? num2 : 0;
			this.TrySyncKscPlayerHp(hp, maxHp);
		}

		// Token: 0x0602FA5D RID: 195165 RVA: 0x00D4AFE8 File Offset: 0x00D491E8
		private void TrySyncKscPlayerHp(int hp, int maxHp)
		{
			int? num = this.LastSyncHp;
			if (num.GetValueOrDefault() == hp & num != null)
			{
				num = this.LastSyncMaxHp;
				if (num.GetValueOrDefault() == maxHp & num != null)
				{
					return;
				}
			}
			this.LastSyncHp = new int?(hp);
			this.LastSyncMaxHp = new int?(maxHp);
			FirstPersonTurretRoleHpPanel roleHpPanel = this.RoleHpPanel;
			if (roleHpPanel == null)
			{
				return;
			}
			roleHpPanel.Refresh((float)this.LastSyncHp.Value, (float)this.LastSyncMaxHp.Value);
		}

		// Token: 0x0602FA5E RID: 195166 RVA: 0x00D4B070 File Offset: 0x00D49270
		private UniTask CreateSkillItemsAsync()
		{
			FirstPersonTurretView.<CreateSkillItemsAsync>d__22 <CreateSkillItemsAsync>d__;
			<CreateSkillItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSkillItemsAsync>d__.<>4__this = this;
			<CreateSkillItemsAsync>d__.<>1__state = -1;
			<CreateSkillItemsAsync>d__.<>t__builder.Start<FirstPersonTurretView.<CreateSkillItemsAsync>d__22>(ref <CreateSkillItemsAsync>d__);
			return <CreateSkillItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA5F RID: 195167 RVA: 0x00D4B0B4 File Offset: 0x00D492B4
		private UniTask CreateSkillItemAsync([Nullable(2)] UUIButtonComponent button, FirstPersonTurretSkillItemParam param)
		{
			FirstPersonTurretView.<CreateSkillItemAsync>d__23 <CreateSkillItemAsync>d__;
			<CreateSkillItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSkillItemAsync>d__.<>4__this = this;
			<CreateSkillItemAsync>d__.button = button;
			<CreateSkillItemAsync>d__.param = param;
			<CreateSkillItemAsync>d__.<>1__state = -1;
			<CreateSkillItemAsync>d__.<>t__builder.Start<FirstPersonTurretView.<CreateSkillItemAsync>d__23>(ref <CreateSkillItemAsync>d__);
			return <CreateSkillItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FA60 RID: 195168 RVA: 0x00D4B107 File Offset: 0x00D49307
		private void RefreshAllSkillItems()
		{
			this.RefreshSkillItemsByButtonType(ESkillButtonType.攻击);
			this.RefreshSkillItemsByButtonType(ESkillButtonType.技能1);
			this.RefreshSkillItemsByButtonType(ESkillButtonType.大招);
		}

		// Token: 0x0602FA61 RID: 195169 RVA: 0x00D4B120 File Offset: 0x00D49320
		private void RefreshSkillItemsByButtonType(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(buttonType);
				if (skillButtonDataByButton == null || skillButtonDataByButton.GetSkillId() == 0)
				{
					skillItem.Deactivate();
					return;
				}
				skillItem.Refresh(skillButtonDataByButton);
			});
		}

		// Token: 0x0602FA62 RID: 195170 RVA: 0x00D4B154 File Offset: 0x00D49354
		private void ForEachSkillItem(ESkillButtonType buttonType, Action<FirstPersonTurretSkillItem> callback)
		{
			List<FirstPersonTurretSkillItem> list;
			if (!this.SkillItemMap.TryGetValue(buttonType, out list))
			{
				return;
			}
			foreach (FirstPersonTurretSkillItem obj in list)
			{
				callback(obj);
			}
		}

		// Token: 0x0602FA63 RID: 195171 RVA: 0x00D4B1B4 File Offset: 0x00D493B4
		private void OnSignoutClicked()
		{
			Action onExitClicked = this.OnExitClicked;
			if (onExitClicked == null)
			{
				return;
			}
			onExitClicked();
		}

		// Token: 0x0602FA64 RID: 195172 RVA: 0x00D4B1C6 File Offset: 0x00D493C6
		private void RefreshGamepadPsFeedback()
		{
			if (Info.Instance.IsInGamepad())
			{
				GamepadController.Instance.TryAddFeedbackReason(EGamepadPsFeedbackReason.FirstPersonTurret, "FirstPersonTurret");
				return;
			}
			GamepadController.Instance.RemoveFeedbackReason(EGamepadPsFeedbackReason.FirstPersonTurret);
		}

		// Token: 0x0602FA65 RID: 195173 RVA: 0x00D4B1F0 File Offset: 0x00D493F0
		private void OnInputControllerChange(EInputControllerType _1, EInputControllerType _2)
		{
			this.RefreshGamepadPsFeedback();
		}

		// Token: 0x0602FA66 RID: 195174 RVA: 0x00D4B1F8 File Offset: 0x00D493F8
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason refreshReason)
		{
			this.RefreshAllSkillItems();
		}

		// Token: 0x0602FA67 RID: 195175 RVA: 0x00D4B200 File Offset: 0x00D49400
		private void OnSkillButtonEnableRefresh(ESkillButtonType buttonType, int extendCoolDown)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				if (skillItem.GetSkillButtonData() == null)
				{
					return;
				}
				skillItem.RefreshEnable(false);
			});
		}

		// Token: 0x0602FA68 RID: 195176 RVA: 0x00D4B228 File Offset: 0x00D49428
		private void OnSkillButtonVisibleRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				if (skillItem.GetSkillButtonData() == null)
				{
					return;
				}
				skillItem.RefreshVisible();
				skillItem.RefreshKey();
			});
		}

		// Token: 0x0602FA69 RID: 195177 RVA: 0x00D4B250 File Offset: 0x00D49450
		private void OnSkillButtonDynamicEffectRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				if (skillItem.GetSkillButtonData() == null)
				{
					return;
				}
				skillItem.RefreshDynamicEffect();
			});
		}

		// Token: 0x0602FA6A RID: 195178 RVA: 0x00D4B278 File Offset: 0x00D49478
		private void OnSkillButtonCustomRefresh(ESkillButtonType buttonType, int from, int param)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				if (skillItem.GetSkillButtonData() == null)
				{
					return;
				}
				skillItem.RefreshCustomHdData(from, param);
			});
		}

		// Token: 0x0602FA6B RID: 195179 RVA: 0x00D4B2AC File Offset: 0x00D494AC
		private void OnSkillButtonSkillIdRefresh(ESkillButtonType buttonType)
		{
			this.RefreshSkillItemsByButtonType(buttonType);
		}

		// Token: 0x0602FA6C RID: 195180 RVA: 0x00D4B2B5 File Offset: 0x00D494B5
		private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshAttribute(true);
			});
		}

		// Token: 0x0602FA6D RID: 195181 RVA: 0x00D4B2DD File Offset: 0x00D494DD
		private void OnSkillButtonIconPathRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshSkillIcon();
				skillItem.RefreshSkillName();
			});
		}

		// Token: 0x0602FA6E RID: 195182 RVA: 0x00D4B305 File Offset: 0x00D49505
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshSkillCoolDown();
			});
		}

		// Token: 0x0602FA6F RID: 195183 RVA: 0x00D4B32D File Offset: 0x00D4952D
		private void OnSkillButtonLongPressRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshSkillButtonLongPress();
				skillItem.RefreshConfigLongPress(-1, 0);
			});
		}

		// Token: 0x0602FA70 RID: 195184 RVA: 0x00D4B355 File Offset: 0x00D49555
		private void OnSkillButtonExtraEffectRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshExtraEffect();
			});
		}

		// Token: 0x040194D8 RID: 103640
		[Nullable(2)]
		public Action OnExitClicked;

		// Token: 0x040194D9 RID: 103641
		private const string PS_FEEDBACK_ID = "FirstPersonTurret";

		// Token: 0x040194DA RID: 103642
		[Nullable(2)]
		private UUIButtonComponent ExitButton;

		// Token: 0x040194DB RID: 103643
		private readonly List<FirstPersonTurretSkillItem> SkillItemList = new List<FirstPersonTurretSkillItem>();

		// Token: 0x040194DC RID: 103644
		private readonly Dictionary<ESkillButtonType, List<FirstPersonTurretSkillItem>> SkillItemMap = new Dictionary<ESkillButtonType, List<FirstPersonTurretSkillItem>>();

		// Token: 0x040194DD RID: 103645
		[Nullable(2)]
		private FirstPersonTurretRoleHpPanel RoleHpPanel;

		// Token: 0x040194DE RID: 103646
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> AttrMap;

		// Token: 0x040194DF RID: 103647
		private int? LastSyncHp;

		// Token: 0x040194E0 RID: 103648
		private int? LastSyncMaxHp;
	}
}
