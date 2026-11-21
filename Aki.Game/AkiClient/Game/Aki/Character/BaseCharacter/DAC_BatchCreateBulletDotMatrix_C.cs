using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E7 RID: 13031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletDotMatrix.DAC_BatchCreateBulletDotMatrix_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class DAC_BatchCreateBulletDotMatrix_C : DAC_BatchCreateBullet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060211C5 RID: 135621 RVA: 0x0095978B File Offset: 0x0095798B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBulletDotMatrix_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletDotMatrix.DAC_BatchCreateBulletDotMatrix_C");
			}
			return DAC_BatchCreateBulletDotMatrix_C._ClassPtr;
		}

		// Token: 0x060211C6 RID: 135622 RVA: 0x009597B0 File Offset: 0x009579B0
		public DAC_BatchCreateBulletDotMatrix_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletDotMatrix_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211C7 RID: 135623 RVA: 0x009597D8 File Offset: 0x009579D8
		public DAC_BatchCreateBulletDotMatrix_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletDotMatrix_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x060211C8 RID: 135624 RVA: 0x0095980C File Offset: 0x00957A0C
		// (set) Token: 0x060211C9 RID: 135625 RVA: 0x00959845 File Offset: 0x00957A45
		public SBatchBulletPositionPointMatrix Shape
		{
			get
			{
				base.FastCheckIsValid();
				SBatchBulletPositionPointMatrix result;
				if ((result = this._Shape) == null)
				{
					result = (this._Shape = new SBatchBulletPositionPointMatrix(base.NativePtr + (IntPtr)DAC_BatchCreateBulletDotMatrix_C.__PropertyOffset_Shape, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBatchBulletPositionPointMatrix.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBulletDotMatrix_C.__PropertyOffset_Shape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060211CA RID: 135626 RVA: 0x00959866 File Offset: 0x00957A66
		protected DAC_BatchCreateBulletDotMatrix_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F7E RID: 73598
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletDotMatrix.DAC_BatchCreateBulletDotMatrix_C";

		// Token: 0x04011F7F RID: 73599
		private static IntPtr _ClassPtr;

		// Token: 0x04011F80 RID: 73600
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F81 RID: 73601
		internal static int __PropertyOffset_Shape;

		// Token: 0x04011F82 RID: 73602
		[Nullable(2)]
		private SBatchBulletPositionPointMatrix _Shape;
	}
}
