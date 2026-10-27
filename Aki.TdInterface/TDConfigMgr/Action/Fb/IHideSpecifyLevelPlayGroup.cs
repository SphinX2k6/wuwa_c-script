using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002795 RID: 10133
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyLevelPlayGroup : IHideGroupType
	{
		// Token: 0x0600E18E RID: 57742 RVA: 0x0021557E File Offset: 0x0021377E
		public static IHideSpecifyLevelPlayGroup Create(IHideSpecifyLevelPlayGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyLevelPlayGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x0600E18F RID: 57743 RVA: 0x0021559D File Offset: 0x0021379D
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x0600E190 RID: 57744 RVA: 0x002155AC File Offset: 0x002137AC
		public virtual List<int> LevelPlays
		{
			get
			{
				if (this._LevelPlaysInited)
				{
					return this._LevelPlaysCache;
				}
				this._LevelPlaysInited = true;
				int levelPlaysLength = this.Instance.LevelPlaysLength;
				this._LevelPlaysCache = new List<int>(levelPlaysLength);
				for (int i = 0; i < levelPlaysLength; i++)
				{
					this._LevelPlaysCache.Add(this.Instance.LevelPlays(i));
				}
				return this._LevelPlaysCache;
			}
		}

		// Token: 0x04007D13 RID: 32019
		private IHideSpecifyLevelPlayGroup Instance;

		// Token: 0x04007D14 RID: 32020
		private List<int> _LevelPlaysCache;

		// Token: 0x04007D15 RID: 32021
		private bool _LevelPlaysInited;
	}
}
