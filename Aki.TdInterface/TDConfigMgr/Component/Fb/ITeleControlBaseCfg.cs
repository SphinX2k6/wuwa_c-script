using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C02 RID: 3074
	public class ITeleControlBaseCfg
	{
		// Token: 0x06004690 RID: 18064 RVA: 0x000B3A4D File Offset: 0x000B1C4D
		public static ITeleControlBaseCfg Create(ITeleControlBaseCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlBaseCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06004691 RID: 18065 RVA: 0x000B3A6C File Offset: 0x000B1C6C
		public virtual string CommonConfig
		{
			get
			{
				return this.Instance.CommonConfig;
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x000B3A7C File Offset: 0x000B1C7C
		public virtual bool? CanRotate
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanRotate);
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x000B3AB4 File Offset: 0x000B1CB4
		public virtual bool? InitialGravity
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.InitialGravity);
			}
		}

		// Token: 0x0400279F RID: 10143
		private ITeleControlBaseCfg Instance;
	}
}
