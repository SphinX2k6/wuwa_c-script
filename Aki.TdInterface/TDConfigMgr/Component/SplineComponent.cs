using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A3 RID: 2211
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineComponent : IComponentBase
	{
		// Token: 0x0600317F RID: 12671 RVA: 0x0007F248 File Offset: 0x0007D448
		private SplineComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SplineComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SplineComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SplineComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x0007F280 File Offset: 0x0007D480
		public static SplineComponent Create([Nullable(2)] SplineComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SplineComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0007F293 File Offset: 0x0007D493
		public static SplineComponent CreateFromSetValue([Nullable(2)] SplineComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SplineComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0007F2A6 File Offset: 0x0007D4A6
		public new SplineComponent_SetValue ToSetValue()
		{
			return new SplineComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Option = this.Option
			};
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x0007F2D4 File Offset: 0x0007D4D4
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x0007F30E File Offset: 0x0007D50E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SplineComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x0007F31C File Offset: 0x0007D51C
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x0007F346 File Offset: 0x0007D546
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x0007F354 File Offset: 0x0007D554
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x0007F37B File Offset: 0x0007D57B
		public virtual ISplineType Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				SplineComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x04002082 RID: 8322
		[Nullable(2)]
		protected new SplineComponent FbInstance;

		// Token: 0x04002083 RID: 8323
		[Nullable(2)]
		protected new SplineComponent_SetValue PocoInterface;
	}
}
