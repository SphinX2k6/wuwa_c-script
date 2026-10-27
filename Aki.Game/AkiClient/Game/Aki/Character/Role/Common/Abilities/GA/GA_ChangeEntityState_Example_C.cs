using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004121 RID: 16673
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_ChangeEntityState_Example.GA_ChangeEntityState_Example_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1556)]
	public class GA_ChangeEntityState_Example_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF2A RID: 175914 RVA: 0x009F0B80 File Offset: 0x009EED80
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_ChangeEntityState_Example_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_ChangeEntityState_Example.GA_ChangeEntityState_Example_C");
			}
			return GA_ChangeEntityState_Example_C._ClassPtr;
		}

		// Token: 0x0602AF2B RID: 175915 RVA: 0x009F0BA4 File Offset: 0x009EEDA4
		public GA_ChangeEntityState_Example_C() : this(BuiltinUtils.AllocNativeUObject(GA_ChangeEntityState_Example_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF2C RID: 175916 RVA: 0x009F0BCC File Offset: 0x009EEDCC
		public GA_ChangeEntityState_Example_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_ChangeEntityState_Example_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069D0 RID: 27088
		// (get) Token: 0x0602AF2D RID: 175917 RVA: 0x009F0BFF File Offset: 0x009EEDFF
		// (set) Token: 0x0602AF2E RID: 175918 RVA: 0x009F0C0F File Offset: 0x009EEE0F
		public unsafe bool 命中目标
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069D1 RID: 27089
		// (get) Token: 0x0602AF2F RID: 175919 RVA: 0x009F0C20 File Offset: 0x009EEE20
		// (set) Token: 0x0602AF30 RID: 175920 RVA: 0x009F0C30 File Offset: 0x009EEE30
		public unsafe int 施法者实体id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170069D2 RID: 27090
		// (get) Token: 0x0602AF31 RID: 175921 RVA: 0x009F0C44 File Offset: 0x009EEE44
		// (set) Token: 0x0602AF32 RID: 175922 RVA: 0x009F0C7D File Offset: 0x009EEE7D
		public TArray<int> 卡牌实体id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._卡牌实体id) == null)
				{
					result = (this._卡牌实体id = new TArray<int>(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.卡牌实体id.CopyAssign(value);
			}
		}

		// Token: 0x170069D3 RID: 27091
		// (get) Token: 0x0602AF33 RID: 175923 RVA: 0x009F0C8C File Offset: 0x009EEE8C
		// (set) Token: 0x0602AF34 RID: 175924 RVA: 0x009F0CC5 File Offset: 0x009EEEC5
		public TArray<string> 卡牌黑板数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._卡牌黑板数组) == null)
				{
					result = (this._卡牌黑板数组 = new TArray<string>(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.卡牌黑板数组.CopyAssign(value);
			}
		}

		// Token: 0x170069D4 RID: 27092
		// (get) Token: 0x0602AF35 RID: 175925 RVA: 0x009F0CD3 File Offset: 0x009EEED3
		// (set) Token: 0x0602AF36 RID: 175926 RVA: 0x009F0CE3 File Offset: 0x009EEEE3
		public unsafe int 随机卡牌
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_ChangeEntityState_Example_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602AF37 RID: 175927 RVA: 0x009F0CF4 File Offset: 0x009EEEF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_A8850AB04A2EE1E2656E5FB4035E8B6F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_ChangeEntityState_Example_C.__OnFinish_A8850AB04A2EE1E2656E5FB4035E8B6F_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF38 RID: 175928 RVA: 0x009F0D08 File Offset: 0x009EEF08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_ChangeEntityState_Example_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF39 RID: 175929 RVA: 0x009F0D1C File Offset: 0x009EEF1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_ChangeEntityState_Example_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF3A RID: 175930 RVA: 0x009F0D31 File Offset: 0x009EEF31
		protected GA_ChangeEntityState_Example_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401643D RID: 91197
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_ChangeEntityState_Example.GA_ChangeEntityState_Example_C";

		// Token: 0x0401643E RID: 91198
		private static IntPtr _ClassPtr;

		// Token: 0x0401643F RID: 91199
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016440 RID: 91200
		internal new static int __PropertyOffset_1;

		// Token: 0x04016441 RID: 91201
		internal new static int __PropertyOffset_2;

		// Token: 0x04016442 RID: 91202
		internal new static int __PropertyOffset_3;

		// Token: 0x04016443 RID: 91203
		[Nullable(2)]
		private TArray<int> _卡牌实体id;

		// Token: 0x04016444 RID: 91204
		internal static int __PropertyOffset_4;

		// Token: 0x04016445 RID: 91205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _卡牌黑板数组;

		// Token: 0x04016446 RID: 91206
		internal static int __PropertyOffset_5;

		// Token: 0x04016447 RID: 91207
		private static IntPtr __OnFinish_A8850AB04A2EE1E2656E5FB4035E8B6F_NativeFunctionPtr;

		// Token: 0x04016448 RID: 91208
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
