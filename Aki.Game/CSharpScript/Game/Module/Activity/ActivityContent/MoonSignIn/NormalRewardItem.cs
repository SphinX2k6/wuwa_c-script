using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x0200646A RID: 25706
	internal class NormalRewardItem : GridProxyAbstract<int>
	{
		// Token: 0x0604099D RID: 264605 RVA: 0x00FA3528 File Offset: 0x00FA1728
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604099E RID: 264606 RVA: 0x00FA3638 File Offset: 0x00FA1838
		protected override UniTask OnBeforeStartAsync()
		{
			NormalRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NormalRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604099F RID: 264607 RVA: 0x00FA367C File Offset: 0x00FA187C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			PhaseOfMoon? phaseOfMoonById = MoonSignInConfig.Instance.GetPhaseOfMoonById(data);
			if (phaseOfMoonById == null)
			{
				return;
			}
			base.GetItem(5).SetUIActive(gridIndex % 2 == 1);
			base.SetTextureByPath(phaseOfMoonById.Value.Texture, base.GetTexture(0), null, null);
			base.SetTextureByPath(phaseOfMoonById.Value.RewardTexture, base.GetTexture(1), null, null);
			base.SetTextureByPath(phaseOfMoonById.Value.Texture, base.GetTexture(6), null, null);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(phaseOfMoonById.Value.Reward);
			MoonSignInData data2 = MoonSignInController.Instance.GetData();
			if (data2 == null)
			{
				return;
			}
			bool flag = !data2.CheckPhaseLock(data);
			UUITexture texture = base.GetTexture(6);
			if (texture != null)
			{
				texture.SetUIActive(!flag);
			}
			List<IRewardItemData> list = new List<IRewardItemData>();
			foreach (TItem itemData in dropPackagePreviewItemList)
			{
				RewardItemDataImpl item = new RewardItemDataImpl
				{
					ItemData = itemData,
					HaveFinish = flag
				};
				list.Add(item);
			}
			for (int i = 0; i < this.RewardItemList.Count; i++)
			{
				RewardItem rewardItem = this.RewardItemList[i];
				if (i < list.Count)
				{
					IRewardItemData data3 = list[i];
					rewardItem.Refresh(data3, false, 0);
				}
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0402195B RID: 137563
		[Nullable(1)]
		private readonly List<RewardItem> RewardItemList = new List<RewardItem>();

		// Token: 0x0402195C RID: 137564
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C697 RID: 50839
		private class EMoonSignInNormalRewardItemDefine
		{
			// Token: 0x0403BF4D RID: 245581
			public const int MoonTexture = 0;

			// Token: 0x0403BF4E RID: 245582
			public const int SimpleTexture = 1;

			// Token: 0x0403BF4F RID: 245583
			public const int RewardItem1 = 2;

			// Token: 0x0403BF50 RID: 245584
			public const int RewardItem2 = 3;

			// Token: 0x0403BF51 RID: 245585
			public const int RewardItem3 = 4;

			// Token: 0x0403BF52 RID: 245586
			public const int MaskItem = 5;

			// Token: 0x0403BF53 RID: 245587
			public const int DisableTexture = 6;
		}
	}
}
