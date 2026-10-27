using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001361 RID: 4961
	public class ICompleteMessageQuestCondition : IPhoneMessageProgressTypeBase
	{
		// Token: 0x0600718F RID: 29071 RVA: 0x00111A04 File Offset: 0x0010FC04
		[NullableContext(1)]
		public static ICompleteMessageQuestCondition Create(ICompleteMessageQuestCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICompleteMessageQuestCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x06007190 RID: 29072 RVA: 0x00111A23 File Offset: 0x0010FC23
		public override EPhoneMessageProgressType Type
		{
			get
			{
				return (EPhoneMessageProgressType)this.Instance.Type;
			}
		}

		// Token: 0x0400419D RID: 16797
		private ICompleteMessageQuestCondition Instance;
	}
}
