using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002783 RID: 10115
	[NullableContext(1)]
	[Nullable(0)]
	public class BeginFlowTemplate : ActionParams
	{
		// Token: 0x0600E132 RID: 57650 RVA: 0x002145E2 File Offset: 0x002127E2
		public static BeginFlowTemplate Create(IBeginFlowTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BeginFlowTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x0600E133 RID: 57651 RVA: 0x00214604 File Offset: 0x00212804
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x0600E134 RID: 57652 RVA: 0x0021463C File Offset: 0x0021283C
		public virtual List<IFlowActorUnit> Actors
		{
			get
			{
				if (this._ActorsInited)
				{
					return this._ActorsCache;
				}
				this._ActorsInited = true;
				int actorsLength = this.Instance.ActorsLength;
				this._ActorsCache = new List<IFlowActorUnit>(actorsLength);
				for (int i = 0; i < actorsLength; i++)
				{
					this._ActorsCache.Add(IFlowActorUnit.Create(this.Instance.Actors(i)));
				}
				return this._ActorsCache;
			}
		}

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x0600E135 RID: 57653 RVA: 0x002146A8 File Offset: 0x002128A8
		[Nullable(2)]
		public virtual List<int> MontageIds
		{
			[NullableContext(2)]
			get
			{
				if (this._MontageIdsInited)
				{
					return this._MontageIdsCache;
				}
				this._MontageIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int montageIdsLength = this.Instance.MontageIdsLength;
				this._MontageIdsCache = new List<int>(montageIdsLength);
				for (int i = 0; i < montageIdsLength; i++)
				{
					this._MontageIdsCache.Add(this.Instance.MontageIds(i));
				}
				return this._MontageIdsCache;
			}
		}

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x0600E136 RID: 57654 RVA: 0x00214720 File Offset: 0x00212920
		public virtual bool? UseFreeCamera
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseFreeCamera);
			}
		}

		// Token: 0x170043F2 RID: 17394
		// (get) Token: 0x0600E137 RID: 57655 RVA: 0x00214758 File Offset: 0x00212958
		public virtual bool? IsSwitchMainRole
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSwitchMainRole);
			}
		}

		// Token: 0x170043F3 RID: 17395
		// (get) Token: 0x0600E138 RID: 57656 RVA: 0x00214790 File Offset: 0x00212990
		public virtual bool? IsUseSeqFace
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsUseSeqFace);
			}
		}

		// Token: 0x04007CC5 RID: 31941
		private IBeginFlowTemplate Instance;

		// Token: 0x04007CC6 RID: 31942
		private List<IFlowActorUnit> _ActorsCache;

		// Token: 0x04007CC7 RID: 31943
		private bool _ActorsInited;

		// Token: 0x04007CC8 RID: 31944
		[Nullable(2)]
		private List<int> _MontageIdsCache;

		// Token: 0x04007CC9 RID: 31945
		private bool _MontageIdsInited;
	}
}
