using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000036 RID: 54
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffProducerComponent : IComponentBase
	{
		// Token: 0x060001EC RID: 492 RVA: 0x000184E0 File Offset: 0x000166E0
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

		// Token: 0x060001ED RID: 493 RVA: 0x00018518 File Offset: 0x00016718
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

		// Token: 0x060001EE RID: 494 RVA: 0x0001852B File Offset: 0x0001672B
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

		// Token: 0x060001EF RID: 495 RVA: 0x0001853E File Offset: 0x0001673E
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00018578 File Offset: 0x00016778
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000185B2 File Offset: 0x000167B2
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000185C0 File Offset: 0x000167C0
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x000185EA File Offset: 0x000167EA
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000185F8 File Offset: 0x000167F8
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0001861F File Offset: 0x0001681F
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0001862D File Offset: 0x0001682D
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00018659 File Offset: 0x00016859
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

		// Token: 0x0400013C RID: 316
		[Nullable(2)]
		protected new BuffProducerComponent FbInstance;

		// Token: 0x0400013D RID: 317
		[Nullable(2)]
		protected new BuffProducerComponent_SetValue PocoInterface;
	}
}
