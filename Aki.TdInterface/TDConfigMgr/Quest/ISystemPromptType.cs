using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001166 RID: 4454
	[NullableContext(1)]
	[Nullable(0)]
	public class ISystemPromptType
	{
		// Token: 0x06006516 RID: 25878 RVA: 0x000F2A04 File Offset: 0x000F0C04
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

		// Token: 0x06006517 RID: 25879 RVA: 0x000F2A3C File Offset: 0x000F0C3C
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

		// Token: 0x06006518 RID: 25880 RVA: 0x000F2A4F File Offset: 0x000F0C4F
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

		// Token: 0x06006519 RID: 25881 RVA: 0x000F2A62 File Offset: 0x000F0C62
		public ISystemPromptType_SetValue ToSetValue()
		{
			return new ISystemPromptType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x000F2A75 File Offset: 0x000F0C75
		// (set) Token: 0x0600651B RID: 25883 RVA: 0x000F2AA0 File Offset: 0x000F0CA0
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

		// Token: 0x04003CA4 RID: 15524
		[Nullable(2)]
		protected ISystemPromptType FbInstance;

		// Token: 0x04003CA5 RID: 15525
		[Nullable(2)]
		protected ISystemPromptType_SetValue PocoInterface;
	}
}
