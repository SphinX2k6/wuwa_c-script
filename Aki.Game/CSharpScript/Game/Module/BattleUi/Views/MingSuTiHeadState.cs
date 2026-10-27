using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D4A RID: 23882
	public class MingSuTiHeadState : HeadStateViewBase
	{
		// Token: 0x0603C9FC RID: 248316 RVA: 0x00E8C59C File Offset: 0x00E8A79C
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

		// Token: 0x0603C9FD RID: 248317 RVA: 0x00E8C885 File Offset: 0x00E8AA85
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_MingsutiState_Prefab";
		}

		// Token: 0x0603C9FE RID: 248318 RVA: 0x00E8C88C File Offset: 0x00E8AA8C
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

		// Token: 0x0603C9FF RID: 248319 RVA: 0x00E8CA50 File Offset: 0x00E8AC50
		[NullableContext(1)]
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.RefreshHp();
			this.RefreshHpColor();
			this.InitHp();
		}

		// Token: 0x0603CA00 RID: 248320 RVA: 0x00E8CA6B File Offset: 0x00E8AC6B
		protected override void OnHealthChanged()
		{
			this.RefreshHp();
		}

		// Token: 0x0603CA01 RID: 248321 RVA: 0x00E8CA73 File Offset: 0x00E8AC73
		[NullableContext(2)]
		private UUISprite GetHpStateSprite(int index)
		{
			return this.HpStateSpriteList.GetValueOrDefault(index);
		}

		// Token: 0x0603CA02 RID: 248322 RVA: 0x00E8CA84 File Offset: 0x00E8AC84
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

		// Token: 0x0603CA03 RID: 248323 RVA: 0x00E8CAEC File Offset: 0x00E8ACEC
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

		// Token: 0x0603CA04 RID: 248324 RVA: 0x00E8CB2C File Offset: 0x00E8AD2C
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

		// Token: 0x0603CA05 RID: 248325 RVA: 0x00E8CB94 File Offset: 0x00E8AD94
		protected override void RefreshOnCampChanged()
		{
			this.RefreshHpColor();
		}

		// Token: 0x0401F949 RID: 129353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUISprite> HpStateSpriteList;

		// Token: 0x0401F94A RID: 129354
		private float CurrentHp;

		// Token: 0x0200BFEE RID: 49134
		private enum EChildType
		{
			// Token: 0x04039E9C RID: 237212
			HpHorizontalBox,
			// Token: 0x04039E9D RID: 237213
			HpSprite1,
			// Token: 0x04039E9E RID: 237214
			HpSprite2,
			// Token: 0x04039E9F RID: 237215
			HpSprite3,
			// Token: 0x04039EA0 RID: 237216
			HpSprite4,
			// Token: 0x04039EA1 RID: 237217
			HpSprite5,
			// Token: 0x04039EA2 RID: 237218
			HpSprite6,
			// Token: 0x04039EA3 RID: 237219
			HpSprite7,
			// Token: 0x04039EA4 RID: 237220
			HpSprite8,
			// Token: 0x04039EA5 RID: 237221
			HpSprite9,
			// Token: 0x04039EA6 RID: 237222
			HpSprite10,
			// Token: 0x04039EA7 RID: 237223
			HpSprite11,
			// Token: 0x04039EA8 RID: 237224
			HpSprite12,
			// Token: 0x04039EA9 RID: 237225
			HpSprite13,
			// Token: 0x04039EAA RID: 237226
			HpSprite14,
			// Token: 0x04039EAB RID: 237227
			HpSprite15,
			// Token: 0x04039EAC RID: 237228
			HpSprite16,
			// Token: 0x04039EAD RID: 237229
			HpSprite17,
			// Token: 0x04039EAE RID: 237230
			HpSprite18,
			// Token: 0x04039EAF RID: 237231
			HpSprite19,
			// Token: 0x04039EB0 RID: 237232
			HpSprite20
		}
	}
}
