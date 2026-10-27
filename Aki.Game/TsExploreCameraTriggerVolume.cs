using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032BB RID: 12987
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsExploreCameraTriggerVolume.TsExploreCameraTriggerVolume_C")]
public class TsExploreCameraTriggerVolume : TsTriggerVolume, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026E8 RID: 9960
	// (get) Token: 0x0601C258 RID: 115288 RVA: 0x007D5AF8 File Offset: 0x007D3CF8
	// (set) Token: 0x0601C259 RID: 115289 RVA: 0x007D5B08 File Offset: 0x007D3D08
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Id
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_Id);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_Id) = value;
		}
	}

	// Token: 0x170026E9 RID: 9961
	// (get) Token: 0x0601C25A RID: 115290 RVA: 0x007D5B19 File Offset: 0x007D3D19
	// (set) Token: 0x0601C25B RID: 115291 RVA: 0x007D5B2D File Offset: 0x007D3D2D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor LookAtActor1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsExploreCameraTriggerVolume.__PropertyOffset_LookAtActor1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsExploreCameraTriggerVolume.__PropertyOffset_LookAtActor1, value);
		}
	}

	// Token: 0x170026EA RID: 9962
	// (get) Token: 0x0601C25C RID: 115292 RVA: 0x007D5B42 File Offset: 0x007D3D42
	// (set) Token: 0x0601C25D RID: 115293 RVA: 0x007D5B56 File Offset: 0x007D3D56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor LookAtActor2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsExploreCameraTriggerVolume.__PropertyOffset_LookAtActor2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsExploreCameraTriggerVolume.__PropertyOffset_LookAtActor2, value);
		}
	}

	// Token: 0x170026EB RID: 9963
	// (get) Token: 0x0601C25E RID: 115294 RVA: 0x007D5B6B File Offset: 0x007D3D6B
	// (set) Token: 0x0601C25F RID: 115295 RVA: 0x007D5B7B File Offset: 0x007D3D7B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float PrepTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_PrepTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_PrepTime) = value;
		}
	}

	// Token: 0x170026EC RID: 9964
	// (get) Token: 0x0601C260 RID: 115296 RVA: 0x007D5B8C File Offset: 0x007D3D8C
	// (set) Token: 0x0601C261 RID: 115297 RVA: 0x007D5B9C File Offset: 0x007D3D9C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FadeDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_FadeDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_FadeDistance) = value;
		}
	}

	// Token: 0x170026ED RID: 9965
	// (get) Token: 0x0601C262 RID: 115298 RVA: 0x007D5BAD File Offset: 0x007D3DAD
	// (set) Token: 0x0601C263 RID: 115299 RVA: 0x007D5BBD File Offset: 0x007D3DBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ArmLengthMin
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_ArmLengthMin);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_ArmLengthMin) = value;
		}
	}

	// Token: 0x170026EE RID: 9966
	// (get) Token: 0x0601C264 RID: 115300 RVA: 0x007D5BCE File Offset: 0x007D3DCE
	// (set) Token: 0x0601C265 RID: 115301 RVA: 0x007D5BDE File Offset: 0x007D3DDE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ArmLengthMax
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_ArmLengthMax);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsExploreCameraTriggerVolume.__PropertyOffset_ArmLengthMax) = value;
		}
	}

	// Token: 0x0601C266 RID: 115302 RVA: 0x007D5BF0 File Offset: 0x007D3DF0
	protected override void OnCollisionEnterFunc(AActor otherActor, AActor overlapped)
	{
		if (!(otherActor is TsBaseCharacter))
		{
			return;
		}
		if (Global.BaseCharacter != otherActor)
		{
			return;
		}
		AActor lookAtActor = this.LookAtActor1;
		if (lookAtActor != null && lookAtActor.IsValid())
		{
			AActor lookAtActor2 = this.LookAtActor2;
			if (lookAtActor2 != null && lookAtActor2.IsValid())
			{
				FVectorDouble value = this.LookAtActor1.D_K2_GetActorLocation();
				FVectorDouble value2 = this.LookAtActor2.D_K2_GetActorLocation();
				CameraController.Instance.EnterCameraExplore(this.Id, new FVectorDouble?(value), new FVectorDouble?(value2), this.PrepTime, this.FadeDistance, this.ArmLengthMin, this.ArmLengthMax, "MainCamera");
				return;
			}
		}
		CameraController.Instance.EnterCameraExplore(this.Id, null, null, this.PrepTime, this.FadeDistance, this.ArmLengthMin, this.ArmLengthMax, "MainCamera");
	}

	// Token: 0x0601C267 RID: 115303 RVA: 0x007D5CC8 File Offset: 0x007D3EC8
	protected override void OnCollisionExitFunc(AActor otherActor, AActor overlapped)
	{
		if (!(otherActor is TsBaseCharacter))
		{
			return;
		}
		if (Global.BaseCharacter != otherActor)
		{
			return;
		}
		CameraController.Instance.ExitCameraExplore(this.Id, "MainCamera");
	}

	// Token: 0x0601C268 RID: 115304 RVA: 0x007D5CF1 File Offset: 0x007D3EF1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsExploreCameraTriggerVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsExploreCameraTriggerVolume.TsExploreCameraTriggerVolume_C");
		}
		return TsExploreCameraTriggerVolume._ClassPtr;
	}

	// Token: 0x0601C269 RID: 115305 RVA: 0x007D5D18 File Offset: 0x007D3F18
	public TsExploreCameraTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(TsExploreCameraTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C26A RID: 115306 RVA: 0x007D5D40 File Offset: 0x007D3F40
	[NullableContext(1)]
	public TsExploreCameraTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreCameraTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C26B RID: 115307 RVA: 0x007D5D73 File Offset: 0x007D3F73
	protected TsExploreCameraTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400DEBC RID: 57020
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsExploreCameraTriggerVolume.TsExploreCameraTriggerVolume_C";

	// Token: 0x0400DEBD RID: 57021
	private static IntPtr _ClassPtr;

	// Token: 0x0400DEBE RID: 57022
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DEBF RID: 57023
	private static int __PropertyOffset_Id;

	// Token: 0x0400DEC0 RID: 57024
	private static int __PropertyOffset_LookAtActor1;

	// Token: 0x0400DEC1 RID: 57025
	private static int __PropertyOffset_LookAtActor2;

	// Token: 0x0400DEC2 RID: 57026
	private static int __PropertyOffset_PrepTime;

	// Token: 0x0400DEC3 RID: 57027
	private static int __PropertyOffset_FadeDistance;

	// Token: 0x0400DEC4 RID: 57028
	private static int __PropertyOffset_ArmLengthMin;

	// Token: 0x0400DEC5 RID: 57029
	private static int __PropertyOffset_ArmLengthMax;
}
