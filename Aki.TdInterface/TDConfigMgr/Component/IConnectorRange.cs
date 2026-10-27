using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027F RID: 639
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorRange : IConnectorLogicType
	{
		// Token: 0x06000BC3 RID: 3011 RVA: 0x0002E9A8 File Offset: 0x0002CBA8
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

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
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

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002E9F3 File Offset: 0x0002CBF3
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

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0002EA08 File Offset: 0x0002CC08
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0002EA86 File Offset: 0x0002CC86
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x0002EAB1 File Offset: 0x0002CCB1
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0002EAC0 File Offset: 0x0002CCC0
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x0002EB21 File Offset: 0x0002CD21
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

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0002EB36 File Offset: 0x0002CD36
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x0002EB61 File Offset: 0x0002CD61
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0002EB6F File Offset: 0x0002CD6F
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0002EB9A File Offset: 0x0002CD9A
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

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0002EBD3 File Offset: 0x0002CDD3
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

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0002EBE4 File Offset: 0x0002CDE4
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x0002EC77 File Offset: 0x0002CE77
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDynamicEntityMatch> MatchConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().MatchConditions = value;
				this._MatchConditionsInited = false;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0002EC8C File Offset: 0x0002CE8C
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0002ED1F File Offset: 0x0002CF1F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IDynamicEntityMatch> KeepConditions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().KeepConditions = value;
				this._KeepConditionsInited = false;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0002ED34 File Offset: 0x0002CF34
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0002ED5F File Offset: 0x0002CF5F
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

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0002ED6D File Offset: 0x0002CF6D
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x0002ED98 File Offset: 0x0002CF98
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

		// Token: 0x04000B3F RID: 2879
		[Nullable(2)]
		protected new IConnectorRange FbInstance;

		// Token: 0x04000B40 RID: 2880
		[Nullable(2)]
		protected new IConnectorRange_SetValue PocoInterface;

		// Token: 0x04000B41 RID: 2881
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000B42 RID: 2882
		private bool _EffectConfigInited;

		// Token: 0x04000B43 RID: 2883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04000B44 RID: 2884
		private bool _MatchConditionsInited;

		// Token: 0x04000B45 RID: 2885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04000B46 RID: 2886
		private bool _KeepConditionsInited;
	}
}
