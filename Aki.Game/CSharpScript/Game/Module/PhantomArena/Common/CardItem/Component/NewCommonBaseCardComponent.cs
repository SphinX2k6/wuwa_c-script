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
	// Token: 0x020051F9 RID: 20985
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewCommonBaseCardComponent : CardComponentBase<ICommonBaseCardComponentData>, ICommonBaseCardComponent
	{
		// Token: 0x06035ADA RID: 219866 RVA: 0x00CB5E88 File Offset: 0x00CB4088
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

		// Token: 0x06035ADB RID: 219867 RVA: 0x00CB6020 File Offset: 0x00CB4220
		protected override UniTask OnBeforeStartAsync()
		{
			NewCommonBaseCardComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewCommonBaseCardComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035ADC RID: 219868 RVA: 0x00CB6064 File Offset: 0x00CB4264
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

		// Token: 0x06035ADD RID: 219869 RVA: 0x00CB6100 File Offset: 0x00CB4300
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

		// Token: 0x06035ADE RID: 219870 RVA: 0x00CB6140 File Offset: 0x00CB4340
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

		// Token: 0x06035ADF RID: 219871 RVA: 0x00CB618C File Offset: 0x00CB438C
		private void RefreshCardType()
		{
			this.CardType = (EPhantomArenaCardType)PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.Data.CardId).Type;
		}

		// Token: 0x06035AE0 RID: 219872 RVA: 0x00CB61BC File Offset: 0x00CB43BC
		private void RefreshAttack()
		{
			base.GetText(1).SetText(this.Data.Attack.ToString(), true);
		}

		// Token: 0x06035AE1 RID: 219873 RVA: 0x00CB61EC File Offset: 0x00CB43EC
		private void RefreshLife()
		{
			base.GetText(3).SetText(this.Data.Life.ToString(), true);
		}

		// Token: 0x06035AE2 RID: 219874 RVA: 0x00CB621C File Offset: 0x00CB441C
		private void RefreshCost()
		{
			base.GetText(4).SetText(this.Data.Cost.ToString(), true);
		}

		// Token: 0x06035AE3 RID: 219875 RVA: 0x00CB6249 File Offset: 0x00CB4449
		public void RefreshElementIcon()
		{
			this.ElementItem.Refresh((ECardElement)this.Data.Element, false, 0);
		}

		// Token: 0x06035AE4 RID: 219876 RVA: 0x00CB6263 File Offset: 0x00CB4463
		public void RefreshElementFrame()
		{
			base.GetItem(8).SetUIActive(this.Data.Element != 0);
		}

		// Token: 0x06035AE5 RID: 219877 RVA: 0x00CB627F File Offset: 0x00CB447F
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

		// Token: 0x06035AE6 RID: 219878 RVA: 0x00CB62A0 File Offset: 0x00CB44A0
		public UniTask RefreshCardFaceAsync()
		{
			NewCommonBaseCardComponent.<RefreshCardFaceAsync>d__15 <RefreshCardFaceAsync>d__;
			<RefreshCardFaceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardFaceAsync>d__.<>4__this = this;
			<RefreshCardFaceAsync>d__.<>1__state = -1;
			<RefreshCardFaceAsync>d__.<>t__builder.Start<NewCommonBaseCardComponent.<RefreshCardFaceAsync>d__15>(ref <RefreshCardFaceAsync>d__);
			return <RefreshCardFaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035AE7 RID: 219879 RVA: 0x00CB62E4 File Offset: 0x00CB44E4
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

		// Token: 0x06035AE8 RID: 219880 RVA: 0x00CB6328 File Offset: 0x00CB4528
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

		// Token: 0x06035AE9 RID: 219881 RVA: 0x00CB6354 File Offset: 0x00CB4554
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

		// Token: 0x06035AEA RID: 219882 RVA: 0x00CB63E8 File Offset: 0x00CB45E8
		public void RefreshToggleState()
		{
			base.GetExtendToggle(0).SetToggleState(this.Data.ToggleState.GetValueOrDefault(), false, false, false);
		}

		// Token: 0x06035AEB RID: 219883 RVA: 0x00CB6418 File Offset: 0x00CB4618
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

		// Token: 0x06035AEC RID: 219884 RVA: 0x00CB64CB File Offset: 0x00CB46CB
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

		// Token: 0x06035AED RID: 219885 RVA: 0x00CB64E7 File Offset: 0x00CB46E7
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

		// Token: 0x06035AEE RID: 219886 RVA: 0x00CB6504 File Offset: 0x00CB4704
		private bool CanToggleExecuteChange()
		{
			ICommonBaseCardComponentData data = this.Data;
			return ((data != null) ? data.CanToggleExecuteChange : null) == null || this.Data.CanToggleExecuteChange();
		}

		// Token: 0x06035AEF RID: 219887 RVA: 0x00CB652C File Offset: 0x00CB472C
		public void RefreshOutlook()
		{
			this.RefreshElementFrame();
			this.RefreshCardFace();
		}

		// Token: 0x0401C789 RID: 116617
		protected ICommonBaseCardComponentData Data;

		// Token: 0x0401C78A RID: 116618
		private CardElementItem ElementItem;

		// Token: 0x0401C78B RID: 116619
		private EPhantomArenaCardType CardType;

		// Token: 0x0200B37C RID: 45948
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403665A RID: 222810
			public const int CardItemToggle = 0;

			// Token: 0x0403665B RID: 222811
			public const int AttackText = 1;

			// Token: 0x0403665C RID: 222812
			public const int ContentItem = 2;

			// Token: 0x0403665D RID: 222813
			public const int LifeText = 3;

			// Token: 0x0403665E RID: 222814
			public const int CostText = 4;

			// Token: 0x0403665F RID: 222815
			public const int MiddleHighLightItem = 5;

			// Token: 0x04036660 RID: 222816
			public const int LeftHighLightItem = 6;

			// Token: 0x04036661 RID: 222817
			public const int RightHighLightItem = 7;

			// Token: 0x04036662 RID: 222818
			public const int ElementItem = 8;

			// Token: 0x04036663 RID: 222819
			public const int ElementIconItem = 9;

			// Token: 0x04036664 RID: 222820
			public const int CostItem = 10;

			// Token: 0x04036665 RID: 222821
			public const int CardFaceTexture = 11;

			// Token: 0x04036666 RID: 222822
			public const int NormalCardItem = 12;

			// Token: 0x04036667 RID: 222823
			public const int SpineRootItem = 13;

			// Token: 0x04036668 RID: 222824
			public const int FieldCardItem = 14;

			// Token: 0x04036669 RID: 222825
			public const int ToolCardItem = 15;

			// Token: 0x0403666A RID: 222826
			public const int ToolCount = 16;
		}
	}
}
