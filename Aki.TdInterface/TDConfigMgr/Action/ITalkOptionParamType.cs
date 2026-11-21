using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021AD RID: 8621
	public class ITalkOptionParamType
	{
		// Token: 0x0600BC00 RID: 48128 RVA: 0x001B38FC File Offset: 0x001B1AFC
		private ITalkOptionParamType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionParamType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionParamType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionParamType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC01 RID: 48129 RVA: 0x001B3934 File Offset: 0x001B1B34
		public static ITalkOptionParamType Create([Nullable(2)] ITalkOptionParamType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionParamType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC02 RID: 48130 RVA: 0x001B3947 File Offset: 0x001B1B47
		public static ITalkOptionParamType CreateFromSetValue([Nullable(2)] ITalkOptionParamType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionParamType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC03 RID: 48131 RVA: 0x001B395A File Offset: 0x001B1B5A
		public ITalkOptionParamType_SetValue ToSetValue()
		{
			return new ITalkOptionParamType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600BC04 RID: 48132 RVA: 0x001B396D File Offset: 0x001B1B6D
		// (set) Token: 0x0600BC05 RID: 48133 RVA: 0x001B3998 File Offset: 0x001B1B98
		public virtual ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007117 RID: 28951
		[Nullable(2)]
		protected ITalkOptionParamType FbInstance;

		// Token: 0x04007118 RID: 28952
		[Nullable(2)]
		protected ITalkOptionParamType_SetValue PocoInterface;
	}
}
