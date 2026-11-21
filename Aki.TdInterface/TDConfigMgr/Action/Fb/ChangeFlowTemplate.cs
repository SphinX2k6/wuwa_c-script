using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4F RID: 10831
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeFlowTemplate : ActionParams
	{
		// Token: 0x0600EF2F RID: 61231 RVA: 0x00230E66 File Offset: 0x0022F066
		[NullableContext(0)]
		public static ChangeFlowTemplate Create(IChangeFlowTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeFlowTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700473F RID: 18239
		// (get) Token: 0x0600EF30 RID: 61232 RVA: 0x00230E85 File Offset: 0x0022F085
		[Nullable(0)]
		public virtual IFlowTemplateMode TemplateMode
		{
			[NullableContext(0)]
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

		// Token: 0x17004740 RID: 18240
		// (get) Token: 0x0600EF31 RID: 61233 RVA: 0x00230EB9 File Offset: 0x0022F0B9
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

		// Token: 0x17004741 RID: 18241
		// (get) Token: 0x0600EF32 RID: 61234 RVA: 0x00230EF0 File Offset: 0x0022F0F0
		public virtual List<int> ActorIdArray
		{
			get
			{
				if (this._ActorIdArrayInited)
				{
					return this._ActorIdArrayCache;
				}
				this._ActorIdArrayInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int actorIdArrayLength = this.Instance.ActorIdArrayLength;
				this._ActorIdArrayCache = new List<int>(actorIdArrayLength);
				for (int i = 0; i < actorIdArrayLength; i++)
				{
					this._ActorIdArrayCache.Add(this.Instance.ActorIdArray(i));
				}
				return this._ActorIdArrayCache;
			}
		}

		// Token: 0x17004742 RID: 18242
		// (get) Token: 0x0600EF33 RID: 61235 RVA: 0x00230F68 File Offset: 0x0022F168
		public virtual List<int> TalkerIds
		{
			get
			{
				if (this._TalkerIdsInited)
				{
					return this._TalkerIdsCache;
				}
				this._TalkerIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
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

		// Token: 0x0400835D RID: 33629
		private IChangeFlowTemplate Instance;

		// Token: 0x0400835E RID: 33630
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x0400835F RID: 33631
		private bool _TemplateModeInited;

		// Token: 0x04008360 RID: 33632
		private PosA _TargetPosCache;

		// Token: 0x04008361 RID: 33633
		private bool _TargetPosInited;

		// Token: 0x04008362 RID: 33634
		private List<int> _ActorIdArrayCache;

		// Token: 0x04008363 RID: 33635
		private bool _ActorIdArrayInited;

		// Token: 0x04008364 RID: 33636
		private List<int> _TalkerIdsCache;

		// Token: 0x04008365 RID: 33637
		private bool _TalkerIdsInited;
	}
}
