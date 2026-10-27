using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction
{
	// Token: 0x02003CFC RID: 15612
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/Struct_SceneInteractData.Struct_SceneInteractData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class Struct_SceneInteractData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025483 RID: 152707 RVA: 0x00955FAC File Offset: 0x009541AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_SceneInteractData._ScriptStructPtr != 0) ? Struct_SceneInteractData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/LeavesInteraction/Struct_SceneInteractData.Struct_SceneInteractData", ref Struct_SceneInteractData._ScriptStructPtr);
		}

		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x06025484 RID: 152708 RVA: 0x00955FD0 File Offset: 0x009541D0
		// (set) Token: 0x06025485 RID: 152709 RVA: 0x00955FE4 File Offset: 0x009541E4
		[Nullable(2)]
		public unsafe BP_SceneBattleInteract_C DataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_SceneInteractData.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_SceneInteractData.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x06025486 RID: 152710 RVA: 0x00955FF9 File Offset: 0x009541F9
		// (set) Token: 0x06025487 RID: 152711 RVA: 0x00956009 File Offset: 0x00954209
		public unsafe float ForceFieldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_SceneInteractData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_SceneInteractData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x06025488 RID: 152712 RVA: 0x0095601A File Offset: 0x0095421A
		// (set) Token: 0x06025489 RID: 152713 RVA: 0x0095602A File Offset: 0x0095422A
		public unsafe float RotationalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_SceneInteractData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_SceneInteractData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x0602548A RID: 152714 RVA: 0x0095603B File Offset: 0x0095423B
		// (set) Token: 0x0602548B RID: 152715 RVA: 0x0095604B File Offset: 0x0095424B
		public unsafe float CentripetalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_SceneInteractData.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_SceneInteractData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602548C RID: 152716 RVA: 0x0095605C File Offset: 0x0095425C
		public Struct_SceneInteractData()
		{
		}

		// Token: 0x0602548D RID: 152717 RVA: 0x00956064 File Offset: 0x00954264
		[NullableContext(1)]
		public Struct_SceneInteractData(BP_SceneBattleInteract_C DataAsset, float ForceFieldRadius, float RotationalForceField, float CentripetalForceField)
		{
			this.DataAsset = DataAsset;
			this.ForceFieldRadius = ForceFieldRadius;
			this.RotationalForceField = RotationalForceField;
			this.CentripetalForceField = CentripetalForceField;
		}

		// Token: 0x0602548E RID: 152718 RVA: 0x00956089 File Offset: 0x00954289
		protected override IntPtr GetUStructPtr()
		{
			return Struct_SceneInteractData.StaticStruct();
		}

		// Token: 0x0602548F RID: 152719 RVA: 0x00956095 File Offset: 0x00954295
		[NullableContext(2)]
		public Struct_SceneInteractData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025490 RID: 152720 RVA: 0x0095609F File Offset: 0x0095429F
		public Struct_SceneInteractData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025491 RID: 152721 RVA: 0x009560AA File Offset: 0x009542AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_SceneInteractData(Pointer, false, true);
		}

		// Token: 0x06025492 RID: 152722 RVA: 0x009560B4 File Offset: 0x009542B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_SceneInteractData(Pointer, MemoryOwner);
		}

		// Token: 0x0401295D RID: 76125
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/Struct_SceneInteractData.Struct_SceneInteractData";

		// Token: 0x0401295E RID: 76126
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401295F RID: 76127
		internal static int __PropertyOffset_0;

		// Token: 0x04012960 RID: 76128
		internal static int __PropertyOffset_1;

		// Token: 0x04012961 RID: 76129
		internal static int __PropertyOffset_2;

		// Token: 0x04012962 RID: 76130
		internal static int __PropertyOffset_3;
	}
}
