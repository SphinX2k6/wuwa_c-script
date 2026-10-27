using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001890 RID: 6288
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAt : IOverrideLookAtType
	{
		// Token: 0x0600870B RID: 34571 RVA: 0x00140624 File Offset: 0x0013E824
		private ICheckFlowLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckFlowLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckFlowLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckFlowLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x0014065C File Offset: 0x0013E85C
		public static ICheckFlowLookAt Create([Nullable(2)] ICheckFlowLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x0014066F File Offset: 0x0013E86F
		public static ICheckFlowLookAt CreateFromSetValue([Nullable(2)] ICheckFlowLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckFlowLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00140682 File Offset: 0x0013E882
		public new ICheckFlowLookAt_SetValue ToSetValue()
		{
			return new ICheckFlowLookAt_SetValue
			{
				Type = this.Type,
				CheckFlowLookAtConfigs = this.CheckFlowLookAtConfigs
			};
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0600870F RID: 34575 RVA: 0x001406A1 File Offset: 0x0013E8A1
		// (set) Token: 0x06008710 RID: 34576 RVA: 0x001406CC File Offset: 0x0013E8CC
		public override EOverrideLookAtType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOverrideLookAtType.CheckFlowLookAt;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06008711 RID: 34577 RVA: 0x001406DC File Offset: 0x0013E8DC
		// (set) Token: 0x06008712 RID: 34578 RVA: 0x0014076F File Offset: 0x0013E96F
		public virtual List<ICheckFlowLookAtConfig> CheckFlowLookAtConfigs
		{
			get
			{
				if (this._CheckFlowLookAtConfigsInited)
				{
					return this._CheckFlowLookAtConfigsCache;
				}
				this._CheckFlowLookAtConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ICheckFlowLookAtConfig> checkFlowLookAtConfigs = this.FbInstance.CheckFlowLookAtConfigs;
					if (checkFlowLookAtConfigs != null)
					{
						this._CheckFlowLookAtConfigsCache = new List<ICheckFlowLookAtConfig>(checkFlowLookAtConfigs.Count);
						for (int i = 0; i < checkFlowLookAtConfigs.Count; i++)
						{
							this._CheckFlowLookAtConfigsCache.Add(ICheckFlowLookAtConfig.Create(checkFlowLookAtConfigs[i]));
						}
					}
				}
				else
				{
					ICheckFlowLookAt_SetValue pocoInterface = this.PocoInterface;
					this._CheckFlowLookAtConfigsCache = ((pocoInterface != null) ? pocoInterface.CheckFlowLookAtConfigs : null);
				}
				return this._CheckFlowLookAtConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().CheckFlowLookAtConfigs = value;
				this._CheckFlowLookAtConfigsInited = false;
			}
		}

		// Token: 0x0400550F RID: 21775
		[Nullable(2)]
		protected new ICheckFlowLookAt FbInstance;

		// Token: 0x04005510 RID: 21776
		[Nullable(2)]
		protected new ICheckFlowLookAt_SetValue PocoInterface;

		// Token: 0x04005511 RID: 21777
		private List<ICheckFlowLookAtConfig> _CheckFlowLookAtConfigsCache;

		// Token: 0x04005512 RID: 21778
		private bool _CheckFlowLookAtConfigsInited;
	}
}
