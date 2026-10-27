using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200430D RID: 17165
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDangoPerformEffectData.SDangoPerformEffectData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SDangoPerformEffectData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C65A RID: 181850 RVA: 0x00A1EEA6 File Offset: 0x00A1D0A6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDangoPerformEffectData._ScriptStructPtr != 0) ? SDangoPerformEffectData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDangoPerformEffectData.SDangoPerformEffectData", ref SDangoPerformEffectData._ScriptStructPtr);
		}

		// Token: 0x17006F13 RID: 28435
		// (get) Token: 0x0602C65B RID: 181851 RVA: 0x00A1EECA File Offset: 0x00A1D0CA
		// (set) Token: 0x0602C65C RID: 181852 RVA: 0x00A1EEE9 File Offset: 0x00A1D0E9
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> 特效路径
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006F14 RID: 28436
		// (get) Token: 0x0602C65D RID: 181853 RVA: 0x00A1EF0E File Offset: 0x00A1D10E
		// (set) Token: 0x0602C65E RID: 181854 RVA: 0x00A1EF22 File Offset: 0x00A1D122
		public unsafe TEnumAsByte<EDangoPerformLocationType> 特效位置类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F15 RID: 28437
		// (get) Token: 0x0602C65F RID: 181855 RVA: 0x00A1EF37 File Offset: 0x00A1D137
		// (set) Token: 0x0602C660 RID: 181856 RVA: 0x00A1EF4B File Offset: 0x00A1D14B
		public unsafe FVector 位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F16 RID: 28438
		// (get) Token: 0x0602C661 RID: 181857 RVA: 0x00A1EF60 File Offset: 0x00A1D160
		// (set) Token: 0x0602C662 RID: 181858 RVA: 0x00A1EF74 File Offset: 0x00A1D174
		public unsafe FName 骨骼名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F17 RID: 28439
		// (get) Token: 0x0602C663 RID: 181859 RVA: 0x00A1EF89 File Offset: 0x00A1D189
		// (set) Token: 0x0602C664 RID: 181860 RVA: 0x00A1EF99 File Offset: 0x00A1D199
		public unsafe int 释放延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformEffectData.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602C665 RID: 181861 RVA: 0x00A1EFAA File Offset: 0x00A1D1AA
		public SDangoPerformEffectData()
		{
		}

		// Token: 0x0602C666 RID: 181862 RVA: 0x00A1EFB2 File Offset: 0x00A1D1B2
		public SDangoPerformEffectData([Nullable(1)] TSoftObjectPtr<UEffectModelBase> 特效路径, TEnumAsByte<EDangoPerformLocationType> 特效位置类型, FVector 位置偏移, FName 骨骼名称, int 释放延迟时间)
		{
			this.特效路径 = 特效路径;
			this.特效位置类型 = 特效位置类型;
			this.位置偏移 = 位置偏移;
			this.骨骼名称 = 骨骼名称;
			this.释放延迟时间 = 释放延迟时间;
		}

		// Token: 0x0602C667 RID: 181863 RVA: 0x00A1EFDF File Offset: 0x00A1D1DF
		protected override IntPtr GetUStructPtr()
		{
			return SDangoPerformEffectData.StaticStruct();
		}

		// Token: 0x0602C668 RID: 181864 RVA: 0x00A1EFEB File Offset: 0x00A1D1EB
		[NullableContext(2)]
		public SDangoPerformEffectData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C669 RID: 181865 RVA: 0x00A1EFF5 File Offset: 0x00A1D1F5
		public SDangoPerformEffectData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C66A RID: 181866 RVA: 0x00A1F000 File Offset: 0x00A1D200
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDangoPerformEffectData(Pointer, false, true);
		}

		// Token: 0x0602C66B RID: 181867 RVA: 0x00A1F00A File Offset: 0x00A1D20A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDangoPerformEffectData(Pointer, MemoryOwner);
		}

		// Token: 0x0401768E RID: 95886
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDangoPerformEffectData.SDangoPerformEffectData";

		// Token: 0x0401768F RID: 95887
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017690 RID: 95888
		internal static int __PropertyOffset_0;

		// Token: 0x04017691 RID: 95889
		internal static int __PropertyOffset_1;

		// Token: 0x04017692 RID: 95890
		internal static int __PropertyOffset_2;

		// Token: 0x04017693 RID: 95891
		internal static int __PropertyOffset_3;

		// Token: 0x04017694 RID: 95892
		internal static int __PropertyOffset_4;
	}
}
