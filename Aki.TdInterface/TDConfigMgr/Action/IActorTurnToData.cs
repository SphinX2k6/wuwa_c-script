using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001917 RID: 6423
	public class IActorTurnToData
	{
		// Token: 0x060086C5 RID: 34501 RVA: 0x00140890 File Offset: 0x0013EA90
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

		// Token: 0x060086C6 RID: 34502 RVA: 0x001408C8 File Offset: 0x0013EAC8
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

		// Token: 0x060086C7 RID: 34503 RVA: 0x001408DB File Offset: 0x0013EADB
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

		// Token: 0x060086C8 RID: 34504 RVA: 0x001408EE File Offset: 0x0013EAEE
		public IActorTurnToData_SetValue ToSetValue()
		{
			return new IActorTurnToData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x060086C9 RID: 34505 RVA: 0x00140901 File Offset: 0x0013EB01
		// (set) Token: 0x060086CA RID: 34506 RVA: 0x0014092C File Offset: 0x0013EB2C
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

		// Token: 0x04005569 RID: 21865
		[Nullable(2)]
		protected IActorTurnToData FbInstance;

		// Token: 0x0400556A RID: 21866
		[Nullable(2)]
		protected IActorTurnToData_SetValue PocoInterface;
	}
}
