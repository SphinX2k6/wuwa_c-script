using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools
{
	// Token: 0x02003A6C RID: 14956
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/BP_Tools/InstanceVolumeParametersStructure.InstanceVolumeParametersStructure")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class InstanceVolumeParametersStructure : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F9C7 RID: 129479 RVA: 0x008BD364 File Offset: 0x008BB564
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (InstanceVolumeParametersStructure._ScriptStructPtr != 0) ? InstanceVolumeParametersStructure._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/Assets/PCG/BP_Tools/InstanceVolumeParametersStructure.InstanceVolumeParametersStructure", ref InstanceVolumeParametersStructure._ScriptStructPtr);
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x0601F9C8 RID: 129480 RVA: 0x008BD388 File Offset: 0x008BB588
		// (set) Token: 0x0601F9C9 RID: 129481 RVA: 0x008BD39C File Offset: 0x008BB59C
		public unsafe string ActorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x0601F9CA RID: 129482 RVA: 0x008BD3B1 File Offset: 0x008BB5B1
		// (set) Token: 0x0601F9CB RID: 129483 RVA: 0x008BD3C1 File Offset: 0x008BB5C1
		public unsafe bool Delete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x0601F9CC RID: 129484 RVA: 0x008BD3D2 File Offset: 0x008BB5D2
		// (set) Token: 0x0601F9CD RID: 129485 RVA: 0x008BD3E2 File Offset: 0x008BB5E2
		public unsafe float Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x0601F9CE RID: 129486 RVA: 0x008BD3F3 File Offset: 0x008BB5F3
		// (set) Token: 0x0601F9CF RID: 129487 RVA: 0x008BD407 File Offset: 0x008BB607
		public unsafe string ReplaceInstance
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)InstanceVolumeParametersStructure.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x0601F9D0 RID: 129488 RVA: 0x008BD41C File Offset: 0x008BB61C
		public InstanceVolumeParametersStructure()
		{
		}

		// Token: 0x0601F9D1 RID: 129489 RVA: 0x008BD424 File Offset: 0x008BB624
		public InstanceVolumeParametersStructure(string ActorName, bool Delete, float Rotation, string ReplaceInstance)
		{
			this.ActorName = ActorName;
			this.Delete = Delete;
			this.Rotation = Rotation;
			this.ReplaceInstance = ReplaceInstance;
		}

		// Token: 0x0601F9D2 RID: 129490 RVA: 0x008BD449 File Offset: 0x008BB649
		protected override IntPtr GetUStructPtr()
		{
			return InstanceVolumeParametersStructure.StaticStruct();
		}

		// Token: 0x0601F9D3 RID: 129491 RVA: 0x008BD455 File Offset: 0x008BB655
		[NullableContext(2)]
		public InstanceVolumeParametersStructure(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F9D4 RID: 129492 RVA: 0x008BD45F File Offset: 0x008BB65F
		public InstanceVolumeParametersStructure(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F9D5 RID: 129493 RVA: 0x008BD46A File Offset: 0x008BB66A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new InstanceVolumeParametersStructure(Pointer, false, true);
		}

		// Token: 0x0601F9D6 RID: 129494 RVA: 0x008BD474 File Offset: 0x008BB674
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new InstanceVolumeParametersStructure(Pointer, MemoryOwner);
		}

		// Token: 0x0400F364 RID: 62308
		public const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/BP_Tools/InstanceVolumeParametersStructure.InstanceVolumeParametersStructure";

		// Token: 0x0400F365 RID: 62309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F366 RID: 62310
		internal static int __PropertyOffset_0;

		// Token: 0x0400F367 RID: 62311
		internal static int __PropertyOffset_1;

		// Token: 0x0400F368 RID: 62312
		internal static int __PropertyOffset_2;

		// Token: 0x0400F369 RID: 62313
		internal static int __PropertyOffset_3;
	}
}
