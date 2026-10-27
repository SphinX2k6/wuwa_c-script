using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B27 RID: 2855
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemFoundation : IComponentBase
	{
		// Token: 0x060041E7 RID: 16871 RVA: 0x000A90C0 File Offset: 0x000A72C0
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

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x000A90E0 File Offset: 0x000A72E0
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

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x000A9118 File Offset: 0x000A7318
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x000A912E File Offset: 0x000A732E
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

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x000A9162 File Offset: 0x000A7362
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

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x000A9196 File Offset: 0x000A7396
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

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x000A91CA File Offset: 0x000A73CA
		public virtual bool IsSilent
		{
			get
			{
				return this.Instance.IsSilent;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x000A91D7 File Offset: 0x000A73D7
		public virtual bool IsDestroy
		{
			get
			{
				return this.Instance.IsDestroy;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x000A91E4 File Offset: 0x000A73E4
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

		// Token: 0x04002532 RID: 9522
		private IItemFoundation Instance;

		// Token: 0x04002533 RID: 9523
		[Nullable(2)]
		private IAdsortTransform _AdsorptionPointCache;

		// Token: 0x04002534 RID: 9524
		private bool _AdsorptionPointInited;

		// Token: 0x04002535 RID: 9525
		[Nullable(2)]
		private IEntityMatch _AdsorptionMatchCache;

		// Token: 0x04002536 RID: 9526
		private bool _AdsorptionMatchInited;

		// Token: 0x04002537 RID: 9527
		[Nullable(2)]
		private IEntityMatch _ActiveMatchCache;

		// Token: 0x04002538 RID: 9528
		private bool _ActiveMatchInited;

		// Token: 0x04002539 RID: 9529
		[Nullable(2)]
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x0400253A RID: 9530
		private bool _ChangeAdsorbateStateInited;
	}
}
