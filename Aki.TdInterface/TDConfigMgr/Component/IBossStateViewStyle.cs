using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000224 RID: 548
	public class IBossStateViewStyle
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00028494 File Offset: 0x00026694
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

		// Token: 0x060008DF RID: 2271 RVA: 0x000284CC File Offset: 0x000266CC
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

		// Token: 0x060008E0 RID: 2272 RVA: 0x000284DF File Offset: 0x000266DF
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

		// Token: 0x060008E1 RID: 2273 RVA: 0x000284F2 File Offset: 0x000266F2
		public IBossStateViewStyle_SetValue ToSetValue()
		{
			return new IBossStateViewStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00028505 File Offset: 0x00026705
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00028530 File Offset: 0x00026730
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

		// Token: 0x040009AD RID: 2477
		[Nullable(2)]
		protected IBossStateViewStyle FbInstance;

		// Token: 0x040009AE RID: 2478
		[Nullable(2)]
		protected IBossStateViewStyle_SetValue PocoInterface;
	}
}
