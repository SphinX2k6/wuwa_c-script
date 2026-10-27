using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02005037 RID: 20535
	[NullableContext(1)]
	[Nullable(0)]
	public class QteManger
	{
		// Token: 0x0603490B RID: 215307 RVA: 0x00C69284 File Offset: 0x00C67484
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

		// Token: 0x0603490C RID: 215308 RVA: 0x00C69418 File Offset: 0x00C67618
		public void HandlePlotQteEnd(int talkId)
		{
			FlowController.Instance.FlowSequence.OnQteEnd(talkId);
		}

		// Token: 0x0603490D RID: 215309 RVA: 0x00C6942C File Offset: 0x00C6762C
		public void StopQte()
		{
			foreach (int qteHandle in this.CurrentQte.Keys)
			{
				CommonQteController.Instance.StopQte(qteHandle);
			}
			this.CurrentQte.Clear();
		}

		// Token: 0x0603490E RID: 215310 RVA: 0x00C69494 File Offset: 0x00C67694
		[NullableContext(2)]
		private void OnQteSuccess(CommonQteContextBase context)
		{
			FlowController.Instance.FlowSequence.OnQteExecute(this.CurrentQte[context.HandleId], true);
			AudioSystem.Instance.PostEvent("plot_seq_qte_success");
			this.OnQteFinish(context);
		}

		// Token: 0x0603490F RID: 215311 RVA: 0x00C694CE File Offset: 0x00C676CE
		[NullableContext(2)]
		private void OnQteFail(CommonQteContextBase context)
		{
			FlowController.Instance.FlowSequence.OnQteExecute(this.CurrentQte.GetValueOrDefault(context.HandleId, 0), false);
			AudioSystem.Instance.PostEvent("plot_seq_qte_timeout");
			this.OnQteFinish(context);
		}

		// Token: 0x06034910 RID: 215312 RVA: 0x00C6950C File Offset: 0x00C6770C
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

		// Token: 0x0401C021 RID: 114721
		private const string EnableInteractReason = "PlotQte";

		// Token: 0x0401C022 RID: 114722
		private const string EVENT_SUCCESS = "plot_seq_qte_success";

		// Token: 0x0401C023 RID: 114723
		private const string EVENT_FAIL = "plot_seq_qte_timeout";

		// Token: 0x0401C024 RID: 114724
		private readonly Dictionary<int, int> CurrentQte = new Dictionary<int, int>();
	}
}
