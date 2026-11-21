using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1D RID: 6685
	public class ICheckFlowLookAtConfig
	{
		// Token: 0x06008E3D RID: 36413 RVA: 0x0014FFC8 File Offset: 0x0014E1C8
		private ICheckFlowLookAtConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckFlowLookAtConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckFlowLookAtConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckFlowLookAtConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x00150000 File Offset: 0x0014E200
		public static ICheckFlowLookAtConfig Create([Nullable(2)] ICheckFlowLookAtConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x00150013 File Offset: 0x0014E213
		public static ICheckFlowLookAtConfig CreateFromSetValue([Nullable(2)] ICheckFlowLookAtConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckFlowLookAtConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x00150026 File Offset: 0x0014E226
		public ICheckFlowLookAtConfig_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtConfig_SetValue
			{
				Flow = this.Flow,
				Target = this.Target,
				EntityLookAtPerform = this.EntityLookAtPerform
			};
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x00150054 File Offset: 0x0014E254
		// (set) Token: 0x06008E42 RID: 36418 RVA: 0x001500B5 File Offset: 0x0014E2B5
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					ICheckFlowLookAtConfig_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x001500CA File Offset: 0x0014E2CA
		// (set) Token: 0x06008E44 RID: 36420 RVA: 0x001500F1 File Offset: 0x0014E2F1
		public virtual ICheckFlowLookAtTarget Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ICheckFlowLookAtConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x06008E45 RID: 36421 RVA: 0x00150100 File Offset: 0x0014E300
		// (set) Token: 0x06008E46 RID: 36422 RVA: 0x00150161 File Offset: 0x0014E361
		[Nullable(2)]
		public virtual IEntityLookAtPerform EntityLookAtPerform
		{
			[NullableContext(2)]
			get
			{
				if (this._EntityLookAtPerformInited)
				{
					return this._EntityLookAtPerformCache;
				}
				this._EntityLookAtPerformInited = true;
				if (this.FbInstance != null)
				{
					this._EntityLookAtPerformCache = IEntityLookAtPerform.Create(this.FbInstance.EntityLookAtPerform);
				}
				else
				{
					ICheckFlowLookAtConfig_SetValue pocoInterface = this.PocoInterface;
					this._EntityLookAtPerformCache = ((pocoInterface != null) ? pocoInterface.EntityLookAtPerform : null);
				}
				return this._EntityLookAtPerformCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EntityLookAtPerform = value;
				this._EntityLookAtPerformInited = false;
			}
		}

		// Token: 0x04005962 RID: 22882
		[Nullable(2)]
		protected ICheckFlowLookAtConfig FbInstance;

		// Token: 0x04005963 RID: 22883
		[Nullable(2)]
		protected ICheckFlowLookAtConfig_SetValue PocoInterface;

		// Token: 0x04005964 RID: 22884
		private PlayFlow _FlowCache;

		// Token: 0x04005965 RID: 22885
		private bool _FlowInited;

		// Token: 0x04005966 RID: 22886
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x04005967 RID: 22887
		private bool _EntityLookAtPerformInited;
	}
}
