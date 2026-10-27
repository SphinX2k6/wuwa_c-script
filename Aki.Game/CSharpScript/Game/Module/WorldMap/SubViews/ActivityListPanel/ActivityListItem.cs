using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityListPanel
{
	// Token: 0x02004848 RID: 18504
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActivityListItem : GridProxyAbstract<ActivityListPanelItemData>
	{
		// Token: 0x060306A5 RID: 198309 RVA: 0x00B3CDE8 File Offset: 0x00B3AFE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.ReadPoint, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.TextTitle, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.TextTime, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.TextDescription, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.Icon, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.TextValue, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.ActivityIcon, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.FinishedIcon, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.UpIcon, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.DoubleUpIcon, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(ActivityListItem.EChildType.Toggle, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(ActivityListItem.EChildType.Toggle, new Action<EToggleState>(this.OnToggleClickInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060306A6 RID: 198310 RVA: 0x00B3CFE8 File Offset: 0x00B3B1E8
		public override void Refresh(ActivityListPanelItemData data, bool isSelected, int gridIndex)
		{
			this.DataParam = data.Data;
			this.OnClickCb = data.OnClickCb;
			this.RefreshReadPoint();
			this.RefreshInfo();
		}

		// Token: 0x060306A7 RID: 198311 RVA: 0x00B3D00E File Offset: 0x00B3B20E
		public void RefreshReadPoint()
		{
			base.GetItem(ActivityListItem.EChildType.ReadPoint).SetUIActive(this.DataParam.RedPoint);
		}

		// Token: 0x060306A8 RID: 198312 RVA: 0x00B3D02B File Offset: 0x00B3B22B
		public EMapPeriodicActivityId GetMapPeriodicActivityId()
		{
			return this.DataParam.Id;
		}

		// Token: 0x060306A9 RID: 198313 RVA: 0x00B3D038 File Offset: 0x00B3B238
		public void RefreshInfo()
		{
			MapPeriodicActivity? mapPeriodicActivityConfig = MapConfig.Instance.GetMapPeriodicActivityConfig(this.DataParam.Id);
			base.GetText(ActivityListItem.EChildType.TextTitle).ShowTextNew(((mapPeriodicActivityConfig != null) ? mapPeriodicActivityConfig.GetValueOrDefault().TitleKey : null) ?? "");
			base.GetText(ActivityListItem.EChildType.TextDescription).ShowTextNew(((mapPeriodicActivityConfig != null) ? mapPeriodicActivityConfig.GetValueOrDefault().DescriptionKey : null) ?? "");
			this.SetSpriteByPath(mapPeriodicActivityConfig.Value.IconPath, base.GetSprite(ActivityListItem.EChildType.ActivityIcon), true, null, null);
			base.GetText(ActivityListItem.EChildType.TextTime).SetText(this.DataParam.LeftTimeText, true);
			UUIText text = base.GetText(ActivityListItem.EChildType.TextValue);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.DataParam.CurrentNum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.DataParam.TotalNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetItem(ActivityListItem.EChildType.Icon).SetUIActive(false);
			base.GetSprite(ActivityListItem.EChildType.FinishedIcon).SetUIActive(this.DataParam.IsFinish);
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("MapPeriodicActivityTime").GetValueOrDefault();
			double leftTime = this.DataParam.LeftTime;
			UUIText text2 = base.GetText(ActivityListItem.EChildType.TextTime);
			UUIItem uuiitem = text2;
			bool bUseChangeColor = leftTime > 0.0 && leftTime <= (double)valueOrDefault;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x060306AA RID: 198314 RVA: 0x00B3D1E3 File Offset: 0x00B3B3E3
		private void OnToggleClickInternal(EToggleState toggleState)
		{
			Action onClickCb = this.DataParam.OnClickCb;
			if (onClickCb != null)
			{
				onClickCb();
			}
			Action onClickCb2 = this.OnClickCb;
			if (onClickCb2 != null)
			{
				onClickCb2();
			}
			base.GetExtendToggle(ActivityListItem.EChildType.Toggle).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401A05F RID: 106591
		private IActivityListItemData DataParam;

		// Token: 0x0401A060 RID: 106592
		[Nullable(2)]
		private Action OnClickCb;

		// Token: 0x0200AB25 RID: 43813
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x04034023 RID: 213027
			public static readonly int Toggle = 0;

			// Token: 0x04034024 RID: 213028
			public static readonly int ReadPoint = 1;

			// Token: 0x04034025 RID: 213029
			public static readonly int TextTitle = 2;

			// Token: 0x04034026 RID: 213030
			public static readonly int TextTime = 3;

			// Token: 0x04034027 RID: 213031
			public static readonly int TextDescription = 4;

			// Token: 0x04034028 RID: 213032
			public static readonly int Icon = 5;

			// Token: 0x04034029 RID: 213033
			public static readonly int TextValue = 6;

			// Token: 0x0403402A RID: 213034
			public static readonly int ActivityIcon = 7;

			// Token: 0x0403402B RID: 213035
			public static readonly int FinishedIcon = 8;

			// Token: 0x0403402C RID: 213036
			public static readonly int UpIcon = 9;

			// Token: 0x0403402D RID: 213037
			public static readonly int DoubleUpIcon = 10;
		}
	}
}
