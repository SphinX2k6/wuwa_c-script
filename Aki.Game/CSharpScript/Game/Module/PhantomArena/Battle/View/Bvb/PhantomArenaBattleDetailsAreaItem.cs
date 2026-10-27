using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Field;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x0200526E RID: 21102
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsAreaItem : UiPanelBase
	{
		// Token: 0x06035F4B RID: 221003 RVA: 0x00CC3D8C File Offset: 0x00CC1F8C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x06035F4C RID: 221004 RVA: 0x00CC3E40 File Offset: 0x00CC2040
		private UniTask InitMonster()
		{
			PhantomArenaBattleDetailsAreaItem.<InitMonster>d__11 <InitMonster>d__;
			<InitMonster>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMonster>d__.<>4__this = this;
			<InitMonster>d__.<>1__state = -1;
			<InitMonster>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitMonster>d__11>(ref <InitMonster>d__);
			return <InitMonster>d__.<>t__builder.Task;
		}

		// Token: 0x06035F4D RID: 221005 RVA: 0x00CC3E84 File Offset: 0x00CC2084
		private UniTask InitBossItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitBossItem>d__12 <InitBossItem>d__;
			<InitBossItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBossItem>d__.<>4__this = this;
			<InitBossItem>d__.<>1__state = -1;
			<InitBossItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitBossItem>d__12>(ref <InitBossItem>d__);
			return <InitBossItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035F4E RID: 221006 RVA: 0x00CC3EC8 File Offset: 0x00CC20C8
		private UniTask InitSkillItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitSkillItem>d__13 <InitSkillItem>d__;
			<InitSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillItem>d__.<>4__this = this;
			<InitSkillItem>d__.<>1__state = -1;
			<InitSkillItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitSkillItem>d__13>(ref <InitSkillItem>d__);
			return <InitSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035F4F RID: 221007 RVA: 0x00CC3F0C File Offset: 0x00CC210C
		private UniTask InitDetailsTipsItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitDetailsTipsItem>d__14 <InitDetailsTipsItem>d__;
			<InitDetailsTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsTipsItem>d__.<>4__this = this;
			<InitDetailsTipsItem>d__.<>1__state = -1;
			<InitDetailsTipsItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitDetailsTipsItem>d__14>(ref <InitDetailsTipsItem>d__);
			return <InitDetailsTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035F50 RID: 221008 RVA: 0x00CC3F50 File Offset: 0x00CC2150
		private UniTask InitFieldItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitFieldItem>d__15 <InitFieldItem>d__;
			<InitFieldItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFieldItem>d__.<>4__this = this;
			<InitFieldItem>d__.<>1__state = -1;
			<InitFieldItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitFieldItem>d__15>(ref <InitFieldItem>d__);
			return <InitFieldItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035F51 RID: 221009 RVA: 0x00CC3F94 File Offset: 0x00CC2194
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsAreaItem.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035F52 RID: 221010 RVA: 0x00CC3FD7 File Offset: 0x00CC21D7
		private PhantomArenaBattleDetailsMonsterItem InitMonsterItem()
		{
			PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem = new PhantomArenaBattleDetailsMonsterItem();
			phantomArenaBattleDetailsMonsterItem.IsOwn = this.IsOwn;
			phantomArenaBattleDetailsMonsterItem.OnClickCb = new Action<long>(this.OnClickMonsterItem);
			phantomArenaBattleDetailsMonsterItem.RegisterProxy(this.Proxy);
			return phantomArenaBattleDetailsMonsterItem;
		}

		// Token: 0x06035F53 RID: 221011 RVA: 0x00CC4008 File Offset: 0x00CC2208
		private void FieldInteractClick(PhantomArenaFieldData fieldData, PhantomArenaFieldItem fieldItem)
		{
			this.DetailsTipsItem.SetUiActive(true);
			this.DetailsTipsItem.RefreshByCardData(fieldData.CardData);
		}

		// Token: 0x06035F54 RID: 221012 RVA: 0x00CC4027 File Offset: 0x00CC2227
		public void RegisterProxy(PhantomArenaBattleDetailsViewProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x06035F55 RID: 221013 RVA: 0x00CC4030 File Offset: 0x00CC2230
		public void SetSettlePoint(int settlePoint)
		{
			this.SkillItem.RefreshSettlePointText(settlePoint);
		}

		// Token: 0x06035F56 RID: 221014 RVA: 0x00CC4040 File Offset: 0x00CC2240
		public void TickMonster(float deltaTime)
		{
			if (this.IsBattleEnd)
			{
				return;
			}
			foreach (PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem in this.Layout.GetLayoutItemList())
			{
				phantomArenaBattleDetailsMonsterItem.Tick(deltaTime);
			}
		}

		// Token: 0x06035F57 RID: 221015 RVA: 0x00CC40A0 File Offset: 0x00CC22A0
		public int GetBeforeDamage()
		{
			int num = 0;
			num += this.SkillItem.GetDamage();
			foreach (PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem in this.Layout.GetLayoutItemList())
			{
				num += phantomArenaBattleDetailsMonsterItem.GetDamage();
			}
			return num;
		}

		// Token: 0x06035F58 RID: 221016 RVA: 0x00CC410C File Offset: 0x00CC230C
		public bool GetPhantomAlive()
		{
			int num = 0;
			foreach (PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem in this.Layout.GetLayoutItemList())
			{
				num += phantomArenaBattleDetailsMonsterItem.GetDamage();
			}
			return num > 0;
		}

		// Token: 0x06035F59 RID: 221017 RVA: 0x00CC416C File Offset: 0x00CC236C
		public void StartShowWinAnim()
		{
			this.IsBattleEnd = true;
			List<PhantomArenaBattleDetailsMonsterItem> layoutItemList = this.Layout.GetLayoutItemList();
			this.SkillItem.ShowWinAnim();
			foreach (PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem in layoutItemList)
			{
				phantomArenaBattleDetailsMonsterItem.ShowWinAnim();
			}
		}

		// Token: 0x06035F5A RID: 221018 RVA: 0x00CC41D8 File Offset: 0x00CC23D8
		public void StartAccumulate(UCurveFloat curveX, UCurveFloat curveY, UCurveFloat curveCommon)
		{
			List<PhantomArenaBattleDetailsMonsterItem> layoutItemList = this.Layout.GetLayoutItemList();
			FVectorDouble headLocation = this.RoleItem.GetHeadLocation();
			PhantomArenaBattleDetailsSkillItem skillItem = this.SkillItem;
			if (skillItem != null)
			{
				skillItem.OnAccumulateEvent((float)headLocation.X, (float)headLocation.Z, curveCommon);
			}
			foreach (PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem in layoutItemList)
			{
				phantomArenaBattleDetailsMonsterItem.OnAccumulateEvent((float)headLocation.X, (float)headLocation.Z, curveX, curveY);
			}
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				PhantomArenaBattleDetailsRoleItem roleItem = this.RoleItem;
				if (roleItem == null)
				{
					return;
				}
				roleItem.OnAccumulateAfterEvent();
			}, 200f, null, null, true, 1f);
		}

		// Token: 0x06035F5B RID: 221019 RVA: 0x00CC4290 File Offset: 0x00CC2490
		public FVectorDouble GetHeadLocation()
		{
			return this.RoleItem.GetHeadLocation();
		}

		// Token: 0x06035F5C RID: 221020 RVA: 0x00CC429D File Offset: 0x00CC249D
		public void SetDamageTween(UCurveFloat curve, int damage)
		{
			PhantomArenaBattleDetailsRoleItem roleItem = this.RoleItem;
			if (roleItem == null)
			{
				return;
			}
			roleItem.RefreshLifeAfterDamage(curve, damage);
		}

		// Token: 0x06035F5D RID: 221021 RVA: 0x00CC42B1 File Offset: 0x00CC24B1
		public void SetHitNum(int damage)
		{
			PhantomArenaBattleDetailsRoleItem roleItem = this.RoleItem;
			if (roleItem == null)
			{
				return;
			}
			roleItem.SetHitNum(damage);
		}

		// Token: 0x06035F5E RID: 221022 RVA: 0x00CC42C4 File Offset: 0x00CC24C4
		private void OnClickMonsterItem(long entityId)
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(entityId);
			this.DetailsTipsItem.SetUiActive(true);
			this.DetailsTipsItem.RefreshByCardData(cardDataByEntityId);
		}

		// Token: 0x06035F5F RID: 221023 RVA: 0x00CC42FA File Offset: 0x00CC24FA
		private void ClickMonsterTipsHide()
		{
			this.DetailsTipsItem.SetUiActive(false);
		}

		// Token: 0x0401C91F RID: 117023
		protected GenericLayout<PhantomArenaBattleDetailsMonsterItem, long> Layout;

		// Token: 0x0401C920 RID: 117024
		public PhantomArenaBattleDetailsRoleItem RoleItem;

		// Token: 0x0401C921 RID: 117025
		protected PhantomArenaBattleDetailsSkillItem SkillItem;

		// Token: 0x0401C922 RID: 117026
		protected PhantomArenaFieldItem FieldItem;

		// Token: 0x0401C923 RID: 117027
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x0401C924 RID: 117028
		public bool IsOwn;

		// Token: 0x0401C925 RID: 117029
		public List<long> EntityIdList = new List<long>();

		// Token: 0x0401C926 RID: 117030
		protected bool IsBattleEnd;

		// Token: 0x0401C927 RID: 117031
		protected PhantomArenaBattleDetailsTips DetailsTipsItem;

		// Token: 0x0200B458 RID: 46168
		[NullableContext(0)]
		private class EAreaItem
		{
			// Token: 0x04036A44 RID: 223812
			public const int RoleItem = 0;

			// Token: 0x04036A45 RID: 223813
			public const int Layout = 1;

			// Token: 0x04036A46 RID: 223814
			public const int LayoutItem = 2;

			// Token: 0x04036A47 RID: 223815
			public const int SkillItem = 3;

			// Token: 0x04036A48 RID: 223816
			public const int PanelCardTips = 4;

			// Token: 0x04036A49 RID: 223817
			public const int FieldRoot = 5;

			// Token: 0x04036A4A RID: 223818
			public const int FieldItem = 6;
		}
	}
}
