using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C4 RID: 12484
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialController.SSceneInteractionMaterialController")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 41)]
	public class SSceneInteractionMaterialController : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E05E RID: 122974 RVA: 0x00908B9E File Offset: 0x00906D9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionMaterialController._ScriptStructPtr != 0) ? SSceneInteractionMaterialController._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialController.SSceneInteractionMaterialController", ref SSceneInteractionMaterialController._ScriptStructPtr);
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0601E05F RID: 122975 RVA: 0x00908BC4 File Offset: 0x00906DC4
		// (set) Token: 0x0601E060 RID: 122976 RVA: 0x00908C07 File Offset: 0x00906E07
		[Nullable(1)]
		public TArray<AActor> Actors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_Actors, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0601E061 RID: 122977 RVA: 0x00908C15 File Offset: 0x00906E15
		// (set) Token: 0x0601E062 RID: 122978 RVA: 0x00908C29 File Offset: 0x00906E29
		public unsafe ItemMaterialControllerActorData Data
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerActorData>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_Data);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_Data, value);
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0601E063 RID: 122979 RVA: 0x00908C3E File Offset: 0x00906E3E
		// (set) Token: 0x0601E064 RID: 122980 RVA: 0x00908C4E File Offset: 0x00906E4E
		public unsafe float TailIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_TailIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_TailIndex) = value;
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0601E065 RID: 122981 RVA: 0x00908C5F File Offset: 0x00906E5F
		// (set) Token: 0x0601E066 RID: 122982 RVA: 0x00908C73 File Offset: 0x00906E73
		public unsafe UMaterialInstance Materials
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_Materials);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_Materials, value);
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0601E067 RID: 122983 RVA: 0x00908C88 File Offset: 0x00906E88
		// (set) Token: 0x0601E068 RID: 122984 RVA: 0x00908C98 File Offset: 0x00906E98
		public unsafe bool IsRevertMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_IsRevertMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_IsRevertMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E069 RID: 122985 RVA: 0x00908CA9 File Offset: 0x00906EA9
		public SSceneInteractionMaterialController()
		{
		}

		// Token: 0x0601E06A RID: 122986 RVA: 0x00908CB1 File Offset: 0x00906EB1
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionMaterialController.StaticStruct();
		}

		// Token: 0x0601E06B RID: 122987 RVA: 0x00908CBD File Offset: 0x00906EBD
		public SSceneInteractionMaterialController(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E06C RID: 122988 RVA: 0x00908CC7 File Offset: 0x00906EC7
		public SSceneInteractionMaterialController(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E06D RID: 122989 RVA: 0x00908CD2 File Offset: 0x00906ED2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionMaterialController(Pointer, false, true);
		}

		// Token: 0x0601E06E RID: 122990 RVA: 0x00908CDC File Offset: 0x00906EDC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionMaterialController(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDDE RID: 64990
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialController.SSceneInteractionMaterialController";

		// Token: 0x0400FDDF RID: 64991
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDE0 RID: 64992
		internal static int __PropertyOffset_Actors;

		// Token: 0x0400FDE1 RID: 64993
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;

		// Token: 0x0400FDE2 RID: 64994
		internal static int __PropertyOffset_Data;

		// Token: 0x0400FDE3 RID: 64995
		internal static int __PropertyOffset_TailIndex;

		// Token: 0x0400FDE4 RID: 64996
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400FDE5 RID: 64997
		internal static int __PropertyOffset_IsRevertMaterial;
	}
}
