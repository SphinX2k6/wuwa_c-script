using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003ACE RID: 15054
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/STransitionLinearColorIndexGroup.STransitionLinearColorIndexGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class STransitionLinearColorIndexGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060206E6 RID: 132838 RVA: 0x008D2854 File Offset: 0x008D0A54
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (STransitionLinearColorIndexGroup._ScriptStructPtr != 0) ? STransitionLinearColorIndexGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/StateMachineEffect/STransitionLinearColorIndexGroup.STransitionLinearColorIndexGroup", ref STransitionLinearColorIndexGroup._ScriptStructPtr);
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x060206E7 RID: 132839 RVA: 0x008D2878 File Offset: 0x008D0A78
		// (set) Token: 0x060206E8 RID: 132840 RVA: 0x008D28BB File Offset: 0x008D0ABB
		public TMap<FName, FLinearColor> LinearColorValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LinearColorValues) == null)
				{
					result = (this._LinearColorValues = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)STransitionLinearColorIndexGroup.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LinearColorValues.CopyAssign(value);
			}
		}

		// Token: 0x060206E9 RID: 132841 RVA: 0x008D28C9 File Offset: 0x008D0AC9
		public STransitionLinearColorIndexGroup()
		{
		}

		// Token: 0x060206EA RID: 132842 RVA: 0x008D28D1 File Offset: 0x008D0AD1
		public STransitionLinearColorIndexGroup(TMap<FName, FLinearColor> LinearColorValues)
		{
			this.LinearColorValues = LinearColorValues;
		}

		// Token: 0x060206EB RID: 132843 RVA: 0x008D28E0 File Offset: 0x008D0AE0
		protected override IntPtr GetUStructPtr()
		{
			return STransitionLinearColorIndexGroup.StaticStruct();
		}

		// Token: 0x060206EC RID: 132844 RVA: 0x008D28EC File Offset: 0x008D0AEC
		[NullableContext(2)]
		public STransitionLinearColorIndexGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060206ED RID: 132845 RVA: 0x008D28F6 File Offset: 0x008D0AF6
		public STransitionLinearColorIndexGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206EE RID: 132846 RVA: 0x008D2901 File Offset: 0x008D0B01
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new STransitionLinearColorIndexGroup(Pointer, false, true);
		}

		// Token: 0x060206EF RID: 132847 RVA: 0x008D290B File Offset: 0x008D0B0B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new STransitionLinearColorIndexGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400FB46 RID: 64326
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/STransitionLinearColorIndexGroup.STransitionLinearColorIndexGroup";

		// Token: 0x0400FB47 RID: 64327
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FB48 RID: 64328
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB49 RID: 64329
		[Nullable(2)]
		private TMap<FName, FLinearColor> _LinearColorValues;
	}
}
