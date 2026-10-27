using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E02 RID: 19970
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchievementItem : GridProxyAbstract<AchievementData>
	{
		// Token: 0x0603386C RID: 211052 RVA: 0x00C0A600 File Offset: 0x00C08800
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

		// Token: 0x0603386D RID: 211053 RVA: 0x00C0A74B File Offset: 0x00C0894B
		protected void OnBtnRewardClickInternal()
		{
			Action onBtnRewardClick = this.OnBtnRewardClick;
			if (onBtnRewardClick == null)
			{
				return;
			}
			onBtnRewardClick();
		}

		// Token: 0x0603386E RID: 211054 RVA: 0x00C0A75D File Offset: 0x00C0895D
		protected override void OnStart()
		{
			if (this.CommonGridItem == null)
			{
				this.CommonGridItem = new CommonItemSmallItemGrid();
				this.CommonGridItem.Initialize(base.GetItem(3).GetOwner());
			}
			this.CommonGridItem.SetActive(false);
		}

		// Token: 0x0603386F RID: 211055 RVA: 0x00C0A795 File Offset: 0x00C08995
		[NullableContext(1)]
		public override object GetKey(AchievementData data, int displayIndex)
		{
			return data.GetId();
		}

		// Token: 0x06033870 RID: 211056 RVA: 0x00C0A7A2 File Offset: 0x00C089A2
		[NullableContext(1)]
		public override void Refresh(AchievementData data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x06033871 RID: 211057 RVA: 0x00C0A7AC File Offset: 0x00C089AC
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

		// Token: 0x0401B561 RID: 111969
		public CommonItemSmallItemGrid CommonGridItem;

		// Token: 0x0401B562 RID: 111970
		public AchievementData Data;

		// Token: 0x0401B563 RID: 111971
		public Action OnBtnRewardClick;

		// Token: 0x0200AF90 RID: 44944
		[NullableContext(0)]
		private class ERoguelikeAchievementItemDefine
		{
			// Token: 0x040354D7 RID: 218327
			public const int TxtTitle = 0;

			// Token: 0x040354D8 RID: 218328
			public const int TxtProgress = 1;

			// Token: 0x040354D9 RID: 218329
			public const int RewardedItem = 2;

			// Token: 0x040354DA RID: 218330
			public const int CommonGridItem = 3;

			// Token: 0x040354DB RID: 218331
			public const int BtnReward = 4;

			// Token: 0x040354DC RID: 218332
			public const int TxtConfirm = 5;

			// Token: 0x040354DD RID: 218333
			public const int DoingItem = 6;
		}
	}
}
