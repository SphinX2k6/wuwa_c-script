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
	// Token: 0x020051F5 RID: 20981
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonBaseCardComponent : CardComponentBase<ICommonBaseCardComponentData>, ICommonBaseCardComponent
	{
		// Token: 0x06035A93 RID: 219795 RVA: 0x00CB578C File Offset: 0x00CB398C
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

		// Token: 0x06035A94 RID: 219796 RVA: 0x00CB590C File Offset: 0x00CB3B0C
		protected override UniTask OnBeforeStartAsync()
		{
			CommonBaseCardComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonBaseCardComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035A95 RID: 219797 RVA: 0x00CB5950 File Offset: 0x00CB3B50
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

		// Token: 0x06035A96 RID: 219798 RVA: 0x00CB59EC File Offset: 0x00CB3BEC
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

		// Token: 0x06035A97 RID: 219799 RVA: 0x00CB5A2C File Offset: 0x00CB3C2C
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

		// Token: 0x06035A98 RID: 219800 RVA: 0x00CB5A78 File Offset: 0x00CB3C78
		public void RefreshAttack()
		{
			base.GetText(1).SetText(this.Data.Attack.ToString(), true);
		}

		// Token: 0x06035A99 RID: 219801 RVA: 0x00CB5AA8 File Offset: 0x00CB3CA8
		public void RefreshLife()
		{
			base.GetText(3).SetText(this.Data.Life.ToString(), true);
		}

		// Token: 0x06035A9A RID: 219802 RVA: 0x00CB5AD8 File Offset: 0x00CB3CD8
		public void RefreshCost()
		{
			base.GetText(4).SetText(this.Data.Cost.ToString(), true);
		}

		// Token: 0x06035A9B RID: 219803 RVA: 0x00CB5B05 File Offset: 0x00CB3D05
		public void RefreshElementIcon()
		{
			this.ElementItem.Refresh((ECardElement)this.Data.Element, false, 0);
		}

		// Token: 0x06035A9C RID: 219804 RVA: 0x00CB5B20 File Offset: 0x00CB3D20
		public void RefreshElementFrame()
		{
			base.GetItem(9).SetUIActive(this.Data.Element != 0 && !this.Data.OutlookUnlocked);
			base.GetItem(11).SetUIActive(this.Data.Element != 0 && this.Data.OutlookUnlocked);
		}

		// Token: 0x06035A9D RID: 219805 RVA: 0x00CB5B80 File Offset: 0x00CB3D80
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

		// Token: 0x06035A9E RID: 219806 RVA: 0x00CB5BA0 File Offset: 0x00CB3DA0
		public UniTask RefreshCardFaceAsync()
		{
			CommonBaseCardComponent.<RefreshCardFaceAsync>d__13 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<CommonBaseCardComponent.<RefreshCardFaceAsync>d__13>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035A9F RID: 219807 RVA: 0x00CB5BE4 File Offset: 0x00CB3DE4
		public void RefreshToggleState()
		{
			base.GetExtendToggle(0).SetToggleState(this.Data.ToggleState.GetValueOrDefault(), false, false, false);
		}

		// Token: 0x06035AA0 RID: 219808 RVA: 0x00CB5C14 File Offset: 0x00CB3E14
		public void RefreshCardFrame()
		{
			base.GetItem(10).SetUIActive(!this.Data.OutlookUnlocked);
			base.GetItem(12).SetUIActive(this.Data.OutlookUnlocked);
		}

		// Token: 0x06035AA1 RID: 219809 RVA: 0x00CB5C4C File Offset: 0x00CB3E4C
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

		// Token: 0x06035AA2 RID: 219810 RVA: 0x00CB5CF3 File Offset: 0x00CB3EF3
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

		// Token: 0x06035AA3 RID: 219811 RVA: 0x00CB5D0F File Offset: 0x00CB3F0F
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

		// Token: 0x06035AA4 RID: 219812 RVA: 0x00CB5D2C File Offset: 0x00CB3F2C
		private bool CanToggleExecuteChange()
		{
			ICommonBaseCardComponentData data = this.Data;
			return ((data != null) ? data.CanToggleExecuteChange : null) == null || this.Data.CanToggleExecuteChange();
		}

		// Token: 0x06035AA5 RID: 219813 RVA: 0x00CB5D54 File Offset: 0x00CB3F54
		public void RefreshOutlook()
		{
			this.RefreshElementFrame();
			this.RefreshCardFrame();
			this.RefreshCardFace();
		}

		// Token: 0x0401C77B RID: 116603
		protected ICommonBaseCardComponentData Data;

		// Token: 0x0401C77C RID: 116604
		private CardElementItem ElementItem;

		// Token: 0x0200B376 RID: 45942
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036636 RID: 222774
			public const int CardItemToggle = 0;

			// Token: 0x04036637 RID: 222775
			public const int AttackText = 1;

			// Token: 0x04036638 RID: 222776
			public const int ContentItem = 2;

			// Token: 0x04036639 RID: 222777
			public const int LifeText = 3;

			// Token: 0x0403663A RID: 222778
			public const int CostText = 4;

			// Token: 0x0403663B RID: 222779
			public const int MiddleHighLightItem = 5;

			// Token: 0x0403663C RID: 222780
			public const int LeftHighLightItem = 6;

			// Token: 0x0403663D RID: 222781
			public const int ElementItem = 7;

			// Token: 0x0403663E RID: 222782
			public const int CardFaceTexture = 8;

			// Token: 0x0403663F RID: 222783
			public const int NormalElementFrameItem = 9;

			// Token: 0x04036640 RID: 222784
			public const int NormalCardFrameItem = 10;

			// Token: 0x04036641 RID: 222785
			public const int GoldElementFrameItem = 11;

			// Token: 0x04036642 RID: 222786
			public const int GoldCardFrameItem = 12;

			// Token: 0x04036643 RID: 222787
			public const int SpineRootItem = 13;

			// Token: 0x04036644 RID: 222788
			public const int HighLightBgItem = 14;

			// Token: 0x04036645 RID: 222789
			public const int RightHighLightItem = 15;
		}
	}
}
