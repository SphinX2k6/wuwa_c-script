using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DE5 RID: 24037
	[NullableContext(1)]
	[Nullable(0)]
	internal class SpecialEnergyBarKaTiXiYaSlot : SpecialEnergyBarBase
	{
		// Token: 0x0603D1A5 RID: 250277 RVA: 0x00EB4BB4 File Offset: 0x00EB2DB4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D1A6 RID: 250278 RVA: 0x00EB4F28 File Offset: 0x00EB3128
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKaTiXiYaSlot.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKaTiXiYaSlot.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1A7 RID: 250279 RVA: 0x00EB4F6C File Offset: 0x00EB316C
		protected unsafe override void OnStart()
		{
			base.OnStart();
			List<List<UUIItem>> energyItemList = this.EnergyItemList;
			int num = 3;
			List<UUIItem> list = new List<UUIItem>(num);
			CollectionsMarshal.SetCount<UUIItem>(list, num);
			Span<UUIItem> span = CollectionsMarshal.AsSpan<UUIItem>(list);
			int num2 = 0;
			*span[num2] = base.GetItem(0);
			num2++;
			*span[num2] = base.GetItem(1);
			num2++;
			*span[num2] = base.GetItem(2);
			energyItemList.Add(list);
			List<List<UUIItem>> energyItemList2 = this.EnergyItemList;
			num2 = 3;
			List<UUIItem> list2 = new List<UUIItem>(num2);
			CollectionsMarshal.SetCount<UUIItem>(list2, num2);
			span = CollectionsMarshal.AsSpan<UUIItem>(list2);
			num = 0;
			*span[num] = base.GetUiNiagara(3);
			num++;
			*span[num] = base.GetUiNiagara(4);
			num++;
			*span[num] = base.GetUiNiagara(5);
			energyItemList2.Add(list2);
			List<List<UUIItem>> energyItemList3 = this.EnergyItemList;
			num = 3;
			List<UUIItem> list3 = new List<UUIItem>(num);
			CollectionsMarshal.SetCount<UUIItem>(list3, num);
			span = CollectionsMarshal.AsSpan<UUIItem>(list3);
			num2 = 0;
			*span[num2] = base.GetItem(12);
			num2++;
			*span[num2] = base.GetItem(13);
			num2++;
			*span[num2] = base.GetItem(14);
			energyItemList3.Add(list3);
			List<List<UUIItem>> swordItemList = this.SwordItemList;
			num2 = 3;
			List<UUIItem> list4 = new List<UUIItem>(num2);
			CollectionsMarshal.SetCount<UUIItem>(list4, num2);
			span = CollectionsMarshal.AsSpan<UUIItem>(list4);
			num = 0;
			*span[num] = base.GetItem(6);
			num++;
			*span[num] = base.GetItem(7);
			num++;
			*span[num] = base.GetItem(8);
			swordItemList.Add(list4);
			List<List<UUIItem>> swordItemList2 = this.SwordItemList;
			num = 3;
			List<UUIItem> list5 = new List<UUIItem>(num);
			CollectionsMarshal.SetCount<UUIItem>(list5, num);
			span = CollectionsMarshal.AsSpan<UUIItem>(list5);
			num2 = 0;
			*span[num2] = base.GetItem(9);
			num2++;
			*span[num2] = base.GetItem(10);
			num2++;
			*span[num2] = base.GetItem(11);
			swordItemList2.Add(list5);
			this.CollectEffectList.Add(base.GetUiNiagara(15));
			this.CollectEffectList.Add(base.GetUiNiagara(16));
			this.CollectEffectList.Add(base.GetUiNiagara(17));
			this.CollectEffectList.Add(base.GetUiNiagara(18));
			this.CollectEffectList.Add(base.GetUiNiagara(20));
			this.CollectEffectList.Add(base.GetUiNiagara(22));
			this.CollectEffectList.Add(base.GetUiNiagara(15));
			this.CollectEffectList.Add(base.GetUiNiagara(16));
			this.CollectEffectList.Add(base.GetUiNiagara(17));
			this.RefreshState(true);
			this.ListenTags();
		}

		// Token: 0x0603D1A8 RID: 250280 RVA: 0x00EB5204 File Offset: 0x00EB3404
		private void ListenTags()
		{
			foreach (int tagId in SpecialEnergyBarKaTiXiYaSlot.NormalTagIds)
			{
				base.ListenForTagAddOrRemoveChanged(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnNormalTagChange));
			}
			foreach (int tagId2 in SpecialEnergyBarKaTiXiYaSlot.CollectTagIds)
			{
				base.ListenForTagAddOrRemoveChanged(tagId2, new BaseTagComponent.TTagSwitchedCallback(this.OnCollectTagChange));
			}
		}

		// Token: 0x0603D1A9 RID: 250281 RVA: 0x00EB5268 File Offset: 0x00EB3468
		private void OnNormalTagChange(int tagId, bool tagExist)
		{
			int num = Array.IndexOf<int>(SpecialEnergyBarKaTiXiYaSlot.NormalTagIds, tagId);
			if (num < 0 || this.NormalTagStateList[num] == tagExist)
			{
				return;
			}
			this.NormalTagStateList[num] = tagExist;
			this.RefreshState(false);
			if (tagExist)
			{
				this.PlayCollectEffect(3 + num, 1000);
				return;
			}
			this.PlayCollectEffect(6 + num, 500);
		}

		// Token: 0x0603D1AA RID: 250282 RVA: 0x00EB52CC File Offset: 0x00EB34CC
		private void OnCollectTagChange(int tagId, bool tagExist)
		{
			int num = Array.IndexOf<int>(SpecialEnergyBarKaTiXiYaSlot.CollectTagIds, tagId);
			if (num < 0 || this.CollectTagStateList[num] == tagExist)
			{
				return;
			}
			this.CollectTagStateList[num] = tagExist;
			this.RefreshState(false);
			if (tagExist)
			{
				this.PlayCollectEffect(num, 800);
			}
		}

		// Token: 0x0603D1AB RID: 250283 RVA: 0x00EB531C File Offset: 0x00EB351C
		private void RefreshState(bool isStart = false)
		{
			if (this.TagComponent == null)
			{
				return;
			}
			if (isStart)
			{
				foreach (int tagId in SpecialEnergyBarKaTiXiYaSlot.NormalTagIds)
				{
					this.NormalTagStateList.Add(this.TagComponent.HasTag(tagId));
				}
				foreach (int tagId2 in SpecialEnergyBarKaTiXiYaSlot.CollectTagIds)
				{
					this.CollectTagStateList.Add(this.TagComponent.HasTag(tagId2));
				}
			}
			bool enable = false;
			bool uiactive = true;
			for (int j = 0; j < 3; j++)
			{
				bool flag = this.NormalTagStateList[j];
				bool flag2 = this.CollectTagStateList[j];
				int num = 0;
				if (flag2)
				{
					num = 2;
				}
				else if (flag)
				{
					num = 1;
					enable = true;
				}
				else
				{
					uiactive = false;
				}
				for (int k = 0; k < 3; k++)
				{
					this.EnergyItemList[k][j].SetUIActive(k == num);
				}
				this.SwordItemList[0][j].SetUIActive(num == 0);
				this.SwordItemList[1][j].SetUIActive(num != 0);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(enable, isStart);
			}
			UUIItem item = base.GetItem(24);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0603D1AC RID: 250284 RVA: 0x00EB5474 File Offset: 0x00EB3674
		private void PlayCollectEffect(int index, int duration)
		{
			UUIItem uuiitem = this.CollectEffectList[index];
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
				this.CollectEffectEndTime[index] = Time.Instance.Now + (double)duration;
				this.IsAnyEffectPlaying = true;
			}
		}

		// Token: 0x0603D1AD RID: 250285 RVA: 0x00EB54B8 File Offset: 0x00EB36B8
		protected override void RefreshVisible()
		{
		}

		// Token: 0x0603D1AE RID: 250286 RVA: 0x00EB54BC File Offset: 0x00EB36BC
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.IsAnyEffectPlaying)
			{
				this.IsAnyEffectPlaying = false;
				for (int i = 0; i < this.CollectEffectEndTime.Count; i++)
				{
					double num = this.CollectEffectEndTime[i];
					if (num > 0.0 && num < Time.Instance.Now)
					{
						this.CollectEffectList[i].SetUIActive(false);
						this.CollectEffectEndTime[i] = 0.0;
					}
					else
					{
						this.IsAnyEffectPlaying = true;
					}
				}
			}
		}

		// Token: 0x0603D1AF RID: 250287 RVA: 0x00EB554C File Offset: 0x00EB374C
		public unsafe SpecialEnergyBarKaTiXiYaSlot()
		{
			int num = 9;
			List<double> list = new List<double>(num);
			CollectionsMarshal.SetCount<double>(list, num);
			Span<double> span = CollectionsMarshal.AsSpan<double>(list);
			int num2 = 0;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			num2++;
			*span[num2] = 0.0;
			this.CollectEffectEndTime = list;
			base..ctor();
		}

		// Token: 0x0401FD81 RID: 130433
		[StaticVariableRuleIgnore]
		private static readonly int[] NormalTagIds = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.幻影剑_水驻场"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.幻影剑_风驻场"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.幻影剑_重力驻场"]
		};

		// Token: 0x0401FD82 RID: 130434
		[StaticVariableRuleIgnore]
		private static readonly int[] CollectTagIds = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.拥有幻影剑_水"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.拥有幻影剑_风"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.拥有幻影剑_重力"]
		};

		// Token: 0x0401FD83 RID: 130435
		private const int SLOT_NUM = 3;

		// Token: 0x0401FD84 RID: 130436
		private const int COLLECT_EFFECT_DURATION = 800;

		// Token: 0x0401FD85 RID: 130437
		private const int COLLECT_IN_EFFECT_DURATION = 1000;

		// Token: 0x0401FD86 RID: 130438
		private const int COLLECT_OUT_EFFECT_DURATION = 500;

		// Token: 0x0401FD87 RID: 130439
		private readonly List<bool> NormalTagStateList = new List<bool>();

		// Token: 0x0401FD88 RID: 130440
		private readonly List<bool> CollectTagStateList = new List<bool>();

		// Token: 0x0401FD89 RID: 130441
		private readonly List<List<UUIItem>> EnergyItemList = new List<List<UUIItem>>();

		// Token: 0x0401FD8A RID: 130442
		private readonly List<List<UUIItem>> SwordItemList = new List<List<UUIItem>>();

		// Token: 0x0401FD8B RID: 130443
		private readonly List<UUIItem> CollectEffectList = new List<UUIItem>();

		// Token: 0x0401FD8C RID: 130444
		private readonly List<double> CollectEffectEndTime;

		// Token: 0x0401FD8D RID: 130445
		private bool IsAnyEffectPlaying;

		// Token: 0x0401FD8E RID: 130446
		[Nullable(2)]
		public UUIItem UiKeyItem;

		// Token: 0x0200C10F RID: 49423
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A492 RID: 238738
			EmptyItem11,
			// Token: 0x0403A493 RID: 238739
			EmptyItem12,
			// Token: 0x0403A494 RID: 238740
			EmptyItem13,
			// Token: 0x0403A495 RID: 238741
			FullEffect21,
			// Token: 0x0403A496 RID: 238742
			FullEffect22,
			// Token: 0x0403A497 RID: 238743
			FullEffect23,
			// Token: 0x0403A498 RID: 238744
			SwordIcon11,
			// Token: 0x0403A499 RID: 238745
			SwordIcon12,
			// Token: 0x0403A49A RID: 238746
			SwordIcon13,
			// Token: 0x0403A49B RID: 238747
			SwordIcon21,
			// Token: 0x0403A49C RID: 238748
			SwordIcon22,
			// Token: 0x0403A49D RID: 238749
			SwordIcon23,
			// Token: 0x0403A49E RID: 238750
			FullEffect31,
			// Token: 0x0403A49F RID: 238751
			FullEffect32,
			// Token: 0x0403A4A0 RID: 238752
			FullEffect33,
			// Token: 0x0403A4A1 RID: 238753
			CollectEffect1,
			// Token: 0x0403A4A2 RID: 238754
			CollectEffect2,
			// Token: 0x0403A4A3 RID: 238755
			CollectEffect3,
			// Token: 0x0403A4A4 RID: 238756
			CollectInEffect1,
			// Token: 0x0403A4A5 RID: 238757
			CollectOutEffect1,
			// Token: 0x0403A4A6 RID: 238758
			CollectInEffect2,
			// Token: 0x0403A4A7 RID: 238759
			CollectOutEffect2,
			// Token: 0x0403A4A8 RID: 238760
			CollectInEffect3,
			// Token: 0x0403A4A9 RID: 238761
			CollectOutEffect3,
			// Token: 0x0403A4AA RID: 238762
			CollectAllItem
		}
	}
}
