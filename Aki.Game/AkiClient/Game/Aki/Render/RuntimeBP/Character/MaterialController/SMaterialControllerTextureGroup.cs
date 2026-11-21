using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003135 RID: 12597
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureGroup.SMaterialControllerTextureGroup")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SMaterialControllerTextureGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EFCD RID: 126925 RVA: 0x00922E7A File Offset: 0x0092107A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerTextureGroup._ScriptStructPtr != 0) ? SMaterialControllerTextureGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureGroup.SMaterialControllerTextureGroup", ref SMaterialControllerTextureGroup._ScriptStructPtr);
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0601EFCE RID: 126926 RVA: 0x00922E9E File Offset: 0x0092109E
		// (set) Token: 0x0601EFCF RID: 126927 RVA: 0x00922EB2 File Offset: 0x009210B2
		public unsafe UTexture2D Start
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_Start);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_Start, value);
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0601EFD0 RID: 126928 RVA: 0x00922EC7 File Offset: 0x009210C7
		// (set) Token: 0x0601EFD1 RID: 126929 RVA: 0x00922EDB File Offset: 0x009210DB
		public unsafe UTexture2D Loop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_Loop);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_Loop, value);
			}
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0601EFD2 RID: 126930 RVA: 0x00922EF0 File Offset: 0x009210F0
		// (set) Token: 0x0601EFD3 RID: 126931 RVA: 0x00922F04 File Offset: 0x00921104
		public unsafe UTexture2D End
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_End);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_End, value);
			}
		}

		// Token: 0x0601EFD4 RID: 126932 RVA: 0x00922F19 File Offset: 0x00921119
		public SMaterialControllerTextureGroup()
		{
		}

		// Token: 0x0601EFD5 RID: 126933 RVA: 0x00922F21 File Offset: 0x00921121
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerTextureGroup.StaticStruct();
		}

		// Token: 0x0601EFD6 RID: 126934 RVA: 0x00922F2D File Offset: 0x0092112D
		public SMaterialControllerTextureGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFD7 RID: 126935 RVA: 0x00922F37 File Offset: 0x00921137
		public SMaterialControllerTextureGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFD8 RID: 126936 RVA: 0x00922F42 File Offset: 0x00921142
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerTextureGroup(Pointer, false, true);
		}

		// Token: 0x0601EFD9 RID: 126937 RVA: 0x00922F4C File Offset: 0x0092114C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerTextureGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040107FC RID: 67580
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureGroup.SMaterialControllerTextureGroup";

		// Token: 0x040107FD RID: 67581
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040107FE RID: 67582
		internal static int __PropertyOffset_Start;

		// Token: 0x040107FF RID: 67583
		internal static int __PropertyOffset_Loop;

		// Token: 0x04010800 RID: 67584
		internal static int __PropertyOffset_End;
	}
}
