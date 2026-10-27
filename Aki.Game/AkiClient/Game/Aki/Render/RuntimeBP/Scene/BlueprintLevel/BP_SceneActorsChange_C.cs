using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Data;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.BlueprintLevel
{
	// Token: 0x02003BA4 RID: 15268
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_SceneActorsChange.BP_SceneActorsChange_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_SceneActorsChange_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021FF7 RID: 139255 RVA: 0x008FBD74 File Offset: 0x008F9F74
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneActorsChange_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_SceneActorsChange.BP_SceneActorsChange_C");
			}
			return BP_SceneActorsChange_C._ClassPtr;
		}

		// Token: 0x06021FF8 RID: 139256 RVA: 0x008FBD98 File Offset: 0x008F9F98
		public BP_SceneActorsChange_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneActorsChange_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FF9 RID: 139257 RVA: 0x008FBDC0 File Offset: 0x008F9FC0
		public BP_SceneActorsChange_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneActorsChange_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x06021FFA RID: 139258 RVA: 0x008FBDF3 File Offset: 0x008F9FF3
		// (set) Token: 0x06021FFB RID: 139259 RVA: 0x008FBE07 File Offset: 0x008FA007
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneActorsChange_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneActorsChange_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x06021FFC RID: 139260 RVA: 0x008FBE1C File Offset: 0x008FA01C
		// (set) Token: 0x06021FFD RID: 139261 RVA: 0x008FBE2C File Offset: 0x008FA02C
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x06021FFE RID: 139262 RVA: 0x008FBE3D File Offset: 0x008FA03D
		// (set) Token: 0x06021FFF RID: 139263 RVA: 0x008FBE4D File Offset: 0x008FA04D
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x06022000 RID: 139264 RVA: 0x008FBE5E File Offset: 0x008FA05E
		// (set) Token: 0x06022001 RID: 139265 RVA: 0x008FBE6E File Offset: 0x008FA06E
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x06022002 RID: 139266 RVA: 0x008FBE7F File Offset: 0x008FA07F
		// (set) Token: 0x06022003 RID: 139267 RVA: 0x008FBE8F File Offset: 0x008FA08F
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x06022004 RID: 139268 RVA: 0x008FBEA0 File Offset: 0x008FA0A0
		// (set) Token: 0x06022005 RID: 139269 RVA: 0x008FBED9 File Offset: 0x008FA0D9
		public TArray<ALight> LightGroup_01
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ALight> result;
				if ((result = this._LightGroup_01) == null)
				{
					result = (this._LightGroup_01 = new TArray<ALight>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.LightGroup_01.CopyAssign(value);
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x06022006 RID: 139270 RVA: 0x008FBEE8 File Offset: 0x008FA0E8
		// (set) Token: 0x06022007 RID: 139271 RVA: 0x008FBF21 File Offset: 0x008FA121
		public TArray<ALight> LightGroup_02
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ALight> result;
				if ((result = this._LightGroup_02) == null)
				{
					result = (this._LightGroup_02 = new TArray<ALight>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.LightGroup_02.CopyAssign(value);
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x06022008 RID: 139272 RVA: 0x008FBF30 File Offset: 0x008FA130
		// (set) Token: 0x06022009 RID: 139273 RVA: 0x008FBF69 File Offset: 0x008FA169
		public TArray<float> LightsIntensity_01
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LightsIntensity_01) == null)
				{
					result = (this._LightsIntensity_01 = new TArray<float>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.LightsIntensity_01.CopyAssign(value);
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0602200A RID: 139274 RVA: 0x008FBF78 File Offset: 0x008FA178
		// (set) Token: 0x0602200B RID: 139275 RVA: 0x008FBFB1 File Offset: 0x008FA1B1
		public TArray<float> LightsIntensity_02
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LightsIntensity_02) == null)
				{
					result = (this._LightsIntensity_02 = new TArray<float>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.LightsIntensity_02.CopyAssign(value);
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0602200C RID: 139276 RVA: 0x008FBFBF File Offset: 0x008FA1BF
		// (set) Token: 0x0602200D RID: 139277 RVA: 0x008FBFCF File Offset: 0x008FA1CF
		public unsafe bool TurnOffOrOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0602200E RID: 139278 RVA: 0x008FBFE0 File Offset: 0x008FA1E0
		// (set) Token: 0x0602200F RID: 139279 RVA: 0x008FC019 File Offset: 0x008FA219
		public TArray<BP_KuroLightDecal_C> DecalGroup_01
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_KuroLightDecal_C> result;
				if ((result = this._DecalGroup_01) == null)
				{
					result = (this._DecalGroup_01 = new TArray<BP_KuroLightDecal_C>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.DecalGroup_01.CopyAssign(value);
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x06022010 RID: 139280 RVA: 0x008FC028 File Offset: 0x008FA228
		// (set) Token: 0x06022011 RID: 139281 RVA: 0x008FC061 File Offset: 0x008FA261
		public TArray<BP_KuroLightDecal_C> DecalGroup_02
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_KuroLightDecal_C> result;
				if ((result = this._DecalGroup_02) == null)
				{
					result = (this._DecalGroup_02 = new TArray<BP_KuroLightDecal_C>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.DecalGroup_02.CopyAssign(value);
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x06022012 RID: 139282 RVA: 0x008FC070 File Offset: 0x008FA270
		// (set) Token: 0x06022013 RID: 139283 RVA: 0x008FC0A9 File Offset: 0x008FA2A9
		public TArray<float> EmissiveIntensity_01
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._EmissiveIntensity_01) == null)
				{
					result = (this._EmissiveIntensity_01 = new TArray<float>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.EmissiveIntensity_01.CopyAssign(value);
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x06022014 RID: 139284 RVA: 0x008FC0B8 File Offset: 0x008FA2B8
		// (set) Token: 0x06022015 RID: 139285 RVA: 0x008FC0F1 File Offset: 0x008FA2F1
		public TArray<float> EmissiveIntensity_02
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._EmissiveIntensity_02) == null)
				{
					result = (this._EmissiveIntensity_02 = new TArray<float>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.EmissiveIntensity_02.CopyAssign(value);
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x06022016 RID: 139286 RVA: 0x008FC100 File Offset: 0x008FA300
		// (set) Token: 0x06022017 RID: 139287 RVA: 0x008FC139 File Offset: 0x008FA339
		public TArray<BP_EffectActor_C> EffectGroup_01
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._EffectGroup_01) == null)
				{
					result = (this._EffectGroup_01 = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.EffectGroup_01.CopyAssign(value);
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x06022018 RID: 139288 RVA: 0x008FC148 File Offset: 0x008FA348
		// (set) Token: 0x06022019 RID: 139289 RVA: 0x008FC181 File Offset: 0x008FA381
		public TArray<BP_EffectActor_C> EffectGroup_02
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_EffectActor_C> result;
				if ((result = this._EffectGroup_02) == null)
				{
					result = (this._EffectGroup_02 = new TArray<BP_EffectActor_C>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.EffectGroup_02.CopyAssign(value);
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0602201A RID: 139290 RVA: 0x008FC190 File Offset: 0x008FA390
		// (set) Token: 0x0602201B RID: 139291 RVA: 0x008FC1C9 File Offset: 0x008FA3C9
		public TArray<SEffectColorParameter> EffectColor_01
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectColorParameter> result;
				if ((result = this._EffectColor_01) == null)
				{
					result = (this._EffectColor_01 = new TArray<SEffectColorParameter>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.EffectColor_01.CopyAssign(value);
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0602201C RID: 139292 RVA: 0x008FC1D8 File Offset: 0x008FA3D8
		// (set) Token: 0x0602201D RID: 139293 RVA: 0x008FC211 File Offset: 0x008FA411
		public TArray<SEffectColorParameter> EffectColor_02
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectColorParameter> result;
				if ((result = this._EffectColor_02) == null)
				{
					result = (this._EffectColor_02 = new TArray<SEffectColorParameter>(base.NativePtr + (IntPtr)BP_SceneActorsChange_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.EffectColor_02.CopyAssign(value);
			}
		}

		// Token: 0x0602201E RID: 139294 RVA: 0x008FC220 File Offset: 0x008FA420
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetEffect([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_EffectActor_C> Array, ref TArray<SEffectColorParameter> List, bool bNewHidden)
		{
			BP_SceneActorsChange_C.__SetEffect_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__SetEffect_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BP_SceneActorsChange_C.__SetEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__SetEffect_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BP_EffectActor_C> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			TArray<SEffectColorParameter> tarray2 = List;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->List);
			}
			ptr->bNewHidden = bNewHidden;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__SetEffect_NativeFunctionPtr, (void*)ptr);
			TArray<BP_EffectActor_C> tarray3 = Array;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Array);
			}
			TArray<SEffectColorParameter> tarray4 = List;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->List);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__SetEffect_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602201F RID: 139295 RVA: 0x008FC2CC File Offset: 0x008FA4CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EffectUpdate([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_EffectActor_C> Array, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_EffectActor_C> Array1, float ElapsedTime)
		{
			BP_SceneActorsChange_C.__EffectUpdate_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__EffectUpdate_FunctionParams[(UIntPtr)271] + 15L / (long)sizeof(BP_SceneActorsChange_C.__EffectUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__EffectUpdate_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BP_EffectActor_C> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			TArray<BP_EffectActor_C> tarray2 = Array1;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Array1);
			}
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__EffectUpdate_NativeFunctionPtr, (void*)ptr);
			TArray<BP_EffectActor_C> tarray3 = Array;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Array);
			}
			TArray<BP_EffectActor_C> tarray4 = Array1;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Array1);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__EffectUpdate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022020 RID: 139296 RVA: 0x008FC378 File Offset: 0x008FA578
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetEffectParam([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_EffectActor_C> Array, in TArray<SEffectColorParameter> TargetArray, bool bHidden)
		{
			BP_SceneActorsChange_C.__GetEffectParam_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__GetEffectParam_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_SceneActorsChange_C.__GetEffectParam_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__GetEffectParam_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BP_EffectActor_C> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			object obj = TargetArray;
			if (obj != null)
			{
				obj.MoveTo(&ptr->TargetArray);
			}
			ptr->bHidden = bHidden;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__GetEffectParam_NativeFunctionPtr, (void*)ptr);
			TArray<BP_EffectActor_C> tarray2 = Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Array);
			}
			object obj2 = TargetArray;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__GetEffectParam_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022021 RID: 139297 RVA: 0x008FC420 File Offset: 0x008FA620
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDecal([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_KuroLightDecal_C> Array, ref TArray<float> List, bool bNewHidden)
		{
			BP_SceneActorsChange_C.__SetDecal_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__SetDecal_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_SceneActorsChange_C.__SetDecal_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__SetDecal_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BP_KuroLightDecal_C> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			TArray<float> tarray2 = List;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->List);
			}
			ptr->bNewHidden = bNewHidden;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__SetDecal_NativeFunctionPtr, (void*)ptr);
			TArray<BP_KuroLightDecal_C> tarray3 = Array;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Array);
			}
			TArray<float> tarray4 = List;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->List);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__SetDecal_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022022 RID: 139298 RVA: 0x008FC4C8 File Offset: 0x008FA6C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DecalUpdate([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_KuroLightDecal_C> Array, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_KuroLightDecal_C> Array1, float ElapsedTime)
		{
			BP_SceneActorsChange_C.__DecalUpdate_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__DecalUpdate_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_SceneActorsChange_C.__DecalUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__DecalUpdate_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BP_KuroLightDecal_C> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			TArray<BP_KuroLightDecal_C> tarray2 = Array1;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Array1);
			}
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__DecalUpdate_NativeFunctionPtr, (void*)ptr);
			TArray<BP_KuroLightDecal_C> tarray3 = Array;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Array);
			}
			TArray<BP_KuroLightDecal_C> tarray4 = Array1;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Array1);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__DecalUpdate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022023 RID: 139299 RVA: 0x008FC574 File Offset: 0x008FA774
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetDecalParam([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<BP_KuroLightDecal_C> Array, ref TArray<float> TargetArray, bool bNewHidden)
		{
			BP_SceneActorsChange_C.__GetDecalParam_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__GetDecalParam_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_SceneActorsChange_C.__GetDecalParam_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__GetDecalParam_NativeFunctionPtr, (void*)ptr, 1);
			TArray<BP_KuroLightDecal_C> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			TArray<float> tarray2 = TargetArray;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->TargetArray);
			}
			ptr->bNewHidden = bNewHidden;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__GetDecalParam_NativeFunctionPtr, (void*)ptr);
			TArray<BP_KuroLightDecal_C> tarray3 = Array;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Array);
			}
			TArray<float> tarray4 = TargetArray;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__GetDecalParam_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022024 RID: 139300 RVA: 0x008FC61C File Offset: 0x008FA81C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLightsIntensity([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ALight> Array, ref TArray<float> LightsIntensity, bool Hidden)
		{
			BP_SceneActorsChange_C.__SetLightsIntensity_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__SetLightsIntensity_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SceneActorsChange_C.__SetLightsIntensity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__SetLightsIntensity_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ALight> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			TArray<float> tarray2 = LightsIntensity;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->LightsIntensity);
			}
			ptr->Hidden = Hidden;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__SetLightsIntensity_NativeFunctionPtr, (void*)ptr);
			TArray<ALight> tarray3 = Array;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Array);
			}
			TArray<float> tarray4 = LightsIntensity;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->LightsIntensity);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__SetLightsIntensity_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022025 RID: 139301 RVA: 0x008FC6C4 File Offset: 0x008FA8C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LightsUpdate([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ALight> Group01, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ALight> Group02, float ElapsedTime)
		{
			BP_SceneActorsChange_C.__LightsUpdate_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__LightsUpdate_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_SceneActorsChange_C.__LightsUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__LightsUpdate_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ALight> tarray = Group01;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Group01);
			}
			TArray<ALight> tarray2 = Group02;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Group02);
			}
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__LightsUpdate_NativeFunctionPtr, (void*)ptr);
			TArray<ALight> tarray3 = Group01;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Group01);
			}
			TArray<ALight> tarray4 = Group02;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Group02);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__LightsUpdate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022026 RID: 139302 RVA: 0x008FC770 File Offset: 0x008FA970
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetLightsIntensity([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ALight> Array, in TArray<float> TargetArray, bool bHidden)
		{
			BP_SceneActorsChange_C.__GetLightsIntensity_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__GetLightsIntensity_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SceneActorsChange_C.__GetLightsIntensity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__GetLightsIntensity_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ALight> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			object obj = TargetArray;
			if (obj != null)
			{
				obj.MoveTo(&ptr->TargetArray);
			}
			ptr->bHidden = bHidden;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__GetLightsIntensity_NativeFunctionPtr, (void*)ptr);
			TArray<ALight> tarray2 = Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Array);
			}
			object obj2 = TargetArray;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->TargetArray);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SceneActorsChange_C.__GetLightsIntensity_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022027 RID: 139303 RVA: 0x008FC818 File Offset: 0x008FAA18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_SceneActorsChange_C.__Timer_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneActorsChange_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x06022028 RID: 139304 RVA: 0x008FC868 File Offset: 0x008FAA68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ActorsChange(bool IsTick)
		{
			BP_SceneActorsChange_C.__ActorsChange_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__ActorsChange_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_SceneActorsChange_C.__ActorsChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__ActorsChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsTick = IsTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__ActorsChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022029 RID: 139305 RVA: 0x008FC8AE File Offset: 0x008FAAAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602202A RID: 139306 RVA: 0x008FC8C2 File Offset: 0x008FAAC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneActorsChange_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602202B RID: 139307 RVA: 0x008FC8D8 File Offset: 0x008FAAD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SceneActorsChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneActorsChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602202C RID: 139308 RVA: 0x008FC920 File Offset: 0x008FAB20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SceneActorsChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneActorsChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneActorsChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602202D RID: 139309 RVA: 0x008FC968 File Offset: 0x008FAB68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SceneActorsChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneActorsChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneActorsChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602202E RID: 139310 RVA: 0x008FC9B0 File Offset: 0x008FABB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SceneActorsChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneActorsChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneActorsChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneActorsChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneActorsChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602202F RID: 139311 RVA: 0x008FC9F7 File Offset: 0x008FABF7
		protected BP_SceneActorsChange_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A19 RID: 68121
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_SceneActorsChange.BP_SceneActorsChange_C";

		// Token: 0x04010A1A RID: 68122
		private static IntPtr _ClassPtr;

		// Token: 0x04010A1B RID: 68123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A1C RID: 68124
		internal static int __PropertyOffset_1;

		// Token: 0x04010A1D RID: 68125
		internal static int __PropertyOffset_2;

		// Token: 0x04010A1E RID: 68126
		internal static int __PropertyOffset_3;

		// Token: 0x04010A1F RID: 68127
		internal static int __PropertyOffset_4;

		// Token: 0x04010A20 RID: 68128
		internal static int __PropertyOffset_5;

		// Token: 0x04010A21 RID: 68129
		internal static int __PropertyOffset_6;

		// Token: 0x04010A22 RID: 68130
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALight> _LightGroup_01;

		// Token: 0x04010A23 RID: 68131
		internal static int __PropertyOffset_7;

		// Token: 0x04010A24 RID: 68132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALight> _LightGroup_02;

		// Token: 0x04010A25 RID: 68133
		internal static int __PropertyOffset_8;

		// Token: 0x04010A26 RID: 68134
		[Nullable(2)]
		private TArray<float> _LightsIntensity_01;

		// Token: 0x04010A27 RID: 68135
		internal static int __PropertyOffset_9;

		// Token: 0x04010A28 RID: 68136
		[Nullable(2)]
		private TArray<float> _LightsIntensity_02;

		// Token: 0x04010A29 RID: 68137
		internal static int __PropertyOffset_10;

		// Token: 0x04010A2A RID: 68138
		internal static int __PropertyOffset_11;

		// Token: 0x04010A2B RID: 68139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_KuroLightDecal_C> _DecalGroup_01;

		// Token: 0x04010A2C RID: 68140
		internal static int __PropertyOffset_12;

		// Token: 0x04010A2D RID: 68141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_KuroLightDecal_C> _DecalGroup_02;

		// Token: 0x04010A2E RID: 68142
		internal static int __PropertyOffset_13;

		// Token: 0x04010A2F RID: 68143
		[Nullable(2)]
		private TArray<float> _EmissiveIntensity_01;

		// Token: 0x04010A30 RID: 68144
		internal static int __PropertyOffset_14;

		// Token: 0x04010A31 RID: 68145
		[Nullable(2)]
		private TArray<float> _EmissiveIntensity_02;

		// Token: 0x04010A32 RID: 68146
		internal static int __PropertyOffset_15;

		// Token: 0x04010A33 RID: 68147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _EffectGroup_01;

		// Token: 0x04010A34 RID: 68148
		internal static int __PropertyOffset_16;

		// Token: 0x04010A35 RID: 68149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_EffectActor_C> _EffectGroup_02;

		// Token: 0x04010A36 RID: 68150
		internal static int __PropertyOffset_17;

		// Token: 0x04010A37 RID: 68151
		[Nullable(2)]
		private TArray<SEffectColorParameter> _EffectColor_01;

		// Token: 0x04010A38 RID: 68152
		internal static int __PropertyOffset_18;

		// Token: 0x04010A39 RID: 68153
		[Nullable(2)]
		private TArray<SEffectColorParameter> _EffectColor_02;

		// Token: 0x04010A3A RID: 68154
		private static IntPtr __SetEffect_NativeFunctionPtr;

		// Token: 0x04010A3B RID: 68155
		private static IntPtr __EffectUpdate_NativeFunctionPtr;

		// Token: 0x04010A3C RID: 68156
		private static IntPtr __GetEffectParam_NativeFunctionPtr;

		// Token: 0x04010A3D RID: 68157
		private static IntPtr __SetDecal_NativeFunctionPtr;

		// Token: 0x04010A3E RID: 68158
		private static IntPtr __DecalUpdate_NativeFunctionPtr;

		// Token: 0x04010A3F RID: 68159
		private static IntPtr __GetDecalParam_NativeFunctionPtr;

		// Token: 0x04010A40 RID: 68160
		private static IntPtr __SetLightsIntensity_NativeFunctionPtr;

		// Token: 0x04010A41 RID: 68161
		private static IntPtr __LightsUpdate_NativeFunctionPtr;

		// Token: 0x04010A42 RID: 68162
		private static IntPtr __GetLightsIntensity_NativeFunctionPtr;

		// Token: 0x04010A43 RID: 68163
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x04010A44 RID: 68164
		private static IntPtr __ActorsChange_NativeFunctionPtr;

		// Token: 0x04010A45 RID: 68165
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010A46 RID: 68166
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010A47 RID: 68167
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D04 RID: 40196
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __SetEffect_FunctionParams
		{
			// Token: 0x04031417 RID: 201751
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x04031418 RID: 201752
			[FieldOffset(16)]
			public byte List;

			// Token: 0x04031419 RID: 201753
			[FieldOffset(32)]
			public bool bNewHidden;
		}

		// Token: 0x02009D05 RID: 40197
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __EffectUpdate_FunctionParams
		{
			// Token: 0x0403141A RID: 201754
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x0403141B RID: 201755
			[FieldOffset(16)]
			public byte Array1;

			// Token: 0x0403141C RID: 201756
			[FieldOffset(32)]
			public float ElapsedTime;
		}

		// Token: 0x02009D06 RID: 40198
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __GetEffectParam_FunctionParams
		{
			// Token: 0x0403141D RID: 201757
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x0403141E RID: 201758
			[FieldOffset(16)]
			public byte TargetArray;

			// Token: 0x0403141F RID: 201759
			[FieldOffset(32)]
			public bool bHidden;
		}

		// Token: 0x02009D07 RID: 40199
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetDecal_FunctionParams
		{
			// Token: 0x04031420 RID: 201760
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x04031421 RID: 201761
			[FieldOffset(16)]
			public byte List;

			// Token: 0x04031422 RID: 201762
			[FieldOffset(32)]
			public bool bNewHidden;
		}

		// Token: 0x02009D08 RID: 40200
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __DecalUpdate_FunctionParams
		{
			// Token: 0x04031423 RID: 201763
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x04031424 RID: 201764
			[FieldOffset(16)]
			public byte Array1;

			// Token: 0x04031425 RID: 201765
			[FieldOffset(32)]
			public float ElapsedTime;
		}

		// Token: 0x02009D09 RID: 40201
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __GetDecalParam_FunctionParams
		{
			// Token: 0x04031426 RID: 201766
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x04031427 RID: 201767
			[FieldOffset(16)]
			public byte TargetArray;

			// Token: 0x04031428 RID: 201768
			[FieldOffset(32)]
			public bool bNewHidden;
		}

		// Token: 0x02009D0A RID: 40202
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetLightsIntensity_FunctionParams
		{
			// Token: 0x04031429 RID: 201769
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x0403142A RID: 201770
			[FieldOffset(16)]
			public byte LightsIntensity;

			// Token: 0x0403142B RID: 201771
			[FieldOffset(32)]
			public bool Hidden;
		}

		// Token: 0x02009D0B RID: 40203
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __LightsUpdate_FunctionParams
		{
			// Token: 0x0403142C RID: 201772
			[FieldOffset(0)]
			public byte Group01;

			// Token: 0x0403142D RID: 201773
			[FieldOffset(16)]
			public byte Group02;

			// Token: 0x0403142E RID: 201774
			[FieldOffset(32)]
			public float ElapsedTime;
		}

		// Token: 0x02009D0C RID: 40204
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetLightsIntensity_FunctionParams
		{
			// Token: 0x0403142F RID: 201775
			[FieldOffset(0)]
			public byte Array;

			// Token: 0x04031430 RID: 201776
			[FieldOffset(16)]
			public byte TargetArray;

			// Token: 0x04031431 RID: 201777
			[FieldOffset(32)]
			public bool bHidden;
		}

		// Token: 0x02009D0D RID: 40205
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031432 RID: 201778
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02009D0E RID: 40206
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ActorsChange_FunctionParams
		{
			// Token: 0x04031433 RID: 201779
			[FieldOffset(0)]
			public bool IsTick;
		}

		// Token: 0x02009D0F RID: 40207
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031434 RID: 201780
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D10 RID: 40208
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031435 RID: 201781
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
