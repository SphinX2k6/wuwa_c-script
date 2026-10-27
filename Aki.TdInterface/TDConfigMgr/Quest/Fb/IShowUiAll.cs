using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200139A RID: 5018
	public class IShowUiAll : IShowUi
	{
		// Token: 0x060072BC RID: 29372 RVA: 0x00113BDA File Offset: 0x00111DDA
		[NullableContext(1)]
		public static IShowUiAll Create(IShowUiAll? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiAll
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x00113BF9 File Offset: 0x00111DF9
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x04004258 RID: 16984
		private IShowUiAll Instance;
	}
}
