using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B14 RID: 11028
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvTeleportTransitionData
	{
		// Token: 0x0600F165 RID: 61797 RVA: 0x00230118 File Offset: 0x0022E318
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

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x0600F166 RID: 61798 RVA: 0x00230137 File Offset: 0x0022E337
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x0600F167 RID: 61799 RVA: 0x00230144 File Offset: 0x0022E344
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

		// Token: 0x040084C6 RID: 33990
		private TCsvTeleportTransitionData Instance;

		// Token: 0x040084C7 RID: 33991
		private ITeleportTransitionType _DataCache;

		// Token: 0x040084C8 RID: 33992
		private bool _DataInited;
	}
}
