using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200432D RID: 17197
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBatchBullet.SSkillBehaviorBatchBullet")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 41)]
	public class SSkillBehaviorBatchBullet : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C8FD RID: 182525 RVA: 0x00A22C6C File Offset: 0x00A20E6C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorBatchBullet._ScriptStructPtr != 0) ? SSkillBehaviorBatchBullet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBatchBullet.SSkillBehaviorBatchBullet", ref SSkillBehaviorBatchBullet._ScriptStructPtr);
		}

		// Token: 0x17006FE7 RID: 28647
		// (get) Token: 0x0602C8FE RID: 182526 RVA: 0x00A22C90 File Offset: 0x00A20E90
		// (set) Token: 0x0602C8FF RID: 182527 RVA: 0x00A22CD3 File Offset: 0x00A20ED3
		[Nullable(1)]
		public TArray<string> Id
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Id) == null)
				{
					result = (this._Id = new TArray<string>(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Id.CopyAssign(value);
			}
		}

		// Token: 0x17006FE8 RID: 28648
		// (get) Token: 0x0602C900 RID: 182528 RVA: 0x00A22CE1 File Offset: 0x00A20EE1
		// (set) Token: 0x0602C901 RID: 182529 RVA: 0x00A22CF1 File Offset: 0x00A20EF1
		public unsafe int Number
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006FE9 RID: 28649
		// (get) Token: 0x0602C902 RID: 182530 RVA: 0x00A22D02 File Offset: 0x00A20F02
		// (set) Token: 0x0602C903 RID: 182531 RVA: 0x00A22D12 File Offset: 0x00A20F12
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006FEA RID: 28650
		// (get) Token: 0x0602C904 RID: 182532 RVA: 0x00A22D23 File Offset: 0x00A20F23
		// (set) Token: 0x0602C905 RID: 182533 RVA: 0x00A22D33 File Offset: 0x00A20F33
		public unsafe bool StopOnSkillEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006FEB RID: 28651
		// (get) Token: 0x0602C906 RID: 182534 RVA: 0x00A22D44 File Offset: 0x00A20F44
		// (set) Token: 0x0602C907 RID: 182535 RVA: 0x00A22D58 File Offset: 0x00A20F58
		public unsafe FGameplayTag ContinueWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006FEC RID: 28652
		// (get) Token: 0x0602C908 RID: 182536 RVA: 0x00A22D6D File Offset: 0x00A20F6D
		// (set) Token: 0x0602C909 RID: 182537 RVA: 0x00A22D81 File Offset: 0x00A20F81
		public unsafe TEnumAsByte<EBatchBulletMoveStartMode> StartMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602C90A RID: 182538 RVA: 0x00A22D96 File Offset: 0x00A20F96
		public SSkillBehaviorBatchBullet()
		{
		}

		// Token: 0x0602C90B RID: 182539 RVA: 0x00A22D9E File Offset: 0x00A20F9E
		public SSkillBehaviorBatchBullet([Nullable(1)] TArray<string> Id, int Number, float Interval, bool StopOnSkillEnd, FGameplayTag ContinueWithTag, TEnumAsByte<EBatchBulletMoveStartMode> StartMoving)
		{
			this.Id = Id;
			this.Number = Number;
			this.Interval = Interval;
			this.StopOnSkillEnd = StopOnSkillEnd;
			this.ContinueWithTag = ContinueWithTag;
			this.StartMoving = StartMoving;
		}

		// Token: 0x0602C90C RID: 182540 RVA: 0x00A22DD3 File Offset: 0x00A20FD3
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorBatchBullet.StaticStruct();
		}

		// Token: 0x0602C90D RID: 182541 RVA: 0x00A22DDF File Offset: 0x00A20FDF
		[NullableContext(2)]
		public SSkillBehaviorBatchBullet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C90E RID: 182542 RVA: 0x00A22DE9 File Offset: 0x00A20FE9
		public SSkillBehaviorBatchBullet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C90F RID: 182543 RVA: 0x00A22DF4 File Offset: 0x00A20FF4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorBatchBullet(Pointer, false, true);
		}

		// Token: 0x0602C910 RID: 182544 RVA: 0x00A22DFE File Offset: 0x00A20FFE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorBatchBullet(Pointer, MemoryOwner);
		}

		// Token: 0x040177D9 RID: 96217
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorBatchBullet.SSkillBehaviorBatchBullet";

		// Token: 0x040177DA RID: 96218
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040177DB RID: 96219
		internal static int __PropertyOffset_0;

		// Token: 0x040177DC RID: 96220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Id;

		// Token: 0x040177DD RID: 96221
		internal static int __PropertyOffset_1;

		// Token: 0x040177DE RID: 96222
		internal static int __PropertyOffset_2;

		// Token: 0x040177DF RID: 96223
		internal static int __PropertyOffset_3;

		// Token: 0x040177E0 RID: 96224
		internal static int __PropertyOffset_4;

		// Token: 0x040177E1 RID: 96225
		internal static int __PropertyOffset_5;
	}
}
