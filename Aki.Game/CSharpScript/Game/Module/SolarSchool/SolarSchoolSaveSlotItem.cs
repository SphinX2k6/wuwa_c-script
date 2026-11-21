using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A04 RID: 23044
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolSaveSlotItem : GridProxyAbstract<SolarSchoolSaveSlotData>
	{
		// Token: 0x17006C64 RID: 27748
		// (get) Token: 0x06038BE1 RID: 232417 RVA: 0x00FE1A09 File Offset: 0x00FDFC09
		// (set) Token: 0x06038BE2 RID: 232418 RVA: 0x00FE1A11 File Offset: 0x00FDFC11
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolSaveSlotData> ClickCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06038BE3 RID: 232419 RVA: 0x00FE1A1C File Offset: 0x00FDFC1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnBtnSlotClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038BE4 RID: 232420 RVA: 0x00FE1C14 File Offset: 0x00FDFE14
		protected override void OnStart()
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(6);
			UUIItem item = base.GetItem(7);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (horizontalLayout != null && auibaseActor != null)
			{
				this.AttrLayout = new GenericLayout<SolarSchoolSaveAttrItem, SolarSchoolSaveAttrData>(horizontalLayout, () => new SolarSchoolSaveAttrItem(), auibaseActor, false, true);
			}
		}

		// Token: 0x06038BE5 RID: 232421 RVA: 0x00FE1C76 File Offset: 0x00FDFE76
		protected override void OnBeforeDestroy()
		{
			GenericLayout<SolarSchoolSaveAttrItem, SolarSchoolSaveAttrData> attrLayout = this.AttrLayout;
			if (attrLayout != null)
			{
				attrLayout.ClearChildren();
			}
			this.AttrLayout = null;
			this.ClickCallback = null;
			this.Data = null;
		}

		// Token: 0x06038BE6 RID: 232422 RVA: 0x00FE1CA0 File Offset: 0x00FDFEA0
		public override void Refresh(SolarSchoolSaveSlotData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(data.IsEmpty);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(!data.IsEmpty);
			}
			UUIButtonComponent button = base.GetButton(9);
			if (button != null)
			{
				button.SetSelfInteractive(data.CanClick);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(data.IsAutoSlot);
			}
			UUITexture texture = base.GetTexture(10);
			if (texture != null)
			{
				texture.SetUIActive(data.IsAutoSlot);
			}
			UUIItem item4 = base.GetItem(11);
			if (item4 != null)
			{
				item4.SetUIActive(data.IsLastSaved);
			}
			if (data.IsEmpty)
			{
				GenericLayout<SolarSchoolSaveAttrItem, SolarSchoolSaveAttrData> attrLayout = this.AttrLayout;
				if (attrLayout == null)
				{
					return;
				}
				attrLayout.RefreshByData(Array.Empty<SolarSchoolSaveAttrData>(), null, false);
				return;
			}
			else
			{
				SolarSchoolSavePreviewPb preview = data.Preview;
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.SetText(string.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchool_CycleNum", null) ?? string.Empty, preview.CycleCount), true);
				}
				UUIText text2 = base.GetText(4);
				if (text2 != null)
				{
					text2.SetText(this.GetGameDateText(preview.GameDay), true);
				}
				base.TrySetTextureByPath(this.GetSeasonTexPath(data.ActivityId, preview.GameDay), base.GetTexture(8), null, null);
				UUIText text3 = base.GetText(5);
				if (text3 != null)
				{
					text3.SetText(TimeUtil.Instance.DateFormatString((double)preview.LastSaveTime), true);
				}
				GenericLayout<SolarSchoolSaveAttrItem, SolarSchoolSaveAttrData> attrLayout2 = this.AttrLayout;
				if (attrLayout2 == null)
				{
					return;
				}
				attrLayout2.RefreshByData(this.BuildAttrList(preview), null, false);
				return;
			}
		}

		// Token: 0x06038BE7 RID: 232423 RVA: 0x00FE1E2D File Offset: 0x00FE002D
		public override void Clear()
		{
			this.Data = null;
		}

		// Token: 0x06038BE8 RID: 232424 RVA: 0x00FE1E36 File Offset: 0x00FE0036
		[NullableContext(2)]
		public UUIItem GetGuideSlotItem()
		{
			UUIButtonComponent button = base.GetButton(9);
			if (button == null)
			{
				return null;
			}
			return button.GetRootComponent();
		}

		// Token: 0x06038BE9 RID: 232425 RVA: 0x00FE1E4C File Offset: 0x00FE004C
		private string GetGameDateText(int dayIndex)
		{
			ValueTuple<int, int> monthDay = SolarSchoolUtils.GetMonthDay(dayIndex);
			int item = monthDay.Item1;
			int item2 = monthDay.Item2;
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("SolarSchool_Day", null);
			if (!string.IsNullOrEmpty(localTextNew))
			{
				return string.Format(localTextNew, item.ToString("D2"), item2.ToString("D2"));
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item, "D2");
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2, "D2");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06038BEA RID: 232426 RVA: 0x00FE1ED8 File Offset: 0x00FE00D8
		[NullableContext(2)]
		private string GetSeasonTexPath(int activityId, int dayIndex)
		{
			SolarSchoolDatePeriod? datePeriod = SolarSchoolConfig.Instance.GetDatePeriod(activityId, dayIndex);
			string text = (datePeriod != null) ? datePeriod.GetValueOrDefault().SaveSlotTex : null;
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06038BEB RID: 232427 RVA: 0x00FE1F1C File Offset: 0x00FE011C
		private List<SolarSchoolSaveAttrData> BuildAttrList(SolarSchoolSavePreviewPb preview)
		{
			Dictionary<ESolarSchoolSecondAttr, int> dictionary = new Dictionary<ESolarSchoolSecondAttr, int>();
			foreach (SolarSchoolAttrPb solarSchoolAttrPb in preview.Attr)
			{
				dictionary[(ESolarSchoolSecondAttr)solarSchoolAttrPb.AttrType] = solarSchoolAttrPb.Value;
			}
			List<SolarSchoolSaveAttrData> list = new List<SolarSchoolSaveAttrData>();
			foreach (ESolarSchoolSecondAttr esolarSchoolSecondAttr in SolarSchoolDefine.AttrsShowList)
			{
				int value;
				dictionary.TryGetValue(esolarSchoolSecondAttr, out value);
				list.Add(new SolarSchoolSaveAttrData(this.Data.ActivityId, esolarSchoolSecondAttr, value));
			}
			return list;
		}

		// Token: 0x06038BEC RID: 232428 RVA: 0x00FE1FC8 File Offset: 0x00FE01C8
		private void OnBtnSlotClick()
		{
			if (this.Data == null || !this.Data.CanClick)
			{
				return;
			}
			Action<SolarSchoolSaveSlotData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data);
		}

		// Token: 0x0401DDF8 RID: 122360
		[Nullable(2)]
		private SolarSchoolSaveSlotData Data;

		// Token: 0x0401DDF9 RID: 122361
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolSaveAttrItem, SolarSchoolSaveAttrData> AttrLayout;

		// Token: 0x0200B5B2 RID: 46514
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040382F5 RID: 230133
			public const int PnlNull = 0;

			// Token: 0x040382F6 RID: 230134
			public const int PnlContent = 1;

			// Token: 0x040382F7 RID: 230135
			public const int TxtTitle = 2;

			// Token: 0x040382F8 RID: 230136
			public const int PnlTips = 3;

			// Token: 0x040382F9 RID: 230137
			public const int TxtPro = 4;

			// Token: 0x040382FA RID: 230138
			public const int TxtTime = 5;

			// Token: 0x040382FB RID: 230139
			public const int PnlItemLayout = 6;

			// Token: 0x040382FC RID: 230140
			public const int PnlItem = 7;

			// Token: 0x040382FD RID: 230141
			public const int TexSeason = 8;

			// Token: 0x040382FE RID: 230142
			public const int BtnSlot = 9;

			// Token: 0x040382FF RID: 230143
			public const int TexBgAuto = 10;

			// Token: 0x04038300 RID: 230144
			public const int PnlLastSavedTag = 11;
		}
	}
}
