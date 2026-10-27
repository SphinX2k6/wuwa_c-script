using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A9 RID: 2217
	[NullableContext(1)]
	[Nullable(0)]
	public class StreamingSourceTriggerPointComponent : IComponentBase
	{
		// Token: 0x060031A9 RID: 12713 RVA: 0x0007F7D0 File Offset: 0x0007D9D0
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

		// Token: 0x060031AA RID: 12714 RVA: 0x0007F808 File Offset: 0x0007DA08
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

		// Token: 0x060031AB RID: 12715 RVA: 0x0007F81B File Offset: 0x0007DA1B
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

		// Token: 0x060031AC RID: 12716 RVA: 0x0007F82E File Offset: 0x0007DA2E
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

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x0007F868 File Offset: 0x0007DA68
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x0007F8A2 File Offset: 0x0007DAA2
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

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x0007F8B0 File Offset: 0x0007DAB0
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x0007F8DA File Offset: 0x0007DADA
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

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x0007F922 File Offset: 0x0007DB22
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

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x0007F930 File Offset: 0x0007DB30
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x0007F957 File Offset: 0x0007DB57
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

		// Token: 0x04002098 RID: 8344
		[Nullable(2)]
		protected new StreamingSourceTriggerPointComponent FbInstance;

		// Token: 0x04002099 RID: 8345
		[Nullable(2)]
		protected new StreamingSourceTriggerPointComponent_SetValue PocoInterface;
	}
}
