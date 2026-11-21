using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C9 RID: 16841
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewCommonBaseCardComponent : CardComponentBase<ICommonBaseCardComponentData>, ICommonBaseCardComponent
	{
		// Token: 0x0602A9D5 RID: 174549 RVA: 0x00C034C4 File Offset: 0x00C016C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUITexture)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIText))
			};
		}

		// Token: 0x0602A9D6 RID: 174550 RVA: 0x00C0365C File Offset: 0x00C0185C
		protected override UniTask OnBeforeStartAsync()
		{
			NewCommonBaseCardComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewCommonBaseCardComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A9D7 RID: 174551 RVA: 0x00C036A0 File Offset: 0x00C018A0
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
			extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointerUp));
			base.GetTexture(11).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x0602A9D8 RID: 174552 RVA: 0x00C0373C File Offset: 0x00C0193C
		public override void Refresh(ICommonBaseCardComponentData data)
		{
			NewCommonBaseCardComponent.<>c__DisplayClass6_0 CS$<>8__locals1 = new NewCommonBaseCardComponent.<>c__DisplayClass6_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			new UiAsyncTask("Refresh", delegate()
			{
				NewCommonBaseCardComponent.<>c__DisplayClass6_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<NewCommonBaseCardComponent.<>c__DisplayClass6_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null).Run();
		}

		// Token: 0x0602A9D9 RID: 174553 RVA: 0x00C0377C File Offset: 0x00C0197C
		public UniTask RefreshAsync(ICommonBaseCardComponentData data)
		{
			NewCommonBaseCardComponent.<RefreshAsync>d__7 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<NewCommonBaseCardComponent.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A9DA RID: 174554 RVA: 0x00C037C8 File Offset: 0x00C019C8
		private void RefreshCardType()
		{
			this.CardType = (EPhantomArenaCardType)PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.CardId).Type;
		}

		// Token: 0x0602A9DB RID: 174555 RVA: 0x00C037F8 File Offset: 0x00C019F8
		private void RefreshAttack()
		{
			base.GetText(1).SetText(this.Data.Attack.ToString(), true);
		}

		// Token: 0x0602A9DC RID: 174556 RVA: 0x00C03828 File Offset: 0x00C01A28
		private void RefreshLife()
		{
			base.GetText(3).SetText(this.Data.Life.ToString(), true);
		}

		// Token: 0x0602A9DD RID: 174557 RVA: 0x00C03858 File Offset: 0x00C01A58
		private void RefreshCost()
		{
			base.GetText(4).SetText(this.Data.Cost.ToString(), true);
		}

		// Token: 0x0602A9DE RID: 174558 RVA: 0x00C03885 File Offset: 0x00C01A85
		public void RefreshElementIcon()
		{
			this.ElementItem.Refresh((ECardElement)this.Data.Element, false, 0);
		}

		// Token: 0x0602A9DF RID: 174559 RVA: 0x00C0389F File Offset: 0x00C01A9F
		public void RefreshElementFrame()
		{
			base.GetItem(8).SetUIActive(this.Data.Element != 0);
		}

		// Token: 0x0602A9E0 RID: 174560 RVA: 0x00C038BB File Offset: 0x00C01ABB
		public void RefreshCardFace()
		{
			new UiAsyncTask("Refresh", delegate()
			{
				NewCommonBaseCardComponent.<<RefreshCardFace>b__14_0>d <<RefreshCardFace>b__14_0>d;
				<<RefreshCardFace>b__14_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshCardFace>b__14_0>d.<>4__this = this;
				<<RefreshCardFace>b__14_0>d.<>1__state = -1;
				<<RefreshCardFace>b__14_0>d.<>t__builder.Start<NewCommonBaseCardComponent.<<RefreshCardFace>b__14_0>d>(ref <<RefreshCardFace>b__14_0>d);
				return <<RefreshCardFace>b__14_0>d.<>t__builder.Task;
			}, null).Run();
		}

		// Token: 0x0602A9E1 RID: 174561 RVA: 0x00C038DC File Offset: 0x00C01ADC
		public UniTask RefreshCardFaceAsync()
		{
			NewCommonBaseCardComponent.<RefreshCardFaceAsync>d__15 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<NewCommonBaseCardComponent.<RefreshCardFaceAsync>d__15>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A9E2 RID: 174562 RVA: 0x00C03920 File Offset: 0x00C01B20
		private void RefreshCardItem()
		{
			bool flag = this.CardType == EPhantomArenaCardType.Normal;
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			this.RefreshAttack();
			this.RefreshLife();
			this.RefreshCost();
		}

		// Token: 0x0602A9E3 RID: 174563 RVA: 0x00C03964 File Offset: 0x00C01B64
		private void RefreshFieldItem()
		{
			bool uiactive = this.CardType == EPhantomArenaCardType.Field;
			UUIItem item = base.GetItem(14);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0602A9E4 RID: 174564 RVA: 0x00C03990 File Offset: 0x00C01B90
		private void RefreshToolItem()
		{
			bool flag = this.CardType == EPhantomArenaCardType.Tool;
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.CardId);
				int value = phantomBattleCardConfig.InitAttack().ContainsKey(12) ? phantomBattleCardConfig.InitAttack()[12] : 0;
				UUIText text = base.GetText(16);
				if (text == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x0602A9E5 RID: 174565 RVA: 0x00C03A24 File Offset: 0x00C01C24
		public void RefreshToggleState()
		{
			base.GetExtendToggle(0).SetToggleState(this.Data.ToggleState.GetValueOrDefault(), false, false, false);
		}

		// Token: 0x0602A9E6 RID: 174566 RVA: 0x00C03A54 File Offset: 0x00C01C54
		public void RefreshLightItem()
		{
			int phantomArenaCardCoreCost = PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost();
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.CardId);
			bool flag = phantomBattleCardConfig.Cost == phantomArenaCardCoreCost;
			bool flag2 = phantomBattleCardConfig.Type == 3;
			int num = (flag || flag2) ? 0 : phantomBattleCardConfig.Cost;
			UUIItem item = base.GetItem(10);
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
			UUIItem item4 = base.GetItem(7);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(num >= 3);
		}

		// Token: 0x0602A9E7 RID: 174567 RVA: 0x00C03B07 File Offset: 0x00C01D07
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

		// Token: 0x0602A9E8 RID: 174568 RVA: 0x00C03B23 File Offset: 0x00C01D23
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

		// Token: 0x0602A9E9 RID: 174569 RVA: 0x00C03B40 File Offset: 0x00C01D40
		private bool CanToggleExecuteChange()
		{
			ICommonBaseCardComponentData data = this.Data;
			return ((data != null) ? data.CanToggleExecuteChange : null) == null || this.Data.CanToggleExecuteChange();
		}

		// Token: 0x0602A9EA RID: 174570 RVA: 0x00C03B68 File Offset: 0x00C01D68
		public void RefreshOutlook()
		{
			this.RefreshElementFrame();
			this.RefreshCardFace();
		}

		// Token: 0x040171BE RID: 94654
		protected ICommonBaseCardComponentData Data;

		// Token: 0x040171BF RID: 94655
		private CardElementItem ElementItem;

		// Token: 0x040171C0 RID: 94656
		private EPhantomArenaCardType CardType;

		// Token: 0x02009DB4 RID: 40372
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040310AD RID: 200877
			public const int CardItemToggle = 0;

			// Token: 0x040310AE RID: 200878
			public const int AttackText = 1;

			// Token: 0x040310AF RID: 200879
			public const int ContentItem = 2;

			// Token: 0x040310B0 RID: 200880
			public const int LifeText = 3;

			// Token: 0x040310B1 RID: 200881
			public const int CostText = 4;

			// Token: 0x040310B2 RID: 200882
			public const int MiddleHighLightItem = 5;

			// Token: 0x040310B3 RID: 200883
			public const int LeftHighLightItem = 6;

			// Token: 0x040310B4 RID: 200884
			public const int RightHighLightItem = 7;

			// Token: 0x040310B5 RID: 200885
			public const int ElementItem = 8;

			// Token: 0x040310B6 RID: 200886
			public const int ElementIconItem = 9;

			// Token: 0x040310B7 RID: 200887
			public const int CostItem = 10;

			// Token: 0x040310B8 RID: 200888
			public const int CardFaceTexture = 11;

			// Token: 0x040310B9 RID: 200889
			public const int NormalCardItem = 12;

			// Token: 0x040310BA RID: 200890
			public const int SpineRootItem = 13;

			// Token: 0x040310BB RID: 200891
			public const int FieldCardItem = 14;

			// Token: 0x040310BC RID: 200892
			public const int ToolCardItem = 15;

			// Token: 0x040310BD RID: 200893
			public const int ToolCount = 16;
		}
	}
}
