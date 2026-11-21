using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DC9 RID: 19913
	[NullableContext(1)]
	[Nullable(0)]
	internal class SpecialEnergyBarKaTiXiYaSlot : SpecialEnergyBarBase
	{
		// Token: 0x0603211C RID: 205084 RVA: 0x00E05AB4 File Offset: 0x00E03CB4
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

		// Token: 0x0603211D RID: 205085 RVA: 0x00E05E28 File Offset: 0x00E04028
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKaTiXiYaSlot.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKaTiXiYaSlot.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603211E RID: 205086 RVA: 0x00E05E6C File Offset: 0x00E0406C
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

		// Token: 0x0603211F RID: 205087 RVA: 0x00E06104 File Offset: 0x00E04304
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

		// Token: 0x06032120 RID: 205088 RVA: 0x00E06168 File Offset: 0x00E04368
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

		// Token: 0x06032121 RID: 205089 RVA: 0x00E061CC File Offset: 0x00E043CC
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

		// Token: 0x06032122 RID: 205090 RVA: 0x00E0621C File Offset: 0x00E0441C
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

		// Token: 0x06032123 RID: 205091 RVA: 0x00E06374 File Offset: 0x00E04574
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

		// Token: 0x06032124 RID: 205092 RVA: 0x00E063B8 File Offset: 0x00E045B8
		protected override void RefreshVisible()
		{
		}

		// Token: 0x06032125 RID: 205093 RVA: 0x00E063BC File Offset: 0x00E045BC
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

		// Token: 0x06032126 RID: 205094 RVA: 0x00E0644C File Offset: 0x00E0464C
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

		// Token: 0x0401A83E RID: 108606
		[StaticVariableRuleIgnore]
		private static readonly int[] NormalTagIds = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.幻影剑_水驻场"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.幻影剑_风驻场"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.幻影剑_重力驻场"]
		};

		// Token: 0x0401A83F RID: 108607
		[StaticVariableRuleIgnore]
		private static readonly int[] CollectTagIds = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.拥有幻影剑_水"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.拥有幻影剑_风"],
			GameplayTagDefine.EGameplayTagId["角色.Katixiya.状态.拥有幻影剑_重力"]
		};

		// Token: 0x0401A840 RID: 108608
		private const int SLOT_NUM = 3;

		// Token: 0x0401A841 RID: 108609
		private const int COLLECT_EFFECT_DURATION = 800;

		// Token: 0x0401A842 RID: 108610
		private const int COLLECT_IN_EFFECT_DURATION = 1000;

		// Token: 0x0401A843 RID: 108611
		private const int COLLECT_OUT_EFFECT_DURATION = 500;

		// Token: 0x0401A844 RID: 108612
		private readonly List<bool> NormalTagStateList = new List<bool>();

		// Token: 0x0401A845 RID: 108613
		private readonly List<bool> CollectTagStateList = new List<bool>();

		// Token: 0x0401A846 RID: 108614
		private readonly List<List<UUIItem>> EnergyItemList = new List<List<UUIItem>>();

		// Token: 0x0401A847 RID: 108615
		private readonly List<List<UUIItem>> SwordItemList = new List<List<UUIItem>>();

		// Token: 0x0401A848 RID: 108616
		private readonly List<UUIItem> CollectEffectList = new List<UUIItem>();

		// Token: 0x0401A849 RID: 108617
		private readonly List<double> CollectEffectEndTime;

		// Token: 0x0401A84A RID: 108618
		private bool IsAnyEffectPlaying;

		// Token: 0x0401A84B RID: 108619
		[Nullable(2)]
		public UUIItem UiKeyItem;

		// Token: 0x0200AB18 RID: 43800
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034E64 RID: 216676
			EmptyItem11,
			// Token: 0x04034E65 RID: 216677
			EmptyItem12,
			// Token: 0x04034E66 RID: 216678
			EmptyItem13,
			// Token: 0x04034E67 RID: 216679
			FullEffect21,
			// Token: 0x04034E68 RID: 216680
			FullEffect22,
			// Token: 0x04034E69 RID: 216681
			FullEffect23,
			// Token: 0x04034E6A RID: 216682
			SwordIcon11,
			// Token: 0x04034E6B RID: 216683
			SwordIcon12,
			// Token: 0x04034E6C RID: 216684
			SwordIcon13,
			// Token: 0x04034E6D RID: 216685
			SwordIcon21,
			// Token: 0x04034E6E RID: 216686
			SwordIcon22,
			// Token: 0x04034E6F RID: 216687
			SwordIcon23,
			// Token: 0x04034E70 RID: 216688
			FullEffect31,
			// Token: 0x04034E71 RID: 216689
			FullEffect32,
			// Token: 0x04034E72 RID: 216690
			FullEffect33,
			// Token: 0x04034E73 RID: 216691
			CollectEffect1,
			// Token: 0x04034E74 RID: 216692
			CollectEffect2,
			// Token: 0x04034E75 RID: 216693
			CollectEffect3,
			// Token: 0x04034E76 RID: 216694
			CollectInEffect1,
			// Token: 0x04034E77 RID: 216695
			CollectOutEffect1,
			// Token: 0x04034E78 RID: 216696
			CollectInEffect2,
			// Token: 0x04034E79 RID: 216697
			CollectOutEffect2,
			// Token: 0x04034E7A RID: 216698
			CollectInEffect3,
			// Token: 0x04034E7B RID: 216699
			CollectOutEffect3,
			// Token: 0x04034E7C RID: 216700
			CollectAllItem
		}
	}
}
