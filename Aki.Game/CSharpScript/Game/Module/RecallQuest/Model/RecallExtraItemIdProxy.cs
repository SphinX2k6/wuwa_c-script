using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02004F1E RID: 20254
	public class RecallExtraItemIdProxy : IExtraItemIdProxy
	{
		// Token: 0x06033EF0 RID: 212720 RVA: 0x00C2C482 File Offset: 0x00C2A682
		public int GetExtraItemId()
		{
			return this.CurrentItemId;
		}

		// Token: 0x06033EF1 RID: 212721 RVA: 0x00C2C48A File Offset: 0x00C2A68A
		public int? GetExtraItemIdReplaceOverride()
		{
			return new int?(this.CurrentItemId);
		}

		// Token: 0x06033EF2 RID: 212722 RVA: 0x00C2C497 File Offset: 0x00C2A697
		[NullableContext(2)]
		public void SetExtraItemId(int itemId, Action<bool> callback = null)
		{
			bool flag = this.CurrentItemId != itemId;
			this.CurrentItemId = itemId;
			if (flag)
			{
				RecallQuestController.Instance.SendRecallExploreSkillRouletteSet(itemId, callback);
			}
		}

		// Token: 0x06033EF3 RID: 212723 RVA: 0x00C2C4BA File Offset: 0x00C2A6BA
		public void ApplyServerSnapshot(int itemId)
		{
			this.CurrentItemId = itemId;
			RouletteController.Instance.TrySetExtraItemIdForReplace(itemId);
		}

		// Token: 0x0401B988 RID: 113032
		private int CurrentItemId;
	}
}
