using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003ACD RID: 15053
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/STransitionFloatIndexGroup.STransitionFloatIndexGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class STransitionFloatIndexGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060206DC RID: 132828 RVA: 0x008D2793 File Offset: 0x008D0993
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (STransitionFloatIndexGroup._ScriptStructPtr != 0) ? STransitionFloatIndexGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/StateMachineEffect/STransitionFloatIndexGroup.STransitionFloatIndexGroup", ref STransitionFloatIndexGroup._ScriptStructPtr);
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x060206DD RID: 132829 RVA: 0x008D27B8 File Offset: 0x008D09B8
		// (set) Token: 0x060206DE RID: 132830 RVA: 0x008D27FB File Offset: 0x008D09FB
		public TMap<FName, float> FloatValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatValues) == null)
				{
					result = (this._FloatValues = new TMap<FName, float>(base.NativePtr + (IntPtr)STransitionFloatIndexGroup.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatValues.CopyAssign(value);
			}
		}

		// Token: 0x060206DF RID: 132831 RVA: 0x008D2809 File Offset: 0x008D0A09
		public STransitionFloatIndexGroup()
		{
		}

		// Token: 0x060206E0 RID: 132832 RVA: 0x008D2811 File Offset: 0x008D0A11
		public STransitionFloatIndexGroup(TMap<FName, float> FloatValues)
		{
			this.FloatValues = FloatValues;
		}

		// Token: 0x060206E1 RID: 132833 RVA: 0x008D2820 File Offset: 0x008D0A20
		protected override IntPtr GetUStructPtr()
		{
			return STransitionFloatIndexGroup.StaticStruct();
		}

		// Token: 0x060206E2 RID: 132834 RVA: 0x008D282C File Offset: 0x008D0A2C
		[NullableContext(2)]
		public STransitionFloatIndexGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060206E3 RID: 132835 RVA: 0x008D2836 File Offset: 0x008D0A36
		public STransitionFloatIndexGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206E4 RID: 132836 RVA: 0x008D2841 File Offset: 0x008D0A41
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new STransitionFloatIndexGroup(Pointer, false, true);
		}

		// Token: 0x060206E5 RID: 132837 RVA: 0x008D284B File Offset: 0x008D0A4B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new STransitionFloatIndexGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400FB42 RID: 64322
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/STransitionFloatIndexGroup.STransitionFloatIndexGroup";

		// Token: 0x0400FB43 RID: 64323
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FB44 RID: 64324
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB45 RID: 64325
		[Nullable(2)]
		private TMap<FName, float> _FloatValues;
	}
}
