using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004027 RID: 16423
	public class PlotPhotoView : UiViewBase
	{
		// Token: 0x06029908 RID: 170248 RVA: 0x00BBCA0E File Offset: 0x00BBAC0E
		[NullableContext(1)]
		public PlotPhotoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029909 RID: 170249 RVA: 0x00BBCA18 File Offset: 0x00BBAC18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCloseButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602990A RID: 170250 RVA: 0x00BBCBA6 File Offset: 0x00BBADA6
		private void OnClickCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.PlotPhotoView, null);
		}

		// Token: 0x0602990B RID: 170251 RVA: 0x00BBCBB8 File Offset: 0x00BBADB8
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0602990C RID: 170252 RVA: 0x00BBCBBA File Offset: 0x00BBADBA
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0602990D RID: 170253 RVA: 0x00BBCBBC File Offset: 0x00BBADBC
		protected override void OnStart()
		{
			this.Callback = (this.OpenParam as Action);
		}

		// Token: 0x0602990E RID: 170254 RVA: 0x00BBCBD0 File Offset: 0x00BBADD0
		protected override void OnAfterShow()
		{
			base.GetSprite(0).SetUIActive(false);
			base.GetSprite(1).SetUIActive(false);
			base.GetText(4).SetUIActive(false);
			base.GetText(6).SetUIActive(false);
			base.GetText(7).SetUIActive(false);
			base.GetText(8).SetUIActive(false);
			base.GetTexture(3).SetUIActive(false);
			base.GetText(5).SetText("test/残鸣初奏", true);
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath((playerGender == EPlayerGender.Male) ? "PlotPhoto_Male" : "PlotPhoto_Female");
			ResourceSystem.Instance.LoadAsync<UTexture>(resourcePath, delegate([Nullable(2)] UTexture loadObject, string _)
			{
				if (loadObject == null || !loadObject.IsValid())
				{
					return;
				}
				base.GetTexture(3).SetTexture(loadObject);
				base.GetTexture(3).SetUIActive(true);
			}, 100, "js_undefined");
		}

		// Token: 0x0602990F RID: 170255 RVA: 0x00BBCC8F File Offset: 0x00BBAE8F
		protected override void OnBeforeDestroy()
		{
			if (this.Callback != null)
			{
				this.Callback();
				this.Callback = null;
			}
		}

		// Token: 0x04016AEE RID: 92910
		[Nullable(2)]
		private Action Callback;

		// Token: 0x02009BEE RID: 39918
		private static class EPhotoFullComponents
		{
			// Token: 0x04030895 RID: 198805
			public const int LastButton = 0;

			// Token: 0x04030896 RID: 198806
			public const int NextButton = 1;

			// Token: 0x04030897 RID: 198807
			public const int CloseButton = 2;

			// Token: 0x04030898 RID: 198808
			public const int Texture = 3;

			// Token: 0x04030899 RID: 198809
			public const int UITextDark = 4;

			// Token: 0x0403089A RID: 198810
			public const int UITextName = 5;

			// Token: 0x0403089B RID: 198811
			public const int UITextDate = 6;

			// Token: 0x0403089C RID: 198812
			public const int UITextNumber = 7;

			// Token: 0x0403089D RID: 198813
			public const int UITextDescription = 8;
		}
	}
}
