using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EED RID: 20205
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceCaptionItemData
	{
		// Token: 0x06032C9E RID: 208030 RVA: 0x00E42F72 File Offset: 0x00E41172
		public string GetName()
		{
			return this.Name;
		}

		// Token: 0x06032C9F RID: 208031 RVA: 0x00E42F7A File Offset: 0x00E4117A
		public string GetTitleSpritePath()
		{
			return this.TitleSpritePath;
		}

		// Token: 0x06032CA0 RID: 208032 RVA: 0x00E42F82 File Offset: 0x00E41182
		public int GetHelpId()
		{
			return this.HelpId;
		}

		// Token: 0x06032CA1 RID: 208033 RVA: 0x00E42F8A File Offset: 0x00E4118A
		public static ActivityEntranceCaptionItemData Create(string name, string titleSpritePath, int helpId)
		{
			return new ActivityEntranceCaptionItemData
			{
				Name = name,
				TitleSpritePath = titleSpritePath,
				HelpId = helpId
			};
		}

		// Token: 0x0401AF6C RID: 110444
		private string Name = string.Empty;

		// Token: 0x0401AF6D RID: 110445
		private string TitleSpritePath = string.Empty;

		// Token: 0x0401AF6E RID: 110446
		private int HelpId;
	}
}
