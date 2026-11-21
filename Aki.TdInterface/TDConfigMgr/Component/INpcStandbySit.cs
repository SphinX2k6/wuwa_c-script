using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005EB RID: 1515
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbySit : INpcStandbyShowMode
	{
		// Token: 0x06001EF4 RID: 7924 RVA: 0x00057470 File Offset: 0x00055670
		[NullableContext(0)]
		private INpcStandbySit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcStandbySit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcStandbySit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcStandbySit_SetValue());
			}
			return result;
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000574A8 File Offset: 0x000556A8
		[NullableContext(0)]
		public static INpcStandbySit Create([Nullable(2)] INpcStandbySit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbySit
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000574BB File Offset: 0x000556BB
		[NullableContext(0)]
		public static INpcStandbySit CreateFromSetValue([Nullable(2)] INpcStandbySit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcStandbySit
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000574D0 File Offset: 0x000556D0
		[NullableContext(0)]
		public new INpcStandbySit_SetValue ToSetValue()
		{
			return new INpcStandbySit_SetValue
			{
				Type = this.Type,
				LookAtConfigs = this.LookAtConfigs,
				Montage = this.Montage,
				RegisteredMontageId = this.RegisteredMontageId,
				FaceExpressionId = this.FaceExpressionId,
				PosEntityId = this.PosEntityId
			};
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0005752A File Offset: 0x0005572A
		// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x00057555 File Offset: 0x00055755
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

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00057564 File Offset: 0x00055764
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x000575F7 File Offset: 0x000557F7
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
					INpcStandbySit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0005760C File Offset: 0x0005580C
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x00057633 File Offset: 0x00055833
		public virtual string Montage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Montage;
				}
				INpcStandbySit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00057644 File Offset: 0x00055844
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x000576A5 File Offset: 0x000558A5
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
					INpcStandbySit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x000576BC File Offset: 0x000558BC
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x000576F6 File Offset: 0x000558F6
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				INpcStandbySit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x00057704 File Offset: 0x00055904
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x0005772F File Offset: 0x0005592F
		public virtual int PosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PosEntityId = value;
			}
		}

		// Token: 0x040015FF RID: 5631
		protected new INpcStandbySit FbInstance;

		// Token: 0x04001600 RID: 5632
		protected new INpcStandbySit_SetValue PocoInterface;

		// Token: 0x04001601 RID: 5633
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x04001602 RID: 5634
		private bool _LookAtConfigsInited;

		// Token: 0x04001603 RID: 5635
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMontageId _RegisteredMontageIdCache;

		// Token: 0x04001604 RID: 5636
		private bool _RegisteredMontageIdInited;
	}
}
