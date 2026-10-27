using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041E RID: 1054
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicActionByHitType : IHitLogicType
	{
		// Token: 0x06001545 RID: 5445 RVA: 0x00042DE8 File Offset: 0x00040FE8
		private IHitLogicActionByHitType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicActionByHitType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicActionByHitType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicActionByHitType_SetValue());
			}
			return result;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00042E20 File Offset: 0x00041020
		public static IHitLogicActionByHitType Create([Nullable(2)] IHitLogicActionByHitType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicActionByHitType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00042E33 File Offset: 0x00041033
		public static IHitLogicActionByHitType CreateFromSetValue([Nullable(2)] IHitLogicActionByHitType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicActionByHitType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00042E46 File Offset: 0x00041046
		public new IHitLogicActionByHitType_SetValue ToSetValue()
		{
			return new IHitLogicActionByHitType_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00042E65 File Offset: 0x00041065
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x00042E90 File Offset: 0x00041090
		public override EHitLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitLogicType.ChangeNextState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00042EA0 File Offset: 0x000410A0
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x00042F33 File Offset: 0x00041133
		public virtual List<IActionByHitTypeConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IActionByHitTypeConfig> configs = this.FbInstance.Configs;
					if (configs != null)
					{
						this._ConfigsCache = new List<IActionByHitTypeConfig>(configs.Count);
						for (int i = 0; i < configs.Count; i++)
						{
							this._ConfigsCache.Add(IActionByHitTypeConfig.Create(configs[i]));
						}
					}
				}
				else
				{
					IHitLogicActionByHitType_SetValue pocoInterface = this.PocoInterface;
					this._ConfigsCache = ((pocoInterface != null) ? pocoInterface.Configs : null);
				}
				return this._ConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().Configs = value;
				this._ConfigsInited = false;
			}
		}

		// Token: 0x0400107E RID: 4222
		[Nullable(2)]
		protected new IHitLogicActionByHitType FbInstance;

		// Token: 0x0400107F RID: 4223
		[Nullable(2)]
		protected new IHitLogicActionByHitType_SetValue PocoInterface;

		// Token: 0x04001080 RID: 4224
		private List<IActionByHitTypeConfig> _ConfigsCache;

		// Token: 0x04001081 RID: 4225
		private bool _ConfigsInited;
	}
}
