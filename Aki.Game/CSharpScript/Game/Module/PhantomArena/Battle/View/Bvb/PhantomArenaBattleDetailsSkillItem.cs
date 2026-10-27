using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02005272 RID: 21106
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsSkillItem : UiPanelBase
	{
		// Token: 0x06035F94 RID: 221076 RVA: 0x00CC5598 File Offset: 0x00CC3798
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUINiagara))
			};
		}

		// Token: 0x06035F95 RID: 221077 RVA: 0x00CC5634 File Offset: 0x00CC3834
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.DelegateX = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallX));
			this.DelegateZ = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenerCallZ));
			base.GetUiNiagara(5).SetUIActive(false);
		}

		// Token: 0x06035F96 RID: 221078 RVA: 0x00CC5690 File Offset: 0x00CC3890
		protected override void OnBeforeDestroy()
		{
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCallX));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenerCallZ));
		}

		// Token: 0x06035F97 RID: 221079 RVA: 0x00CC56E0 File Offset: 0x00CC38E0
		public void RefreshIcon(string icon)
		{
			base.SetTextureByPath(icon, base.GetTexture(0), null, null);
		}

		// Token: 0x06035F98 RID: 221080 RVA: 0x00CC5705 File Offset: 0x00CC3905
		public void RefreshSettlePointText(int settlePoint)
		{
			this.SettlePoint = settlePoint;
			base.GetText(1).SetText(settlePoint.ToString(), true);
		}

		// Token: 0x06035F99 RID: 221081 RVA: 0x00CC5724 File Offset: 0x00CC3924
		public int ShowWinAnim()
		{
			if (this.SettlePoint == 0)
			{
				return 0;
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName(EPhantomBattleHeadAnim.DamageAccumulate.ToString(), false, null, false);
			}
			return this.SettlePoint;
		}

		// Token: 0x06035F9A RID: 221082 RVA: 0x00CC576D File Offset: 0x00CC396D
		public int GetDamage()
		{
			return this.SettlePoint;
		}

		// Token: 0x06035F9B RID: 221083 RVA: 0x00CC5778 File Offset: 0x00CC3978
		public void OnAccumulateEvent(float endX, float endZ, UCurveFloat curveCommon)
		{
			if (this.SettlePoint == 0)
			{
				return;
			}
			base.GetUiNiagara(5).SetUIActive(true);
			FVectorDouble fvectorDouble = base.GetTexture(0).D_K2_GetComponentLocation();
			this.TweenerX = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateX, (float)fvectorDouble.X, endX, 0.3f, 0f, LTweenEase.OutCubic);
			this.TweenerZ = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateZ, (float)fvectorDouble.Z, endZ, 0.3f, 0f, LTweenEase.OutCubic);
			if (this.TweenerX != null)
			{
				this.TweenerX.SetEase(LTweenEase.CurveFloat);
				this.TweenerX.SetCurveFloat(curveCommon);
				this.TweenerX.OnCompleteCallBack.Bind(new Action(this.OnTweenerXEnd));
			}
			if (this.TweenerZ != null)
			{
				this.TweenerZ.SetEase(LTweenEase.CurveFloat);
				this.TweenerZ.SetCurveFloat(curveCommon);
				this.TweenerZ.OnCompleteCallBack.Bind(new Action(this.OnTweenerZEnd));
			}
		}

		// Token: 0x06035F9C RID: 221084 RVA: 0x00CC5878 File Offset: 0x00CC3A78
		private void TweenCallX(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(5).D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create((double)value, fvectorDouble.Y, fvectorDouble.Z).ToUeVector(false);
			base.GetUiNiagara(5).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06035F9D RID: 221085 RVA: 0x00CC58C0 File Offset: 0x00CC3AC0
		private void TweenerCallZ(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(5).D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create(fvectorDouble.X, fvectorDouble.Y, (double)value).ToUeVector(false);
			base.GetUiNiagara(5).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06035F9E RID: 221086 RVA: 0x00CC5908 File Offset: 0x00CC3B08
		private void OnTweenerXEnd()
		{
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			base.GetUiNiagara(5).SetUIActive(false);
		}

		// Token: 0x06035F9F RID: 221087 RVA: 0x00CC5926 File Offset: 0x00CC3B26
		private void OnTweenerZEnd()
		{
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
		}

		// Token: 0x0401C947 RID: 117063
		protected ULTweener TweenerX;

		// Token: 0x0401C948 RID: 117064
		protected ULTweener TweenerZ;

		// Token: 0x0401C949 RID: 117065
		protected FLTweenFloatSetterDynamic DelegateX;

		// Token: 0x0401C94A RID: 117066
		protected FLTweenFloatSetterDynamic DelegateZ;

		// Token: 0x0401C94B RID: 117067
		protected int SettlePoint;

		// Token: 0x0401C94C RID: 117068
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B466 RID: 46182
		[NullableContext(0)]
		private class ESkillItem
		{
			// Token: 0x04036A86 RID: 223878
			public const int Icon = 0;

			// Token: 0x04036A87 RID: 223879
			public const int SettlePointText = 1;

			// Token: 0x04036A88 RID: 223880
			public const int PanelSkill = 2;

			// Token: 0x04036A89 RID: 223881
			public const int SpriteSkillCost = 3;

			// Token: 0x04036A8A RID: 223882
			public const int Content = 4;

			// Token: 0x04036A8B RID: 223883
			public const int NiagaraPoint = 5;
		}
	}
}
