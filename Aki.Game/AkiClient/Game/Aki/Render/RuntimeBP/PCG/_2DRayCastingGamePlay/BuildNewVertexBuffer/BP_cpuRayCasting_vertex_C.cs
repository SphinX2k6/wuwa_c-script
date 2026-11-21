using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG._2DRayCastingGamePlay.BuildNewVertexBuffer
{
	// Token: 0x020030EC RID: 12524
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/BP_cpuRayCasting_vertex.BP_cpuRayCasting_vertex_C")]
	[UnrealStructLayout(2128, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2120)]
	public class BP_cpuRayCasting_vertex_C : AHexagonConsumer, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E554 RID: 124244 RVA: 0x0091164F File Offset: 0x0090F84F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_cpuRayCasting_vertex_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/BP_cpuRayCasting_vertex.BP_cpuRayCasting_vertex_C");
			}
			return BP_cpuRayCasting_vertex_C._ClassPtr;
		}

		// Token: 0x0601E555 RID: 124245 RVA: 0x00911674 File Offset: 0x0090F874
		public BP_cpuRayCasting_vertex_C() : this(BuiltinUtils.AllocNativeUObject(BP_cpuRayCasting_vertex_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E556 RID: 124246 RVA: 0x0091169C File Offset: 0x0090F89C
		[NullableContext(1)]
		public BP_cpuRayCasting_vertex_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_cpuRayCasting_vertex_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0601E557 RID: 124247 RVA: 0x009116CF File Offset: 0x0090F8CF
		// (set) Token: 0x0601E558 RID: 124248 RVA: 0x009116E3 File Offset: 0x0090F8E3
		public unsafe UStaticMeshComponent Plane1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_Plane1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_Plane1, value);
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0601E559 RID: 124249 RVA: 0x009116F8 File Offset: 0x0090F8F8
		// (set) Token: 0x0601E55A RID: 124250 RVA: 0x0091170C File Offset: 0x0090F90C
		public unsafe UBoxComponent Box_Collision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_Box_Collision);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_Box_Collision, value);
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0601E55B RID: 124251 RVA: 0x00911724 File Offset: 0x0090F924
		// (set) Token: 0x0601E55C RID: 124252 RVA: 0x0091175D File Offset: 0x0090F95D
		[Nullable(1)]
		public TArray<FVector> EndPos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._EndPos) == null)
				{
					result = (this._EndPos = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_EndPos, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EndPos.CopyAssign(value);
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0601E55D RID: 124253 RVA: 0x0091176B File Offset: 0x0090F96B
		// (set) Token: 0x0601E55E RID: 124254 RVA: 0x0091177B File Offset: 0x0090F97B
		public unsafe float RayCastingDetectDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RayCastingDetectDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RayCastingDetectDis) = value;
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0601E55F RID: 124255 RVA: 0x0091178C File Offset: 0x0090F98C
		// (set) Token: 0x0601E560 RID: 124256 RVA: 0x0091179C File Offset: 0x0090F99C
		public unsafe int CountIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_CountIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_CountIndex) = value;
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0601E561 RID: 124257 RVA: 0x009117B0 File Offset: 0x0090F9B0
		// (set) Token: 0x0601E562 RID: 124258 RVA: 0x009117E9 File Offset: 0x0090F9E9
		[Nullable(1)]
		public TArray<FVector> Vertices
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Vertices, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0601E563 RID: 124259 RVA: 0x009117F8 File Offset: 0x0090F9F8
		// (set) Token: 0x0601E564 RID: 124260 RVA: 0x00911831 File Offset: 0x0090FA31
		[Nullable(1)]
		public TArray<int> triangles
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._triangles) == null)
				{
					result = (this._triangles = new TArray<int>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_triangles, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.triangles.CopyAssign(value);
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0601E565 RID: 124261 RVA: 0x00911840 File Offset: 0x0090FA40
		// (set) Token: 0x0601E566 RID: 124262 RVA: 0x00911879 File Offset: 0x0090FA79
		[Nullable(1)]
		public FSoftObjectPath EffectNormal
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EffectNormal) == null)
				{
					result = (this._EffectNormal = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_EffectNormal, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_EffectNormal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0601E567 RID: 124263 RVA: 0x0091189A File Offset: 0x0090FA9A
		// (set) Token: 0x0601E568 RID: 124264 RVA: 0x009118AA File Offset: 0x0090FAAA
		public unsafe bool stopMeshing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_stopMeshing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_stopMeshing) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0601E569 RID: 124265 RVA: 0x009118BB File Offset: 0x0090FABB
		// (set) Token: 0x0601E56A RID: 124266 RVA: 0x009118CF File Offset: 0x0090FACF
		public unsafe FRotator RayStartoRatation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RayStartoRatation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RayStartoRatation) = value;
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0601E56B RID: 124267 RVA: 0x009118E4 File Offset: 0x0090FAE4
		// (set) Token: 0x0601E56C RID: 124268 RVA: 0x009118F4 File Offset: 0x0090FAF4
		public unsafe int BatchSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_BatchSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_BatchSize) = value;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0601E56D RID: 124269 RVA: 0x00911905 File Offset: 0x0090FB05
		// (set) Token: 0x0601E56E RID: 124270 RVA: 0x00911915 File Offset: 0x0090FB15
		public unsafe bool PlayerColOnOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_PlayerColOnOrNot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_PlayerColOnOrNot) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0601E56F RID: 124271 RVA: 0x00911926 File Offset: 0x0090FB26
		// (set) Token: 0x0601E570 RID: 124272 RVA: 0x00911936 File Offset: 0x0090FB36
		public unsafe bool drawdebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_drawdebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_drawdebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0601E571 RID: 124273 RVA: 0x00911947 File Offset: 0x0090FB47
		// (set) Token: 0x0601E572 RID: 124274 RVA: 0x00911957 File Offset: 0x0090FB57
		public unsafe bool motionOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_motionOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_motionOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0601E573 RID: 124275 RVA: 0x00911968 File Offset: 0x0090FB68
		// (set) Token: 0x0601E574 RID: 124276 RVA: 0x0091197C File Offset: 0x0090FB7C
		public unsafe FVector C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_C);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_C) = value;
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0601E575 RID: 124277 RVA: 0x00911991 File Offset: 0x0090FB91
		// (set) Token: 0x0601E576 RID: 124278 RVA: 0x009119A1 File Offset: 0x0090FBA1
		public unsafe float R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_R);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_R) = value;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0601E577 RID: 124279 RVA: 0x009119B2 File Offset: 0x0090FBB2
		// (set) Token: 0x0601E578 RID: 124280 RVA: 0x009119C2 File Offset: 0x0090FBC2
		public unsafe float dA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_dA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_dA) = value;
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0601E579 RID: 124281 RVA: 0x009119D3 File Offset: 0x0090FBD3
		// (set) Token: 0x0601E57A RID: 124282 RVA: 0x009119E3 File Offset: 0x0090FBE3
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0601E57B RID: 124283 RVA: 0x009119F4 File Offset: 0x0090FBF4
		// (set) Token: 0x0601E57C RID: 124284 RVA: 0x00911A04 File Offset: 0x0090FC04
		public unsafe float debugangle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_debugangle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_debugangle) = value;
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0601E57D RID: 124285 RVA: 0x00911A15 File Offset: 0x0090FC15
		// (set) Token: 0x0601E57E RID: 124286 RVA: 0x00911A25 File Offset: 0x0090FC25
		public unsafe int debugdir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_debugdir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_debugdir) = value;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0601E57F RID: 124287 RVA: 0x00911A36 File Offset: 0x0090FC36
		// (set) Token: 0x0601E580 RID: 124288 RVA: 0x00911A46 File Offset: 0x0090FC46
		public unsafe float BoundingBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_BoundingBoxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_BoundingBoxSize) = value;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0601E581 RID: 124289 RVA: 0x00911A58 File Offset: 0x0090FC58
		// (set) Token: 0x0601E582 RID: 124290 RVA: 0x00911A91 File Offset: 0x0090FC91
		[Nullable(1)]
		public TArray<AActor> IgnoreActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._IgnoreActors) == null)
				{
					result = (this._IgnoreActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_IgnoreActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IgnoreActors.CopyAssign(value);
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0601E583 RID: 124291 RVA: 0x00911A9F File Offset: 0x0090FC9F
		// (set) Token: 0x0601E584 RID: 124292 RVA: 0x00911AAF File Offset: 0x0090FCAF
		public unsafe double Max_Degree_Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Max_Degree_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Max_Degree_Angle) = value;
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0601E585 RID: 124293 RVA: 0x00911AC0 File Offset: 0x0090FCC0
		// (set) Token: 0x0601E586 RID: 124294 RVA: 0x00911AD0 File Offset: 0x0090FCD0
		public unsafe double Return_Speed_Degrees_Second
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Return_Speed_Degrees_Second);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Return_Speed_Degrees_Second) = value;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0601E587 RID: 124295 RVA: 0x00911AE1 File Offset: 0x0090FCE1
		// (set) Token: 0x0601E588 RID: 124296 RVA: 0x00911AF1 File Offset: 0x0090FCF1
		public unsafe double Follow_Speed_Degrees_Second
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Follow_Speed_Degrees_Second);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Follow_Speed_Degrees_Second) = value;
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0601E589 RID: 124297 RVA: 0x00911B02 File Offset: 0x0090FD02
		// (set) Token: 0x0601E58A RID: 124298 RVA: 0x00911B12 File Offset: 0x0090FD12
		public unsafe double Min_Active_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Min_Active_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Min_Active_Radius) = value;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0601E58B RID: 124299 RVA: 0x00911B23 File Offset: 0x0090FD23
		// (set) Token: 0x0601E58C RID: 124300 RVA: 0x00911B33 File Offset: 0x0090FD33
		public unsafe double Max_Active_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Max_Active_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Max_Active_Radius) = value;
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0601E58D RID: 124301 RVA: 0x00911B44 File Offset: 0x0090FD44
		// (set) Token: 0x0601E58E RID: 124302 RVA: 0x00911B54 File Offset: 0x0090FD54
		public unsafe bool Enable跷跷板
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Enable跷跷板) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_Enable跷跷板) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0601E58F RID: 124303 RVA: 0x00911B65 File Offset: 0x0090FD65
		// (set) Token: 0x0601E590 RID: 124304 RVA: 0x00911B75 File Offset: 0x0090FD75
		public unsafe float RayCastingDetectMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RayCastingDetectMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RayCastingDetectMax) = value;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0601E591 RID: 124305 RVA: 0x00911B86 File Offset: 0x0090FD86
		// (set) Token: 0x0601E592 RID: 124306 RVA: 0x00911B9A File Offset: 0x0090FD9A
		public unsafe FVector startWorldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_startWorldPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_startWorldPos) = value;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0601E593 RID: 124307 RVA: 0x00911BAF File Offset: 0x0090FDAF
		// (set) Token: 0x0601E594 RID: 124308 RVA: 0x00911BBF File Offset: 0x0090FDBF
		public unsafe bool DebugMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_DebugMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_DebugMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0601E595 RID: 124309 RVA: 0x00911BD0 File Offset: 0x0090FDD0
		// (set) Token: 0x0601E596 RID: 124310 RVA: 0x00911BE0 File Offset: 0x0090FDE0
		public unsafe bool bEditorT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_bEditorT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_bEditorT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0601E597 RID: 124311 RVA: 0x00911BF1 File Offset: 0x0090FDF1
		// (set) Token: 0x0601E598 RID: 124312 RVA: 0x00911C01 File Offset: 0x0090FE01
		public unsafe bool bdebugTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_bdebugTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_bdebugTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0601E599 RID: 124313 RVA: 0x00911C12 File Offset: 0x0090FE12
		// (set) Token: 0x0601E59A RID: 124314 RVA: 0x00911C26 File Offset: 0x0090FE26
		public unsafe UTextureRenderTarget2D cap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_cap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_cap, value);
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0601E59B RID: 124315 RVA: 0x00911C3B File Offset: 0x0090FE3B
		// (set) Token: 0x0601E59C RID: 124316 RVA: 0x00911C4F File Offset: 0x0090FE4F
		public unsafe UTextureRenderTarget2D final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_final);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_final, value);
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0601E59D RID: 124317 RVA: 0x00911C64 File Offset: 0x0090FE64
		// (set) Token: 0x0601E59E RID: 124318 RVA: 0x00911C78 File Offset: 0x0090FE78
		public unsafe UMaterialInstanceDynamic DMat_add
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_DMat_add);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_DMat_add, value);
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0601E59F RID: 124319 RVA: 0x00911C8D File Offset: 0x0090FE8D
		// (set) Token: 0x0601E5A0 RID: 124320 RVA: 0x00911CA1 File Offset: 0x0090FEA1
		public unsafe UMaterialInstanceDynamic DMat_preview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_DMat_preview);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_DMat_preview, value);
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0601E5A1 RID: 124321 RVA: 0x00911CB6 File Offset: 0x0090FEB6
		// (set) Token: 0x0601E5A2 RID: 124322 RVA: 0x00911CCA File Offset: 0x0090FECA
		public unsafe UMaterialInstanceDynamic DMat_preview_ice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_DMat_preview_ice);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_DMat_preview_ice, value);
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0601E5A3 RID: 124323 RVA: 0x00911CDF File Offset: 0x0090FEDF
		// (set) Token: 0x0601E5A4 RID: 124324 RVA: 0x00911CEF File Offset: 0x0090FEEF
		public unsafe bool DoNotNeedRayCasting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_DoNotNeedRayCasting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_DoNotNeedRayCasting) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0601E5A5 RID: 124325 RVA: 0x00911D00 File Offset: 0x0090FF00
		// (set) Token: 0x0601E5A6 RID: 124326 RVA: 0x00911D10 File Offset: 0x0090FF10
		public unsafe int RTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RTSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_RTSize) = value;
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0601E5A7 RID: 124327 RVA: 0x00911D21 File Offset: 0x0090FF21
		// (set) Token: 0x0601E5A8 RID: 124328 RVA: 0x00911D31 File Offset: 0x0090FF31
		public unsafe bool 是不是冰封状态_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_是不是冰封状态_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_是不是冰封状态_) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0601E5A9 RID: 124329 RVA: 0x00911D42 File Offset: 0x0090FF42
		// (set) Token: 0x0601E5AA RID: 124330 RVA: 0x00911D52 File Offset: 0x0090FF52
		public unsafe bool 锁定碰撞体模式_跷跷板直接关闭_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_锁定碰撞体模式_跷跷板直接关闭_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_锁定碰撞体模式_跷跷板直接关闭_) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0601E5AB RID: 124331 RVA: 0x00911D63 File Offset: 0x0090FF63
		// (set) Token: 0x0601E5AC RID: 124332 RVA: 0x00911D73 File Offset: 0x0090FF73
		public unsafe bool 多个光片模式_玩家离开立刻停止跷跷板_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_多个光片模式_玩家离开立刻停止跷跷板_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_多个光片模式_玩家离开立刻停止跷跷板_) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0601E5AD RID: 124333 RVA: 0x00911D84 File Offset: 0x0090FF84
		// (set) Token: 0x0601E5AE RID: 124334 RVA: 0x00911D98 File Offset: 0x0090FF98
		public unsafe FTransform startTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_startTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_startTransform) = value;
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0601E5AF RID: 124335 RVA: 0x00911DAD File Offset: 0x0090FFAD
		// (set) Token: 0x0601E5B0 RID: 124336 RVA: 0x00911DBD File Offset: 0x0090FFBD
		public unsafe float LastFrameRayCastingDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_LastFrameRayCastingDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_LastFrameRayCastingDis) = value;
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0601E5B1 RID: 124337 RVA: 0x00911DCE File Offset: 0x0090FFCE
		// (set) Token: 0x0601E5B2 RID: 124338 RVA: 0x00911DDE File Offset: 0x0090FFDE
		public unsafe bool LastFrame_是不是冰封状态_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_LastFrame_是不是冰封状态_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_LastFrame_是不是冰封状态_) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0601E5B3 RID: 124339 RVA: 0x00911DEF File Offset: 0x0090FFEF
		// (set) Token: 0x0601E5B4 RID: 124340 RVA: 0x00911E03 File Offset: 0x00910003
		public unsafe AStaticMeshActor actorBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_actorBox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_actorBox, value);
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0601E5B5 RID: 124341 RVA: 0x00911E18 File Offset: 0x00910018
		// (set) Token: 0x0601E5B6 RID: 124342 RVA: 0x00911E51 File Offset: 0x00910051
		[Nullable(1)]
		public TArray<FVector> SkipTraceBoxOrigins
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._SkipTraceBoxOrigins) == null)
				{
					result = (this._SkipTraceBoxOrigins = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_SkipTraceBoxOrigins, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkipTraceBoxOrigins.CopyAssign(value);
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0601E5B7 RID: 124343 RVA: 0x00911E60 File Offset: 0x00910060
		// (set) Token: 0x0601E5B8 RID: 124344 RVA: 0x00911E99 File Offset: 0x00910099
		[Nullable(1)]
		public TArray<FVector> SkipTraceBoxExtent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._SkipTraceBoxExtent) == null)
				{
					result = (this._SkipTraceBoxExtent = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_SkipTraceBoxExtent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkipTraceBoxExtent.CopyAssign(value);
			}
		}

		// Token: 0x0601E5B9 RID: 124345 RVA: 0x00911EA8 File Offset: 0x009100A8
		[SkipLocalsInit]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_cpuRayCasting_vertex_C.__GetHandle_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x0601E5BA RID: 124346 RVA: 0x00911EF7 File Offset: 0x009100F7
		[SkipLocalsInit]
		public virtual void boxcollisionConst()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__boxcollisionConst_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5BB RID: 124347 RVA: 0x00911F0C File Offset: 0x0091010C
		[SkipLocalsInit]
		public unsafe virtual void Rotate_Plane_by_Player(bool OnPlaneOrNot, bool StopPlaneReturn)
		{
			BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_FunctionParams[(UIntPtr)1551] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OnPlaneOrNot = OnPlaneOrNot;
			ptr->StopPlaneReturn = StopPlaneReturn;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E5BC RID: 124348 RVA: 0x00911F5C File Offset: 0x0091015C
		[SkipLocalsInit]
		public unsafe virtual void DebugMovement(float dt)
		{
			BP_cpuRayCasting_vertex_C.__DebugMovement_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__DebugMovement_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__DebugMovement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__DebugMovement_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__DebugMovement_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E5BD RID: 124349 RVA: 0x00911FA5 File Offset: 0x009101A5
		[SkipLocalsInit]
		public virtual void Init_All()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__Init_All_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5BE RID: 124350 RVA: 0x00911FB9 File Offset: 0x009101B9
		[SkipLocalsInit]
		public virtual void Init_Triangles()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__Init_Triangles_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5BF RID: 124351 RVA: 0x00911FCD File Offset: 0x009101CD
		[SkipLocalsInit]
		public virtual void initRay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__initRay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C0 RID: 124352 RVA: 0x00911FE1 File Offset: 0x009101E1
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C1 RID: 124353 RVA: 0x00911FF5 File Offset: 0x009101F5
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C2 RID: 124354 RVA: 0x00912009 File Offset: 0x00910209
		[SkipLocalsInit]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C3 RID: 124355 RVA: 0x0091201D File Offset: 0x0091021D
		[SkipLocalsInit]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C4 RID: 124356 RVA: 0x00912034 File Offset: 0x00910234
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E5C5 RID: 124357 RVA: 0x0091207C File Offset: 0x0091027C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E5C6 RID: 124358 RVA: 0x009120C2 File Offset: 0x009102C2
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C7 RID: 124359 RVA: 0x009120D6 File Offset: 0x009102D6
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C8 RID: 124360 RVA: 0x009120EA File Offset: 0x009102EA
		[SkipLocalsInit]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5C9 RID: 124361 RVA: 0x009120FE File Offset: 0x009102FE
		[SkipLocalsInit]
		public virtual void test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__test_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5CA RID: 124362 RVA: 0x00912112 File Offset: 0x00910312
		[SkipLocalsInit]
		public virtual void SeveralLightPlane()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SeveralLightPlane_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5CB RID: 124363 RVA: 0x00912126 File Offset: 0x00910326
		[SkipLocalsInit]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5CC RID: 124364 RVA: 0x0091213A File Offset: 0x0091033A
		[SkipLocalsInit]
		public virtual void SaveBoxToBp()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SaveBoxToBp_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5CD RID: 124365 RVA: 0x00912150 File Offset: 0x00910350
		[SkipLocalsInit]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_cpuRayCasting_vertex_C.__SetHandle_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E5CE RID: 124366 RVA: 0x00912196 File Offset: 0x00910396
		[SkipLocalsInit]
		public virtual void SaveBoxArrToDA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SaveBoxArrToDA_NativeFunctionPtr, null);
		}

		// Token: 0x0601E5CF RID: 124367 RVA: 0x009121AA File Offset: 0x009103AA
		protected BP_cpuRayCasting_vertex_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100EF RID: 65775
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/BP_cpuRayCasting_vertex.BP_cpuRayCasting_vertex_C";

		// Token: 0x040100F0 RID: 65776
		private static IntPtr _ClassPtr;

		// Token: 0x040100F1 RID: 65777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100F2 RID: 65778
		internal static int __PropertyOffset_Plane1;

		// Token: 0x040100F3 RID: 65779
		internal static int __PropertyOffset_Box_Collision;

		// Token: 0x040100F4 RID: 65780
		internal static int __PropertyOffset_EndPos;

		// Token: 0x040100F5 RID: 65781
		private TArray<FVector> _EndPos;

		// Token: 0x040100F6 RID: 65782
		internal static int __PropertyOffset_RayCastingDetectDis;

		// Token: 0x040100F7 RID: 65783
		internal static int __PropertyOffset_CountIndex;

		// Token: 0x040100F8 RID: 65784
		internal static int __PropertyOffset_Vertices;

		// Token: 0x040100F9 RID: 65785
		private TArray<FVector> _Vertices;

		// Token: 0x040100FA RID: 65786
		internal static int __PropertyOffset_triangles;

		// Token: 0x040100FB RID: 65787
		private TArray<int> _triangles;

		// Token: 0x040100FC RID: 65788
		internal static int __PropertyOffset_EffectNormal;

		// Token: 0x040100FD RID: 65789
		private FSoftObjectPath _EffectNormal;

		// Token: 0x040100FE RID: 65790
		internal static int __PropertyOffset_stopMeshing;

		// Token: 0x040100FF RID: 65791
		internal static int __PropertyOffset_RayStartoRatation;

		// Token: 0x04010100 RID: 65792
		internal static int __PropertyOffset_BatchSize;

		// Token: 0x04010101 RID: 65793
		internal static int __PropertyOffset_PlayerColOnOrNot;

		// Token: 0x04010102 RID: 65794
		internal static int __PropertyOffset_drawdebug;

		// Token: 0x04010103 RID: 65795
		internal static int __PropertyOffset_motionOn;

		// Token: 0x04010104 RID: 65796
		internal static int __PropertyOffset_C;

		// Token: 0x04010105 RID: 65797
		internal static int __PropertyOffset_R;

		// Token: 0x04010106 RID: 65798
		internal static int __PropertyOffset_dA;

		// Token: 0x04010107 RID: 65799
		internal static int __PropertyOffset_A;

		// Token: 0x04010108 RID: 65800
		internal static int __PropertyOffset_debugangle;

		// Token: 0x04010109 RID: 65801
		internal static int __PropertyOffset_debugdir;

		// Token: 0x0401010A RID: 65802
		internal static int __PropertyOffset_BoundingBoxSize;

		// Token: 0x0401010B RID: 65803
		internal static int __PropertyOffset_IgnoreActors;

		// Token: 0x0401010C RID: 65804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _IgnoreActors;

		// Token: 0x0401010D RID: 65805
		internal static int __PropertyOffset_Max_Degree_Angle;

		// Token: 0x0401010E RID: 65806
		internal static int __PropertyOffset_Return_Speed_Degrees_Second;

		// Token: 0x0401010F RID: 65807
		internal static int __PropertyOffset_Follow_Speed_Degrees_Second;

		// Token: 0x04010110 RID: 65808
		internal static int __PropertyOffset_Min_Active_Radius;

		// Token: 0x04010111 RID: 65809
		internal static int __PropertyOffset_Max_Active_Radius;

		// Token: 0x04010112 RID: 65810
		internal static int __PropertyOffset_Enable跷跷板;

		// Token: 0x04010113 RID: 65811
		internal static int __PropertyOffset_RayCastingDetectMax;

		// Token: 0x04010114 RID: 65812
		internal static int __PropertyOffset_startWorldPos;

		// Token: 0x04010115 RID: 65813
		internal static int __PropertyOffset_DebugMove;

		// Token: 0x04010116 RID: 65814
		internal static int __PropertyOffset_bEditorT;

		// Token: 0x04010117 RID: 65815
		internal static int __PropertyOffset_bdebugTransform;

		// Token: 0x04010118 RID: 65816
		internal static int __PropertyOffset_cap;

		// Token: 0x04010119 RID: 65817
		internal static int __PropertyOffset_final;

		// Token: 0x0401011A RID: 65818
		internal static int __PropertyOffset_DMat_add;

		// Token: 0x0401011B RID: 65819
		internal static int __PropertyOffset_DMat_preview;

		// Token: 0x0401011C RID: 65820
		internal static int __PropertyOffset_DMat_preview_ice;

		// Token: 0x0401011D RID: 65821
		internal static int __PropertyOffset_DoNotNeedRayCasting;

		// Token: 0x0401011E RID: 65822
		internal static int __PropertyOffset_RTSize;

		// Token: 0x0401011F RID: 65823
		internal static int __PropertyOffset_是不是冰封状态_;

		// Token: 0x04010120 RID: 65824
		internal static int __PropertyOffset_锁定碰撞体模式_跷跷板直接关闭_;

		// Token: 0x04010121 RID: 65825
		internal static int __PropertyOffset_多个光片模式_玩家离开立刻停止跷跷板_;

		// Token: 0x04010122 RID: 65826
		internal static int __PropertyOffset_startTransform;

		// Token: 0x04010123 RID: 65827
		internal static int __PropertyOffset_LastFrameRayCastingDis;

		// Token: 0x04010124 RID: 65828
		internal static int __PropertyOffset_LastFrame_是不是冰封状态_;

		// Token: 0x04010125 RID: 65829
		internal static int __PropertyOffset_actorBox;

		// Token: 0x04010126 RID: 65830
		internal static int __PropertyOffset_SkipTraceBoxOrigins;

		// Token: 0x04010127 RID: 65831
		private TArray<FVector> _SkipTraceBoxOrigins;

		// Token: 0x04010128 RID: 65832
		internal static int __PropertyOffset_SkipTraceBoxExtent;

		// Token: 0x04010129 RID: 65833
		private TArray<FVector> _SkipTraceBoxExtent;

		// Token: 0x0401012A RID: 65834
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x0401012B RID: 65835
		private static IntPtr __boxcollisionConst_NativeFunctionPtr;

		// Token: 0x0401012C RID: 65836
		private static IntPtr __Rotate_Plane_by_Player_NativeFunctionPtr;

		// Token: 0x0401012D RID: 65837
		private static IntPtr __DebugMovement_NativeFunctionPtr;

		// Token: 0x0401012E RID: 65838
		private static IntPtr __Init_All_NativeFunctionPtr;

		// Token: 0x0401012F RID: 65839
		private static IntPtr __Init_Triangles_NativeFunctionPtr;

		// Token: 0x04010130 RID: 65840
		private static IntPtr __initRay_NativeFunctionPtr;

		// Token: 0x04010131 RID: 65841
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010132 RID: 65842
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x04010133 RID: 65843
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010134 RID: 65844
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010135 RID: 65845
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010136 RID: 65846
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x04010137 RID: 65847
		private static IntPtr __test_NativeFunctionPtr;

		// Token: 0x04010138 RID: 65848
		private static IntPtr __SeveralLightPlane_NativeFunctionPtr;

		// Token: 0x04010139 RID: 65849
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x0401013A RID: 65850
		private static IntPtr __SaveBoxToBp_NativeFunctionPtr;

		// Token: 0x0401013B RID: 65851
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x0401013C RID: 65852
		private static IntPtr __SaveBoxArrToDA_NativeFunctionPtr;

		// Token: 0x02008E68 RID: 36456
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x0402CAB4 RID: 182964
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008E69 RID: 36457
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1536)]
		protected ref struct __Rotate_Plane_by_Player_FunctionParams
		{
			// Token: 0x0402CAB5 RID: 182965
			[FieldOffset(0)]
			public bool OnPlaneOrNot;

			// Token: 0x0402CAB6 RID: 182966
			[FieldOffset(1)]
			public bool StopPlaneReturn;
		}

		// Token: 0x02008E6A RID: 36458
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __DebugMovement_FunctionParams
		{
			// Token: 0x0402CAB7 RID: 182967
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02008E6B RID: 36459
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAB8 RID: 182968
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E6C RID: 36460
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x0402CAB9 RID: 182969
			[FieldOffset(0)]
			public int Handle;
		}
	}
}
