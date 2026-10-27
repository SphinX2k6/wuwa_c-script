using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E9 RID: 2025
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindSourceBase
	{
		// Token: 0x06002C01 RID: 11265 RVA: 0x000728B0 File Offset: 0x00070AB0
		private IWindSourceBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindSourceBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindSourceBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindSourceBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000728E8 File Offset: 0x00070AE8
		public static IWindSourceBase Create([Nullable(2)] IWindSourceBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindSourceBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000728FB File Offset: 0x00070AFB
		public static IWindSourceBase CreateFromSetValue([Nullable(2)] IWindSourceBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindSourceBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x0007290E File Offset: 0x00070B0E
		public IWindSourceBase_SetValue ToSetValue()
		{
			return new IWindSourceBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x00072921 File Offset: 0x00070B21
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x0007294C File Offset: 0x00070B4C
		public virtual EWindSourceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWindSourceType.Directional;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001D2E RID: 7470
		[Nullable(2)]
		protected IWindSourceBase FbInstance;

		// Token: 0x04001D2F RID: 7471
		[Nullable(2)]
		protected IWindSourceBase_SetValue PocoInterface;
	}
}
