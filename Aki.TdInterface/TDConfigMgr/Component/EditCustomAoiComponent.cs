using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000096 RID: 150
	public class EditCustomAoiComponent : IComponentBase
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		private EditCustomAoiComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EditCustomAoiComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EditCustomAoiComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EditCustomAoiComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001C2DC File Offset: 0x0001A4DC
		public static EditCustomAoiComponent Create([Nullable(2)] EditCustomAoiComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EditCustomAoiComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0001C2EF File Offset: 0x0001A4EF
		public static EditCustomAoiComponent CreateFromSetValue([Nullable(2)] EditCustomAoiComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EditCustomAoiComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0001C302 File Offset: 0x0001A502
		public new EditCustomAoiComponent_SetValue ToSetValue()
		{
			return new EditCustomAoiComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Entities = this.Entities
			};
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001C330 File Offset: 0x0001A530
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0001C36A File Offset: 0x0001A56A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EditCustomAoiComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001C378 File Offset: 0x0001A578
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0001C3A2 File Offset: 0x0001A5A2
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0001C3D7 File Offset: 0x0001A5D7
		public virtual List<int> Entities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entities;
				}
				EditCustomAoiComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040003B1 RID: 945
		[Nullable(2)]
		protected new EditCustomAoiComponent FbInstance;

		// Token: 0x040003B2 RID: 946
		[Nullable(2)]
		protected new EditCustomAoiComponent_SetValue PocoInterface;
	}
}
