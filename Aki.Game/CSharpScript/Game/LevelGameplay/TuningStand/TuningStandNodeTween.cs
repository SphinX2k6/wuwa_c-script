using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B28 RID: 23336
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandNodeTween
	{
		// Token: 0x0603966E RID: 235118 RVA: 0x0101B9C8 File Offset: 0x01019BC8
		public TuningStandNodeTween(UUIItem nodeItem, string curveNameX)
		{
			this.NodeItem = nodeItem;
			this.CurveNameX = curveNameX;
			this.DelegateX = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallX));
			this.DelegateZ = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallZ));
			this.SequencePlayer = new LevelSequencePlayer(this.NodeItem);
		}

		// Token: 0x17006D57 RID: 27991
		// (get) Token: 0x0603966F RID: 235119 RVA: 0x0101BA28 File Offset: 0x01019C28
		protected UUIItem NodeItem { get; }

		// Token: 0x17006D58 RID: 27992
		// (get) Token: 0x06039670 RID: 235120 RVA: 0x0101BA30 File Offset: 0x01019C30
		protected string CurveNameX { get; }

		// Token: 0x06039671 RID: 235121 RVA: 0x0101BA38 File Offset: 0x01019C38
		private void TweenCallX(float value)
		{
			FVectorDouble fvectorDouble = this.NodeItem.D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create((double)value, fvectorDouble.Y, fvectorDouble.Z).ToUeVector(false);
			this.NodeItem.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06039672 RID: 235122 RVA: 0x0101BA80 File Offset: 0x01019C80
		private void TweenCallZ(float value)
		{
			FVectorDouble fvectorDouble = this.NodeItem.D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create(fvectorDouble.X, fvectorDouble.Y, (double)value).ToUeVector(false);
			this.NodeItem.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06039673 RID: 235123 RVA: 0x0101BAC6 File Offset: 0x01019CC6
		private void OnTweenerEndX()
		{
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			EventSystem.Instance.Emit(EEventName.TuningStandSuccessShowEnd);
		}

		// Token: 0x06039674 RID: 235124 RVA: 0x0101BAE7 File Offset: 0x01019CE7
		private void OnTweenerEndZ()
		{
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
		}

		// Token: 0x06039675 RID: 235125 RVA: 0x0101BAF8 File Offset: 0x01019CF8
		public UniTask InitCurveDamage()
		{
			TuningStandNodeTween.<InitCurveDamage>d__18 <InitCurveDamage>d__;
			<InitCurveDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamage>d__.<>4__this = this;
			<InitCurveDamage>d__.<>1__state = -1;
			<InitCurveDamage>d__.<>t__builder.Start<TuningStandNodeTween.<InitCurveDamage>d__18>(ref <InitCurveDamage>d__);
			return <InitCurveDamage>d__.<>t__builder.Task;
		}

		// Token: 0x06039676 RID: 235126 RVA: 0x0101BB3C File Offset: 0x01019D3C
		public void PlayTween(FVectorDouble start, FVectorDouble end, bool needVisible = true)
		{
			this.TweenerX = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateX, (float)start.X, (float)end.X, 1f, 0f, LTweenEase.OutCubic);
			this.TweenerZ = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateZ, (float)start.Z, (float)end.Z, 1f, 0f, LTweenEase.OutCubic);
			this.NodeItem.SetUIActive(needVisible);
			this.NodeItem.D_K2_SetWorldLocation(start, false, ref WorldGlobal.SweepHitResult, false);
			this.SequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			if (this.TweenerX != null)
			{
				this.TweenerX.SetEase(LTweenEase.CurveFloat);
				this.TweenerX.SetCurveFloat(this.CurveX);
				this.TweenerX.OnCompleteCallBack.Bind(new Action(this.OnTweenerEndX));
			}
			if (this.TweenerZ != null)
			{
				this.TweenerZ.SetEase(LTweenEase.CurveFloat);
				this.TweenerZ.SetCurveFloat(this.CurveZ);
				this.TweenerZ.OnCompleteCallBack.Bind(new Action(this.OnTweenerEndZ));
			}
		}

		// Token: 0x06039677 RID: 235127 RVA: 0x0101BC6C File Offset: 0x01019E6C
		public void Clear()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCallX));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCallZ));
			this.CurveX = null;
			this.CurveZ = null;
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0401E477 RID: 124023
		[Nullable(2)]
		protected ULTweener TweenerX;

		// Token: 0x0401E478 RID: 124024
		[Nullable(2)]
		protected ULTweener TweenerZ;

		// Token: 0x0401E479 RID: 124025
		protected FLTweenFloatSetterDynamic DelegateX;

		// Token: 0x0401E47A RID: 124026
		protected FLTweenFloatSetterDynamic DelegateZ;

		// Token: 0x0401E47B RID: 124027
		[Nullable(2)]
		protected UCurveFloat CurveX;

		// Token: 0x0401E47C RID: 124028
		[Nullable(2)]
		protected UCurveFloat CurveZ;

		// Token: 0x0401E47D RID: 124029
		[Nullable(2)]
		protected LevelSequencePlayer SequencePlayer;
	}
}
