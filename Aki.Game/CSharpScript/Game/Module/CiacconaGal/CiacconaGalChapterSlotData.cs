using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BAE RID: 19374
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterSlotData
	{
		// Token: 0x060305EA RID: 198122 RVA: 0x00D7B834 File Offset: 0x00D79A34
		public CiacconaGalChapterSlotData(CiacconaChapterSlot config)
		{
			this.Config = config;
		}

		// Token: 0x170060F2 RID: 24818
		// (get) Token: 0x060305EB RID: 198123 RVA: 0x00D7B844 File Offset: 0x00D79A44
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170060F3 RID: 24819
		// (get) Token: 0x060305EC RID: 198124 RVA: 0x00D7B860 File Offset: 0x00D79A60
		public int ChapterId
		{
			get
			{
				return this.Config.ChapterId;
			}
		}

		// Token: 0x170060F4 RID: 24820
		// (get) Token: 0x060305ED RID: 198125 RVA: 0x00D7B87C File Offset: 0x00D79A7C
		public string SlotImagePath
		{
			get
			{
				return this.Config.SlotImage;
			}
		}

		// Token: 0x170060F5 RID: 24821
		// (get) Token: 0x060305EE RID: 198126 RVA: 0x00D7B898 File Offset: 0x00D79A98
		public string SlotLockImagePath
		{
			get
			{
				return this.Config.SlotLockImage;
			}
		}

		// Token: 0x170060F6 RID: 24822
		// (get) Token: 0x060305EF RID: 198127 RVA: 0x00D7B8B4 File Offset: 0x00D79AB4
		public string RomanNumberIconPath
		{
			get
			{
				return this.Config.RomanNumberIcon;
			}
		}

		// Token: 0x04019A1D RID: 104989
		private readonly CiacconaChapterSlot Config;
	}
}
