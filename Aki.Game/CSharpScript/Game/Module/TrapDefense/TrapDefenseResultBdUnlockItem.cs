using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A52 RID: 14930
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultBdUnlockItem : GridProxyAbstract<ITrapDefenseResultUnlockInfo>
	{
		// Token: 0x060265F7 RID: 157175 RVA: 0x00ABF8A4 File Offset: 0x00ABDAA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060265F8 RID: 157176 RVA: 0x00ABFA32 File Offset: 0x00ABDC32
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(8));
		}

		// Token: 0x060265F9 RID: 157177 RVA: 0x00ABFA48 File Offset: 0x00ABDC48
		public override void Refresh(ITrapDefenseResultUnlockInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (data.Type == ETrapDefenseResultUnlockType.Organ || data.Type == ETrapDefenseResultUnlockType.OrganShare)
			{
				return;
			}
			TrapDefenseBdData trapDefenseBdData = TrapDefenseModel.Instance.RougeModeData.BdDataMap[data.Id];
			bool valueOrDefault = data.NeedUnlockBar.GetValueOrDefault();
			base.SetTextureByPath(trapDefenseBdData.Config.Icon, base.GetTexture(5), null, null);
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetUIActive(valueOrDefault || data.ForShare.GetValueOrDefault());
			}
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(data.IsFinish.GetValueOrDefault());
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsNewUnlock.GetValueOrDefault());
			}
			this.Data.IsNewUnlock = null;
			if (!valueOrDefault)
			{
				this.SetGoldActive(false, null);
				this.SetPurpleActive(false, null, null);
				if (trapDefenseBdData != null && data.ForShare.GetValueOrDefault())
				{
					int currentActiveProgressNum = trapDefenseBdData.GetCurrentActiveProgressNum();
					UUIText text2 = base.GetText(6);
					if (text2 == null)
					{
						return;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(currentActiveProgressNum);
					text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
				return;
			}
			if (trapDefenseBdData != null)
			{
				this.SetProgress(trapDefenseBdData);
			}
		}

		// Token: 0x060265FA RID: 157178 RVA: 0x00ABFBB4 File Offset: 0x00ABDDB4
		private void SetProgress(TrapDefenseBdData bdData)
		{
			int currentActiveProgressNum = bdData.GetCurrentActiveProgressNum();
			int sumProgressForStageMode = bdData.GetSumProgressForStageMode(0);
			ETrapDefenseBdBuffQuality curActiveQualityPool = bdData.GetCurActiveQualityPool();
			float value = (sumProgressForStageMode == 0) ? 0f : ((float)currentActiveProgressNum / (float)sumProgressForStageMode);
			if (this.Data.ForShare.GetValueOrDefault())
			{
				UUIText text = base.GetText(6);
				if (text != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(currentActiveProgressNum);
					text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			else
			{
				UUIText text2 = base.GetText(6);
				if (text2 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(currentActiveProgressNum);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(sumProgressForStageMode);
					text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			if (curActiveQualityPool == ETrapDefenseBdBuffQuality.Purple)
			{
				this.SetPurpleActive(true, new float?(value), new bool?(false));
				return;
			}
			if (curActiveQualityPool == ETrapDefenseBdBuffQuality.Gold)
			{
				this.SetGoldActive(true, new float?(value));
				return;
			}
			this.SetPurpleActive(true, new float?(value), new bool?(true));
		}

		// Token: 0x060265FB RID: 157179 RVA: 0x00ABFCA8 File Offset: 0x00ABDEA8
		private void SetGoldActive(bool show, float? amount = null)
		{
			UUISprite sprite = base.GetSprite(1);
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(show);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(show);
			}
			if (amount != null && amount.GetValueOrDefault() != 0f && sprite != null)
			{
				sprite.SetFillAmount(amount.Value);
			}
		}

		// Token: 0x060265FC RID: 157180 RVA: 0x00ABFD04 File Offset: 0x00ABDF04
		private void SetPurpleActive(bool show, float? amount = null, bool? useColor = null)
		{
			UUISprite sprite = base.GetSprite(2);
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(show);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(show);
			}
			if (useColor.GetValueOrDefault() && sprite != null)
			{
				UUIItem uuiitem = sprite;
				bool value = useColor.Value;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(value, fcolor);
			}
			if (amount != null && amount.GetValueOrDefault() != 0f && sprite != null)
			{
				sprite.SetFillAmount(amount.Value);
			}
		}

		// Token: 0x060265FD RID: 157181 RVA: 0x00ABFD84 File Offset: 0x00ABDF84
		private void OnClicked()
		{
			if (this.Data.Type == ETrapDefenseResultUnlockType.Organ)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingGangsInfoView, this.Data.Id, null);
		}

		// Token: 0x060265FE RID: 157182 RVA: 0x00ABFDB4 File Offset: 0x00ABDFB4
		public void PlayUnlockAnim()
		{
			if (this.Data.Type != ETrapDefenseResultUnlockType.Bd)
			{
				return;
			}
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Unlock", false, null);
		}

		// Token: 0x040150E1 RID: 86241
		protected ITrapDefenseResultUnlockInfo Data;

		// Token: 0x040150E2 RID: 86242
		protected TrapDefenseBuildingDevelopItemData OrganData;

		// Token: 0x040150E3 RID: 86243
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200961D RID: 38429
		[NullableContext(0)]
		internal class EUnlockBd
		{
			// Token: 0x0402EDDE RID: 191966
			public const int Btn = 0;

			// Token: 0x0402EDDF RID: 191967
			public const int SpriteBarGold = 1;

			// Token: 0x0402EDE0 RID: 191968
			public const int SpriteBarPurple = 2;

			// Token: 0x0402EDE1 RID: 191969
			public const int SpriteBgPurple = 3;

			// Token: 0x0402EDE2 RID: 191970
			public const int SpriteBgGold = 4;

			// Token: 0x0402EDE3 RID: 191971
			public const int TextureIcon = 5;

			// Token: 0x0402EDE4 RID: 191972
			public const int TxtNum = 6;

			// Token: 0x0402EDE5 RID: 191973
			public const int ItemFinish = 7;

			// Token: 0x0402EDE6 RID: 191974
			public const int UnlockItem = 8;
		}
	}
}
