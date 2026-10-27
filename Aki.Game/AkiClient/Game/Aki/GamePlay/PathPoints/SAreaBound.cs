using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.PathPoints
{
	// Token: 0x02003E5B RID: 15963
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/GamePlay/PathPoints/SAreaBound.SAreaBound")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SAreaBound : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028219 RID: 164377 RVA: 0x009A4E40 File Offset: 0x009A3040
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAreaBound._ScriptStructPtr != 0) ? SAreaBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/PathPoints/SAreaBound.SAreaBound", ref SAreaBound._ScriptStructPtr);
		}

		// Token: 0x17005BDF RID: 23519
		// (get) Token: 0x0602821A RID: 164378 RVA: 0x009A4E64 File Offset: 0x009A3064
		// (set) Token: 0x0602821B RID: 164379 RVA: 0x009A4E78 File Offset: 0x009A3078
		public unsafe string AreaName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAreaBound.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAreaBound.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005BE0 RID: 23520
		// (get) Token: 0x0602821C RID: 164380 RVA: 0x009A4E8D File Offset: 0x009A308D
		// (set) Token: 0x0602821D RID: 164381 RVA: 0x009A4E9D File Offset: 0x009A309D
		public unsafe float MinX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005BE1 RID: 23521
		// (get) Token: 0x0602821E RID: 164382 RVA: 0x009A4EAE File Offset: 0x009A30AE
		// (set) Token: 0x0602821F RID: 164383 RVA: 0x009A4EBE File Offset: 0x009A30BE
		public unsafe float MinY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005BE2 RID: 23522
		// (get) Token: 0x06028220 RID: 164384 RVA: 0x009A4ECF File Offset: 0x009A30CF
		// (set) Token: 0x06028221 RID: 164385 RVA: 0x009A4EDF File Offset: 0x009A30DF
		public unsafe float MinZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005BE3 RID: 23523
		// (get) Token: 0x06028222 RID: 164386 RVA: 0x009A4EF0 File Offset: 0x009A30F0
		// (set) Token: 0x06028223 RID: 164387 RVA: 0x009A4F00 File Offset: 0x009A3100
		public unsafe float MaxX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005BE4 RID: 23524
		// (get) Token: 0x06028224 RID: 164388 RVA: 0x009A4F11 File Offset: 0x009A3111
		// (set) Token: 0x06028225 RID: 164389 RVA: 0x009A4F21 File Offset: 0x009A3121
		public unsafe float MaxY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005BE5 RID: 23525
		// (get) Token: 0x06028226 RID: 164390 RVA: 0x009A4F32 File Offset: 0x009A3132
		// (set) Token: 0x06028227 RID: 164391 RVA: 0x009A4F42 File Offset: 0x009A3142
		public unsafe float MaxZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAreaBound.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06028228 RID: 164392 RVA: 0x009A4F53 File Offset: 0x009A3153
		public SAreaBound()
		{
		}

		// Token: 0x06028229 RID: 164393 RVA: 0x009A4F5B File Offset: 0x009A315B
		public SAreaBound(string AreaName, float MinX, float MinY, float MinZ, float MaxX, float MaxY, float MaxZ)
		{
			this.AreaName = AreaName;
			this.MinX = MinX;
			this.MinY = MinY;
			this.MinZ = MinZ;
			this.MaxX = MaxX;
			this.MaxY = MaxY;
			this.MaxZ = MaxZ;
		}

		// Token: 0x0602822A RID: 164394 RVA: 0x009A4F98 File Offset: 0x009A3198
		protected override IntPtr GetUStructPtr()
		{
			return SAreaBound.StaticStruct();
		}

		// Token: 0x0602822B RID: 164395 RVA: 0x009A4FA4 File Offset: 0x009A31A4
		[NullableContext(2)]
		public SAreaBound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602822C RID: 164396 RVA: 0x009A4FAE File Offset: 0x009A31AE
		public SAreaBound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602822D RID: 164397 RVA: 0x009A4FB9 File Offset: 0x009A31B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAreaBound(Pointer, false, true);
		}

		// Token: 0x0602822E RID: 164398 RVA: 0x009A4FC3 File Offset: 0x009A31C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAreaBound(Pointer, MemoryOwner);
		}

		// Token: 0x040146D1 RID: 83665
		public const string __ObjectPath = "/Game/Aki/GamePlay/PathPoints/SAreaBound.SAreaBound";

		// Token: 0x040146D2 RID: 83666
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040146D3 RID: 83667
		internal static int __PropertyOffset_0;

		// Token: 0x040146D4 RID: 83668
		internal static int __PropertyOffset_1;

		// Token: 0x040146D5 RID: 83669
		internal static int __PropertyOffset_2;

		// Token: 0x040146D6 RID: 83670
		internal static int __PropertyOffset_3;

		// Token: 0x040146D7 RID: 83671
		internal static int __PropertyOffset_4;

		// Token: 0x040146D8 RID: 83672
		internal static int __PropertyOffset_5;

		// Token: 0x040146D9 RID: 83673
		internal static int __PropertyOffset_6;
	}
}
