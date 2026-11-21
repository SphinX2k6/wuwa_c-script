using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001592 RID: 5522
	[NullableContext(2)]
	[Nullable(0)]
	public class IAddTimeConfig
	{
		// Token: 0x06007C7A RID: 31866 RVA: 0x00127C02 File Offset: 0x00125E02
		[NullableContext(0)]
		public static IAddTimeConfig Create(IAddTimeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddTimeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x00127C21 File Offset: 0x00125E21
		public virtual IKillMonster MonsterConfig
		{
			get
			{
				if (this._MonsterConfigInited)
				{
					return this._MonsterConfigCache;
				}
				this._MonsterConfigInited = true;
				this._MonsterConfigCache = IKillMonster.Create(this.Instance.MonsterConfig);
				return this._MonsterConfigCache;
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06007C7C RID: 31868 RVA: 0x00127C58 File Offset: 0x00125E58
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int stateConfigLength = this.Instance.StateConfigLength;
				this._StateConfigCache = new List<IAddTimeStateCondition>(stateConfigLength);
				for (int i = 0; i < stateConfigLength; i++)
				{
					this._StateConfigCache.Add(IAddTimeStateCondition.Create(this.Instance.StateConfig(i)));
				}
				return this._StateConfigCache;
			}
		}

		// Token: 0x040047C8 RID: 18376
		private IAddTimeConfig Instance;

		// Token: 0x040047C9 RID: 18377
		private IKillMonster _MonsterConfigCache;

		// Token: 0x040047CA RID: 18378
		private bool _MonsterConfigInited;

		// Token: 0x040047CB RID: 18379
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAddTimeStateCondition> _StateConfigCache;

		// Token: 0x040047CC RID: 18380
		private bool _StateConfigInited;
	}
}
