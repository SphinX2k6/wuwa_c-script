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
	// Token: 0x02003C97 RID: 15511
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin.BP_KuroCSCloth_DynamicPin_C")]
	[UnrealStructLayout(2144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2132)]
	public class BP_KuroCSCloth_DynamicPin_C : AKuroCS_Cloth_DynamicPin, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024513 RID: 148755 RVA: 0x0093B33E File Offset: 0x0093953E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCSCloth_DynamicPin_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin.BP_KuroCSCloth_DynamicPin_C");
			}
			return BP_KuroCSCloth_DynamicPin_C._ClassPtr;
		}

		// Token: 0x06024514 RID: 148756 RVA: 0x0093B364 File Offset: 0x00939564
		public BP_KuroCSCloth_DynamicPin_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_DynamicPin_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024515 RID: 148757 RVA: 0x0093B38C File Offset: 0x0093958C
		[NullableContext(1)]
		public BP_KuroCSCloth_DynamicPin_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_DynamicPin_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x06024516 RID: 148758 RVA: 0x0093B3BF File Offset: 0x009395BF
		// (set) Token: 0x06024517 RID: 148759 RVA: 0x0093B3D3 File Offset: 0x009395D3
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x06024518 RID: 148760 RVA: 0x0093B3E8 File Offset: 0x009395E8
		// (set) Token: 0x06024519 RID: 148761 RVA: 0x0093B3FC File Offset: 0x009395FC
		public unsafe UStaticMeshComponent MobileProxy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x0602451A RID: 148762 RVA: 0x0093B411 File Offset: 0x00939611
		// (set) Token: 0x0602451B RID: 148763 RVA: 0x0093B425 File Offset: 0x00939625
		public unsafe UStaticMeshComponent MeshXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x0602451C RID: 148764 RVA: 0x0093B43A File Offset: 0x0093963A
		// (set) Token: 0x0602451D RID: 148765 RVA: 0x0093B44E File Offset: 0x0093964E
		public unsafe USceneComponent PinnedLB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x0602451E RID: 148766 RVA: 0x0093B463 File Offset: 0x00939663
		// (set) Token: 0x0602451F RID: 148767 RVA: 0x0093B477 File Offset: 0x00939677
		public unsafe USceneComponent PinnedLT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x06024520 RID: 148768 RVA: 0x0093B48C File Offset: 0x0093968C
		// (set) Token: 0x06024521 RID: 148769 RVA: 0x0093B4A0 File Offset: 0x009396A0
		public unsafe USceneComponent PinnedRB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x06024522 RID: 148770 RVA: 0x0093B4B5 File Offset: 0x009396B5
		// (set) Token: 0x06024523 RID: 148771 RVA: 0x0093B4C9 File Offset: 0x009396C9
		public unsafe USceneComponent PinnedRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x06024524 RID: 148772 RVA: 0x0093B4DE File Offset: 0x009396DE
		// (set) Token: 0x06024525 RID: 148773 RVA: 0x0093B4F2 File Offset: 0x009396F2
		public unsafe UTextureRenderTarget2D RTPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x06024526 RID: 148774 RVA: 0x0093B507 File Offset: 0x00939707
		// (set) Token: 0x06024527 RID: 148775 RVA: 0x0093B517 File Offset: 0x00939717
		public unsafe bool bSyncToBindPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x06024528 RID: 148776 RVA: 0x0093B528 File Offset: 0x00939728
		// (set) Token: 0x06024529 RID: 148777 RVA: 0x0093B53C File Offset: 0x0093973C
		public unsafe BP_BridgeModels_C bindBrige
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BridgeModels_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x0602452A RID: 148778 RVA: 0x0093B551 File Offset: 0x00939751
		// (set) Token: 0x0602452B RID: 148779 RVA: 0x0093B561 File Offset: 0x00939761
		public unsafe int linkIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x0602452C RID: 148780 RVA: 0x0093B572 File Offset: 0x00939772
		// (set) Token: 0x0602452D RID: 148781 RVA: 0x0093B582 File Offset: 0x00939782
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x0602452E RID: 148782 RVA: 0x0093B593 File Offset: 0x00939793
		// (set) Token: 0x0602452F RID: 148783 RVA: 0x0093B5A7 File Offset: 0x009397A7
		public unsafe FVector PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x06024530 RID: 148784 RVA: 0x0093B5BC File Offset: 0x009397BC
		// (set) Token: 0x06024531 RID: 148785 RVA: 0x0093B5F5 File Offset: 0x009397F5
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
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x17004670 RID: 18032
		// (get) Token: 0x06024532 RID: 148786 RVA: 0x0093B603 File Offset: 0x00939803
		// (set) Token: 0x06024533 RID: 148787 RVA: 0x0093B613 File Offset: 0x00939813
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004671 RID: 18033
		// (get) Token: 0x06024534 RID: 148788 RVA: 0x0093B624 File Offset: 0x00939824
		// (set) Token: 0x06024535 RID: 148789 RVA: 0x0093B638 File Offset: 0x00939838
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004672 RID: 18034
		// (get) Token: 0x06024536 RID: 148790 RVA: 0x0093B64D File Offset: 0x0093984D
		// (set) Token: 0x06024537 RID: 148791 RVA: 0x0093B65D File Offset: 0x0093985D
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004673 RID: 18035
		// (get) Token: 0x06024538 RID: 148792 RVA: 0x0093B66E File Offset: 0x0093986E
		// (set) Token: 0x06024539 RID: 148793 RVA: 0x0093B67E File Offset: 0x0093987E
		public unsafe int Substep_Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004674 RID: 18036
		// (get) Token: 0x0602453A RID: 148794 RVA: 0x0093B68F File Offset: 0x0093988F
		// (set) Token: 0x0602453B RID: 148795 RVA: 0x0093B69F File Offset: 0x0093989F
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x0602453C RID: 148796 RVA: 0x0093B6B0 File Offset: 0x009398B0
		// (set) Token: 0x0602453D RID: 148797 RVA: 0x0093B6C0 File Offset: 0x009398C0
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x0602453E RID: 148798 RVA: 0x0093B6D1 File Offset: 0x009398D1
		// (set) Token: 0x0602453F RID: 148799 RVA: 0x0093B6E1 File Offset: 0x009398E1
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x06024540 RID: 148800 RVA: 0x0093B6F2 File Offset: 0x009398F2
		// (set) Token: 0x06024541 RID: 148801 RVA: 0x0093B702 File Offset: 0x00939902
		public unsafe bool bStopSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x06024542 RID: 148802 RVA: 0x0093B713 File Offset: 0x00939913
		// (set) Token: 0x06024543 RID: 148803 RVA: 0x0093B723 File Offset: 0x00939923
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x06024544 RID: 148804 RVA: 0x0093B734 File Offset: 0x00939934
		// (set) Token: 0x06024545 RID: 148805 RVA: 0x0093B76D File Offset: 0x0093996D
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_24, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x06024546 RID: 148806 RVA: 0x0093B77C File Offset: 0x0093997C
		// (set) Token: 0x06024547 RID: 148807 RVA: 0x0093B7B5 File Offset: 0x009399B5
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_25, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x06024548 RID: 148808 RVA: 0x0093B7C4 File Offset: 0x009399C4
		// (set) Token: 0x06024549 RID: 148809 RVA: 0x0093B7FD File Offset: 0x009399FD
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_26, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x0602454A RID: 148810 RVA: 0x0093B80B File Offset: 0x00939A0B
		// (set) Token: 0x0602454B RID: 148811 RVA: 0x0093B81F File Offset: 0x00939A1F
		public unsafe FTransformDouble Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x0602454C RID: 148812 RVA: 0x0093B834 File Offset: 0x00939A34
		// (set) Token: 0x0602454D RID: 148813 RVA: 0x0093B844 File Offset: 0x00939A44
		public unsafe int Substep_CountRaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x0602454E RID: 148814 RVA: 0x0093B855 File Offset: 0x00939A55
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__UpdateMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x0602454F RID: 148815 RVA: 0x0093B869 File Offset: 0x00939A69
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024550 RID: 148816 RVA: 0x0093B87D File Offset: 0x00939A7D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024551 RID: 148817 RVA: 0x0093B891 File Offset: 0x00939A91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x06024552 RID: 148818 RVA: 0x0093B8A5 File Offset: 0x00939AA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x06024553 RID: 148819 RVA: 0x0093B8B9 File Offset: 0x00939AB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FitToBridge()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__FitToBridge_NativeFunctionPtr, null);
		}

		// Token: 0x06024554 RID: 148820 RVA: 0x0093B8CD File Offset: 0x00939ACD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawDeformPoints()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__DrawDeformPoints_NativeFunctionPtr, null);
		}

		// Token: 0x06024555 RID: 148821 RVA: 0x0093B8E4 File Offset: 0x00939AE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SyncPos(USceneComponent From, USceneComponent To)
		{
			BP_KuroCSCloth_DynamicPin_C.__SyncPos_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_C.__SyncPos_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_C.__SyncPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_C.__SyncPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__SyncPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024556 RID: 148822 RVA: 0x0093B952 File Offset: 0x00939B52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SyncToBindPin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__SyncToBindPin_NativeFunctionPtr, null);
		}

		// Token: 0x06024557 RID: 148823 RVA: 0x0093B966 File Offset: 0x00939B66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawAndSetPin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__DrawAndSetPin_NativeFunctionPtr, null);
		}

		// Token: 0x06024558 RID: 148824 RVA: 0x0093B97A File Offset: 0x00939B7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024559 RID: 148825 RVA: 0x0093B98E File Offset: 0x00939B8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602455A RID: 148826 RVA: 0x0093B9A3 File Offset: 0x00939BA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602455B RID: 148827 RVA: 0x0093B9B7 File Offset: 0x00939BB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602455C RID: 148828 RVA: 0x0093B9CC File Offset: 0x00939BCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602455D RID: 148829 RVA: 0x0093BA14 File Offset: 0x00939C14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602455E RID: 148830 RVA: 0x0093BA5B File Offset: 0x00939C5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602455F RID: 148831 RVA: 0x0093BA70 File Offset: 0x00939C70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024560 RID: 148832 RVA: 0x0093BABC File Offset: 0x00939CBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024561 RID: 148833 RVA: 0x0093BB08 File Offset: 0x00939D08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024562 RID: 148834 RVA: 0x0093BBC4 File Offset: 0x00939DC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024563 RID: 148835 RVA: 0x0093BC4D File Offset: 0x00939E4D
		protected BP_KuroCSCloth_DynamicPin_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401202A RID: 73770
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin.BP_KuroCSCloth_DynamicPin_C";

		// Token: 0x0401202B RID: 73771
		private static IntPtr _ClassPtr;

		// Token: 0x0401202C RID: 73772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401202D RID: 73773
		internal static int __PropertyOffset_1;

		// Token: 0x0401202E RID: 73774
		internal static int __PropertyOffset_2;

		// Token: 0x0401202F RID: 73775
		internal static int __PropertyOffset_3;

		// Token: 0x04012030 RID: 73776
		internal static int __PropertyOffset_4;

		// Token: 0x04012031 RID: 73777
		internal static int __PropertyOffset_5;

		// Token: 0x04012032 RID: 73778
		internal static int __PropertyOffset_6;

		// Token: 0x04012033 RID: 73779
		internal static int __PropertyOffset_7;

		// Token: 0x04012034 RID: 73780
		internal static int __PropertyOffset_8;

		// Token: 0x04012035 RID: 73781
		internal static int __PropertyOffset_9;

		// Token: 0x04012036 RID: 73782
		internal static int __PropertyOffset_10;

		// Token: 0x04012037 RID: 73783
		internal static int __PropertyOffset_11;

		// Token: 0x04012038 RID: 73784
		internal static int __PropertyOffset_12;

		// Token: 0x04012039 RID: 73785
		internal static int __PropertyOffset_13;

		// Token: 0x0401203A RID: 73786
		internal static int __PropertyOffset_14;

		// Token: 0x0401203B RID: 73787
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x0401203C RID: 73788
		internal static int __PropertyOffset_15;

		// Token: 0x0401203D RID: 73789
		internal static int __PropertyOffset_16;

		// Token: 0x0401203E RID: 73790
		internal static int __PropertyOffset_17;

		// Token: 0x0401203F RID: 73791
		internal static int __PropertyOffset_18;

		// Token: 0x04012040 RID: 73792
		internal static int __PropertyOffset_19;

		// Token: 0x04012041 RID: 73793
		internal static int __PropertyOffset_20;

		// Token: 0x04012042 RID: 73794
		internal static int __PropertyOffset_21;

		// Token: 0x04012043 RID: 73795
		internal static int __PropertyOffset_22;

		// Token: 0x04012044 RID: 73796
		internal static int __PropertyOffset_23;

		// Token: 0x04012045 RID: 73797
		internal static int __PropertyOffset_24;

		// Token: 0x04012046 RID: 73798
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04012047 RID: 73799
		internal static int __PropertyOffset_25;

		// Token: 0x04012048 RID: 73800
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04012049 RID: 73801
		internal static int __PropertyOffset_26;

		// Token: 0x0401204A RID: 73802
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0401204B RID: 73803
		internal static int __PropertyOffset_27;

		// Token: 0x0401204C RID: 73804
		internal static int __PropertyOffset_28;

		// Token: 0x0401204D RID: 73805
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x0401204E RID: 73806
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x0401204F RID: 73807
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04012050 RID: 73808
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04012051 RID: 73809
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04012052 RID: 73810
		private static IntPtr __FitToBridge_NativeFunctionPtr;

		// Token: 0x04012053 RID: 73811
		private static IntPtr __DrawDeformPoints_NativeFunctionPtr;

		// Token: 0x04012054 RID: 73812
		private static IntPtr __SyncPos_NativeFunctionPtr;

		// Token: 0x04012055 RID: 73813
		private static IntPtr __SyncToBindPin_NativeFunctionPtr;

		// Token: 0x04012056 RID: 73814
		private static IntPtr __DrawAndSetPin_NativeFunctionPtr;

		// Token: 0x04012057 RID: 73815
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012058 RID: 73816
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012059 RID: 73817
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401205A RID: 73818
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401205B RID: 73819
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0401205C RID: 73820
		private static IntPtr __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401205D RID: 73821
		private static IntPtr __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009EFF RID: 40703
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __SyncPos_FunctionParams
		{
			// Token: 0x0403182E RID: 202798
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x0403182F RID: 202799
			[FieldOffset(8)]
			public IntPtr To;
		}

		// Token: 0x02009F00 RID: 40704
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031830 RID: 202800
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F01 RID: 40705
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031831 RID: 202801
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F02 RID: 40706
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031832 RID: 202802
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031833 RID: 202803
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031834 RID: 202804
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031835 RID: 202805
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031836 RID: 202806
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031837 RID: 202807
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F03 RID: 40707
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031838 RID: 202808
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031839 RID: 202809
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403183A RID: 202810
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403183B RID: 202811
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
