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
	// Token: 0x02004DF9 RID: 19961
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueInfoSpecialView : UiPanelBase
	{
		// Token: 0x06033823 RID: 210979 RVA: 0x00C09308 File Offset: 0x00C07508
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

		// Token: 0x06033824 RID: 210980 RVA: 0x00C09350 File Offset: 0x00C07550
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06033825 RID: 210981 RVA: 0x00C0936A File Offset: 0x00C0756A
		protected override void OnStart()
		{
			this.SpecialItemLayout = new GenericLayout<RoguelikeSelectSpecialItem, RogueGainEntry>(base.GetHorizontalLayout(0), new Func<RoguelikeSelectSpecialItem>(this.CreateSpecialItem), null, false, true);
		}

		// Token: 0x06033826 RID: 210982 RVA: 0x00C09390 File Offset: 0x00C07590
		public void Refresh(List<RogueGainEntry> specialDataList)
		{
			List<RogueGainEntry> list = specialDataList.ToList<RogueGainEntry>();
			list.Sort(new Comparison<RogueGainEntry>(this.SortSpecialItem));
			this.SpecialItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06033827 RID: 210983 RVA: 0x00C093C4 File Offset: 0x00C075C4
		private int SortSpecialItem(RogueGainEntry a, RogueGainEntry b)
		{
			RougeMiraclecreation? roguelikeSpecialConfig = RoguelikeConfig.Instance.GetRoguelikeSpecialConfig(a.ConfigId);
			RougeMiraclecreation? roguelikeSpecialConfig2 = RoguelikeConfig.Instance.GetRoguelikeSpecialConfig(b.ConfigId);
			RougeMiraclecreationColor? rougeMiraclecreationColor = (roguelikeSpecialConfig != null) ? RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(roguelikeSpecialConfig.Value.ColorType) : null;
			RougeMiraclecreationColor? rougeMiraclecreationColor2 = (roguelikeSpecialConfig2 != null) ? RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(roguelikeSpecialConfig2.Value.ColorType) : null;
			int num = (rougeMiraclecreationColor != null) ? rougeMiraclecreationColor.GetValueOrDefault().Sort : 0;
			return ((rougeMiraclecreationColor2 != null) ? rougeMiraclecreationColor2.GetValueOrDefault().Sort : 0) - num;
		}

		// Token: 0x06033828 RID: 210984 RVA: 0x00C09490 File Offset: 0x00C07690
		private RoguelikeSelectSpecialItem CreateSpecialItem()
		{
			return new RoguelikeSelectSpecialItem(new Action<RoguelikeSelectSpecialItem, RogueGainEntry>(this.OnClickRoguelikeSpecialItem));
		}

		// Token: 0x06033829 RID: 210985 RVA: 0x00C094A3 File Offset: 0x00C076A3
		private void OnClickRoguelikeSpecialItem(RoguelikeSelectSpecialItem item, RogueGainEntry data)
		{
			item.SetSelect(false);
			UiManager instance = UiManager.Instance;
			EUiViewName roguelikeSpecialDetailView = EUiViewName.RoguelikeSpecialDetailView;
			object[] array = new object[2];
			array[0] = data;
			instance.OpenView(roguelikeSpecialDetailView, array, null);
		}

		// Token: 0x0401B54E RID: 111950
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialItem, RogueGainEntry> SpecialItemLayout;

		// Token: 0x0401B54F RID: 111951
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0200AF86 RID: 44934
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040354B4 RID: 218292
			public const int SpecialItemLayout = 0;
		}
	}
}
