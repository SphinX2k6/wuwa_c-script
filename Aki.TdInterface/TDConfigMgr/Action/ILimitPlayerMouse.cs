using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B90 RID: 7056
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerMouse : ILimitPlayerOption
	{
		// Token: 0x06009711 RID: 38673 RVA: 0x0015C9A4 File Offset: 0x0015ABA4
		private ILimitPlayerMouse_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerMouse 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerMouse_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerMouse_SetValue());
			}
			return result;
		}

		// Token: 0x06009712 RID: 38674 RVA: 0x0015C9DC File Offset: 0x0015ABDC
		public static ILimitPlayerMouse Create([Nullable(2)] ILimitPlayerMouse instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMouse
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009713 RID: 38675 RVA: 0x0015C9EF File Offset: 0x0015ABEF
		public static ILimitPlayerMouse CreateFromSetValue([Nullable(2)] ILimitPlayerMouse_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerMouse
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x0015CA02 File Offset: 0x0015AC02
		public new ILimitPlayerMouse_SetValue ToSetValue()
		{
			return new ILimitPlayerMouse_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x06009715 RID: 38677 RVA: 0x0015CA15 File Offset: 0x0015AC15
		// (set) Token: 0x06009716 RID: 38678 RVA: 0x0015CA40 File Offset: 0x0015AC40
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C42 RID: 23618
		[Nullable(2)]
		protected new ILimitPlayerMouse FbInstance;

		// Token: 0x04005C43 RID: 23619
		[Nullable(2)]
		protected new ILimitPlayerMouse_SetValue PocoInterface;
	}
}
