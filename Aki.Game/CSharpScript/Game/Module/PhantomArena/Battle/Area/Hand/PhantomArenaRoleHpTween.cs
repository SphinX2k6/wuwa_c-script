using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand
{
	// Token: 0x0200429C RID: 17052
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleHpTween
	{
		// Token: 0x0602B2BB RID: 176827 RVA: 0x00C224F2 File Offset: 0x00C206F2
		public PhantomArenaRoleHpTween()
		{
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCall));
		}

		// Token: 0x0602B2BC RID: 176828 RVA: 0x00C22511 File Offset: 0x00C20711
		private void TweenCall(float value)
		{
			this.RoleItem.RefreshLifeNumTween(value, this.MaxLifeNum);
		}

		// Token: 0x0602B2BD RID: 176829 RVA: 0x00C22525 File Offset: 0x00C20725
		private void OnTweenerEnd()
		{
			if (this.Tweener != null)
			{
				this.Tweener = null;
			}
		}

		// Token: 0x0602B2BE RID: 176830 RVA: 0x00C22536 File Offset: 0x00C20736
		public void SetRoleItem(PhantomArenaRoleItem roleItem)
		{
			this.RoleItem = roleItem;
		}

		// Token: 0x0602B2BF RID: 176831 RVA: 0x00C22540 File Offset: 0x00C20740
		public UniTask InitCurveDamage()
		{
			PhantomArenaRoleHpTween.<InitCurveDamage>d__9 <InitCurveDamage>d__;
			<InitCurveDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamage>d__.<>4__this = this;
			<InitCurveDamage>d__.<>1__state = -1;
			<InitCurveDamage>d__.<>t__builder.Start<PhantomArenaRoleHpTween.<InitCurveDamage>d__9>(ref <InitCurveDamage>d__);
			return <InitCurveDamage>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2C0 RID: 176832 RVA: 0x00C22584 File Offset: 0x00C20784
		public void PlayHpTween(int oldLife, int lifeNum, int maxLifeNum)
		{
			this.MaxLifeNum = maxLifeNum;
			this.RoleItem.RefreshLifeNumTweenStart(lifeNum, maxLifeNum);
			this.RoleItem.RefreshLifeNumTween((float)oldLife, this.MaxLifeNum);
			this.Tweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, (float)oldLife, (float)lifeNum, 0.4f, 0f, LTweenEase.OutCubic);
			if (this.Tweener != null)
			{
				this.Tweener.SetEase(LTweenEase.CurveFloat);
				this.Tweener.SetCurveFloat(this.CurveDamage);
				this.Tweener.OnCompleteCallBack.Bind(new Action(this.OnTweenerEnd));
			}
		}

		// Token: 0x0602B2C1 RID: 176833 RVA: 0x00C22621 File Offset: 0x00C20821
		public void Clear()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCall));
			this.CurveDamage = null;
		}

		// Token: 0x04017506 RID: 95494
		protected PhantomArenaRoleItem RoleItem;

		// Token: 0x04017507 RID: 95495
		protected int MaxLifeNum;

		// Token: 0x04017508 RID: 95496
		protected UCurveFloat CurveDamage;

		// Token: 0x04017509 RID: 95497
		protected ULTweener Tweener;

		// Token: 0x0401750A RID: 95498
		protected FLTweenFloatSetterDynamic Delegate;
	}
}
