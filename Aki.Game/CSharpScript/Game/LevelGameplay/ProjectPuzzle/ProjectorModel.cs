using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ProjectPuzzle
{
	// Token: 0x02005C13 RID: 23571
	[NullableContext(1)]
	[Nullable(0)]
	public class ProjectorModel : ModelBase
	{
		// Token: 0x06039E3C RID: 237116 RVA: 0x010469D4 File Offset: 0x01044BD4
		public void InitFromComponent(int entityId, float rotationSpeed, float dragRotationCoefficient, float matchTolerance, Rotator[] targetRotators, Action<bool> finishCallback)
		{
			this.IsActive = true;
			this.EntityId = entityId;
			this.RotationSpeed = rotationSpeed;
			this.DragRotationCoefficient = dragRotationCoefficient;
			this.MatchTolerance = matchTolerance;
			this.IsCompleted = false;
			this.FinishCallback = finishCallback;
			if (targetRotators.Length == 0)
			{
				this.TargetRotators = Array.Empty<Rotator>();
			}
			else
			{
				Rotator[] array = new Rotator[targetRotators.Length];
				Array.Copy(targetRotators, array, targetRotators.Length);
				this.TargetRotators = array;
			}
			this.ResetInputState();
		}

		// Token: 0x06039E3D RID: 237117 RVA: 0x01046A49 File Offset: 0x01044C49
		protected override bool OnClear()
		{
			this.Reset();
			return true;
		}

		// Token: 0x06039E3E RID: 237118 RVA: 0x01046A54 File Offset: 0x01044C54
		public void ResetInputState()
		{
			this.HasLastArcballVector = false;
			this.DragCenterX = 0f;
			this.DragCenterY = 0f;
			this.FrameDragAngle = 0f;
			this.FrameStickAngle = 0f;
			this.LastArcballVector.Reset();
			this.TempArcballVector.Reset();
			this.TempAxis.Reset();
			this.TempWorldAxis.Reset();
		}

		// Token: 0x06039E3F RID: 237119 RVA: 0x01046AC0 File Offset: 0x01044CC0
		public void Reset()
		{
			this.EntityId = 0;
			this.IsActive = false;
			this.IsCompleted = false;
			this.RotationSpeed = 0f;
			this.DragRotationCoefficient = 0f;
			this.MatchTolerance = 0f;
			this.TargetRotators = Array.Empty<Rotator>();
			this.FinishCallback = null;
			this.AttachActor = null;
			this.InitialAttachRelativeRotator.Set(0f, 0f, 0f);
			this.BackgroundActor = null;
			this.BackgroundDecalEffectId = 0;
			this.ShadowCompensationActor = null;
			this.RotationAudioHandle = 0;
			this.ResetInputState();
		}

		// Token: 0x17006E4B RID: 28235
		// (get) Token: 0x06039E40 RID: 237120 RVA: 0x01046B58 File Offset: 0x01044D58
		public static ProjectorModel Instance
		{
			get
			{
				return ProjectorModel._Instance;
			}
		}

		// Token: 0x06039E41 RID: 237121 RVA: 0x01046B5F File Offset: 0x01044D5F
		public static ProjectorModel GetOrCreateInstance()
		{
			if (ProjectorModel._Instance == null)
			{
				ProjectorModel.CreateInstance();
			}
			return ProjectorModel._Instance;
		}

		// Token: 0x06039E42 RID: 237122 RVA: 0x01046B73 File Offset: 0x01044D73
		public static bool CreateInstance()
		{
			if (ProjectorModel._Instance != null)
			{
				return true;
			}
			ProjectorModel._Instance = new ProjectorModel();
			return true;
		}

		// Token: 0x06039E43 RID: 237123 RVA: 0x01046B89 File Offset: 0x01044D89
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039E44 RID: 237124 RVA: 0x01046B8B File Offset: 0x01044D8B
		public static void ResetStaticDefaultValue()
		{
			ProjectorModel._Instance = null;
		}

		// Token: 0x06039E45 RID: 237125 RVA: 0x01046B93 File Offset: 0x01044D93
		static ProjectorModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ProjectorModel.CreateStaticDefaultValue), new Action(ProjectorModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E972 RID: 125298
		public int EntityId;

		// Token: 0x0401E973 RID: 125299
		public bool IsActive;

		// Token: 0x0401E974 RID: 125300
		public bool IsCompleted;

		// Token: 0x0401E975 RID: 125301
		public float RotationSpeed;

		// Token: 0x0401E976 RID: 125302
		public float DragRotationCoefficient;

		// Token: 0x0401E977 RID: 125303
		public float MatchTolerance;

		// Token: 0x0401E978 RID: 125304
		public Rotator[] TargetRotators = Array.Empty<Rotator>();

		// Token: 0x0401E979 RID: 125305
		[Nullable(2)]
		public Action<bool> FinishCallback;

		// Token: 0x0401E97A RID: 125306
		[Nullable(2)]
		public AActor AttachActor;

		// Token: 0x0401E97B RID: 125307
		public readonly Rotator InitialAttachRelativeRotator = Rotator.Create();

		// Token: 0x0401E97C RID: 125308
		[Nullable(2)]
		public AActor BackgroundActor;

		// Token: 0x0401E97D RID: 125309
		public int BackgroundDecalEffectId;

		// Token: 0x0401E97E RID: 125310
		[Nullable(2)]
		public AStaticMeshActor ShadowCompensationActor;

		// Token: 0x0401E97F RID: 125311
		public int RotationAudioHandle;

		// Token: 0x0401E980 RID: 125312
		public float FrameDragAngle;

		// Token: 0x0401E981 RID: 125313
		public float FrameStickAngle;

		// Token: 0x0401E982 RID: 125314
		public bool HasLastArcballVector;

		// Token: 0x0401E983 RID: 125315
		public float DragCenterX;

		// Token: 0x0401E984 RID: 125316
		public float DragCenterY;

		// Token: 0x0401E985 RID: 125317
		public readonly Vector LastArcballVector = Vector.Create();

		// Token: 0x0401E986 RID: 125318
		public readonly Vector TempArcballVector = Vector.Create();

		// Token: 0x0401E987 RID: 125319
		public readonly Vector TempAxis = Vector.Create();

		// Token: 0x0401E988 RID: 125320
		public readonly Vector TempWorldAxis = Vector.Create();

		// Token: 0x0401E989 RID: 125321
		public readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401E98A RID: 125322
		public readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401E98B RID: 125323
		public readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x0401E98C RID: 125324
		[Nullable(2)]
		private static ProjectorModel _Instance;
	}
}
