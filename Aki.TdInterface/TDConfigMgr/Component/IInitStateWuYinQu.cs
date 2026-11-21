using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C9 RID: 1225
	public class IInitStateWuYinQu : IInitState
	{
		// Token: 0x06001883 RID: 6275 RVA: 0x00049E24 File Offset: 0x00048024
		private IInitStateWuYinQu_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateWuYinQu 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateWuYinQu_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateWuYinQu_SetValue());
			}
			return result;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00049E5C File Offset: 0x0004805C
		public static IInitStateWuYinQu Create([Nullable(2)] IInitStateWuYinQu instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateWuYinQu
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00049E6F File Offset: 0x0004806F
		public static IInitStateWuYinQu CreateFromSetValue([Nullable(2)] IInitStateWuYinQu_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateWuYinQu
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00049E82 File Offset: 0x00048082
		public new IInitStateWuYinQu_SetValue ToSetValue()
		{
			return new IInitStateWuYinQu_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00049E95 File Offset: 0x00048095
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x00049EC0 File Offset: 0x000480C0
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001275 RID: 4725
		[Nullable(2)]
		protected new IInitStateWuYinQu FbInstance;

		// Token: 0x04001276 RID: 4726
		[Nullable(2)]
		protected new IInitStateWuYinQu_SetValue PocoInterface;
	}
}
