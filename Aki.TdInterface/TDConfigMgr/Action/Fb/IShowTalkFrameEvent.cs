using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B1 RID: 9649
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkFrameEvent
	{
		// Token: 0x0600D90D RID: 55565 RVA: 0x002061FD File Offset: 0x002043FD
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

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x0600D90E RID: 55566 RVA: 0x0020621C File Offset: 0x0020441C
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

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x0600D90F RID: 55567 RVA: 0x00206250 File Offset: 0x00204450
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

		// Token: 0x0400788F RID: 30863
		private IShowTalkFrameEvent Instance;

		// Token: 0x04007890 RID: 30864
		[Nullable(2)]
		private ISequenceFrameEvent _FrameEventCache;

		// Token: 0x04007891 RID: 30865
		private bool _FrameEventInited;

		// Token: 0x04007892 RID: 30866
		[Nullable(2)]
		private IShowTalkFrameEventPosition _PositionCache;

		// Token: 0x04007893 RID: 30867
		private bool _PositionInited;
	}
}
