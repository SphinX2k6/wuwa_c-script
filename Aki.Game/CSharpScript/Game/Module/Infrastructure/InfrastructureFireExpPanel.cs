using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005910 RID: 22800
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureFireExpPanel : UiPanelBase
	{
		// Token: 0x06039E5D RID: 237149 RVA: 0x00DC09E8 File Offset: 0x00DBEBE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickHelp));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039E5E RID: 237150 RVA: 0x00DC0C88 File Offset: 0x00DBEE88
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetItem(16));
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			(base.GetItem(16).GetOwner() as AUIBaseActor).OnSequencePlayEvent.Bind(new Action<string, string>(this.SequenceEvent));
			this.RefreshActivityLevel(0, true);
		}

		// Token: 0x06039E5F RID: 237151 RVA: 0x00DC0CF1 File Offset: 0x00DBEEF1
		public bool UpdateExp()
		{
			return this.RefreshActivityLevel(0, false);
		}

		// Token: 0x06039E60 RID: 237152 RVA: 0x00DC0CFC File Offset: 0x00DBEEFC
		public void RefreshExpBeforeRoadBuilt(int roadId)
		{
			this.RefreshActivityLevel(InfrastructureConfig.Instance.GetRoadConfigById(roadId).Value.FireExpReward, true);
		}

		// Token: 0x06039E61 RID: 237153 RVA: 0x00DC0D2C File Offset: 0x00DBEF2C
		private bool RefreshActivityLevel(int expDiff = 0, bool disableSequence = false)
		{
			double num = Math.Pow(10.0, (double)(this.numEnum.Length - 1));
			List<int> currentFireExpArray = this.CurrentFireExpArray;
			this.CurrentFireExpArray = new List<int>();
			double num2 = (double)(InfrastructureModel.Instance.FireExp - (long)expDiff);
			int i;
			for (i = 0; i < this.numEnum.Length; i++)
			{
				int item = (int)Math.Floor(num2 / num);
				this.CurrentFireExpArray.Add(item);
				num2 %= num;
				num /= 10.0;
			}
			bool flag = false;
			i = 0;
			bool flag2 = true;
			while (i < this.numEnum.Length)
			{
				UUIArtText artText = base.GetArtText(this.numEnum[i]);
				UUIArtText artText2 = base.GetArtText(this.preNumEnum[i]);
				UUIArtText artText3 = base.GetArtText(this.nextNumEnum[i]);
				int num3 = this.CurrentFireExpArray[i];
				flag2 = (flag2 && num3 == 0 && i < this.numEnum.Length - 1);
				if (flag2)
				{
					UUIItem uuiitem = artText;
					bool bUseChangeColor = true;
					FColor? fcolor = new FColor?(artText.changeColor);
					uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				}
				else
				{
					UUIItem uuiitem2 = artText;
					bool bUseChangeColor2 = false;
					FColor? fcolor = new FColor?(artText.Color);
					uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
				}
				if (disableSequence)
				{
					artText.SetText(num3.ToString());
				}
				if ((i < currentFireExpArray.Count && num3 != currentFireExpArray[i]) || flag)
				{
					flag = true;
					artText2.SetText(((currentFireExpArray[i] + 9) % 10).ToString());
					artText3.SetText(((currentFireExpArray[i] + 1) % 10).ToString());
					if (!disableSequence)
					{
						this.SeqPlayer.PlayLevelSequenceByName(this.sequenceName[i], false, null, false);
					}
				}
				i++;
			}
			return flag;
		}

		// Token: 0x06039E62 RID: 237154 RVA: 0x00DC0EEC File Offset: 0x00DBF0EC
		public void SetOnClickHelpCb(Action cb)
		{
			this.OnClickHelpCb = cb;
		}

		// Token: 0x06039E63 RID: 237155 RVA: 0x00DC0EF5 File Offset: 0x00DBF0F5
		public void SetOnDigitSequenceFinishCb(Action cb)
		{
			this.OnDigitSequenceFinishCb = cb;
		}

		// Token: 0x06039E64 RID: 237156 RVA: 0x00DC0EFE File Offset: 0x00DBF0FE
		private void OnClickHelp()
		{
			Action onClickHelpCb = this.OnClickHelpCb;
			if (onClickHelpCb == null)
			{
				return;
			}
			onClickHelpCb();
		}

		// Token: 0x06039E65 RID: 237157 RVA: 0x00DC0F10 File Offset: 0x00DBF110
		private void OnSequenceClose(string seqName)
		{
			if (this.sequenceName.Contains(seqName))
			{
				Action onDigitSequenceFinishCb = this.OnDigitSequenceFinishCb;
				if (onDigitSequenceFinishCb == null)
				{
					return;
				}
				onDigitSequenceFinishCb();
			}
		}

		// Token: 0x06039E66 RID: 237158 RVA: 0x00DC0F30 File Offset: 0x00DBF130
		private void SequenceEvent(string seqName, string eventName)
		{
			if (this.sequenceName.Contains(seqName) && eventName == "On")
			{
				int num = this.sequenceName.IndexOf(seqName);
				int num2 = this.CurrentFireExpArray[num];
				base.GetArtText(this.numEnum[num]).SetText(num2.ToString());
			}
		}

		// Token: 0x0401E31A RID: 123674
		private List<int> CurrentFireExpArray = new List<int>();

		// Token: 0x0401E31B RID: 123675
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401E31C RID: 123676
		private Action OnClickHelpCb;

		// Token: 0x0401E31D RID: 123677
		private Action OnDigitSequenceFinishCb;

		// Token: 0x0401E31E RID: 123678
		private readonly int[] numEnum = new int[]
		{
			1,
			2,
			3,
			4,
			5
		};

		// Token: 0x0401E31F RID: 123679
		private readonly int[] preNumEnum = new int[]
		{
			11,
			12,
			13,
			14,
			15
		};

		// Token: 0x0401E320 RID: 123680
		private readonly int[] nextNumEnum = new int[]
		{
			6,
			7,
			8,
			9,
			10
		};

		// Token: 0x0401E321 RID: 123681
		private readonly string[] sequenceName = new string[]
		{
			"FirstDigit",
			"SecondDigit",
			"ThirdDigit",
			"FourthDigit",
			"FifthDigit"
		};

		// Token: 0x0200BB82 RID: 48002
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038994 RID: 231828
			public const int BtnHelp = 0;

			// Token: 0x04038995 RID: 231829
			public const int ArtText1 = 1;

			// Token: 0x04038996 RID: 231830
			public const int ArtText2 = 2;

			// Token: 0x04038997 RID: 231831
			public const int ArtText3 = 3;

			// Token: 0x04038998 RID: 231832
			public const int ArtText4 = 4;

			// Token: 0x04038999 RID: 231833
			public const int ArtText5 = 5;

			// Token: 0x0403899A RID: 231834
			public const int ArtTextNext1 = 6;

			// Token: 0x0403899B RID: 231835
			public const int ArtTextNext2 = 7;

			// Token: 0x0403899C RID: 231836
			public const int ArtTextNext3 = 8;

			// Token: 0x0403899D RID: 231837
			public const int ArtTextNext4 = 9;

			// Token: 0x0403899E RID: 231838
			public const int ArtTextNext5 = 10;

			// Token: 0x0403899F RID: 231839
			public const int ArtTextPre1 = 11;

			// Token: 0x040389A0 RID: 231840
			public const int ArtTextPre2 = 12;

			// Token: 0x040389A1 RID: 231841
			public const int ArtTextPre3 = 13;

			// Token: 0x040389A2 RID: 231842
			public const int ArtTextPre4 = 14;

			// Token: 0x040389A3 RID: 231843
			public const int ArtTextPre5 = 15;

			// Token: 0x040389A4 RID: 231844
			public const int PanelSeq = 16;
		}
	}
}
