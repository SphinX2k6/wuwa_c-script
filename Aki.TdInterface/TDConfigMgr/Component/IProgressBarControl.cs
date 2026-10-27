using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200062C RID: 1580
	[NullableContext(1)]
	[Nullable(0)]
	public class IProgressBarControl
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x0005D26C File Offset: 0x0005B46C
		private IProgressBarControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProgressBarControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProgressBarControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProgressBarControl_SetValue());
			}
			return result;
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0005D2A4 File Offset: 0x0005B4A4
		public static IProgressBarControl Create([Nullable(2)] IProgressBarControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBarControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0005D2B7 File Offset: 0x0005B4B7
		public static IProgressBarControl CreateFromSetValue([Nullable(2)] IProgressBarControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProgressBarControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0005D2CA File Offset: 0x0005B4CA
		public IProgressBarControl_SetValue ToSetValue()
		{
			return new IProgressBarControl_SetValue
			{
				Type = this.Type,
				MaxValue = this.MaxValue,
				InitValue = this.InitValue,
				ProgressPerformanceAttribute = this.ProgressPerformanceAttribute
			};
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x0005D301 File Offset: 0x0005B501
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x0005D32C File Offset: 0x0005B52C
		public virtual EProgressBarControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x0005D33A File Offset: 0x0005B53A
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x0005D365 File Offset: 0x0005B565
		public virtual int MaxValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxValue;
			}
			set
			{
				this.GetOrCreatePoco().MaxValue = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x0005D373 File Offset: 0x0005B573
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x0005D39E File Offset: 0x0005B59E
		public virtual int InitValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitValue;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InitValue;
			}
			set
			{
				this.GetOrCreatePoco().InitValue = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x0005D3AC File Offset: 0x0005B5AC
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x0005D3E6 File Offset: 0x0005B5E6
		public virtual int? ProgressPerformanceAttribute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressPerformanceAttribute;
				}
				IProgressBarControl_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProgressPerformanceAttribute;
			}
			set
			{
				this.GetOrCreatePoco().ProgressPerformanceAttribute = value;
			}
		}

		// Token: 0x04001785 RID: 6021
		[Nullable(2)]
		protected IProgressBarControl FbInstance;

		// Token: 0x04001786 RID: 6022
		[Nullable(2)]
		protected IProgressBarControl_SetValue PocoInterface;
	}
}
