using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010B7 RID: 4279
	public class IFlagChallengeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005E8C RID: 24204 RVA: 0x000E521C File Offset: 0x000E341C
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

		// Token: 0x06005E8D RID: 24205 RVA: 0x000E5254 File Offset: 0x000E3454
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

		// Token: 0x06005E8E RID: 24206 RVA: 0x000E5267 File Offset: 0x000E3467
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

		// Token: 0x06005E8F RID: 24207 RVA: 0x000E527A File Offset: 0x000E347A
		public new IFlagChallengeSystemConfig_SetValue ToSetValue()
		{
			return new IFlagChallengeSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06005E90 RID: 24208 RVA: 0x000E5299 File Offset: 0x000E3499
		// (set) Token: 0x06005E91 RID: 24209 RVA: 0x000E52C4 File Offset: 0x000E34C4
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

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06005E92 RID: 24210 RVA: 0x000E52D4 File Offset: 0x000E34D4
		// (set) Token: 0x06005E93 RID: 24211 RVA: 0x000E5367 File Offset: 0x000E3567
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

		// Token: 0x040038CC RID: 14540
		[Nullable(2)]
		protected new IFlagChallengeSystemConfig FbInstance;

		// Token: 0x040038CD RID: 14541
		[Nullable(2)]
		protected new IFlagChallengeSystemConfig_SetValue PocoInterface;

		// Token: 0x040038CE RID: 14542
		private List<IFlagChallengeSystemVar> _VarsCache;

		// Token: 0x040038CF RID: 14543
		private bool _VarsInited;
	}
}
