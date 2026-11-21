using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005765 RID: 22373
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlEventTips : UiPanelBase
	{
		// Token: 0x060372EE RID: 226030 RVA: 0x00F67834 File Offset: 0x00F65A34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060372EF RID: 226031 RVA: 0x00F678C0 File Offset: 0x00F65AC0
		protected override void OnBeforeCreateImplement()
		{
			this.TipsSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.TipsSequence);
			this.TipsSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnTipsStartSequenceStart));
			this.TipsSequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnTipsCloseSequenceFinish), false);
		}

		// Token: 0x060372F0 RID: 226032 RVA: 0x00F67920 File Offset: 0x00F65B20
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlEventTips.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlEventTips.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060372F1 RID: 226033 RVA: 0x00F67963 File Offset: 0x00F65B63
		protected override void OnBeforeDestroy()
		{
			this.UnbindGlobalInput();
			this.OnTipsClosed = null;
		}

		// Token: 0x060372F2 RID: 226034 RVA: 0x00F67972 File Offset: 0x00F65B72
		[NullableContext(2)]
		public void SetKeepOpenItem(UUIItem item)
		{
			this.KeepOpenItem = item;
		}

		// Token: 0x060372F3 RID: 226035 RVA: 0x00F6797C File Offset: 0x00F65B7C
		public void Show(bool locked)
		{
			if (!this.TipsWantVisible)
			{
				this.TipsWantVisible = true;
				UiBehaviorLevelSequence tipsSequence = this.TipsSequence;
				if (tipsSequence != null)
				{
					tipsSequence.StopSequenceByKey("Close", false, false);
				}
				UiBehaviorLevelSequence tipsSequence2 = this.TipsSequence;
				if (tipsSequence2 != null)
				{
					tipsSequence2.PlaySequence("Start", false, null);
				}
			}
			if (locked)
			{
				this.BindGlobalInput();
				return;
			}
			this.UnbindGlobalInput();
		}

		// Token: 0x060372F4 RID: 226036 RVA: 0x00F679E0 File Offset: 0x00F65BE0
		public void Hide()
		{
			if (!this.TipsWantVisible)
			{
				this.UnbindGlobalInput();
				base.SetUiActive(false);
				return;
			}
			this.TipsWantVisible = false;
			this.UnbindGlobalInput();
			UiBehaviorLevelSequence tipsSequence = this.TipsSequence;
			if (tipsSequence != null)
			{
				tipsSequence.PlaySequence("Close", false, null);
			}
			Action onTipsClosed = this.OnTipsClosed;
			if (onTipsClosed == null)
			{
				return;
			}
			onTipsClosed();
		}

		// Token: 0x060372F5 RID: 226037 RVA: 0x00F67A40 File Offset: 0x00F65C40
		public void Refresh(int[] eventIds)
		{
			int num = eventIds.Length;
			if (num <= 0)
			{
				return;
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(num > 1);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(num > 1);
			}
			for (int i = 0; i < num; i++)
			{
				this.EventTipsItemList[i].Refresh(eventIds[i]);
			}
		}

		// Token: 0x060372F6 RID: 226038 RVA: 0x00F67AA2 File Offset: 0x00F65CA2
		private void OnTipsStartSequenceStart(string _)
		{
			base.SetUiActive(true);
		}

		// Token: 0x060372F7 RID: 226039 RVA: 0x00F67AAB File Offset: 0x00F65CAB
		private void OnTipsCloseSequenceFinish(string _)
		{
			if (!this.TipsWantVisible)
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x060372F8 RID: 226040 RVA: 0x00F67ABC File Offset: 0x00F65CBC
		private void BindGlobalInput()
		{
			InputDistributeController.Instance.BindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x060372F9 RID: 226041 RVA: 0x00F67AD9 File Offset: 0x00F65CD9
		private void UnbindGlobalInput()
		{
			InputDistributeController.Instance.UnBindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x060372FA RID: 226042 RVA: 0x00F67AF8 File Offset: 0x00F65CF8
		private void OnGlobalClickAction(string _, InputDistributeDefine.EActionType actionType, InputIdentification __)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			UUIItem nowHitComponent = LguiEventSystemManager.Instance.GetNowHitComponent();
			if (this.IsHitOnSelfOrKeepOpen(nowHitComponent))
			{
				return;
			}
			this.Hide();
		}

		// Token: 0x060372FB RID: 226043 RVA: 0x00F67B24 File Offset: 0x00F65D24
		[NullableContext(2)]
		private bool IsHitOnSelfOrKeepOpen(UUIItem hit)
		{
			if (hit == null)
			{
				return false;
			}
			UUIItem uuiitem = hit;
			int num = 0;
			while (uuiitem != null && num < 32)
			{
				if (uuiitem == this.RootItem || uuiitem == this.KeepOpenItem)
				{
					return true;
				}
				uuiitem = uuiitem.GetParentAsUIItem();
				num++;
			}
			return false;
		}

		// Token: 0x0401D299 RID: 119449
		private List<DangoBrawlEventTipsItem> EventTipsItemList = new List<DangoBrawlEventTipsItem>();

		// Token: 0x0401D29A RID: 119450
		[Nullable(2)]
		private UiBehaviorLevelSequence TipsSequence;

		// Token: 0x0401D29B RID: 119451
		private bool TipsWantVisible;

		// Token: 0x0401D29C RID: 119452
		[Nullable(2)]
		private UUIItem KeepOpenItem;

		// Token: 0x0401D29D RID: 119453
		[Nullable(2)]
		public Action OnTipsClosed;

		// Token: 0x0200B370 RID: 45936
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403775A RID: 227162
			PnlListEvent1,
			// Token: 0x0403775B RID: 227163
			PnlLine,
			// Token: 0x0403775C RID: 227164
			PnlListEvent2
		}
	}
}
