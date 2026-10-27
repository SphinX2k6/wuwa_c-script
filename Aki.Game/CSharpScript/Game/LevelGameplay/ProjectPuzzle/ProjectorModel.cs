using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ProjectPuzzle
{
	// Token: 0x02006AB6 RID: 27318
	[NullableContext(1)]
	[Nullable(0)]
	public class ProjectorModel : ModelBase
	{
		// Token: 0x06043DE2 RID: 277986 RVA: 0x010A2348 File Offset: 0x010A0548
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

		// Token: 0x06043DE3 RID: 277987 RVA: 0x010A23BD File Offset: 0x010A05BD
		protected override bool OnClear()
		{
			this.Reset();
			return true;
		}

		// Token: 0x06043DE4 RID: 277988 RVA: 0x010A23C8 File Offset: 0x010A05C8
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

		// Token: 0x06043DE5 RID: 277989 RVA: 0x010A2434 File Offset: 0x010A0634
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

		// Token: 0x1700995A RID: 39258
		// (get) Token: 0x06043DE6 RID: 277990 RVA: 0x010A24CC File Offset: 0x010A06CC
		public static ProjectorModel Instance
		{
			get
			{
				return ProjectorModel._Instance;
			}
		}

		// Token: 0x06043DE7 RID: 277991 RVA: 0x010A24D3 File Offset: 0x010A06D3
		public static ProjectorModel GetOrCreateInstance()
		{
			if (ProjectorModel._Instance == null)
			{
				ProjectorModel.CreateInstance();
			}
			return ProjectorModel._Instance;
		}

		// Token: 0x06043DE8 RID: 277992 RVA: 0x010A24E7 File Offset: 0x010A06E7
		public static bool CreateInstance()
		{
			if (ProjectorModel._Instance != null)
			{
				return true;
			}
			ProjectorModel._Instance = new ProjectorModel();
			return true;
		}

		// Token: 0x06043DE9 RID: 277993 RVA: 0x010A24FD File Offset: 0x010A06FD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043DEA RID: 277994 RVA: 0x010A24FF File Offset: 0x010A06FF
		public static void ResetStaticDefaultValue()
		{
			ProjectorModel._Instance = null;
		}

		// Token: 0x06043DEB RID: 277995 RVA: 0x010A2507 File Offset: 0x010A0707
		static ProjectorModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ProjectorModel.CreateStaticDefaultValue), new Action(ProjectorModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023780 RID: 145280
		public int EntityId;

		// Token: 0x04023781 RID: 145281
		public bool IsActive;

		// Token: 0x04023782 RID: 145282
		public bool IsCompleted;

		// Token: 0x04023783 RID: 145283
		public float RotationSpeed;

		// Token: 0x04023784 RID: 145284
		public float DragRotationCoefficient;

		// Token: 0x04023785 RID: 145285
		public float MatchTolerance;

		// Token: 0x04023786 RID: 145286
		public Rotator[] TargetRotators = Array.Empty<Rotator>();

		// Token: 0x04023787 RID: 145287
		[Nullable(2)]
		public Action<bool> FinishCallback;

		// Token: 0x04023788 RID: 145288
		[Nullable(2)]
		public AActor AttachActor;

		// Token: 0x04023789 RID: 145289
		public readonly Rotator InitialAttachRelativeRotator = Rotator.Create();

		// Token: 0x0402378A RID: 145290
		[Nullable(2)]
		public AActor BackgroundActor;

		// Token: 0x0402378B RID: 145291
		public int BackgroundDecalEffectId;

		// Token: 0x0402378C RID: 145292
		[Nullable(2)]
		public AStaticMeshActor ShadowCompensationActor;

		// Token: 0x0402378D RID: 145293
		public int RotationAudioHandle;

		// Token: 0x0402378E RID: 145294
		public float FrameDragAngle;

		// Token: 0x0402378F RID: 145295
		public float FrameStickAngle;

		// Token: 0x04023790 RID: 145296
		public bool HasLastArcballVector;

		// Token: 0x04023791 RID: 145297
		public float DragCenterX;

		// Token: 0x04023792 RID: 145298
		public float DragCenterY;

		// Token: 0x04023793 RID: 145299
		public readonly Vector LastArcballVector = Vector.Create();

		// Token: 0x04023794 RID: 145300
		public readonly Vector TempArcballVector = Vector.Create();

		// Token: 0x04023795 RID: 145301
		public readonly Vector TempAxis = Vector.Create();

		// Token: 0x04023796 RID: 145302
		public readonly Vector TempWorldAxis = Vector.Create();

		// Token: 0x04023797 RID: 145303
		public readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023798 RID: 145304
		public readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04023799 RID: 145305
		public readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x0402379A RID: 145306
		[Nullable(2)]
		private static ProjectorModel _Instance;
	}
}
