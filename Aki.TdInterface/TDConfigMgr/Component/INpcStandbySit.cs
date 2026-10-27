using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000582 RID: 1410
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbySit : INpcStandbyShowMode
	{
		// Token: 0x06001CEE RID: 7406 RVA: 0x000525B4 File Offset: 0x000507B4
		[NullableContext(1)]
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

		// Token: 0x06001CEF RID: 7407 RVA: 0x000525EC File Offset: 0x000507EC
		[NullableContext(1)]
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

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000525FF File Offset: 0x000507FF
		[NullableContext(1)]
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

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00052614 File Offset: 0x00050814
		[NullableContext(1)]
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

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0005266E File Offset: 0x0005086E
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x00052699 File Offset: 0x00050899
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

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x000526A8 File Offset: 0x000508A8
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0005273B File Offset: 0x0005093B
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
					INpcStandbySit_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00052750 File Offset: 0x00050950
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x00052777 File Offset: 0x00050977
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

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00052788 File Offset: 0x00050988
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x000527E9 File Offset: 0x000509E9
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

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00052800 File Offset: 0x00050A00
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0005283A File Offset: 0x00050A3A
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

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00052848 File Offset: 0x00050A48
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00052873 File Offset: 0x00050A73
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

		// Token: 0x04001491 RID: 5265
		protected new INpcStandbySit FbInstance;

		// Token: 0x04001492 RID: 5266
		protected new INpcStandbySit_SetValue PocoInterface;

		// Token: 0x04001493 RID: 5267
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x04001494 RID: 5268
		private bool _LookAtConfigsInited;

		// Token: 0x04001495 RID: 5269
		[Nullable(1)]
		private Aki.TDConfigMgr.Action.IMontageId _RegisteredMontageIdCache;

		// Token: 0x04001496 RID: 5270
		private bool _RegisteredMontageIdInited;
	}
}
