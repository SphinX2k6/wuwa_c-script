using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014EE RID: 5358
	public class IRogueRandomEvent : IShowUi
	{
		// Token: 0x0600796F RID: 31087 RVA: 0x00122359 File Offset: 0x00120559
		public static IRogueRandomEvent Create(IRogueRandomEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueRandomEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x06007970 RID: 31088 RVA: 0x00122378 File Offset: 0x00120578
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x040045DC RID: 17884
		private IRogueRandomEvent Instance;
	}
}
