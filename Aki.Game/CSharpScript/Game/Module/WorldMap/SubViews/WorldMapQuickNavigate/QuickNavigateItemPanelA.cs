using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x02003704 RID: 14084
	public class QuickNavigateItemPanelA : UiPanelBase
	{
		// Token: 0x06024AAB RID: 150187 RVA: 0x00A59DC8 File Offset: 0x00A57FC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024AAC RID: 150188 RVA: 0x00A59EB0 File Offset: 0x00A580B0
		[NullableContext(1)]
		public void RefreshByData(QuickNavigateDynamicData data)
		{
			this.NavigateDynamicData = data;
			Country? config = ConfigCountryById.GetConfig(data.CountryId, true);
			if (config == null)
			{
				return;
			}
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, config.Value.Title, Array.Empty<object>());
			UUITexture texture = base.GetTexture(2);
			base.SetTextureByPath(config.Value.Logo, texture, null, null);
			bool hasState = this.NavigateDynamicData.HasState;
			this.UpdateToggleSetState();
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(hasState);
		}

		// Token: 0x06024AAD RID: 150189 RVA: 0x00A59F51 File Offset: 0x00A58151
		private void OnClickToggle(EToggleState toggleState)
		{
			this.UpdateToggleSetState();
			if (this.NavigateDynamicData != null)
			{
				EventSystem instance = EventSystem.Instance;
				if (instance == null)
				{
					return;
				}
				instance.Emit<QuickNavigateDynamicData>(EEventName.WorldMapFirstNavigateSelect, this.NavigateDynamicData);
			}
		}

		// Token: 0x06024AAE RID: 150190 RVA: 0x00A59F7C File Offset: 0x00A5817C
		private void UpdateToggleSetState()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null || this.NavigateDynamicData == null)
			{
				return;
			}
			if (this.NavigateDynamicData.HasState)
			{
				extendToggle.SetToggleState(this.NavigateDynamicData.IsExpand ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
			extendToggle.SetToggleState(this.NavigateDynamicData.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x040145D5 RID: 83413
		[Nullable(2)]
		private QuickNavigateDynamicData NavigateDynamicData;

		// Token: 0x02009444 RID: 37956
		public static class EComponent
		{
			// Token: 0x0402E5D8 RID: 189912
			public const int UiItemStripF2 = 0;

			// Token: 0x0402E5D9 RID: 189913
			public const int TxtName = 1;

			// Token: 0x0402E5DA RID: 189914
			public const int TexIcon = 2;

			// Token: 0x0402E5DB RID: 189915
			public const int SprArrow = 3;
		}
	}
}
