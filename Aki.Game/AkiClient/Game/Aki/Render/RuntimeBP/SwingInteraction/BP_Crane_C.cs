using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x02003ABE RID: 15038
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_Crane.BP_Crane_C")]
	[UnrealStructLayout(1696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1692)]
	public class BP_Crane_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020445 RID: 132165 RVA: 0x008CE3DA File Offset: 0x008CC5DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Crane_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_Crane.BP_Crane_C");
			}
			return BP_Crane_C._ClassPtr;
		}

		// Token: 0x06020446 RID: 132166 RVA: 0x008CE400 File Offset: 0x008CC600
		public BP_Crane_C() : this(BuiltinUtils.AllocNativeUObject(BP_Crane_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020447 RID: 132167 RVA: 0x008CE428 File Offset: 0x008CC628
		[NullableContext(1)]
		public BP_Crane_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Crane_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x06020448 RID: 132168 RVA: 0x008CE45B File Offset: 0x008CC65B
		// (set) Token: 0x06020449 RID: 132169 RVA: 0x008CE46F File Offset: 0x008CC66F
		public unsafe UStaticMeshComponent SM_Hook
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0602044A RID: 132170 RVA: 0x008CE484 File Offset: 0x008CC684
		// (set) Token: 0x0602044B RID: 132171 RVA: 0x008CE498 File Offset: 0x008CC698
		public unsafe UStaticMeshComponent SM_SwingSingleRopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0602044C RID: 132172 RVA: 0x008CE4AD File Offset: 0x008CC6AD
		// (set) Token: 0x0602044D RID: 132173 RVA: 0x008CE4C1 File Offset: 0x008CC6C1
		public unsafe UStaticMeshComponent SM_SwingSingleRopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0602044E RID: 132174 RVA: 0x008CE4D6 File Offset: 0x008CC6D6
		// (set) Token: 0x0602044F RID: 132175 RVA: 0x008CE4EA File Offset: 0x008CC6EA
		public unsafe UStaticMeshComponent SM_SwingTop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x06020450 RID: 132176 RVA: 0x008CE4FF File Offset: 0x008CC6FF
		// (set) Token: 0x06020451 RID: 132177 RVA: 0x008CE513 File Offset: 0x008CC713
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x06020452 RID: 132178 RVA: 0x008CE528 File Offset: 0x008CC728
		// (set) Token: 0x06020453 RID: 132179 RVA: 0x008CE561 File Offset: 0x008CC761
		[Nullable(1)]
		public TArray<FName> NameList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameList) == null)
				{
					result = (this._NameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NameList.CopyAssign(value);
			}
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x06020454 RID: 132180 RVA: 0x008CE56F File Offset: 0x008CC76F
		// (set) Token: 0x06020455 RID: 132181 RVA: 0x008CE57F File Offset: 0x008CC77F
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x06020456 RID: 132182 RVA: 0x008CE590 File Offset: 0x008CC790
		// (set) Token: 0x06020457 RID: 132183 RVA: 0x008CE5A0 File Offset: 0x008CC7A0
		public unsafe bool bUseConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x06020458 RID: 132184 RVA: 0x008CE5B1 File Offset: 0x008CC7B1
		// (set) Token: 0x06020459 RID: 132185 RVA: 0x008CE5C1 File Offset: 0x008CC7C1
		public unsafe float ConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0602045A RID: 132186 RVA: 0x008CE5D2 File Offset: 0x008CC7D2
		// (set) Token: 0x0602045B RID: 132187 RVA: 0x008CE5E6 File Offset: 0x008CC7E6
		public unsafe FVector StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0602045C RID: 132188 RVA: 0x008CE5FB File Offset: 0x008CC7FB
		// (set) Token: 0x0602045D RID: 132189 RVA: 0x008CE60B File Offset: 0x008CC80B
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0602045E RID: 132190 RVA: 0x008CE61C File Offset: 0x008CC81C
		// (set) Token: 0x0602045F RID: 132191 RVA: 0x008CE62C File Offset: 0x008CC82C
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x06020460 RID: 132192 RVA: 0x008CE63D File Offset: 0x008CC83D
		// (set) Token: 0x06020461 RID: 132193 RVA: 0x008CE651 File Offset: 0x008CC851
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x06020462 RID: 132194 RVA: 0x008CE666 File Offset: 0x008CC866
		// (set) Token: 0x06020463 RID: 132195 RVA: 0x008CE676 File Offset: 0x008CC876
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x06020464 RID: 132196 RVA: 0x008CE687 File Offset: 0x008CC887
		// (set) Token: 0x06020465 RID: 132197 RVA: 0x008CE697 File Offset: 0x008CC897
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x06020466 RID: 132198 RVA: 0x008CE6A8 File Offset: 0x008CC8A8
		// (set) Token: 0x06020467 RID: 132199 RVA: 0x008CE6BC File Offset: 0x008CC8BC
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x06020468 RID: 132200 RVA: 0x008CE6D1 File Offset: 0x008CC8D1
		// (set) Token: 0x06020469 RID: 132201 RVA: 0x008CE6E5 File Offset: 0x008CC8E5
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0602046A RID: 132202 RVA: 0x008CE6FA File Offset: 0x008CC8FA
		// (set) Token: 0x0602046B RID: 132203 RVA: 0x008CE70E File Offset: 0x008CC90E
		public unsafe FVector leftPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0602046C RID: 132204 RVA: 0x008CE723 File Offset: 0x008CC923
		// (set) Token: 0x0602046D RID: 132205 RVA: 0x008CE737 File Offset: 0x008CC937
		public unsafe FVector rightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0602046E RID: 132206 RVA: 0x008CE74C File Offset: 0x008CC94C
		// (set) Token: 0x0602046F RID: 132207 RVA: 0x008CE760 File Offset: 0x008CC960
		public unsafe FVector leftNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x06020470 RID: 132208 RVA: 0x008CE778 File Offset: 0x008CC978
		// (set) Token: 0x06020471 RID: 132209 RVA: 0x008CE7B1 File Offset: 0x008CC9B1
		[Nullable(1)]
		public TArray<FParticle_QiuQian> particleArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FParticle_QiuQian> result;
				if ((result = this._particleArr) == null)
				{
					result = (this._particleArr = new TArray<FParticle_QiuQian>(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_21, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.particleArr.CopyAssign(value);
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x06020472 RID: 132210 RVA: 0x008CE7BF File Offset: 0x008CC9BF
		// (set) Token: 0x06020473 RID: 132211 RVA: 0x008CE7D3 File Offset: 0x008CC9D3
		public unsafe FVector rightNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x06020474 RID: 132212 RVA: 0x008CE7E8 File Offset: 0x008CC9E8
		// (set) Token: 0x06020475 RID: 132213 RVA: 0x008CE7F8 File Offset: 0x008CC9F8
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x06020476 RID: 132214 RVA: 0x008CE809 File Offset: 0x008CCA09
		// (set) Token: 0x06020477 RID: 132215 RVA: 0x008CE819 File Offset: 0x008CCA19
		public unsafe float endParticleMassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x06020478 RID: 132216 RVA: 0x008CE82A File Offset: 0x008CCA2A
		// (set) Token: 0x06020479 RID: 132217 RVA: 0x008CE83A File Offset: 0x008CCA3A
		public unsafe float debugDrawDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0602047A RID: 132218 RVA: 0x008CE84B File Offset: 0x008CCA4B
		// (set) Token: 0x0602047B RID: 132219 RVA: 0x008CE85B File Offset: 0x008CCA5B
		public unsafe bool IsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0602047C RID: 132220 RVA: 0x008CE86C File Offset: 0x008CCA6C
		// (set) Token: 0x0602047D RID: 132221 RVA: 0x008CE87C File Offset: 0x008CCA7C
		public unsafe bool IsPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0602047E RID: 132222 RVA: 0x008CE88D File Offset: 0x008CCA8D
		// (set) Token: 0x0602047F RID: 132223 RVA: 0x008CE8A1 File Offset: 0x008CCAA1
		public unsafe UMaterialInstanceDynamic DMI_RopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x06020480 RID: 132224 RVA: 0x008CE8B6 File Offset: 0x008CCAB6
		// (set) Token: 0x06020481 RID: 132225 RVA: 0x008CE8CA File Offset: 0x008CCACA
		public unsafe UMaterialInstanceDynamic DMI_RopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Crane_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x06020482 RID: 132226 RVA: 0x008CE8DF File Offset: 0x008CCADF
		// (set) Token: 0x06020483 RID: 132227 RVA: 0x008CE8EF File Offset: 0x008CCAEF
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x06020484 RID: 132228 RVA: 0x008CE900 File Offset: 0x008CCB00
		// (set) Token: 0x06020485 RID: 132229 RVA: 0x008CE910 File Offset: 0x008CCB10
		public unsafe bool IsWarm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x06020486 RID: 132230 RVA: 0x008CE921 File Offset: 0x008CCB21
		// (set) Token: 0x06020487 RID: 132231 RVA: 0x008CE931 File Offset: 0x008CCB31
		public unsafe float WarmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Crane_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x06020488 RID: 132232 RVA: 0x008CE942 File Offset: 0x008CCB42
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeParticleArr()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__InitializeParticleArr_NativeFunctionPtr, null);
		}

		// Token: 0x06020489 RID: 132233 RVA: 0x008CE958 File Offset: 0x008CCB58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDMIOffsetEnable(bool OffsetEnable)
		{
			BP_Crane_C.__SetDMIOffsetEnable_FunctionParams* ptr = stackalloc BP_Crane_C.__SetDMIOffsetEnable_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_Crane_C.__SetDMIOffsetEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Crane_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OffsetEnable = OffsetEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602048A RID: 132234 RVA: 0x008CE99E File Offset: 0x008CCB9E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateaDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__UpdateaDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0602048B RID: 132235 RVA: 0x008CE9B2 File Offset: 0x008CCBB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__InitializeDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0602048C RID: 132236 RVA: 0x008CE9C8 File Offset: 0x008CCBC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_Crane_C.__solve_FunctionParams* ptr = stackalloc BP_Crane_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_Crane_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Crane_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x0602048D RID: 132237 RVA: 0x008CEA49 File Offset: 0x008CCC49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602048E RID: 132238 RVA: 0x008CEA5D File Offset: 0x008CCC5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Crane_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602048F RID: 132239 RVA: 0x008CEA72 File Offset: 0x008CCC72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020490 RID: 132240 RVA: 0x008CEA86 File Offset: 0x008CCC86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Crane_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020491 RID: 132241 RVA: 0x008CEA9C File Offset: 0x008CCC9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Crane_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Crane_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Crane_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Crane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020492 RID: 132242 RVA: 0x008CEAE4 File Offset: 0x008CCCE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Crane_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Crane_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Crane_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Crane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Crane_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020493 RID: 132243 RVA: 0x008CEB2B File Offset: 0x008CCD2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void place_plank_event()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__place_plank_event_NativeFunctionPtr, null);
		}

		// Token: 0x06020494 RID: 132244 RVA: 0x008CEB3F File Offset: 0x008CCD3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06020495 RID: 132245 RVA: 0x008CEB53 File Offset: 0x008CCD53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Crane_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020496 RID: 132246 RVA: 0x008CEB68 File Offset: 0x008CCD68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Crane_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06020497 RID: 132247 RVA: 0x008CEB7C File Offset: 0x008CCD7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Crane_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020498 RID: 132248 RVA: 0x008CEB91 File Offset: 0x008CCD91
		protected BP_Crane_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9A9 RID: 63913
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_Crane.BP_Crane_C";

		// Token: 0x0400F9AA RID: 63914
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9AB RID: 63915
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9AC RID: 63916
		internal static int __PropertyOffset_1;

		// Token: 0x0400F9AD RID: 63917
		internal static int __PropertyOffset_2;

		// Token: 0x0400F9AE RID: 63918
		internal static int __PropertyOffset_3;

		// Token: 0x0400F9AF RID: 63919
		internal static int __PropertyOffset_4;

		// Token: 0x0400F9B0 RID: 63920
		internal static int __PropertyOffset_5;

		// Token: 0x0400F9B1 RID: 63921
		internal static int __PropertyOffset_6;

		// Token: 0x0400F9B2 RID: 63922
		private TArray<FName> _NameList;

		// Token: 0x0400F9B3 RID: 63923
		internal static int __PropertyOffset_7;

		// Token: 0x0400F9B4 RID: 63924
		internal static int __PropertyOffset_8;

		// Token: 0x0400F9B5 RID: 63925
		internal static int __PropertyOffset_9;

		// Token: 0x0400F9B6 RID: 63926
		internal static int __PropertyOffset_10;

		// Token: 0x0400F9B7 RID: 63927
		internal static int __PropertyOffset_11;

		// Token: 0x0400F9B8 RID: 63928
		internal static int __PropertyOffset_12;

		// Token: 0x0400F9B9 RID: 63929
		internal static int __PropertyOffset_13;

		// Token: 0x0400F9BA RID: 63930
		internal static int __PropertyOffset_14;

		// Token: 0x0400F9BB RID: 63931
		internal static int __PropertyOffset_15;

		// Token: 0x0400F9BC RID: 63932
		internal static int __PropertyOffset_16;

		// Token: 0x0400F9BD RID: 63933
		internal static int __PropertyOffset_17;

		// Token: 0x0400F9BE RID: 63934
		internal static int __PropertyOffset_18;

		// Token: 0x0400F9BF RID: 63935
		internal static int __PropertyOffset_19;

		// Token: 0x0400F9C0 RID: 63936
		internal static int __PropertyOffset_20;

		// Token: 0x0400F9C1 RID: 63937
		internal static int __PropertyOffset_21;

		// Token: 0x0400F9C2 RID: 63938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticle_QiuQian> _particleArr;

		// Token: 0x0400F9C3 RID: 63939
		internal static int __PropertyOffset_22;

		// Token: 0x0400F9C4 RID: 63940
		internal static int __PropertyOffset_23;

		// Token: 0x0400F9C5 RID: 63941
		internal static int __PropertyOffset_24;

		// Token: 0x0400F9C6 RID: 63942
		internal static int __PropertyOffset_25;

		// Token: 0x0400F9C7 RID: 63943
		internal static int __PropertyOffset_26;

		// Token: 0x0400F9C8 RID: 63944
		internal static int __PropertyOffset_27;

		// Token: 0x0400F9C9 RID: 63945
		internal static int __PropertyOffset_28;

		// Token: 0x0400F9CA RID: 63946
		internal static int __PropertyOffset_29;

		// Token: 0x0400F9CB RID: 63947
		internal static int __PropertyOffset_30;

		// Token: 0x0400F9CC RID: 63948
		internal static int __PropertyOffset_31;

		// Token: 0x0400F9CD RID: 63949
		internal static int __PropertyOffset_32;

		// Token: 0x0400F9CE RID: 63950
		private static IntPtr __InitializeParticleArr_NativeFunctionPtr;

		// Token: 0x0400F9CF RID: 63951
		private static IntPtr __SetDMIOffsetEnable_NativeFunctionPtr;

		// Token: 0x0400F9D0 RID: 63952
		private static IntPtr __UpdateaDMI_NativeFunctionPtr;

		// Token: 0x0400F9D1 RID: 63953
		private static IntPtr __InitializeDMI_NativeFunctionPtr;

		// Token: 0x0400F9D2 RID: 63954
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x0400F9D3 RID: 63955
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F9D4 RID: 63956
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F9D5 RID: 63957
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F9D6 RID: 63958
		private static IntPtr __place_plank_event_NativeFunctionPtr;

		// Token: 0x0400F9D7 RID: 63959
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400F9D8 RID: 63960
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009B9C RID: 39836
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __SetDMIOffsetEnable_FunctionParams
		{
			// Token: 0x040311F0 RID: 201200
			[FieldOffset(0)]
			public bool OffsetEnable;
		}

		// Token: 0x02009B9D RID: 39837
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x040311F1 RID: 201201
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x040311F2 RID: 201202
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x040311F3 RID: 201203
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x040311F4 RID: 201204
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x040311F5 RID: 201205
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x040311F6 RID: 201206
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009B9E RID: 39838
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311F7 RID: 201207
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
