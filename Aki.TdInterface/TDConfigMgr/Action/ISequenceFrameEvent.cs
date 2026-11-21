using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002033 RID: 8243
	public class ISequenceFrameEvent
	{
		// Token: 0x0600AEF7 RID: 44791 RVA: 0x0018A4BC File Offset: 0x001886BC
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

		// Token: 0x0600AEF8 RID: 44792 RVA: 0x0018A4F4 File Offset: 0x001886F4
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

		// Token: 0x0600AEF9 RID: 44793 RVA: 0x0018A507 File Offset: 0x00188707
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

		// Token: 0x0600AEFA RID: 44794 RVA: 0x0018A51A File Offset: 0x0018871A
		public ISequenceFrameEvent_SetValue ToSetValue()
		{
			return new ISequenceFrameEvent_SetValue
			{
				EventKey = this.EventKey,
				EventActions = this.EventActions
			};
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600AEFB RID: 44795 RVA: 0x0018A539 File Offset: 0x00188739
		// (set) Token: 0x0600AEFC RID: 44796 RVA: 0x0018A564 File Offset: 0x00188764
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

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600AEFD RID: 44797 RVA: 0x0018A574 File Offset: 0x00188774
		// (set) Token: 0x0600AEFE RID: 44798 RVA: 0x0018A607 File Offset: 0x00188807
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

		// Token: 0x0400683C RID: 26684
		[Nullable(2)]
		protected ISequenceFrameEvent FbInstance;

		// Token: 0x0400683D RID: 26685
		[Nullable(2)]
		protected ISequenceFrameEvent_SetValue PocoInterface;

		// Token: 0x0400683E RID: 26686
		private List<ActionInfo> _EventActionsCache;

		// Token: 0x0400683F RID: 26687
		private bool _EventActionsInited;
	}
}
