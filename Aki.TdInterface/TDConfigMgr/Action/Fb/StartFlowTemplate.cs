using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002779 RID: 10105
	[NullableContext(1)]
	[Nullable(0)]
	public class StartFlowTemplate : ActionParams
	{
		// Token: 0x0600E100 RID: 57600 RVA: 0x00213DF6 File Offset: 0x00211FF6
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

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x0600E101 RID: 57601 RVA: 0x00213E15 File Offset: 0x00212015
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

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x0600E102 RID: 57602 RVA: 0x00213E49 File Offset: 0x00212049
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

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x0600E103 RID: 57603 RVA: 0x00213E80 File Offset: 0x00212080
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

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x0600E104 RID: 57604 RVA: 0x00213EE4 File Offset: 0x002120E4
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

		// Token: 0x04007C97 RID: 31895
		private IStartFlowTemplate Instance;

		// Token: 0x04007C98 RID: 31896
		[Nullable(2)]
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x04007C99 RID: 31897
		private bool _TemplateModeInited;

		// Token: 0x04007C9A RID: 31898
		[Nullable(2)]
		private PosA _TargetPosCache;

		// Token: 0x04007C9B RID: 31899
		private bool _TargetPosInited;

		// Token: 0x04007C9C RID: 31900
		private List<int> _ActorIdArrayCache;

		// Token: 0x04007C9D RID: 31901
		private bool _ActorIdArrayInited;

		// Token: 0x04007C9E RID: 31902
		[Nullable(2)]
		private List<int> _TalkerIdsCache;

		// Token: 0x04007C9F RID: 31903
		private bool _TalkerIdsInited;
	}
}
