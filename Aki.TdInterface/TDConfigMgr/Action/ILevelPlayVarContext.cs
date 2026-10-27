using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B76 RID: 7030
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayVarContext : IVarContext
	{
		// Token: 0x06009687 RID: 38535 RVA: 0x0015BA38 File Offset: 0x00159C38
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

		// Token: 0x06009688 RID: 38536 RVA: 0x0015BA70 File Offset: 0x00159C70
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

		// Token: 0x06009689 RID: 38537 RVA: 0x0015BA83 File Offset: 0x00159C83
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

		// Token: 0x0600968A RID: 38538 RVA: 0x0015BA96 File Offset: 0x00159C96
		public new ILevelPlayVarContext_SetValue ToSetValue()
		{
			return new ILevelPlayVarContext_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0600968B RID: 38539 RVA: 0x0015BAB5 File Offset: 0x00159CB5
		// (set) Token: 0x0600968C RID: 38540 RVA: 0x0015BAE0 File Offset: 0x00159CE0
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

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x0015BAEE File Offset: 0x00159CEE
		// (set) Token: 0x0600968E RID: 38542 RVA: 0x0015BB19 File Offset: 0x00159D19
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

		// Token: 0x04005C04 RID: 23556
		[Nullable(2)]
		protected new ILevelPlayVarContext FbInstance;

		// Token: 0x04005C05 RID: 23557
		[Nullable(2)]
		protected new ILevelPlayVarContext_SetValue PocoInterface;
	}
}
