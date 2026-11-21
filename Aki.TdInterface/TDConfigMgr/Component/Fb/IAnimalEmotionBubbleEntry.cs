using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF9 RID: 3321
	public class IAnimalEmotionBubbleEntry
	{
		// Token: 0x06004BAC RID: 19372 RVA: 0x000BD95D File Offset: 0x000BBB5D
		public static IAnimalEmotionBubbleEntry Create(IAnimalEmotionBubbleEntry? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnimalEmotionBubbleEntry
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06004BAD RID: 19373 RVA: 0x000BD97C File Offset: 0x000BBB7C
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06004BAE RID: 19374 RVA: 0x000BD989 File Offset: 0x000BBB89
		public virtual string EmotionName
		{
			get
			{
				return this.Instance.EmotionName;
			}
		}

		// Token: 0x04002AC4 RID: 10948
		private IAnimalEmotionBubbleEntry Instance;
	}
}
