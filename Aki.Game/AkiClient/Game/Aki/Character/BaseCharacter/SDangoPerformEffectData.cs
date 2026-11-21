using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200334A RID: 13130
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDangoPerformEffectData.SDangoPerformEffectData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SDangoPerformEffectData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021378 RID: 136056 RVA: 0x0095BDDD File Offset: 0x00959FDD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDangoPerformEffectData._ScriptStructPtr != 0) ? SDangoPerformEffectData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDangoPerformEffectData.SDangoPerformEffectData", ref SDangoPerformEffectData._ScriptStructPtr);
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x06021379 RID: 136057 RVA: 0x0095BE01 File Offset: 0x0095A001
		// (set) Token: 0x0602137A RID: 136058 RVA: 0x0095BE20 File Offset: 0x0095A020
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> 特效路径
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_特效路径, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_特效路径, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x0602137B RID: 136059 RVA: 0x0095BE45 File Offset: 0x0095A045
		// (set) Token: 0x0602137C RID: 136060 RVA: 0x0095BE59 File Offset: 0x0095A059
		public unsafe TEnumAsByte<EDangoPerformLocationType> 特效位置类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_特效位置类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_特效位置类型) = value;
			}
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x0602137D RID: 136061 RVA: 0x0095BE6E File Offset: 0x0095A06E
		// (set) Token: 0x0602137E RID: 136062 RVA: 0x0095BE82 File Offset: 0x0095A082
		public unsafe FVector 位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_位置偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_位置偏移) = value;
			}
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x0602137F RID: 136063 RVA: 0x0095BE97 File Offset: 0x0095A097
		// (set) Token: 0x06021380 RID: 136064 RVA: 0x0095BEAB File Offset: 0x0095A0AB
		public unsafe FName 骨骼名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_骨骼名称);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_骨骼名称) = value;
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x06021381 RID: 136065 RVA: 0x0095BEC0 File Offset: 0x0095A0C0
		// (set) Token: 0x06021382 RID: 136066 RVA: 0x0095BED0 File Offset: 0x0095A0D0
		public unsafe int 释放延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_释放延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_释放延迟时间) = value;
			}
		}

		// Token: 0x06021383 RID: 136067 RVA: 0x0095BEE1 File Offset: 0x0095A0E1
		public SDangoPerformEffectData()
		{
		}

		// Token: 0x06021384 RID: 136068 RVA: 0x0095BEE9 File Offset: 0x0095A0E9
		protected override IntPtr GetUStructPtr()
		{
			return SDangoPerformEffectData.StaticStruct();
		}

		// Token: 0x06021385 RID: 136069 RVA: 0x0095BEF5 File Offset: 0x0095A0F5
		[NullableContext(2)]
		public SDangoPerformEffectData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021386 RID: 136070 RVA: 0x0095BEFF File Offset: 0x0095A0FF
		public SDangoPerformEffectData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021387 RID: 136071 RVA: 0x0095BF0A File Offset: 0x0095A10A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDangoPerformEffectData(Pointer, false, true);
		}

		// Token: 0x06021388 RID: 136072 RVA: 0x0095BF14 File Offset: 0x0095A114
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDangoPerformEffectData(Pointer, MemoryOwner);
		}

		// Token: 0x04012293 RID: 74387
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDangoPerformEffectData.SDangoPerformEffectData";

		// Token: 0x04012294 RID: 74388
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012295 RID: 74389
		internal static int __PropertyOffset_特效路径;

		// Token: 0x04012296 RID: 74390
		internal static int __PropertyOffset_特效位置类型;

		// Token: 0x04012297 RID: 74391
		internal static int __PropertyOffset_位置偏移;

		// Token: 0x04012298 RID: 74392
		internal static int __PropertyOffset_骨骼名称;

		// Token: 0x04012299 RID: 74393
		internal static int __PropertyOffset_释放延迟时间;
	}
}
