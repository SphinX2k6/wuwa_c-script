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
	// Token: 0x02005266 RID: 21094
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponDecomposeResultView : UiViewBase
	{
		// Token: 0x06034811 RID: 215057 RVA: 0x00EB0E4E File Offset: 0x00EAF04E
		public PinballWeaponDecomposeResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034813 RID: 215059 RVA: 0x00EB0EAC File Offset: 0x00EAF0AC
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

		// Token: 0x06034814 RID: 215060 RVA: 0x00EB0F94 File Offset: 0x00EAF194
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponDecomposeResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponDecomposeResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034815 RID: 215061 RVA: 0x00EB0FD7 File Offset: 0x00EAF1D7
		protected override void OnBeforeShow()
		{
			this.RefreshItemsAsync().Forget();
		}

		// Token: 0x06034816 RID: 215062 RVA: 0x00EB0FE4 File Offset: 0x00EAF1E4
		private UniTask RefreshItemsAsync()
		{
			PinballWeaponDecomposeResultView.<RefreshItemsAsync>d__10 <RefreshItemsAsync>d__;
			<RefreshItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshItemsAsync>d__.<>4__this = this;
			<RefreshItemsAsync>d__.<>1__state = -1;
			<RefreshItemsAsync>d__.<>t__builder.Start<PinballWeaponDecomposeResultView.<RefreshItemsAsync>d__10>(ref <RefreshItemsAsync>d__);
			return <RefreshItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034817 RID: 215063 RVA: 0x00EB1027 File Offset: 0x00EAF227
		private void OnBtnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034818 RID: 215064 RVA: 0x00EB1030 File Offset: 0x00EAF230
		private void OnResultItemExtendToggleClicked(IPinballItemToggleCallback callbackParameter)
		{
			ItemController.Instance.OpenItemTipsByItemId(89500002, true, null, false);
		}

		// Token: 0x06034819 RID: 215065 RVA: 0x00EB1044 File Offset: 0x00EAF244
		private bool OnResultItemCanExecuteChange(IPinballItemToggleCallback callbackParameter)
		{
			return false;
		}

		// Token: 0x0401BD96 RID: 114070
		public new TItem OpenParam;

		// Token: 0x0401BD97 RID: 114071
		private PinballItemView ResultItemView;

		// Token: 0x0401BD98 RID: 114072
		private PinballItemView ReflectionResultItemView;

		// Token: 0x0401BD99 RID: 114073
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

		// Token: 0x0200AEBC RID: 44732
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035FBF RID: 221119
			BtnClose,
			// Token: 0x04035FC0 RID: 221120
			Item,
			// Token: 0x04035FC1 RID: 221121
			ItemReflection,
			// Token: 0x04035FC2 RID: 221122
			TexLight
		}
	}
}
