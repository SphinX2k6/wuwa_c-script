using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB9 RID: 15801
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomSelectResultView : RogueSelectResultBaseView
	{
		// Token: 0x06028636 RID: 165430 RVA: 0x00B510CF File Offset: 0x00B4F2CF
		public PhantomSelectResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028637 RID: 165431 RVA: 0x00B510D8 File Offset: 0x00B4F2D8
		protected override UniTask OnCreateAsync()
		{
			PhantomSelectResultView.<OnCreateAsync>d__4 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PhantomSelectResultView.<OnCreateAsync>d__4>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028638 RID: 165432 RVA: 0x00B5111C File Offset: 0x00B4F31C
		protected override void OnStart()
		{
			base.OnStart();
			this.RogueSelectResult = (this.OpenParam as RogueSelectResult);
			this.UiPoolActorPrivate.UiItem.SetUIParent(base.GetHorizontalLayout(3).GetRootComponent(), false);
			this.PhantomSelectItemLayout = new GenericLayout<PhantomSelectItem, IPhantomSelectItemContextData>(base.GetHorizontalLayout(3), new Func<PhantomSelectItem>(this.CreatePhantomSelectItem), null, false, true);
		}

		// Token: 0x06028639 RID: 165433 RVA: 0x00B5117E File Offset: 0x00B4F37E
		private PhantomSelectItem CreatePhantomSelectItem()
		{
			return new PhantomSelectItem(false);
		}

		// Token: 0x0602863A RID: 165434 RVA: 0x00B51186 File Offset: 0x00B4F386
		protected override void OnBeforeDestroy()
		{
			if (this.UiPoolActorPrivate != null)
			{
				UiActorPool.Instance.RecycleAsync(this.UiPoolActorPrivate, "UiItem_PhantomSelectItem_Prefab");
			}
		}

		// Token: 0x0602863B RID: 165435 RVA: 0x00B511A5 File Offset: 0x00B4F3A5
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0602863C RID: 165436 RVA: 0x00B511AD File Offset: 0x00B4F3AD
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x0602863D RID: 165437 RVA: 0x00B511B5 File Offset: 0x00B4F3B5
		protected override void Refresh()
		{
			this.RefreshPhantomSelectItemList();
			this.RefreshTitleText();
		}

		// Token: 0x0602863E RID: 165438 RVA: 0x00B511C4 File Offset: 0x00B4F3C4
		private unsafe void RefreshPhantomSelectItemList()
		{
			PhantomSelectItemContextData phantomSelectItemContextData = new PhantomSelectItemContextData
			{
				RogueGainEntry = this.RogueSelectResult.NewRogueGainEntry,
				RoguelikeInfo = RoguelikeModel.Instance.RogueInfo
			};
			int num = 1;
			List<IPhantomSelectItemContextData> list = new List<IPhantomSelectItemContextData>(num);
			CollectionsMarshal.SetCount<IPhantomSelectItemContextData>(list, num);
			Span<IPhantomSelectItemContextData> span = CollectionsMarshal.AsSpan<IPhantomSelectItemContextData>(list);
			int index = 0;
			*span[index] = phantomSelectItemContextData;
			List<IPhantomSelectItemContextData> data = list;
			this.PhantomSelectItemLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0602863F RID: 165439 RVA: 0x00B5122B File Offset: 0x00B4F42B
		protected void RefreshTitleText()
		{
			if (this.RogueSelectResult.OldRogueGainEntry == null)
			{
				base.GetText(4).ShowTextNew("RoguelikeView_25_Text");
				return;
			}
			base.GetText(4).ShowTextNew("RoguelikeView_19_Text");
		}

		// Token: 0x04015F06 RID: 89862
		[Nullable(2)]
		private RogueSelectResult RogueSelectResult;

		// Token: 0x04015F07 RID: 89863
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PhantomSelectItem, IPhantomSelectItemContextData> PhantomSelectItemLayout;

		// Token: 0x04015F08 RID: 89864
		[Nullable(2)]
		private UiPoolActor UiPoolActorPrivate;
	}
}
