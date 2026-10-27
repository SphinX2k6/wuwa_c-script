using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F8D RID: 3981
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlagChallengeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060058BA RID: 22714 RVA: 0x000D87F4 File Offset: 0x000D69F4
		private IFlagChallengeSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlagChallengeSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlagChallengeSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlagChallengeSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x000D882C File Offset: 0x000D6A2C
		public static IFlagChallengeSystemConfig Create([Nullable(2)] IFlagChallengeSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlagChallengeSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x000D883F File Offset: 0x000D6A3F
		public static IFlagChallengeSystemConfig CreateFromSetValue([Nullable(2)] IFlagChallengeSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlagChallengeSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x000D8852 File Offset: 0x000D6A52
		public new IFlagChallengeSystemConfig_SetValue ToSetValue()
		{
			return new IFlagChallengeSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x000D8871 File Offset: 0x000D6A71
		// (set) Token: 0x060058BF RID: 22719 RVA: 0x000D889C File Offset: 0x000D6A9C
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x060058C0 RID: 22720 RVA: 0x000D88AC File Offset: 0x000D6AAC
		// (set) Token: 0x060058C1 RID: 22721 RVA: 0x000D893F File Offset: 0x000D6B3F
		public virtual List<IFlagChallengeSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				if (this.FbInstance != null)
				{
					List<IFlagChallengeSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IFlagChallengeSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IFlagChallengeSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IFlagChallengeSystemConfig_SetValue pocoInterface = this.PocoInterface;
					this._VarsCache = ((pocoInterface != null) ? pocoInterface.Vars : null);
				}
				return this._VarsCache;
			}
			set
			{
				this.GetOrCreatePoco().Vars = value;
				this._VarsInited = false;
			}
		}

		// Token: 0x0400359C RID: 13724
		[Nullable(2)]
		protected new IFlagChallengeSystemConfig FbInstance;

		// Token: 0x0400359D RID: 13725
		[Nullable(2)]
		protected new IFlagChallengeSystemConfig_SetValue PocoInterface;

		// Token: 0x0400359E RID: 13726
		private List<IFlagChallengeSystemVar> _VarsCache;

		// Token: 0x0400359F RID: 13727
		private bool _VarsInited;
	}
}
