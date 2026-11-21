using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA3 RID: 7075
	public class IEntityLookAtPerform
	{
		// Token: 0x0600964B RID: 38475 RVA: 0x0015DDD0 File Offset: 0x0015BFD0
		private IEntityLookAtPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityLookAtPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityLookAtPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityLookAtPerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x0015DE08 File Offset: 0x0015C008
		public static IEntityLookAtPerform Create([Nullable(2)] IEntityLookAtPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityLookAtPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x0015DE1B File Offset: 0x0015C01B
		public static IEntityLookAtPerform CreateFromSetValue([Nullable(2)] IEntityLookAtPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityLookAtPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x0015DE2E File Offset: 0x0015C02E
		public IEntityLookAtPerform_SetValue ToSetValue()
		{
			return new IEntityLookAtPerform_SetValue
			{
				EntityId = this.EntityId,
				FaceExpressionId = this.FaceExpressionId,
				OverlapMontageId = this.OverlapMontageId,
				OverlapMontageConfig = this.OverlapMontageConfig
			};
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0600964F RID: 38479 RVA: 0x0015DE65 File Offset: 0x0015C065
		// (set) Token: 0x06009650 RID: 38480 RVA: 0x0015DE90 File Offset: 0x0015C090
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x06009651 RID: 38481 RVA: 0x0015DEA0 File Offset: 0x0015C0A0
		// (set) Token: 0x06009652 RID: 38482 RVA: 0x0015DEDA File Offset: 0x0015C0DA
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				IEntityLookAtPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpressionId = value;
			}
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x06009653 RID: 38483 RVA: 0x0015DEE8 File Offset: 0x0015C0E8
		// (set) Token: 0x06009654 RID: 38484 RVA: 0x0015DF22 File Offset: 0x0015C122
		public virtual int? OverlapMontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverlapMontageId;
				}
				IEntityLookAtPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OverlapMontageId;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageId = value;
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x06009655 RID: 38485 RVA: 0x0015DF30 File Offset: 0x0015C130
		// (set) Token: 0x06009656 RID: 38486 RVA: 0x0015DF91 File Offset: 0x0015C191
		[Nullable(2)]
		public virtual ILookAtPerformOverlapMontageConfig OverlapMontageConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._OverlapMontageConfigInited)
				{
					return this._OverlapMontageConfigCache;
				}
				this._OverlapMontageConfigInited = true;
				if (this.FbInstance != null)
				{
					this._OverlapMontageConfigCache = ILookAtPerformOverlapMontageConfig.Create(this.FbInstance.OverlapMontageConfig);
				}
				else
				{
					IEntityLookAtPerform_SetValue pocoInterface = this.PocoInterface;
					this._OverlapMontageConfigCache = ((pocoInterface != null) ? pocoInterface.OverlapMontageConfig : null);
				}
				return this._OverlapMontageConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OverlapMontageConfig = value;
				this._OverlapMontageConfigInited = false;
			}
		}

		// Token: 0x04005CDE RID: 23774
		[Nullable(2)]
		protected IEntityLookAtPerform FbInstance;

		// Token: 0x04005CDF RID: 23775
		[Nullable(2)]
		protected IEntityLookAtPerform_SetValue PocoInterface;

		// Token: 0x04005CE0 RID: 23776
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x04005CE1 RID: 23777
		private bool _OverlapMontageConfigInited;
	}
}
