using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F5 RID: 17141
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataCollision.SBulletDataCollision")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 14)]
	public class SBulletDataCollision : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C480 RID: 181376 RVA: 0x00A1C0CE File Offset: 0x00A1A2CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataCollision._ScriptStructPtr != 0) ? SBulletDataCollision._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataCollision.SBulletDataCollision", ref SBulletDataCollision._ScriptStructPtr);
		}

		// Token: 0x17006E84 RID: 28292
		// (get) Token: 0x0602C481 RID: 181377 RVA: 0x00A1C0F2 File Offset: 0x00A1A2F2
		// (set) Token: 0x0602C482 RID: 181378 RVA: 0x00A1C106 File Offset: 0x00A1A306
		public unsafe FName 子弹碰撞预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataCollision.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataCollision.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E85 RID: 28293
		// (get) Token: 0x0602C483 RID: 181379 RVA: 0x00A1C11B File Offset: 0x00A1A31B
		// (set) Token: 0x0602C484 RID: 181380 RVA: 0x00A1C12B File Offset: 0x00A1A32B
		public unsafe bool 子弹碰撞障碍销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataCollision.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataCollision.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E86 RID: 28294
		// (get) Token: 0x0602C485 RID: 181381 RVA: 0x00A1C13C File Offset: 0x00A1A33C
		// (set) Token: 0x0602C486 RID: 181382 RVA: 0x00A1C14C File Offset: 0x00A1A34C
		public unsafe bool 子弹碰撞单位销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataCollision.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataCollision.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C487 RID: 181383 RVA: 0x00A1C15D File Offset: 0x00A1A35D
		public SBulletDataCollision()
		{
		}

		// Token: 0x0602C488 RID: 181384 RVA: 0x00A1C165 File Offset: 0x00A1A365
		public SBulletDataCollision(FName 子弹碰撞预设, bool 子弹碰撞障碍销毁, bool 子弹碰撞单位销毁)
		{
			this.子弹碰撞预设 = 子弹碰撞预设;
			this.子弹碰撞障碍销毁 = 子弹碰撞障碍销毁;
			this.子弹碰撞单位销毁 = 子弹碰撞单位销毁;
		}

		// Token: 0x0602C489 RID: 181385 RVA: 0x00A1C182 File Offset: 0x00A1A382
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataCollision.StaticStruct();
		}

		// Token: 0x0602C48A RID: 181386 RVA: 0x00A1C18E File Offset: 0x00A1A38E
		[NullableContext(2)]
		public SBulletDataCollision(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C48B RID: 181387 RVA: 0x00A1C198 File Offset: 0x00A1A398
		public SBulletDataCollision(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C48C RID: 181388 RVA: 0x00A1C1A3 File Offset: 0x00A1A3A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataCollision(Pointer, false, true);
		}

		// Token: 0x0602C48D RID: 181389 RVA: 0x00A1C1AD File Offset: 0x00A1A3AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataCollision(Pointer, MemoryOwner);
		}

		// Token: 0x0401759B RID: 95643
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataCollision.SBulletDataCollision";

		// Token: 0x0401759C RID: 95644
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401759D RID: 95645
		internal static int __PropertyOffset_0;

		// Token: 0x0401759E RID: 95646
		internal static int __PropertyOffset_1;

		// Token: 0x0401759F RID: 95647
		internal static int __PropertyOffset_2;
	}
}
