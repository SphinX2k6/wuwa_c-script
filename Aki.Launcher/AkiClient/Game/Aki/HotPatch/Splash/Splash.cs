using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch.Splash
{
	// Token: 0x02000027 RID: 39
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/HotPatch/Splash/Splash.Splash")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class Splash : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600016E RID: 366 RVA: 0x000092C7 File Offset: 0x000074C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Splash._ScriptStructPtr != 0) ? Splash._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/HotPatch/Splash/Splash.Splash", ref Splash._ScriptStructPtr);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000092EB File Offset: 0x000074EB
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000092FF File Offset: 0x000074FF
		[Nullable(2)]
		public unsafe UTexture2D value
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Splash.__PropertyOffset_value);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Splash.__PropertyOffset_value, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00009314 File Offset: 0x00007514
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00009328 File Offset: 0x00007528
		public unsafe string path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Splash.__PropertyOffset_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Splash.__PropertyOffset_path)), value);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000933D File Offset: 0x0000753D
		public Splash()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00009345 File Offset: 0x00007545
		public Splash(UTexture2D value, string path)
		{
			this.value = value;
			this.path = path;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000935B File Offset: 0x0000755B
		protected override IntPtr GetUStructPtr()
		{
			return Splash.StaticStruct();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00009367 File Offset: 0x00007567
		[NullableContext(2)]
		public Splash(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00009371 File Offset: 0x00007571
		public Splash(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000937C File Offset: 0x0000757C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Splash(Pointer, false, true);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00009386 File Offset: 0x00007586
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Splash(Pointer, MemoryOwner);
		}

		// Token: 0x040000B0 RID: 176
		public const string __ObjectPath = "/Game/Aki/HotPatch/Splash/Splash.Splash";

		// Token: 0x040000B1 RID: 177
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040000B2 RID: 178
		internal static int __PropertyOffset_value;

		// Token: 0x040000B3 RID: 179
		internal static int __PropertyOffset_path;
	}
}
