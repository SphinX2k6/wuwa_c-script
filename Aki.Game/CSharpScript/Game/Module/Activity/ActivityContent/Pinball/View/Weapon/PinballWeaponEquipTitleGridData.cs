using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062E2 RID: 25314
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTitleGridData : IMultiTemplateGridData<IPinballWeaponEquipTitleItemData, PinballWeaponEquipTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x170092A3 RID: 37539
		// (get) Token: 0x0603FB0E RID: 260878 RVA: 0x00F68C49 File Offset: 0x00F66E49
		// (set) Token: 0x0603FB0F RID: 260879 RVA: 0x00F68C51 File Offset: 0x00F66E51
		public IPinballWeaponEquipTitleItemData Data { get; set; }

		// Token: 0x170092A4 RID: 37540
		// (get) Token: 0x0603FB10 RID: 260880 RVA: 0x00F68C5A File Offset: 0x00F66E5A
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603FB11 RID: 260881 RVA: 0x00F68C62 File Offset: 0x00F66E62
		public PinballWeaponEquipTitleGridData(IPinballWeaponEquipTitleItemData data)
		{
			this.Data = data;
		}

		// Token: 0x0603FB12 RID: 260882 RVA: 0x00F68C71 File Offset: 0x00F66E71
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603FB13 RID: 260883 RVA: 0x00F68C74 File Offset: 0x00F66E74
		public PinballWeaponEquipTitleItem CreateProxy()
		{
			return new PinballWeaponEquipTitleItem();
		}

		// Token: 0x0603FB14 RID: 260884 RVA: 0x00F68C7B File Offset: 0x00F66E7B
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}
	}
}
