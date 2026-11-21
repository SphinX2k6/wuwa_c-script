using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Interaction.Struct
{
	// Token: 0x020031D0 RID: 12752
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Struct/SInteractionConfig.SInteractionConfig")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 202)]
	public class SInteractionConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F9B4 RID: 129460 RVA: 0x0093160B File Offset: 0x0092F80B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractionConfig._ScriptStructPtr != 0) ? SInteractionConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Struct/SInteractionConfig.SInteractionConfig", ref SInteractionConfig._ScriptStructPtr);
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0601F9B5 RID: 129461 RVA: 0x0093162F File Offset: 0x0092F82F
		// (set) Token: 0x0601F9B6 RID: 129462 RVA: 0x00931643 File Offset: 0x0092F843
		public unsafe FName ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0601F9B7 RID: 129463 RVA: 0x00931658 File Offset: 0x0092F858
		// (set) Token: 0x0601F9B8 RID: 129464 RVA: 0x0093166C File Offset: 0x0092F86C
		public unsafe FName 组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_组ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_组ID) = value;
			}
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x0601F9B9 RID: 129465 RVA: 0x00931681 File Offset: 0x0092F881
		// (set) Token: 0x0601F9BA RID: 129466 RVA: 0x00931691 File Offset: 0x0092F891
		public unsafe bool 是否自动触发
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_是否自动触发) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_是否自动触发) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x0601F9BB RID: 129467 RVA: 0x009316A4 File Offset: 0x0092F8A4
		// (set) Token: 0x0601F9BC RID: 129468 RVA: 0x009316E7 File Offset: 0x0092F8E7
		public TArray<SInteractionOption> 交互选项组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInteractionOption> result;
				if ((result = this._交互选项组) == null)
				{
					result = (this._交互选项组 = new TArray<SInteractionOption>(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互选项组, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.交互选项组.CopyAssign(value);
			}
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x0601F9BD RID: 129469 RVA: 0x009316F5 File Offset: 0x0092F8F5
		// (set) Token: 0x0601F9BE RID: 129470 RVA: 0x00931709 File Offset: 0x0092F909
		public unsafe FName 交互SequenceNetwrokID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互SequenceNetwrokID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互SequenceNetwrokID) = value;
			}
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x0601F9BF RID: 129471 RVA: 0x0093171E File Offset: 0x0092F91E
		// (set) Token: 0x0601F9C0 RID: 129472 RVA: 0x0093173D File Offset: 0x0092F93D
		public TSoftObjectPtr<UDataTable> 交互SequenceNetwrok
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互SequenceNetwrok, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互SequenceNetwrok, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0601F9C1 RID: 129473 RVA: 0x00931762 File Offset: 0x0092F962
		// (set) Token: 0x0601F9C2 RID: 129474 RVA: 0x00931776 File Offset: 0x0092F976
		public unsafe FName 交互条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互条件组ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互条件组ID) = value;
			}
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0601F9C3 RID: 129475 RVA: 0x0093178B File Offset: 0x0092F98B
		// (set) Token: 0x0601F9C4 RID: 129476 RVA: 0x0093179B File Offset: 0x0092F99B
		public unsafe float 交互范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_交互范围) = value;
			}
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0601F9C5 RID: 129477 RVA: 0x009317AC File Offset: 0x0092F9AC
		// (set) Token: 0x0601F9C6 RID: 129478 RVA: 0x009317EF File Offset: 0x0092F9EF
		public unsafe FText 描述
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._描述) == null)
				{
					result = (this._描述 = new FText(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_描述, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionConfig.__PropertyOffset_描述)), value.NativePtr, 1);
			}
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0601F9C7 RID: 129479 RVA: 0x0093180A File Offset: 0x0092FA0A
		// (set) Token: 0x0601F9C8 RID: 129480 RVA: 0x00931829 File Offset: 0x0092FA29
		public TSoftObjectPtr<UTexture2D> 图标路径
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_图标路径, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_图标路径, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0601F9C9 RID: 129481 RVA: 0x0093184E File Offset: 0x0092FA4E
		// (set) Token: 0x0601F9CA RID: 129482 RVA: 0x0093185E File Offset: 0x0092FA5E
		public unsafe bool 是否添加离开选项
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_是否添加离开选项) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_是否添加离开选项) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F9CB RID: 129483 RVA: 0x0093186F File Offset: 0x0092FA6F
		public SInteractionConfig()
		{
		}

		// Token: 0x0601F9CC RID: 129484 RVA: 0x00931877 File Offset: 0x0092FA77
		protected override IntPtr GetUStructPtr()
		{
			return SInteractionConfig.StaticStruct();
		}

		// Token: 0x0601F9CD RID: 129485 RVA: 0x00931883 File Offset: 0x0092FA83
		[NullableContext(2)]
		public SInteractionConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F9CE RID: 129486 RVA: 0x0093188D File Offset: 0x0092FA8D
		public SInteractionConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F9CF RID: 129487 RVA: 0x00931898 File Offset: 0x0092FA98
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractionConfig(Pointer, false, true);
		}

		// Token: 0x0601F9D0 RID: 129488 RVA: 0x009318A2 File Offset: 0x0092FAA2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractionConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010F45 RID: 69445
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Struct/SInteractionConfig.SInteractionConfig";

		// Token: 0x04010F46 RID: 69446
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F47 RID: 69447
		internal static int __PropertyOffset_ID;

		// Token: 0x04010F48 RID: 69448
		internal static int __PropertyOffset_组ID;

		// Token: 0x04010F49 RID: 69449
		internal static int __PropertyOffset_是否自动触发;

		// Token: 0x04010F4A RID: 69450
		internal static int __PropertyOffset_交互选项组;

		// Token: 0x04010F4B RID: 69451
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInteractionOption> _交互选项组;

		// Token: 0x04010F4C RID: 69452
		internal static int __PropertyOffset_交互SequenceNetwrokID;

		// Token: 0x04010F4D RID: 69453
		internal static int __PropertyOffset_交互SequenceNetwrok;

		// Token: 0x04010F4E RID: 69454
		internal static int __PropertyOffset_交互条件组ID;

		// Token: 0x04010F4F RID: 69455
		internal static int __PropertyOffset_交互范围;

		// Token: 0x04010F50 RID: 69456
		internal static int __PropertyOffset_描述;

		// Token: 0x04010F51 RID: 69457
		[Nullable(2)]
		private FText _描述;

		// Token: 0x04010F52 RID: 69458
		internal static int __PropertyOffset_图标路径;

		// Token: 0x04010F53 RID: 69459
		internal static int __PropertyOffset_是否添加离开选项;
	}
}
