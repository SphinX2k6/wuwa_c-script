using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.WeaponDecompose
{
	// Token: 0x020062E8 RID: 25320
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponDecomposeResultView : UiViewBase
	{
		// Token: 0x0603FB50 RID: 260944 RVA: 0x00F69EF2 File Offset: 0x00F680F2
		public PinballWeaponDecomposeResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FB52 RID: 260946 RVA: 0x00F69F50 File Offset: 0x00F68150
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCloseClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FB53 RID: 260947 RVA: 0x00F6A038 File Offset: 0x00F68238
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponDecomposeResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponDecomposeResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB54 RID: 260948 RVA: 0x00F6A07B File Offset: 0x00F6827B
		protected override void OnBeforeShow()
		{
			this.RefreshItemsAsync().Forget();
		}

		// Token: 0x0603FB55 RID: 260949 RVA: 0x00F6A088 File Offset: 0x00F68288
		private UniTask RefreshItemsAsync()
		{
			PinballWeaponDecomposeResultView.<RefreshItemsAsync>d__10 <RefreshItemsAsync>d__;
			<RefreshItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshItemsAsync>d__.<>4__this = this;
			<RefreshItemsAsync>d__.<>1__state = -1;
			<RefreshItemsAsync>d__.<>t__builder.Start<PinballWeaponDecomposeResultView.<RefreshItemsAsync>d__10>(ref <RefreshItemsAsync>d__);
			return <RefreshItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FB56 RID: 260950 RVA: 0x00F6A0CB File Offset: 0x00F682CB
		private void OnBtnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603FB57 RID: 260951 RVA: 0x00F6A0D4 File Offset: 0x00F682D4
		private void OnResultItemExtendToggleClicked(IPinballItemToggleCallback callbackParameter)
		{
			ItemController.Instance.OpenItemTipsByItemId(89500002, true, null);
		}

		// Token: 0x0603FB58 RID: 260952 RVA: 0x00F6A0E7 File Offset: 0x00F682E7
		private bool OnResultItemCanExecuteChange(IPinballItemToggleCallback callbackParameter)
		{
			return false;
		}

		// Token: 0x04021467 RID: 136295
		public new TItem OpenParam;

		// Token: 0x04021468 RID: 136296
		private PinballItemView ResultItemView;

		// Token: 0x04021469 RID: 136297
		private PinballItemView ReflectionResultItemView;

		// Token: 0x0402146A RID: 136298
		private static readonly Dictionary<InventoryDefine.EQuality, string> QualityColorMap = new Dictionary<InventoryDefine.EQuality, string>
		{
			{
				InventoryDefine.EQuality.White,
				"56D29BFF"
			},
			{
				InventoryDefine.EQuality.Green,
				"53D0FEFF"
			},
			{
				InventoryDefine.EQuality.Blue,
				"A651FEFF"
			},
			{
				InventoryDefine.EQuality.Purple,
				"E48C26FF"
			},
			{
				InventoryDefine.EQuality.Orange,
				"DD0D33FF"
			}
		};

		// Token: 0x0200C4D5 RID: 50389
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B65D RID: 243293
			BtnClose,
			// Token: 0x0403B65E RID: 243294
			Item,
			// Token: 0x0403B65F RID: 243295
			ItemReflection,
			// Token: 0x0403B660 RID: 243296
			TexLight
		}
	}
}
