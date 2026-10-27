using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F6D RID: 3949
	[NullableContext(1)]
	[Nullable(0)]
	public class IFastReturnPosBase
	{
		// Token: 0x060057CC RID: 22476 RVA: 0x000D67F4 File Offset: 0x000D49F4
		private IFastReturnPosBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFastReturnPosBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFastReturnPosBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFastReturnPosBase_SetValue());
			}
			return result;
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x000D682C File Offset: 0x000D4A2C
		public static IFastReturnPosBase Create([Nullable(2)] IFastReturnPosBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnPosBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x000D683F File Offset: 0x000D4A3F
		public static IFastReturnPosBase CreateFromSetValue([Nullable(2)] IFastReturnPosBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFastReturnPosBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x000D6852 File Offset: 0x000D4A52
		public IFastReturnPosBase_SetValue ToSetValue()
		{
			return new IFastReturnPosBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x060057D0 RID: 22480 RVA: 0x000D6865 File Offset: 0x000D4A65
		// (set) Token: 0x060057D1 RID: 22481 RVA: 0x000D6890 File Offset: 0x000D4A90
		public virtual EFastReturnPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFastReturnPosType.EntityPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400350F RID: 13583
		[Nullable(2)]
		protected IFastReturnPosBase FbInstance;

		// Token: 0x04003510 RID: 13584
		[Nullable(2)]
		protected IFastReturnPosBase_SetValue PocoInterface;
	}
}
