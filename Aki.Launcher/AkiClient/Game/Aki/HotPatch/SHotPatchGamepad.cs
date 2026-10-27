using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch
{
	// Token: 0x02000025 RID: 37
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/HotPatch/SHotPatchGamepad.SHotPatchGamepad")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SHotPatchGamepad : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000133 RID: 307 RVA: 0x000087A4 File Offset: 0x000069A4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHotPatchGamepad._ScriptStructPtr != 0) ? SHotPatchGamepad._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/HotPatch/SHotPatchGamepad.SHotPatchGamepad", ref SHotPatchGamepad._ScriptStructPtr);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000087C8 File Offset: 0x000069C8
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000087DC File Offset: 0x000069DC
		public unsafe string ActionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SHotPatchGamepad.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SHotPatchGamepad.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000087F1 File Offset: 0x000069F1
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00008805 File Offset: 0x00006A05
		[Nullable(2)]
		public unsafe AUITextureActor TextureActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUITextureActor>(base.NativePtr / (IntPtr)sizeof(void*) + SHotPatchGamepad.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHotPatchGamepad.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000881A File Offset: 0x00006A1A
		public SHotPatchGamepad()
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008822 File Offset: 0x00006A22
		public SHotPatchGamepad(string ActionName, AUITextureActor TextureActor)
		{
			this.ActionName = ActionName;
			this.TextureActor = TextureActor;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00008838 File Offset: 0x00006A38
		protected override IntPtr GetUStructPtr()
		{
			return SHotPatchGamepad.StaticStruct();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008844 File Offset: 0x00006A44
		[NullableContext(2)]
		public SHotPatchGamepad(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000884E File Offset: 0x00006A4E
		public SHotPatchGamepad(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008859 File Offset: 0x00006A59
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHotPatchGamepad(Pointer, false, true);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008863 File Offset: 0x00006A63
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHotPatchGamepad(Pointer, MemoryOwner);
		}

		// Token: 0x04000080 RID: 128
		public const string __ObjectPath = "/Game/Aki/HotPatch/SHotPatchGamepad.SHotPatchGamepad";

		// Token: 0x04000081 RID: 129
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000082 RID: 130
		internal static int __PropertyOffset_0;

		// Token: 0x04000083 RID: 131
		internal static int __PropertyOffset_1;
	}
}
