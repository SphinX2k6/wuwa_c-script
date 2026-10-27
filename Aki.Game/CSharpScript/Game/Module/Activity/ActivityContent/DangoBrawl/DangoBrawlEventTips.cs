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
	// Token: 0x02006815 RID: 26645
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlEventTips : UiPanelBase
	{
		// Token: 0x06042799 RID: 272281 RVA: 0x010262F0 File Offset: 0x010244F0
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

		// Token: 0x0604279A RID: 272282 RVA: 0x0102637C File Offset: 0x0102457C
		protected override void OnBeforeCreateImplement()
		{
			this.TipsSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.TipsSequence);
			this.TipsSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnTipsStartSequenceStart));
			this.TipsSequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnTipsCloseSequenceFinish), false);
		}

		// Token: 0x0604279B RID: 272283 RVA: 0x010263DC File Offset: 0x010245DC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlEventTips.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlEventTips.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604279C RID: 272284 RVA: 0x0102641F File Offset: 0x0102461F
		protected override void OnBeforeDestroy()
		{
			this.UnbindGlobalInput();
			this.OnTipsClosed = null;
		}

		// Token: 0x0604279D RID: 272285 RVA: 0x0102642E File Offset: 0x0102462E
		[NullableContext(2)]
		public void SetKeepOpenItem(UUIItem item)
		{
			this.KeepOpenItem = item;
		}

		// Token: 0x0604279E RID: 272286 RVA: 0x01026438 File Offset: 0x01024638
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

		// Token: 0x0604279F RID: 272287 RVA: 0x0102649C File Offset: 0x0102469C
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

		// Token: 0x060427A0 RID: 272288 RVA: 0x010264FC File Offset: 0x010246FC
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

		// Token: 0x060427A1 RID: 272289 RVA: 0x0102655E File Offset: 0x0102475E
		private void OnTipsStartSequenceStart(string _)
		{
			base.SetUiActive(true);
		}

		// Token: 0x060427A2 RID: 272290 RVA: 0x01026567 File Offset: 0x01024767
		private void OnTipsCloseSequenceFinish(string _)
		{
			if (!this.TipsWantVisible)
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x060427A3 RID: 272291 RVA: 0x01026578 File Offset: 0x01024778
		private void BindGlobalInput()
		{
			InputDistributeController.Instance.BindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x060427A4 RID: 272292 RVA: 0x01026595 File Offset: 0x01024795
		private void UnbindGlobalInput()
		{
			InputDistributeController.Instance.UnBindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x060427A5 RID: 272293 RVA: 0x010265B4 File Offset: 0x010247B4
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

		// Token: 0x060427A6 RID: 272294 RVA: 0x010265E0 File Offset: 0x010247E0
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

		// Token: 0x04022A3C RID: 141884
		private List<DangoBrawlEventTipsItem> EventTipsItemList = new List<DangoBrawlEventTipsItem>();

		// Token: 0x04022A3D RID: 141885
		[Nullable(2)]
		private UiBehaviorLevelSequence TipsSequence;

		// Token: 0x04022A3E RID: 141886
		private bool TipsWantVisible;

		// Token: 0x04022A3F RID: 141887
		[Nullable(2)]
		private UUIItem KeepOpenItem;

		// Token: 0x04022A40 RID: 141888
		[Nullable(2)]
		public Action OnTipsClosed;

		// Token: 0x0200C9A3 RID: 51619
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CE6D RID: 249453
			PnlListEvent1,
			// Token: 0x0403CE6E RID: 249454
			PnlLine,
			// Token: 0x0403CE6F RID: 249455
			PnlListEvent2
		}
	}
}
