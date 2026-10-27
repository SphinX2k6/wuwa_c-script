using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A10 RID: 6672
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerformRender
	{
		// Token: 0x06008EEF RID: 36591 RVA: 0x0014E08C File Offset: 0x0014C28C
		[NullableContext(1)]
		private IEntityLookAtPerformRender_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityLookAtPerformRender 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityLookAtPerformRender_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityLookAtPerformRender_SetValue());
			}
			return result;
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x0014E0C4 File Offset: 0x0014C2C4
		[NullableContext(1)]
		public static IEntityLookAtPerformRender Create([Nullable(2)] IEntityLookAtPerformRender instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityLookAtPerformRender
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x0014E0D7 File Offset: 0x0014C2D7
		[NullableContext(1)]
		public static IEntityLookAtPerformRender CreateFromSetValue([Nullable(2)] IEntityLookAtPerformRender_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityLookAtPerformRender
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x0014E0EA File Offset: 0x0014C2EA
		[NullableContext(1)]
		public IEntityLookAtPerformRender_SetValue ToSetValue()
		{
			return new IEntityLookAtPerformRender_SetValue
			{
				EntityId = this.EntityId,
				FaceExpressionId = this.FaceExpressionId,
				OverlapMontageId = this.OverlapMontageId,
				OverlapMontageConfig = this.OverlapMontageConfig
			};
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x0014E121 File Offset: 0x0014C321
		// (set) Token: 0x06008EF4 RID: 36596 RVA: 0x0014E14C File Offset: 0x0014C34C
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

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x0014E15C File Offset: 0x0014C35C
		// (set) Token: 0x06008EF6 RID: 36598 RVA: 0x0014E196 File Offset: 0x0014C396
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				IEntityLookAtPerformRender_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x0014E1A4 File Offset: 0x0014C3A4
		// (set) Token: 0x06008EF8 RID: 36600 RVA: 0x0014E205 File Offset: 0x0014C405
		public virtual IMontageId OverlapMontageId
		{
			get
			{
				if (this._OverlapMontageIdInited)
				{
					return this._OverlapMontageIdCache;
				}
				this._OverlapMontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._OverlapMontageIdCache = IMontageId.Create(this.FbInstance.OverlapMontageId);
				}
				else
				{
					IEntityLookAtPerformRender_SetValue pocoInterface = this.PocoInterface;
					this._OverlapMontageIdCache = ((pocoInterface != null) ? pocoInterface.OverlapMontageId : null);
				}
				return this._OverlapMontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageId = value;
				this._OverlapMontageIdInited = false;
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x0014E21C File Offset: 0x0014C41C
		// (set) Token: 0x06008EFA RID: 36602 RVA: 0x0014E27D File Offset: 0x0014C47D
		public virtual ILookAtPerformOverlapMontageConfig OverlapMontageConfig
		{
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
					IEntityLookAtPerformRender_SetValue pocoInterface = this.PocoInterface;
					this._OverlapMontageConfigCache = ((pocoInterface != null) ? pocoInterface.OverlapMontageConfig : null);
				}
				return this._OverlapMontageConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageConfig = value;
				this._OverlapMontageConfigInited = false;
			}
		}

		// Token: 0x04005881 RID: 22657
		protected IEntityLookAtPerformRender FbInstance;

		// Token: 0x04005882 RID: 22658
		protected IEntityLookAtPerformRender_SetValue PocoInterface;

		// Token: 0x04005883 RID: 22659
		[Nullable(1)]
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x04005884 RID: 22660
		private bool _OverlapMontageIdInited;

		// Token: 0x04005885 RID: 22661
		[Nullable(1)]
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x04005886 RID: 22662
		private bool _OverlapMontageConfigInited;
	}
}
