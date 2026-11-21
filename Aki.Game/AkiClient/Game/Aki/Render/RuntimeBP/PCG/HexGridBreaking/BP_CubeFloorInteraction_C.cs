using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.HexGridBreaking
{
	// Token: 0x020030E8 RID: 12520
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_CubeFloorInteraction.BP_CubeFloorInteraction_C")]
	[UnrealStructLayout(2040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2036)]
	public class BP_CubeFloorInteraction_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601E4C3 RID: 124099 RVA: 0x00910748 File Offset: 0x0090E948
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CubeFloorInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_CubeFloorInteraction.BP_CubeFloorInteraction_C");
			}
			return BP_CubeFloorInteraction_C._ClassPtr;
		}

		// Token: 0x0601E4C4 RID: 124100 RVA: 0x0091076C File Offset: 0x0090E96C
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_CubeFloorInteraction_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x0601E4C5 RID: 124101 RVA: 0x00910774 File Offset: 0x0090E974
		public BP_CubeFloorInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_CubeFloorInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E4C6 RID: 124102 RVA: 0x0091079C File Offset: 0x0090E99C
		public BP_CubeFloorInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CubeFloorInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0601E4C7 RID: 124103 RVA: 0x009107CF File Offset: 0x0090E9CF
		// (set) Token: 0x0601E4C8 RID: 124104 RVA: 0x009107E3 File Offset: 0x0090E9E3
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_Hub_Pro_101AL_FX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_SM_Hub_Pro_101AL_FX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_SM_Hub_Pro_101AL_FX, value);
			}
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0601E4C9 RID: 124105 RVA: 0x009107F8 File Offset: 0x0090E9F8
		// (set) Token: 0x0601E4CA RID: 124106 RVA: 0x0091080C File Offset: 0x0090EA0C
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0601E4CB RID: 124107 RVA: 0x00910821 File Offset: 0x0090EA21
		// (set) Token: 0x0601E4CC RID: 124108 RVA: 0x00910831 File Offset: 0x0090EA31
		public unsafe float AtackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_AtackTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_AtackTime) = value;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0601E4CD RID: 124109 RVA: 0x00910842 File Offset: 0x0090EA42
		// (set) Token: 0x0601E4CE RID: 124110 RVA: 0x00910852 File Offset: 0x0090EA52
		public unsafe float In_Delta_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_In_Delta_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_In_Delta_Time) = value;
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0601E4CF RID: 124111 RVA: 0x00910863 File Offset: 0x0090EA63
		// (set) Token: 0x0601E4D0 RID: 124112 RVA: 0x00910877 File Offset: 0x0090EA77
		public unsafe FVector OriginPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_OriginPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_OriginPosition) = value;
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0601E4D1 RID: 124113 RVA: 0x0091088C File Offset: 0x0090EA8C
		// (set) Token: 0x0601E4D2 RID: 124114 RVA: 0x0091089C File Offset: 0x0090EA9C
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Start) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Start) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0601E4D3 RID: 124115 RVA: 0x009108AD File Offset: 0x0090EAAD
		// (set) Token: 0x0601E4D4 RID: 124116 RVA: 0x009108BD File Offset: 0x0090EABD
		public unsafe float NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_NewVar_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_NewVar_0) = value;
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0601E4D5 RID: 124117 RVA: 0x009108CE File Offset: 0x0090EACE
		// (set) Token: 0x0601E4D6 RID: 124118 RVA: 0x009108DE File Offset: 0x0090EADE
		public unsafe int Frame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Frame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Frame) = value;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0601E4D7 RID: 124119 RVA: 0x009108EF File Offset: 0x0090EAEF
		// (set) Token: 0x0601E4D8 RID: 124120 RVA: 0x00910903 File Offset: 0x0090EB03
		public unsafe FVector LastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_LastPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_LastPosition) = value;
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0601E4D9 RID: 124121 RVA: 0x00910918 File Offset: 0x0090EB18
		// (set) Token: 0x0601E4DA RID: 124122 RVA: 0x00910928 File Offset: 0x0090EB28
		public unsafe bool Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Tick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Tick) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0601E4DB RID: 124123 RVA: 0x00910939 File Offset: 0x0090EB39
		// (set) Token: 0x0601E4DC RID: 124124 RVA: 0x00910949 File Offset: 0x0090EB49
		public unsafe bool Runtime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Runtime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Runtime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0601E4DD RID: 124125 RVA: 0x0091095A File Offset: 0x0090EB5A
		// (set) Token: 0x0601E4DE RID: 124126 RVA: 0x0091096A File Offset: 0x0090EB6A
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Delay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Delay) = value;
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0601E4DF RID: 124127 RVA: 0x0091097B File Offset: 0x0090EB7B
		// (set) Token: 0x0601E4E0 RID: 124128 RVA: 0x0091098B File Offset: 0x0090EB8B
		public unsafe float MaxDistanceLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_MaxDistanceLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_MaxDistanceLimit) = value;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0601E4E1 RID: 124129 RVA: 0x0091099C File Offset: 0x0090EB9C
		// (set) Token: 0x0601E4E2 RID: 124130 RVA: 0x009109AC File Offset: 0x0090EBAC
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0601E4E3 RID: 124131 RVA: 0x009109C0 File Offset: 0x0090EBC0
		// (set) Token: 0x0601E4E4 RID: 124132 RVA: 0x009109F9 File Offset: 0x0090EBF9
		public TMap<int, FVector2D> AttackPosition
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FVector2D> result;
				if ((result = this._AttackPosition) == null)
				{
					result = (this._AttackPosition = new TMap<int, FVector2D>(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_AttackPosition, this));
				}
				return result;
			}
			set
			{
				this.AttackPosition.CopyAssign(value);
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0601E4E5 RID: 124133 RVA: 0x00910A07 File Offset: 0x0090EC07
		// (set) Token: 0x0601E4E6 RID: 124134 RVA: 0x00910A17 File Offset: 0x0090EC17
		public unsafe float FinishTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishTime) = value;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0601E4E7 RID: 124135 RVA: 0x00910A28 File Offset: 0x0090EC28
		// (set) Token: 0x0601E4E8 RID: 124136 RVA: 0x00910A3C File Offset: 0x0090EC3C
		public unsafe string 普通子弹
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_普通子弹)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_普通子弹)), value);
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0601E4E9 RID: 124137 RVA: 0x00910A51 File Offset: 0x0090EC51
		// (set) Token: 0x0601E4EA RID: 124138 RVA: 0x00910A61 File Offset: 0x0090EC61
		public unsafe float 冲击波速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_冲击波速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_冲击波速度) = value;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0601E4EB RID: 124139 RVA: 0x00910A72 File Offset: 0x0090EC72
		// (set) Token: 0x0601E4EC RID: 124140 RVA: 0x00910A86 File Offset: 0x0090EC86
		public unsafe string 终结子弹
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结子弹)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结子弹)), value);
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0601E4ED RID: 124141 RVA: 0x00910A9B File Offset: 0x0090EC9B
		// (set) Token: 0x0601E4EE RID: 124142 RVA: 0x00910AAB File Offset: 0x0090ECAB
		public unsafe float 终结效果速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结效果速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结效果速度) = value;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0601E4EF RID: 124143 RVA: 0x00910ABC File Offset: 0x0090ECBC
		// (set) Token: 0x0601E4F0 RID: 124144 RVA: 0x00910ACC File Offset: 0x0090ECCC
		public unsafe float 终结技延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结技延迟);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结技延迟) = value;
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0601E4F1 RID: 124145 RVA: 0x00910ADD File Offset: 0x0090ECDD
		// (set) Token: 0x0601E4F2 RID: 124146 RVA: 0x00910AED File Offset: 0x0090ECED
		public unsafe float ShockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_ShockTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_ShockTime) = value;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0601E4F3 RID: 124147 RVA: 0x00910AFE File Offset: 0x0090ECFE
		// (set) Token: 0x0601E4F4 RID: 124148 RVA: 0x00910B12 File Offset: 0x0090ED12
		public unsafe string 冲击波子弹
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_冲击波子弹)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_冲击波子弹)), value);
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0601E4F5 RID: 124149 RVA: 0x00910B27 File Offset: 0x0090ED27
		// (set) Token: 0x0601E4F6 RID: 124150 RVA: 0x00910B37 File Offset: 0x0090ED37
		public unsafe float FinishDitherTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishDitherTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishDitherTime) = value;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0601E4F7 RID: 124151 RVA: 0x00910B48 File Offset: 0x0090ED48
		// (set) Token: 0x0601E4F8 RID: 124152 RVA: 0x00910B5C File Offset: 0x0090ED5C
		public unsafe string DebugString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_DebugString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_DebugString)), value);
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0601E4F9 RID: 124153 RVA: 0x00910B74 File Offset: 0x0090ED74
		// (set) Token: 0x0601E4FA RID: 124154 RVA: 0x00910BAD File Offset: 0x0090EDAD
		public FKuroCurveFloat FinishTimeCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FinishTimeCurve) == null)
				{
					result = (this._FinishTimeCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishTimeCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishTimeCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0601E4FB RID: 124155 RVA: 0x00910BCE File Offset: 0x0090EDCE
		// (set) Token: 0x0601E4FC RID: 124156 RVA: 0x00910BDE File Offset: 0x0090EDDE
		public unsafe float 终结效果消散速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结效果消散速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结效果消散速度) = value;
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0601E4FD RID: 124157 RVA: 0x00910BEF File Offset: 0x0090EDEF
		// (set) Token: 0x0601E4FE RID: 124158 RVA: 0x00910BFF File Offset: 0x0090EDFF
		public unsafe float 终结消散延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结消散延迟);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_终结消散延迟) = value;
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0601E4FF RID: 124159 RVA: 0x00910C10 File Offset: 0x0090EE10
		// (set) Token: 0x0601E500 RID: 124160 RVA: 0x00910C49 File Offset: 0x0090EE49
		public FKuroCurveFloat FinishDissiveCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FinishDissiveCurve) == null)
				{
					result = (this._FinishDissiveCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishDissiveCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_FinishDissiveCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0601E501 RID: 124161 RVA: 0x00910C6A File Offset: 0x0090EE6A
		// (set) Token: 0x0601E502 RID: 124162 RVA: 0x00910C7A File Offset: 0x0090EE7A
		public unsafe float test
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_test);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_test) = value;
			}
		}

		// Token: 0x0601E503 RID: 124163 RVA: 0x00910C8B File Offset: 0x0090EE8B
		[SkipLocalsInit]
		public virtual void Shock()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Shock_NativeFunctionPtr, null);
		}

		// Token: 0x0601E504 RID: 124164 RVA: 0x00910C9F File Offset: 0x0090EE9F
		[SkipLocalsInit]
		public virtual void Finish()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Finish_NativeFunctionPtr, null);
		}

		// Token: 0x0601E505 RID: 124165 RVA: 0x00910CB3 File Offset: 0x0090EEB3
		[SkipLocalsInit]
		public virtual void Pound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Pound_NativeFunctionPtr, null);
		}

		// Token: 0x0601E506 RID: 124166 RVA: 0x00910CC7 File Offset: 0x0090EEC7
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E507 RID: 124167 RVA: 0x00910CDB File Offset: 0x0090EEDB
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E508 RID: 124168 RVA: 0x00910CF0 File Offset: 0x0090EEF0
		[SkipLocalsInit]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E509 RID: 124169 RVA: 0x00910D44 File Offset: 0x0090EF44
		[SkipLocalsInit]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E50A RID: 124170 RVA: 0x00910D98 File Offset: 0x0090EF98
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E50B RID: 124171 RVA: 0x00910DE0 File Offset: 0x0090EFE0
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E50C RID: 124172 RVA: 0x00910E26 File Offset: 0x0090F026
		[SkipLocalsInit]
		public virtual void Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Debug_NativeFunctionPtr, null);
		}

		// Token: 0x0601E50D RID: 124173 RVA: 0x00910E3C File Offset: 0x0090F03C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E50E RID: 124174 RVA: 0x00910E84 File Offset: 0x0090F084
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E50F RID: 124175 RVA: 0x00910ECA File Offset: 0x0090F0CA
		protected BP_CubeFloorInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010099 RID: 65689
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x0401009A RID: 65690
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_CubeFloorInteraction.BP_CubeFloorInteraction_C";

		// Token: 0x0401009B RID: 65691
		private static IntPtr _ClassPtr;

		// Token: 0x0401009C RID: 65692
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401009D RID: 65693
		internal static int __PropertyOffset_SM_Hub_Pro_101AL_FX;

		// Token: 0x0401009E RID: 65694
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401009F RID: 65695
		internal static int __PropertyOffset_AtackTime;

		// Token: 0x040100A0 RID: 65696
		internal static int __PropertyOffset_In_Delta_Time;

		// Token: 0x040100A1 RID: 65697
		internal static int __PropertyOffset_OriginPosition;

		// Token: 0x040100A2 RID: 65698
		internal static int __PropertyOffset_Start;

		// Token: 0x040100A3 RID: 65699
		internal static int __PropertyOffset_NewVar_0;

		// Token: 0x040100A4 RID: 65700
		internal static int __PropertyOffset_Frame;

		// Token: 0x040100A5 RID: 65701
		internal static int __PropertyOffset_LastPosition;

		// Token: 0x040100A6 RID: 65702
		internal static int __PropertyOffset_Tick;

		// Token: 0x040100A7 RID: 65703
		internal static int __PropertyOffset_Runtime;

		// Token: 0x040100A8 RID: 65704
		internal static int __PropertyOffset_Delay;

		// Token: 0x040100A9 RID: 65705
		internal static int __PropertyOffset_MaxDistanceLimit;

		// Token: 0x040100AA RID: 65706
		internal static int __PropertyOffset_Count;

		// Token: 0x040100AB RID: 65707
		internal static int __PropertyOffset_AttackPosition;

		// Token: 0x040100AC RID: 65708
		[Nullable(2)]
		private TMap<int, FVector2D> _AttackPosition;

		// Token: 0x040100AD RID: 65709
		internal static int __PropertyOffset_FinishTime;

		// Token: 0x040100AE RID: 65710
		internal static int __PropertyOffset_普通子弹;

		// Token: 0x040100AF RID: 65711
		internal static int __PropertyOffset_冲击波速度;

		// Token: 0x040100B0 RID: 65712
		internal static int __PropertyOffset_终结子弹;

		// Token: 0x040100B1 RID: 65713
		internal static int __PropertyOffset_终结效果速度;

		// Token: 0x040100B2 RID: 65714
		internal static int __PropertyOffset_终结技延迟;

		// Token: 0x040100B3 RID: 65715
		internal static int __PropertyOffset_ShockTime;

		// Token: 0x040100B4 RID: 65716
		internal static int __PropertyOffset_冲击波子弹;

		// Token: 0x040100B5 RID: 65717
		internal static int __PropertyOffset_FinishDitherTime;

		// Token: 0x040100B6 RID: 65718
		internal static int __PropertyOffset_DebugString;

		// Token: 0x040100B7 RID: 65719
		internal static int __PropertyOffset_FinishTimeCurve;

		// Token: 0x040100B8 RID: 65720
		[Nullable(2)]
		private FKuroCurveFloat _FinishTimeCurve;

		// Token: 0x040100B9 RID: 65721
		internal static int __PropertyOffset_终结效果消散速度;

		// Token: 0x040100BA RID: 65722
		internal static int __PropertyOffset_终结消散延迟;

		// Token: 0x040100BB RID: 65723
		internal static int __PropertyOffset_FinishDissiveCurve;

		// Token: 0x040100BC RID: 65724
		[Nullable(2)]
		private FKuroCurveFloat _FinishDissiveCurve;

		// Token: 0x040100BD RID: 65725
		internal static int __PropertyOffset_test;

		// Token: 0x040100BE RID: 65726
		private static IntPtr __Shock_NativeFunctionPtr;

		// Token: 0x040100BF RID: 65727
		private static IntPtr __Finish_NativeFunctionPtr;

		// Token: 0x040100C0 RID: 65728
		private static IntPtr __Pound_NativeFunctionPtr;

		// Token: 0x040100C1 RID: 65729
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040100C2 RID: 65730
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x040100C3 RID: 65731
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040100C4 RID: 65732
		private static IntPtr __Debug_NativeFunctionPtr;

		// Token: 0x040100C5 RID: 65733
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008E5E RID: 36446
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x0402CAA9 RID: 182953
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x0402CAAA RID: 182954
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}

		// Token: 0x02008E5F RID: 36447
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CAAB RID: 182955
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E60 RID: 36448
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAAC RID: 182956
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
