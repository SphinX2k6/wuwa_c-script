using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E1E RID: 15902
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureGroup.SMaterialControllerTextureGroup")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SMaterialControllerTextureGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027DC9 RID: 163273 RVA: 0x0099D3AC File Offset: 0x0099B5AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerTextureGroup._ScriptStructPtr != 0) ? SMaterialControllerTextureGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureGroup.SMaterialControllerTextureGroup", ref SMaterialControllerTextureGroup._ScriptStructPtr);
		}

		// Token: 0x17005A7D RID: 23165
		// (get) Token: 0x06027DCA RID: 163274 RVA: 0x0099D3D0 File Offset: 0x0099B5D0
		// (set) Token: 0x06027DCB RID: 163275 RVA: 0x0099D3E4 File Offset: 0x0099B5E4
		public unsafe UTexture2D Start
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005A7E RID: 23166
		// (get) Token: 0x06027DCC RID: 163276 RVA: 0x0099D3F9 File Offset: 0x0099B5F9
		// (set) Token: 0x06027DCD RID: 163277 RVA: 0x0099D40D File Offset: 0x0099B60D
		public unsafe UTexture2D Loop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005A7F RID: 23167
		// (get) Token: 0x06027DCE RID: 163278 RVA: 0x0099D422 File Offset: 0x0099B622
		// (set) Token: 0x06027DCF RID: 163279 RVA: 0x0099D436 File Offset: 0x0099B636
		public unsafe UTexture2D End
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMaterialControllerTextureGroup.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06027DD0 RID: 163280 RVA: 0x0099D44B File Offset: 0x0099B64B
		public SMaterialControllerTextureGroup()
		{
		}

		// Token: 0x06027DD1 RID: 163281 RVA: 0x0099D453 File Offset: 0x0099B653
		[NullableContext(1)]
		public SMaterialControllerTextureGroup(UTexture2D Start, UTexture2D Loop, UTexture2D End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x06027DD2 RID: 163282 RVA: 0x0099D470 File Offset: 0x0099B670
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerTextureGroup.StaticStruct();
		}

		// Token: 0x06027DD3 RID: 163283 RVA: 0x0099D47C File Offset: 0x0099B67C
		public SMaterialControllerTextureGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027DD4 RID: 163284 RVA: 0x0099D486 File Offset: 0x0099B686
		public SMaterialControllerTextureGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027DD5 RID: 163285 RVA: 0x0099D491 File Offset: 0x0099B691
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerTextureGroup(Pointer, false, true);
		}

		// Token: 0x06027DD6 RID: 163286 RVA: 0x0099D49B File Offset: 0x0099B69B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerTextureGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04014357 RID: 82775
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureGroup.SMaterialControllerTextureGroup";

		// Token: 0x04014358 RID: 82776
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014359 RID: 82777
		internal static int __PropertyOffset_0;

		// Token: 0x0401435A RID: 82778
		internal static int __PropertyOffset_1;

		// Token: 0x0401435B RID: 82779
		internal static int __PropertyOffset_2;
	}
}
