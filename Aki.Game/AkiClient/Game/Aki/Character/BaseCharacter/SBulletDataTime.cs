using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042FB RID: 17147
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataTime.SBulletDataTime")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SBulletDataTime : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C508 RID: 181512 RVA: 0x00A1CE04 File Offset: 0x00A1B004
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataTime._ScriptStructPtr != 0) ? SBulletDataTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataTime.SBulletDataTime", ref SBulletDataTime._ScriptStructPtr);
		}

		// Token: 0x17006EB0 RID: 28336
		// (get) Token: 0x0602C509 RID: 181513 RVA: 0x00A1CE28 File Offset: 0x00A1B028
		// (set) Token: 0x0602C50A RID: 181514 RVA: 0x00A1CE38 File Offset: 0x00A1B038
		public unsafe bool 是否受顿帧影响
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataTime.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataTime.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006EB1 RID: 28337
		// (get) Token: 0x0602C50B RID: 181515 RVA: 0x00A1CE4C File Offset: 0x00A1B04C
		// (set) Token: 0x0602C50C RID: 181516 RVA: 0x00A1CE8F File Offset: 0x00A1B08F
		public STimeScale 攻击顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._攻击顿帧) == null)
				{
					result = (this._攻击顿帧 = new STimeScale(base.NativePtr + (IntPtr)SBulletDataTime.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataTime.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EB2 RID: 28338
		// (get) Token: 0x0602C50D RID: 181517 RVA: 0x00A1CEB0 File Offset: 0x00A1B0B0
		// (set) Token: 0x0602C50E RID: 181518 RVA: 0x00A1CEF3 File Offset: 0x00A1B0F3
		public STimeScale 受击顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._受击顿帧) == null)
				{
					result = (this._受击顿帧 = new STimeScale(base.NativePtr + (IntPtr)SBulletDataTime.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataTime.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C50F RID: 181519 RVA: 0x00A1CF14 File Offset: 0x00A1B114
		public SBulletDataTime()
		{
		}

		// Token: 0x0602C510 RID: 181520 RVA: 0x00A1CF1C File Offset: 0x00A1B11C
		public SBulletDataTime(bool 是否受顿帧影响, STimeScale 攻击顿帧, STimeScale 受击顿帧)
		{
			this.是否受顿帧影响 = 是否受顿帧影响;
			this.攻击顿帧 = 攻击顿帧;
			this.受击顿帧 = 受击顿帧;
		}

		// Token: 0x0602C511 RID: 181521 RVA: 0x00A1CF39 File Offset: 0x00A1B139
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataTime.StaticStruct();
		}

		// Token: 0x0602C512 RID: 181522 RVA: 0x00A1CF45 File Offset: 0x00A1B145
		[NullableContext(2)]
		public SBulletDataTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C513 RID: 181523 RVA: 0x00A1CF4F File Offset: 0x00A1B14F
		public SBulletDataTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C514 RID: 181524 RVA: 0x00A1CF5A File Offset: 0x00A1B15A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataTime(Pointer, false, true);
		}

		// Token: 0x0602C515 RID: 181525 RVA: 0x00A1CF64 File Offset: 0x00A1B164
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataTime(Pointer, MemoryOwner);
		}

		// Token: 0x040175DF RID: 95711
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataTime.SBulletDataTime";

		// Token: 0x040175E0 RID: 95712
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175E1 RID: 95713
		internal static int __PropertyOffset_0;

		// Token: 0x040175E2 RID: 95714
		internal static int __PropertyOffset_1;

		// Token: 0x040175E3 RID: 95715
		[Nullable(2)]
		private STimeScale _攻击顿帧;

		// Token: 0x040175E4 RID: 95716
		internal static int __PropertyOffset_2;

		// Token: 0x040175E5 RID: 95717
		[Nullable(2)]
		private STimeScale _受击顿帧;
	}
}
