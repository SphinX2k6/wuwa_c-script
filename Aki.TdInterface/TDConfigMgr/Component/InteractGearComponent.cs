using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A0 RID: 1440
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractGearComponent : IComponentBase
	{
		// Token: 0x06001E5E RID: 7774 RVA: 0x000561CC File Offset: 0x000543CC
		private InteractGearComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("InteractGearComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			InteractGearComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new InteractGearComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00056204 File Offset: 0x00054404
		public static InteractGearComponent Create([Nullable(2)] InteractGearComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InteractGearComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00056217 File Offset: 0x00054417
		public static InteractGearComponent CreateFromSetValue([Nullable(2)] InteractGearComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new InteractGearComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0005622A File Offset: 0x0005442A
		public new InteractGearComponent_SetValue ToSetValue()
		{
			return new InteractGearComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				NormalPrepareTime = this.NormalPrepareTime,
				ActivePrepareTime = this.ActivePrepareTime
			};
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x00056264 File Offset: 0x00054464
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0005629E File Offset: 0x0005449E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				InteractGearComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000562AC File Offset: 0x000544AC
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x000562D6 File Offset: 0x000544D6
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

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000562E4 File Offset: 0x000544E4
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x00056313 File Offset: 0x00054513
		public virtual float NormalPrepareTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NormalPrepareTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.NormalPrepareTime;
			}
			set
			{
				this.GetOrCreatePoco().NormalPrepareTime = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00056321 File Offset: 0x00054521
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x00056350 File Offset: 0x00054550
		public virtual float ActivePrepareTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActivePrepareTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ActivePrepareTime;
			}
			set
			{
				this.GetOrCreatePoco().ActivePrepareTime = value;
			}
		}

		// Token: 0x040015AC RID: 5548
		[Nullable(2)]
		protected new InteractGearComponent FbInstance;

		// Token: 0x040015AD RID: 5549
		[Nullable(2)]
		protected new InteractGearComponent_SetValue PocoInterface;
	}
}
