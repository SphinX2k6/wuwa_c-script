using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A4 RID: 420
	public class GroupAiComponent : IComponentBase
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x00021A8C File Offset: 0x0001FC8C
		private GroupAiComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GroupAiComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GroupAiComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GroupAiComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00021AC4 File Offset: 0x0001FCC4
		public static GroupAiComponent Create([Nullable(2)] GroupAiComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GroupAiComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00021AD7 File Offset: 0x0001FCD7
		public static GroupAiComponent CreateFromSetValue([Nullable(2)] GroupAiComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GroupAiComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00021AEC File Offset: 0x0001FCEC
		public new GroupAiComponent_SetValue ToSetValue()
		{
			return new GroupAiComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Entities = this.Entities,
				Option = this.Option,
				SyncTags = this.SyncTags
			};
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00021B3C File Offset: 0x0001FD3C
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00021B76 File Offset: 0x0001FD76
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00021B84 File Offset: 0x0001FD84
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00021BAE File Offset: 0x0001FDAE
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00021BBC File Offset: 0x0001FDBC
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00021BE3 File Offset: 0x0001FDE3
		public virtual List<int> Entities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entities;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entities;
			}
			set
			{
				this.GetOrCreatePoco().Entities = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00021BF1 File Offset: 0x0001FDF1
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00021C18 File Offset: 0x0001FE18
		public virtual IGroupAiMode Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00021C26 File Offset: 0x0001FE26
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00021C4D File Offset: 0x0001FE4D
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> SyncTags
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SyncTags;
				}
				GroupAiComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SyncTags;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().SyncTags = value;
			}
		}

		// Token: 0x040007DE RID: 2014
		[Nullable(2)]
		protected new GroupAiComponent FbInstance;

		// Token: 0x040007DF RID: 2015
		[Nullable(2)]
		protected new GroupAiComponent_SetValue PocoInterface;
	}
}
