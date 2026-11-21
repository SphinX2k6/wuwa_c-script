using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02004242 RID: 16962
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsSkillItem : UiPanelBase
	{
		// Token: 0x0602AE8F RID: 175759 RVA: 0x00C12C98 File Offset: 0x00C10E98
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

		// Token: 0x0602AE90 RID: 175760 RVA: 0x00C12D34 File Offset: 0x00C10F34
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.DelegateX = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallX));
			this.DelegateZ = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenerCallZ));
			base.GetUiNiagara(5).SetUIActive(false);
		}

		// Token: 0x0602AE91 RID: 175761 RVA: 0x00C12D90 File Offset: 0x00C10F90
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

		// Token: 0x0602AE92 RID: 175762 RVA: 0x00C12DE0 File Offset: 0x00C10FE0
		public void RefreshIcon(string icon)
		{
			base.SetTextureByPath(icon, base.GetTexture(0), null, null);
		}

		// Token: 0x0602AE93 RID: 175763 RVA: 0x00C12E05 File Offset: 0x00C11005
		public void RefreshSettlePointText(int settlePoint)
		{
			this.SettlePoint = settlePoint;
			base.GetText(1).SetText(settlePoint.ToString(), true);
		}

		// Token: 0x0602AE94 RID: 175764 RVA: 0x00C12E24 File Offset: 0x00C11024
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

		// Token: 0x0602AE95 RID: 175765 RVA: 0x00C12E6D File Offset: 0x00C1106D
		public int GetDamage()
		{
			return this.SettlePoint;
		}

		// Token: 0x0602AE96 RID: 175766 RVA: 0x00C12E78 File Offset: 0x00C11078
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

		// Token: 0x0602AE97 RID: 175767 RVA: 0x00C12F78 File Offset: 0x00C11178
		private void TweenCallX(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(5).D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create((double)value, fvectorDouble.Y, fvectorDouble.Z).ToUeVector(false);
			base.GetUiNiagara(5).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x0602AE98 RID: 175768 RVA: 0x00C12FC0 File Offset: 0x00C111C0
		private void TweenerCallZ(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(5).D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create(fvectorDouble.X, fvectorDouble.Y, (double)value).ToUeVector(false);
			base.GetUiNiagara(5).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x0602AE99 RID: 175769 RVA: 0x00C13008 File Offset: 0x00C11208
		private void OnTweenerXEnd()
		{
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			base.GetUiNiagara(5).SetUIActive(false);
		}

		// Token: 0x0602AE9A RID: 175770 RVA: 0x00C13026 File Offset: 0x00C11226
		private void OnTweenerZEnd()
		{
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
		}

		// Token: 0x0401737C RID: 95100
		protected ULTweener TweenerX;

		// Token: 0x0401737D RID: 95101
		protected ULTweener TweenerZ;

		// Token: 0x0401737E RID: 95102
		protected FLTweenFloatSetterDynamic DelegateX;

		// Token: 0x0401737F RID: 95103
		protected FLTweenFloatSetterDynamic DelegateZ;

		// Token: 0x04017380 RID: 95104
		protected int SettlePoint;

		// Token: 0x04017381 RID: 95105
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x02009E9E RID: 40606
		[NullableContext(0)]
		private class ESkillItem
		{
			// Token: 0x040314D9 RID: 201945
			public const int Icon = 0;

			// Token: 0x040314DA RID: 201946
			public const int SettlePointText = 1;

			// Token: 0x040314DB RID: 201947
			public const int PanelSkill = 2;

			// Token: 0x040314DC RID: 201948
			public const int SpriteSkillCost = 3;

			// Token: 0x040314DD RID: 201949
			public const int Content = 4;

			// Token: 0x040314DE RID: 201950
			public const int NiagaraPoint = 5;
		}
	}
}
