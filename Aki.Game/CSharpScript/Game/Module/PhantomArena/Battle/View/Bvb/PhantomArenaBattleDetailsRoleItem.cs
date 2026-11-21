using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02004241 RID: 16961
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsRoleItem : UiPanelBase
	{
		// Token: 0x0602AE7E RID: 175742 RVA: 0x00C12890 File Offset: 0x00C10A90
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
		}

		// Token: 0x0602AE7F RID: 175743 RVA: 0x00C12942 File Offset: 0x00C10B42
		protected override void OnStart()
		{
			this.DelegateDamage = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallDamage));
		}

		// Token: 0x0602AE80 RID: 175744 RVA: 0x00C1295B File Offset: 0x00C10B5B
		protected override void OnBeforeDestroy()
		{
			if (this.TweenerDamage != null)
			{
				this.TweenerDamage = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCallDamage));
		}

		// Token: 0x0602AE81 RID: 175745 RVA: 0x00C12980 File Offset: 0x00C10B80
		private UniTask InitRoleHead()
		{
			PhantomArenaBattleDetailsRoleItem.<InitRoleHead>d__12 <InitRoleHead>d__;
			<InitRoleHead>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHead>d__.<>4__this = this;
			<InitRoleHead>d__.<>1__state = -1;
			<InitRoleHead>d__.<>t__builder.Start<PhantomArenaBattleDetailsRoleItem.<InitRoleHead>d__12>(ref <InitRoleHead>d__);
			return <InitRoleHead>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE82 RID: 175746 RVA: 0x00C129C4 File Offset: 0x00C10BC4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsRoleItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsRoleItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE83 RID: 175747 RVA: 0x00C12A08 File Offset: 0x00C10C08
		public void RefreshLifeNum(int lifeNum, int maxLifeNum)
		{
			this.MaxLife = maxLifeNum;
			this.CurLife = lifeNum;
			base.GetText(1).SetText(lifeNum.ToString() + "/" + maxLifeNum.ToString(), true);
			this.RoleHead.RefreshLifeBar((float)lifeNum / (float)maxLifeNum);
		}

		// Token: 0x0602AE84 RID: 175748 RVA: 0x00C12A58 File Offset: 0x00C10C58
		public void SetHitNum(int damage)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText("-" + damage.ToString(), true);
		}

		// Token: 0x0602AE85 RID: 175749 RVA: 0x00C12A80 File Offset: 0x00C10C80
		public void RefreshLifeAfterDamage(UCurveFloat curve, int damage)
		{
			int num = Math.Max(0, this.CurLife - damage);
			this.RoleHead.RefreshLifeBar((float)num / (float)this.MaxLife);
			float duration = 0.2f;
			this.TweenerDamage = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateDamage, (float)this.CurLife, (float)num, duration, 0f, LTweenEase.OutCubic);
			if (this.TweenerDamage != null)
			{
				this.TweenerDamage.OnCompleteCallBack.Bind(new Action(this.OnTweenerEnd));
				this.TweenerDamage.SetEase(LTweenEase.CurveFloat);
				this.TweenerDamage.SetCurveFloat(curve);
			}
		}

		// Token: 0x0602AE86 RID: 175750 RVA: 0x00C12B1C File Offset: 0x00C10D1C
		public void SetBarActive(bool isOwn)
		{
			this.RoleHead.SetBarActive(isOwn);
		}

		// Token: 0x0602AE87 RID: 175751 RVA: 0x00C12B2A File Offset: 0x00C10D2A
		public void RefreshHeadIcon(string headIcon)
		{
			this.RoleHead.RefreshRoleIcon(headIcon);
		}

		// Token: 0x0602AE88 RID: 175752 RVA: 0x00C12B38 File Offset: 0x00C10D38
		public void RefreshShieldNum(int shieldNum)
		{
			if (shieldNum > this.LastShieldNum && this.LastShieldNum == 0)
			{
				base.GetText(5).SetText(shieldNum.ToString(), true);
				base.GetItem(4).SetUIActive(true);
				this.LastShieldNum = shieldNum;
				return;
			}
			if (shieldNum >= this.LastShieldNum)
			{
				base.GetText(5).SetText(shieldNum.ToString(), true);
				this.LastShieldNum = shieldNum;
				return;
			}
			if (shieldNum == 0)
			{
				base.GetItem(4).SetUIActive(false);
				this.LastShieldNum = shieldNum;
				return;
			}
			int num = shieldNum - this.LastShieldNum;
			base.GetText(5).SetText(shieldNum.ToString(), true);
			base.GetText(6).SetText(num.ToString(), true);
			this.LastShieldNum = shieldNum;
		}

		// Token: 0x0602AE89 RID: 175753 RVA: 0x00C12BF4 File Offset: 0x00C10DF4
		public void RegisterViewProxy(PhantomArenaBattleDetailsViewProxy viewProxy)
		{
			this.ViewProxy = viewProxy;
		}

		// Token: 0x0602AE8A RID: 175754 RVA: 0x00C12BFD File Offset: 0x00C10DFD
		public void OnAccumulateAfterEvent()
		{
			PhantomArenaHeadItem roleHead = this.RoleHead;
			if (roleHead == null)
			{
				return;
			}
			roleHead.PlayAccumulateDamage();
		}

		// Token: 0x0602AE8B RID: 175755 RVA: 0x00C12C0F File Offset: 0x00C10E0F
		public FVectorDouble GetHeadLocation()
		{
			return base.GetItem(0).D_K2_GetComponentLocation();
		}

		// Token: 0x0602AE8C RID: 175756 RVA: 0x00C12C20 File Offset: 0x00C10E20
		private void TweenCallDamage(float value)
		{
			PhantomArenaHeadItem roleHead = this.RoleHead;
			if (roleHead != null)
			{
				roleHead.RefreshDamageBar(value / (float)this.MaxLife);
			}
			int num = Math.Max(0, (int)Math.Floor((double)value));
			base.GetText(1).SetText(num.ToString() + "/" + this.MaxLife.ToString(), true);
		}

		// Token: 0x0602AE8D RID: 175757 RVA: 0x00C12C7F File Offset: 0x00C10E7F
		private void OnTweenerEnd()
		{
			if (this.TweenerDamage != null)
			{
				this.TweenerDamage = null;
			}
		}

		// Token: 0x04017374 RID: 95092
		protected PhantomArenaHeadItem RoleHead;

		// Token: 0x04017375 RID: 95093
		protected PhantomArenaBattleDetailsViewProxy ViewProxy;

		// Token: 0x04017376 RID: 95094
		protected ULTweener TweenerDamage;

		// Token: 0x04017377 RID: 95095
		protected FLTweenFloatSetterDynamic DelegateDamage;

		// Token: 0x04017378 RID: 95096
		public bool IsOwn;

		// Token: 0x04017379 RID: 95097
		protected int MaxLife;

		// Token: 0x0401737A RID: 95098
		protected int CurLife;

		// Token: 0x0401737B RID: 95099
		protected int LastShieldNum;

		// Token: 0x02009E9B RID: 40603
		[NullableContext(0)]
		private class ERoleItem
		{
			// Token: 0x040314CA RID: 201930
			public const int HeadItem = 0;

			// Token: 0x040314CB RID: 201931
			public const int LifeNum = 1;

			// Token: 0x040314CC RID: 201932
			public const int PanelHit = 2;

			// Token: 0x040314CD RID: 201933
			public const int HitNum = 3;

			// Token: 0x040314CE RID: 201934
			public const int ShieldItem = 4;

			// Token: 0x040314CF RID: 201935
			public const int ShieldNum = 5;

			// Token: 0x040314D0 RID: 201936
			public const int ShieldReduceNum = 6;
		}
	}
}
