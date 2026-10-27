using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A2 RID: 1442
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractiveComponent : IComponentBase
	{
		// Token: 0x06001E6C RID: 7788 RVA: 0x00056370 File Offset: 0x00054570
		private InteractiveComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("InteractiveComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			InteractiveComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new InteractiveComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000563A8 File Offset: 0x000545A8
		public static InteractiveComponent Create([Nullable(2)] InteractiveComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InteractiveComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000563BB File Offset: 0x000545BB
		public static InteractiveComponent CreateFromSetValue([Nullable(2)] InteractiveComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new InteractiveComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000563CE File Offset: 0x000545CE
		public new InteractiveComponent_SetValue ToSetValue()
		{
			return new InteractiveComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Content = this.Content,
				Icon = this.Icon
			};
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x00056408 File Offset: 0x00054608
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00056442 File Offset: 0x00054642
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				InteractiveComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00056450 File Offset: 0x00054650
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0005647A File Offset: 0x0005467A
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

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00056488 File Offset: 0x00054688
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x000564B3 File Offset: 0x000546B3
		public virtual string Content
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Content;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Content;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x000564C1 File Offset: 0x000546C1
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x000564EC File Offset: 0x000546EC
		public virtual string Icon
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Icon;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Icon;
			}
			set
			{
				this.GetOrCreatePoco().Icon = value;
			}
		}

		// Token: 0x040015B2 RID: 5554
		[Nullable(2)]
		protected new InteractiveComponent FbInstance;

		// Token: 0x040015B3 RID: 5555
		[Nullable(2)]
		protected new InteractiveComponent_SetValue PocoInterface;
	}
}
