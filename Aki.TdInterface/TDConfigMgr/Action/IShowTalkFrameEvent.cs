using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E64 RID: 7780
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkFrameEvent
	{
		// Token: 0x0600A689 RID: 42633 RVA: 0x00178D94 File Offset: 0x00176F94
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

		// Token: 0x0600A68A RID: 42634 RVA: 0x00178DCC File Offset: 0x00176FCC
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

		// Token: 0x0600A68B RID: 42635 RVA: 0x00178DDF File Offset: 0x00176FDF
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

		// Token: 0x0600A68C RID: 42636 RVA: 0x00178DF2 File Offset: 0x00176FF2
		public IShowTalkFrameEvent_SetValue ToSetValue()
		{
			return new IShowTalkFrameEvent_SetValue
			{
				FrameEvent = this.FrameEvent,
				Position = this.Position
			};
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600A68D RID: 42637 RVA: 0x00178E14 File Offset: 0x00177014
		// (set) Token: 0x0600A68E RID: 42638 RVA: 0x00178E75 File Offset: 0x00177075
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

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600A68F RID: 42639 RVA: 0x00178E8C File Offset: 0x0017708C
		// (set) Token: 0x0600A690 RID: 42640 RVA: 0x00178EED File Offset: 0x001770ED
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

		// Token: 0x04006378 RID: 25464
		[Nullable(2)]
		protected IShowTalkFrameEvent FbInstance;

		// Token: 0x04006379 RID: 25465
		[Nullable(2)]
		protected IShowTalkFrameEvent_SetValue PocoInterface;

		// Token: 0x0400637A RID: 25466
		private ISequenceFrameEvent _FrameEventCache;

		// Token: 0x0400637B RID: 25467
		private bool _FrameEventInited;

		// Token: 0x0400637C RID: 25468
		private IShowTalkFrameEventPosition _PositionCache;

		// Token: 0x0400637D RID: 25469
		private bool _PositionInited;
	}
}
