using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200282C RID: 10284
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsExploreCameraTriggerVolume.TsExploreCameraTriggerVolume_C")]
public class TsExploreCameraTriggerVolume : TsTriggerVolume, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029D4 RID: 10708
	// (get) Token: 0x06019E98 RID: 106136 RVA: 0x007FCC94 File Offset: 0x007FAE94
	// (set) Token: 0x06019E99 RID: 106137 RVA: 0x007FCCA4 File Offset: 0x007FAEA4
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

	// Token: 0x170029D5 RID: 10709
	// (get) Token: 0x06019E9A RID: 106138 RVA: 0x007FCCB5 File Offset: 0x007FAEB5
	// (set) Token: 0x06019E9B RID: 106139 RVA: 0x007FCCC9 File Offset: 0x007FAEC9
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

	// Token: 0x170029D6 RID: 10710
	// (get) Token: 0x06019E9C RID: 106140 RVA: 0x007FCCDE File Offset: 0x007FAEDE
	// (set) Token: 0x06019E9D RID: 106141 RVA: 0x007FCCF2 File Offset: 0x007FAEF2
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

	// Token: 0x170029D7 RID: 10711
	// (get) Token: 0x06019E9E RID: 106142 RVA: 0x007FCD07 File Offset: 0x007FAF07
	// (set) Token: 0x06019E9F RID: 106143 RVA: 0x007FCD17 File Offset: 0x007FAF17
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

	// Token: 0x170029D8 RID: 10712
	// (get) Token: 0x06019EA0 RID: 106144 RVA: 0x007FCD28 File Offset: 0x007FAF28
	// (set) Token: 0x06019EA1 RID: 106145 RVA: 0x007FCD38 File Offset: 0x007FAF38
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

	// Token: 0x170029D9 RID: 10713
	// (get) Token: 0x06019EA2 RID: 106146 RVA: 0x007FCD49 File Offset: 0x007FAF49
	// (set) Token: 0x06019EA3 RID: 106147 RVA: 0x007FCD59 File Offset: 0x007FAF59
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

	// Token: 0x170029DA RID: 10714
	// (get) Token: 0x06019EA4 RID: 106148 RVA: 0x007FCD6A File Offset: 0x007FAF6A
	// (set) Token: 0x06019EA5 RID: 106149 RVA: 0x007FCD7A File Offset: 0x007FAF7A
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

	// Token: 0x06019EA6 RID: 106150 RVA: 0x007FCD8C File Offset: 0x007FAF8C
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

	// Token: 0x06019EA7 RID: 106151 RVA: 0x007FCE64 File Offset: 0x007FB064
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

	// Token: 0x06019EA8 RID: 106152 RVA: 0x007FCE8D File Offset: 0x007FB08D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsExploreCameraTriggerVolume._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsExploreCameraTriggerVolume.TsExploreCameraTriggerVolume_C");
		}
		return TsExploreCameraTriggerVolume._ClassPtr;
	}

	// Token: 0x06019EA9 RID: 106153 RVA: 0x007FCEB4 File Offset: 0x007FB0B4
	public TsExploreCameraTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(TsExploreCameraTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019EAA RID: 106154 RVA: 0x007FCEDC File Offset: 0x007FB0DC
	[NullableContext(1)]
	public TsExploreCameraTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreCameraTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019EAB RID: 106155 RVA: 0x007FCF0F File Offset: 0x007FB10F
	protected TsExploreCameraTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E361 RID: 58209
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/TsExploreCameraTriggerVolume.TsExploreCameraTriggerVolume_C";

	// Token: 0x0400E362 RID: 58210
	private static IntPtr _ClassPtr;

	// Token: 0x0400E363 RID: 58211
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E364 RID: 58212
	private static int __PropertyOffset_Id;

	// Token: 0x0400E365 RID: 58213
	private static int __PropertyOffset_LookAtActor1;

	// Token: 0x0400E366 RID: 58214
	private static int __PropertyOffset_LookAtActor2;

	// Token: 0x0400E367 RID: 58215
	private static int __PropertyOffset_PrepTime;

	// Token: 0x0400E368 RID: 58216
	private static int __PropertyOffset_FadeDistance;

	// Token: 0x0400E369 RID: 58217
	private static int __PropertyOffset_ArmLengthMin;

	// Token: 0x0400E36A RID: 58218
	private static int __PropertyOffset_ArmLengthMax;
}
