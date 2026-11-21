using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200025A RID: 602
	public class IChargeSlashControl : ICurveControlConfig
	{
		// Token: 0x06000A54 RID: 2644 RVA: 0x0002B9CC File Offset: 0x00029BCC
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

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002BA04 File Offset: 0x00029C04
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

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002BA17 File Offset: 0x00029C17
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

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002BA2A File Offset: 0x00029C2A
		public new IChargeSlashControl_SetValue ToSetValue()
		{
			return new IChargeSlashControl_SetValue
			{
				Type = this.Type,
				UpHeight = this.UpHeight,
				UpCurvePath = this.UpCurvePath
			};
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002BA55 File Offset: 0x00029C55
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x0002BA80 File Offset: 0x00029C80
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002BA8E File Offset: 0x00029C8E
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x0002BAB9 File Offset: 0x00029CB9
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0002BAC7 File Offset: 0x00029CC7
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0002BAEE File Offset: 0x00029CEE
		[Nullable(2)]
		public virtual string UpCurvePath
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UpCurvePath = value;
			}
		}

		// Token: 0x04000A9B RID: 2715
		[Nullable(2)]
		protected new IChargeSlashControl FbInstance;

		// Token: 0x04000A9C RID: 2716
		[Nullable(2)]
		protected new IChargeSlashControl_SetValue PocoInterface;
	}
}
