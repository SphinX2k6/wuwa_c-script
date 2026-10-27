using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A2A RID: 14890
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/BP_SequenceData_Generated.BP_SequenceData_Generated_C")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class BP_SequenceData_Generated_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F592 RID: 128402 RVA: 0x008B6065 File Offset: 0x008B4265
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceData_Generated_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Manager/BP_SequenceData_Generated.BP_SequenceData_Generated_C");
			}
			return BP_SequenceData_Generated_C._ClassPtr;
		}

		// Token: 0x0601F593 RID: 128403 RVA: 0x008B608C File Offset: 0x008B428C
		public BP_SequenceData_Generated_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_Generated_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F594 RID: 128404 RVA: 0x008B60B4 File Offset: 0x008B42B4
		public BP_SequenceData_Generated_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_Generated_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x0601F595 RID: 128405 RVA: 0x008B60E8 File Offset: 0x008B42E8
		// (set) Token: 0x0601F596 RID: 128406 RVA: 0x008B6121 File Offset: 0x008B4321
		public TArray<SSequencesKeyFrames> KeyFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSequencesKeyFrames> result;
				if ((result = this._KeyFrames) == null)
				{
					result = (this._KeyFrames = new TArray<SSequencesKeyFrames>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.KeyFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0601F597 RID: 128407 RVA: 0x008B6130 File Offset: 0x008B4330
		// (set) Token: 0x0601F598 RID: 128408 RVA: 0x008B6169 File Offset: 0x008B4369
		public TArray<FTransform> FinalPos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._FinalPos) == null)
				{
					result = (this._FinalPos = new TArray<FTransform>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.FinalPos.CopyAssign(value);
			}
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0601F599 RID: 128409 RVA: 0x008B6178 File Offset: 0x008B4378
		// (set) Token: 0x0601F59A RID: 128410 RVA: 0x008B61B1 File Offset: 0x008B43B1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<AActor>> BindingBP
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<AActor>> result;
				if ((result = this._BindingBP) == null)
				{
					result = (this._BindingBP = new TArray<TSubclassOf<AActor>>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.BindingBP.CopyAssign(value);
			}
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0601F59B RID: 128411 RVA: 0x008B61C0 File Offset: 0x008B43C0
		// (set) Token: 0x0601F59C RID: 128412 RVA: 0x008B61F9 File Offset: 0x008B43F9
		public TArray<bool> IsFadeEnd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._IsFadeEnd) == null)
				{
					result = (this._IsFadeEnd = new TArray<bool>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.IsFadeEnd.CopyAssign(value);
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0601F59D RID: 128413 RVA: 0x008B6207 File Offset: 0x008B4407
		// (set) Token: 0x0601F59E RID: 128414 RVA: 0x008B621B File Offset: 0x008B441B
		public unsafe FName BlendInTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x0601F59F RID: 128415 RVA: 0x008B6230 File Offset: 0x008B4430
		// (set) Token: 0x0601F5A0 RID: 128416 RVA: 0x008B6269 File Offset: 0x008B4469
		public TArray<FName> BlendInTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BlendInTags) == null)
				{
					result = (this._BlendInTags = new TArray<FName>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.BlendInTags.CopyAssign(value);
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x0601F5A1 RID: 128417 RVA: 0x008B6277 File Offset: 0x008B4477
		// (set) Token: 0x0601F5A2 RID: 128418 RVA: 0x008B628B File Offset: 0x008B448B
		public unsafe FName BlendOutTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x0601F5A3 RID: 128419 RVA: 0x008B62A0 File Offset: 0x008B44A0
		// (set) Token: 0x0601F5A4 RID: 128420 RVA: 0x008B62D9 File Offset: 0x008B44D9
		public TArray<FName> BlendOutTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BlendOutTags) == null)
				{
					result = (this._BlendOutTags = new TArray<FName>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.BlendOutTags.CopyAssign(value);
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x0601F5A5 RID: 128421 RVA: 0x008B62E8 File Offset: 0x008B44E8
		// (set) Token: 0x0601F5A6 RID: 128422 RVA: 0x008B6321 File Offset: 0x008B4521
		public TArray<string> PreloadUiArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PreloadUiArray) == null)
				{
					result = (this._PreloadUiArray = new TArray<string>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.PreloadUiArray.CopyAssign(value);
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x0601F5A7 RID: 128423 RVA: 0x008B632F File Offset: 0x008B452F
		// (set) Token: 0x0601F5A8 RID: 128424 RVA: 0x008B633F File Offset: 0x008B453F
		public unsafe bool IsCustomizedFinalPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x0601F5A9 RID: 128425 RVA: 0x008B6350 File Offset: 0x008B4550
		// (set) Token: 0x0601F5AA RID: 128426 RVA: 0x008B6365 File Offset: 0x008B4565
		public TSoftClassPtr<AActor> MalePlayerBP
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_10, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0601F5AB RID: 128427 RVA: 0x008B638A File Offset: 0x008B458A
		// (set) Token: 0x0601F5AC RID: 128428 RVA: 0x008B639F File Offset: 0x008B459F
		public TSoftClassPtr<AActor> FemalePlayerBP
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_11, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0601F5AD RID: 128429 RVA: 0x008B63C4 File Offset: 0x008B45C4
		// (set) Token: 0x0601F5AE RID: 128430 RVA: 0x008B63D9 File Offset: 0x008B45D9
		public TSoftObjectPtr<USkeletalMesh> MaleMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_12, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0601F5AF RID: 128431 RVA: 0x008B63FE File Offset: 0x008B45FE
		// (set) Token: 0x0601F5B0 RID: 128432 RVA: 0x008B6413 File Offset: 0x008B4613
		public TSoftObjectPtr<USkeletalMesh> FemaleMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_13, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_13, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0601F5B1 RID: 128433 RVA: 0x008B6438 File Offset: 0x008B4638
		// (set) Token: 0x0601F5B2 RID: 128434 RVA: 0x008B6471 File Offset: 0x008B4671
		public TArray<int> QteId
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._QteId) == null)
				{
					result = (this._QteId = new TArray<int>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.QteId.CopyAssign(value);
			}
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0601F5B3 RID: 128435 RVA: 0x008B6480 File Offset: 0x008B4680
		// (set) Token: 0x0601F5B4 RID: 128436 RVA: 0x008B64B9 File Offset: 0x008B46B9
		public TArray<FSoftObjectPath> ActorRefs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._ActorRefs) == null)
				{
					result = (this._ActorRefs = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.ActorRefs.CopyAssign(value);
			}
		}

		// Token: 0x0601F5B5 RID: 128437 RVA: 0x008B64C7 File Offset: 0x008B46C7
		protected BP_SequenceData_Generated_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F0BC RID: 61628
		public new const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_SequenceData_Generated.BP_SequenceData_Generated_C";

		// Token: 0x0400F0BD RID: 61629
		private static IntPtr _ClassPtr;

		// Token: 0x0400F0BE RID: 61630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F0BF RID: 61631
		internal static int __PropertyOffset_0;

		// Token: 0x0400F0C0 RID: 61632
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSequencesKeyFrames> _KeyFrames;

		// Token: 0x0400F0C1 RID: 61633
		internal static int __PropertyOffset_1;

		// Token: 0x0400F0C2 RID: 61634
		[Nullable(2)]
		private TArray<FTransform> _FinalPos;

		// Token: 0x0400F0C3 RID: 61635
		internal static int __PropertyOffset_2;

		// Token: 0x0400F0C4 RID: 61636
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<AActor>> _BindingBP;

		// Token: 0x0400F0C5 RID: 61637
		internal static int __PropertyOffset_3;

		// Token: 0x0400F0C6 RID: 61638
		[Nullable(2)]
		private TArray<bool> _IsFadeEnd;

		// Token: 0x0400F0C7 RID: 61639
		internal static int __PropertyOffset_4;

		// Token: 0x0400F0C8 RID: 61640
		internal static int __PropertyOffset_5;

		// Token: 0x0400F0C9 RID: 61641
		[Nullable(2)]
		private TArray<FName> _BlendInTags;

		// Token: 0x0400F0CA RID: 61642
		internal static int __PropertyOffset_6;

		// Token: 0x0400F0CB RID: 61643
		internal static int __PropertyOffset_7;

		// Token: 0x0400F0CC RID: 61644
		[Nullable(2)]
		private TArray<FName> _BlendOutTags;

		// Token: 0x0400F0CD RID: 61645
		internal static int __PropertyOffset_8;

		// Token: 0x0400F0CE RID: 61646
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PreloadUiArray;

		// Token: 0x0400F0CF RID: 61647
		internal static int __PropertyOffset_9;

		// Token: 0x0400F0D0 RID: 61648
		internal static int __PropertyOffset_10;

		// Token: 0x0400F0D1 RID: 61649
		internal static int __PropertyOffset_11;

		// Token: 0x0400F0D2 RID: 61650
		internal static int __PropertyOffset_12;

		// Token: 0x0400F0D3 RID: 61651
		internal static int __PropertyOffset_13;

		// Token: 0x0400F0D4 RID: 61652
		internal static int __PropertyOffset_14;

		// Token: 0x0400F0D5 RID: 61653
		[Nullable(2)]
		private TArray<int> _QteId;

		// Token: 0x0400F0D6 RID: 61654
		internal static int __PropertyOffset_15;

		// Token: 0x0400F0D7 RID: 61655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ActorRefs;
	}
}
