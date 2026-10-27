using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003D9D RID: 15773
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaPreset.NinjaPreset")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class NinjaPreset : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027297 RID: 160407 RVA: 0x009899F4 File Offset: 0x00987BF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (NinjaPreset._ScriptStructPtr != 0) ? NinjaPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaPreset.NinjaPreset", ref NinjaPreset._ScriptStructPtr);
		}

		// Token: 0x170056AA RID: 22186
		// (get) Token: 0x06027298 RID: 160408 RVA: 0x00989A18 File Offset: 0x00987C18
		// (set) Token: 0x06027299 RID: 160409 RVA: 0x00989A2C File Offset: 0x00987C2C
		public unsafe string SourceString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaPreset.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaPreset.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x0602729A RID: 160410 RVA: 0x00989A41 File Offset: 0x00987C41
		public NinjaPreset()
		{
		}

		// Token: 0x0602729B RID: 160411 RVA: 0x00989A49 File Offset: 0x00987C49
		public NinjaPreset(string SourceString)
		{
			this.SourceString = SourceString;
		}

		// Token: 0x0602729C RID: 160412 RVA: 0x00989A58 File Offset: 0x00987C58
		protected override IntPtr GetUStructPtr()
		{
			return NinjaPreset.StaticStruct();
		}

		// Token: 0x0602729D RID: 160413 RVA: 0x00989A64 File Offset: 0x00987C64
		[NullableContext(2)]
		public NinjaPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602729E RID: 160414 RVA: 0x00989A6E File Offset: 0x00987C6E
		public NinjaPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602729F RID: 160415 RVA: 0x00989A79 File Offset: 0x00987C79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new NinjaPreset(Pointer, false, true);
		}

		// Token: 0x060272A0 RID: 160416 RVA: 0x00989A83 File Offset: 0x00987C83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new NinjaPreset(Pointer, MemoryOwner);
		}

		// Token: 0x04013BE2 RID: 80866
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaPreset.NinjaPreset";

		// Token: 0x04013BE3 RID: 80867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013BE4 RID: 80868
		internal static int __PropertyOffset_0;
	}
}
