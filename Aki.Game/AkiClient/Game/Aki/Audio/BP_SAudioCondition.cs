using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004431 RID: 17457
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Audio/BP_SAudioCondition.BP_SAudioCondition")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class BP_SAudioCondition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D2DE RID: 185054 RVA: 0x00A35672 File Offset: 0x00A33872
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BP_SAudioCondition._ScriptStructPtr != 0) ? BP_SAudioCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Audio/BP_SAudioCondition.BP_SAudioCondition", ref BP_SAudioCondition._ScriptStructPtr);
		}

		// Token: 0x17007268 RID: 29288
		// (get) Token: 0x0602D2DF RID: 185055 RVA: 0x00A35696 File Offset: 0x00A33896
		// (set) Token: 0x0602D2E0 RID: 185056 RVA: 0x00A356AA File Offset: 0x00A338AA
		public unsafe TEnumAsByte<BP_EAudioCondition> 条件标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SAudioCondition.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SAudioCondition.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007269 RID: 29289
		// (get) Token: 0x0602D2E1 RID: 185057 RVA: 0x00A356BF File Offset: 0x00A338BF
		// (set) Token: 0x0602D2E2 RID: 185058 RVA: 0x00A356D3 File Offset: 0x00A338D3
		[Nullable(1)]
		public unsafe string 条件字段
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SAudioCondition.__PropertyOffset_1)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SAudioCondition.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x1700726A RID: 29290
		// (get) Token: 0x0602D2E3 RID: 185059 RVA: 0x00A356E8 File Offset: 0x00A338E8
		// (set) Token: 0x0602D2E4 RID: 185060 RVA: 0x00A356FC File Offset: 0x00A338FC
		[Nullable(2)]
		public unsafe UAkAudioEvent 进入音效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SAudioCondition.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SAudioCondition.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700726B RID: 29291
		// (get) Token: 0x0602D2E5 RID: 185061 RVA: 0x00A35711 File Offset: 0x00A33911
		// (set) Token: 0x0602D2E6 RID: 185062 RVA: 0x00A35725 File Offset: 0x00A33925
		[Nullable(2)]
		public unsafe UAkAudioEvent 离开音效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SAudioCondition.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SAudioCondition.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602D2E7 RID: 185063 RVA: 0x00A3573A File Offset: 0x00A3393A
		public BP_SAudioCondition()
		{
		}

		// Token: 0x0602D2E8 RID: 185064 RVA: 0x00A35742 File Offset: 0x00A33942
		[NullableContext(1)]
		public BP_SAudioCondition([Nullable(0)] TEnumAsByte<BP_EAudioCondition> 条件标签, string 条件字段, UAkAudioEvent 进入音效, UAkAudioEvent 离开音效)
		{
			this.条件标签 = 条件标签;
			this.条件字段 = 条件字段;
			this.进入音效 = 进入音效;
			this.离开音效 = 离开音效;
		}

		// Token: 0x0602D2E9 RID: 185065 RVA: 0x00A35767 File Offset: 0x00A33967
		protected override IntPtr GetUStructPtr()
		{
			return BP_SAudioCondition.StaticStruct();
		}

		// Token: 0x0602D2EA RID: 185066 RVA: 0x00A35773 File Offset: 0x00A33973
		[NullableContext(2)]
		public BP_SAudioCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D2EB RID: 185067 RVA: 0x00A3577D File Offset: 0x00A3397D
		public BP_SAudioCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D2EC RID: 185068 RVA: 0x00A35788 File Offset: 0x00A33988
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BP_SAudioCondition(Pointer, false, true);
		}

		// Token: 0x0602D2ED RID: 185069 RVA: 0x00A35792 File Offset: 0x00A33992
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BP_SAudioCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04018020 RID: 98336
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Audio/BP_SAudioCondition.BP_SAudioCondition";

		// Token: 0x04018021 RID: 98337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04018022 RID: 98338
		internal static int __PropertyOffset_0;

		// Token: 0x04018023 RID: 98339
		internal static int __PropertyOffset_1;

		// Token: 0x04018024 RID: 98340
		internal static int __PropertyOffset_2;

		// Token: 0x04018025 RID: 98341
		internal static int __PropertyOffset_3;
	}
}
