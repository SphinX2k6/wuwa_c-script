using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F4 RID: 17140
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataChild.SBulletDataChild")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 21)]
	public class SBulletDataChild : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C46E RID: 181358 RVA: 0x00A1BF9C File Offset: 0x00A1A19C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataChild._ScriptStructPtr != 0) ? SBulletDataChild._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataChild.SBulletDataChild", ref SBulletDataChild._ScriptStructPtr);
		}

		// Token: 0x17006E7F RID: 28287
		// (get) Token: 0x0602C46F RID: 181359 RVA: 0x00A1BFC0 File Offset: 0x00A1A1C0
		// (set) Token: 0x0602C470 RID: 181360 RVA: 0x00A1BFD0 File Offset: 0x00A1A1D0
		public unsafe long 召唤子弹ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E80 RID: 28288
		// (get) Token: 0x0602C471 RID: 181361 RVA: 0x00A1BFE1 File Offset: 0x00A1A1E1
		// (set) Token: 0x0602C472 RID: 181362 RVA: 0x00A1BFF1 File Offset: 0x00A1A1F1
		public unsafe float 召唤子弹延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E81 RID: 28289
		// (get) Token: 0x0602C473 RID: 181363 RVA: 0x00A1C002 File Offset: 0x00A1A202
		// (set) Token: 0x0602C474 RID: 181364 RVA: 0x00A1C012 File Offset: 0x00A1A212
		public unsafe int 召唤子弹数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006E82 RID: 28290
		// (get) Token: 0x0602C475 RID: 181365 RVA: 0x00A1C023 File Offset: 0x00A1A223
		// (set) Token: 0x0602C476 RID: 181366 RVA: 0x00A1C033 File Offset: 0x00A1A233
		public unsafe float 召唤子弹间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006E83 RID: 28291
		// (get) Token: 0x0602C477 RID: 181367 RVA: 0x00A1C044 File Offset: 0x00A1A244
		// (set) Token: 0x0602C478 RID: 181368 RVA: 0x00A1C054 File Offset: 0x00A1A254
		public unsafe bool 销毁时生成子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataChild.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C479 RID: 181369 RVA: 0x00A1C065 File Offset: 0x00A1A265
		public SBulletDataChild()
		{
		}

		// Token: 0x0602C47A RID: 181370 RVA: 0x00A1C06D File Offset: 0x00A1A26D
		public SBulletDataChild(long 召唤子弹ID, float 召唤子弹延迟, int 召唤子弹数量, float 召唤子弹间隔, bool 销毁时生成子弹)
		{
			this.召唤子弹ID = 召唤子弹ID;
			this.召唤子弹延迟 = 召唤子弹延迟;
			this.召唤子弹数量 = 召唤子弹数量;
			this.召唤子弹间隔 = 召唤子弹间隔;
			this.销毁时生成子弹 = 销毁时生成子弹;
		}

		// Token: 0x0602C47B RID: 181371 RVA: 0x00A1C09A File Offset: 0x00A1A29A
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataChild.StaticStruct();
		}

		// Token: 0x0602C47C RID: 181372 RVA: 0x00A1C0A6 File Offset: 0x00A1A2A6
		[NullableContext(2)]
		public SBulletDataChild(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C47D RID: 181373 RVA: 0x00A1C0B0 File Offset: 0x00A1A2B0
		public SBulletDataChild(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C47E RID: 181374 RVA: 0x00A1C0BB File Offset: 0x00A1A2BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataChild(Pointer, false, true);
		}

		// Token: 0x0602C47F RID: 181375 RVA: 0x00A1C0C5 File Offset: 0x00A1A2C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataChild(Pointer, MemoryOwner);
		}

		// Token: 0x04017594 RID: 95636
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataChild.SBulletDataChild";

		// Token: 0x04017595 RID: 95637
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017596 RID: 95638
		internal static int __PropertyOffset_0;

		// Token: 0x04017597 RID: 95639
		internal static int __PropertyOffset_1;

		// Token: 0x04017598 RID: 95640
		internal static int __PropertyOffset_2;

		// Token: 0x04017599 RID: 95641
		internal static int __PropertyOffset_3;

		// Token: 0x0401759A RID: 95642
		internal static int __PropertyOffset_4;
	}
}
