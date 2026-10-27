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
	// Token: 0x0200525C RID: 21084
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOwnRolePanel : UiPanelBase
	{
		// Token: 0x06035E34 RID: 220724 RVA: 0x00CC08B0 File Offset: 0x00CBEAB0
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

		// Token: 0x06035E35 RID: 220725 RVA: 0x00CC0920 File Offset: 0x00CBEB20
		protected UniTask InitGamepadFieldItem()
		{
			PhantomArenaOwnRolePanel.<InitGamepadFieldItem>d__8 <InitGamepadFieldItem>d__;
			<InitGamepadFieldItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGamepadFieldItem>d__.<>4__this = this;
			<InitGamepadFieldItem>d__.<>1__state = -1;
			<InitGamepadFieldItem>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitGamepadFieldItem>d__8>(ref <InitGamepadFieldItem>d__);
			return <InitGamepadFieldItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E36 RID: 220726 RVA: 0x00CC0963 File Offset: 0x00CBEB63
		private void FieldPointerEnter(PhantomArenaFieldData fieldData, UUIItem attachItem)
		{
			this.ParentArea.ViewProxy.FieldPointerEnter(fieldData, attachItem, true);
		}

		// Token: 0x06035E37 RID: 220727 RVA: 0x00CC0978 File Offset: 0x00CBEB78
		protected UniTask InitRoleHpTween()
		{
			PhantomArenaOwnRolePanel.<InitRoleHpTween>d__10 <InitRoleHpTween>d__;
			<InitRoleHpTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHpTween>d__.<>4__this = this;
			<InitRoleHpTween>d__.<>1__state = -1;
			<InitRoleHpTween>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitRoleHpTween>d__10>(ref <InitRoleHpTween>d__);
			return <InitRoleHpTween>d__.<>t__builder.Task;
		}

		// Token: 0x06035E38 RID: 220728 RVA: 0x00CC09BC File Offset: 0x00CBEBBC
		protected UniTask InitRoleItem()
		{
			PhantomArenaOwnRolePanel.<InitRoleItem>d__11 <InitRoleItem>d__;
			<InitRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleItem>d__.<>4__this = this;
			<InitRoleItem>d__.<>1__state = -1;
			<InitRoleItem>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitRoleItem>d__11>(ref <InitRoleItem>d__);
			return <InitRoleItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035E39 RID: 220729 RVA: 0x00CC0A00 File Offset: 0x00CBEC00
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

		// Token: 0x06035E3A RID: 220730 RVA: 0x00CC0A54 File Offset: 0x00CBEC54
		protected UniTask InitSkillList()
		{
			PhantomArenaOwnRolePanel.<InitSkillList>d__13 <InitSkillList>d__;
			<InitSkillList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillList>d__.<>4__this = this;
			<InitSkillList>d__.<>1__state = -1;
			<InitSkillList>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<InitSkillList>d__13>(ref <InitSkillList>d__);
			return <InitSkillList>d__.<>t__builder.Task;
		}

		// Token: 0x06035E3B RID: 220731 RVA: 0x00CC0A98 File Offset: 0x00CBEC98
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaOwnRolePanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaOwnRolePanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E3C RID: 220732 RVA: 0x00CC0ADB File Offset: 0x00CBECDB
		protected override void OnStart()
		{
			this.RoleHpTween.SetRoleItem(this.RoleItem);
			this.RoleItem.SetBarActive(true);
			this.InitAll();
		}

		// Token: 0x06035E3D RID: 220733 RVA: 0x00CC0B00 File Offset: 0x00CBED00
		protected override void OnBeforeDestroy()
		{
			this.RoleHpTween.Clear();
		}

		// Token: 0x06035E3E RID: 220734 RVA: 0x00CC0B0D File Offset: 0x00CBED0D
		private void InitAll()
		{
			this.InitLifeNum();
			this.RefreshTask();
			this.RefreshSkillEffect();
		}

		// Token: 0x06035E3F RID: 220735 RVA: 0x00CC0B24 File Offset: 0x00CBED24
		private void InitLifeNum()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleModel.Instance.OwnData.SetPrevShowLife(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x06035E40 RID: 220736 RVA: 0x00CC0B70 File Offset: 0x00CBED70
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

		// Token: 0x06035E41 RID: 220737 RVA: 0x00CC0B98 File Offset: 0x00CBED98
		public void RefreshLifeNumWithEffect()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			this.RoleItem.PlayHpEffect(battleStatusValue);
			this.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x06035E42 RID: 220738 RVA: 0x00CC0BE0 File Offset: 0x00CBEDE0
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

		// Token: 0x06035E43 RID: 220739 RVA: 0x00CC0C84 File Offset: 0x00CBEE84
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

		// Token: 0x06035E44 RID: 220740 RVA: 0x00CC0CE8 File Offset: 0x00CBEEE8
		public void RefreshShieldNum()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OwnData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x06035E45 RID: 220741 RVA: 0x00CC0D14 File Offset: 0x00CBEF14
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

		// Token: 0x06035E46 RID: 220742 RVA: 0x00CC0D80 File Offset: 0x00CBEF80
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

		// Token: 0x06035E47 RID: 220743 RVA: 0x00CC0DCB File Offset: 0x00CBEFCB
		public void ActiveIsFourCostShowInFirstTime()
		{
			this.IsFourCostShowInFirstTime = true;
			this.RoleItem.ShowPhantomBtn();
		}

		// Token: 0x06035E48 RID: 220744 RVA: 0x00CC0DE0 File Offset: 0x00CBEFE0
		public void RefreshSkillEffect()
		{
			foreach (PhantomArenaSkill phantomArenaSkill in this.SkillList)
			{
				phantomArenaSkill.RefreshSkillEffect();
			}
		}

		// Token: 0x06035E49 RID: 220745 RVA: 0x00CC0E30 File Offset: 0x00CBF030
		public void RegisterBattleArea(PhantomArenaOwnArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x06035E4A RID: 220746 RVA: 0x00CC0E39 File Offset: 0x00CBF039
		public void SwitchFieldState(bool active)
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.SetFieldItemActive(active);
		}

		// Token: 0x06035E4B RID: 220747 RVA: 0x00CC0E4C File Offset: 0x00CBF04C
		public void RefreshField()
		{
			PhantomArenaFieldItem gamepadFieldItem = this.GamepadFieldItem;
			if (gamepadFieldItem == null)
			{
				return;
			}
			gamepadFieldItem.Refresh(PhantomArenaBattleModel.Instance.OwnData.FieldData).Forget();
		}

		// Token: 0x06035E4C RID: 220748 RVA: 0x00CC0E72 File Offset: 0x00CBF072
		public UUIItem GetRoleRootItem()
		{
			return this.RoleItem.GetRootItem();
		}

		// Token: 0x06035E4D RID: 220749 RVA: 0x00CC0E7F File Offset: 0x00CBF07F
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

		// Token: 0x0401C8DD RID: 116957
		protected PhantomArenaOwnArea ParentArea;

		// Token: 0x0401C8DE RID: 116958
		protected PhantomArenaRoleItem RoleItem;

		// Token: 0x0401C8DF RID: 116959
		protected bool IsFourCostShowInFirstTime;

		// Token: 0x0401C8E0 RID: 116960
		protected PhantomArenaRoleHpTween RoleHpTween;

		// Token: 0x0401C8E1 RID: 116961
		protected List<PhantomArenaSkill> SkillList = new List<PhantomArenaSkill>();

		// Token: 0x0401C8E2 RID: 116962
		protected PhantomArenaFieldItem GamepadFieldItem;

		// Token: 0x0200B429 RID: 46121
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036962 RID: 223586
			public const int RoleItem = 0;

			// Token: 0x04036963 RID: 223587
			public const int SkillItemTwo = 1;

			// Token: 0x04036964 RID: 223588
			public const int SkillItemOne = 2;

			// Token: 0x04036965 RID: 223589
			public const int GamepadFieldItem = 3;
		}
	}
}
