using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E4 RID: 20708
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeLootItem : RoverlikeMultiUseGridProxyAbstract<RoverlikeLootGainEntry>
	{
		// Token: 0x06033D32 RID: 212274 RVA: 0x00E81B7C File Offset: 0x00E7FD7C
		public void BindOnItemSelect(Action<RoverlikeLootGainEntry> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x06033D33 RID: 212275 RVA: 0x00E81B88 File Offset: 0x00E7FD88
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

		// Token: 0x06033D34 RID: 212276 RVA: 0x00E81CF4 File Offset: 0x00E7FEF4
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

		// Token: 0x06033D35 RID: 212277 RVA: 0x00E81E2D File Offset: 0x00E8002D
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033D36 RID: 212278 RVA: 0x00E81E40 File Offset: 0x00E80040
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033D37 RID: 212279 RVA: 0x00E81E53 File Offset: 0x00E80053
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

		// Token: 0x06033D38 RID: 212280 RVA: 0x00E81E77 File Offset: 0x00E80077
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(2), new Func<RoverlikeLootStarItem>(this.CreateStarItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033D39 RID: 212281 RVA: 0x00E81EAA File Offset: 0x00E800AA
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x0401B739 RID: 112441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarLayout;

		// Token: 0x0401B73A RID: 112442
		[Nullable(2)]
		private RoverlikeLootGainEntry CurrentData;

		// Token: 0x0401B73B RID: 112443
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RoverlikeLootGainEntry> OnItemSelect;

		// Token: 0x0401B73C RID: 112444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RoverlikeLootGainEntry, bool> GetHasRedDot;

		// Token: 0x0200ADB1 RID: 44465
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035AB1 RID: 219825
			public const int TogCommon = 0;

			// Token: 0x04035AB2 RID: 219826
			public const int TexIcon = 1;

			// Token: 0x04035AB3 RID: 219827
			public const int StarLayout = 2;

			// Token: 0x04035AB4 RID: 219828
			public const int StarItem = 3;

			// Token: 0x04035AB5 RID: 219829
			public const int TxtName = 4;

			// Token: 0x04035AB6 RID: 219830
			public const int ItemTagNew = 5;

			// Token: 0x04035AB7 RID: 219831
			public const int PnlLock = 6;

			// Token: 0x04035AB8 RID: 219832
			public const int PnlEquipment = 7;
		}
	}
}
