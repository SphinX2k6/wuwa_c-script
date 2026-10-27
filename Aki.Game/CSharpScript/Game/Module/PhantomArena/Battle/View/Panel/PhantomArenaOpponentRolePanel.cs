using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.Opponent;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Field;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x0200525B RID: 21083
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOpponentRolePanel : UiPanelBase
	{
		// Token: 0x06035E1B RID: 220699 RVA: 0x00CC02DC File Offset: 0x00CBE4DC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06035E1C RID: 220700 RVA: 0x00CC034C File Offset: 0x00CBE54C
		protected UniTask InitGamepadFieldItem()
		{
			PhantomArenaOpponentRolePanel.<InitGamepadFieldItem>d__8 <InitGamepadFieldItem>d__;
			<InitGamepadFieldItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGamepadFieldItem>d__.<>4__this = this;
			<InitGamepadFieldItem>d__.<>1__state = -1;
			<InitGamepadFieldItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitGamepadFieldItem>d__8>(ref <InitGamepadFieldItem>d__);
			return <InitGamepadFieldItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E1D RID: 220701 RVA: 0x00CC038F File Offset: 0x00CBE58F
		private void FieldPointerEnter(PhantomArenaFieldData fieldData, UUIItem attachItem)
		{
			this.ParentArea.ViewProxy.FieldPointerEnter(fieldData, attachItem, true);
		}

		// Token: 0x06035E1E RID: 220702 RVA: 0x00CC03A4 File Offset: 0x00CBE5A4
		protected UniTask CreateSkillItem(IPhantomArenaSkillData skillData)
		{
			PhantomArenaOpponentRolePanel.<CreateSkillItem>d__10 <CreateSkillItem>d__;
			<CreateSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSkillItem>d__.<>4__this = this;
			<CreateSkillItem>d__.skillData = skillData;
			<CreateSkillItem>d__.<>1__state = -1;
			<CreateSkillItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<CreateSkillItem>d__10>(ref <CreateSkillItem>d__);
			return <CreateSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E1F RID: 220703 RVA: 0x00CC03F0 File Offset: 0x00CBE5F0
		protected UniTask CreateGamepadSkillItem(IPhantomArenaSkillData skillData)
		{
			PhantomArenaOpponentRolePanel.<CreateGamepadSkillItem>d__11 <CreateGamepadSkillItem>d__;
			<CreateGamepadSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGamepadSkillItem>d__.<>4__this = this;
			<CreateGamepadSkillItem>d__.skillData = skillData;
			<CreateGamepadSkillItem>d__.<>1__state = -1;
			<CreateGamepadSkillItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<CreateGamepadSkillItem>d__11>(ref <CreateGamepadSkillItem>d__);
			return <CreateGamepadSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E20 RID: 220704 RVA: 0x00CC043C File Offset: 0x00CBE63C
		protected UniTask InitSkillItem()
		{
			PhantomArenaOpponentRolePanel.<InitSkillItem>d__12 <InitSkillItem>d__;
			<InitSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillItem>d__.<>4__this = this;
			<InitSkillItem>d__.<>1__state = -1;
			<InitSkillItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitSkillItem>d__12>(ref <InitSkillItem>d__);
			return <InitSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E21 RID: 220705 RVA: 0x00CC0480 File Offset: 0x00CBE680
		private UniTask InitRoleItem()
		{
			PhantomArenaOpponentRolePanel.<InitRoleItem>d__13 <InitRoleItem>d__;
			<InitRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleItem>d__.<>4__this = this;
			<InitRoleItem>d__.<>1__state = -1;
			<InitRoleItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitRoleItem>d__13>(ref <InitRoleItem>d__);
			return <InitRoleItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E22 RID: 220706 RVA: 0x00CC04C4 File Offset: 0x00CBE6C4
		private UniTask InitRoleHpTween()
		{
			PhantomArenaOpponentRolePanel.<InitRoleHpTween>d__14 <InitRoleHpTween>d__;
			<InitRoleHpTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHpTween>d__.<>4__this = this;
			<InitRoleHpTween>d__.<>1__state = -1;
			<InitRoleHpTween>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitRoleHpTween>d__14>(ref <InitRoleHpTween>d__);
			return <InitRoleHpTween>d__.<>t__builder.Task;
		}

		// Token: 0x06035E23 RID: 220707 RVA: 0x00CC0508 File Offset: 0x00CBE708
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaOpponentRolePanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E24 RID: 220708 RVA: 0x00CC054B File Offset: 0x00CBE74B
		protected override void OnStart()
		{
			this.RoleHpTween.SetRoleItem(this.RoleItem);
			this.RoleItem.SetBarActive(true);
		}

		// Token: 0x06035E25 RID: 220709 RVA: 0x00CC056A File Offset: 0x00CBE76A
		protected override void OnBeforeDestroy()
		{
			this.RoleHpTween.Clear();
		}

		// Token: 0x06035E26 RID: 220710 RVA: 0x00CC0578 File Offset: 0x00CBE778
		private void InitLifeNum()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OpponentData.SetPrevShowLife(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x06035E27 RID: 220711 RVA: 0x00CC05C4 File Offset: 0x00CBE7C4
		public void RefreshAll(bool isFromWorldDone)
		{
			if (isFromWorldDone)
			{
				this.InitLifeNum();
			}
			else
			{
				this.RefreshShieldNum();
				this.TryDoLifeChangeShow();
			}
			this.RefreshTask();
		}

		// Token: 0x06035E28 RID: 220712 RVA: 0x00CC05E4 File Offset: 0x00CBE7E4
		public void RefreshLifeNumWithEffect()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OpponentData.SetPrevShowLife(battleStatusValue);
			this.RoleItem.PlayHpEffect(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x06035E29 RID: 220713 RVA: 0x00CC063C File Offset: 0x00CBE83C
		public void TryDoLifeChangeShow()
		{
			int oldLife = PhantomArenaBattleModel.Instance.OpponentData.PrevShowLife;
			int lifeNum = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			if (oldLife == lifeNum)
			{
				return;
			}
			int maxLifeNum = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OpponentData.SetPrevShowLife(lifeNum);
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RoleHpTween.PlayHpTween(oldLife, lifeNum, maxLifeNum);
				if (oldLife > lifeNum)
				{
					this.RoleItem.PlayHitAnim();
				}
			}, 300f, null, null, true, 1f);
		}

		// Token: 0x06035E2A RID: 220714 RVA: 0x00CC06E0 File Offset: 0x00CBE8E0
		public void PlayHpTween()
		{
			int prevShowLife = PhantomArenaBattleModel.Instance.OpponentData.PrevShowLife;
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			if (prevShowLife == battleStatusValue)
			{
				return;
			}
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OpponentData.SetPrevShowLife(battleStatusValue);
			this.RoleHpTween.PlayHpTween(prevShowLife, battleStatusValue, battleStatusValue2);
		}

		// Token: 0x06035E2B RID: 220715 RVA: 0x00CC0744 File Offset: 0x00CBE944
		public void RefreshShieldNum()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OpponentData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x06035E2C RID: 220716 RVA: 0x00CC0770 File Offset: 0x00CBE970
		public void RefreshTask()
		{
			PhantomArenaCardTaskData taskData = PhantomArenaBattleModel.Instance.OpponentData.TaskData;
			if (taskData == null || taskData.IsAllFinish)
			{
				this.RoleItem.SetPhantomBtnActive(false);
				return;
			}
			this.RoleItem.SetPhantomBtnActive(true);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(taskData.TaskCardConfigId);
			this.RoleItem.RefreshMonsterIcon(phantomBattleCardConfig.TaskBg);
		}

		// Token: 0x06035E2D RID: 220717 RVA: 0x00CC07D4 File Offset: 0x00CBE9D4
		public UniTask PlayBeHitEffect(int damage)
		{
			PhantomArenaOpponentRolePanel.<PlayBeHitEffect>d__25 <PlayBeHitEffect>d__;
			<PlayBeHitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBeHitEffect>d__.<>4__this = this;
			<PlayBeHitEffect>d__.damage = damage;
			<PlayBeHitEffect>d__.<>1__state = -1;
			<PlayBeHitEffect>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<PlayBeHitEffect>d__25>(ref <PlayBeHitEffect>d__);
			return <PlayBeHitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035E2E RID: 220718 RVA: 0x00CC081F File Offset: 0x00CBEA1F
		public void RegisterBattleArea(OpponentArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x06035E2F RID: 220719 RVA: 0x00CC0828 File Offset: 0x00CBEA28
		public void SwitchFieldState(bool active)
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.SetFieldItemActive(active);
		}

		// Token: 0x06035E30 RID: 220720 RVA: 0x00CC083B File Offset: 0x00CBEA3B
		public void RefreshSkillState()
		{
			PhantomArenaSkill skillItem = this.SkillItem;
			if (skillItem != null)
			{
				skillItem.SetActive(!Info.Instance.IsInGamepad());
			}
			PhantomArenaSkill gamepadSkillItem = this.GamepadSkillItem;
			if (gamepadSkillItem == null)
			{
				return;
			}
			gamepadSkillItem.SetActive(Info.Instance.IsInGamepad());
		}

		// Token: 0x06035E31 RID: 220721 RVA: 0x00CC0875 File Offset: 0x00CBEA75
		public void RefreshField()
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.Refresh(PhantomArenaBattleModel.Instance.OpponentData.FieldData).Forget();
		}

		// Token: 0x06035E32 RID: 220722 RVA: 0x00CC089B File Offset: 0x00CBEA9B
		public UUIItem GetRoleRootItem()
		{
			return this.RoleItem.GetRootItem();
		}

		// Token: 0x0401C8D7 RID: 116951
		protected OpponentArea ParentArea;

		// Token: 0x0401C8D8 RID: 116952
		protected PhantomArenaRoleItem RoleItem;

		// Token: 0x0401C8D9 RID: 116953
		protected PhantomArenaSkill SkillItem;

		// Token: 0x0401C8DA RID: 116954
		protected PhantomArenaSkill GamepadSkillItem;

		// Token: 0x0401C8DB RID: 116955
		protected PhantomArenaFieldItem GamepadFieldItem;

		// Token: 0x0401C8DC RID: 116956
		protected PhantomArenaRoleHpTween RoleHpTween;

		// Token: 0x0200B41F RID: 46111
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036937 RID: 223543
			public const int RoleItem = 0;

			// Token: 0x04036938 RID: 223544
			public const int GamepadSkillItem = 1;

			// Token: 0x04036939 RID: 223545
			public const int GamepadFieldItem = 2;

			// Token: 0x0403693A RID: 223546
			public const int SkillItem = 3;
		}
	}
}
