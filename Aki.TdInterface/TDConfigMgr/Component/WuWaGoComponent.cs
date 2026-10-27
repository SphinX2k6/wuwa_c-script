using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008EA RID: 2282
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoComponent : IComponentBase
	{
		// Token: 0x060033C9 RID: 13257 RVA: 0x00084808 File Offset: 0x00082A08
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

		// Token: 0x060033CA RID: 13258 RVA: 0x00084840 File Offset: 0x00082A40
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

		// Token: 0x060033CB RID: 13259 RVA: 0x00084853 File Offset: 0x00082A53
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

		// Token: 0x060033CC RID: 13260 RVA: 0x00084866 File Offset: 0x00082A66
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

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000848A0 File Offset: 0x00082AA0
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x000848DA File Offset: 0x00082ADA
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

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x000848E8 File Offset: 0x00082AE8
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x00084912 File Offset: 0x00082B12
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

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x00084920 File Offset: 0x00082B20
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x00084947 File Offset: 0x00082B47
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

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x00084955 File Offset: 0x00082B55
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x0008497C File Offset: 0x00082B7C
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

		// Token: 0x040021E6 RID: 8678
		[Nullable(2)]
		protected new WuWaGoComponent FbInstance;

		// Token: 0x040021E7 RID: 8679
		[Nullable(2)]
		protected new WuWaGoComponent_SetValue PocoInterface;
	}
}
