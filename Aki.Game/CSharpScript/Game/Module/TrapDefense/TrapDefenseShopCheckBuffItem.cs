using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A74 RID: 14964
	public class TrapDefenseShopCheckBuffItem : UiPanelBase
	{
		// Token: 0x06026737 RID: 157495 RVA: 0x00AC5078 File Offset: 0x00AC3278
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnSelfClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026738 RID: 157496 RVA: 0x00AC5208 File Offset: 0x00AC3408
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseShopCheckBuffItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseShopCheckBuffItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026739 RID: 157497 RVA: 0x00AC524C File Offset: 0x00AC344C
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetTexture(0).SetUIActive(false);
			base.GetSprite(7).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ETrapDefenseTextKey.ShopBuffViewEntry.ToString(), Array.Empty<object>());
		}

		// Token: 0x0602673A RID: 157498 RVA: 0x00AC52A8 File Offset: 0x00AC34A8
		private void OnBtnSelfClicked()
		{
			TrapDefenseModel.Instance.OpenViewBdSum(null, null, null);
		}

		// Token: 0x0200965F RID: 38495
		private class EComponentDefine
		{
			// Token: 0x0402EF17 RID: 192279
			public const int TextureIcon = 0;

			// Token: 0x0402EF18 RID: 192280
			public const int TextNum = 1;

			// Token: 0x0402EF19 RID: 192281
			public const int BtnAdd = 2;

			// Token: 0x0402EF1A RID: 192282
			public const int BtnSelf = 3;

			// Token: 0x0402EF1B RID: 192283
			public const int TextureIconTrans = 4;

			// Token: 0x0402EF1C RID: 192284
			public const int Item = 5;

			// Token: 0x0402EF1D RID: 192285
			public const int SpriteFill = 6;

			// Token: 0x0402EF1E RID: 192286
			public const int SpriteIcon = 7;

			// Token: 0x0402EF1F RID: 192287
			public const int SpriteMax = 8;
		}
	}
}
