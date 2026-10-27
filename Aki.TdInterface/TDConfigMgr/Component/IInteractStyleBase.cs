using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000491 RID: 1169
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractStyleBase
	{
		// Token: 0x06001780 RID: 6016 RVA: 0x000471A0 File Offset: 0x000453A0
		private IInteractStyleBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractStyleBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractStyleBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractStyleBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000471D8 File Offset: 0x000453D8
		public static IInteractStyleBase Create([Nullable(2)] IInteractStyleBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractStyleBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000471EB File Offset: 0x000453EB
		public static IInteractStyleBase CreateFromSetValue([Nullable(2)] IInteractStyleBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractStyleBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000471FE File Offset: 0x000453FE
		public IInteractStyleBase_SetValue ToSetValue()
		{
			return new IInteractStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x00047211 File Offset: 0x00045411
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0004723C File Offset: 0x0004543C
		public virtual EInteractStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractStyleType.Panorama;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001196 RID: 4502
		[Nullable(2)]
		protected IInteractStyleBase FbInstance;

		// Token: 0x04001197 RID: 4503
		[Nullable(2)]
		protected IInteractStyleBase_SetValue PocoInterface;
	}
}
