using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6E RID: 28270
	public class IRemoveTrialCharacterT
	{
		// Token: 0x1700D293 RID: 53907
		// (get) Token: 0x06031F66 RID: 204646 RVA: 0x006C244F File Offset: 0x006C064F
		// (set) Token: 0x06031F67 RID: 204647 RVA: 0x006C2457 File Offset: 0x006C0657
		public int CharacterId { get; set; }

		// Token: 0x1700D294 RID: 53908
		// (get) Token: 0x06031F68 RID: 204648 RVA: 0x006C2460 File Offset: 0x006C0660
		// (set) Token: 0x06031F69 RID: 204649 RVA: 0x006C2468 File Offset: 0x006C0668
		public List<int> CharacterGroup { get; set; }

		// Token: 0x1700D295 RID: 53909
		// (get) Token: 0x06031F6A RID: 204650 RVA: 0x006C2471 File Offset: 0x006C0671
		// (set) Token: 0x06031F6B RID: 204651 RVA: 0x006C2479 File Offset: 0x006C0679
		public bool IsRemoveTips { get; set; }

		// Token: 0x1700D296 RID: 53910
		// (get) Token: 0x06031F6C RID: 204652 RVA: 0x006C2482 File Offset: 0x006C0682
		// (set) Token: 0x06031F6D RID: 204653 RVA: 0x006C248A File Offset: 0x006C068A
		public bool EnableSeamlessTeamSwitch { get; set; }

		// Token: 0x1700D297 RID: 53911
		// (get) Token: 0x06031F6E RID: 204654 RVA: 0x006C2493 File Offset: 0x006C0693
		// (set) Token: 0x06031F6F RID: 204655 RVA: 0x006C249B File Offset: 0x006C069B
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700D298 RID: 53912
		// (get) Token: 0x06031F70 RID: 204656 RVA: 0x006C24A4 File Offset: 0x006C06A4
		// (set) Token: 0x06031F71 RID: 204657 RVA: 0x006C24AC File Offset: 0x006C06AC
		public byte NullMask { get; set; }

		// Token: 0x06031F72 RID: 204658 RVA: 0x006C24B5 File Offset: 0x006C06B5
		public IRemoveTrialCharacterT()
		{
			this.CharacterId = 0;
			this.CharacterGroup = null;
			this.IsRemoveTips = false;
			this.EnableSeamlessTeamSwitch = false;
			this.OnlyLowMemoryDeviceExecute = false;
			this.NullMask = 0;
		}
	}
}
