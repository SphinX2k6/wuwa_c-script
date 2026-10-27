using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E20 RID: 20000
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeSelectSpecialItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x06033952 RID: 211282 RVA: 0x00C0FDA8 File Offset: 0x00C0DFA8
		public RoguelikeSelectSpecialItem(Action<RoguelikeSelectSpecialItem, RogueGainEntry> clickSpecialItemCallback)
		{
			this.ClickSpecialItemCallback = clickSpecialItemCallback;
		}

		// Token: 0x06033953 RID: 211283 RVA: 0x00C0FDDC File Offset: 0x00C0DFDC
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

		// Token: 0x06033954 RID: 211284 RVA: 0x00C10037 File Offset: 0x00C0E237
		protected override void OnBeforeShow()
		{
			this.StarLayout = new GenericLayout<RoguelikeSelectSpecialStarItem, bool>(base.GetHorizontalLayout(4), this.CreateStarItem, null, false, true);
		}

		// Token: 0x06033955 RID: 211285 RVA: 0x00C10054 File Offset: 0x00C0E254
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
			string[] source = (edescModel2.GetValueOrDefault() == edescModel3 & edescModel2 != null) ? roguelikeSpecialConfig.Value.BriefDescParam() : roguelikeSpecialConfig.Value.DescParam();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, source.ToArray<string>());
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

		// Token: 0x06033956 RID: 211286 RVA: 0x00C103A8 File Offset: 0x00C0E5A8
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

		// Token: 0x06033957 RID: 211287 RVA: 0x00C103E4 File Offset: 0x00C0E5E4
		public void SetSelect(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(9).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06033958 RID: 211288 RVA: 0x00C1040B File Offset: 0x00C0E60B
		private void OnClickSpecialItem(EToggleState state)
		{
			if (this.ClickSpecialItemCallback != null)
			{
				this.ClickSpecialItemCallback(this, this.RogueGainEntry);
			}
		}

		// Token: 0x0401B5C7 RID: 112071
		[Nullable(2)]
		private RogueGainEntry RogueGainEntry;

		// Token: 0x0401B5C8 RID: 112072
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly Action<RoguelikeSelectSpecialItem, RogueGainEntry> ClickSpecialItemCallback;

		// Token: 0x0401B5C9 RID: 112073
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialStarItem, bool> StarLayout;

		// Token: 0x0401B5CA RID: 112074
		private readonly Func<RoguelikeSelectSpecialStarItem> CreateStarItem = () => new RoguelikeSelectSpecialStarItem();

		// Token: 0x0200AFC0 RID: 44992
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040355A7 RID: 218535
			public const int BackGroundIcon = 0;

			// Token: 0x040355A8 RID: 218536
			public const int Icon = 1;

			// Token: 0x040355A9 RID: 218537
			public const int StarLineItem = 2;

			// Token: 0x040355AA RID: 218538
			public const int NoStarLineItem = 3;

			// Token: 0x040355AB RID: 218539
			public const int StarLayout = 4;

			// Token: 0x040355AC RID: 218540
			public const int NameText = 5;

			// Token: 0x040355AD RID: 218541
			public const int DescText = 6;

			// Token: 0x040355AE RID: 218542
			public const int RemainTimeText = 7;

			// Token: 0x040355AF RID: 218543
			public const int DisableItem = 8;

			// Token: 0x040355B0 RID: 218544
			public const int ClickToggle = 9;

			// Token: 0x040355B1 RID: 218545
			public const int Niagara = 10;

			// Token: 0x040355B2 RID: 218546
			public const int NiagaraNor = 11;

			// Token: 0x040355B3 RID: 218547
			public const int NewItem = 12;

			// Token: 0x040355B4 RID: 218548
			public const int NiagaraSelect = 13;

			// Token: 0x040355B5 RID: 218549
			public const int NiagaraSelect1 = 14;
		}
	}
}
