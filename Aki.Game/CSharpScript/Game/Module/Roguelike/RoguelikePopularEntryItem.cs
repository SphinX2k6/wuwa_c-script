using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DA6 RID: 15782
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePopularEntryItem : GridProxyAbstract<RoguelikeEntryData>
	{
		// Token: 0x060285A6 RID: 165286 RVA: 0x00B4EC88 File Offset: 0x00B4CE88
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

		// Token: 0x060285A7 RID: 165287 RVA: 0x00B4EDBA File Offset: 0x00B4CFBA
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(4).SetUIActive(true);
			this.Vm = RoguelikeModel.Instance.GetEntranceViewModel();
		}

		// Token: 0x060285A8 RID: 165288 RVA: 0x00B4EDEC File Offset: 0x00B4CFEC
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

		// Token: 0x060285A9 RID: 165289 RVA: 0x00B4EEF8 File Offset: 0x00B4D0F8
		protected override void OnBeforeDestroy()
		{
			if (this.Data != null)
			{
				this.Data.SetEntryToggleState = null;
			}
		}

		// Token: 0x060285AA RID: 165290 RVA: 0x00B4EF0E File Offset: 0x00B4D10E
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

		// Token: 0x060285AB RID: 165291 RVA: 0x00B4EF34 File Offset: 0x00B4D134
		public void SetEmpty()
		{
			base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(false);
			base.SetUiActive(true);
		}

		// Token: 0x060285AC RID: 165292 RVA: 0x00B4EF64 File Offset: 0x00B4D164
		public void SetActiveState(bool isActive)
		{
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayOrReplaySequenceByName(isActive ? "True" : "False", false, null);
		}

		// Token: 0x060285AD RID: 165293 RVA: 0x00B4EFA2 File Offset: 0x00B4D1A2
		public void SetFocusState(bool isFocus)
		{
		}

		// Token: 0x060285AE RID: 165294 RVA: 0x00B4EFA4 File Offset: 0x00B4D1A4
		private void SetToggleState(bool isSelected, bool bFireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x04015EDA RID: 89818
		private RoguelikeEntranceViewModel Vm;

		// Token: 0x04015EDB RID: 89819
		private RoguelikeEntryData Data;

		// Token: 0x04015EDC RID: 89820
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015EDD RID: 89821
		public bool IsValid = true;

		// Token: 0x02009997 RID: 39319
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402FE4A RID: 196170
			public const int ToggleSelf = 0;

			// Token: 0x0402FE4B RID: 196171
			public const int TexArrow = 1;

			// Token: 0x0402FE4C RID: 196172
			public const int TexIcon = 2;

			// Token: 0x0402FE4D RID: 196173
			public const int SpriteIcon = 3;

			// Token: 0x0402FE4E RID: 196174
			public const int ItemActive = 4;

			// Token: 0x0402FE4F RID: 196175
			public const int ItemLock = 5;
		}
	}
}
