using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010F8 RID: 4344
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueRandomEvent : IShowUi
	{
		// Token: 0x06006246 RID: 25158 RVA: 0x000ECD0C File Offset: 0x000EAF0C
		private IRogueRandomEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueRandomEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueRandomEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueRandomEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x000ECD44 File Offset: 0x000EAF44
		public static IRogueRandomEvent Create([Nullable(2)] IRogueRandomEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueRandomEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x000ECD57 File Offset: 0x000EAF57
		public static IRogueRandomEvent CreateFromSetValue([Nullable(2)] IRogueRandomEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueRandomEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x000ECD6A File Offset: 0x000EAF6A
		public new IRogueRandomEvent_SetValue ToSetValue()
		{
			return new IRogueRandomEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x0600624A RID: 25162 RVA: 0x000ECD7D File Offset: 0x000EAF7D
		// (set) Token: 0x0600624B RID: 25163 RVA: 0x000ECDA8 File Offset: 0x000EAFA8
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B0C RID: 15116
		[Nullable(2)]
		protected new IRogueRandomEvent FbInstance;

		// Token: 0x04003B0D RID: 15117
		[Nullable(2)]
		protected new IRogueRandomEvent_SetValue PocoInterface;
	}
}
