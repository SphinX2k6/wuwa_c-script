using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F06 RID: 24326
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceCaptionItemData
	{
		// Token: 0x0603DD03 RID: 253187 RVA: 0x00EF126A File Offset: 0x00EEF46A
		public string GetName()
		{
			return this.Name;
		}

		// Token: 0x0603DD04 RID: 253188 RVA: 0x00EF1272 File Offset: 0x00EEF472
		public string GetTitleSpritePath()
		{
			return this.TitleSpritePath;
		}

		// Token: 0x0603DD05 RID: 253189 RVA: 0x00EF127A File Offset: 0x00EEF47A
		public int GetHelpId()
		{
			return this.HelpId;
		}

		// Token: 0x0603DD06 RID: 253190 RVA: 0x00EF1282 File Offset: 0x00EEF482
		public static ActivityEntranceCaptionItemData Create(string name, string titleSpritePath, int helpId)
		{
			return new ActivityEntranceCaptionItemData
			{
				Name = name,
				TitleSpritePath = titleSpritePath,
				HelpId = helpId
			};
		}

		// Token: 0x0402049A RID: 132250
		private string Name = string.Empty;

		// Token: 0x0402049B RID: 132251
		private string TitleSpritePath = string.Empty;

		// Token: 0x0402049C RID: 132252
		private int HelpId;
	}
}
