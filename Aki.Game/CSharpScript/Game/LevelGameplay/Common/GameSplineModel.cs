using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x0200609F RID: 24735
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GameSplineModel : ModelBase
	{
		// Token: 0x0603B542 RID: 243010 RVA: 0x010CB54C File Offset: 0x010C974C
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

		// Token: 0x0603B543 RID: 243011 RVA: 0x010CB738 File Offset: 0x010C9938
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

		// Token: 0x0603B544 RID: 243012 RVA: 0x010CB800 File Offset: 0x010C9A00
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

		// Token: 0x0603B545 RID: 243013 RVA: 0x010CB828 File Offset: 0x010C9A28
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

		// Token: 0x17007047 RID: 28743
		// (get) Token: 0x0603B546 RID: 243014 RVA: 0x010CB8A8 File Offset: 0x010C9AA8
		public static GameSplineModel Instance
		{
			get
			{
				return GameSplineModel._Instance;
			}
		}

		// Token: 0x0603B547 RID: 243015 RVA: 0x010CB8AF File Offset: 0x010C9AAF
		public static GameSplineModel GetOrCreateInstance()
		{
			if (GameSplineModel._Instance == null)
			{
				GameSplineModel.CreateInstance();
			}
			return GameSplineModel._Instance;
		}

		// Token: 0x0603B548 RID: 243016 RVA: 0x010CB8C3 File Offset: 0x010C9AC3
		public static bool CreateInstance()
		{
			if (GameSplineModel._Instance != null)
			{
				return true;
			}
			GameSplineModel._Instance = new GameSplineModel();
			return true;
		}

		// Token: 0x0603B549 RID: 243017 RVA: 0x010CB8D9 File Offset: 0x010C9AD9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B54A RID: 243018 RVA: 0x010CB8DB File Offset: 0x010C9ADB
		public static void ResetStaticDefaultValue()
		{
			GameSplineModel._Instance = null;
		}

		// Token: 0x0603B54B RID: 243019 RVA: 0x010CB8E3 File Offset: 0x010C9AE3
		static GameSplineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GameSplineModel.CreateStaticDefaultValue), new Action(GameSplineModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F42B RID: 128043
		private const int TIMER_PERIOD = 5000;

		// Token: 0x0401F42C RID: 128044
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

		// Token: 0x0401F42D RID: 128045
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401F42E RID: 128046
		public float CurWindPipelineResistance;

		// Token: 0x0401F42F RID: 128047
		public float CurWindPipelineSpeedLimit;

		// Token: 0x0401F430 RID: 128048
		[Nullable(2)]
		private static GameSplineModel _Instance;
	}
}
