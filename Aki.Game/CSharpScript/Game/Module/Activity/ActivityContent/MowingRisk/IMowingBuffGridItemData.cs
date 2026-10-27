using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063BD RID: 25533
	[NullableContext(1)]
	public interface IMowingBuffGridItemData
	{
		// Token: 0x170093B1 RID: 37809
		// (get) Token: 0x060403C0 RID: 263104
		// (set) Token: 0x060403C1 RID: 263105
		int BuffId { get; set; }

		// Token: 0x170093B2 RID: 37810
		// (get) Token: 0x060403C2 RID: 263106
		// (set) Token: 0x060403C3 RID: 263107
		string QualityPath { get; set; }

		// Token: 0x170093B3 RID: 37811
		// (get) Token: 0x060403C4 RID: 263108
		// (set) Token: 0x060403C5 RID: 263109
		string IconPath { get; set; }

		// Token: 0x170093B4 RID: 37812
		// (get) Token: 0x060403C6 RID: 263110
		// (set) Token: 0x060403C7 RID: 263111
		string NameTextId { get; set; }

		// Token: 0x170093B5 RID: 37813
		// (get) Token: 0x060403C8 RID: 263112
		// (set) Token: 0x060403C9 RID: 263113
		bool IsShowBackground { get; set; }

		// Token: 0x170093B6 RID: 37814
		// (get) Token: 0x060403CA RID: 263114
		// (set) Token: 0x060403CB RID: 263115
		bool IsChosen { get; set; }

		// Token: 0x170093B7 RID: 37815
		// (get) Token: 0x060403CC RID: 263116
		// (set) Token: 0x060403CD RID: 263117
		bool IsUnlock { get; set; }

		// Token: 0x170093B8 RID: 37816
		// (get) Token: 0x060403CE RID: 263118
		// (set) Token: 0x060403CF RID: 263119
		string LevelContent { get; set; }
	}
}
