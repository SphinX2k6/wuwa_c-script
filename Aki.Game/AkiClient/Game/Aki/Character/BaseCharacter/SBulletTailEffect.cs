using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042FD RID: 17149
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletTailEffect.SBulletTailEffect")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class SBulletTailEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C522 RID: 181538 RVA: 0x00A1D08E File Offset: 0x00A1B28E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletTailEffect._ScriptStructPtr != 0) ? SBulletTailEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletTailEffect.SBulletTailEffect", ref SBulletTailEffect._ScriptStructPtr);
		}

		// Token: 0x17006EB5 RID: 28341
		// (get) Token: 0x0602C523 RID: 181539 RVA: 0x00A1D0B2 File Offset: 0x00A1B2B2
		// (set) Token: 0x0602C524 RID: 181540 RVA: 0x00A1D0C6 File Offset: 0x00A1B2C6
		public unsafe FTransform 子弹拖尾特效位置相对偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletTailEffect.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletTailEffect.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006EB6 RID: 28342
		// (get) Token: 0x0602C525 RID: 181541 RVA: 0x00A1D0DB File Offset: 0x00A1B2DB
		// (set) Token: 0x0602C526 RID: 181542 RVA: 0x00A1D0EB File Offset: 0x00A1B2EB
		public unsafe float 子弹拖尾特效相对击中或发出时延迟销毁时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletTailEffect.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletTailEffect.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602C527 RID: 181543 RVA: 0x00A1D0FC File Offset: 0x00A1B2FC
		public SBulletTailEffect()
		{
		}

		// Token: 0x0602C528 RID: 181544 RVA: 0x00A1D104 File Offset: 0x00A1B304
		public SBulletTailEffect(FTransform 子弹拖尾特效位置相对偏移, float 子弹拖尾特效相对击中或发出时延迟销毁时间)
		{
			this.子弹拖尾特效位置相对偏移 = 子弹拖尾特效位置相对偏移;
			this.子弹拖尾特效相对击中或发出时延迟销毁时间 = 子弹拖尾特效相对击中或发出时延迟销毁时间;
		}

		// Token: 0x0602C529 RID: 181545 RVA: 0x00A1D11A File Offset: 0x00A1B31A
		protected override IntPtr GetUStructPtr()
		{
			return SBulletTailEffect.StaticStruct();
		}

		// Token: 0x0602C52A RID: 181546 RVA: 0x00A1D126 File Offset: 0x00A1B326
		[NullableContext(2)]
		public SBulletTailEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C52B RID: 181547 RVA: 0x00A1D130 File Offset: 0x00A1B330
		public SBulletTailEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C52C RID: 181548 RVA: 0x00A1D13B File Offset: 0x00A1B33B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletTailEffect(Pointer, false, true);
		}

		// Token: 0x0602C52D RID: 181549 RVA: 0x00A1D145 File Offset: 0x00A1B345
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletTailEffect(Pointer, MemoryOwner);
		}

		// Token: 0x040175EB RID: 95723
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletTailEffect.SBulletTailEffect";

		// Token: 0x040175EC RID: 95724
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175ED RID: 95725
		internal static int __PropertyOffset_0;

		// Token: 0x040175EE RID: 95726
		internal static int __PropertyOffset_1;
	}
}
