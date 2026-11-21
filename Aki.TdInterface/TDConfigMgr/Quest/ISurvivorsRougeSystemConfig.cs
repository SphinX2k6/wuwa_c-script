using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001292 RID: 4754
	public class ISurvivorsRougeSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006B09 RID: 27401 RVA: 0x000FFA5C File Offset: 0x000FDC5C
		private ISurvivorsRougeSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x000FFA94 File Offset: 0x000FDC94
		public static ISurvivorsRougeSystemConfig Create([Nullable(2)] ISurvivorsRougeSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x000FFAA7 File Offset: 0x000FDCA7
		public static ISurvivorsRougeSystemConfig CreateFromSetValue([Nullable(2)] ISurvivorsRougeSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x000FFABA File Offset: 0x000FDCBA
		public new ISurvivorsRougeSystemConfig_SetValue ToSetValue()
		{
			return new ISurvivorsRougeSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06006B0D RID: 27405 RVA: 0x000FFAD9 File Offset: 0x000FDCD9
		// (set) Token: 0x06006B0E RID: 27406 RVA: 0x000FFB04 File Offset: 0x000FDD04
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

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x000FFB14 File Offset: 0x000FDD14
		// (set) Token: 0x06006B10 RID: 27408 RVA: 0x000FFBA7 File Offset: 0x000FDDA7
		public virtual List<ISurvivorsRougeSystemVar> Vars
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
					List<ISurvivorsRougeSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<ISurvivorsRougeSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(ISurvivorsRougeSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					ISurvivorsRougeSystemConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003FED RID: 16365
		[Nullable(2)]
		protected new ISurvivorsRougeSystemConfig FbInstance;

		// Token: 0x04003FEE RID: 16366
		[Nullable(2)]
		protected new ISurvivorsRougeSystemConfig_SetValue PocoInterface;

		// Token: 0x04003FEF RID: 16367
		private List<ISurvivorsRougeSystemVar> _VarsCache;

		// Token: 0x04003FF0 RID: 16368
		private bool _VarsInited;
	}
}
