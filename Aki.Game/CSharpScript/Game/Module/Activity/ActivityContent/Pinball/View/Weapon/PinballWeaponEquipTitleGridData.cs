using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x02005260 RID: 21088
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTitleGridData : IMultiTemplateGridData<IPinballWeaponEquipTitleItemData, PinballWeaponEquipTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x17006605 RID: 26117
		// (get) Token: 0x060347CF RID: 214991 RVA: 0x00EAFBA5 File Offset: 0x00EADDA5
		// (set) Token: 0x060347D0 RID: 214992 RVA: 0x00EAFBAD File Offset: 0x00EADDAD
		public IPinballWeaponEquipTitleItemData Data { get; set; }

		// Token: 0x17006606 RID: 26118
		// (get) Token: 0x060347D1 RID: 214993 RVA: 0x00EAFBB6 File Offset: 0x00EADDB6
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x060347D2 RID: 214994 RVA: 0x00EAFBBE File Offset: 0x00EADDBE
		public PinballWeaponEquipTitleGridData(IPinballWeaponEquipTitleItemData data)
		{
			this.Data = data;
		}

		// Token: 0x060347D3 RID: 214995 RVA: 0x00EAFBCD File Offset: 0x00EADDCD
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x060347D4 RID: 214996 RVA: 0x00EAFBD0 File Offset: 0x00EADDD0
		public PinballWeaponEquipTitleItem CreateProxy()
		{
			return new PinballWeaponEquipTitleItem();
		}

		// Token: 0x060347D5 RID: 214997 RVA: 0x00EAFBD7 File Offset: 0x00EADDD7
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}
	}
}
