using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007FB RID: 2043
	public class ItemFoundation : IComponentBase
	{
		// Token: 0x06002BBF RID: 11199 RVA: 0x00072804 File Offset: 0x00070A04
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

		// Token: 0x06002BC0 RID: 11200 RVA: 0x0007283C File Offset: 0x00070A3C
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

		// Token: 0x06002BC1 RID: 11201 RVA: 0x0007284F File Offset: 0x00070A4F
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

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00072864 File Offset: 0x00070A64
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

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x000728D8 File Offset: 0x00070AD8
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x00072912 File Offset: 0x00070B12
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

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x00072920 File Offset: 0x00070B20
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x0007294A File Offset: 0x00070B4A
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

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x00072958 File Offset: 0x00070B58
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x000729B9 File Offset: 0x00070BB9
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

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x000729D0 File Offset: 0x00070BD0
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x00072A31 File Offset: 0x00070C31
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

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x00072A48 File Offset: 0x00070C48
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x00072AA9 File Offset: 0x00070CA9
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

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00072ABE File Offset: 0x00070CBE
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x00072AE9 File Offset: 0x00070CE9
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

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x00072AF7 File Offset: 0x00070CF7
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x00072B22 File Offset: 0x00070D22
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

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x00072B30 File Offset: 0x00070D30
		// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x00072B91 File Offset: 0x00070D91
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

		// Token: 0x04001D4B RID: 7499
		[Nullable(2)]
		protected new ItemFoundation FbInstance;

		// Token: 0x04001D4C RID: 7500
		[Nullable(2)]
		protected new ItemFoundation_SetValue PocoInterface;

		// Token: 0x04001D4D RID: 7501
		private IAdsortTransform _AdsorptionPointCache;

		// Token: 0x04001D4E RID: 7502
		private bool _AdsorptionPointInited;

		// Token: 0x04001D4F RID: 7503
		private IEntityMatch _AdsorptionMatchCache;

		// Token: 0x04001D50 RID: 7504
		private bool _AdsorptionMatchInited;

		// Token: 0x04001D51 RID: 7505
		private IEntityMatch _ActiveMatchCache;

		// Token: 0x04001D52 RID: 7506
		private bool _ActiveMatchInited;

		// Token: 0x04001D53 RID: 7507
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x04001D54 RID: 7508
		private bool _ChangeAdsorbateStateInited;
	}
}
