using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUGrassInteraction
{
	// Token: 0x02003CA5 RID: 15525
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/BP_GPUFoliageInteraction.BP_GPUFoliageInteraction_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class BP_GPUFoliageInteraction_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024762 RID: 149346 RVA: 0x0093F6C1 File Offset: 0x0093D8C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GPUFoliageInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/BP_GPUFoliageInteraction.BP_GPUFoliageInteraction_C");
			}
			return BP_GPUFoliageInteraction_C._ClassPtr;
		}

		// Token: 0x06024763 RID: 149347 RVA: 0x0093F6E8 File Offset: 0x0093D8E8
		public BP_GPUFoliageInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_GPUFoliageInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024764 RID: 149348 RVA: 0x0093F710 File Offset: 0x0093D910
		public BP_GPUFoliageInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GPUFoliageInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700472E RID: 18222
		// (get) Token: 0x06024765 RID: 149349 RVA: 0x0093F743 File Offset: 0x0093D943
		// (set) Token: 0x06024766 RID: 149350 RVA: 0x0093F753 File Offset: 0x0093D953
		public unsafe int Bone_Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700472F RID: 18223
		// (get) Token: 0x06024767 RID: 149351 RVA: 0x0093F764 File Offset: 0x0093D964
		// (set) Token: 0x06024768 RID: 149352 RVA: 0x0093F79D File Offset: 0x0093D99D
		public TArray<int> Parent_ID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Parent_ID) == null)
				{
					result = (this._Parent_ID = new TArray<int>(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Parent_ID.CopyAssign(value);
			}
		}

		// Token: 0x17004730 RID: 18224
		// (get) Token: 0x06024769 RID: 149353 RVA: 0x0093F7AC File Offset: 0x0093D9AC
		// (set) Token: 0x0602476A RID: 149354 RVA: 0x0093F7E5 File Offset: 0x0093D9E5
		public TArray<int> PPID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PPID) == null)
				{
					result = (this._PPID = new TArray<int>(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.PPID.CopyAssign(value);
			}
		}

		// Token: 0x17004731 RID: 18225
		// (get) Token: 0x0602476B RID: 149355 RVA: 0x0093F7F4 File Offset: 0x0093D9F4
		// (set) Token: 0x0602476C RID: 149356 RVA: 0x0093F82D File Offset: 0x0093DA2D
		public TArray<int> Child_ID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Child_ID) == null)
				{
					result = (this._Child_ID = new TArray<int>(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Child_ID.CopyAssign(value);
			}
		}

		// Token: 0x17004732 RID: 18226
		// (get) Token: 0x0602476D RID: 149357 RVA: 0x0093F83C File Offset: 0x0093DA3C
		// (set) Token: 0x0602476E RID: 149358 RVA: 0x0093F875 File Offset: 0x0093DA75
		public TArray<float> BoneMask
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BoneMask) == null)
				{
					result = (this._BoneMask = new TArray<float>(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.BoneMask.CopyAssign(value);
			}
		}

		// Token: 0x17004733 RID: 18227
		// (get) Token: 0x0602476F RID: 149359 RVA: 0x0093F884 File Offset: 0x0093DA84
		// (set) Token: 0x06024770 RID: 149360 RVA: 0x0093F8BD File Offset: 0x0093DABD
		public TArray<FMatrix> Transform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMatrix> result;
				if ((result = this._Transform) == null)
				{
					result = (this._Transform = new TArray<FMatrix>(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.Transform.CopyAssign(value);
			}
		}

		// Token: 0x17004734 RID: 18228
		// (get) Token: 0x06024771 RID: 149361 RVA: 0x0093F8CC File Offset: 0x0093DACC
		// (set) Token: 0x06024772 RID: 149362 RVA: 0x0093F905 File Offset: 0x0093DB05
		public TArray<FQuat> Quat
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._Quat) == null)
				{
					result = (this._Quat = new TArray<FQuat>(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.Quat.CopyAssign(value);
			}
		}

		// Token: 0x17004735 RID: 18229
		// (get) Token: 0x06024773 RID: 149363 RVA: 0x0093F914 File Offset: 0x0093DB14
		// (set) Token: 0x06024774 RID: 149364 RVA: 0x0093F94D File Offset: 0x0093DB4D
		public TArray<FVector> P
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._P) == null)
				{
					result = (this._P = new TArray<FVector>(base.NativePtr + (IntPtr)BP_GPUFoliageInteraction_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.P.CopyAssign(value);
			}
		}

		// Token: 0x06024775 RID: 149365 RVA: 0x0093F95B File Offset: 0x0093DB5B
		protected BP_GPUFoliageInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401218E RID: 74126
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/BP_GPUFoliageInteraction.BP_GPUFoliageInteraction_C";

		// Token: 0x0401218F RID: 74127
		private static IntPtr _ClassPtr;

		// Token: 0x04012190 RID: 74128
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012191 RID: 74129
		internal static int __PropertyOffset_0;

		// Token: 0x04012192 RID: 74130
		internal static int __PropertyOffset_1;

		// Token: 0x04012193 RID: 74131
		[Nullable(2)]
		private TArray<int> _Parent_ID;

		// Token: 0x04012194 RID: 74132
		internal static int __PropertyOffset_2;

		// Token: 0x04012195 RID: 74133
		[Nullable(2)]
		private TArray<int> _PPID;

		// Token: 0x04012196 RID: 74134
		internal static int __PropertyOffset_3;

		// Token: 0x04012197 RID: 74135
		[Nullable(2)]
		private TArray<int> _Child_ID;

		// Token: 0x04012198 RID: 74136
		internal static int __PropertyOffset_4;

		// Token: 0x04012199 RID: 74137
		[Nullable(2)]
		private TArray<float> _BoneMask;

		// Token: 0x0401219A RID: 74138
		internal static int __PropertyOffset_5;

		// Token: 0x0401219B RID: 74139
		[Nullable(2)]
		private TArray<FMatrix> _Transform;

		// Token: 0x0401219C RID: 74140
		internal static int __PropertyOffset_6;

		// Token: 0x0401219D RID: 74141
		[Nullable(2)]
		private TArray<FQuat> _Quat;

		// Token: 0x0401219E RID: 74142
		internal static int __PropertyOffset_7;

		// Token: 0x0401219F RID: 74143
		[Nullable(2)]
		private TArray<FVector> _P;
	}
}
