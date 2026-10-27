using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E31 RID: 20017
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSpecialDetailView : UiViewBase
	{
		// Token: 0x060339CC RID: 211404 RVA: 0x00C13EC4 File Offset: 0x00C120C4
		public RoguelikeSpecialDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060339CD RID: 211405 RVA: 0x00C13EF4 File Offset: 0x00C120F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060339CE RID: 211406 RVA: 0x00C140A4 File Offset: 0x00C122A4
		protected override void OnStart()
		{
			object[] array = this.OpenParam as object[];
			if (array == null)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.BB, "RoguelikeSpecialDetailView无效输入", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.GainEntryData = (array[0] as RogueGainEntry);
			this.CloseCallBack = (array[1] as Action<bool?>);
			this.StarLayout = new GenericLayout<RoguelikeSelectSpecialStarItem, bool>(base.GetHorizontalLayout(3), this.CreateStarItem, null, false, true);
			this.RefreshUi(this.GainEntryData);
		}

		// Token: 0x060339CF RID: 211407 RVA: 0x00C14123 File Offset: 0x00C12323
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.RoguelikeDataRefresh));
		}

		// Token: 0x060339D0 RID: 211408 RVA: 0x00C14141 File Offset: 0x00C12341
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.RoguelikeDataRefresh));
		}

		// Token: 0x060339D1 RID: 211409 RVA: 0x00C14160 File Offset: 0x00C12360
		private void RefreshUi(RogueGainEntry data)
		{
			RougeMiraclecreation? roguelikeSpecialConfig = RoguelikeConfig.Instance.GetRoguelikeSpecialConfig(data.ConfigId);
			if (roguelikeSpecialConfig == null)
			{
				return;
			}
			UUITexture iconTexture = base.GetTexture(0);
			iconTexture.SetUIActive(false);
			base.SetTextureByPath(roguelikeSpecialConfig.Value.Icon, iconTexture, null, delegate(bool _)
			{
				iconTexture.SetUIActive(true);
			});
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), roguelikeSpecialConfig.Value.Name, Array.Empty<object>());
			RoguelikeModel instance = RoguelikeModel.Instance;
			EDescModel? edescModel2;
			EDescModel? edescModel = edescModel2 = ((instance != null) ? new EDescModel?(instance.GetDescModel()) : null);
			EDescModel edescModel3 = EDescModel.SIMPLE;
			string textStringId = (edescModel2.GetValueOrDefault() == edescModel3 & edescModel2 != null) ? roguelikeSpecialConfig.Value.BriefDescribe : roguelikeSpecialConfig.Value.Describe;
			edescModel2 = edescModel;
			edescModel3 = EDescModel.SIMPLE;
			string[] source = (edescModel2.GetValueOrDefault() == edescModel3 & edescModel2 != null) ? roguelikeSpecialConfig.Value.BriefDescParam() : roguelikeSpecialConfig.Value.DescParam();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textStringId, source.ToArray<string>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), roguelikeSpecialConfig.Value.StoryDescribe, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RogueSpecialRemainTime", new <>z__ReadOnlySingleElementList<object>(data.RestCount));
			base.GetText(4).SetUIActive(data.RestCount != 0);
			int colorType = roguelikeSpecialConfig.Value.ColorType;
			RougeMiraclecreationColor? roguelikeMiraclecreationColorConfig = RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(colorType);
			FKuroCurveLinearColor fkuroCurveLinearColor = base.GetUiNiagara(8).ColorParameter.Get("Color");
			FColor fcolor = FColor.FromHex(roguelikeMiraclecreationColorConfig.Value.NiaColor);
			fkuroCurveLinearColor.Constant = FLinearColor.FromSRGBColor(fcolor);
			FKuroCurveLinearColor fkuroCurveLinearColor2 = base.GetUiNiagara(9).ColorParameter.Get("Color");
			fcolor = FColor.FromHex(roguelikeMiraclecreationColorConfig.Value.NiaNorColor);
			fkuroCurveLinearColor2.Constant = FLinearColor.FromSRGBColor(fcolor);
			this.RefreshStarLayout(roguelikeSpecialConfig.Value.Level, roguelikeSpecialConfig.Value.MaxLevel);
		}

		// Token: 0x060339D2 RID: 211410 RVA: 0x00C143CC File Offset: 0x00C125CC
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

		// Token: 0x060339D3 RID: 211411 RVA: 0x00C14405 File Offset: 0x00C12605
		private void RoguelikeDataRefresh()
		{
			this.RefreshUi(this.GainEntryData);
		}

		// Token: 0x060339D4 RID: 211412 RVA: 0x00C14413 File Offset: 0x00C12613
		private void OnClickCloseBtn()
		{
			base.CloseMe(delegate(bool success)
			{
				Action<bool?> closeCallBack = this.CloseCallBack;
				if (closeCallBack == null)
				{
					return;
				}
				closeCallBack(new bool?(success));
			});
		}

		// Token: 0x0401B5FE RID: 112126
		[Nullable(2)]
		private RogueGainEntry GainEntryData;

		// Token: 0x0401B5FF RID: 112127
		[Nullable(2)]
		private Action<bool?> CloseCallBack;

		// Token: 0x0401B600 RID: 112128
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialStarItem, bool> StarLayout;

		// Token: 0x0401B601 RID: 112129
		private readonly Func<RoguelikeSelectSpecialStarItem> CreateStarItem = () => new RoguelikeSelectSpecialStarItem();

		// Token: 0x0200AFE8 RID: 45032
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04035677 RID: 218743
			public const int Icon = 0;

			// Token: 0x04035678 RID: 218744
			public const int BgIcon = 1;

			// Token: 0x04035679 RID: 218745
			public const int Name = 2;

			// Token: 0x0403567A RID: 218746
			public const int StarLayout = 3;

			// Token: 0x0403567B RID: 218747
			public const int RemainTimeText = 4;

			// Token: 0x0403567C RID: 218748
			public const int Desc = 5;

			// Token: 0x0403567D RID: 218749
			public const int StoryDesc = 6;

			// Token: 0x0403567E RID: 218750
			public const int CloseButton = 7;

			// Token: 0x0403567F RID: 218751
			public const int Niagara = 8;

			// Token: 0x04035680 RID: 218752
			public const int NiagaraNor = 9;
		}
	}
}
