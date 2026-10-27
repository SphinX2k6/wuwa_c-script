using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200681A RID: 26650
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlSmallTips : UiPanelBase
	{
		// Token: 0x060427D1 RID: 272337 RVA: 0x01027844 File Offset: 0x01025A44
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

		// Token: 0x060427D2 RID: 272338 RVA: 0x010278B0 File Offset: 0x01025AB0
		protected override void OnBeforeCreateImplement()
		{
			this.TipsSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.TipsSequence);
			this.TipsSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnTipsStartSequenceStart));
			this.TipsSequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnTipsCloseSequenceFinish), false);
		}

		// Token: 0x060427D3 RID: 272339 RVA: 0x0102790E File Offset: 0x01025B0E
		protected override void OnBeforeDestroy()
		{
			this.UnbindGlobalInput();
			this.ReleaseMask();
			this.OnTipsClosed = null;
		}

		// Token: 0x060427D4 RID: 272340 RVA: 0x01027923 File Offset: 0x01025B23
		public void SetKeepOpenItem(UUIItem item)
		{
			this.KeepOpenItem = item;
		}

		// Token: 0x060427D5 RID: 272341 RVA: 0x0102792C File Offset: 0x01025B2C
		public void SetMaskAttach(UUIButtonComponent maskButton)
		{
			this.MaskButton = maskButton;
		}

		// Token: 0x17009737 RID: 38711
		// (get) Token: 0x060427D6 RID: 272342 RVA: 0x01027935 File Offset: 0x01025B35
		private bool UseMaskClose
		{
			get
			{
				return this.MaskButton != null;
			}
		}

		// Token: 0x060427D7 RID: 272343 RVA: 0x01027940 File Offset: 0x01025B40
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

		// Token: 0x060427D8 RID: 272344 RVA: 0x010279C8 File Offset: 0x01025BC8
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

		// Token: 0x060427D9 RID: 272345 RVA: 0x01027A28 File Offset: 0x01025C28
		[NullableContext(1)]
		public void Refresh(string title, string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), desc, Array.Empty<object>());
		}

		// Token: 0x060427DA RID: 272346 RVA: 0x01027A58 File Offset: 0x01025C58
		[NullableContext(1)]
		private void OnTipsStartSequenceStart(string _)
		{
			base.SetUiActive(true);
		}

		// Token: 0x060427DB RID: 272347 RVA: 0x01027A61 File Offset: 0x01025C61
		[NullableContext(1)]
		private void OnTipsCloseSequenceFinish(string _)
		{
			if (!this.TipsWantVisible)
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x060427DC RID: 272348 RVA: 0x01027A74 File Offset: 0x01025C74
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

		// Token: 0x060427DD RID: 272349 RVA: 0x01027AAC File Offset: 0x01025CAC
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

		// Token: 0x060427DE RID: 272350 RVA: 0x01027AEC File Offset: 0x01025CEC
		private void BindGlobalInput()
		{
			InputDistributeController.Instance.BindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x060427DF RID: 272351 RVA: 0x01027B09 File Offset: 0x01025D09
		private void UnbindGlobalInput()
		{
			InputDistributeController.Instance.UnBindActionIgnoreLimit("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGlobalClickAction));
		}

		// Token: 0x060427E0 RID: 272352 RVA: 0x01027B28 File Offset: 0x01025D28
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

		// Token: 0x060427E1 RID: 272353 RVA: 0x01027B54 File Offset: 0x01025D54
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

		// Token: 0x04022A56 RID: 141910
		private UiBehaviorLevelSequence TipsSequence;

		// Token: 0x04022A57 RID: 141911
		private bool TipsWantVisible;

		// Token: 0x04022A58 RID: 141912
		private UUIItem KeepOpenItem;

		// Token: 0x04022A59 RID: 141913
		private UUIButtonComponent MaskButton;

		// Token: 0x04022A5A RID: 141914
		private bool MaskHeld;

		// Token: 0x04022A5B RID: 141915
		public Action OnTipsClosed;

		// Token: 0x0200C9AC RID: 51628
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CEA5 RID: 249509
			TxtTitle,
			// Token: 0x0403CEA6 RID: 249510
			TxtDesc
		}
	}
}
