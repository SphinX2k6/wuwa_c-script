using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E3 RID: 13027
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_KuroCheatManager.BP_KuroCheatManager_C")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class BP_KuroCheatManager_C : UCheatManager, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021172 RID: 135538 RVA: 0x00958DCF File Offset: 0x00956FCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCheatManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_KuroCheatManager.BP_KuroCheatManager_C");
			}
			return BP_KuroCheatManager_C._ClassPtr;
		}

		// Token: 0x06021173 RID: 135539 RVA: 0x00958DF4 File Offset: 0x00956FF4
		public BP_KuroCheatManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCheatManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021174 RID: 135540 RVA: 0x00958E1C File Offset: 0x0095701C
		public BP_KuroCheatManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCheatManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x06021175 RID: 135541 RVA: 0x00958E4F File Offset: 0x0095704F
		// (set) Token: 0x06021176 RID: 135542 RVA: 0x00958E63 File Offset: 0x00957063
		[Nullable(2)]
		public unsafe BP_CharacterController_C CharacterController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_CharacterController_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCheatManager_C.__PropertyOffset_CharacterController);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCheatManager_C.__PropertyOffset_CharacterController, value);
			}
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x06021177 RID: 135543 RVA: 0x00958E78 File Offset: 0x00957078
		// (set) Token: 0x06021178 RID: 135544 RVA: 0x00958EB1 File Offset: 0x009570B1
		public FKey 输入按键
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._输入按键) == null)
				{
					result = (this._输入按键 = new FKey(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_输入按键, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_输入按键, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x06021179 RID: 135545 RVA: 0x00958ED2 File Offset: 0x009570D2
		// (set) Token: 0x0602117A RID: 135546 RVA: 0x00958EE2 File Offset: 0x009570E2
		public unsafe bool 按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_按下) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_按下) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x0602117B RID: 135547 RVA: 0x00958EF3 File Offset: 0x009570F3
		// (set) Token: 0x0602117C RID: 135548 RVA: 0x00958F03 File Offset: 0x00957103
		public unsafe bool LeftAlt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_LeftAlt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_LeftAlt) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x0602117D RID: 135549 RVA: 0x00958F14 File Offset: 0x00957114
		// (set) Token: 0x0602117E RID: 135550 RVA: 0x00958F24 File Offset: 0x00957124
		public unsafe bool LeftCtrl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_LeftCtrl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_LeftCtrl) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x0602117F RID: 135551 RVA: 0x00958F35 File Offset: 0x00957135
		// (set) Token: 0x06021180 RID: 135552 RVA: 0x00958F45 File Offset: 0x00957145
		public unsafe float 全局TimeDilation倍数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_全局TimeDilation倍数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_全局TimeDilation倍数) = value;
			}
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x06021181 RID: 135553 RVA: 0x00958F56 File Offset: 0x00957156
		// (set) Token: 0x06021182 RID: 135554 RVA: 0x00958F66 File Offset: 0x00957166
		public unsafe float LastDebugPressTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_LastDebugPressTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_LastDebugPressTime) = value;
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x06021183 RID: 135555 RVA: 0x00958F77 File Offset: 0x00957177
		// (set) Token: 0x06021184 RID: 135556 RVA: 0x00958F87 File Offset: 0x00957187
		public unsafe bool DebugSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_DebugSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_DebugSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x06021185 RID: 135557 RVA: 0x00958F98 File Offset: 0x00957198
		// (set) Token: 0x06021186 RID: 135558 RVA: 0x00958FA8 File Offset: 0x009571A8
		public unsafe bool GhostMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_GhostMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_GhostMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x06021187 RID: 135559 RVA: 0x00958FBC File Offset: 0x009571BC
		// (set) Token: 0x06021188 RID: 135560 RVA: 0x00958FF5 File Offset: 0x009571F5
		public TSet<TsBaseCharacter> 被销毁怪物缓存
		{
			get
			{
				base.FastCheckIsValid();
				TSet<TsBaseCharacter> result;
				if ((result = this._被销毁怪物缓存) == null)
				{
					result = (this._被销毁怪物缓存 = new TSet<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_被销毁怪物缓存, this));
				}
				return result;
			}
			set
			{
				this.被销毁怪物缓存.CopyAssign(value);
			}
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x06021189 RID: 135561 RVA: 0x00959003 File Offset: 0x00957203
		// (set) Token: 0x0602118A RID: 135562 RVA: 0x00959013 File Offset: 0x00957213
		public unsafe float TouchDebugSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_TouchDebugSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_TouchDebugSize) = value;
			}
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x0602118B RID: 135563 RVA: 0x00959024 File Offset: 0x00957224
		// (set) Token: 0x0602118C RID: 135564 RVA: 0x00959034 File Offset: 0x00957234
		public unsafe bool 角色是否已强化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_角色是否已强化) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_角色是否已强化) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x0602118D RID: 135565 RVA: 0x00959045 File Offset: 0x00957245
		// (set) Token: 0x0602118E RID: 135566 RVA: 0x00959055 File Offset: 0x00957255
		public unsafe bool RightCtrl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_RightCtrl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_RightCtrl) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602118F RID: 135567 RVA: 0x00959068 File Offset: 0x00957268
		[SkipLocalsInit]
		public unsafe virtual void 强化或还原角色(bool 是否需要强化)
		{
			BP_KuroCheatManager_C.__强化或还原角色_FunctionParams* ptr = stackalloc BP_KuroCheatManager_C.__强化或还原角色_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroCheatManager_C.__强化或还原角色_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCheatManager_C.__强化或还原角色_NativeFunctionPtr, (void*)ptr, 1);
			ptr->是否需要强化 = 是否需要强化;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__强化或还原角色_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021190 RID: 135568 RVA: 0x009590AE File Offset: 0x009572AE
		[SkipLocalsInit]
		public virtual void TouchDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__TouchDebug_NativeFunctionPtr, null);
		}

		// Token: 0x06021191 RID: 135569 RVA: 0x009590C2 File Offset: 0x009572C2
		[SkipLocalsInit]
		public virtual void PrintTimeScale()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__PrintTimeScale_NativeFunctionPtr, null);
		}

		// Token: 0x06021192 RID: 135570 RVA: 0x009590D6 File Offset: 0x009572D6
		[SkipLocalsInit]
		public virtual void UpdateFunctionKey()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__UpdateFunctionKey_NativeFunctionPtr, null);
		}

		// Token: 0x06021193 RID: 135571 RVA: 0x009590EC File Offset: 0x009572EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 作弊指令(FKey 输入按键, bool 按下)
		{
			BP_KuroCheatManager_C.__作弊指令_FunctionParams* ptr = stackalloc BP_KuroCheatManager_C.__作弊指令_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(BP_KuroCheatManager_C.__作弊指令_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCheatManager_C.__作弊指令_NativeFunctionPtr, (void*)ptr, 1);
			if (输入按键 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->输入按键, 输入按键.NativePtr, 1, false);
			}
			ptr->按下 = 按下;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__作弊指令_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroCheatManager_C.__作弊指令_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021194 RID: 135572 RVA: 0x00959168 File Offset: 0x00957368
		[SkipLocalsInit]
		public override void ReceiveInitCheatManager()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__ReceiveInitCheatManager_NativeFunctionPtr, null);
		}

		// Token: 0x06021195 RID: 135573 RVA: 0x0095917C File Offset: 0x0095737C
		[SkipLocalsInit]
		protected virtual void ReceiveInitCheatManager_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCheatManager_C.__ReceiveInitCheatManager_NativeFunctionPtr, null);
		}

		// Token: 0x06021196 RID: 135574 RVA: 0x00959190 File Offset: 0x00957390
		protected BP_KuroCheatManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F43 RID: 73539
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_KuroCheatManager.BP_KuroCheatManager_C";

		// Token: 0x04011F44 RID: 73540
		private static IntPtr _ClassPtr;

		// Token: 0x04011F45 RID: 73541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F46 RID: 73542
		internal static int __PropertyOffset_CharacterController;

		// Token: 0x04011F47 RID: 73543
		internal static int __PropertyOffset_输入按键;

		// Token: 0x04011F48 RID: 73544
		[Nullable(2)]
		private FKey _输入按键;

		// Token: 0x04011F49 RID: 73545
		internal static int __PropertyOffset_按下;

		// Token: 0x04011F4A RID: 73546
		internal static int __PropertyOffset_LeftAlt;

		// Token: 0x04011F4B RID: 73547
		internal static int __PropertyOffset_LeftCtrl;

		// Token: 0x04011F4C RID: 73548
		internal static int __PropertyOffset_全局TimeDilation倍数;

		// Token: 0x04011F4D RID: 73549
		internal static int __PropertyOffset_LastDebugPressTime;

		// Token: 0x04011F4E RID: 73550
		internal static int __PropertyOffset_DebugSpeed;

		// Token: 0x04011F4F RID: 73551
		internal static int __PropertyOffset_GhostMode;

		// Token: 0x04011F50 RID: 73552
		internal static int __PropertyOffset_被销毁怪物缓存;

		// Token: 0x04011F51 RID: 73553
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<TsBaseCharacter> _被销毁怪物缓存;

		// Token: 0x04011F52 RID: 73554
		internal static int __PropertyOffset_TouchDebugSize;

		// Token: 0x04011F53 RID: 73555
		internal static int __PropertyOffset_角色是否已强化;

		// Token: 0x04011F54 RID: 73556
		internal static int __PropertyOffset_RightCtrl;

		// Token: 0x04011F55 RID: 73557
		private static IntPtr __强化或还原角色_NativeFunctionPtr;

		// Token: 0x04011F56 RID: 73558
		private static IntPtr __TouchDebug_NativeFunctionPtr;

		// Token: 0x04011F57 RID: 73559
		private static IntPtr __PrintTimeScale_NativeFunctionPtr;

		// Token: 0x04011F58 RID: 73560
		private static IntPtr __UpdateFunctionKey_NativeFunctionPtr;

		// Token: 0x04011F59 RID: 73561
		private static IntPtr __作弊指令_NativeFunctionPtr;

		// Token: 0x04011F5A RID: 73562
		private static IntPtr __ReceiveInitCheatManager_NativeFunctionPtr;

		// Token: 0x02009083 RID: 36995
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __强化或还原角色_FunctionParams
		{
			// Token: 0x0402CE96 RID: 183958
			[FieldOffset(0)]
			public bool 是否需要强化;
		}

		// Token: 0x02009084 RID: 36996
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __作弊指令_FunctionParams
		{
			// Token: 0x0402CE97 RID: 183959
			[FieldOffset(0)]
			public byte 输入按键;

			// Token: 0x0402CE98 RID: 183960
			[FieldOffset(32)]
			public bool 按下;
		}
	}
}
