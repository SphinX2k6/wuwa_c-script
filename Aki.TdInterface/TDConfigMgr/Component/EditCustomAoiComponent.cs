using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000091 RID: 145
	[NullableContext(1)]
	[Nullable(0)]
	public class EditCustomAoiComponent : IComponentBase
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0001B930 File Offset: 0x00019B30
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

		// Token: 0x06000355 RID: 853 RVA: 0x0001B968 File Offset: 0x00019B68
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

		// Token: 0x06000356 RID: 854 RVA: 0x0001B97B File Offset: 0x00019B7B
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

		// Token: 0x06000357 RID: 855 RVA: 0x0001B98E File Offset: 0x00019B8E
		public new EditCustomAoiComponent_SetValue ToSetValue()
		{
			return new EditCustomAoiComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Entities = this.Entities
			};
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0001B9BC File Offset: 0x00019BBC
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0001B9F6 File Offset: 0x00019BF6
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0001BA04 File Offset: 0x00019C04
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0001BA2E File Offset: 0x00019C2E
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001BA3C File Offset: 0x00019C3C
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0001BA63 File Offset: 0x00019C63
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

		// Token: 0x04000398 RID: 920
		[Nullable(2)]
		protected new EditCustomAoiComponent FbInstance;

		// Token: 0x04000399 RID: 921
		[Nullable(2)]
		protected new EditCustomAoiComponent_SetValue PocoInterface;
	}
}
