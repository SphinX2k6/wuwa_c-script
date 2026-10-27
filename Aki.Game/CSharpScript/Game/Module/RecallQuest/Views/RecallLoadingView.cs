using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RecallQuest.Views
{
	// Token: 0x02004F1C RID: 20252
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallLoadingView : LoadingViewBase
	{
		// Token: 0x06033EDD RID: 212701 RVA: 0x00C2BEE5 File Offset: 0x00C2A0E5
		public RecallLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033EDE RID: 212702 RVA: 0x00C2BEF0 File Offset: 0x00C2A0F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033EDF RID: 212703 RVA: 0x00C2C020 File Offset: 0x00C2A220
		protected override void OnStart()
		{
			int loadingId = RecallQuestModel.Instance.GetLoadingId();
			LoadingModel.Instance.SetSpecifiedLoadingConfigId(new int?(loadingId));
			this.FillWidth = base.GetItem(6).Width;
			base.OnStart();
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(1f);
		}

		// Token: 0x06033EE0 RID: 212704 RVA: 0x00C2C075 File Offset: 0x00C2A275
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
		}

		// Token: 0x06033EE1 RID: 212705 RVA: 0x00C2C07D File Offset: 0x00C2A27D
		protected override void UpdateShowTipsUi(string title, string tips)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), tips, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), title, Array.Empty<object>());
		}

		// Token: 0x06033EE2 RID: 212706 RVA: 0x00C2C0B0 File Offset: 0x00C2A2B0
		protected override void UpdateProgressRate(float rate)
		{
			base.SetTextureProgressRate(0, rate);
			float anchorOffsetX = this.FillWidth * rate;
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetAnchorOffsetX(anchorOffsetX);
		}

		// Token: 0x06033EE3 RID: 212707 RVA: 0x00C2C0E0 File Offset: 0x00C2A2E0
		protected override void UpdateProgressValue(float value)
		{
			this.SetTextProgressValue(4, value, "");
		}

		// Token: 0x06033EE4 RID: 212708 RVA: 0x00C2C0EF File Offset: 0x00C2A2EF
		protected override void UpdateBgUi(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(3), new EUiViewName?(this.ViewInfo.Name), null);
		}

		// Token: 0x0401B982 RID: 113026
		private float FillWidth;

		// Token: 0x0200B064 RID: 45156
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04035887 RID: 219271
			public const int Progress = 0;

			// Token: 0x04035888 RID: 219272
			public const int Tips = 1;

			// Token: 0x04035889 RID: 219273
			public const int Title = 2;

			// Token: 0x0403588A RID: 219274
			public const int BgTexture = 3;

			// Token: 0x0403588B RID: 219275
			public const int ProgressText = 4;

			// Token: 0x0403588C RID: 219276
			public const int MoveHandle = 5;

			// Token: 0x0403588D RID: 219277
			public const int MoveHandleFollowTarget = 6;

			// Token: 0x0403588E RID: 219278
			public const int ReviewDesc = 7;
		}
	}
}
