using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001FB RID: 507
	[NullableContext(1)]
	[Nullable(0)]
	public class IBossStateViewStyle
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x00026B40 File Offset: 0x00024D40
		private IBossStateViewStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBossStateViewStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBossStateViewStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBossStateViewStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00026B78 File Offset: 0x00024D78
		public static IBossStateViewStyle Create([Nullable(2)] IBossStateViewStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBossStateViewStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00026B8B File Offset: 0x00024D8B
		public static IBossStateViewStyle CreateFromSetValue([Nullable(2)] IBossStateViewStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBossStateViewStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00026B9E File Offset: 0x00024D9E
		public IBossStateViewStyle_SetValue ToSetValue()
		{
			return new IBossStateViewStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00026BB1 File Offset: 0x00024DB1
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00026BDC File Offset: 0x00024DDC
		public virtual EBossStateViewStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBossStateViewStyle.DoubleView;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400091C RID: 2332
		[Nullable(2)]
		protected IBossStateViewStyle FbInstance;

		// Token: 0x0400091D RID: 2333
		[Nullable(2)]
		protected IBossStateViewStyle_SetValue PocoInterface;
	}
}
