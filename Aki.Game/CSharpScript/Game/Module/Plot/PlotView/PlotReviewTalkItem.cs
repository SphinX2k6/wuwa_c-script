using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200505D RID: 20573
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewTalkItem : UiPanelBase
	{
		// Token: 0x06034A4E RID: 215630 RVA: 0x00C709B0 File Offset: 0x00C6EBB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToggleClickInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034A4F RID: 215631 RVA: 0x00C70A98 File Offset: 0x00C6EC98
		protected override void OnStart()
		{
			base.GetExtendToggle(3).CanExecuteChange.Bind(new Func<bool>(this.CanToggleChangeInternal));
		}

		// Token: 0x06034A50 RID: 215632 RVA: 0x00C70AB7 File Offset: 0x00C6ECB7
		protected override void OnBeforeDestroy()
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
		}

		// Token: 0x06034A51 RID: 215633 RVA: 0x00C70ACA File Offset: 0x00C6ECCA
		private void OnToggleClickInternal(EToggleState toggleState)
		{
			Action<int> onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(this.Index);
		}

		// Token: 0x06034A52 RID: 215634 RVA: 0x00C70AE2 File Offset: 0x00C6ECE2
		private bool CanToggleChangeInternal()
		{
			return this.CanToggleChange == null || this.CanToggleChange(this.Index);
		}

		// Token: 0x06034A53 RID: 215635 RVA: 0x00C70B00 File Offset: 0x00C6ED00
		[NullableContext(1)]
		public void Update(PlotReviewTalkItemData data, int index)
		{
			UUIText text = base.GetText(1);
			if (TermExplanationController.Instance.IsUiTextRegistered(text))
			{
				TermExplanationController.Instance.UnRegisterTextHyperlink(text);
			}
			ITermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = text,
				ViewType = ETermExplanationViewType.Center,
				Group = new ETermExplanationGroup?(ETermExplanationGroup.PlotReview),
				Priority = new int?(index),
				ReportType = ETermExplanationReportType.PlotReview
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
			this.Data = data;
			this.Index = index;
			this.Refresh();
		}

		// Token: 0x06034A54 RID: 215636 RVA: 0x00C70B80 File Offset: 0x00C6ED80
		public void Refresh()
		{
			this.RefreshName();
			this.RefreshContent();
			this.RefreshAudio();
		}

		// Token: 0x06034A55 RID: 215637 RVA: 0x00C70B94 File Offset: 0x00C6ED94
		public void RefreshName()
		{
			PlotReviewTalkItemData data = this.Data;
			ITalkItemDialog talkItemDialog = ((data != null) ? data.TalkItem : null) as ITalkItemDialog;
			string text;
			if (talkItemDialog != null)
			{
				ETalkItemType? type = talkItemDialog.Type;
				ETalkItemType etalkItemType = ETalkItemType.Talk;
				if (type.GetValueOrDefault() == etalkItemType & type != null)
				{
					ITalkItemStyle style = talkItemDialog.Style;
					if (style != null && style.Type == ETalkItemStyle.InnerVoice)
					{
						text = ConfigMultiTextLang.GetLocalTextNew("PlotReview_3", null);
						goto IL_F8;
					}
				}
			}
			Speaker? config = ConfigSpeakerById.GetConfig(((talkItemDialog != null) ? talkItemDialog.WhoId : null).GetValueOrDefault(), true);
			string text2 = (config != null) ? PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(config.Value.Id)) : null;
			string text3 = (config != null) ? PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerTitle, new int?(config.Value.Id)) : null;
			text = (string.IsNullOrEmpty(text2) ? text3 : text2);
			IL_F8:
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PlotReview_1", new <>z__ReadOnlySingleElementList<object>(text ?? ""));
		}

		// Token: 0x06034A56 RID: 215638 RVA: 0x00C70CC0 File Offset: 0x00C6EEC0
		public void RefreshContent()
		{
			string tidTalk = this.Data.TalkItem.TidTalk;
			if (string.IsNullOrEmpty(tidTalk))
			{
				return;
			}
			string text = PublicUtil.Instance.GetFlowConfigLocalText(tidTalk);
			text = PlotModel.Instance.PlotTextReplacer.Replace(text, false);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			base.GetText(1).SetText(text, true);
		}

		// Token: 0x06034A57 RID: 215639 RVA: 0x00C70D1C File Offset: 0x00C6EF1C
		public void RefreshAudio()
		{
			ITalkItem talkItem = this.Data.TalkItem;
			this.CanPlayVoice = talkItem.PlayVoice.GetValueOrDefault();
			base.GetSprite(2).SetUIActive(this.CanPlayVoice);
			EToggleState toggleState = this.Data.IsPlaying ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.SetToggleState(toggleState);
		}

		// Token: 0x06034A58 RID: 215640 RVA: 0x00C70D74 File Offset: 0x00C6EF74
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(3).SetToggleState(state, false, false, false);
		}

		// Token: 0x0401C0EA RID: 114922
		protected int Index = -1;

		// Token: 0x0401C0EB RID: 114923
		private PlotReviewTalkItemData Data;

		// Token: 0x0401C0EC RID: 114924
		public Action<int> OnToggleClick;

		// Token: 0x0401C0ED RID: 114925
		public Func<int, bool> CanToggleChange;

		// Token: 0x0401C0EE RID: 114926
		private bool CanPlayVoice;
	}
}
