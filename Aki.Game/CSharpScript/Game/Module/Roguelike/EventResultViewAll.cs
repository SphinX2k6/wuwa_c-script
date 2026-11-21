using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DAC RID: 15788
	[NullableContext(1)]
	[Nullable(0)]
	public class EventResultViewAll : RogueSelectResultBaseView
	{
		// Token: 0x060285CC RID: 165324 RVA: 0x00B4F69F File Offset: 0x00B4D89F
		public EventResultViewAll(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060285CD RID: 165325 RVA: 0x00B4F6A8 File Offset: 0x00B4D8A8
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

		// Token: 0x060285CE RID: 165326 RVA: 0x00B4F6BC File Offset: 0x00B4D8BC
		protected override UniTask OnBeforeStartAsync()
		{
			EventResultViewAll.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EventResultViewAll.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060285CF RID: 165327 RVA: 0x00B4F6FF File Offset: 0x00B4D8FF
		protected CommonSelectItem CreateCommonSelectItem()
		{
			return new CommonSelectItem();
		}

		// Token: 0x060285D0 RID: 165328 RVA: 0x00B4F708 File Offset: 0x00B4D908
		protected override void OnStart()
		{
			base.OnStart();
			this.EventResult = (this.OpenParam as EventResult);
			UUIItem rootComponent = base.GetHorizontalLayout(3).GetRootComponent();
			this.CommonItemActor.UiItem.SetUIParent(rootComponent, false);
			this.Refresh();
		}

		// Token: 0x060285D1 RID: 165329 RVA: 0x00B4F751 File Offset: 0x00B4D951
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

		// Token: 0x060285D2 RID: 165330 RVA: 0x00B4F781 File Offset: 0x00B4D981
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x060285D3 RID: 165331 RVA: 0x00B4F78C File Offset: 0x00B4D98C
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

		// Token: 0x060285D4 RID: 165332 RVA: 0x00B4F7D1 File Offset: 0x00B4D9D1
		protected void RefreshTitleText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_20_Text");
		}

		// Token: 0x04015EE7 RID: 89831
		private EventResult EventResult;

		// Token: 0x04015EE8 RID: 89832
		private UiPoolActor CommonItemActor;

		// Token: 0x04015EE9 RID: 89833
		protected GenericLayout<CommonSelectItem, RogueGainEntry> CommonSelectItemLayout;
	}
}
