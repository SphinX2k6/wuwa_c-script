using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200117C RID: 4476
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TargetEntityType : ITakePhoto2Target
	{
		// Token: 0x060065A8 RID: 26024 RVA: 0x000F3DE0 File Offset: 0x000F1FE0
		[NullableContext(1)]
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

		// Token: 0x060065A9 RID: 26025 RVA: 0x000F3E18 File Offset: 0x000F2018
		[NullableContext(1)]
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

		// Token: 0x060065AA RID: 26026 RVA: 0x000F3E2B File Offset: 0x000F202B
		[NullableContext(1)]
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

		// Token: 0x060065AB RID: 26027 RVA: 0x000F3E40 File Offset: 0x000F2040
		[NullableContext(1)]
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

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x060065AC RID: 26028 RVA: 0x000F3EB2 File Offset: 0x000F20B2
		// (set) Token: 0x060065AD RID: 26029 RVA: 0x000F3EDD File Offset: 0x000F20DD
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

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x060065AE RID: 26030 RVA: 0x000F3EEC File Offset: 0x000F20EC
		// (set) Token: 0x060065AF RID: 26031 RVA: 0x000F3F26 File Offset: 0x000F2126
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

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x060065B0 RID: 26032 RVA: 0x000F3F34 File Offset: 0x000F2134
		// (set) Token: 0x060065B1 RID: 26033 RVA: 0x000F3F95 File Offset: 0x000F2195
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

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x060065B2 RID: 26034 RVA: 0x000F3FAC File Offset: 0x000F21AC
		// (set) Token: 0x060065B3 RID: 26035 RVA: 0x000F400D File Offset: 0x000F220D
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().EntityCategory = value;
				this._EntityCategoryInited = false;
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x000F4024 File Offset: 0x000F2224
		// (set) Token: 0x060065B5 RID: 26037 RVA: 0x000F4085 File Offset: 0x000F2285
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

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x000F409C File Offset: 0x000F229C
		// (set) Token: 0x060065B7 RID: 26039 RVA: 0x000F40FD File Offset: 0x000F22FD
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

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x060065B8 RID: 26040 RVA: 0x000F4114 File Offset: 0x000F2314
		// (set) Token: 0x060065B9 RID: 26041 RVA: 0x000F4175 File Offset: 0x000F2375
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

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x060065BA RID: 26042 RVA: 0x000F418A File Offset: 0x000F238A
		// (set) Token: 0x060065BB RID: 26043 RVA: 0x000F41B5 File Offset: 0x000F23B5
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

		// Token: 0x04003D00 RID: 15616
		protected new ITakePhoto2TargetEntityType FbInstance;

		// Token: 0x04003D01 RID: 15617
		protected new ITakePhoto2TargetEntityType_SetValue PocoInterface;

		// Token: 0x04003D02 RID: 15618
		[Nullable(1)]
		private ITakePhoto2TargetCameraDistanceCondition _TargetCameraDistanceConditionCache;

		// Token: 0x04003D03 RID: 15619
		private bool _TargetCameraDistanceConditionInited;

		// Token: 0x04003D04 RID: 15620
		[Nullable(1)]
		private IEntityCategory _EntityCategoryCache;

		// Token: 0x04003D05 RID: 15621
		private bool _EntityCategoryInited;

		// Token: 0x04003D06 RID: 15622
		[Nullable(1)]
		private ITakePhoto2TargetPosByRangeCondition _TargetPosConditionCache;

		// Token: 0x04003D07 RID: 15623
		private bool _TargetPosConditionInited;

		// Token: 0x04003D08 RID: 15624
		[Nullable(1)]
		private ITakePhoto2TargetPlayMontageCondition _TargetPlayMontageConditionCache;

		// Token: 0x04003D09 RID: 15625
		private bool _TargetPlayMontageConditionInited;

		// Token: 0x04003D0A RID: 15626
		[Nullable(1)]
		private ITakePhoto2TargetAnsTagCondition _TargetAnsTagConditionCache;

		// Token: 0x04003D0B RID: 15627
		private bool _TargetAnsTagConditionInited;
	}
}
