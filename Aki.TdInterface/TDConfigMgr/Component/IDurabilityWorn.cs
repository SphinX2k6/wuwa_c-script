using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000320 RID: 800
	public class IDurabilityWorn
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x00036298 File Offset: 0x00034498
		private IDurabilityWorn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDurabilityWorn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDurabilityWorn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDurabilityWorn_SetValue());
			}
			return result;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000362D0 File Offset: 0x000344D0
		public static IDurabilityWorn Create([Nullable(2)] IDurabilityWorn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityWorn
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x000362E3 File Offset: 0x000344E3
		public static IDurabilityWorn CreateFromSetValue([Nullable(2)] IDurabilityWorn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDurabilityWorn
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000362F6 File Offset: 0x000344F6
		public IDurabilityWorn_SetValue ToSetValue()
		{
			return new IDurabilityWorn_SetValue
			{
				SlightWear = this.SlightWear,
				SevereWear = this.SevereWear
			};
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00036318 File Offset: 0x00034518
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00036352 File Offset: 0x00034552
		public virtual int? SlightWear
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SlightWear;
				}
				IDurabilityWorn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SlightWear;
			}
			set
			{
				this.GetOrCreatePoco().SlightWear = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00036360 File Offset: 0x00034560
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x0003639A File Offset: 0x0003459A
		public virtual int? SevereWear
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SevereWear;
				}
				IDurabilityWorn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SevereWear;
			}
			set
			{
				this.GetOrCreatePoco().SevereWear = value;
			}
		}

		// Token: 0x04000D60 RID: 3424
		[Nullable(2)]
		protected IDurabilityWorn FbInstance;

		// Token: 0x04000D61 RID: 3425
		[Nullable(2)]
		protected IDurabilityWorn_SetValue PocoInterface;
	}
}
