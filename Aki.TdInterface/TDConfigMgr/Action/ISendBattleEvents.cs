using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF6 RID: 7670
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendBattleEvents : IExecBattleActionType
	{
		// Token: 0x0600A41F RID: 42015 RVA: 0x001744C8 File Offset: 0x001726C8
		private ISendBattleEvents_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISendBattleEvents 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISendBattleEvents_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISendBattleEvents_SetValue());
			}
			return result;
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x00174500 File Offset: 0x00172700
		public static ISendBattleEvents Create([Nullable(2)] ISendBattleEvents instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEvents
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x00174513 File Offset: 0x00172713
		public static ISendBattleEvents CreateFromSetValue([Nullable(2)] ISendBattleEvents_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISendBattleEvents
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x00174526 File Offset: 0x00172726
		public new ISendBattleEvents_SetValue ToSetValue()
		{
			return new ISendBattleEvents_SetValue
			{
				Type = this.Type,
				Configs = this.Configs
			};
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600A423 RID: 42019 RVA: 0x00174545 File Offset: 0x00172745
		// (set) Token: 0x0600A424 RID: 42020 RVA: 0x00174570 File Offset: 0x00172770
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

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600A425 RID: 42021 RVA: 0x00174580 File Offset: 0x00172780
		// (set) Token: 0x0600A426 RID: 42022 RVA: 0x00174613 File Offset: 0x00172813
		public virtual List<ISetBattleTagConfig> Configs
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
					List<ISetBattleTagConfig> configs = this.FbInstance.Configs;
					if (configs != null)
					{
						this._ConfigsCache = new List<ISetBattleTagConfig>(configs.Count);
						for (int i = 0; i < configs.Count; i++)
						{
							this._ConfigsCache.Add(ISetBattleTagConfig.Create(configs[i]));
						}
					}
				}
				else
				{
					ISendBattleEvents_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400624C RID: 25164
		[Nullable(2)]
		protected new ISendBattleEvents FbInstance;

		// Token: 0x0400624D RID: 25165
		[Nullable(2)]
		protected new ISendBattleEvents_SetValue PocoInterface;

		// Token: 0x0400624E RID: 25166
		private List<ISetBattleTagConfig> _ConfigsCache;

		// Token: 0x0400624F RID: 25167
		private bool _ConfigsInited;
	}
}
