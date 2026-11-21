using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200112F RID: 4399
	public class ILogicProgramSpecialProcessOperation
	{
		// Token: 0x06006164 RID: 24932 RVA: 0x000EAEEC File Offset: 0x000E90EC
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

		// Token: 0x06006165 RID: 24933 RVA: 0x000EAF24 File Offset: 0x000E9124
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

		// Token: 0x06006166 RID: 24934 RVA: 0x000EAF37 File Offset: 0x000E9137
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

		// Token: 0x06006167 RID: 24935 RVA: 0x000EAF4A File Offset: 0x000E914A
		public ILogicProgramSpecialProcessOperation_SetValue ToSetValue()
		{
			return new ILogicProgramSpecialProcessOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x000EAF5D File Offset: 0x000E915D
		// (set) Token: 0x06006169 RID: 24937 RVA: 0x000EAF88 File Offset: 0x000E9188
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

		// Token: 0x04003A5E RID: 14942
		[Nullable(2)]
		protected ILogicProgramSpecialProcessOperation FbInstance;

		// Token: 0x04003A5F RID: 14943
		[Nullable(2)]
		protected ILogicProgramSpecialProcessOperation_SetValue PocoInterface;
	}
}
