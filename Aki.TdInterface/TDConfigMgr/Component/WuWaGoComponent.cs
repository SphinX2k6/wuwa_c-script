using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098F RID: 2447
	public class WuWaGoComponent : IComponentBase
	{
		// Token: 0x06003711 RID: 14097 RVA: 0x0008BE44 File Offset: 0x0008A044
		private WuWaGoComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("WuWaGoComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			WuWaGoComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new WuWaGoComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x0008BE7C File Offset: 0x0008A07C
		public static WuWaGoComponent Create([Nullable(2)] WuWaGoComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WuWaGoComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x0008BE8F File Offset: 0x0008A08F
		public static WuWaGoComponent CreateFromSetValue([Nullable(2)] WuWaGoComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new WuWaGoComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x0008BEA2 File Offset: 0x0008A0A2
		public new WuWaGoComponent_SetValue ToSetValue()
		{
			return new WuWaGoComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WuWaGoEntity = this.WuWaGoEntity,
				OpenAddClientTags = this.OpenAddClientTags
			};
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x0008BEDC File Offset: 0x0008A0DC
		// (set) Token: 0x06003716 RID: 14102 RVA: 0x0008BF16 File Offset: 0x0008A116
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				WuWaGoComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06003717 RID: 14103 RVA: 0x0008BF24 File Offset: 0x0008A124
		// (set) Token: 0x06003718 RID: 14104 RVA: 0x0008BF4E File Offset: 0x0008A14E
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

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x0008BF5C File Offset: 0x0008A15C
		// (set) Token: 0x0600371A RID: 14106 RVA: 0x0008BF83 File Offset: 0x0008A183
		public virtual IWuWaGoEntityBase WuWaGoEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WuWaGoEntity;
				}
				WuWaGoComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WuWaGoEntity;
			}
			set
			{
				this.GetOrCreatePoco().WuWaGoEntity = value;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x0008BF91 File Offset: 0x0008A191
		// (set) Token: 0x0600371C RID: 14108 RVA: 0x0008BFB8 File Offset: 0x0008A1B8
		[Nullable(2)]
		public virtual List<int> OpenAddClientTags
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OpenAddClientTags;
				}
				WuWaGoComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OpenAddClientTags;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OpenAddClientTags = value;
			}
		}

		// Token: 0x040023FD RID: 9213
		[Nullable(2)]
		protected new WuWaGoComponent FbInstance;

		// Token: 0x040023FE RID: 9214
		[Nullable(2)]
		protected new WuWaGoComponent_SetValue PocoInterface;
	}
}
