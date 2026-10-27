using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069CC RID: 27084
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandNodeTween
	{
		// Token: 0x06043632 RID: 276018 RVA: 0x01077534 File Offset: 0x01075734
		public TuningStandNodeTween(UUIItem nodeItem, string curveNameX)
		{
			this.NodeItem = nodeItem;
			this.CurveNameX = curveNameX;
			this.DelegateX = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallX));
			this.DelegateZ = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallZ));
			this.SequencePlayer = new LevelSequencePlayer(this.NodeItem);
		}

		// Token: 0x17009877 RID: 39031
		// (get) Token: 0x06043633 RID: 276019 RVA: 0x01077594 File Offset: 0x01075794
		protected UUIItem NodeItem { get; }

		// Token: 0x17009878 RID: 39032
		// (get) Token: 0x06043634 RID: 276020 RVA: 0x0107759C File Offset: 0x0107579C
		protected string CurveNameX { get; }

		// Token: 0x06043635 RID: 276021 RVA: 0x010775A4 File Offset: 0x010757A4
		private void TweenCallX(float value)
		{
			FVectorDouble fvectorDouble = this.NodeItem.D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create((double)value, fvectorDouble.Y, fvectorDouble.Z).ToUeVector(false);
			this.NodeItem.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06043636 RID: 276022 RVA: 0x010775EC File Offset: 0x010757EC
		private void TweenCallZ(float value)
		{
			FVectorDouble fvectorDouble = this.NodeItem.D_K2_GetComponentLocation();
			FVectorDouble newLocation = Vector.Create(fvectorDouble.X, fvectorDouble.Y, (double)value).ToUeVector(false);
			this.NodeItem.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06043637 RID: 276023 RVA: 0x01077632 File Offset: 0x01075832
		private void OnTweenerEndX()
		{
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			EventSystem.Instance.Emit(EEventName.TuningStandSuccessShowEnd);
		}

		// Token: 0x06043638 RID: 276024 RVA: 0x01077653 File Offset: 0x01075853
		private void OnTweenerEndZ()
		{
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
		}

		// Token: 0x06043639 RID: 276025 RVA: 0x01077664 File Offset: 0x01075864
		public UniTask InitCurveDamage()
		{
			TuningStandNodeTween.<InitCurveDamage>d__18 <InitCurveDamage>d__;
			<InitCurveDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamage>d__.<>4__this = this;
			<InitCurveDamage>d__.<>1__state = -1;
			<InitCurveDamage>d__.<>t__builder.Start<TuningStandNodeTween.<InitCurveDamage>d__18>(ref <InitCurveDamage>d__);
			return <InitCurveDamage>d__.<>t__builder.Task;
		}

		// Token: 0x0604363A RID: 276026 RVA: 0x010776A8 File Offset: 0x010758A8
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

		// Token: 0x0604363B RID: 276027 RVA: 0x010777D8 File Offset: 0x010759D8
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

		// Token: 0x04023287 RID: 144007
		[Nullable(2)]
		protected ULTweener TweenerX;

		// Token: 0x04023288 RID: 144008
		[Nullable(2)]
		protected ULTweener TweenerZ;

		// Token: 0x04023289 RID: 144009
		protected FLTweenFloatSetterDynamic DelegateX;

		// Token: 0x0402328A RID: 144010
		protected FLTweenFloatSetterDynamic DelegateZ;

		// Token: 0x0402328B RID: 144011
		[Nullable(2)]
		protected UCurveFloat CurveX;

		// Token: 0x0402328C RID: 144012
		[Nullable(2)]
		protected UCurveFloat CurveZ;

		// Token: 0x0402328D RID: 144013
		[Nullable(2)]
		protected LevelSequencePlayer SequencePlayer;
	}
}
