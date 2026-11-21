using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A60 RID: 23136
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolMonthSummaryItem : GridProxyAbstract<SolarSchoolMonthSummaryData>
	{
		// Token: 0x06038FF7 RID: 233463 RVA: 0x00FF6F1C File Offset: 0x00FF511C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038FF8 RID: 233464 RVA: 0x00FF6FA6 File Offset: 0x00FF51A6
		protected override void OnStart()
		{
		}

		// Token: 0x06038FF9 RID: 233465 RVA: 0x00FF6FA8 File Offset: 0x00FF51A8
		public override void Refresh(SolarSchoolMonthSummaryData data, bool isSelected, int gridIndex)
		{
			if (data.IsNotice)
			{
				this.RefreshNotice(data);
				return;
			}
			this.RefreshAttribute(data);
		}

		// Token: 0x06038FFA RID: 233466 RVA: 0x00FF6FC4 File Offset: 0x00FF51C4
		private void RefreshNotice(SolarSchoolMonthSummaryData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SolarSchool_CompleteSpecialApproval_1", Array.Empty<object>());
			int value = data.Value;
			string str = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchool_CompleteSpecialApproval_2", null), new string[]
			{
				value.ToString()
			});
			string newText = (value > 0) ? ("<color=#adef80>" + str + "</color>") : ("<color=#ff6e8d>" + str + "</color>");
			base.GetText(2).SetText(newText, true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.NoticeIconSourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				return;
			}
			base.TrySetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}

		// Token: 0x06038FFB RID: 233467 RVA: 0x00FF707C File Offset: 0x00FF527C
		private void RefreshAttribute(SolarSchoolMonthSummaryData data)
		{
			ESolarSchoolSecondAttr? attr = data.Attr;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(instance.ActivityId, (int)attr.Value);
			if (solarSchoolAttr == null)
			{
				return;
			}
			SolarSchoolAttr value = solarSchoolAttr.Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			base.TrySetTextureByPath(value.YellowIconSmall, base.GetTexture(0), null, null);
			int value2 = data.Value;
			string str = StringUtils.Format((value2 > 0) ? "+{0}" : "-{0}", new string[]
			{
				Math.Abs(value2).ToString()
			});
			string newText = (value2 > 0) ? ("<color=#adef80>" + str + "</color>") : ("<color=#ff6e8d>" + str + "</color>");
			base.GetText(2).SetText(newText, true);
		}

		// Token: 0x0401DFFC RID: 122876
		[Nullable(2)]
		private SolarSchoolGalleryData Data;

		// Token: 0x0401DFFD RID: 122877
		private string NoticeIconSourceId = "T_IconSolarSchoolSumTonggao";

		// Token: 0x0200B64D RID: 46669
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403864F RID: 230991
			public const int Icon = 0;

			// Token: 0x04038650 RID: 230992
			public const int NameText = 1;

			// Token: 0x04038651 RID: 230993
			public const int ValueText = 2;
		}
	}
}
