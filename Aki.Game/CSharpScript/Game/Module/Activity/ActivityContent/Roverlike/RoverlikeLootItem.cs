using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006166 RID: 24934
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeLootItem : RoverlikeMultiUseGridProxyAbstract<RoverlikeLootGainEntry>
	{
		// Token: 0x0603F072 RID: 258162 RVA: 0x00F3ACA8 File Offset: 0x00F38EA8
		public void BindOnItemSelect(Action<RoverlikeLootGainEntry> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x0603F073 RID: 258163 RVA: 0x00F3ACB4 File Offset: 0x00F38EB4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogCommonStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F074 RID: 258164 RVA: 0x00F3AE20 File Offset: 0x00F39020
		public override void Refresh(RoverlikeLootGainEntry data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			RoverRogueLoot? lootConfig = RoverlikeConfig.Instance.GetLootConfig(data.ConfigId);
			if (lootConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), lootConfig.Value.Name, Array.Empty<object>());
			base.SetTextureByPath(lootConfig.Value.Icon, base.GetTexture(1), null, null);
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(!data.Unlock);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(data.Unlock && data.IsEquipped);
			}
			Func<RoverlikeLootGainEntry, bool> getHasRedDot = this.GetHasRedDot;
			bool uiactive = getHasRedDot != null && getHasRedDot(data);
			UUIItem item3 = base.GetItem(5);
			if (item3 != null)
			{
				item3.SetUIActive(uiactive);
			}
			List<bool> list = new List<bool>();
			for (int i = 0; i < lootConfig.Value.MaxLevel; i++)
			{
				list.Add(i < data.LootLv);
			}
			this.StarLayout.RefreshByData(list, null, false);
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603F075 RID: 258165 RVA: 0x00F3AF59 File Offset: 0x00F39159
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603F076 RID: 258166 RVA: 0x00F3AF6C File Offset: 0x00F3916C
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603F077 RID: 258167 RVA: 0x00F3AF7F File Offset: 0x00F3917F
		private void OnTogCommonStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.CurrentData != null)
			{
				Action<RoverlikeLootGainEntry> onItemSelect = this.OnItemSelect;
				if (onItemSelect == null)
				{
					return;
				}
				onItemSelect(this.CurrentData);
			}
		}

		// Token: 0x0603F078 RID: 258168 RVA: 0x00F3AFA3 File Offset: 0x00F391A3
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(2), new Func<RoverlikeLootStarItem>(this.CreateStarItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603F079 RID: 258169 RVA: 0x00F3AFD6 File Offset: 0x00F391D6
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x04020E0C RID: 134668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarLayout;

		// Token: 0x04020E0D RID: 134669
		[Nullable(2)]
		private RoverlikeLootGainEntry CurrentData;

		// Token: 0x04020E0E RID: 134670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RoverlikeLootGainEntry> OnItemSelect;

		// Token: 0x04020E0F RID: 134671
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeLootGainEntry, bool> GetHasRedDot;

		// Token: 0x0200C3CA RID: 50122
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B150 RID: 242000
			public const int TogCommon = 0;

			// Token: 0x0403B151 RID: 242001
			public const int TexIcon = 1;

			// Token: 0x0403B152 RID: 242002
			public const int StarLayout = 2;

			// Token: 0x0403B153 RID: 242003
			public const int StarItem = 3;

			// Token: 0x0403B154 RID: 242004
			public const int TxtName = 4;

			// Token: 0x0403B155 RID: 242005
			public const int ItemTagNew = 5;

			// Token: 0x0403B156 RID: 242006
			public const int PnlLock = 6;

			// Token: 0x0403B157 RID: 242007
			public const int PnlEquipment = 7;
		}
	}
}
