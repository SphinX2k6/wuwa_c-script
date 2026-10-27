using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013BA RID: 5050
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TaggedActorTarget : ITakePhoto2Target
	{
		// Token: 0x06007352 RID: 29522 RVA: 0x00114DE7 File Offset: 0x00112FE7
		[NullableContext(1)]
		public static ITakePhoto2TaggedActorTarget Create(ITakePhoto2TaggedActorTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TaggedActorTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x06007353 RID: 29523 RVA: 0x00114E06 File Offset: 0x00113006
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x06007354 RID: 29524 RVA: 0x00114E14 File Offset: 0x00113014
		public override bool? IsOptionalTarget
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOptionalTarget);
			}
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x06007355 RID: 29525 RVA: 0x00114E4A File Offset: 0x0011304A
		public override ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
		{
			get
			{
				if (this._TargetCameraDistanceConditionInited)
				{
					return this._TargetCameraDistanceConditionCache;
				}
				this._TargetCameraDistanceConditionInited = true;
				this._TargetCameraDistanceConditionCache = ITakePhoto2TargetCameraDistanceCondition.Create(this.Instance.TargetCameraDistanceCondition);
				return this._TargetCameraDistanceConditionCache;
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x06007356 RID: 29526 RVA: 0x00114E7E File Offset: 0x0011307E
		[Nullable(1)]
		public virtual string Tag
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06007357 RID: 29527 RVA: 0x00114E8B File Offset: 0x0011308B
		public virtual ITakePhoto2TargetPosByRangeCondition TargetPosCondition
		{
			get
			{
				if (this._TargetPosConditionInited)
				{
					return this._TargetPosConditionCache;
				}
				this._TargetPosConditionInited = true;
				this._TargetPosConditionCache = ITakePhoto2TargetPosByRangeCondition.Create(this.Instance.TargetPosCondition);
				return this._TargetPosConditionCache;
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06007358 RID: 29528 RVA: 0x00114EBF File Offset: 0x001130BF
		public virtual int TargetSatisfiedCount
		{
			get
			{
				return this.Instance.TargetSatisfiedCount;
			}
		}

		// Token: 0x040042BA RID: 17082
		private ITakePhoto2TaggedActorTarget Instance;

		// Token: 0x040042BB RID: 17083
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x040042BC RID: 17084
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x040042BD RID: 17085
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x040042BE RID: 17086
		private bool _TargetPosConditionInited;
	}
}
