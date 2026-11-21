using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D2F RID: 7471
	public class ILiftMoveTypeCircular : ILiftMoveType
	{
		// Token: 0x06009EAF RID: 40623 RVA: 0x0016CE74 File Offset: 0x0016B074
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

		// Token: 0x06009EB0 RID: 40624 RVA: 0x0016CEAC File Offset: 0x0016B0AC
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

		// Token: 0x06009EB1 RID: 40625 RVA: 0x0016CEBF File Offset: 0x0016B0BF
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

		// Token: 0x06009EB2 RID: 40626 RVA: 0x0016CED2 File Offset: 0x0016B0D2
		public new ILiftMoveTypeCircular_SetValue ToSetValue()
		{
			return new ILiftMoveTypeCircular_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x0016CEE5 File Offset: 0x0016B0E5
		// (set) Token: 0x06009EB4 RID: 40628 RVA: 0x0016CF10 File Offset: 0x0016B110
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

		// Token: 0x040060C0 RID: 24768
		[Nullable(2)]
		protected new ILiftMoveTypeCircular FbInstance;

		// Token: 0x040060C1 RID: 24769
		[Nullable(2)]
		protected new ILiftMoveTypeCircular_SetValue PocoInterface;
	}
}
