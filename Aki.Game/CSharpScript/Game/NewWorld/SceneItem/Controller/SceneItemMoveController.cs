using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x0200723E RID: 29246
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneItemMoveController : ControllerBase
	{
		// Token: 0x06047AD6 RID: 293590 RVA: 0x01258348 File Offset: 0x01256548
		public void AddSceneItemMove(Entity entity, List<IVector> points, bool isLoop, ISceneItemMoveMotionType moveMotion, float? stopTime = null)
		{
			SceneItemMoveController.MoveParam moveParam = new SceneItemMoveController.MoveParam();
			moveParam.Points = points;
			moveParam.IsLoop = isLoop;
			moveParam.MoveMotion = moveMotion;
			moveParam.StopTime = stopTime;
			float? acceleration;
			if (moveMotion.Type != EMoveMotion.VariableMotion)
			{
				acceleration = new float?((float)-1);
			}
			else
			{
				IVariableMotion variableMotion = moveMotion as IVariableMotion;
				acceleration = ((variableMotion != null) ? new float?(variableMotion.Acceleration) : null);
			}
			moveParam.Acceleration = acceleration;
			float? maxSpeed;
			if (moveMotion.Type != EMoveMotion.VariableMotion)
			{
				maxSpeed = new float?((float)-1);
			}
			else
			{
				IVariableMotion variableMotion2 = moveMotion as IVariableMotion;
				maxSpeed = ((variableMotion2 != null) ? new float?(variableMotion2.MaxSpeed) : null);
			}
			moveParam.MaxSpeed = maxSpeed;
			SceneItemMoveController.MoveParam moveParam2 = moveParam;
			this.MoveParams[entity] = moveParam2;
			if (!EventSystem.Instance.HasWithTarget<Entity>(entity, EEventName.OnSceneItemMoveBroken, new Action<Entity>(this.OnStopCallback)))
			{
				EventSystem.Instance.AddWithTarget<Entity>(entity, EEventName.OnSceneItemMoveBroken, new Action<Entity>(this.OnStopCallback));
			}
			int num = -1;
			if (moveMotion.Type != EMoveMotion.VariableMotion)
			{
				Vector actorLocationProxy = entity.GetComponent<BaseActorComponent>().ActorLocationProxy;
				Vector v = Vector.Create(points[points.Count - 1].X, points[points.Count - 1].Y, points[points.Count - 1].Z);
				if (Vector.Distance(actorLocationProxy, v) < 1E-08)
				{
					if (moveParam2.IsLoop)
					{
						this.MoveToStartPoint(entity, 1);
					}
					return;
				}
				Vector vector = Vector.Create(points[points.Count - 1].X, points[points.Count - 1].Y, points[points.Count - 1].Z);
				vector.SubtractionEqual(Vector.Create(points[0].X, points[0].Y, points[0].Z));
				vector.Normalize(9.99999993922529E-09);
				for (int i = 1; i < points.Count; i++)
				{
					Vector vector2 = Vector.Create(points[i].X, points[i].Y, points[i].Z);
					vector2.SubtractionEqual(actorLocationProxy);
					vector2.Normalize(9.99999993922529E-09);
					if (vector2.DotProduct(vector) > 0.0)
					{
						num = i;
						break;
					}
				}
				if (num == -1)
				{
					return;
				}
			}
			else
			{
				num = 0;
			}
			this.MoveToEndPoint(entity, num);
		}

		// Token: 0x06047AD7 RID: 293591 RVA: 0x012585B4 File Offset: 0x012567B4
		private void MoveToStartPoint(Entity entity, int spliceNum = 1)
		{
			SceneItemMoveController.MoveParam moveParam;
			if (!this.MoveParams.TryGetValue(entity, out moveParam))
			{
				return;
			}
			SceneItemMoveComponent component = entity.GetComponent<SceneItemMoveComponent>();
			if (component == null)
			{
				return;
			}
			List<IVector> list = new List<IVector>(moveParam.Points);
			list.Reverse();
			if (spliceNum > 0 && spliceNum <= list.Count)
			{
				list.RemoveRange(0, spliceNum);
			}
			ISceneItemMoveMotionType moveMotion = moveParam.MoveMotion;
			if (moveMotion != null && moveMotion.Type == EMoveMotion.VariableMotion)
			{
				using (List<IVector>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IVector vector = enumerator.Current;
						Vector vector2 = Vector.Create(vector.X, vector.Y, vector.Z);
						SceneItemMoveComponent sceneItemMoveComponent = component;
						IVector targetPosData = vector2;
						float moveTime = -1f;
						float valueOrDefault = moveParam.StopTime.GetValueOrDefault();
						IVariableMotion variableMotion = moveParam.MoveMotion as IVariableMotion;
						float maxSpeed = (variableMotion != null) ? variableMotion.MaxSpeed : -1f;
						IVariableMotion variableMotion2 = moveParam.MoveMotion as IVariableMotion;
						sceneItemMoveComponent.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(targetPosData, moveTime, valueOrDefault, maxSpeed, (variableMotion2 != null) ? variableMotion2.Acceleration : -1f));
					}
					goto IL_181;
				}
			}
			foreach (IVector vector3 in list)
			{
				Vector vector4 = Vector.Create(vector3.X, vector3.Y, vector3.Z);
				SceneItemMoveComponent sceneItemMoveComponent2 = component;
				IVector targetPosData2 = vector4;
				IUniformMotion uniformMotion = moveParam.MoveMotion as IUniformMotion;
				sceneItemMoveComponent2.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(targetPosData2, (uniformMotion != null) ? uniformMotion.Time : -1f, moveParam.StopTime.GetValueOrDefault(), -1f, -1f));
			}
			IL_181:
			if (moveParam.IsLoop)
			{
				component.AddStopMoveCallbackWithEntity(new Action<Entity>(this.MoveToEndCallback));
				return;
			}
			component.AddStopMoveCallbackWithEntity(new Action<Entity>(this.OnStopCallback));
		}

		// Token: 0x06047AD8 RID: 293592 RVA: 0x0125878C File Offset: 0x0125698C
		private void MoveToEndPoint(Entity entity, int spliceNum = 1)
		{
			SceneItemMoveController.MoveParam moveParam;
			if (!this.MoveParams.TryGetValue(entity, out moveParam))
			{
				return;
			}
			SceneItemMoveComponent component = entity.GetComponent<SceneItemMoveComponent>();
			if (component == null)
			{
				return;
			}
			List<IVector> list = new List<IVector>(moveParam.Points);
			if (spliceNum > 0 && spliceNum <= list.Count)
			{
				list.RemoveRange(0, spliceNum);
			}
			ISceneItemMoveMotionType moveMotion = moveParam.MoveMotion;
			if (moveMotion != null && moveMotion.Type == EMoveMotion.VariableMotion)
			{
				bool flag = spliceNum > 0;
				using (List<IVector>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IVector vector = enumerator.Current;
						Vector vector2 = Vector.Create(vector.X, vector.Y, vector.Z);
						float? stopTime = moveParam.StopTime;
						if (!flag)
						{
							stopTime = new float?(0f);
							flag = true;
						}
						SceneItemMoveComponent sceneItemMoveComponent = component;
						IVector targetPosData = vector2;
						float moveTime = -1f;
						float valueOrDefault = stopTime.GetValueOrDefault();
						IVariableMotion variableMotion = moveParam.MoveMotion as IVariableMotion;
						float maxSpeed = (variableMotion != null) ? variableMotion.MaxSpeed : -1f;
						IVariableMotion variableMotion2 = moveParam.MoveMotion as IVariableMotion;
						sceneItemMoveComponent.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(targetPosData, moveTime, valueOrDefault, maxSpeed, (variableMotion2 != null) ? variableMotion2.Acceleration : -1f));
					}
					goto IL_19A;
				}
			}
			foreach (IVector vector3 in list)
			{
				Vector vector4 = Vector.Create(vector3.X, vector3.Y, vector3.Z);
				SceneItemMoveComponent sceneItemMoveComponent2 = component;
				IVector targetPosData2 = vector4;
				IUniformMotion uniformMotion = moveParam.MoveMotion as IUniformMotion;
				sceneItemMoveComponent2.AddMoveTarget(new SceneItemMoveComponent.MoveTarget(targetPosData2, (uniformMotion != null) ? uniformMotion.Time : -1f, moveParam.StopTime.GetValueOrDefault(), -1f, -1f));
			}
			IL_19A:
			if (moveParam.IsLoop)
			{
				component.AddStopMoveCallbackWithEntity(new Action<Entity>(this.MoveToStartCallback));
				return;
			}
			component.AddStopMoveCallbackWithEntity(new Action<Entity>(this.OnStopCallback));
		}

		// Token: 0x06047AD9 RID: 293593 RVA: 0x0125897C File Offset: 0x01256B7C
		private void MoveToStartCallback(Entity entity)
		{
			SceneItemMoveComponent component = entity.GetComponent<SceneItemMoveComponent>();
			if (component == null)
			{
				return;
			}
			component.RemoveStopMoveCallbackWithEntity(new Action<Entity>(this.MoveToStartCallback));
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.CH, "[LevelEventSceneItemMove] MoveToStartCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.MoveToStartPoint(entity, 1);
		}

		// Token: 0x06047ADA RID: 293594 RVA: 0x012589CC File Offset: 0x01256BCC
		private void MoveToEndCallback(Entity entity)
		{
			SceneItemMoveComponent component = entity.GetComponent<SceneItemMoveComponent>();
			if (component == null)
			{
				return;
			}
			component.RemoveStopMoveCallbackWithEntity(new Action<Entity>(this.MoveToEndCallback));
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.CH, "[LevelEventSceneItemMove] MoveToEndCallback", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.MoveToEndPoint(entity, 1);
		}

		// Token: 0x06047ADB RID: 293595 RVA: 0x01258A1C File Offset: 0x01256C1C
		public void OnStopCallback(Entity entity)
		{
			SceneItemMoveComponent component = entity.GetComponent<SceneItemMoveComponent>();
			if (component == null)
			{
				return;
			}
			component.RemoveStopMoveCallbackWithEntity(new Action<Entity>(this.OnStopCallback));
			if (EventSystem.Instance.HasWithTarget<Entity>(entity, EEventName.OnSceneItemMoveBroken, new Action<Entity>(this.OnStopCallback)))
			{
				EventSystem.Instance.RemoveWithTarget<Entity>(entity, EEventName.OnSceneItemMoveBroken, new Action<Entity>(this.OnStopCallback));
			}
			this.MoveParams.Remove(entity);
		}

		// Token: 0x17009E45 RID: 40517
		// (get) Token: 0x06047ADC RID: 293596 RVA: 0x01258A8E File Offset: 0x01256C8E
		public static SceneItemMoveController Instance
		{
			get
			{
				return SceneItemMoveController._Instance;
			}
		}

		// Token: 0x06047ADD RID: 293597 RVA: 0x01258A95 File Offset: 0x01256C95
		public static SceneItemMoveController GetOrCreateInstance()
		{
			if (SceneItemMoveController._Instance == null)
			{
				SceneItemMoveController.CreateInstance();
			}
			return SceneItemMoveController._Instance;
		}

		// Token: 0x06047ADE RID: 293598 RVA: 0x01258AA9 File Offset: 0x01256CA9
		public static bool CreateInstance()
		{
			if (SceneItemMoveController._Instance != null)
			{
				return true;
			}
			SceneItemMoveController._Instance = new SceneItemMoveController();
			return true;
		}

		// Token: 0x06047ADF RID: 293599 RVA: 0x01258ABF File Offset: 0x01256CBF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047AE0 RID: 293600 RVA: 0x01258AC1 File Offset: 0x01256CC1
		public static void ResetStaticDefaultValue()
		{
			SceneItemMoveController._Instance = null;
		}

		// Token: 0x06047AE1 RID: 293601 RVA: 0x01258AC9 File Offset: 0x01256CC9
		static SceneItemMoveController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemMoveController.CreateStaticDefaultValue), new Action(SceneItemMoveController.ResetStaticDefaultValue));
		}

		// Token: 0x04025B5F RID: 154463
		private readonly Dictionary<Entity, SceneItemMoveController.MoveParam> MoveParams = new Dictionary<Entity, SceneItemMoveController.MoveParam>();

		// Token: 0x04025B60 RID: 154464
		[Nullable(2)]
		private static SceneItemMoveController _Instance;

		// Token: 0x0200CF8A RID: 53130
		[NullableContext(0)]
		private class MoveParam
		{
			// Token: 0x0403E5F0 RID: 255472
			[Nullable(1)]
			public List<IVector> Points = new List<IVector>();

			// Token: 0x0403E5F1 RID: 255473
			public bool IsLoop;

			// Token: 0x0403E5F2 RID: 255474
			[Nullable(2)]
			public ISceneItemMoveMotionType MoveMotion;

			// Token: 0x0403E5F3 RID: 255475
			public float? StopTime;

			// Token: 0x0403E5F4 RID: 255476
			public float? Acceleration;

			// Token: 0x0403E5F5 RID: 255477
			public float? MaxSpeed;
		}
	}
}
