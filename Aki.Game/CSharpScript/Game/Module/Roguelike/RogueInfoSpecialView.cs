using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC2 RID: 15810
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueInfoSpecialView : UiPanelBase
	{
		// Token: 0x0602868E RID: 165518 RVA: 0x00B52818 File Offset: 0x00B50A18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602868F RID: 165519 RVA: 0x00B52860 File Offset: 0x00B50A60
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06028690 RID: 165520 RVA: 0x00B5287A File Offset: 0x00B50A7A
		protected override void OnStart()
		{
			this.SpecialItemLayout = new GenericLayout<RoguelikeSelectSpecialItem, RogueGainEntry>(base.GetHorizontalLayout(0), new Func<RoguelikeSelectSpecialItem>(this.CreateSpecialItem), null, false, true);
		}

		// Token: 0x06028691 RID: 165521 RVA: 0x00B528A0 File Offset: 0x00B50AA0
		public void Refresh(List<RogueGainEntry> specialDataList)
		{
			List<RogueGainEntry> list = specialDataList.ToList<RogueGainEntry>();
			list.Sort(new Comparison<RogueGainEntry>(this.SortSpecialItem));
			this.SpecialItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06028692 RID: 165522 RVA: 0x00B528D4 File Offset: 0x00B50AD4
		private int SortSpecialItem(RogueGainEntry a, RogueGainEntry b)
		{
			RougeMiraclecreation? roguelikeSpecialConfig = RoguelikeConfig.Instance.GetRoguelikeSpecialConfig(a.ConfigId);
			RougeMiraclecreation? roguelikeSpecialConfig2 = RoguelikeConfig.Instance.GetRoguelikeSpecialConfig(b.ConfigId);
			RougeMiraclecreationColor? rougeMiraclecreationColor = (roguelikeSpecialConfig != null) ? RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(roguelikeSpecialConfig.Value.ColorType) : null;
			RougeMiraclecreationColor? rougeMiraclecreationColor2 = (roguelikeSpecialConfig2 != null) ? RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(roguelikeSpecialConfig2.Value.ColorType) : null;
			int num = (rougeMiraclecreationColor != null) ? rougeMiraclecreationColor.GetValueOrDefault().Sort : 0;
			return ((rougeMiraclecreationColor2 != null) ? rougeMiraclecreationColor2.GetValueOrDefault().Sort : 0) - num;
		}

		// Token: 0x06028693 RID: 165523 RVA: 0x00B529A0 File Offset: 0x00B50BA0
		private RoguelikeSelectSpecialItem CreateSpecialItem()
		{
			return new RoguelikeSelectSpecialItem(new Action<RoguelikeSelectSpecialItem, RogueGainEntry>(this.OnClickRoguelikeSpecialItem));
		}

		// Token: 0x06028694 RID: 165524 RVA: 0x00B529B3 File Offset: 0x00B50BB3
		private void OnClickRoguelikeSpecialItem(RoguelikeSelectSpecialItem item, RogueGainEntry data)
		{
			item.SetSelect(false);
			UiManager instance = UiManager.Instance;
			EUiViewName roguelikeSpecialDetailView = EUiViewName.RoguelikeSpecialDetailView;
			object[] array = new object[2];
			array[0] = data;
			instance.OpenView(roguelikeSpecialDetailView, array, null);
		}

		// Token: 0x04015F21 RID: 89889
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialItem, RogueGainEntry> SpecialItemLayout;

		// Token: 0x04015F22 RID: 89890
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x020099BB RID: 39355
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402FEE7 RID: 196327
			public const int SpecialItemLayout = 0;
		}
	}
}
