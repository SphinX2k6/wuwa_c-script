using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001798 RID: 6040
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorTurnToEmptyData : IActorTurnToData
	{
		// Token: 0x06007FDD RID: 32733 RVA: 0x001316EC File Offset: 0x0012F8EC
		private IActorTurnToEmptyData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorTurnToEmptyData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorTurnToEmptyData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorTurnToEmptyData_SetValue());
			}
			return result;
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x00131724 File Offset: 0x0012F924
		public static IActorTurnToEmptyData Create([Nullable(2)] IActorTurnToEmptyData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToEmptyData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x00131737 File Offset: 0x0012F937
		public static IActorTurnToEmptyData CreateFromSetValue([Nullable(2)] IActorTurnToEmptyData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorTurnToEmptyData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x0013174A File Offset: 0x0012F94A
		public new IActorTurnToEmptyData_SetValue ToSetValue()
		{
			return new IActorTurnToEmptyData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x06007FE1 RID: 32737 RVA: 0x0013175D File Offset: 0x0012F95D
		// (set) Token: 0x06007FE2 RID: 32738 RVA: 0x00131788 File Offset: 0x0012F988
		public override EActorTurnToMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorTurnToMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005136 RID: 20790
		[Nullable(2)]
		protected new IActorTurnToEmptyData FbInstance;

		// Token: 0x04005137 RID: 20791
		[Nullable(2)]
		protected new IActorTurnToEmptyData_SetValue PocoInterface;
	}
}
