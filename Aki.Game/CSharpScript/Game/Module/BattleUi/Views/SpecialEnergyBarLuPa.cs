using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD7 RID: 19927
	public class SpecialEnergyBarLuPa : SpecialEnergyBarBase
	{
		// Token: 0x060321BE RID: 205246 RVA: 0x00E09B88 File Offset: 0x00E07D88
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

		// Token: 0x060321BF RID: 205247 RVA: 0x00E09CD9 File Offset: 0x00E07ED9
		protected override void OnInitData()
		{
			base.OnInitData();
			base.ListenForTagCountChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LupaMd10011.状态标识.能量转换层数"], new BaseTagComponent.TTagChangedCallback(this.OnTagCountChanged));
		}

		// Token: 0x060321C0 RID: 205248 RVA: 0x00E09D04 File Offset: 0x00E07F04
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuPa.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuPa.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060321C1 RID: 205249 RVA: 0x00E09D48 File Offset: 0x00E07F48
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuPa.<InitBarItem>d__6 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuPa.<InitBarItem>d__6>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060321C2 RID: 205250 RVA: 0x00E09D8B File Offset: 0x00E07F8B
		private void OnTagCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshTagCount(count, false);
		}

		// Token: 0x060321C3 RID: 205251 RVA: 0x00E09D98 File Offset: 0x00E07F98
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

		// Token: 0x060321C4 RID: 205252 RVA: 0x00E09DEC File Offset: 0x00E07FEC
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

		// Token: 0x060321C5 RID: 205253 RVA: 0x00E09ED9 File Offset: 0x00E080D9
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

		// Token: 0x060321C6 RID: 205254 RVA: 0x00E09F03 File Offset: 0x00E08103
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

		// Token: 0x0401A8AE RID: 108718
		private int TagCount;

		// Token: 0x0401A8AF RID: 108719
		[Nullable(2)]
		private SpecialEnergyBarLuPaSlot BarItem;

		// Token: 0x0200AB3D RID: 43837
		private enum EChildType
		{
			// Token: 0x04034F5E RID: 216926
			SlotItem,
			// Token: 0x04034F5F RID: 216927
			StateItemA,
			// Token: 0x04034F60 RID: 216928
			StateItemB,
			// Token: 0x04034F61 RID: 216929
			AniLeftIn,
			// Token: 0x04034F62 RID: 216930
			AniLeftOut,
			// Token: 0x04034F63 RID: 216931
			EffectRight,
			// Token: 0x04034F64 RID: 216932
			EffectLeft,
			// Token: 0x04034F65 RID: 216933
			AniRightIn,
			// Token: 0x04034F66 RID: 216934
			AniRightOut
		}
	}
}
