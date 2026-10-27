using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI.ActorComponent
{
	// Token: 0x02003AA5 RID: 15013
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/ActorComponent/S_UIitemOffset.S_UIitemOffset")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class S_UIitemOffset : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602022B RID: 131627 RVA: 0x008CAAB5 File Offset: 0x008C8CB5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_UIitemOffset._ScriptStructPtr != 0) ? S_UIitemOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/UI/ActorComponent/S_UIitemOffset.S_UIitemOffset", ref S_UIitemOffset._ScriptStructPtr);
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0602022C RID: 131628 RVA: 0x008CAAD9 File Offset: 0x008C8CD9
		// (set) Token: 0x0602022D RID: 131629 RVA: 0x008CAAED File Offset: 0x008C8CED
		[Nullable(2)]
		public unsafe AUIBaseActor UIActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + S_UIitemOffset.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_UIitemOffset.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0602022E RID: 131630 RVA: 0x008CAB02 File Offset: 0x008C8D02
		// (set) Token: 0x0602022F RID: 131631 RVA: 0x008CAB16 File Offset: 0x008C8D16
		public unsafe FVector2D MaxOffsetXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_UIitemOffset.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_UIitemOffset.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06020230 RID: 131632 RVA: 0x008CAB2B File Offset: 0x008C8D2B
		public S_UIitemOffset()
		{
		}

		// Token: 0x06020231 RID: 131633 RVA: 0x008CAB33 File Offset: 0x008C8D33
		[NullableContext(1)]
		public S_UIitemOffset(AUIBaseActor UIActor, FVector2D MaxOffsetXY)
		{
			this.UIActor = UIActor;
			this.MaxOffsetXY = MaxOffsetXY;
		}

		// Token: 0x06020232 RID: 131634 RVA: 0x008CAB49 File Offset: 0x008C8D49
		protected override IntPtr GetUStructPtr()
		{
			return S_UIitemOffset.StaticStruct();
		}

		// Token: 0x06020233 RID: 131635 RVA: 0x008CAB55 File Offset: 0x008C8D55
		[NullableContext(2)]
		public S_UIitemOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020234 RID: 131636 RVA: 0x008CAB5F File Offset: 0x008C8D5F
		public S_UIitemOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020235 RID: 131637 RVA: 0x008CAB6A File Offset: 0x008C8D6A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_UIitemOffset(Pointer, false, true);
		}

		// Token: 0x06020236 RID: 131638 RVA: 0x008CAB74 File Offset: 0x008C8D74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_UIitemOffset(Pointer, MemoryOwner);
		}

		// Token: 0x0400F868 RID: 63592
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/ActorComponent/S_UIitemOffset.S_UIitemOffset";

		// Token: 0x0400F869 RID: 63593
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F86A RID: 63594
		internal static int __PropertyOffset_0;

		// Token: 0x0400F86B RID: 63595
		internal static int __PropertyOffset_1;
	}
}
