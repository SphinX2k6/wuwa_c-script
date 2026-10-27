using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A35 RID: 6709
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceExpressionConfig
	{
		// Token: 0x06008FA4 RID: 36772 RVA: 0x0014F49C File Offset: 0x0014D69C
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

		// Token: 0x06008FA5 RID: 36773 RVA: 0x0014F4D4 File Offset: 0x0014D6D4
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

		// Token: 0x06008FA6 RID: 36774 RVA: 0x0014F4E7 File Offset: 0x0014D6E7
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

		// Token: 0x06008FA7 RID: 36775 RVA: 0x0014F4FA File Offset: 0x0014D6FA
		public IFaceExpressionConfig_SetValue ToSetValue()
		{
			return new IFaceExpressionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x0014F50D File Offset: 0x0014D70D
		// (set) Token: 0x06008FA9 RID: 36777 RVA: 0x0014F538 File Offset: 0x0014D738
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

		// Token: 0x040058D5 RID: 22741
		[Nullable(2)]
		protected IFaceExpressionConfig FbInstance;

		// Token: 0x040058D6 RID: 22742
		[Nullable(2)]
		protected IFaceExpressionConfig_SetValue PocoInterface;
	}
}
