using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000977 RID: 2423
	public class TurntableControlComponent : IComponentBase
	{
		// Token: 0x06003659 RID: 13913 RVA: 0x0008A5FC File Offset: 0x000887FC
		private TurntableControlComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TurntableControlComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TurntableControlComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TurntableControlComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x0008A634 File Offset: 0x00088834
		public static TurntableControlComponent Create([Nullable(2)] TurntableControlComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TurntableControlComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0008A647 File Offset: 0x00088847
		public static TurntableControlComponent CreateFromSetValue([Nullable(2)] TurntableControlComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TurntableControlComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x0008A65A File Offset: 0x0008885A
		public new TurntableControlComponent_SetValue ToSetValue()
		{
			return new TurntableControlComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x0008A688 File Offset: 0x00088888
		// (set) Token: 0x0600365E RID: 13918 RVA: 0x0008A6C2 File Offset: 0x000888C2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TurntableControlComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x0008A6D0 File Offset: 0x000888D0
		// (set) Token: 0x06003660 RID: 13920 RVA: 0x0008A6FA File Offset: 0x000888FA
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

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x0008A708 File Offset: 0x00088908
		// (set) Token: 0x06003662 RID: 13922 RVA: 0x0008A72F File Offset: 0x0008892F
		public virtual ITurntableControlType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				TurntableControlComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x0400239D RID: 9117
		[Nullable(2)]
		protected new TurntableControlComponent FbInstance;

		// Token: 0x0400239E RID: 9118
		[Nullable(2)]
		protected new TurntableControlComponent_SetValue PocoInterface;
	}
}
