using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D33 RID: 7475
	public class ILiftMoveTypeDefault : ILiftMoveType
	{
		// Token: 0x06009EC3 RID: 40643 RVA: 0x0016D078 File Offset: 0x0016B278
		private ILiftMoveTypeDefault_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveTypeDefault 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveTypeDefault_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveTypeDefault_SetValue());
			}
			return result;
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x0016D0B0 File Offset: 0x0016B2B0
		public static ILiftMoveTypeDefault Create([Nullable(2)] ILiftMoveTypeDefault instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeDefault
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x0016D0C3 File Offset: 0x0016B2C3
		public static ILiftMoveTypeDefault CreateFromSetValue([Nullable(2)] ILiftMoveTypeDefault_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveTypeDefault
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x0016D0D6 File Offset: 0x0016B2D6
		public new ILiftMoveTypeDefault_SetValue ToSetValue()
		{
			return new ILiftMoveTypeDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x0016D0E9 File Offset: 0x0016B2E9
		// (set) Token: 0x06009EC8 RID: 40648 RVA: 0x0016D114 File Offset: 0x0016B314
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

		// Token: 0x040060C8 RID: 24776
		[Nullable(2)]
		protected new ILiftMoveTypeDefault FbInstance;

		// Token: 0x040060C9 RID: 24777
		[Nullable(2)]
		protected new ILiftMoveTypeDefault_SetValue PocoInterface;
	}
}
