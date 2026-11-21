using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0F RID: 3087
	public class ILetGoDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x060046C6 RID: 18118 RVA: 0x000B3F64 File Offset: 0x000B2164
		public static ILetGoDestroyCondition Create(ILetGoDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILetGoDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x000B3F83 File Offset: 0x000B2183
		public override ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x040027B6 RID: 10166
		private ILetGoDestroyCondition Instance;
	}
}
