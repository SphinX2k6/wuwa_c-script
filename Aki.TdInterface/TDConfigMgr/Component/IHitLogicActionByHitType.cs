using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000477 RID: 1143
	public class IHitLogicActionByHitType : IHitLogicType
	{
		// Token: 0x060016DF RID: 5855 RVA: 0x00046B30 File Offset: 0x00044D30
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

		// Token: 0x060016E0 RID: 5856 RVA: 0x00046B68 File Offset: 0x00044D68
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

		// Token: 0x060016E1 RID: 5857 RVA: 0x00046B7B File Offset: 0x00044D7B
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

		// Token: 0x060016E2 RID: 5858 RVA: 0x00046B8E File Offset: 0x00044D8E
		public new IHitLogicActionByHitType_SetValue ToSetValue()
		{
			return new IHitLogicActionByHitType_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00046BAD File Offset: 0x00044DAD
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00046BD8 File Offset: 0x00044DD8
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00046BE8 File Offset: 0x00044DE8
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x00046C7B File Offset: 0x00044E7B
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

		// Token: 0x040011A0 RID: 4512
		[Nullable(2)]
		protected new IHitLogicActionByHitType FbInstance;

		// Token: 0x040011A1 RID: 4513
		[Nullable(2)]
		protected new IHitLogicActionByHitType_SetValue PocoInterface;

		// Token: 0x040011A2 RID: 4514
		private List<IActionByHitTypeConfig> _ConfigsCache;

		// Token: 0x040011A3 RID: 4515
		private bool _ConfigsInited;
	}
}
