using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D7E RID: 7550
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestActionContext : IActionContextType
	{
		// Token: 0x0600A1D3 RID: 41427 RVA: 0x001705F4 File Offset: 0x0016E7F4
		private IQuestActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x0017062C File Offset: 0x0016E82C
		public static IQuestActionContext Create([Nullable(2)] IQuestActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x0017063F File Offset: 0x0016E83F
		public static IQuestActionContext CreateFromSetValue([Nullable(2)] IQuestActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x00170652 File Offset: 0x0016E852
		public new IQuestActionContext_SetValue ToSetValue()
		{
			return new IQuestActionContext_SetValue
			{
				Type = this.Type,
				IsChildQuestOfDungeon = this.IsChildQuestOfDungeon
			};
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600A1D7 RID: 41431 RVA: 0x00170671 File Offset: 0x0016E871
		// (set) Token: 0x0600A1D8 RID: 41432 RVA: 0x0017069C File Offset: 0x0016E89C
		public new virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600A1D9 RID: 41433 RVA: 0x001706AC File Offset: 0x0016E8AC
		// (set) Token: 0x0600A1DA RID: 41434 RVA: 0x001706E6 File Offset: 0x0016E8E6
		public virtual bool? IsChildQuestOfDungeon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsChildQuestOfDungeon;
				}
				IQuestActionContext_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsChildQuestOfDungeon;
			}
			set
			{
				this.GetOrCreatePoco().IsChildQuestOfDungeon = value;
			}
		}

		// Token: 0x0400614C RID: 24908
		[Nullable(2)]
		protected new IQuestActionContext FbInstance;

		// Token: 0x0400614D RID: 24909
		[Nullable(2)]
		protected new IQuestActionContext_SetValue PocoInterface;
	}
}
