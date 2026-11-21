using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000946 RID: 2374
	public class SplineComponent : IComponentBase
	{
		// Token: 0x060034BB RID: 13499 RVA: 0x00086730 File Offset: 0x00084930
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

		// Token: 0x060034BC RID: 13500 RVA: 0x00086768 File Offset: 0x00084968
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

		// Token: 0x060034BD RID: 13501 RVA: 0x0008677B File Offset: 0x0008497B
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

		// Token: 0x060034BE RID: 13502 RVA: 0x0008678E File Offset: 0x0008498E
		public new SplineComponent_SetValue ToSetValue()
		{
			return new SplineComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Option = this.Option
			};
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x000867BC File Offset: 0x000849BC
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x000867F6 File Offset: 0x000849F6
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

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x00086804 File Offset: 0x00084A04
		// (set) Token: 0x060034C2 RID: 13506 RVA: 0x0008682E File Offset: 0x00084A2E
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

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x0008683C File Offset: 0x00084A3C
		// (set) Token: 0x060034C4 RID: 13508 RVA: 0x00086863 File Offset: 0x00084A63
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

		// Token: 0x04002294 RID: 8852
		[Nullable(2)]
		protected new SplineComponent FbInstance;

		// Token: 0x04002295 RID: 8853
		[Nullable(2)]
		protected new SplineComponent_SetValue PocoInterface;
	}
}
