using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CE RID: 1998
	public sealed class InfrLibraryPb : IMessage<InfrLibraryPb>, IMessage, IEquatable<InfrLibraryPb>, IDeepCloneable<InfrLibraryPb>, IBufferMessage
	{
		// Token: 0x0600B3C6 RID: 46022 RVA: 0x001AE065 File Offset: 0x001AC265
		[NullableContext(1)]
		public static InfrLibraryPb Create()
		{
			return new InfrLibraryPb();
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600B3C7 RID: 46023 RVA: 0x001AE06C File Offset: 0x001AC26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600B3C8 RID: 46024 RVA: 0x001AE06F File Offset: 0x001AC26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLibraryPb.Descriptor;
			}
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x001AE076 File Offset: 0x001AC276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryPb()
		{
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x001AE0A0 File Offset: 0x001AC2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryPb(InfrLibraryPb other) : this()
		{
			this.archiveTasks_ = other.archiveTasks_.Clone();
			this.phoneTasks_ = other.phoneTasks_.Clone();
			this.unreadArchives_ = other.unreadArchives_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3CB RID: 46027 RVA: 0x001AE0F7 File Offset: 0x001AC2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryPb Clone()
		{
			return new InfrLibraryPb(this);
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600B3CC RID: 46028 RVA: 0x001AE0FF File Offset: 0x001AC2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> ArchiveTasks
		{
			get
			{
				return this.archiveTasks_;
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600B3CD RID: 46029 RVA: 0x001AE107 File Offset: 0x001AC307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> PhoneTasks
		{
			get
			{
				return this.phoneTasks_;
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x0600B3CE RID: 46030 RVA: 0x001AE10F File Offset: 0x001AC30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnreadArchives
		{
			get
			{
				return this.unreadArchives_;
			}
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x001AE117 File Offset: 0x001AC317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLibraryPb);
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x001AE128 File Offset: 0x001AC328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLibraryPb other)
		{
			return other != null && (other == this || (this.archiveTasks_.Equals(other.archiveTasks_) && this.phoneTasks_.Equals(other.phoneTasks_) && this.unreadArchives_.Equals(other.unreadArchives_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x001AE190 File Offset: 0x001AC390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.archiveTasks_.GetHashCode();
			num ^= this.phoneTasks_.GetHashCode();
			num ^= this.unreadArchives_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x001AE1E0 File Offset: 0x001AC3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x001AE1ED File Offset: 0x001AC3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x001AE1F8 File Offset: 0x001AC3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.archiveTasks_.WriteTo(ref output, InfrLibraryPb._repeated_archiveTasks_codec);
			this.phoneTasks_.WriteTo(ref output, InfrLibraryPb._repeated_phoneTasks_codec);
			this.unreadArchives_.WriteTo(ref output, InfrLibraryPb._repeated_unreadArchives_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x001AE24C File Offset: 0x001AC44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.archiveTasks_.CalculateSize(InfrLibraryPb._repeated_archiveTasks_codec);
			num += this.phoneTasks_.CalculateSize(InfrLibraryPb._repeated_phoneTasks_codec);
			num += this.unreadArchives_.CalculateSize(InfrLibraryPb._repeated_unreadArchives_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x001AE2AC File Offset: 0x001AC4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrLibraryPb other)
		{
			if (other == null)
			{
				return;
			}
			this.archiveTasks_.Add(other.archiveTasks_);
			this.phoneTasks_.Add(other.phoneTasks_);
			this.unreadArchives_.Add(other.unreadArchives_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x001AE307 File Offset: 0x001AC507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x001AE310 File Offset: 0x001AC510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.archiveTasks_.AddEntriesFrom(ref input, InfrLibraryPb._repeated_archiveTasks_codec);
						continue;
					}
					if (num == 18U)
					{
						this.phoneTasks_.AddEntriesFrom(ref input, InfrLibraryPb._repeated_phoneTasks_codec);
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.unreadArchives_.AddEntriesFrom(ref input, InfrLibraryPb._repeated_unreadArchives_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005066 RID: 20582
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005067 RID: 20583
		public const int ArchiveTasksFieldNumber = 1;

		// Token: 0x04005068 RID: 20584
		private static readonly FieldCodec<InfrTaskPb> _repeated_archiveTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(10U, InfrTaskPb.Parser);

		// Token: 0x04005069 RID: 20585
		private readonly RepeatedField<InfrTaskPb> archiveTasks_ = new RepeatedField<InfrTaskPb>();

		// Token: 0x0400506A RID: 20586
		public const int PhoneTasksFieldNumber = 2;

		// Token: 0x0400506B RID: 20587
		private static readonly FieldCodec<InfrTaskPb> _repeated_phoneTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(18U, InfrTaskPb.Parser);

		// Token: 0x0400506C RID: 20588
		private readonly RepeatedField<InfrTaskPb> phoneTasks_ = new RepeatedField<InfrTaskPb>();

		// Token: 0x0400506D RID: 20589
		public const int UnreadArchivesFieldNumber = 3;

		// Token: 0x0400506E RID: 20590
		private static readonly FieldCodec<int> _repeated_unreadArchives_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400506F RID: 20591
		private readonly RepeatedField<int> unreadArchives_ = new RepeatedField<int>();
	}
}
