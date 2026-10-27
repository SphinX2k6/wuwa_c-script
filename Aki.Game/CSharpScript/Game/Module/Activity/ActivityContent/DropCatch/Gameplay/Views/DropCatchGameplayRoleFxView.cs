using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006708 RID: 26376
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayRoleFxView : UiPanelBase
	{
		// Token: 0x06041E13 RID: 269843 RVA: 0x00FFA4E0 File Offset: 0x00FF86E0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUINiagara)),
				new ValueTuple<int, Type>(1, typeof(UUINiagara)),
				new ValueTuple<int, Type>(2, typeof(UUINiagara)),
				new ValueTuple<int, Type>(3, typeof(UUINiagara))
			};
		}

		// Token: 0x06041E14 RID: 269844 RVA: 0x00FFA550 File Offset: 0x00FF8750
		protected override void OnStart()
		{
			this.ResetView();
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnTweenUpdate));
		}

		// Token: 0x06041E15 RID: 269845 RVA: 0x00FFA56F File Offset: 0x00FF876F
		public void PlayShield()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(true);
			}
			this.PlayShieldTween(0f, 1f, this.TWEENTIME, LTweenEase.InOutSine, null);
		}

		// Token: 0x06041E16 RID: 269846 RVA: 0x00FFA59D File Offset: 0x00FF879D
		public void PlayAdd()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(1);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(true);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(1);
			if (uiNiagara2 == null)
			{
				return;
			}
			uiNiagara2.ActivateSystem(true);
		}

		// Token: 0x06041E17 RID: 269847 RVA: 0x00FFA5C4 File Offset: 0x00FF87C4
		public void PlayShieldEnd()
		{
			this.PlayShieldTween(1f, 0f, this.TWEENTIME, LTweenEase.InOutSine, delegate
			{
				UUINiagara uiNiagara = base.GetUiNiagara(0);
				if (uiNiagara == null)
				{
					return;
				}
				uiNiagara.SetUIActive(false);
			});
		}

		// Token: 0x06041E18 RID: 269848 RVA: 0x00FFA5EA File Offset: 0x00FF87EA
		public void PlaySpeedUp()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(true);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(3);
			if (uiNiagara2 == null)
			{
				return;
			}
			uiNiagara2.ActivateSystem(true);
		}

		// Token: 0x06041E19 RID: 269849 RVA: 0x00FFA611 File Offset: 0x00FF8811
		public void HideSpeedUp()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x06041E1A RID: 269850 RVA: 0x00FFA625 File Offset: 0x00FF8825
		private void OnTweenUpdate(float value)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetNiagaraVarFloat("Dissolve", value);
		}

		// Token: 0x06041E1B RID: 269851 RVA: 0x00FFA640 File Offset: 0x00FF8840
		private void PlayShieldTween(float startValue, float endValue, float tweenTime, LTweenEase tweenEase, Action callback = null)
		{
			this.KillTweener();
			this.Tweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, startValue, endValue, tweenTime, 0f, tweenEase);
			this.Tweener.OnCompleteCallBack.Bind(delegate()
			{
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			});
		}

		// Token: 0x06041E1C RID: 269852 RVA: 0x00FFA69D File Offset: 0x00FF889D
		private void KillTweener()
		{
			if (this.Tweener != null)
			{
				this.Tweener.Kill(false);
				this.Tweener = null;
			}
		}

		// Token: 0x06041E1D RID: 269853 RVA: 0x00FFA6BA File Offset: 0x00FF88BA
		protected override void OnBeforeDestroy()
		{
			this.KillTweener();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnTweenUpdate));
		}

		// Token: 0x06041E1E RID: 269854 RVA: 0x00FFA6D4 File Offset: 0x00FF88D4
		public void ResetView()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(1);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(false);
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(2);
			if (uiNiagara3 != null)
			{
				uiNiagara3.SetUIActive(false);
			}
			UUINiagara uiNiagara4 = base.GetUiNiagara(3);
			if (uiNiagara4 == null)
			{
				return;
			}
			uiNiagara4.SetUIActive(false);
		}

		// Token: 0x04022527 RID: 140583
		private readonly float TWEENTIME = 0.4f;

		// Token: 0x04022528 RID: 140584
		private ULTweener Tweener;

		// Token: 0x04022529 RID: 140585
		private FLTweenFloatSetterDynamic Delegate;
	}
}
