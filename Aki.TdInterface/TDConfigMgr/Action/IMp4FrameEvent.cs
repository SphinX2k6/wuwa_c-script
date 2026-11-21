using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E3F RID: 7743
	public class IMp4FrameEvent
	{
		// Token: 0x0600A4A9 RID: 42153 RVA: 0x00177FB4 File Offset: 0x001761B4
		private IMp4FrameEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMp4FrameEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMp4FrameEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMp4FrameEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4AA RID: 42154 RVA: 0x00177FEC File Offset: 0x001761EC
		public static IMp4FrameEvent Create([Nullable(2)] IMp4FrameEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4FrameEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x00177FFF File Offset: 0x001761FF
		public static IMp4FrameEvent CreateFromSetValue([Nullable(2)] IMp4FrameEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMp4FrameEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x00178012 File Offset: 0x00176212
		public IMp4FrameEvent_SetValue ToSetValue()
		{
			return new IMp4FrameEvent_SetValue
			{
				Second = this.Second,
				EventActions = this.EventActions
			};
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600A4AD RID: 42157 RVA: 0x00178031 File Offset: 0x00176231
		// (set) Token: 0x0600A4AE RID: 42158 RVA: 0x00178060 File Offset: 0x00176260
		public virtual float Second
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Second;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Second;
			}
			set
			{
				this.GetOrCreatePoco().Second = value;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600A4AF RID: 42159 RVA: 0x00178070 File Offset: 0x00176270
		// (set) Token: 0x0600A4B0 RID: 42160 RVA: 0x00178103 File Offset: 0x00176303
		public virtual List<ActionInfo> EventActions
		{
			get
			{
				if (this._EventActionsInited)
				{
					return this._EventActionsCache;
				}
				this._EventActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> eventActions = this.FbInstance.EventActions;
					if (eventActions != null)
					{
						this._EventActionsCache = new List<ActionInfo>(eventActions.Count);
						for (int i = 0; i < eventActions.Count; i++)
						{
							this._EventActionsCache.Add(ActionInfo.Create(eventActions[i]));
						}
					}
				}
				else
				{
					IMp4FrameEvent_SetValue pocoInterface = this.PocoInterface;
					this._EventActionsCache = ((pocoInterface != null) ? pocoInterface.EventActions : null);
				}
				return this._EventActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().EventActions = value;
				this._EventActionsInited = false;
			}
		}

		// Token: 0x0400638F RID: 25487
		[Nullable(2)]
		protected IMp4FrameEvent FbInstance;

		// Token: 0x04006390 RID: 25488
		[Nullable(2)]
		protected IMp4FrameEvent_SetValue PocoInterface;

		// Token: 0x04006391 RID: 25489
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x04006392 RID: 25490
		private bool _EventActionsInited;
	}
}
