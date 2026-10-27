using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200427E RID: 17022
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_HeadStateComponent.BP_HeadStateComponent_C")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class BP_HeadStateComponent_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C2FA RID: 180986 RVA: 0x00A194CB File Offset: 0x00A176CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HeadStateComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_HeadStateComponent.BP_HeadStateComponent_C");
			}
			return BP_HeadStateComponent_C._ClassPtr;
		}

		// Token: 0x0602C2FB RID: 180987 RVA: 0x00A194F0 File Offset: 0x00A176F0
		public BP_HeadStateComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_HeadStateComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C2FC RID: 180988 RVA: 0x00A19518 File Offset: 0x00A17718
		public BP_HeadStateComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HeadStateComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E0C RID: 28172
		// (get) Token: 0x0602C2FD RID: 180989 RVA: 0x00A1954B File Offset: 0x00A1774B
		// (set) Token: 0x0602C2FE RID: 180990 RVA: 0x00A1955B File Offset: 0x00A1775B
		public unsafe float 检测半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E0D RID: 28173
		// (get) Token: 0x0602C2FF RID: 180991 RVA: 0x00A1956C File Offset: 0x00A1776C
		// (set) Token: 0x0602C300 RID: 180992 RVA: 0x00A1957C File Offset: 0x00A1777C
		public unsafe float 检测频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006E0E RID: 28174
		// (get) Token: 0x0602C301 RID: 180993 RVA: 0x00A19590 File Offset: 0x00A17790
		// (set) Token: 0x0602C302 RID: 180994 RVA: 0x00A195C9 File Offset: 0x00A177C9
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> 检测ObjectTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._检测ObjectTypes) == null)
				{
					result = (this._检测ObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.检测ObjectTypes.CopyAssign(value);
			}
		}

		// Token: 0x17006E0F RID: 28175
		// (get) Token: 0x0602C303 RID: 180995 RVA: 0x00A195D7 File Offset: 0x00A177D7
		// (set) Token: 0x0602C304 RID: 180996 RVA: 0x00A195EB File Offset: 0x00A177EB
		[Nullable(2)]
		public unsafe AActor Source_Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HeadStateComponent_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HeadStateComponent_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006E10 RID: 28176
		// (get) Token: 0x0602C305 RID: 180997 RVA: 0x00A19600 File Offset: 0x00A17800
		// (set) Token: 0x0602C306 RID: 180998 RVA: 0x00A19639 File Offset: 0x00A17839
		public FTimerHandle 检测TimerHandle
		{
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._检测TimerHandle) == null)
				{
					result = (this._检测TimerHandle = new FTimerHandle(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E11 RID: 28177
		// (get) Token: 0x0602C307 RID: 180999 RVA: 0x00A1965A File Offset: 0x00A1785A
		// (set) Token: 0x0602C308 RID: 181000 RVA: 0x00A1966A File Offset: 0x00A1786A
		public unsafe float Draw_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006E12 RID: 28178
		// (get) Token: 0x0602C309 RID: 181001 RVA: 0x00A1967B File Offset: 0x00A1787B
		// (set) Token: 0x0602C30A RID: 181002 RVA: 0x00A1968F File Offset: 0x00A1788F
		[Nullable(0)]
		public unsafe TEnumAsByte<EDrawDebugTrace> Draw_Debug_Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006E13 RID: 28179
		// (get) Token: 0x0602C30B RID: 181003 RVA: 0x00A196A4 File Offset: 0x00A178A4
		// (set) Token: 0x0602C30C RID: 181004 RVA: 0x00A196DD File Offset: 0x00A178DD
		public 当刷新检测结果时 当刷新检测结果时
		{
			get
			{
				base.FastCheckIsValid();
				当刷新检测结果时 result;
				if ((result = this._当刷新检测结果时) == null)
				{
					result = (this._当刷新检测结果时 = new 当刷新检测结果时(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_8, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006E14 RID: 28180
		// (get) Token: 0x0602C30D RID: 181005 RVA: 0x00A19700 File Offset: 0x00A17900
		// (set) Token: 0x0602C30E RID: 181006 RVA: 0x00A19739 File Offset: 0x00A17939
		public TArray<TsBaseCharacter> CheckCharacters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TsBaseCharacter> result;
				if ((result = this._CheckCharacters) == null)
				{
					result = (this._CheckCharacters = new TArray<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_HeadStateComponent_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.CheckCharacters.CopyAssign(value);
			}
		}

		// Token: 0x0602C30F RID: 181007 RVA: 0x00A19748 File Offset: 0x00A17948
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取检测结果([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<TsBaseCharacter> Results)
		{
			BP_HeadStateComponent_C.__获取检测结果_FunctionParams* ptr = stackalloc BP_HeadStateComponent_C.__获取检测结果_FunctionParams[(UIntPtr)407] + 15L / (long)sizeof(BP_HeadStateComponent_C.__获取检测结果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HeadStateComponent_C.__获取检测结果_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Results;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Results);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeadStateComponent_C.__获取检测结果_NativeFunctionPtr, (void*)ptr);
			object obj2 = Results;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Results);
			}
			UnrealReflectionUtils.DestroyStruct(BP_HeadStateComponent_C.__获取检测结果_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C310 RID: 181008 RVA: 0x00A197C4 File Offset: 0x00A179C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool 获取是否在检测范围内(AActor OtherActor)
		{
			BP_HeadStateComponent_C.__获取是否在检测范围内_FunctionParams* ptr = stackalloc BP_HeadStateComponent_C.__获取是否在检测范围内_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_HeadStateComponent_C.__获取是否在检测范围内_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HeadStateComponent_C.__获取是否在检测范围内_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeadStateComponent_C.__获取是否在检测范围内_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C311 RID: 181009 RVA: 0x00A1981F File Offset: 0x00A17A1F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 当检测时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeadStateComponent_C.__当检测时_NativeFunctionPtr, null);
		}

		// Token: 0x0602C312 RID: 181010 RVA: 0x00A19833 File Offset: 0x00A17A33
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 休眠检测()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeadStateComponent_C.__休眠检测_NativeFunctionPtr, null);
		}

		// Token: 0x0602C313 RID: 181011 RVA: 0x00A19848 File Offset: 0x00A17A48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 激活检测(AActor Source_Actor)
		{
			BP_HeadStateComponent_C.__激活检测_FunctionParams* ptr = stackalloc BP_HeadStateComponent_C.__激活检测_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_HeadStateComponent_C.__激活检测_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HeadStateComponent_C.__激活检测_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Source_Actor = ((Source_Actor != null) ? Source_Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeadStateComponent_C.__激活检测_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C314 RID: 181012 RVA: 0x00A198A0 File Offset: 0x00A17AA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_HeadStateComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_HeadStateComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_HeadStateComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HeadStateComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HeadStateComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C315 RID: 181013 RVA: 0x00A198EC File Offset: 0x00A17AEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_HeadStateComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_HeadStateComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_HeadStateComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HeadStateComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HeadStateComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602C316 RID: 181014 RVA: 0x00A19938 File Offset: 0x00A17B38
		protected BP_HeadStateComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040171FA RID: 94714
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_HeadStateComponent.BP_HeadStateComponent_C";

		// Token: 0x040171FB RID: 94715
		private static IntPtr _ClassPtr;

		// Token: 0x040171FC RID: 94716
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040171FD RID: 94717
		public static IntPtr __当刷新检测结果时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040171FE RID: 94718
		internal static int __PropertyOffset_1;

		// Token: 0x040171FF RID: 94719
		internal static int __PropertyOffset_2;

		// Token: 0x04017200 RID: 94720
		internal static int __PropertyOffset_3;

		// Token: 0x04017201 RID: 94721
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _检测ObjectTypes;

		// Token: 0x04017202 RID: 94722
		internal static int __PropertyOffset_4;

		// Token: 0x04017203 RID: 94723
		internal static int __PropertyOffset_5;

		// Token: 0x04017204 RID: 94724
		[Nullable(2)]
		private FTimerHandle _检测TimerHandle;

		// Token: 0x04017205 RID: 94725
		internal static int __PropertyOffset_6;

		// Token: 0x04017206 RID: 94726
		internal static int __PropertyOffset_7;

		// Token: 0x04017207 RID: 94727
		internal static int __PropertyOffset_8;

		// Token: 0x04017208 RID: 94728
		[Nullable(2)]
		private 当刷新检测结果时 _当刷新检测结果时;

		// Token: 0x04017209 RID: 94729
		internal static int __PropertyOffset_9;

		// Token: 0x0401720A RID: 94730
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<TsBaseCharacter> _CheckCharacters;

		// Token: 0x0401720B RID: 94731
		private static IntPtr __获取检测结果_NativeFunctionPtr;

		// Token: 0x0401720C RID: 94732
		private static IntPtr __获取是否在检测范围内_NativeFunctionPtr;

		// Token: 0x0401720D RID: 94733
		private static IntPtr __当检测时_NativeFunctionPtr;

		// Token: 0x0401720E RID: 94734
		private static IntPtr __休眠检测_NativeFunctionPtr;

		// Token: 0x0401720F RID: 94735
		private static IntPtr __激活检测_NativeFunctionPtr;

		// Token: 0x04017210 RID: 94736
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A669 RID: 42601
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 392)]
		protected ref struct __获取检测结果_FunctionParams
		{
			// Token: 0x040325A3 RID: 206243
			[FieldOffset(0)]
			public byte Results;
		}

		// Token: 0x0200A66A RID: 42602
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取是否在检测范围内_FunctionParams
		{
			// Token: 0x040325A4 RID: 206244
			[FieldOffset(0)]
			public IntPtr OtherActor;

			// Token: 0x040325A5 RID: 206245
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200A66B RID: 42603
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __激活检测_FunctionParams
		{
			// Token: 0x040325A6 RID: 206246
			[FieldOffset(0)]
			public IntPtr Source_Actor;
		}

		// Token: 0x0200A66C RID: 42604
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040325A7 RID: 206247
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
