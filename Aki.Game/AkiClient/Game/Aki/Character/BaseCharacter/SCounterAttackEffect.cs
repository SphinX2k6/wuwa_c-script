using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004307 RID: 17159
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttackEffect.SCounterAttackEffect")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 524)]
	public class SCounterAttackEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C5ED RID: 181741 RVA: 0x00A1E415 File Offset: 0x00A1C615
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttackEffect._ScriptStructPtr != 0) ? SCounterAttackEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttackEffect.SCounterAttackEffect", ref SCounterAttackEffect._ScriptStructPtr);
		}

		// Token: 0x17006EF4 RID: 28404
		// (get) Token: 0x0602C5EE RID: 181742 RVA: 0x00A1E439 File Offset: 0x00A1C639
		// (set) Token: 0x0602C5EF RID: 181743 RVA: 0x00A1E44D File Offset: 0x00A1C64D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UCameraShakeBase> 震屏
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_0);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006EF5 RID: 28405
		// (get) Token: 0x0602C5F0 RID: 181744 RVA: 0x00A1E464 File Offset: 0x00A1C664
		// (set) Token: 0x0602C5F1 RID: 181745 RVA: 0x00A1E4A7 File Offset: 0x00A1C6A7
		public FSoftObjectPath 特效DA
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._特效DA) == null)
				{
					result = (this._特效DA = new FSoftObjectPath(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EF6 RID: 28406
		// (get) Token: 0x0602C5F2 RID: 181746 RVA: 0x00A1E4C8 File Offset: 0x00A1C6C8
		// (set) Token: 0x0602C5F3 RID: 181747 RVA: 0x00A1E50B File Offset: 0x00A1C70B
		public STimeScale 攻击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._攻击者顿帧) == null)
				{
					result = (this._攻击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EF7 RID: 28407
		// (get) Token: 0x0602C5F4 RID: 181748 RVA: 0x00A1E52C File Offset: 0x00A1C72C
		// (set) Token: 0x0602C5F5 RID: 181749 RVA: 0x00A1E56F File Offset: 0x00A1C76F
		public STimeScale 被击者顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._被击者顿帧) == null)
				{
					result = (this._被击者顿帧 = new STimeScale(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EF8 RID: 28408
		// (get) Token: 0x0602C5F6 RID: 181750 RVA: 0x00A1E590 File Offset: 0x00A1C790
		// (set) Token: 0x0602C5F7 RID: 181751 RVA: 0x00A1E5D3 File Offset: 0x00A1C7D3
		public SCounterAttackCamera 摄像机设置
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackCamera result;
				if ((result = this._摄像机设置) == null)
				{
					result = (this._摄像机设置 = new SCounterAttackCamera(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackCamera.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EF9 RID: 28409
		// (get) Token: 0x0602C5F8 RID: 181752 RVA: 0x00A1E5F4 File Offset: 0x00A1C7F4
		// (set) Token: 0x0602C5F9 RID: 181753 RVA: 0x00A1E608 File Offset: 0x00A1C808
		public unsafe FVector 特效Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006EFA RID: 28410
		// (get) Token: 0x0602C5FA RID: 181754 RVA: 0x00A1E61D File Offset: 0x00A1C81D
		// (set) Token: 0x0602C5FB RID: 181755 RVA: 0x00A1E631 File Offset: 0x00A1C831
		public unsafe FVector 特效Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006EFB RID: 28411
		// (get) Token: 0x0602C5FC RID: 181756 RVA: 0x00A1E646 File Offset: 0x00A1C846
		// (set) Token: 0x0602C5FD RID: 181757 RVA: 0x00A1E656 File Offset: 0x00A1C856
		public unsafe float 特效位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttackEffect.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602C5FE RID: 181758 RVA: 0x00A1E667 File Offset: 0x00A1C867
		public SCounterAttackEffect()
		{
		}

		// Token: 0x0602C5FF RID: 181759 RVA: 0x00A1E670 File Offset: 0x00A1C870
		public SCounterAttackEffect([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> 震屏, FSoftObjectPath 特效DA, STimeScale 攻击者顿帧, STimeScale 被击者顿帧, SCounterAttackCamera 摄像机设置, FVector 特效Offset, FVector 特效Scale, float 特效位置)
		{
			this.震屏 = 震屏;
			this.特效DA = 特效DA;
			this.攻击者顿帧 = 攻击者顿帧;
			this.被击者顿帧 = 被击者顿帧;
			this.摄像机设置 = 摄像机设置;
			this.特效Offset = 特效Offset;
			this.特效Scale = 特效Scale;
			this.特效位置 = 特效位置;
		}

		// Token: 0x0602C600 RID: 181760 RVA: 0x00A1E6C0 File Offset: 0x00A1C8C0
		protected override IntPtr GetUStructPtr()
		{
			return SCounterAttackEffect.StaticStruct();
		}

		// Token: 0x0602C601 RID: 181761 RVA: 0x00A1E6CC File Offset: 0x00A1C8CC
		[NullableContext(2)]
		public SCounterAttackEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C602 RID: 181762 RVA: 0x00A1E6D6 File Offset: 0x00A1C8D6
		public SCounterAttackEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C603 RID: 181763 RVA: 0x00A1E6E1 File Offset: 0x00A1C8E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterAttackEffect(Pointer, false, true);
		}

		// Token: 0x0602C604 RID: 181764 RVA: 0x00A1E6EB File Offset: 0x00A1C8EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterAttackEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04017657 RID: 95831
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttackEffect.SCounterAttackEffect";

		// Token: 0x04017658 RID: 95832
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017659 RID: 95833
		internal static int __PropertyOffset_0;

		// Token: 0x0401765A RID: 95834
		internal static int __PropertyOffset_1;

		// Token: 0x0401765B RID: 95835
		[Nullable(2)]
		private FSoftObjectPath _特效DA;

		// Token: 0x0401765C RID: 95836
		internal static int __PropertyOffset_2;

		// Token: 0x0401765D RID: 95837
		[Nullable(2)]
		private STimeScale _攻击者顿帧;

		// Token: 0x0401765E RID: 95838
		internal static int __PropertyOffset_3;

		// Token: 0x0401765F RID: 95839
		[Nullable(2)]
		private STimeScale _被击者顿帧;

		// Token: 0x04017660 RID: 95840
		internal static int __PropertyOffset_4;

		// Token: 0x04017661 RID: 95841
		[Nullable(2)]
		private SCounterAttackCamera _摄像机设置;

		// Token: 0x04017662 RID: 95842
		internal static int __PropertyOffset_5;

		// Token: 0x04017663 RID: 95843
		internal static int __PropertyOffset_6;

		// Token: 0x04017664 RID: 95844
		internal static int __PropertyOffset_7;
	}
}
