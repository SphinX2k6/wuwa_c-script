using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E90 RID: 28304
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class ElementalFieldDebugDrawController : ControllerBase
	{
		// Token: 0x17009A58 RID: 39512
		// (get) Token: 0x06044FAA RID: 282538 RVA: 0x0110BF10 File Offset: 0x0110A110
		public bool Enabled
		{
			get
			{
				if (GlobalData.IsPlayInEditor)
				{
					SundryModel instance = SundryModel.Instance;
					return ((instance != null) ? instance.GetModuleDebugLevel("ElementalCasket") : 0) >= 4;
				}
				return false;
			}
		}

		// Token: 0x06044FAB RID: 282539 RVA: 0x0110BF37 File Offset: 0x0110A137
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<string, int>(EEventName.OnChangeModuleDebugLevel, new Action<string, int>(this.OnChangeModuleDebugLevel));
			return true;
		}

		// Token: 0x06044FAC RID: 282540 RVA: 0x0110BF56 File Offset: 0x0110A156
		protected override bool OnClear()
		{
			this.ClearShapes();
			EventSystem.Instance.Remove<string, int>(EEventName.OnChangeModuleDebugLevel, new Action<string, int>(this.OnChangeModuleDebugLevel));
			return true;
		}

		// Token: 0x06044FAD RID: 282541 RVA: 0x0110BF7C File Offset: 0x0110A17C
		protected override void OnTick(float delta)
		{
			if (!GlobalData.IsPlayInEditor)
			{
				return;
			}
			SundryModel instance = SundryModel.Instance;
			if (((instance != null) ? instance.GetModuleDebugLevel("ElementalFieldVolume") : 0) >= 4)
			{
				foreach (IActiveVolumeEntry activeVolumeEntry in ElementalFieldVolumeController.Instance.ActiveVolumes)
				{
					activeVolumeEntry.Volume.DebugDraw();
				}
			}
			if (this.ShapeInfos.Count == 0 || !this.Enabled)
			{
				return;
			}
			foreach (KeyValuePair<int, Dictionary<UObject, IElementalDebugDrawShapeInfo>> keyValuePair in this.ShapeInfos)
			{
				int num;
				Dictionary<UObject, IElementalDebugDrawShapeInfo> dictionary;
				keyValuePair.Deconstruct(out num, out dictionary);
				int ownerId = num;
				foreach (IElementalDebugDrawShapeInfo shapeInfo in dictionary.Values)
				{
					this.DrawShapeInfo(ownerId, shapeInfo);
				}
			}
		}

		// Token: 0x06044FAE RID: 282542 RVA: 0x0110C098 File Offset: 0x0110A298
		public void RegisterShape(int ownerId, IElementalDebugDrawShapeInfo shapeInfo)
		{
			if (!GlobalData.IsPlayInEditor)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[ElementalField] Register Entity=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(ownerId);
			this.PrintScreen(defaultInterpolatedStringHandler.ToStringAndClear(), shapeInfo.Role);
			Dictionary<UObject, IElementalDebugDrawShapeInfo> dictionary;
			if (!this.ShapeInfos.TryGetValue(ownerId, out dictionary))
			{
				dictionary = new Dictionary<UObject, IElementalDebugDrawShapeInfo>();
				this.ShapeInfos[ownerId] = dictionary;
			}
			dictionary[shapeInfo.Shape] = shapeInfo;
			this.ApplyShape(shapeInfo, this.Enabled);
		}

		// Token: 0x06044FAF RID: 282543 RVA: 0x0110C11C File Offset: 0x0110A31C
		[NullableContext(2)]
		public void UnregisterShape(int ownerId, UObject shape = null)
		{
			if (!GlobalData.IsPlayInEditor)
			{
				return;
			}
			Dictionary<UObject, IElementalDebugDrawShapeInfo> dictionary;
			if (!this.ShapeInfos.TryGetValue(ownerId, out dictionary))
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (shape == null)
			{
				foreach (IElementalDebugDrawShapeInfo elementalDebugDrawShapeInfo in dictionary.Values)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
					defaultInterpolatedStringHandler.AppendLiteral("[ElementalField] Unregister Entity=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(ownerId);
					this.PrintScreen(defaultInterpolatedStringHandler.ToStringAndClear(), elementalDebugDrawShapeInfo.Role);
					this.DisableShapeDebugDraw(elementalDebugDrawShapeInfo);
				}
				this.ShapeInfos.Remove(ownerId);
				return;
			}
			IElementalDebugDrawShapeInfo elementalDebugDrawShapeInfo2;
			if (!dictionary.TryGetValue(shape, out elementalDebugDrawShapeInfo2))
			{
				return;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[ElementalField] Unregister Entity=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(ownerId);
			this.PrintScreen(defaultInterpolatedStringHandler.ToStringAndClear(), elementalDebugDrawShapeInfo2.Role);
			dictionary.Remove(shape);
			if (dictionary.Count == 0)
			{
				this.ShapeInfos.Remove(ownerId);
			}
			this.DisableShapeDebugDraw(elementalDebugDrawShapeInfo2);
		}

		// Token: 0x06044FB0 RID: 282544 RVA: 0x0110C230 File Offset: 0x0110A430
		public void ClearShapes()
		{
			if (!GlobalData.IsPlayInEditor)
			{
				return;
			}
			foreach (Dictionary<UObject, IElementalDebugDrawShapeInfo> dictionary in this.ShapeInfos.Values)
			{
				foreach (IElementalDebugDrawShapeInfo shapeInfo in dictionary.Values)
				{
					this.DisableShapeDebugDraw(shapeInfo);
				}
			}
			this.ShapeInfos.Clear();
		}

		// Token: 0x06044FB1 RID: 282545 RVA: 0x0110C2D4 File Offset: 0x0110A4D4
		private void PrintScreen(string message, EElementalFieldDebugShapeRole role)
		{
			if (!this.Enabled)
			{
				return;
			}
			FLinearColor value = (role == EElementalFieldDebugShapeRole.Detector) ? ElementalCasketDefine.elementalFieldDetectorDebugTextColor : ElementalCasketDefine.elementalFieldDetectableDebugTextColor;
			UKismetSystemLibrary.PrintString(GlobalData.World, message, true, true, new FLinearColor?(value), 5f);
		}

		// Token: 0x06044FB2 RID: 282546 RVA: 0x0110C314 File Offset: 0x0110A514
		private void DrawShapeInfo(int ownerId, IElementalDebugDrawShapeInfo shapeInfo)
		{
			if (!shapeInfo.Shape.IsValid())
			{
				return;
			}
			if (!shapeInfo.Shape.IsA(UKuroFastCollisionShapeComponent.StaticClass()))
			{
				return;
			}
			UKuroFastCollisionShapeComponent shape = shapeInfo.Shape as UKuroFastCollisionShapeComponent;
			FVectorDouble textLocation = ElementalCasketHelper.ComputeShapeCenterLocation(shape);
			string str = (shapeInfo.Role == EElementalFieldDebugShapeRole.Detector) ? "Detector" : "Detectable";
			FLinearColor value = (shapeInfo.Role == EElementalFieldDebugShapeRole.Detector) ? ElementalCasketDefine.elementalFieldDetectorDebugTextColor : ElementalCasketDefine.elementalFieldDetectableDebugTextColor;
			UKismetSystemLibrary.D_DrawDebugString(GlobalData.World, textLocation, "[" + str + "] " + this.DescribeShape(ownerId, shape), null, new FLinearColor?(value), 0f);
		}

		// Token: 0x06044FB3 RID: 282547 RVA: 0x0110C3B0 File Offset: 0x0110A5B0
		private string DescribeShape(int ownerId, UKuroFastCollisionShapeComponent shape)
		{
			switch (shape.Kind)
			{
			case ECollisionShapeKind.Sphere:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[Sphere] Entity=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ownerId);
				defaultInterpolatedStringHandler.AppendLiteral("\n Radius=");
				float num = shape.Radius;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler2.AppendLiteral("F");
				defaultInterpolatedStringHandler2.AppendFormatted<int>(1);
				defaultInterpolatedStringHandler.AppendFormatted(num.ToString(defaultInterpolatedStringHandler2.ToStringAndClear()));
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			case ECollisionShapeKind.Box:
			{
				FVector halfExtent = shape.HalfExtent;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				string value = halfExtent.X.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				string value2 = halfExtent.Y.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				string value3 = halfExtent.Z.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 4);
				defaultInterpolatedStringHandler.AppendLiteral("[Box] Entity=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ownerId);
				defaultInterpolatedStringHandler.AppendLiteral("\n HalfExtent=(");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted(value3);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			case ECollisionShapeKind.Capsule:
			{
				float num = shape.Radius;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				string value4 = num.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
				num = shape.HalfLength;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				string value5 = num.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[Capsule] Entity=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ownerId);
				defaultInterpolatedStringHandler.AppendLiteral("\n Radius=");
				defaultInterpolatedStringHandler.AppendFormatted(value4);
				defaultInterpolatedStringHandler.AppendLiteral(" HalfLength=");
				defaultInterpolatedStringHandler.AppendFormatted(value5);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			case ECollisionShapeKind.Cone:
			{
				float num = shape.ConeHalfAngle * 57.29578f;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				string value6 = num.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
				num = shape.ConeHeight;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				string value7 = num.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[Cone] Entity=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ownerId);
				defaultInterpolatedStringHandler.AppendLiteral("\n HalfAngleDeg=");
				defaultInterpolatedStringHandler.AppendFormatted(value6);
				defaultInterpolatedStringHandler.AppendLiteral(" Height=");
				defaultInterpolatedStringHandler.AppendFormatted(value7);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			default:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("UnknownKind=");
				defaultInterpolatedStringHandler.AppendFormatted<ECollisionShapeKind>(shape.Kind);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			}
		}

		// Token: 0x06044FB4 RID: 282548 RVA: 0x0110C6F9 File Offset: 0x0110A8F9
		private void DisableShapeDebugDraw(IElementalDebugDrawShapeInfo shapeInfo)
		{
			if (shapeInfo.Shape.IsValid())
			{
				shapeInfo.Shape.IsA(UKuroFastCollisionShapeComponent.StaticClass());
			}
		}

		// Token: 0x06044FB5 RID: 282549 RVA: 0x0110C719 File Offset: 0x0110A919
		private void ApplyShape(IElementalDebugDrawShapeInfo shapeInfo, bool enabled)
		{
			if (!shapeInfo.Shape.IsValid() || !shapeInfo.Shape.IsA(UKuroFastCollisionShapeComponent.StaticClass()))
			{
				return;
			}
			UObject shape = shapeInfo.Shape;
		}

		// Token: 0x06044FB6 RID: 282550 RVA: 0x0110C744 File Offset: 0x0110A944
		private void OnChangeModuleDebugLevel(string key, int level)
		{
			if (key != "ElementalCasket")
			{
				return;
			}
			bool enabled = level >= 4;
			foreach (Dictionary<UObject, IElementalDebugDrawShapeInfo> dictionary in this.ShapeInfos.Values)
			{
				foreach (IElementalDebugDrawShapeInfo shapeInfo in dictionary.Values)
				{
					this.ApplyShape(shapeInfo, enabled);
				}
			}
		}

		// Token: 0x06044FB7 RID: 282551 RVA: 0x0110C7EC File Offset: 0x0110A9EC
		public bool IsSnapshotDebugDrawEnabled<[Nullable(2)] T>(ISceneItemElementalFieldSnapshot<T> snapshot)
		{
			SundryModel instance = SundryModel.Instance;
			return ((instance != null) ? instance.GetModuleDebugLevel("ElementalCasket") : 0) >= 4 && snapshot.Enabled;
		}

		// Token: 0x06044FB8 RID: 282552 RVA: 0x0110C810 File Offset: 0x0110AA10
		public void DebugDrawConeSnapshot(ISceneItemElementalFieldConeSnapshot snapshot)
		{
			if (!this.IsSnapshotDebugDrawEnabled<ESceneItemElementalFieldShapeType>(snapshot))
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugCone(GlobalData.World, snapshot.Center, new FVectorDouble((double)snapshot.ConeAxis.X, (double)snapshot.ConeAxis.Y, (double)snapshot.ConeAxis.Z), (float)snapshot.ConeHeight, (float)snapshot.ConeHalfAngle, (float)snapshot.ConeHalfAngle, 16, ElementalCasketDefine.snapshotDebugDrawColor, 0.2f, 1f);
		}

		// Token: 0x06044FB9 RID: 282553 RVA: 0x0110C886 File Offset: 0x0110AA86
		public void DebugDrawSphereSnapshot(ISceneItemElementalFieldSphereSnapshot snapshot)
		{
			if (!this.IsSnapshotDebugDrawEnabled<ESceneItemElementalFieldShapeType>(snapshot))
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, snapshot.Center, (float)snapshot.SphereRadius, 16, new FLinearColor?(ElementalCasketDefine.snapshotDebugDrawColor), 0.2f, 1f);
		}

		// Token: 0x06044FBA RID: 282554 RVA: 0x0110C8C0 File Offset: 0x0110AAC0
		public void DebugDrawBoxSnapshot(ISceneItemElementalFieldBoxSnapshot snapshot)
		{
			if (!this.IsSnapshotDebugDrawEnabled<ESceneItemElementalFieldShapeType>(snapshot))
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, snapshot.Center, snapshot.BoxSize, ElementalCasketDefine.snapshotDebugDrawColor, snapshot.BoxRotation ?? new FRotator(), 0.2f, 1f);
		}

		// Token: 0x17009A59 RID: 39513
		// (get) Token: 0x06044FBB RID: 282555 RVA: 0x0110C91A File Offset: 0x0110AB1A
		public static ElementalFieldDebugDrawController Instance
		{
			get
			{
				return ElementalFieldDebugDrawController._Instance;
			}
		}

		// Token: 0x06044FBC RID: 282556 RVA: 0x0110C921 File Offset: 0x0110AB21
		public static ElementalFieldDebugDrawController GetOrCreateInstance()
		{
			if (ElementalFieldDebugDrawController._Instance == null)
			{
				ElementalFieldDebugDrawController.CreateInstance();
			}
			return ElementalFieldDebugDrawController._Instance;
		}

		// Token: 0x06044FBD RID: 282557 RVA: 0x0110C935 File Offset: 0x0110AB35
		public static bool CreateInstance()
		{
			if (ElementalFieldDebugDrawController._Instance != null)
			{
				return true;
			}
			ElementalFieldDebugDrawController._Instance = new ElementalFieldDebugDrawController();
			return true;
		}

		// Token: 0x06044FBE RID: 282558 RVA: 0x0110C94B File Offset: 0x0110AB4B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044FBF RID: 282559 RVA: 0x0110C94D File Offset: 0x0110AB4D
		public static void ResetStaticDefaultValue()
		{
			ElementalFieldDebugDrawController._Instance = null;
		}

		// Token: 0x06044FC0 RID: 282560 RVA: 0x0110C955 File Offset: 0x0110AB55
		static ElementalFieldDebugDrawController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ElementalFieldDebugDrawController.CreateStaticDefaultValue), new Action(ElementalFieldDebugDrawController.ResetStaticDefaultValue));
		}

		// Token: 0x04023EB3 RID: 147123
		private readonly Dictionary<int, Dictionary<UObject, IElementalDebugDrawShapeInfo>> ShapeInfos = new Dictionary<int, Dictionary<UObject, IElementalDebugDrawShapeInfo>>();

		// Token: 0x04023EB4 RID: 147124
		[Nullable(2)]
		private static ElementalFieldDebugDrawController _Instance;
	}
}
