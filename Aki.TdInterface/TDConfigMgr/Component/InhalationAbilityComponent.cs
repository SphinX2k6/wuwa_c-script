using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000548 RID: 1352
	[NullableContext(1)]
	[Nullable(0)]
	public class InhalationAbilityComponent : IComponentBase
	{
		// Token: 0x06001BA4 RID: 7076 RVA: 0x0004FC04 File Offset: 0x0004DE04
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

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0004FC3C File Offset: 0x0004DE3C
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

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0004FC4F File Offset: 0x0004DE4F
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

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0004FC62 File Offset: 0x0004DE62
		public new InhalationAbilityComponent_SetValue ToSetValue()
		{
			return new InhalationAbilityComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InhalationConfigs = this.InhalationConfigs
			};
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0004FC90 File Offset: 0x0004DE90
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0004FCCA File Offset: 0x0004DECA
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

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0004FCD8 File Offset: 0x0004DED8
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0004FD02 File Offset: 0x0004DF02
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

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x0004FD10 File Offset: 0x0004DF10
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0004FDA3 File Offset: 0x0004DFA3
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

		// Token: 0x040013DD RID: 5085
		[Nullable(2)]
		protected new InhalationAbilityComponent FbInstance;

		// Token: 0x040013DE RID: 5086
		[Nullable(2)]
		protected new InhalationAbilityComponent_SetValue PocoInterface;

		// Token: 0x040013DF RID: 5087
		private List<IInhalationConfig> _InhalationConfigsCache;

		// Token: 0x040013E0 RID: 5088
		private bool _InhalationConfigsInited;
	}
}
