using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000167 RID: 359
	[NullableContext(1)]
	[Nullable(0)]
	public class ExhibitComponent : IComponentBase
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0001E2AC File Offset: 0x0001C4AC
		private ExhibitComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExhibitComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExhibitComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExhibitComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		public static ExhibitComponent Create([Nullable(2)] ExhibitComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExhibitComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001E2F7 File Offset: 0x0001C4F7
		public static ExhibitComponent CreateFromSetValue([Nullable(2)] ExhibitComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExhibitComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001E30A File Offset: 0x0001C50A
		public new ExhibitComponent_SetValue ToSetValue()
		{
			return new ExhibitComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ExhibitConfig = this.ExhibitConfig
			};
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0001E338 File Offset: 0x0001C538
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0001E372 File Offset: 0x0001C572
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ExhibitComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0001E380 File Offset: 0x0001C580
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0001E3AA File Offset: 0x0001C5AA
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0001E3DF File Offset: 0x0001C5DF
		public virtual IExhibitItemType ExhibitConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExhibitConfig;
				}
				ExhibitComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExhibitConfig;
			}
			set
			{
				this.GetOrCreatePoco().ExhibitConfig = value;
			}
		}

		// Token: 0x040006D0 RID: 1744
		[Nullable(2)]
		protected new ExhibitComponent FbInstance;

		// Token: 0x040006D1 RID: 1745
		[Nullable(2)]
		protected new ExhibitComponent_SetValue PocoInterface;
	}
}
