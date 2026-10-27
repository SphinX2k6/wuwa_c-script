using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004287 RID: 17031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletSpline.DAC_BatchCreateBulletSpline_C")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class DAC_BatchCreateBulletSpline_C : DAC_BatchCreateBullet_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C38E RID: 181134 RVA: 0x00A1A6DF File Offset: 0x00A188DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBulletSpline_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletSpline.DAC_BatchCreateBulletSpline_C");
			}
			return DAC_BatchCreateBulletSpline_C._ClassPtr;
		}

		// Token: 0x0602C38F RID: 181135 RVA: 0x00A1A704 File Offset: 0x00A18904
		public DAC_BatchCreateBulletSpline_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletSpline_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C390 RID: 181136 RVA: 0x00A1A72C File Offset: 0x00A1892C
		public DAC_BatchCreateBulletSpline_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBulletSpline_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E3D RID: 28221
		// (get) Token: 0x0602C391 RID: 181137 RVA: 0x00A1A760 File Offset: 0x00A18960
		// (set) Token: 0x0602C392 RID: 181138 RVA: 0x00A1A799 File Offset: 0x00A18999
		public SBatchBulletPositionSpline Shape
		{
			get
			{
				base.FastCheckIsValid();
				SBatchBulletPositionSpline result;
				if ((result = this._Shape) == null)
				{
					result = (this._Shape = new SBatchBulletPositionSpline(base.NativePtr + (IntPtr)DAC_BatchCreateBulletSpline_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBatchBulletPositionSpline.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBulletSpline_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C393 RID: 181139 RVA: 0x00A1A7BA File Offset: 0x00A189BA
		protected DAC_BatchCreateBulletSpline_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017265 RID: 94821
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBulletSpline.DAC_BatchCreateBulletSpline_C";

		// Token: 0x04017266 RID: 94822
		private static IntPtr _ClassPtr;

		// Token: 0x04017267 RID: 94823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017268 RID: 94824
		internal new static int __PropertyOffset_0;

		// Token: 0x04017269 RID: 94825
		[Nullable(2)]
		private SBatchBulletPositionSpline _Shape;
	}
}
