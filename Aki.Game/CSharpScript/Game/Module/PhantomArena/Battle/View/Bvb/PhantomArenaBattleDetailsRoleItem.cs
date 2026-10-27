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
	// Token: 0x02005271 RID: 21105
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsRoleItem : UiPanelBase
	{
		// Token: 0x06035F83 RID: 221059 RVA: 0x00CC5190 File Offset: 0x00CC3390
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

		// Token: 0x06035F84 RID: 221060 RVA: 0x00CC5242 File Offset: 0x00CC3442
		protected override void OnStart()
		{
			this.DelegateDamage = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallDamage));
		}

		// Token: 0x06035F85 RID: 221061 RVA: 0x00CC525B File Offset: 0x00CC345B
		protected override void OnBeforeDestroy()
		{
			if (this.TweenerDamage != null)
			{
				this.TweenerDamage = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCallDamage));
		}

		// Token: 0x06035F86 RID: 221062 RVA: 0x00CC5280 File Offset: 0x00CC3480
		private UniTask InitRoleHead()
		{
			PhantomArenaBattleDetailsRoleItem.<InitRoleHead>d__12 <InitRoleHead>d__;
			<InitRoleHead>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleHead>d__.<>4__this = this;
			<InitRoleHead>d__.<>1__state = -1;
			<InitRoleHead>d__.<>t__builder.Start<PhantomArenaBattleDetailsRoleItem.<InitRoleHead>d__12>(ref <InitRoleHead>d__);
			return <InitRoleHead>d__.<>t__builder.Task;
		}

		// Token: 0x06035F87 RID: 221063 RVA: 0x00CC52C4 File Offset: 0x00CC34C4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsRoleItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsRoleItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035F88 RID: 221064 RVA: 0x00CC5308 File Offset: 0x00CC3508
		public void RefreshLifeNum(int lifeNum, int maxLifeNum)
		{
			this.MaxLife = maxLifeNum;
			this.CurLife = lifeNum;
			base.GetText(1).SetText(lifeNum.ToString() + "/" + maxLifeNum.ToString(), true);
			this.RoleHead.RefreshLifeBar((float)lifeNum / (float)maxLifeNum);
		}

		// Token: 0x06035F89 RID: 221065 RVA: 0x00CC5358 File Offset: 0x00CC3558
		public void SetHitNum(int damage)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText("-" + damage.ToString(), true);
		}

		// Token: 0x06035F8A RID: 221066 RVA: 0x00CC5380 File Offset: 0x00CC3580
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

		// Token: 0x06035F8B RID: 221067 RVA: 0x00CC541C File Offset: 0x00CC361C
		public void SetBarActive(bool isOwn)
		{
			this.RoleHead.SetBarActive(isOwn);
		}

		// Token: 0x06035F8C RID: 221068 RVA: 0x00CC542A File Offset: 0x00CC362A
		public void RefreshHeadIcon(string headIcon)
		{
			this.RoleHead.RefreshRoleIcon(headIcon);
		}

		// Token: 0x06035F8D RID: 221069 RVA: 0x00CC5438 File Offset: 0x00CC3638
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

		// Token: 0x06035F8E RID: 221070 RVA: 0x00CC54F4 File Offset: 0x00CC36F4
		public void RegisterViewProxy(PhantomArenaBattleDetailsViewProxy viewProxy)
		{
			this.ViewProxy = viewProxy;
		}

		// Token: 0x06035F8F RID: 221071 RVA: 0x00CC54FD File Offset: 0x00CC36FD
		public void OnAccumulateAfterEvent()
		{
			PhantomArenaHeadItem roleHead = this.RoleHead;
			if (roleHead == null)
			{
				return;
			}
			roleHead.PlayAccumulateDamage();
		}

		// Token: 0x06035F90 RID: 221072 RVA: 0x00CC550F File Offset: 0x00CC370F
		public FVectorDouble GetHeadLocation()
		{
			return base.GetItem(0).D_K2_GetComponentLocation();
		}

		// Token: 0x06035F91 RID: 221073 RVA: 0x00CC5520 File Offset: 0x00CC3720
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

		// Token: 0x06035F92 RID: 221074 RVA: 0x00CC557F File Offset: 0x00CC377F
		private void OnTweenerEnd()
		{
			if (this.TweenerDamage != null)
			{
				this.TweenerDamage = null;
			}
		}

		// Token: 0x0401C93F RID: 117055
		protected PhantomArenaHeadItem RoleHead;

		// Token: 0x0401C940 RID: 117056
		protected PhantomArenaBattleDetailsViewProxy ViewProxy;

		// Token: 0x0401C941 RID: 117057
		protected ULTweener TweenerDamage;

		// Token: 0x0401C942 RID: 117058
		protected FLTweenFloatSetterDynamic DelegateDamage;

		// Token: 0x0401C943 RID: 117059
		public bool IsOwn;

		// Token: 0x0401C944 RID: 117060
		protected int MaxLife;

		// Token: 0x0401C945 RID: 117061
		protected int CurLife;

		// Token: 0x0401C946 RID: 117062
		protected int LastShieldNum;

		// Token: 0x0200B463 RID: 46179
		[NullableContext(0)]
		private class ERoleItem
		{
			// Token: 0x04036A77 RID: 223863
			public const int HeadItem = 0;

			// Token: 0x04036A78 RID: 223864
			public const int LifeNum = 1;

			// Token: 0x04036A79 RID: 223865
			public const int PanelHit = 2;

			// Token: 0x04036A7A RID: 223866
			public const int HitNum = 3;

			// Token: 0x04036A7B RID: 223867
			public const int ShieldItem = 4;

			// Token: 0x04036A7C RID: 223868
			public const int ShieldNum = 5;

			// Token: 0x04036A7D RID: 223869
			public const int ShieldReduceNum = 6;
		}
	}
}
