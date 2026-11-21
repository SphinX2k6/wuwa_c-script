using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004AB8 RID: 19128
	[NullableContext(2)]
	[Nullable(0)]
	public class PluginEquipViewModel : ViewModelBase<EPluginEquipViewData>
	{
		// Token: 0x0602FDC5 RID: 196037 RVA: 0x00D5BA5E File Offset: 0x00D59C5E
		public PluginEquipViewModel()
		{
			this.DataMap[EPluginEquipViewData.DangoId] = 0;
			this.DataMap[EPluginEquipViewData.SlotIndex] = -1;
			this.DataMap[EPluginEquipViewData.PluginItem] = null;
		}

		// Token: 0x0602FDC6 RID: 196038 RVA: 0x00D5BA97 File Offset: 0x00D59C97
		public void SetDangoId(int dangoId, bool notNotify = false)
		{
			base.SetData(EPluginEquipViewData.DangoId, dangoId, notNotify);
		}

		// Token: 0x0602FDC7 RID: 196039 RVA: 0x00D5BAA7 File Offset: 0x00D59CA7
		public void SetSlotIndex(int slotIndex, bool notNotify = false)
		{
			base.SetData(EPluginEquipViewData.SlotIndex, slotIndex, notNotify);
		}

		// Token: 0x0602FDC8 RID: 196040 RVA: 0x00D5BAB7 File Offset: 0x00D59CB7
		public void SetPluginItem(AbyssPluginItemInfo pluginItem, bool notNotify = false)
		{
			base.SetData(EPluginEquipViewData.PluginItem, pluginItem, notNotify);
		}

		// Token: 0x0602FDC9 RID: 196041 RVA: 0x00D5BAC2 File Offset: 0x00D59CC2
		public int GetDangoId()
		{
			return (int)base.GetData(EPluginEquipViewData.DangoId);
		}

		// Token: 0x0602FDCA RID: 196042 RVA: 0x00D5BAD0 File Offset: 0x00D59CD0
		public int GetSlotIndex()
		{
			return (int)base.GetData(EPluginEquipViewData.SlotIndex);
		}

		// Token: 0x0602FDCB RID: 196043 RVA: 0x00D5BADE File Offset: 0x00D59CDE
		public AbyssPluginItemInfo GetPluginItem()
		{
			return base.GetData(EPluginEquipViewData.PluginItem) as AbyssPluginItemInfo;
		}
	}
}
