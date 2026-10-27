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
	// Token: 0x0200634E RID: 25422
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemTipsComponentContentComponent : UiPanelBase
	{
		// Token: 0x0603FF8C RID: 262028 RVA: 0x00F7A108 File Offset: 0x00F78308
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

		// Token: 0x0603FF8D RID: 262029 RVA: 0x00F7A237 File Offset: 0x00F78437
		protected override void OnStart()
		{
			base.GetTexture(1).SetUIActive(false);
			this.SubComponent = new TipsMaterialComponent(base.GetItem(4));
		}

		// Token: 0x0603FF8E RID: 262030 RVA: 0x00F7A258 File Offset: 0x00F78458
		public void Refresh(ItemTipsData data)
		{
			this.RefreshBase(data);
			this.SubComponent.Refresh((TipsMaterialData)data);
			this.SetActive(true);
		}

		// Token: 0x0603FF8F RID: 262031 RVA: 0x00F7A279 File Offset: 0x00F78479
		private void RefreshBase(ItemTipsData data)
		{
			this.RefreshBaseName(data);
			this.RefreshBaseQuality(data);
			this.RefreshBaseIcon(data);
			this.SetDebugText(data.ConfigId);
		}

		// Token: 0x0603FF90 RID: 262032 RVA: 0x00F7A29C File Offset: 0x00F7849C
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

		// Token: 0x0603FF91 RID: 262033 RVA: 0x00F7A30C File Offset: 0x00F7850C
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

		// Token: 0x0603FF92 RID: 262034 RVA: 0x00F7A368 File Offset: 0x00F78568
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

		// Token: 0x0603FF93 RID: 262035 RVA: 0x00F7A3D8 File Offset: 0x00F785D8
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

		// Token: 0x040215B2 RID: 136626
		[Nullable(2)]
		public TipsMaterialComponent SubComponent;

		// Token: 0x0200C56A RID: 50538
		[NullableContext(0)]
		private enum EItemTipsComponentContent
		{
			// Token: 0x0403B955 RID: 244053
			Title,
			// Token: 0x0403B956 RID: 244054
			TexQuality,
			// Token: 0x0403B957 RID: 244055
			TexItemIcon256,
			// Token: 0x0403B958 RID: 244056
			NiagaraQuality,
			// Token: 0x0403B959 RID: 244057
			PanelContent,
			// Token: 0x0403B95A RID: 244058
			TxtDebug,
			// Token: 0x0403B95B RID: 244059
			TextureItemIcon732,
			// Token: 0x0403B95C RID: 244060
			QualityItem
		}
	}
}
