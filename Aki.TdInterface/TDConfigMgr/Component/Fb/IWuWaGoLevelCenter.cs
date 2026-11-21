using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F03 RID: 3843
	public class IWuWaGoLevelCenter : IWuWaGoEntityBase
	{
		// Token: 0x06005671 RID: 22129 RVA: 0x000D41C9 File Offset: 0x000D23C9
		public static IWuWaGoLevelCenter Create(IWuWaGoLevelCenter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoLevelCenter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06005672 RID: 22130 RVA: 0x000D41E8 File Offset: 0x000D23E8
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06005673 RID: 22131 RVA: 0x000D41F5 File Offset: 0x000D23F5
		public virtual string LevelKey
		{
			get
			{
				return this.Instance.LevelKey;
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06005674 RID: 22132 RVA: 0x000D4204 File Offset: 0x000D2404
		public virtual List<int> LevelEntityIds
		{
			get
			{
				if (this._LevelEntityIdsInited)
				{
					return this._LevelEntityIdsCache;
				}
				this._LevelEntityIdsInited = true;
				int levelEntityIdsLength = this.Instance.LevelEntityIdsLength;
				this._LevelEntityIdsCache = new List<int>(levelEntityIdsLength);
				for (int i = 0; i < levelEntityIdsLength; i++)
				{
					this._LevelEntityIdsCache.Add(this.Instance.LevelEntityIds(i));
				}
				return this._LevelEntityIdsCache;
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06005675 RID: 22133 RVA: 0x000D4268 File Offset: 0x000D2468
		[Nullable(2)]
		public virtual string EdActorPath
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04003190 RID: 12688
		private IWuWaGoLevelCenter Instance;

		// Token: 0x04003191 RID: 12689
		private List<int> _LevelEntityIdsCache;

		// Token: 0x04003192 RID: 12690
		private bool _LevelEntityIdsInited;
	}
}
