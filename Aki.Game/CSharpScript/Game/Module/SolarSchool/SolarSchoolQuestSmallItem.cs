using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F1 RID: 23025
	public class SolarSchoolQuestSmallItem : SolarSchoolQuestNodeItemBase
	{
		// Token: 0x06038B6E RID: 232302 RVA: 0x00FDF3FC File Offset: 0x00FDD5FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038B6F RID: 232303 RVA: 0x00FDF4C8 File Offset: 0x00FDD6C8
		protected override void OnStart()
		{
			base.OnStart();
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06038B70 RID: 232304 RVA: 0x00FDF4E4 File Offset: 0x00FDD6E4
		[NullableContext(1)]
		protected override void OnRefreshNode(SolarSchoolQuest quest, SolarSchoolSingleQuestData questData)
		{
			UUITexture texture = base.GetTexture(1);
			base.SetTextureShowUntilLoaded(quest.ImportantIcon, texture, null);
			if (texture != null)
			{
				texture.SetIsGray(questData.IsExpired);
			}
			if (texture != null)
			{
				UUIItem uuiitem = texture;
				bool bUseChangeColor = !questData.InShowTime && !questData.IsExpired;
				FColor? fcolor = new FColor?(texture.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), quest.Name, Array.Empty<object>());
			UUIText text = base.GetText(3);
			string dateStr = base.GetDateStr(quest.EndDayIndex, questData.IsExpired);
			if (text != null)
			{
				text.SetText(dateStr, true);
			}
			if (questData.IsUnlocked)
			{
				this.MarkQuestUnlockRedDot();
			}
		}

		// Token: 0x06038B71 RID: 232305 RVA: 0x00FDF598 File Offset: 0x00FDD798
		private void MarkQuestUnlockRedDot()
		{
			SolarSchoolSingleQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(base.QuestId);
			if (questData == null)
			{
				return;
			}
			questData.MarkQuestUnlockRedDot();
		}

		// Token: 0x0200B5A4 RID: 46500
		private class EComponents
		{
			// Token: 0x040382BB RID: 230075
			public const int PnlRoot = 0;

			// Token: 0x040382BC RID: 230076
			public const int TexIcon = 1;

			// Token: 0x040382BD RID: 230077
			public const int TxtTitle = 2;

			// Token: 0x040382BE RID: 230078
			public const int TxtDate = 3;

			// Token: 0x040382BF RID: 230079
			public const int ItemRedPoint = 4;
		}
	}
}
