using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B9 RID: 5049
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TargetEntityType : ITakePhoto2Target
	{
		// Token: 0x06007348 RID: 29512 RVA: 0x00114C6B File Offset: 0x00112E6B
		[NullableContext(1)]
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

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x06007349 RID: 29513 RVA: 0x00114C8A File Offset: 0x00112E8A
		public override ETakePhoto2TargetType Type
		{
			get
			{
				return (ETakePhoto2TargetType)this.Instance.Type;
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x0600734A RID: 29514 RVA: 0x00114C98 File Offset: 0x00112E98
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

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x0600734B RID: 29515 RVA: 0x00114CCE File Offset: 0x00112ECE
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

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x0600734C RID: 29516 RVA: 0x00114D02 File Offset: 0x00112F02
		[Nullable(1)]
		public virtual IEntityCategory EntityCategory
		{
			[NullableContext(1)]
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

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x00114D36 File Offset: 0x00112F36
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

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x0600734E RID: 29518 RVA: 0x00114D6A File Offset: 0x00112F6A
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

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x0600734F RID: 29519 RVA: 0x00114D9E File Offset: 0x00112F9E
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

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x06007350 RID: 29520 RVA: 0x00114DD2 File Offset: 0x00112FD2
		public virtual int TargetSatisfiedCount
		{
			get
			{
				return this.Instance.TargetSatisfiedCount;
			}
		}

		// Token: 0x040042AF RID: 17071
		private ITakePhoto2TargetEntityType Instance;

		// Token: 0x040042B0 RID: 17072
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x040042B1 RID: 17073
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x040042B2 RID: 17074
		private IEntityCategory _EntityCategoryCache;

		// Token: 0x040042B3 RID: 17075
		private bool _EntityCategoryInited;

		// Token: 0x040042B4 RID: 17076
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x040042B5 RID: 17077
		private bool _TargetPosConditionInited;

		// Token: 0x040042B6 RID: 17078
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x040042B7 RID: 17079
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x040042B8 RID: 17080
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x040042B9 RID: 17081
		private bool _TargetAnsTagConditionInited;
	}
}
