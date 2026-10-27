using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004887 RID: 18567
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class VillageTaskItem : GridProxyAbstract<VillageInfrLimitTaskData>
	{
		// Token: 0x06030919 RID: 198937 RVA: 0x00B47F24 File Offset: 0x00B46124
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickConfirm))
			};
		}

		// Token: 0x0603091A RID: 198938 RVA: 0x00B48025 File Offset: 0x00B46225
		protected override void OnStart()
		{
			this.RewardScroll = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), () => new CommonItemSmallItemGrid(), null, false, true);
		}

		// Token: 0x0603091B RID: 198939 RVA: 0x00B4805C File Offset: 0x00B4625C
		public override void Refresh(VillageInfrLimitTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			InfrV2Reward? infrActivityTaskConfig = VillageInfrConfig.Instance.GetInfrActivityTaskConfig(this.Data.ConfigId);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.Data.TaskReward);
			this.RewardScroll.RefreshByData(dropPackagePreviewItemList, null, false);
			ConditionTaskState status = data.Status;
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetText(5).SetUIActive(status == ConditionTaskState.ConditionTaskRunning);
			base.GetSprite(6).SetUIActive(status == ConditionTaskState.ConditionTaskTaken);
			base.GetItem(7).SetUIActive(status == ConditionTaskState.ConditionTaskFinish);
			base.GetButton(8).RootUIComp.Get().SetUIActive(status == ConditionTaskState.ConditionTaskFinish);
			base.GetText(0).ShowTextNew(infrActivityTaskConfig.Value.Desc);
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603091C RID: 198940 RVA: 0x00B48181 File Offset: 0x00B46381
		public void SetOnClickConfirm([Nullable(new byte[]
		{
			2,
			1
		})] Action<VillageInfrLimitTaskData> callback)
		{
			this.OnClickConfirmCb = callback;
		}

		// Token: 0x0603091D RID: 198941 RVA: 0x00B4818A File Offset: 0x00B4638A
		private void OnClickConfirm()
		{
			Action<VillageInfrLimitTaskData> onClickConfirmCb = this.OnClickConfirmCb;
			if (onClickConfirmCb == null)
			{
				return;
			}
			onClickConfirmCb(this.Data);
		}

		// Token: 0x0401A19D RID: 106909
		[Nullable(2)]
		private VillageInfrLimitTaskData Data;

		// Token: 0x0401A19E RID: 106910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<VillageInfrLimitTaskData> OnClickConfirmCb;

		// Token: 0x0401A19F RID: 106911
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardScroll;
	}
}
