using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x020032DC RID: 13020
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/SeqAudio_Seq_V2.SeqAudio_Seq_V2_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 201)]
	public class SeqAudio_Seq_V2_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060210A4 RID: 135332 RVA: 0x00957973 File Offset: 0x00955B73
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SeqAudio_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseSeqCharacter/SeqAudio_Seq_V2.SeqAudio_Seq_V2_C");
			}
			return SeqAudio_Seq_V2_C._ClassPtr;
		}

		// Token: 0x060210A5 RID: 135333 RVA: 0x00957998 File Offset: 0x00955B98
		public SeqAudio_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(SeqAudio_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060210A6 RID: 135334 RVA: 0x009579C0 File Offset: 0x00955BC0
		[NullableContext(1)]
		public SeqAudio_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SeqAudio_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x060210A7 RID: 135335 RVA: 0x009579F3 File Offset: 0x00955BF3
		// (set) Token: 0x060210A8 RID: 135336 RVA: 0x00957A03 File Offset: 0x00955C03
		public unsafe bool UseAudioSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SeqAudio_Seq_V2_C.__PropertyOffset_UseAudioSeq) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SeqAudio_Seq_V2_C.__PropertyOffset_UseAudioSeq) = (value ? 1 : 0);
			}
		}

		// Token: 0x060210A9 RID: 135337 RVA: 0x00957A14 File Offset: 0x00955C14
		protected SeqAudio_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011ECE RID: 73422
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/SeqAudio_Seq_V2.SeqAudio_Seq_V2_C";

		// Token: 0x04011ECF RID: 73423
		private static IntPtr _ClassPtr;

		// Token: 0x04011ED0 RID: 73424
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011ED1 RID: 73425
		internal static int __PropertyOffset_UseAudioSeq;
	}
}
