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
	// Token: 0x0200422B RID: 16939
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOpponentRolePanel : UiPanelBase
	{
		// Token: 0x0602AD16 RID: 175382 RVA: 0x00C0D96C File Offset: 0x00C0BB6C
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

		// Token: 0x0602AD17 RID: 175383 RVA: 0x00C0D9DC File Offset: 0x00C0BBDC
		protected UniTask InitGamepadFieldItem()
		{
			PhantomArenaOpponentRolePanel.<InitGamepadFieldItem>d__8 <InitGamepadFieldItem>d__;
			<InitGamepadFieldItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGamepadFieldItem>d__.<>4__this = this;
			<InitGamepadFieldItem>d__.<>1__state = -1;
			<InitGamepadFieldItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitGamepadFieldItem>d__8>(ref <InitGamepadFieldItem>d__);
			return <InitGamepadFieldItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD18 RID: 175384 RVA: 0x00C0DA1F File Offset: 0x00C0BC1F
		private void FieldPointerEnter(PhantomArenaFieldData fieldData, UUIItem attachItem)
		{
			this.ParentArea.ViewProxy.FieldPointerEnter(fieldData, attachItem, true);
		}

		// Token: 0x0602AD19 RID: 175385 RVA: 0x00C0DA34 File Offset: 0x00C0BC34
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

		// Token: 0x0602AD1A RID: 175386 RVA: 0x00C0DA80 File Offset: 0x00C0BC80
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

		// Token: 0x0602AD1B RID: 175387 RVA: 0x00C0DACC File Offset: 0x00C0BCCC
		protected UniTask InitSkillItem()
		{
			PhantomArenaOpponentRolePanel.<InitSkillItem>d__12 <InitSkillItem>d__;
			<InitSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillItem>d__.<>4__this = this;
			<InitSkillItem>d__.<>1__state = -1;
			<InitSkillItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitSkillItem>d__12>(ref <InitSkillItem>d__);
			return <InitSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD1C RID: 175388 RVA: 0x00C0DB10 File Offset: 0x00C0BD10
		private UniTask InitRoleItem()
		{
			PhantomArenaOpponentRolePanel.<InitRoleItem>d__13 <InitRoleItem>d__;
			<InitRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleItem>d__.<>4__this = this;
			<InitRoleItem>d__.<>1__state = -1;
			<InitRoleItem>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitRoleItem>d__13>(ref <InitRoleItem>d__);
			return <InitRoleItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD1D RID: 175389 RVA: 0x00C0DB54 File Offset: 0x00C0BD54
		private UniTask InitRoleHpTween()
		{
			PhantomArenaOpponentRolePanel.<InitRoleHpTween>d__14 <InitRoleHpTween>d__;
			<InitRoleHpTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHpTween>d__.<>4__this = this;
			<InitRoleHpTween>d__.<>1__state = -1;
			<InitRoleHpTween>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<InitRoleHpTween>d__14>(ref <InitRoleHpTween>d__);
			return <InitRoleHpTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD1E RID: 175390 RVA: 0x00C0DB98 File Offset: 0x00C0BD98
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaOpponentRolePanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaOpponentRolePanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD1F RID: 175391 RVA: 0x00C0DBDB File Offset: 0x00C0BDDB
		protected override void OnStart()
		{
			this.RoleHpTween.SetRoleItem(this.RoleItem);
			this.RoleItem.SetBarActive(true);
		}

		// Token: 0x0602AD20 RID: 175392 RVA: 0x00C0DBFA File Offset: 0x00C0BDFA
		protected override void OnBeforeDestroy()
		{
			this.RoleHpTween.Clear();
		}

		// Token: 0x0602AD21 RID: 175393 RVA: 0x00C0DC08 File Offset: 0x00C0BE08
		private void InitLifeNum()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OpponentData.SetPrevShowLife(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x0602AD22 RID: 175394 RVA: 0x00C0DC54 File Offset: 0x00C0BE54
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

		// Token: 0x0602AD23 RID: 175395 RVA: 0x00C0DC74 File Offset: 0x00C0BE74
		public void RefreshLifeNumWithEffect()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OpponentData.SetPrevShowLife(battleStatusValue);
			this.RoleItem.PlayHpEffect(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x0602AD24 RID: 175396 RVA: 0x00C0DCCC File Offset: 0x00C0BECC
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

		// Token: 0x0602AD25 RID: 175397 RVA: 0x00C0DD70 File Offset: 0x00C0BF70
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

		// Token: 0x0602AD26 RID: 175398 RVA: 0x00C0DDD4 File Offset: 0x00C0BFD4
		public void RefreshShieldNum()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OpponentData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x0602AD27 RID: 175399 RVA: 0x00C0DE00 File Offset: 0x00C0C000
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

		// Token: 0x0602AD28 RID: 175400 RVA: 0x00C0DE64 File Offset: 0x00C0C064
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

		// Token: 0x0602AD29 RID: 175401 RVA: 0x00C0DEAF File Offset: 0x00C0C0AF
		public void RegisterBattleArea(OpponentArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x0602AD2A RID: 175402 RVA: 0x00C0DEB8 File Offset: 0x00C0C0B8
		public void SwitchFieldState(bool active)
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.SetFieldItemActive(active);
		}

		// Token: 0x0602AD2B RID: 175403 RVA: 0x00C0DECB File Offset: 0x00C0C0CB
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

		// Token: 0x0602AD2C RID: 175404 RVA: 0x00C0DF05 File Offset: 0x00C0C105
		public void RefreshField()
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.Refresh(PhantomArenaBattleModel.Instance.OpponentData.FieldData).Forget();
		}

		// Token: 0x0602AD2D RID: 175405 RVA: 0x00C0DF2B File Offset: 0x00C0C12B
		public UUIItem GetRoleRootItem()
		{
			return this.RoleItem.GetRootItem();
		}

		// Token: 0x0401730C RID: 94988
		protected OpponentArea ParentArea;

		// Token: 0x0401730D RID: 94989
		protected PhantomArenaRoleItem RoleItem;

		// Token: 0x0401730E RID: 94990
		protected PhantomArenaSkill SkillItem;

		// Token: 0x0401730F RID: 94991
		protected PhantomArenaSkill GamepadSkillItem;

		// Token: 0x04017310 RID: 94992
		protected PhantomArenaFieldItem GamepadFieldItem;

		// Token: 0x04017311 RID: 94993
		protected PhantomArenaRoleHpTween RoleHpTween;

		// Token: 0x02009E57 RID: 40535
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403138A RID: 201610
			public const int RoleItem = 0;

			// Token: 0x0403138B RID: 201611
			public const int GamepadSkillItem = 1;

			// Token: 0x0403138C RID: 201612
			public const int GamepadFieldItem = 2;

			// Token: 0x0403138D RID: 201613
			public const int SkillItem = 3;
		}
	}
}
