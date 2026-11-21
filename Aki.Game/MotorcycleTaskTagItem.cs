using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200171F RID: 5919
public class MotorcycleTaskTagItem : UiPanelBase
{
	// Token: 0x0600E629 RID: 58921 RVA: 0x00438A34 File Offset: 0x00436C34
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

	// Token: 0x0600E62A RID: 58922 RVA: 0x00438AA4 File Offset: 0x00436CA4
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

	// Token: 0x0600E62B RID: 58923 RVA: 0x00438BE8 File Offset: 0x00436DE8
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

	// Token: 0x020078F8 RID: 30968
	private class EMotorTaskTabItemComponent
	{
		// Token: 0x04027376 RID: 160630
		public const int SprTagBg = 0;

		// Token: 0x04027377 RID: 160631
		public const int RepeatItem = 1;

		// Token: 0x04027378 RID: 160632
		public const int TimeItem = 2;

		// Token: 0x04027379 RID: 160633
		public const int TxtTag = 3;
	}
}
