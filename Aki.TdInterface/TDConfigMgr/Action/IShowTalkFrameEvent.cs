using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002099 RID: 8345
	public class IShowTalkFrameEvent
	{
		// Token: 0x0600B141 RID: 45377 RVA: 0x0018EA94 File Offset: 0x0018CC94
		private IShowTalkFrameEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowTalkFrameEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowTalkFrameEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowTalkFrameEvent_SetValue());
			}
			return result;
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x0018EACC File Offset: 0x0018CCCC
		public static IShowTalkFrameEvent Create([Nullable(2)] IShowTalkFrameEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkFrameEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x0018EADF File Offset: 0x0018CCDF
		public static IShowTalkFrameEvent CreateFromSetValue([Nullable(2)] IShowTalkFrameEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowTalkFrameEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x0018EAF2 File Offset: 0x0018CCF2
		public IShowTalkFrameEvent_SetValue ToSetValue()
		{
			return new IShowTalkFrameEvent_SetValue
			{
				FrameEvent = this.FrameEvent,
				Position = this.Position
			};
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600B145 RID: 45381 RVA: 0x0018EB14 File Offset: 0x0018CD14
		// (set) Token: 0x0600B146 RID: 45382 RVA: 0x0018EB75 File Offset: 0x0018CD75
		public virtual ISequenceFrameEvent FrameEvent
		{
			get
			{
				if (this._FrameEventInited)
				{
					return this._FrameEventCache;
				}
				this._FrameEventInited = true;
				if (this.FbInstance != null)
				{
					this._FrameEventCache = ISequenceFrameEvent.Create(this.FbInstance.FrameEvent);
				}
				else
				{
					IShowTalkFrameEvent_SetValue pocoInterface = this.PocoInterface;
					this._FrameEventCache = ((pocoInterface != null) ? pocoInterface.FrameEvent : null);
				}
				return this._FrameEventCache;
			}
			set
			{
				this.GetOrCreatePoco().FrameEvent = value;
				this._FrameEventInited = false;
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600B147 RID: 45383 RVA: 0x0018EB8C File Offset: 0x0018CD8C
		// (set) Token: 0x0600B148 RID: 45384 RVA: 0x0018EBED File Offset: 0x0018CDED
		public virtual IShowTalkFrameEventPosition Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				if (this.FbInstance != null)
				{
					this._PositionCache = IShowTalkFrameEventPosition.Create(this.FbInstance.Position);
				}
				else
				{
					IShowTalkFrameEvent_SetValue pocoInterface = this.PocoInterface;
					this._PositionCache = ((pocoInterface != null) ? pocoInterface.Position : null);
				}
				return this._PositionCache;
			}
			set
			{
				this.GetOrCreatePoco().Position = value;
				this._PositionInited = false;
			}
		}

		// Token: 0x0400695C RID: 26972
		[Nullable(2)]
		protected IShowTalkFrameEvent FbInstance;

		// Token: 0x0400695D RID: 26973
		[Nullable(2)]
		protected IShowTalkFrameEvent_SetValue PocoInterface;

		// Token: 0x0400695E RID: 26974
		private ISequenceFrameEvent _FrameEventCache;

		// Token: 0x0400695F RID: 26975
		private bool _FrameEventInited;

		// Token: 0x04006960 RID: 26976
		private IShowTalkFrameEventPosition _PositionCache;

		// Token: 0x04006961 RID: 26977
		private bool _PositionInited;
	}
}
