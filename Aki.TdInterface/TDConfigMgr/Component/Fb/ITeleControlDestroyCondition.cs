using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0E RID: 3086
	public class ITeleControlDestroyCondition
	{
		// Token: 0x060046C3 RID: 18115 RVA: 0x000B3F30 File Offset: 0x000B2130
		public static ITeleControlDestroyCondition Create(ITeleControlDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x000B3F4F File Offset: 0x000B214F
		public virtual ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x040027B5 RID: 10165
		private ITeleControlDestroyCondition Instance;
	}
}
