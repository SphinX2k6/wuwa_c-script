using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002392 RID: 9106
	public class RecordDungeonEvent : ActionParams
	{
		// Token: 0x0600C6BA RID: 50874 RVA: 0x001C7770 File Offset: 0x001C5970
		private RecordDungeonEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RecordDungeonEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RecordDungeonEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RecordDungeonEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600C6BB RID: 50875 RVA: 0x001C77A8 File Offset: 0x001C59A8
		public static RecordDungeonEvent Create([Nullable(2)] RecordDungeonEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RecordDungeonEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C6BC RID: 50876 RVA: 0x001C77BB File Offset: 0x001C59BB
		public static RecordDungeonEvent CreateFromSetValue([Nullable(2)] RecordDungeonEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RecordDungeonEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C6BD RID: 50877 RVA: 0x001C77CE File Offset: 0x001C59CE
		public RecordDungeonEvent_SetValue ToSetValue()
		{
			return new RecordDungeonEvent_SetValue
			{
				EventConfig = this.EventConfig
			};
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0600C6BE RID: 50878 RVA: 0x001C77E4 File Offset: 0x001C59E4
		// (set) Token: 0x0600C6BF RID: 50879 RVA: 0x001C7845 File Offset: 0x001C5A45
		public virtual IRecordTimeStampType EventConfig
		{
			get
			{
				if (this._EventConfigInited)
				{
					return this._EventConfigCache;
				}
				this._EventConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EventConfigCache = IRecordTimeStampType.Create(this.FbInstance.EventConfig);
				}
				else
				{
					RecordDungeonEvent_SetValue pocoInterface = this.PocoInterface;
					this._EventConfigCache = ((pocoInterface != null) ? pocoInterface.EventConfig : null);
				}
				return this._EventConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EventConfig = value;
				this._EventConfigInited = false;
			}
		}

		// Token: 0x0400762C RID: 30252
		[Nullable(2)]
		protected new RecordDungeonEvent FbInstance;

		// Token: 0x0400762D RID: 30253
		[Nullable(2)]
		protected RecordDungeonEvent_SetValue PocoInterface;

		// Token: 0x0400762E RID: 30254
		private IRecordTimeStampType _EventConfigCache;

		// Token: 0x0400762F RID: 30255
		private bool _EventConfigInited;
	}
}
