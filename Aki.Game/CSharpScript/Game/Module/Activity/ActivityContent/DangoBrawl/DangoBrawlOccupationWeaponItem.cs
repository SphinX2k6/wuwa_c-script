using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005763 RID: 22371
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlOccupationWeaponItem : GridProxyAbstract<DangoBrawlOccupationWeaponItemData>
	{
		// Token: 0x17006A77 RID: 27255
		// (get) Token: 0x060372D3 RID: 226003 RVA: 0x00F67089 File Offset: 0x00F65289
		public DangoBrawlOccupationWeaponItemData ItemData
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x060372D4 RID: 226004 RVA: 0x00F67094 File Offset: 0x00F65294
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

		// Token: 0x060372D5 RID: 226005 RVA: 0x00F671BF File Offset: 0x00F653BF
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x060372D6 RID: 226006 RVA: 0x00F671D3 File Offset: 0x00F653D3
		protected override void OnBeforeDestroy()
		{
			this.BlurGridPool.Clear();
		}

		// Token: 0x060372D7 RID: 226007 RVA: 0x00F671E0 File Offset: 0x00F653E0
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

		// Token: 0x060372D8 RID: 226008 RVA: 0x00F672D0 File Offset: 0x00F654D0
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

		// Token: 0x060372D9 RID: 226009 RVA: 0x00F6740E File Offset: 0x00F6560E
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x060372DA RID: 226010 RVA: 0x00F67417 File Offset: 0x00F65617
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x060372DB RID: 226011 RVA: 0x00F67420 File Offset: 0x00F65620
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

		// Token: 0x060372DC RID: 226012 RVA: 0x00F6744B File Offset: 0x00F6564B
		private void OnToggleClick(EToggleState state)
		{
			Action<int, DangoBrawlOccupationWeaponItemData> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GridIndex, this.Data);
		}

		// Token: 0x060372DD RID: 226013 RVA: 0x00F67469 File Offset: 0x00F65669
		public override object GetKey(DangoBrawlOccupationWeaponItemData data, int displayIndex)
		{
			return data.PanelPos;
		}

		// Token: 0x0401D292 RID: 119442
		private DangoBrawlOccupationWeaponItemData Data;

		// Token: 0x0401D293 RID: 119443
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x0401D294 RID: 119444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, DangoBrawlOccupationWeaponItemData> OnClickToggleBack;

		// Token: 0x0200B36C RID: 45932
		[NullableContext(0)]
		private enum EItemComponent
		{
			// Token: 0x04037742 RID: 227138
			TexQuality,
			// Token: 0x04037743 RID: 227139
			TexIcon,
			// Token: 0x04037744 RID: 227140
			GridContent,
			// Token: 0x04037745 RID: 227141
			SprGrid,
			// Token: 0x04037746 RID: 227142
			TogItem,
			// Token: 0x04037747 RID: 227143
			UniqueWeaponItem = 9
		}
	}
}
