using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003073 RID: 12403
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/BP_SequenceData_Generated.BP_SequenceData_Generated_C")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class BP_SequenceData_Generated_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D916 RID: 121110 RVA: 0x008FB7F1 File Offset: 0x008F99F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceData_Generated_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Manager/BP_SequenceData_Generated.BP_SequenceData_Generated_C");
			}
			return BP_SequenceData_Generated_C._ClassPtr;
		}

		// Token: 0x0601D917 RID: 121111 RVA: 0x008FB818 File Offset: 0x008F9A18
		public BP_SequenceData_Generated_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_Generated_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D918 RID: 121112 RVA: 0x008FB840 File Offset: 0x008F9A40
		public BP_SequenceData_Generated_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_Generated_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0601D919 RID: 121113 RVA: 0x008FB874 File Offset: 0x008F9A74
		// (set) Token: 0x0601D91A RID: 121114 RVA: 0x008FB8AD File Offset: 0x008F9AAD
		public TArray<SSequencesKeyFrames> KeyFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSequencesKeyFrames> result;
				if ((result = this._KeyFrames) == null)
				{
					result = (this._KeyFrames = new TArray<SSequencesKeyFrames>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_KeyFrames, this));
				}
				return result;
			}
			set
			{
				this.KeyFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0601D91B RID: 121115 RVA: 0x008FB8BC File Offset: 0x008F9ABC
		// (set) Token: 0x0601D91C RID: 121116 RVA: 0x008FB8F5 File Offset: 0x008F9AF5
		public TArray<FTransform> FinalPos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._FinalPos) == null)
				{
					result = (this._FinalPos = new TArray<FTransform>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_FinalPos, this));
				}
				return result;
			}
			set
			{
				this.FinalPos.CopyAssign(value);
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0601D91D RID: 121117 RVA: 0x008FB904 File Offset: 0x008F9B04
		// (set) Token: 0x0601D91E RID: 121118 RVA: 0x008FB93D File Offset: 0x008F9B3D
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
					result = (this._BindingBP = new TArray<TSubclassOf<AActor>>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_BindingBP, this));
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

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0601D91F RID: 121119 RVA: 0x008FB94C File Offset: 0x008F9B4C
		// (set) Token: 0x0601D920 RID: 121120 RVA: 0x008FB985 File Offset: 0x008F9B85
		public TArray<bool> IsFadeEnd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._IsFadeEnd) == null)
				{
					result = (this._IsFadeEnd = new TArray<bool>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_IsFadeEnd, this));
				}
				return result;
			}
			set
			{
				this.IsFadeEnd.CopyAssign(value);
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0601D921 RID: 121121 RVA: 0x008FB993 File Offset: 0x008F9B93
		// (set) Token: 0x0601D922 RID: 121122 RVA: 0x008FB9A7 File Offset: 0x008F9BA7
		public unsafe FName BlendInTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_BlendInTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_BlendInTag) = value;
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0601D923 RID: 121123 RVA: 0x008FB9BC File Offset: 0x008F9BBC
		// (set) Token: 0x0601D924 RID: 121124 RVA: 0x008FB9F5 File Offset: 0x008F9BF5
		public TArray<FName> BlendInTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BlendInTags) == null)
				{
					result = (this._BlendInTags = new TArray<FName>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_BlendInTags, this));
				}
				return result;
			}
			set
			{
				this.BlendInTags.CopyAssign(value);
			}
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0601D925 RID: 121125 RVA: 0x008FBA03 File Offset: 0x008F9C03
		// (set) Token: 0x0601D926 RID: 121126 RVA: 0x008FBA17 File Offset: 0x008F9C17
		public unsafe FName BlendOutTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_BlendOutTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_BlendOutTag) = value;
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0601D927 RID: 121127 RVA: 0x008FBA2C File Offset: 0x008F9C2C
		// (set) Token: 0x0601D928 RID: 121128 RVA: 0x008FBA65 File Offset: 0x008F9C65
		public TArray<FName> BlendOutTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BlendOutTags) == null)
				{
					result = (this._BlendOutTags = new TArray<FName>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_BlendOutTags, this));
				}
				return result;
			}
			set
			{
				this.BlendOutTags.CopyAssign(value);
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0601D929 RID: 121129 RVA: 0x008FBA74 File Offset: 0x008F9C74
		// (set) Token: 0x0601D92A RID: 121130 RVA: 0x008FBAAD File Offset: 0x008F9CAD
		public TArray<string> PreloadUiArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PreloadUiArray) == null)
				{
					result = (this._PreloadUiArray = new TArray<string>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_PreloadUiArray, this));
				}
				return result;
			}
			set
			{
				this.PreloadUiArray.CopyAssign(value);
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0601D92B RID: 121131 RVA: 0x008FBABB File Offset: 0x008F9CBB
		// (set) Token: 0x0601D92C RID: 121132 RVA: 0x008FBACB File Offset: 0x008F9CCB
		public unsafe bool IsCustomizedFinalPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_IsCustomizedFinalPos) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_IsCustomizedFinalPos) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0601D92D RID: 121133 RVA: 0x008FBADC File Offset: 0x008F9CDC
		// (set) Token: 0x0601D92E RID: 121134 RVA: 0x008FBAF1 File Offset: 0x008F9CF1
		public TSoftClassPtr<AActor> MalePlayerBP
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_MalePlayerBP, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_MalePlayerBP, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0601D92F RID: 121135 RVA: 0x008FBB16 File Offset: 0x008F9D16
		// (set) Token: 0x0601D930 RID: 121136 RVA: 0x008FBB2B File Offset: 0x008F9D2B
		public TSoftClassPtr<AActor> FemalePlayerBP
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_FemalePlayerBP, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_FemalePlayerBP, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0601D931 RID: 121137 RVA: 0x008FBB50 File Offset: 0x008F9D50
		// (set) Token: 0x0601D932 RID: 121138 RVA: 0x008FBB65 File Offset: 0x008F9D65
		public TSoftObjectPtr<USkeletalMesh> MaleMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_MaleMesh, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_MaleMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0601D933 RID: 121139 RVA: 0x008FBB8A File Offset: 0x008F9D8A
		// (set) Token: 0x0601D934 RID: 121140 RVA: 0x008FBB9F File Offset: 0x008F9D9F
		public TSoftObjectPtr<USkeletalMesh> FemaleMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_FemaleMesh, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_FemaleMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0601D935 RID: 121141 RVA: 0x008FBBC4 File Offset: 0x008F9DC4
		// (set) Token: 0x0601D936 RID: 121142 RVA: 0x008FBBFD File Offset: 0x008F9DFD
		public TArray<int> QteId
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._QteId) == null)
				{
					result = (this._QteId = new TArray<int>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_QteId, this));
				}
				return result;
			}
			set
			{
				this.QteId.CopyAssign(value);
			}
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0601D937 RID: 121143 RVA: 0x008FBC0C File Offset: 0x008F9E0C
		// (set) Token: 0x0601D938 RID: 121144 RVA: 0x008FBC45 File Offset: 0x008F9E45
		public TArray<FSoftObjectPath> ActorRefs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._ActorRefs) == null)
				{
					result = (this._ActorRefs = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_ActorRefs, this));
				}
				return result;
			}
			set
			{
				this.ActorRefs.CopyAssign(value);
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0601D939 RID: 121145 RVA: 0x008FBC54 File Offset: 0x008F9E54
		// (set) Token: 0x0601D93A RID: 121146 RVA: 0x008FBC8D File Offset: 0x008F9E8D
		public TArray<int> PreStreamSeqIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PreStreamSeqIndices) == null)
				{
					result = (this._PreStreamSeqIndices = new TArray<int>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_PreStreamSeqIndices, this));
				}
				return result;
			}
			set
			{
				this.PreStreamSeqIndices.CopyAssign(value);
			}
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0601D93B RID: 121147 RVA: 0x008FBC9C File Offset: 0x008F9E9C
		// (set) Token: 0x0601D93C RID: 121148 RVA: 0x008FBCD5 File Offset: 0x008F9ED5
		public TArray<int> PreStreamFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PreStreamFrames) == null)
				{
					result = (this._PreStreamFrames = new TArray<int>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_PreStreamFrames, this));
				}
				return result;
			}
			set
			{
				this.PreStreamFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0601D93D RID: 121149 RVA: 0x008FBCE4 File Offset: 0x008F9EE4
		// (set) Token: 0x0601D93E RID: 121150 RVA: 0x008FBD1D File Offset: 0x008F9F1D
		public TArray<FVector> PreStreamLocations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PreStreamLocations) == null)
				{
					result = (this._PreStreamLocations = new TArray<FVector>(base.NativePtr + (IntPtr)BP_SequenceData_Generated_C.__PropertyOffset_PreStreamLocations, this));
				}
				return result;
			}
			set
			{
				this.PreStreamLocations.CopyAssign(value);
			}
		}

		// Token: 0x0601D93F RID: 121151 RVA: 0x008FBD2B File Offset: 0x008F9F2B
		protected BP_SequenceData_Generated_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F938 RID: 63800
		public new const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_SequenceData_Generated.BP_SequenceData_Generated_C";

		// Token: 0x0400F939 RID: 63801
		private static IntPtr _ClassPtr;

		// Token: 0x0400F93A RID: 63802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F93B RID: 63803
		internal static int __PropertyOffset_KeyFrames;

		// Token: 0x0400F93C RID: 63804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSequencesKeyFrames> _KeyFrames;

		// Token: 0x0400F93D RID: 63805
		internal static int __PropertyOffset_FinalPos;

		// Token: 0x0400F93E RID: 63806
		[Nullable(2)]
		private TArray<FTransform> _FinalPos;

		// Token: 0x0400F93F RID: 63807
		internal static int __PropertyOffset_BindingBP;

		// Token: 0x0400F940 RID: 63808
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<AActor>> _BindingBP;

		// Token: 0x0400F941 RID: 63809
		internal static int __PropertyOffset_IsFadeEnd;

		// Token: 0x0400F942 RID: 63810
		[Nullable(2)]
		private TArray<bool> _IsFadeEnd;

		// Token: 0x0400F943 RID: 63811
		internal static int __PropertyOffset_BlendInTag;

		// Token: 0x0400F944 RID: 63812
		internal static int __PropertyOffset_BlendInTags;

		// Token: 0x0400F945 RID: 63813
		[Nullable(2)]
		private TArray<FName> _BlendInTags;

		// Token: 0x0400F946 RID: 63814
		internal static int __PropertyOffset_BlendOutTag;

		// Token: 0x0400F947 RID: 63815
		internal static int __PropertyOffset_BlendOutTags;

		// Token: 0x0400F948 RID: 63816
		[Nullable(2)]
		private TArray<FName> _BlendOutTags;

		// Token: 0x0400F949 RID: 63817
		internal static int __PropertyOffset_PreloadUiArray;

		// Token: 0x0400F94A RID: 63818
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PreloadUiArray;

		// Token: 0x0400F94B RID: 63819
		internal static int __PropertyOffset_IsCustomizedFinalPos;

		// Token: 0x0400F94C RID: 63820
		internal static int __PropertyOffset_MalePlayerBP;

		// Token: 0x0400F94D RID: 63821
		internal static int __PropertyOffset_FemalePlayerBP;

		// Token: 0x0400F94E RID: 63822
		internal static int __PropertyOffset_MaleMesh;

		// Token: 0x0400F94F RID: 63823
		internal static int __PropertyOffset_FemaleMesh;

		// Token: 0x0400F950 RID: 63824
		internal static int __PropertyOffset_QteId;

		// Token: 0x0400F951 RID: 63825
		[Nullable(2)]
		private TArray<int> _QteId;

		// Token: 0x0400F952 RID: 63826
		internal static int __PropertyOffset_ActorRefs;

		// Token: 0x0400F953 RID: 63827
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ActorRefs;

		// Token: 0x0400F954 RID: 63828
		internal static int __PropertyOffset_PreStreamSeqIndices;

		// Token: 0x0400F955 RID: 63829
		[Nullable(2)]
		private TArray<int> _PreStreamSeqIndices;

		// Token: 0x0400F956 RID: 63830
		internal static int __PropertyOffset_PreStreamFrames;

		// Token: 0x0400F957 RID: 63831
		[Nullable(2)]
		private TArray<int> _PreStreamFrames;

		// Token: 0x0400F958 RID: 63832
		internal static int __PropertyOffset_PreStreamLocations;

		// Token: 0x0400F959 RID: 63833
		[Nullable(2)]
		private TArray<FVector> _PreStreamLocations;
	}
}
