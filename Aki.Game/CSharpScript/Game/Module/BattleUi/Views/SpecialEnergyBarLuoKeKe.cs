using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DED RID: 24045
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarLuoKeKe : SpecialEnergyBarBase
	{
		// Token: 0x0603D208 RID: 250376 RVA: 0x00EB7918 File Offset: 0x00EB5B18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D209 RID: 250377 RVA: 0x00EB7A6C File Offset: 0x00EB5C6C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuoKeKe.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuoKeKe.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D20A RID: 250378 RVA: 0x00EB7AB0 File Offset: 0x00EB5CB0
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuoKeKe.<InitBarItem>d__14 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuoKeKe.<InitBarItem>d__14>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D20B RID: 250379 RVA: 0x00EB7AF4 File Offset: 0x00EB5CF4
		private void UpdateIsGhost()
		{
			this.IsInGhost = false;
			foreach (int tagId in SpecialEnergyBarLuoKeKe.GhostTags)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null && tagComponent.HasTag(tagId))
				{
					this.IsInGhost = true;
					return;
				}
			}
		}

		// Token: 0x0603D20C RID: 250380 RVA: 0x00EB7B40 File Offset: 0x00EB5D40
		protected override void AddEvents()
		{
			base.AddEvents();
			foreach (int tagId in SpecialEnergyBarLuoKeKe.GhostTags)
			{
				base.ListenForTagAddOrRemoveChanged(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnGhostTagChange));
			}
		}

		// Token: 0x0603D20D RID: 250381 RVA: 0x00EB7B7E File Offset: 0x00EB5D7E
		private void OnGhostTagChange(int tagId, bool bTagExists)
		{
			if (bTagExists)
			{
				this.IsInGhost = true;
			}
			else
			{
				this.UpdateIsGhost();
			}
			this.RefreshGhostEffectItem(false);
		}

		// Token: 0x0603D20E RID: 250382 RVA: 0x00EB7B9C File Offset: 0x00EB5D9C
		protected override void OnStart()
		{
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			this.UpdateIsGhost();
			for (int i = 0; i < 3; i++)
			{
				this.GhostItemList.Add(base.GetItem(1 + i));
				this.GhostEffectItemList.Add(base.GetItem(4 + i));
				this.GhostEffectItemList[i].SetUIActive(false);
			}
			this.RefreshGhostEffectItem(true);
		}

		// Token: 0x0603D20F RID: 250383 RVA: 0x00EB7C0A File Offset: 0x00EB5E0A
		protected override void OnBarPercentChanged()
		{
			this.RefreshGhostEffectItem(false);
		}

		// Token: 0x0603D210 RID: 250384 RVA: 0x00EB7C14 File Offset: 0x00EB5E14
		private void RefreshGhostEffectItem(bool isStart = false)
		{
			int num = (int)Math.Floor((double)(this.PercentMachine.GetCurPercent() * 3f));
			int num2 = this.IsInGhost ? num : 0;
			if (this.LastVisibleGhostCount != num2)
			{
				if (num2 > this.LastVisibleGhostCount)
				{
					for (int i = 0; i < 3; i++)
					{
						bool flag = i < num2;
						this.GhostItemList[i].SetUIActive(flag);
						if (isStart && flag)
						{
							this.GhostItemList[i].SetAlpha(1f);
						}
					}
					if (!isStart)
					{
						base.StopTweenAnim(8);
						base.PlayTweenAnim(7);
					}
				}
				else if (!isStart)
				{
					base.StopTweenAnim(7);
					base.PlayTweenAnim(8);
				}
				if (this.IsInGhost)
				{
					for (int j = 0; j < 3; j++)
					{
						this.BarItem.SetFullEffectVisible(j, false);
					}
				}
				else
				{
					for (int k = 0; k < 3; k++)
					{
						bool visible = k < num;
						this.BarItem.SetFullEffectVisible(k, visible);
					}
				}
				this.LastVisibleGhostCount = num2;
			}
			if (this.LastGhostCount != num)
			{
				if (num < this.LastGhostCount)
				{
					for (int l = num; l < this.LastGhostCount; l++)
					{
						this.GhostEffectItemList[l].SetUIActive(true);
						this.EffectFinishTime = Time.Instance.Now + 1000.0;
						this.IsAnyEffectPlaying = true;
					}
				}
				this.LastGhostCount = num;
			}
		}

		// Token: 0x0603D211 RID: 250385 RVA: 0x00EB7D78 File Offset: 0x00EB5F78
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			if (!this.IsAnyEffectPlaying)
			{
				return;
			}
			if (this.EffectFinishTime <= Time.Instance.Now)
			{
				foreach (UUIItem uuiitem in this.GhostEffectItemList)
				{
					uuiitem.SetUIActive(false);
				}
				this.IsAnyEffectPlaying = false;
			}
		}

		// Token: 0x0401FDCF RID: 130511
		private const int NUM = 3;

		// Token: 0x0401FDD0 RID: 130512
		private const double EFFECT_TIME = 1000.0;

		// Token: 0x0401FDD1 RID: 130513
		[StaticVariableRuleIgnore]
		private static readonly int[] GhostTags = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1LuokekeMd10011.状态标识.灵感1层"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1LuokekeMd10011.状态标识.灵感2层"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1LuokekeMd10011.状态标识.灵感3层"]
		};

		// Token: 0x0401FDD2 RID: 130514
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401FDD3 RID: 130515
		private readonly List<UUIItem> GhostItemList = new List<UUIItem>();

		// Token: 0x0401FDD4 RID: 130516
		private readonly List<UUIItem> GhostEffectItemList = new List<UUIItem>();

		// Token: 0x0401FDD5 RID: 130517
		private bool IsAnyEffectPlaying;

		// Token: 0x0401FDD6 RID: 130518
		private double EffectFinishTime;

		// Token: 0x0401FDD7 RID: 130519
		private bool IsInGhost;

		// Token: 0x0401FDD8 RID: 130520
		private int LastGhostCount;

		// Token: 0x0401FDD9 RID: 130521
		private int LastVisibleGhostCount;

		// Token: 0x0200C123 RID: 49443
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A536 RID: 238902
			SlotBarItem,
			// Token: 0x0403A537 RID: 238903
			GhostItem1,
			// Token: 0x0403A538 RID: 238904
			GhostItem2,
			// Token: 0x0403A539 RID: 238905
			GhostItem3,
			// Token: 0x0403A53A RID: 238906
			GhostEffectItem1,
			// Token: 0x0403A53B RID: 238907
			GhostEffectItem2,
			// Token: 0x0403A53C RID: 238908
			GhostEffectItem3,
			// Token: 0x0403A53D RID: 238909
			AniGhostIn,
			// Token: 0x0403A53E RID: 238910
			AniGhostOut
		}
	}
}
