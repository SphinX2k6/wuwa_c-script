using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000015 RID: 21
	[NullableContext(1)]
	[Nullable(0)]
	public class AdviseItemComponent : IComponentBase
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000145B8 File Offset: 0x000127B8
		private AdviseItemComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AdviseItemComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AdviseItemComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AdviseItemComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000145F0 File Offset: 0x000127F0
		public static AdviseItemComponent Create([Nullable(2)] AdviseItemComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdviseItemComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00014603 File Offset: 0x00012803
		public static AdviseItemComponent CreateFromSetValue([Nullable(2)] AdviseItemComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AdviseItemComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00014616 File Offset: 0x00012816
		public new AdviseItemComponent_SetValue ToSetValue()
		{
			return new AdviseItemComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00014638 File Offset: 0x00012838
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00014672 File Offset: 0x00012872
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AdviseItemComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00014680 File Offset: 0x00012880
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000146AA File Offset: 0x000128AA
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

		// Token: 0x0400003E RID: 62
		[Nullable(2)]
		protected new AdviseItemComponent FbInstance;

		// Token: 0x0400003F RID: 63
		[Nullable(2)]
		protected new AdviseItemComponent_SetValue PocoInterface;
	}
}
