using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA7 RID: 15783
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/RenderTargetListItem.RenderTargetListItem")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class RenderTargetListItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060272F4 RID: 160500 RVA: 0x0098A65D File Offset: 0x0098885D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RenderTargetListItem._ScriptStructPtr != 0) ? RenderTargetListItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/RenderTargetListItem.RenderTargetListItem", ref RenderTargetListItem._ScriptStructPtr);
		}

		// Token: 0x170056B4 RID: 22196
		// (get) Token: 0x060272F5 RID: 160501 RVA: 0x0098A681 File Offset: 0x00988881
		// (set) Token: 0x060272F6 RID: 160502 RVA: 0x0098A695 File Offset: 0x00988895
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + RenderTargetListItem.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + RenderTargetListItem.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170056B5 RID: 22197
		// (get) Token: 0x060272F7 RID: 160503 RVA: 0x0098A6AA File Offset: 0x009888AA
		// (set) Token: 0x060272F8 RID: 160504 RVA: 0x0098A6BA File Offset: 0x009888BA
		public unsafe bool free
		{
			get
			{
				return *(base.NativePtr + (IntPtr)RenderTargetListItem.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)RenderTargetListItem.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x060272F9 RID: 160505 RVA: 0x0098A6CB File Offset: 0x009888CB
		public RenderTargetListItem()
		{
		}

		// Token: 0x060272FA RID: 160506 RVA: 0x0098A6D3 File Offset: 0x009888D3
		[NullableContext(1)]
		public RenderTargetListItem(UTextureRenderTarget2D RT, bool free)
		{
			this.RT = RT;
			this.free = free;
		}

		// Token: 0x060272FB RID: 160507 RVA: 0x0098A6E9 File Offset: 0x009888E9
		protected override IntPtr GetUStructPtr()
		{
			return RenderTargetListItem.StaticStruct();
		}

		// Token: 0x060272FC RID: 160508 RVA: 0x0098A6F5 File Offset: 0x009888F5
		[NullableContext(2)]
		public RenderTargetListItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060272FD RID: 160509 RVA: 0x0098A6FF File Offset: 0x009888FF
		public RenderTargetListItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060272FE RID: 160510 RVA: 0x0098A70A File Offset: 0x0098890A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new RenderTargetListItem(Pointer, false, true);
		}

		// Token: 0x060272FF RID: 160511 RVA: 0x0098A714 File Offset: 0x00988914
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new RenderTargetListItem(Pointer, MemoryOwner);
		}

		// Token: 0x04013C24 RID: 80932
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/RenderTargetListItem.RenderTargetListItem";

		// Token: 0x04013C25 RID: 80933
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013C26 RID: 80934
		internal static int __PropertyOffset_0;

		// Token: 0x04013C27 RID: 80935
		internal static int __PropertyOffset_1;
	}
}
