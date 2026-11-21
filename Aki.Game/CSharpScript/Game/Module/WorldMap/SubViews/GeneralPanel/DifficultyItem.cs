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
	// Token: 0x02003751 RID: 14161
	[NullableContext(1)]
	[Nullable(0)]
	public class DifficultyItem : UiPanelBase, IGridProxy<DarkCoastDeliveryLevelData>
	{
		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x06024D34 RID: 150836 RVA: 0x00A68779 File Offset: 0x00A66979
		// (set) Token: 0x06024D35 RID: 150837 RVA: 0x00A68781 File Offset: 0x00A66981
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

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x06024D36 RID: 150838 RVA: 0x00A6878A File Offset: 0x00A6698A
		// (set) Token: 0x06024D37 RID: 150839 RVA: 0x00A68792 File Offset: 0x00A66992
		public int GridIndex { get; set; }

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x06024D38 RID: 150840 RVA: 0x00A6879B File Offset: 0x00A6699B
		// (set) Token: 0x06024D39 RID: 150841 RVA: 0x00A687A3 File Offset: 0x00A669A3
		public int DisplayIndex { get; set; }

		// Token: 0x06024D3A RID: 150842 RVA: 0x00A687AC File Offset: 0x00A669AC
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

		// Token: 0x06024D3B RID: 150843 RVA: 0x00A68858 File Offset: 0x00A66A58
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

		// Token: 0x06024D3C RID: 150844 RVA: 0x00A6893F File Offset: 0x00A66B3F
		public void Clear()
		{
		}

		// Token: 0x06024D3D RID: 150845 RVA: 0x00A68941 File Offset: 0x00A66B41
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06024D3E RID: 150846 RVA: 0x00A68943 File Offset: 0x00A66B43
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06024D3F RID: 150847 RVA: 0x00A68945 File Offset: 0x00A66B45
		public object GetKey(DarkCoastDeliveryLevelData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
