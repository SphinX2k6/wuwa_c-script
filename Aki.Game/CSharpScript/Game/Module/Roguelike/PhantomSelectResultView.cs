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
	// Token: 0x02004DF0 RID: 19952
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomSelectResultView : RogueSelectResultBaseView
	{
		// Token: 0x060337CB RID: 210891 RVA: 0x00C07BBF File Offset: 0x00C05DBF
		public PhantomSelectResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060337CC RID: 210892 RVA: 0x00C07BC8 File Offset: 0x00C05DC8
		protected override UniTask OnCreateAsync()
		{
			PhantomSelectResultView.<OnCreateAsync>d__4 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PhantomSelectResultView.<OnCreateAsync>d__4>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060337CD RID: 210893 RVA: 0x00C07C0C File Offset: 0x00C05E0C
		protected override void OnStart()
		{
			base.OnStart();
			this.RogueSelectResult = (this.OpenParam as RogueSelectResult);
			this.UiPoolActorPrivate.UiItem.SetUIParent(base.GetHorizontalLayout(3).GetRootComponent(), false);
			this.PhantomSelectItemLayout = new GenericLayout<PhantomSelectItem, IPhantomSelectItemContextData>(base.GetHorizontalLayout(3), new Func<PhantomSelectItem>(this.CreatePhantomSelectItem), null, false, true);
		}

		// Token: 0x060337CE RID: 210894 RVA: 0x00C07C6E File Offset: 0x00C05E6E
		private PhantomSelectItem CreatePhantomSelectItem()
		{
			return new PhantomSelectItem(false);
		}

		// Token: 0x060337CF RID: 210895 RVA: 0x00C07C76 File Offset: 0x00C05E76
		protected override void OnBeforeDestroy()
		{
			if (this.UiPoolActorPrivate != null)
			{
				UiActorPool.Instance.RecycleAsync(this.UiPoolActorPrivate, "UiItem_PhantomSelectItem_Prefab");
			}
		}

		// Token: 0x060337D0 RID: 210896 RVA: 0x00C07C95 File Offset: 0x00C05E95
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x060337D1 RID: 210897 RVA: 0x00C07C9D File Offset: 0x00C05E9D
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x060337D2 RID: 210898 RVA: 0x00C07CA5 File Offset: 0x00C05EA5
		protected override void Refresh()
		{
			this.RefreshPhantomSelectItemList();
			this.RefreshTitleText();
		}

		// Token: 0x060337D3 RID: 210899 RVA: 0x00C07CB4 File Offset: 0x00C05EB4
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

		// Token: 0x060337D4 RID: 210900 RVA: 0x00C07D1B File Offset: 0x00C05F1B
		protected void RefreshTitleText()
		{
			if (this.RogueSelectResult.OldRogueGainEntry == null)
			{
				base.GetText(4).ShowTextNew("RoguelikeView_25_Text");
				return;
			}
			base.GetText(4).ShowTextNew("RoguelikeView_19_Text");
		}

		// Token: 0x0401B533 RID: 111923
		[Nullable(2)]
		private RogueSelectResult RogueSelectResult;

		// Token: 0x0401B534 RID: 111924
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PhantomSelectItem, IPhantomSelectItemContextData> PhantomSelectItemLayout;

		// Token: 0x0401B535 RID: 111925
		[Nullable(2)]
		private UiPoolActor UiPoolActorPrivate;
	}
}
