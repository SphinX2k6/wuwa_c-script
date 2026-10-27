using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD7 RID: 19671
	[NullableContext(1)]
	public interface IDisplayableItem
	{
		// Token: 0x17007D8B RID: 32139
		// (get) Token: 0x06032C6D RID: 207981
		// (set) Token: 0x06032C6E RID: 207982
		string DisplayName { get; set; }

		// Token: 0x17007D8C RID: 32140
		// (get) Token: 0x06032C6F RID: 207983
		// (set) Token: 0x06032C70 RID: 207984
		string DisplayIcon { get; set; }

		// Token: 0x17007D8D RID: 32141
		// (get) Token: 0x06032C71 RID: 207985
		// (set) Token: 0x06032C72 RID: 207986
		int? DisplayCount { get; set; }

		// Token: 0x17007D8E RID: 32142
		// (get) Token: 0x06032C73 RID: 207987
		// (set) Token: 0x06032C74 RID: 207988
		bool IsUnlocked { get; set; }

		// Token: 0x17007D8F RID: 32143
		// (get) Token: 0x06032C75 RID: 207989
		// (set) Token: 0x06032C76 RID: 207990
		bool IsEquipped { get; set; }

		// Token: 0x17007D90 RID: 32144
		// (get) Token: 0x06032C77 RID: 207991
		// (set) Token: 0x06032C78 RID: 207992
		int? QualityLevel { get; set; }

		// Token: 0x17007D91 RID: 32145
		// (get) Token: 0x06032C79 RID: 207993
		// (set) Token: 0x06032C7A RID: 207994
		bool? IsFinished { get; set; }

		// Token: 0x17007D92 RID: 32146
		// (get) Token: 0x06032C7B RID: 207995
		// (set) Token: 0x06032C7C RID: 207996
		EClickActionType ClickAction { get; set; }

		// Token: 0x17007D93 RID: 32147
		// (get) Token: 0x06032C7D RID: 207997
		// (set) Token: 0x06032C7E RID: 207998
		int? ClickParam { get; set; }
	}
}
