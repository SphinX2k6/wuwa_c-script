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
		// Token: 0x0600016E RID: 366 RVA: 0x0000928F File Offset: 0x0000748F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Splash._ScriptStructPtr != 0) ? Splash._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/HotPatch/Splash/Splash.Splash", ref Splash._ScriptStructPtr);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000092B3 File Offset: 0x000074B3
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000092C7 File Offset: 0x000074C7
		[Nullable(2)]
		public unsafe UTexture2D value
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Splash.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Splash.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000092DC File Offset: 0x000074DC
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000092F0 File Offset: 0x000074F0
		public unsafe string path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Splash.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Splash.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00009305 File Offset: 0x00007505
		public Splash()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000930D File Offset: 0x0000750D
		public Splash(UTexture2D value, string path)
		{
			this.value = value;
			this.path = path;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00009323 File Offset: 0x00007523
		protected override IntPtr GetUStructPtr()
		{
			return Splash.StaticStruct();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000932F File Offset: 0x0000752F
		[NullableContext(2)]
		public Splash(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00009339 File Offset: 0x00007539
		public Splash(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00009344 File Offset: 0x00007544
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Splash(Pointer, false, true);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000934E File Offset: 0x0000754E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Splash(Pointer, MemoryOwner);
		}

		// Token: 0x040000AF RID: 175
		public const string __ObjectPath = "/Game/Aki/HotPatch/Splash/Splash.Splash";

		// Token: 0x040000B0 RID: 176
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040000B1 RID: 177
		internal static int __PropertyOffset_0;

		// Token: 0x040000B2 RID: 178
		internal static int __PropertyOffset_1;
	}
}
