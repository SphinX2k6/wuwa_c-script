using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C3 RID: 6339
	public class HideGroup : ActionParams
	{
		// Token: 0x060084F3 RID: 34035 RVA: 0x0013D1C8 File Offset: 0x0013B3C8
		private HideGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HideGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HideGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HideGroup_SetValue());
			}
			return result;
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x0013D200 File Offset: 0x0013B400
		public static HideGroup Create([Nullable(2)] HideGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x0013D213 File Offset: 0x0013B413
		public static HideGroup CreateFromSetValue([Nullable(2)] HideGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HideGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x0013D226 File Offset: 0x0013B426
		public HideGroup_SetValue ToSetValue()
		{
			return new HideGroup_SetValue
			{
				GroupKey = this.GroupKey,
				HideConfig = this.HideConfig,
				IsHidePasserByNpc = this.IsHidePasserByNpc
			};
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x060084F7 RID: 34039 RVA: 0x0013D251 File Offset: 0x0013B451
		// (set) Token: 0x060084F8 RID: 34040 RVA: 0x0013D27C File Offset: 0x0013B47C
		public virtual string GroupKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.GroupKey;
			}
			set
			{
				this.GetOrCreatePoco().GroupKey = value;
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x060084F9 RID: 34041 RVA: 0x0013D28A File Offset: 0x0013B48A
		// (set) Token: 0x060084FA RID: 34042 RVA: 0x0013D2B1 File Offset: 0x0013B4B1
		public virtual IHideGroupType HideConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideConfig;
				}
				HideGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideConfig;
			}
			set
			{
				this.GetOrCreatePoco().HideConfig = value;
			}
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x0013D2C0 File Offset: 0x0013B4C0
		// (set) Token: 0x060084FC RID: 34044 RVA: 0x0013D2FA File Offset: 0x0013B4FA
		public virtual bool? IsHidePasserByNpc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsHidePasserByNpc;
				}
				HideGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsHidePasserByNpc;
			}
			set
			{
				this.GetOrCreatePoco().IsHidePasserByNpc = value;
			}
		}

		// Token: 0x04005489 RID: 21641
		[Nullable(2)]
		protected new HideGroup FbInstance;

		// Token: 0x0400548A RID: 21642
		[Nullable(2)]
		protected HideGroup_SetValue PocoInterface;
	}
}
