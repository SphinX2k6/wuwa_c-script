using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005904 RID: 22788
	public class InfrArchiveCollectCardItem : GridProxyAbstract<int>
	{
		// Token: 0x06039DE3 RID: 237027 RVA: 0x00DBE41C File Offset: 0x00DBC61C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnItem));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnGo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039DE4 RID: 237028 RVA: 0x00DBE611 File Offset: 0x00DBC811
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ArchiveId = data;
			this.RefreshCardView();
		}

		// Token: 0x06039DE5 RID: 237029 RVA: 0x00DBE620 File Offset: 0x00DBC820
		private void RefreshCardView()
		{
			InfrArchiveItem? archiveItemConfig = InfrastructureConfig.Instance.GetArchiveItemConfig(this.ArchiveId);
			bool flag = InventoryModel.Instance.GetItemCountByConfigId(archiveItemConfig.Value.ItemId, 0) > 0;
			ItemInfo? config = ItemConfig.Instance.GetConfig(archiveItemConfig.Value.ItemId);
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(5).SetUIActive(flag);
			base.SetTextureByPath(config.Value.Icon, base.GetTexture(2), null, null);
			base.SetTextureByPath(config.Value.Icon, base.GetTexture(6), null, null);
			base.GetText(7).ShowTextNew(config.Value.Name);
			string archiveItemQualityPath = InfrastructureConfig.Instance.GetArchiveItemQualityPath(config.Value.QualityId);
			base.SetTextureByPath(archiveItemQualityPath, base.GetTexture(8), null, null);
			base.GetItem(9).SetUIActive(InfrastructureModel.Instance.GetArchiveIsUnRead(this.ArchiveId));
			base.GetUiNiagara(10).SetNiagaraVarInt("Subuv", archiveItemConfig.Value.EffectId);
		}

		// Token: 0x06039DE6 RID: 237030 RVA: 0x00DBE774 File Offset: 0x00DBC974
		private void OnClickBtnItem()
		{
			InfrArchiveItem? archiveItemConfig = InfrastructureConfig.Instance.GetArchiveItemConfig(this.ArchiveId);
			bool flag = InventoryModel.Instance.GetItemCountByConfigId(archiveItemConfig.Value.ItemId, 0) > 0;
			if (archiveItemConfig != null && flag)
			{
				if (InfrastructureModel.Instance.GetArchiveIsUnRead(this.ArchiveId))
				{
					InfrastructureController.Instance.RequestInfrArchiveReadRequest(new int[]
					{
						this.ArchiveId
					});
				}
				InfoDisplayController.Instance.OpenInfoDisplay(archiveItemConfig.Value.InfoDisplayId, null, null, false, new ELayerType?(ELayerType.Pop));
			}
		}

		// Token: 0x06039DE7 RID: 237031 RVA: 0x00DBE80C File Offset: 0x00DBCA0C
		private void OnClickBtnGo()
		{
			InfrArchiveItem? archiveItemConfig = InfrastructureConfig.Instance.GetArchiveItemConfig(this.ArchiveId);
			if (archiveItemConfig != null)
			{
				SkipTaskManager.RunByConfigId(archiveItemConfig.Value.AccessPath, null);
			}
		}

		// Token: 0x0401E2FF RID: 123647
		private int ArchiveId;

		// Token: 0x0200BB66 RID: 47974
		private class EChildType
		{
			// Token: 0x04038906 RID: 231686
			public const int BtnItem = 0;

			// Token: 0x04038907 RID: 231687
			public const int PanelLock = 1;

			// Token: 0x04038908 RID: 231688
			public const int TextureCardIconLock = 2;

			// Token: 0x04038909 RID: 231689
			public const int TextLockTitle = 3;

			// Token: 0x0403890A RID: 231690
			public const int BtnGo = 4;

			// Token: 0x0403890B RID: 231691
			public const int PanelUnlock = 5;

			// Token: 0x0403890C RID: 231692
			public const int TextureCardIconUnlock = 6;

			// Token: 0x0403890D RID: 231693
			public const int TextTitle = 7;

			// Token: 0x0403890E RID: 231694
			public const int TextureQuality = 8;

			// Token: 0x0403890F RID: 231695
			public const int PanelNew = 9;

			// Token: 0x04038910 RID: 231696
			public const int NiagaraIcon = 10;
		}
	}
}
