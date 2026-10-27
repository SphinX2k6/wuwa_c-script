using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006813 RID: 26643
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlOccupationWeaponItem : GridProxyAbstract<DangoBrawlOccupationWeaponItemData>
	{
		// Token: 0x17009736 RID: 38710
		// (get) Token: 0x0604277E RID: 272254 RVA: 0x01025B45 File Offset: 0x01023D45
		public DangoBrawlOccupationWeaponItemData ItemData
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0604277F RID: 272255 RVA: 0x01025B50 File Offset: 0x01023D50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042780 RID: 272256 RVA: 0x01025C7B File Offset: 0x01023E7B
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x06042781 RID: 272257 RVA: 0x01025C8F File Offset: 0x01023E8F
		protected override void OnBeforeDestroy()
		{
			this.BlurGridPool.Clear();
		}

		// Token: 0x06042782 RID: 272258 RVA: 0x01025C9C File Offset: 0x01023E9C
		public override void Refresh(DangoBrawlOccupationWeaponItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(data.WeaponId);
			base.SetTextureByPath(DangoBrawlConfig.Instance.GetItemQualityConfigById(itemConfigById.Value.Quality).Value.HandBookSmallItemIcon, base.GetTexture(0), null, null);
			UUITexture texture = base.GetTexture(1);
			base.SetTextureByPath(itemConfigById.Value.IconHandBook, texture, null, null);
			float iconOccupationScale = itemConfigById.Value.IconOccupationScale2;
			texture.SetRelativeScale3D(new FVector(iconOccupationScale, iconOccupationScale, iconOccupationScale));
			bool isSpeItem = itemConfigById.Value.IsSpeItem;
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(isSpeItem);
			}
			PanelPos[] posList = DangoBrawlUtil.RotatePanelPosList(data.WeaponId, EDangoBrawlRotate.Direction0);
			this.RefreshBlurGrids(posList);
		}

		// Token: 0x06042783 RID: 272259 RVA: 0x01025D8C File Offset: 0x01023F8C
		private void RefreshBlurGrids(PanelPos[] posList)
		{
			UUISprite sprite = base.GetSprite(3);
			UUIItem item = base.GetItem(2);
			if (sprite == null || item == null)
			{
				return;
			}
			float height = sprite.GetHeight();
			FVector relativeLocation = sprite.RelativeLocation;
			ValueTuple<int, int, int, int> panelPosBound = DangoBrawlUtil.GetPanelPosBound(posList);
			int item2 = panelPosBound.Item2;
			int item3 = panelPosBound.Item3;
			FVector fvector = new FVector((float)(-(float)item2) * height, (float)item3 * height, 0f);
			sprite.SetUIActive(false);
			for (int i = 0; i < posList.Length; i++)
			{
				PanelPos panelPos = posList[i];
				FVector fvector2 = new FVector((float)panelPos.ColIndex * height, (float)(-(float)panelPos.RowIndex) * height, 0f);
				FVector fvector3 = relativeLocation + fvector2;
				FVector uirelativeLocation = fvector3 + fvector;
				UUIItem uuiitem = (i < this.BlurGridPool.Count) ? this.BlurGridPool[i] : null;
				if (uuiitem == null)
				{
					uuiitem = LguiUtil.Instance.CopyItem(sprite, item);
					this.BlurGridPool.Add(uuiitem);
				}
				uuiitem.SetUIActive(true);
				uuiitem.SetUIRelativeLocation(uirelativeLocation);
			}
			for (int j = posList.Length; j < this.BlurGridPool.Count; j++)
			{
				this.BlurGridPool[j].SetUIActive(false);
			}
		}

		// Token: 0x06042784 RID: 272260 RVA: 0x01025ECA File Offset: 0x010240CA
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06042785 RID: 272261 RVA: 0x01025ED3 File Offset: 0x010240D3
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06042786 RID: 272262 RVA: 0x01025EDC File Offset: 0x010240DC
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state2, false, false, false);
		}

		// Token: 0x06042787 RID: 272263 RVA: 0x01025F07 File Offset: 0x01024107
		private void OnToggleClick(EToggleState state)
		{
			Action<int, DangoBrawlOccupationWeaponItemData> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GridIndex, this.Data);
		}

		// Token: 0x06042788 RID: 272264 RVA: 0x01025F25 File Offset: 0x01024125
		public override object GetKey(DangoBrawlOccupationWeaponItemData data, int displayIndex)
		{
			return data.PanelPos;
		}

		// Token: 0x04022A35 RID: 141877
		private DangoBrawlOccupationWeaponItemData Data;

		// Token: 0x04022A36 RID: 141878
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x04022A37 RID: 141879
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, DangoBrawlOccupationWeaponItemData> OnClickToggleBack;

		// Token: 0x0200C99F RID: 51615
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x0403CE55 RID: 249429
			TexQuality,
			// Token: 0x0403CE56 RID: 249430
			TexIcon,
			// Token: 0x0403CE57 RID: 249431
			GridContent,
			// Token: 0x0403CE58 RID: 249432
			SprGrid,
			// Token: 0x0403CE59 RID: 249433
			TogItem,
			// Token: 0x0403CE5A RID: 249434
			UniqueWeaponItem = 9
		}
	}
}
