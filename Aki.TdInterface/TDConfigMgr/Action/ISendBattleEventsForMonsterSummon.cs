using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF8 RID: 7672
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendBattleEventsForMonsterSummon : IExecBattleActionType
	{
		// Token: 0x0600A429 RID: 42025 RVA: 0x00174638 File Offset: 0x00172838
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

		// Token: 0x0600A42A RID: 42026 RVA: 0x00174670 File Offset: 0x00172870
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

		// Token: 0x0600A42B RID: 42027 RVA: 0x00174683 File Offset: 0x00172883
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

		// Token: 0x0600A42C RID: 42028 RVA: 0x00174696 File Offset: 0x00172896
		public new ISendBattleEventsForMonsterSummon_SetValue ToSetValue()
		{
			return new ISendBattleEventsForMonsterSummon_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600A42D RID: 42029 RVA: 0x001746B5 File Offset: 0x001728B5
		// (set) Token: 0x0600A42E RID: 42030 RVA: 0x001746E0 File Offset: 0x001728E0
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

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600A42F RID: 42031 RVA: 0x001746F0 File Offset: 0x001728F0
		// (set) Token: 0x0600A430 RID: 42032 RVA: 0x00174783 File Offset: 0x00172983
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

		// Token: 0x04006252 RID: 25170
		[Nullable(2)]
		protected new ISendBattleEventsForMonsterSummon FbInstance;

		// Token: 0x04006253 RID: 25171
		[Nullable(2)]
		protected new ISendBattleEventsForMonsterSummon_SetValue PocoInterface;

		// Token: 0x04006254 RID: 25172
		private List<ISendBattleEventsForMonsterSummonConfig> _ConfigsCache;

		// Token: 0x04006255 RID: 25173
		private bool _ConfigsInited;
	}
}
