using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F04 RID: 3844
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckTrapDefenseEventBase
	{
		// Token: 0x060054C8 RID: 21704 RVA: 0x000CFEF8 File Offset: 0x000CE0F8
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

		// Token: 0x060054C9 RID: 21705 RVA: 0x000CFF30 File Offset: 0x000CE130
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

		// Token: 0x060054CA RID: 21706 RVA: 0x000CFF43 File Offset: 0x000CE143
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

		// Token: 0x060054CB RID: 21707 RVA: 0x000CFF56 File Offset: 0x000CE156
		public ICheckTrapDefenseEventBase_SetValue ToSetValue()
		{
			return new ICheckTrapDefenseEventBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x000CFF69 File Offset: 0x000CE169
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x000CFF94 File Offset: 0x000CE194
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

		// Token: 0x04003352 RID: 13138
		[Nullable(2)]
		protected ICheckTrapDefenseEventBase FbInstance;

		// Token: 0x04003353 RID: 13139
		[Nullable(2)]
		protected ICheckTrapDefenseEventBase_SetValue PocoInterface;
	}
}
