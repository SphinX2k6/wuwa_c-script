using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006010 RID: 24592
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class ElementalFieldDebugDrawController : ControllerBase
	{
		// Token: 0x17006F8F RID: 28559
		// (get) Token: 0x0603B14B RID: 241995 RVA: 0x010B5FEC File Offset: 0x010B41EC
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

		// Token: 0x0603B14C RID: 241996 RVA: 0x010B6013 File Offset: 0x010B4213
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<string, int>(EEventName.OnChangeModuleDebugLevel, new Action<string, int>(this.OnChangeModuleDebugLevel));
			return true;
		}

		// Token: 0x0603B14D RID: 241997 RVA: 0x010B6032 File Offset: 0x010B4232
		protected override bool OnClear()
		{
			this.ClearShapes();
			EventSystem.Instance.Remove<string, int>(EEventName.OnChangeModuleDebugLevel, new Action<string, int>(this.OnChangeModuleDebugLevel));
			return true;
		}

		// Token: 0x0603B14E RID: 241998 RVA: 0x010B6058 File Offset: 0x010B4258
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

		// Token: 0x0603B14F RID: 241999 RVA: 0x010B6174 File Offset: 0x010B4374
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

		// Token: 0x0603B150 RID: 242000 RVA: 0x010B61F8 File Offset: 0x010B43F8
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

		// Token: 0x0603B151 RID: 242001 RVA: 0x010B630C File Offset: 0x010B450C
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

		// Token: 0x0603B152 RID: 242002 RVA: 0x010B63B0 File Offset: 0x010B45B0
		private void PrintScreen(string message, EElementalFieldDebugShapeRole role)
		{
			if (!this.Enabled)
			{
				return;
			}
			FLinearColor value = (role == EElementalFieldDebugShapeRole.Detector) ? ElementalCasketDefine.elementalFieldDetectorDebugTextColor : ElementalCasketDefine.elementalFieldDetectableDebugTextColor;
			UKismetSystemLibrary.PrintString(GlobalData.World, message, true, true, new FLinearColor?(value), 5f);
		}

		// Token: 0x0603B153 RID: 242003 RVA: 0x010B63F0 File Offset: 0x010B45F0
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

		// Token: 0x0603B154 RID: 242004 RVA: 0x010B648C File Offset: 0x010B468C
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

		// Token: 0x0603B155 RID: 242005 RVA: 0x010B67D5 File Offset: 0x010B49D5
		private void DisableShapeDebugDraw(IElementalDebugDrawShapeInfo shapeInfo)
		{
			if (shapeInfo.Shape.IsValid())
			{
				shapeInfo.Shape.IsA(UKuroFastCollisionShapeComponent.StaticClass());
			}
		}

		// Token: 0x0603B156 RID: 242006 RVA: 0x010B67F5 File Offset: 0x010B49F5
		private void ApplyShape(IElementalDebugDrawShapeInfo shapeInfo, bool enabled)
		{
			if (!shapeInfo.Shape.IsValid() || !shapeInfo.Shape.IsA(UKuroFastCollisionShapeComponent.StaticClass()))
			{
				return;
			}
			UObject shape = shapeInfo.Shape;
		}

		// Token: 0x0603B157 RID: 242007 RVA: 0x010B6820 File Offset: 0x010B4A20
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

		// Token: 0x0603B158 RID: 242008 RVA: 0x010B68C8 File Offset: 0x010B4AC8
		public bool IsSnapshotDebugDrawEnabled<[Nullable(2)] T>(ISceneItemElementalFieldSnapshot<T> snapshot)
		{
			SundryModel instance = SundryModel.Instance;
			return ((instance != null) ? instance.GetModuleDebugLevel("ElementalCasket") : 0) >= 4 && snapshot.Enabled;
		}

		// Token: 0x0603B159 RID: 242009 RVA: 0x010B68EC File Offset: 0x010B4AEC
		public void DebugDrawConeSnapshot(ISceneItemElementalFieldConeSnapshot snapshot)
		{
			if (!this.IsSnapshotDebugDrawEnabled<ESceneItemElementalFieldShapeType>(snapshot))
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugCone(GlobalData.World, snapshot.Center, new FVectorDouble((double)snapshot.ConeAxis.X, (double)snapshot.ConeAxis.Y, (double)snapshot.ConeAxis.Z), (float)snapshot.ConeHeight, (float)snapshot.ConeHalfAngle, (float)snapshot.ConeHalfAngle, 16, ElementalCasketDefine.snapshotDebugDrawColor, 0.2f, 1f);
		}

		// Token: 0x0603B15A RID: 242010 RVA: 0x010B6962 File Offset: 0x010B4B62
		public void DebugDrawSphereSnapshot(ISceneItemElementalFieldSphereSnapshot snapshot)
		{
			if (!this.IsSnapshotDebugDrawEnabled<ESceneItemElementalFieldShapeType>(snapshot))
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, snapshot.Center, (float)snapshot.SphereRadius, 16, new FLinearColor?(ElementalCasketDefine.snapshotDebugDrawColor), 0.2f, 1f);
		}

		// Token: 0x0603B15B RID: 242011 RVA: 0x010B699C File Offset: 0x010B4B9C
		public void DebugDrawBoxSnapshot(ISceneItemElementalFieldBoxSnapshot snapshot)
		{
			if (!this.IsSnapshotDebugDrawEnabled<ESceneItemElementalFieldShapeType>(snapshot))
			{
				return;
			}
			UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, snapshot.Center, snapshot.BoxSize, ElementalCasketDefine.snapshotDebugDrawColor, snapshot.BoxRotation ?? new FRotator(), 0.2f, 1f);
		}

		// Token: 0x17006F90 RID: 28560
		// (get) Token: 0x0603B15C RID: 242012 RVA: 0x010B69F6 File Offset: 0x010B4BF6
		public static ElementalFieldDebugDrawController Instance
		{
			get
			{
				return ElementalFieldDebugDrawController._Instance;
			}
		}

		// Token: 0x0603B15D RID: 242013 RVA: 0x010B69FD File Offset: 0x010B4BFD
		public static ElementalFieldDebugDrawController GetOrCreateInstance()
		{
			if (ElementalFieldDebugDrawController._Instance == null)
			{
				ElementalFieldDebugDrawController.CreateInstance();
			}
			return ElementalFieldDebugDrawController._Instance;
		}

		// Token: 0x0603B15E RID: 242014 RVA: 0x010B6A11 File Offset: 0x010B4C11
		public static bool CreateInstance()
		{
			if (ElementalFieldDebugDrawController._Instance != null)
			{
				return true;
			}
			ElementalFieldDebugDrawController._Instance = new ElementalFieldDebugDrawController();
			return true;
		}

		// Token: 0x0603B15F RID: 242015 RVA: 0x010B6A27 File Offset: 0x010B4C27
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B160 RID: 242016 RVA: 0x010B6A29 File Offset: 0x010B4C29
		public static void ResetStaticDefaultValue()
		{
			ElementalFieldDebugDrawController._Instance = null;
		}

		// Token: 0x0603B161 RID: 242017 RVA: 0x010B6A31 File Offset: 0x010B4C31
		static ElementalFieldDebugDrawController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ElementalFieldDebugDrawController.CreateStaticDefaultValue), new Action(ElementalFieldDebugDrawController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F166 RID: 127334
		private readonly Dictionary<int, Dictionary<UObject, IElementalDebugDrawShapeInfo>> ShapeInfos = new Dictionary<int, Dictionary<UObject, IElementalDebugDrawShapeInfo>>();

		// Token: 0x0401F167 RID: 127335
		[Nullable(2)]
		private static ElementalFieldDebugDrawController _Instance;
	}
}
