using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004BB RID: 1211
	public class IInhaledPerResultType
	{
		// Token: 0x06001841 RID: 6209 RVA: 0x00049724 File Offset: 0x00047924
		private IInhaledPerResultType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhaledPerResultType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhaledPerResultType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhaledPerResultType_SetValue());
			}
			return result;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0004975C File Offset: 0x0004795C
		public static IInhaledPerResultType Create([Nullable(2)] IInhaledPerResultType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledPerResultType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0004976F File Offset: 0x0004796F
		public static IInhaledPerResultType CreateFromSetValue([Nullable(2)] IInhaledPerResultType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhaledPerResultType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00049782 File Offset: 0x00047982
		public IInhaledPerResultType_SetValue ToSetValue()
		{
			return new IInhaledPerResultType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00049795 File Offset: 0x00047995
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x000497C0 File Offset: 0x000479C0
		public virtual EInhaledPerResultType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001259 RID: 4697
		[Nullable(2)]
		protected IInhaledPerResultType FbInstance;

		// Token: 0x0400125A RID: 4698
		[Nullable(2)]
		protected IInhaledPerResultType_SetValue PocoInterface;
	}
}
