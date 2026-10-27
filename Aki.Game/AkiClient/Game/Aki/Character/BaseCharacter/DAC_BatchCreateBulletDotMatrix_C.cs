using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004286 RID: 17030
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletDotMatrix.DAC_BatchCreateBulletDotMatrix_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class DAC_BatchCreateBulletDotMatrix_C : DAC_BatchCreateBullet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C388 RID: 181128 RVA: 0x00A1A5FB File Offset: 0x00A187FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBulletDotMatrix_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletDotMatrix.DAC_BatchCreateBulletDotMatrix_C");
			}
			return DAC_BatchCreateBulletDotMatrix_C._ClassPtr;
		}

		// Token: 0x0602C389 RID: 181129 RVA: 0x00A1A620 File Offset: 0x00A18820
		public DAC_BatchCreateBulletDotMatrix_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletDotMatrix_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C38A RID: 181130 RVA: 0x00A1A648 File Offset: 0x00A18848
		public DAC_BatchCreateBulletDotMatrix_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletDotMatrix_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E3C RID: 28220
		// (get) Token: 0x0602C38B RID: 181131 RVA: 0x00A1A67C File Offset: 0x00A1887C
		// (set) Token: 0x0602C38C RID: 181132 RVA: 0x00A1A6B5 File Offset: 0x00A188B5
		public SBatchBulletPositionPointMatrix Shape
		{
			get
			{
				base.FastCheckIsValid();
				SBatchBulletPositionPointMatrix result;
				if ((result = this._Shape) == null)
				{
					result = (this._Shape = new SBatchBulletPositionPointMatrix(base.NativePtr + (IntPtr)DAC_BatchCreateBulletDotMatrix_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBatchBulletPositionPointMatrix.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBulletDotMatrix_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C38D RID: 181133 RVA: 0x00A1A6D6 File Offset: 0x00A188D6
		protected DAC_BatchCreateBulletDotMatrix_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017260 RID: 94816
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletDotMatrix.DAC_BatchCreateBulletDotMatrix_C";

		// Token: 0x04017261 RID: 94817
		private static IntPtr _ClassPtr;

		// Token: 0x04017262 RID: 94818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017263 RID: 94819
		internal new static int __PropertyOffset_0;

		// Token: 0x04017264 RID: 94820
		[Nullable(2)]
		private SBatchBulletPositionPointMatrix _Shape;
	}
}
