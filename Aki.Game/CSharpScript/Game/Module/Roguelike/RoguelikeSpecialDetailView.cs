using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DFA RID: 15866
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSpecialDetailView : UiViewBase
	{
		// Token: 0x06028837 RID: 165943 RVA: 0x00B5D3F0 File Offset: 0x00B5B5F0
		public RoguelikeSpecialDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028838 RID: 165944 RVA: 0x00B5D420 File Offset: 0x00B5B620
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

		// Token: 0x06028839 RID: 165945 RVA: 0x00B5D5D0 File Offset: 0x00B5B7D0
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

		// Token: 0x0602883A RID: 165946 RVA: 0x00B5D64F File Offset: 0x00B5B84F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.RoguelikeDataRefresh));
		}

		// Token: 0x0602883B RID: 165947 RVA: 0x00B5D66D File Offset: 0x00B5B86D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.RoguelikeDataRefresh));
		}

		// Token: 0x0602883C RID: 165948 RVA: 0x00B5D68C File Offset: 0x00B5B88C
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
			string[] args = (edescModel2.GetValueOrDefault() == edescModel3 & edescModel2 != null) ? roguelikeSpecialConfig.Value.BriefDescParam() : roguelikeSpecialConfig.Value.DescParam();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textStringId, args);
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

		// Token: 0x0602883D RID: 165949 RVA: 0x00B5D8F4 File Offset: 0x00B5BAF4
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

		// Token: 0x0602883E RID: 165950 RVA: 0x00B5D92D File Offset: 0x00B5BB2D
		private void RoguelikeDataRefresh()
		{
			this.RefreshUi(this.GainEntryData);
		}

		// Token: 0x0602883F RID: 165951 RVA: 0x00B5D93B File Offset: 0x00B5BB3B
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

		// Token: 0x04015FD1 RID: 90065
		[Nullable(2)]
		private RogueGainEntry GainEntryData;

		// Token: 0x04015FD2 RID: 90066
		[Nullable(2)]
		private Action<bool?> CloseCallBack;

		// Token: 0x04015FD3 RID: 90067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoguelikeSelectSpecialStarItem, bool> StarLayout;

		// Token: 0x04015FD4 RID: 90068
		private readonly Func<RoguelikeSelectSpecialStarItem> CreateStarItem = () => new RoguelikeSelectSpecialStarItem();

		// Token: 0x02009A1A RID: 39450
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040300A7 RID: 196775
			public const int Icon = 0;

			// Token: 0x040300A8 RID: 196776
			public const int BgIcon = 1;

			// Token: 0x040300A9 RID: 196777
			public const int Name = 2;

			// Token: 0x040300AA RID: 196778
			public const int StarLayout = 3;

			// Token: 0x040300AB RID: 196779
			public const int RemainTimeText = 4;

			// Token: 0x040300AC RID: 196780
			public const int Desc = 5;

			// Token: 0x040300AD RID: 196781
			public const int StoryDesc = 6;

			// Token: 0x040300AE RID: 196782
			public const int CloseButton = 7;

			// Token: 0x040300AF RID: 196783
			public const int Niagara = 8;

			// Token: 0x040300B0 RID: 196784
			public const int NiagaraNor = 9;
		}
	}
}
