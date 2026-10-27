using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057C RID: 1404
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowFinitelyInfo
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x00051E6C File Offset: 0x0005006C
		[NullableContext(1)]
		private INpcStandbyShowFinitelyInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcStandbyShowFinitelyInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcStandbyShowFinitelyInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcStandbyShowFinitelyInfo_SetValue());
			}
			return result;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00051EA4 File Offset: 0x000500A4
		[NullableContext(1)]
		public static INpcStandbyShowFinitelyInfo Create([Nullable(2)] INpcStandbyShowFinitelyInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitelyInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00051EB7 File Offset: 0x000500B7
		[NullableContext(1)]
		public static INpcStandbyShowFinitelyInfo CreateFromSetValue([Nullable(2)] INpcStandbyShowFinitelyInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitelyInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00051ECC File Offset: 0x000500CC
		[NullableContext(1)]
		public INpcStandbyShowFinitelyInfo_SetValue ToSetValue()
		{
			return new INpcStandbyShowFinitelyInfo_SetValue
			{
				Montage = this.Montage,
				RegisteredMontageId = this.RegisteredMontageId,
				FaceExpressionId = this.FaceExpressionId,
				Time = this.Time,
				IgnoreEntityCollision = this.IgnoreEntityCollision
			};
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00051F1A File Offset: 0x0005011A
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00051F41 File Offset: 0x00050141
		public virtual string Montage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Montage;
				}
				INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Montage;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00051F50 File Offset: 0x00050150
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00051FB1 File Offset: 0x000501B1
		public virtual IMontageId RegisteredMontageId
		{
			get
			{
				if (this._RegisteredMontageIdInited)
				{
					return this._RegisteredMontageIdCache;
				}
				this._RegisteredMontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._RegisteredMontageIdCache = IMontageId.Create(this.FbInstance.RegisteredMontageId);
				}
				else
				{
					INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
					this._RegisteredMontageIdCache = ((pocoInterface != null) ? pocoInterface.RegisteredMontageId : null);
				}
				return this._RegisteredMontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().RegisteredMontageId = value;
				this._RegisteredMontageIdInited = false;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x00051FC8 File Offset: 0x000501C8
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00052002 File Offset: 0x00050202
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpressionId = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00052010 File Offset: 0x00050210
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0005203B File Offset: 0x0005023B
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0005204C File Offset: 0x0005024C
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x000520AD File Offset: 0x000502AD
		public virtual IIgnoreEntityIdsCollision IgnoreEntityCollision
		{
			get
			{
				if (this._IgnoreEntityCollisionInited)
				{
					return this._IgnoreEntityCollisionCache;
				}
				this._IgnoreEntityCollisionInited = true;
				if (this.FbInstance != null)
				{
					this._IgnoreEntityCollisionCache = IIgnoreEntityIdsCollision.Create(this.FbInstance.IgnoreEntityCollision);
				}
				else
				{
					INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
					this._IgnoreEntityCollisionCache = ((pocoInterface != null) ? pocoInterface.IgnoreEntityCollision : null);
				}
				return this._IgnoreEntityCollisionCache;
			}
			set
			{
				this.GetOrCreatePoco().IgnoreEntityCollision = value;
				this._IgnoreEntityCollisionInited = false;
			}
		}

		// Token: 0x04001471 RID: 5233
		protected INpcStandbyShowFinitelyInfo FbInstance;

		// Token: 0x04001472 RID: 5234
		protected INpcStandbyShowFinitelyInfo_SetValue PocoInterface;

		// Token: 0x04001473 RID: 5235
		[Nullable(1)]
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x04001474 RID: 5236
		private bool _RegisteredMontageIdInited;

		// Token: 0x04001475 RID: 5237
		[Nullable(1)]
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x04001476 RID: 5238
		private bool _IgnoreEntityCollisionInited;
	}
}
