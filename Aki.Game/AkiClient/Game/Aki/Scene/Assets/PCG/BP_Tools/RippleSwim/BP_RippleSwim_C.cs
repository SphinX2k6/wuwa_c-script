using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools.RippleSwim
{
	// Token: 0x020030A6 RID: 12454
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/BP_Tools/RippleSwim/BP_RippleSwim.BP_RippleSwim_C")]
	[UnrealStructLayout(2152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2145)]
	public class BP_RippleSwim_C : AKuroBPCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DC73 RID: 121971 RVA: 0x00901883 File Offset: 0x008FFA83
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RippleSwim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/Assets/PCG/BP_Tools/RippleSwim/BP_RippleSwim.BP_RippleSwim_C");
			}
			return BP_RippleSwim_C._ClassPtr;
		}

		// Token: 0x0601DC74 RID: 121972 RVA: 0x009018A8 File Offset: 0x008FFAA8
		public BP_RippleSwim_C() : this(BuiltinUtils.AllocNativeUObject(BP_RippleSwim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DC75 RID: 121973 RVA: 0x009018D0 File Offset: 0x008FFAD0
		[NullableContext(1)]
		public BP_RippleSwim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RippleSwim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x0601DC76 RID: 121974 RVA: 0x00901903 File Offset: 0x008FFB03
		// (set) Token: 0x0601DC77 RID: 121975 RVA: 0x00901917 File Offset: 0x008FFB17
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0601DC78 RID: 121976 RVA: 0x0090192C File Offset: 0x008FFB2C
		// (set) Token: 0x0601DC79 RID: 121977 RVA: 0x00901940 File Offset: 0x008FFB40
		public unsafe UMaterialInstanceDynamic AddNewMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_AddNewMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_AddNewMaterial, value);
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0601DC7A RID: 121978 RVA: 0x00901955 File Offset: 0x008FFB55
		// (set) Token: 0x0601DC7B RID: 121979 RVA: 0x00901969 File Offset: 0x008FFB69
		public unsafe UMaterialInstanceDynamic tempToPrevMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_tempToPrevMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_tempToPrevMaterial, value);
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x0601DC7C RID: 121980 RVA: 0x0090197E File Offset: 0x008FFB7E
		// (set) Token: 0x0601DC7D RID: 121981 RVA: 0x00901992 File Offset: 0x008FFB92
		public unsafe UMaterialInstanceDynamic DrawMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_DrawMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_DrawMaterial, value);
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x0601DC7E RID: 121982 RVA: 0x009019A7 File Offset: 0x008FFBA7
		// (set) Token: 0x0601DC7F RID: 121983 RVA: 0x009019B7 File Offset: 0x008FFBB7
		public unsafe bool bSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bSim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bSim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x0601DC80 RID: 121984 RVA: 0x009019C8 File Offset: 0x008FFBC8
		// (set) Token: 0x0601DC81 RID: 121985 RVA: 0x009019DC File Offset: 0x008FFBDC
		public unsafe AActor Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_Plane);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_Plane, value);
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x0601DC82 RID: 121986 RVA: 0x009019F1 File Offset: 0x008FFBF1
		// (set) Token: 0x0601DC83 RID: 121987 RVA: 0x00901A01 File Offset: 0x008FFC01
		public unsafe int PrevState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PrevState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PrevState) = value;
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0601DC84 RID: 121988 RVA: 0x00901A12 File Offset: 0x008FFC12
		// (set) Token: 0x0601DC85 RID: 121989 RVA: 0x00901A22 File Offset: 0x008FFC22
		public unsafe int State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_State);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_State) = value;
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0601DC86 RID: 121990 RVA: 0x00901A34 File Offset: 0x008FFC34
		// (set) Token: 0x0601DC87 RID: 121991 RVA: 0x00901A6D File Offset: 0x008FFC6D
		[Nullable(1)]
		public FGameplayTagContainer Tag_Container
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tag_Container) == null)
				{
					result = (this._Tag_Container = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Tag_Container, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Tag_Container, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0601DC88 RID: 121992 RVA: 0x00901A8E File Offset: 0x008FFC8E
		// (set) Token: 0x0601DC89 RID: 121993 RVA: 0x00901A9E File Offset: 0x008FFC9E
		public unsafe float Step
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Step);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Step) = value;
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0601DC8A RID: 121994 RVA: 0x00901AAF File Offset: 0x008FFCAF
		// (set) Token: 0x0601DC8B RID: 121995 RVA: 0x00901ABF File Offset: 0x008FFCBF
		public unsafe float captureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_captureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_captureSize) = value;
			}
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0601DC8C RID: 121996 RVA: 0x00901AD0 File Offset: 0x008FFCD0
		// (set) Token: 0x0601DC8D RID: 121997 RVA: 0x00901AE4 File Offset: 0x008FFCE4
		public unsafe UMaterialInstanceDynamic rippleMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_rippleMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_rippleMaterial, value);
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0601DC8E RID: 121998 RVA: 0x00901AF9 File Offset: 0x008FFCF9
		// (set) Token: 0x0601DC8F RID: 121999 RVA: 0x00901B0D File Offset: 0x008FFD0D
		public unsafe UTextureRenderTarget2D prevRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_prevRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_prevRT, value);
			}
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0601DC90 RID: 122000 RVA: 0x00901B22 File Offset: 0x008FFD22
		// (set) Token: 0x0601DC91 RID: 122001 RVA: 0x00901B36 File Offset: 0x008FFD36
		public unsafe UTextureRenderTarget2D currentRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_currentRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_currentRT, value);
			}
		}

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0601DC92 RID: 122002 RVA: 0x00901B4B File Offset: 0x008FFD4B
		// (set) Token: 0x0601DC93 RID: 122003 RVA: 0x00901B5F File Offset: 0x008FFD5F
		public unsafe UTextureRenderTarget2D tempRTRef
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_tempRTRef);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_tempRTRef, value);
			}
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0601DC94 RID: 122004 RVA: 0x00901B74 File Offset: 0x008FFD74
		// (set) Token: 0x0601DC95 RID: 122005 RVA: 0x00901B88 File Offset: 0x008FFD88
		public unsafe FVector PlayerLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerLocation) = value;
			}
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0601DC96 RID: 122006 RVA: 0x00901B9D File Offset: 0x008FFD9D
		// (set) Token: 0x0601DC97 RID: 122007 RVA: 0x00901BB1 File Offset: 0x008FFDB1
		public unsafe FVector2D Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0601DC98 RID: 122008 RVA: 0x00901BC6 File Offset: 0x008FFDC6
		// (set) Token: 0x0601DC99 RID: 122009 RVA: 0x00901BDA File Offset: 0x008FFDDA
		public unsafe AActor TestActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_TestActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_TestActor, value);
			}
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0601DC9A RID: 122010 RVA: 0x00901BEF File Offset: 0x008FFDEF
		// (set) Token: 0x0601DC9B RID: 122011 RVA: 0x00901BFF File Offset: 0x008FFDFF
		public unsafe float PlayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerSize) = value;
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0601DC9C RID: 122012 RVA: 0x00901C10 File Offset: 0x008FFE10
		// (set) Token: 0x0601DC9D RID: 122013 RVA: 0x00901C24 File Offset: 0x008FFE24
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_Global_MPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_Global_MPC, value);
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0601DC9E RID: 122014 RVA: 0x00901C39 File Offset: 0x008FFE39
		// (set) Token: 0x0601DC9F RID: 122015 RVA: 0x00901C49 File Offset: 0x008FFE49
		public unsafe bool bPlayerInWaterLast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bPlayerInWaterLast) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bPlayerInWaterLast) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0601DCA0 RID: 122016 RVA: 0x00901C5A File Offset: 0x008FFE5A
		// (set) Token: 0x0601DCA1 RID: 122017 RVA: 0x00901C6A File Offset: 0x008FFE6A
		public unsafe float RippleDistanceNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleDistanceNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleDistanceNormal) = value;
			}
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0601DCA2 RID: 122018 RVA: 0x00901C7B File Offset: 0x008FFE7B
		// (set) Token: 0x0601DCA3 RID: 122019 RVA: 0x00901C8B File Offset: 0x008FFE8B
		public unsafe float RippleDistanceFluo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleDistanceFluo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleDistanceFluo) = value;
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0601DCA4 RID: 122020 RVA: 0x00901C9C File Offset: 0x008FFE9C
		// (set) Token: 0x0601DCA5 RID: 122021 RVA: 0x00901CB0 File Offset: 0x008FFEB0
		public unsafe FVector2D PositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PositionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PositionOffset) = value;
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0601DCA6 RID: 122022 RVA: 0x00901CC5 File Offset: 0x008FFEC5
		// (set) Token: 0x0601DCA7 RID: 122023 RVA: 0x00901CD9 File Offset: 0x008FFED9
		public unsafe FVector LastRippleLocationNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastRippleLocationNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastRippleLocationNormal) = value;
			}
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0601DCA8 RID: 122024 RVA: 0x00901CEE File Offset: 0x008FFEEE
		// (set) Token: 0x0601DCA9 RID: 122025 RVA: 0x00901CFE File Offset: 0x008FFEFE
		public unsafe float RippleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleOffset) = value;
			}
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x0601DCAA RID: 122026 RVA: 0x00901D0F File Offset: 0x008FFF0F
		// (set) Token: 0x0601DCAB RID: 122027 RVA: 0x00901D23 File Offset: 0x008FFF23
		public unsafe FVector LastRippleLocationFluo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastRippleLocationFluo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastRippleLocationFluo) = value;
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0601DCAC RID: 122028 RVA: 0x00901D38 File Offset: 0x008FFF38
		// (set) Token: 0x0601DCAD RID: 122029 RVA: 0x00901D48 File Offset: 0x008FFF48
		public unsafe float SwimRippleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_SwimRippleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_SwimRippleOffset) = value;
			}
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0601DCAE RID: 122030 RVA: 0x00901D59 File Offset: 0x008FFF59
		// (set) Token: 0x0601DCAF RID: 122031 RVA: 0x00901D6D File Offset: 0x008FFF6D
		public unsafe FVector2D PlayerPosNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerPosNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerPosNormal) = value;
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0601DCB0 RID: 122032 RVA: 0x00901D82 File Offset: 0x008FFF82
		// (set) Token: 0x0601DCB1 RID: 122033 RVA: 0x00901D96 File Offset: 0x008FFF96
		public unsafe FVector2D PlayerPosFluo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerPosFluo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_PlayerPosFluo) = value;
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0601DCB2 RID: 122034 RVA: 0x00901DAB File Offset: 0x008FFFAB
		// (set) Token: 0x0601DCB3 RID: 122035 RVA: 0x00901DBB File Offset: 0x008FFFBB
		public unsafe float LastRipplePastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastRipplePastTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastRipplePastTime) = value;
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0601DCB4 RID: 122036 RVA: 0x00901DCC File Offset: 0x008FFFCC
		// (set) Token: 0x0601DCB5 RID: 122037 RVA: 0x00901DDC File Offset: 0x008FFFDC
		public unsafe bool InFixedRippleArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_InFixedRippleArea) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_InFixedRippleArea) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0601DCB6 RID: 122038 RVA: 0x00901DED File Offset: 0x008FFFED
		// (set) Token: 0x0601DCB7 RID: 122039 RVA: 0x00901E01 File Offset: 0x00900001
		public unsafe UTextureRenderTarget2D PersistRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_PersistRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_PersistRT, value);
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0601DCB8 RID: 122040 RVA: 0x00901E16 File Offset: 0x00900016
		// (set) Token: 0x0601DCB9 RID: 122041 RVA: 0x00901E2A File Offset: 0x0090002A
		public unsafe UTextureRenderTarget2D FinalRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_FinalRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_FinalRT, value);
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0601DCBA RID: 122042 RVA: 0x00901E3F File Offset: 0x0090003F
		// (set) Token: 0x0601DCBB RID: 122043 RVA: 0x00901E4F File Offset: 0x0090004F
		public unsafe bool bCustomRippleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bCustomRippleState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bCustomRippleState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0601DCBC RID: 122044 RVA: 0x00901E60 File Offset: 0x00900060
		// (set) Token: 0x0601DCBD RID: 122045 RVA: 0x00901E74 File Offset: 0x00900074
		public unsafe BP_SceneBattleInteract_C BulletConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_BulletConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_BulletConfig, value);
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0601DCBE RID: 122046 RVA: 0x00901E89 File Offset: 0x00900089
		// (set) Token: 0x0601DCBF RID: 122047 RVA: 0x00901E9D File Offset: 0x0090009D
		public unsafe FVector2D BulletUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletUV) = value;
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0601DCC0 RID: 122048 RVA: 0x00901EB2 File Offset: 0x009000B2
		// (set) Token: 0x0601DCC1 RID: 122049 RVA: 0x00901EC6 File Offset: 0x009000C6
		public unsafe FVector2D LastBulletUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastBulletUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastBulletUV) = value;
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0601DCC2 RID: 122050 RVA: 0x00901EDB File Offset: 0x009000DB
		// (set) Token: 0x0601DCC3 RID: 122051 RVA: 0x00901EEB File Offset: 0x009000EB
		public unsafe bool bSetUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bSetUV) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bSetUV) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0601DCC4 RID: 122052 RVA: 0x00901EFC File Offset: 0x009000FC
		// (set) Token: 0x0601DCC5 RID: 122053 RVA: 0x00901F0C File Offset: 0x0090010C
		public unsafe bool bShowDebugData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bShowDebugData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bShowDebugData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0601DCC6 RID: 122054 RVA: 0x00901F1D File Offset: 0x0090011D
		// (set) Token: 0x0601DCC7 RID: 122055 RVA: 0x00901F2D File Offset: 0x0090012D
		public unsafe double 翱翔射线长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_翱翔射线长度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_翱翔射线长度) = value;
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0601DCC8 RID: 122056 RVA: 0x00901F3E File Offset: 0x0090013E
		// (set) Token: 0x0601DCC9 RID: 122057 RVA: 0x00901F4E File Offset: 0x0090014E
		public unsafe float CurrRippleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CurrRippleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CurrRippleOffset) = value;
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0601DCCA RID: 122058 RVA: 0x00901F5F File Offset: 0x0090015F
		// (set) Token: 0x0601DCCB RID: 122059 RVA: 0x00901F6F File Offset: 0x0090016F
		public unsafe float CurrRippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CurrRippleIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CurrRippleIntensity) = value;
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0601DCCC RID: 122060 RVA: 0x00901F80 File Offset: 0x00900180
		// (set) Token: 0x0601DCCD RID: 122061 RVA: 0x00901F90 File Offset: 0x00900190
		public unsafe float RippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleIntensity) = value;
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0601DCCE RID: 122062 RVA: 0x00901FA1 File Offset: 0x009001A1
		// (set) Token: 0x0601DCCF RID: 122063 RVA: 0x00901FB1 File Offset: 0x009001B1
		public unsafe float FlyMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_FlyMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_FlyMaxDistance) = value;
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x0601DCD0 RID: 122064 RVA: 0x00901FC2 File Offset: 0x009001C2
		// (set) Token: 0x0601DCD1 RID: 122065 RVA: 0x00901FD2 File Offset: 0x009001D2
		public unsafe float FlyMinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_FlyMinDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_FlyMinDistance) = value;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x0601DCD2 RID: 122066 RVA: 0x00901FE3 File Offset: 0x009001E3
		// (set) Token: 0x0601DCD3 RID: 122067 RVA: 0x00901FF3 File Offset: 0x009001F3
		public unsafe float RippleAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleAttenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleAttenuation) = value;
			}
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x0601DCD4 RID: 122068 RVA: 0x00902004 File Offset: 0x00900204
		// (set) Token: 0x0601DCD5 RID: 122069 RVA: 0x00902018 File Offset: 0x00900218
		public unsafe FVectorDouble AvailblePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_AvailblePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_AvailblePoint) = value;
			}
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x0601DCD6 RID: 122070 RVA: 0x0090202D File Offset: 0x0090022D
		// (set) Token: 0x0601DCD7 RID: 122071 RVA: 0x00902041 File Offset: 0x00900241
		public unsafe FVectorDouble LastAvailblePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastAvailblePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_LastAvailblePoint) = value;
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x0601DCD8 RID: 122072 RVA: 0x00902056 File Offset: 0x00900256
		// (set) Token: 0x0601DCD9 RID: 122073 RVA: 0x00902066 File Offset: 0x00900266
		public unsafe float BulletMinConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletMinConnectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletMinConnectDistance) = value;
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0601DCDA RID: 122074 RVA: 0x00902077 File Offset: 0x00900277
		// (set) Token: 0x0601DCDB RID: 122075 RVA: 0x00902087 File Offset: 0x00900287
		public unsafe float BulletMaxConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletMaxConnectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletMaxConnectDistance) = value;
			}
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0601DCDC RID: 122076 RVA: 0x00902098 File Offset: 0x00900298
		// (set) Token: 0x0601DCDD RID: 122077 RVA: 0x009020A8 File Offset: 0x009002A8
		public unsafe double Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x0601DCDE RID: 122078 RVA: 0x009020B9 File Offset: 0x009002B9
		// (set) Token: 0x0601DCDF RID: 122079 RVA: 0x009020C9 File Offset: 0x009002C9
		public unsafe float BulletLastHitTime0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletLastHitTime0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletLastHitTime0) = value;
			}
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0601DCE0 RID: 122080 RVA: 0x009020DC File Offset: 0x009002DC
		// (set) Token: 0x0601DCE1 RID: 122081 RVA: 0x00902115 File Offset: 0x00900315
		[Nullable(1)]
		public TArray<FVectorDouble> BulletPointList0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletPointList0) == null)
				{
					result = (this._BulletPointList0 = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletPointList0, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletPointList0.CopyAssign(value);
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0601DCE2 RID: 122082 RVA: 0x00902123 File Offset: 0x00900323
		// (set) Token: 0x0601DCE3 RID: 122083 RVA: 0x00902133 File Offset: 0x00900333
		public unsafe float BulletLastHitTime1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletLastHitTime1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletLastHitTime1) = value;
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0601DCE4 RID: 122084 RVA: 0x00902144 File Offset: 0x00900344
		// (set) Token: 0x0601DCE5 RID: 122085 RVA: 0x0090217D File Offset: 0x0090037D
		[Nullable(1)]
		public TArray<FVectorDouble> BulletPointList1
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletPointList1) == null)
				{
					result = (this._BulletPointList1 = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletPointList1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletPointList1.CopyAssign(value);
			}
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0601DCE6 RID: 122086 RVA: 0x0090218B File Offset: 0x0090038B
		// (set) Token: 0x0601DCE7 RID: 122087 RVA: 0x0090219B File Offset: 0x0090039B
		public unsafe float BulletLastHitTime2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletLastHitTime2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletLastHitTime2) = value;
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0601DCE8 RID: 122088 RVA: 0x009021AC File Offset: 0x009003AC
		// (set) Token: 0x0601DCE9 RID: 122089 RVA: 0x009021E5 File Offset: 0x009003E5
		[Nullable(1)]
		public TArray<FVectorDouble> BulletPointList2
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletPointList2) == null)
				{
					result = (this._BulletPointList2 = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_BulletPointList2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletPointList2.CopyAssign(value);
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0601DCEA RID: 122090 RVA: 0x009021F3 File Offset: 0x009003F3
		// (set) Token: 0x0601DCEB RID: 122091 RVA: 0x00902203 File Offset: 0x00900403
		public unsafe int CatMullStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CatMullStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CatMullStep) = value;
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0601DCEC RID: 122092 RVA: 0x00902214 File Offset: 0x00900414
		// (set) Token: 0x0601DCED RID: 122093 RVA: 0x00902224 File Offset: 0x00900424
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0601DCEE RID: 122094 RVA: 0x00902235 File Offset: 0x00900435
		// (set) Token: 0x0601DCEF RID: 122095 RVA: 0x00902245 File Offset: 0x00900445
		public unsafe float Tension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Tension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Tension) = value;
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0601DCF0 RID: 122096 RVA: 0x00902258 File Offset: 0x00900458
		// (set) Token: 0x0601DCF1 RID: 122097 RVA: 0x00902291 File Offset: 0x00900491
		[Nullable(1)]
		public TArray<FVectorDouble> AvailblePointList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._AvailblePointList) == null)
				{
					result = (this._AvailblePointList = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_AvailblePointList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AvailblePointList.CopyAssign(value);
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0601DCF2 RID: 122098 RVA: 0x0090229F File Offset: 0x0090049F
		// (set) Token: 0x0601DCF3 RID: 122099 RVA: 0x009022B3 File Offset: 0x009004B3
		public unsafe UTextureRenderTarget2D PointRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_PointRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_PointRT, value);
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0601DCF4 RID: 122100 RVA: 0x009022C8 File Offset: 0x009004C8
		// (set) Token: 0x0601DCF5 RID: 122101 RVA: 0x009022DC File Offset: 0x009004DC
		public unsafe UMaterialInstanceDynamic AddPointsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_AddPointsMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_AddPointsMaterial, value);
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0601DCF6 RID: 122102 RVA: 0x009022F1 File Offset: 0x009004F1
		// (set) Token: 0x0601DCF7 RID: 122103 RVA: 0x00902305 File Offset: 0x00900505
		public unsafe UMaterialInstanceDynamic AddCapsuleMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_AddCapsuleMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_AddCapsuleMaterial, value);
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0601DCF8 RID: 122104 RVA: 0x0090231A File Offset: 0x0090051A
		// (set) Token: 0x0601DCF9 RID: 122105 RVA: 0x0090232E File Offset: 0x0090052E
		[Nullable(0)]
		public unsafe TEnumAsByte<EDrawDebugTrace> Fly_Ray_Debug_Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Fly_Ray_Debug_Type);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Fly_Ray_Debug_Type) = value;
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0601DCFA RID: 122106 RVA: 0x00902343 File Offset: 0x00900543
		// (set) Token: 0x0601DCFB RID: 122107 RVA: 0x00902357 File Offset: 0x00900557
		public unsafe FVector2D CurrentRippleCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CurrentRippleCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_CurrentRippleCenter) = value;
			}
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0601DCFC RID: 122108 RVA: 0x0090236C File Offset: 0x0090056C
		// (set) Token: 0x0601DCFD RID: 122109 RVA: 0x0090237C File Offset: 0x0090057C
		public unsafe bool UseOldRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_UseOldRipple) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_UseOldRipple) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0601DCFE RID: 122110 RVA: 0x0090238D File Offset: 0x0090058D
		// (set) Token: 0x0601DCFF RID: 122111 RVA: 0x0090239D File Offset: 0x0090059D
		public unsafe float NewCaptureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_NewCaptureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_NewCaptureSize) = value;
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0601DD00 RID: 122112 RVA: 0x009023AE File Offset: 0x009005AE
		// (set) Token: 0x0601DD01 RID: 122113 RVA: 0x009023C2 File Offset: 0x009005C2
		public unsafe UMaterialInstanceDynamic NewRipplePrevMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_NewRipplePrevMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_NewRipplePrevMaterial, value);
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0601DD02 RID: 122114 RVA: 0x009023D7 File Offset: 0x009005D7
		// (set) Token: 0x0601DD03 RID: 122115 RVA: 0x009023EB File Offset: 0x009005EB
		public unsafe FLinearColor Weapon_0_Debug_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Weapon_0_Debug_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Weapon_0_Debug_Color) = value;
			}
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0601DD04 RID: 122116 RVA: 0x00902400 File Offset: 0x00900600
		// (set) Token: 0x0601DD05 RID: 122117 RVA: 0x00902414 File Offset: 0x00900614
		public unsafe FLinearColor Weapon_1_Debug_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Weapon_1_Debug_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Weapon_1_Debug_Color) = value;
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0601DD06 RID: 122118 RVA: 0x00902429 File Offset: 0x00900629
		// (set) Token: 0x0601DD07 RID: 122119 RVA: 0x0090243D File Offset: 0x0090063D
		public unsafe FLinearColor Weapon_2_Debug_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Weapon_2_Debug_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_Weapon_2_Debug_Color) = value;
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x0601DD08 RID: 122120 RVA: 0x00902452 File Offset: 0x00900652
		// (set) Token: 0x0601DD09 RID: 122121 RVA: 0x00902466 File Offset: 0x00900666
		public unsafe FVector2D RippleCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_RippleCenterOffset) = value;
			}
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0601DD0A RID: 122122 RVA: 0x0090247B File Offset: 0x0090067B
		// (set) Token: 0x0601DD0B RID: 122123 RVA: 0x0090248B File Offset: 0x0090068B
		public unsafe bool bEnableSwimRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bEnableSwimRipple) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bEnableSwimRipple) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0601DD0C RID: 122124 RVA: 0x0090249C File Offset: 0x0090069C
		// (set) Token: 0x0601DD0D RID: 122125 RVA: 0x009024AC File Offset: 0x009006AC
		public unsafe float WaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_WaterDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_WaterDepth) = value;
			}
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0601DD0E RID: 122126 RVA: 0x009024BD File Offset: 0x009006BD
		// (set) Token: 0x0601DD0F RID: 122127 RVA: 0x009024CD File Offset: 0x009006CD
		public unsafe float FallJumpDepthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_FallJumpDepthThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_FallJumpDepthThreshold) = value;
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0601DD10 RID: 122128 RVA: 0x009024DE File Offset: 0x009006DE
		// (set) Token: 0x0601DD11 RID: 122129 RVA: 0x009024EE File Offset: 0x009006EE
		public unsafe bool bForceSwimRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bForceSwimRipple) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_bForceSwimRipple) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DD12 RID: 122130 RVA: 0x009024FF File Offset: 0x009006FF
		[SkipLocalsInit]
		public virtual void Ripple_Stamp()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Ripple_Stamp_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD13 RID: 122131 RVA: 0x00902513 File Offset: 0x00900713
		[SkipLocalsInit]
		public virtual void Ripple_Simulation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Ripple_Simulation_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD14 RID: 122132 RVA: 0x00902528 File Offset: 0x00900728
		[SkipLocalsInit]
		public unsafe virtual void CheckAndSetPos(float DeltaSeconds, ref float LastRippleTime)
		{
			BP_RippleSwim_C.__CheckAndSetPos_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CheckAndSetPos_FunctionParams[(UIntPtr)1359] + 15L / (long)sizeof(BP_RippleSwim_C.__CheckAndSetPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CheckAndSetPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->LastRippleTime = LastRippleTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CheckAndSetPos_NativeFunctionPtr, (void*)ptr);
			LastRippleTime = ptr->LastRippleTime;
		}

		// Token: 0x0601DD15 RID: 122133 RVA: 0x00902581 File Offset: 0x00900781
		[SkipLocalsInit]
		public virtual void SetCloseSwimRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__SetCloseSwimRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD16 RID: 122134 RVA: 0x00902598 File Offset: 0x00900798
		[SkipLocalsInit]
		public unsafe virtual void Set_Bullet_Data(BP_SceneBattleInteract_C Config)
		{
			BP_RippleSwim_C.__Set_Bullet_Data_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Set_Bullet_Data_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_RippleSwim_C.__Set_Bullet_Data_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Set_Bullet_Data_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Set_Bullet_Data_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD17 RID: 122135 RVA: 0x009025ED File Offset: 0x009007ED
		[SkipLocalsInit]
		public virtual void SetNewRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__SetNewRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD18 RID: 122136 RVA: 0x00902601 File Offset: 0x00900801
		[SkipLocalsInit]
		public virtual void SetOldRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__SetOldRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD19 RID: 122137 RVA: 0x00902618 File Offset: 0x00900818
		[SkipLocalsInit]
		public unsafe virtual void TexcoordToPosition(FVectorDouble RippleCenter, FVector2D RippleUV, float CaptureSize, ref FVector2D Position)
		{
			BP_RippleSwim_C.__TexcoordToPosition_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__TexcoordToPosition_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_RippleSwim_C.__TexcoordToPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__TexcoordToPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RippleCenter = RippleCenter;
			ptr->RippleUV = RippleUV;
			ptr->CaptureSize = CaptureSize;
			ptr->Position = Position;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__TexcoordToPosition_NativeFunctionPtr, (void*)ptr);
			Position = ptr->Position;
		}

		// Token: 0x0601DD1A RID: 122138 RVA: 0x0090268C File Offset: 0x0090088C
		[SkipLocalsInit]
		public unsafe virtual void Calc_Circle_Weapon_2(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Circle_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Circle_Weapon_2_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Circle_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Circle_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Circle_Weapon_2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD1B RID: 122139 RVA: 0x009026EC File Offset: 0x009008EC
		[SkipLocalsInit]
		public unsafe virtual void Calc_Capsule_Weapon_2(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Capsule_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Capsule_Weapon_2_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Capsule_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Capsule_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Capsule_Weapon_2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD1C RID: 122140 RVA: 0x0090274C File Offset: 0x0090094C
		[SkipLocalsInit]
		public unsafe virtual void Compare_New_Point_Weapon_2(FVectorDouble V2, ref bool Vaild)
		{
			BP_RippleSwim_C.__Compare_New_Point_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Compare_New_Point_Weapon_2_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_RippleSwim_C.__Compare_New_Point_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Compare_New_Point_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Compare_New_Point_Weapon_2_NativeFunctionPtr, (void*)ptr);
			Vaild = ptr->Vaild;
		}

		// Token: 0x0601DD1D RID: 122141 RVA: 0x009027A4 File Offset: 0x009009A4
		[SkipLocalsInit]
		public unsafe virtual void Calc_Catmull_Weapon_2(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Catmull_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Catmull_Weapon_2_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Catmull_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Catmull_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Catmull_Weapon_2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD1E RID: 122142 RVA: 0x00902804 File Offset: 0x00900A04
		[SkipLocalsInit]
		public unsafe virtual void Compare_New_Point_Weapon_1(FVectorDouble V2, ref bool Vaild)
		{
			BP_RippleSwim_C.__Compare_New_Point_Weapon_1_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Compare_New_Point_Weapon_1_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_RippleSwim_C.__Compare_New_Point_Weapon_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Compare_New_Point_Weapon_1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Compare_New_Point_Weapon_1_NativeFunctionPtr, (void*)ptr);
			Vaild = ptr->Vaild;
		}

		// Token: 0x0601DD1F RID: 122143 RVA: 0x0090285C File Offset: 0x00900A5C
		[SkipLocalsInit]
		public unsafe virtual void Calc_Catmull_Weapon_1(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Catmull_Weapon_1_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Catmull_Weapon_1_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Catmull_Weapon_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Catmull_Weapon_1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Catmull_Weapon_1_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD20 RID: 122144 RVA: 0x009028BC File Offset: 0x00900ABC
		[SkipLocalsInit]
		public unsafe virtual void Compare_New_Point_Weapon_0(FVectorDouble V2, ref bool Vaild)
		{
			BP_RippleSwim_C.__Compare_New_Point_Weapon_0_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Compare_New_Point_Weapon_0_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_RippleSwim_C.__Compare_New_Point_Weapon_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Compare_New_Point_Weapon_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Compare_New_Point_Weapon_0_NativeFunctionPtr, (void*)ptr);
			Vaild = ptr->Vaild;
		}

		// Token: 0x0601DD21 RID: 122145 RVA: 0x00902914 File Offset: 0x00900B14
		[SkipLocalsInit]
		public unsafe virtual void Calc_Catmull_Weapon_0(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Catmull_Weapon_0_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Catmull_Weapon_0_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Catmull_Weapon_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Catmull_Weapon_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Catmull_Weapon_0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD22 RID: 122146 RVA: 0x00902974 File Offset: 0x00900B74
		[SkipLocalsInit]
		public unsafe virtual void CalcTexCoord2D(FVectorDouble RippleCenter, FVector2D RipplePointLocation, float CaptureSize, ref FVector2D TexCoord)
		{
			BP_RippleSwim_C.__CalcTexCoord2D_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CalcTexCoord2D_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_RippleSwim_C.__CalcTexCoord2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CalcTexCoord2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RippleCenter = RippleCenter;
			ptr->RipplePointLocation = RipplePointLocation;
			ptr->CaptureSize = CaptureSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CalcTexCoord2D_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x0601DD23 RID: 122147 RVA: 0x009029E8 File Offset: 0x00900BE8
		[SkipLocalsInit]
		public unsafe virtual void GetPointsV3(ref TArray<FVectorDouble> PointList, ref bool Vaild, ref FVector2D P_0, ref FVector2D P_1, ref FVector2D P_2, ref FVector2D P_3)
		{
			BP_RippleSwim_C.__GetPointsV3_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__GetPointsV3_FunctionParams[(UIntPtr)343] + 15L / (long)sizeof(BP_RippleSwim_C.__GetPointsV3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__GetPointsV3_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVectorDouble> tarray = PointList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PointList);
			}
			ptr->Vaild = Vaild;
			ptr->P_0 = P_0;
			ptr->P_1 = P_1;
			ptr->P_2 = P_2;
			ptr->P_3 = P_3;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__GetPointsV3_NativeFunctionPtr, (void*)ptr);
			TArray<FVectorDouble> tarray2 = PointList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->PointList);
			}
			Vaild = ptr->Vaild;
			P_0 = ptr->P_0;
			P_1 = ptr->P_1;
			P_2 = ptr->P_2;
			P_3 = ptr->P_3;
			UnrealReflectionUtils.DestroyStruct(BP_RippleSwim_C.__GetPointsV3_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD24 RID: 122148 RVA: 0x00902ADC File Offset: 0x00900CDC
		[SkipLocalsInit]
		public unsafe virtual void GetPoints(ref TArray<FVector2D> PointList, ref bool Vaild, ref FVector2D P_0, ref FVector2D P_1, ref FVector2D P_2, ref FVector2D P_3)
		{
			BP_RippleSwim_C.__GetPoints_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__GetPoints_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_RippleSwim_C.__GetPoints_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__GetPoints_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector2D> tarray = PointList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PointList);
			}
			ptr->Vaild = Vaild;
			ptr->P_0 = P_0;
			ptr->P_1 = P_1;
			ptr->P_2 = P_2;
			ptr->P_3 = P_3;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__GetPoints_NativeFunctionPtr, (void*)ptr);
			TArray<FVector2D> tarray2 = PointList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->PointList);
			}
			Vaild = ptr->Vaild;
			P_0 = ptr->P_0;
			P_1 = ptr->P_1;
			P_2 = ptr->P_2;
			P_3 = ptr->P_3;
			UnrealReflectionUtils.DestroyStruct(BP_RippleSwim_C.__GetPoints_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD25 RID: 122149 RVA: 0x00902BD0 File Offset: 0x00900DD0
		[SkipLocalsInit]
		public unsafe virtual void CatmullRom(ref TArray<FVector2D> PointList, int StepCount, ref bool Vaild, ref TArray<FVector2D> CurveList)
		{
			BP_RippleSwim_C.__CatmullRom_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CatmullRom_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(BP_RippleSwim_C.__CatmullRom_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CatmullRom_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector2D> tarray = PointList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PointList);
			}
			ptr->StepCount = StepCount;
			ptr->Vaild = Vaild;
			TArray<FVector2D> tarray2 = CurveList;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->CurveList);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CatmullRom_NativeFunctionPtr, (void*)ptr);
			TArray<FVector2D> tarray3 = PointList;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->PointList);
			}
			Vaild = ptr->Vaild;
			TArray<FVector2D> tarray4 = CurveList;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->CurveList);
			}
			UnrealReflectionUtils.DestroyStruct(BP_RippleSwim_C.__CatmullRom_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD26 RID: 122150 RVA: 0x00902C8C File Offset: 0x00900E8C
		[SkipLocalsInit]
		public unsafe virtual void CalcDistance2D(FVectorDouble V1, FVectorDouble V2, ref double Distance)
		{
			BP_RippleSwim_C.__CalcDistance2D_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CalcDistance2D_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_RippleSwim_C.__CalcDistance2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V1 = V1;
			ptr->V2 = V2;
			ptr->Distance = Distance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr);
			Distance = ptr->Distance;
		}

		// Token: 0x0601DD27 RID: 122151 RVA: 0x00902CEC File Offset: 0x00900EEC
		[SkipLocalsInit]
		public unsafe virtual void Choose_Available_Point(FVectorDouble CollisionPoint, FVectorDouble WeaponPoint, BP_SceneBattleInteract_C ConfigDA, ref FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Choose_Available_Point_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Choose_Available_Point_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_RippleSwim_C.__Choose_Available_Point_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CollisionPoint = CollisionPoint;
			ptr->WeaponPoint = WeaponPoint;
			ptr->ConfigDA = ((ConfigDA != null) ? ConfigDA.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr);
			AvailblePoint = ptr->AvailblePoint;
		}

		// Token: 0x0601DD28 RID: 122152 RVA: 0x00902D6C File Offset: 0x00900F6C
		[SkipLocalsInit]
		public unsafe virtual void CalcTexCoord(FVectorDouble RippleCenter, FVectorDouble RipplePointLocation, float CaptureSize, ref FVector TexCoord)
		{
			BP_RippleSwim_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CalcTexCoord_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_RippleSwim_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RippleCenter = RippleCenter;
			ptr->RipplePointLocation = RipplePointLocation;
			ptr->CaptureSize = CaptureSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x0601DD29 RID: 122153 RVA: 0x00902DDD File Offset: 0x00900FDD
		[SkipLocalsInit]
		public virtual void Clear_RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Clear_RT_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD2A RID: 122154 RVA: 0x00902DF4 File Offset: 0x00900FF4
		[SkipLocalsInit]
		public unsafe virtual void AboveWater(FVector Location, ref bool bAboveWater)
		{
			BP_RippleSwim_C.__AboveWater_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__AboveWater_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_RippleSwim_C.__AboveWater_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__AboveWater_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			ptr->bAboveWater = bAboveWater;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__AboveWater_NativeFunctionPtr, (void*)ptr);
			bAboveWater = ptr->bAboveWater;
		}

		// Token: 0x0601DD2B RID: 122155 RVA: 0x00902E4A File Offset: 0x0090104A
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD2C RID: 122156 RVA: 0x00902E5E File Offset: 0x0090105E
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD2D RID: 122157 RVA: 0x00902E72 File Offset: 0x00901072
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD2E RID: 122158 RVA: 0x00902E86 File Offset: 0x00901086
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD2F RID: 122159 RVA: 0x00902E9C File Offset: 0x0090109C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_RippleSwim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD30 RID: 122160 RVA: 0x00902EE4 File Offset: 0x009010E4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_RippleSwim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD31 RID: 122161 RVA: 0x00902F2A File Offset: 0x0090112A
		[SkipLocalsInit]
		public virtual void Refresh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Refresh_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD32 RID: 122162 RVA: 0x00902F3E File Offset: 0x0090113E
		[SkipLocalsInit]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD33 RID: 122163 RVA: 0x00902F52 File Offset: 0x00901152
		[SkipLocalsInit]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0601DD34 RID: 122164 RVA: 0x00902F68 File Offset: 0x00901168
		[SkipLocalsInit]
		public unsafe virtual void OnBulletHitWater(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__OnBulletHitWater_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__OnBulletHitWater_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__OnBulletHitWater_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__OnBulletHitWater_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__OnBulletHitWater_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD35 RID: 122165 RVA: 0x00902FD4 File Offset: 0x009011D4
		[SkipLocalsInit]
		public unsafe virtual void BulletHitPos(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__BulletHitPos_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__BulletHitPos_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__BulletHitPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__BulletHitPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__BulletHitPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD36 RID: 122166 RVA: 0x00903040 File Offset: 0x00901240
		[SkipLocalsInit]
		public unsafe virtual void OnBulletHitPos(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__OnBulletHitPos_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__OnBulletHitPos_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__OnBulletHitPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__OnBulletHitPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__OnBulletHitPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD37 RID: 122167 RVA: 0x009030AC File Offset: 0x009012AC
		[SkipLocalsInit]
		public unsafe virtual void TestHitEvent(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__TestHitEvent_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__TestHitEvent_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__TestHitEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__TestHitEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__TestHitEvent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD38 RID: 122168 RVA: 0x00903118 File Offset: 0x00901318
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD39 RID: 122169 RVA: 0x00903164 File Offset: 0x00901364
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD3A RID: 122170 RVA: 0x009031AF File Offset: 0x009013AF
		protected BP_RippleSwim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB4F RID: 64335
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/BP_Tools/RippleSwim/BP_RippleSwim.BP_RippleSwim_C";

		// Token: 0x0400FB50 RID: 64336
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB51 RID: 64337
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB52 RID: 64338
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FB53 RID: 64339
		internal static int __PropertyOffset_AddNewMaterial;

		// Token: 0x0400FB54 RID: 64340
		internal static int __PropertyOffset_tempToPrevMaterial;

		// Token: 0x0400FB55 RID: 64341
		internal static int __PropertyOffset_DrawMaterial;

		// Token: 0x0400FB56 RID: 64342
		internal static int __PropertyOffset_bSim;

		// Token: 0x0400FB57 RID: 64343
		internal static int __PropertyOffset_Plane;

		// Token: 0x0400FB58 RID: 64344
		internal static int __PropertyOffset_PrevState;

		// Token: 0x0400FB59 RID: 64345
		internal static int __PropertyOffset_State;

		// Token: 0x0400FB5A RID: 64346
		internal static int __PropertyOffset_Tag_Container;

		// Token: 0x0400FB5B RID: 64347
		private FGameplayTagContainer _Tag_Container;

		// Token: 0x0400FB5C RID: 64348
		internal static int __PropertyOffset_Step;

		// Token: 0x0400FB5D RID: 64349
		internal static int __PropertyOffset_captureSize;

		// Token: 0x0400FB5E RID: 64350
		internal static int __PropertyOffset_rippleMaterial;

		// Token: 0x0400FB5F RID: 64351
		internal static int __PropertyOffset_prevRT;

		// Token: 0x0400FB60 RID: 64352
		internal static int __PropertyOffset_currentRT;

		// Token: 0x0400FB61 RID: 64353
		internal static int __PropertyOffset_tempRTRef;

		// Token: 0x0400FB62 RID: 64354
		internal static int __PropertyOffset_PlayerLocation;

		// Token: 0x0400FB63 RID: 64355
		internal static int __PropertyOffset_Offset;

		// Token: 0x0400FB64 RID: 64356
		internal static int __PropertyOffset_TestActor;

		// Token: 0x0400FB65 RID: 64357
		internal static int __PropertyOffset_PlayerSize;

		// Token: 0x0400FB66 RID: 64358
		internal static int __PropertyOffset_Global_MPC;

		// Token: 0x0400FB67 RID: 64359
		internal static int __PropertyOffset_bPlayerInWaterLast;

		// Token: 0x0400FB68 RID: 64360
		internal static int __PropertyOffset_RippleDistanceNormal;

		// Token: 0x0400FB69 RID: 64361
		internal static int __PropertyOffset_RippleDistanceFluo;

		// Token: 0x0400FB6A RID: 64362
		internal static int __PropertyOffset_PositionOffset;

		// Token: 0x0400FB6B RID: 64363
		internal static int __PropertyOffset_LastRippleLocationNormal;

		// Token: 0x0400FB6C RID: 64364
		internal static int __PropertyOffset_RippleOffset;

		// Token: 0x0400FB6D RID: 64365
		internal static int __PropertyOffset_LastRippleLocationFluo;

		// Token: 0x0400FB6E RID: 64366
		internal static int __PropertyOffset_SwimRippleOffset;

		// Token: 0x0400FB6F RID: 64367
		internal static int __PropertyOffset_PlayerPosNormal;

		// Token: 0x0400FB70 RID: 64368
		internal static int __PropertyOffset_PlayerPosFluo;

		// Token: 0x0400FB71 RID: 64369
		internal static int __PropertyOffset_LastRipplePastTime;

		// Token: 0x0400FB72 RID: 64370
		internal static int __PropertyOffset_InFixedRippleArea;

		// Token: 0x0400FB73 RID: 64371
		internal static int __PropertyOffset_PersistRT;

		// Token: 0x0400FB74 RID: 64372
		internal static int __PropertyOffset_FinalRT;

		// Token: 0x0400FB75 RID: 64373
		internal static int __PropertyOffset_bCustomRippleState;

		// Token: 0x0400FB76 RID: 64374
		internal static int __PropertyOffset_BulletConfig;

		// Token: 0x0400FB77 RID: 64375
		internal static int __PropertyOffset_BulletUV;

		// Token: 0x0400FB78 RID: 64376
		internal static int __PropertyOffset_LastBulletUV;

		// Token: 0x0400FB79 RID: 64377
		internal static int __PropertyOffset_bSetUV;

		// Token: 0x0400FB7A RID: 64378
		internal static int __PropertyOffset_bShowDebugData;

		// Token: 0x0400FB7B RID: 64379
		internal static int __PropertyOffset_翱翔射线长度;

		// Token: 0x0400FB7C RID: 64380
		internal static int __PropertyOffset_CurrRippleOffset;

		// Token: 0x0400FB7D RID: 64381
		internal static int __PropertyOffset_CurrRippleIntensity;

		// Token: 0x0400FB7E RID: 64382
		internal static int __PropertyOffset_RippleIntensity;

		// Token: 0x0400FB7F RID: 64383
		internal static int __PropertyOffset_FlyMaxDistance;

		// Token: 0x0400FB80 RID: 64384
		internal static int __PropertyOffset_FlyMinDistance;

		// Token: 0x0400FB81 RID: 64385
		internal static int __PropertyOffset_RippleAttenuation;

		// Token: 0x0400FB82 RID: 64386
		internal static int __PropertyOffset_AvailblePoint;

		// Token: 0x0400FB83 RID: 64387
		internal static int __PropertyOffset_LastAvailblePoint;

		// Token: 0x0400FB84 RID: 64388
		internal static int __PropertyOffset_BulletMinConnectDistance;

		// Token: 0x0400FB85 RID: 64389
		internal static int __PropertyOffset_BulletMaxConnectDistance;

		// Token: 0x0400FB86 RID: 64390
		internal static int __PropertyOffset_Distance;

		// Token: 0x0400FB87 RID: 64391
		internal static int __PropertyOffset_BulletLastHitTime0;

		// Token: 0x0400FB88 RID: 64392
		internal static int __PropertyOffset_BulletPointList0;

		// Token: 0x0400FB89 RID: 64393
		private TArray<FVectorDouble> _BulletPointList0;

		// Token: 0x0400FB8A RID: 64394
		internal static int __PropertyOffset_BulletLastHitTime1;

		// Token: 0x0400FB8B RID: 64395
		internal static int __PropertyOffset_BulletPointList1;

		// Token: 0x0400FB8C RID: 64396
		private TArray<FVectorDouble> _BulletPointList1;

		// Token: 0x0400FB8D RID: 64397
		internal static int __PropertyOffset_BulletLastHitTime2;

		// Token: 0x0400FB8E RID: 64398
		internal static int __PropertyOffset_BulletPointList2;

		// Token: 0x0400FB8F RID: 64399
		private TArray<FVectorDouble> _BulletPointList2;

		// Token: 0x0400FB90 RID: 64400
		internal static int __PropertyOffset_CatMullStep;

		// Token: 0x0400FB91 RID: 64401
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400FB92 RID: 64402
		internal static int __PropertyOffset_Tension;

		// Token: 0x0400FB93 RID: 64403
		internal static int __PropertyOffset_AvailblePointList;

		// Token: 0x0400FB94 RID: 64404
		private TArray<FVectorDouble> _AvailblePointList;

		// Token: 0x0400FB95 RID: 64405
		internal static int __PropertyOffset_PointRT;

		// Token: 0x0400FB96 RID: 64406
		internal static int __PropertyOffset_AddPointsMaterial;

		// Token: 0x0400FB97 RID: 64407
		internal static int __PropertyOffset_AddCapsuleMaterial;

		// Token: 0x0400FB98 RID: 64408
		internal static int __PropertyOffset_Fly_Ray_Debug_Type;

		// Token: 0x0400FB99 RID: 64409
		internal static int __PropertyOffset_CurrentRippleCenter;

		// Token: 0x0400FB9A RID: 64410
		internal static int __PropertyOffset_UseOldRipple;

		// Token: 0x0400FB9B RID: 64411
		internal static int __PropertyOffset_NewCaptureSize;

		// Token: 0x0400FB9C RID: 64412
		internal static int __PropertyOffset_NewRipplePrevMaterial;

		// Token: 0x0400FB9D RID: 64413
		internal static int __PropertyOffset_Weapon_0_Debug_Color;

		// Token: 0x0400FB9E RID: 64414
		internal static int __PropertyOffset_Weapon_1_Debug_Color;

		// Token: 0x0400FB9F RID: 64415
		internal static int __PropertyOffset_Weapon_2_Debug_Color;

		// Token: 0x0400FBA0 RID: 64416
		internal static int __PropertyOffset_RippleCenterOffset;

		// Token: 0x0400FBA1 RID: 64417
		internal static int __PropertyOffset_bEnableSwimRipple;

		// Token: 0x0400FBA2 RID: 64418
		internal static int __PropertyOffset_WaterDepth;

		// Token: 0x0400FBA3 RID: 64419
		internal static int __PropertyOffset_FallJumpDepthThreshold;

		// Token: 0x0400FBA4 RID: 64420
		internal static int __PropertyOffset_bForceSwimRipple;

		// Token: 0x0400FBA5 RID: 64421
		private static IntPtr __Ripple_Stamp_NativeFunctionPtr;

		// Token: 0x0400FBA6 RID: 64422
		private static IntPtr __Ripple_Simulation_NativeFunctionPtr;

		// Token: 0x0400FBA7 RID: 64423
		private static IntPtr __CheckAndSetPos_NativeFunctionPtr;

		// Token: 0x0400FBA8 RID: 64424
		private static IntPtr __SetCloseSwimRipple_NativeFunctionPtr;

		// Token: 0x0400FBA9 RID: 64425
		private static IntPtr __Set_Bullet_Data_NativeFunctionPtr;

		// Token: 0x0400FBAA RID: 64426
		private static IntPtr __SetNewRipple_NativeFunctionPtr;

		// Token: 0x0400FBAB RID: 64427
		private static IntPtr __SetOldRipple_NativeFunctionPtr;

		// Token: 0x0400FBAC RID: 64428
		private static IntPtr __TexcoordToPosition_NativeFunctionPtr;

		// Token: 0x0400FBAD RID: 64429
		private static IntPtr __Calc_Circle_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400FBAE RID: 64430
		private static IntPtr __Calc_Capsule_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400FBAF RID: 64431
		private static IntPtr __Compare_New_Point_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400FBB0 RID: 64432
		private static IntPtr __Calc_Catmull_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400FBB1 RID: 64433
		private static IntPtr __Compare_New_Point_Weapon_1_NativeFunctionPtr;

		// Token: 0x0400FBB2 RID: 64434
		private static IntPtr __Calc_Catmull_Weapon_1_NativeFunctionPtr;

		// Token: 0x0400FBB3 RID: 64435
		private static IntPtr __Compare_New_Point_Weapon_0_NativeFunctionPtr;

		// Token: 0x0400FBB4 RID: 64436
		private static IntPtr __Calc_Catmull_Weapon_0_NativeFunctionPtr;

		// Token: 0x0400FBB5 RID: 64437
		private static IntPtr __CalcTexCoord2D_NativeFunctionPtr;

		// Token: 0x0400FBB6 RID: 64438
		private static IntPtr __GetPointsV3_NativeFunctionPtr;

		// Token: 0x0400FBB7 RID: 64439
		private static IntPtr __GetPoints_NativeFunctionPtr;

		// Token: 0x0400FBB8 RID: 64440
		private static IntPtr __CatmullRom_NativeFunctionPtr;

		// Token: 0x0400FBB9 RID: 64441
		private static IntPtr __CalcDistance2D_NativeFunctionPtr;

		// Token: 0x0400FBBA RID: 64442
		private static IntPtr __Choose_Available_Point_NativeFunctionPtr;

		// Token: 0x0400FBBB RID: 64443
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x0400FBBC RID: 64444
		private static IntPtr __Clear_RT_NativeFunctionPtr;

		// Token: 0x0400FBBD RID: 64445
		private static IntPtr __AboveWater_NativeFunctionPtr;

		// Token: 0x0400FBBE RID: 64446
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FBBF RID: 64447
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FBC0 RID: 64448
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FBC1 RID: 64449
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x0400FBC2 RID: 64450
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x0400FBC3 RID: 64451
		private static IntPtr __OnBulletHitWater_NativeFunctionPtr;

		// Token: 0x0400FBC4 RID: 64452
		private static IntPtr __BulletHitPos_NativeFunctionPtr;

		// Token: 0x0400FBC5 RID: 64453
		private static IntPtr __OnBulletHitPos_NativeFunctionPtr;

		// Token: 0x0400FBC6 RID: 64454
		private static IntPtr __TestHitEvent_NativeFunctionPtr;

		// Token: 0x0400FBC7 RID: 64455
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008DA0 RID: 36256
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1344)]
		protected ref struct __CheckAndSetPos_FunctionParams
		{
			// Token: 0x0402C95C RID: 182620
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x0402C95D RID: 182621
			[FieldOffset(4)]
			public float LastRippleTime;
		}

		// Token: 0x02008DA1 RID: 36257
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Set_Bullet_Data_FunctionParams
		{
			// Token: 0x0402C95E RID: 182622
			[FieldOffset(0)]
			public IntPtr Config;
		}

		// Token: 0x02008DA2 RID: 36258
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __TexcoordToPosition_FunctionParams
		{
			// Token: 0x0402C95F RID: 182623
			[FieldOffset(0)]
			public FVectorDouble RippleCenter;

			// Token: 0x0402C960 RID: 182624
			[FieldOffset(24)]
			public FVector2D RippleUV;

			// Token: 0x0402C961 RID: 182625
			[FieldOffset(32)]
			public float CaptureSize;

			// Token: 0x0402C962 RID: 182626
			[FieldOffset(36)]
			public FVector2D Position;
		}

		// Token: 0x02008DA3 RID: 36259
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __Calc_Circle_Weapon_2_FunctionParams
		{
			// Token: 0x0402C963 RID: 182627
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x0402C964 RID: 182628
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02008DA4 RID: 36260
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __Calc_Capsule_Weapon_2_FunctionParams
		{
			// Token: 0x0402C965 RID: 182629
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x0402C966 RID: 182630
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02008DA5 RID: 36261
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Compare_New_Point_Weapon_2_FunctionParams
		{
			// Token: 0x0402C967 RID: 182631
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x0402C968 RID: 182632
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02008DA6 RID: 36262
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __Calc_Catmull_Weapon_2_FunctionParams
		{
			// Token: 0x0402C969 RID: 182633
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x0402C96A RID: 182634
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02008DA7 RID: 36263
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Compare_New_Point_Weapon_1_FunctionParams
		{
			// Token: 0x0402C96B RID: 182635
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x0402C96C RID: 182636
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02008DA8 RID: 36264
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __Calc_Catmull_Weapon_1_FunctionParams
		{
			// Token: 0x0402C96D RID: 182637
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x0402C96E RID: 182638
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02008DA9 RID: 36265
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Compare_New_Point_Weapon_0_FunctionParams
		{
			// Token: 0x0402C96F RID: 182639
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x0402C970 RID: 182640
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02008DAA RID: 36266
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __Calc_Catmull_Weapon_0_FunctionParams
		{
			// Token: 0x0402C971 RID: 182641
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x0402C972 RID: 182642
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02008DAB RID: 36267
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __CalcTexCoord2D_FunctionParams
		{
			// Token: 0x0402C973 RID: 182643
			[FieldOffset(0)]
			public FVectorDouble RippleCenter;

			// Token: 0x0402C974 RID: 182644
			[FieldOffset(24)]
			public FVector2D RipplePointLocation;

			// Token: 0x0402C975 RID: 182645
			[FieldOffset(32)]
			public float CaptureSize;

			// Token: 0x0402C976 RID: 182646
			[FieldOffset(36)]
			public FVector2D TexCoord;
		}

		// Token: 0x02008DAC RID: 36268
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 328)]
		protected ref struct __GetPointsV3_FunctionParams
		{
			// Token: 0x0402C977 RID: 182647
			[FieldOffset(0)]
			public byte PointList;

			// Token: 0x0402C978 RID: 182648
			[FieldOffset(16)]
			public bool Vaild;

			// Token: 0x0402C979 RID: 182649
			[FieldOffset(20)]
			public FVector2D P_0;

			// Token: 0x0402C97A RID: 182650
			[FieldOffset(28)]
			public FVector2D P_1;

			// Token: 0x0402C97B RID: 182651
			[FieldOffset(36)]
			public FVector2D P_2;

			// Token: 0x0402C97C RID: 182652
			[FieldOffset(44)]
			public FVector2D P_3;
		}

		// Token: 0x02008DAD RID: 36269
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetPoints_FunctionParams
		{
			// Token: 0x0402C97D RID: 182653
			[FieldOffset(0)]
			public byte PointList;

			// Token: 0x0402C97E RID: 182654
			[FieldOffset(16)]
			public bool Vaild;

			// Token: 0x0402C97F RID: 182655
			[FieldOffset(20)]
			public FVector2D P_0;

			// Token: 0x0402C980 RID: 182656
			[FieldOffset(28)]
			public FVector2D P_1;

			// Token: 0x0402C981 RID: 182657
			[FieldOffset(36)]
			public FVector2D P_2;

			// Token: 0x0402C982 RID: 182658
			[FieldOffset(44)]
			public FVector2D P_3;
		}

		// Token: 0x02008DAE RID: 36270
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __CatmullRom_FunctionParams
		{
			// Token: 0x0402C983 RID: 182659
			[FieldOffset(0)]
			public byte PointList;

			// Token: 0x0402C984 RID: 182660
			[FieldOffset(16)]
			public int StepCount;

			// Token: 0x0402C985 RID: 182661
			[FieldOffset(20)]
			public bool Vaild;

			// Token: 0x0402C986 RID: 182662
			[FieldOffset(24)]
			public byte CurveList;
		}

		// Token: 0x02008DAF RID: 36271
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __CalcDistance2D_FunctionParams
		{
			// Token: 0x0402C987 RID: 182663
			[FieldOffset(0)]
			public FVectorDouble V1;

			// Token: 0x0402C988 RID: 182664
			[FieldOffset(24)]
			public FVectorDouble V2;

			// Token: 0x0402C989 RID: 182665
			[FieldOffset(48)]
			public double Distance;
		}

		// Token: 0x02008DB0 RID: 36272
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Choose_Available_Point_FunctionParams
		{
			// Token: 0x0402C98A RID: 182666
			[FieldOffset(0)]
			public FVectorDouble CollisionPoint;

			// Token: 0x0402C98B RID: 182667
			[FieldOffset(24)]
			public FVectorDouble WeaponPoint;

			// Token: 0x0402C98C RID: 182668
			[FieldOffset(48)]
			public IntPtr ConfigDA;

			// Token: 0x0402C98D RID: 182669
			[FieldOffset(56)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02008DB1 RID: 36273
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x0402C98E RID: 182670
			[FieldOffset(0)]
			public FVectorDouble RippleCenter;

			// Token: 0x0402C98F RID: 182671
			[FieldOffset(24)]
			public FVectorDouble RipplePointLocation;

			// Token: 0x0402C990 RID: 182672
			[FieldOffset(48)]
			public float CaptureSize;

			// Token: 0x0402C991 RID: 182673
			[FieldOffset(52)]
			public FVector TexCoord;
		}

		// Token: 0x02008DB2 RID: 36274
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __AboveWater_FunctionParams
		{
			// Token: 0x0402C992 RID: 182674
			[FieldOffset(0)]
			public FVector Location;

			// Token: 0x0402C993 RID: 182675
			[FieldOffset(12)]
			public bool bAboveWater;
		}

		// Token: 0x02008DB3 RID: 36275
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C994 RID: 182676
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008DB4 RID: 36276
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __OnBulletHitWater_FunctionParams
		{
			// Token: 0x0402C995 RID: 182677
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x0402C996 RID: 182678
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0402C997 RID: 182679
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x0402C998 RID: 182680
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02008DB5 RID: 36277
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __BulletHitPos_FunctionParams
		{
			// Token: 0x0402C999 RID: 182681
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x0402C99A RID: 182682
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0402C99B RID: 182683
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x0402C99C RID: 182684
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02008DB6 RID: 36278
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __OnBulletHitPos_FunctionParams
		{
			// Token: 0x0402C99D RID: 182685
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x0402C99E RID: 182686
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0402C99F RID: 182687
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x0402C9A0 RID: 182688
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02008DB7 RID: 36279
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __TestHitEvent_FunctionParams
		{
			// Token: 0x0402C9A1 RID: 182689
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x0402C9A2 RID: 182690
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0402C9A3 RID: 182691
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x0402C9A4 RID: 182692
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02008DB8 RID: 36280
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402C9A5 RID: 182693
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
