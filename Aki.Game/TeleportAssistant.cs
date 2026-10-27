using System;
using System.Linq;
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

// Token: 0x020021F1 RID: 8689
[NullableContext(1)]
[Nullable(0)]
public class TeleportAssistant : ControllerAssistantBase
{
	// Token: 0x06010E85 RID: 69253 RVA: 0x0041D05A File Offset: 0x0041B25A
	protected override void OnDestroy()
	{
		this.CurrentSequenceConfig = null;
		this.CurFlowListName = "";
		this.CurFlowId = 0;
		this.IsGmUnlockAll = false;
		this.IsInPlot = false;
	}

	// Token: 0x06010E86 RID: 69254 RVA: 0x0041D088 File Offset: 0x0041B288
	public override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TeleportUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTeleportUpdateNotify));
	}

	// Token: 0x06010E87 RID: 69255 RVA: 0x0041D0A6 File Offset: 0x0041B2A6
	public override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TeleportUpdateNotify);
	}

	// Token: 0x06010E88 RID: 69256 RVA: 0x0041D0B8 File Offset: 0x0041B2B8
	public override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		EventSystem.Instance.Add(EEventName.OnExecuteServerGm, new Action<string>(this.OnExecuteServerGm));
	}

	// Token: 0x06010E89 RID: 69257 RVA: 0x0041D0F2 File Offset: 0x0041B2F2
	public override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
		EventSystem.Instance.Remove(EEventName.OnExecuteServerGm, new Action<string>(this.OnExecuteServerGm));
	}

	// Token: 0x06010E8A RID: 69258 RVA: 0x0041D12C File Offset: 0x0041B32C
	[NullableContext(2)]
	private void OnTeleportUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		int[] array = ((TeleportUpdateNotify)msg).Ids.ToArray<int>();
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

	// Token: 0x06010E8B RID: 69259 RVA: 0x0041D194 File Offset: 0x0041B394
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

	// Token: 0x06010E8C RID: 69260 RVA: 0x0041D251 File Offset: 0x0041B451
	private void OnWorldMapViewOpened()
	{
		LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "BlackScreenFadeOnPlotToWorldMap", delegate
		{
			EventSystem.Instance.Emit(EEventName.BlackScreenFadeOnPlotToWorldMap);
		}, new float?((float)1));
	}

	// Token: 0x06010E8D RID: 69261 RVA: 0x0041D28C File Offset: 0x0041B48C
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

	// Token: 0x06010E8E RID: 69262 RVA: 0x0041D3ED File Offset: 0x0041B5ED
	private void OnExecuteServerGm(string gm)
	{
		if (gm.ToLower() != "activateteleport 0")
		{
			return;
		}
		this.IsGmUnlockAll = true;
	}

	// Token: 0x06010E8F RID: 69263 RVA: 0x0041D40C File Offset: 0x0041B60C
	public UniTask RequestTeleportData()
	{
		TeleportAssistant.<RequestTeleportData>d__16 <RequestTeleportData>d__;
		<RequestTeleportData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestTeleportData>d__.<>1__state = -1;
		<RequestTeleportData>d__.<>t__builder.Start<TeleportAssistant.<RequestTeleportData>d__16>(ref <RequestTeleportData>d__);
		return <RequestTeleportData>d__.<>t__builder.Task;
	}

	// Token: 0x0400807F RID: 32895
	private const string GM_UNLOCK_ALL_TELEPORT = "activateteleport 0";

	// Token: 0x04008080 RID: 32896
	private Teleporter? CurrentSequenceConfig;

	// Token: 0x04008081 RID: 32897
	private string CurFlowListName = "";

	// Token: 0x04008082 RID: 32898
	private int CurFlowId;

	// Token: 0x04008083 RID: 32899
	private bool IsGmUnlockAll;

	// Token: 0x04008084 RID: 32900
	private bool IsInPlot;
}
