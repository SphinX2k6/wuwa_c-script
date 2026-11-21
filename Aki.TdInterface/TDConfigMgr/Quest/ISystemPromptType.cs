using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001296 RID: 4758
	public class ISystemPromptType
	{
		// Token: 0x06006B1D RID: 27421 RVA: 0x000FFCC8 File Offset: 0x000FDEC8
		private ISystemPromptType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISystemPromptType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISystemPromptType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISystemPromptType_SetValue());
			}
			return result;
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x000FFD00 File Offset: 0x000FDF00
		public static ISystemPromptType Create([Nullable(2)] ISystemPromptType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemPromptType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x000FFD13 File Offset: 0x000FDF13
		public static ISystemPromptType CreateFromSetValue([Nullable(2)] ISystemPromptType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISystemPromptType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x000FFD26 File Offset: 0x000FDF26
		public ISystemPromptType_SetValue ToSetValue()
		{
			return new ISystemPromptType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06006B21 RID: 27425 RVA: 0x000FFD39 File Offset: 0x000FDF39
		// (set) Token: 0x06006B22 RID: 27426 RVA: 0x000FFD64 File Offset: 0x000FDF64
		public virtual ESystemPromptType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemPromptType.AreaName;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003FF7 RID: 16375
		[Nullable(2)]
		protected ISystemPromptType FbInstance;

		// Token: 0x04003FF8 RID: 16376
		[Nullable(2)]
		protected ISystemPromptType_SetValue PocoInterface;
	}
}
