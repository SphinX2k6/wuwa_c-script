using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211F RID: 8479
	[NullableContext(1)]
	[Nullable(0)]
	public class PlaySequenceData : ActionParams
	{
		// Token: 0x0600BAB2 RID: 47794 RVA: 0x001AF65C File Offset: 0x001AD85C
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

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x001AF694 File Offset: 0x001AD894
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

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x001AF6A7 File Offset: 0x001AD8A7
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

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x001AF6BC File Offset: 0x001AD8BC
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

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600BAB6 RID: 47798 RVA: 0x001AF722 File Offset: 0x001AD922
		// (set) Token: 0x0600BAB7 RID: 47799 RVA: 0x001AF74D File Offset: 0x001AD94D
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

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600BAB8 RID: 47800 RVA: 0x001AF75C File Offset: 0x001AD95C
		// (set) Token: 0x0600BAB9 RID: 47801 RVA: 0x001AF796 File Offset: 0x001AD996
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

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600BABA RID: 47802 RVA: 0x001AF7A4 File Offset: 0x001AD9A4
		// (set) Token: 0x0600BABB RID: 47803 RVA: 0x001AF7DE File Offset: 0x001AD9DE
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

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600BABC RID: 47804 RVA: 0x001AF7EC File Offset: 0x001AD9EC
		// (set) Token: 0x0600BABD RID: 47805 RVA: 0x001AF826 File Offset: 0x001ADA26
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

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600BABE RID: 47806 RVA: 0x001AF834 File Offset: 0x001ADA34
		// (set) Token: 0x0600BABF RID: 47807 RVA: 0x001AF8C7 File Offset: 0x001ADAC7
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().FrameEvents = value;
				this._FrameEventsInited = false;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x001AF8DC File Offset: 0x001ADADC
		// (set) Token: 0x0600BAC1 RID: 47809 RVA: 0x001AF916 File Offset: 0x001ADB16
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

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x001AF924 File Offset: 0x001ADB24
		// (set) Token: 0x0600BAC3 RID: 47811 RVA: 0x001AF985 File Offset: 0x001ADB85
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

		// Token: 0x04006FBF RID: 28607
		[Nullable(2)]
		protected new PlaySequenceData FbInstance;

		// Token: 0x04006FC0 RID: 28608
		[Nullable(2)]
		protected PlaySequenceData_SetValue PocoInterface;

		// Token: 0x04006FC1 RID: 28609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISequenceFrameEvent> _FrameEventsCache;

		// Token: 0x04006FC2 RID: 28610
		private bool _FrameEventsInited;

		// Token: 0x04006FC3 RID: 28611
		private SetBlendAnim _SeqBlendAnimCache;

		// Token: 0x04006FC4 RID: 28612
		private bool _SeqBlendAnimInited;
	}
}
