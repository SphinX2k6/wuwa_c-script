using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AFA RID: 15098
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ChromaticAberration.BP_ChromaticAberration_C")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1816)]
	public class BP_ChromaticAberration_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020BAB RID: 134059 RVA: 0x008DBAE4 File Offset: 0x008D9CE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ChromaticAberration_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ChromaticAberration.BP_ChromaticAberration_C");
			}
			return BP_ChromaticAberration_C._ClassPtr;
		}

		// Token: 0x06020BAC RID: 134060 RVA: 0x008DBB08 File Offset: 0x008D9D08
		public BP_ChromaticAberration_C() : this(BuiltinUtils.AllocNativeUObject(BP_ChromaticAberration_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020BAD RID: 134061 RVA: 0x008DBB30 File Offset: 0x008D9D30
		[NullableContext(1)]
		public BP_ChromaticAberration_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ChromaticAberration_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x06020BAE RID: 134062 RVA: 0x008DBB63 File Offset: 0x008D9D63
		// (set) Token: 0x06020BAF RID: 134063 RVA: 0x008DBB77 File Offset: 0x008D9D77
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x06020BB0 RID: 134064 RVA: 0x008DBB8C File Offset: 0x008D9D8C
		// (set) Token: 0x06020BB1 RID: 134065 RVA: 0x008DBBA0 File Offset: 0x008D9DA0
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x06020BB2 RID: 134066 RVA: 0x008DBBB5 File Offset: 0x008D9DB5
		// (set) Token: 0x06020BB3 RID: 134067 RVA: 0x008DBBC9 File Offset: 0x008D9DC9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x06020BB4 RID: 134068 RVA: 0x008DBBDE File Offset: 0x008D9DDE
		// (set) Token: 0x06020BB5 RID: 134069 RVA: 0x008DBBF2 File Offset: 0x008D9DF2
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x06020BB6 RID: 134070 RVA: 0x008DBC07 File Offset: 0x008D9E07
		// (set) Token: 0x06020BB7 RID: 134071 RVA: 0x008DBC17 File Offset: 0x008D9E17
		public unsafe float CenterX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x06020BB8 RID: 134072 RVA: 0x008DBC28 File Offset: 0x008D9E28
		// (set) Token: 0x06020BB9 RID: 134073 RVA: 0x008DBC61 File Offset: 0x008D9E61
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x06020BBA RID: 134074 RVA: 0x008DBC70 File Offset: 0x008D9E70
		// (set) Token: 0x06020BBB RID: 134075 RVA: 0x008DBCA9 File Offset: 0x008D9EA9
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x06020BBC RID: 134076 RVA: 0x008DBCB8 File Offset: 0x008D9EB8
		// (set) Token: 0x06020BBD RID: 134077 RVA: 0x008DBCF1 File Offset: 0x008D9EF1
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x06020BBE RID: 134078 RVA: 0x008DBCFF File Offset: 0x008D9EFF
		// (set) Token: 0x06020BBF RID: 134079 RVA: 0x008DBD0F File Offset: 0x008D9F0F
		public unsafe float CenterY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x06020BC0 RID: 134080 RVA: 0x008DBD20 File Offset: 0x008D9F20
		// (set) Token: 0x06020BC1 RID: 134081 RVA: 0x008DBD34 File Offset: 0x008D9F34
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x06020BC2 RID: 134082 RVA: 0x008DBD49 File Offset: 0x008D9F49
		// (set) Token: 0x06020BC3 RID: 134083 RVA: 0x008DBD59 File Offset: 0x008D9F59
		public unsafe float BlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x06020BC4 RID: 134084 RVA: 0x008DBD6A File Offset: 0x008D9F6A
		// (set) Token: 0x06020BC5 RID: 134085 RVA: 0x008DBD7E File Offset: 0x008D9F7E
		public unsafe UTexture SpectralLUT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x06020BC6 RID: 134086 RVA: 0x008DBD93 File Offset: 0x008D9F93
		// (set) Token: 0x06020BC7 RID: 134087 RVA: 0x008DBDA3 File Offset: 0x008D9FA3
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x06020BC8 RID: 134088 RVA: 0x008DBDB4 File Offset: 0x008D9FB4
		// (set) Token: 0x06020BC9 RID: 134089 RVA: 0x008DBDC4 File Offset: 0x008D9FC4
		public unsafe int ToonDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x06020BCA RID: 134090 RVA: 0x008DBDD5 File Offset: 0x008D9FD5
		// (set) Token: 0x06020BCB RID: 134091 RVA: 0x008DBDE5 File Offset: 0x008D9FE5
		public unsafe float Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x06020BCC RID: 134092 RVA: 0x008DBDF6 File Offset: 0x008D9FF6
		// (set) Token: 0x06020BCD RID: 134093 RVA: 0x008DBE06 File Offset: 0x008DA006
		public unsafe bool bEnableActorPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x06020BCE RID: 134094 RVA: 0x008DBE17 File Offset: 0x008DA017
		// (set) Token: 0x06020BCF RID: 134095 RVA: 0x008DBE27 File Offset: 0x008DA027
		public unsafe bool DisableStencilTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x06020BD0 RID: 134096 RVA: 0x008DBE38 File Offset: 0x008DA038
		// (set) Token: 0x06020BD1 RID: 134097 RVA: 0x008DBE4C File Offset: 0x008DA04C
		public unsafe UMaterialInstance Material_DisableStencil
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChromaticAberration_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x06020BD2 RID: 134098 RVA: 0x008DBE61 File Offset: 0x008DA061
		// (set) Token: 0x06020BD3 RID: 134099 RVA: 0x008DBE71 File Offset: 0x008DA071
		public unsafe float Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x06020BD4 RID: 134100 RVA: 0x008DBE82 File Offset: 0x008DA082
		// (set) Token: 0x06020BD5 RID: 134101 RVA: 0x008DBE92 File Offset: 0x008DA092
		public unsafe float ProtectCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x06020BD6 RID: 134102 RVA: 0x008DBEA3 File Offset: 0x008DA0A3
		// (set) Token: 0x06020BD7 RID: 134103 RVA: 0x008DBEB7 File Offset: 0x008DA0B7
		public unsafe FName NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x06020BD8 RID: 134104 RVA: 0x008DBECC File Offset: 0x008DA0CC
		// (set) Token: 0x06020BD9 RID: 134105 RVA: 0x008DBEDC File Offset: 0x008DA0DC
		public unsafe float Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ChromaticAberration_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x06020BDA RID: 134106 RVA: 0x008DBEED File Offset: 0x008DA0ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChromaticAberration_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06020BDB RID: 134107 RVA: 0x008DBF01 File Offset: 0x008DA101
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChromaticAberration_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020BDC RID: 134108 RVA: 0x008DBF15 File Offset: 0x008DA115
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChromaticAberration_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020BDD RID: 134109 RVA: 0x008DBF2A File Offset: 0x008DA12A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChromaticAberration_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020BDE RID: 134110 RVA: 0x008DBF3E File Offset: 0x008DA13E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChromaticAberration_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020BDF RID: 134111 RVA: 0x008DBF54 File Offset: 0x008DA154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ChromaticAberration_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ChromaticAberration_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ChromaticAberration_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ChromaticAberration_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChromaticAberration_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020BE0 RID: 134112 RVA: 0x008DBF9C File Offset: 0x008DA19C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ChromaticAberration_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ChromaticAberration_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ChromaticAberration_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ChromaticAberration_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChromaticAberration_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020BE1 RID: 134113 RVA: 0x008DBFE3 File Offset: 0x008DA1E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChromaticAberration_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020BE2 RID: 134114 RVA: 0x008DBFF7 File Offset: 0x008DA1F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChromaticAberration_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020BE3 RID: 134115 RVA: 0x008DC00C File Offset: 0x008DA20C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ChromaticAberration_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ChromaticAberration_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ChromaticAberration_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ChromaticAberration_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChromaticAberration_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020BE4 RID: 134116 RVA: 0x008DC054 File Offset: 0x008DA254
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ChromaticAberration_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ChromaticAberration_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ChromaticAberration_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ChromaticAberration_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChromaticAberration_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020BE5 RID: 134117 RVA: 0x008DC09B File Offset: 0x008DA29B
		protected BP_ChromaticAberration_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE4D RID: 65101
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ChromaticAberration.BP_ChromaticAberration_C";

		// Token: 0x0400FE4E RID: 65102
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE4F RID: 65103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE50 RID: 65104
		internal static int __PropertyOffset_1;

		// Token: 0x0400FE51 RID: 65105
		internal static int __PropertyOffset_2;

		// Token: 0x0400FE52 RID: 65106
		internal static int __PropertyOffset_3;

		// Token: 0x0400FE53 RID: 65107
		internal static int __PropertyOffset_4;

		// Token: 0x0400FE54 RID: 65108
		internal static int __PropertyOffset_5;

		// Token: 0x0400FE55 RID: 65109
		internal static int __PropertyOffset_6;

		// Token: 0x0400FE56 RID: 65110
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FE57 RID: 65111
		internal static int __PropertyOffset_7;

		// Token: 0x0400FE58 RID: 65112
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FE59 RID: 65113
		internal static int __PropertyOffset_8;

		// Token: 0x0400FE5A RID: 65114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FE5B RID: 65115
		internal static int __PropertyOffset_9;

		// Token: 0x0400FE5C RID: 65116
		internal static int __PropertyOffset_10;

		// Token: 0x0400FE5D RID: 65117
		internal static int __PropertyOffset_11;

		// Token: 0x0400FE5E RID: 65118
		internal static int __PropertyOffset_12;

		// Token: 0x0400FE5F RID: 65119
		internal static int __PropertyOffset_13;

		// Token: 0x0400FE60 RID: 65120
		internal static int __PropertyOffset_14;

		// Token: 0x0400FE61 RID: 65121
		internal static int __PropertyOffset_15;

		// Token: 0x0400FE62 RID: 65122
		internal static int __PropertyOffset_16;

		// Token: 0x0400FE63 RID: 65123
		internal static int __PropertyOffset_17;

		// Token: 0x0400FE64 RID: 65124
		internal static int __PropertyOffset_18;

		// Token: 0x0400FE65 RID: 65125
		internal static int __PropertyOffset_19;

		// Token: 0x0400FE66 RID: 65126
		internal static int __PropertyOffset_20;

		// Token: 0x0400FE67 RID: 65127
		internal static int __PropertyOffset_21;

		// Token: 0x0400FE68 RID: 65128
		internal static int __PropertyOffset_22;

		// Token: 0x0400FE69 RID: 65129
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0400FE6A RID: 65130
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE6B RID: 65131
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE6C RID: 65132
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FE6D RID: 65133
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FE6E RID: 65134
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C2F RID: 39983
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312DF RID: 201439
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C30 RID: 39984
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312E0 RID: 201440
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
