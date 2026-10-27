using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A30 RID: 14896
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/SSequencesKeyFrames.SSequencesKeyFrames")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class SSequencesKeyFrames : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5CC RID: 128460 RVA: 0x008B66C7 File Offset: 0x008B48C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequencesKeyFrames._ScriptStructPtr != 0) ? SSequencesKeyFrames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/SSequencesKeyFrames.SSequencesKeyFrames", ref SSequencesKeyFrames._ScriptStructPtr);
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x0601F5CD RID: 128461 RVA: 0x008B66EC File Offset: 0x008B48EC
		// (set) Token: 0x0601F5CE RID: 128462 RVA: 0x008B672F File Offset: 0x008B492F
		public TArray<int> SubtitleStartFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SubtitleStartFrames) == null)
				{
					result = (this._SubtitleStartFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubtitleStartFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0601F5CF RID: 128463 RVA: 0x008B6740 File Offset: 0x008B4940
		// (set) Token: 0x0601F5D0 RID: 128464 RVA: 0x008B6783 File Offset: 0x008B4983
		public TArray<int> SubtitleEndFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SubtitleEndFrames) == null)
				{
					result = (this._SubtitleEndFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubtitleEndFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x0601F5D1 RID: 128465 RVA: 0x008B6794 File Offset: 0x008B4994
		// (set) Token: 0x0601F5D2 RID: 128466 RVA: 0x008B67D7 File Offset: 0x008B49D7
		public TArray<int> ShotStartFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ShotStartFrames) == null)
				{
					result = (this._ShotStartFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShotStartFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x0601F5D3 RID: 128467 RVA: 0x008B67E8 File Offset: 0x008B49E8
		// (set) Token: 0x0601F5D4 RID: 128468 RVA: 0x008B682B File Offset: 0x008B4A2B
		public TArray<int> ShotEndFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ShotEndFrames) == null)
				{
					result = (this._ShotEndFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShotEndFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x0601F5D5 RID: 128469 RVA: 0x008B683C File Offset: 0x008B4A3C
		// (set) Token: 0x0601F5D6 RID: 128470 RVA: 0x008B687F File Offset: 0x008B4A7F
		public TMap<string, int> FrameEventFrames
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._FrameEventFrames) == null)
				{
					result = (this._FrameEventFrames = new TMap<string, int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FrameEventFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x0601F5D7 RID: 128471 RVA: 0x008B6890 File Offset: 0x008B4A90
		// (set) Token: 0x0601F5D8 RID: 128472 RVA: 0x008B68D3 File Offset: 0x008B4AD3
		public TArray<int> KeyFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._KeyFrames) == null)
				{
					result = (this._KeyFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyFrames.CopyAssign(value);
			}
		}

		// Token: 0x0601F5D9 RID: 128473 RVA: 0x008B68E1 File Offset: 0x008B4AE1
		public SSequencesKeyFrames()
		{
		}

		// Token: 0x0601F5DA RID: 128474 RVA: 0x008B68E9 File Offset: 0x008B4AE9
		public SSequencesKeyFrames(TArray<int> SubtitleStartFrames, TArray<int> SubtitleEndFrames, TArray<int> ShotStartFrames, TArray<int> ShotEndFrames, TMap<string, int> FrameEventFrames, TArray<int> KeyFrames)
		{
			this.SubtitleStartFrames = SubtitleStartFrames;
			this.SubtitleEndFrames = SubtitleEndFrames;
			this.ShotStartFrames = ShotStartFrames;
			this.ShotEndFrames = ShotEndFrames;
			this.FrameEventFrames = FrameEventFrames;
			this.KeyFrames = KeyFrames;
		}

		// Token: 0x0601F5DB RID: 128475 RVA: 0x008B691E File Offset: 0x008B4B1E
		protected override IntPtr GetUStructPtr()
		{
			return SSequencesKeyFrames.StaticStruct();
		}

		// Token: 0x0601F5DC RID: 128476 RVA: 0x008B692A File Offset: 0x008B4B2A
		[NullableContext(2)]
		public SSequencesKeyFrames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5DD RID: 128477 RVA: 0x008B6934 File Offset: 0x008B4B34
		public SSequencesKeyFrames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5DE RID: 128478 RVA: 0x008B693F File Offset: 0x008B4B3F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequencesKeyFrames(Pointer, false, true);
		}

		// Token: 0x0601F5DF RID: 128479 RVA: 0x008B6949 File Offset: 0x008B4B49
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequencesKeyFrames(Pointer, MemoryOwner);
		}

		// Token: 0x0400F0ED RID: 61677
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/SSequencesKeyFrames.SSequencesKeyFrames";

		// Token: 0x0400F0EE RID: 61678
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F0EF RID: 61679
		internal static int __PropertyOffset_0;

		// Token: 0x0400F0F0 RID: 61680
		[Nullable(2)]
		private TArray<int> _SubtitleStartFrames;

		// Token: 0x0400F0F1 RID: 61681
		internal static int __PropertyOffset_1;

		// Token: 0x0400F0F2 RID: 61682
		[Nullable(2)]
		private TArray<int> _SubtitleEndFrames;

		// Token: 0x0400F0F3 RID: 61683
		internal static int __PropertyOffset_2;

		// Token: 0x0400F0F4 RID: 61684
		[Nullable(2)]
		private TArray<int> _ShotStartFrames;

		// Token: 0x0400F0F5 RID: 61685
		internal static int __PropertyOffset_3;

		// Token: 0x0400F0F6 RID: 61686
		[Nullable(2)]
		private TArray<int> _ShotEndFrames;

		// Token: 0x0400F0F7 RID: 61687
		internal static int __PropertyOffset_4;

		// Token: 0x0400F0F8 RID: 61688
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _FrameEventFrames;

		// Token: 0x0400F0F9 RID: 61689
		internal static int __PropertyOffset_5;

		// Token: 0x0400F0FA RID: 61690
		[Nullable(2)]
		private TArray<int> _KeyFrames;
	}
}
