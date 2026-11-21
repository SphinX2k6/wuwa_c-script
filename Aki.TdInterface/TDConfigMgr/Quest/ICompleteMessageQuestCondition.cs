using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001038 RID: 4152
	public class ICompleteMessageQuestCondition : IPhoneMessageProgressTypeBase
	{
		// Token: 0x06005B2A RID: 23338 RVA: 0x000DE04C File Offset: 0x000DC24C
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

		// Token: 0x06005B2B RID: 23339 RVA: 0x000DE084 File Offset: 0x000DC284
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

		// Token: 0x06005B2C RID: 23340 RVA: 0x000DE097 File Offset: 0x000DC297
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

		// Token: 0x06005B2D RID: 23341 RVA: 0x000DE0AA File Offset: 0x000DC2AA
		public new ICompleteMessageQuestCondition_SetValue ToSetValue()
		{
			return new ICompleteMessageQuestCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x000DE0BD File Offset: 0x000DC2BD
		// (set) Token: 0x06005B2F RID: 23343 RVA: 0x000DE0E8 File Offset: 0x000DC2E8
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

		// Token: 0x040036E3 RID: 14051
		[Nullable(2)]
		protected new ICompleteMessageQuestCondition FbInstance;

		// Token: 0x040036E4 RID: 14052
		[Nullable(2)]
		protected new ICompleteMessageQuestCondition_SetValue PocoInterface;
	}
}
