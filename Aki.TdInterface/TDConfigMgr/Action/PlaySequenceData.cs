using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002380 RID: 9088
	public class PlaySequenceData : ActionParams
	{
		// Token: 0x0600C640 RID: 50752 RVA: 0x001C6810 File Offset: 0x001C4A10
		private PlaySequenceData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlaySequenceData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlaySequenceData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlaySequenceData_SetValue());
			}
			return result;
		}

		// Token: 0x0600C641 RID: 50753 RVA: 0x001C6848 File Offset: 0x001C4A48
		public static PlaySequenceData Create([Nullable(2)] PlaySequenceData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlaySequenceData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C642 RID: 50754 RVA: 0x001C685B File Offset: 0x001C4A5B
		public static PlaySequenceData CreateFromSetValue([Nullable(2)] PlaySequenceData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlaySequenceData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C643 RID: 50755 RVA: 0x001C6870 File Offset: 0x001C4A70
		public PlaySequenceData_SetValue ToSetValue()
		{
			return new PlaySequenceData_SetValue
			{
				Path = this.Path,
				ResetCamera = this.ResetCamera,
				KeepCamera = this.KeepCamera,
				PreLoadRenderAssets = this.PreLoadRenderAssets,
				FrameEvents = this.FrameEvents,
				SaveFinalPos = this.SaveFinalPos,
				SeqBlendAnim = this.SeqBlendAnim
			};
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0600C644 RID: 50756 RVA: 0x001C68D6 File Offset: 0x001C4AD6
		// (set) Token: 0x0600C645 RID: 50757 RVA: 0x001C6901 File Offset: 0x001C4B01
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0600C646 RID: 50758 RVA: 0x001C6910 File Offset: 0x001C4B10
		// (set) Token: 0x0600C647 RID: 50759 RVA: 0x001C694A File Offset: 0x001C4B4A
		public virtual bool? ResetCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetCamera;
				}
				PlaySequenceData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetCamera;
			}
			set
			{
				this.GetOrCreatePoco().ResetCamera = value;
			}
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x0600C648 RID: 50760 RVA: 0x001C6958 File Offset: 0x001C4B58
		// (set) Token: 0x0600C649 RID: 50761 RVA: 0x001C6992 File Offset: 0x001C4B92
		public virtual bool? KeepCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepCamera;
				}
				PlaySequenceData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepCamera;
			}
			set
			{
				this.GetOrCreatePoco().KeepCamera = value;
			}
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600C64A RID: 50762 RVA: 0x001C69A0 File Offset: 0x001C4BA0
		// (set) Token: 0x0600C64B RID: 50763 RVA: 0x001C69DA File Offset: 0x001C4BDA
		public virtual bool? PreLoadRenderAssets
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PreLoadRenderAssets;
				}
				PlaySequenceData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PreLoadRenderAssets;
			}
			set
			{
				this.GetOrCreatePoco().PreLoadRenderAssets = value;
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600C64C RID: 50764 RVA: 0x001C69E8 File Offset: 0x001C4BE8
		// (set) Token: 0x0600C64D RID: 50765 RVA: 0x001C6A7B File Offset: 0x001C4C7B
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
				if (this.FbInstance != null)
				{
					List<ISequenceFrameEvent> frameEvents = this.FbInstance.FrameEvents;
					if (frameEvents != null)
					{
						this._FrameEventsCache = new List<ISequenceFrameEvent>(frameEvents.Count);
						for (int i = 0; i < frameEvents.Count; i++)
						{
							this._FrameEventsCache.Add(ISequenceFrameEvent.Create(frameEvents[i]));
						}
					}
				}
				else
				{
					PlaySequenceData_SetValue pocoInterface = this.PocoInterface;
					this._FrameEventsCache = ((pocoInterface != null) ? pocoInterface.FrameEvents : null);
				}
				return this._FrameEventsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().FrameEvents = value;
				this._FrameEventsInited = false;
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600C64E RID: 50766 RVA: 0x001C6A90 File Offset: 0x001C4C90
		// (set) Token: 0x0600C64F RID: 50767 RVA: 0x001C6ACA File Offset: 0x001C4CCA
		public virtual bool? SaveFinalPos
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SaveFinalPos;
				}
				PlaySequenceData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SaveFinalPos;
			}
			set
			{
				this.GetOrCreatePoco().SaveFinalPos = value;
			}
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0600C650 RID: 50768 RVA: 0x001C6AD8 File Offset: 0x001C4CD8
		// (set) Token: 0x0600C651 RID: 50769 RVA: 0x001C6B39 File Offset: 0x001C4D39
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
				if (this.FbInstance != null)
				{
					this._SeqBlendAnimCache = SetBlendAnim.Create(this.FbInstance.SeqBlendAnim);
				}
				else
				{
					PlaySequenceData_SetValue pocoInterface = this.PocoInterface;
					this._SeqBlendAnimCache = ((pocoInterface != null) ? pocoInterface.SeqBlendAnim : null);
				}
				return this._SeqBlendAnimCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SeqBlendAnim = value;
				this._SeqBlendAnimInited = false;
			}
		}

		// Token: 0x040075F4 RID: 30196
		[Nullable(2)]
		protected new PlaySequenceData FbInstance;

		// Token: 0x040075F5 RID: 30197
		[Nullable(2)]
		protected PlaySequenceData_SetValue PocoInterface;

		// Token: 0x040075F6 RID: 30198
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ISequenceFrameEvent> _FrameEventsCache;

		// Token: 0x040075F7 RID: 30199
		private bool _FrameEventsInited;

		// Token: 0x040075F8 RID: 30200
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x040075F9 RID: 30201
		private bool _SeqBlendAnimInited;
	}
}
