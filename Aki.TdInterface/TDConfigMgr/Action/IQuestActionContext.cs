using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F8F RID: 8079
	public class IQuestActionContext : IActionContextType
	{
		// Token: 0x0600ABBF RID: 43967 RVA: 0x00184A18 File Offset: 0x00182C18
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

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x00184A50 File Offset: 0x00182C50
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

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x00184A63 File Offset: 0x00182C63
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

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x00184A76 File Offset: 0x00182C76
		public new IQuestActionContext_SetValue ToSetValue()
		{
			return new IQuestActionContext_SetValue
			{
				Type = this.Type,
				IsChildQuestOfDungeon = this.IsChildQuestOfDungeon
			};
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600ABC3 RID: 43971 RVA: 0x00184A95 File Offset: 0x00182C95
		// (set) Token: 0x0600ABC4 RID: 43972 RVA: 0x00184AC0 File Offset: 0x00182CC0
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

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600ABC5 RID: 43973 RVA: 0x00184AD0 File Offset: 0x00182CD0
		// (set) Token: 0x0600ABC6 RID: 43974 RVA: 0x00184B0A File Offset: 0x00182D0A
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

		// Token: 0x040066C8 RID: 26312
		[Nullable(2)]
		protected new IQuestActionContext FbInstance;

		// Token: 0x040066C9 RID: 26313
		[Nullable(2)]
		protected new IQuestActionContext_SetValue PocoInterface;
	}
}
