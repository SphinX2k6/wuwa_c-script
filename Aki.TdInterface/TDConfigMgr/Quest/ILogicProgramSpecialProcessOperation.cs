using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001003 RID: 4099
	[NullableContext(1)]
	[Nullable(0)]
	public class ILogicProgramSpecialProcessOperation
	{
		// Token: 0x06005B84 RID: 23428 RVA: 0x000DE2AC File Offset: 0x000DC4AC
		private ILogicProgramSpecialProcessOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILogicProgramSpecialProcessOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILogicProgramSpecialProcessOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILogicProgramSpecialProcessOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x000DE2E4 File Offset: 0x000DC4E4
		public static ILogicProgramSpecialProcessOperation Create([Nullable(2)] ILogicProgramSpecialProcessOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILogicProgramSpecialProcessOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x000DE2F7 File Offset: 0x000DC4F7
		public static ILogicProgramSpecialProcessOperation CreateFromSetValue([Nullable(2)] ILogicProgramSpecialProcessOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILogicProgramSpecialProcessOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x000DE30A File Offset: 0x000DC50A
		public ILogicProgramSpecialProcessOperation_SetValue ToSetValue()
		{
			return new ILogicProgramSpecialProcessOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06005B88 RID: 23432 RVA: 0x000DE31D File Offset: 0x000DC51D
		// (set) Token: 0x06005B89 RID: 23433 RVA: 0x000DE348 File Offset: 0x000DC548
		public virtual ELogicProgramSpecialProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELogicProgramSpecialProcess.DisableURO;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003726 RID: 14118
		[Nullable(2)]
		protected ILogicProgramSpecialProcessOperation FbInstance;

		// Token: 0x04003727 RID: 14119
		[Nullable(2)]
		protected ILogicProgramSpecialProcessOperation_SetValue PocoInterface;
	}
}
