using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005057 RID: 20567
	public class PlotPhotoView : UiViewBase
	{
		// Token: 0x06034A15 RID: 215573 RVA: 0x00C6F76E File Offset: 0x00C6D96E
		[NullableContext(1)]
		public PlotPhotoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034A16 RID: 215574 RVA: 0x00C6F778 File Offset: 0x00C6D978
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

		// Token: 0x06034A17 RID: 215575 RVA: 0x00C6F906 File Offset: 0x00C6DB06
		private void OnClickCloseButton()
		{
			UiManager.Instance.CloseView(EUiViewName.PlotPhotoView, null);
		}

		// Token: 0x06034A18 RID: 215576 RVA: 0x00C6F918 File Offset: 0x00C6DB18
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06034A19 RID: 215577 RVA: 0x00C6F91A File Offset: 0x00C6DB1A
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06034A1A RID: 215578 RVA: 0x00C6F91C File Offset: 0x00C6DB1C
		protected override void OnStart()
		{
			this.Callback = (this.OpenParam as Action);
		}

		// Token: 0x06034A1B RID: 215579 RVA: 0x00C6F930 File Offset: 0x00C6DB30
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

		// Token: 0x06034A1C RID: 215580 RVA: 0x00C6F9EF File Offset: 0x00C6DBEF
		protected override void OnBeforeDestroy()
		{
			if (this.Callback != null)
			{
				this.Callback();
				this.Callback = null;
			}
		}

		// Token: 0x0401C0C3 RID: 114883
		[Nullable(2)]
		private Action Callback;

		// Token: 0x0200B1B4 RID: 45492
		private static class EPhotoFullComponents
		{
			// Token: 0x04035E40 RID: 220736
			public const int LastButton = 0;

			// Token: 0x04035E41 RID: 220737
			public const int NextButton = 1;

			// Token: 0x04035E42 RID: 220738
			public const int CloseButton = 2;

			// Token: 0x04035E43 RID: 220739
			public const int Texture = 3;

			// Token: 0x04035E44 RID: 220740
			public const int UITextDark = 4;

			// Token: 0x04035E45 RID: 220741
			public const int UITextName = 5;

			// Token: 0x04035E46 RID: 220742
			public const int UITextDate = 6;

			// Token: 0x04035E47 RID: 220743
			public const int UITextNumber = 7;

			// Token: 0x04035E48 RID: 220744
			public const int UITextDescription = 8;
		}
	}
}
