using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB3 RID: 19891
	public class SpecialEnergyBarBuLing : SpecialEnergyBarBase
	{
		// Token: 0x06031FF7 RID: 204791 RVA: 0x00DFE558 File Offset: 0x00DFC758
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031FF8 RID: 204792 RVA: 0x00DFE734 File Offset: 0x00DFC934
		protected override void OnInitData()
		{
			base.OnInitData();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarBuLing.TagLeft, new BaseTagComponent.TTagSwitchedCallback(this.OnTagLeftChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarBuLing.TagRight, new BaseTagComponent.TTagSwitchedCallback(this.OnTagRightChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarBuLing.TagAll, new BaseTagComponent.TTagSwitchedCallback(this.OnTagAllChanged));
		}

		// Token: 0x06031FF9 RID: 204793 RVA: 0x00DFE78C File Offset: 0x00DFC98C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarBuLing.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarBuLing.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031FFA RID: 204794 RVA: 0x00DFE7D0 File Offset: 0x00DFC9D0
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarBuLing.<InitBarItem>d__14 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarBuLing.<InitBarItem>d__14>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031FFB RID: 204795 RVA: 0x00DFE813 File Offset: 0x00DFCA13
		private void OnTagLeftChanged(int tagId, bool tagExist)
		{
			this.HasTagLeft = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x06031FFC RID: 204796 RVA: 0x00DFE823 File Offset: 0x00DFCA23
		private void OnTagRightChanged(int tagId, bool tagExist)
		{
			this.HasTagRight = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x06031FFD RID: 204797 RVA: 0x00DFE833 File Offset: 0x00DFCA33
		private void OnTagAllChanged(int tagId, bool tagExist)
		{
			this.HasTagAll = tagExist;
			this.RefreshState(false);
		}

		// Token: 0x06031FFE RID: 204798 RVA: 0x00DFE844 File Offset: 0x00DFCA44
		protected override void OnStart()
		{
			base.InitTweenAnim(7);
			base.InitTweenAnim(9);
			base.InitTweenAnim(8);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			BaseTagComponent tagComponent = this.TagComponent;
			this.HasTagLeft = (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarBuLing.TagLeft));
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.HasTagRight = (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarBuLing.TagRight));
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.HasTagAll = (tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarBuLing.TagAll));
			this.RefreshState(true);
		}

		// Token: 0x06031FFF RID: 204799 RVA: 0x00DFE8E0 File Offset: 0x00DFCAE0
		private void RefreshState(bool isStart = false)
		{
			this.BarItem.SetState(this.HasTagLeft || this.HasTagAll, this.HasTagRight || this.HasTagAll);
			int num = 0;
			if (this.HasTagAll)
			{
				num = 3;
			}
			else if (this.HasTagLeft)
			{
				num = 1;
			}
			else if (this.HasTagRight)
			{
				num = 2;
			}
			if (num == this.State && !isStart)
			{
				return;
			}
			int state = this.State;
			this.State = num;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.State == 0);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(this.State == 1);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(this.State == 2);
			}
			UUIItem item4 = base.GetItem(4);
			if (item4 != null)
			{
				item4.SetUIActive(this.State == 3);
			}
			UUIItem item5 = base.GetItem(5);
			if (item5 != null)
			{
				item5.SetUIActive(this.HasTagLeft || this.HasTagAll);
			}
			UUIItem item6 = base.GetItem(6);
			if (item6 != null)
			{
				item6.SetUIActive(this.HasTagRight || this.HasTagAll);
			}
			if (!isStart)
			{
				if (this.State == 0)
				{
					if (state == 3)
					{
						this.PlayTweenAnimOnly(10);
						return;
					}
					if (state == 1)
					{
						this.PlayTweenAnimOnly(11);
						return;
					}
					if (state == 2)
					{
						this.PlayTweenAnimOnly(12);
						return;
					}
				}
				else
				{
					if (this.State == 3)
					{
						this.PlayTweenAnimOnly(9);
						return;
					}
					if (this.State == 1)
					{
						if (state == 0)
						{
							this.PlayTweenAnimOnly(7);
							return;
						}
					}
					else if (this.State == 2 && state == 0)
					{
						this.PlayTweenAnimOnly(8);
					}
				}
			}
		}

		// Token: 0x06032000 RID: 204800 RVA: 0x00DFEA76 File Offset: 0x00DFCC76
		protected void PlayTweenAnimOnly(int componentType)
		{
			if (this.LastAni >= 0)
			{
				base.StopTweenAnim(this.LastAni);
			}
			this.LastAni = componentType;
			base.PlayTweenAnim(componentType);
		}

		// Token: 0x06032001 RID: 204801 RVA: 0x00DFEA9B File Offset: 0x00DFCC9B
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarBuLingSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.Tick(delta);
		}

		// Token: 0x0401A77B RID: 108411
		[StaticVariableRuleIgnore]
		private static readonly int TagLeft = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.阴阳鱼.阳侧"];

		// Token: 0x0401A77C RID: 108412
		[StaticVariableRuleIgnore]
		private static readonly int TagRight = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.阴阳鱼.阴侧"];

		// Token: 0x0401A77D RID: 108413
		[StaticVariableRuleIgnore]
		private static readonly int TagAll = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.阴阳鱼.嵌合中"];

		// Token: 0x0401A77E RID: 108414
		private const float EFFECT_BASE_PERCENT = 0.41463414f;

		// Token: 0x0401A77F RID: 108415
		private bool HasTagLeft;

		// Token: 0x0401A780 RID: 108416
		private bool HasTagRight;

		// Token: 0x0401A781 RID: 108417
		private bool HasTagAll;

		// Token: 0x0401A782 RID: 108418
		private int State;

		// Token: 0x0401A783 RID: 108419
		private int LastAni = -1;

		// Token: 0x0401A784 RID: 108420
		[Nullable(2)]
		private SpecialEnergyBarBuLingSlot BarItem;

		// Token: 0x0200AAEB RID: 43755
		private enum EChildType
		{
			// Token: 0x04034D11 RID: 216337
			SlotItem,
			// Token: 0x04034D12 RID: 216338
			StateNoneItem,
			// Token: 0x04034D13 RID: 216339
			StateRightItem,
			// Token: 0x04034D14 RID: 216340
			StateLeftItem,
			// Token: 0x04034D15 RID: 216341
			StateAllItem,
			// Token: 0x04034D16 RID: 216342
			LeftBottomItem,
			// Token: 0x04034D17 RID: 216343
			RightBottomItem,
			// Token: 0x04034D18 RID: 216344
			AniLeftIn,
			// Token: 0x04034D19 RID: 216345
			AniRightIn,
			// Token: 0x04034D1A RID: 216346
			AniAllIn,
			// Token: 0x04034D1B RID: 216347
			AniAllOut,
			// Token: 0x04034D1C RID: 216348
			AniLeftOut,
			// Token: 0x04034D1D RID: 216349
			AniRightOut
		}
	}
}
