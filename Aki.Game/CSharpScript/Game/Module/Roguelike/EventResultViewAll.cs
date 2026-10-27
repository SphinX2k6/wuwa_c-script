using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE3 RID: 19939
	[NullableContext(1)]
	[Nullable(0)]
	public class EventResultViewAll : RogueSelectResultBaseView
	{
		// Token: 0x06033761 RID: 210785 RVA: 0x00C0618F File Offset: 0x00C0438F
		public EventResultViewAll(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033762 RID: 210786 RVA: 0x00C06198 File Offset: 0x00C04398
		protected override void CloseBtn()
		{
			base.CloseMe(delegate(bool success)
			{
				EventResult eventResult = this.EventResult;
				if (eventResult == null)
				{
					return;
				}
				Action<bool?> callback = eventResult.Callback;
				if (callback == null)
				{
					return;
				}
				callback(new bool?(success));
			});
		}

		// Token: 0x06033763 RID: 210787 RVA: 0x00C061AC File Offset: 0x00C043AC
		protected override UniTask OnBeforeStartAsync()
		{
			EventResultViewAll.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EventResultViewAll.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033764 RID: 210788 RVA: 0x00C061EF File Offset: 0x00C043EF
		protected CommonSelectItem CreateCommonSelectItem()
		{
			return new CommonSelectItem();
		}

		// Token: 0x06033765 RID: 210789 RVA: 0x00C061F8 File Offset: 0x00C043F8
		protected override void OnStart()
		{
			base.OnStart();
			this.EventResult = (this.OpenParam as EventResult);
			UUIItem rootComponent = base.GetHorizontalLayout(3).GetRootComponent();
			this.CommonItemActor.UiItem.SetUIParent(rootComponent, false);
			this.Refresh();
		}

		// Token: 0x06033766 RID: 210790 RVA: 0x00C06241 File Offset: 0x00C04441
		protected override void OnBeforeDestroy()
		{
			GenericLayout<CommonSelectItem, RogueGainEntry> commonSelectItemLayout = this.CommonSelectItemLayout;
			if (commonSelectItemLayout != null)
			{
				commonSelectItemLayout.ClearChildren();
			}
			if (this.CommonItemActor != null)
			{
				UiActorPool.Instance.RecycleAsync(this.CommonItemActor, "UiItem_CommonSelectItem_Prefab");
			}
		}

		// Token: 0x06033767 RID: 210791 RVA: 0x00C06271 File Offset: 0x00C04471
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x06033768 RID: 210792 RVA: 0x00C0627C File Offset: 0x00C0447C
		protected override void Refresh()
		{
			this.CommonSelectItemLayout.RefreshByDataAsync(this.EventResult.RogueGainEntryArray, false, null).ContinueWith(delegate()
			{
				this.CommonSelectItemLayout.GetLayoutItemList().ForEach(delegate(CommonSelectItem item)
				{
					item.SetToggleUnDetermined();
				});
			});
			this.RefreshTitleText();
		}

		// Token: 0x06033769 RID: 210793 RVA: 0x00C062C1 File Offset: 0x00C044C1
		protected void RefreshTitleText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_20_Text");
		}

		// Token: 0x0401B514 RID: 111892
		private EventResult EventResult;

		// Token: 0x0401B515 RID: 111893
		private UiPoolActor CommonItemActor;

		// Token: 0x0401B516 RID: 111894
		protected GenericLayout<CommonSelectItem, RogueGainEntry> CommonSelectItemLayout;
	}
}
