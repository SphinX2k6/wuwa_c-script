using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B82 RID: 7042
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveTypeCircular : ILiftMoveType
	{
		// Token: 0x060096CD RID: 38605 RVA: 0x0015C2C8 File Offset: 0x0015A4C8
		private ILiftMoveTypeCircular_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveTypeCircular 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveTypeCircular_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveTypeCircular_SetValue());
			}
			return result;
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x0015C300 File Offset: 0x0015A500
		public static ILiftMoveTypeCircular Create([Nullable(2)] ILiftMoveTypeCircular instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeCircular
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x0015C313 File Offset: 0x0015A513
		public static ILiftMoveTypeCircular CreateFromSetValue([Nullable(2)] ILiftMoveTypeCircular_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveTypeCircular
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x0015C326 File Offset: 0x0015A526
		public new ILiftMoveTypeCircular_SetValue ToSetValue()
		{
			return new ILiftMoveTypeCircular_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x060096D1 RID: 38609 RVA: 0x0015C339 File Offset: 0x0015A539
		// (set) Token: 0x060096D2 RID: 38610 RVA: 0x0015C364 File Offset: 0x0015A564
		public override ELiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiftMoveType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C27 RID: 23591
		[Nullable(2)]
		protected new ILiftMoveTypeCircular FbInstance;

		// Token: 0x04005C28 RID: 23592
		[Nullable(2)]
		protected new ILiftMoveTypeCircular_SetValue PocoInterface;
	}
}
