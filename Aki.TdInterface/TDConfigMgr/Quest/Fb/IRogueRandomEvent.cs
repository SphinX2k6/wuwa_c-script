using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200139D RID: 5021
	public class IRogueRandomEvent : IShowUi
	{
		// Token: 0x060072C8 RID: 29384 RVA: 0x00113C9D File Offset: 0x00111E9D
		[NullableContext(1)]
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

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x060072C9 RID: 29385 RVA: 0x00113CBC File Offset: 0x00111EBC
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x0400425B RID: 16987
		private IRogueRandomEvent Instance;
	}
}
