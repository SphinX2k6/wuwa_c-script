using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B4A RID: 15178
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitemIndestructibleEffectsParameters.SSceneInteractionitemIndestructibleEffectsParameters")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 164)]
	public class SSceneInteractionitemIndestructibleEffectsParameters : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219B5 RID: 137653 RVA: 0x008F0CD0 File Offset: 0x008EEED0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionitemIndestructibleEffectsParameters._ScriptStructPtr != 0) ? SSceneInteractionitemIndestructibleEffectsParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitemIndestructibleEffectsParameters.SSceneInteractionitemIndestructibleEffectsParameters", ref SSceneInteractionitemIndestructibleEffectsParameters._ScriptStructPtr);
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x060219B6 RID: 137654 RVA: 0x008F0CF4 File Offset: 0x008EEEF4
		// (set) Token: 0x060219B7 RID: 137655 RVA: 0x008F0D37 File Offset: 0x008EEF37
		public TMap<string, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<string, float>(base.NativePtr + (IntPtr)SSceneInteractionitemIndestructibleEffectsParameters.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x060219B8 RID: 137656 RVA: 0x008F0D48 File Offset: 0x008EEF48
		// (set) Token: 0x060219B9 RID: 137657 RVA: 0x008F0D8B File Offset: 0x008EEF8B
		public TMap<string, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<string, FLinearColor>(base.NativePtr + (IntPtr)SSceneInteractionitemIndestructibleEffectsParameters.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x060219BA RID: 137658 RVA: 0x008F0D99 File Offset: 0x008EEF99
		// (set) Token: 0x060219BB RID: 137659 RVA: 0x008F0DA9 File Offset: 0x008EEFA9
		public unsafe int IndestructibleEffectIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionitemIndestructibleEffectsParameters.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionitemIndestructibleEffectsParameters.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x060219BC RID: 137660 RVA: 0x008F0DBA File Offset: 0x008EEFBA
		public SSceneInteractionitemIndestructibleEffectsParameters()
		{
		}

		// Token: 0x060219BD RID: 137661 RVA: 0x008F0DC2 File Offset: 0x008EEFC2
		public SSceneInteractionitemIndestructibleEffectsParameters(TMap<string, float> FloatParameters, TMap<string, FLinearColor> ColorParameters, int IndestructibleEffectIndex)
		{
			this.FloatParameters = FloatParameters;
			this.ColorParameters = ColorParameters;
			this.IndestructibleEffectIndex = IndestructibleEffectIndex;
		}

		// Token: 0x060219BE RID: 137662 RVA: 0x008F0DDF File Offset: 0x008EEFDF
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionitemIndestructibleEffectsParameters.StaticStruct();
		}

		// Token: 0x060219BF RID: 137663 RVA: 0x008F0DEB File Offset: 0x008EEFEB
		[NullableContext(2)]
		public SSceneInteractionitemIndestructibleEffectsParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219C0 RID: 137664 RVA: 0x008F0DF5 File Offset: 0x008EEFF5
		public SSceneInteractionitemIndestructibleEffectsParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219C1 RID: 137665 RVA: 0x008F0E00 File Offset: 0x008EF000
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionitemIndestructibleEffectsParameters(Pointer, false, true);
		}

		// Token: 0x060219C2 RID: 137666 RVA: 0x008F0E0A File Offset: 0x008EF00A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionitemIndestructibleEffectsParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0401062E RID: 67118
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionitemIndestructibleEffectsParameters.SSceneInteractionitemIndestructibleEffectsParameters";

		// Token: 0x0401062F RID: 67119
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010630 RID: 67120
		internal static int __PropertyOffset_0;

		// Token: 0x04010631 RID: 67121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _FloatParameters;

		// Token: 0x04010632 RID: 67122
		internal static int __PropertyOffset_1;

		// Token: 0x04010633 RID: 67123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FLinearColor> _ColorParameters;

		// Token: 0x04010634 RID: 67124
		internal static int __PropertyOffset_2;
	}
}
