using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E8 RID: 13032
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletSpline.DAC_BatchCreateBulletSpline_C")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class DAC_BatchCreateBulletSpline_C : DAC_BatchCreateBullet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060211CB RID: 135627 RVA: 0x0095986F File Offset: 0x00957A6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBulletSpline_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletSpline.DAC_BatchCreateBulletSpline_C");
			}
			return DAC_BatchCreateBulletSpline_C._ClassPtr;
		}

		// Token: 0x060211CC RID: 135628 RVA: 0x00959894 File Offset: 0x00957A94
		public DAC_BatchCreateBulletSpline_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletSpline_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211CD RID: 135629 RVA: 0x009598BC File Offset: 0x00957ABC
		public DAC_BatchCreateBulletSpline_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletSpline_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x060211CE RID: 135630 RVA: 0x009598F0 File Offset: 0x00957AF0
		// (set) Token: 0x060211CF RID: 135631 RVA: 0x00959929 File Offset: 0x00957B29
		public SBatchBulletPositionSpline Shape
		{
			get
			{
				base.FastCheckIsValid();
				SBatchBulletPositionSpline result;
				if ((result = this._Shape) == null)
				{
					result = (this._Shape = new SBatchBulletPositionSpline(base.NativePtr + (IntPtr)DAC_BatchCreateBulletSpline_C.__PropertyOffset_Shape, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBatchBulletPositionSpline.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBulletSpline_C.__PropertyOffset_Shape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060211D0 RID: 135632 RVA: 0x0095994A File Offset: 0x00957B4A
		protected DAC_BatchCreateBulletSpline_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F83 RID: 73603
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletSpline.DAC_BatchCreateBulletSpline_C";

		// Token: 0x04011F84 RID: 73604
		private static IntPtr _ClassPtr;

		// Token: 0x04011F85 RID: 73605
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F86 RID: 73606
		internal static int __PropertyOffset_Shape;

		// Token: 0x04011F87 RID: 73607
		[Nullable(2)]
		private SBatchBulletPositionSpline _Shape;
	}
}
