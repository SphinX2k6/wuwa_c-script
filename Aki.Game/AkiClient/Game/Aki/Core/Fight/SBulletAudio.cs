using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200400B RID: 16395
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SBulletAudio.SBulletAudio")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SBulletAudio : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029FAB RID: 171947 RVA: 0x009D28BC File Offset: 0x009D0ABC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletAudio._ScriptStructPtr != 0) ? SBulletAudio._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SBulletAudio.SBulletAudio", ref SBulletAudio._ScriptStructPtr);
		}

		// Token: 0x17006619 RID: 26137
		// (get) Token: 0x06029FAC RID: 171948 RVA: 0x009D28E0 File Offset: 0x009D0AE0
		// (set) Token: 0x06029FAD RID: 171949 RVA: 0x009D28FF File Offset: 0x009D0AFF
		public TSoftObjectPtr<UAkAudioEvent> 音效资源
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)SBulletAudio.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBulletAudio.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700661A RID: 26138
		// (get) Token: 0x06029FAE RID: 171950 RVA: 0x009D2924 File Offset: 0x009D0B24
		// (set) Token: 0x06029FAF RID: 171951 RVA: 0x009D2938 File Offset: 0x009D0B38
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBulletAudio.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBulletAudio.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x06029FB0 RID: 171952 RVA: 0x009D294D File Offset: 0x009D0B4D
		public SBulletAudio()
		{
		}

		// Token: 0x06029FB1 RID: 171953 RVA: 0x009D2955 File Offset: 0x009D0B55
		public SBulletAudio(TSoftObjectPtr<UAkAudioEvent> 音效资源, string 备注)
		{
			this.音效资源 = 音效资源;
			this.备注 = 备注;
		}

		// Token: 0x06029FB2 RID: 171954 RVA: 0x009D296B File Offset: 0x009D0B6B
		protected override IntPtr GetUStructPtr()
		{
			return SBulletAudio.StaticStruct();
		}

		// Token: 0x06029FB3 RID: 171955 RVA: 0x009D2977 File Offset: 0x009D0B77
		[NullableContext(2)]
		public SBulletAudio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029FB4 RID: 171956 RVA: 0x009D2981 File Offset: 0x009D0B81
		public SBulletAudio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029FB5 RID: 171957 RVA: 0x009D298C File Offset: 0x009D0B8C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletAudio(Pointer, false, true);
		}

		// Token: 0x06029FB6 RID: 171958 RVA: 0x009D2996 File Offset: 0x009D0B96
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletAudio(Pointer, MemoryOwner);
		}

		// Token: 0x040159E5 RID: 88549
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SBulletAudio.SBulletAudio";

		// Token: 0x040159E6 RID: 88550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040159E7 RID: 88551
		internal static int __PropertyOffset_0;

		// Token: 0x040159E8 RID: 88552
		internal static int __PropertyOffset_1;
	}
}
