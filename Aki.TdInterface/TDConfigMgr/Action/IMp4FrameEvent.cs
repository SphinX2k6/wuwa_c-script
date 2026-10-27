using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C48 RID: 7240
	[NullableContext(1)]
	[Nullable(0)]
	public class IMp4FrameEvent
	{
		// Token: 0x06009B51 RID: 39761 RVA: 0x00164C74 File Offset: 0x00162E74
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

		// Token: 0x06009B52 RID: 39762 RVA: 0x00164CAC File Offset: 0x00162EAC
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

		// Token: 0x06009B53 RID: 39763 RVA: 0x00164CBF File Offset: 0x00162EBF
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

		// Token: 0x06009B54 RID: 39764 RVA: 0x00164CD2 File Offset: 0x00162ED2
		public IMp4FrameEvent_SetValue ToSetValue()
		{
			return new IMp4FrameEvent_SetValue
			{
				Second = this.Second,
				EventActions = this.EventActions
			};
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x06009B55 RID: 39765 RVA: 0x00164CF1 File Offset: 0x00162EF1
		// (set) Token: 0x06009B56 RID: 39766 RVA: 0x00164D20 File Offset: 0x00162F20
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

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x06009B57 RID: 39767 RVA: 0x00164D30 File Offset: 0x00162F30
		// (set) Token: 0x06009B58 RID: 39768 RVA: 0x00164DC3 File Offset: 0x00162FC3
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

		// Token: 0x04005E58 RID: 24152
		[Nullable(2)]
		protected IMp4FrameEvent FbInstance;

		// Token: 0x04005E59 RID: 24153
		[Nullable(2)]
		protected IMp4FrameEvent_SetValue PocoInterface;

		// Token: 0x04005E5A RID: 24154
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x04005E5B RID: 24155
		private bool _EventActionsInited;
	}
}
