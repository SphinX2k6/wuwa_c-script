using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EC8 RID: 3784
	[NullableContext(1)]
	[Nullable(0)]
	public class IAreaNameSystemPrompt : ISystemPromptType
	{
		// Token: 0x0600538E RID: 21390 RVA: 0x000CD8C0 File Offset: 0x000CBAC0
		private IAreaNameSystemPrompt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAreaNameSystemPrompt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAreaNameSystemPrompt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAreaNameSystemPrompt_SetValue());
			}
			return result;
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x000CD8F8 File Offset: 0x000CBAF8
		public static IAreaNameSystemPrompt Create([Nullable(2)] IAreaNameSystemPrompt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAreaNameSystemPrompt
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x000CD90B File Offset: 0x000CBB0B
		public static IAreaNameSystemPrompt CreateFromSetValue([Nullable(2)] IAreaNameSystemPrompt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAreaNameSystemPrompt
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x000CD91E File Offset: 0x000CBB1E
		public new IAreaNameSystemPrompt_SetValue ToSetValue()
		{
			return new IAreaNameSystemPrompt_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x000CD931 File Offset: 0x000CBB31
		// (set) Token: 0x06005393 RID: 21395 RVA: 0x000CD95C File Offset: 0x000CBB5C
		public override ESystemPromptType Type
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

		// Token: 0x0400329E RID: 12958
		[Nullable(2)]
		protected new IAreaNameSystemPrompt FbInstance;

		// Token: 0x0400329F RID: 12959
		[Nullable(2)]
		protected new IAreaNameSystemPrompt_SetValue PocoInterface;
	}
}
