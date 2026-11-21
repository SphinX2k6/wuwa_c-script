using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D23 RID: 7459
	public class ILevelPlayVarContext : IVarContext
	{
		// Token: 0x06009E69 RID: 40553 RVA: 0x0016C5E4 File Offset: 0x0016A7E4
		private ILevelPlayVarContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPlayVarContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPlayVarContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPlayVarContext_SetValue());
			}
			return result;
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x0016C61C File Offset: 0x0016A81C
		public static ILevelPlayVarContext Create([Nullable(2)] ILevelPlayVarContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayVarContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x0016C62F File Offset: 0x0016A82F
		public static ILevelPlayVarContext CreateFromSetValue([Nullable(2)] ILevelPlayVarContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPlayVarContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x0016C642 File Offset: 0x0016A842
		public new ILevelPlayVarContext_SetValue ToSetValue()
		{
			return new ILevelPlayVarContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x06009E6D RID: 40557 RVA: 0x0016C661 File Offset: 0x0016A861
		// (set) Token: 0x06009E6E RID: 40558 RVA: 0x0016C68C File Offset: 0x0016A88C
		public override EVarContext Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVarContext)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x0016C69A File Offset: 0x0016A89A
		// (set) Token: 0x06009E70 RID: 40560 RVA: 0x0016C6C5 File Offset: 0x0016A8C5
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x0400609D RID: 24733
		[Nullable(2)]
		protected new ILevelPlayVarContext FbInstance;

		// Token: 0x0400609E RID: 24734
		[Nullable(2)]
		protected new ILevelPlayVarContext_SetValue PocoInterface;
	}
}
