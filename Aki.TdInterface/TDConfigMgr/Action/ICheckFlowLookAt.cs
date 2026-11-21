using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1B RID: 6683
	public class ICheckFlowLookAt : IOverrideLookAtType
	{
		// Token: 0x06008E33 RID: 36403 RVA: 0x0014FE58 File Offset: 0x0014E058
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

		// Token: 0x06008E34 RID: 36404 RVA: 0x0014FE90 File Offset: 0x0014E090
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

		// Token: 0x06008E35 RID: 36405 RVA: 0x0014FEA3 File Offset: 0x0014E0A3
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

		// Token: 0x06008E36 RID: 36406 RVA: 0x0014FEB6 File Offset: 0x0014E0B6
		public new ICheckFlowLookAt_SetValue ToSetValue()
		{
			return new ICheckFlowLookAt_SetValue
			{
				Type = this.Type,
				CheckFlowLookAtConfigs = this.CheckFlowLookAtConfigs
			};
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x0014FED5 File Offset: 0x0014E0D5
		// (set) Token: 0x06008E38 RID: 36408 RVA: 0x0014FF00 File Offset: 0x0014E100
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

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x0014FF10 File Offset: 0x0014E110
		// (set) Token: 0x06008E3A RID: 36410 RVA: 0x0014FFA3 File Offset: 0x0014E1A3
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

		// Token: 0x0400595C RID: 22876
		[Nullable(2)]
		protected new ICheckFlowLookAt FbInstance;

		// Token: 0x0400595D RID: 22877
		[Nullable(2)]
		protected new ICheckFlowLookAt_SetValue PocoInterface;

		// Token: 0x0400595E RID: 22878
		private List<ICheckFlowLookAtConfig> _CheckFlowLookAtConfigsCache;

		// Token: 0x0400595F RID: 22879
		private bool _CheckFlowLookAtConfigsInited;
	}
}
