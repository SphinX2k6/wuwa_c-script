using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004288 RID: 17032
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBullet.DAC_BatchCreateBullet_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 129)]
	public class DAC_BatchCreateBullet_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C394 RID: 181140 RVA: 0x00A1A7C3 File Offset: 0x00A189C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBullet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBullet.DAC_BatchCreateBullet_C");
			}
			return DAC_BatchCreateBullet_C._ClassPtr;
		}

		// Token: 0x0602C395 RID: 181141 RVA: 0x00A1A7E8 File Offset: 0x00A189E8
		public DAC_BatchCreateBullet_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBullet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C396 RID: 181142 RVA: 0x00A1A810 File Offset: 0x00A18A10
		[NullableContext(1)]
		public DAC_BatchCreateBullet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBullet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E3E RID: 28222
		// (get) Token: 0x0602C397 RID: 181143 RVA: 0x00A1A844 File Offset: 0x00A18A44
		// (set) Token: 0x0602C398 RID: 181144 RVA: 0x00A1A87D File Offset: 0x00A18A7D
		[Nullable(1)]
		public SSkillBehaviorBatchBullet Base
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SSkillBehaviorBatchBullet result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new SSkillBehaviorBatchBullet(base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_0, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorBatchBullet.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E3F RID: 28223
		// (get) Token: 0x0602C399 RID: 181145 RVA: 0x00A1A89E File Offset: 0x00A18A9E
		// (set) Token: 0x0602C39A RID: 181146 RVA: 0x00A1A8B2 File Offset: 0x00A18AB2
		public unsafe TEnumAsByte<EBatchBulletPosition> BeginPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602C39B RID: 181147 RVA: 0x00A1A8C7 File Offset: 0x00A18AC7
		protected DAC_BatchCreateBullet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401726A RID: 94826
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBullet.DAC_BatchCreateBullet_C";

		// Token: 0x0401726B RID: 94827
		private static IntPtr _ClassPtr;

		// Token: 0x0401726C RID: 94828
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401726D RID: 94829
		internal static int __PropertyOffset_0;

		// Token: 0x0401726E RID: 94830
		[Nullable(2)]
		private SSkillBehaviorBatchBullet _Base;

		// Token: 0x0401726F RID: 94831
		internal static int __PropertyOffset_1;
	}
}
