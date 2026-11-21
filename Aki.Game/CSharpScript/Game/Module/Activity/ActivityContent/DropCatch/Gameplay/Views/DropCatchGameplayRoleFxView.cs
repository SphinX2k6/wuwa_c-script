using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005658 RID: 22104
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayRoleFxView : UiPanelBase
	{
		// Token: 0x0603695F RID: 223583 RVA: 0x00F3B8D4 File Offset: 0x00F39AD4
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

		// Token: 0x06036960 RID: 223584 RVA: 0x00F3B944 File Offset: 0x00F39B44
		protected override void OnStart()
		{
			this.ResetView();
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnTweenUpdate));
		}

		// Token: 0x06036961 RID: 223585 RVA: 0x00F3B963 File Offset: 0x00F39B63
		public void PlayShield()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(true);
			}
			this.PlayShieldTween(0f, 1f, this.TWEENTIME, LTweenEase.InOutSine, null);
		}

		// Token: 0x06036962 RID: 223586 RVA: 0x00F3B991 File Offset: 0x00F39B91
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

		// Token: 0x06036963 RID: 223587 RVA: 0x00F3B9B8 File Offset: 0x00F39BB8
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

		// Token: 0x06036964 RID: 223588 RVA: 0x00F3B9DE File Offset: 0x00F39BDE
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

		// Token: 0x06036965 RID: 223589 RVA: 0x00F3BA05 File Offset: 0x00F39C05
		public void HideSpeedUp()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x06036966 RID: 223590 RVA: 0x00F3BA19 File Offset: 0x00F39C19
		private void OnTweenUpdate(float value)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetNiagaraVarFloat("Dissolve", value);
		}

		// Token: 0x06036967 RID: 223591 RVA: 0x00F3BA34 File Offset: 0x00F39C34
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

		// Token: 0x06036968 RID: 223592 RVA: 0x00F3BA91 File Offset: 0x00F39C91
		private void KillTweener()
		{
			if (this.Tweener != null)
			{
				this.Tweener.Kill(false);
				this.Tweener = null;
			}
		}

		// Token: 0x06036969 RID: 223593 RVA: 0x00F3BAAE File Offset: 0x00F39CAE
		protected override void OnBeforeDestroy()
		{
			this.KillTweener();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnTweenUpdate));
		}

		// Token: 0x0603696A RID: 223594 RVA: 0x00F3BAC8 File Offset: 0x00F39CC8
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

		// Token: 0x0401CD80 RID: 118144
		private readonly float TWEENTIME = 0.4f;

		// Token: 0x0401CD81 RID: 118145
		private ULTweener Tweener;

		// Token: 0x0401CD82 RID: 118146
		private FLTweenFloatSetterDynamic Delegate;
	}
}
