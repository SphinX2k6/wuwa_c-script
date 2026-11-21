using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006C9 RID: 1737
	public class IProgressBarControl
	{
		// Token: 0x060024C2 RID: 9410 RVA: 0x00063F80 File Offset: 0x00062180
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

		// Token: 0x060024C3 RID: 9411 RVA: 0x00063FB8 File Offset: 0x000621B8
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

		// Token: 0x060024C4 RID: 9412 RVA: 0x00063FCB File Offset: 0x000621CB
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

		// Token: 0x060024C5 RID: 9413 RVA: 0x00063FDE File Offset: 0x000621DE
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

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x00064015 File Offset: 0x00062215
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x00064040 File Offset: 0x00062240
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

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x0006404E File Offset: 0x0006224E
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x00064079 File Offset: 0x00062279
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

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x00064087 File Offset: 0x00062287
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x000640B2 File Offset: 0x000622B2
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000640C0 File Offset: 0x000622C0
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x000640FA File Offset: 0x000622FA
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

		// Token: 0x04001977 RID: 6519
		[Nullable(2)]
		protected IProgressBarControl FbInstance;

		// Token: 0x04001978 RID: 6520
		[Nullable(2)]
		protected IProgressBarControl_SetValue PocoInterface;
	}
}
