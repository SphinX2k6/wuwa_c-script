using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005AF RID: 1455
	public class InhalationAbilityComponent : IComponentBase
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x000549C0 File Offset: 0x00052BC0
		private InhalationAbilityComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("InhalationAbilityComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			InhalationAbilityComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new InhalationAbilityComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x000549F8 File Offset: 0x00052BF8
		public static InhalationAbilityComponent Create([Nullable(2)] InhalationAbilityComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InhalationAbilityComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00054A0B File Offset: 0x00052C0B
		public static InhalationAbilityComponent CreateFromSetValue([Nullable(2)] InhalationAbilityComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new InhalationAbilityComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00054A1E File Offset: 0x00052C1E
		public new InhalationAbilityComponent_SetValue ToSetValue()
		{
			return new InhalationAbilityComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InhalationConfigs = this.InhalationConfigs
			};
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00054A4C File Offset: 0x00052C4C
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00054A86 File Offset: 0x00052C86
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				InhalationAbilityComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00054A94 File Offset: 0x00052C94
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x00054ABE File Offset: 0x00052CBE
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00054ACC File Offset: 0x00052CCC
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x00054B5F File Offset: 0x00052D5F
		public virtual List<IInhalationConfig> InhalationConfigs
		{
			get
			{
				if (this._InhalationConfigsInited)
				{
					return this._InhalationConfigsCache;
				}
				this._InhalationConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IInhalationConfig> inhalationConfigs = this.FbInstance.InhalationConfigs;
					if (inhalationConfigs != null)
					{
						this._InhalationConfigsCache = new List<IInhalationConfig>(inhalationConfigs.Count);
						for (int i = 0; i < inhalationConfigs.Count; i++)
						{
							this._InhalationConfigsCache.Add(IInhalationConfig.Create(inhalationConfigs[i]));
						}
					}
				}
				else
				{
					InhalationAbilityComponent_SetValue pocoInterface = this.PocoInterface;
					this._InhalationConfigsCache = ((pocoInterface != null) ? pocoInterface.InhalationConfigs : null);
				}
				return this._InhalationConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().InhalationConfigs = value;
				this._InhalationConfigsInited = false;
			}
		}

		// Token: 0x04001547 RID: 5447
		[Nullable(2)]
		protected new InhalationAbilityComponent FbInstance;

		// Token: 0x04001548 RID: 5448
		[Nullable(2)]
		protected new InhalationAbilityComponent_SetValue PocoInterface;

		// Token: 0x04001549 RID: 5449
		private List<IInhalationConfig> _InhalationConfigsCache;

		// Token: 0x0400154A RID: 5450
		private bool _InhalationConfigsInited;
	}
}
