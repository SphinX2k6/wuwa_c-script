using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057E RID: 1406
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowLooply : INpcStandbyShowMode
	{
		// Token: 0x06001CD0 RID: 7376 RVA: 0x000520D4 File Offset: 0x000502D4
		[NullableContext(1)]
		private INpcStandbyShowLooply_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcStandbyShowLooply 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcStandbyShowLooply_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcStandbyShowLooply_SetValue());
			}
			return result;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0005210C File Offset: 0x0005030C
		[NullableContext(1)]
		public static INpcStandbyShowLooply Create([Nullable(2)] INpcStandbyShowLooply instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowLooply
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0005211F File Offset: 0x0005031F
		[NullableContext(1)]
		public static INpcStandbyShowLooply CreateFromSetValue([Nullable(2)] INpcStandbyShowLooply_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcStandbyShowLooply
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00052134 File Offset: 0x00050334
		[NullableContext(1)]
		public new INpcStandbyShowLooply_SetValue ToSetValue()
		{
			return new INpcStandbyShowLooply_SetValue
			{
				Type = this.Type,
				LookAtConfigs = this.LookAtConfigs,
				Montage = this.Montage,
				RegisteredMontageId = this.RegisteredMontageId,
				FaceExpressionId = this.FaceExpressionId,
				IgnoreEntityCollision = this.IgnoreEntityCollision,
				SetFadeInTimeToZero = this.SetFadeInTimeToZero
			};
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0005219A File Offset: 0x0005039A
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000521C5 File Offset: 0x000503C5
		public override ENpcStandbyShowMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcStandbyShowMode.Finite;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000521D4 File Offset: 0x000503D4
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00052267 File Offset: 0x00050467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.INpcLookAtConfig> lookAtConfigs = this.FbInstance.LookAtConfigs;
					if (lookAtConfigs != null)
					{
						this._LookAtConfigsCache = new List<Aki.TDConfigMgr.Action.INpcLookAtConfig>(lookAtConfigs.Count);
						for (int i = 0; i < lookAtConfigs.Count; i++)
						{
							this._LookAtConfigsCache.Add(Aki.TDConfigMgr.Action.INpcLookAtConfig.Create(lookAtConfigs[i]));
						}
					}
				}
				else
				{
					INpcStandbyShowLooply_SetValue pocoInterface = this.PocoInterface;
					this._LookAtConfigsCache = ((pocoInterface != null) ? pocoInterface.LookAtConfigs : null);
				}
				return this._LookAtConfigsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().LookAtConfigs = value;
				this._LookAtConfigsInited = false;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0005227C File Offset: 0x0005047C
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x000522A3 File Offset: 0x000504A3
		public virtual string Montage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Montage;
				}
				INpcStandbyShowLooply_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000522B4 File Offset: 0x000504B4
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x00052315 File Offset: 0x00050515
		public virtual Aki.TDConfigMgr.Action.IMontageId RegisteredMontageId
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
					this._RegisteredMontageIdCache = Aki.TDConfigMgr.Action.IMontageId.Create(this.FbInstance.RegisteredMontageId);
				}
				else
				{
					INpcStandbyShowLooply_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0005232C File Offset: 0x0005052C
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00052366 File Offset: 0x00050566
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				INpcStandbyShowLooply_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00052374 File Offset: 0x00050574
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x000523D5 File Offset: 0x000505D5
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
					INpcStandbyShowLooply_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000523EC File Offset: 0x000505EC
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00052426 File Offset: 0x00050626
		public virtual bool? SetFadeInTimeToZero
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetFadeInTimeToZero;
				}
				INpcStandbyShowLooply_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SetFadeInTimeToZero;
			}
			set
			{
				this.GetOrCreatePoco().SetFadeInTimeToZero = value;
			}
		}

		// Token: 0x0400147C RID: 5244
		protected new INpcStandbyShowLooply FbInstance;

		// Token: 0x0400147D RID: 5245
		protected new INpcStandbyShowLooply_SetValue PocoInterface;

		// Token: 0x0400147E RID: 5246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x0400147F RID: 5247
		private bool _LookAtConfigsInited;

		// Token: 0x04001480 RID: 5248
		[Nullable(1)]
		private Aki.TDConfigMgr.Action.IMontageId _RegisteredMontageIdCache;

		// Token: 0x04001481 RID: 5249
		private bool _RegisteredMontageIdInited;

		// Token: 0x04001482 RID: 5250
		[Nullable(1)]
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x04001483 RID: 5251
		private bool _IgnoreEntityCollisionInited;
	}
}
