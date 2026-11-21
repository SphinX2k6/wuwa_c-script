using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F2 RID: 30194
	public class IRemoveTrialCharacterT
	{
		// Token: 0x1700DDEA RID: 56810
		// (get) Token: 0x06034FA6 RID: 216998 RVA: 0x0071E183 File Offset: 0x0071C383
		// (set) Token: 0x06034FA7 RID: 216999 RVA: 0x0071E18B File Offset: 0x0071C38B
		public int CharacterId { get; set; }

		// Token: 0x1700DDEB RID: 56811
		// (get) Token: 0x06034FA8 RID: 217000 RVA: 0x0071E194 File Offset: 0x0071C394
		// (set) Token: 0x06034FA9 RID: 217001 RVA: 0x0071E19C File Offset: 0x0071C39C
		public List<int> CharacterGroup { get; set; }

		// Token: 0x1700DDEC RID: 56812
		// (get) Token: 0x06034FAA RID: 217002 RVA: 0x0071E1A5 File Offset: 0x0071C3A5
		// (set) Token: 0x06034FAB RID: 217003 RVA: 0x0071E1AD File Offset: 0x0071C3AD
		public bool IsRemoveTips { get; set; }

		// Token: 0x1700DDED RID: 56813
		// (get) Token: 0x06034FAC RID: 217004 RVA: 0x0071E1B6 File Offset: 0x0071C3B6
		// (set) Token: 0x06034FAD RID: 217005 RVA: 0x0071E1BE File Offset: 0x0071C3BE
		public bool EnableSeamlessTeamSwitch { get; set; }

		// Token: 0x1700DDEE RID: 56814
		// (get) Token: 0x06034FAE RID: 217006 RVA: 0x0071E1C7 File Offset: 0x0071C3C7
		// (set) Token: 0x06034FAF RID: 217007 RVA: 0x0071E1CF File Offset: 0x0071C3CF
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700DDEF RID: 56815
		// (get) Token: 0x06034FB0 RID: 217008 RVA: 0x0071E1D8 File Offset: 0x0071C3D8
		// (set) Token: 0x06034FB1 RID: 217009 RVA: 0x0071E1E0 File Offset: 0x0071C3E0
		public byte NullMask { get; set; }

		// Token: 0x06034FB2 RID: 217010 RVA: 0x0071E1E9 File Offset: 0x0071C3E9
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
