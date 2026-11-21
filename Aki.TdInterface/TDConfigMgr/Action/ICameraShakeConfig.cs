using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019DD RID: 6621
	public class ICameraShakeConfig
	{
		// Token: 0x06008CED RID: 36077 RVA: 0x0014D9E4 File Offset: 0x0014BBE4
		private ICameraShakeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraShakeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraShakeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraShakeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x0014DA1C File Offset: 0x0014BC1C
		public static ICameraShakeConfig Create([Nullable(2)] ICameraShakeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraShakeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x0014DA2F File Offset: 0x0014BC2F
		public static ICameraShakeConfig CreateFromSetValue([Nullable(2)] ICameraShakeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraShakeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x0014DA42 File Offset: 0x0014BC42
		public ICameraShakeConfig_SetValue ToSetValue()
		{
			return new ICameraShakeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x06008CF1 RID: 36081 RVA: 0x0014DA55 File Offset: 0x0014BC55
		// (set) Token: 0x06008CF2 RID: 36082 RVA: 0x0014DA80 File Offset: 0x0014BC80
		public virtual ECameraShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraShakeType.Constant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040058C6 RID: 22726
		[Nullable(2)]
		protected ICameraShakeConfig FbInstance;

		// Token: 0x040058C7 RID: 22727
		[Nullable(2)]
		protected ICameraShakeConfig_SetValue PocoInterface;
	}
}
