using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4B RID: 10827
	public class StartFlowTemplate : ActionParams
	{
		// Token: 0x0600EF1E RID: 61214 RVA: 0x00230B8A File Offset: 0x0022ED8A
		public static StartFlowTemplate Create(IStartFlowTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StartFlowTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004736 RID: 18230
		// (get) Token: 0x0600EF1F RID: 61215 RVA: 0x00230BA9 File Offset: 0x0022EDA9
		public virtual IFlowTemplateMode TemplateMode
		{
			get
			{
				if (this._TemplateModeInited)
				{
					return this._TemplateModeCache;
				}
				this._TemplateModeInited = true;
				this._TemplateModeCache = IFlowTemplateMode.Create(this.Instance.TemplateMode);
				return this._TemplateModeCache;
			}
		}

		// Token: 0x17004737 RID: 18231
		// (get) Token: 0x0600EF20 RID: 61216 RVA: 0x00230BDD File Offset: 0x0022EDDD
		public virtual PosA TargetPos
		{
			get
			{
				if (this._TargetPosInited)
				{
					return this._TargetPosCache;
				}
				this._TargetPosInited = true;
				this._TargetPosCache = PosA.Create(this.Instance.TargetPos);
				return this._TargetPosCache;
			}
		}

		// Token: 0x17004738 RID: 18232
		// (get) Token: 0x0600EF21 RID: 61217 RVA: 0x00230C14 File Offset: 0x0022EE14
		public virtual List<int> ActorIdArray
		{
			get
			{
				if (this._ActorIdArrayInited)
				{
					return this._ActorIdArrayCache;
				}
				this._ActorIdArrayInited = true;
				int actorIdArrayLength = this.Instance.ActorIdArrayLength;
				this._ActorIdArrayCache = new List<int>(actorIdArrayLength);
				for (int i = 0; i < actorIdArrayLength; i++)
				{
					this._ActorIdArrayCache.Add(this.Instance.ActorIdArray(i));
				}
				return this._ActorIdArrayCache;
			}
		}

		// Token: 0x17004739 RID: 18233
		// (get) Token: 0x0600EF22 RID: 61218 RVA: 0x00230C78 File Offset: 0x0022EE78
		[Nullable(2)]
		public virtual List<int> TalkerIds
		{
			[NullableContext(2)]
			get
			{
				if (this._TalkerIdsInited)
				{
					return this._TalkerIdsCache;
				}
				this._TalkerIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int talkerIdsLength = this.Instance.TalkerIdsLength;
				this._TalkerIdsCache = new List<int>(talkerIdsLength);
				for (int i = 0; i < talkerIdsLength; i++)
				{
					this._TalkerIdsCache.Add(this.Instance.TalkerIds(i));
				}
				return this._TalkerIdsCache;
			}
		}

		// Token: 0x0400834D RID: 33613
		private IStartFlowTemplate Instance;

		// Token: 0x0400834E RID: 33614
		[Nullable(2)]
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x0400834F RID: 33615
		private bool _TemplateModeInited;

		// Token: 0x04008350 RID: 33616
		[Nullable(2)]
		private PosA _TargetPosCache;

		// Token: 0x04008351 RID: 33617
		private bool _TargetPosInited;

		// Token: 0x04008352 RID: 33618
		private List<int> _ActorIdArrayCache;

		// Token: 0x04008353 RID: 33619
		private bool _ActorIdArrayInited;

		// Token: 0x04008354 RID: 33620
		[Nullable(2)]
		private List<int> _TalkerIdsCache;

		// Token: 0x04008355 RID: 33621
		private bool _TalkerIdsInited;
	}
}
