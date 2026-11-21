using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E9 RID: 13033
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBullet.DAC_BatchCreateBullet_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 129)]
	public class DAC_BatchCreateBullet_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060211D1 RID: 135633 RVA: 0x00959953 File Offset: 0x00957B53
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DAC_BatchCreateBullet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBullet.DAC_BatchCreateBullet_C");
			}
			return DAC_BatchCreateBullet_C._ClassPtr;
		}

		// Token: 0x060211D2 RID: 135634 RVA: 0x00959978 File Offset: 0x00957B78
		public DAC_BatchCreateBullet_C() : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBullet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211D3 RID: 135635 RVA: 0x009599A0 File Offset: 0x00957BA0
		[NullableContext(1)]
		public DAC_BatchCreateBullet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DAC_BatchCreateBullet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x060211D4 RID: 135636 RVA: 0x009599D4 File Offset: 0x00957BD4
		// (set) Token: 0x060211D5 RID: 135637 RVA: 0x00959A0D File Offset: 0x00957C0D
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
					result = (this._Base = new SSkillBehaviorBatchBullet(base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_Base, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorBatchBullet.StaticStruct(), base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x060211D6 RID: 135638 RVA: 0x00959A2E File Offset: 0x00957C2E
		// (set) Token: 0x060211D7 RID: 135639 RVA: 0x00959A42 File Offset: 0x00957C42
		public unsafe TEnumAsByte<EBatchBulletPosition> BeginPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_BeginPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)DAC_BatchCreateBullet_C.__PropertyOffset_BeginPos) = value;
			}
		}

		// Token: 0x060211D8 RID: 135640 RVA: 0x00959A57 File Offset: 0x00957C57
		protected DAC_BatchCreateBullet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F88 RID: 73608
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/DAC_BatchCreateBullet.DAC_BatchCreateBullet_C";

		// Token: 0x04011F89 RID: 73609
		private static IntPtr _ClassPtr;

		// Token: 0x04011F8A RID: 73610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F8B RID: 73611
		internal static int __PropertyOffset_Base;

		// Token: 0x04011F8C RID: 73612
		[Nullable(2)]
		private SSkillBehaviorBatchBullet _Base;

		// Token: 0x04011F8D RID: 73613
		internal static int __PropertyOffset_BeginPos;
	}
}
