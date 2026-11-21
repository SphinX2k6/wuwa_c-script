using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E6 RID: 13030
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletCircle.DAC_BatchCreateBulletCircle_C")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class DAC_BatchCreateBulletCircle_C : DAC_BatchCreateBullet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060211BF RID: 135615 RVA: 0x009596A8 File Offset: 0x009578A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBulletCircle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletCircle.DAC_BatchCreateBulletCircle_C");
			}
			return DAC_BatchCreateBulletCircle_C._ClassPtr;
		}

		// Token: 0x060211C0 RID: 135616 RVA: 0x009596CC File Offset: 0x009578CC
		public DAC_BatchCreateBulletCircle_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletCircle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211C1 RID: 135617 RVA: 0x009596F4 File Offset: 0x009578F4
		public DAC_BatchCreateBulletCircle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletCircle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x060211C2 RID: 135618 RVA: 0x00959728 File Offset: 0x00957928
		// (set) Token: 0x060211C3 RID: 135619 RVA: 0x00959761 File Offset: 0x00957961
		public SBatchBulletPositionCircle Shape
		{
			get
			{
				base.FastCheckIsValid();
				SBatchBulletPositionCircle result;
				if ((result = this._Shape) == null)
				{
					result = (this._Shape = new SBatchBulletPositionCircle(base.NativePtr + (IntPtr)DAC_BatchCreateBulletCircle_C.__PropertyOffset_Shape, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBatchBulletPositionCircle.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBulletCircle_C.__PropertyOffset_Shape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060211C4 RID: 135620 RVA: 0x00959782 File Offset: 0x00957982
		protected DAC_BatchCreateBulletCircle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F79 RID: 73593
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletCircle.DAC_BatchCreateBulletCircle_C";

		// Token: 0x04011F7A RID: 73594
		private static IntPtr _ClassPtr;

		// Token: 0x04011F7B RID: 73595
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F7C RID: 73596
		internal static int __PropertyOffset_Shape;

		// Token: 0x04011F7D RID: 73597
		[Nullable(2)]
		private SBatchBulletPositionCircle _Shape;
	}
}
