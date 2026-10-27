using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AAA RID: 19114
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultBdUnlockItem : GridProxyAbstract<ITrapDefenseResultUnlockInfo>
	{
		// Token: 0x06031867 RID: 202855 RVA: 0x00B7B8F0 File Offset: 0x00B79AF0
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

		// Token: 0x06031868 RID: 202856 RVA: 0x00B7BA7E File Offset: 0x00B79C7E
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(8));
		}

		// Token: 0x06031869 RID: 202857 RVA: 0x00B7BA94 File Offset: 0x00B79C94
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

		// Token: 0x0603186A RID: 202858 RVA: 0x00B7BC00 File Offset: 0x00B79E00
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

		// Token: 0x0603186B RID: 202859 RVA: 0x00B7BCF4 File Offset: 0x00B79EF4
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

		// Token: 0x0603186C RID: 202860 RVA: 0x00B7BD50 File Offset: 0x00B79F50
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

		// Token: 0x0603186D RID: 202861 RVA: 0x00B7BDD0 File Offset: 0x00B79FD0
		private void OnClicked()
		{
			if (this.Data.Type == ETrapDefenseResultUnlockType.Organ)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingGangsInfoView, this.Data.Id, null);
		}

		// Token: 0x0603186E RID: 202862 RVA: 0x00B7BE00 File Offset: 0x00B7A000
		public void PlayUnlockAnim()
		{
			if (this.Data.Type != ETrapDefenseResultUnlockType.Bd)
			{
				return;
			}
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Unlock", false, null);
		}

		// Token: 0x0401A78F RID: 108431
		protected ITrapDefenseResultUnlockInfo Data;

		// Token: 0x0401A790 RID: 108432
		protected TrapDefenseBuildingDevelopItemData OrganData;

		// Token: 0x0401A791 RID: 108433
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200ABFD RID: 44029
		[NullableContext(0)]
		internal class EUnlockBd
		{
			// Token: 0x0403442D RID: 214061
			public const int Btn = 0;

			// Token: 0x0403442E RID: 214062
			public const int SpriteBarGold = 1;

			// Token: 0x0403442F RID: 214063
			public const int SpriteBarPurple = 2;

			// Token: 0x04034430 RID: 214064
			public const int SpriteBgPurple = 3;

			// Token: 0x04034431 RID: 214065
			public const int SpriteBgGold = 4;

			// Token: 0x04034432 RID: 214066
			public const int TextureIcon = 5;

			// Token: 0x04034433 RID: 214067
			public const int TxtNum = 6;

			// Token: 0x04034434 RID: 214068
			public const int ItemFinish = 7;

			// Token: 0x04034435 RID: 214069
			public const int UnlockItem = 8;
		}
	}
}
