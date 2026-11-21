using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094C RID: 2380
	public class StreamingSourceTriggerPointComponent : IComponentBase
	{
		// Token: 0x060034E5 RID: 13541 RVA: 0x00086CB8 File Offset: 0x00084EB8
		private StreamingSourceTriggerPointComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StreamingSourceTriggerPointComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StreamingSourceTriggerPointComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StreamingSourceTriggerPointComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00086CF0 File Offset: 0x00084EF0
		public static StreamingSourceTriggerPointComponent Create([Nullable(2)] StreamingSourceTriggerPointComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StreamingSourceTriggerPointComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x00086D03 File Offset: 0x00084F03
		public static StreamingSourceTriggerPointComponent CreateFromSetValue([Nullable(2)] StreamingSourceTriggerPointComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StreamingSourceTriggerPointComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00086D16 File Offset: 0x00084F16
		public new StreamingSourceTriggerPointComponent_SetValue ToSetValue()
		{
			return new StreamingSourceTriggerPointComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Radius = this.Radius,
				StreamingSource = this.StreamingSource
			};
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x00086D50 File Offset: 0x00084F50
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x00086D8A File Offset: 0x00084F8A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				StreamingSourceTriggerPointComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x00086D98 File Offset: 0x00084F98
		// (set) Token: 0x060034EC RID: 13548 RVA: 0x00086DC2 File Offset: 0x00084FC2
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060034ED RID: 13549 RVA: 0x00086DD0 File Offset: 0x00084FD0
		// (set) Token: 0x060034EE RID: 13550 RVA: 0x00086E0A File Offset: 0x0008500A
		public virtual int? Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				StreamingSourceTriggerPointComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x00086E18 File Offset: 0x00085018
		// (set) Token: 0x060034F0 RID: 13552 RVA: 0x00086E3F File Offset: 0x0008503F
		public virtual IStreamingSourceConfigBase StreamingSource
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StreamingSource;
				}
				StreamingSourceTriggerPointComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StreamingSource;
			}
			set
			{
				this.GetOrCreatePoco().StreamingSource = value;
			}
		}

		// Token: 0x040022AA RID: 8874
		[Nullable(2)]
		protected new StreamingSourceTriggerPointComponent FbInstance;

		// Token: 0x040022AB RID: 8875
		[Nullable(2)]
		protected new StreamingSourceTriggerPointComponent_SetValue PocoInterface;
	}
}
