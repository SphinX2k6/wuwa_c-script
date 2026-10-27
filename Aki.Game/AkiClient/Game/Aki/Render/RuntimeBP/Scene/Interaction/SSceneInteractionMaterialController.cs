using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B4B RID: 15179
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialController.SSceneInteractionMaterialController")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 41)]
	public class SSceneInteractionMaterialController : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219C3 RID: 137667 RVA: 0x008F0E13 File Offset: 0x008EF013
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionMaterialController._ScriptStructPtr != 0) ? SSceneInteractionMaterialController._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialController.SSceneInteractionMaterialController", ref SSceneInteractionMaterialController._ScriptStructPtr);
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x060219C4 RID: 137668 RVA: 0x008F0E38 File Offset: 0x008EF038
		// (set) Token: 0x060219C5 RID: 137669 RVA: 0x008F0E7B File Offset: 0x008EF07B
		public TArray<AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x060219C6 RID: 137670 RVA: 0x008F0E89 File Offset: 0x008EF089
		// (set) Token: 0x060219C7 RID: 137671 RVA: 0x008F0E9D File Offset: 0x008EF09D
		[Nullable(2)]
		public unsafe ItemMaterialControllerActorData Data
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerActorData>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x060219C8 RID: 137672 RVA: 0x008F0EB2 File Offset: 0x008EF0B2
		// (set) Token: 0x060219C9 RID: 137673 RVA: 0x008F0EC2 File Offset: 0x008EF0C2
		public unsafe float TailIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x060219CA RID: 137674 RVA: 0x008F0ED3 File Offset: 0x008EF0D3
		// (set) Token: 0x060219CB RID: 137675 RVA: 0x008F0EE7 File Offset: 0x008EF0E7
		[Nullable(2)]
		public unsafe UMaterialInstance Materials
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMaterialController.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x060219CC RID: 137676 RVA: 0x008F0EFC File Offset: 0x008EF0FC
		// (set) Token: 0x060219CD RID: 137677 RVA: 0x008F0F0C File Offset: 0x008EF10C
		public unsafe bool IsRevertMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMaterialController.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x060219CE RID: 137678 RVA: 0x008F0F1D File Offset: 0x008EF11D
		public SSceneInteractionMaterialController()
		{
		}

		// Token: 0x060219CF RID: 137679 RVA: 0x008F0F25 File Offset: 0x008EF125
		public SSceneInteractionMaterialController(TArray<AActor> Actors, ItemMaterialControllerActorData Data, float TailIndex, UMaterialInstance Materials, bool IsRevertMaterial)
		{
			this.Actors = Actors;
			this.Data = Data;
			this.TailIndex = TailIndex;
			this.Materials = Materials;
			this.IsRevertMaterial = IsRevertMaterial;
		}

		// Token: 0x060219D0 RID: 137680 RVA: 0x008F0F52 File Offset: 0x008EF152
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionMaterialController.StaticStruct();
		}

		// Token: 0x060219D1 RID: 137681 RVA: 0x008F0F5E File Offset: 0x008EF15E
		[NullableContext(2)]
		public SSceneInteractionMaterialController(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219D2 RID: 137682 RVA: 0x008F0F68 File Offset: 0x008EF168
		public SSceneInteractionMaterialController(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219D3 RID: 137683 RVA: 0x008F0F73 File Offset: 0x008EF173
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionMaterialController(Pointer, false, true);
		}

		// Token: 0x060219D4 RID: 137684 RVA: 0x008F0F7D File Offset: 0x008EF17D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionMaterialController(Pointer, MemoryOwner);
		}

		// Token: 0x04010635 RID: 67125
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialController.SSceneInteractionMaterialController";

		// Token: 0x04010636 RID: 67126
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010637 RID: 67127
		internal static int __PropertyOffset_0;

		// Token: 0x04010638 RID: 67128
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;

		// Token: 0x04010639 RID: 67129
		internal static int __PropertyOffset_1;

		// Token: 0x0401063A RID: 67130
		internal static int __PropertyOffset_2;

		// Token: 0x0401063B RID: 67131
		internal static int __PropertyOffset_3;

		// Token: 0x0401063C RID: 67132
		internal static int __PropertyOffset_4;
	}
}
