using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004306 RID: 17158
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttackCamera.SCounterAttackCamera")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 408)]
	public class SCounterAttackCamera : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C5D7 RID: 181719 RVA: 0x00A1E23C File Offset: 0x00A1C43C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttackCamera._ScriptStructPtr != 0) ? SCounterAttackCamera._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttackCamera.SCounterAttackCamera", ref SCounterAttackCamera._ScriptStructPtr);
		}

		// Token: 0x17006EED RID: 28397
		// (get) Token: 0x0602C5D8 RID: 181720 RVA: 0x00A1E260 File Offset: 0x00A1C460
		// (set) Token: 0x0602C5D9 RID: 181721 RVA: 0x00A1E274 File Offset: 0x00A1C474
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006EEE RID: 28398
		// (get) Token: 0x0602C5DA RID: 181722 RVA: 0x00A1E289 File Offset: 0x00A1C489
		// (set) Token: 0x0602C5DB RID: 181723 RVA: 0x00A1E299 File Offset: 0x00A1C499
		public unsafe float 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006EEF RID: 28399
		// (get) Token: 0x0602C5DC RID: 181724 RVA: 0x00A1E2AA File Offset: 0x00A1C4AA
		// (set) Token: 0x0602C5DD RID: 181725 RVA: 0x00A1E2BA File Offset: 0x00A1C4BA
		public unsafe float 淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006EF0 RID: 28400
		// (get) Token: 0x0602C5DE RID: 181726 RVA: 0x00A1E2CB File Offset: 0x00A1C4CB
		// (set) Token: 0x0602C5DF RID: 181727 RVA: 0x00A1E2DB File Offset: 0x00A1C4DB
		public unsafe float 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006EF1 RID: 28401
		// (get) Token: 0x0602C5E0 RID: 181728 RVA: 0x00A1E2EC File Offset: 0x00A1C4EC
		// (set) Token: 0x0602C5E1 RID: 181729 RVA: 0x00A1E2FC File Offset: 0x00A1C4FC
		public unsafe float 打断淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006EF2 RID: 28402
		// (get) Token: 0x0602C5E2 RID: 181730 RVA: 0x00A1E30D File Offset: 0x00A1C50D
		// (set) Token: 0x0602C5E3 RID: 181731 RVA: 0x00A1E321 File Offset: 0x00A1C521
		public unsafe string CameraAttachSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCounterAttackCamera.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCounterAttackCamera.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17006EF3 RID: 28403
		// (get) Token: 0x0602C5E4 RID: 181732 RVA: 0x00A1E338 File Offset: 0x00A1C538
		// (set) Token: 0x0602C5E5 RID: 181733 RVA: 0x00A1E37B File Offset: 0x00A1C57B
		public SCameraModifier_Settings 摄像机配置
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._摄像机配置) == null)
				{
					result = (this._摄像机配置 = new SCameraModifier_Settings(base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackCamera.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C5E6 RID: 181734 RVA: 0x00A1E39C File Offset: 0x00A1C59C
		public SCounterAttackCamera()
		{
		}

		// Token: 0x0602C5E7 RID: 181735 RVA: 0x00A1E3A4 File Offset: 0x00A1C5A4
		public SCounterAttackCamera(FGameplayTag Tag, float 持续时间, float 淡入时间, float 淡出时间, float 打断淡出时间, string CameraAttachSocket, SCameraModifier_Settings 摄像机配置)
		{
			this.Tag = Tag;
			this.持续时间 = 持续时间;
			this.淡入时间 = 淡入时间;
			this.淡出时间 = 淡出时间;
			this.打断淡出时间 = 打断淡出时间;
			this.CameraAttachSocket = CameraAttachSocket;
			this.摄像机配置 = 摄像机配置;
		}

		// Token: 0x0602C5E8 RID: 181736 RVA: 0x00A1E3E1 File Offset: 0x00A1C5E1
		protected override IntPtr GetUStructPtr()
		{
			return SCounterAttackCamera.StaticStruct();
		}

		// Token: 0x0602C5E9 RID: 181737 RVA: 0x00A1E3ED File Offset: 0x00A1C5ED
		[NullableContext(2)]
		public SCounterAttackCamera(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C5EA RID: 181738 RVA: 0x00A1E3F7 File Offset: 0x00A1C5F7
		public SCounterAttackCamera(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C5EB RID: 181739 RVA: 0x00A1E402 File Offset: 0x00A1C602
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterAttackCamera(Pointer, false, true);
		}

		// Token: 0x0602C5EC RID: 181740 RVA: 0x00A1E40C File Offset: 0x00A1C60C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterAttackCamera(Pointer, MemoryOwner);
		}

		// Token: 0x0401764D RID: 95821
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttackCamera.SCounterAttackCamera";

		// Token: 0x0401764E RID: 95822
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401764F RID: 95823
		internal static int __PropertyOffset_0;

		// Token: 0x04017650 RID: 95824
		internal static int __PropertyOffset_1;

		// Token: 0x04017651 RID: 95825
		internal static int __PropertyOffset_2;

		// Token: 0x04017652 RID: 95826
		internal static int __PropertyOffset_3;

		// Token: 0x04017653 RID: 95827
		internal static int __PropertyOffset_4;

		// Token: 0x04017654 RID: 95828
		internal static int __PropertyOffset_5;

		// Token: 0x04017655 RID: 95829
		internal static int __PropertyOffset_6;

		// Token: 0x04017656 RID: 95830
		[Nullable(2)]
		private SCameraModifier_Settings _摄像机配置;
	}
}
