using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E7 RID: 1511
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowLooply : INpcStandbyShowMode
	{
		// Token: 0x06001ED6 RID: 7894 RVA: 0x00056F90 File Offset: 0x00055190
		[NullableContext(0)]
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

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00056FC8 File Offset: 0x000551C8
		[NullableContext(0)]
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

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00056FDB File Offset: 0x000551DB
		[NullableContext(0)]
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

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00056FF0 File Offset: 0x000551F0
		[NullableContext(0)]
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

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x00057056 File Offset: 0x00055256
		// (set) Token: 0x06001EDB RID: 7899 RVA: 0x00057081 File Offset: 0x00055281
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00057090 File Offset: 0x00055290
		// (set) Token: 0x06001EDD RID: 7901 RVA: 0x00057123 File Offset: 0x00055323
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().LookAtConfigs = value;
				this._LookAtConfigsInited = false;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00057138 File Offset: 0x00055338
		// (set) Token: 0x06001EDF RID: 7903 RVA: 0x0005715F File Offset: 0x0005535F
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00057170 File Offset: 0x00055370
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x000571D1 File Offset: 0x000553D1
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x000571E8 File Offset: 0x000553E8
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x00057222 File Offset: 0x00055422
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

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00057230 File Offset: 0x00055430
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x00057291 File Offset: 0x00055491
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x000572A8 File Offset: 0x000554A8
		// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x000572E2 File Offset: 0x000554E2
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

		// Token: 0x040015EA RID: 5610
		protected new INpcStandbyShowLooply FbInstance;

		// Token: 0x040015EB RID: 5611
		protected new INpcStandbyShowLooply_SetValue PocoInterface;

		// Token: 0x040015EC RID: 5612
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040015ED RID: 5613
		private bool _LookAtConfigsInited;

		// Token: 0x040015EE RID: 5614
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMontageId _RegisteredMontageIdCache;

		// Token: 0x040015EF RID: 5615
		private bool _RegisteredMontageIdInited;

		// Token: 0x040015F0 RID: 5616
		[Nullable(0)]
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x040015F1 RID: 5617
		private bool _IgnoreEntityCollisionInited;
	}
}
