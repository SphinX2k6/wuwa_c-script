using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB6 RID: 3510
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicSpawnMonsterComponent : IComponentBase
	{
		// Token: 0x06004FB2 RID: 20402 RVA: 0x000C5425 File Offset: 0x000C3625
		public static DynamicSpawnMonsterComponent Create(IDynamicSpawnMonsterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x000C5444 File Offset: 0x000C3644
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x000C547C File Offset: 0x000C367C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x000C5494 File Offset: 0x000C3694
		public virtual List<IConditionSpawnMonster> Group
		{
			get
			{
				if (this._GroupInited)
				{
					return this._GroupCache;
				}
				this._GroupInited = true;
				int groupLength = this.Instance.GroupLength;
				this._GroupCache = new List<IConditionSpawnMonster>(groupLength);
				for (int i = 0; i < groupLength; i++)
				{
					this._GroupCache.Add(IConditionSpawnMonster.Create(this.Instance.Group(i)));
				}
				return this._GroupCache;
			}
		}

		// Token: 0x04002DBD RID: 11709
		private IDynamicSpawnMonsterComponent Instance;

		// Token: 0x04002DBE RID: 11710
		private List<IConditionSpawnMonster> _GroupCache;

		// Token: 0x04002DBF RID: 11711
		private bool _GroupInited;
	}
}
