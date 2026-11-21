using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B5 RID: 13237
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskRandomMontage.BP_SM_TaskRandomMontage_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 73)]
	public class BP_SM_TaskRandomMontage_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602191A RID: 137498 RVA: 0x009641C7 File Offset: 0x009623C7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskRandomMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskRandomMontage.BP_SM_TaskRandomMontage_C");
			}
			return BP_SM_TaskRandomMontage_C._ClassPtr;
		}

		// Token: 0x0602191B RID: 137499 RVA: 0x009641EC File Offset: 0x009623EC
		public BP_SM_TaskRandomMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskRandomMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602191C RID: 137500 RVA: 0x00964214 File Offset: 0x00962414
		public BP_SM_TaskRandomMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskRandomMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x0602191D RID: 137501 RVA: 0x00964248 File Offset: 0x00962448
		// (set) Token: 0x0602191E RID: 137502 RVA: 0x00964281 File Offset: 0x00962481
		public TArray<string> MontageNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MontageNames) == null)
				{
					result = (this._MontageNames = new TArray<string>(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_MontageNames, this));
				}
				return result;
			}
			set
			{
				this.MontageNames.CopyAssign(value);
			}
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x0602191F RID: 137503 RVA: 0x0096428F File Offset: 0x0096248F
		// (set) Token: 0x06021920 RID: 137504 RVA: 0x0096429F File Offset: 0x0096249F
		public unsafe bool 加载期间隐藏模型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_加载期间隐藏模型) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_加载期间隐藏模型) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x06021921 RID: 137505 RVA: 0x009642B0 File Offset: 0x009624B0
		// (set) Token: 0x06021922 RID: 137506 RVA: 0x009642C0 File Offset: 0x009624C0
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_允许打断) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_允许打断) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x06021923 RID: 137507 RVA: 0x009642D1 File Offset: 0x009624D1
		// (set) Token: 0x06021924 RID: 137508 RVA: 0x009642E1 File Offset: 0x009624E1
		public unsafe int BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x06021925 RID: 137509 RVA: 0x009642F2 File Offset: 0x009624F2
		// (set) Token: 0x06021926 RID: 137510 RVA: 0x00964302 File Offset: 0x00962502
		public unsafe bool 客户端随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_客户端随机) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskRandomMontage_C.__PropertyOffset_客户端随机) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021927 RID: 137511 RVA: 0x00964313 File Offset: 0x00962513
		protected BP_SM_TaskRandomMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125BF RID: 75199
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskRandomMontage.BP_SM_TaskRandomMontage_C";

		// Token: 0x040125C0 RID: 75200
		private static IntPtr _ClassPtr;

		// Token: 0x040125C1 RID: 75201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125C2 RID: 75202
		internal static int __PropertyOffset_MontageNames;

		// Token: 0x040125C3 RID: 75203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MontageNames;

		// Token: 0x040125C4 RID: 75204
		internal static int __PropertyOffset_加载期间隐藏模型;

		// Token: 0x040125C5 RID: 75205
		internal static int __PropertyOffset_允许打断;

		// Token: 0x040125C6 RID: 75206
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x040125C7 RID: 75207
		internal static int __PropertyOffset_客户端随机;
	}
}
