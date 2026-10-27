using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032D RID: 813
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityMatchSpecificBp : IEntityMatchConfig
	{
		// Token: 0x06000FFE RID: 4094 RVA: 0x00037E2C File Offset: 0x0003602C
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

		// Token: 0x06000FFF RID: 4095 RVA: 0x00037E64 File Offset: 0x00036064
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

		// Token: 0x06001000 RID: 4096 RVA: 0x00037E77 File Offset: 0x00036077
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

		// Token: 0x06001001 RID: 4097 RVA: 0x00037E8A File Offset: 0x0003608A
		public new IEntityMatchSpecificBp_SetValue ToSetValue()
		{
			return new IEntityMatchSpecificBp_SetValue
			{
				Type = this.Type,
				SpecificBpList = this.SpecificBpList
			};
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00037EA9 File Offset: 0x000360A9
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x00037ED4 File Offset: 0x000360D4
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00037EE2 File Offset: 0x000360E2
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x00037F09 File Offset: 0x00036109
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

		// Token: 0x04000D89 RID: 3465
		[Nullable(2)]
		protected new IEntityMatchSpecificBp FbInstance;

		// Token: 0x04000D8A RID: 3466
		[Nullable(2)]
		protected new IEntityMatchSpecificBp_SetValue PocoInterface;
	}
}
