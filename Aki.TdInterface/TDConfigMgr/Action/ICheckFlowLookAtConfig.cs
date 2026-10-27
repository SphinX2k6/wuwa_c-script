using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001892 RID: 6290
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAtConfig
	{
		// Token: 0x06008715 RID: 34581 RVA: 0x00140794 File Offset: 0x0013E994
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

		// Token: 0x06008716 RID: 34582 RVA: 0x001407CC File Offset: 0x0013E9CC
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

		// Token: 0x06008717 RID: 34583 RVA: 0x001407DF File Offset: 0x0013E9DF
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

		// Token: 0x06008718 RID: 34584 RVA: 0x001407F2 File Offset: 0x0013E9F2
		public ICheckFlowLookAtConfig_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtConfig_SetValue
			{
				Flow = this.Flow,
				Target = this.Target,
				EntityLookAtPerform = this.EntityLookAtPerform
			};
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06008719 RID: 34585 RVA: 0x00140820 File Offset: 0x0013EA20
		// (set) Token: 0x0600871A RID: 34586 RVA: 0x00140881 File Offset: 0x0013EA81
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

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x0600871B RID: 34587 RVA: 0x00140896 File Offset: 0x0013EA96
		// (set) Token: 0x0600871C RID: 34588 RVA: 0x001408BD File Offset: 0x0013EABD
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

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x0600871D RID: 34589 RVA: 0x001408CC File Offset: 0x0013EACC
		// (set) Token: 0x0600871E RID: 34590 RVA: 0x0014092D File Offset: 0x0013EB2D
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

		// Token: 0x04005515 RID: 21781
		[Nullable(2)]
		protected ICheckFlowLookAtConfig FbInstance;

		// Token: 0x04005516 RID: 21782
		[Nullable(2)]
		protected ICheckFlowLookAtConfig_SetValue PocoInterface;

		// Token: 0x04005517 RID: 21783
		private PlayFlow _FlowCache;

		// Token: 0x04005518 RID: 21784
		private bool _FlowInited;

		// Token: 0x04005519 RID: 21785
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x0400551A RID: 21786
		private bool _EntityLookAtPerformInited;
	}
}
