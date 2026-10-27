using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F22 RID: 3874
	[NullableContext(1)]
	[Nullable(0)]
	public class ICompleteMessageQuestCondition : IPhoneMessageProgressTypeBase
	{
		// Token: 0x060055AE RID: 21934 RVA: 0x000D1EA4 File Offset: 0x000D00A4
		private ICompleteMessageQuestCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICompleteMessageQuestCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICompleteMessageQuestCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICompleteMessageQuestCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x000D1EDC File Offset: 0x000D00DC
		public static ICompleteMessageQuestCondition Create([Nullable(2)] ICompleteMessageQuestCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICompleteMessageQuestCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x000D1EEF File Offset: 0x000D00EF
		public static ICompleteMessageQuestCondition CreateFromSetValue([Nullable(2)] ICompleteMessageQuestCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICompleteMessageQuestCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x000D1F02 File Offset: 0x000D0102
		public new ICompleteMessageQuestCondition_SetValue ToSetValue()
		{
			return new ICompleteMessageQuestCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x000D1F15 File Offset: 0x000D0115
		// (set) Token: 0x060055B3 RID: 21939 RVA: 0x000D1F40 File Offset: 0x000D0140
		public override EPhoneMessageProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageProgressType.CompleteMessage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040033D6 RID: 13270
		[Nullable(2)]
		protected new ICompleteMessageQuestCondition FbInstance;

		// Token: 0x040033D7 RID: 13271
		[Nullable(2)]
		protected new ICompleteMessageQuestCondition_SetValue PocoInterface;
	}
}
