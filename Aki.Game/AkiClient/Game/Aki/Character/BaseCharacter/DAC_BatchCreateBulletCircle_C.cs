using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004285 RID: 17029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletCircle.DAC_BatchCreateBulletCircle_C")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class DAC_BatchCreateBulletCircle_C : DAC_BatchCreateBullet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C382 RID: 181122 RVA: 0x00A1A516 File Offset: 0x00A18716
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBulletCircle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletCircle.DAC_BatchCreateBulletCircle_C");
			}
			return DAC_BatchCreateBulletCircle_C._ClassPtr;
		}

		// Token: 0x0602C383 RID: 181123 RVA: 0x00A1A53C File Offset: 0x00A1873C
		public DAC_BatchCreateBulletCircle_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletCircle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C384 RID: 181124 RVA: 0x00A1A564 File Offset: 0x00A18764
		public DAC_BatchCreateBulletCircle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletCircle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E3B RID: 28219
		// (get) Token: 0x0602C385 RID: 181125 RVA: 0x00A1A598 File Offset: 0x00A18798
		// (set) Token: 0x0602C386 RID: 181126 RVA: 0x00A1A5D1 File Offset: 0x00A187D1
		public SBatchBulletPositionCircle Shape
		{
			get
			{
				base.FastCheckIsValid();
				SBatchBulletPositionCircle result;
				if ((result = this._Shape) == null)
				{
					result = (this._Shape = new SBatchBulletPositionCircle(base.NativePtr + (IntPtr)DAC_BatchCreateBulletCircle_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBatchBulletPositionCircle.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBulletCircle_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C387 RID: 181127 RVA: 0x00A1A5F2 File Offset: 0x00A187F2
		protected DAC_BatchCreateBulletCircle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401725B RID: 94811
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletCircle.DAC_BatchCreateBulletCircle_C";

		// Token: 0x0401725C RID: 94812
		private static IntPtr _ClassPtr;

		// Token: 0x0401725D RID: 94813
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401725E RID: 94814
		internal new static int __PropertyOffset_0;

		// Token: 0x0401725F RID: 94815
		[Nullable(2)]
		private SBatchBulletPositionCircle _Shape;
	}
}
