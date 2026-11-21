using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C2 RID: 706
	public class IConnectorRange : IConnectorLogicType
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x00031698 File Offset: 0x0002F898
		private IConnectorRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorRange_SetValue());
			}
			return result;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000316D0 File Offset: 0x0002F8D0
		public static IConnectorRange Create([Nullable(2)] IConnectorRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000316E3 File Offset: 0x0002F8E3
		public static IConnectorRange CreateFromSetValue([Nullable(2)] IConnectorRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000316F8 File Offset: 0x0002F8F8
		public new IConnectorRange_SetValue ToSetValue()
		{
			return new IConnectorRange_SetValue
			{
				Type = this.Type,
				EffectConfig = this.EffectConfig,
				ActiveState = this.ActiveState,
				EnterRange = this.EnterRange,
				LeaveRange = this.LeaveRange,
				MatchConditions = this.MatchConditions,
				KeepConditions = this.KeepConditions,
				ConnectedState = this.ConnectedState,
				DisconnectedState = this.DisconnectedState
			};
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00031776 File Offset: 0x0002F976
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x000317A1 File Offset: 0x0002F9A1
		public override EConnectorLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorLogicType.Range;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000317B0 File Offset: 0x0002F9B0
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00031811 File Offset: 0x0002FA11
		public override IConnectorEffectConfig EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EffectConfigCache = IConnectorEffectConfig.Create(this.FbInstance.EffectConfig);
				}
				else
				{
					IConnectorRange_SetValue pocoInterface = this.PocoInterface;
					this._EffectConfigCache = ((pocoInterface != null) ? pocoInterface.EffectConfig : null);
				}
				return this._EffectConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectConfig = value;
				this._EffectConfigInited = false;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00031826 File Offset: 0x0002FA26
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00031851 File Offset: 0x0002FA51
		public virtual string ActiveState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActiveState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActiveState;
			}
			set
			{
				this.GetOrCreatePoco().ActiveState = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0003185F File Offset: 0x0002FA5F
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0003188A File Offset: 0x0002FA8A
		public virtual int EnterRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EnterRange;
			}
			set
			{
				this.GetOrCreatePoco().EnterRange = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00031898 File Offset: 0x0002FA98
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x000318C3 File Offset: 0x0002FAC3
		public virtual int LeaveRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LeaveRange;
			}
			set
			{
				this.GetOrCreatePoco().LeaveRange = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000318D4 File Offset: 0x0002FAD4
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00031967 File Offset: 0x0002FB67
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDynamicEntityMatch> MatchConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._MatchConditionsInited)
				{
					return this._MatchConditionsCache;
				}
				this._MatchConditionsInited = true;
				if (this.FbInstance != null)
				{
					List<IDynamicEntityMatch> matchConditions = this.FbInstance.MatchConditions;
					if (matchConditions != null)
					{
						this._MatchConditionsCache = new List<IDynamicEntityMatch>(matchConditions.Count);
						for (int i = 0; i < matchConditions.Count; i++)
						{
							this._MatchConditionsCache.Add(IDynamicEntityMatch.Create(matchConditions[i]));
						}
					}
				}
				else
				{
					IConnectorRange_SetValue pocoInterface = this.PocoInterface;
					this._MatchConditionsCache = ((pocoInterface != null) ? pocoInterface.MatchConditions : null);
				}
				return this._MatchConditionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().MatchConditions = value;
				this._MatchConditionsInited = false;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0003197C File Offset: 0x0002FB7C
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00031A0F File Offset: 0x0002FC0F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._KeepConditionsInited)
				{
					return this._KeepConditionsCache;
				}
				this._KeepConditionsInited = true;
				if (this.FbInstance != null)
				{
					List<IDynamicEntityMatch> keepConditions = this.FbInstance.KeepConditions;
					if (keepConditions != null)
					{
						this._KeepConditionsCache = new List<IDynamicEntityMatch>(keepConditions.Count);
						for (int i = 0; i < keepConditions.Count; i++)
						{
							this._KeepConditionsCache.Add(IDynamicEntityMatch.Create(keepConditions[i]));
						}
					}
				}
				else
				{
					IConnectorRange_SetValue pocoInterface = this.PocoInterface;
					this._KeepConditionsCache = ((pocoInterface != null) ? pocoInterface.KeepConditions : null);
				}
				return this._KeepConditionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().KeepConditions = value;
				this._KeepConditionsInited = false;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00031A24 File Offset: 0x0002FC24
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00031A4F File Offset: 0x0002FC4F
		public virtual string ConnectedState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConnectedState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ConnectedState;
			}
			set
			{
				this.GetOrCreatePoco().ConnectedState = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00031A5D File Offset: 0x0002FC5D
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00031A88 File Offset: 0x0002FC88
		public virtual string DisconnectedState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisconnectedState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.DisconnectedState;
			}
			set
			{
				this.GetOrCreatePoco().DisconnectedState = value;
			}
		}

		// Token: 0x04000C20 RID: 3104
		[Nullable(2)]
		protected new IConnectorRange FbInstance;

		// Token: 0x04000C21 RID: 3105
		[Nullable(2)]
		protected new IConnectorRange_SetValue PocoInterface;

		// Token: 0x04000C22 RID: 3106
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000C23 RID: 3107
		private bool _EffectConfigInited;

		// Token: 0x04000C24 RID: 3108
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04000C25 RID: 3109
		private bool _MatchConditionsInited;

		// Token: 0x04000C26 RID: 3110
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04000C27 RID: 3111
		private bool _KeepConditionsInited;
	}
}
