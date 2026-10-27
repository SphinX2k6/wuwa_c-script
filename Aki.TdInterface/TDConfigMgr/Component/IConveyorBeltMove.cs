using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000289 RID: 649
	[NullableContext(1)]
	[Nullable(0)]
	public class IConveyorBeltMove
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x0002F918 File Offset: 0x0002DB18
		private IConveyorBeltMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConveyorBeltMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConveyorBeltMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConveyorBeltMove_SetValue());
			}
			return result;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0002F950 File Offset: 0x0002DB50
		public static IConveyorBeltMove Create([Nullable(2)] IConveyorBeltMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002F963 File Offset: 0x0002DB63
		public static IConveyorBeltMove CreateFromSetValue([Nullable(2)] IConveyorBeltMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConveyorBeltMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0002F976 File Offset: 0x0002DB76
		public IConveyorBeltMove_SetValue ToSetValue()
		{
			return new IConveyorBeltMove_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0002F989 File Offset: 0x0002DB89
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x0002F9B4 File Offset: 0x0002DBB4
		public virtual EConveyorBeltMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConveyorBeltMoveType.FixSpeed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000B83 RID: 2947
		[Nullable(2)]
		protected IConveyorBeltMove FbInstance;

		// Token: 0x04000B84 RID: 2948
		[Nullable(2)]
		protected IConveyorBeltMove_SetValue PocoInterface;
	}
}
