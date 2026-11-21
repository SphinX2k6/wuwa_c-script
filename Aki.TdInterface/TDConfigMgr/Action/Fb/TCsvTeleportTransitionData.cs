using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E32 RID: 11826
	public class TCsvTeleportTransitionData
	{
		// Token: 0x060100B9 RID: 65721 RVA: 0x0024EBB0 File Offset: 0x0024CDB0
		public static TCsvTeleportTransitionData Create(TCsvTeleportTransitionData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvTeleportTransitionData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x060100BA RID: 65722 RVA: 0x0024EBCF File Offset: 0x0024CDCF
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17005104 RID: 20740
		// (get) Token: 0x060100BB RID: 65723 RVA: 0x0024EBDC File Offset: 0x0024CDDC
		public virtual ITeleportTransitionType Data
		{
			get
			{
				if (this._DataInited)
				{
					return this._DataCache;
				}
				this._DataInited = true;
				this._DataCache = ActionReadHelper.ReadTCsvTeleportTransitionData_Data(this.Instance);
				return this._DataCache;
			}
		}

		// Token: 0x04008C0E RID: 35854
		private TCsvTeleportTransitionData Instance;

		// Token: 0x04008C0F RID: 35855
		private ITeleportTransitionType _DataCache;

		// Token: 0x04008C10 RID: 35856
		private bool _DataInited;
	}
}
