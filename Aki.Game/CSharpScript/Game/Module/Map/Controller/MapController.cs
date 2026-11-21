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
	// Token: 0x02004566 RID: 17766
	[NullableContext(1)]
	[Nullable(0)]
	public class MapController : ControllerWithAssistantBase
	{
		// Token: 0x0602CC0B RID: 183307 RVA: 0x00C87811 File Offset: 0x00C85A11
		protected override bool OnInit()
		{
			bool result = base.OnInit();
			this.LineTraceSaver = new LineTraceSaver();
			this.RegisterAssistant();
			return result;
		}

		// Token: 0x0602CC0C RID: 183308 RVA: 0x00C8782A File Offset: 0x00C85A2A
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

		// Token: 0x0602CC0D RID: 183309 RVA: 0x00C87864 File Offset: 0x00C85A64
		protected override void OnAddEvents()
		{
			base.OnAddEvents();
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
			EventSystem.Instance.Add(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
		}

		// Token: 0x0602CC0E RID: 183310 RVA: 0x00C878CC File Offset: 0x00C85ACC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
			EventSystem.Instance.Remove(EEventName.OnLeaveOnlineWorld, new Action(this.OnLeaveOnlineWorld));
			base.OnRemoveEvents();
		}

		// Token: 0x0602CC0F RID: 183311 RVA: 0x00C87933 File Offset: 0x00C85B33
		protected override void RegisterAssistant()
		{
			this.Assistants = new Dictionary<int, ControllerAssistantBase>();
			this.Assistants[0] = new MarkAssistant();
			this.Assistants[1] = new TeleportAssistant();
			this.Assistants[2] = new AreaAssistant();
		}

		// Token: 0x0602CC10 RID: 183312 RVA: 0x00C87974 File Offset: 0x00C85B74
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

		// Token: 0x0602CC11 RID: 183313 RVA: 0x00C879B8 File Offset: 0x00C85BB8
		private void OnWorldDone()
		{
			this.WorldDoneRequest();
		}

		// Token: 0x0602CC12 RID: 183314 RVA: 0x00C879C1 File Offset: 0x00C85BC1
		private void ClearAllTrack()
		{
			TrackModel.Instance.ClearTrackData();
			MapModel.Instance.SetCurTrackMark(null);
		}

		// Token: 0x0602CC13 RID: 183315 RVA: 0x00C879D8 File Offset: 0x00C85BD8
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

		// Token: 0x0602CC14 RID: 183316 RVA: 0x00C879F2 File Offset: 0x00C85BF2
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

		// Token: 0x0602CC15 RID: 183317 RVA: 0x00C87A0C File Offset: 0x00C85C0C
		private UniTask WorldDoneRequest()
		{
			MapController.<WorldDoneRequest>d__15 <WorldDoneRequest>d__;
			<WorldDoneRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WorldDoneRequest>d__.<>4__this = this;
			<WorldDoneRequest>d__.<>1__state = -1;
			<WorldDoneRequest>d__.<>t__builder.Start<MapController.<WorldDoneRequest>d__15>(ref <WorldDoneRequest>d__);
			return <WorldDoneRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0602CC16 RID: 183318 RVA: 0x00C87A50 File Offset: 0x00C85C50
		public UniTask RequestMapData()
		{
			MapController.<RequestMapData>d__16 <RequestMapData>d__;
			<RequestMapData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestMapData>d__.<>4__this = this;
			<RequestMapData>d__.<>1__state = -1;
			<RequestMapData>d__.<>t__builder.Start<MapController.<RequestMapData>d__16>(ref <RequestMapData>d__);
			return <RequestMapData>d__.<>t__builder.Task;
		}

		// Token: 0x0602CC17 RID: 183319 RVA: 0x00C87A93 File Offset: 0x00C85C93
		[NullableContext(2)]
		public Vector GetMarkPosition(double x, double y)
		{
			return this.LineTraceSaver.GetMarkPosition(x, y);
		}

		// Token: 0x0602CC18 RID: 183320 RVA: 0x00C87AA4 File Offset: 0x00C85CA4
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

		// Token: 0x0602CC19 RID: 183321 RVA: 0x00C87B60 File Offset: 0x00C85D60
		public void RequestMapMarkReplace(int markId, int configId)
		{
			this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark).RequestMapMarkReplace(markId, configId);
		}

		// Token: 0x0602CC1A RID: 183322 RVA: 0x00C87B70 File Offset: 0x00C85D70
		public void RequestCreateCustomMark(TTrackTarget trackPosition, int configId, [Nullable(2)] Action<bool> successCallBack = null)
		{
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestCreateCustomMark(trackPosition, configId, successCallBack);
		}

		// Token: 0x0602CC1B RID: 183323 RVA: 0x00C87B88 File Offset: 0x00C85D88
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

		// Token: 0x0602CC1C RID: 183324 RVA: 0x00C87C10 File Offset: 0x00C85E10
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

		// Token: 0x0602CC1D RID: 183325 RVA: 0x00C87CB8 File Offset: 0x00C85EB8
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

		// Token: 0x0602CC1E RID: 183326 RVA: 0x00C87D0E File Offset: 0x00C85F0E
		private void HandleRemoteTrack(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack = null)
		{
			this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark).RequestTrackMapMark(@params.MarkType, @params.MarkId, resultCallBack);
			MapModel.Instance.SetCurTrackMark(@params);
		}

		// Token: 0x0602CC1F RID: 183327 RVA: 0x00C87D34 File Offset: 0x00C85F34
		private void HandleLocalTrack(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack)
		{
			MapModel.Instance.SetCurTrackMark(@params);
			MapModel.Instance.SetTrackMark(@params.MarkType, @params.MarkId, @params.Track);
			if (resultCallBack != null)
			{
				resultCallBack(ETrackMapMarkResultType.Success, true);
			}
		}

		// Token: 0x0602CC20 RID: 183328 RVA: 0x00C87D68 File Offset: 0x00C85F68
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

		// Token: 0x0602CC21 RID: 183329 RVA: 0x00C87D93 File Offset: 0x00C85F93
		private void HandleLocalUnTrack(TrackMapMarkParams @params, [Nullable(2)] Action<ETrackMapMarkResultType, bool> resultCallBack = null)
		{
			MapModel.Instance.SetCurTrackMark(null);
			MapModel.Instance.SetTrackMark(@params.MarkType, @params.MarkId, false);
			if (resultCallBack != null)
			{
				resultCallBack(ETrackMapMarkResultType.Success, false);
			}
		}

		// Token: 0x0602CC22 RID: 183330 RVA: 0x00C87DC2 File Offset: 0x00C85FC2
		public void UpdateCustomMapMarkPosition(int markId, Vector markPos)
		{
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.UpdateCustomMapMarkPosition(markId, markPos);
		}

		// Token: 0x0602CC23 RID: 183331 RVA: 0x00C87DD7 File Offset: 0x00C85FD7
		public void RequestTrackEnrichmentArea(int? itemId = null)
		{
			MarkAssistant assistant = this.GetAssistant<MarkAssistant>(MapController.EAssistantType.Mark);
			if (assistant == null)
			{
				return;
			}
			assistant.RequestTrackEnrichmentArea(itemId, null);
		}

		// Token: 0x0602CC24 RID: 183332 RVA: 0x00C87DEC File Offset: 0x00C85FEC
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

		// Token: 0x0602CC25 RID: 183333 RVA: 0x00C87E44 File Offset: 0x00C86044
		public void ForceSetMarkVisible(EMarkType markType, int markId, bool visible)
		{
			MapModel.Instance.ForceSetMarkVisible(markType, markId, visible);
			EventSystem.Instance.Emit<EMarkType, int, bool>(EEventName.MarkForceVisibleChanged, markType, markId, visible);
		}

		// Token: 0x0602CC26 RID: 183334 RVA: 0x00C87E66 File Offset: 0x00C86066
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

		// Token: 0x17005A31 RID: 23089
		// (get) Token: 0x0602CC27 RID: 183335 RVA: 0x00C87E81 File Offset: 0x00C86081
		public static MapController Instance
		{
			get
			{
				return MapController._Instance;
			}
		}

		// Token: 0x0602CC28 RID: 183336 RVA: 0x00C87E88 File Offset: 0x00C86088
		public static MapController GetOrCreateInstance()
		{
			if (MapController._Instance == null)
			{
				MapController.CreateInstance();
			}
			return MapController._Instance;
		}

		// Token: 0x0602CC29 RID: 183337 RVA: 0x00C87E9C File Offset: 0x00C8609C
		public static bool CreateInstance()
		{
			if (MapController._Instance != null)
			{
				return true;
			}
			MapController._Instance = new MapController();
			return true;
		}

		// Token: 0x0602CC2A RID: 183338 RVA: 0x00C87EB2 File Offset: 0x00C860B2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602CC2B RID: 183339 RVA: 0x00C87EB4 File Offset: 0x00C860B4
		public static void ResetStaticDefaultValue()
		{
			MapController._Instance = null;
		}

		// Token: 0x0602CC2C RID: 183340 RVA: 0x00C87EBC File Offset: 0x00C860BC
		static MapController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapController.CreateStaticDefaultValue), new Action(MapController.ResetStaticDefaultValue));
		}

		// Token: 0x04017FF0 RID: 98288
		public const int SCALE_XY = 100;

		// Token: 0x04017FF1 RID: 98289
		public const int SCALE_Z = 1000000;

		// Token: 0x04017FF2 RID: 98290
		public const string PROFILE_KEY = "WorldMapView_CreateNewCustomMarkItem";

		// Token: 0x04017FF3 RID: 98291
		[Nullable(2)]
		private LineTraceSaver LineTraceSaver;

		// Token: 0x04017FF4 RID: 98292
		[Nullable(2)]
		private static MapController _Instance;

		// Token: 0x0200A1A5 RID: 41381
		[NullableContext(0)]
		public enum EAssistantType
		{
			// Token: 0x040322E2 RID: 205538
			Mark,
			// Token: 0x040322E3 RID: 205539
			Teleport,
			// Token: 0x040322E4 RID: 205540
			Area
		}
	}
}
