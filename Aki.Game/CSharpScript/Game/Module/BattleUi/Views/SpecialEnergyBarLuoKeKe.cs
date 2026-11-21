using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD2 RID: 19922
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarLuoKeKe : SpecialEnergyBarBase
	{
		// Token: 0x06032197 RID: 205207 RVA: 0x00E08E58 File Offset: 0x00E07058
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

		// Token: 0x06032198 RID: 205208 RVA: 0x00E08FAC File Offset: 0x00E071AC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuoKeKe.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuoKeKe.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032199 RID: 205209 RVA: 0x00E08FF0 File Offset: 0x00E071F0
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuoKeKe.<InitBarItem>d__14 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuoKeKe.<InitBarItem>d__14>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603219A RID: 205210 RVA: 0x00E09034 File Offset: 0x00E07234
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

		// Token: 0x0603219B RID: 205211 RVA: 0x00E09080 File Offset: 0x00E07280
		protected override void AddEvents()
		{
			base.AddEvents();
			foreach (int tagId in SpecialEnergyBarLuoKeKe.GhostTags)
			{
				base.ListenForTagAddOrRemoveChanged(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnGhostTagChange));
			}
		}

		// Token: 0x0603219C RID: 205212 RVA: 0x00E090BE File Offset: 0x00E072BE
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

		// Token: 0x0603219D RID: 205213 RVA: 0x00E090DC File Offset: 0x00E072DC
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

		// Token: 0x0603219E RID: 205214 RVA: 0x00E0914A File Offset: 0x00E0734A
		protected override void OnBarPercentChanged()
		{
			this.RefreshGhostEffectItem(false);
		}

		// Token: 0x0603219F RID: 205215 RVA: 0x00E09154 File Offset: 0x00E07354
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

		// Token: 0x060321A0 RID: 205216 RVA: 0x00E092B8 File Offset: 0x00E074B8
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

		// Token: 0x0401A896 RID: 108694
		private const int NUM = 3;

		// Token: 0x0401A897 RID: 108695
		private const double EFFECT_TIME = 1000.0;

		// Token: 0x0401A898 RID: 108696
		[StaticVariableRuleIgnore]
		private static readonly int[] GhostTags = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1LuokekeMd10011.状态标识.灵感1层"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1LuokekeMd10011.状态标识.灵感2层"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1LuokekeMd10011.状态标识.灵感3层"]
		};

		// Token: 0x0401A899 RID: 108697
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401A89A RID: 108698
		private readonly List<UUIItem> GhostItemList = new List<UUIItem>();

		// Token: 0x0401A89B RID: 108699
		private readonly List<UUIItem> GhostEffectItemList = new List<UUIItem>();

		// Token: 0x0401A89C RID: 108700
		private bool IsAnyEffectPlaying;

		// Token: 0x0401A89D RID: 108701
		private double EffectFinishTime;

		// Token: 0x0401A89E RID: 108702
		private bool IsInGhost;

		// Token: 0x0401A89F RID: 108703
		private int LastGhostCount;

		// Token: 0x0401A8A0 RID: 108704
		private int LastVisibleGhostCount;

		// Token: 0x0200AB32 RID: 43826
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034F28 RID: 216872
			SlotBarItem,
			// Token: 0x04034F29 RID: 216873
			GhostItem1,
			// Token: 0x04034F2A RID: 216874
			GhostItem2,
			// Token: 0x04034F2B RID: 216875
			GhostItem3,
			// Token: 0x04034F2C RID: 216876
			GhostEffectItem1,
			// Token: 0x04034F2D RID: 216877
			GhostEffectItem2,
			// Token: 0x04034F2E RID: 216878
			GhostEffectItem3,
			// Token: 0x04034F2F RID: 216879
			AniGhostIn,
			// Token: 0x04034F30 RID: 216880
			AniGhostOut
		}
	}
}
