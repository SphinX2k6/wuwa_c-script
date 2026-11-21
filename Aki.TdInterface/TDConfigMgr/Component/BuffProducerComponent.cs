using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000036 RID: 54
	public class BuffProducerComponent : IComponentBase
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x00018E54 File Offset: 0x00017054
		private BuffProducerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BuffProducerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BuffProducerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BuffProducerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00018E8C File Offset: 0x0001708C
		public static BuffProducerComponent Create([Nullable(2)] BuffProducerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BuffProducerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00018E9F File Offset: 0x0001709F
		public static BuffProducerComponent CreateFromSetValue([Nullable(2)] BuffProducerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BuffProducerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00018EB2 File Offset: 0x000170B2
		public new BuffProducerComponent_SetValue ToSetValue()
		{
			return new BuffProducerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AddBuffMode = this.AddBuffMode,
				BuffId = this.BuffId
			};
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00018EEC File Offset: 0x000170EC
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00018F26 File Offset: 0x00017126
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				BuffProducerComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00018F34 File Offset: 0x00017134
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00018F5E File Offset: 0x0001715E
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00018F6C File Offset: 0x0001716C
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00018F93 File Offset: 0x00017193
		public virtual IAddBuffMode AddBuffMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AddBuffMode;
				}
				BuffProducerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AddBuffMode;
			}
			set
			{
				this.GetOrCreatePoco().AddBuffMode = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00018FA1 File Offset: 0x000171A1
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00018FCD File Offset: 0x000171CD
		public virtual long BuffId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BuffId;
			}
			set
			{
				this.GetOrCreatePoco().BuffId = value;
			}
		}

		// Token: 0x04000141 RID: 321
		[Nullable(2)]
		protected new BuffProducerComponent FbInstance;

		// Token: 0x04000142 RID: 322
		[Nullable(2)]
		protected new BuffProducerComponent_SetValue PocoInterface;
	}
}
