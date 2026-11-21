using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001226 RID: 4646
	public class IRogueRandomEvent : IShowUi
	{
		// Token: 0x06006841 RID: 26689 RVA: 0x000F9E80 File Offset: 0x000F8080
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

		// Token: 0x06006842 RID: 26690 RVA: 0x000F9EB8 File Offset: 0x000F80B8
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

		// Token: 0x06006843 RID: 26691 RVA: 0x000F9ECB File Offset: 0x000F80CB
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

		// Token: 0x06006844 RID: 26692 RVA: 0x000F9EDE File Offset: 0x000F80DE
		public new IRogueRandomEvent_SetValue ToSetValue()
		{
			return new IRogueRandomEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06006845 RID: 26693 RVA: 0x000F9EF1 File Offset: 0x000F80F1
		// (set) Token: 0x06006846 RID: 26694 RVA: 0x000F9F1C File Offset: 0x000F811C
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

		// Token: 0x04003E5A RID: 15962
		[Nullable(2)]
		protected new IRogueRandomEvent FbInstance;

		// Token: 0x04003E5B RID: 15963
		[Nullable(2)]
		protected new IRogueRandomEvent_SetValue PocoInterface;
	}
}
