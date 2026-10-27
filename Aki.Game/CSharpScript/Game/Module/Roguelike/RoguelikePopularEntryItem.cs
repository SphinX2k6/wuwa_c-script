using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DDD RID: 19933
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePopularEntryItem : GridProxyAbstract<RoguelikeEntryData>
	{
		// Token: 0x0603373B RID: 210747 RVA: 0x00C05778 File Offset: 0x00C03978
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			if (this.IsValid)
			{
				num2 = 1;
				List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
				Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
				num = 0;
				*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickSelf));
				this.BtnBindInfo = list2;
			}
		}

		// Token: 0x0603373C RID: 210748 RVA: 0x00C058AA File Offset: 0x00C03AAA
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(4).SetUIActive(true);
			this.Vm = RoguelikeModel.Instance.GetEntranceViewModel();
		}

		// Token: 0x0603373D RID: 210749 RVA: 0x00C058DC File Offset: 0x00C03ADC
		[NullableContext(1)]
		public override void Refresh(RoguelikeEntryData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			data.SetEntryToggleState = new Action<bool, bool>(this.SetToggleState);
			string icon = data.GetConfig().Icon;
			bool flag = icon.Contains("Atlas");
			UUITexture texture = base.GetTexture(2);
			texture.SetUIActive(!flag);
			UUISprite sprite = base.GetSprite(3);
			sprite.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(icon, sprite, false, null, null);
			}
			else
			{
				base.SetTextureByPath(icon, texture, null, null);
			}
			bool entryDataActiveState = this.Vm.GetEntryDataActiveState(data);
			bool isUnlock = this.Vm.EntriesDataGroupMap[data.GroupId].IsUnlock;
			FColor color = FColor.FromHex(RoguelikeConfig.Instance.GetRogueHotEntryTypeConfig((int)data.Type).Value.ArrowColor);
			base.GetTexture(1).SetColor(color);
			base.GetItem(5).SetUIActive(!isUnlock);
			this.SetActiveState(entryDataActiveState);
		}

		// Token: 0x0603373E RID: 210750 RVA: 0x00C059E8 File Offset: 0x00C03BE8
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.SetEntryToggleState = null;
			}
		}

		// Token: 0x0603373F RID: 210751 RVA: 0x00C059FE File Offset: 0x00C03BFE
		private void OnClickSelf(EToggleState state)
		{
			RoguelikeEntranceViewModel vm = this.Vm;
			if (vm == null)
			{
				return;
			}
			Action<bool, RoguelikeEntryData> onClickEntry = vm.OnClickEntry;
			if (onClickEntry == null)
			{
				return;
			}
			onClickEntry(state == EToggleState.ETT_Checked, this.Data);
		}

		// Token: 0x06033740 RID: 210752 RVA: 0x00C05A24 File Offset: 0x00C03C24
		public void SetEmpty()
		{
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
			base.SetUiActive(true);
		}

		// Token: 0x06033741 RID: 210753 RVA: 0x00C05A54 File Offset: 0x00C03C54
		public void SetActiveState(bool isActive)
		{
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayOrReplaySequenceByName(isActive ? "True" : "False", false, null);
		}

		// Token: 0x06033742 RID: 210754 RVA: 0x00C05A92 File Offset: 0x00C03C92
		public void SetFocusState(bool isFocus)
		{
		}

		// Token: 0x06033743 RID: 210755 RVA: 0x00C05A94 File Offset: 0x00C03C94
		private void SetToggleState(bool isSelected, bool bFireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x0401B507 RID: 111879
		private RoguelikeEntranceViewModel Vm;

		// Token: 0x0401B508 RID: 111880
		private RoguelikeEntryData Data;

		// Token: 0x0401B509 RID: 111881
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B50A RID: 111882
		public bool IsValid = true;

		// Token: 0x0200AF62 RID: 44898
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04035417 RID: 218135
			public const int ToggleSelf = 0;

			// Token: 0x04035418 RID: 218136
			public const int TexArrow = 1;

			// Token: 0x04035419 RID: 218137
			public const int TexIcon = 2;

			// Token: 0x0403541A RID: 218138
			public const int SpriteIcon = 3;

			// Token: 0x0403541B RID: 218139
			public const int ItemActive = 4;

			// Token: 0x0403541C RID: 218140
			public const int ItemLock = 5;
		}
	}
}
