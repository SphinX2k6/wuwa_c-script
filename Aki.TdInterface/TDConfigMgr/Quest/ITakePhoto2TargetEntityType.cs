using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B6 RID: 4790
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TargetEntityType : ITakePhoto2Target
	{
		// Token: 0x06006BDF RID: 27615 RVA: 0x001015AC File Offset: 0x000FF7AC
		[NullableContext(0)]
		private ITakePhoto2TargetEntityType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2TargetEntityType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2TargetEntityType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2TargetEntityType_SetValue());
			}
			return result;
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x001015E4 File Offset: 0x000FF7E4
		[NullableContext(0)]
		public static ITakePhoto2TargetEntityType Create([Nullable(2)] ITakePhoto2TargetEntityType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetEntityType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x001015F7 File Offset: 0x000FF7F7
		[NullableContext(0)]
		public static ITakePhoto2TargetEntityType CreateFromSetValue([Nullable(2)] ITakePhoto2TargetEntityType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2TargetEntityType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x0010160C File Offset: 0x000FF80C
		[NullableContext(0)]
		public new ITakePhoto2TargetEntityType_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetEntityType_SetValue
			{
				Type = this.Type,
				IsOptionalTarget = this.IsOptionalTarget,
				TargetCameraDistanceCondition = this.TargetCameraDistanceCondition,
				EntityCategory = this.EntityCategory,
				TargetPosCondition = this.TargetPosCondition,
				TargetPlayMontageCondition = this.TargetPlayMontageCondition,
				TargetAnsTagCondition = this.TargetAnsTagCondition,
				TargetSatisfiedCount = this.TargetSatisfiedCount
			};
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x0010167E File Offset: 0x000FF87E
		// (set) Token: 0x06006BE4 RID: 27620 RVA: 0x001016A9 File Offset: 0x000FF8A9
		public override ETakePhoto2TargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETakePhoto2TargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x001016B8 File Offset: 0x000FF8B8
		// (set) Token: 0x06006BE6 RID: 27622 RVA: 0x001016F2 File Offset: 0x000FF8F2
		public override bool? IsOptionalTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOptionalTarget;
				}
				ITakePhoto2TargetEntityType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOptionalTarget;
			}
			set
			{
				this.GetOrCreatePoco().IsOptionalTarget = value;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x06006BE7 RID: 27623 RVA: 0x00101700 File Offset: 0x000FF900
		// (set) Token: 0x06006BE8 RID: 27624 RVA: 0x00101761 File Offset: 0x000FF961
		public override ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition
		{
			get
			{
				if (this._TargetCameraDistanceConditionInited)
				{
					return this._TargetCameraDistanceConditionCache;
				}
				this._TargetCameraDistanceConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetCameraDistanceConditionCache = ITakePhoto2TargetCameraDistanceCondition.Create(this.FbInstance.TargetCameraDistanceCondition);
				}
				else
				{
					ITakePhoto2TargetEntityType_SetValue pocoInterface = this.PocoInterface;
					this._TargetCameraDistanceConditionCache = ((pocoInterface != null) ? pocoInterface.TargetCameraDistanceCondition : null);
				}
				return this._TargetCameraDistanceConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetCameraDistanceCondition = value;
				this._TargetCameraDistanceConditionInited = false;
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x06006BE9 RID: 27625 RVA: 0x00101778 File Offset: 0x000FF978
		// (set) Token: 0x06006BEA RID: 27626 RVA: 0x001017D9 File Offset: 0x000FF9D9
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
				if (this.FbInstance != null)
				{
					this._EntityCategoryCache = IEntityCategory.Create(this.FbInstance.EntityCategory);
				}
				else
				{
					ITakePhoto2TargetEntityType_SetValue pocoInterface = this.PocoInterface;
					this._EntityCategoryCache = ((pocoInterface != null) ? pocoInterface.EntityCategory : null);
				}
				return this._EntityCategoryCache;
			}
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().EntityCategory = value;
				this._EntityCategoryInited = false;
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x06006BEB RID: 27627 RVA: 0x001017F0 File Offset: 0x000FF9F0
		// (set) Token: 0x06006BEC RID: 27628 RVA: 0x00101851 File Offset: 0x000FFA51
		public virtual ITakePhoto2TargetPosByRangeCondition TargetPosCondition
		{
			get
			{
				if (this._TargetPosConditionInited)
				{
					return this._TargetPosConditionCache;
				}
				this._TargetPosConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetPosConditionCache = ITakePhoto2TargetPosByRangeCondition.Create(this.FbInstance.TargetPosCondition);
				}
				else
				{
					ITakePhoto2TargetEntityType_SetValue pocoInterface = this.PocoInterface;
					this._TargetPosConditionCache = ((pocoInterface != null) ? pocoInterface.TargetPosCondition : null);
				}
				return this._TargetPosConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetPosCondition = value;
				this._TargetPosConditionInited = false;
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x06006BED RID: 27629 RVA: 0x00101868 File Offset: 0x000FFA68
		// (set) Token: 0x06006BEE RID: 27630 RVA: 0x001018C9 File Offset: 0x000FFAC9
		public virtual ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition
		{
			get
			{
				if (this._TargetPlayMontageConditionInited)
				{
					return this._TargetPlayMontageConditionCache;
				}
				this._TargetPlayMontageConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetPlayMontageConditionCache = ITakePhoto2TargetPlayMontageCondition.Create(this.FbInstance.TargetPlayMontageCondition);
				}
				else
				{
					ITakePhoto2TargetEntityType_SetValue pocoInterface = this.PocoInterface;
					this._TargetPlayMontageConditionCache = ((pocoInterface != null) ? pocoInterface.TargetPlayMontageCondition : null);
				}
				return this._TargetPlayMontageConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetPlayMontageCondition = value;
				this._TargetPlayMontageConditionInited = false;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x06006BEF RID: 27631 RVA: 0x001018E0 File Offset: 0x000FFAE0
		// (set) Token: 0x06006BF0 RID: 27632 RVA: 0x00101941 File Offset: 0x000FFB41
		public virtual ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition
		{
			get
			{
				if (this._TargetAnsTagConditionInited)
				{
					return this._TargetAnsTagConditionCache;
				}
				this._TargetAnsTagConditionInited = true;
				if (this.FbInstance != null)
				{
					this._TargetAnsTagConditionCache = ITakePhoto2TargetAnsTagCondition.Create(this.FbInstance.TargetAnsTagCondition);
				}
				else
				{
					ITakePhoto2TargetEntityType_SetValue pocoInterface = this.PocoInterface;
					this._TargetAnsTagConditionCache = ((pocoInterface != null) ? pocoInterface.TargetAnsTagCondition : null);
				}
				return this._TargetAnsTagConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetAnsTagCondition = value;
				this._TargetAnsTagConditionInited = false;
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x06006BF1 RID: 27633 RVA: 0x00101956 File Offset: 0x000FFB56
		// (set) Token: 0x06006BF2 RID: 27634 RVA: 0x00101981 File Offset: 0x000FFB81
		public virtual int TargetSatisfiedCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetSatisfiedCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetSatisfiedCount;
			}
			set
			{
				this.GetOrCreatePoco().TargetSatisfiedCount = value;
			}
		}

		// Token: 0x04004068 RID: 16488
		protected new ITakePhoto2TargetEntityType FbInstance;

		// Token: 0x04004069 RID: 16489
		protected new ITakePhoto2TargetEntityType_SetValue PocoInterface;

		// Token: 0x0400406A RID: 16490
		[Nullable(0)]
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x0400406B RID: 16491
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x0400406C RID: 16492
		[Nullable(0)]
		private IEntityCategory _EntityCategoryCache;

		// Token: 0x0400406D RID: 16493
		private bool _EntityCategoryInited;

		// Token: 0x0400406E RID: 16494
		[Nullable(0)]
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x0400406F RID: 16495
		private bool _TargetPosConditionInited;

		// Token: 0x04004070 RID: 16496
		[Nullable(0)]
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x04004071 RID: 16497
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x04004072 RID: 16498
		[Nullable(0)]
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x04004073 RID: 16499
		private bool _TargetAnsTagConditionInited;
	}
}
