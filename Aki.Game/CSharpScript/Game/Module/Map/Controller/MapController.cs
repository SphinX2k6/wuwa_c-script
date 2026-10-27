using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Controller
{
	// Token: 0x02005590 RID: 21904
	[NullableContext(1)]
	[Nullable(0)]
	public class MapController : ControllerWithAssistantBase
	{
		// Token: 0x06037D0D RID: 228621 RVA: 0x00D39B49 File Offset: 0x00D37D49
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			this.LineTraceSaver = new LineTraceSaver();
			this.RegisterAssistant();
			return result;
		}

		// Token: 0x06037D0E RID: 228622 RVA: 0x00D39B62 File Offset: 0x00D37D62
		protected override bool OnClear()
		{
			LineTraceSaver lineTraceSaver = this.LineTraceSaver;
			if (lineTraceSaver != null)
			{
				lineTraceSaver.OnClear();
			}
			this.LineTraceSaver = null;
			Dictionary<int, ControllerAssistantBase> assistants = this.Assistants;
			if (assistants != null)
			{
				assistants.Clear();
			}
			this.Assistants = null;
			return base.OnClear();
		}

		// Token: 0x06037D0F RID: 228623 RVA: 0x00D39B9C File Offset: 0x00D37D9C
		protected override void OnAddEvents()
		{
			base.OnAddEvents();
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
			EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		}

		// Token: 0x06037D10 RID: 228624 RVA: 0x00D39C04 File Offset: 0x00D37E04
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
			EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
			base.OnRemoveEvents();
		}

		// Token: 0x06037D11 RID: 228625 RVA: 0x00D39C6B File Offset: 0x00D37E6B
		protected override void RegisterAssistant()
		{
			this.Assistants = new Dictionary<int, ControllerAssistantBase>();
			this.Assistants[0] = new MarkAssistant();
			this.Assistants[1] = new TeleportAssistant();
			this.Assistants[2] = new AreaAssistant();
		}

		// Token: 0x06037D12 RID: 228626 RVA: 0x00D39CAC File Offset: 0x00D37EAC
		[NullableContext(0)]
		[return: Nullable(2)]
		private T GetAssistant<T>(MapController.EAssistantType type) where T : ControllerAssistantBase
		{
			if (this.Assistants == null)
			{
				return default(T);
			}
			ControllerAssistantBase controllerAssistantBase;
			if (this.Assistants.TryGetValue((int)type, out controllerAssistantBase))
			{
				return controllerAssistantBase as T;
			}
			return default(T);
		}

		// Token: 0x06037D13 RID: 228627 RVA: 0x00D39CF0 File Offset: 0x00D37EF0
		private void OnWorldDone()
		{
			this.WorldDoneRequest();
		}

		// Token: 0x06037D14 RID: 228628 RVA: 0x00D39CF9 File Offset: 0x00D37EF9
		private void ClearAllTrack()
		{
			TrackModel.Instance.ClearTrackData();
			MapModel.Instance.SetCurTrackMark(null);
		}

		// Token: 0x06037D15 RID: 228629 RVA: 0x00D39D10 File Offset: 0x00D37F10
		private void OnEnterOnlineWorld()
		{
			this.ClearAllTrack();
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestTrackInfo();
		}

		// Token: 0x06037D16 RID: 228630 RVA: 0x00D39D2A File Offset: 0x00D37F2A
		private void OnLeaveOnlineWorld()
		{
			this.ClearAllTrack();
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestTrackInfo();
		}

		// Token: 0x06037D17 RID: 228631 RVA: 0x00D39D44 File Offset: 0x00D37F44
		private UniTask WorldDoneRequest()
		{
			MapController.<WorldDoneRequest>d__15 <WorldDoneRequest>d__;
			<WorldDoneRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WorldDoneRequest>d__.<>4__this = this;
			<WorldDoneRequest>d__.<>1__state = -1;
			<WorldDoneRequest>d__.<>t__builder.Start<MapController.<WorldDoneRequest>d__15>(ref <WorldDoneRequest>d__);
			return <WorldDoneRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06037D18 RID: 228632 RVA: 0x00D39D88 File Offset: 0x00D37F88
		public UniTask RequestMapData()
		{
			MapController.<RequestMapData>d__16 <RequestMapData>d__;
			<RequestMapData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestMapData>d__.<>4__this = this;
			<RequestMapData>d__.<>1__state = -1;
			<RequestMapData>d__.<>t__builder.Start<MapController.<RequestMapData>d__16>(ref <RequestMapData>d__);
			return <RequestMapData>d__.<>t__builder.Task;
		}

		// Token: 0x06037D19 RID: 228633 RVA: 0x00D39DCB File Offset: 0x00D37FCB
		[NullableContext(2)]
		public Vector GetMarkPosition(double x, double y)
		{
			return this.LineTraceSaver.GetMarkPosition(x, y);
		}

		// Token: 0x06037D1A RID: 228634 RVA: 0x00D39DDC File Offset: 0x00D37FDC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<Vector, Vector2D>? GetNewCustomMarkPosition(double x, double y)
		{
			Vector markPosition = this.GetMarkPosition(x, y);
			if (markPosition == null)
			{
				return new OneOf<Vector, Vector2D>?(Vector2D.Create(x, -y));
			}
			IReadOnlyList<int> commonIntArray = WorldMapConfig.Instance.GetCommonIntArray("MarkCollisionRange");
			float num = (float)commonIntArray[0];
			float num2 = (float)commonIntArray[1];
			bool flag = markPosition.Z >= (double)num && markPosition.Z <= (double)num2;
			if (!flag)
			{
				return new OneOf<Vector, Vector2D>?(Vector2D.Create(x, -y));
			}
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "MapController.GetNewCustomMarkPosition()";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("自定义地图标记不在有效范围 Z轴坐标:", markPosition.Z);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return new OneOf<Vector, Vector2D>?(markPosition);
		}

		// Token: 0x06037D1B RID: 228635 RVA: 0x00D39E98 File Offset: 0x00D38098
		public void RequestMapMarkReplace(int markId, int configId)
		{
			this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark).RequestMapMarkReplace(markId, configId);
		}

		// Token: 0x06037D1C RID: 228636 RVA: 0x00D39EA8 File Offset: 0x00D380A8
		public void RequestCreateCustomMark(TTrackTarget trackPosition, int configId, [Nullable(2)] Action<bool> successCallBack = null)
		{
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestCreateCustomMark(trackPosition, configId, successCallBack);
		}

		// Token: 0x06037D1D RID: 228637 RVA: 0x00D39EC0 File Offset: 0x00D380C0
		public void RequestRemoveMapMarks(EMarkType markType, List<int> markIds)
		{
			TrackMapMarkParams curTrackMark = MapModel.Instance.GetCurTrackMark();
			foreach (int num in markIds)
			{
				if (curTrackMark != null && curTrackMark.MarkType == markType && curTrackMark.MarkId == num)
				{
					MapModel.Instance.SetCurTrackMark(null);
				}
			}
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestRemoveMapMarks(markType, markIds);
		}

		// Token: 0x06037D1E RID: 228638 RVA: 0x00D39F48 File Offset: 0x00D38148
		public void RequestTrackMapMark(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack = null)
		{
			if (@params.TrackMode == null)
			{
				if (@params.MarkType == EMarkType.Custom || MapConfig.Instance.GetConfigMark(@params.MarkId) != null)
				{
					@params.TrackMode = new ETrackMapMarkMode?(ETrackMapMarkMode.Remote);
				}
				else
				{
					@params.TrackMode = new ETrackMapMarkMode?(ETrackMapMarkMode.Local);
				}
			}
			if (@params.Track)
			{
				this.HandleUnTrackCurrent(@params);
				if (@params.TrackMode.GetValueOrDefault() == ETrackMapMarkMode.Remote)
				{
					this.HandleRemoteTrack(@params, resultCallBack);
					return;
				}
				this.HandleLocalTrack(@params, resultCallBack);
				return;
			}
			else
			{
				if (@params.TrackMode.GetValueOrDefault() == ETrackMapMarkMode.Remote)
				{
					this.HandleRemoteUnTrack(@params, resultCallBack);
					return;
				}
				this.HandleLocalUnTrack(@params, resultCallBack);
				return;
			}
		}

		// Token: 0x06037D1F RID: 228639 RVA: 0x00D39FF0 File Offset: 0x00D381F0
		private void HandleUnTrackCurrent(TrackMapMarkParams newTrackParams)
		{
			TrackMapMarkParams curTrackMark = MapModel.Instance.GetCurTrackMark();
			if (curTrackMark != null && (curTrackMark.MarkType != newTrackParams.MarkType || curTrackMark.MarkId != newTrackParams.MarkId))
			{
				if (curTrackMark.TrackMode.GetValueOrDefault() == ETrackMapMarkMode.Remote)
				{
					this.HandleRemoteUnTrack(curTrackMark, null);
					return;
				}
				this.HandleLocalUnTrack(curTrackMark, null);
			}
		}

		// Token: 0x06037D20 RID: 228640 RVA: 0x00D3A046 File Offset: 0x00D38246
		private void HandleRemoteTrack(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack = null)
		{
			this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark).RequestTrackMapMark(@params.MarkType, @params.MarkId, resultCallBack);
			MapModel.Instance.SetCurTrackMark(@params);
		}

		// Token: 0x06037D21 RID: 228641 RVA: 0x00D3A06C File Offset: 0x00D3826C
		private void HandleLocalTrack(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack)
		{
			MapModel.Instance.SetCurTrackMark(@params);
			MapModel.Instance.SetTrackMark(@params.MarkType, @params.MarkId, @params.Track);
			if (resultCallBack != null)
			{
				resultCallBack(ETrackMapMarkResultType.Success, true);
			}
		}

		// Token: 0x06037D22 RID: 228642 RVA: 0x00D3A0A0 File Offset: 0x00D382A0
		private void HandleRemoteUnTrack(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack = null)
		{
			MapModel.Instance.SetCurTrackMark(null);
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestCancelTrackMapMark(@params.MarkType, @params.MarkId, resultCallBack);
		}

		// Token: 0x06037D23 RID: 228643 RVA: 0x00D3A0CB File Offset: 0x00D382CB
		private void HandleLocalUnTrack(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack = null)
		{
			MapModel.Instance.SetCurTrackMark(null);
			MapModel.Instance.SetTrackMark(@params.MarkType, @params.MarkId, false);
			if (resultCallBack != null)
			{
				resultCallBack(ETrackMapMarkResultType.Success, false);
			}
		}

		// Token: 0x06037D24 RID: 228644 RVA: 0x00D3A0FA File Offset: 0x00D382FA
		public void UpdateCustomMapMarkPosition(int markId, Vector markPos)
		{
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.UpdateCustomMapMarkPosition(markId, markPos);
		}

		// Token: 0x06037D25 RID: 228645 RVA: 0x00D3A10F File Offset: 0x00D3830F
		public void RequestTrackEnrichmentArea(int? itemId = null)
		{
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestTrackEnrichmentArea(itemId, null);
		}

		// Token: 0x06037D26 RID: 228646 RVA: 0x00D3A124 File Offset: 0x00D38324
		[NullableContext(2)]
		public void RequestTeleportToTargetByTemporaryTeleport(int teleportId, TOnTelSuccessCallBack successAction = null)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return;
			}
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			if (component == null)
			{
				return;
			}
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestTeleportToTargetByTemporaryTeleport(teleportId, Rotator.Create(component.ActorRotationProxy), successAction);
		}

		// Token: 0x06037D27 RID: 228647 RVA: 0x00D3A17C File Offset: 0x00D3837C
		public void ForceSetMarkVisible(EMarkType markType, int markId, bool visible)
		{
			MapModel.Instance.ForceSetMarkVisible(markType, markId, visible);
			EventSystem.Instance.Emit<EMarkType, int, bool>(EEventName.MarkForceVisibleChanged, markType, markId, visible);
		}

		// Token: 0x06037D28 RID: 228648 RVA: 0x00D3A19E File Offset: 0x00D3839E
		[NullableContext(2)]
		public void OpenMapViewAndFocusMark(EMarkType markType, int markId, Action<bool, int> callback = null, bool isFocusTween = true, float startScale = 1f)
		{
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.OpenMapViewAndFocus(markType, markId, callback, isFocusTween, startScale, false);
		}

		// Token: 0x1700866A RID: 34410
		// (get) Token: 0x06037D29 RID: 228649 RVA: 0x00D3A1B9 File Offset: 0x00D383B9
		public static MapController Instance
		{
			get
			{
				return MapController._Instance;
			}
		}

		// Token: 0x06037D2A RID: 228650 RVA: 0x00D3A1C0 File Offset: 0x00D383C0
		public static MapController GetOrCreateInstance()
		{
			if (MapController._Instance == null)
			{
				MapController.CreateInstance();
			}
			return MapController._Instance;
		}

		// Token: 0x06037D2B RID: 228651 RVA: 0x00D3A1D4 File Offset: 0x00D383D4
		public static bool CreateInstance()
		{
			if (MapController._Instance != null)
			{
				return true;
			}
			MapController._Instance = new MapController();
			return true;
		}

		// Token: 0x06037D2C RID: 228652 RVA: 0x00D3A1EA File Offset: 0x00D383EA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037D2D RID: 228653 RVA: 0x00D3A1EC File Offset: 0x00D383EC
		public static void ResetStaticDefaultValue()
		{
			MapController._Instance = null;
		}

		// Token: 0x06037D2E RID: 228654 RVA: 0x00D3A1F4 File Offset: 0x00D383F4
		static MapController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapController.CreateStaticDefaultValue), new Action(MapController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D565 RID: 120165
		public const int SCALE_XY = 100;

		// Token: 0x0401D566 RID: 120166
		public const int SCALE_Z = 1000000;

		// Token: 0x0401D567 RID: 120167
		public const string PROFILE_KEY = "WorldMapView_CreateNewCustomMarkItem";

		// Token: 0x0401D568 RID: 120168
		[Nullable(2)]
		private LineTraceSaver LineTraceSaver;

		// Token: 0x0401D569 RID: 120169
		[Nullable(2)]
		private static MapController _Instance;

		// Token: 0x0200B77A RID: 46970
		[NullableContext(0)]
		public enum EAssistantType
		{
			// Token: 0x040378B7 RID: 227511
			Mark,
			// Token: 0x040378B8 RID: 227512
			Teleport,
			// Token: 0x040378B9 RID: 227513
			Area
		}
	}
}
