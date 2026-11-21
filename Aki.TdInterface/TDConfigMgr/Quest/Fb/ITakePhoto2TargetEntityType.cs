using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200150A RID: 5386
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TargetEntityType : ITakePhoto2Target
	{
		// Token: 0x060079EF RID: 31215 RVA: 0x00123327 File Offset: 0x00121527
		[NullableContext(0)]
		public static ITakePhoto2TargetEntityType Create(ITakePhoto2TargetEntityType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetEntityType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x060079F0 RID: 31216 RVA: 0x00123346 File Offset: 0x00121546
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x060079F1 RID: 31217 RVA: 0x00123354 File Offset: 0x00121554
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

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x060079F2 RID: 31218 RVA: 0x0012338A File Offset: 0x0012158A
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

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x060079F3 RID: 31219 RVA: 0x001233BE File Offset: 0x001215BE
		[Nullable(0)]
		public virtual IEntityCategory EntityCategory
		{
			[NullableContext(0)]
			get
			{
				if (this._EntityCategoryInited)
				{
					return this._EntityCategoryCache;
				}
				this._EntityCategoryInited = true;
				this._EntityCategoryCache = IEntityCategory.Create(this.Instance.EntityCategory);
				return this._EntityCategoryCache;
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x001233F2 File Offset: 0x001215F2
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

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x060079F5 RID: 31221 RVA: 0x00123426 File Offset: 0x00121626
		public virtual ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition
		{
			get
			{
				if (this._TargetPlayMontageConditionInited)
				{
					return this._TargetPlayMontageConditionCache;
				}
				this._TargetPlayMontageConditionInited = true;
				this._TargetPlayMontageConditionCache = ITakePhoto2TargetPlayMontageCondition.Create(this.Instance.TargetPlayMontageCondition);
				return this._TargetPlayMontageConditionCache;
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x060079F6 RID: 31222 RVA: 0x0012345A File Offset: 0x0012165A
		public virtual ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition
		{
			get
			{
				if (this._TargetAnsTagConditionInited)
				{
					return this._TargetAnsTagConditionCache;
				}
				this._TargetAnsTagConditionInited = true;
				this._TargetAnsTagConditionCache = ITakePhoto2TargetAnsTagCondition.Create(this.Instance.TargetAnsTagCondition);
				return this._TargetAnsTagConditionCache;
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x060079F7 RID: 31223 RVA: 0x0012348E File Offset: 0x0012168E
		public virtual int TargetSatisfiedCount
		{
			get
			{
				return this.Instance.TargetSatisfiedCount;
			}
		}

		// Token: 0x04004630 RID: 17968
		private ITakePhoto2TargetEntityType Instance;

		// Token: 0x04004631 RID: 17969
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04004632 RID: 17970
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04004633 RID: 17971
		private IEntityCategory _EntityCategoryCache;

		// Token: 0x04004634 RID: 17972
		private bool _EntityCategoryInited;

		// Token: 0x04004635 RID: 17973
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04004636 RID: 17974
		private bool _TargetPosConditionInited;

		// Token: 0x04004637 RID: 17975
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x04004638 RID: 17976
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x04004639 RID: 17977
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x0400463A RID: 17978
		private bool _TargetAnsTagConditionInited;
	}
}
