using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063BE RID: 25534
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffGridItemData : IMowingBuffGridItemData
	{
		// Token: 0x170093B9 RID: 37817
		// (get) Token: 0x060403D0 RID: 263120 RVA: 0x00F8B76F File Offset: 0x00F8996F
		// (set) Token: 0x060403D1 RID: 263121 RVA: 0x00F8B777 File Offset: 0x00F89977
		public int BuffId { get; set; }

		// Token: 0x170093BA RID: 37818
		// (get) Token: 0x060403D2 RID: 263122 RVA: 0x00F8B780 File Offset: 0x00F89980
		// (set) Token: 0x060403D3 RID: 263123 RVA: 0x00F8B788 File Offset: 0x00F89988
		public string QualityPath { get; set; }

		// Token: 0x170093BB RID: 37819
		// (get) Token: 0x060403D4 RID: 263124 RVA: 0x00F8B791 File Offset: 0x00F89991
		// (set) Token: 0x060403D5 RID: 263125 RVA: 0x00F8B799 File Offset: 0x00F89999
		public string IconPath { get; set; }

		// Token: 0x170093BC RID: 37820
		// (get) Token: 0x060403D6 RID: 263126 RVA: 0x00F8B7A2 File Offset: 0x00F899A2
		// (set) Token: 0x060403D7 RID: 263127 RVA: 0x00F8B7AA File Offset: 0x00F899AA
		public string NameTextId { get; set; }

		// Token: 0x170093BD RID: 37821
		// (get) Token: 0x060403D8 RID: 263128 RVA: 0x00F8B7B3 File Offset: 0x00F899B3
		// (set) Token: 0x060403D9 RID: 263129 RVA: 0x00F8B7BB File Offset: 0x00F899BB
		public bool IsShowBackground { get; set; }

		// Token: 0x170093BE RID: 37822
		// (get) Token: 0x060403DA RID: 263130 RVA: 0x00F8B7C4 File Offset: 0x00F899C4
		// (set) Token: 0x060403DB RID: 263131 RVA: 0x00F8B7CC File Offset: 0x00F899CC
		public bool IsChosen { get; set; }

		// Token: 0x170093BF RID: 37823
		// (get) Token: 0x060403DC RID: 263132 RVA: 0x00F8B7D5 File Offset: 0x00F899D5
		// (set) Token: 0x060403DD RID: 263133 RVA: 0x00F8B7DD File Offset: 0x00F899DD
		public bool IsUnlock { get; set; }

		// Token: 0x170093C0 RID: 37824
		// (get) Token: 0x060403DE RID: 263134 RVA: 0x00F8B7E6 File Offset: 0x00F899E6
		// (set) Token: 0x060403DF RID: 263135 RVA: 0x00F8B7EE File Offset: 0x00F899EE
		public string LevelContent { get; set; }
	}
}
