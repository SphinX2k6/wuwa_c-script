using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200101A RID: 4122
	public class ICheckTrapDefenseEventBase
	{
		// Token: 0x06005A44 RID: 23108 RVA: 0x000DC0A0 File Offset: 0x000DA2A0
		private ICheckTrapDefenseEventBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckTrapDefenseEventBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckTrapDefenseEventBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckTrapDefenseEventBase_SetValue());
			}
			return result;
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x000DC0D8 File Offset: 0x000DA2D8
		public static ICheckTrapDefenseEventBase Create([Nullable(2)] ICheckTrapDefenseEventBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x000DC0EB File Offset: 0x000DA2EB
		public static ICheckTrapDefenseEventBase CreateFromSetValue([Nullable(2)] ICheckTrapDefenseEventBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckTrapDefenseEventBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x000DC0FE File Offset: 0x000DA2FE
		public ICheckTrapDefenseEventBase_SetValue ToSetValue()
		{
			return new ICheckTrapDefenseEventBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06005A48 RID: 23112 RVA: 0x000DC111 File Offset: 0x000DA311
		// (set) Token: 0x06005A49 RID: 23113 RVA: 0x000DC13C File Offset: 0x000DA33C
		public virtual ECheckTrapDefenseEvent Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400365F RID: 13919
		[Nullable(2)]
		protected ICheckTrapDefenseEventBase FbInstance;

		// Token: 0x04003660 RID: 13920
		[Nullable(2)]
		protected ICheckTrapDefenseEventBase_SetValue PocoInterface;
	}
}
