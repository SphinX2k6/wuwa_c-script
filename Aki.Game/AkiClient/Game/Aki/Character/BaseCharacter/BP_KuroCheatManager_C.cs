using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004280 RID: 17024
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_KuroCheatManager.BP_KuroCheatManager_C")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class BP_KuroCheatManager_C : UCheatManager, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C321 RID: 181025 RVA: 0x00A19A60 File Offset: 0x00A17C60
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCheatManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_KuroCheatManager.BP_KuroCheatManager_C");
			}
			return BP_KuroCheatManager_C._ClassPtr;
		}

		// Token: 0x0602C322 RID: 181026 RVA: 0x00A19A84 File Offset: 0x00A17C84
		public BP_KuroCheatManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCheatManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C323 RID: 181027 RVA: 0x00A19AAC File Offset: 0x00A17CAC
		public BP_KuroCheatManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCheatManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E18 RID: 28184
		// (get) Token: 0x0602C324 RID: 181028 RVA: 0x00A19ADF File Offset: 0x00A17CDF
		// (set) Token: 0x0602C325 RID: 181029 RVA: 0x00A19AF3 File Offset: 0x00A17CF3
		[Nullable(2)]
		public unsafe BP_CharacterController_C CharacterController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_CharacterController_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCheatManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCheatManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006E19 RID: 28185
		// (get) Token: 0x0602C326 RID: 181030 RVA: 0x00A19B08 File Offset: 0x00A17D08
		// (set) Token: 0x0602C327 RID: 181031 RVA: 0x00A19B41 File Offset: 0x00A17D41
		public FKey 输入按键
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._输入按键) == null)
				{
					result = (this._输入按键 = new FKey(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E1A RID: 28186
		// (get) Token: 0x0602C328 RID: 181032 RVA: 0x00A19B62 File Offset: 0x00A17D62
		// (set) Token: 0x0602C329 RID: 181033 RVA: 0x00A19B72 File Offset: 0x00A17D72
		public unsafe bool 按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E1B RID: 28187
		// (get) Token: 0x0602C32A RID: 181034 RVA: 0x00A19B83 File Offset: 0x00A17D83
		// (set) Token: 0x0602C32B RID: 181035 RVA: 0x00A19B93 File Offset: 0x00A17D93
		public unsafe bool LeftAlt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E1C RID: 28188
		// (get) Token: 0x0602C32C RID: 181036 RVA: 0x00A19BA4 File Offset: 0x00A17DA4
		// (set) Token: 0x0602C32D RID: 181037 RVA: 0x00A19BB4 File Offset: 0x00A17DB4
		public unsafe bool LeftCtrl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E1D RID: 28189
		// (get) Token: 0x0602C32E RID: 181038 RVA: 0x00A19BC5 File Offset: 0x00A17DC5
		// (set) Token: 0x0602C32F RID: 181039 RVA: 0x00A19BD5 File Offset: 0x00A17DD5
		public unsafe float 全局TimeDilation倍数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006E1E RID: 28190
		// (get) Token: 0x0602C330 RID: 181040 RVA: 0x00A19BE6 File Offset: 0x00A17DE6
		// (set) Token: 0x0602C331 RID: 181041 RVA: 0x00A19BF6 File Offset: 0x00A17DF6
		public unsafe float LastDebugPressTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006E1F RID: 28191
		// (get) Token: 0x0602C332 RID: 181042 RVA: 0x00A19C07 File Offset: 0x00A17E07
		// (set) Token: 0x0602C333 RID: 181043 RVA: 0x00A19C17 File Offset: 0x00A17E17
		public unsafe bool DebugSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E20 RID: 28192
		// (get) Token: 0x0602C334 RID: 181044 RVA: 0x00A19C28 File Offset: 0x00A17E28
		// (set) Token: 0x0602C335 RID: 181045 RVA: 0x00A19C38 File Offset: 0x00A17E38
		public unsafe bool GhostMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E21 RID: 28193
		// (get) Token: 0x0602C336 RID: 181046 RVA: 0x00A19C4C File Offset: 0x00A17E4C
		// (set) Token: 0x0602C337 RID: 181047 RVA: 0x00A19C85 File Offset: 0x00A17E85
		public TSet<TsBaseCharacter> 被销毁怪物缓存
		{
			get
			{
				base.FastCheckIsValid();
				TSet<TsBaseCharacter> result;
				if ((result = this._被销毁怪物缓存) == null)
				{
					result = (this._被销毁怪物缓存 = new TSet<TsBaseCharacter>(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.被销毁怪物缓存.CopyAssign(value);
			}
		}

		// Token: 0x17006E22 RID: 28194
		// (get) Token: 0x0602C338 RID: 181048 RVA: 0x00A19C93 File Offset: 0x00A17E93
		// (set) Token: 0x0602C339 RID: 181049 RVA: 0x00A19CA3 File Offset: 0x00A17EA3
		public unsafe float TouchDebugSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006E23 RID: 28195
		// (get) Token: 0x0602C33A RID: 181050 RVA: 0x00A19CB4 File Offset: 0x00A17EB4
		// (set) Token: 0x0602C33B RID: 181051 RVA: 0x00A19CC4 File Offset: 0x00A17EC4
		public unsafe bool 角色是否已强化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E24 RID: 28196
		// (get) Token: 0x0602C33C RID: 181052 RVA: 0x00A19CD5 File Offset: 0x00A17ED5
		// (set) Token: 0x0602C33D RID: 181053 RVA: 0x00A19CE5 File Offset: 0x00A17EE5
		public unsafe bool RightCtrl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCheatManager_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C33E RID: 181054 RVA: 0x00A19CF8 File Offset: 0x00A17EF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 强化或还原角色(bool 是否需要强化)
		{
			BP_KuroCheatManager_C.__强化或还原角色_FunctionParams* ptr = stackalloc BP_KuroCheatManager_C.__强化或还原角色_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroCheatManager_C.__强化或还原角色_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCheatManager_C.__强化或还原角色_NativeFunctionPtr, (void*)ptr, 1);
			ptr->是否需要强化 = 是否需要强化;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__强化或还原角色_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C33F RID: 181055 RVA: 0x00A19D3E File Offset: 0x00A17F3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TouchDebug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__TouchDebug_NativeFunctionPtr, null);
		}

		// Token: 0x0602C340 RID: 181056 RVA: 0x00A19D52 File Offset: 0x00A17F52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PrintTimeScale()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__PrintTimeScale_NativeFunctionPtr, null);
		}

		// Token: 0x0602C341 RID: 181057 RVA: 0x00A19D66 File Offset: 0x00A17F66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFunctionKey()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__UpdateFunctionKey_NativeFunctionPtr, null);
		}

		// Token: 0x0602C342 RID: 181058 RVA: 0x00A19D7C File Offset: 0x00A17F7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602C343 RID: 181059 RVA: 0x00A19DF8 File Offset: 0x00A17FF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveInitCheatManager()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCheatManager_C.__ReceiveInitCheatManager_NativeFunctionPtr, null);
		}

		// Token: 0x0602C344 RID: 181060 RVA: 0x00A19E0C File Offset: 0x00A1800C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveInitCheatManager_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCheatManager_C.__ReceiveInitCheatManager_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C345 RID: 181061 RVA: 0x00A19E21 File Offset: 0x00A18021
		protected BP_KuroCheatManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017218 RID: 94744
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_KuroCheatManager.BP_KuroCheatManager_C";

		// Token: 0x04017219 RID: 94745
		private static IntPtr _ClassPtr;

		// Token: 0x0401721A RID: 94746
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401721B RID: 94747
		internal static int __PropertyOffset_1;

		// Token: 0x0401721C RID: 94748
		internal static int __PropertyOffset_2;

		// Token: 0x0401721D RID: 94749
		[Nullable(2)]
		private FKey _输入按键;

		// Token: 0x0401721E RID: 94750
		internal static int __PropertyOffset_3;

		// Token: 0x0401721F RID: 94751
		internal static int __PropertyOffset_4;

		// Token: 0x04017220 RID: 94752
		internal static int __PropertyOffset_5;

		// Token: 0x04017221 RID: 94753
		internal static int __PropertyOffset_6;

		// Token: 0x04017222 RID: 94754
		internal static int __PropertyOffset_7;

		// Token: 0x04017223 RID: 94755
		internal static int __PropertyOffset_8;

		// Token: 0x04017224 RID: 94756
		internal static int __PropertyOffset_9;

		// Token: 0x04017225 RID: 94757
		internal static int __PropertyOffset_10;

		// Token: 0x04017226 RID: 94758
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<TsBaseCharacter> _被销毁怪物缓存;

		// Token: 0x04017227 RID: 94759
		internal static int __PropertyOffset_11;

		// Token: 0x04017228 RID: 94760
		internal static int __PropertyOffset_12;

		// Token: 0x04017229 RID: 94761
		internal static int __PropertyOffset_13;

		// Token: 0x0401722A RID: 94762
		internal static int __PropertyOffset_14;

		// Token: 0x0401722B RID: 94763
		private static IntPtr __强化或还原角色_NativeFunctionPtr;

		// Token: 0x0401722C RID: 94764
		private static IntPtr __TouchDebug_NativeFunctionPtr;

		// Token: 0x0401722D RID: 94765
		private static IntPtr __PrintTimeScale_NativeFunctionPtr;

		// Token: 0x0401722E RID: 94766
		private static IntPtr __UpdateFunctionKey_NativeFunctionPtr;

		// Token: 0x0401722F RID: 94767
		private static IntPtr __作弊指令_NativeFunctionPtr;

		// Token: 0x04017230 RID: 94768
		private static IntPtr __ReceiveInitCheatManager_NativeFunctionPtr;

		// Token: 0x0200A66D RID: 42605
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __强化或还原角色_FunctionParams
		{
			// Token: 0x040325A8 RID: 206248
			[FieldOffset(0)]
			public bool 是否需要强化;
		}

		// Token: 0x0200A66E RID: 42606
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __作弊指令_FunctionParams
		{
			// Token: 0x040325A9 RID: 206249
			[FieldOffset(0)]
			public byte 输入按键;

			// Token: 0x040325AA RID: 206250
			[FieldOffset(32)]
			public bool 按下;
		}
	}
}
