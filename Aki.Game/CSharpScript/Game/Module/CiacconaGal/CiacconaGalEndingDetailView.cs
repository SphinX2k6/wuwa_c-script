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
	// Token: 0x02004BCE RID: 19406
	public class CiacconaGalEndingDetailView : UiViewBase
	{
		// Token: 0x060306FD RID: 198397 RVA: 0x00D7F99F File Offset: 0x00D7DB9F
		[NullableContext(1)]
		public CiacconaGalEndingDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060306FE RID: 198398 RVA: 0x00D7F9A8 File Offset: 0x00D7DBA8
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

		// Token: 0x060306FF RID: 198399 RVA: 0x00D7FA74 File Offset: 0x00D7DC74
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalEndingDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalEndingDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030700 RID: 198400 RVA: 0x00D7FAB8 File Offset: 0x00D7DCB8
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

		// Token: 0x04019A83 RID: 105091
		[Nullable(2)]
		private PopupCaptionItem ItemCaption;

		// Token: 0x04019A84 RID: 105092
		[Nullable(2)]
		private CiacconaGalEndingData EndingData;

		// Token: 0x0200A7DC RID: 42972
		private class EComponentDefine
		{
			// Token: 0x04033D92 RID: 212370
			public const int ItemCaption = 0;

			// Token: 0x04033D93 RID: 212371
			public const int TextureBg = 1;

			// Token: 0x04033D94 RID: 212372
			public const int TextTitle = 2;

			// Token: 0x04033D95 RID: 212373
			public const int TextLabel = 3;

			// Token: 0x04033D96 RID: 212374
			public const int TextInfo = 4;
		}
	}
}
