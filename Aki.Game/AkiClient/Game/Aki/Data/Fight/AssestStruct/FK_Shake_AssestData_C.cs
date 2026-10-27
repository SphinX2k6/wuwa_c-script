using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.AssestStruct
{
	// Token: 0x02003F87 RID: 16263
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/AssestStruct/FK_Shake_AssestData.FK_Shake_AssestData_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class FK_Shake_AssestData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029844 RID: 170052 RVA: 0x009C5FA2 File Offset: 0x009C41A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (FK_Shake_AssestData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/AssestStruct/FK_Shake_AssestData.FK_Shake_AssestData_C");
			}
			return FK_Shake_AssestData_C._ClassPtr;
		}

		// Token: 0x06029845 RID: 170053 RVA: 0x009C5FC8 File Offset: 0x009C41C8
		public FK_Shake_AssestData_C() : this(BuiltinUtils.AllocNativeUObject(FK_Shake_AssestData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029846 RID: 170054 RVA: 0x009C5FF0 File Offset: 0x009C41F0
		public FK_Shake_AssestData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(FK_Shake_AssestData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170063AE RID: 25518
		// (get) Token: 0x06029847 RID: 170055 RVA: 0x009C6024 File Offset: 0x009C4224
		// (set) Token: 0x06029848 RID: 170056 RVA: 0x009C605D File Offset: 0x009C425D
		public FSkeletonGroup ShakeBonesData
		{
			get
			{
				base.FastCheckIsValid();
				FSkeletonGroup result;
				if ((result = this._ShakeBonesData) == null)
				{
					result = (this._ShakeBonesData = new FSkeletonGroup(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletonGroup.StaticStruct(), base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170063AF RID: 25519
		// (get) Token: 0x06029849 RID: 170057 RVA: 0x009C607E File Offset: 0x009C427E
		// (set) Token: 0x0602984A RID: 170058 RVA: 0x009C6092 File Offset: 0x009C4292
		[Nullable(2)]
		public unsafe UCurveFloat ShakeCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FK_Shake_AssestData_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FK_Shake_AssestData_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170063B0 RID: 25520
		// (get) Token: 0x0602984B RID: 170059 RVA: 0x009C60A7 File Offset: 0x009C42A7
		// (set) Token: 0x0602984C RID: 170060 RVA: 0x009C60B7 File Offset: 0x009C42B7
		public unsafe float ShakeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170063B1 RID: 25521
		// (get) Token: 0x0602984D RID: 170061 RVA: 0x009C60C8 File Offset: 0x009C42C8
		// (set) Token: 0x0602984E RID: 170062 RVA: 0x009C60D8 File Offset: 0x009C42D8
		public unsafe float ShakeAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170063B2 RID: 25522
		// (get) Token: 0x0602984F RID: 170063 RVA: 0x009C60E9 File Offset: 0x009C42E9
		// (set) Token: 0x06029850 RID: 170064 RVA: 0x009C60F9 File Offset: 0x009C42F9
		public unsafe int ShakeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170063B3 RID: 25523
		// (get) Token: 0x06029851 RID: 170065 RVA: 0x009C610C File Offset: 0x009C430C
		// (set) Token: 0x06029852 RID: 170066 RVA: 0x009C6145 File Offset: 0x009C4345
		public FBoneFeedbackAnimConfigGroup FeedbackAnim
		{
			get
			{
				base.FastCheckIsValid();
				FBoneFeedbackAnimConfigGroup result;
				if ((result = this._FeedbackAnim) == null)
				{
					result = (this._FeedbackAnim = new FBoneFeedbackAnimConfigGroup(base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneFeedbackAnimConfigGroup.StaticStruct(), base.NativePtr + (IntPtr)FK_Shake_AssestData_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06029853 RID: 170067 RVA: 0x009C6166 File Offset: 0x009C4366
		protected FK_Shake_AssestData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401547C RID: 87164
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/AssestStruct/FK_Shake_AssestData.FK_Shake_AssestData_C";

		// Token: 0x0401547D RID: 87165
		private static IntPtr _ClassPtr;

		// Token: 0x0401547E RID: 87166
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401547F RID: 87167
		internal static int __PropertyOffset_0;

		// Token: 0x04015480 RID: 87168
		[Nullable(2)]
		private FSkeletonGroup _ShakeBonesData;

		// Token: 0x04015481 RID: 87169
		internal static int __PropertyOffset_1;

		// Token: 0x04015482 RID: 87170
		internal static int __PropertyOffset_2;

		// Token: 0x04015483 RID: 87171
		internal static int __PropertyOffset_3;

		// Token: 0x04015484 RID: 87172
		internal static int __PropertyOffset_4;

		// Token: 0x04015485 RID: 87173
		internal static int __PropertyOffset_5;

		// Token: 0x04015486 RID: 87174
		[Nullable(2)]
		private FBoneFeedbackAnimConfigGroup _FeedbackAnim;
	}
}
