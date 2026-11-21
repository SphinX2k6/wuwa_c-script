using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000374 RID: 884
	public class IEntityMatchSpecificBp : IEntityMatchConfig
	{
		// Token: 0x06001130 RID: 4400 RVA: 0x0003ADF8 File Offset: 0x00038FF8
		private IEntityMatchSpecificBp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityMatchSpecificBp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityMatchSpecificBp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityMatchSpecificBp_SetValue());
			}
			return result;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0003AE30 File Offset: 0x00039030
		public static IEntityMatchSpecificBp Create([Nullable(2)] IEntityMatchSpecificBp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchSpecificBp
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0003AE43 File Offset: 0x00039043
		public static IEntityMatchSpecificBp CreateFromSetValue([Nullable(2)] IEntityMatchSpecificBp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityMatchSpecificBp
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0003AE56 File Offset: 0x00039056
		public new IEntityMatchSpecificBp_SetValue ToSetValue()
		{
			return new IEntityMatchSpecificBp_SetValue
			{
				Type = this.Type,
				SpecificBpList = this.SpecificBpList
			};
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0003AE75 File Offset: 0x00039075
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x0003AEA0 File Offset: 0x000390A0
		public override EEntityMatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityMatchType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0003AEAE File Offset: 0x000390AE
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x0003AED5 File Offset: 0x000390D5
		public virtual List<string> SpecificBpList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpecificBpList;
				}
				IEntityMatchSpecificBp_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpecificBpList;
			}
			set
			{
				this.GetOrCreatePoco().SpecificBpList = value;
			}
		}

		// Token: 0x04000E74 RID: 3700
		[Nullable(2)]
		protected new IEntityMatchSpecificBp FbInstance;

		// Token: 0x04000E75 RID: 3701
		[Nullable(2)]
		protected new IEntityMatchSpecificBp_SetValue PocoInterface;
	}
}
