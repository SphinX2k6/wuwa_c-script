using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C32 RID: 3122
	public class ItemFoundation2 : IComponentBase
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x000B53F2 File Offset: 0x000B35F2
		public static ItemFoundation2 Create(IItemFoundation2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ItemFoundation2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x000B5414 File Offset: 0x000B3614
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x000B544C File Offset: 0x000B364C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x000B5462 File Offset: 0x000B3662
		public virtual IItemFoundationType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ComponentReadHelper.ReadItemFoundation2_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x04002833 RID: 10291
		private IItemFoundation2 Instance;

		// Token: 0x04002834 RID: 10292
		private IItemFoundationType _ConfigCache;

		// Token: 0x04002835 RID: 10293
		private bool _ConfigInited;
	}
}
