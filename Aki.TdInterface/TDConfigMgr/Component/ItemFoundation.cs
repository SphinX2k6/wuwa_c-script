using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200075A RID: 1882
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemFoundation : IComponentBase
	{
		// Token: 0x0600289B RID: 10395 RVA: 0x0006B65C File Offset: 0x0006985C
		private ItemFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ItemFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ItemFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ItemFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0006B694 File Offset: 0x00069894
		public static ItemFoundation Create([Nullable(2)] ItemFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ItemFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0006B6A7 File Offset: 0x000698A7
		public static ItemFoundation CreateFromSetValue([Nullable(2)] ItemFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ItemFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0006B6BC File Offset: 0x000698BC
		public new ItemFoundation_SetValue ToSetValue()
		{
			return new ItemFoundation_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AdsorptionPoint = this.AdsorptionPoint,
				AdsorptionMatch = this.AdsorptionMatch,
				ActiveMatch = this.ActiveMatch,
				IsSilent = this.IsSilent,
				IsDestroy = this.IsDestroy,
				ChangeAdsorbateState = this.ChangeAdsorbateState
			};
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0006B730 File Offset: 0x00069930
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x0006B76A File Offset: 0x0006996A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ItemFoundation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x0006B778 File Offset: 0x00069978
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x0006B7A2 File Offset: 0x000699A2
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0006B7B0 File Offset: 0x000699B0
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x0006B811 File Offset: 0x00069A11
		public virtual IAdsortTransform AdsorptionPoint
		{
			get
			{
				if (this._AdsorptionPointInited)
				{
					return this._AdsorptionPointCache;
				}
				this._AdsorptionPointInited = true;
				if (this.FbInstance != null)
				{
					this._AdsorptionPointCache = IAdsortTransform.Create(this.FbInstance.AdsorptionPoint);
				}
				else
				{
					ItemFoundation_SetValue pocoInterface = this.PocoInterface;
					this._AdsorptionPointCache = ((pocoInterface != null) ? pocoInterface.AdsorptionPoint : null);
				}
				return this._AdsorptionPointCache;
			}
			set
			{
				this.GetOrCreatePoco().AdsorptionPoint = value;
				this._AdsorptionPointInited = false;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x0006B828 File Offset: 0x00069A28
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x0006B889 File Offset: 0x00069A89
		public virtual IEntityMatch AdsorptionMatch
		{
			get
			{
				if (this._AdsorptionMatchInited)
				{
					return this._AdsorptionMatchCache;
				}
				this._AdsorptionMatchInited = true;
				if (this.FbInstance != null)
				{
					this._AdsorptionMatchCache = IEntityMatch.Create(this.FbInstance.AdsorptionMatch);
				}
				else
				{
					ItemFoundation_SetValue pocoInterface = this.PocoInterface;
					this._AdsorptionMatchCache = ((pocoInterface != null) ? pocoInterface.AdsorptionMatch : null);
				}
				return this._AdsorptionMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().AdsorptionMatch = value;
				this._AdsorptionMatchInited = false;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x0006B8A0 File Offset: 0x00069AA0
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x0006B901 File Offset: 0x00069B01
		public virtual IEntityMatch ActiveMatch
		{
			get
			{
				if (this._ActiveMatchInited)
				{
					return this._ActiveMatchCache;
				}
				this._ActiveMatchInited = true;
				if (this.FbInstance != null)
				{
					this._ActiveMatchCache = IEntityMatch.Create(this.FbInstance.ActiveMatch);
				}
				else
				{
					ItemFoundation_SetValue pocoInterface = this.PocoInterface;
					this._ActiveMatchCache = ((pocoInterface != null) ? pocoInterface.ActiveMatch : null);
				}
				return this._ActiveMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().ActiveMatch = value;
				this._ActiveMatchInited = false;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x0006B916 File Offset: 0x00069B16
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x0006B941 File Offset: 0x00069B41
		public virtual bool IsSilent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSilent;
				}
				return this.PocoInterface != null && this.PocoInterface.IsSilent;
			}
			set
			{
				this.GetOrCreatePoco().IsSilent = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0006B94F File Offset: 0x00069B4F
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x0006B97A File Offset: 0x00069B7A
		public virtual bool IsDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDestroy;
				}
				return this.PocoInterface != null && this.PocoInterface.IsDestroy;
			}
			set
			{
				this.GetOrCreatePoco().IsDestroy = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0006B988 File Offset: 0x00069B88
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x0006B9E9 File Offset: 0x00069BE9
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
				if (this.FbInstance != null)
				{
					this._ChangeAdsorbateStateCache = IItemChangeAdsorbateState.Create(this.FbInstance.ChangeAdsorbateState);
				}
				else
				{
					ItemFoundation_SetValue pocoInterface = this.PocoInterface;
					this._ChangeAdsorbateStateCache = ((pocoInterface != null) ? pocoInterface.ChangeAdsorbateState : null);
				}
				return this._ChangeAdsorbateStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ChangeAdsorbateState = value;
				this._ChangeAdsorbateStateInited = false;
			}
		}

		// Token: 0x04001B46 RID: 6982
		[Nullable(2)]
		protected new ItemFoundation FbInstance;

		// Token: 0x04001B47 RID: 6983
		[Nullable(2)]
		protected new ItemFoundation_SetValue PocoInterface;

		// Token: 0x04001B48 RID: 6984
		private IAdsortTransform _AdsorptionPointCache;

		// Token: 0x04001B49 RID: 6985
		private bool _AdsorptionPointInited;

		// Token: 0x04001B4A RID: 6986
		private IEntityMatch _AdsorptionMatchCache;

		// Token: 0x04001B4B RID: 6987
		private bool _AdsorptionMatchInited;

		// Token: 0x04001B4C RID: 6988
		private IEntityMatch _ActiveMatchCache;

		// Token: 0x04001B4D RID: 6989
		private bool _ActiveMatchInited;

		// Token: 0x04001B4E RID: 6990
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x04001B4F RID: 6991
		private bool _ChangeAdsorbateStateInited;
	}
}
