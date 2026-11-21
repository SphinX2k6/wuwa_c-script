using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF5 RID: 3061
	public class ItemFoundation : IComponentBase
	{
		// Token: 0x06004640 RID: 17984 RVA: 0x000B3184 File Offset: 0x000B1384
		public static ItemFoundation Create(IItemFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ItemFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06004641 RID: 17985 RVA: 0x000B31A4 File Offset: 0x000B13A4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06004642 RID: 17986 RVA: 0x000B31DC File Offset: 0x000B13DC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x000B31F2 File Offset: 0x000B13F2
		public virtual IAdsortTransform AdsorptionPoint
		{
			get
			{
				if (this._AdsorptionPointInited)
				{
					return this._AdsorptionPointCache;
				}
				this._AdsorptionPointInited = true;
				this._AdsorptionPointCache = IAdsortTransform.Create(this.Instance.AdsorptionPoint);
				return this._AdsorptionPointCache;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x000B3226 File Offset: 0x000B1426
		public virtual IEntityMatch AdsorptionMatch
		{
			get
			{
				if (this._AdsorptionMatchInited)
				{
					return this._AdsorptionMatchCache;
				}
				this._AdsorptionMatchInited = true;
				this._AdsorptionMatchCache = IEntityMatch.Create(this.Instance.AdsorptionMatch);
				return this._AdsorptionMatchCache;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x000B325A File Offset: 0x000B145A
		public virtual IEntityMatch ActiveMatch
		{
			get
			{
				if (this._ActiveMatchInited)
				{
					return this._ActiveMatchCache;
				}
				this._ActiveMatchInited = true;
				this._ActiveMatchCache = IEntityMatch.Create(this.Instance.ActiveMatch);
				return this._ActiveMatchCache;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x000B328E File Offset: 0x000B148E
		public virtual bool IsSilent
		{
			get
			{
				return this.Instance.IsSilent;
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x000B329B File Offset: 0x000B149B
		public virtual bool IsDestroy
		{
			get
			{
				return this.Instance.IsDestroy;
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x000B32A8 File Offset: 0x000B14A8
		[Nullable(2)]
		public virtual IItemChangeAdsorbateState ChangeAdsorbateState
		{
			[NullableContext(2)]
			get
			{
				if (this._ChangeAdsorbateStateInited)
				{
					return this._ChangeAdsorbateStateCache;
				}
				this._ChangeAdsorbateStateInited = true;
				this._ChangeAdsorbateStateCache = IItemChangeAdsorbateState.Create(this.Instance.ChangeAdsorbateState);
				return this._ChangeAdsorbateStateCache;
			}
		}

		// Token: 0x0400277A RID: 10106
		private IItemFoundation Instance;

		// Token: 0x0400277B RID: 10107
		[Nullable(2)]
		private IAdsortTransform _AdsorptionPointCache;

		// Token: 0x0400277C RID: 10108
		private bool _AdsorptionPointInited;

		// Token: 0x0400277D RID: 10109
		[Nullable(2)]
		private IEntityMatch _AdsorptionMatchCache;

		// Token: 0x0400277E RID: 10110
		private bool _AdsorptionMatchInited;

		// Token: 0x0400277F RID: 10111
		[Nullable(2)]
		private IEntityMatch _ActiveMatchCache;

		// Token: 0x04002780 RID: 10112
		private bool _ActiveMatchInited;

		// Token: 0x04002781 RID: 10113
		[Nullable(2)]
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x04002782 RID: 10114
		private bool _ChangeAdsorbateStateInited;
	}
}
