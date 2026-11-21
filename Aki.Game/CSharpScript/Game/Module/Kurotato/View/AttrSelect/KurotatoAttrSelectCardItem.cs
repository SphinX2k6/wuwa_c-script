using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200474C RID: 18252
	[NullableContext(1)]
	[Nullable(0)]
	internal class KurotatoAttrSelectCardItem : UiPanelBase
	{
		// Token: 0x0602DD13 RID: 187667 RVA: 0x00CD23D8 File Offset: 0x00CD05D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action<EToggleState>(this.OnTogglePreviewState));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DD14 RID: 187668 RVA: 0x00CD258C File Offset: 0x00CD078C
		protected override void OnStart()
		{
			this.AttrScrollList = new GenericScrollViewNew<AttrListItem, string>(base.GetScrollViewWithScrollbar(8), () => new AttrListItem(), null, false, null);
			UUIExtendToggle extendToggle = base.GetExtendToggle(11);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPreviewHoverEnter));
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnPointExitCallBack.Bind(new Action<EToggleState>(this.OnPreviewHoverExit));
		}

		// Token: 0x0602DD15 RID: 187669 RVA: 0x00CD260D File Offset: 0x00CD080D
		protected override void OnBeforeDestroy()
		{
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(false, new List<IKurotatoAttrPreviewDelta>());
		}

		// Token: 0x0602DD16 RID: 187670 RVA: 0x00CD2625 File Offset: 0x00CD0825
		public void SetAttrPreviewCb(Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x0602DD17 RID: 187671 RVA: 0x00CD262E File Offset: 0x00CD082E
		public void ClearAttrPreviewSelection()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(11);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602DD18 RID: 187672 RVA: 0x00CD2648 File Offset: 0x00CD0848
		public void Refresh(IKurotatoAttrSelectCardData data)
		{
			this.Data = data;
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoItem value = instance.GetItemConfigByItemId(data.ItemId).Value;
			KurotatoQuality value2 = instance.GetQualityByQuality(value.Quality).Value;
			base.SetTextureByPath(value2.AttrSelectQualityBg, base.GetTexture(0), null, null);
			base.GetTexture(1).SetColor(FColor.FromHex(value2.AttrSelectCircleLight));
			base.GetTexture(2).SetColor(FColor.FromHex(value2.AttrSelectCircle));
			base.GetSprite(3).SetColor(FColor.FromHex(value2.AttrSelectFrame));
			base.SetTextureByPath(value2.AttrSelectLineTexture, base.GetTexture(4), null, null);
			base.SetTextureByPath(value.Icon, base.GetTexture(5), null, null);
			base.GetText(6).ShowTextNew(value.Name);
			base.GetText(6).SetColor(FColor.FromHex(value2.AttrSelectCircleLight));
			List<IKurotatoAttrDisplay> itemAttrDisplayList = KurotatoUtil.GetItemAttrDisplayList(new List<int>(value.EffectIter()), false, true, false);
			List<string> list = new List<string>(itemAttrDisplayList.Count);
			foreach (IKurotatoAttrDisplay kurotatoAttrDisplay in itemAttrDisplayList)
			{
				list.Add(kurotatoAttrDisplay.Text);
			}
			this.AttrScrollList.RefreshByData(list, null, false);
			base.GetItem(7).SetUIActive(data.IsRecommend);
		}

		// Token: 0x0602DD19 RID: 187673 RVA: 0x00CD27E4 File Offset: 0x00CD09E4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0 || configParams[0] != "UpgradeRecommend")
			{
				return null;
			}
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				item,
				item
			};
		}

		// Token: 0x0602DD1A RID: 187674 RVA: 0x00CD2824 File Offset: 0x00CD0A24
		private void OnTogglePreviewState(EToggleState state)
		{
			if (!Info.Instance.IsInTouch())
			{
				return;
			}
			if (state == EToggleState.ETT_Checked)
			{
				Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
				if (attrPreviewCb == null)
				{
					return;
				}
				attrPreviewCb(true, this.BuildPreviewDeltas());
				return;
			}
			else
			{
				Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb2 = this.AttrPreviewCb;
				if (attrPreviewCb2 == null)
				{
					return;
				}
				attrPreviewCb2(false, new List<IKurotatoAttrPreviewDelta>());
				return;
			}
		}

		// Token: 0x0602DD1B RID: 187675 RVA: 0x00CD2870 File Offset: 0x00CD0A70
		private void OnPreviewHoverEnter(EToggleState state)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(true, this.BuildPreviewDeltas());
		}

		// Token: 0x0602DD1C RID: 187676 RVA: 0x00CD2896 File Offset: 0x00CD0A96
		private void OnPreviewHoverExit(EToggleState state)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(false, new List<IKurotatoAttrPreviewDelta>());
		}

		// Token: 0x0602DD1D RID: 187677 RVA: 0x00CD28BC File Offset: 0x00CD0ABC
		private IReadOnlyList<IKurotatoAttrPreviewDelta> BuildPreviewDeltas()
		{
			List<IKurotatoAttrPreviewDelta> list = new List<IKurotatoAttrPreviewDelta>();
			if (this.Data == null)
			{
				return list;
			}
			KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(this.Data.ItemId);
			if (itemConfigByItemId == null)
			{
				return list;
			}
			foreach (IKurotatoAttrDisplay kurotatoAttrDisplay in KurotatoUtil.GetItemAttrPreviewList(new List<int>(itemConfigByItemId.Value.EffectIter())))
			{
				list.Add(new KurotatoAttrPreviewDelta
				{
					PropertyId = kurotatoAttrDisplay.PropertyId,
					ValueStr = kurotatoAttrDisplay.Text
				});
			}
			return list;
		}

		// Token: 0x040187D6 RID: 100310
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<AttrListItem, string> AttrScrollList;

		// Token: 0x040187D7 RID: 100311
		[Nullable(2)]
		private IKurotatoAttrSelectCardData Data;

		// Token: 0x040187D8 RID: 100312
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200A3A1 RID: 41889
		[NullableContext(0)]
		private class ECardItemComp
		{
			// Token: 0x04032B8B RID: 207755
			public const int TextureQuality = 0;

			// Token: 0x04032B8C RID: 207756
			public const int TextureCircleLight = 1;

			// Token: 0x04032B8D RID: 207757
			public const int TextureCircleQuality = 2;

			// Token: 0x04032B8E RID: 207758
			public const int SpriteQualityFrame = 3;

			// Token: 0x04032B8F RID: 207759
			public const int TextureQualityLine = 4;

			// Token: 0x04032B90 RID: 207760
			public const int TextureIcon = 5;

			// Token: 0x04032B91 RID: 207761
			public const int TextName = 6;

			// Token: 0x04032B92 RID: 207762
			public const int PanelRecommend = 7;

			// Token: 0x04032B93 RID: 207763
			public const int ScrollAttrList = 8;

			// Token: 0x04032B94 RID: 207764
			public const int Toggle = 11;
		}
	}
}
