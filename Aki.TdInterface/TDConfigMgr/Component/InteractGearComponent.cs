using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000609 RID: 1545
	public class InteractGearComponent : IComponentBase
	{
		// Token: 0x06002064 RID: 8292 RVA: 0x0005B088 File Offset: 0x00059288
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

		// Token: 0x06002065 RID: 8293 RVA: 0x0005B0C0 File Offset: 0x000592C0
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

		// Token: 0x06002066 RID: 8294 RVA: 0x0005B0D3 File Offset: 0x000592D3
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

		// Token: 0x06002067 RID: 8295 RVA: 0x0005B0E6 File Offset: 0x000592E6
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

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x0005B120 File Offset: 0x00059320
		// (set) Token: 0x06002069 RID: 8297 RVA: 0x0005B15A File Offset: 0x0005935A
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

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x0005B168 File Offset: 0x00059368
		// (set) Token: 0x0600206B RID: 8299 RVA: 0x0005B192 File Offset: 0x00059392
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

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0005B1A0 File Offset: 0x000593A0
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x0005B1CF File Offset: 0x000593CF
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

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0005B1DD File Offset: 0x000593DD
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x0005B20C File Offset: 0x0005940C
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

		// Token: 0x0400171A RID: 5914
		[Nullable(2)]
		protected new InteractGearComponent FbInstance;

		// Token: 0x0400171B RID: 5915
		[Nullable(2)]
		protected new InteractGearComponent_SetValue PocoInterface;
	}
}
