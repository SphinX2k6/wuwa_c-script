using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002895 RID: 10389
	public class PlaySequenceData : ActionParams
	{
		// Token: 0x0600E784 RID: 59268 RVA: 0x00223ED5 File Offset: 0x002220D5
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

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x0600E785 RID: 59269 RVA: 0x00223EF4 File Offset: 0x002220F4
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x0600E786 RID: 59270 RVA: 0x00223F04 File Offset: 0x00222104
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

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x0600E787 RID: 59271 RVA: 0x00223F3C File Offset: 0x0022213C
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

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x0600E788 RID: 59272 RVA: 0x00223F74 File Offset: 0x00222174
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

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x0600E789 RID: 59273 RVA: 0x00223FAC File Offset: 0x002221AC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ISequenceFrameEvent> FrameEvents
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x0600E78A RID: 59274 RVA: 0x00224028 File Offset: 0x00222228
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

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x0600E78B RID: 59275 RVA: 0x0022405F File Offset: 0x0022225F
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

		// Token: 0x04007F83 RID: 32643
		private IPlaySequenceData Instance;

		// Token: 0x04007F84 RID: 32644
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ISequenceFrameEvent> _FrameEventsCache;

		// Token: 0x04007F85 RID: 32645
		private bool _FrameEventsInited;

		// Token: 0x04007F86 RID: 32646
		[Nullable(2)]
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x04007F87 RID: 32647
		private bool _SeqBlendAnimInited;
	}
}
