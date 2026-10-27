using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002131 RID: 8497
	[NullableContext(1)]
	[Nullable(0)]
	public class RecordDungeonEvent : ActionParams
	{
		// Token: 0x0600BB2C RID: 47916 RVA: 0x001B05BC File Offset: 0x001AE7BC
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

		// Token: 0x0600BB2D RID: 47917 RVA: 0x001B05F4 File Offset: 0x001AE7F4
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

		// Token: 0x0600BB2E RID: 47918 RVA: 0x001B0607 File Offset: 0x001AE807
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

		// Token: 0x0600BB2F RID: 47919 RVA: 0x001B061A File Offset: 0x001AE81A
		public RecordDungeonEvent_SetValue ToSetValue()
		{
			return new RecordDungeonEvent_SetValue
			{
				EventConfig = this.EventConfig
			};
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x001B0630 File Offset: 0x001AE830
		// (set) Token: 0x0600BB31 RID: 47921 RVA: 0x001B0691 File Offset: 0x001AE891
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

		// Token: 0x04006FF7 RID: 28663
		[Nullable(2)]
		protected new RecordDungeonEvent FbInstance;

		// Token: 0x04006FF8 RID: 28664
		[Nullable(2)]
		protected RecordDungeonEvent_SetValue PocoInterface;

		// Token: 0x04006FF9 RID: 28665
		private IRecordTimeStampType _EventConfigCache;

		// Token: 0x04006FFA RID: 28666
		private bool _EventConfigInited;
	}
}
