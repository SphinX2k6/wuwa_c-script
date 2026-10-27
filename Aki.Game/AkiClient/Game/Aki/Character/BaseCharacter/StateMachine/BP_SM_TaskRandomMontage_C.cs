using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004395 RID: 17301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskRandomMontage.BP_SM_TaskRandomMontage_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 73)]
	public class BP_SM_TaskRandomMontage_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CD04 RID: 183556 RVA: 0x00A2946F File Offset: 0x00A2766F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskRandomMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskRandomMontage.BP_SM_TaskRandomMontage_C");
			}
			return BP_SM_TaskRandomMontage_C._ClassPtr;
		}

		// Token: 0x0602CD05 RID: 183557 RVA: 0x00A29494 File Offset: 0x00A27694
		public BP_SM_TaskRandomMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskRandomMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CD06 RID: 183558 RVA: 0x00A294BC File Offset: 0x00A276BC
		public BP_SM_TaskRandomMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskRandomMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070EF RID: 28911
		// (get) Token: 0x0602CD07 RID: 183559 RVA: 0x00A294F0 File Offset: 0x00A276F0
		// (set) Token: 0x0602CD08 RID: 183560 RVA: 0x00A29529 File Offset: 0x00A27729
		public TArray<string> MontageNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MontageNames) == null)
				{
					result = (this._MontageNames = new TArray<string>(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.MontageNames.CopyAssign(value);
			}
		}

		// Token: 0x170070F0 RID: 28912
		// (get) Token: 0x0602CD09 RID: 183561 RVA: 0x00A29537 File Offset: 0x00A27737
		// (set) Token: 0x0602CD0A RID: 183562 RVA: 0x00A29547 File Offset: 0x00A27747
		public unsafe bool 加载期间隐藏模型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070F1 RID: 28913
		// (get) Token: 0x0602CD0B RID: 183563 RVA: 0x00A29558 File Offset: 0x00A27758
		// (set) Token: 0x0602CD0C RID: 183564 RVA: 0x00A29568 File Offset: 0x00A27768
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070F2 RID: 28914
		// (get) Token: 0x0602CD0D RID: 183565 RVA: 0x00A29579 File Offset: 0x00A27779
		// (set) Token: 0x0602CD0E RID: 183566 RVA: 0x00A29589 File Offset: 0x00A27789
		public unsafe int BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170070F3 RID: 28915
		// (get) Token: 0x0602CD0F RID: 183567 RVA: 0x00A2959A File Offset: 0x00A2779A
		// (set) Token: 0x0602CD10 RID: 183568 RVA: 0x00A295AA File Offset: 0x00A277AA
		public unsafe bool 客户端随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CD11 RID: 183569 RVA: 0x00A295BB File Offset: 0x00A277BB
		protected BP_SM_TaskRandomMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A44 RID: 96836
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskRandomMontage.BP_SM_TaskRandomMontage_C";

		// Token: 0x04017A45 RID: 96837
		private static IntPtr _ClassPtr;

		// Token: 0x04017A46 RID: 96838
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A47 RID: 96839
		internal static int __PropertyOffset_0;

		// Token: 0x04017A48 RID: 96840
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MontageNames;

		// Token: 0x04017A49 RID: 96841
		internal static int __PropertyOffset_1;

		// Token: 0x04017A4A RID: 96842
		internal static int __PropertyOffset_2;

		// Token: 0x04017A4B RID: 96843
		internal static int __PropertyOffset_3;

		// Token: 0x04017A4C RID: 96844
		internal static int __PropertyOffset_4;
	}
}
