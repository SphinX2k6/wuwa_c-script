using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C5 RID: 16837
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonBaseCardComponent : CardComponentBase<ICommonBaseCardComponentData>, ICommonBaseCardComponent
	{
		// Token: 0x0602A98E RID: 174478 RVA: 0x00C02DC8 File Offset: 0x00C00FC8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem))
			};
		}

		// Token: 0x0602A98F RID: 174479 RVA: 0x00C02F48 File Offset: 0x00C01148
		protected override UniTask OnBeforeStartAsync()
		{
			CommonBaseCardComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonBaseCardComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A990 RID: 174480 RVA: 0x00C02F8C File Offset: 0x00C0118C
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
			extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointerUp));
			base.GetTexture(8).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(15).SetUIActive(false);
			base.GetItem(14).SetUIActive(false);
		}

		// Token: 0x0602A991 RID: 174481 RVA: 0x00C03028 File Offset: 0x00C01228
		public override void Refresh(ICommonBaseCardComponentData data)
		{
			CommonBaseCardComponent.<>c__DisplayClass5_0 CS$<>8__locals1 = new CommonBaseCardComponent.<>c__DisplayClass5_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			new UiAsyncTask("Refresh", delegate()
			{
				CommonBaseCardComponent.<>c__DisplayClass5_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<CommonBaseCardComponent.<>c__DisplayClass5_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null).Run();
		}

		// Token: 0x0602A992 RID: 174482 RVA: 0x00C03068 File Offset: 0x00C01268
		public UniTask RefreshAsync(ICommonBaseCardComponentData data)
		{
			CommonBaseCardComponent.<RefreshAsync>d__6 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<CommonBaseCardComponent.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A993 RID: 174483 RVA: 0x00C030B4 File Offset: 0x00C012B4
		public void RefreshAttack()
		{
			base.GetText(1).SetText(this.Data.Attack.ToString(), true);
		}

		// Token: 0x0602A994 RID: 174484 RVA: 0x00C030E4 File Offset: 0x00C012E4
		public void RefreshLife()
		{
			base.GetText(3).SetText(this.Data.Life.ToString(), true);
		}

		// Token: 0x0602A995 RID: 174485 RVA: 0x00C03114 File Offset: 0x00C01314
		public void RefreshCost()
		{
			base.GetText(4).SetText(this.Data.Cost.ToString(), true);
		}

		// Token: 0x0602A996 RID: 174486 RVA: 0x00C03141 File Offset: 0x00C01341
		public void RefreshElementIcon()
		{
			this.ElementItem.Refresh((ECardElement)this.Data.Element, false, 0);
		}

		// Token: 0x0602A997 RID: 174487 RVA: 0x00C0315C File Offset: 0x00C0135C
		public void RefreshElementFrame()
		{
			base.GetItem(9).SetUIActive(this.Data.Element != 0 && !this.Data.OutlookUnlocked);
			base.GetItem(11).SetUIActive(this.Data.Element != 0 && this.Data.OutlookUnlocked);
		}

		// Token: 0x0602A998 RID: 174488 RVA: 0x00C031BC File Offset: 0x00C013BC
		public void RefreshCardFace()
		{
			new UiAsyncTask("Refresh", delegate()
			{
				CommonBaseCardComponent.<<RefreshCardFace>b__12_0>d <<RefreshCardFace>b__12_0>d;
				<<RefreshCardFace>b__12_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshCardFace>b__12_0>d.<>4__this = this;
				<<RefreshCardFace>b__12_0>d.<>1__state = -1;
				<<RefreshCardFace>b__12_0>d.<>t__builder.Start<CommonBaseCardComponent.<<RefreshCardFace>b__12_0>d>(ref <<RefreshCardFace>b__12_0>d);
				return <<RefreshCardFace>b__12_0>d.<>t__builder.Task;
			}, null).Run();
		}

		// Token: 0x0602A999 RID: 174489 RVA: 0x00C031DC File Offset: 0x00C013DC
		public UniTask RefreshCardFaceAsync()
		{
			CommonBaseCardComponent.<RefreshCardFaceAsync>d__13 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<CommonBaseCardComponent.<RefreshCardFaceAsync>d__13>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A99A RID: 174490 RVA: 0x00C03220 File Offset: 0x00C01420
		public void RefreshToggleState()
		{
			base.GetExtendToggle(0).SetToggleState(this.Data.ToggleState.GetValueOrDefault(), false, false, false);
		}

		// Token: 0x0602A99B RID: 174491 RVA: 0x00C03250 File Offset: 0x00C01450
		public void RefreshCardFrame()
		{
			base.GetItem(10).SetUIActive(!this.Data.OutlookUnlocked);
			base.GetItem(12).SetUIActive(this.Data.OutlookUnlocked);
		}

		// Token: 0x0602A99C RID: 174492 RVA: 0x00C03288 File Offset: 0x00C01488
		public void RefreshLightItem()
		{
			int phantomArenaCardCoreCost = PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost();
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.CardId);
			int num = (phantomBattleCardConfig.Cost == phantomArenaCardCoreCost) ? 0 : phantomBattleCardConfig.Cost;
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(num != 0);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(num >= 1);
			}
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(num >= 3);
			}
			UUIItem item4 = base.GetItem(15);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(num >= 3);
		}

		// Token: 0x0602A99D RID: 174493 RVA: 0x00C0332F File Offset: 0x00C0152F
		private void OnPointerUp(EToggleState _)
		{
			ICommonBaseCardComponentData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action onPointerUp = data.OnPointerUp;
			if (onPointerUp == null)
			{
				return;
			}
			onPointerUp();
		}

		// Token: 0x0602A99E RID: 174494 RVA: 0x00C0334B File Offset: 0x00C0154B
		private void OnToggleStateChanged(EToggleState state)
		{
			ICommonBaseCardComponentData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action<EToggleState> onToggleStateChanged = data.OnToggleStateChanged;
			if (onToggleStateChanged == null)
			{
				return;
			}
			onToggleStateChanged(state);
		}

		// Token: 0x0602A99F RID: 174495 RVA: 0x00C03368 File Offset: 0x00C01568
		private bool CanToggleExecuteChange()
		{
			ICommonBaseCardComponentData data = this.Data;
			return ((data != null) ? data.CanToggleExecuteChange : null) == null || this.Data.CanToggleExecuteChange();
		}

		// Token: 0x0602A9A0 RID: 174496 RVA: 0x00C03390 File Offset: 0x00C01590
		public void RefreshOutlook()
		{
			this.RefreshElementFrame();
			this.RefreshCardFrame();
			this.RefreshCardFace();
		}

		// Token: 0x040171B0 RID: 94640
		protected ICommonBaseCardComponentData Data;

		// Token: 0x040171B1 RID: 94641
		private CardElementItem ElementItem;

		// Token: 0x02009DAE RID: 40366
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04031089 RID: 200841
			public const int CardItemToggle = 0;

			// Token: 0x0403108A RID: 200842
			public const int AttackText = 1;

			// Token: 0x0403108B RID: 200843
			public const int ContentItem = 2;

			// Token: 0x0403108C RID: 200844
			public const int LifeText = 3;

			// Token: 0x0403108D RID: 200845
			public const int CostText = 4;

			// Token: 0x0403108E RID: 200846
			public const int MiddleHighLightItem = 5;

			// Token: 0x0403108F RID: 200847
			public const int LeftHighLightItem = 6;

			// Token: 0x04031090 RID: 200848
			public const int ElementItem = 7;

			// Token: 0x04031091 RID: 200849
			public const int CardFaceTexture = 8;

			// Token: 0x04031092 RID: 200850
			public const int NormalElementFrameItem = 9;

			// Token: 0x04031093 RID: 200851
			public const int NormalCardFrameItem = 10;

			// Token: 0x04031094 RID: 200852
			public const int GoldElementFrameItem = 11;

			// Token: 0x04031095 RID: 200853
			public const int GoldCardFrameItem = 12;

			// Token: 0x04031096 RID: 200854
			public const int SpineRootItem = 13;

			// Token: 0x04031097 RID: 200855
			public const int HighLightBgItem = 14;

			// Token: 0x04031098 RID: 200856
			public const int RightHighLightItem = 15;
		}
	}
}
