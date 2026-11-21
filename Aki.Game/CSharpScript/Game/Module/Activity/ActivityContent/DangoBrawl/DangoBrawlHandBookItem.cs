using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005754 RID: 22356
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlHandBookItem : SyncGridProxyAbstract<DangoBrawlHandBookItemData>
	{
		// Token: 0x060371F0 RID: 225776 RVA: 0x00F61FDC File Offset: 0x00F601DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060371F1 RID: 225777 RVA: 0x00F6216B File Offset: 0x00F6036B
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x060371F2 RID: 225778 RVA: 0x00F62190 File Offset: 0x00F60390
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.Clear();
			}
			this.SeqPlayer = null;
			this.BlurGridPool.Clear();
		}

		// Token: 0x060371F3 RID: 225779 RVA: 0x00F621B8 File Offset: 0x00F603B8
		[NullableContext(1)]
		public override void Refresh(DangoBrawlHandBookItemData data)
		{
			this.ItemData = data;
			base.SetTextureByPath(DangoBrawlConfig.Instance.GetItemQualityConfigById(data.ItemQuality).Value.HandBookItemIcon, base.GetTexture(1), null, null);
			UUITexture texture = base.GetTexture(2);
			base.SetTextureByPath(data.ItemIcon, texture, null, null);
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(data.ItemId);
			if (dangoBrawlItemById != null)
			{
				float iconHandBookScale = dangoBrawlItemById.Value.IconHandBookScale;
				texture.SetRelativeScale3D(new FVector(iconHandBookScale, iconHandBookScale, iconHandBookScale));
				bool isSpeItem = dangoBrawlItemById.Value.IsSpeItem;
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(isSpeItem);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.ItemName, Array.Empty<object>());
			UUIItem item2 = base.GetItem(6);
			bool flag = !data.IsUnlocked;
			bool valueOrDefault = data.IsNew.GetValueOrDefault();
			if (item2 != null)
			{
				item2.SetUIActive(flag || valueOrDefault);
			}
			string sequenceName = flag ? "Lock" : "Unlock";
			if (valueOrDefault)
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer != null)
				{
					seqPlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
				}
				this.SeqIsLocked = new bool?(flag);
				data.IsNew = new bool?(false);
				Action<int> onUnlockAnimPlayed = this.OnUnlockAnimPlayed;
				if (onUnlockAnimPlayed != null)
				{
					onUnlockAnimPlayed(data.ItemId);
				}
			}
			else if (this.SeqIsLocked != null)
			{
				bool? seqIsLocked = this.SeqIsLocked;
				bool flag2 = flag;
				if (!(seqIsLocked.GetValueOrDefault() == flag2 & seqIsLocked != null))
				{
					LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
					if (seqPlayer2 != null)
					{
						seqPlayer2.PlayOrReplaySequenceByName(sequenceName, false, null);
					}
					LevelSequencePlayer seqPlayer3 = this.SeqPlayer;
					if (seqPlayer3 != null)
					{
						seqPlayer3.EndSequenceLastFrame(sequenceName);
					}
					this.SeqIsLocked = new bool?(flag);
				}
			}
			EToggleState state = this.IsSelected(data.ItemId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(state, false, false, false);
			}
			PanelPos[] posList = DangoBrawlUtil.RotatePanelPosList(data.ItemId, EDangoBrawlRotate.Direction0);
			this.RefreshBlurGrids(posList);
		}

		// Token: 0x060371F4 RID: 225780 RVA: 0x00F623E8 File Offset: 0x00F605E8
		[NullableContext(1)]
		private void RefreshBlurGrids(PanelPos[] posList)
		{
			UUISprite sprite = base.GetSprite(5);
			UUIItem item = base.GetItem(4);
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

		// Token: 0x060371F5 RID: 225781 RVA: 0x00F62526 File Offset: 0x00F60726
		private void OnToggleClick(EToggleState state)
		{
			if (this.ItemData != null)
			{
				Action<DangoBrawlHandBookItemData> onClickCb = this.OnClickCb;
				if (onClickCb == null)
				{
					return;
				}
				onClickCb(this.ItemData);
			}
		}

		// Token: 0x060371F6 RID: 225782 RVA: 0x00F62548 File Offset: 0x00F60748
		public UUIItem GetNavigationItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.RootUIComp.Get();
		}

		// Token: 0x0401D230 RID: 119344
		private DangoBrawlHandBookItemData ItemData;

		// Token: 0x0401D231 RID: 119345
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401D232 RID: 119346
		private bool? SeqIsLocked;

		// Token: 0x0401D233 RID: 119347
		[Nullable(1)]
		private readonly List<UUIItem> BlurGridPool = new List<UUIItem>();

		// Token: 0x0401D234 RID: 119348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlHandBookItemData> OnClickCb;

		// Token: 0x0401D235 RID: 119349
		public Action<int> OnUnlockAnimPlayed;

		// Token: 0x0401D236 RID: 119350
		public Func<int, bool> IsSelected = (int _) => false;

		// Token: 0x0200B343 RID: 45891
		[NullableContext(0)]
		private enum EHandBookItemComponent
		{
			// Token: 0x0403764D RID: 226893
			SprFrameSelect,
			// Token: 0x0403764E RID: 226894
			TexQuality,
			// Token: 0x0403764F RID: 226895
			TexIcon,
			// Token: 0x04037650 RID: 226896
			TxtName,
			// Token: 0x04037651 RID: 226897
			GridContent,
			// Token: 0x04037652 RID: 226898
			SprGrid,
			// Token: 0x04037653 RID: 226899
			UnlockItem,
			// Token: 0x04037654 RID: 226900
			TogItem,
			// Token: 0x04037655 RID: 226901
			NewItem,
			// Token: 0x04037656 RID: 226902
			CostItem,
			// Token: 0x04037657 RID: 226903
			UniqueWeaponItem
		}
	}
}
