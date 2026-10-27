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
	// Token: 0x02005A85 RID: 23173
	[NullableContext(1)]
	[Nullable(0)]
	public class FirstPersonTurretView : UiTickViewBase
	{
		// Token: 0x0603AB08 RID: 240392 RVA: 0x00DFA2E4 File Offset: 0x00DF84E4
		public FirstPersonTurretView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AB09 RID: 240393 RVA: 0x00DFA304 File Offset: 0x00DF8504
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

		// Token: 0x0603AB0A RID: 240394 RVA: 0x00DFA544 File Offset: 0x00DF8744
		protected override UniTask OnBeforeStartAsync()
		{
			FirstPersonTurretView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FirstPersonTurretView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AB0B RID: 240395 RVA: 0x00DFA588 File Offset: 0x00DF8788
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

		// Token: 0x0603AB0C RID: 240396 RVA: 0x00DFA6E8 File Offset: 0x00DF88E8
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

		// Token: 0x0603AB0D RID: 240397 RVA: 0x00DFA845 File Offset: 0x00DF8A45
		protected override void OnAfterShow()
		{
			this.RefreshGamepadPsFeedback();
		}

		// Token: 0x0603AB0E RID: 240398 RVA: 0x00DFA850 File Offset: 0x00DF8A50
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

		// Token: 0x0603AB0F RID: 240399 RVA: 0x00DFA8C0 File Offset: 0x00DF8AC0
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

		// Token: 0x0603AB10 RID: 240400 RVA: 0x00DFA948 File Offset: 0x00DF8B48
		private UniTask CreateRoleHpPanelAsync()
		{
			FirstPersonTurretView.<CreateRoleHpPanelAsync>d__17 <CreateRoleHpPanelAsync>d__;
			<CreateRoleHpPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRoleHpPanelAsync>d__.<>4__this = this;
			<CreateRoleHpPanelAsync>d__.<>1__state = -1;
			<CreateRoleHpPanelAsync>d__.<>t__builder.Start<FirstPersonTurretView.<CreateRoleHpPanelAsync>d__17>(ref <CreateRoleHpPanelAsync>d__);
			return <CreateRoleHpPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AB11 RID: 240401 RVA: 0x00DFA98B File Offset: 0x00DF8B8B
		private void ClearKscPlayerData()
		{
			this.AttrMap = null;
			this.LastSyncHp = null;
			this.LastSyncMaxHp = null;
		}

		// Token: 0x0603AB12 RID: 240402 RVA: 0x00DFA9AC File Offset: 0x00DF8BAC
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

		// Token: 0x0603AB13 RID: 240403 RVA: 0x00DFAA0C File Offset: 0x00DF8C0C
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

		// Token: 0x0603AB14 RID: 240404 RVA: 0x00DFAA54 File Offset: 0x00DF8C54
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

		// Token: 0x0603AB15 RID: 240405 RVA: 0x00DFAADC File Offset: 0x00DF8CDC
		private UniTask CreateSkillItemsAsync()
		{
			FirstPersonTurretView.<CreateSkillItemsAsync>d__22 <CreateSkillItemsAsync>d__;
			<CreateSkillItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSkillItemsAsync>d__.<>4__this = this;
			<CreateSkillItemsAsync>d__.<>1__state = -1;
			<CreateSkillItemsAsync>d__.<>t__builder.Start<FirstPersonTurretView.<CreateSkillItemsAsync>d__22>(ref <CreateSkillItemsAsync>d__);
			return <CreateSkillItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AB16 RID: 240406 RVA: 0x00DFAB20 File Offset: 0x00DF8D20
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

		// Token: 0x0603AB17 RID: 240407 RVA: 0x00DFAB73 File Offset: 0x00DF8D73
		private void RefreshAllSkillItems()
		{
			this.RefreshSkillItemsByButtonType(ESkillButtonType.攻击);
			this.RefreshSkillItemsByButtonType(ESkillButtonType.技能1);
			this.RefreshSkillItemsByButtonType(ESkillButtonType.大招);
		}

		// Token: 0x0603AB18 RID: 240408 RVA: 0x00DFAB8C File Offset: 0x00DF8D8C
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

		// Token: 0x0603AB19 RID: 240409 RVA: 0x00DFABC0 File Offset: 0x00DF8DC0
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

		// Token: 0x0603AB1A RID: 240410 RVA: 0x00DFAC20 File Offset: 0x00DF8E20
		private void OnSignoutClicked()
		{
			Action onExitClicked = this.OnExitClicked;
			if (onExitClicked == null)
			{
				return;
			}
			onExitClicked();
		}

		// Token: 0x0603AB1B RID: 240411 RVA: 0x00DFAC32 File Offset: 0x00DF8E32
		private void RefreshGamepadPsFeedback()
		{
			if (Info.Instance.IsInGamepad())
			{
				GamepadController.Instance.TryAddFeedbackReason(EGamepadPsFeedbackReason.FirstPersonTurret, "FirstPersonTurret");
				return;
			}
			GamepadController.Instance.RemoveFeedbackReason(EGamepadPsFeedbackReason.FirstPersonTurret);
		}

		// Token: 0x0603AB1C RID: 240412 RVA: 0x00DFAC5C File Offset: 0x00DF8E5C
		private void OnInputControllerChange(EInputControllerType _1, EInputControllerType _2)
		{
			this.RefreshGamepadPsFeedback();
		}

		// Token: 0x0603AB1D RID: 240413 RVA: 0x00DFAC64 File Offset: 0x00DF8E64
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason refreshReason)
		{
			this.RefreshAllSkillItems();
		}

		// Token: 0x0603AB1E RID: 240414 RVA: 0x00DFAC6C File Offset: 0x00DF8E6C
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

		// Token: 0x0603AB1F RID: 240415 RVA: 0x00DFAC94 File Offset: 0x00DF8E94
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

		// Token: 0x0603AB20 RID: 240416 RVA: 0x00DFACBC File Offset: 0x00DF8EBC
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

		// Token: 0x0603AB21 RID: 240417 RVA: 0x00DFACE4 File Offset: 0x00DF8EE4
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

		// Token: 0x0603AB22 RID: 240418 RVA: 0x00DFAD18 File Offset: 0x00DF8F18
		private void OnSkillButtonSkillIdRefresh(ESkillButtonType buttonType)
		{
			this.RefreshSkillItemsByButtonType(buttonType);
		}

		// Token: 0x0603AB23 RID: 240419 RVA: 0x00DFAD21 File Offset: 0x00DF8F21
		private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshAttribute(true);
			});
		}

		// Token: 0x0603AB24 RID: 240420 RVA: 0x00DFAD49 File Offset: 0x00DF8F49
		private void OnSkillButtonIconPathRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshSkillIcon();
				skillItem.RefreshSkillName();
			});
		}

		// Token: 0x0603AB25 RID: 240421 RVA: 0x00DFAD71 File Offset: 0x00DF8F71
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshSkillCoolDown();
			});
		}

		// Token: 0x0603AB26 RID: 240422 RVA: 0x00DFAD99 File Offset: 0x00DF8F99
		private void OnSkillButtonLongPressRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshSkillButtonLongPress();
				skillItem.RefreshConfigLongPress(-1, 0);
			});
		}

		// Token: 0x0603AB27 RID: 240423 RVA: 0x00DFADC1 File Offset: 0x00DF8FC1
		private void OnSkillButtonExtraEffectRefresh(ESkillButtonType buttonType)
		{
			this.ForEachSkillItem(buttonType, delegate(FirstPersonTurretSkillItem skillItem)
			{
				skillItem.RefreshExtraEffect();
			});
		}

		// Token: 0x0401EA31 RID: 125489
		[Nullable(2)]
		public Action OnExitClicked;

		// Token: 0x0401EA32 RID: 125490
		private const string PS_FEEDBACK_ID = "FirstPersonTurret";

		// Token: 0x0401EA33 RID: 125491
		[Nullable(2)]
		private UUIButtonComponent ExitButton;

		// Token: 0x0401EA34 RID: 125492
		private readonly List<FirstPersonTurretSkillItem> SkillItemList = new List<FirstPersonTurretSkillItem>();

		// Token: 0x0401EA35 RID: 125493
		private readonly Dictionary<ESkillButtonType, List<FirstPersonTurretSkillItem>> SkillItemMap = new Dictionary<ESkillButtonType, List<FirstPersonTurretSkillItem>>();

		// Token: 0x0401EA36 RID: 125494
		[Nullable(2)]
		private FirstPersonTurretRoleHpPanel RoleHpPanel;

		// Token: 0x0401EA37 RID: 125495
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> AttrMap;

		// Token: 0x0401EA38 RID: 125496
		private int? LastSyncHp;

		// Token: 0x0401EA39 RID: 125497
		private int? LastSyncMaxHp;
	}
}
