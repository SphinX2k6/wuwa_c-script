using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Scene3DUI.Struct
{
	// Token: 0x02003E99 RID: 16025
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Scene3DUI/Struct/SSceneDecorationConfig.SSceneDecorationConfig")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SSceneDecorationConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602883F RID: 165951 RVA: 0x009AE2D7 File Offset: 0x009AC4D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneDecorationConfig._ScriptStructPtr != 0) ? SSceneDecorationConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Scene3DUI/Struct/SSceneDecorationConfig.SSceneDecorationConfig", ref SSceneDecorationConfig._ScriptStructPtr);
		}

		// Token: 0x17005E44 RID: 24132
		// (get) Token: 0x06028840 RID: 165952 RVA: 0x009AE2FB File Offset: 0x009AC4FB
		// (set) Token: 0x06028841 RID: 165953 RVA: 0x009AE30F File Offset: 0x009AC50F
		public unsafe string ResourcePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSceneDecorationConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSceneDecorationConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005E45 RID: 24133
		// (get) Token: 0x06028842 RID: 165954 RVA: 0x009AE324 File Offset: 0x009AC524
		// (set) Token: 0x06028843 RID: 165955 RVA: 0x009AE338 File Offset: 0x009AC538
		public unsafe string SceneClassTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSceneDecorationConfig.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSceneDecorationConfig.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17005E46 RID: 24134
		// (get) Token: 0x06028844 RID: 165956 RVA: 0x009AE34D File Offset: 0x009AC54D
		// (set) Token: 0x06028845 RID: 165957 RVA: 0x009AE361 File Offset: 0x009AC561
		public unsafe string ViewClassTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSceneDecorationConfig.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSceneDecorationConfig.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x06028846 RID: 165958 RVA: 0x009AE376 File Offset: 0x009AC576
		public SSceneDecorationConfig()
		{
		}

		// Token: 0x06028847 RID: 165959 RVA: 0x009AE37E File Offset: 0x009AC57E
		public SSceneDecorationConfig(string ResourcePath, string SceneClassTag, string ViewClassTag)
		{
			this.ResourcePath = ResourcePath;
			this.SceneClassTag = SceneClassTag;
			this.ViewClassTag = ViewClassTag;
		}

		// Token: 0x06028848 RID: 165960 RVA: 0x009AE39B File Offset: 0x009AC59B
		protected override IntPtr GetUStructPtr()
		{
			return SSceneDecorationConfig.StaticStruct();
		}

		// Token: 0x06028849 RID: 165961 RVA: 0x009AE3A7 File Offset: 0x009AC5A7
		[NullableContext(2)]
		public SSceneDecorationConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602884A RID: 165962 RVA: 0x009AE3B1 File Offset: 0x009AC5B1
		public SSceneDecorationConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602884B RID: 165963 RVA: 0x009AE3BC File Offset: 0x009AC5BC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneDecorationConfig(Pointer, false, true);
		}

		// Token: 0x0602884C RID: 165964 RVA: 0x009AE3C6 File Offset: 0x009AC5C6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneDecorationConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014AA7 RID: 84647
		public const string __ObjectPath = "/Game/Aki/Data/Scene3DUI/Struct/SSceneDecorationConfig.SSceneDecorationConfig";

		// Token: 0x04014AA8 RID: 84648
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AA9 RID: 84649
		internal static int __PropertyOffset_0;

		// Token: 0x04014AAA RID: 84650
		internal static int __PropertyOffset_1;

		// Token: 0x04014AAB RID: 84651
		internal static int __PropertyOffset_2;
	}
}
