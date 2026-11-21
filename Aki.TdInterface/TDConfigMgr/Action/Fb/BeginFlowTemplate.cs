using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A55 RID: 10837
	public class BeginFlowTemplate : ActionParams
	{
		// Token: 0x0600EF50 RID: 61264 RVA: 0x00231376 File Offset: 0x0022F576
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

		// Token: 0x17004754 RID: 18260
		// (get) Token: 0x0600EF51 RID: 61265 RVA: 0x00231398 File Offset: 0x0022F598
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

		// Token: 0x17004755 RID: 18261
		// (get) Token: 0x0600EF52 RID: 61266 RVA: 0x002313D0 File Offset: 0x0022F5D0
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

		// Token: 0x17004756 RID: 18262
		// (get) Token: 0x0600EF53 RID: 61267 RVA: 0x0023143C File Offset: 0x0022F63C
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

		// Token: 0x17004757 RID: 18263
		// (get) Token: 0x0600EF54 RID: 61268 RVA: 0x002314B4 File Offset: 0x0022F6B4
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

		// Token: 0x17004758 RID: 18264
		// (get) Token: 0x0600EF55 RID: 61269 RVA: 0x002314EC File Offset: 0x0022F6EC
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

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x0600EF56 RID: 61270 RVA: 0x00231524 File Offset: 0x0022F724
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

		// Token: 0x0400837B RID: 33659
		private IBeginFlowTemplate Instance;

		// Token: 0x0400837C RID: 33660
		private List<IFlowActorUnit> _ActorsCache;

		// Token: 0x0400837D RID: 33661
		private bool _ActorsInited;

		// Token: 0x0400837E RID: 33662
		[Nullable(2)]
		private List<int> _MontageIdsCache;

		// Token: 0x0400837F RID: 33663
		private bool _MontageIdsInited;
	}
}
