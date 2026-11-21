using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002860 RID: 10336
	public class IShowTalkFrameEvent
	{
		// Token: 0x0600E687 RID: 59015 RVA: 0x00221ED1 File Offset: 0x002200D1
		public static IShowTalkFrameEvent Create(IShowTalkFrameEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkFrameEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x0600E688 RID: 59016 RVA: 0x00221EF0 File Offset: 0x002200F0
		public virtual ISequenceFrameEvent FrameEvent
		{
			get
			{
				if (this._FrameEventInited)
				{
					return this._FrameEventCache;
				}
				this._FrameEventInited = true;
				this._FrameEventCache = ISequenceFrameEvent.Create(this.Instance.FrameEvent);
				return this._FrameEventCache;
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0600E689 RID: 59017 RVA: 0x00221F24 File Offset: 0x00220124
		public virtual IShowTalkFrameEventPosition Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				this._PositionCache = IShowTalkFrameEventPosition.Create(this.Instance.Position);
				return this._PositionCache;
			}
		}

		// Token: 0x04007EF6 RID: 32502
		private IShowTalkFrameEvent Instance;

		// Token: 0x04007EF7 RID: 32503
		[Nullable(2)]
		private ISequenceFrameEvent _FrameEventCache;

		// Token: 0x04007EF8 RID: 32504
		private bool _FrameEventInited;

		// Token: 0x04007EF9 RID: 32505
		[Nullable(2)]
		private IShowTalkFrameEventPosition _PositionCache;

		// Token: 0x04007EFA RID: 32506
		private bool _PositionInited;
	}
}
