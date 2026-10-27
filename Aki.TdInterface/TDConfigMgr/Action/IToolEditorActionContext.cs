using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD2 RID: 8146
	[NullableContext(1)]
	[Nullable(0)]
	public class IToolEditorActionContext : IActionContextType
	{
		// Token: 0x0600B33A RID: 45882 RVA: 0x001A1564 File Offset: 0x0019F764
		private IToolEditorActionContext_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToolEditorActionContext 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToolEditorActionContext_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToolEditorActionContext_SetValue());
			}
			return result;
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x001A159C File Offset: 0x0019F79C
		public static IToolEditorActionContext Create([Nullable(2)] IToolEditorActionContext instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToolEditorActionContext
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x001A15AF File Offset: 0x0019F7AF
		public static IToolEditorActionContext CreateFromSetValue([Nullable(2)] IToolEditorActionContext_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToolEditorActionContext
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x001A15C2 File Offset: 0x0019F7C2
		public new IToolEditorActionContext_SetValue ToSetValue()
		{
			return new IToolEditorActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600B33E RID: 45886 RVA: 0x001A15D5 File Offset: 0x0019F7D5
		// (set) Token: 0x0600B33F RID: 45887 RVA: 0x001A1600 File Offset: 0x0019F800
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

		// Token: 0x04006C25 RID: 27685
		[Nullable(2)]
		protected new IToolEditorActionContext FbInstance;

		// Token: 0x04006C26 RID: 27686
		[Nullable(2)]
		protected new IToolEditorActionContext_SetValue PocoInterface;
	}
}
