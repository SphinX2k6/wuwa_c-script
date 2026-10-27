using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277D RID: 10109
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeFlowTemplate : ActionParams
	{
		// Token: 0x0600E111 RID: 57617 RVA: 0x002140D2 File Offset: 0x002122D2
		[NullableContext(1)]
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

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x0600E112 RID: 57618 RVA: 0x002140F1 File Offset: 0x002122F1
		[Nullable(1)]
		public virtual IFlowTemplateMode TemplateMode
		{
			[NullableContext(1)]
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

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x0600E113 RID: 57619 RVA: 0x00214125 File Offset: 0x00212325
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

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x0600E114 RID: 57620 RVA: 0x0021415C File Offset: 0x0021235C
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

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x0600E115 RID: 57621 RVA: 0x002141D4 File Offset: 0x002123D4
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

		// Token: 0x04007CA7 RID: 31911
		private IChangeFlowTemplate Instance;

		// Token: 0x04007CA8 RID: 31912
		private IFlowTemplateMode _TemplateModeCache;

		// Token: 0x04007CA9 RID: 31913
		private bool _TemplateModeInited;

		// Token: 0x04007CAA RID: 31914
		private PosA _TargetPosCache;

		// Token: 0x04007CAB RID: 31915
		private bool _TargetPosInited;

		// Token: 0x04007CAC RID: 31916
		private List<int> _ActorIdArrayCache;

		// Token: 0x04007CAD RID: 31917
		private bool _ActorIdArrayInited;

		// Token: 0x04007CAE RID: 31918
		private List<int> _TalkerIdsCache;

		// Token: 0x04007CAF RID: 31919
		private bool _TalkerIdsInited;
	}
}
