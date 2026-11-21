using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02004004 RID: 16388
	[NullableContext(1)]
	[Nullable(0)]
	public class QteManger
	{
		// Token: 0x060297C9 RID: 169929 RVA: 0x00BB5714 File Offset: 0x00BB3914
		public void HandlePlotQte(ITalkItem subtitle)
		{
			if (this.CurrentQte.Count > 0)
			{
				foreach (int qteHandle in this.CurrentQte.Keys)
				{
					CommonQteController.Instance.StopQte(qteHandle);
				}
				this.CurrentQte.Clear();
			}
			int num = FlowController.Instance.FlowSequence.OnQteStart(subtitle.Id);
			if (SequenceModel.Instance.IsMuteAllQte || SequenceModel.Instance.MuteQteList.Contains(num))
			{
				FlowController.Instance.FlowSequence.OnQteExecute(subtitle.Id, true);
				return;
			}
			CommonQteContextBase commonQteContextBase = CommonQteController.Instance.StartQte(num, new TCommonQteCallback(this.OnQteSuccess), new TCommonQteCallback(this.OnQteFail), EQteSource.Plot, null);
			if (commonQteContextBase == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[FlowSequence][PlotQte] Sequence Qte 失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			SCommonQte config = commonQteContextBase.Config;
			float playRate = (config != null) ? config.BaseConfig.TimeDilation : 1f;
			ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
			if (curLevelSeqActor != null)
			{
				ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.SetPlayRate(playRate);
				}
			}
			FlowController.Instance.EnableSkip(false);
			PlotController.Instance.PlotViewManager.EnableInteractPlot(false, new bool?(true), "PlotQte");
			this.CurrentQte[commonQteContextBase.HandleId] = subtitle.Id;
		}

		// Token: 0x060297CA RID: 169930 RVA: 0x00BB58A8 File Offset: 0x00BB3AA8
		public void HandlePlotQteEnd(int talkId)
		{
			FlowController.Instance.FlowSequence.OnQteEnd(talkId);
		}

		// Token: 0x060297CB RID: 169931 RVA: 0x00BB58BC File Offset: 0x00BB3ABC
		public void StopQte()
		{
			foreach (int qteHandle in this.CurrentQte.Keys)
			{
				CommonQteController.Instance.StopQte(qteHandle);
			}
			this.CurrentQte.Clear();
		}

		// Token: 0x060297CC RID: 169932 RVA: 0x00BB5924 File Offset: 0x00BB3B24
		[NullableContext(2)]
		private void OnQteSuccess(CommonQteContextBase context)
		{
			FlowController.Instance.FlowSequence.OnQteExecute(this.CurrentQte[context.HandleId], true);
			AudioSystem.Instance.PostEvent("plot_seq_qte_success");
			this.OnQteFinish(context);
		}

		// Token: 0x060297CD RID: 169933 RVA: 0x00BB595E File Offset: 0x00BB3B5E
		[NullableContext(2)]
		private void OnQteFail(CommonQteContextBase context)
		{
			FlowController.Instance.FlowSequence.OnQteExecute(this.CurrentQte.GetValueOrDefault(context.HandleId, 0), false);
			AudioSystem.Instance.PostEvent("plot_seq_qte_timeout");
			this.OnQteFinish(context);
		}

		// Token: 0x060297CE RID: 169934 RVA: 0x00BB599C File Offset: 0x00BB3B9C
		private void OnQteFinish(CommonQteContextBase context)
		{
			ALevelSequenceActor curLevelSeqActor = SequenceModel.Instance.CurLevelSeqActor;
			if (curLevelSeqActor != null)
			{
				ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.SetPlayRate(1f);
				}
			}
			AudioSystem.Instance.SetRtpcValue("plot_seq_qte_time_scale", 1f, null);
			FlowController.Instance.EnableSkip(true);
			PlotController.Instance.PlotViewManager.EnableInteractPlot(true, new bool?(true), "PlotQte");
			this.CurrentQte.Remove(context.HandleId);
		}

		// Token: 0x04016A2C RID: 92716
		private const string EnableInteractReason = "PlotQte";

		// Token: 0x04016A2D RID: 92717
		private const string EVENT_SUCCESS = "plot_seq_qte_success";

		// Token: 0x04016A2E RID: 92718
		private const string EVENT_FAIL = "plot_seq_qte_timeout";

		// Token: 0x04016A2F RID: 92719
		private readonly Dictionary<int, int> CurrentQte = new Dictionary<int, int>();
	}
}
