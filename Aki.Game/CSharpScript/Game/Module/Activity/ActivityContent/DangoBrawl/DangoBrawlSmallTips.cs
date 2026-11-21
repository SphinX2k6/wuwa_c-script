using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200576A RID: 22378
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlSmallTips : UiPanelBase
	{
		// Token: 0x06037326 RID: 226086 RVA: 0x00F68D88 File Offset: 0x00F66F88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037327 RID: 226087 RVA: 0x00F68DF4 File Offset: 0x00F66FF4
		protected override void OnBeforeCreateImplement()
		{
			this.TipsSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.TipsSequence);
			this.TipsSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnTipsStartSequenceStart));
			this.TipsSequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnTipsCloseSequenceFinish), false);
		}

		// Token: 0x06037328 RID: 226088 RVA: 0x00F68E52 File Offset: 0x00F67052
		protected override void OnBeforeDestroy()
		{
			this.UnbindGlobalInput();
			this.ReleaseMask();
			this.OnTipsClosed = null;
		}

		// Token: 0x06037329 RID: 226089 RVA: 0x00F68E67 File Offset: 0x00F67067
		public void SetKeepOpenItem(UUIItem item)
		{
			this.KeepOpenItem = item;
		}

		// Token: 0x0603732A RID: 226090 RVA: 0x00F68E70 File Offset: 0x00F67070
		public void SetMaskAttach(UUIButtonComponent maskButton)
		{
			this.MaskButton = maskButton;
		}

		// Token: 0x17006A78 RID: 27256
		// (get) Token: 0x0603732B RID: 226091 RVA: 0x00F68E79 File Offset: 0x00F67079
		private bool UseMaskClose
		{
			get
			{
				return this.MaskButton != null;
			}
		}

		// Token: 0x0603732C RID: 226092 RVA: 0x00F68E84 File Offset: 0x00F67084
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
			if (!locked)
			{
				this.UnbindGlobalInput();
				this.ReleaseMask();
				return;
			}
			if (this.UseMaskClose)
			{
				this.UnbindGlobalInput();
				this.HoldMask();
				return;
			}
			this.ReleaseMask();
			this.BindGlobalInput();
		}

		// Token: 0x0603732D RID: 226093 RVA: 0x00F68F0C File Offset: 0x00F6710C
		public void Hide()
		{
			this.UnbindGlobalInput();
			this.ReleaseMask();
			if (!this.TipsWantVisible)
			{
				base.SetUiActive(false);
				return;
			}
			this.TipsWantVisible = false;
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

		// Token: 0x0603732E RID: 226094 RVA: 0x00F68F6C File Offset: 0x00F6716C
		[NullableContext(1)]
		public void Refresh(string title, string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), desc, Array.Empty<object>());
		}

		// Token: 0x0603732F RID: 226095 RVA: 0x00F68F9C File Offset: 0x00F6719C
		[NullableContext(1)]
		private void OnTipsStartSequenceStart(string _)
		{
			base.SetUiActive(true);
		}

		// Token: 0x06037330 RID: 226096 RVA: 0x00F68FA5 File Offset: 0x00F671A5
		[NullableContext(1)]
		private void OnTipsCloseSequenceFinish(string _)
		{
			if (!this.TipsWantVisible)
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x06037331 RID: 226097 RVA: 0x00F68FB8 File Offset: 0x00F671B8
		private void HoldMask()
		{
			this.MaskHeld = true;
			UUIButtonComponent maskButton = this.MaskButton;
			if (maskButton == null)
			{
				return;
			}
			UUIItem uuiitem = maskButton.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(true);
		}

		// Token: 0x06037332 RID: 226098 RVA: 0x00F68FF0 File Offset: 0x00F671F0
		private void ReleaseMask()
		{
			if (!this.MaskHeld)
			{
				return;
			}
			this.MaskHeld = false;
			UUIButtonComponent maskButton = this.MaskButton;
			if (maskButton == null)
			{
				return;
			}
			UUIItem uuiitem = maskButton.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(false);
		}

		// Token: 0x06037333 RID: 226099 RVA: 0x00F69030 File Offset: 0x00F67230
		private void BindGlobalInput()
		{
			InputDistributeController.Instance.BindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x06037334 RID: 226100 RVA: 0x00F6904D File Offset: 0x00F6724D
		private void UnbindGlobalInput()
		{
			InputDistributeController.Instance.UnBindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x06037335 RID: 226101 RVA: 0x00F6906C File Offset: 0x00F6726C
		[NullableContext(1)]
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

		// Token: 0x06037336 RID: 226102 RVA: 0x00F69098 File Offset: 0x00F67298
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

		// Token: 0x0401D2B3 RID: 119475
		private UiBehaviorLevelSequence TipsSequence;

		// Token: 0x0401D2B4 RID: 119476
		private bool TipsWantVisible;

		// Token: 0x0401D2B5 RID: 119477
		private UUIItem KeepOpenItem;

		// Token: 0x0401D2B6 RID: 119478
		private UUIButtonComponent MaskButton;

		// Token: 0x0401D2B7 RID: 119479
		private bool MaskHeld;

		// Token: 0x0401D2B8 RID: 119480
		public Action OnTipsClosed;

		// Token: 0x0200B379 RID: 45945
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037792 RID: 227218
			TxtTitle,
			// Token: 0x04037793 RID: 227219
			TxtDesc
		}
	}
}
