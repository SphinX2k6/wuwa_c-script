using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D6 RID: 9686
	[NullableContext(1)]
	[Nullable(0)]
	public class PlaySequenceData : ActionParams
	{
		// Token: 0x0600D9BC RID: 55740 RVA: 0x00207821 File Offset: 0x00205A21
		public static PlaySequenceData Create(IPlaySequenceData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlaySequenceData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x0600D9BD RID: 55741 RVA: 0x00207840 File Offset: 0x00205A40
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x00207850 File Offset: 0x00205A50
		public virtual bool? ResetCamera
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ResetCamera);
			}
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x0600D9BF RID: 55743 RVA: 0x00207888 File Offset: 0x00205A88
		public virtual bool? KeepCamera
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepCamera);
			}
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x0600D9C0 RID: 55744 RVA: 0x002078C0 File Offset: 0x00205AC0
		public virtual bool? PreLoadRenderAssets
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PreLoadRenderAssets);
			}
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x0600D9C1 RID: 55745 RVA: 0x002078F8 File Offset: 0x00205AF8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ISequenceFrameEvent> FrameEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._FrameEventsInited)
				{
					return this._FrameEventsCache;
				}
				this._FrameEventsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int frameEventsLength = this.Instance.FrameEventsLength;
				this._FrameEventsCache = new List<ISequenceFrameEvent>(frameEventsLength);
				for (int i = 0; i < frameEventsLength; i++)
				{
					this._FrameEventsCache.Add(ISequenceFrameEvent.Create(this.Instance.FrameEvents(i)));
				}
				return this._FrameEventsCache;
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x0600D9C2 RID: 55746 RVA: 0x00207974 File Offset: 0x00205B74
		public virtual bool? SaveFinalPos
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SaveFinalPos);
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x0600D9C3 RID: 55747 RVA: 0x002079AB File Offset: 0x00205BAB
		[Nullable(2)]
		public virtual SetBlendAnim SeqBlendAnim
		{
			[NullableContext(2)]
			get
			{
				if (this._SeqBlendAnimInited)
				{
					return this._SeqBlendAnimCache;
				}
				this._SeqBlendAnimInited = true;
				this._SeqBlendAnimCache = SetBlendAnim.Create(this.Instance.SeqBlendAnim);
				return this._SeqBlendAnimCache;
			}
		}

		// Token: 0x040078EC RID: 30956
		private IPlaySequenceData Instance;

		// Token: 0x040078ED RID: 30957
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISequenceFrameEvent> _FrameEventsCache;

		// Token: 0x040078EE RID: 30958
		private bool _FrameEventsInited;

		// Token: 0x040078EF RID: 30959
		[Nullable(2)]
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x040078F0 RID: 30960
		private bool _SeqBlendAnimInited;
	}
}
