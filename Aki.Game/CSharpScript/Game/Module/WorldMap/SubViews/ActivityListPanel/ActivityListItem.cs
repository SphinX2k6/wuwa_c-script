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
	// Token: 0x02003779 RID: 14201
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActivityListItem : GridProxyAbstract<ActivityListPanelItemData>
	{
		// Token: 0x06024E75 RID: 151157 RVA: 0x00A6CFD0 File Offset: 0x00A6B1D0
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

		// Token: 0x06024E76 RID: 151158 RVA: 0x00A6D1D0 File Offset: 0x00A6B3D0
		public override void Refresh(ActivityListPanelItemData data, bool isSelected, int gridIndex)
		{
			this.DataParam = data.Data;
			this.OnClickCb = data.OnClickCb;
			this.RefreshReadPoint();
			this.RefreshInfo();
		}

		// Token: 0x06024E77 RID: 151159 RVA: 0x00A6D1F6 File Offset: 0x00A6B3F6
		public void RefreshReadPoint()
		{
			base.GetItem(ActivityListItem.EChildType.ReadPoint).SetUIActive(this.DataParam.RedPoint);
		}

		// Token: 0x06024E78 RID: 151160 RVA: 0x00A6D213 File Offset: 0x00A6B413
		public EMapPeriodicActivityId GetMapPeriodicActivityId()
		{
			return this.DataParam.Id;
		}

		// Token: 0x06024E79 RID: 151161 RVA: 0x00A6D220 File Offset: 0x00A6B420
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

		// Token: 0x06024E7A RID: 151162 RVA: 0x00A6D3CB File Offset: 0x00A6B5CB
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

		// Token: 0x04014713 RID: 83731
		private IActivityListItemData DataParam;

		// Token: 0x04014714 RID: 83732
		[Nullable(2)]
		private Action OnClickCb;

		// Token: 0x020094D3 RID: 38099
		[NullableContext(0)]
		public static class EChildType
		{
			// Token: 0x0402E79E RID: 190366
			public static readonly int Toggle = 0;

			// Token: 0x0402E79F RID: 190367
			public static readonly int ReadPoint = 1;

			// Token: 0x0402E7A0 RID: 190368
			public static readonly int TextTitle = 2;

			// Token: 0x0402E7A1 RID: 190369
			public static readonly int TextTime = 3;

			// Token: 0x0402E7A2 RID: 190370
			public static readonly int TextDescription = 4;

			// Token: 0x0402E7A3 RID: 190371
			public static readonly int Icon = 5;

			// Token: 0x0402E7A4 RID: 190372
			public static readonly int TextValue = 6;

			// Token: 0x0402E7A5 RID: 190373
			public static readonly int ActivityIcon = 7;

			// Token: 0x0402E7A6 RID: 190374
			public static readonly int FinishedIcon = 8;

			// Token: 0x0402E7A7 RID: 190375
			public static readonly int UpIcon = 9;

			// Token: 0x0402E7A8 RID: 190376
			public static readonly int DoubleUpIcon = 10;
		}
	}
}
