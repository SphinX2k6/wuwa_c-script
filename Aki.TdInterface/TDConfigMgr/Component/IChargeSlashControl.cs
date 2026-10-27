using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000233 RID: 563
	[NullableContext(2)]
	[Nullable(0)]
	public class IChargeSlashControl : ICurveControlConfig
	{
		// Token: 0x060009E0 RID: 2528 RVA: 0x0002A20C File Offset: 0x0002840C
		[NullableContext(1)]
		private IChargeSlashControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChargeSlashControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChargeSlashControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChargeSlashControl_SetValue());
			}
			return result;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002A244 File Offset: 0x00028444
		[NullableContext(1)]
		public static IChargeSlashControl Create([Nullable(2)] IChargeSlashControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChargeSlashControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002A257 File Offset: 0x00028457
		[NullableContext(1)]
		public static IChargeSlashControl CreateFromSetValue([Nullable(2)] IChargeSlashControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChargeSlashControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002A26A File Offset: 0x0002846A
		[NullableContext(1)]
		public new IChargeSlashControl_SetValue ToSetValue()
		{
			return new IChargeSlashControl_SetValue
			{
				Type = this.Type,
				UpHeight = this.UpHeight,
				UpCurvePath = this.UpCurvePath
			};
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0002A295 File Offset: 0x00028495
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0002A2C0 File Offset: 0x000284C0
		public override ECurveControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECurveControlType.ChargeSlash;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0002A2CE File Offset: 0x000284CE
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0002A2F9 File Offset: 0x000284F9
		public virtual int UpHeight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpHeight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.UpHeight;
			}
			set
			{
				this.GetOrCreatePoco().UpHeight = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0002A307 File Offset: 0x00028507
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0002A32E File Offset: 0x0002852E
		public virtual string UpCurvePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpCurvePath;
				}
				IChargeSlashControl_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UpCurvePath;
			}
			set
			{
				this.GetOrCreatePoco().UpCurvePath = value;
			}
		}

		// Token: 0x04000A11 RID: 2577
		protected new IChargeSlashControl FbInstance;

		// Token: 0x04000A12 RID: 2578
		protected new IChargeSlashControl_SetValue PocoInterface;
	}
}
