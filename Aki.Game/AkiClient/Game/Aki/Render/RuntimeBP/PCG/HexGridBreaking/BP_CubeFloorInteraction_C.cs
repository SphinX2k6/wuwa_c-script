using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Monster.Boss.MB1TianyanhuanxinMd00311;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.HexGridBreaking
{
	// Token: 0x02003C9F RID: 15519
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_CubeFloorInteraction.BP_CubeFloorInteraction_C")]
	[UnrealStructLayout(2040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2036)]
	public class BP_CubeFloorInteraction_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06024656 RID: 149078 RVA: 0x0093D658 File Offset: 0x0093B858
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CubeFloorInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_CubeFloorInteraction.BP_CubeFloorInteraction_C");
			}
			return BP_CubeFloorInteraction_C._ClassPtr;
		}

		// Token: 0x06024657 RID: 149079 RVA: 0x0093D67C File Offset: 0x0093B87C
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_CubeFloorInteraction_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x06024658 RID: 149080 RVA: 0x0093D684 File Offset: 0x0093B884
		public BP_CubeFloorInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_CubeFloorInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024659 RID: 149081 RVA: 0x0093D6AC File Offset: 0x0093B8AC
		public BP_CubeFloorInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CubeFloorInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046D1 RID: 18129
		// (get) Token: 0x0602465A RID: 149082 RVA: 0x0093D6DF File Offset: 0x0093B8DF
		// (set) Token: 0x0602465B RID: 149083 RVA: 0x0093D6F3 File Offset: 0x0093B8F3
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_Hub_Pro_101AL_FX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170046D2 RID: 18130
		// (get) Token: 0x0602465C RID: 149084 RVA: 0x0093D708 File Offset: 0x0093B908
		// (set) Token: 0x0602465D RID: 149085 RVA: 0x0093D71C File Offset: 0x0093B91C
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170046D3 RID: 18131
		// (get) Token: 0x0602465E RID: 149086 RVA: 0x0093D731 File Offset: 0x0093B931
		// (set) Token: 0x0602465F RID: 149087 RVA: 0x0093D741 File Offset: 0x0093B941
		public unsafe float AtackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170046D4 RID: 18132
		// (get) Token: 0x06024660 RID: 149088 RVA: 0x0093D752 File Offset: 0x0093B952
		// (set) Token: 0x06024661 RID: 149089 RVA: 0x0093D762 File Offset: 0x0093B962
		public unsafe float In_Delta_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170046D5 RID: 18133
		// (get) Token: 0x06024662 RID: 149090 RVA: 0x0093D773 File Offset: 0x0093B973
		// (set) Token: 0x06024663 RID: 149091 RVA: 0x0093D787 File Offset: 0x0093B987
		public unsafe FVector OriginPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170046D6 RID: 18134
		// (get) Token: 0x06024664 RID: 149092 RVA: 0x0093D79C File Offset: 0x0093B99C
		// (set) Token: 0x06024665 RID: 149093 RVA: 0x0093D7AC File Offset: 0x0093B9AC
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046D7 RID: 18135
		// (get) Token: 0x06024666 RID: 149094 RVA: 0x0093D7BD File Offset: 0x0093B9BD
		// (set) Token: 0x06024667 RID: 149095 RVA: 0x0093D7CD File Offset: 0x0093B9CD
		public unsafe float NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170046D8 RID: 18136
		// (get) Token: 0x06024668 RID: 149096 RVA: 0x0093D7DE File Offset: 0x0093B9DE
		// (set) Token: 0x06024669 RID: 149097 RVA: 0x0093D7EE File Offset: 0x0093B9EE
		public unsafe int Frame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170046D9 RID: 18137
		// (get) Token: 0x0602466A RID: 149098 RVA: 0x0093D7FF File Offset: 0x0093B9FF
		// (set) Token: 0x0602466B RID: 149099 RVA: 0x0093D813 File Offset: 0x0093BA13
		[Nullable(2)]
		public unsafe BP_MB1TianyanhuanxinMd00311_C BossObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_MB1TianyanhuanxinMd00311_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_9);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CubeFloorInteraction_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170046DA RID: 18138
		// (get) Token: 0x0602466C RID: 149100 RVA: 0x0093D828 File Offset: 0x0093BA28
		// (set) Token: 0x0602466D RID: 149101 RVA: 0x0093D83C File Offset: 0x0093BA3C
		public unsafe FVector LastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170046DB RID: 18139
		// (get) Token: 0x0602466E RID: 149102 RVA: 0x0093D851 File Offset: 0x0093BA51
		// (set) Token: 0x0602466F RID: 149103 RVA: 0x0093D861 File Offset: 0x0093BA61
		public unsafe bool Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046DC RID: 18140
		// (get) Token: 0x06024670 RID: 149104 RVA: 0x0093D872 File Offset: 0x0093BA72
		// (set) Token: 0x06024671 RID: 149105 RVA: 0x0093D882 File Offset: 0x0093BA82
		public unsafe bool Runtime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046DD RID: 18141
		// (get) Token: 0x06024672 RID: 149106 RVA: 0x0093D893 File Offset: 0x0093BA93
		// (set) Token: 0x06024673 RID: 149107 RVA: 0x0093D8A3 File Offset: 0x0093BAA3
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170046DE RID: 18142
		// (get) Token: 0x06024674 RID: 149108 RVA: 0x0093D8B4 File Offset: 0x0093BAB4
		// (set) Token: 0x06024675 RID: 149109 RVA: 0x0093D8C4 File Offset: 0x0093BAC4
		public unsafe float MaxDistanceLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170046DF RID: 18143
		// (get) Token: 0x06024676 RID: 149110 RVA: 0x0093D8D5 File Offset: 0x0093BAD5
		// (set) Token: 0x06024677 RID: 149111 RVA: 0x0093D8E5 File Offset: 0x0093BAE5
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170046E0 RID: 18144
		// (get) Token: 0x06024678 RID: 149112 RVA: 0x0093D8F8 File Offset: 0x0093BAF8
		// (set) Token: 0x06024679 RID: 149113 RVA: 0x0093D931 File Offset: 0x0093BB31
		public TMap<int, FVector2D> AttackPosition
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FVector2D> result;
				if ((result = this._AttackPosition) == null)
				{
					result = (this._AttackPosition = new TMap<int, FVector2D>(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.AttackPosition.CopyAssign(value);
			}
		}

		// Token: 0x170046E1 RID: 18145
		// (get) Token: 0x0602467A RID: 149114 RVA: 0x0093D93F File Offset: 0x0093BB3F
		// (set) Token: 0x0602467B RID: 149115 RVA: 0x0093D94F File Offset: 0x0093BB4F
		public unsafe float FinishTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170046E2 RID: 18146
		// (get) Token: 0x0602467C RID: 149116 RVA: 0x0093D960 File Offset: 0x0093BB60
		// (set) Token: 0x0602467D RID: 149117 RVA: 0x0093D974 File Offset: 0x0093BB74
		public unsafe string 普通子弹
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_18)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_18)), value);
			}
		}

		// Token: 0x170046E3 RID: 18147
		// (get) Token: 0x0602467E RID: 149118 RVA: 0x0093D989 File Offset: 0x0093BB89
		// (set) Token: 0x0602467F RID: 149119 RVA: 0x0093D999 File Offset: 0x0093BB99
		public unsafe float 冲击波速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170046E4 RID: 18148
		// (get) Token: 0x06024680 RID: 149120 RVA: 0x0093D9AA File Offset: 0x0093BBAA
		// (set) Token: 0x06024681 RID: 149121 RVA: 0x0093D9BE File Offset: 0x0093BBBE
		public unsafe string 终结子弹
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_20)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_20)), value);
			}
		}

		// Token: 0x170046E5 RID: 18149
		// (get) Token: 0x06024682 RID: 149122 RVA: 0x0093D9D3 File Offset: 0x0093BBD3
		// (set) Token: 0x06024683 RID: 149123 RVA: 0x0093D9E3 File Offset: 0x0093BBE3
		public unsafe float 终结效果速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170046E6 RID: 18150
		// (get) Token: 0x06024684 RID: 149124 RVA: 0x0093D9F4 File Offset: 0x0093BBF4
		// (set) Token: 0x06024685 RID: 149125 RVA: 0x0093DA04 File Offset: 0x0093BC04
		public unsafe float 终结技延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170046E7 RID: 18151
		// (get) Token: 0x06024686 RID: 149126 RVA: 0x0093DA15 File Offset: 0x0093BC15
		// (set) Token: 0x06024687 RID: 149127 RVA: 0x0093DA25 File Offset: 0x0093BC25
		public unsafe float ShockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170046E8 RID: 18152
		// (get) Token: 0x06024688 RID: 149128 RVA: 0x0093DA36 File Offset: 0x0093BC36
		// (set) Token: 0x06024689 RID: 149129 RVA: 0x0093DA4A File Offset: 0x0093BC4A
		public unsafe string 冲击波子弹
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_24)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_24)), value);
			}
		}

		// Token: 0x170046E9 RID: 18153
		// (get) Token: 0x0602468A RID: 149130 RVA: 0x0093DA5F File Offset: 0x0093BC5F
		// (set) Token: 0x0602468B RID: 149131 RVA: 0x0093DA6F File Offset: 0x0093BC6F
		public unsafe float FinishDitherTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170046EA RID: 18154
		// (get) Token: 0x0602468C RID: 149132 RVA: 0x0093DA80 File Offset: 0x0093BC80
		// (set) Token: 0x0602468D RID: 149133 RVA: 0x0093DA94 File Offset: 0x0093BC94
		public unsafe string DebugString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_26)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_26)), value);
			}
		}

		// Token: 0x170046EB RID: 18155
		// (get) Token: 0x0602468E RID: 149134 RVA: 0x0093DAAC File Offset: 0x0093BCAC
		// (set) Token: 0x0602468F RID: 149135 RVA: 0x0093DAE5 File Offset: 0x0093BCE5
		public FKuroCurveFloat FinishTimeCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FinishTimeCurve) == null)
				{
					result = (this._FinishTimeCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_27, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_27, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046EC RID: 18156
		// (get) Token: 0x06024690 RID: 149136 RVA: 0x0093DB06 File Offset: 0x0093BD06
		// (set) Token: 0x06024691 RID: 149137 RVA: 0x0093DB16 File Offset: 0x0093BD16
		public unsafe float 终结效果消散速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170046ED RID: 18157
		// (get) Token: 0x06024692 RID: 149138 RVA: 0x0093DB27 File Offset: 0x0093BD27
		// (set) Token: 0x06024693 RID: 149139 RVA: 0x0093DB37 File Offset: 0x0093BD37
		public unsafe float 终结消散延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x06024694 RID: 149140 RVA: 0x0093DB48 File Offset: 0x0093BD48
		// (set) Token: 0x06024695 RID: 149141 RVA: 0x0093DB81 File Offset: 0x0093BD81
		public FKuroCurveFloat FinishDissiveCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FinishDissiveCurve) == null)
				{
					result = (this._FinishDissiveCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_30, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x06024696 RID: 149142 RVA: 0x0093DBA2 File Offset: 0x0093BDA2
		// (set) Token: 0x06024697 RID: 149143 RVA: 0x0093DBB2 File Offset: 0x0093BDB2
		public unsafe float test
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CubeFloorInteraction_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x06024698 RID: 149144 RVA: 0x0093DBC3 File Offset: 0x0093BDC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Shock()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Shock_NativeFunctionPtr, null);
		}

		// Token: 0x06024699 RID: 149145 RVA: 0x0093DBD7 File Offset: 0x0093BDD7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Finish()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Finish_NativeFunctionPtr, null);
		}

		// Token: 0x0602469A RID: 149146 RVA: 0x0093DBEB File Offset: 0x0093BDEB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Pound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Pound_NativeFunctionPtr, null);
		}

		// Token: 0x0602469B RID: 149147 RVA: 0x0093DBFF File Offset: 0x0093BDFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602469C RID: 149148 RVA: 0x0093DC13 File Offset: 0x0093BE13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602469D RID: 149149 RVA: 0x0093DC28 File Offset: 0x0093BE28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602469E RID: 149150 RVA: 0x0093DC7C File Offset: 0x0093BE7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602469F RID: 149151 RVA: 0x0093DCD0 File Offset: 0x0093BED0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060246A0 RID: 149152 RVA: 0x0093DD18 File Offset: 0x0093BF18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060246A1 RID: 149153 RVA: 0x0093DD5F File Offset: 0x0093BF5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__Debug_NativeFunctionPtr, null);
		}

		// Token: 0x060246A2 RID: 149154 RVA: 0x0093DD74 File Offset: 0x0093BF74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060246A3 RID: 149155 RVA: 0x0093DDBC File Offset: 0x0093BFBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CubeFloorInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CubeFloorInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060246A4 RID: 149156 RVA: 0x0093DE03 File Offset: 0x0093C003
		protected BP_CubeFloorInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040120E6 RID: 73958
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x040120E7 RID: 73959
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_CubeFloorInteraction.BP_CubeFloorInteraction_C";

		// Token: 0x040120E8 RID: 73960
		private static IntPtr _ClassPtr;

		// Token: 0x040120E9 RID: 73961
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040120EA RID: 73962
		internal static int __PropertyOffset_1;

		// Token: 0x040120EB RID: 73963
		internal static int __PropertyOffset_2;

		// Token: 0x040120EC RID: 73964
		internal static int __PropertyOffset_3;

		// Token: 0x040120ED RID: 73965
		internal static int __PropertyOffset_4;

		// Token: 0x040120EE RID: 73966
		internal static int __PropertyOffset_5;

		// Token: 0x040120EF RID: 73967
		internal static int __PropertyOffset_6;

		// Token: 0x040120F0 RID: 73968
		internal static int __PropertyOffset_7;

		// Token: 0x040120F1 RID: 73969
		internal static int __PropertyOffset_8;

		// Token: 0x040120F2 RID: 73970
		internal static int __PropertyOffset_9;

		// Token: 0x040120F3 RID: 73971
		internal static int __PropertyOffset_10;

		// Token: 0x040120F4 RID: 73972
		internal static int __PropertyOffset_11;

		// Token: 0x040120F5 RID: 73973
		internal static int __PropertyOffset_12;

		// Token: 0x040120F6 RID: 73974
		internal static int __PropertyOffset_13;

		// Token: 0x040120F7 RID: 73975
		internal static int __PropertyOffset_14;

		// Token: 0x040120F8 RID: 73976
		internal static int __PropertyOffset_15;

		// Token: 0x040120F9 RID: 73977
		internal static int __PropertyOffset_16;

		// Token: 0x040120FA RID: 73978
		[Nullable(2)]
		private TMap<int, FVector2D> _AttackPosition;

		// Token: 0x040120FB RID: 73979
		internal static int __PropertyOffset_17;

		// Token: 0x040120FC RID: 73980
		internal static int __PropertyOffset_18;

		// Token: 0x040120FD RID: 73981
		internal static int __PropertyOffset_19;

		// Token: 0x040120FE RID: 73982
		internal static int __PropertyOffset_20;

		// Token: 0x040120FF RID: 73983
		internal static int __PropertyOffset_21;

		// Token: 0x04012100 RID: 73984
		internal static int __PropertyOffset_22;

		// Token: 0x04012101 RID: 73985
		internal static int __PropertyOffset_23;

		// Token: 0x04012102 RID: 73986
		internal static int __PropertyOffset_24;

		// Token: 0x04012103 RID: 73987
		internal static int __PropertyOffset_25;

		// Token: 0x04012104 RID: 73988
		internal static int __PropertyOffset_26;

		// Token: 0x04012105 RID: 73989
		internal static int __PropertyOffset_27;

		// Token: 0x04012106 RID: 73990
		[Nullable(2)]
		private FKuroCurveFloat _FinishTimeCurve;

		// Token: 0x04012107 RID: 73991
		internal static int __PropertyOffset_28;

		// Token: 0x04012108 RID: 73992
		internal static int __PropertyOffset_29;

		// Token: 0x04012109 RID: 73993
		internal static int __PropertyOffset_30;

		// Token: 0x0401210A RID: 73994
		[Nullable(2)]
		private FKuroCurveFloat _FinishDissiveCurve;

		// Token: 0x0401210B RID: 73995
		internal static int __PropertyOffset_31;

		// Token: 0x0401210C RID: 73996
		private static IntPtr __Shock_NativeFunctionPtr;

		// Token: 0x0401210D RID: 73997
		private static IntPtr __Finish_NativeFunctionPtr;

		// Token: 0x0401210E RID: 73998
		private static IntPtr __Pound_NativeFunctionPtr;

		// Token: 0x0401210F RID: 73999
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012110 RID: 74000
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x04012111 RID: 74001
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012112 RID: 74002
		private static IntPtr __Debug_NativeFunctionPtr;

		// Token: 0x04012113 RID: 74003
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009F12 RID: 40722
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x04031866 RID: 202854
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x04031867 RID: 202855
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}

		// Token: 0x02009F13 RID: 40723
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031868 RID: 202856
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F14 RID: 40724
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031869 RID: 202857
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
