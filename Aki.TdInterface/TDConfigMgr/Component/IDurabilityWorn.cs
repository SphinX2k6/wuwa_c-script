using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D9 RID: 729
	[NullableContext(1)]
	[Nullable(0)]
	public class IDurabilityWorn
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x00033364 File Offset: 0x00031564
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

		// Token: 0x06000DEC RID: 3564 RVA: 0x0003339C File Offset: 0x0003159C
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

		// Token: 0x06000DED RID: 3565 RVA: 0x000333AF File Offset: 0x000315AF
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

		// Token: 0x06000DEE RID: 3566 RVA: 0x000333C2 File Offset: 0x000315C2
		public IDurabilityWorn_SetValue ToSetValue()
		{
			return new IDurabilityWorn_SetValue
			{
				SlightWear = this.SlightWear,
				SevereWear = this.SevereWear
			};
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x000333E4 File Offset: 0x000315E4
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x0003341E File Offset: 0x0003161E
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x0003342C File Offset: 0x0003162C
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00033466 File Offset: 0x00031666
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

		// Token: 0x04000C76 RID: 3190
		[Nullable(2)]
		protected IDurabilityWorn FbInstance;

		// Token: 0x04000C77 RID: 3191
		[Nullable(2)]
		protected IDurabilityWorn_SetValue PocoInterface;
	}
}
