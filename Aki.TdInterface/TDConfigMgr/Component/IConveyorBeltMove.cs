using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002CC RID: 716
	public class IConveyorBeltMove
	{
		// Token: 0x06000D33 RID: 3379 RVA: 0x00032608 File Offset: 0x00030808
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

		// Token: 0x06000D34 RID: 3380 RVA: 0x00032640 File Offset: 0x00030840
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

		// Token: 0x06000D35 RID: 3381 RVA: 0x00032653 File Offset: 0x00030853
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

		// Token: 0x06000D36 RID: 3382 RVA: 0x00032666 File Offset: 0x00030866
		public IConveyorBeltMove_SetValue ToSetValue()
		{
			return new IConveyorBeltMove_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x00032679 File Offset: 0x00030879
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000326A4 File Offset: 0x000308A4
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

		// Token: 0x04000C64 RID: 3172
		[Nullable(2)]
		protected IConveyorBeltMove FbInstance;

		// Token: 0x04000C65 RID: 3173
		[Nullable(2)]
		protected IConveyorBeltMove_SetValue PocoInterface;
	}
}
