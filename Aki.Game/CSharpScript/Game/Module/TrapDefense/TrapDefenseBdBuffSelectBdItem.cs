using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A84 RID: 14980
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBdBuffSelectBdItem : GridProxyAbstract<TrapDefenseBdData>
	{
		// Token: 0x060267BD RID: 157629 RVA: 0x00AC7E78 File Offset: 0x00AC6078
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleSelf));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060267BE RID: 157630 RVA: 0x00AC80F4 File Offset: 0x00AC62F4
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBdBuffSelectBdItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdBuffSelectBdItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060267BF RID: 157631 RVA: 0x00AC8137 File Offset: 0x00AC6337
		protected override void OnStart()
		{
			this.SequenceItem = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060267C0 RID: 157632 RVA: 0x00AC814A File Offset: 0x00AC634A
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060267C1 RID: 157633 RVA: 0x00AC814C File Offset: 0x00AC634C
		public void UpdateDataBase(TrapDefenseBdData data)
		{
			this.ItemData = data;
			UUITexture texture = base.GetTexture(3);
			base.SetTextureByPath(data.Config.IconSmall, texture, null, null);
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(data.Config.Name);
		}

		// Token: 0x060267C2 RID: 157634 RVA: 0x00AC81A0 File Offset: 0x00AC63A0
		public override void Refresh(TrapDefenseBdData data, bool isSelected, int gridIndex)
		{
			this.UpdateDataBase(data);
			this.UpdateProgressValue(null, null, null);
			this.UpdateQualityShow();
			this.CheckBdActiveNewQuality(true);
		}

		// Token: 0x060267C3 RID: 157635 RVA: 0x00AC81E4 File Offset: 0x00AC63E4
		public void RefreshItem(TrapDefenseBdData data)
		{
			this.UpdateDataBase(data);
			this.UpdateProgressValue(null, null, null);
			this.UpdateQualityShow();
			this.CheckBdActiveNewQuality(false);
		}

		// Token: 0x060267C4 RID: 157636 RVA: 0x00AC8228 File Offset: 0x00AC6428
		public void RefreshCheckProgress(TrapDefenseBdData data)
		{
			this.UpdateDataBase(data);
			this.CheckBdActiveNewQuality(false);
			if (this.ItemData.PreAddedBuffIsActiveNewQuality(0).Item1)
			{
				int value = this.ItemData.GetCurrentActiveProgressNum() - 1;
				this.UpdateProgressValue(new int?(value), new int?(1), new int?(-1));
			}
			else
			{
				this.UpdateProgressValue(null, null, null);
			}
			this.UpdateQualityShow();
		}

		// Token: 0x060267C5 RID: 157637 RVA: 0x00AC82A8 File Offset: 0x00AC64A8
		public void UpdateProgressValue(int? curNum = null, int? addNum = null, int? addSum = null)
		{
			UUIText text = base.GetText(5);
			int num = curNum ?? this.ItemData.GetCurrentActiveProgressNum();
			int num2 = addNum ?? ((this.ItemData.PreAddedBdBuffData != null) ? 1 : 0);
			string text2;
			if (num2 <= 0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string newText = text2;
			text.SetText(newText, true);
			int sumProgressForStageMode = this.ItemData.GetSumProgressForStageMode(addSum.GetValueOrDefault());
			UUIText text3 = base.GetText(6);
			if (text3 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(sumProgressForStageMode);
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			float fillAmount = (sumProgressForStageMode == 0) ? 0f : ((float)num / (float)sumProgressForStageMode);
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetFillAmount(fillAmount);
			}
			UUISprite sprite2 = base.GetSprite(10);
			if (sprite2 != null)
			{
				sprite2.SetFillAmount(fillAmount);
			}
			float num3 = (sumProgressForStageMode == 0) ? 0f : ((float)(num + num2) / (float)sumProgressForStageMode);
			UUISprite sprite3 = base.GetSprite(7);
			if (sprite3 != null)
			{
				sprite3.SetFillAmount(num3);
			}
			UUISprite sprite4 = base.GetSprite(9);
			if (sprite4 != null)
			{
				sprite4.SetFillAmount(num3);
			}
			this.IsUpStage = (num3 == 1f && num2 > 0);
			if (this.IsUpStage)
			{
				LevelSequencePlayer sequenceItem = this.SequenceItem;
				if (sequenceItem == null)
				{
					return;
				}
				sequenceItem.PlaySequencePurely("Loop", false, false, null, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer sequenceItem2 = this.SequenceItem;
				if (sequenceItem2 == null)
				{
					return;
				}
				sequenceItem2.StopSequenceByKey("Loop", false, false);
				return;
			}
		}

		// Token: 0x060267C6 RID: 157638 RVA: 0x00AC846C File Offset: 0x00AC666C
		private void UpdateQualityShow()
		{
			ValueTuple<bool, ETrapDefenseBdBuffQuality> valueTuple = this.ItemData.PreAddedBuffIsActiveNewQuality(-1);
			bool item = valueTuple.Item1;
			ETrapDefenseBdBuffQuality item2 = valueTuple.Item2;
			bool flag = item && this.IsUpStage;
			this.Quality = item2;
			if (item2 == ETrapDefenseBdBuffQuality.Purple)
			{
				this.SetProgressShowStateGold(!flag, false, true);
				this.SetProgressShowStatePurple(flag, true, false);
				return;
			}
			if (item2 == ETrapDefenseBdBuffQuality.Gold)
			{
				this.SetProgressShowStatePurple(false, false, false);
				this.SetProgressShowStateGold(true, true, false);
				return;
			}
			this.SetProgressShowStateGold(false, false, false);
			this.SetProgressShowStatePurple(true, false, true);
		}

		// Token: 0x060267C7 RID: 157639 RVA: 0x00AC84EC File Offset: 0x00AC66EC
		public void SetProgressShowStatePurple(bool show, bool showBg = false, bool useColor = false)
		{
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetUIActive(show);
			}
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(useColor, fcolor);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(showBg);
			}
			UUISprite sprite2 = base.GetSprite(7);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(show);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(show);
		}

		// Token: 0x060267C8 RID: 157640 RVA: 0x00AC855C File Offset: 0x00AC675C
		public void SetProgressShowStateGold(bool show, bool showBg = false, bool useColor = false)
		{
			UUISprite sprite = base.GetSprite(10);
			if (sprite != null)
			{
				sprite.SetUIActive(show);
			}
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(useColor, fcolor);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(showBg);
			}
			UUISprite sprite2 = base.GetSprite(9);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(show);
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(show);
		}

		// Token: 0x060267C9 RID: 157641 RVA: 0x00AC85CE File Offset: 0x00AC67CE
		public UUIExtendToggle GetSelfToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x060267CA RID: 157642 RVA: 0x00AC85D7 File Offset: 0x00AC67D7
		private void OnClickToggleSelf(EToggleState state)
		{
			Action<TrapDefenseBdData> clickCallBack = this.ClickCallBack;
			if (clickCallBack != null)
			{
				clickCallBack(this.ItemData);
			}
			this.GetSelfToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060267CB RID: 157643 RVA: 0x00AC8600 File Offset: 0x00AC6800
		public UniTask CheckPlayUpStageEffect()
		{
			TrapDefenseBdBuffSelectBdItem.<CheckPlayUpStageEffect>d__21 <CheckPlayUpStageEffect>d__;
			<CheckPlayUpStageEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckPlayUpStageEffect>d__.<>4__this = this;
			<CheckPlayUpStageEffect>d__.<>1__state = -1;
			<CheckPlayUpStageEffect>d__.<>t__builder.Start<TrapDefenseBdBuffSelectBdItem.<CheckPlayUpStageEffect>d__21>(ref <CheckPlayUpStageEffect>d__);
			return <CheckPlayUpStageEffect>d__.<>t__builder.Task;
		}

		// Token: 0x060267CC RID: 157644 RVA: 0x00AC8644 File Offset: 0x00AC6844
		public void CheckBdActiveNewQuality(bool isCheckPre = false)
		{
			if (isCheckPre && this.ItemData.PreAddedBdBuffData == null)
			{
				this.BtnTagTips.SetActive(false);
				return;
			}
			ValueTuple<bool, ETrapDefenseBdBuffQuality> valueTuple = this.ItemData.PreAddedBuffIsActiveNewQuality(-1);
			bool item = valueTuple.Item1;
			ETrapDefenseBdBuffQuality item2 = valueTuple.Item2;
			this.BtnTagTips.SetActive(item);
			if (item)
			{
				this.BtnTagTips.UpdateQuality(item2);
				this.BtnTagTips.UpdateDescForBuffSelect(item2);
			}
		}

		// Token: 0x04015180 RID: 86400
		public TrapDefenseBdData ItemData;

		// Token: 0x04015181 RID: 86401
		public Action<TrapDefenseBdData> ClickCallBack;

		// Token: 0x04015182 RID: 86402
		public LevelSequencePlayer SequenceItem;

		// Token: 0x04015183 RID: 86403
		public bool IsUpStage;

		// Token: 0x04015184 RID: 86404
		public ETrapDefenseBdBuffQuality Quality = ETrapDefenseBdBuffQuality.Purple;

		// Token: 0x04015185 RID: 86405
		public TrapDefenseBtnTagTips BtnTagTips;

		// Token: 0x0200967E RID: 38526
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EFCB RID: 192459
			public const int ToggleSelf = 0;

			// Token: 0x0402EFCC RID: 192460
			public const int ItemBgGold = 1;

			// Token: 0x0402EFCD RID: 192461
			public const int ItemBgPurple = 2;

			// Token: 0x0402EFCE RID: 192462
			public const int TextureIcon = 3;

			// Token: 0x0402EFCF RID: 192463
			public const int TextName = 4;

			// Token: 0x0402EFD0 RID: 192464
			public const int TextProgress = 5;

			// Token: 0x0402EFD1 RID: 192465
			public const int TextSumProgress = 6;

			// Token: 0x0402EFD2 RID: 192466
			public const int SpriteProgressAddPurple = 7;

			// Token: 0x0402EFD3 RID: 192467
			public const int SpriteProgressPurple = 8;

			// Token: 0x0402EFD4 RID: 192468
			public const int SpriteProgressAddGold = 9;

			// Token: 0x0402EFD5 RID: 192469
			public const int SpriteProgressGold = 10;

			// Token: 0x0402EFD6 RID: 192470
			public const int ItemProgressBgPurple = 11;

			// Token: 0x0402EFD7 RID: 192471
			public const int ItemProgressBgGold = 12;

			// Token: 0x0402EFD8 RID: 192472
			public const int ItemUpStageEffectGold = 13;

			// Token: 0x0402EFD9 RID: 192473
			public const int ItemUpStageEffectPurple = 14;

			// Token: 0x0402EFDA RID: 192474
			public const int ItemTagTip = 15;
		}
	}
}
