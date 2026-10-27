using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B54 RID: 6996
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractPointConfig
	{
		// Token: 0x060095D1 RID: 38353 RVA: 0x0015A504 File Offset: 0x00158704
		private IInteractPointConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractPointConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractPointConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractPointConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x0015A53C File Offset: 0x0015873C
		public static IInteractPointConfig Create([Nullable(2)] IInteractPointConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractPointConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x0015A54F File Offset: 0x0015874F
		public static IInteractPointConfig CreateFromSetValue([Nullable(2)] IInteractPointConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractPointConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x0015A562 File Offset: 0x00158762
		public IInteractPointConfig_SetValue ToSetValue()
		{
			return new IInteractPointConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x060095D5 RID: 38357 RVA: 0x0015A575 File Offset: 0x00158775
		// (set) Token: 0x060095D6 RID: 38358 RVA: 0x0015A5A0 File Offset: 0x001587A0
		public virtual EInteractUnlockType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractUnlockType.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BAC RID: 23468
		[Nullable(2)]
		protected IInteractPointConfig FbInstance;

		// Token: 0x04005BAD RID: 23469
		[Nullable(2)]
		protected IInteractPointConfig_SetValue PocoInterface;
	}
}
