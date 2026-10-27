using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseSeqCharacter
{
	// Token: 0x02004270 RID: 17008
	[UnrealObjectPath("/Game/Aki/Character/BaseSeqCharacter/SeqAudio_Seq_V2.SeqAudio_Seq_V2_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 201)]
	public class SeqAudio_Seq_V2_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C1FC RID: 180732 RVA: 0x00A16DFB File Offset: 0x00A14FFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SeqAudio_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseSeqCharacter/SeqAudio_Seq_V2.SeqAudio_Seq_V2_C");
			}
			return SeqAudio_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602C1FD RID: 180733 RVA: 0x00A16E20 File Offset: 0x00A15020
		public SeqAudio_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(SeqAudio_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C1FE RID: 180734 RVA: 0x00A16E48 File Offset: 0x00A15048
		[NullableContext(1)]
		public SeqAudio_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SeqAudio_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DB1 RID: 28081
		// (get) Token: 0x0602C1FF RID: 180735 RVA: 0x00A16E7B File Offset: 0x00A1507B
		// (set) Token: 0x0602C200 RID: 180736 RVA: 0x00A16E8B File Offset: 0x00A1508B
		public unsafe bool UseAudioSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SeqAudio_Seq_V2_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SeqAudio_Seq_V2_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C201 RID: 180737 RVA: 0x00A16E9C File Offset: 0x00A1509C
		protected SeqAudio_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401715B RID: 94555
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseSeqCharacter/SeqAudio_Seq_V2.SeqAudio_Seq_V2_C";

		// Token: 0x0401715C RID: 94556
		private static IntPtr _ClassPtr;

		// Token: 0x0401715D RID: 94557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401715E RID: 94558
		internal static int __PropertyOffset_0;
	}
}
