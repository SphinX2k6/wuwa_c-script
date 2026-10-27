using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE2 RID: 19938
	[NullableContext(1)]
	[Nullable(0)]
	public class EventResultViewOneByOne : RogueSelectResultBaseView
	{
		// Token: 0x06033756 RID: 210774 RVA: 0x00C05F9E File Offset: 0x00C0419E
		public EventResultViewOneByOne(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033757 RID: 210775 RVA: 0x00C05FA8 File Offset: 0x00C041A8
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

		// Token: 0x06033758 RID: 210776 RVA: 0x00C06004 File Offset: 0x00C04204
		protected override UniTask OnBeforeStartAsync()
		{
			EventResultViewOneByOne.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EventResultViewOneByOne.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033759 RID: 210777 RVA: 0x00C06047 File Offset: 0x00C04247
		protected CommonSelectItem CreateCommonSelectItem()
		{
			return new CommonSelectItem();
		}

		// Token: 0x0603375A RID: 210778 RVA: 0x00C06050 File Offset: 0x00C04250
		protected override void OnStart()
		{
			base.OnStart();
			this.EventResult = (this.OpenParam as EventResult);
			UUIItem rootComponent = base.GetHorizontalLayout(3).GetRootComponent();
			this.CommonItemActor.UiItem.SetUIParent(rootComponent, false);
			this.Refresh();
		}

		// Token: 0x0603375B RID: 210779 RVA: 0x00C06099 File Offset: 0x00C04299
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

		// Token: 0x0603375C RID: 210780 RVA: 0x00C060C9 File Offset: 0x00C042C9
		protected override void OnDescModelChange()
		{
			this.Refresh();
		}

		// Token: 0x0603375D RID: 210781 RVA: 0x00C060D4 File Offset: 0x00C042D4
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

		// Token: 0x0603375E RID: 210782 RVA: 0x00C06129 File Offset: 0x00C04329
		protected void RefreshTitleText()
		{
			base.GetText(4).ShowTextNew("RoguelikeView_20_Text");
		}

		// Token: 0x0401B510 RID: 111888
		private EventResult EventResult;

		// Token: 0x0401B511 RID: 111889
		private int CurIndex;

		// Token: 0x0401B512 RID: 111890
		private UiPoolActor CommonItemActor;

		// Token: 0x0401B513 RID: 111891
		protected GenericLayout<CommonSelectItem, RogueGainEntry> CommonSelectItemLayout;
	}
}
