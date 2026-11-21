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
	// Token: 0x0200423E RID: 16958
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsAreaItem : UiPanelBase
	{
		// Token: 0x0602AE46 RID: 175686 RVA: 0x00C1148C File Offset: 0x00C0F68C
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

		// Token: 0x0602AE47 RID: 175687 RVA: 0x00C11540 File Offset: 0x00C0F740
		private UniTask InitMonster()
		{
			PhantomArenaBattleDetailsAreaItem.<InitMonster>d__11 <InitMonster>d__;
			<InitMonster>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMonster>d__.<>4__this = this;
			<InitMonster>d__.<>1__state = -1;
			<InitMonster>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitMonster>d__11>(ref <InitMonster>d__);
			return <InitMonster>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE48 RID: 175688 RVA: 0x00C11584 File Offset: 0x00C0F784
		private UniTask InitBossItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitBossItem>d__12 <InitBossItem>d__;
			<InitBossItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBossItem>d__.<>4__this = this;
			<InitBossItem>d__.<>1__state = -1;
			<InitBossItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitBossItem>d__12>(ref <InitBossItem>d__);
			return <InitBossItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE49 RID: 175689 RVA: 0x00C115C8 File Offset: 0x00C0F7C8
		private UniTask InitSkillItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitSkillItem>d__13 <InitSkillItem>d__;
			<InitSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillItem>d__.<>4__this = this;
			<InitSkillItem>d__.<>1__state = -1;
			<InitSkillItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitSkillItem>d__13>(ref <InitSkillItem>d__);
			return <InitSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE4A RID: 175690 RVA: 0x00C1160C File Offset: 0x00C0F80C
		private UniTask InitDetailsTipsItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitDetailsTipsItem>d__14 <InitDetailsTipsItem>d__;
			<InitDetailsTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsTipsItem>d__.<>4__this = this;
			<InitDetailsTipsItem>d__.<>1__state = -1;
			<InitDetailsTipsItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitDetailsTipsItem>d__14>(ref <InitDetailsTipsItem>d__);
			return <InitDetailsTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE4B RID: 175691 RVA: 0x00C11650 File Offset: 0x00C0F850
		private UniTask InitFieldItem()
		{
			PhantomArenaBattleDetailsAreaItem.<InitFieldItem>d__15 <InitFieldItem>d__;
			<InitFieldItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFieldItem>d__.<>4__this = this;
			<InitFieldItem>d__.<>1__state = -1;
			<InitFieldItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<InitFieldItem>d__15>(ref <InitFieldItem>d__);
			return <InitFieldItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE4C RID: 175692 RVA: 0x00C11694 File Offset: 0x00C0F894
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsAreaItem.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsAreaItem.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE4D RID: 175693 RVA: 0x00C116D7 File Offset: 0x00C0F8D7
		private PhantomArenaBattleDetailsMonsterItem InitMonsterItem()
		{
			PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem = new PhantomArenaBattleDetailsMonsterItem();
			phantomArenaBattleDetailsMonsterItem.IsOwn = this.IsOwn;
			phantomArenaBattleDetailsMonsterItem.OnClickCb = new Action<long>(this.OnClickMonsterItem);
			phantomArenaBattleDetailsMonsterItem.RegisterProxy(this.Proxy);
			return phantomArenaBattleDetailsMonsterItem;
		}

		// Token: 0x0602AE4E RID: 175694 RVA: 0x00C11708 File Offset: 0x00C0F908
		private void FieldInteractClick(PhantomArenaFieldData fieldData, PhantomArenaFieldItem fieldItem)
		{
			this.DetailsTipsItem.SetUiActive(true);
			this.DetailsTipsItem.RefreshByCardData(fieldData.CardData);
		}

		// Token: 0x0602AE4F RID: 175695 RVA: 0x00C11727 File Offset: 0x00C0F927
		public void RegisterProxy(PhantomArenaBattleDetailsViewProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0602AE50 RID: 175696 RVA: 0x00C11730 File Offset: 0x00C0F930
		public void SetSettlePoint(int settlePoint)
		{
			this.SkillItem.RefreshSettlePointText(settlePoint);
		}

		// Token: 0x0602AE51 RID: 175697 RVA: 0x00C11740 File Offset: 0x00C0F940
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

		// Token: 0x0602AE52 RID: 175698 RVA: 0x00C117A0 File Offset: 0x00C0F9A0
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

		// Token: 0x0602AE53 RID: 175699 RVA: 0x00C1180C File Offset: 0x00C0FA0C
		public bool GetPhantomAlive()
		{
			int num = 0;
			foreach (PhantomArenaBattleDetailsMonsterItem phantomArenaBattleDetailsMonsterItem in this.Layout.GetLayoutItemList())
			{
				num += phantomArenaBattleDetailsMonsterItem.GetDamage();
			}
			return num > 0;
		}

		// Token: 0x0602AE54 RID: 175700 RVA: 0x00C1186C File Offset: 0x00C0FA6C
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

		// Token: 0x0602AE55 RID: 175701 RVA: 0x00C118D8 File Offset: 0x00C0FAD8
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

		// Token: 0x0602AE56 RID: 175702 RVA: 0x00C11990 File Offset: 0x00C0FB90
		public FVectorDouble GetHeadLocation()
		{
			return this.RoleItem.GetHeadLocation();
		}

		// Token: 0x0602AE57 RID: 175703 RVA: 0x00C1199D File Offset: 0x00C0FB9D
		public void SetDamageTween(UCurveFloat curve, int damage)
		{
			PhantomArenaBattleDetailsRoleItem roleItem = this.RoleItem;
			if (roleItem == null)
			{
				return;
			}
			roleItem.RefreshLifeAfterDamage(curve, damage);
		}

		// Token: 0x0602AE58 RID: 175704 RVA: 0x00C119B1 File Offset: 0x00C0FBB1
		public void SetHitNum(int damage)
		{
			PhantomArenaBattleDetailsRoleItem roleItem = this.RoleItem;
			if (roleItem == null)
			{
				return;
			}
			roleItem.SetHitNum(damage);
		}

		// Token: 0x0602AE59 RID: 175705 RVA: 0x00C119C4 File Offset: 0x00C0FBC4
		private void OnClickMonsterItem(long entityId)
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(entityId);
			this.DetailsTipsItem.SetUiActive(true);
			this.DetailsTipsItem.RefreshByCardData(cardDataByEntityId);
		}

		// Token: 0x0602AE5A RID: 175706 RVA: 0x00C119FA File Offset: 0x00C0FBFA
		private void ClickMonsterTipsHide()
		{
			this.DetailsTipsItem.SetUiActive(false);
		}

		// Token: 0x04017354 RID: 95060
		protected GenericLayout<PhantomArenaBattleDetailsMonsterItem, long> Layout;

		// Token: 0x04017355 RID: 95061
		public PhantomArenaBattleDetailsRoleItem RoleItem;

		// Token: 0x04017356 RID: 95062
		protected PhantomArenaBattleDetailsSkillItem SkillItem;

		// Token: 0x04017357 RID: 95063
		protected PhantomArenaFieldItem FieldItem;

		// Token: 0x04017358 RID: 95064
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x04017359 RID: 95065
		public bool IsOwn;

		// Token: 0x0401735A RID: 95066
		public List<long> EntityIdList = new List<long>();

		// Token: 0x0401735B RID: 95067
		protected bool IsBattleEnd;

		// Token: 0x0401735C RID: 95068
		protected PhantomArenaBattleDetailsTips DetailsTipsItem;

		// Token: 0x02009E90 RID: 40592
		[NullableContext(0)]
		private class EAreaItem
		{
			// Token: 0x04031497 RID: 201879
			public const int RoleItem = 0;

			// Token: 0x04031498 RID: 201880
			public const int Layout = 1;

			// Token: 0x04031499 RID: 201881
			public const int LayoutItem = 2;

			// Token: 0x0403149A RID: 201882
			public const int SkillItem = 3;

			// Token: 0x0403149B RID: 201883
			public const int PanelCardTips = 4;

			// Token: 0x0403149C RID: 201884
			public const int FieldRoot = 5;

			// Token: 0x0403149D RID: 201885
			public const int FieldItem = 6;
		}
	}
}
