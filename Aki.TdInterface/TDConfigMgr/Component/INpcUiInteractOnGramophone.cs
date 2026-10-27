using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058A RID: 1418
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnGramophone : INpcUiInteractType
	{
		// Token: 0x06001D44 RID: 7492 RVA: 0x00053398 File Offset: 0x00051598
		private INpcUiInteractOnGramophone_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcUiInteractOnGramophone 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcUiInteractOnGramophone_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcUiInteractOnGramophone_SetValue());
			}
			return result;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x000533D0 File Offset: 0x000515D0
		public static INpcUiInteractOnGramophone Create([Nullable(2)] INpcUiInteractOnGramophone instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcUiInteractOnGramophone
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x000533E3 File Offset: 0x000515E3
		public static INpcUiInteractOnGramophone CreateFromSetValue([Nullable(2)] INpcUiInteractOnGramophone_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcUiInteractOnGramophone
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000533F8 File Offset: 0x000515F8
		public new INpcUiInteractOnGramophone_SetValue ToSetValue()
		{
			return new INpcUiInteractOnGramophone_SetValue
			{
				Type = this.Type,
				EnterMontage = this.EnterMontage,
				StandByMontage = this.StandByMontage,
				SwitchMusicMontage = this.SwitchMusicMontage,
				ExitMontage = this.ExitMontage,
				EnterFlow = this.EnterFlow,
				FailedFlow = this.FailedFlow,
				SuccessFlow = this.SuccessFlow
			};
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x0005346A File Offset: 0x0005166A
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00053495 File Offset: 0x00051695
		public override ENpcUiInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000534A3 File Offset: 0x000516A3
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x000534CE File Offset: 0x000516CE
		public virtual string EnterMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EnterMontage;
			}
			set
			{
				this.GetOrCreatePoco().EnterMontage = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x000534DC File Offset: 0x000516DC
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00053507 File Offset: 0x00051707
		public virtual string StandByMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StandByMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.StandByMontage;
			}
			set
			{
				this.GetOrCreatePoco().StandByMontage = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00053515 File Offset: 0x00051715
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x00053540 File Offset: 0x00051740
		public virtual string SwitchMusicMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SwitchMusicMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SwitchMusicMontage;
			}
			set
			{
				this.GetOrCreatePoco().SwitchMusicMontage = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x0005354E File Offset: 0x0005174E
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x00053579 File Offset: 0x00051779
		public virtual string ExitMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitMontage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ExitMontage;
			}
			set
			{
				this.GetOrCreatePoco().ExitMontage = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00053588 File Offset: 0x00051788
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x000535E9 File Offset: 0x000517E9
		[Nullable(2)]
		public virtual PlayFlow EnterFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._EnterFlowInited)
				{
					return this._EnterFlowCache;
				}
				this._EnterFlowInited = true;
				if (this.FbInstance != null)
				{
					this._EnterFlowCache = PlayFlow.Create(this.FbInstance.EnterFlow);
				}
				else
				{
					INpcUiInteractOnGramophone_SetValue pocoInterface = this.PocoInterface;
					this._EnterFlowCache = ((pocoInterface != null) ? pocoInterface.EnterFlow : null);
				}
				return this._EnterFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EnterFlow = value;
				this._EnterFlowInited = false;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00053600 File Offset: 0x00051800
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00053661 File Offset: 0x00051861
		[Nullable(2)]
		public virtual PlayFlow FailedFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._FailedFlowInited)
				{
					return this._FailedFlowCache;
				}
				this._FailedFlowInited = true;
				if (this.FbInstance != null)
				{
					this._FailedFlowCache = PlayFlow.Create(this.FbInstance.FailedFlow);
				}
				else
				{
					INpcUiInteractOnGramophone_SetValue pocoInterface = this.PocoInterface;
					this._FailedFlowCache = ((pocoInterface != null) ? pocoInterface.FailedFlow : null);
				}
				return this._FailedFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FailedFlow = value;
				this._FailedFlowInited = false;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00053678 File Offset: 0x00051878
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x000536D9 File Offset: 0x000518D9
		[Nullable(2)]
		public virtual PlayFlow SuccessFlow
		{
			[NullableContext(2)]
			get
			{
				if (this._SuccessFlowInited)
				{
					return this._SuccessFlowCache;
				}
				this._SuccessFlowInited = true;
				if (this.FbInstance != null)
				{
					this._SuccessFlowCache = PlayFlow.Create(this.FbInstance.SuccessFlow);
				}
				else
				{
					INpcUiInteractOnGramophone_SetValue pocoInterface = this.PocoInterface;
					this._SuccessFlowCache = ((pocoInterface != null) ? pocoInterface.SuccessFlow : null);
				}
				return this._SuccessFlowCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SuccessFlow = value;
				this._SuccessFlowInited = false;
			}
		}

		// Token: 0x040014D2 RID: 5330
		[Nullable(2)]
		protected new INpcUiInteractOnGramophone FbInstance;

		// Token: 0x040014D3 RID: 5331
		[Nullable(2)]
		protected new INpcUiInteractOnGramophone_SetValue PocoInterface;

		// Token: 0x040014D4 RID: 5332
		private PlayFlow _EnterFlowCache;

		// Token: 0x040014D5 RID: 5333
		private bool _EnterFlowInited;

		// Token: 0x040014D6 RID: 5334
		private PlayFlow _FailedFlowCache;

		// Token: 0x040014D7 RID: 5335
		private bool _FailedFlowInited;

		// Token: 0x040014D8 RID: 5336
		private PlayFlow _SuccessFlowCache;

		// Token: 0x040014D9 RID: 5337
		private bool _SuccessFlowInited;
	}
}
