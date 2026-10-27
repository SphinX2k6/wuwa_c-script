using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ACC RID: 19148
	public class TrapDefenseShopCheckBuffItem : UiPanelBase
	{
		// Token: 0x060319A7 RID: 203175 RVA: 0x00B810C4 File Offset: 0x00B7F2C4
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

		// Token: 0x060319A8 RID: 203176 RVA: 0x00B81254 File Offset: 0x00B7F454
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseShopCheckBuffItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseShopCheckBuffItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319A9 RID: 203177 RVA: 0x00B81298 File Offset: 0x00B7F498
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetTexture(0).SetUIActive(false);
			base.GetSprite(7).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ETrapDefenseTextKey.ShopBuffViewEntry.ToString(), Array.Empty<object>());
		}

		// Token: 0x060319AA RID: 203178 RVA: 0x00B812F4 File Offset: 0x00B7F4F4
		private void OnBtnSelfClicked()
		{
			TrapDefenseModel.Instance.OpenViewBdSum(null, null, null);
		}

		// Token: 0x0200AC3F RID: 44095
		private class EComponentDefine
		{
			// Token: 0x04034566 RID: 214374
			public const int TextureIcon = 0;

			// Token: 0x04034567 RID: 214375
			public const int TextNum = 1;

			// Token: 0x04034568 RID: 214376
			public const int BtnAdd = 2;

			// Token: 0x04034569 RID: 214377
			public const int BtnSelf = 3;

			// Token: 0x0403456A RID: 214378
			public const int TextureIconTrans = 4;

			// Token: 0x0403456B RID: 214379
			public const int Item = 5;

			// Token: 0x0403456C RID: 214380
			public const int SpriteFill = 6;

			// Token: 0x0403456D RID: 214381
			public const int SpriteIcon = 7;

			// Token: 0x0403456E RID: 214382
			public const int SpriteMax = 8;
		}
	}
}
