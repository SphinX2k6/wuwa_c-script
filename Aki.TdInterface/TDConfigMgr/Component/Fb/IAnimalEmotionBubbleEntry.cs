using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C26 RID: 3110
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnimalEmotionBubbleEntry
	{
		// Token: 0x0600473D RID: 18237 RVA: 0x000B3625 File Offset: 0x000B1825
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

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x000B3644 File Offset: 0x000B1844
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x000B3651 File Offset: 0x000B1851
		public virtual string EmotionName
		{
			get
			{
				return this.Instance.EmotionName;
			}
		}

		// Token: 0x04002871 RID: 10353
		private IAnimalEmotionBubbleEntry Instance;
	}
}
