using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200143A RID: 5178
	[NullableContext(2)]
	[Nullable(0)]
	public class IAddTimeConfig
	{
		// Token: 0x060075B5 RID: 30133 RVA: 0x001191B6 File Offset: 0x001173B6
		[NullableContext(1)]
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

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x060075B6 RID: 30134 RVA: 0x001191D5 File Offset: 0x001173D5
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

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x060075B7 RID: 30135 RVA: 0x0011920C File Offset: 0x0011740C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IAddTimeStateCondition> StateConfig
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04004434 RID: 17460
		private IAddTimeConfig Instance;

		// Token: 0x04004435 RID: 17461
		private IKillMonster _MonsterConfigCache;

		// Token: 0x04004436 RID: 17462
		private bool _MonsterConfigInited;

		// Token: 0x04004437 RID: 17463
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAddTimeStateCondition> _StateConfigCache;

		// Token: 0x04004438 RID: 17464
		private bool _StateConfigInited;
	}
}
