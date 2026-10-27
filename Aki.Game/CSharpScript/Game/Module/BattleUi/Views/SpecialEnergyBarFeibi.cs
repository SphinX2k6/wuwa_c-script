using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD6 RID: 24022
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarFeibi : SpecialEnergyBarBase
	{
		// Token: 0x0603D0E2 RID: 250082 RVA: 0x00EAFC78 File Offset: 0x00EADE78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
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
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D0E3 RID: 250083 RVA: 0x00EAFEB7 File Offset: 0x00EAE0B7
		protected override void OnInitData()
		{
			this.YellowConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150602);
			this.BlueConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(150603);
		}

		// Token: 0x0603D0E4 RID: 250084 RVA: 0x00EAFEF0 File Offset: 0x00EAE0F0
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识1"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识2"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange));
		}

		// Token: 0x0603D0E5 RID: 250085 RVA: 0x00EAFF45 File Offset: 0x00EAE145
		private void OnTagChange(int tagId, bool tagExist)
		{
			this.RefreshState(false);
		}

		// Token: 0x0603D0E6 RID: 250086 RVA: 0x00EAFF50 File Offset: 0x00EAE150
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarFeibi.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarFeibi.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0E7 RID: 250087 RVA: 0x00EAFF94 File Offset: 0x00EAE194
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarFeibi.<InitBarItem>d__14 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarFeibi.<InitBarItem>d__14>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0E8 RID: 250088 RVA: 0x00EAFFD7 File Offset: 0x00EAE1D7
		protected override void OnStart()
		{
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			this.RefreshState(true);
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603D0E9 RID: 250089 RVA: 0x00EAFFF7 File Offset: 0x00EAE1F7
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D0EA RID: 250090 RVA: 0x00EB0000 File Offset: 0x00EAE200
		private void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			switch (this.CurState)
			{
			case SpecialEnergyBarFeibi.EState.Normal:
			{
				UUITexture texture = base.GetTexture(11);
				if (texture != null)
				{
					texture.SetFillAmount(curPercent);
				}
				this.RefreshKeyEnable(isStart);
				return;
			}
			case SpecialEnergyBarFeibi.EState.Yellow:
			{
				UUITexture texture2 = base.GetTexture(5);
				if (texture2 == null)
				{
					return;
				}
				texture2.SetFillAmount(curPercent);
				return;
			}
			case SpecialEnergyBarFeibi.EState.Blue:
			{
				UUITexture texture3 = base.GetTexture(4);
				if (texture3 == null)
				{
					return;
				}
				texture3.SetFillAmount(curPercent);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603D0EB RID: 250091 RVA: 0x00EB0074 File Offset: 0x00EAE274
		protected override void OnKeyEnableChanged()
		{
			this.RefreshKeyEnable(false);
		}

		// Token: 0x0603D0EC RID: 250092 RVA: 0x00EB0080 File Offset: 0x00EAE280
		private void RefreshKeyEnable(bool isStart = false)
		{
			bool keyEnable = this.GetKeyEnable();
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0603D0ED RID: 250093 RVA: 0x00EB00A8 File Offset: 0x00EAE2A8
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识1"]))
			{
				this.SetState(SpecialEnergyBarFeibi.EState.Yellow, isStart);
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1FeibiMd10011.逻辑.延奏标识2"]))
				{
					this.SetState(SpecialEnergyBarFeibi.EState.Blue, isStart);
				}
				else
				{
					this.SetState(SpecialEnergyBarFeibi.EState.Normal, isStart);
				}
			}
			if (!isStart)
			{
				this.RefreshBarPercent(false);
			}
		}

		// Token: 0x0603D0EE RID: 250094 RVA: 0x00EB0124 File Offset: 0x00EAE324
		private void SetState(SpecialEnergyBarFeibi.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			this.CurState = state;
			switch (this.CurState)
			{
			case SpecialEnergyBarFeibi.EState.Normal:
			{
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(0);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				UUIItem item4 = base.GetItem(12);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				if (!isStart)
				{
					base.StopTweenAnim(13);
					base.PlayTweenAnim(14);
					return;
				}
				break;
			}
			case SpecialEnergyBarFeibi.EState.Yellow:
			{
				UUIItem item5 = base.GetItem(10);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUIItem item6 = base.GetItem(1);
				if (item6 != null)
				{
					item6.SetUIActive(true);
				}
				UUIItem item7 = base.GetItem(0);
				if (item7 != null)
				{
					item7.SetUIActive(false);
				}
				UUIItem item8 = base.GetItem(12);
				if (item8 != null)
				{
					item8.SetUIActive(false);
				}
				if (!isStart)
				{
					base.StopTweenAnim(14);
					base.PlayTweenAnim(13);
					return;
				}
				break;
			}
			case SpecialEnergyBarFeibi.EState.Blue:
			{
				UUIItem item9 = base.GetItem(10);
				if (item9 != null)
				{
					item9.SetUIActive(false);
				}
				UUIItem item10 = base.GetItem(1);
				if (item10 != null)
				{
					item10.SetUIActive(false);
				}
				UUIItem item11 = base.GetItem(0);
				if (item11 != null)
				{
					item11.SetUIActive(true);
				}
				UUIItem item12 = base.GetItem(12);
				if (item12 != null)
				{
					item12.SetUIActive(false);
				}
				if (!isStart)
				{
					base.StopTweenAnim(14);
					base.PlayTweenAnim(13);
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0603D0EF RID: 250095 RVA: 0x00EB0287 File Offset: 0x00EAE487
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarFeibiSlot barItemYellow = this.BarItemYellow;
			if (barItemYellow != null)
			{
				barItemYellow.Tick(delta);
			}
			SpecialEnergyBarFeibiSlot barItemBlue = this.BarItemBlue;
			if (barItemBlue == null)
			{
				return;
			}
			barItemBlue.Tick(delta);
		}

		// Token: 0x0401FCFA RID: 130298
		private const int YELLOW_CONFIG_ID = 150602;

		// Token: 0x0401FCFB RID: 130299
		private const int BLUE_CONFIG_ID = 150603;

		// Token: 0x0401FCFC RID: 130300
		private SpecialEnergyBarInfo YellowConfig;

		// Token: 0x0401FCFD RID: 130301
		private SpecialEnergyBarInfo BlueConfig;

		// Token: 0x0401FCFE RID: 130302
		private SpecialEnergyBarFeibiSlot BarItemYellow;

		// Token: 0x0401FCFF RID: 130303
		private SpecialEnergyBarFeibiSlot BarItemBlue;

		// Token: 0x0401FD00 RID: 130304
		private SpecialEnergyBarFeibi.EState CurState;

		// Token: 0x0200C0F1 RID: 49393
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A3B3 RID: 238515
			BlueItem,
			// Token: 0x0403A3B4 RID: 238516
			YellowItem,
			// Token: 0x0403A3B5 RID: 238517
			SlotBarItemBlue,
			// Token: 0x0403A3B6 RID: 238518
			SlotBarItemYellow,
			// Token: 0x0403A3B7 RID: 238519
			BarTextureBlue,
			// Token: 0x0403A3B8 RID: 238520
			BarTextureYellow,
			// Token: 0x0403A3B9 RID: 238521
			CoreBlue,
			// Token: 0x0403A3BA RID: 238522
			CoreYellow,
			// Token: 0x0403A3BB RID: 238523
			BgBlueItem,
			// Token: 0x0403A3BC RID: 238524
			BgYellowItem,
			// Token: 0x0403A3BD RID: 238525
			NormalItem,
			// Token: 0x0403A3BE RID: 238526
			BarTextureNormal,
			// Token: 0x0403A3BF RID: 238527
			KeyItem,
			// Token: 0x0403A3C0 RID: 238528
			AnimAwakeIn,
			// Token: 0x0403A3C1 RID: 238529
			AnimAwakeOut,
			// Token: 0x0403A3C2 RID: 238530
			AnimBurst
		}

		// Token: 0x0200C0F2 RID: 49394
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A3C4 RID: 238532
			Normal,
			// Token: 0x0403A3C5 RID: 238533
			Yellow,
			// Token: 0x0403A3C6 RID: 238534
			Blue
		}
	}
}
