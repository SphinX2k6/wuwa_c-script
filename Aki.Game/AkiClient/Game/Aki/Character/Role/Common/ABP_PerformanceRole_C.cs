using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.DT;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200409E RID: 16542
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C")]
	[UnrealStructLayout(32576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 32566)]
	public class ABP_PerformanceRole_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AAD4 RID: 174804 RVA: 0x009E87C4 File Offset: 0x009E69C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_PerformanceRole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C");
			}
			return ABP_PerformanceRole_C._ClassPtr;
		}

		// Token: 0x0602AAD5 RID: 174805 RVA: 0x009E87E8 File Offset: 0x009E69E8
		public ABP_PerformanceRole_C() : this(BuiltinUtils.AllocNativeUObject(ABP_PerformanceRole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AAD6 RID: 174806 RVA: 0x009E8810 File Offset: 0x009E6A10
		[NullableContext(1)]
		public ABP_PerformanceRole_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_PerformanceRole_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068E3 RID: 26851
		// (get) Token: 0x0602AAD7 RID: 174807 RVA: 0x009E8843 File Offset: 0x009E6A43
		// (set) Token: 0x0602AAD8 RID: 174808 RVA: 0x009E8857 File Offset: 0x009E6A57
		public unsafe TEnumAsByte<EPerformanceRoleState> StateInternal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_261);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_261) = value;
			}
		}

		// Token: 0x170068E4 RID: 26852
		// (get) Token: 0x0602AAD9 RID: 174809 RVA: 0x009E886C File Offset: 0x009E6A6C
		// (set) Token: 0x0602AADA RID: 174810 RVA: 0x009E887C File Offset: 0x009E6A7C
		public unsafe bool reLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_262) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_262) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068E5 RID: 26853
		// (get) Token: 0x0602AADB RID: 174811 RVA: 0x009E888D File Offset: 0x009E6A8D
		// (set) Token: 0x0602AADC RID: 174812 RVA: 0x009E889D File Offset: 0x009E6A9D
		public unsafe bool bForceChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_263) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_263) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068E6 RID: 26854
		// (get) Token: 0x0602AADD RID: 174813 RVA: 0x009E88AE File Offset: 0x009E6AAE
		// (set) Token: 0x0602AADE RID: 174814 RVA: 0x009E88BE File Offset: 0x009E6ABE
		public unsafe float Delta_Time_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_264);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_264) = value;
			}
		}

		// Token: 0x170068E7 RID: 26855
		// (get) Token: 0x0602AADF RID: 174815 RVA: 0x009E88CF File Offset: 0x009E6ACF
		// (set) Token: 0x0602AAE0 RID: 174816 RVA: 0x009E88DF File Offset: 0x009E6ADF
		public unsafe float HeadAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_265);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_265) = value;
			}
		}

		// Token: 0x170068E8 RID: 26856
		// (get) Token: 0x0602AAE1 RID: 174817 RVA: 0x009E88F0 File Offset: 0x009E6AF0
		// (set) Token: 0x0602AAE2 RID: 174818 RVA: 0x009E8929 File Offset: 0x009E6B29
		[Nullable(1)]
		public OnEffectBegin OnEffectBegin
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnEffectBegin result;
				if ((result = this._OnEffectBegin) == null)
				{
					result = (this._OnEffectBegin = new OnEffectBegin(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_266, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_266, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170068E9 RID: 26857
		// (get) Token: 0x0602AAE3 RID: 174819 RVA: 0x009E894C File Offset: 0x009E6B4C
		// (set) Token: 0x0602AAE4 RID: 174820 RVA: 0x009E8985 File Offset: 0x009E6B85
		[Nullable(1)]
		public OnEffectEnd OnEffectEnd
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnEffectEnd result;
				if ((result = this._OnEffectEnd) == null)
				{
					result = (this._OnEffectEnd = new OnEffectEnd(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_267, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_267, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170068EA RID: 26858
		// (get) Token: 0x0602AAE5 RID: 174821 RVA: 0x009E89A6 File Offset: 0x009E6BA6
		// (set) Token: 0x0602AAE6 RID: 174822 RVA: 0x009E89B6 File Offset: 0x009E6BB6
		public unsafe float PerformDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_268);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_268) = value;
			}
		}

		// Token: 0x170068EB RID: 26859
		// (get) Token: 0x0602AAE7 RID: 174823 RVA: 0x009E89C7 File Offset: 0x009E6BC7
		// (set) Token: 0x0602AAE8 RID: 174824 RVA: 0x009E89D7 File Offset: 0x009E6BD7
		public unsafe float CurPerformTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_269);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_269) = value;
			}
		}

		// Token: 0x170068EC RID: 26860
		// (get) Token: 0x0602AAE9 RID: 174825 RVA: 0x009E89E8 File Offset: 0x009E6BE8
		// (set) Token: 0x0602AAEA RID: 174826 RVA: 0x009E89F8 File Offset: 0x009E6BF8
		public unsafe bool bForceChange_Perform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_270) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_270) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068ED RID: 26861
		// (get) Token: 0x0602AAEB RID: 174827 RVA: 0x009E8A09 File Offset: 0x009E6C09
		// (set) Token: 0x0602AAEC RID: 174828 RVA: 0x009E8A1D File Offset: 0x009E6C1D
		public unsafe FVector2D CacheViewportSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_271);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_271) = value;
			}
		}

		// Token: 0x170068EE RID: 26862
		// (get) Token: 0x0602AAED RID: 174829 RVA: 0x009E8A32 File Offset: 0x009E6C32
		// (set) Token: 0x0602AAEE RID: 174830 RVA: 0x009E8A46 File Offset: 0x009E6C46
		public unsafe FVector LookAtWorld_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_272);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_272) = value;
			}
		}

		// Token: 0x170068EF RID: 26863
		// (get) Token: 0x0602AAEF RID: 174831 RVA: 0x009E8A5B File Offset: 0x009E6C5B
		// (set) Token: 0x0602AAF0 RID: 174832 RVA: 0x009E8A6F File Offset: 0x009E6C6F
		[Nullable(2)]
		public unsafe USkeletalMeshComponent Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_273);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_273, value);
			}
		}

		// Token: 0x170068F0 RID: 26864
		// (get) Token: 0x0602AAF1 RID: 174833 RVA: 0x009E8A84 File Offset: 0x009E6C84
		// (set) Token: 0x0602AAF2 RID: 174834 RVA: 0x009E8A98 File Offset: 0x009E6C98
		public unsafe FVector LookAtDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_274);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_274) = value;
			}
		}

		// Token: 0x170068F1 RID: 26865
		// (get) Token: 0x0602AAF3 RID: 174835 RVA: 0x009E8AAD File Offset: 0x009E6CAD
		// (set) Token: 0x0602AAF4 RID: 174836 RVA: 0x009E8ABD File Offset: 0x009E6CBD
		public unsafe bool IsCreateRoleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_275) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_275) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068F2 RID: 26866
		// (get) Token: 0x0602AAF5 RID: 174837 RVA: 0x009E8ACE File Offset: 0x009E6CCE
		// (set) Token: 0x0602AAF6 RID: 174838 RVA: 0x009E8AE2 File Offset: 0x009E6CE2
		public unsafe FVector CreateRoleStartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_276);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_276) = value;
			}
		}

		// Token: 0x170068F3 RID: 26867
		// (get) Token: 0x0602AAF7 RID: 174839 RVA: 0x009E8AF7 File Offset: 0x009E6CF7
		// (set) Token: 0x0602AAF8 RID: 174840 RVA: 0x009E8B0B File Offset: 0x009E6D0B
		public unsafe FVector CreateRoleEndLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_277);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_277) = value;
			}
		}

		// Token: 0x170068F4 RID: 26868
		// (get) Token: 0x0602AAF9 RID: 174841 RVA: 0x009E8B20 File Offset: 0x009E6D20
		// (set) Token: 0x0602AAFA RID: 174842 RVA: 0x009E8B30 File Offset: 0x009E6D30
		public unsafe float CreateRoleMoveAllTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_278);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_278) = value;
			}
		}

		// Token: 0x170068F5 RID: 26869
		// (get) Token: 0x0602AAFB RID: 174843 RVA: 0x009E8B41 File Offset: 0x009E6D41
		// (set) Token: 0x0602AAFC RID: 174844 RVA: 0x009E8B55 File Offset: 0x009E6D55
		[Nullable(2)]
		public unsafe TsUiSceneRoleActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsUiSceneRoleActor>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_279);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_279, value);
			}
		}

		// Token: 0x170068F6 RID: 26870
		// (get) Token: 0x0602AAFD RID: 174845 RVA: 0x009E8B6A File Offset: 0x009E6D6A
		// (set) Token: 0x0602AAFE RID: 174846 RVA: 0x009E8B7A File Offset: 0x009E6D7A
		public unsafe float CreateRoleMoveCurrentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_280);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_280) = value;
			}
		}

		// Token: 0x170068F7 RID: 26871
		// (get) Token: 0x0602AAFF RID: 174847 RVA: 0x009E8B8B File Offset: 0x009E6D8B
		// (set) Token: 0x0602AB00 RID: 174848 RVA: 0x009E8B9F File Offset: 0x009E6D9F
		public unsafe FRotator CreateRoleStartRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_281);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_281) = value;
			}
		}

		// Token: 0x170068F8 RID: 26872
		// (get) Token: 0x0602AB01 RID: 174849 RVA: 0x009E8BB4 File Offset: 0x009E6DB4
		// (set) Token: 0x0602AB02 RID: 174850 RVA: 0x009E8BC8 File Offset: 0x009E6DC8
		public unsafe FVector CreateRoleEndLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_282);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_282) = value;
			}
		}

		// Token: 0x170068F9 RID: 26873
		// (get) Token: 0x0602AB03 RID: 174851 RVA: 0x009E8BDD File Offset: 0x009E6DDD
		// (set) Token: 0x0602AB04 RID: 174852 RVA: 0x009E8BF1 File Offset: 0x009E6DF1
		public unsafe FRotator CreateRoleEndRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_283);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_283) = value;
			}
		}

		// Token: 0x170068FA RID: 26874
		// (get) Token: 0x0602AB05 RID: 174853 RVA: 0x009E8C06 File Offset: 0x009E6E06
		// (set) Token: 0x0602AB06 RID: 174854 RVA: 0x009E8C1A File Offset: 0x009E6E1A
		public unsafe FRotator CreateRoleEndRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_284);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_284) = value;
			}
		}

		// Token: 0x170068FB RID: 26875
		// (get) Token: 0x0602AB07 RID: 174855 RVA: 0x009E8C2F File Offset: 0x009E6E2F
		// (set) Token: 0x0602AB08 RID: 174856 RVA: 0x009E8C3F File Offset: 0x009E6E3F
		public unsafe float CreateRoleMovePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_285);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_285) = value;
			}
		}

		// Token: 0x170068FC RID: 26876
		// (get) Token: 0x0602AB09 RID: 174857 RVA: 0x009E8C50 File Offset: 0x009E6E50
		// (set) Token: 0x0602AB0A RID: 174858 RVA: 0x009E8C60 File Offset: 0x009E6E60
		public unsafe bool HasInitCreateRoleInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_286) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_286) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068FD RID: 26877
		// (get) Token: 0x0602AB0B RID: 174859 RVA: 0x009E8C71 File Offset: 0x009E6E71
		// (set) Token: 0x0602AB0C RID: 174860 RVA: 0x009E8C81 File Offset: 0x009E6E81
		public unsafe bool isLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_287) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_287) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068FE RID: 26878
		// (get) Token: 0x0602AB0D RID: 174861 RVA: 0x009E8C92 File Offset: 0x009E6E92
		// (set) Token: 0x0602AB0E RID: 174862 RVA: 0x009E8CA2 File Offset: 0x009E6EA2
		public unsafe bool bInitCreateRoleInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_288) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_288) = (value ? 1 : 0);
			}
		}

		// Token: 0x170068FF RID: 26879
		// (get) Token: 0x0602AB0F RID: 174863 RVA: 0x009E8CB3 File Offset: 0x009E6EB3
		// (set) Token: 0x0602AB10 RID: 174864 RVA: 0x009E8CC3 File Offset: 0x009E6EC3
		public unsafe bool InSkillRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_289) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_289) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006900 RID: 26880
		// (get) Token: 0x0602AB11 RID: 174865 RVA: 0x009E8CD4 File Offset: 0x009E6ED4
		// (set) Token: 0x0602AB12 RID: 174866 RVA: 0x009E8CE4 File Offset: 0x009E6EE4
		public unsafe bool InSkillEndRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_290) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_290) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006901 RID: 26881
		// (get) Token: 0x0602AB13 RID: 174867 RVA: 0x009E8CF5 File Offset: 0x009E6EF5
		// (set) Token: 0x0602AB14 RID: 174868 RVA: 0x009E8D05 File Offset: 0x009E6F05
		public unsafe bool TempRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_291) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_291) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006902 RID: 26882
		// (get) Token: 0x0602AB15 RID: 174869 RVA: 0x009E8D18 File Offset: 0x009E6F18
		// (set) Token: 0x0602AB16 RID: 174870 RVA: 0x009E8D51 File Offset: 0x009E6F51
		[Nullable(1)]
		public SPerformanceRoleInfo PerformanceRoleInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SPerformanceRoleInfo result;
				if ((result = this._PerformanceRoleInfo) == null)
				{
					result = (this._PerformanceRoleInfo = new SPerformanceRoleInfo(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_292, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPerformanceRoleInfo.StaticStruct(), base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_292, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006903 RID: 26883
		// (get) Token: 0x0602AB17 RID: 174871 RVA: 0x009E8D72 File Offset: 0x009E6F72
		// (set) Token: 0x0602AB18 RID: 174872 RVA: 0x009E8D82 File Offset: 0x009E6F82
		public unsafe float BlinkAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_293);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_293) = value;
			}
		}

		// Token: 0x17006904 RID: 26884
		// (get) Token: 0x0602AB19 RID: 174873 RVA: 0x009E8D93 File Offset: 0x009E6F93
		// (set) Token: 0x0602AB1A RID: 174874 RVA: 0x009E8DA3 File Offset: 0x009E6FA3
		public unsafe bool InBlinking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_294) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_294) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006905 RID: 26885
		// (get) Token: 0x0602AB1B RID: 174875 RVA: 0x009E8DB4 File Offset: 0x009E6FB4
		// (set) Token: 0x0602AB1C RID: 174876 RVA: 0x009E8DC4 File Offset: 0x009E6FC4
		public unsafe float BlinkEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_295);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_295) = value;
			}
		}

		// Token: 0x17006906 RID: 26886
		// (get) Token: 0x0602AB1D RID: 174877 RVA: 0x009E8DD5 File Offset: 0x009E6FD5
		// (set) Token: 0x0602AB1E RID: 174878 RVA: 0x009E8DE5 File Offset: 0x009E6FE5
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_296);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_296) = value;
			}
		}

		// Token: 0x17006907 RID: 26887
		// (get) Token: 0x0602AB1F RID: 174879 RVA: 0x009E8DF6 File Offset: 0x009E6FF6
		// (set) Token: 0x0602AB20 RID: 174880 RVA: 0x009E8E06 File Offset: 0x009E7006
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_297);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_297) = value;
			}
		}

		// Token: 0x17006908 RID: 26888
		// (get) Token: 0x0602AB21 RID: 174881 RVA: 0x009E8E18 File Offset: 0x009E7018
		// (set) Token: 0x0602AB22 RID: 174882 RVA: 0x009E8E51 File Offset: 0x009E7051
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EPerformanceRoleState>> SameStateArray01
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EPerformanceRoleState>> result;
				if ((result = this._SameStateArray01) == null)
				{
					result = (this._SameStateArray01 = new TArray<TEnumAsByte<EPerformanceRoleState>>(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_298, this));
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
				this.SameStateArray01.CopyAssign(value);
			}
		}

		// Token: 0x17006909 RID: 26889
		// (get) Token: 0x0602AB23 RID: 174883 RVA: 0x009E8E5F File Offset: 0x009E705F
		// (set) Token: 0x0602AB24 RID: 174884 RVA: 0x009E8E6F File Offset: 0x009E706F
		public unsafe bool False
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_299) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_299) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700690A RID: 26890
		// (get) Token: 0x0602AB25 RID: 174885 RVA: 0x009E8E80 File Offset: 0x009E7080
		// (set) Token: 0x0602AB26 RID: 174886 RVA: 0x009E8E90 File Offset: 0x009E7090
		public unsafe bool DirectEnterLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_300) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_300) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700690B RID: 26891
		// (get) Token: 0x0602AB27 RID: 174887 RVA: 0x009E8EA1 File Offset: 0x009E70A1
		// (set) Token: 0x0602AB28 RID: 174888 RVA: 0x009E8EB5 File Offset: 0x009E70B5
		public unsafe TEnumAsByte<EPerformanceRoleState> CurrentState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_301);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_301) = value;
			}
		}

		// Token: 0x1700690C RID: 26892
		// (get) Token: 0x0602AB29 RID: 174889 RVA: 0x009E8ECA File Offset: 0x009E70CA
		// (set) Token: 0x0602AB2A RID: 174890 RVA: 0x009E8EDA File Offset: 0x009E70DA
		public unsafe bool reLoopFromLoopToStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_302) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_302) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700690D RID: 26893
		// (get) Token: 0x0602AB2B RID: 174891 RVA: 0x009E8EEB File Offset: 0x009E70EB
		// (set) Token: 0x0602AB2C RID: 174892 RVA: 0x009E8EFB File Offset: 0x009E70FB
		public unsafe bool bForceEnterLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_303) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_303) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700690E RID: 26894
		// (get) Token: 0x0602AB2D RID: 174893 RVA: 0x009E8F0C File Offset: 0x009E710C
		// (set) Token: 0x0602AB2E RID: 174894 RVA: 0x009E8F1C File Offset: 0x009E711C
		public unsafe bool bInstantAttributeBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_304) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_304) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AB2F RID: 174895 RVA: 0x009E8F30 File Offset: 0x009E7130
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PostProcessPose(FPoseLink InPose, ref FPoseLink PostProcessPose)
		{
			ABP_PerformanceRole_C.__PostProcessPose_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__PostProcessPose_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_PerformanceRole_C.__PostProcessPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__PostProcessPose_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (PostProcessPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->PostProcessPose, PostProcessPose.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__PostProcessPose_NativeFunctionPtr, (void*)ptr);
			if (PostProcessPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), PostProcessPose.NativePtr, &ptr->PostProcessPose, 1, false);
			}
		}

		// Token: 0x0602AB30 RID: 174896 RVA: 0x009E8FDC File Offset: 0x009E71DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BasePose(ref FPoseLink BasePose)
		{
			ABP_PerformanceRole_C.__BasePose_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__BasePose_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_PerformanceRole_C.__BasePose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__BasePose_NativeFunctionPtr, (void*)ptr, 1);
			if (BasePose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->BasePose, BasePose.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__BasePose_NativeFunctionPtr, (void*)ptr);
			if (BasePose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), BasePose.NativePtr, &ptr->BasePose, 1, false);
			}
		}

		// Token: 0x0602AB31 RID: 174897 RVA: 0x009E9064 File Offset: 0x009E7264
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_PerformanceRole_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_PerformanceRole_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AB32 RID: 174898 RVA: 0x009E90EC File Offset: 0x009E72EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetInstantAttributeBlend(bool bInstant)
		{
			ABP_PerformanceRole_C.__SetInstantAttributeBlend_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__SetInstantAttributeBlend_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_PerformanceRole_C.__SetInstantAttributeBlend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__SetInstantAttributeBlend_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstant = bInstant;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SetInstantAttributeBlend_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB33 RID: 174899 RVA: 0x009E9132 File Offset: 0x009E7332
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TryForceEnterLoop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__TryForceEnterLoop_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB34 RID: 174900 RVA: 0x009E9148 File Offset: 0x009E7348
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Current_State(EPerformanceRoleState state)
		{
			ABP_PerformanceRole_C.__Set_Current_State_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__Set_Current_State_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_PerformanceRole_C.__Set_Current_State_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__Set_Current_State_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__Set_Current_State_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB35 RID: 174901 RVA: 0x009E9194 File Offset: 0x009E7394
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool Is_Same_State(EPerformanceRoleState NewState, in EPerformanceRoleState StateInternal)
		{
			ABP_PerformanceRole_C.__Is_Same_State_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__Is_Same_State_FunctionParams[(UIntPtr)21] + 15L / (long)sizeof(ABP_PerformanceRole_C.__Is_Same_State_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__Is_Same_State_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewState = NewState;
			ptr->StateInternal = (EPerformanceRoleState)StateInternal;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__Is_Same_State_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602AB36 RID: 174902 RVA: 0x009E91F2 File Offset: 0x009E73F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateBlinkInfo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateBlinkInfo_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB37 RID: 174903 RVA: 0x009E9206 File Offset: 0x009E7406
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SkillRotate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SkillRotate_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB38 RID: 174904 RVA: 0x009E921C File Offset: 0x009E741C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetIsLooping(ref bool isLooping)
		{
			ABP_PerformanceRole_C.__GetIsLooping_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__GetIsLooping_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_PerformanceRole_C.__GetIsLooping_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__GetIsLooping_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isLooping = isLooping;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__GetIsLooping_NativeFunctionPtr, (void*)ptr);
			isLooping = ptr->isLooping;
		}

		// Token: 0x0602AB39 RID: 174905 RVA: 0x009E926B File Offset: 0x009E746B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearCreateRoleState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__ClearCreateRoleState_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB3A RID: 174906 RVA: 0x009E927F File Offset: 0x009E747F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCreateRoleLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateCreateRoleLocation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB3B RID: 174907 RVA: 0x009E9294 File Offset: 0x009E7494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DebugLine(FVector LineStart, FVector LineEnd, FLinearColor LineColor)
		{
			ABP_PerformanceRole_C.__DebugLine_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__DebugLine_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(ABP_PerformanceRole_C.__DebugLine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__DebugLine_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LineStart = LineStart;
			ptr->LineEnd = LineEnd;
			ptr->LineColor = LineColor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__DebugLine_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB3C RID: 174908 RVA: 0x009E92E8 File Offset: 0x009E74E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLookAtRotation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateLookAtRotation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB3D RID: 174909 RVA: 0x009E92FC File Offset: 0x009E74FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePerfromTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdatePerfromTime_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB3E RID: 174910 RVA: 0x009E9310 File Offset: 0x009E7510
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPerformDelay(float PerformTime)
		{
			ABP_PerformanceRole_C.__SetPerformDelay_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__SetPerformDelay_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PerformanceRole_C.__SetPerformDelay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__SetPerformDelay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PerformTime = PerformTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SetPerformDelay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB3F RID: 174911 RVA: 0x009E9358 File Offset: 0x009E7558
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SyncAnimInstance(ABP_PerformanceRole_C SourceAnimInstance)
		{
			ABP_PerformanceRole_C.__SyncAnimInstance_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__SyncAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_PerformanceRole_C.__SyncAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__SyncAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SourceAnimInstance = ((SourceAnimInstance != null) ? SourceAnimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SyncAnimInstance_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB40 RID: 174912 RVA: 0x009E93AD File Offset: 0x009E75AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateHeadRotator()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateHeadRotator_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB41 RID: 174913 RVA: 0x009E93C4 File Offset: 0x009E75C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float GetHeadApha()
		{
			ABP_PerformanceRole_C.__GetHeadApha_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__GetHeadApha_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_PerformanceRole_C.__GetHeadApha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__GetHeadApha_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__GetHeadApha_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602AB42 RID: 174914 RVA: 0x009E940C File Offset: 0x009E760C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetState(EPerformanceRoleState State, bool reLoop, bool reLoopFromLoopToStart, bool WaitLaseStateEnd)
		{
			ABP_PerformanceRole_C.__SetState_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__SetState_FunctionParams[(UIntPtr)29] + 15L / (long)sizeof(ABP_PerformanceRole_C.__SetState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__SetState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			ptr->reLoop = reLoop;
			ptr->reLoopFromLoopToStart = reLoopFromLoopToStart;
			ptr->WaitLaseStateEnd = WaitLaseStateEnd;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SetState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB43 RID: 174915 RVA: 0x009E9470 File Offset: 0x009E7670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AB44 RID: 174916 RVA: 0x009E94B8 File Offset: 0x009E76B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AB45 RID: 174917 RVA: 0x009E94FF File Offset: 0x009E76FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602AB46 RID: 174918 RVA: 0x009E9513 File Offset: 0x009E7713
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AB47 RID: 174919 RVA: 0x009E9528 File Offset: 0x009E7728
		protected ABP_PerformanceRole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016152 RID: 90450
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C";

		// Token: 0x04016153 RID: 90451
		private static IntPtr _ClassPtr;

		// Token: 0x04016154 RID: 90452
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016155 RID: 90453
		public static IntPtr __OnEffectEnd__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04016156 RID: 90454
		public static IntPtr __OnEffectBegin__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04016157 RID: 90455
		internal static int __PropertyOffset_261;

		// Token: 0x04016158 RID: 90456
		internal static int __PropertyOffset_262;

		// Token: 0x04016159 RID: 90457
		internal static int __PropertyOffset_263;

		// Token: 0x0401615A RID: 90458
		internal static int __PropertyOffset_264;

		// Token: 0x0401615B RID: 90459
		internal static int __PropertyOffset_265;

		// Token: 0x0401615C RID: 90460
		internal static int __PropertyOffset_266;

		// Token: 0x0401615D RID: 90461
		[Nullable(2)]
		private OnEffectBegin _OnEffectBegin;

		// Token: 0x0401615E RID: 90462
		internal static int __PropertyOffset_267;

		// Token: 0x0401615F RID: 90463
		[Nullable(2)]
		private OnEffectEnd _OnEffectEnd;

		// Token: 0x04016160 RID: 90464
		internal static int __PropertyOffset_268;

		// Token: 0x04016161 RID: 90465
		internal static int __PropertyOffset_269;

		// Token: 0x04016162 RID: 90466
		internal static int __PropertyOffset_270;

		// Token: 0x04016163 RID: 90467
		internal static int __PropertyOffset_271;

		// Token: 0x04016164 RID: 90468
		internal static int __PropertyOffset_272;

		// Token: 0x04016165 RID: 90469
		internal static int __PropertyOffset_273;

		// Token: 0x04016166 RID: 90470
		internal static int __PropertyOffset_274;

		// Token: 0x04016167 RID: 90471
		internal static int __PropertyOffset_275;

		// Token: 0x04016168 RID: 90472
		internal static int __PropertyOffset_276;

		// Token: 0x04016169 RID: 90473
		internal static int __PropertyOffset_277;

		// Token: 0x0401616A RID: 90474
		internal static int __PropertyOffset_278;

		// Token: 0x0401616B RID: 90475
		internal static int __PropertyOffset_279;

		// Token: 0x0401616C RID: 90476
		internal static int __PropertyOffset_280;

		// Token: 0x0401616D RID: 90477
		internal static int __PropertyOffset_281;

		// Token: 0x0401616E RID: 90478
		internal static int __PropertyOffset_282;

		// Token: 0x0401616F RID: 90479
		internal static int __PropertyOffset_283;

		// Token: 0x04016170 RID: 90480
		internal static int __PropertyOffset_284;

		// Token: 0x04016171 RID: 90481
		internal static int __PropertyOffset_285;

		// Token: 0x04016172 RID: 90482
		internal static int __PropertyOffset_286;

		// Token: 0x04016173 RID: 90483
		internal static int __PropertyOffset_287;

		// Token: 0x04016174 RID: 90484
		internal static int __PropertyOffset_288;

		// Token: 0x04016175 RID: 90485
		internal static int __PropertyOffset_289;

		// Token: 0x04016176 RID: 90486
		internal static int __PropertyOffset_290;

		// Token: 0x04016177 RID: 90487
		internal static int __PropertyOffset_291;

		// Token: 0x04016178 RID: 90488
		internal static int __PropertyOffset_292;

		// Token: 0x04016179 RID: 90489
		[Nullable(2)]
		private SPerformanceRoleInfo _PerformanceRoleInfo;

		// Token: 0x0401617A RID: 90490
		internal static int __PropertyOffset_293;

		// Token: 0x0401617B RID: 90491
		internal static int __PropertyOffset_294;

		// Token: 0x0401617C RID: 90492
		internal static int __PropertyOffset_295;

		// Token: 0x0401617D RID: 90493
		internal static int __PropertyOffset_296;

		// Token: 0x0401617E RID: 90494
		internal static int __PropertyOffset_297;

		// Token: 0x0401617F RID: 90495
		internal static int __PropertyOffset_298;

		// Token: 0x04016180 RID: 90496
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EPerformanceRoleState>> _SameStateArray01;

		// Token: 0x04016181 RID: 90497
		internal static int __PropertyOffset_299;

		// Token: 0x04016182 RID: 90498
		internal static int __PropertyOffset_300;

		// Token: 0x04016183 RID: 90499
		internal static int __PropertyOffset_301;

		// Token: 0x04016184 RID: 90500
		internal static int __PropertyOffset_302;

		// Token: 0x04016185 RID: 90501
		internal static int __PropertyOffset_303;

		// Token: 0x04016186 RID: 90502
		internal static int __PropertyOffset_304;

		// Token: 0x04016187 RID: 90503
		private static IntPtr __PostProcessPose_NativeFunctionPtr;

		// Token: 0x04016188 RID: 90504
		private static IntPtr __BasePose_NativeFunctionPtr;

		// Token: 0x04016189 RID: 90505
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0401618A RID: 90506
		private static IntPtr __SetInstantAttributeBlend_NativeFunctionPtr;

		// Token: 0x0401618B RID: 90507
		private static IntPtr __TryForceEnterLoop_NativeFunctionPtr;

		// Token: 0x0401618C RID: 90508
		private static IntPtr __Set_Current_State_NativeFunctionPtr;

		// Token: 0x0401618D RID: 90509
		private static IntPtr __Is_Same_State_NativeFunctionPtr;

		// Token: 0x0401618E RID: 90510
		private static IntPtr __UpdateBlinkInfo_NativeFunctionPtr;

		// Token: 0x0401618F RID: 90511
		private static IntPtr __SkillRotate_NativeFunctionPtr;

		// Token: 0x04016190 RID: 90512
		private static IntPtr __GetIsLooping_NativeFunctionPtr;

		// Token: 0x04016191 RID: 90513
		private static IntPtr __ClearCreateRoleState_NativeFunctionPtr;

		// Token: 0x04016192 RID: 90514
		private static IntPtr __UpdateCreateRoleLocation_NativeFunctionPtr;

		// Token: 0x04016193 RID: 90515
		private static IntPtr __DebugLine_NativeFunctionPtr;

		// Token: 0x04016194 RID: 90516
		private static IntPtr __UpdateLookAtRotation_NativeFunctionPtr;

		// Token: 0x04016195 RID: 90517
		private static IntPtr __UpdatePerfromTime_NativeFunctionPtr;

		// Token: 0x04016196 RID: 90518
		private static IntPtr __SetPerformDelay_NativeFunctionPtr;

		// Token: 0x04016197 RID: 90519
		private static IntPtr __SyncAnimInstance_NativeFunctionPtr;

		// Token: 0x04016198 RID: 90520
		private static IntPtr __UpdateHeadRotator_NativeFunctionPtr;

		// Token: 0x04016199 RID: 90521
		private static IntPtr __GetHeadApha_NativeFunctionPtr;

		// Token: 0x0401619A RID: 90522
		private static IntPtr __SetState_NativeFunctionPtr;

		// Token: 0x0401619B RID: 90523
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0401619C RID: 90524
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A407 RID: 41991
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PostProcessPose_FunctionParams
		{
			// Token: 0x04032237 RID: 205367
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x04032238 RID: 205368
			[FieldOffset(24)]
			public byte PostProcessPose;
		}

		// Token: 0x0200A408 RID: 41992
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BasePose_FunctionParams
		{
			// Token: 0x04032239 RID: 205369
			[FieldOffset(0)]
			public byte BasePose;
		}

		// Token: 0x0200A409 RID: 41993
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403223A RID: 205370
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A40A RID: 41994
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetInstantAttributeBlend_FunctionParams
		{
			// Token: 0x0403223B RID: 205371
			[FieldOffset(0)]
			public bool bInstant;
		}

		// Token: 0x0200A40B RID: 41995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __Set_Current_State_FunctionParams
		{
			// Token: 0x0403223C RID: 205372
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> state;
		}

		// Token: 0x0200A40C RID: 41996
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 6)]
		protected ref struct __Is_Same_State_FunctionParams
		{
			// Token: 0x0403223D RID: 205373
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> NewState;

			// Token: 0x0403223E RID: 205374
			[FieldOffset(1)]
			public TEnumAsByte<EPerformanceRoleState> StateInternal;

			// Token: 0x0403223F RID: 205375
			[FieldOffset(2)]
			public bool __Result;
		}

		// Token: 0x0200A40D RID: 41997
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetIsLooping_FunctionParams
		{
			// Token: 0x04032240 RID: 205376
			[FieldOffset(0)]
			public bool isLooping;
		}

		// Token: 0x0200A40E RID: 41998
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __DebugLine_FunctionParams
		{
			// Token: 0x04032241 RID: 205377
			[FieldOffset(0)]
			public FVector LineStart;

			// Token: 0x04032242 RID: 205378
			[FieldOffset(12)]
			public FVector LineEnd;

			// Token: 0x04032243 RID: 205379
			[FieldOffset(24)]
			public FLinearColor LineColor;
		}

		// Token: 0x0200A40F RID: 41999
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPerformDelay_FunctionParams
		{
			// Token: 0x04032244 RID: 205380
			[FieldOffset(0)]
			public float PerformTime;
		}

		// Token: 0x0200A410 RID: 42000
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SyncAnimInstance_FunctionParams
		{
			// Token: 0x04032245 RID: 205381
			[FieldOffset(0)]
			public IntPtr SourceAnimInstance;
		}

		// Token: 0x0200A411 RID: 42001
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetHeadApha_FunctionParams
		{
			// Token: 0x04032246 RID: 205382
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x0200A412 RID: 42002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 14)]
		protected ref struct __SetState_FunctionParams
		{
			// Token: 0x04032247 RID: 205383
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> State;

			// Token: 0x04032248 RID: 205384
			[FieldOffset(1)]
			public bool reLoop;

			// Token: 0x04032249 RID: 205385
			[FieldOffset(2)]
			public bool reLoopFromLoopToStart;

			// Token: 0x0403224A RID: 205386
			[FieldOffset(3)]
			public bool WaitLaseStateEnd;
		}

		// Token: 0x0200A413 RID: 42003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0403224B RID: 205387
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
