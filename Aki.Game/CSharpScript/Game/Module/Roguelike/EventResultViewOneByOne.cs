using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DAB RID: 15787
	[NullableContext(1)]
	[Nullable(0)]
	public class EventResultViewOneByOne : RogueSelectResultBaseView
	{
		// Token: 0x060285C1 RID: 165313 RVA: 0x00B4F4AE File Offset: 0x00B4D6AE
		public EventResultViewOneByOne(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060285C2 RID: 165314 RVA: 0x00B4F4B8 File Offset: 0x00B4D6B8
		protected override void CloseBtn()
		{
			if (this.CurIndex + 1 >= this.EventResult.RogueGainEntryArray.Count)
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
				return;
			}
			base.PlaySequence("Start", null, false);
			this.CurIndex++;
			this.Refresh();
		}

		// Token: 0x060285C3 RID: 165315 RVA: 0x00B4F514 File Offset: 0x00B4D714
		protected override UniTask OnBeforeStartAsync()
		{
			EventResultViewOneByOne.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EventResultViewOneByOne.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060285C4 RID: 165316 RVA: 0x00B4F557 File Offset: 0x00B4D757
		protected CommonSelectItem CreateCommonSelectItem()
		{
			return new CommonSelectItem();
		}

		// Token: 0x060285C5 RID: 165317 RVA: 0x00B4F560 File Offset: 0x00B4D760
		protected override void OnStart()
		{
			base.OnStart();
			this.EventResult = (this.OpenParam as EventResult);
			UUIItem rootComponent = base.GetHorizontalLayout(3).GetRootComponent();
			this.CommonItemActor.UiItem.SetUIParent(rootComponent, false);
			this.Refresh();
		}

		// Token: 0x060285C6 RID: 165318 RVA: 0x00B4F5A9 File Offset: 0x00B4D7A9
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

		// Token: 0x060285C7 RID: 165319 RVA: 0x00B4F5D9 File Offset: 0x00B4D7D9
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x060285C8 RID: 165320 RVA: 0x00B4F5E4 File Offset: 0x00B4D7E4
		protected override void Refresh()
		{
			this.CommonSelectItemLayout.RefreshByDataAsync(new <>z__ReadOnlySingleElementList<RogueGainEntry>(this.EventResult.RogueGainEntryArray[this.CurIndex]), false, null).ContinueWith(delegate()
			{
				this.CommonSelectItemLayout.GetLayoutItemList().ForEach(delegate(CommonSelectItem item)
				{
					item.SetToggleUnDetermined();
				});
			});
			this.RefreshTitleText();
		}

		// Token: 0x060285C9 RID: 165321 RVA: 0x00B4F639 File Offset: 0x00B4D839
		protected void RefreshTitleText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_20_Text");
		}

		// Token: 0x04015EE3 RID: 89827
		private EventResult EventResult;

		// Token: 0x04015EE4 RID: 89828
		private int CurIndex;

		// Token: 0x04015EE5 RID: 89829
		private UiPoolActor CommonItemActor;

		// Token: 0x04015EE6 RID: 89830
		protected GenericLayout<CommonSelectItem, RogueGainEntry> CommonSelectItemLayout;
	}
}
