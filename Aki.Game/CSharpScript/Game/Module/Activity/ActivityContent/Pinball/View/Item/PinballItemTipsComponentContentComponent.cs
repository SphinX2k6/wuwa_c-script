using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052CC RID: 21196
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemTipsComponentContentComponent : UiPanelBase
	{
		// Token: 0x06034C4D RID: 216141 RVA: 0x00EC1068 File Offset: 0x00EBF268
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034C4E RID: 216142 RVA: 0x00EC1197 File Offset: 0x00EBF397
		protected override void OnStart()
		{
			base.GetTexture(1).SetUIActive(false);
			this.SubComponent = new TipsMaterialComponent(base.GetItem(4));
		}

		// Token: 0x06034C4F RID: 216143 RVA: 0x00EC11B8 File Offset: 0x00EBF3B8
		public void Refresh(ItemTipsData data)
		{
			this.RefreshBase(data);
			this.SubComponent.Refresh((TipsMaterialData)data);
			this.SetActive(true);
		}

		// Token: 0x06034C50 RID: 216144 RVA: 0x00EC11D9 File Offset: 0x00EBF3D9
		private void RefreshBase(ItemTipsData data)
		{
			this.RefreshBaseName(data);
			this.RefreshBaseQuality(data);
			this.RefreshBaseIcon(data);
			this.SetDebugText(data.ConfigId);
		}

		// Token: 0x06034C51 RID: 216145 RVA: 0x00EC11FC File Offset: 0x00EBF3FC
		private void RefreshBaseName(ItemTipsData data)
		{
			UUIText text = base.GetText(0);
			if (data.IsQualityByType)
			{
				text.SetUIActive(false);
				return;
			}
			FColor color = FColor.FromHex(CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(data.QualityId).Value.TypeADropColor);
			base.GetText(0).SetColor(color);
			LguiUtil.Instance.SetLocalTextNew(text, data.Title, Array.Empty<object>());
		}

		// Token: 0x06034C52 RID: 216146 RVA: 0x00EC126C File Offset: 0x00EBF46C
		private void RefreshBaseQuality(ItemTipsData data)
		{
			UUIItem item = base.GetItem(7);
			if (data.IsQualityByType)
			{
				item.SetUIActive(false);
				return;
			}
			FColor color = FColor.FromHex(InventoryConfig.Instance.GetItemQualityConfig(data.QualityId).Value.TypeAItemTipsEffectColor);
			item.SetColor(color);
			item.SetUIActive(true);
		}

		// Token: 0x06034C53 RID: 216147 RVA: 0x00EC12C8 File Offset: 0x00EBF4C8
		private void RefreshBaseIcon(ItemTipsData data)
		{
			base.GetTexture(2).SetUIActive(false);
			base.GetTexture(6).SetUIActive(false);
			UUITexture texture = base.GetTexture(2);
			if (data.IsShowIconBig())
			{
				texture = base.GetTexture(6);
			}
			if (data.IsIconByType)
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			base.SetItemIcon(texture, data.ConfigId, null, null);
		}

		// Token: 0x06034C54 RID: 216148 RVA: 0x00EC1338 File Offset: 0x00EBF538
		private void SetDebugText(int debugId)
		{
			UUIText text = base.GetText(5);
			if (!GlobalData.IsPlayInEditor)
			{
				text.SetUIActive(false);
				return;
			}
			LguiUtil.Instance.SetLocalText(text, "CommonTipsDebugItemId", new <>z__ReadOnlySingleElementList<object>(debugId));
			text.SetUIActive(true);
		}

		// Token: 0x0401BEE1 RID: 114401
		[Nullable(2)]
		public TipsMaterialComponent SubComponent;

		// Token: 0x0200AF51 RID: 44881
		[NullableContext(0)]
		private enum EItemTipsComponentContent
		{
			// Token: 0x040362B7 RID: 221879
			Title,
			// Token: 0x040362B8 RID: 221880
			TexQuality,
			// Token: 0x040362B9 RID: 221881
			TexItemIcon256,
			// Token: 0x040362BA RID: 221882
			NiagaraQuality,
			// Token: 0x040362BB RID: 221883
			PanelContent,
			// Token: 0x040362BC RID: 221884
			TxtDebug,
			// Token: 0x040362BD RID: 221885
			TextureItemIcon732,
			// Token: 0x040362BE RID: 221886
			QualityItem
		}
	}
}
