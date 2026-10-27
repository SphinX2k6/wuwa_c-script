using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005AD7 RID: 23255
	[NullableContext(2)]
	[Nullable(0)]
	public class PluginEquipViewModel : ViewModelBase<EPluginEquipViewData>
	{
		// Token: 0x0603AE53 RID: 241235 RVA: 0x00E0AD76 File Offset: 0x00E08F76
		public PluginEquipViewModel()
		{
			this.DataMap[EPluginEquipViewData.DangoId] = 0;
			this.DataMap[EPluginEquipViewData.SlotIndex] = -1;
			this.DataMap[EPluginEquipViewData.PluginItem] = null;
		}

		// Token: 0x0603AE54 RID: 241236 RVA: 0x00E0ADAF File Offset: 0x00E08FAF
		public void SetDangoId(int dangoId, bool notNotify = false)
		{
			base.SetData(EPluginEquipViewData.DangoId, dangoId, notNotify);
		}

		// Token: 0x0603AE55 RID: 241237 RVA: 0x00E0ADBF File Offset: 0x00E08FBF
		public void SetSlotIndex(int slotIndex, bool notNotify = false)
		{
			base.SetData(EPluginEquipViewData.SlotIndex, slotIndex, notNotify);
		}

		// Token: 0x0603AE56 RID: 241238 RVA: 0x00E0ADCF File Offset: 0x00E08FCF
		public void SetPluginItem(AbyssPluginItemInfo pluginItem, bool notNotify = false)
		{
			base.SetData(EPluginEquipViewData.PluginItem, pluginItem, notNotify);
		}

		// Token: 0x0603AE57 RID: 241239 RVA: 0x00E0ADDA File Offset: 0x00E08FDA
		public int GetDangoId()
		{
			return (int)base.GetData(EPluginEquipViewData.DangoId);
		}

		// Token: 0x0603AE58 RID: 241240 RVA: 0x00E0ADE8 File Offset: 0x00E08FE8
		public int GetSlotIndex()
		{
			return (int)base.GetData(EPluginEquipViewData.SlotIndex);
		}

		// Token: 0x0603AE59 RID: 241241 RVA: 0x00E0ADF6 File Offset: 0x00E08FF6
		public AbyssPluginItemInfo GetPluginItem()
		{
			return base.GetData(EPluginEquipViewData.PluginItem) as AbyssPluginItemInfo;
		}
	}
}
