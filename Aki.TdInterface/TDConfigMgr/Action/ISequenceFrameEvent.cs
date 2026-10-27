using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E00 RID: 7680
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceFrameEvent
	{
		// Token: 0x0600A44F RID: 42063 RVA: 0x00174AB4 File Offset: 0x00172CB4
		private ISequenceFrameEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISequenceFrameEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISequenceFrameEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISequenceFrameEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x00174AEC File Offset: 0x00172CEC
		public static ISequenceFrameEvent Create([Nullable(2)] ISequenceFrameEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceFrameEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x00174AFF File Offset: 0x00172CFF
		public static ISequenceFrameEvent CreateFromSetValue([Nullable(2)] ISequenceFrameEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISequenceFrameEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x00174B12 File Offset: 0x00172D12
		public ISequenceFrameEvent_SetValue ToSetValue()
		{
			return new ISequenceFrameEvent_SetValue
			{
				EventKey = this.EventKey,
				EventActions = this.EventActions
			};
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600A453 RID: 42067 RVA: 0x00174B31 File Offset: 0x00172D31
		// (set) Token: 0x0600A454 RID: 42068 RVA: 0x00174B5C File Offset: 0x00172D5C
		public virtual string EventKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EventKey;
			}
			set
			{
				this.GetOrCreatePoco().EventKey = value;
			}
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600A455 RID: 42069 RVA: 0x00174B6C File Offset: 0x00172D6C
		// (set) Token: 0x0600A456 RID: 42070 RVA: 0x00174BFF File Offset: 0x00172DFF
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
					ISequenceFrameEvent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006265 RID: 25189
		[Nullable(2)]
		protected ISequenceFrameEvent FbInstance;

		// Token: 0x04006266 RID: 25190
		[Nullable(2)]
		protected ISequenceFrameEvent_SetValue PocoInterface;

		// Token: 0x04006267 RID: 25191
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x04006268 RID: 25192
		private bool _EventActionsInited;
	}
}
