using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.MingSu;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.GeneralPanel
{
	// Token: 0x02004820 RID: 18464
	[NullableContext(1)]
	[Nullable(0)]
	public class DifficultyItem : UiPanelBase, IGridProxy<DarkCoastDeliveryLevelData>
	{
		// Token: 0x170078E9 RID: 30953
		// (get) Token: 0x06030564 RID: 197988 RVA: 0x00B386AD File Offset: 0x00B368AD
		// (set) Token: 0x06030565 RID: 197989 RVA: 0x00B386B5 File Offset: 0x00B368B5
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<DarkCoastDeliveryLevelData>, DarkCoastDeliveryLevelData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x170078EA RID: 30954
		// (get) Token: 0x06030566 RID: 197990 RVA: 0x00B386BE File Offset: 0x00B368BE
		// (set) Token: 0x06030567 RID: 197991 RVA: 0x00B386C6 File Offset: 0x00B368C6
		public int GridIndex { get; set; }

		// Token: 0x170078EB RID: 30955
		// (get) Token: 0x06030568 RID: 197992 RVA: 0x00B386CF File Offset: 0x00B368CF
		// (set) Token: 0x06030569 RID: 197993 RVA: 0x00B386D7 File Offset: 0x00B368D7
		public int DisplayIndex { get; set; }

		// Token: 0x0603056A RID: 197994 RVA: 0x00B386E0 File Offset: 0x00B368E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603056B RID: 197995 RVA: 0x00B3878C File Offset: 0x00B3698C
		public void Refresh(DarkCoastDeliveryLevelData data, bool isSelected, int gridIndex)
		{
			string resourceId = (data.GetDarkCoastDeliveryGuardState() == MingSuDefine.EDarkCoastDeliveryLevelDataState.Received) ? "T_MapDifficultyTick" : "T_MapDifficultyEmpty";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "DarkShoreBossFirst_Text", Array.Empty<object>());
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			UUIText text3 = base.GetText(3);
			if (text3 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Config.RewardCount);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603056C RID: 197996 RVA: 0x00B38873 File Offset: 0x00B36A73
		public void Clear()
		{
		}

		// Token: 0x0603056D RID: 197997 RVA: 0x00B38875 File Offset: 0x00B36A75
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603056E RID: 197998 RVA: 0x00B38877 File Offset: 0x00B36A77
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603056F RID: 197999 RVA: 0x00B38879 File Offset: 0x00B36A79
		public object GetKey(DarkCoastDeliveryLevelData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
