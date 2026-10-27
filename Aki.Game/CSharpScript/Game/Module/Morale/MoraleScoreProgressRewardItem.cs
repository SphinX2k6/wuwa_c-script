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
	// Token: 0x020053B9 RID: 21433
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleScoreProgressRewardItem : GridProxyAbstract<MoraleProgressRewardData>
	{
		// Token: 0x06036C3B RID: 224315 RVA: 0x00CF6330 File Offset: 0x00CF4530
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleScoreProgressRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleScoreProgressRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C3C RID: 224316 RVA: 0x00CF6373 File Offset: 0x00CF4573
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06036C3D RID: 224317 RVA: 0x00CF63AC File Offset: 0x00CF45AC
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

		// Token: 0x06036C3E RID: 224318 RVA: 0x00CF6442 File Offset: 0x00CF4642
		public string GetCountStr()
		{
			if (this.ItemData.ItemNum > 0)
			{
				return this.ItemData.ItemNum.ToString();
			}
			return "";
		}

		// Token: 0x06036C3F RID: 224319 RVA: 0x00CF6468 File Offset: 0x00CF4668
		private void OnClickReward(MediumItemGridExtendCallback _)
		{
			Action<MoraleProgressRewardData> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this.ItemData);
		}

		// Token: 0x0401CE77 RID: 118391
		public MoraleProgressRewardData ItemData;

		// Token: 0x0401CE78 RID: 118392
		public SmallItemGrid RewardItem;

		// Token: 0x0401CE79 RID: 118393
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MoraleProgressRewardData> ClickCallBack;

		// Token: 0x0200B659 RID: 46681
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040373E3 RID: 226275
			public const int ItemSelf = 0;

			// Token: 0x040373E4 RID: 226276
			public const int ItemReward = 1;
		}
	}
}
