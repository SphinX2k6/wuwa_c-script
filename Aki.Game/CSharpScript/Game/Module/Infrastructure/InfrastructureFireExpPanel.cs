using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E9 RID: 18665
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureFireExpPanel : UiPanelBase
	{
		// Token: 0x0602ED80 RID: 191872 RVA: 0x00D0FCE0 File Offset: 0x00D0DEE0
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

		// Token: 0x0602ED81 RID: 191873 RVA: 0x00D0FF80 File Offset: 0x00D0E180
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetItem(16));
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			(base.GetItem(16).GetOwner() as AUIBaseActor).OnSequencePlayEvent.Bind(new Action<string, string>(this.SequenceEvent));
			this.RefreshActivityLevel(0, true);
		}

		// Token: 0x0602ED82 RID: 191874 RVA: 0x00D0FFE9 File Offset: 0x00D0E1E9
		public bool UpdateExp()
		{
			return this.RefreshActivityLevel(0, false);
		}

		// Token: 0x0602ED83 RID: 191875 RVA: 0x00D0FFF4 File Offset: 0x00D0E1F4
		public void RefreshExpBeforeRoadBuilt(int roadId)
		{
			this.RefreshActivityLevel(InfrastructureConfig.Instance.GetRoadConfigById(roadId).Value.FireExpReward, true);
		}

		// Token: 0x0602ED84 RID: 191876 RVA: 0x00D10024 File Offset: 0x00D0E224
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

		// Token: 0x0602ED85 RID: 191877 RVA: 0x00D101E4 File Offset: 0x00D0E3E4
		public void SetOnClickHelpCb(Action cb)
		{
			this.OnClickHelpCb = cb;
		}

		// Token: 0x0602ED86 RID: 191878 RVA: 0x00D101ED File Offset: 0x00D0E3ED
		public void SetOnDigitSequenceFinishCb(Action cb)
		{
			this.OnDigitSequenceFinishCb = cb;
		}

		// Token: 0x0602ED87 RID: 191879 RVA: 0x00D101F6 File Offset: 0x00D0E3F6
		private void OnClickHelp()
		{
			Action onClickHelpCb = this.OnClickHelpCb;
			if (onClickHelpCb == null)
			{
				return;
			}
			onClickHelpCb();
		}

		// Token: 0x0602ED88 RID: 191880 RVA: 0x00D10208 File Offset: 0x00D0E408
		private void OnSequenceClose(string seqName)
		{
			if (Array.IndexOf<string>(this.sequenceName, seqName) >= 0)
			{
				Action onDigitSequenceFinishCb = this.OnDigitSequenceFinishCb;
				if (onDigitSequenceFinishCb == null)
				{
					return;
				}
				onDigitSequenceFinishCb();
			}
		}

		// Token: 0x0602ED89 RID: 191881 RVA: 0x00D1022C File Offset: 0x00D0E42C
		private void SequenceEvent(string seqName, string eventName)
		{
			if (Array.IndexOf<string>(this.sequenceName, seqName) >= 0 && eventName == "On")
			{
				int num = this.sequenceName.IndexOf(seqName);
				int num2 = this.CurrentFireExpArray[num];
				base.GetArtText(this.numEnum[num]).SetText(num2.ToString());
			}
		}

		// Token: 0x04018DB7 RID: 101815
		private List<int> CurrentFireExpArray = new List<int>();

		// Token: 0x04018DB8 RID: 101816
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04018DB9 RID: 101817
		private Action OnClickHelpCb;

		// Token: 0x04018DBA RID: 101818
		private Action OnDigitSequenceFinishCb;

		// Token: 0x04018DBB RID: 101819
		private readonly int[] numEnum = new int[]
		{
			1,
			2,
			3,
			4,
			5
		};

		// Token: 0x04018DBC RID: 101820
		private readonly int[] preNumEnum = new int[]
		{
			11,
			12,
			13,
			14,
			15
		};

		// Token: 0x04018DBD RID: 101821
		private readonly int[] nextNumEnum = new int[]
		{
			6,
			7,
			8,
			9,
			10
		};

		// Token: 0x04018DBE RID: 101822
		private readonly string[] sequenceName = new string[]
		{
			"FirstDigit",
			"SecondDigit",
			"ThirdDigit",
			"FourthDigit",
			"FifthDigit"
		};

		// Token: 0x0200A592 RID: 42386
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403337C RID: 209788
			public const int BtnHelp = 0;

			// Token: 0x0403337D RID: 209789
			public const int ArtText1 = 1;

			// Token: 0x0403337E RID: 209790
			public const int ArtText2 = 2;

			// Token: 0x0403337F RID: 209791
			public const int ArtText3 = 3;

			// Token: 0x04033380 RID: 209792
			public const int ArtText4 = 4;

			// Token: 0x04033381 RID: 209793
			public const int ArtText5 = 5;

			// Token: 0x04033382 RID: 209794
			public const int ArtTextNext1 = 6;

			// Token: 0x04033383 RID: 209795
			public const int ArtTextNext2 = 7;

			// Token: 0x04033384 RID: 209796
			public const int ArtTextNext3 = 8;

			// Token: 0x04033385 RID: 209797
			public const int ArtTextNext4 = 9;

			// Token: 0x04033386 RID: 209798
			public const int ArtTextNext5 = 10;

			// Token: 0x04033387 RID: 209799
			public const int ArtTextPre1 = 11;

			// Token: 0x04033388 RID: 209800
			public const int ArtTextPre2 = 12;

			// Token: 0x04033389 RID: 209801
			public const int ArtTextPre3 = 13;

			// Token: 0x0403338A RID: 209802
			public const int ArtTextPre4 = 14;

			// Token: 0x0403338B RID: 209803
			public const int ArtTextPre5 = 15;

			// Token: 0x0403338C RID: 209804
			public const int PanelSeq = 16;
		}
	}
}
