using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02005775 RID: 22389
	[NullableContext(1)]
	[Nullable(0)]
	internal class KurotatoAttrSelectCardItem : UiPanelBase
	{
		// Token: 0x06038E03 RID: 232963 RVA: 0x00D838D0 File Offset: 0x00D81AD0
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

		// Token: 0x06038E04 RID: 232964 RVA: 0x00D83A84 File Offset: 0x00D81C84
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

		// Token: 0x06038E05 RID: 232965 RVA: 0x00D83B05 File Offset: 0x00D81D05
		protected override void OnBeforeDestroy()
		{
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(false, new List<IKurotatoAttrPreviewDelta>());
		}

		// Token: 0x06038E06 RID: 232966 RVA: 0x00D83B1D File Offset: 0x00D81D1D
		public void SetAttrPreviewCb(Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x06038E07 RID: 232967 RVA: 0x00D83B26 File Offset: 0x00D81D26
		public void ClearAttrPreviewSelection()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(11);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038E08 RID: 232968 RVA: 0x00D83B40 File Offset: 0x00D81D40
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
			List<IKurotatoAttrDisplay> itemAttrDisplayList = KurotatoUtil.GetItemAttrDisplayList(value.EffectIter().ToList<int>(), false, true, false);
			this.AttrScrollList.RefreshByData((from attr in itemAttrDisplayList
			select attr.Text).ToList<string>(), null, false);
			base.GetItem(7).SetUIActive(data.IsRecommend);
		}

		// Token: 0x06038E09 RID: 232969 RVA: 0x00D83CB4 File Offset: 0x00D81EB4
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

		// Token: 0x06038E0A RID: 232970 RVA: 0x00D83CF4 File Offset: 0x00D81EF4
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

		// Token: 0x06038E0B RID: 232971 RVA: 0x00D83D40 File Offset: 0x00D81F40
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

		// Token: 0x06038E0C RID: 232972 RVA: 0x00D83D66 File Offset: 0x00D81F66
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

		// Token: 0x06038E0D RID: 232973 RVA: 0x00D83D8C File Offset: 0x00D81F8C
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
			foreach (IKurotatoAttrDisplay kurotatoAttrDisplay in KurotatoUtil.GetItemAttrPreviewList(itemConfigByItemId.Value.EffectIter().ToList<int>()))
			{
				list.Add(new KurotatoAttrPreviewDelta
				{
					PropertyId = kurotatoAttrDisplay.PropertyId,
					ValueStr = kurotatoAttrDisplay.Text
				});
			}
			return list;
		}

		// Token: 0x0401DD40 RID: 122176
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<AttrListItem, string> AttrScrollList;

		// Token: 0x0401DD41 RID: 122177
		[Nullable(2)]
		private IKurotatoAttrSelectCardData Data;

		// Token: 0x0401DD42 RID: 122178
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200B987 RID: 47495
		[NullableContext(0)]
		private class ECardItemComp
		{
			// Token: 0x04038191 RID: 229777
			public const int TextureQuality = 0;

			// Token: 0x04038192 RID: 229778
			public const int TextureCircleLight = 1;

			// Token: 0x04038193 RID: 229779
			public const int TextureCircleQuality = 2;

			// Token: 0x04038194 RID: 229780
			public const int SpriteQualityFrame = 3;

			// Token: 0x04038195 RID: 229781
			public const int TextureQualityLine = 4;

			// Token: 0x04038196 RID: 229782
			public const int TextureIcon = 5;

			// Token: 0x04038197 RID: 229783
			public const int TextName = 6;

			// Token: 0x04038198 RID: 229784
			public const int PanelRecommend = 7;

			// Token: 0x04038199 RID: 229785
			public const int ScrollAttrList = 8;

			// Token: 0x0403819A RID: 229786
			public const int Toggle = 11;
		}
	}
}
