using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F9 RID: 1785
	public class IRangeByTag
	{
		// Token: 0x060025DE RID: 9694 RVA: 0x000667DC File Offset: 0x000649DC
		private IRangeByTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRangeByTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRangeByTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRangeByTag_SetValue());
			}
			return result;
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00066814 File Offset: 0x00064A14
		public static IRangeByTag Create([Nullable(2)] IRangeByTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeByTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00066827 File Offset: 0x00064A27
		public static IRangeByTag CreateFromSetValue([Nullable(2)] IRangeByTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRangeByTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x0006683A File Offset: 0x00064A3A
		public IRangeByTag_SetValue ToSetValue()
		{
			return new IRangeByTag_SetValue
			{
				Tag = this.Tag,
				Range = this.Range,
				ExitRange = this.ExitRange
			};
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x00066865 File Offset: 0x00064A65
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00066890 File Offset: 0x00064A90
		public virtual int Tag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Tag;
			}
			set
			{
				this.GetOrCreatePoco().Tag = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x0006689E File Offset: 0x00064A9E
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x000668CD File Offset: 0x00064ACD
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000668DC File Offset: 0x00064ADC
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x00066916 File Offset: 0x00064B16
		public virtual float? ExitRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitRange;
				}
				IRangeByTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitRange;
			}
			set
			{
				this.GetOrCreatePoco().ExitRange = value;
			}
		}

		// Token: 0x04001A25 RID: 6693
		[Nullable(2)]
		protected IRangeByTag FbInstance;

		// Token: 0x04001A26 RID: 6694
		[Nullable(2)]
		protected IRangeByTag_SetValue PocoInterface;
	}
}
