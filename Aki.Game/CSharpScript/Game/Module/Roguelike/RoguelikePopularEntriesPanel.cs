using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DDA RID: 19930
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikePopularEntriesPanel : UiPanelBase
	{
		// Token: 0x06033720 RID: 210720 RVA: 0x00C04C18 File Offset: 0x00C02E18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033721 RID: 210721 RVA: 0x00C04E7C File Offset: 0x00C0307C
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikePopularEntriesPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikePopularEntriesPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033722 RID: 210722 RVA: 0x00C04EBF File Offset: 0x00C030BF
		private RoguelikePopularEntriesGroup CreateEntriesGroupItem()
		{
			return new RoguelikePopularEntriesGroup
			{
				IsLastGroup = new Func<int, bool>(this.IsLastGroup)
			};
		}

		// Token: 0x06033723 RID: 210723 RVA: 0x00C04ED8 File Offset: 0x00C030D8
		private RoguelikePopularEntryTypeItem CreateEntriesTypeItem()
		{
			return new RoguelikePopularEntryTypeItem();
		}

		// Token: 0x06033724 RID: 210724 RVA: 0x00C04EDF File Offset: 0x00C030DF
		private bool IsLastGroup(int index)
		{
			return index == RoguelikeModel.Instance.GetEntranceViewModel().EntriesDataGroupList.Count - 1;
		}

		// Token: 0x06033725 RID: 210725 RVA: 0x00C04EFA File Offset: 0x00C030FA
		public void Refresh(RoguelikeEntranceViewModel vm)
		{
			if (vm.CurrentSelectEntryData != null)
			{
				this.RefreshSelectEntry(vm, vm.CurrentSelectEntryData, false);
			}
		}

		// Token: 0x06033726 RID: 210726 RVA: 0x00C04F14 File Offset: 0x00C03114
		public void ScrollToGroup(int groupId)
		{
			UUIItem itemByKey = this.LayoutEntriesGroup.GetItemByKey(groupId);
			if (itemByKey != null)
			{
				this.LayoutEntriesGroup.LateScrollTo(itemByKey, null, true);
			}
		}

		// Token: 0x06033727 RID: 210727 RVA: 0x00C04F44 File Offset: 0x00C03144
		public void RefreshSelectEntry(RoguelikeEntranceViewModel vm, RoguelikeEntryData entryData, bool isSwitch = false)
		{
			RogueHotEntryType? rogueHotEntryTypeConfig = RoguelikeConfig.Instance.GetRogueHotEntryTypeConfig((int)entryData.Type);
			FColor color = FColor.FromHex(rogueHotEntryTypeConfig.Value.DescRingColor);
			UUITexture texture = base.GetTexture(4);
			if (texture != null)
			{
				texture.SetColor(color);
			}
			base.SetTextureByPath(rogueHotEntryTypeConfig.Value.Icon, base.GetTexture(8), null, null);
			UUIText text = base.GetText(9);
			LguiUtil.Instance.SetLocalTextNew(text, rogueHotEntryTypeConfig.Value.Name, Array.Empty<object>());
			FColor color2 = FColor.FromHex(rogueHotEntryTypeConfig.Value.NameColor);
			text.SetColor(color2);
			UUISprite sprite = base.GetSprite(16);
			this.SetSpriteByPath(rogueHotEntryTypeConfig.Value.FrameIcon, sprite, false, null, null);
			UUIText text2 = base.GetText(12);
			bool entryDataActiveState = vm.GetEntryDataActiveState(entryData);
			string textStringId = vm.EntriesDataGroupMap[entryData.GroupId].IsUnlock ? (entryDataActiveState ? "RogueHotEntry_Activate" : "RogueHotEntry_Unactivate") : "RogueHotEntry_Lock";
			LguiUtil.Instance.SetLocalTextNew(text2, textStringId, Array.Empty<object>());
			UUIItem uuiitem = text2;
			bool bUseChangeColor = !entryDataActiveState;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.GetItem(10).SetUIActive(!entryDataActiveState);
			base.GetItem(11).SetUIActive(entryDataActiveState);
			RogueHotEntry config = entryData.GetConfig();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), config.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), config.Desc, config.DescParam());
			string icon = config.Icon;
			bool flag = icon.Contains("Atlas");
			UUITexture texture2 = base.GetTexture(5);
			texture2.SetUIActive(!flag);
			UUISprite sprite2 = base.GetSprite(6);
			sprite2.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(icon, sprite2, false, null, null);
			}
			else
			{
				base.SetTextureByPath(icon, texture2, null, null);
			}
			if (isSwitch)
			{
				base.GetUiNiagara(14).ActivateSystem(true);
				this.LevelSequencePlayer.PlayOrReplaySequenceByName("Sle", false, null);
			}
		}

		// Token: 0x0401B4F7 RID: 111863
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikePopularEntriesGroup, RoguelikeEntriesGroupData> LayoutEntriesGroup;

		// Token: 0x0401B4F8 RID: 111864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoguelikePopularEntryTypeItem, ERoguelikeEntryType> LayoutEntriesType;

		// Token: 0x0401B4F9 RID: 111865
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AF5F RID: 44895
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035400 RID: 218112
			public const int LayoutIcon = 0;

			// Token: 0x04035401 RID: 218113
			public const int ItemIcon = 1;

			// Token: 0x04035402 RID: 218114
			public const int LayoutEntriesGroup = 2;

			// Token: 0x04035403 RID: 218115
			public const int ItemEntriesGroup = 3;

			// Token: 0x04035404 RID: 218116
			public const int TexEntryTypeRing = 4;

			// Token: 0x04035405 RID: 218117
			public const int TexEntry = 5;

			// Token: 0x04035406 RID: 218118
			public const int SpriteEntry = 6;

			// Token: 0x04035407 RID: 218119
			public const int TxtEntryName = 7;

			// Token: 0x04035408 RID: 218120
			public const int TexEntryTypeIcon = 8;

			// Token: 0x04035409 RID: 218121
			public const int TxtTypeName = 9;

			// Token: 0x0403540A RID: 218122
			public const int ItemDeactivate = 10;

			// Token: 0x0403540B RID: 218123
			public const int ItemActive = 11;

			// Token: 0x0403540C RID: 218124
			public const int TxtActive = 12;

			// Token: 0x0403540D RID: 218125
			public const int TxtEntryDesc = 13;

			// Token: 0x0403540E RID: 218126
			public const int NiagaraTxtEntryDesc = 14;

			// Token: 0x0403540F RID: 218127
			public const int PanelEntry = 15;

			// Token: 0x04035410 RID: 218128
			public const int FrameIcon = 16;
		}
	}
}
