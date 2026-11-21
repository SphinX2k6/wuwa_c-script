using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001919 RID: 6425
	public class IActorTurnToEmptyData : IActorTurnToData
	{
		// Token: 0x060086CD RID: 34509 RVA: 0x0014094C File Offset: 0x0013EB4C
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

		// Token: 0x060086CE RID: 34510 RVA: 0x00140984 File Offset: 0x0013EB84
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

		// Token: 0x060086CF RID: 34511 RVA: 0x00140997 File Offset: 0x0013EB97
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

		// Token: 0x060086D0 RID: 34512 RVA: 0x001409AA File Offset: 0x0013EBAA
		public new IActorTurnToEmptyData_SetValue ToSetValue()
		{
			return new IActorTurnToEmptyData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x060086D1 RID: 34513 RVA: 0x001409BD File Offset: 0x0013EBBD
		// (set) Token: 0x060086D2 RID: 34514 RVA: 0x001409E8 File Offset: 0x0013EBE8
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

		// Token: 0x0400556C RID: 21868
		[Nullable(2)]
		protected new IActorTurnToEmptyData FbInstance;

		// Token: 0x0400556D RID: 21869
		[Nullable(2)]
		protected new IActorTurnToEmptyData_SetValue PocoInterface;
	}
}
