using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC9 RID: 16329
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyOneParamFunction.SAiRaceStrategyOneParamFunction")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SAiRaceStrategyOneParamFunction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029CEE RID: 171246 RVA: 0x009CCF02 File Offset: 0x009CB102
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiRaceStrategyOneParamFunction._ScriptStructPtr != 0) ? SAiRaceStrategyOneParamFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyOneParamFunction.SAiRaceStrategyOneParamFunction", ref SAiRaceStrategyOneParamFunction._ScriptStructPtr);
		}

		// Token: 0x1700655A RID: 25946
		// (get) Token: 0x06029CEF RID: 171247 RVA: 0x009CCF26 File Offset: 0x009CB126
		// (set) Token: 0x06029CF0 RID: 171248 RVA: 0x009CCF3A File Offset: 0x009CB13A
		public unsafe FFloatRange ParamRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700655B RID: 25947
		// (get) Token: 0x06029CF1 RID: 171249 RVA: 0x009CCF4F File Offset: 0x009CB14F
		// (set) Token: 0x06029CF2 RID: 171250 RVA: 0x009CCF63 File Offset: 0x009CB163
		public unsafe TEnumAsByte<EAiRaceStrategyOneParamFuncType> FunctionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700655C RID: 25948
		// (get) Token: 0x06029CF3 RID: 171251 RVA: 0x009CCF78 File Offset: 0x009CB178
		// (set) Token: 0x06029CF4 RID: 171252 RVA: 0x009CCFBB File Offset: 0x009CB1BB
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
					result = (this._CoefficientList = new TArray<float>(base.NativePtr + (IntPtr)SAiRaceStrategyOneParamFunction.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CoefficientList.CopyAssign(value);
			}
		}

		// Token: 0x06029CF5 RID: 171253 RVA: 0x009CCFC9 File Offset: 0x009CB1C9
		public SAiRaceStrategyOneParamFunction()
		{
		}

		// Token: 0x06029CF6 RID: 171254 RVA: 0x009CCFD1 File Offset: 0x009CB1D1
		public SAiRaceStrategyOneParamFunction(FFloatRange ParamRange, TEnumAsByte<EAiRaceStrategyOneParamFuncType> FunctionType, [Nullable(1)] TArray<float> CoefficientList)
		{
			this.ParamRange = ParamRange;
			this.FunctionType = FunctionType;
			this.CoefficientList = CoefficientList;
		}

		// Token: 0x06029CF7 RID: 171255 RVA: 0x009CCFEE File Offset: 0x009CB1EE
		protected override IntPtr GetUStructPtr()
		{
			return SAiRaceStrategyOneParamFunction.StaticStruct();
		}

		// Token: 0x06029CF8 RID: 171256 RVA: 0x009CCFFA File Offset: 0x009CB1FA
		[NullableContext(2)]
		public SAiRaceStrategyOneParamFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029CF9 RID: 171257 RVA: 0x009CD004 File Offset: 0x009CB204
		public SAiRaceStrategyOneParamFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029CFA RID: 171258 RVA: 0x009CD00F File Offset: 0x009CB20F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiRaceStrategyOneParamFunction(Pointer, false, true);
		}

		// Token: 0x06029CFB RID: 171259 RVA: 0x009CD019 File Offset: 0x009CB219
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiRaceStrategyOneParamFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0401578B RID: 87947
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/SAiRaceStrategyOneParamFunction.SAiRaceStrategyOneParamFunction";

		// Token: 0x0401578C RID: 87948
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401578D RID: 87949
		internal static int __PropertyOffset_0;

		// Token: 0x0401578E RID: 87950
		internal static int __PropertyOffset_1;

		// Token: 0x0401578F RID: 87951
		internal static int __PropertyOffset_2;

		// Token: 0x04015790 RID: 87952
		[Nullable(2)]
		private TArray<float> _CoefficientList;
	}
}
