using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x0200324E RID: 12878
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyOneParamFunction.SAiRaceStrategyOneParamFunction")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SAiRaceStrategyOneParamFunction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060202D9 RID: 131801 RVA: 0x0093F11E File Offset: 0x0093D31E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyOneParamFunction._ScriptStructPtr != 0) ? SAiRaceStrategyOneParamFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyOneParamFunction.SAiRaceStrategyOneParamFunction", ref SAiRaceStrategyOneParamFunction._ScriptStructPtr);
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x060202DA RID: 131802 RVA: 0x0093F142 File Offset: 0x0093D342
		// (set) Token: 0x060202DB RID: 131803 RVA: 0x0093F156 File Offset: 0x0093D356
		public unsafe FFloatRange ParamRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_ParamRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_ParamRange) = value;
			}
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x060202DC RID: 131804 RVA: 0x0093F16B File Offset: 0x0093D36B
		// (set) Token: 0x060202DD RID: 131805 RVA: 0x0093F17F File Offset: 0x0093D37F
		public unsafe TEnumAsByte<EAiRaceStrategyOneParamFuncType> FunctionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_FunctionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_FunctionType) = value;
			}
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x060202DE RID: 131806 RVA: 0x0093F194 File Offset: 0x0093D394
		// (set) Token: 0x060202DF RID: 131807 RVA: 0x0093F1D7 File Offset: 0x0093D3D7
		[Nullable(1)]
		public TArray<float> CoefficientList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CoefficientList) == null)
				{
					result = (this._CoefficientList = new TArray<float>(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_CoefficientList, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CoefficientList.CopyAssign(value);
			}
		}

		// Token: 0x060202E0 RID: 131808 RVA: 0x0093F1E5 File Offset: 0x0093D3E5
		public SAiRaceStrategyOneParamFunction()
		{
		}

		// Token: 0x060202E1 RID: 131809 RVA: 0x0093F1ED File Offset: 0x0093D3ED
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyOneParamFunction.StaticStruct();
		}

		// Token: 0x060202E2 RID: 131810 RVA: 0x0093F1F9 File Offset: 0x0093D3F9
		[NullableContext(2)]
		public SAiRaceStrategyOneParamFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060202E3 RID: 131811 RVA: 0x0093F203 File Offset: 0x0093D403
		public SAiRaceStrategyOneParamFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060202E4 RID: 131812 RVA: 0x0093F20E File Offset: 0x0093D40E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyOneParamFunction(Pointer, false, true);
		}

		// Token: 0x060202E5 RID: 131813 RVA: 0x0093F218 File Offset: 0x0093D418
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyOneParamFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0401151C RID: 70940
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyOneParamFunction.SAiRaceStrategyOneParamFunction";

		// Token: 0x0401151D RID: 70941
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401151E RID: 70942
		internal static int __PropertyOffset_ParamRange;

		// Token: 0x0401151F RID: 70943
		internal static int __PropertyOffset_FunctionType;

		// Token: 0x04011520 RID: 70944
		internal static int __PropertyOffset_CoefficientList;

		// Token: 0x04011521 RID: 70945
		[Nullable(2)]
		private TArray<float> _CoefficientList;
	}
}
