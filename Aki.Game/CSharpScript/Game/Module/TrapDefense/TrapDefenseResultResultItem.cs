using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AA5 RID: 19109
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseResultResultItem : GridProxyAbstract<ITrapDefenseResultInfo>
	{
		// Token: 0x0603184D RID: 202829 RVA: 0x00B7AE1C File Offset: 0x00B7901C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603184E RID: 202830 RVA: 0x00B7AF09 File Offset: 0x00B79109
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<TrapDefenseResultStarItem, ITrapDefenseStarInfo>(base.GetHorizontalLayout(3), new Func<TrapDefenseResultStarItem>(this.CreateStar), null, false, true);
		}

		// Token: 0x0603184F RID: 202831 RVA: 0x00B7AF2C File Offset: 0x00B7912C
		public override void Refresh(ITrapDefenseResultInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(data.Type > ETrapDefenseResultType.Star);
			}
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(3);
			if (horizontalLayout != null)
			{
				horizontalLayout.RootUIComp.Get().SetUIActive(data.Type == ETrapDefenseResultType.Star);
			}
			if (data.Type == ETrapDefenseResultType.Star)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "TowerDefense_Ending_GainStar_Text", Array.Empty<object>());
				if (this.StarList.Count == 0)
				{
					int i = 1;
					while (i <= data.Value)
					{
						ITrapDefenseStarInfo trapDefenseStarInfo = new ITrapDefenseStarInfo();
						int num = i;
						int? num2 = data.Total;
						trapDefenseStarInfo.IsAchieve = (num <= num2.GetValueOrDefault() & num2 != null);
						int num3 = i;
						num2 = data.Total;
						bool isNew;
						if (num3 <= num2.GetValueOrDefault() & num2 != null)
						{
							int num4 = i;
							num2 = data.History;
							isNew = (num4 > num2.GetValueOrDefault() & num2 != null);
						}
						else
						{
							isNew = false;
						}
						trapDefenseStarInfo.IsNew = isNew;
						trapDefenseStarInfo.HasPlayed = false;
						int num5 = i;
						num2 = data.Total;
						if (!(num5 <= num2.GetValueOrDefault() & num2 != null))
						{
							goto IL_12F;
						}
						int num6 = i;
						num2 = data.History;
						if (!(num6 > num2.GetValueOrDefault() & num2 != null))
						{
							goto IL_12F;
						}
						int playDelay = this.GetAnimDelay(i - data.History.Value, data.Total.Value - data.History.Value);
						IL_165:
						trapDefenseStarInfo.PlayDelay = playDelay;
						ITrapDefenseStarInfo item2 = trapDefenseStarInfo;
						this.StarList.Add(item2);
						i++;
						continue;
						IL_12F:
						playDelay = 0;
						goto IL_165;
					}
				}
				GenericLayout<TrapDefenseResultStarItem, ITrapDefenseStarInfo> layout = this.Layout;
				if (layout == null)
				{
					return;
				}
				layout.RefreshByData(this.StarList, null, true);
				return;
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "TowerDefense_Ending_GainBdUp_Text", Array.Empty<object>());
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Value);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
		}

		// Token: 0x06031850 RID: 202832 RVA: 0x00B7B124 File Offset: 0x00B79324
		public void PlayStarIn()
		{
			if (this.Data.Type != ETrapDefenseResultType.Star)
			{
				return;
			}
			foreach (TrapDefenseResultStarItem trapDefenseResultStarItem in this.Layout.GetLayoutItemList())
			{
				trapDefenseResultStarItem.PlayAnim();
			}
		}

		// Token: 0x06031851 RID: 202833 RVA: 0x00B7B188 File Offset: 0x00B79388
		public void EndStarAnim()
		{
			foreach (ITrapDefenseStarInfo trapDefenseStarInfo in this.StarList)
			{
				trapDefenseStarInfo.HasPlayed = true;
			}
		}

		// Token: 0x06031852 RID: 202834 RVA: 0x00B7B1DC File Offset: 0x00B793DC
		private int GetAnimDelay(int index, int length)
		{
			if (length <= 1 || index <= 1)
			{
				return 0;
			}
			int num = 50;
			int num2 = 150;
			return num + (int)Math.Floor((double)((float)((num2 - num) * (index - 2)) / ((float)(length - 2) * 1f)));
		}

		// Token: 0x06031853 RID: 202835 RVA: 0x00B7B218 File Offset: 0x00B79418
		private TrapDefenseResultStarItem CreateStar()
		{
			return new TrapDefenseResultStarItem();
		}

		// Token: 0x0401A780 RID: 108416
		private GenericLayout<TrapDefenseResultStarItem, ITrapDefenseStarInfo> Layout;

		// Token: 0x0401A781 RID: 108417
		private ITrapDefenseResultInfo Data;

		// Token: 0x0401A782 RID: 108418
		private List<ITrapDefenseStarInfo> StarList = new List<ITrapDefenseStarInfo>();

		// Token: 0x0200ABFA RID: 44026
		[NullableContext(0)]
		private class EResult
		{
			// Token: 0x0403441F RID: 214047
			public const int Title = 0;

			// Token: 0x04034420 RID: 214048
			public const int Value = 1;

			// Token: 0x04034421 RID: 214049
			public const int Icon = 2;

			// Token: 0x04034422 RID: 214050
			public const int StarLayout = 3;

			// Token: 0x04034423 RID: 214051
			public const int StarItem = 4;

			// Token: 0x04034424 RID: 214052
			public const int PanelTxt = 5;
		}
	}
}
