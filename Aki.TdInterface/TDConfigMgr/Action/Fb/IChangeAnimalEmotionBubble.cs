using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BF RID: 10687
	public class IChangeAnimalEmotionBubble : IExecClientBattleActionType
	{
		// Token: 0x0600ECA7 RID: 60583 RVA: 0x0022D300 File Offset: 0x0022B500
		public static IChangeAnimalEmotionBubble Create(IChangeAnimalEmotionBubble? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeAnimalEmotionBubble
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x0600ECA8 RID: 60584 RVA: 0x0022D31F File Offset: 0x0022B51F
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x0600ECA9 RID: 60585 RVA: 0x0022D32C File Offset: 0x0022B52C
		public virtual List<int> AnimalEntityIds
		{
			get
			{
				if (this._AnimalEntityIdsInited)
				{
					return this._AnimalEntityIdsCache;
				}
				this._AnimalEntityIdsInited = true;
				int animalEntityIdsLength = this.Instance.AnimalEntityIdsLength;
				this._AnimalEntityIdsCache = new List<int>(animalEntityIdsLength);
				for (int i = 0; i < animalEntityIdsLength; i++)
				{
					this._AnimalEntityIdsCache.Add(this.Instance.AnimalEntityIds(i));
				}
				return this._AnimalEntityIdsCache;
			}
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x0600ECAA RID: 60586 RVA: 0x0022D390 File Offset: 0x0022B590
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x0600ECAB RID: 60587 RVA: 0x0022D39D File Offset: 0x0022B59D
		public virtual string EmotionName
		{
			get
			{
				return this.Instance.EmotionName;
			}
		}

		// Token: 0x04008247 RID: 33351
		private IChangeAnimalEmotionBubble Instance;

		// Token: 0x04008248 RID: 33352
		private List<int> _AnimalEntityIdsCache;

		// Token: 0x04008249 RID: 33353
		private bool _AnimalEntityIdsInited;
	}
}
