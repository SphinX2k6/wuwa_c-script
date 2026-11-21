using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.SpineMouthAnimation.Struct
{
	// Token: 0x0200316D RID: 12653
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/SpineMouthAnimation/Struct/BP_SpineMouthAnimation.BP_SpineMouthAnimation_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class BP_SpineMouthAnimation_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F373 RID: 127859 RVA: 0x00928CC1 File Offset: 0x00926EC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpineMouthAnimation_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/SpineMouthAnimation/Struct/BP_SpineMouthAnimation.BP_SpineMouthAnimation_C");
			}
			return BP_SpineMouthAnimation_C._ClassPtr;
		}

		// Token: 0x0601F374 RID: 127860 RVA: 0x00928CE8 File Offset: 0x00926EE8
		public BP_SpineMouthAnimation_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpineMouthAnimation_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F375 RID: 127861 RVA: 0x00928D10 File Offset: 0x00926F10
		public BP_SpineMouthAnimation_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpineMouthAnimation_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0601F376 RID: 127862 RVA: 0x00928D43 File Offset: 0x00926F43
		// (set) Token: 0x0601F377 RID: 127863 RVA: 0x00928D53 File Offset: 0x00926F53
		public unsafe int DurationMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpineMouthAnimation_C.__PropertyOffset_DurationMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpineMouthAnimation_C.__PropertyOffset_DurationMs) = value;
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0601F378 RID: 127864 RVA: 0x00928D64 File Offset: 0x00926F64
		// (set) Token: 0x0601F379 RID: 127865 RVA: 0x00928D9D File Offset: 0x00926F9D
		public TArray<SSpineMouthKey> Keys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSpineMouthKey> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<SSpineMouthKey>(base.NativePtr + (IntPtr)BP_SpineMouthAnimation_C.__PropertyOffset_Keys, this));
				}
				return result;
			}
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x0601F37A RID: 127866 RVA: 0x00928DAB File Offset: 0x00926FAB
		protected BP_SpineMouthAnimation_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B15 RID: 68373
		public new const string __ObjectPath = "/Game/Aki/Data/SpineMouthAnimation/Struct/BP_SpineMouthAnimation.BP_SpineMouthAnimation_C";

		// Token: 0x04010B16 RID: 68374
		private static IntPtr _ClassPtr;

		// Token: 0x04010B17 RID: 68375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B18 RID: 68376
		internal static int __PropertyOffset_DurationMs;

		// Token: 0x04010B19 RID: 68377
		internal static int __PropertyOffset_Keys;

		// Token: 0x04010B1A RID: 68378
		[Nullable(2)]
		private TArray<SSpineMouthKey> _Keys;
	}
}
