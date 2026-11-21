using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E22 RID: 20002
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlGroundView : UiViewBase
	{
		// Token: 0x0603250B RID: 206091 RVA: 0x00E1B07E File Offset: 0x00E1927E
		[NullableContext(1)]
		public SwordControlGroundView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603250C RID: 206092 RVA: 0x00E1B098 File Offset: 0x00E19298
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603250D RID: 206093 RVA: 0x00E1B124 File Offset: 0x00E19324
		protected override UniTask OnBeforeStartAsync()
		{
			SwordControlGroundView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SwordControlGroundView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603250E RID: 206094 RVA: 0x00E1B167 File Offset: 0x00E19367
		protected override void OnBeforeShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlGroundView.HideBattleUiChildernList, false, true, 0);
		}

		// Token: 0x0603250F RID: 206095 RVA: 0x00E1B181 File Offset: 0x00E19381
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlGroundView.HideBattleUiChildernList, true, true, 0);
		}

		// Token: 0x06032510 RID: 206096 RVA: 0x00E1B19C File Offset: 0x00E1939C
		protected override void OnStart()
		{
			base.OnStart();
			this.SwordIconLayout = new GenericLayout<GroundSwordStackItem, ESwordStackState>(base.GetHorizontalLayout(1), new Func<GroundSwordStackItem>(this.CreateSwordIconItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			this.RefreshRoleData();
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x06032511 RID: 206097 RVA: 0x00E1B204 File Offset: 0x00E19404
		protected override void OnBeforeDestroy()
		{
			this.RemoveListenSwordStackTagCountChanged();
			this.RemoveListenLockedTargetTagChanged();
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
			SwordControlGroundAttackButton groundAttackButton = this.GroundAttackButton;
			if (groundAttackButton != null)
			{
				groundAttackButton.Destroy(null);
			}
			this.GroundAttackButton = null;
			this.RoleData = null;
			this.SwordIconLayout = null;
		}

		// Token: 0x06032512 RID: 206098 RVA: 0x00E1B260 File Offset: 0x00E19460
		private void OnBattleUiCurRoleDataChanged(int newEntityId, int oldEntityId)
		{
			this.RefreshRoleData();
		}

		// Token: 0x06032513 RID: 206099 RVA: 0x00E1B268 File Offset: 0x00E19468
		private void RefreshRoleData()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (this.RoleData == curRoleData)
			{
				this.RefreshSwordStackCountUI(this.GetCurrentSwordUnlockStackCount(), this.GetCurrentLockedTargetCount(), true);
				this.RefreshAttackButtonUI(this.GetCurrentLockedTargetCount() > 0, true);
				return;
			}
			this.RemoveListenSwordStackTagCountChanged();
			this.RemoveListenLockedTargetTagChanged();
			this.RoleData = curRoleData;
			this.ListenForSwordStackTagCountChanged();
			this.ListenForLockedTargetTagChanged();
			this.RefreshSwordStackCountUI(this.GetCurrentSwordUnlockStackCount(), this.GetCurrentLockedTargetCount(), true);
			this.RefreshAttackButtonUI(this.GetCurrentLockedTargetCount() > 0, true);
		}

		// Token: 0x06032514 RID: 206100 RVA: 0x00E1B2F0 File Offset: 0x00E194F0
		private void ListenForSwordStackTagCountChanged()
		{
			BattleUiRoleData roleData = this.RoleData;
			BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
			if (baseTagComponent == null)
			{
				return;
			}
			this.SwordStackTagTask = baseTagComponent.ListenForTagAnyCountChanged(SwordControlGroundView.SwordUnlockStackTagId, new BaseTagComponent.TTagChangedCallback(this.OnSwordStackTagCountChanged));
		}

		// Token: 0x06032515 RID: 206101 RVA: 0x00E1B331 File Offset: 0x00E19531
		private void RemoveListenSwordStackTagCountChanged()
		{
			ITagTask swordStackTagTask = this.SwordStackTagTask;
			if (swordStackTagTask != null)
			{
				swordStackTagTask.EndTask();
			}
			this.SwordStackTagTask = null;
		}

		// Token: 0x06032516 RID: 206102 RVA: 0x00E1B34B File Offset: 0x00E1954B
		private void OnSwordStackTagCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshSwordStackCountUI(count, this.GetCurrentLockedTargetCount(), false);
		}

		// Token: 0x06032517 RID: 206103 RVA: 0x00E1B35C File Offset: 0x00E1955C
		private void ListenForLockedTargetTagChanged()
		{
			BattleUiRoleData roleData = this.RoleData;
			BaseTagComponent baseTagComponent = (roleData != null) ? roleData.GameplayTagComponent : null;
			if (baseTagComponent == null)
			{
				return;
			}
			this.LockedTargetTagTask = baseTagComponent.ListenForTagAnyCountChanged(SwordControlGroundView.SwordLockedTargetCountTagId, new BaseTagComponent.TTagChangedCallback(this.OnLockedTargetTagChanged));
		}

		// Token: 0x06032518 RID: 206104 RVA: 0x00E1B39D File Offset: 0x00E1959D
		private void RemoveListenLockedTargetTagChanged()
		{
			ITagTask lockedTargetTagTask = this.LockedTargetTagTask;
			if (lockedTargetTagTask != null)
			{
				lockedTargetTagTask.EndTask();
			}
			this.LockedTargetTagTask = null;
		}

		// Token: 0x06032519 RID: 206105 RVA: 0x00E1B3B7 File Offset: 0x00E195B7
		private void OnLockedTargetTagChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshSwordStackCountUI(this.GetCurrentSwordUnlockStackCount(), count, false);
			this.RefreshAttackButtonUI(count > 0, false);
		}

		// Token: 0x0603251A RID: 206106 RVA: 0x00E1B3D4 File Offset: 0x00E195D4
		private int GetCurrentSwordUnlockStackCount()
		{
			BattleUiRoleData roleData = this.RoleData;
			int? num;
			if (roleData == null)
			{
				num = null;
			}
			else
			{
				BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
				num = ((gameplayTagComponent != null) ? new int?(gameplayTagComponent.GetTagCount(SwordControlGroundView.SwordUnlockStackTagId)) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x0603251B RID: 206107 RVA: 0x00E1B424 File Offset: 0x00E19624
		private int GetCurrentLockedTargetCount()
		{
			BattleUiRoleData roleData = this.RoleData;
			int? num;
			if (roleData == null)
			{
				num = null;
			}
			else
			{
				BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
				num = ((gameplayTagComponent != null) ? new int?(gameplayTagComponent.GetTagCount(SwordControlGroundView.SwordLockedTargetCountTagId)) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x0603251C RID: 206108 RVA: 0x00E1B474 File Offset: 0x00E19674
		private void RefreshSwordStackCountUI(int unlockStackCount, int lockedTargetCount, bool isForced = false)
		{
			int num = Math.Max(0, Math.Min(5, unlockStackCount));
			int num2 = Math.Max(0, Math.Min(num, lockedTargetCount));
			if (this.SwordUnlockCount == num && this.LockedTargetCount == num2 && !isForced)
			{
				return;
			}
			this.SwordUnlockCount = num;
			this.LockedTargetCount = num2;
			List<ESwordStackState> list = new List<ESwordStackState>();
			for (int i = 0; i < 5; i++)
			{
				if (i < num2)
				{
					list.Add(ESwordStackState.Aim);
				}
				else if (i < num)
				{
					list.Add(ESwordStackState.Normal);
				}
				else
				{
					list.Add(ESwordStackState.Lock);
				}
			}
			GenericLayout<GroundSwordStackItem, ESwordStackState> swordIconLayout = this.SwordIconLayout;
			if (swordIconLayout == null)
			{
				return;
			}
			swordIconLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603251D RID: 206109 RVA: 0x00E1B507 File Offset: 0x00E19707
		private void RefreshAttackButtonUI(bool isAttacking, bool isForced = false)
		{
			if (this.IsAttacking == isAttacking && !isForced)
			{
				return;
			}
			this.IsAttacking = isAttacking;
			SwordControlGroundAttackButton groundAttackButton = this.GroundAttackButton;
			if (groundAttackButton == null)
			{
				return;
			}
			groundAttackButton.SetInteractive(isAttacking, false);
		}

		// Token: 0x0603251E RID: 206110 RVA: 0x00E1B52F File Offset: 0x00E1972F
		[NullableContext(1)]
		private GroundSwordStackItem CreateSwordIconItem()
		{
			return new GroundSwordStackItem();
		}

		// Token: 0x0401AABA RID: 109242
		[StaticVariableRuleIgnore]
		private static readonly int SwordUnlockStackTagId = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.御剑剑意.解锁层数"];

		// Token: 0x0401AABB RID: 109243
		private const int SwordStackIconCount = 5;

		// Token: 0x0401AABC RID: 109244
		[StaticVariableRuleIgnore]
		private static readonly int SwordLockedTargetCountTagId = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.御剑剑意.瞄准数量"];

		// Token: 0x0401AABD RID: 109245
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<EBattleUiChild> HideBattleUiChildernList = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.Formation,
			EBattleUiChild.GamepadFormation,
			EBattleUiChild.SkillButton,
			EBattleUiChild.GamepadSkillButton,
			EBattleUiChild.RoleState
		});

		// Token: 0x0401AABE RID: 109246
		private BattleUiRoleData RoleData;

		// Token: 0x0401AABF RID: 109247
		private ITagTask SwordStackTagTask;

		// Token: 0x0401AAC0 RID: 109248
		private ITagTask LockedTargetTagTask;

		// Token: 0x0401AAC1 RID: 109249
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<GroundSwordStackItem, ESwordStackState> SwordIconLayout;

		// Token: 0x0401AAC2 RID: 109250
		private SwordControlGroundAttackButton GroundAttackButton;

		// Token: 0x0401AAC3 RID: 109251
		private int SwordUnlockCount = -1;

		// Token: 0x0401AAC4 RID: 109252
		private int LockedTargetCount = -1;

		// Token: 0x0401AAC5 RID: 109253
		private bool IsAttacking;

		// Token: 0x0200ABCB RID: 43979
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040352AE RID: 217774
			BtnSkillNor,
			// Token: 0x040352AF RID: 217775
			PnlIconList,
			// Token: 0x040352B0 RID: 217776
			PnlIconItem
		}
	}
}
