using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003337 RID: 13111
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionCircle.SBatchBulletPositionCircle")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SBatchBulletPositionCircle : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060211F3 RID: 135667 RVA: 0x00959C49 File Offset: 0x00957E49
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBatchBulletPositionCircle._ScriptStructPtr != 0) ? SBatchBulletPositionCircle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionCircle.SBatchBulletPositionCircle", ref SBatchBulletPositionCircle._ScriptStructPtr);
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x060211F4 RID: 135668 RVA: 0x00959C6D File Offset: 0x00957E6D
		// (set) Token: 0x060211F5 RID: 135669 RVA: 0x00959C81 File Offset: 0x00957E81
		public unsafe string CenterKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_CenterKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_CenterKey)), value);
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x060211F6 RID: 135670 RVA: 0x00959C96 File Offset: 0x00957E96
		// (set) Token: 0x060211F7 RID: 135671 RVA: 0x00959CAA File Offset: 0x00957EAA
		public unsafe string RadiusKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_RadiusKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_RadiusKey)), value);
			}
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x060211F8 RID: 135672 RVA: 0x00959CBF File Offset: 0x00957EBF
		// (set) Token: 0x060211F9 RID: 135673 RVA: 0x00959CD3 File Offset: 0x00957ED3
		public unsafe string ForwardKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_ForwardKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_ForwardKey)), value);
			}
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x060211FA RID: 135674 RVA: 0x00959CE8 File Offset: 0x00957EE8
		// (set) Token: 0x060211FB RID: 135675 RVA: 0x00959CF8 File Offset: 0x00957EF8
		public unsafe bool Clockwise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_Clockwise) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_Clockwise) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x060211FC RID: 135676 RVA: 0x00959D09 File Offset: 0x00957F09
		// (set) Token: 0x060211FD RID: 135677 RVA: 0x00959D19 File Offset: 0x00957F19
		public unsafe float BeginAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_BeginAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_BeginAngle) = value;
			}
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x060211FE RID: 135678 RVA: 0x00959D2A File Offset: 0x00957F2A
		// (set) Token: 0x060211FF RID: 135679 RVA: 0x00959D3E File Offset: 0x00957F3E
		public unsafe string AngleIntervalKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_AngleIntervalKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_AngleIntervalKey)), value);
			}
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x06021200 RID: 135680 RVA: 0x00959D53 File Offset: 0x00957F53
		// (set) Token: 0x06021201 RID: 135681 RVA: 0x00959D67 File Offset: 0x00957F67
		[Nullable(0)]
		public unsafe TEnumAsByte<EBatchBulletBeginRotator> BeginRotator
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_BeginRotator);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_BeginRotator) = value;
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x06021202 RID: 135682 RVA: 0x00959D7C File Offset: 0x00957F7C
		// (set) Token: 0x06021203 RID: 135683 RVA: 0x00959D90 File Offset: 0x00957F90
		public unsafe string StartPosKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_StartPosKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_StartPosKey)), value);
			}
		}

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x06021204 RID: 135684 RVA: 0x00959DA5 File Offset: 0x00957FA5
		// (set) Token: 0x06021205 RID: 135685 RVA: 0x00959DB9 File Offset: 0x00957FB9
		public unsafe string DistToTarget
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_DistToTarget)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_DistToTarget)), value);
			}
		}

		// Token: 0x06021206 RID: 135686 RVA: 0x00959DCE File Offset: 0x00957FCE
		public SBatchBulletPositionCircle()
		{
		}

		// Token: 0x06021207 RID: 135687 RVA: 0x00959DD6 File Offset: 0x00957FD6
		protected override IntPtr GetUStructPtr()
		{
			return SBatchBulletPositionCircle.StaticStruct();
		}

		// Token: 0x06021208 RID: 135688 RVA: 0x00959DE2 File Offset: 0x00957FE2
		[NullableContext(2)]
		public SBatchBulletPositionCircle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021209 RID: 135689 RVA: 0x00959DEC File Offset: 0x00957FEC
		public SBatchBulletPositionCircle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602120A RID: 135690 RVA: 0x00959DF7 File Offset: 0x00957FF7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBatchBulletPositionCircle(Pointer, false, true);
		}

		// Token: 0x0602120B RID: 135691 RVA: 0x00959E01 File Offset: 0x00958001
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBatchBulletPositionCircle(Pointer, MemoryOwner);
		}

		// Token: 0x040121C7 RID: 74183
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBatchBulletPositionCircle.SBatchBulletPositionCircle";

		// Token: 0x040121C8 RID: 74184
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121C9 RID: 74185
		internal static int __PropertyOffset_CenterKey;

		// Token: 0x040121CA RID: 74186
		internal static int __PropertyOffset_RadiusKey;

		// Token: 0x040121CB RID: 74187
		internal static int __PropertyOffset_ForwardKey;

		// Token: 0x040121CC RID: 74188
		internal static int __PropertyOffset_Clockwise;

		// Token: 0x040121CD RID: 74189
		internal static int __PropertyOffset_BeginAngle;

		// Token: 0x040121CE RID: 74190
		internal static int __PropertyOffset_AngleIntervalKey;

		// Token: 0x040121CF RID: 74191
		internal static int __PropertyOffset_BeginRotator;

		// Token: 0x040121D0 RID: 74192
		internal static int __PropertyOffset_StartPosKey;

		// Token: 0x040121D1 RID: 74193
		internal static int __PropertyOffset_DistToTarget;
	}
}
