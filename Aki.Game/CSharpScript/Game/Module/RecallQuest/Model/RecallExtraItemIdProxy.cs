using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02003EE7 RID: 16103
	public class RecallExtraItemIdProxy : IExtraItemIdProxy
	{
		// Token: 0x06028D5B RID: 167259 RVA: 0x00B75AF6 File Offset: 0x00B73CF6
		public int GetExtraItemId()
		{
			return this.CurrentItemId;
		}

		// Token: 0x06028D5C RID: 167260 RVA: 0x00B75AFE File Offset: 0x00B73CFE
		public int? GetExtraItemIdReplaceOverride()
		{
			return new int?(this.CurrentItemId);
		}

		// Token: 0x06028D5D RID: 167261 RVA: 0x00B75B0B File Offset: 0x00B73D0B
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

		// Token: 0x06028D5E RID: 167262 RVA: 0x00B75B2E File Offset: 0x00B73D2E
		public void ApplyServerSnapshot(int itemId)
		{
			this.CurrentItemId = itemId;
			RouletteController.Instance.TrySetExtraItemIdForReplace(itemId);
		}

		// Token: 0x0401635B RID: 90971
		private int CurrentItemId;
	}
}
