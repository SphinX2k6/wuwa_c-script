using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B86 RID: 7046
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveTypeDefault : ILiftMoveType
	{
		// Token: 0x060096E1 RID: 38625 RVA: 0x0015C4CC File Offset: 0x0015A6CC
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

		// Token: 0x060096E2 RID: 38626 RVA: 0x0015C504 File Offset: 0x0015A704
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

		// Token: 0x060096E3 RID: 38627 RVA: 0x0015C517 File Offset: 0x0015A717
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

		// Token: 0x060096E4 RID: 38628 RVA: 0x0015C52A File Offset: 0x0015A72A
		public new ILiftMoveTypeDefault_SetValue ToSetValue()
		{
			return new ILiftMoveTypeDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x060096E5 RID: 38629 RVA: 0x0015C53D File Offset: 0x0015A73D
		// (set) Token: 0x060096E6 RID: 38630 RVA: 0x0015C568 File Offset: 0x0015A768
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

		// Token: 0x04005C2F RID: 23599
		[Nullable(2)]
		protected new ILiftMoveTypeDefault FbInstance;

		// Token: 0x04005C30 RID: 23600
		[Nullable(2)]
		protected new ILiftMoveTypeDefault_SetValue PocoInterface;
	}
}
