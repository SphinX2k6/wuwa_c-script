using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF2 RID: 24050
	public class SpecialEnergyBarLuPa : SpecialEnergyBarBase
	{
		// Token: 0x0603D22F RID: 250415 RVA: 0x00EB8640 File Offset: 0x00EB6840
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
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D230 RID: 250416 RVA: 0x00EB8791 File Offset: 0x00EB6991
		protected override void OnInitData()
		{
			base.OnInitData();
			base.ListenForTagCountChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LupaMd10011.状态标识.能量转换层数"], new BaseTagComponent.TTagChangedCallback(this.OnTagCountChanged));
		}

		// Token: 0x0603D231 RID: 250417 RVA: 0x00EB87BC File Offset: 0x00EB69BC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuPa.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuPa.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D232 RID: 250418 RVA: 0x00EB8800 File Offset: 0x00EB6A00
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuPa.<InitBarItem>d__6 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuPa.<InitBarItem>d__6>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D233 RID: 250419 RVA: 0x00EB8843 File Offset: 0x00EB6A43
		private void OnTagCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshTagCount(count, false);
		}

		// Token: 0x0603D234 RID: 250420 RVA: 0x00EB8850 File Offset: 0x00EB6A50
		protected override void OnStart()
		{
			base.InitTweenAnim(3);
			base.InitTweenAnim(4);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			BaseTagComponent tagComponent = this.TagComponent;
			int tagCount = (tagComponent != null) ? tagComponent.GetTagCount(GameplayTagDefine.EGameplayTagId["角色.R2T1LupaMd10011.状态标识.能量转换层数"]) : 0;
			this.RefreshTagCount(tagCount, true);
		}

		// Token: 0x0603D235 RID: 250421 RVA: 0x00EB88A4 File Offset: 0x00EB6AA4
		private void RefreshTagCount(int tagCount, bool isStart = false)
		{
			if (tagCount == this.TagCount && !isStart)
			{
				return;
			}
			int tagCount2 = this.TagCount;
			this.TagCount = tagCount;
			this.BarItem.SetTagCount(this.TagCount);
			this.SetBottomLineState(this.TagCount >= 2);
			if (isStart)
			{
				if (this.TagCount >= 2)
				{
					base.PlayTweenAnim(3);
					base.PlayTweenAnim(7);
					return;
				}
				if (this.TagCount == 1)
				{
					base.PlayTweenAnim(3);
				}
				return;
			}
			else
			{
				if (tagCount2 > this.TagCount)
				{
					for (int i = this.TagCount; i < tagCount2; i++)
					{
						if (i == 0)
						{
							base.StopTweenAnim(3);
							base.PlayTweenAnim(4);
						}
						else if (i == 1)
						{
							base.StopTweenAnim(7);
							base.PlayTweenAnim(8);
						}
					}
					return;
				}
				for (int j = tagCount2; j < this.TagCount; j++)
				{
					if (j == 0)
					{
						base.StopTweenAnim(4);
						base.PlayTweenAnim(3);
					}
					else if (j == 1)
					{
						base.StopTweenAnim(8);
						base.PlayTweenAnim(7);
					}
				}
				return;
			}
		}

		// Token: 0x0603D236 RID: 250422 RVA: 0x00EB8991 File Offset: 0x00EB6B91
		private void SetBottomLineState(bool isLight)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!isLight);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(isLight);
		}

		// Token: 0x0603D237 RID: 250423 RVA: 0x00EB89BB File Offset: 0x00EB6BBB
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarLuPaSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.Tick(delta);
		}

		// Token: 0x0401FDE7 RID: 130535
		private int TagCount;

		// Token: 0x0401FDE8 RID: 130536
		[Nullable(2)]
		private SpecialEnergyBarLuPaSlot BarItem;

		// Token: 0x0200C12E RID: 49454
		private enum EChildType
		{
			// Token: 0x0403A56C RID: 238956
			SlotItem,
			// Token: 0x0403A56D RID: 238957
			StateItemA,
			// Token: 0x0403A56E RID: 238958
			StateItemB,
			// Token: 0x0403A56F RID: 238959
			AniLeftIn,
			// Token: 0x0403A570 RID: 238960
			AniLeftOut,
			// Token: 0x0403A571 RID: 238961
			EffectRight,
			// Token: 0x0403A572 RID: 238962
			EffectLeft,
			// Token: 0x0403A573 RID: 238963
			AniRightIn,
			// Token: 0x0403A574 RID: 238964
			AniRightOut
		}
	}
}
