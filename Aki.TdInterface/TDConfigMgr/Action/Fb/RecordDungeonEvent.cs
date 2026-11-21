using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF1 RID: 11505
	public class RecordDungeonEvent : ActionParams
	{
		// Token: 0x0600FBEF RID: 64495 RVA: 0x00247544 File Offset: 0x00245744
		public static RecordDungeonEvent Create(IRecordDungeonEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RecordDungeonEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x0600FBF0 RID: 64496 RVA: 0x00247563 File Offset: 0x00245763
		public virtual IRecordTimeStampType EventConfig
		{
			get
			{
				if (this._EventConfigInited)
				{
					return this._EventConfigCache;
				}
				this._EventConfigInited = true;
				this._EventConfigCache = IRecordTimeStampType.Create(this.Instance.EventConfig);
				return this._EventConfigCache;
			}
		}

		// Token: 0x04008997 RID: 35223
		private IRecordDungeonEvent Instance;

		// Token: 0x04008998 RID: 35224
		[Nullable(2)]
		private IRecordTimeStampType _EventConfigCache;

		// Token: 0x04008999 RID: 35225
		private bool _EventConfigInited;
	}
}
