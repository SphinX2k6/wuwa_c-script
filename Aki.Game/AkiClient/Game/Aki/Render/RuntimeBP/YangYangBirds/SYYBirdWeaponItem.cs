using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.YangYangBirds
{
	// Token: 0x02003A78 RID: 14968
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/YangYangBirds/SYYBirdWeaponItem.SYYBirdWeaponItem")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SYYBirdWeaponItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FB5B RID: 129883 RVA: 0x008C075A File Offset: 0x008BE95A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SYYBirdWeaponItem._ScriptStructPtr != 0) ? SYYBirdWeaponItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/YangYangBirds/SYYBirdWeaponItem.SYYBirdWeaponItem", ref SYYBirdWeaponItem._ScriptStructPtr);
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x0601FB5C RID: 129884 RVA: 0x008C077E File Offset: 0x008BE97E
		// (set) Token: 0x0601FB5D RID: 129885 RVA: 0x008C0792 File Offset: 0x008BE992
		public unsafe FVectorDouble Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SYYBirdWeaponItem.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SYYBirdWeaponItem.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0601FB5E RID: 129886 RVA: 0x008C07A7 File Offset: 0x008BE9A7
		// (set) Token: 0x0601FB5F RID: 129887 RVA: 0x008C07B7 File Offset: 0x008BE9B7
		public unsafe float LastRecordTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SYYBirdWeaponItem.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SYYBirdWeaponItem.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x0601FB60 RID: 129888 RVA: 0x008C07C8 File Offset: 0x008BE9C8
		// (set) Token: 0x0601FB61 RID: 129889 RVA: 0x008C07D8 File Offset: 0x008BE9D8
		public unsafe float Impaction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SYYBirdWeaponItem.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SYYBirdWeaponItem.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0601FB62 RID: 129890 RVA: 0x008C07E9 File Offset: 0x008BE9E9
		public SYYBirdWeaponItem()
		{
		}

		// Token: 0x0601FB63 RID: 129891 RVA: 0x008C07F1 File Offset: 0x008BE9F1
		public SYYBirdWeaponItem(FVectorDouble Position, float LastRecordTime, float Impaction)
		{
			this.Position = Position;
			this.LastRecordTime = LastRecordTime;
			this.Impaction = Impaction;
		}

		// Token: 0x0601FB64 RID: 129892 RVA: 0x008C080E File Offset: 0x008BEA0E
		protected override IntPtr GetUStructPtr()
		{
			return SYYBirdWeaponItem.StaticStruct();
		}

		// Token: 0x0601FB65 RID: 129893 RVA: 0x008C081A File Offset: 0x008BEA1A
		[NullableContext(2)]
		public SYYBirdWeaponItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FB66 RID: 129894 RVA: 0x008C0824 File Offset: 0x008BEA24
		public SYYBirdWeaponItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FB67 RID: 129895 RVA: 0x008C082F File Offset: 0x008BEA2F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SYYBirdWeaponItem(Pointer, false, true);
		}

		// Token: 0x0601FB68 RID: 129896 RVA: 0x008C0839 File Offset: 0x008BEA39
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SYYBirdWeaponItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400F458 RID: 62552
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/YangYangBirds/SYYBirdWeaponItem.SYYBirdWeaponItem";

		// Token: 0x0400F459 RID: 62553
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F45A RID: 62554
		internal static int __PropertyOffset_0;

		// Token: 0x0400F45B RID: 62555
		internal static int __PropertyOffset_1;

		// Token: 0x0400F45C RID: 62556
		internal static int __PropertyOffset_2;
	}
}
