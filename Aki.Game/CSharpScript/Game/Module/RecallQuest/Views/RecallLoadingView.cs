using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RecallQuest.Views
{
	// Token: 0x02003EE5 RID: 16101
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallLoadingView : LoadingViewBase
	{
		// Token: 0x06028D48 RID: 167240 RVA: 0x00B75559 File Offset: 0x00B73759
		public RecallLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028D49 RID: 167241 RVA: 0x00B75564 File Offset: 0x00B73764
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

		// Token: 0x06028D4A RID: 167242 RVA: 0x00B75694 File Offset: 0x00B73894
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

		// Token: 0x06028D4B RID: 167243 RVA: 0x00B756E9 File Offset: 0x00B738E9
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
		}

		// Token: 0x06028D4C RID: 167244 RVA: 0x00B756F1 File Offset: 0x00B738F1
		protected override void UpdateShowTipsUi(string title, string tips)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), tips, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), title, Array.Empty<object>());
		}

		// Token: 0x06028D4D RID: 167245 RVA: 0x00B75724 File Offset: 0x00B73924
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

		// Token: 0x06028D4E RID: 167246 RVA: 0x00B75754 File Offset: 0x00B73954
		protected override void UpdateProgressValue(float value)
		{
			this.SetTextProgressValue(4, value, "");
		}

		// Token: 0x06028D4F RID: 167247 RVA: 0x00B75763 File Offset: 0x00B73963
		protected override void UpdateBgUi(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(3), new EUiViewName?(this.ViewInfo.Name), null);
		}

		// Token: 0x04016355 RID: 90965
		private float FillWidth;

		// Token: 0x02009A94 RID: 39572
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040302B2 RID: 197298
			public const int Progress = 0;

			// Token: 0x040302B3 RID: 197299
			public const int Tips = 1;

			// Token: 0x040302B4 RID: 197300
			public const int Title = 2;

			// Token: 0x040302B5 RID: 197301
			public const int BgTexture = 3;

			// Token: 0x040302B6 RID: 197302
			public const int ProgressText = 4;

			// Token: 0x040302B7 RID: 197303
			public const int MoveHandle = 5;

			// Token: 0x040302B8 RID: 197304
			public const int MoveHandleFollowTarget = 6;

			// Token: 0x040302B9 RID: 197305
			public const int ReviewDesc = 7;
		}
	}
}
