using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BCA RID: 7114
	public class IFaceExpressionConfig
	{
		// Token: 0x0600970E RID: 38670 RVA: 0x0015F3C8 File Offset: 0x0015D5C8
		private IFaceExpressionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaceExpressionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaceExpressionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaceExpressionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x0015F400 File Offset: 0x0015D600
		public static IFaceExpressionConfig Create([Nullable(2)] IFaceExpressionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceExpressionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x0015F413 File Offset: 0x0015D613
		public static IFaceExpressionConfig CreateFromSetValue([Nullable(2)] IFaceExpressionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaceExpressionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x0015F426 File Offset: 0x0015D626
		public IFaceExpressionConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x0015F439 File Offset: 0x0015D639
		// (set) Token: 0x06009713 RID: 38675 RVA: 0x0015F464 File Offset: 0x0015D664
		public virtual EFaceExpressionConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFaceExpressionConfigType.Morph;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D3A RID: 23866
		[Nullable(2)]
		protected IFaceExpressionConfig FbInstance;

		// Token: 0x04005D3B RID: 23867
		[Nullable(2)]
		protected IFaceExpressionConfig_SetValue PocoInterface;
	}
}
