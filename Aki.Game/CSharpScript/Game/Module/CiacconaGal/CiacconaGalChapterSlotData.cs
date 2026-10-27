using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BCE RID: 23502
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterSlotData
	{
		// Token: 0x0603B69E RID: 243358 RVA: 0x00E2B540 File Offset: 0x00E29740
		public CiacconaGalChapterSlotData(CiacconaChapterSlot config)
		{
			this.Config = config;
		}

		// Token: 0x17008D20 RID: 36128
		// (get) Token: 0x0603B69F RID: 243359 RVA: 0x00E2B550 File Offset: 0x00E29750
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D21 RID: 36129
		// (get) Token: 0x0603B6A0 RID: 243360 RVA: 0x00E2B56C File Offset: 0x00E2976C
		public int ChapterId
		{
			get
			{
				return this.Config.ChapterId;
			}
		}

		// Token: 0x17008D22 RID: 36130
		// (get) Token: 0x0603B6A1 RID: 243361 RVA: 0x00E2B588 File Offset: 0x00E29788
		public string SlotImagePath
		{
			get
			{
				return this.Config.SlotImage;
			}
		}

		// Token: 0x17008D23 RID: 36131
		// (get) Token: 0x0603B6A2 RID: 243362 RVA: 0x00E2B5A4 File Offset: 0x00E297A4
		public string SlotLockImagePath
		{
			get
			{
				return this.Config.SlotLockImage;
			}
		}

		// Token: 0x17008D24 RID: 36132
		// (get) Token: 0x0603B6A3 RID: 243363 RVA: 0x00E2B5C0 File Offset: 0x00E297C0
		public string RomanNumberIconPath
		{
			get
			{
				return this.Config.RomanNumberIcon;
			}
		}

		// Token: 0x0401EF6C RID: 126828
		private readonly CiacconaChapterSlot Config;
	}
}
