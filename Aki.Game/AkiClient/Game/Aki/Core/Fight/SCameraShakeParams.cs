using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200400D RID: 16397
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SCameraShakeParams.SCameraShakeParams")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SCameraShakeParams : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029FC7 RID: 171975 RVA: 0x009D2AC0 File Offset: 0x009D0CC0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraShakeParams._ScriptStructPtr != 0) ? SCameraShakeParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SCameraShakeParams.SCameraShakeParams", ref SCameraShakeParams._ScriptStructPtr);
		}

		// Token: 0x1700661F RID: 26143
		// (get) Token: 0x06029FC8 RID: 171976 RVA: 0x009D2AE4 File Offset: 0x009D0CE4
		// (set) Token: 0x06029FC9 RID: 171977 RVA: 0x009D2AF8 File Offset: 0x009D0CF8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UCameraShakeBase> 震屏配置
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraShakeParams.__PropertyOffset_0);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SCameraShakeParams.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006620 RID: 26144
		// (get) Token: 0x06029FCA RID: 171978 RVA: 0x009D2B0D File Offset: 0x009D0D0D
		// (set) Token: 0x06029FCB RID: 171979 RVA: 0x009D2B1D File Offset: 0x009D0D1D
		public unsafe bool bForSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraShakeParams.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraShakeParams.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006621 RID: 26145
		// (get) Token: 0x06029FCC RID: 171980 RVA: 0x009D2B2E File Offset: 0x009D0D2E
		// (set) Token: 0x06029FCD RID: 171981 RVA: 0x009D2B3E File Offset: 0x009D0D3E
		public unsafe float 衰减极限距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraShakeParams.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraShakeParams.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06029FCE RID: 171982 RVA: 0x009D2B4F File Offset: 0x009D0D4F
		public SCameraShakeParams()
		{
		}

		// Token: 0x06029FCF RID: 171983 RVA: 0x009D2B57 File Offset: 0x009D0D57
		public SCameraShakeParams([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> 震屏配置, bool bForSelf, float 衰减极限距离)
		{
			this.震屏配置 = 震屏配置;
			this.bForSelf = bForSelf;
			this.衰减极限距离 = 衰减极限距离;
		}

		// Token: 0x06029FD0 RID: 171984 RVA: 0x009D2B74 File Offset: 0x009D0D74
		protected override IntPtr GetUStructPtr()
		{
			return SCameraShakeParams.StaticStruct();
		}

		// Token: 0x06029FD1 RID: 171985 RVA: 0x009D2B80 File Offset: 0x009D0D80
		[NullableContext(2)]
		public SCameraShakeParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029FD2 RID: 171986 RVA: 0x009D2B8A File Offset: 0x009D0D8A
		public SCameraShakeParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029FD3 RID: 171987 RVA: 0x009D2B95 File Offset: 0x009D0D95
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraShakeParams(Pointer, false, true);
		}

		// Token: 0x06029FD4 RID: 171988 RVA: 0x009D2B9F File Offset: 0x009D0D9F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraShakeParams(Pointer, MemoryOwner);
		}

		// Token: 0x040159EF RID: 88559
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SCameraShakeParams.SCameraShakeParams";

		// Token: 0x040159F0 RID: 88560
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040159F1 RID: 88561
		internal static int __PropertyOffset_0;

		// Token: 0x040159F2 RID: 88562
		internal static int __PropertyOffset_1;

		// Token: 0x040159F3 RID: 88563
		internal static int __PropertyOffset_2;
	}
}
