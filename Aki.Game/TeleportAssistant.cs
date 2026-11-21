using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x020016D5 RID: 5845
[NullableContext(1)]
[Nullable(0)]
public class TeleportAssistant : ControllerAssistantBase
{
	// Token: 0x0600E318 RID: 58136 RVA: 0x004299EE File Offset: 0x00427BEE
	protected override void OnDestroy()
	{
		this.CurrentSequenceConfig = null;
		this.CurFlowListName = "";
		this.CurFlowId = 0;
		this.IsGmUnlockAll = false;
		this.IsInPlot = false;
	}

	// Token: 0x0600E319 RID: 58137 RVA: 0x00429A1C File Offset: 0x00427C1C
	public override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TeleportUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTeleportUpdateNotify));
	}

	// Token: 0x0600E31A RID: 58138 RVA: 0x00429A3A File Offset: 0x00427C3A
	public override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TeleportUpdateNotify);
	}

	// Token: 0x0600E31B RID: 58139 RVA: 0x00429A4C File Offset: 0x00427C4C
	public override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		EventSystem.Instance.Add(EEventName.OnExecuteServerGm, new Action<string>(this.OnExecuteServerGm));
	}

	// Token: 0x0600E31C RID: 58140 RVA: 0x00429A86 File Offset: 0x00427C86
	public override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		EventSystem.Instance.Remove(EEventName.OnExecuteServerGm, new Action<string>(this.OnExecuteServerGm));
	}

	// Token: 0x0600E31D RID: 58141 RVA: 0x00429AC0 File Offset: 0x00427CC0
	[NullableContext(2)]
	private void OnTeleportUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> ids = ((TeleportUpdateNotify)msg).Ids;
		int[] array = new int[ids.Count];
		ids.CopyTo(array, 0);
		MapModel.Instance.UnlockTeleports(array, false);
		if (GameModeModel.Instance.IsMulti)
		{
			int? id = PlayerInfoModel.Instance.GetId();
			int worldOwner = CreatureModel.Instance.GetWorldOwner();
			if (!(id.GetValueOrDefault() == worldOwner & id != null))
			{
				return;
			}
		}
		this.PlaySequenceOnUnlockNewTeleport(array);
	}

	// Token: 0x0600E31E RID: 58142 RVA: 0x00429B38 File Offset: 0x00427D38
	private void PlaySequenceOnUnlockNewTeleport(int[] teleportIds)
	{
		if (this.IsGmUnlockAll)
		{
			return;
		}
		if (this.IsInPlot)
		{
			return;
		}
		if (teleportIds.Length == 0)
		{
			return;
		}
		Teleporter? teleportConfigById = MapConfig.Instance.GetTeleportConfigById(teleportIds[0]);
		if (teleportConfigById == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(teleportConfigById.Value.Plot))
		{
			string[] array = teleportConfigById.Value.Plot.Split(',', StringSplitOptions.None);
			if (array.Length > 2)
			{
				this.CurFlowListName = array[0];
				this.CurFlowId = int.Parse(array[1]);
				int stateId = int.Parse(array[2]);
				this.CurrentSequenceConfig = teleportConfigById;
				this.IsInPlot = true;
				FlowController.Instance.StartFlow(this.CurFlowListName, this.CurFlowId, stateId, null, 0L, false, false, false, null);
			}
		}
	}

	// Token: 0x0600E31F RID: 58143 RVA: 0x00429BF5 File Offset: 0x00427DF5
	private void OnWorldMapViewOpened()
	{
		LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "BlackScreenFadeOnPlotToWorldMap", delegate
		{
			EventSystem.Instance.Emit(EEventName.BlackScreenFadeOnPlotToWorldMap);
		}, new float?((float)1));
	}

	// Token: 0x0600E320 RID: 58144 RVA: 0x00429C30 File Offset: 0x00427E30
	private void OnPlotNetworkEnd(PlotResultInfo plotResult)
	{
		if (!(plotResult.FlowListName != this.CurFlowListName))
		{
			int? flowId = plotResult.FlowId;
			int curFlowId = this.CurFlowId;
			if (flowId.GetValueOrDefault() == curFlowId & flowId != null)
			{
				this.IsInPlot = false;
				ETeleportType type = (ETeleportType)this.CurrentSequenceConfig.Value.Type;
				if (type != ETeleportType.BigTeleport)
				{
					if (type != ETeleportType.SmallTeleport)
					{
					}
					ScrollingTipsController.Instance.ShowTipsById("TeleporterUnlock", Array.Empty<object>());
				}
				else
				{
					ScrollingTipsController.Instance.ShowTipsById("TeleporterUnlockBig", Array.Empty<object>());
				}
				WorldMapViewOpenParams data = new WorldMapViewOpenParams
				{
					MarkType = EMarkType.None,
					MarkId = new int?(0),
					OpenFogId = new int?(this.CurrentSequenceConfig.Value.FogId)
				};
				if (this.CurrentSequenceConfig.Value.ShowWorldMap)
				{
					EventSystem.Instance.Once(EEventName.WorldMapViewOpened, new Action(this.OnWorldMapViewOpened));
					WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
				}
				else
				{
					LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "TeleportAssistant_PlotEnd", delegate
					{
					}, new float?((float)1));
				}
				this.CurFlowListName = "";
				this.CurFlowId = 0;
				this.CurrentSequenceConfig = null;
				return;
			}
		}
	}

	// Token: 0x0600E321 RID: 58145 RVA: 0x00429D91 File Offset: 0x00427F91
	private void OnExecuteServerGm(string gm)
	{
		if (gm.ToLower() != "activateteleport 0")
		{
			return;
		}
		this.IsGmUnlockAll = true;
	}

	// Token: 0x0600E322 RID: 58146 RVA: 0x00429DB0 File Offset: 0x00427FB0
	public UniTask RequestTeleportData()
	{
		TeleportAssistant.<RequestTeleportData>d__16 <RequestTeleportData>d__;
		<RequestTeleportData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestTeleportData>d__.<>1__state = -1;
		<RequestTeleportData>d__.<>t__builder.Start<TeleportAssistant.<RequestTeleportData>d__16>(ref <RequestTeleportData>d__);
		return <RequestTeleportData>d__.<>t__builder.Task;
	}

	// Token: 0x040081BD RID: 33213
	private const string GM_UNLOCK_ALL_TELEPORT = "activateteleport 0";

	// Token: 0x040081BE RID: 33214
	private Teleporter? CurrentSequenceConfig;

	// Token: 0x040081BF RID: 33215
	private string CurFlowListName = "";

	// Token: 0x040081C0 RID: 33216
	private int CurFlowId;

	// Token: 0x040081C1 RID: 33217
	private bool IsGmUnlockAll;

	// Token: 0x040081C2 RID: 33218
	private bool IsInPlot;
}
