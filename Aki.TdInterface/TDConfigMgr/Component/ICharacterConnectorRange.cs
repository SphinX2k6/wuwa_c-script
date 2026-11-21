using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000258 RID: 600
	public class ICharacterConnectorRange : ICharacterConnectorLogicType
	{
		// Token: 0x06000A40 RID: 2624 RVA: 0x0002B64C File Offset: 0x0002984C
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

		// Token: 0x06000A41 RID: 2625 RVA: 0x0002B684 File Offset: 0x00029884
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

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002B697 File Offset: 0x00029897
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

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002B6AC File Offset: 0x000298AC
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0002B712 File Offset: 0x00029912
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x0002B73D File Offset: 0x0002993D
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0002B74C File Offset: 0x0002994C
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0002B7AD File Offset: 0x000299AD
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0002B7C2 File Offset: 0x000299C2
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0002B7ED File Offset: 0x000299ED
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0002B7FB File Offset: 0x000299FB
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x0002B826 File Offset: 0x00029A26
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0002B834 File Offset: 0x00029A34
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x0002B85B File Offset: 0x00029A5B
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0002B86C File Offset: 0x00029A6C
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x0002B8FF File Offset: 0x00029AFF
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
					ICharacterConnectorRange_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0002B914 File Offset: 0x00029B14
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0002B9A7 File Offset: 0x00029BA7
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
					ICharacterConnectorRange_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000A8C RID: 2700
		[Nullable(2)]
		protected new ICharacterConnectorRange FbInstance;

		// Token: 0x04000A8D RID: 2701
		[Nullable(2)]
		protected new ICharacterConnectorRange_SetValue PocoInterface;

		// Token: 0x04000A8E RID: 2702
		private IConnectorEffectConfig _EffectConfigCache;

		// Token: 0x04000A8F RID: 2703
		private bool _EffectConfigInited;

		// Token: 0x04000A90 RID: 2704
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _MatchConditionsCache;

		// Token: 0x04000A91 RID: 2705
		private bool _MatchConditionsInited;

		// Token: 0x04000A92 RID: 2706
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IDynamicEntityMatch> _KeepConditionsCache;

		// Token: 0x04000A93 RID: 2707
		private bool _KeepConditionsInited;
	}
}
