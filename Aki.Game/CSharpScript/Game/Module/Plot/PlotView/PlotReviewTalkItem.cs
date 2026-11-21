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
	// Token: 0x0200402D RID: 16429
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewTalkItem : UiPanelBase
	{
		// Token: 0x06029941 RID: 170305 RVA: 0x00BBDC50 File Offset: 0x00BBBE50
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

		// Token: 0x06029942 RID: 170306 RVA: 0x00BBDD38 File Offset: 0x00BBBF38
		protected override void OnStart()
		{
			base.GetExtendToggle(3).CanExecuteChange.Bind(new Func<bool>(this.CanToggleChangeInternal));
		}

		// Token: 0x06029943 RID: 170307 RVA: 0x00BBDD57 File Offset: 0x00BBBF57
		protected override void OnBeforeDestroy()
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
		}

		// Token: 0x06029944 RID: 170308 RVA: 0x00BBDD6A File Offset: 0x00BBBF6A
		private void OnToggleClickInternal(EToggleState toggleState)
		{
			Action<int> onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(this.Index);
		}

		// Token: 0x06029945 RID: 170309 RVA: 0x00BBDD82 File Offset: 0x00BBBF82
		private bool CanToggleChangeInternal()
		{
			return this.CanToggleChange == null || this.CanToggleChange(this.Index);
		}

		// Token: 0x06029946 RID: 170310 RVA: 0x00BBDDA0 File Offset: 0x00BBBFA0
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

		// Token: 0x06029947 RID: 170311 RVA: 0x00BBDE20 File Offset: 0x00BBC020
		public void Refresh()
		{
			this.RefreshName();
			this.RefreshContent();
			this.RefreshAudio();
		}

		// Token: 0x06029948 RID: 170312 RVA: 0x00BBDE34 File Offset: 0x00BBC034
		public void RefreshName()
		{
			UUIItem text = base.GetText(0);
			PlotReviewTalkItemData data = this.Data;
			text.SetUIActive(data == null || data.ShowSpeakerName);
			PlotReviewTalkItemData data2 = this.Data;
			if (data2 != null && !data2.ShowSpeakerName)
			{
				return;
			}
			PlotReviewTalkItemData data3 = this.Data;
			ITalkItem talkItem = (data3 != null) ? data3.TalkItem : null;
			ITalkItemDialog talkItemDialog = talkItem as ITalkItemDialog;
			string text2;
			if (talkItemDialog != null)
			{
				ETalkItemType? type = talkItemDialog.Type;
				ETalkItemType etalkItemType = ETalkItemType.Talk;
				if (type.GetValueOrDefault() == etalkItemType & type != null)
				{
					ITalkItemStyle style = talkItemDialog.Style;
					if (style != null && style.Type == ETalkItemStyle.InnerVoice)
					{
						text2 = ConfigMultiTextLang.GetLocalTextNew("PlotReview_3", null);
						goto IL_132;
					}
				}
			}
			Speaker? config = ConfigSpeakerById.GetConfig(((talkItem != null) ? talkItem.WhoId : null).GetValueOrDefault(), true);
			string text3 = (config != null) ? PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(config.Value.Id)) : null;
			string text4 = (config != null) ? PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerTitle, new int?(config.Value.Id)) : null;
			text2 = (string.IsNullOrEmpty(text3) ? text4 : text3);
			IL_132:
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PlotReview_1", new <>z__ReadOnlySingleElementList<object>(text2 ?? ""));
		}

		// Token: 0x06029949 RID: 170313 RVA: 0x00BBDF98 File Offset: 0x00BBC198
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

		// Token: 0x0602994A RID: 170314 RVA: 0x00BBDFF4 File Offset: 0x00BBC1F4
		public void RefreshAudio()
		{
			ITalkItem talkItem = this.Data.TalkItem;
			this.CanPlayVoice = talkItem.PlayVoice.GetValueOrDefault();
			base.GetSprite(2).SetUIActive(this.CanPlayVoice);
			EToggleState toggleState = this.Data.IsPlaying ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.SetToggleState(toggleState);
		}

		// Token: 0x0602994B RID: 170315 RVA: 0x00BBE04C File Offset: 0x00BBC24C
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(3).SetToggleState(state, false, false, false);
		}

		// Token: 0x04016B15 RID: 92949
		protected int Index = -1;

		// Token: 0x04016B16 RID: 92950
		private PlotReviewTalkItemData Data;

		// Token: 0x04016B17 RID: 92951
		public Action<int> OnToggleClick;

		// Token: 0x04016B18 RID: 92952
		public Func<int, bool> CanToggleChange;

		// Token: 0x04016B19 RID: 92953
		private bool CanPlayVoice;
	}
}
