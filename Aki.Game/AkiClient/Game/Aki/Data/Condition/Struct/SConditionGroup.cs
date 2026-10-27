using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Condition.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Condition.Struct
{
	// Token: 0x02003FA0 RID: 16288
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Condition/Struct/SConditionGroup.SConditionGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SConditionGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060299C8 RID: 170440 RVA: 0x009C894F File Offset: 0x009C6B4F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SConditionGroup._ScriptStructPtr != 0) ? SConditionGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Condition/Struct/SConditionGroup.SConditionGroup", ref SConditionGroup._ScriptStructPtr);
		}

		// Token: 0x17006434 RID: 25652
		// (get) Token: 0x060299C9 RID: 170441 RVA: 0x009C8973 File Offset: 0x009C6B73
		// (set) Token: 0x060299CA RID: 170442 RVA: 0x009C8987 File Offset: 0x009C6B87
		public unsafe FName 条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SConditionGroup.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SConditionGroup.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006435 RID: 25653
		// (get) Token: 0x060299CB RID: 170443 RVA: 0x009C899C File Offset: 0x009C6B9C
		// (set) Token: 0x060299CC RID: 170444 RVA: 0x009C89B0 File Offset: 0x009C6BB0
		[Nullable(0)]
		public unsafe TEnumAsByte<SConditionGroupType> 条件组策略
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SConditionGroup.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SConditionGroup.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006436 RID: 25654
		// (get) Token: 0x060299CD RID: 170445 RVA: 0x009C89C8 File Offset: 0x009C6BC8
		// (set) Token: 0x060299CE RID: 170446 RVA: 0x009C8A0B File Offset: 0x009C6C0B
		public TArray<SCondition> 条件组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCondition> result;
				if ((result = this._条件组) == null)
				{
					result = (this._条件组 = new TArray<SCondition>(base.NativePtr + (IntPtr)SConditionGroup.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.条件组.CopyAssign(value);
			}
		}

		// Token: 0x17006437 RID: 25655
		// (get) Token: 0x060299CF RID: 170447 RVA: 0x009C8A1C File Offset: 0x009C6C1C
		// (set) Token: 0x060299D0 RID: 170448 RVA: 0x009C8A5F File Offset: 0x009C6C5F
		public unsafe FText 拦截提示
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._拦截提示) == null)
				{
					result = (this._拦截提示 = new FText(base.NativePtr + (IntPtr)SConditionGroup.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SConditionGroup.__PropertyOffset_3)), value.NativePtr, 1);
			}
		}

		// Token: 0x17006438 RID: 25656
		// (get) Token: 0x060299D1 RID: 170449 RVA: 0x009C8A7C File Offset: 0x009C6C7C
		// (set) Token: 0x060299D2 RID: 170450 RVA: 0x009C8ABF File Offset: 0x009C6CBF
		public unsafe FText 条件组描述
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._条件组描述) == null)
				{
					result = (this._条件组描述 = new FText(base.NativePtr + (IntPtr)SConditionGroup.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SConditionGroup.__PropertyOffset_4)), value.NativePtr, 1);
			}
		}

		// Token: 0x060299D3 RID: 170451 RVA: 0x009C8ADA File Offset: 0x009C6CDA
		public SConditionGroup()
		{
		}

		// Token: 0x060299D4 RID: 170452 RVA: 0x009C8AE2 File Offset: 0x009C6CE2
		public SConditionGroup(FName 条件组ID, [Nullable(0)] TEnumAsByte<SConditionGroupType> 条件组策略, TArray<SCondition> 条件组, FText 拦截提示, FText 条件组描述)
		{
			this.条件组ID = 条件组ID;
			this.条件组策略 = 条件组策略;
			this.条件组 = 条件组;
			this.拦截提示 = 拦截提示;
			this.条件组描述 = 条件组描述;
		}

		// Token: 0x060299D5 RID: 170453 RVA: 0x009C8B0F File Offset: 0x009C6D0F
		protected override IntPtr GetUStructPtr()
		{
			return SConditionGroup.StaticStruct();
		}

		// Token: 0x060299D6 RID: 170454 RVA: 0x009C8B1B File Offset: 0x009C6D1B
		[NullableContext(2)]
		public SConditionGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060299D7 RID: 170455 RVA: 0x009C8B25 File Offset: 0x009C6D25
		public SConditionGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060299D8 RID: 170456 RVA: 0x009C8B30 File Offset: 0x009C6D30
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SConditionGroup(Pointer, false, true);
		}

		// Token: 0x060299D9 RID: 170457 RVA: 0x009C8B3A File Offset: 0x009C6D3A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SConditionGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0401559F RID: 87455
		public const string __ObjectPath = "/Game/Aki/Data/Condition/Struct/SConditionGroup.SConditionGroup";

		// Token: 0x040155A0 RID: 87456
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040155A1 RID: 87457
		internal static int __PropertyOffset_0;

		// Token: 0x040155A2 RID: 87458
		internal static int __PropertyOffset_1;

		// Token: 0x040155A3 RID: 87459
		internal static int __PropertyOffset_2;

		// Token: 0x040155A4 RID: 87460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCondition> _条件组;

		// Token: 0x040155A5 RID: 87461
		internal static int __PropertyOffset_3;

		// Token: 0x040155A6 RID: 87462
		[Nullable(2)]
		private FText _拦截提示;

		// Token: 0x040155A7 RID: 87463
		internal static int __PropertyOffset_4;

		// Token: 0x040155A8 RID: 87464
		[Nullable(2)]
		private FText _条件组描述;
	}
}
