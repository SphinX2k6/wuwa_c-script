using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F9 RID: 9977
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeAnimalEmotionBubble : IExecClientBattleActionType
	{
		// Token: 0x0600DEBF RID: 57023 RVA: 0x00210998 File Offset: 0x0020EB98
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

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x0600DEC0 RID: 57024 RVA: 0x002109B7 File Offset: 0x0020EBB7
		public override EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x0600DEC1 RID: 57025 RVA: 0x002109C4 File Offset: 0x0020EBC4
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

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x0600DEC2 RID: 57026 RVA: 0x00210A28 File Offset: 0x0020EC28
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x0600DEC3 RID: 57027 RVA: 0x00210A35 File Offset: 0x0020EC35
		public virtual string EmotionName
		{
			get
			{
				return this.Instance.EmotionName;
			}
		}

		// Token: 0x04007BA3 RID: 31651
		private IChangeAnimalEmotionBubble Instance;

		// Token: 0x04007BA4 RID: 31652
		private List<int> _AnimalEntityIdsCache;

		// Token: 0x04007BA5 RID: 31653
		private bool _AnimalEntityIdsInited;
	}
}
