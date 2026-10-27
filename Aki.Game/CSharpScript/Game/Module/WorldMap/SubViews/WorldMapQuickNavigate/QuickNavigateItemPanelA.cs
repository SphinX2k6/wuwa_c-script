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
	// Token: 0x020047D3 RID: 18387
	public class QuickNavigateItemPanelA : UiPanelBase
	{
		// Token: 0x060302DB RID: 197339 RVA: 0x00B29F2C File Offset: 0x00B2812C
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

		// Token: 0x060302DC RID: 197340 RVA: 0x00B2A014 File Offset: 0x00B28214
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

		// Token: 0x060302DD RID: 197341 RVA: 0x00B2A0B5 File Offset: 0x00B282B5
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

		// Token: 0x060302DE RID: 197342 RVA: 0x00B2A0E0 File Offset: 0x00B282E0
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

		// Token: 0x04019F21 RID: 106273
		[Nullable(2)]
		private QuickNavigateDynamicData NavigateDynamicData;

		// Token: 0x0200AA92 RID: 43666
		public static class EComponent
		{
			// Token: 0x04033E50 RID: 212560
			public const int UiItemStripF2 = 0;

			// Token: 0x04033E51 RID: 212561
			public const int TxtName = 1;

			// Token: 0x04033E52 RID: 212562
			public const int TexIcon = 2;

			// Token: 0x04033E53 RID: 212563
			public const int SprArrow = 3;
		}
	}
}
