using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003077 RID: 12407
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/SSequencesKeyFrames.SSequencesKeyFrames")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class SSequencesKeyFrames : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D94A RID: 121162 RVA: 0x008FBE42 File Offset: 0x008FA042
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequencesKeyFrames._ScriptStructPtr != 0) ? SSequencesKeyFrames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/SSequencesKeyFrames.SSequencesKeyFrames", ref SSequencesKeyFrames._ScriptStructPtr);
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0601D94B RID: 121163 RVA: 0x008FBE68 File Offset: 0x008FA068
		// (set) Token: 0x0601D94C RID: 121164 RVA: 0x008FBEAB File Offset: 0x008FA0AB
		public TArray<int> SubtitleStartFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SubtitleStartFrames) == null)
				{
					result = (this._SubtitleStartFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_SubtitleStartFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubtitleStartFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0601D94D RID: 121165 RVA: 0x008FBEBC File Offset: 0x008FA0BC
		// (set) Token: 0x0601D94E RID: 121166 RVA: 0x008FBEFF File Offset: 0x008FA0FF
		public TArray<int> SubtitleEndFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SubtitleEndFrames) == null)
				{
					result = (this._SubtitleEndFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_SubtitleEndFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubtitleEndFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0601D94F RID: 121167 RVA: 0x008FBF10 File Offset: 0x008FA110
		// (set) Token: 0x0601D950 RID: 121168 RVA: 0x008FBF53 File Offset: 0x008FA153
		public TArray<int> ShotStartFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ShotStartFrames) == null)
				{
					result = (this._ShotStartFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_ShotStartFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShotStartFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0601D951 RID: 121169 RVA: 0x008FBF64 File Offset: 0x008FA164
		// (set) Token: 0x0601D952 RID: 121170 RVA: 0x008FBFA7 File Offset: 0x008FA1A7
		public TArray<int> ShotEndFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ShotEndFrames) == null)
				{
					result = (this._ShotEndFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_ShotEndFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShotEndFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0601D953 RID: 121171 RVA: 0x008FBFB8 File Offset: 0x008FA1B8
		// (set) Token: 0x0601D954 RID: 121172 RVA: 0x008FBFFB File Offset: 0x008FA1FB
		public TMap<string, int> FrameEventFrames
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._FrameEventFrames) == null)
				{
					result = (this._FrameEventFrames = new TMap<string, int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_FrameEventFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FrameEventFrames.CopyAssign(value);
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0601D955 RID: 121173 RVA: 0x008FC00C File Offset: 0x008FA20C
		// (set) Token: 0x0601D956 RID: 121174 RVA: 0x008FC04F File Offset: 0x008FA24F
		public TArray<int> KeyFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._KeyFrames) == null)
				{
					result = (this._KeyFrames = new TArray<int>(base.NativePtr + (IntPtr)SSequencesKeyFrames.__PropertyOffset_KeyFrames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyFrames.CopyAssign(value);
			}
		}

		// Token: 0x0601D957 RID: 121175 RVA: 0x008FC05D File Offset: 0x008FA25D
		public SSequencesKeyFrames()
		{
		}

		// Token: 0x0601D958 RID: 121176 RVA: 0x008FC065 File Offset: 0x008FA265
		protected override IntPtr GetUStructPtr()
		{
			return SSequencesKeyFrames.StaticStruct();
		}

		// Token: 0x0601D959 RID: 121177 RVA: 0x008FC071 File Offset: 0x008FA271
		[NullableContext(2)]
		public SSequencesKeyFrames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D95A RID: 121178 RVA: 0x008FC07B File Offset: 0x008FA27B
		public SSequencesKeyFrames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D95B RID: 121179 RVA: 0x008FC086 File Offset: 0x008FA286
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequencesKeyFrames(Pointer, false, true);
		}

		// Token: 0x0601D95C RID: 121180 RVA: 0x008FC090 File Offset: 0x008FA290
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequencesKeyFrames(Pointer, MemoryOwner);
		}

		// Token: 0x0400F965 RID: 63845
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/SSequencesKeyFrames.SSequencesKeyFrames";

		// Token: 0x0400F966 RID: 63846
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F967 RID: 63847
		internal static int __PropertyOffset_SubtitleStartFrames;

		// Token: 0x0400F968 RID: 63848
		[Nullable(2)]
		private TArray<int> _SubtitleStartFrames;

		// Token: 0x0400F969 RID: 63849
		internal static int __PropertyOffset_SubtitleEndFrames;

		// Token: 0x0400F96A RID: 63850
		[Nullable(2)]
		private TArray<int> _SubtitleEndFrames;

		// Token: 0x0400F96B RID: 63851
		internal static int __PropertyOffset_ShotStartFrames;

		// Token: 0x0400F96C RID: 63852
		[Nullable(2)]
		private TArray<int> _ShotStartFrames;

		// Token: 0x0400F96D RID: 63853
		internal static int __PropertyOffset_ShotEndFrames;

		// Token: 0x0400F96E RID: 63854
		[Nullable(2)]
		private TArray<int> _ShotEndFrames;

		// Token: 0x0400F96F RID: 63855
		internal static int __PropertyOffset_FrameEventFrames;

		// Token: 0x0400F970 RID: 63856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _FrameEventFrames;

		// Token: 0x0400F971 RID: 63857
		internal static int __PropertyOffset_KeyFrames;

		// Token: 0x0400F972 RID: 63858
		[Nullable(2)]
		private TArray<int> _KeyFrames;
	}
}
