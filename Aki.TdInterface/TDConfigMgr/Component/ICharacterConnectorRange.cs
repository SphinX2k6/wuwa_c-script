using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000231 RID: 561
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterConnectorRange : ICharacterConnectorLogicType
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x00029E8C File Offset: 0x0002808C
		private ICharacterConnectorRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterConnectorRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterConnectorRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterConnectorRange_SetValue());
			}
			return result;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00029EC4 File Offset: 0x000280C4
		public static ICharacterConnectorRange Create([Nullable(2)] ICharacterConnectorRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterConnectorRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00029ED7 File Offset: 0x000280D7
		public static ICharacterConnectorRange CreateFromSetValue([Nullable(2)] ICharacterConnectorRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterConnectorRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00029EEC File Offset: 0x000280EC
		public new ICharacterConnectorRange_SetValue ToSetValue()
		{
			return new ICharacterConnectorRange_SetValue
			{
				Type = this.Type,
				EffectConfig = this.EffectConfig,
				EnterRange = this.EnterRange,
				LeaveRange = this.LeaveRange,
				TagConditions = this.TagConditions,
				MatchConditions = this.MatchConditions,
				KeepConditions = this.KeepConditions
			};
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00029F52 File Offset: 0x00028152
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x00029F7D File Offset: 0x0002817D
		public override ECharacterConnectorLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECharacterConnectorLogicType.Range;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00029F8C File Offset: 0x0002818C
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00029FED File Offset: 0x000281ED
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
					ICharacterConnectorRange_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002A002 File Offset: 0x00028202
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x0002A02D File Offset: 0x0002822D
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002A03B File Offset: 0x0002823B
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0002A066 File Offset: 0x00028266
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0002A074 File Offset: 0x00028274
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x0002A09B File Offset: 0x0002829B
		[Nullable(2)]
		public virtual List<int> TagConditions
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagConditions;
				}
				ICharacterConnectorRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TagConditions;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TagConditions = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002A0AC File Offset: 0x000282AC
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x0002A13F File Offset: 0x0002833F
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
					ICharacterConnectorRange_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0002A154 File Offset: 0x00028354
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x0002A1E7 File Offset: 0x000283E7
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
					ICharacterConnectorRange_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000A02 RID: 2562
		[Nullable(2)]
		protected new ICharacterConnectorRange FbInstance;

		// Token: 0x04000A03 RID: 2563
		[Nullable(2)]
		protected new ICharacterConnectorRange_SetValue PocoInterface;

		// Token: 0x04000A04 RID: 2564
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000A05 RID: 2565
		private bool _EffectConfigInited;

		// Token: 0x04000A06 RID: 2566
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04000A07 RID: 2567
		private bool _MatchConditionsInited;

		// Token: 0x04000A08 RID: 2568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04000A09 RID: 2569
		private bool _KeepConditionsInited;
	}
}
