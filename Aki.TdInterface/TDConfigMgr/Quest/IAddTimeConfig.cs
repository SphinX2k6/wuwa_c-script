using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD0 RID: 4048
	public class IAddTimeConfig
	{
		// Token: 0x0600589E RID: 22686 RVA: 0x000D8CD4 File Offset: 0x000D6ED4
		private IAddTimeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddTimeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddTimeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddTimeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x000D8D0C File Offset: 0x000D6F0C
		public static IAddTimeConfig Create([Nullable(2)] IAddTimeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddTimeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x000D8D1F File Offset: 0x000D6F1F
		public static IAddTimeConfig CreateFromSetValue([Nullable(2)] IAddTimeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddTimeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x000D8D32 File Offset: 0x000D6F32
		public IAddTimeConfig_SetValue ToSetValue()
		{
			return new IAddTimeConfig_SetValue
			{
				MonsterConfig = this.MonsterConfig,
				StateConfig = this.StateConfig
			};
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x060058A2 RID: 22690 RVA: 0x000D8D54 File Offset: 0x000D6F54
		// (set) Token: 0x060058A3 RID: 22691 RVA: 0x000D8DB5 File Offset: 0x000D6FB5
		[Nullable(2)]
		public virtual IKillMonster MonsterConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._MonsterConfigInited)
				{
					return this._MonsterConfigCache;
				}
				this._MonsterConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MonsterConfigCache = IKillMonster.Create(this.FbInstance.MonsterConfig);
				}
				else
				{
					IAddTimeConfig_SetValue pocoInterface = this.PocoInterface;
					this._MonsterConfigCache = ((pocoInterface != null) ? pocoInterface.MonsterConfig : null);
				}
				return this._MonsterConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MonsterConfig = value;
				this._MonsterConfigInited = false;
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x060058A4 RID: 22692 RVA: 0x000D8DCC File Offset: 0x000D6FCC
		// (set) Token: 0x060058A5 RID: 22693 RVA: 0x000D8E5F File Offset: 0x000D705F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IAddTimeStateCondition> StateConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._StateConfigInited)
				{
					return this._StateConfigCache;
				}
				this._StateConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IAddTimeStateCondition> stateConfig = this.FbInstance.StateConfig;
					if (stateConfig != null)
					{
						this._StateConfigCache = new List<IAddTimeStateCondition>(stateConfig.Count);
						for (int i = 0; i < stateConfig.Count; i++)
						{
							this._StateConfigCache.Add(IAddTimeStateCondition.Create(stateConfig[i]));
						}
					}
				}
				else
				{
					IAddTimeConfig_SetValue pocoInterface = this.PocoInterface;
					this._StateConfigCache = ((pocoInterface != null) ? pocoInterface.StateConfig : null);
				}
				return this._StateConfigCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().StateConfig = value;
				this._StateConfigInited = false;
			}
		}

		// Token: 0x04003572 RID: 13682
		[Nullable(2)]
		protected IAddTimeConfig FbInstance;

		// Token: 0x04003573 RID: 13683
		[Nullable(2)]
		protected IAddTimeConfig_SetValue PocoInterface;

		// Token: 0x04003574 RID: 13684
		private IKillMonster _MonsterConfigCache;

		// Token: 0x04003575 RID: 13685
		private bool _MonsterConfigInited;

		// Token: 0x04003576 RID: 13686
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAddTimeStateCondition> _StateConfigCache;

		// Token: 0x04003577 RID: 13687
		private bool _StateConfigInited;
	}
}
