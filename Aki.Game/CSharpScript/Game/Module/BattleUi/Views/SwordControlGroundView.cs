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
	// Token: 0x02005E3D RID: 24125
	[NullableContext(2)]
	[Nullable(0)]
	public class SwordControlGroundView : UiViewBase
	{
		// Token: 0x0603D57B RID: 251259 RVA: 0x00EC9B12 File Offset: 0x00EC7D12
		[NullableContext(1)]
		public SwordControlGroundView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603D57C RID: 251260 RVA: 0x00EC9B2C File Offset: 0x00EC7D2C
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

		// Token: 0x0603D57D RID: 251261 RVA: 0x00EC9BB8 File Offset: 0x00EC7DB8
		protected override UniTask OnBeforeStartAsync()
		{
			SwordControlGroundView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SwordControlGroundView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D57E RID: 251262 RVA: 0x00EC9BFB File Offset: 0x00EC7DFB
		protected override void OnBeforeShow()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlGroundView.HideBattleUiChildernList, false, true, 0);
		}

		// Token: 0x0603D57F RID: 251263 RVA: 0x00EC9C15 File Offset: 0x00EC7E15
		protected override void OnAfterHide()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.Custom, SwordControlGroundView.HideBattleUiChildernList, true, true, 0);
		}

		// Token: 0x0603D580 RID: 251264 RVA: 0x00EC9C30 File Offset: 0x00EC7E30
		protected override void OnStart()
		{
			base.OnStart();
			this.SwordIconLayout = new GenericLayout<GroundSwordStackItem, ESwordStackState>(base.GetHorizontalLayout(1), new Func<GroundSwordStackItem>(this.CreateSwordIconItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			this.RefreshRoleData();
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		}

		// Token: 0x0603D581 RID: 251265 RVA: 0x00EC9C98 File Offset: 0x00EC7E98
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

		// Token: 0x0603D582 RID: 251266 RVA: 0x00EC9CF4 File Offset: 0x00EC7EF4
		private void OnBattleUiCurRoleDataChanged(int newEntityId, int oldEntityId)
		{
			this.RefreshRoleData();
		}

		// Token: 0x0603D583 RID: 251267 RVA: 0x00EC9CFC File Offset: 0x00EC7EFC
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

		// Token: 0x0603D584 RID: 251268 RVA: 0x00EC9D84 File Offset: 0x00EC7F84
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

		// Token: 0x0603D585 RID: 251269 RVA: 0x00EC9DC5 File Offset: 0x00EC7FC5
		private void RemoveListenSwordStackTagCountChanged()
		{
			ITagTask swordStackTagTask = this.SwordStackTagTask;
			if (swordStackTagTask != null)
			{
				swordStackTagTask.EndTask();
			}
			this.SwordStackTagTask = null;
		}

		// Token: 0x0603D586 RID: 251270 RVA: 0x00EC9DDF File Offset: 0x00EC7FDF
		private void OnSwordStackTagCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshSwordStackCountUI(count, this.GetCurrentLockedTargetCount(), false);
		}

		// Token: 0x0603D587 RID: 251271 RVA: 0x00EC9DF0 File Offset: 0x00EC7FF0
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

		// Token: 0x0603D588 RID: 251272 RVA: 0x00EC9E31 File Offset: 0x00EC8031
		private void RemoveListenLockedTargetTagChanged()
		{
			ITagTask lockedTargetTagTask = this.LockedTargetTagTask;
			if (lockedTargetTagTask != null)
			{
				lockedTargetTagTask.EndTask();
			}
			this.LockedTargetTagTask = null;
		}

		// Token: 0x0603D589 RID: 251273 RVA: 0x00EC9E4B File Offset: 0x00EC804B
		private void OnLockedTargetTagChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshSwordStackCountUI(this.GetCurrentSwordUnlockStackCount(), count, false);
			this.RefreshAttackButtonUI(count > 0, false);
		}

		// Token: 0x0603D58A RID: 251274 RVA: 0x00EC9E68 File Offset: 0x00EC8068
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

		// Token: 0x0603D58B RID: 251275 RVA: 0x00EC9EB8 File Offset: 0x00EC80B8
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

		// Token: 0x0603D58C RID: 251276 RVA: 0x00EC9F08 File Offset: 0x00EC8108
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

		// Token: 0x0603D58D RID: 251277 RVA: 0x00EC9F9B File Offset: 0x00EC819B
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

		// Token: 0x0603D58E RID: 251278 RVA: 0x00EC9FC3 File Offset: 0x00EC81C3
		[NullableContext(1)]
		private GroundSwordStackItem CreateSwordIconItem()
		{
			return new GroundSwordStackItem();
		}

		// Token: 0x0401FFF3 RID: 131059
		[StaticVariableRuleIgnore]
		private static readonly int SwordUnlockStackTagId = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.御剑剑意.解锁层数"];

		// Token: 0x0401FFF4 RID: 131060
		private const int SwordStackIconCount = 5;

		// Token: 0x0401FFF5 RID: 131061
		[StaticVariableRuleIgnore]
		private static readonly int SwordLockedTargetCountTagId = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.御剑剑意.瞄准数量"];

		// Token: 0x0401FFF6 RID: 131062
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

		// Token: 0x0401FFF7 RID: 131063
		private BattleUiRoleData RoleData;

		// Token: 0x0401FFF8 RID: 131064
		private ITagTask SwordStackTagTask;

		// Token: 0x0401FFF9 RID: 131065
		private ITagTask LockedTargetTagTask;

		// Token: 0x0401FFFA RID: 131066
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<GroundSwordStackItem, ESwordStackState> SwordIconLayout;

		// Token: 0x0401FFFB RID: 131067
		private SwordControlGroundAttackButton GroundAttackButton;

		// Token: 0x0401FFFC RID: 131068
		private int SwordUnlockCount = -1;

		// Token: 0x0401FFFD RID: 131069
		private int LockedTargetCount = -1;

		// Token: 0x0401FFFE RID: 131070
		private bool IsAttacking;

		// Token: 0x0200C1BC RID: 49596
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A8BC RID: 239804
			BtnSkillNor,
			// Token: 0x0403A8BD RID: 239805
			PnlIconList,
			// Token: 0x0403A8BE RID: 239806
			PnlIconItem
		}
	}
}
