using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DE9 RID: 15849
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeSelectSpecialItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x060287BD RID: 165821 RVA: 0x00B592E0 File Offset: 0x00B574E0
		public RoguelikeSelectSpecialItem(Action<RoguelikeSelectSpecialItem, RogueGainEntry> clickSpecialItemCallback)
		{
			this.ClickSpecialItemCallback = clickSpecialItemCallback;
		}

		// Token: 0x060287BE RID: 165822 RVA: 0x00B59314 File Offset: 0x00B57514
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickSpecialItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060287BF RID: 165823 RVA: 0x00B5956F File Offset: 0x00B5776F
		protected override void OnBeforeShow()
		{
			this.StarLayout = new GenericLayout<RoguelikeSelectSpecialStarItem, bool>(base.GetHorizontalLayout(4), this.CreateStarItem, null, false, true);
		}

		// Token: 0x060287C0 RID: 165824 RVA: 0x00B5958C File Offset: 0x00B5778C
		public override void Refresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.RogueGainEntry = data;
			RougeMiraclecreation? roguelikeSpecialConfig = RoguelikeConfig.Instance.GetRoguelikeSpecialConfig(data.ConfigId);
			if (roguelikeSpecialConfig == null)
			{
				return;
			}
			UUITexture iconTexture = base.GetTexture(1);
			iconTexture.SetUIActive(false);
			base.SetTextureByPath(roguelikeSpecialConfig.Value.Icon, iconTexture, null, delegate(bool _)
			{
				iconTexture.SetUIActive(true);
			});
			EDescModel? edescModel2;
			EDescModel? edescModel = edescModel2 = new EDescModel?(RoguelikeModel.Instance.GetDescModel());
			EDescModel edescModel3 = EDescModel.SIMPLE;
			string textStringId = (edescModel2.GetValueOrDefault() == edescModel3 & edescModel2 != null) ? roguelikeSpecialConfig.Value.BriefDescribe : roguelikeSpecialConfig.Value.Describe;
			edescModel2 = edescModel;
			edescModel3 = EDescModel.SIMPLE;
			string[] args = (edescModel2.GetValueOrDefault() == edescModel3 & edescModel2 != null) ? roguelikeSpecialConfig.Value.BriefDescParam() : roguelikeSpecialConfig.Value.DescParam();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, args);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), roguelikeSpecialConfig.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(7);
			LguiUtil.Instance.SetLocalTextNew(text, "RogueSpecialRemainTime", new <>z__ReadOnlySingleElementList<object>(data.RestCount));
			text.SetUIActive(data.RestCount != 0);
			base.GetItem(12).SetUIActive(data.IsNew);
			if (roguelikeSpecialConfig.Value.Level > 0)
			{
				base.GetItem(2).SetUIActive(true);
				base.GetItem(3).SetUIActive(false);
				this.RefreshStarLayout(roguelikeSpecialConfig.Value.Level, roguelikeSpecialConfig.Value.MaxLevel);
			}
			else
			{
				base.GetItem(2).SetUIActive(false);
				base.GetItem(3).SetUIActive(true);
			}
			if (data.IsValid)
			{
				base.GetItem(8).SetUIActive(false);
				base.GetTexture(0).SetAlpha(1f);
			}
			else
			{
				base.GetItem(8).SetUIActive(true);
				base.GetTexture(0).SetAlpha(0.6f);
			}
			int colorType = roguelikeSpecialConfig.Value.ColorType;
			RougeMiraclecreationColor? roguelikeMiraclecreationColorConfig = RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(colorType);
			FKuroCurveLinearColor fkuroCurveLinearColor = base.GetUiNiagara(10).ColorParameter.Get("Color");
			FColor fcolor = FColor.FromHex(roguelikeMiraclecreationColorConfig.Value.NiaColor);
			fkuroCurveLinearColor.Constant = FLinearColor.FromSRGBColor(fcolor);
			FKuroCurveLinearColor fkuroCurveLinearColor2 = base.GetUiNiagara(11).ColorParameter.Get("Color");
			fcolor = FColor.FromHex(roguelikeMiraclecreationColorConfig.Value.NiaNorColor);
			fkuroCurveLinearColor2.Constant = FLinearColor.FromSRGBColor(fcolor);
			FKuroCurveLinearColor fkuroCurveLinearColor3 = base.GetUiNiagara(13).ColorParameter.Get("Color");
			fcolor = FColor.FromHex(roguelikeMiraclecreationColorConfig.Value.NiaSelectColor);
			fkuroCurveLinearColor3.Constant = FLinearColor.FromSRGBColor(fcolor);
			FKuroCurveLinearColor fkuroCurveLinearColor4 = base.GetUiNiagara(14).ColorParameter.Get("Color");
			fcolor = FColor.FromHex(roguelikeMiraclecreationColorConfig.Value.NiaSelect1Color);
			fkuroCurveLinearColor4.Constant = FLinearColor.FromSRGBColor(fcolor);
		}

		// Token: 0x060287C1 RID: 165825 RVA: 0x00B598DC File Offset: 0x00B57ADC
		private void RefreshStarLayout(int level, int maxLevel)
		{
			List<bool> list = new List<bool>();
			for (int i = 0; i < maxLevel; i++)
			{
				bool item = level > i;
				list.Add(item);
			}
			this.StarLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060287C2 RID: 165826 RVA: 0x00B59918 File Offset: 0x00B57B18
		public void SetSelect(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(9).SetToggleState(state2, false, false, false);
		}

		// Token: 0x060287C3 RID: 165827 RVA: 0x00B5993F File Offset: 0x00B57B3F
		private void OnClickSpecialItem(EToggleState state)
		{
			if (this.ClickSpecialItemCallback != null)
			{
				this.ClickSpecialItemCallback(this, this.RogueGainEntry);
			}
		}

		// Token: 0x04015F9A RID: 90010
		[Nullable(2)]
		private RogueGainEntry RogueGainEntry;

		// Token: 0x04015F9B RID: 90011
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly Action<RoguelikeSelectSpecialItem, RogueGainEntry> ClickSpecialItemCallback;

		// Token: 0x04015F9C RID: 90012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialStarItem, bool> StarLayout;

		// Token: 0x04015F9D RID: 90013
		private readonly Func<RoguelikeSelectSpecialStarItem> CreateStarItem = () => new RoguelikeSelectSpecialStarItem();

		// Token: 0x020099F2 RID: 39410
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402FFD7 RID: 196567
			public const int BackGroundIcon = 0;

			// Token: 0x0402FFD8 RID: 196568
			public const int Icon = 1;

			// Token: 0x0402FFD9 RID: 196569
			public const int StarLineItem = 2;

			// Token: 0x0402FFDA RID: 196570
			public const int NoStarLineItem = 3;

			// Token: 0x0402FFDB RID: 196571
			public const int StarLayout = 4;

			// Token: 0x0402FFDC RID: 196572
			public const int NameText = 5;

			// Token: 0x0402FFDD RID: 196573
			public const int DescText = 6;

			// Token: 0x0402FFDE RID: 196574
			public const int RemainTimeText = 7;

			// Token: 0x0402FFDF RID: 196575
			public const int DisableItem = 8;

			// Token: 0x0402FFE0 RID: 196576
			public const int ClickToggle = 9;

			// Token: 0x0402FFE1 RID: 196577
			public const int Niagara = 10;

			// Token: 0x0402FFE2 RID: 196578
			public const int NiagaraNor = 11;

			// Token: 0x0402FFE3 RID: 196579
			public const int NewItem = 12;

			// Token: 0x0402FFE4 RID: 196580
			public const int NiagaraSelect = 13;

			// Token: 0x0402FFE5 RID: 196581
			public const int NiagaraSelect1 = 14;
		}
	}
}
