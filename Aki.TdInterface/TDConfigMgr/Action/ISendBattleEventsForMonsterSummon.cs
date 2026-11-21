using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200202B RID: 8235
	public class ISendBattleEventsForMonsterSummon : IExecBattleActionType
	{
		// Token: 0x0600AED1 RID: 44753 RVA: 0x0018A040 File Offset: 0x00188240
		private ISendBattleEventsForMonsterSummon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISendBattleEventsForMonsterSummon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISendBattleEventsForMonsterSummon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISendBattleEventsForMonsterSummon_SetValue());
			}
			return result;
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x0018A078 File Offset: 0x00188278
		public static ISendBattleEventsForMonsterSummon Create([Nullable(2)] ISendBattleEventsForMonsterSummon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummon
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x0018A08B File Offset: 0x0018828B
		public static ISendBattleEventsForMonsterSummon CreateFromSetValue([Nullable(2)] ISendBattleEventsForMonsterSummon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummon
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x0018A09E File Offset: 0x0018829E
		public new ISendBattleEventsForMonsterSummon_SetValue ToSetValue()
		{
			return new ISendBattleEventsForMonsterSummon_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600AED5 RID: 44757 RVA: 0x0018A0BD File Offset: 0x001882BD
		// (set) Token: 0x0600AED6 RID: 44758 RVA: 0x0018A0E8 File Offset: 0x001882E8
		public override EExecBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x0018A0F8 File Offset: 0x001882F8
		// (set) Token: 0x0600AED8 RID: 44760 RVA: 0x0018A18B File Offset: 0x0018838B
		public virtual List<ISendBattleEventsForMonsterSummonConfig> Configs
		{
			get
			{
				if (this._ConfigsInited)
				{
					return this._ConfigsCache;
				}
				this._ConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ISendBattleEventsForMonsterSummonConfig> configs = this.FbInstance.Configs;
					if (configs != null)
					{
						this._ConfigsCache = new List<ISendBattleEventsForMonsterSummonConfig>(configs.Count);
						for (int i = 0; i < configs.Count; i++)
						{
							this._ConfigsCache.Add(ISendBattleEventsForMonsterSummonConfig.Create(configs[i]));
						}
					}
				}
				else
				{
					ISendBattleEventsForMonsterSummon_SetValue pocoInterface = this.PocoInterface;
					this._ConfigsCache = ((pocoInterface != null) ? pocoInterface.Configs : null);
				}
				return this._ConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().Configs = value;
				this._ConfigsInited = false;
			}
		}

		// Token: 0x04006829 RID: 26665
		[Nullable(2)]
		protected new ISendBattleEventsForMonsterSummon FbInstance;

		// Token: 0x0400682A RID: 26666
		[Nullable(2)]
		protected new ISendBattleEventsForMonsterSummon_SetValue PocoInterface;

		// Token: 0x0400682B RID: 26667
		private List<ISendBattleEventsForMonsterSummonConfig> _ConfigsCache;

		// Token: 0x0400682C RID: 26668
		private bool _ConfigsInited;
	}
}
