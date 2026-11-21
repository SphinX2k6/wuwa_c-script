using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Interaction.Struct
{
	// Token: 0x020031D1 RID: 12753
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Struct/SInteractionOption.SInteractionOption")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 241)]
	public class SInteractionOption : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F9D1 RID: 129489 RVA: 0x009318AB File Offset: 0x0092FAAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractionOption._ScriptStructPtr != 0) ? SInteractionOption._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Struct/SInteractionOption.SInteractionOption", ref SInteractionOption._ScriptStructPtr);
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0601F9D2 RID: 129490 RVA: 0x009318D0 File Offset: 0x0092FAD0
		// (set) Token: 0x0601F9D3 RID: 129491 RVA: 0x00931913 File Offset: 0x0092FB13
		public unsafe FText 选项内容
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._选项内容) == null)
				{
					result = (this._选项内容 = new FText(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_选项内容, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionOption.__PropertyOffset_选项内容)), value.NativePtr, 1);
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0601F9D4 RID: 129492 RVA: 0x0093192E File Offset: 0x0092FB2E
		// (set) Token: 0x0601F9D5 RID: 129493 RVA: 0x00931942 File Offset: 0x0092FB42
		public unsafe FName 解锁条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_解锁条件组ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_解锁条件组ID) = value;
			}
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0601F9D6 RID: 129494 RVA: 0x00931957 File Offset: 0x0092FB57
		// (set) Token: 0x0601F9D7 RID: 129495 RVA: 0x0093196B File Offset: 0x0092FB6B
		public unsafe FName 剧情ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_剧情ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_剧情ID) = value;
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0601F9D8 RID: 129496 RVA: 0x00931980 File Offset: 0x0092FB80
		// (set) Token: 0x0601F9D9 RID: 129497 RVA: 0x0093199F File Offset: 0x0092FB9F
		public TSoftObjectPtr<UDataTable> 剧情资源
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_剧情资源, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_剧情资源, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0601F9DA RID: 129498 RVA: 0x009319C4 File Offset: 0x0092FBC4
		// (set) Token: 0x0601F9DB RID: 129499 RVA: 0x009319D8 File Offset: 0x0092FBD8
		public unsafe string Plot
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionOption.__PropertyOffset_Plot)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionOption.__PropertyOffset_Plot)), value);
			}
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x0601F9DC RID: 129500 RVA: 0x009319ED File Offset: 0x0092FBED
		// (set) Token: 0x0601F9DD RID: 129501 RVA: 0x00931A01 File Offset: 0x0092FC01
		public unsafe FName 事件ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_事件ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_事件ID) = value;
			}
		}

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0601F9DE RID: 129502 RVA: 0x00931A16 File Offset: 0x0092FC16
		// (set) Token: 0x0601F9DF RID: 129503 RVA: 0x00931A26 File Offset: 0x0092FC26
		public unsafe bool 是否关闭交互界面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_是否关闭交互界面) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_是否关闭交互界面) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x0601F9E0 RID: 129504 RVA: 0x00931A37 File Offset: 0x0092FC37
		// (set) Token: 0x0601F9E1 RID: 129505 RVA: 0x00931A56 File Offset: 0x0092FC56
		public TSoftObjectPtr<UTexture2D> 图标路径
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_图标路径, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_图标路径, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F9E2 RID: 129506 RVA: 0x00931A7B File Offset: 0x0092FC7B
		public SInteractionOption()
		{
		}

		// Token: 0x0601F9E3 RID: 129507 RVA: 0x00931A83 File Offset: 0x0092FC83
		protected override IntPtr GetUStructPtr()
		{
			return SInteractionOption.StaticStruct();
		}

		// Token: 0x0601F9E4 RID: 129508 RVA: 0x00931A8F File Offset: 0x0092FC8F
		[NullableContext(2)]
		public SInteractionOption(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F9E5 RID: 129509 RVA: 0x00931A99 File Offset: 0x0092FC99
		public SInteractionOption(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F9E6 RID: 129510 RVA: 0x00931AA4 File Offset: 0x0092FCA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractionOption(Pointer, false, true);
		}

		// Token: 0x0601F9E7 RID: 129511 RVA: 0x00931AAE File Offset: 0x0092FCAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractionOption(Pointer, MemoryOwner);
		}

		// Token: 0x04010F54 RID: 69460
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Struct/SInteractionOption.SInteractionOption";

		// Token: 0x04010F55 RID: 69461
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F56 RID: 69462
		internal static int __PropertyOffset_选项内容;

		// Token: 0x04010F57 RID: 69463
		[Nullable(2)]
		private FText _选项内容;

		// Token: 0x04010F58 RID: 69464
		internal static int __PropertyOffset_解锁条件组ID;

		// Token: 0x04010F59 RID: 69465
		internal static int __PropertyOffset_剧情ID;

		// Token: 0x04010F5A RID: 69466
		internal static int __PropertyOffset_剧情资源;

		// Token: 0x04010F5B RID: 69467
		internal static int __PropertyOffset_Plot;

		// Token: 0x04010F5C RID: 69468
		internal static int __PropertyOffset_事件ID;

		// Token: 0x04010F5D RID: 69469
		internal static int __PropertyOffset_是否关闭交互界面;

		// Token: 0x04010F5E RID: 69470
		internal static int __PropertyOffset_图标路径;
	}
}
