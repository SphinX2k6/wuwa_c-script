using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001796 RID: 6038
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorTurnToData
	{
		// Token: 0x06007FD5 RID: 32725 RVA: 0x00131630 File Offset: 0x0012F830
		private IActorTurnToData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorTurnToData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorTurnToData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorTurnToData_SetValue());
			}
			return result;
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00131668 File Offset: 0x0012F868
		public static IActorTurnToData Create([Nullable(2)] IActorTurnToData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x0013167B File Offset: 0x0012F87B
		public static IActorTurnToData CreateFromSetValue([Nullable(2)] IActorTurnToData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorTurnToData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x0013168E File Offset: 0x0012F88E
		public IActorTurnToData_SetValue ToSetValue()
		{
			return new IActorTurnToData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x001316A1 File Offset: 0x0012F8A1
		// (set) Token: 0x06007FDA RID: 32730 RVA: 0x001316CC File Offset: 0x0012F8CC
		public virtual EActorTurnToMode Type
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

		// Token: 0x04005133 RID: 20787
		[Nullable(2)]
		protected IActorTurnToData FbInstance;

		// Token: 0x04005134 RID: 20788
		[Nullable(2)]
		protected IActorTurnToData_SetValue PocoInterface;
	}
}
