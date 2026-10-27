using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.ClothDynamicPin
{
	// Token: 0x02003C95 RID: 15509
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin_35Bridge.BP_KuroCSCloth_DynamicPin_35Bridge_C")]
	[UnrealStructLayout(2144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2132)]
	public class BP_KuroCSCloth_DynamicPin_35Bridge_C : AKuroCS_Cloth_DynamicPin, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602446C RID: 148588 RVA: 0x0093A0A2 File Offset: 0x009382A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCSCloth_DynamicPin_35Bridge_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin_35Bridge.BP_KuroCSCloth_DynamicPin_35Bridge_C");
			}
			return BP_KuroCSCloth_DynamicPin_35Bridge_C._ClassPtr;
		}

		// Token: 0x0602446D RID: 148589 RVA: 0x0093A0C8 File Offset: 0x009382C8
		public BP_KuroCSCloth_DynamicPin_35Bridge_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_DynamicPin_35Bridge_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602446E RID: 148590 RVA: 0x0093A0F0 File Offset: 0x009382F0
		[NullableContext(1)]
		public BP_KuroCSCloth_DynamicPin_35Bridge_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_DynamicPin_35Bridge_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x0602446F RID: 148591 RVA: 0x0093A123 File Offset: 0x00938323
		// (set) Token: 0x06024470 RID: 148592 RVA: 0x0093A137 File Offset: 0x00938337
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x06024471 RID: 148593 RVA: 0x0093A14C File Offset: 0x0093834C
		// (set) Token: 0x06024472 RID: 148594 RVA: 0x0093A160 File Offset: 0x00938360
		public unsafe UStaticMeshComponent MobileProxy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x06024473 RID: 148595 RVA: 0x0093A175 File Offset: 0x00938375
		// (set) Token: 0x06024474 RID: 148596 RVA: 0x0093A189 File Offset: 0x00938389
		public unsafe UStaticMeshComponent MeshXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x06024475 RID: 148597 RVA: 0x0093A19E File Offset: 0x0093839E
		// (set) Token: 0x06024476 RID: 148598 RVA: 0x0093A1B2 File Offset: 0x009383B2
		public unsafe USceneComponent PinnedLB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x06024477 RID: 148599 RVA: 0x0093A1C7 File Offset: 0x009383C7
		// (set) Token: 0x06024478 RID: 148600 RVA: 0x0093A1DB File Offset: 0x009383DB
		public unsafe USceneComponent PinnedLT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x06024479 RID: 148601 RVA: 0x0093A1F0 File Offset: 0x009383F0
		// (set) Token: 0x0602447A RID: 148602 RVA: 0x0093A204 File Offset: 0x00938404
		public unsafe USceneComponent PinnedRB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x0602447B RID: 148603 RVA: 0x0093A219 File Offset: 0x00938419
		// (set) Token: 0x0602447C RID: 148604 RVA: 0x0093A22D File Offset: 0x0093842D
		public unsafe USceneComponent PinnedRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x0602447D RID: 148605 RVA: 0x0093A242 File Offset: 0x00938442
		// (set) Token: 0x0602447E RID: 148606 RVA: 0x0093A256 File Offset: 0x00938456
		public unsafe UTextureRenderTarget2D RTPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x0602447F RID: 148607 RVA: 0x0093A26B File Offset: 0x0093846B
		// (set) Token: 0x06024480 RID: 148608 RVA: 0x0093A27B File Offset: 0x0093847B
		public unsafe bool bSyncToBindPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x06024481 RID: 148609 RVA: 0x0093A28C File Offset: 0x0093848C
		// (set) Token: 0x06024482 RID: 148610 RVA: 0x0093A2A0 File Offset: 0x009384A0
		public unsafe BP_BridgeModels_3_5_C bindBrige
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BridgeModels_3_5_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x06024483 RID: 148611 RVA: 0x0093A2B5 File Offset: 0x009384B5
		// (set) Token: 0x06024484 RID: 148612 RVA: 0x0093A2C9 File Offset: 0x009384C9
		public unsafe BP_CPP_bridge_doubleChain_realModel_Broken_C BindBridgeChain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_CPP_bridge_doubleChain_realModel_Broken_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x06024485 RID: 148613 RVA: 0x0093A2DE File Offset: 0x009384DE
		// (set) Token: 0x06024486 RID: 148614 RVA: 0x0093A2EE File Offset: 0x009384EE
		public unsafe int linkIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x06024487 RID: 148615 RVA: 0x0093A2FF File Offset: 0x009384FF
		// (set) Token: 0x06024488 RID: 148616 RVA: 0x0093A30F File Offset: 0x0093850F
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x06024489 RID: 148617 RVA: 0x0093A320 File Offset: 0x00938520
		// (set) Token: 0x0602448A RID: 148618 RVA: 0x0093A334 File Offset: 0x00938534
		public unsafe FVector PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x0602448B RID: 148619 RVA: 0x0093A34C File Offset: 0x0093854C
		// (set) Token: 0x0602448C RID: 148620 RVA: 0x0093A385 File Offset: 0x00938585
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x0602448D RID: 148621 RVA: 0x0093A393 File Offset: 0x00938593
		// (set) Token: 0x0602448E RID: 148622 RVA: 0x0093A3A3 File Offset: 0x009385A3
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x0602448F RID: 148623 RVA: 0x0093A3B4 File Offset: 0x009385B4
		// (set) Token: 0x06024490 RID: 148624 RVA: 0x0093A3C8 File Offset: 0x009385C8
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x06024491 RID: 148625 RVA: 0x0093A3DD File Offset: 0x009385DD
		// (set) Token: 0x06024492 RID: 148626 RVA: 0x0093A3ED File Offset: 0x009385ED
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x06024493 RID: 148627 RVA: 0x0093A3FE File Offset: 0x009385FE
		// (set) Token: 0x06024494 RID: 148628 RVA: 0x0093A40E File Offset: 0x0093860E
		public unsafe int Substep_Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x06024495 RID: 148629 RVA: 0x0093A41F File Offset: 0x0093861F
		// (set) Token: 0x06024496 RID: 148630 RVA: 0x0093A42F File Offset: 0x0093862F
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x06024497 RID: 148631 RVA: 0x0093A440 File Offset: 0x00938640
		// (set) Token: 0x06024498 RID: 148632 RVA: 0x0093A450 File Offset: 0x00938650
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x06024499 RID: 148633 RVA: 0x0093A461 File Offset: 0x00938661
		// (set) Token: 0x0602449A RID: 148634 RVA: 0x0093A471 File Offset: 0x00938671
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x0602449B RID: 148635 RVA: 0x0093A482 File Offset: 0x00938682
		// (set) Token: 0x0602449C RID: 148636 RVA: 0x0093A492 File Offset: 0x00938692
		public unsafe bool bStopSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x0602449D RID: 148637 RVA: 0x0093A4A3 File Offset: 0x009386A3
		// (set) Token: 0x0602449E RID: 148638 RVA: 0x0093A4B3 File Offset: 0x009386B3
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x0602449F RID: 148639 RVA: 0x0093A4C4 File Offset: 0x009386C4
		// (set) Token: 0x060244A0 RID: 148640 RVA: 0x0093A4FD File Offset: 0x009386FD
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_25, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x060244A1 RID: 148641 RVA: 0x0093A50C File Offset: 0x0093870C
		// (set) Token: 0x060244A2 RID: 148642 RVA: 0x0093A545 File Offset: 0x00938745
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_26, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x060244A3 RID: 148643 RVA: 0x0093A554 File Offset: 0x00938754
		// (set) Token: 0x060244A4 RID: 148644 RVA: 0x0093A58D File Offset: 0x0093878D
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x060244A5 RID: 148645 RVA: 0x0093A59B File Offset: 0x0093879B
		// (set) Token: 0x060244A6 RID: 148646 RVA: 0x0093A5AF File Offset: 0x009387AF
		public unsafe FTransformDouble Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x060244A7 RID: 148647 RVA: 0x0093A5C4 File Offset: 0x009387C4
		// (set) Token: 0x060244A8 RID: 148648 RVA: 0x0093A5D4 File Offset: 0x009387D4
		public unsafe int Substep_CountRaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_35Bridge_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x060244A9 RID: 148649 RVA: 0x0093A5E5 File Offset: 0x009387E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__UpdateMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x060244AA RID: 148650 RVA: 0x0093A5F9 File Offset: 0x009387F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x060244AB RID: 148651 RVA: 0x0093A60D File Offset: 0x0093880D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x060244AC RID: 148652 RVA: 0x0093A621 File Offset: 0x00938821
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x060244AD RID: 148653 RVA: 0x0093A635 File Offset: 0x00938835
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x060244AE RID: 148654 RVA: 0x0093A649 File Offset: 0x00938849
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FitToBridge()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__FitToBridge_NativeFunctionPtr, null);
		}

		// Token: 0x060244AF RID: 148655 RVA: 0x0093A65D File Offset: 0x0093885D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawDeformPoints()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__DrawDeformPoints_NativeFunctionPtr, null);
		}

		// Token: 0x060244B0 RID: 148656 RVA: 0x0093A674 File Offset: 0x00938874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SyncPos(USceneComponent From, USceneComponent To)
		{
			BP_KuroCSCloth_DynamicPin_35Bridge_C.__SyncPos_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_35Bridge_C.__SyncPos_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_35Bridge_C.__SyncPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_35Bridge_C.__SyncPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__SyncPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060244B1 RID: 148657 RVA: 0x0093A6E2 File Offset: 0x009388E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SyncToBindPin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__SyncToBindPin_NativeFunctionPtr, null);
		}

		// Token: 0x060244B2 RID: 148658 RVA: 0x0093A6F6 File Offset: 0x009388F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawAndSetPin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__DrawAndSetPin_NativeFunctionPtr, null);
		}

		// Token: 0x060244B3 RID: 148659 RVA: 0x0093A70A File Offset: 0x0093890A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060244B4 RID: 148660 RVA: 0x0093A71E File Offset: 0x0093891E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060244B5 RID: 148661 RVA: 0x0093A733 File Offset: 0x00938933
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060244B6 RID: 148662 RVA: 0x0093A747 File Offset: 0x00938947
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060244B7 RID: 148663 RVA: 0x0093A75C File Offset: 0x0093895C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060244B8 RID: 148664 RVA: 0x0093A7A4 File Offset: 0x009389A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060244B9 RID: 148665 RVA: 0x0093A7EB File Offset: 0x009389EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060244BA RID: 148666 RVA: 0x0093A800 File Offset: 0x00938A00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060244BB RID: 148667 RVA: 0x0093A84C File Offset: 0x00938A4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060244BC RID: 148668 RVA: 0x0093A898 File Offset: 0x00938A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060244BD RID: 148669 RVA: 0x0093A954 File Offset: 0x00938B54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_35Bridge_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060244BE RID: 148670 RVA: 0x0093A9DD File Offset: 0x00938BDD
		protected BP_KuroCSCloth_DynamicPin_35Bridge_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FBF RID: 73663
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin_35Bridge.BP_KuroCSCloth_DynamicPin_35Bridge_C";

		// Token: 0x04011FC0 RID: 73664
		private static IntPtr _ClassPtr;

		// Token: 0x04011FC1 RID: 73665
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FC2 RID: 73666
		internal static int __PropertyOffset_1;

		// Token: 0x04011FC3 RID: 73667
		internal static int __PropertyOffset_2;

		// Token: 0x04011FC4 RID: 73668
		internal static int __PropertyOffset_3;

		// Token: 0x04011FC5 RID: 73669
		internal static int __PropertyOffset_4;

		// Token: 0x04011FC6 RID: 73670
		internal static int __PropertyOffset_5;

		// Token: 0x04011FC7 RID: 73671
		internal static int __PropertyOffset_6;

		// Token: 0x04011FC8 RID: 73672
		internal static int __PropertyOffset_7;

		// Token: 0x04011FC9 RID: 73673
		internal static int __PropertyOffset_8;

		// Token: 0x04011FCA RID: 73674
		internal static int __PropertyOffset_9;

		// Token: 0x04011FCB RID: 73675
		internal static int __PropertyOffset_10;

		// Token: 0x04011FCC RID: 73676
		internal static int __PropertyOffset_11;

		// Token: 0x04011FCD RID: 73677
		internal static int __PropertyOffset_12;

		// Token: 0x04011FCE RID: 73678
		internal static int __PropertyOffset_13;

		// Token: 0x04011FCF RID: 73679
		internal static int __PropertyOffset_14;

		// Token: 0x04011FD0 RID: 73680
		internal static int __PropertyOffset_15;

		// Token: 0x04011FD1 RID: 73681
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x04011FD2 RID: 73682
		internal static int __PropertyOffset_16;

		// Token: 0x04011FD3 RID: 73683
		internal static int __PropertyOffset_17;

		// Token: 0x04011FD4 RID: 73684
		internal static int __PropertyOffset_18;

		// Token: 0x04011FD5 RID: 73685
		internal static int __PropertyOffset_19;

		// Token: 0x04011FD6 RID: 73686
		internal static int __PropertyOffset_20;

		// Token: 0x04011FD7 RID: 73687
		internal static int __PropertyOffset_21;

		// Token: 0x04011FD8 RID: 73688
		internal static int __PropertyOffset_22;

		// Token: 0x04011FD9 RID: 73689
		internal static int __PropertyOffset_23;

		// Token: 0x04011FDA RID: 73690
		internal static int __PropertyOffset_24;

		// Token: 0x04011FDB RID: 73691
		internal static int __PropertyOffset_25;

		// Token: 0x04011FDC RID: 73692
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04011FDD RID: 73693
		internal static int __PropertyOffset_26;

		// Token: 0x04011FDE RID: 73694
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04011FDF RID: 73695
		internal static int __PropertyOffset_27;

		// Token: 0x04011FE0 RID: 73696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04011FE1 RID: 73697
		internal static int __PropertyOffset_28;

		// Token: 0x04011FE2 RID: 73698
		internal static int __PropertyOffset_29;

		// Token: 0x04011FE3 RID: 73699
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x04011FE4 RID: 73700
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04011FE5 RID: 73701
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04011FE6 RID: 73702
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04011FE7 RID: 73703
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04011FE8 RID: 73704
		private static IntPtr __FitToBridge_NativeFunctionPtr;

		// Token: 0x04011FE9 RID: 73705
		private static IntPtr __DrawDeformPoints_NativeFunctionPtr;

		// Token: 0x04011FEA RID: 73706
		private static IntPtr __SyncPos_NativeFunctionPtr;

		// Token: 0x04011FEB RID: 73707
		private static IntPtr __SyncToBindPin_NativeFunctionPtr;

		// Token: 0x04011FEC RID: 73708
		private static IntPtr __DrawAndSetPin_NativeFunctionPtr;

		// Token: 0x04011FED RID: 73709
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011FEE RID: 73710
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011FEF RID: 73711
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011FF0 RID: 73712
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011FF1 RID: 73713
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04011FF2 RID: 73714
		private static IntPtr __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011FF3 RID: 73715
		private static IntPtr __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009EF5 RID: 40693
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __SyncPos_FunctionParams
		{
			// Token: 0x04031812 RID: 202770
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x04031813 RID: 202771
			[FieldOffset(8)]
			public IntPtr To;
		}

		// Token: 0x02009EF6 RID: 40694
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031814 RID: 202772
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EF7 RID: 40695
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031815 RID: 202773
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009EF8 RID: 40696
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031816 RID: 202774
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031817 RID: 202775
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031818 RID: 202776
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031819 RID: 202777
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403181A RID: 202778
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403181B RID: 202779
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EF9 RID: 40697
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403181C RID: 202780
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403181D RID: 202781
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403181E RID: 202782
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403181F RID: 202783
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
