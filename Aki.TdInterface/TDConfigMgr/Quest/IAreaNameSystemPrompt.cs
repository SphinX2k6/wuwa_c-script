using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FDE RID: 4062
	public class IAreaNameSystemPrompt : ISystemPromptType
	{
		// Token: 0x0600590A RID: 22794 RVA: 0x000D9A68 File Offset: 0x000D7C68
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

		// Token: 0x0600590B RID: 22795 RVA: 0x000D9AA0 File Offset: 0x000D7CA0
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

		// Token: 0x0600590C RID: 22796 RVA: 0x000D9AB3 File Offset: 0x000D7CB3
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

		// Token: 0x0600590D RID: 22797 RVA: 0x000D9AC6 File Offset: 0x000D7CC6
		public new IAreaNameSystemPrompt_SetValue ToSetValue()
		{
			return new IAreaNameSystemPrompt_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x0600590E RID: 22798 RVA: 0x000D9AD9 File Offset: 0x000D7CD9
		// (set) Token: 0x0600590F RID: 22799 RVA: 0x000D9B04 File Offset: 0x000D7D04
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

		// Token: 0x040035AB RID: 13739
		[Nullable(2)]
		protected new IAreaNameSystemPrompt FbInstance;

		// Token: 0x040035AC RID: 13740
		[Nullable(2)]
		protected new IAreaNameSystemPrompt_SetValue PocoInterface;
	}
}
