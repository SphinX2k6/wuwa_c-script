using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F6 RID: 17142
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataEffect.SBulletDataEffect")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SBulletDataEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C48E RID: 181390 RVA: 0x00A1C1B6 File Offset: 0x00A1A3B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataEffect._ScriptStructPtr != 0) ? SBulletDataEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataEffect.SBulletDataEffect", ref SBulletDataEffect._ScriptStructPtr);
		}

		// Token: 0x17006E87 RID: 28295
		// (get) Token: 0x0602C48F RID: 181391 RVA: 0x00A1C1DA File Offset: 0x00A1A3DA
		// (set) Token: 0x0602C490 RID: 181392 RVA: 0x00A1C1F9 File Offset: 0x00A1A3F9
		public TSoftClassPtr<UMatineeCameraShake> 受击震屏
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SBulletDataEffect.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBulletDataEffect.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E88 RID: 28296
		// (get) Token: 0x0602C491 RID: 181393 RVA: 0x00A1C21E File Offset: 0x00A1A41E
		// (set) Token: 0x0602C492 RID: 181394 RVA: 0x00A1C22E File Offset: 0x00A1A42E
		public unsafe int 最大震动次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataEffect.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataEffect.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E89 RID: 28297
		// (get) Token: 0x0602C493 RID: 181395 RVA: 0x00A1C23F File Offset: 0x00A1A43F
		// (set) Token: 0x0602C494 RID: 181396 RVA: 0x00A1C24F File Offset: 0x00A1A44F
		public unsafe float 受击特效生成位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataEffect.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataEffect.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006E8A RID: 28298
		// (get) Token: 0x0602C495 RID: 181397 RVA: 0x00A1C260 File Offset: 0x00A1A460
		// (set) Token: 0x0602C496 RID: 181398 RVA: 0x00A1C2A3 File Offset: 0x00A1A4A3
		public TArray<SBulletTailEffect> 子弹拖尾特效
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBulletTailEffect> result;
				if ((result = this._子弹拖尾特效) == null)
				{
					result = (this._子弹拖尾特效 = new TArray<SBulletTailEffect>(base.NativePtr + (IntPtr)SBulletDataEffect.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.子弹拖尾特效.CopyAssign(value);
			}
		}

		// Token: 0x0602C497 RID: 181399 RVA: 0x00A1C2B1 File Offset: 0x00A1A4B1
		public SBulletDataEffect()
		{
		}

		// Token: 0x0602C498 RID: 181400 RVA: 0x00A1C2B9 File Offset: 0x00A1A4B9
		public SBulletDataEffect(TSoftClassPtr<UMatineeCameraShake> 受击震屏, int 最大震动次数, float 受击特效生成位置偏移, TArray<SBulletTailEffect> 子弹拖尾特效)
		{
			this.受击震屏 = 受击震屏;
			this.最大震动次数 = 最大震动次数;
			this.受击特效生成位置偏移 = 受击特效生成位置偏移;
			this.子弹拖尾特效 = 子弹拖尾特效;
		}

		// Token: 0x0602C499 RID: 181401 RVA: 0x00A1C2DE File Offset: 0x00A1A4DE
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataEffect.StaticStruct();
		}

		// Token: 0x0602C49A RID: 181402 RVA: 0x00A1C2EA File Offset: 0x00A1A4EA
		[NullableContext(2)]
		public SBulletDataEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C49B RID: 181403 RVA: 0x00A1C2F4 File Offset: 0x00A1A4F4
		public SBulletDataEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C49C RID: 181404 RVA: 0x00A1C2FF File Offset: 0x00A1A4FF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataEffect(Pointer, false, true);
		}

		// Token: 0x0602C49D RID: 181405 RVA: 0x00A1C309 File Offset: 0x00A1A509
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataEffect(Pointer, MemoryOwner);
		}

		// Token: 0x040175A0 RID: 95648
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataEffect.SBulletDataEffect";

		// Token: 0x040175A1 RID: 95649
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175A2 RID: 95650
		internal static int __PropertyOffset_0;

		// Token: 0x040175A3 RID: 95651
		internal static int __PropertyOffset_1;

		// Token: 0x040175A4 RID: 95652
		internal static int __PropertyOffset_2;

		// Token: 0x040175A5 RID: 95653
		internal static int __PropertyOffset_3;

		// Token: 0x040175A6 RID: 95654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBulletTailEffect> _子弹拖尾特效;
	}
}
