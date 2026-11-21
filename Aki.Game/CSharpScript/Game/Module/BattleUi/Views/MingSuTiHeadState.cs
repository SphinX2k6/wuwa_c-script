using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D2C RID: 19756
	public class MingSuTiHeadState : HeadStateViewBase
	{
		// Token: 0x06031955 RID: 203093 RVA: 0x00DDCD4C File Offset: 0x00DDAF4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031956 RID: 203094 RVA: 0x00DDD035 File Offset: 0x00DDB235
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_MingsutiState_Prefab";
		}

		// Token: 0x06031957 RID: 203095 RVA: 0x00DDD03C File Offset: 0x00DDB23C
		protected unsafe override void OnStart()
		{
			int num = 20;
			List<UUISprite> list = new List<UUISprite>(num);
			CollectionsMarshal.SetCount<UUISprite>(list, num);
			Span<UUISprite> span = CollectionsMarshal.AsSpan<UUISprite>(list);
			int num2 = 0;
			*span[num2] = base.GetSprite(1);
			num2++;
			*span[num2] = base.GetSprite(2);
			num2++;
			*span[num2] = base.GetSprite(3);
			num2++;
			*span[num2] = base.GetSprite(4);
			num2++;
			*span[num2] = base.GetSprite(5);
			num2++;
			*span[num2] = base.GetSprite(6);
			num2++;
			*span[num2] = base.GetSprite(7);
			num2++;
			*span[num2] = base.GetSprite(8);
			num2++;
			*span[num2] = base.GetSprite(9);
			num2++;
			*span[num2] = base.GetSprite(10);
			num2++;
			*span[num2] = base.GetSprite(11);
			num2++;
			*span[num2] = base.GetSprite(12);
			num2++;
			*span[num2] = base.GetSprite(13);
			num2++;
			*span[num2] = base.GetSprite(14);
			num2++;
			*span[num2] = base.GetSprite(15);
			num2++;
			*span[num2] = base.GetSprite(16);
			num2++;
			*span[num2] = base.GetSprite(17);
			num2++;
			*span[num2] = base.GetSprite(18);
			num2++;
			*span[num2] = base.GetSprite(19);
			num2++;
			*span[num2] = base.GetSprite(20);
			this.HpStateSpriteList = list;
		}

		// Token: 0x06031958 RID: 203096 RVA: 0x00DDD200 File Offset: 0x00DDB400
		[NullableContext(1)]
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.RefreshHp();
			this.RefreshHpColor();
			this.InitHp();
		}

		// Token: 0x06031959 RID: 203097 RVA: 0x00DDD21B File Offset: 0x00DDB41B
		protected override void OnHealthChanged()
		{
			this.RefreshHp();
		}

		// Token: 0x0603195A RID: 203098 RVA: 0x00DDD223 File Offset: 0x00DDB423
		[NullableContext(2)]
		private UUISprite GetHpStateSprite(int index)
		{
			return this.HpStateSpriteList.GetValueOrDefault(index);
		}

		// Token: 0x0603195B RID: 203099 RVA: 0x00DDD234 File Offset: 0x00DDB434
		private void RefreshHp()
		{
			ValueTuple<float, float> hpAndMaxHp = base.GetHpAndMaxHp();
			float item = hpAndMaxHp.Item1;
			float item2 = hpAndMaxHp.Item2;
			if (this.CurrentHp == item)
			{
				return;
			}
			this.CurrentHp = item;
			int num = 0;
			while ((double)num < Math.Floor((double)item2))
			{
				UUISprite hpStateSprite = this.GetHpStateSprite(num);
				if (hpStateSprite != null && (float)num < item != hpStateSprite.bIsUIActive)
				{
					hpStateSprite.SetUIActive((float)num < item);
				}
				num++;
			}
		}

		// Token: 0x0603195C RID: 203100 RVA: 0x00DDD29C File Offset: 0x00DDB49C
		private void InitHp()
		{
			for (int i = (int)this.GetMaxHp(); i < this.HpStateSpriteList.Count; i++)
			{
				UUISprite hpStateSprite = this.GetHpStateSprite(i);
				if (hpStateSprite != null)
				{
					hpStateSprite.GetParentAsUIItem().SetUIActive(false);
				}
			}
		}

		// Token: 0x0603195D RID: 203101 RVA: 0x00DDD2DC File Offset: 0x00DDB4DC
		private void RefreshHpColor()
		{
			string hpColor = base.GetHpColor();
			if (string.IsNullOrEmpty(hpColor))
			{
				return;
			}
			FColor color = FColor.FromHex(hpColor);
			foreach (UUISprite uuisprite in this.HpStateSpriteList)
			{
				uuisprite.SetColor(color);
			}
		}

		// Token: 0x0603195E RID: 203102 RVA: 0x00DDD344 File Offset: 0x00DDB544
		protected override void RefreshOnCampChanged()
		{
			this.RefreshHpColor();
		}

		// Token: 0x0401A402 RID: 107522
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUISprite> HpStateSpriteList;

		// Token: 0x0401A403 RID: 107523
		private float CurrentHp;

		// Token: 0x0200A9F4 RID: 43508
		private enum EChildType
		{
			// Token: 0x0403485E RID: 215134
			HpHorizontalBox,
			// Token: 0x0403485F RID: 215135
			HpSprite1,
			// Token: 0x04034860 RID: 215136
			HpSprite2,
			// Token: 0x04034861 RID: 215137
			HpSprite3,
			// Token: 0x04034862 RID: 215138
			HpSprite4,
			// Token: 0x04034863 RID: 215139
			HpSprite5,
			// Token: 0x04034864 RID: 215140
			HpSprite6,
			// Token: 0x04034865 RID: 215141
			HpSprite7,
			// Token: 0x04034866 RID: 215142
			HpSprite8,
			// Token: 0x04034867 RID: 215143
			HpSprite9,
			// Token: 0x04034868 RID: 215144
			HpSprite10,
			// Token: 0x04034869 RID: 215145
			HpSprite11,
			// Token: 0x0403486A RID: 215146
			HpSprite12,
			// Token: 0x0403486B RID: 215147
			HpSprite13,
			// Token: 0x0403486C RID: 215148
			HpSprite14,
			// Token: 0x0403486D RID: 215149
			HpSprite15,
			// Token: 0x0403486E RID: 215150
			HpSprite16,
			// Token: 0x0403486F RID: 215151
			HpSprite17,
			// Token: 0x04034870 RID: 215152
			HpSprite18,
			// Token: 0x04034871 RID: 215153
			HpSprite19,
			// Token: 0x04034872 RID: 215154
			HpSprite20
		}
	}
}
