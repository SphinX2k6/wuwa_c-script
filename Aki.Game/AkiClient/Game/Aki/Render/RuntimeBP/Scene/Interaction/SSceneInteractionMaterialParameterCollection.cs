using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B4C RID: 15180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialParameterCollection.SSceneInteractionMaterialParameterCollection")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class SSceneInteractionMaterialParameterCollection : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219D5 RID: 137685 RVA: 0x008F0F86 File Offset: 0x008EF186
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionMaterialParameterCollection._ScriptStructPtr != 0) ? SSceneInteractionMaterialParameterCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialParameterCollection.SSceneInteractionMaterialParameterCollection", ref SSceneInteractionMaterialParameterCollection._ScriptStructPtr);
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x060219D6 RID: 137686 RVA: 0x008F0FAC File Offset: 0x008EF1AC
		// (set) Token: 0x060219D7 RID: 137687 RVA: 0x008F0FEF File Offset: 0x008EF1EF
		public TMap<string, FLinearColor> MPC_Vector
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FLinearColor> result;
				if ((result = this._MPC_Vector) == null)
				{
					result = (this._MPC_Vector = new TMap<string, FLinearColor>(base.NativePtr + (IntPtr)SSceneInteractionMaterialParameterCollection.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MPC_Vector.CopyAssign(value);
			}
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x060219D8 RID: 137688 RVA: 0x008F1000 File Offset: 0x008EF200
		// (set) Token: 0x060219D9 RID: 137689 RVA: 0x008F1043 File Offset: 0x008EF243
		public TMap<string, float> MPC_Scalar
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._MPC_Scalar) == null)
				{
					result = (this._MPC_Scalar = new TMap<string, float>(base.NativePtr + (IntPtr)SSceneInteractionMaterialParameterCollection.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MPC_Scalar.CopyAssign(value);
			}
		}

		// Token: 0x060219DA RID: 137690 RVA: 0x008F1051 File Offset: 0x008EF251
		public SSceneInteractionMaterialParameterCollection()
		{
		}

		// Token: 0x060219DB RID: 137691 RVA: 0x008F1059 File Offset: 0x008EF259
		public SSceneInteractionMaterialParameterCollection(TMap<string, FLinearColor> MPC_Vector, TMap<string, float> MPC_Scalar)
		{
			this.MPC_Vector = MPC_Vector;
			this.MPC_Scalar = MPC_Scalar;
		}

		// Token: 0x060219DC RID: 137692 RVA: 0x008F106F File Offset: 0x008EF26F
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionMaterialParameterCollection.StaticStruct();
		}

		// Token: 0x060219DD RID: 137693 RVA: 0x008F107B File Offset: 0x008EF27B
		[NullableContext(2)]
		public SSceneInteractionMaterialParameterCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219DE RID: 137694 RVA: 0x008F1085 File Offset: 0x008EF285
		public SSceneInteractionMaterialParameterCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219DF RID: 137695 RVA: 0x008F1090 File Offset: 0x008EF290
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionMaterialParameterCollection(Pointer, false, true);
		}

		// Token: 0x060219E0 RID: 137696 RVA: 0x008F109A File Offset: 0x008EF29A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionMaterialParameterCollection(Pointer, MemoryOwner);
		}

		// Token: 0x0401063D RID: 67133
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMaterialParameterCollection.SSceneInteractionMaterialParameterCollection";

		// Token: 0x0401063E RID: 67134
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401063F RID: 67135
		internal static int __PropertyOffset_0;

		// Token: 0x04010640 RID: 67136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FLinearColor> _MPC_Vector;

		// Token: 0x04010641 RID: 67137
		internal static int __PropertyOffset_1;

		// Token: 0x04010642 RID: 67138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _MPC_Scalar;
	}
}
