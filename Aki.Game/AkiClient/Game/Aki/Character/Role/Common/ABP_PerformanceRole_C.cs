using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200329A RID: 12954
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C")]
	[UnrealStructLayout(32944, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 32935)]
	public class ABP_PerformanceRole_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020870 RID: 133232 RVA: 0x00948E61 File Offset: 0x00947061
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_PerformanceRole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C");
			}
			return ABP_PerformanceRole_C._ClassPtr;
		}

		// Token: 0x06020871 RID: 133233 RVA: 0x00948E88 File Offset: 0x00947088
		public ABP_PerformanceRole_C() : this(BuiltinUtils.AllocNativeUObject(ABP_PerformanceRole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020872 RID: 133234 RVA: 0x00948EB0 File Offset: 0x009470B0
		[NullableContext(1)]
		public ABP_PerformanceRole_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_PerformanceRole_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x06020873 RID: 133235 RVA: 0x00948EE3 File Offset: 0x009470E3
		// (set) Token: 0x06020874 RID: 133236 RVA: 0x00948EF7 File Offset: 0x009470F7
		public unsafe TEnumAsByte<EPerformanceRoleState> StateInternal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_StateInternal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_StateInternal) = value;
			}
		}

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x06020875 RID: 133237 RVA: 0x00948F0C File Offset: 0x0094710C
		// (set) Token: 0x06020876 RID: 133238 RVA: 0x00948F1C File Offset: 0x0094711C
		public unsafe bool reLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_reLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_reLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x06020877 RID: 133239 RVA: 0x00948F2D File Offset: 0x0094712D
		// (set) Token: 0x06020878 RID: 133240 RVA: 0x00948F3D File Offset: 0x0094713D
		public unsafe bool bForceChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bForceChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bForceChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x06020879 RID: 133241 RVA: 0x00948F4E File Offset: 0x0094714E
		// (set) Token: 0x0602087A RID: 133242 RVA: 0x00948F5E File Offset: 0x0094715E
		public unsafe float Delta_Time_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_Delta_Time_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_Delta_Time_X) = value;
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x0602087B RID: 133243 RVA: 0x00948F6F File Offset: 0x0094716F
		// (set) Token: 0x0602087C RID: 133244 RVA: 0x00948F7F File Offset: 0x0094717F
		public unsafe float HeadAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_HeadAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_HeadAlpha) = value;
			}
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x0602087D RID: 133245 RVA: 0x00948F90 File Offset: 0x00947190
		// (set) Token: 0x0602087E RID: 133246 RVA: 0x00948FC9 File Offset: 0x009471C9
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
					result = (this._OnEffectBegin = new OnEffectBegin(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_OnEffectBegin, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_OnEffectBegin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x0602087F RID: 133247 RVA: 0x00948FEC File Offset: 0x009471EC
		// (set) Token: 0x06020880 RID: 133248 RVA: 0x00949025 File Offset: 0x00947225
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
					result = (this._OnEffectEnd = new OnEffectEnd(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_OnEffectEnd, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_OnEffectEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x06020881 RID: 133249 RVA: 0x00949046 File Offset: 0x00947246
		// (set) Token: 0x06020882 RID: 133250 RVA: 0x00949056 File Offset: 0x00947256
		public unsafe float PerformDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_PerformDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_PerformDelay) = value;
			}
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x06020883 RID: 133251 RVA: 0x00949067 File Offset: 0x00947267
		// (set) Token: 0x06020884 RID: 133252 RVA: 0x00949077 File Offset: 0x00947277
		public unsafe float CurPerformTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CurPerformTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CurPerformTime) = value;
			}
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x06020885 RID: 133253 RVA: 0x00949088 File Offset: 0x00947288
		// (set) Token: 0x06020886 RID: 133254 RVA: 0x00949098 File Offset: 0x00947298
		public unsafe bool bForceChange_Perform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bForceChange_Perform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bForceChange_Perform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x06020887 RID: 133255 RVA: 0x009490A9 File Offset: 0x009472A9
		// (set) Token: 0x06020888 RID: 133256 RVA: 0x009490BD File Offset: 0x009472BD
		public unsafe FVector2D CacheViewportSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CacheViewportSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CacheViewportSize) = value;
			}
		}

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x06020889 RID: 133257 RVA: 0x009490D2 File Offset: 0x009472D2
		// (set) Token: 0x0602088A RID: 133258 RVA: 0x009490E6 File Offset: 0x009472E6
		public unsafe FVector LookAtWorld_Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_LookAtWorld_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_LookAtWorld_Position) = value;
			}
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x0602088B RID: 133259 RVA: 0x009490FB File Offset: 0x009472FB
		// (set) Token: 0x0602088C RID: 133260 RVA: 0x0094910F File Offset: 0x0094730F
		[Nullable(2)]
		public unsafe USkeletalMeshComponent Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x0602088D RID: 133261 RVA: 0x00949124 File Offset: 0x00947324
		// (set) Token: 0x0602088E RID: 133262 RVA: 0x00949138 File Offset: 0x00947338
		public unsafe FVector LookAtDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_LookAtDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_LookAtDirection) = value;
			}
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x0602088F RID: 133263 RVA: 0x0094914D File Offset: 0x0094734D
		// (set) Token: 0x06020890 RID: 133264 RVA: 0x0094915D File Offset: 0x0094735D
		public unsafe bool IsCreateRoleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_IsCreateRoleState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_IsCreateRoleState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x06020891 RID: 133265 RVA: 0x0094916E File Offset: 0x0094736E
		// (set) Token: 0x06020892 RID: 133266 RVA: 0x00949182 File Offset: 0x00947382
		public unsafe FVector CreateRoleStartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleStartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleStartLocation) = value;
			}
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x06020893 RID: 133267 RVA: 0x00949197 File Offset: 0x00947397
		// (set) Token: 0x06020894 RID: 133268 RVA: 0x009491AB File Offset: 0x009473AB
		public unsafe FVector CreateRoleEndLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndLocation) = value;
			}
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x06020895 RID: 133269 RVA: 0x009491C0 File Offset: 0x009473C0
		// (set) Token: 0x06020896 RID: 133270 RVA: 0x009491D0 File Offset: 0x009473D0
		public unsafe float CreateRoleMoveAllTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleMoveAllTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleMoveAllTime) = value;
			}
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x06020897 RID: 133271 RVA: 0x009491E1 File Offset: 0x009473E1
		// (set) Token: 0x06020898 RID: 133272 RVA: 0x009491F5 File Offset: 0x009473F5
		[Nullable(2)]
		public unsafe TsUiSceneRoleActor Actor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsUiSceneRoleActor>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_Actor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_PerformanceRole_C.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x06020899 RID: 133273 RVA: 0x0094920A File Offset: 0x0094740A
		// (set) Token: 0x0602089A RID: 133274 RVA: 0x0094921A File Offset: 0x0094741A
		public unsafe float CreateRoleMoveCurrentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleMoveCurrentTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleMoveCurrentTime) = value;
			}
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x0602089B RID: 133275 RVA: 0x0094922B File Offset: 0x0094742B
		// (set) Token: 0x0602089C RID: 133276 RVA: 0x0094923F File Offset: 0x0094743F
		public unsafe FRotator CreateRoleStartRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleStartRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleStartRotation) = value;
			}
		}

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x0602089D RID: 133277 RVA: 0x00949254 File Offset: 0x00947454
		// (set) Token: 0x0602089E RID: 133278 RVA: 0x00949268 File Offset: 0x00947468
		public unsafe FVector CreateRoleEndLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndLocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndLocationOffset) = value;
			}
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x0602089F RID: 133279 RVA: 0x0094927D File Offset: 0x0094747D
		// (set) Token: 0x060208A0 RID: 133280 RVA: 0x00949291 File Offset: 0x00947491
		public unsafe FRotator CreateRoleEndRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndRotation) = value;
			}
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x060208A1 RID: 133281 RVA: 0x009492A6 File Offset: 0x009474A6
		// (set) Token: 0x060208A2 RID: 133282 RVA: 0x009492BA File Offset: 0x009474BA
		public unsafe FRotator CreateRoleEndRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleEndRotationOffset) = value;
			}
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x060208A3 RID: 133283 RVA: 0x009492CF File Offset: 0x009474CF
		// (set) Token: 0x060208A4 RID: 133284 RVA: 0x009492DF File Offset: 0x009474DF
		public unsafe float CreateRoleMovePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleMovePlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CreateRoleMovePlayRate) = value;
			}
		}

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x060208A5 RID: 133285 RVA: 0x009492F0 File Offset: 0x009474F0
		// (set) Token: 0x060208A6 RID: 133286 RVA: 0x00949300 File Offset: 0x00947500
		public unsafe bool HasInitCreateRoleInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_HasInitCreateRoleInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_HasInitCreateRoleInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x060208A7 RID: 133287 RVA: 0x00949311 File Offset: 0x00947511
		// (set) Token: 0x060208A8 RID: 133288 RVA: 0x00949321 File Offset: 0x00947521
		public unsafe bool isLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_isLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_isLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x060208A9 RID: 133289 RVA: 0x00949332 File Offset: 0x00947532
		// (set) Token: 0x060208AA RID: 133290 RVA: 0x00949342 File Offset: 0x00947542
		public unsafe bool bInitCreateRoleInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bInitCreateRoleInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bInitCreateRoleInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x060208AB RID: 133291 RVA: 0x00949353 File Offset: 0x00947553
		// (set) Token: 0x060208AC RID: 133292 RVA: 0x00949363 File Offset: 0x00947563
		public unsafe bool InSkillRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_InSkillRotate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_InSkillRotate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x060208AD RID: 133293 RVA: 0x00949374 File Offset: 0x00947574
		// (set) Token: 0x060208AE RID: 133294 RVA: 0x00949384 File Offset: 0x00947584
		public unsafe bool InSkillEndRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_InSkillEndRotate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_InSkillEndRotate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x060208AF RID: 133295 RVA: 0x00949395 File Offset: 0x00947595
		// (set) Token: 0x060208B0 RID: 133296 RVA: 0x009493A5 File Offset: 0x009475A5
		public unsafe bool TempRotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_TempRotate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_TempRotate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x060208B1 RID: 133297 RVA: 0x009493B6 File Offset: 0x009475B6
		// (set) Token: 0x060208B2 RID: 133298 RVA: 0x009493C6 File Offset: 0x009475C6
		public unsafe float BlinkAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_BlinkAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_BlinkAlpha) = value;
			}
		}

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x060208B3 RID: 133299 RVA: 0x009493D7 File Offset: 0x009475D7
		// (set) Token: 0x060208B4 RID: 133300 RVA: 0x009493E7 File Offset: 0x009475E7
		public unsafe bool InBlinking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_InBlinking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_InBlinking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x060208B5 RID: 133301 RVA: 0x009493F8 File Offset: 0x009475F8
		// (set) Token: 0x060208B6 RID: 133302 RVA: 0x00949408 File Offset: 0x00947608
		public unsafe float BlinkEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_BlinkEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_BlinkEndTime) = value;
			}
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x060208B7 RID: 133303 RVA: 0x00949419 File Offset: 0x00947619
		// (set) Token: 0x060208B8 RID: 133304 RVA: 0x00949429 File Offset: 0x00947629
		public unsafe float 眨眼动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_眨眼动画时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_眨眼动画时长) = value;
			}
		}

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x060208B9 RID: 133305 RVA: 0x0094943A File Offset: 0x0094763A
		// (set) Token: 0x060208BA RID: 133306 RVA: 0x0094944A File Offset: 0x0094764A
		public unsafe float 此轮眨眼动画总时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_此轮眨眼动画总时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_此轮眨眼动画总时长) = value;
			}
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x060208BB RID: 133307 RVA: 0x0094945C File Offset: 0x0094765C
		// (set) Token: 0x060208BC RID: 133308 RVA: 0x00949495 File Offset: 0x00947695
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
					result = (this._SameStateArray01 = new TArray<TEnumAsByte<EPerformanceRoleState>>(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_SameStateArray01, this));
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

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x060208BD RID: 133309 RVA: 0x009494A3 File Offset: 0x009476A3
		// (set) Token: 0x060208BE RID: 133310 RVA: 0x009494B3 File Offset: 0x009476B3
		public unsafe bool False
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_False) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_False) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x060208BF RID: 133311 RVA: 0x009494C4 File Offset: 0x009476C4
		// (set) Token: 0x060208C0 RID: 133312 RVA: 0x009494D4 File Offset: 0x009476D4
		public unsafe bool DirectEnterLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_DirectEnterLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_DirectEnterLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x060208C1 RID: 133313 RVA: 0x009494E5 File Offset: 0x009476E5
		// (set) Token: 0x060208C2 RID: 133314 RVA: 0x009494F9 File Offset: 0x009476F9
		public unsafe TEnumAsByte<EPerformanceRoleState> CurrentState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CurrentState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_CurrentState) = value;
			}
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x060208C3 RID: 133315 RVA: 0x0094950E File Offset: 0x0094770E
		// (set) Token: 0x060208C4 RID: 133316 RVA: 0x0094951E File Offset: 0x0094771E
		public unsafe bool reLoopFromLoopToStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_reLoopFromLoopToStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_reLoopFromLoopToStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x060208C5 RID: 133317 RVA: 0x0094952F File Offset: 0x0094772F
		// (set) Token: 0x060208C6 RID: 133318 RVA: 0x0094953F File Offset: 0x0094773F
		public unsafe bool bForceEnterLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bForceEnterLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bForceEnterLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x060208C7 RID: 133319 RVA: 0x00949550 File Offset: 0x00947750
		// (set) Token: 0x060208C8 RID: 133320 RVA: 0x00949560 File Offset: 0x00947760
		public unsafe bool bInstantAttributeBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bInstantAttributeBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bInstantAttributeBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x060208C9 RID: 133321 RVA: 0x00949571 File Offset: 0x00947771
		// (set) Token: 0x060208CA RID: 133322 RVA: 0x00949581 File Offset: 0x00947781
		public unsafe bool bTriggerElementEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bTriggerElementEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_PerformanceRole_C.__PropertyOffset_bTriggerElementEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x060208CB RID: 133323 RVA: 0x00949594 File Offset: 0x00947794
		[SkipLocalsInit]
		public unsafe virtual void TriggerElementEnd(bool bTrigger)
		{
			ABP_PerformanceRole_C.__TriggerElementEnd_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__TriggerElementEnd_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_PerformanceRole_C.__TriggerElementEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__TriggerElementEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bTrigger = bTrigger;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__TriggerElementEnd_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208CC RID: 133324 RVA: 0x009495DC File Offset: 0x009477DC
		[SkipLocalsInit]
		public unsafe virtual void SetInstantAttributeBlend(bool bInstant)
		{
			ABP_PerformanceRole_C.__SetInstantAttributeBlend_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__SetInstantAttributeBlend_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_PerformanceRole_C.__SetInstantAttributeBlend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__SetInstantAttributeBlend_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInstant = bInstant;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SetInstantAttributeBlend_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208CD RID: 133325 RVA: 0x00949622 File Offset: 0x00947822
		[SkipLocalsInit]
		public virtual void TryForceEnterLoop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__TryForceEnterLoop_NativeFunctionPtr, null);
		}

		// Token: 0x060208CE RID: 133326 RVA: 0x00949638 File Offset: 0x00947838
		[SkipLocalsInit]
		public unsafe virtual void Set_Current_State(EPerformanceRoleState state)
		{
			ABP_PerformanceRole_C.__Set_Current_State_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__Set_Current_State_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_PerformanceRole_C.__Set_Current_State_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__Set_Current_State_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__Set_Current_State_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208CF RID: 133327 RVA: 0x00949684 File Offset: 0x00947884
		[SkipLocalsInit]
		public unsafe virtual bool Is_Same_State(EPerformanceRoleState NewState, in EPerformanceRoleState StateInternal)
		{
			ABP_PerformanceRole_C.__Is_Same_State_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__Is_Same_State_FunctionParams[(UIntPtr)21] + 15L / (long)sizeof(ABP_PerformanceRole_C.__Is_Same_State_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__Is_Same_State_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewState = NewState;
			ptr->StateInternal = (EPerformanceRoleState)StateInternal;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__Is_Same_State_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060208D0 RID: 133328 RVA: 0x009496E2 File Offset: 0x009478E2
		[SkipLocalsInit]
		public virtual void UpdateBlinkInfo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateBlinkInfo_NativeFunctionPtr, null);
		}

		// Token: 0x060208D1 RID: 133329 RVA: 0x009496F6 File Offset: 0x009478F6
		[SkipLocalsInit]
		public virtual void SkillRotate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SkillRotate_NativeFunctionPtr, null);
		}

		// Token: 0x060208D2 RID: 133330 RVA: 0x0094970C File Offset: 0x0094790C
		[SkipLocalsInit]
		public unsafe virtual void GetIsLooping(ref bool isLooping)
		{
			ABP_PerformanceRole_C.__GetIsLooping_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__GetIsLooping_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_PerformanceRole_C.__GetIsLooping_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__GetIsLooping_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isLooping = isLooping;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__GetIsLooping_NativeFunctionPtr, (void*)ptr);
			isLooping = ptr->isLooping;
		}

		// Token: 0x060208D3 RID: 133331 RVA: 0x0094975B File Offset: 0x0094795B
		[SkipLocalsInit]
		public virtual void ClearCreateRoleState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__ClearCreateRoleState_NativeFunctionPtr, null);
		}

		// Token: 0x060208D4 RID: 133332 RVA: 0x0094976F File Offset: 0x0094796F
		[SkipLocalsInit]
		public virtual void UpdateCreateRoleLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateCreateRoleLocation_NativeFunctionPtr, null);
		}

		// Token: 0x060208D5 RID: 133333 RVA: 0x00949784 File Offset: 0x00947984
		[SkipLocalsInit]
		public unsafe virtual void DebugLine(FVector LineStart, FVector LineEnd, FLinearColor LineColor)
		{
			ABP_PerformanceRole_C.__DebugLine_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__DebugLine_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(ABP_PerformanceRole_C.__DebugLine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__DebugLine_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LineStart = LineStart;
			ptr->LineEnd = LineEnd;
			ptr->LineColor = LineColor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__DebugLine_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208D6 RID: 133334 RVA: 0x009497D8 File Offset: 0x009479D8
		[SkipLocalsInit]
		public virtual void UpdateLookAtRotation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateLookAtRotation_NativeFunctionPtr, null);
		}

		// Token: 0x060208D7 RID: 133335 RVA: 0x009497EC File Offset: 0x009479EC
		[SkipLocalsInit]
		public virtual void UpdatePerfromTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdatePerfromTime_NativeFunctionPtr, null);
		}

		// Token: 0x060208D8 RID: 133336 RVA: 0x00949800 File Offset: 0x00947A00
		[SkipLocalsInit]
		public unsafe virtual void SetPerformDelay(float PerformTime)
		{
			ABP_PerformanceRole_C.__SetPerformDelay_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__SetPerformDelay_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PerformanceRole_C.__SetPerformDelay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__SetPerformDelay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PerformTime = PerformTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SetPerformDelay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208D9 RID: 133337 RVA: 0x00949848 File Offset: 0x00947A48
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void SyncAnimInstance(ABP_PerformanceRole_C SourceAnimInstance)
		{
			ABP_PerformanceRole_C.__SyncAnimInstance_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__SyncAnimInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_PerformanceRole_C.__SyncAnimInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__SyncAnimInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SourceAnimInstance = ((SourceAnimInstance != null) ? SourceAnimInstance.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__SyncAnimInstance_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208DA RID: 133338 RVA: 0x0094989D File Offset: 0x00947A9D
		[SkipLocalsInit]
		public virtual void UpdateHeadRotator()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__UpdateHeadRotator_NativeFunctionPtr, null);
		}

		// Token: 0x060208DB RID: 133339 RVA: 0x009498B4 File Offset: 0x00947AB4
		[SkipLocalsInit]
		public unsafe virtual float GetHeadApha()
		{
			ABP_PerformanceRole_C.__GetHeadApha_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__GetHeadApha_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_PerformanceRole_C.__GetHeadApha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__GetHeadApha_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__GetHeadApha_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060208DC RID: 133340 RVA: 0x009498FC File Offset: 0x00947AFC
		[SkipLocalsInit]
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

		// Token: 0x060208DD RID: 133341 RVA: 0x00949960 File Offset: 0x00947B60
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208DE RID: 133342 RVA: 0x009499A8 File Offset: 0x00947BA8
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208DF RID: 133343 RVA: 0x009499EE File Offset: 0x00947BEE
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x060208E0 RID: 133344 RVA: 0x00949A02 File Offset: 0x00947C02
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_PerformanceRole_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x060208E1 RID: 133345 RVA: 0x00949A16 File Offset: 0x00947C16
		protected ABP_PerformanceRole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011948 RID: 72008
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C";

		// Token: 0x04011949 RID: 72009
		private static IntPtr _ClassPtr;

		// Token: 0x0401194A RID: 72010
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401194B RID: 72011
		public static IntPtr __OnEffectEnd__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401194C RID: 72012
		public static IntPtr __OnEffectBegin__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401194D RID: 72013
		internal static int __PropertyOffset_StateInternal;

		// Token: 0x0401194E RID: 72014
		internal static int __PropertyOffset_reLoop;

		// Token: 0x0401194F RID: 72015
		internal static int __PropertyOffset_bForceChange;

		// Token: 0x04011950 RID: 72016
		internal static int __PropertyOffset_Delta_Time_X;

		// Token: 0x04011951 RID: 72017
		internal static int __PropertyOffset_HeadAlpha;

		// Token: 0x04011952 RID: 72018
		internal static int __PropertyOffset_OnEffectBegin;

		// Token: 0x04011953 RID: 72019
		[Nullable(2)]
		private OnEffectBegin _OnEffectBegin;

		// Token: 0x04011954 RID: 72020
		internal static int __PropertyOffset_OnEffectEnd;

		// Token: 0x04011955 RID: 72021
		[Nullable(2)]
		private OnEffectEnd _OnEffectEnd;

		// Token: 0x04011956 RID: 72022
		internal static int __PropertyOffset_PerformDelay;

		// Token: 0x04011957 RID: 72023
		internal static int __PropertyOffset_CurPerformTime;

		// Token: 0x04011958 RID: 72024
		internal static int __PropertyOffset_bForceChange_Perform;

		// Token: 0x04011959 RID: 72025
		internal static int __PropertyOffset_CacheViewportSize;

		// Token: 0x0401195A RID: 72026
		internal static int __PropertyOffset_LookAtWorld_Position;

		// Token: 0x0401195B RID: 72027
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0401195C RID: 72028
		internal static int __PropertyOffset_LookAtDirection;

		// Token: 0x0401195D RID: 72029
		internal static int __PropertyOffset_IsCreateRoleState;

		// Token: 0x0401195E RID: 72030
		internal static int __PropertyOffset_CreateRoleStartLocation;

		// Token: 0x0401195F RID: 72031
		internal static int __PropertyOffset_CreateRoleEndLocation;

		// Token: 0x04011960 RID: 72032
		internal static int __PropertyOffset_CreateRoleMoveAllTime;

		// Token: 0x04011961 RID: 72033
		internal static int __PropertyOffset_Actor;

		// Token: 0x04011962 RID: 72034
		internal static int __PropertyOffset_CreateRoleMoveCurrentTime;

		// Token: 0x04011963 RID: 72035
		internal static int __PropertyOffset_CreateRoleStartRotation;

		// Token: 0x04011964 RID: 72036
		internal static int __PropertyOffset_CreateRoleEndLocationOffset;

		// Token: 0x04011965 RID: 72037
		internal static int __PropertyOffset_CreateRoleEndRotation;

		// Token: 0x04011966 RID: 72038
		internal static int __PropertyOffset_CreateRoleEndRotationOffset;

		// Token: 0x04011967 RID: 72039
		internal static int __PropertyOffset_CreateRoleMovePlayRate;

		// Token: 0x04011968 RID: 72040
		internal static int __PropertyOffset_HasInitCreateRoleInfo;

		// Token: 0x04011969 RID: 72041
		internal static int __PropertyOffset_isLooping;

		// Token: 0x0401196A RID: 72042
		internal static int __PropertyOffset_bInitCreateRoleInfo;

		// Token: 0x0401196B RID: 72043
		internal static int __PropertyOffset_InSkillRotate;

		// Token: 0x0401196C RID: 72044
		internal static int __PropertyOffset_InSkillEndRotate;

		// Token: 0x0401196D RID: 72045
		internal static int __PropertyOffset_TempRotate;

		// Token: 0x0401196E RID: 72046
		internal static int __PropertyOffset_BlinkAlpha;

		// Token: 0x0401196F RID: 72047
		internal static int __PropertyOffset_InBlinking;

		// Token: 0x04011970 RID: 72048
		internal static int __PropertyOffset_BlinkEndTime;

		// Token: 0x04011971 RID: 72049
		internal static int __PropertyOffset_眨眼动画时长;

		// Token: 0x04011972 RID: 72050
		internal static int __PropertyOffset_此轮眨眼动画总时长;

		// Token: 0x04011973 RID: 72051
		internal static int __PropertyOffset_SameStateArray01;

		// Token: 0x04011974 RID: 72052
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EPerformanceRoleState>> _SameStateArray01;

		// Token: 0x04011975 RID: 72053
		internal static int __PropertyOffset_False;

		// Token: 0x04011976 RID: 72054
		internal static int __PropertyOffset_DirectEnterLoop;

		// Token: 0x04011977 RID: 72055
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x04011978 RID: 72056
		internal static int __PropertyOffset_reLoopFromLoopToStart;

		// Token: 0x04011979 RID: 72057
		internal static int __PropertyOffset_bForceEnterLoop;

		// Token: 0x0401197A RID: 72058
		internal static int __PropertyOffset_bInstantAttributeBlend;

		// Token: 0x0401197B RID: 72059
		internal static int __PropertyOffset_bTriggerElementEnd;

		// Token: 0x0401197C RID: 72060
		private static IntPtr __TriggerElementEnd_NativeFunctionPtr;

		// Token: 0x0401197D RID: 72061
		private static IntPtr __SetInstantAttributeBlend_NativeFunctionPtr;

		// Token: 0x0401197E RID: 72062
		private static IntPtr __TryForceEnterLoop_NativeFunctionPtr;

		// Token: 0x0401197F RID: 72063
		private static IntPtr __Set_Current_State_NativeFunctionPtr;

		// Token: 0x04011980 RID: 72064
		private static IntPtr __Is_Same_State_NativeFunctionPtr;

		// Token: 0x04011981 RID: 72065
		private static IntPtr __UpdateBlinkInfo_NativeFunctionPtr;

		// Token: 0x04011982 RID: 72066
		private static IntPtr __SkillRotate_NativeFunctionPtr;

		// Token: 0x04011983 RID: 72067
		private static IntPtr __GetIsLooping_NativeFunctionPtr;

		// Token: 0x04011984 RID: 72068
		private static IntPtr __ClearCreateRoleState_NativeFunctionPtr;

		// Token: 0x04011985 RID: 72069
		private static IntPtr __UpdateCreateRoleLocation_NativeFunctionPtr;

		// Token: 0x04011986 RID: 72070
		private static IntPtr __DebugLine_NativeFunctionPtr;

		// Token: 0x04011987 RID: 72071
		private static IntPtr __UpdateLookAtRotation_NativeFunctionPtr;

		// Token: 0x04011988 RID: 72072
		private static IntPtr __UpdatePerfromTime_NativeFunctionPtr;

		// Token: 0x04011989 RID: 72073
		private static IntPtr __SetPerformDelay_NativeFunctionPtr;

		// Token: 0x0401198A RID: 72074
		private static IntPtr __SyncAnimInstance_NativeFunctionPtr;

		// Token: 0x0401198B RID: 72075
		private static IntPtr __UpdateHeadRotator_NativeFunctionPtr;

		// Token: 0x0401198C RID: 72076
		private static IntPtr __GetHeadApha_NativeFunctionPtr;

		// Token: 0x0401198D RID: 72077
		private static IntPtr __SetState_NativeFunctionPtr;

		// Token: 0x0401198E RID: 72078
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0401198F RID: 72079
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x02008F88 RID: 36744
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __TriggerElementEnd_FunctionParams
		{
			// Token: 0x0402CD20 RID: 183584
			[FieldOffset(0)]
			public bool bTrigger;
		}

		// Token: 0x02008F89 RID: 36745
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetInstantAttributeBlend_FunctionParams
		{
			// Token: 0x0402CD21 RID: 183585
			[FieldOffset(0)]
			public bool bInstant;
		}

		// Token: 0x02008F8A RID: 36746
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __Set_Current_State_FunctionParams
		{
			// Token: 0x0402CD22 RID: 183586
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> state;
		}

		// Token: 0x02008F8B RID: 36747
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 6)]
		protected ref struct __Is_Same_State_FunctionParams
		{
			// Token: 0x0402CD23 RID: 183587
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> NewState;

			// Token: 0x0402CD24 RID: 183588
			[FieldOffset(1)]
			public TEnumAsByte<EPerformanceRoleState> StateInternal;

			// Token: 0x0402CD25 RID: 183589
			[FieldOffset(2)]
			public bool __Result;
		}

		// Token: 0x02008F8C RID: 36748
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetIsLooping_FunctionParams
		{
			// Token: 0x0402CD26 RID: 183590
			[FieldOffset(0)]
			public bool isLooping;
		}

		// Token: 0x02008F8D RID: 36749
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __DebugLine_FunctionParams
		{
			// Token: 0x0402CD27 RID: 183591
			[FieldOffset(0)]
			public FVector LineStart;

			// Token: 0x0402CD28 RID: 183592
			[FieldOffset(12)]
			public FVector LineEnd;

			// Token: 0x0402CD29 RID: 183593
			[FieldOffset(24)]
			public FLinearColor LineColor;
		}

		// Token: 0x02008F8E RID: 36750
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPerformDelay_FunctionParams
		{
			// Token: 0x0402CD2A RID: 183594
			[FieldOffset(0)]
			public float PerformTime;
		}

		// Token: 0x02008F8F RID: 36751
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SyncAnimInstance_FunctionParams
		{
			// Token: 0x0402CD2B RID: 183595
			[FieldOffset(0)]
			public IntPtr SourceAnimInstance;
		}

		// Token: 0x02008F90 RID: 36752
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetHeadApha_FunctionParams
		{
			// Token: 0x0402CD2C RID: 183596
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02008F91 RID: 36753
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 14)]
		protected ref struct __SetState_FunctionParams
		{
			// Token: 0x0402CD2D RID: 183597
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> State;

			// Token: 0x0402CD2E RID: 183598
			[FieldOffset(1)]
			public bool reLoop;

			// Token: 0x0402CD2F RID: 183599
			[FieldOffset(2)]
			public bool reLoopFromLoopToStart;

			// Token: 0x0402CD30 RID: 183600
			[FieldOffset(3)]
			public bool WaitLaseStateEnd;
		}

		// Token: 0x02008F92 RID: 36754
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD31 RID: 183601
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
