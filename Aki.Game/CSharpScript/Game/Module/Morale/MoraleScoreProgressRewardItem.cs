using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200439C RID: 17308
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleScoreProgressRewardItem : GridProxyAbstract<MoraleProgressRewardData>
	{
		// Token: 0x0602BB81 RID: 179073 RVA: 0x00C453D8 File Offset: 0x00C435D8
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleScoreProgressRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleScoreProgressRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB82 RID: 179074 RVA: 0x00C4541B File Offset: 0x00C4361B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602BB83 RID: 179075 RVA: 0x00C45454 File Offset: 0x00C43654
		public override void Refresh(MoraleProgressRewardData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = this.ItemData,
				ItemConfigId = new int?(this.ItemData.ItemId),
				IsRedDotVisible = new bool?(this.ItemData.IsCanReceived),
				IsReceivedVisible = new bool?(this.ItemData.IsReceived),
				IsReceivableVisible = new bool?(this.ItemData.IsCanReceived),
				BottomText = this.GetCountStr()
			};
			this.RewardItem.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x0602BB84 RID: 179076 RVA: 0x00C454EA File Offset: 0x00C436EA
		public string GetCountStr()
		{
			if (this.ItemData.ItemNum > 0)
			{
				return this.ItemData.ItemNum.ToString();
			}
			return "";
		}

		// Token: 0x0602BB85 RID: 179077 RVA: 0x00C45510 File Offset: 0x00C43710
		private void OnClickReward(MediumItemGridExtendCallback _)
		{
			Action<MoraleProgressRewardData> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this.ItemData);
		}

		// Token: 0x0401790F RID: 96527
		public MoraleProgressRewardData ItemData;

		// Token: 0x04017910 RID: 96528
		public SmallItemGrid RewardItem;

		// Token: 0x04017911 RID: 96529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleProgressRewardData> ClickCallBack;

		// Token: 0x0200A091 RID: 41105
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031E38 RID: 204344
			public const int ItemSelf = 0;

			// Token: 0x04031E39 RID: 204345
			public const int ItemReward = 1;
		}
	}
}
