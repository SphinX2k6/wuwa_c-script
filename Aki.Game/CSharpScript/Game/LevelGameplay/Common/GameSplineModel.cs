using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x02006F1E RID: 28446
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GameSplineModel : ModelBase
	{
		// Token: 0x06045394 RID: 283540 RVA: 0x011215A0 File Offset: 0x0111F7A0
		private void CheckAndReleaseActor(float _)
		{
			foreach (KeyValuePair<int, ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>>> keyValuePair in this.ActorMaps)
			{
				int key = keyValuePair.Key;
				ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>> value = keyValuePair.Value;
				foreach (ActorId actorId in value.Item3)
				{
					switch (actorId.Type)
					{
					case EIdType.PbDataId:
						if (CreatureModel.Instance.GetEntityByPbDataId(actorId.Id) == null)
						{
							value.Item3.Remove(actorId);
						}
						break;
					case EIdType.EntityId:
						if (EntitySystem.Instance.Get(actorId.Id) == null)
						{
							value.Item3.Remove(actorId);
						}
						break;
					case EIdType.SimpleCombatId:
						if (TowerDefenseEventModel.Instance.GetEntity((long)actorId.Id) == null)
						{
							KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
							if (curSubModel == null || !curSubModel.IsCreatureIdValid(actorId.Id))
							{
								value.Item3.Remove(actorId);
							}
						}
						break;
					case EIdType.SimpleCombatPreviewId:
						if (!TowerDefenseEventController.Instance.IsInPreview())
						{
							value.Item3.Remove(actorId);
						}
						break;
					}
				}
				if (value.Item3.Count == 0)
				{
					ActorSystem.Instance.Put("GameSplineModel.CheckAndReleaseActor", value.Item1, null);
					this.ActorMaps.Remove(key);
				}
			}
			if (this.ActorMaps.Count == 0 && this.Timer != null)
			{
				TimerSystem.Instance.Remove(this.Timer);
				this.Timer = null;
			}
		}

		// Token: 0x06045395 RID: 283541 RVA: 0x0112178C File Offset: 0x0111F98C
		public USplineComponent LoadAndGetSplineComponent(int splineId, int id, EIdType idType = EIdType.PbDataId)
		{
			ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>> value;
			ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>>? valueTuple;
			if (!this.ActorMaps.TryGetValue(splineId, out value))
			{
				TsGameSplineActor tsGameSplineActor = ActorSystem.Instance.Get(TsGameSplineActor.StaticClass(), new FTransformDouble(), null, true) as TsGameSplineActor;
				valueTuple = new ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>>?(new ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>>(tsGameSplineActor, GameSplineUtils.InitGameSplineBySplineEntity(splineId, tsGameSplineActor), new HashSet<ActorId>()));
				this.ActorMaps[splineId] = valueTuple.Value;
				if (this.Timer == null)
				{
					this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.CheckAndReleaseActor), 5000f, 1f, null, null, true);
				}
			}
			else
			{
				valueTuple = new ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>>?(value);
			}
			valueTuple.Value.Item3.Add(new ActorId(id, idType));
			return valueTuple.Value.Item2;
		}

		// Token: 0x06045396 RID: 283542 RVA: 0x01121854 File Offset: 0x0111FA54
		[NullableContext(2)]
		public TsGameSplineActor GetSplineActorBySplineId(int splineId)
		{
			ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>> valueTuple;
			if (!this.ActorMaps.TryGetValue(splineId, out valueTuple))
			{
				return null;
			}
			return valueTuple.Item1;
		}

		// Token: 0x06045397 RID: 283543 RVA: 0x0112187C File Offset: 0x0111FA7C
		public void ReleaseSpline(int splineId, long id, EIdType idType = EIdType.PbDataId)
		{
			ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>> valueTuple;
			if (!this.ActorMaps.TryGetValue(splineId, out valueTuple))
			{
				return;
			}
			foreach (ActorId actorId in valueTuple.Item3)
			{
				if ((long)actorId.Id == id && actorId.Type == idType)
				{
					valueTuple.Item3.Remove(actorId);
				}
			}
		}

		// Token: 0x17009B08 RID: 39688
		// (get) Token: 0x06045398 RID: 283544 RVA: 0x011218FC File Offset: 0x0111FAFC
		public static GameSplineModel Instance
		{
			get
			{
				return GameSplineModel._Instance;
			}
		}

		// Token: 0x06045399 RID: 283545 RVA: 0x01121903 File Offset: 0x0111FB03
		public static GameSplineModel GetOrCreateInstance()
		{
			if (GameSplineModel._Instance == null)
			{
				GameSplineModel.CreateInstance();
			}
			return GameSplineModel._Instance;
		}

		// Token: 0x0604539A RID: 283546 RVA: 0x01121917 File Offset: 0x0111FB17
		public static bool CreateInstance()
		{
			if (GameSplineModel._Instance != null)
			{
				return true;
			}
			GameSplineModel._Instance = new GameSplineModel();
			return true;
		}

		// Token: 0x0604539B RID: 283547 RVA: 0x0112192D File Offset: 0x0111FB2D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604539C RID: 283548 RVA: 0x0112192F File Offset: 0x0111FB2F
		public static void ResetStaticDefaultValue()
		{
			GameSplineModel._Instance = null;
		}

		// Token: 0x0604539D RID: 283549 RVA: 0x01121937 File Offset: 0x0111FB37
		static GameSplineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameSplineModel.CreateStaticDefaultValue), new Action(GameSplineModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024176 RID: 147830
		private const int TIMER_PERIOD = 5000;

		// Token: 0x04024177 RID: 147831
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1,
			1
		})]
		private readonly Dictionary<int, ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>>> ActorMaps = new Dictionary<int, ValueTuple<TsGameSplineActor, USplineComponent, HashSet<ActorId>>>();

		// Token: 0x04024178 RID: 147832
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x04024179 RID: 147833
		public float CurWindPipelineResistance;

		// Token: 0x0402417A RID: 147834
		public float CurWindPipelineSpeedLimit;

		// Token: 0x0402417B RID: 147835
		[Nullable(2)]
		private static GameSplineModel _Instance;
	}
}
