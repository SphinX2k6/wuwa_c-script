using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002219 RID: 8729
	public class IToolEditorActionContext : IActionContextType
	{
		// Token: 0x0600BE50 RID: 48720 RVA: 0x001B7AD0 File Offset: 0x001B5CD0
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

		// Token: 0x0600BE51 RID: 48721 RVA: 0x001B7B08 File Offset: 0x001B5D08
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

		// Token: 0x0600BE52 RID: 48722 RVA: 0x001B7B1B File Offset: 0x001B5D1B
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

		// Token: 0x0600BE53 RID: 48723 RVA: 0x001B7B2E File Offset: 0x001B5D2E
		public new IToolEditorActionContext_SetValue ToSetValue()
		{
			return new IToolEditorActionContext_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0600BE54 RID: 48724 RVA: 0x001B7B41 File Offset: 0x001B5D41
		// (set) Token: 0x0600BE55 RID: 48725 RVA: 0x001B7B6C File Offset: 0x001B5D6C
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

		// Token: 0x04007227 RID: 29223
		[Nullable(2)]
		protected new IToolEditorActionContext FbInstance;

		// Token: 0x04007228 RID: 29224
		[Nullable(2)]
		protected new IToolEditorActionContext_SetValue PocoInterface;
	}
}
