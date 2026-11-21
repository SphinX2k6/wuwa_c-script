using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DCB RID: 15819
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchievementItem : GridProxyAbstract<AchievementData>
	{
		// Token: 0x060286D7 RID: 165591 RVA: 0x00B53B10 File Offset: 0x00B51D10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnRewardClickInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060286D8 RID: 165592 RVA: 0x00B53C5B File Offset: 0x00B51E5B
		protected void OnBtnRewardClickInternal()
		{
			Action onBtnRewardClick = this.OnBtnRewardClick;
			if (onBtnRewardClick == null)
			{
				return;
			}
			onBtnRewardClick();
		}

		// Token: 0x060286D9 RID: 165593 RVA: 0x00B53C6D File Offset: 0x00B51E6D
		protected override void OnStart()
		{
			if (this.CommonGridItem == null)
			{
				this.CommonGridItem = new CommonItemSmallItemGrid();
				this.CommonGridItem.Initialize(base.GetItem(3).GetOwner());
			}
			this.CommonGridItem.SetActive(false);
		}

		// Token: 0x060286DA RID: 165594 RVA: 0x00B53CA5 File Offset: 0x00B51EA5
		[NullableContext(1)]
		public override object GetKey(AchievementData data, int displayIndex)
		{
			return data.GetId();
		}

		// Token: 0x060286DB RID: 165595 RVA: 0x00B53CB2 File Offset: 0x00B51EB2
		[NullableContext(1)]
		public override void Refresh(AchievementData data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x060286DC RID: 165596 RVA: 0x00B53CBC File Offset: 0x00B51EBC
		public void Update(AchievementData data = null)
		{
			this.Data = ((data != null) ? data : this.Data);
			base.GetText(0).SetText(this.Data.GetDesc(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Rogue_Achievement_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.Data.GetCurrentProgress(),
				this.Data.GetMaxProgress()
			}));
			switch (this.Data.GetFinishState())
			{
			case EAchievementStateEnum.UnFinished:
				base.GetItem(2).SetUIActive(false);
				base.GetButton(4).RootUIComp.Get().SetUIActive(false);
				base.GetItem(6).SetUIActive(true);
				break;
			case EAchievementStateEnum.CanGetReward:
				base.GetItem(2).SetUIActive(false);
				base.GetButton(4).RootUIComp.Get().SetUIActive(true);
				base.GetItem(6).SetUIActive(false);
				break;
			case EAchievementStateEnum.HaveGetReward:
				base.GetItem(2).SetUIActive(true);
				base.GetButton(4).RootUIComp.Get().SetUIActive(false);
				base.GetItem(6).SetUIActive(false);
				break;
			}
			List<TItem> rewards = this.Data.GetRewards();
			if (rewards.Count > 0)
			{
				this.CommonGridItem.SetActive(true);
				this.CommonGridItem.Refresh(rewards[0]);
			}
		}

		// Token: 0x04015F34 RID: 89908
		public CommonItemSmallItemGrid CommonGridItem;

		// Token: 0x04015F35 RID: 89909
		public AchievementData Data;

		// Token: 0x04015F36 RID: 89910
		public Action OnBtnRewardClick;

		// Token: 0x020099C5 RID: 39365
		[NullableContext(0)]
		private class ERoguelikeAchievementItemDefine
		{
			// Token: 0x0402FF0A RID: 196362
			public const int TxtTitle = 0;

			// Token: 0x0402FF0B RID: 196363
			public const int TxtProgress = 1;

			// Token: 0x0402FF0C RID: 196364
			public const int RewardedItem = 2;

			// Token: 0x0402FF0D RID: 196365
			public const int CommonGridItem = 3;

			// Token: 0x0402FF0E RID: 196366
			public const int BtnReward = 4;

			// Token: 0x0402FF0F RID: 196367
			public const int TxtConfirm = 5;

			// Token: 0x0402FF10 RID: 196368
			public const int DoingItem = 6;
		}
	}
}
