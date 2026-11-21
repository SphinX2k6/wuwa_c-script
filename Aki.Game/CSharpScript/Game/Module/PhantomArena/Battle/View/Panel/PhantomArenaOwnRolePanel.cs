using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Area;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Field;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x0200422C RID: 16940
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOwnRolePanel : UiPanelBase
	{
		// Token: 0x0602AD2F RID: 175407 RVA: 0x00C0DF40 File Offset: 0x00C0C140
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

		// Token: 0x0602AD30 RID: 175408 RVA: 0x00C0DFB0 File Offset: 0x00C0C1B0
		protected UniTask InitGamepadFieldItem()
		{
			PhantomArenaOwnRolePanel.<InitGamepadFieldItem>d__8 <InitGamepadFieldItem>d__;
			<InitGamepadFieldItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGamepadFieldItem>d__.<>4__this = this;
			<InitGamepadFieldItem>d__.<>1__state = -1;
			<InitGamepadFieldItem>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitGamepadFieldItem>d__8>(ref <InitGamepadFieldItem>d__);
			return <InitGamepadFieldItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD31 RID: 175409 RVA: 0x00C0DFF3 File Offset: 0x00C0C1F3
		private void FieldPointerEnter(PhantomArenaFieldData fieldData, UUIItem attachItem)
		{
			this.ParentArea.ViewProxy.FieldPointerEnter(fieldData, attachItem, true);
		}

		// Token: 0x0602AD32 RID: 175410 RVA: 0x00C0E008 File Offset: 0x00C0C208
		protected UniTask InitRoleHpTween()
		{
			PhantomArenaOwnRolePanel.<InitRoleHpTween>d__10 <InitRoleHpTween>d__;
			<InitRoleHpTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHpTween>d__.<>4__this = this;
			<InitRoleHpTween>d__.<>1__state = -1;
			<InitRoleHpTween>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitRoleHpTween>d__10>(ref <InitRoleHpTween>d__);
			return <InitRoleHpTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD33 RID: 175411 RVA: 0x00C0E04C File Offset: 0x00C0C24C
		protected UniTask InitRoleItem()
		{
			PhantomArenaOwnRolePanel.<InitRoleItem>d__11 <InitRoleItem>d__;
			<InitRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleItem>d__.<>4__this = this;
			<InitRoleItem>d__.<>1__state = -1;
			<InitRoleItem>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitRoleItem>d__11>(ref <InitRoleItem>d__);
			return <InitRoleItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD34 RID: 175412 RVA: 0x00C0E090 File Offset: 0x00C0C290
		protected UniTask InitSkillItem(UUIItem uiItem, bool needShow)
		{
			PhantomArenaOwnRolePanel.<InitSkillItem>d__12 <InitSkillItem>d__;
			<InitSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillItem>d__.<>4__this = this;
			<InitSkillItem>d__.uiItem = uiItem;
			<InitSkillItem>d__.needShow = needShow;
			<InitSkillItem>d__.<>1__state = -1;
			<InitSkillItem>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitSkillItem>d__12>(ref <InitSkillItem>d__);
			return <InitSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD35 RID: 175413 RVA: 0x00C0E0E4 File Offset: 0x00C0C2E4
		protected UniTask InitSkillList()
		{
			PhantomArenaOwnRolePanel.<InitSkillList>d__13 <InitSkillList>d__;
			<InitSkillList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillList>d__.<>4__this = this;
			<InitSkillList>d__.<>1__state = -1;
			<InitSkillList>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitSkillList>d__13>(ref <InitSkillList>d__);
			return <InitSkillList>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD36 RID: 175414 RVA: 0x00C0E128 File Offset: 0x00C0C328
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaOwnRolePanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD37 RID: 175415 RVA: 0x00C0E16B File Offset: 0x00C0C36B
		protected override void OnStart()
		{
			this.RoleHpTween.SetRoleItem(this.RoleItem);
			this.RoleItem.SetBarActive(true);
			this.InitAll();
		}

		// Token: 0x0602AD38 RID: 175416 RVA: 0x00C0E190 File Offset: 0x00C0C390
		protected override void OnBeforeDestroy()
		{
			this.RoleHpTween.Clear();
		}

		// Token: 0x0602AD39 RID: 175417 RVA: 0x00C0E19D File Offset: 0x00C0C39D
		private void InitAll()
		{
			this.InitLifeNum();
			this.RefreshTask();
			this.RefreshSkillEffect();
		}

		// Token: 0x0602AD3A RID: 175418 RVA: 0x00C0E1B4 File Offset: 0x00C0C3B4
		private void InitLifeNum()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OwnData.SetPrevShowLife(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x0602AD3B RID: 175419 RVA: 0x00C0E200 File Offset: 0x00C0C400
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
			this.RefreshSkillEffect();
		}

		// Token: 0x0602AD3C RID: 175420 RVA: 0x00C0E228 File Offset: 0x00C0C428
		public void RefreshLifeNumWithEffect()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			this.RoleItem.PlayHpEffect(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x0602AD3D RID: 175421 RVA: 0x00C0E270 File Offset: 0x00C0C470
		public void TryDoLifeChangeShow()
		{
			int oldLife = PhantomArenaBattleModel.Instance.OwnData.PrevShowLife;
			int lifeNum = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			if (oldLife == lifeNum)
			{
				return;
			}
			int maxLifeNum = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OwnData.SetPrevShowLife(lifeNum);
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RoleHpTween.PlayHpTween(oldLife, lifeNum, maxLifeNum);
				if (oldLife > lifeNum)
				{
					this.RoleItem.PlayHitAnim();
				}
			}, 300f, null, null, true, 1f);
		}

		// Token: 0x0602AD3E RID: 175422 RVA: 0x00C0E314 File Offset: 0x00C0C514
		public void PlayHpTween()
		{
			int prevShowLife = PhantomArenaBattleModel.Instance.OwnData.PrevShowLife;
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			if (prevShowLife == battleStatusValue)
			{
				return;
			}
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OwnData.SetPrevShowLife(battleStatusValue);
			this.RoleHpTween.PlayHpTween(prevShowLife, battleStatusValue, battleStatusValue2);
		}

		// Token: 0x0602AD3F RID: 175423 RVA: 0x00C0E378 File Offset: 0x00C0C578
		public void RefreshShieldNum()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OwnData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x0602AD40 RID: 175424 RVA: 0x00C0E3A4 File Offset: 0x00C0C5A4
		public void RefreshTask()
		{
			PhantomArenaCardTaskData taskData = PhantomArenaBattleModel.Instance.OwnData.TaskData;
			if (taskData == null || taskData.IsAllFinish)
			{
				this.RoleItem.SetPhantomBtnActive(false);
				return;
			}
			this.RoleItem.SetPhantomBtnActive(this.IsFourCostShowInFirstTime);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(taskData.TaskCardConfigId);
			this.RoleItem.RefreshMonsterIcon(phantomBattleCardConfig.TaskBg);
		}

		// Token: 0x0602AD41 RID: 175425 RVA: 0x00C0E410 File Offset: 0x00C0C610
		public UniTask PlayBeHitEffect(int damage)
		{
			PhantomArenaOwnRolePanel.<PlayBeHitEffect>d__25 <PlayBeHitEffect>d__;
			<PlayBeHitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBeHitEffect>d__.<>4__this = this;
			<PlayBeHitEffect>d__.damage = damage;
			<PlayBeHitEffect>d__.<>1__state = -1;
			<PlayBeHitEffect>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<PlayBeHitEffect>d__25>(ref <PlayBeHitEffect>d__);
			return <PlayBeHitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD42 RID: 175426 RVA: 0x00C0E45B File Offset: 0x00C0C65B
		public void ActiveIsFourCostShowInFirstTime()
		{
			this.IsFourCostShowInFirstTime = true;
			this.RoleItem.ShowPhantomBtn();
		}

		// Token: 0x0602AD43 RID: 175427 RVA: 0x00C0E470 File Offset: 0x00C0C670
		public void RefreshSkillEffect()
		{
			foreach (PhantomArenaSkill phantomArenaSkill in this.SkillList)
			{
				phantomArenaSkill.RefreshSkillEffect();
			}
		}

		// Token: 0x0602AD44 RID: 175428 RVA: 0x00C0E4C0 File Offset: 0x00C0C6C0
		public void RegisterBattleArea(PhantomArenaOwnArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x0602AD45 RID: 175429 RVA: 0x00C0E4C9 File Offset: 0x00C0C6C9
		public void SwitchFieldState(bool active)
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.SetFieldItemActive(active);
		}

		// Token: 0x0602AD46 RID: 175430 RVA: 0x00C0E4DC File Offset: 0x00C0C6DC
		public void RefreshField()
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.Refresh(PhantomArenaBattleModel.Instance.OwnData.FieldData).Forget();
		}

		// Token: 0x0602AD47 RID: 175431 RVA: 0x00C0E502 File Offset: 0x00C0C702
		public UUIItem GetRoleRootItem()
		{
			return this.RoleItem.GetRootItem();
		}

		// Token: 0x0602AD48 RID: 175432 RVA: 0x00C0E50F File Offset: 0x00C0C70F
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "Task"))
			{
				return null;
			}
			PhantomArenaRoleItem roleItem = this.RoleItem;
			if (roleItem == null)
			{
				return null;
			}
			return roleItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x04017312 RID: 94994
		protected PhantomArenaOwnArea ParentArea;

		// Token: 0x04017313 RID: 94995
		protected PhantomArenaRoleItem RoleItem;

		// Token: 0x04017314 RID: 94996
		protected bool IsFourCostShowInFirstTime;

		// Token: 0x04017315 RID: 94997
		protected PhantomArenaRoleHpTween RoleHpTween;

		// Token: 0x04017316 RID: 94998
		protected List<PhantomArenaSkill> SkillList = new List<PhantomArenaSkill>();

		// Token: 0x04017317 RID: 94999
		protected PhantomArenaFieldItem GamepadFieldItem;

		// Token: 0x02009E61 RID: 40545
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040313B5 RID: 201653
			public const int RoleItem = 0;

			// Token: 0x040313B6 RID: 201654
			public const int SkillItemTwo = 1;

			// Token: 0x040313B7 RID: 201655
			public const int SkillItemOne = 2;

			// Token: 0x040313B8 RID: 201656
			public const int GamepadFieldItem = 3;
		}
	}
}
