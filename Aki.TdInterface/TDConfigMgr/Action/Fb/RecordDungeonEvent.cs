using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A04 RID: 10756
	[NullableContext(1)]
	[Nullable(0)]
	public class RecordDungeonEvent : ActionParams
	{
		// Token: 0x0600ED58 RID: 60760 RVA: 0x00229BC0 File Offset: 0x00227DC0
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

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x0600ED59 RID: 60761 RVA: 0x00229BDF File Offset: 0x00227DDF
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

		// Token: 0x040082A6 RID: 33446
		private IRecordDungeonEvent Instance;

		// Token: 0x040082A7 RID: 33447
		[Nullable(2)]
		private IRecordTimeStampType _EventConfigCache;

		// Token: 0x040082A8 RID: 33448
		private bool _EventConfigInited;
	}
}
