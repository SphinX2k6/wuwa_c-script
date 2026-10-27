using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E05 RID: 24069
	public class SpecialEnergyBarThunder : SpecialEnergyBarBase
	{
		// Token: 0x0603D336 RID: 250678 RVA: 0x00EBE37C File Offset: 0x00EBC57C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D337 RID: 250679 RVA: 0x00EBE4AB File Offset: 0x00EBC6AB
		protected override void OnInitData()
		{
			this.OverloadConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130901);
		}

		// Token: 0x0603D338 RID: 250680 RVA: 0x00EBE4C7 File Offset: 0x00EBC6C7
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarThunder.OverloadTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnOverloadTagChanged));
		}

		// Token: 0x0603D339 RID: 250681 RVA: 0x00EBE4E8 File Offset: 0x00EBC6E8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarThunder.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarThunder.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D33A RID: 250682 RVA: 0x00EBE52C File Offset: 0x00EBC72C
		private UniTask InitBarItem()
		{
			SpecialEnergyBarThunder.<InitBarItem>d__13 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarThunder.<InitBarItem>d__13>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D33B RID: 250683 RVA: 0x00EBE570 File Offset: 0x00EBC770
		private UniTask InitOverloadBarItem()
		{
			SpecialEnergyBarThunder.<InitOverloadBarItem>d__14 <InitOverloadBarItem>d__;
			<InitOverloadBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOverloadBarItem>d__.<>4__this = this;
			<InitOverloadBarItem>d__.<>1__state = -1;
			<InitOverloadBarItem>d__.<>t__builder.Start<SpecialEnergyBarThunder.<InitOverloadBarItem>d__14>(ref <InitOverloadBarItem>d__);
			return <InitOverloadBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D33C RID: 250684 RVA: 0x00EBE5B3 File Offset: 0x00EBC7B3
		protected override void OnStart()
		{
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			this.RefreshState(true);
			this.RefreshFullState(true);
		}

		// Token: 0x0603D33D RID: 250685 RVA: 0x00EBE5D8 File Offset: 0x00EBC7D8
		protected override void OnBarPercentChanged()
		{
			this.RefreshFullState(false);
		}

		// Token: 0x0603D33E RID: 250686 RVA: 0x00EBE5E1 File Offset: 0x00EBC7E1
		protected override void OnKeyEnableChanged()
		{
			this.RefreshFullState(false);
		}

		// Token: 0x0603D33F RID: 250687 RVA: 0x00EBE5EA File Offset: 0x00EBC7EA
		private void OnOverloadTagChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarThunder.EState.Overload : SpecialEnergyBarThunder.EState.Normal, false);
		}

		// Token: 0x0603D340 RID: 250688 RVA: 0x00EBE5FC File Offset: 0x00EBC7FC
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetState((tagComponent != null && tagComponent.HasTag(SpecialEnergyBarThunder.OverloadTagId)) ? SpecialEnergyBarThunder.EState.Overload : SpecialEnergyBarThunder.EState.Normal, isStart);
		}

		// Token: 0x0603D341 RID: 250689 RVA: 0x00EBE630 File Offset: 0x00EBC830
		private void SetState(SpecialEnergyBarThunder.EState state, bool isStart = false)
		{
			if (this.CurState == state && !isStart)
			{
				return;
			}
			this.CurState = state;
			bool flag = this.CurState == SpecialEnergyBarThunder.EState.Overload;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUIItem item4 = base.GetItem(4);
			if (item4 != null)
			{
				item4.SetUIActive(flag);
			}
			if (!isStart)
			{
				if (flag)
				{
					base.StopTweenAnim(7);
					base.PlayTweenAnim(6);
				}
				else
				{
					base.StopTweenAnim(6);
					base.PlayTweenAnim(7);
				}
				SpecialEnergyBarThunderOverload overloadBarItem = this.OverloadBarItem;
				if (overloadBarItem != null)
				{
					overloadBarItem.OnChangeVisibleByTagChange(flag);
				}
			}
			this.RefreshFullState(true);
		}

		// Token: 0x0603D342 RID: 250690 RVA: 0x00EBE6EC File Offset: 0x00EBC8EC
		private void RefreshFullState(bool isStart = false)
		{
			if (this.CurState == SpecialEnergyBarThunder.EState.Overload)
			{
				if (this.IsFull || isStart)
				{
					this.IsFull = false;
					this.SetNormalBgUseChangeColor(false);
					base.StopTweenAnim(5);
				}
				return;
			}
			bool keyEnable = this.GetKeyEnable();
			if (this.IsFull == keyEnable && !isStart)
			{
				return;
			}
			this.IsFull = keyEnable;
			this.SetNormalBgUseChangeColor(keyEnable);
			if (keyEnable)
			{
				base.PlayTweenAnim(5);
				return;
			}
			base.StopTweenAnim(5);
		}

		// Token: 0x0603D343 RID: 250691 RVA: 0x00EBE758 File Offset: 0x00EBC958
		private void SetNormalBgUseChangeColor(bool useChangeColor)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				UUIItem uuiitem = texture;
				FColor? fcolor = new FColor?(texture.changeColor);
				uuiitem.SetChangeColor(useChangeColor, fcolor);
			}
		}

		// Token: 0x0603D344 RID: 250692 RVA: 0x00EBE785 File Offset: 0x00EBC985
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			SpecialEnergyBarThunderOverload overloadBarItem = this.OverloadBarItem;
			if (overloadBarItem == null)
			{
				return;
			}
			overloadBarItem.Tick(delta);
		}

		// Token: 0x0401FE95 RID: 130709
		private const int OVERLOAD_CONFIG_ID = 130901;

		// Token: 0x0401FE96 RID: 130710
		[StaticVariableRuleIgnore]
		private static readonly int OverloadTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1ThunderNanzhuMd10011.逻辑.E技能派生"];

		// Token: 0x0401FE97 RID: 130711
		[Nullable(2)]
		private SpecialEnergyBarInfo OverloadConfig;

		// Token: 0x0401FE98 RID: 130712
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401FE99 RID: 130713
		[Nullable(2)]
		private SpecialEnergyBarThunderOverload OverloadBarItem;

		// Token: 0x0401FE9A RID: 130714
		private bool IsFull;

		// Token: 0x0401FE9B RID: 130715
		private SpecialEnergyBarThunder.EState CurState;

		// Token: 0x0200C162 RID: 49506
		private enum EChildType
		{
			// Token: 0x0403A6BB RID: 239291
			StateItemA,
			// Token: 0x0403A6BC RID: 239292
			BgTexture,
			// Token: 0x0403A6BD RID: 239293
			SlotBarItem,
			// Token: 0x0403A6BE RID: 239294
			StateItemB,
			// Token: 0x0403A6BF RID: 239295
			OverloadSlotBarItem,
			// Token: 0x0403A6C0 RID: 239296
			AniAmax,
			// Token: 0x0403A6C1 RID: 239297
			AniAtoB,
			// Token: 0x0403A6C2 RID: 239298
			AniBtoA
		}

		// Token: 0x0200C163 RID: 49507
		private enum EState
		{
			// Token: 0x0403A6C4 RID: 239300
			Normal,
			// Token: 0x0403A6C5 RID: 239301
			Overload
		}
	}
}
