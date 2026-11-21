using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA5 RID: 7077
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerformRender
	{
		// Token: 0x06009659 RID: 38489 RVA: 0x0015DFB8 File Offset: 0x0015C1B8
		[NullableContext(0)]
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

		// Token: 0x0600965A RID: 38490 RVA: 0x0015DFF0 File Offset: 0x0015C1F0
		[NullableContext(0)]
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

		// Token: 0x0600965B RID: 38491 RVA: 0x0015E003 File Offset: 0x0015C203
		[NullableContext(0)]
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

		// Token: 0x0600965C RID: 38492 RVA: 0x0015E016 File Offset: 0x0015C216
		[NullableContext(0)]
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

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600965D RID: 38493 RVA: 0x0015E04D File Offset: 0x0015C24D
		// (set) Token: 0x0600965E RID: 38494 RVA: 0x0015E078 File Offset: 0x0015C278
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

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600965F RID: 38495 RVA: 0x0015E088 File Offset: 0x0015C288
		// (set) Token: 0x06009660 RID: 38496 RVA: 0x0015E0C2 File Offset: 0x0015C2C2
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

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x06009661 RID: 38497 RVA: 0x0015E0D0 File Offset: 0x0015C2D0
		// (set) Token: 0x06009662 RID: 38498 RVA: 0x0015E131 File Offset: 0x0015C331
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

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x06009663 RID: 38499 RVA: 0x0015E148 File Offset: 0x0015C348
		// (set) Token: 0x06009664 RID: 38500 RVA: 0x0015E1A9 File Offset: 0x0015C3A9
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

		// Token: 0x04005CE6 RID: 23782
		protected IEntityLookAtPerformRender FbInstance;

		// Token: 0x04005CE7 RID: 23783
		protected IEntityLookAtPerformRender_SetValue PocoInterface;

		// Token: 0x04005CE8 RID: 23784
		[Nullable(0)]
		private IMontageId _OverlapMontageIdCache;

		// Token: 0x04005CE9 RID: 23785
		private bool _OverlapMontageIdInited;

		// Token: 0x04005CEA RID: 23786
		[Nullable(0)]
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x04005CEB RID: 23787
		private bool _OverlapMontageConfigInited;
	}
}
