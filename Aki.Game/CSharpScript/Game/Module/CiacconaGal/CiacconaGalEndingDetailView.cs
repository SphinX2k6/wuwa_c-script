using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BEE RID: 23534
	public class CiacconaGalEndingDetailView : UiViewBase
	{
		// Token: 0x0603B7B2 RID: 243634 RVA: 0x00E2F68F File Offset: 0x00E2D88F
		[NullableContext(1)]
		public CiacconaGalEndingDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B7B3 RID: 243635 RVA: 0x00E2F698 File Offset: 0x00E2D898
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B7B4 RID: 243636 RVA: 0x00E2F764 File Offset: 0x00E2D964
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalEndingDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalEndingDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7B5 RID: 243637 RVA: 0x00E2F7A8 File Offset: 0x00E2D9A8
		protected override void OnStart()
		{
			ICiacconaEndingViewParam ciacconaEndingViewParam = this.OpenParam as ICiacconaEndingViewParam;
			this.EndingData = ciacconaEndingViewParam.EndingData;
			if (this.EndingData == null)
			{
				return;
			}
			base.SetTextureByPath(this.EndingData.DetailImagePath, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.EndingData.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.EndingData.Desc, Array.Empty<object>());
			base.GetText(3).SetUIActive(!string.IsNullOrEmpty(ciacconaEndingViewParam.LabelTextId));
			if (!string.IsNullOrEmpty(ciacconaEndingViewParam.LabelTextId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), ciacconaEndingViewParam.LabelTextId, Array.Empty<object>());
			}
		}

		// Token: 0x0401EFD2 RID: 126930
		[Nullable(2)]
		private PopupCaptionItem ItemCaption;

		// Token: 0x0401EFD3 RID: 126931
		[Nullable(2)]
		private CiacconaGalEndingData EndingData;

		// Token: 0x0200BDD4 RID: 48596
		private class EComponentDefine
		{
			// Token: 0x040393CF RID: 234447
			public const int ItemCaption = 0;

			// Token: 0x040393D0 RID: 234448
			public const int TextureBg = 1;

			// Token: 0x040393D1 RID: 234449
			public const int TextTitle = 2;

			// Token: 0x040393D2 RID: 234450
			public const int TextLabel = 3;

			// Token: 0x040393D3 RID: 234451
			public const int TextInfo = 4;
		}
	}
}
