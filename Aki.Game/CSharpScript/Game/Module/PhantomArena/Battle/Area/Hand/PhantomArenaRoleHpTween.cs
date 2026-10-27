using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand
{
	// Token: 0x020052CC RID: 21196
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleHpTween
	{
		// Token: 0x060363C0 RID: 222144 RVA: 0x00CD4DCA File Offset: 0x00CD2FCA
		public PhantomArenaRoleHpTween()
		{
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCall));
		}

		// Token: 0x060363C1 RID: 222145 RVA: 0x00CD4DE9 File Offset: 0x00CD2FE9
		private void TweenCall(float value)
		{
			this.RoleItem.RefreshLifeNumTween(value, this.MaxLifeNum);
		}

		// Token: 0x060363C2 RID: 222146 RVA: 0x00CD4DFD File Offset: 0x00CD2FFD
		private void OnTweenerEnd()
		{
			if (this.Tweener != null)
			{
				this.Tweener = null;
			}
		}

		// Token: 0x060363C3 RID: 222147 RVA: 0x00CD4E0E File Offset: 0x00CD300E
		public void SetRoleItem(PhantomArenaRoleItem roleItem)
		{
			this.RoleItem = roleItem;
		}

		// Token: 0x060363C4 RID: 222148 RVA: 0x00CD4E18 File Offset: 0x00CD3018
		public UniTask InitCurveDamage()
		{
			PhantomArenaRoleHpTween.<InitCurveDamage>d__9 <InitCurveDamage>d__;
			<InitCurveDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamage>d__.<>4__this = this;
			<InitCurveDamage>d__.<>1__state = -1;
			<InitCurveDamage>d__.<>t__builder.Start<PhantomArenaRoleHpTween.<InitCurveDamage>d__9>(ref <InitCurveDamage>d__);
			return <InitCurveDamage>d__.<>t__builder.Task;
		}

		// Token: 0x060363C5 RID: 222149 RVA: 0x00CD4E5C File Offset: 0x00CD305C
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

		// Token: 0x060363C6 RID: 222150 RVA: 0x00CD4EF9 File Offset: 0x00CD30F9
		public void Clear()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCall));
			this.CurveDamage = null;
		}

		// Token: 0x0401CAD1 RID: 117457
		protected PhantomArenaRoleItem RoleItem;

		// Token: 0x0401CAD2 RID: 117458
		protected int MaxLifeNum;

		// Token: 0x0401CAD3 RID: 117459
		protected UCurveFloat CurveDamage;

		// Token: 0x0401CAD4 RID: 117460
		protected ULTweener Tweener;

		// Token: 0x0401CAD5 RID: 117461
		protected FLTweenFloatSetterDynamic Delegate;
	}
}
