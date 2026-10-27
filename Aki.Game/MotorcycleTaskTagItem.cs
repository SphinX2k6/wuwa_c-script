using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200223B RID: 8763
public class MotorcycleTaskTagItem : UiPanelBase
{
	// Token: 0x06011193 RID: 70035 RVA: 0x0042BE90 File Offset: 0x0042A090
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x06011194 RID: 70036 RVA: 0x0042BF00 File Offset: 0x0042A100
	[NullableContext(1)]
	public void Refresh(MotorTechTaskNode node)
	{
		base.GetItem(1).SetUIActive(node.Type == EMotorTechTaskType.Loop);
		base.GetItem(2).SetUIActive(node.Type == EMotorTechTaskType.Limited);
		if (node.Type == EMotorTechTaskType.Limited)
		{
			double endTime = (double)node.EndTime;
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = Math.Max(endTime - serverTime, 1.0);
			CommonDefine.ETimeType[] timeTypeData = this.GetTimeTypeData(num);
			string text = TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(timeTypeData[0]), new CommonDefine.ETimeType?(timeTypeData[1])).CountDownText ?? "";
			base.GetText(3).SetText(StringUtils.Format("{0}", new string[]
			{
				text
			}), true);
		}
		else if (node.Type == EMotorTechTaskType.Loop)
		{
			int num2 = node.RewardInfo.WaitRewardCount + node.RewardInfo.RewardedCount;
			int maxRewardCount = node.RewardInfo.MaxRewardCount;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "MotorBike_TechCube_RepeatStatus", new <>z__ReadOnlyArray<object>(new object[]
			{
				num2,
				maxRewardCount
			}));
		}
		UUISprite sprite = base.GetSprite(0);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = node.Type == EMotorTechTaskType.Loop;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x06011195 RID: 70037 RVA: 0x0042C044 File Offset: 0x0042A244
	[NullableContext(1)]
	private CommonDefine.ETimeType[] GetTimeTypeData(double remainTime)
	{
		if (remainTime > 86400.0)
		{
			return new CommonDefine.ETimeType[]
			{
				CommonDefine.ETimeType.Day,
				CommonDefine.ETimeType.Hour
			};
		}
		if (remainTime > 3600.0)
		{
			return new CommonDefine.ETimeType[]
			{
				CommonDefine.ETimeType.Hour,
				CommonDefine.ETimeType.Minute
			};
		}
		if (remainTime > 60.0)
		{
			CommonDefine.ETimeType[] array = new CommonDefine.ETimeType[2];
			array[0] = CommonDefine.ETimeType.Minute;
			return array;
		}
		return new CommonDefine.ETimeType[2];
	}

	// Token: 0x0200876F RID: 34671
	private class EMotorTaskTabItemComponent
	{
		// Token: 0x0402C05E RID: 180318
		public const int SprTagBg = 0;

		// Token: 0x0402C05F RID: 180319
		public const int RepeatItem = 1;

		// Token: 0x0402C060 RID: 180320
		public const int TimeItem = 2;

		// Token: 0x0402C061 RID: 180321
		public const int TxtTag = 3;
	}
}
