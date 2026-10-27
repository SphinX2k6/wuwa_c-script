using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E2 RID: 2018
	public sealed class InfrLibraryPb : IMessage<InfrLibraryPb>, IMessage, IEquatable<InfrLibraryPb>, IDeepCloneable<InfrLibraryPb>, IBufferMessage
	{
		// Token: 0x0600B51C RID: 46364 RVA: 0x001B0A99 File Offset: 0x001AEC99
		[NullableContext(1)]
		public static InfrLibraryPb Create()
		{
			return new InfrLibraryPb();
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600B51D RID: 46365 RVA: 0x001B0AA0 File Offset: 0x001AECA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600B51E RID: 46366 RVA: 0x001B0AA3 File Offset: 0x001AECA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLibraryPb.Descriptor;
			}
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x001B0AAA File Offset: 0x001AECAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryPb()
		{
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x001B0AD4 File Offset: 0x001AECD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryPb(InfrLibraryPb other) : this()
		{
			this.archiveTasks_ = other.archiveTasks_.Clone();
			this.phoneTasks_ = other.phoneTasks_.Clone();
			this.unreadArchives_ = other.unreadArchives_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x001B0B2B File Offset: 0x001AED2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryPb Clone()
		{
			return new InfrLibraryPb(this);
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600B522 RID: 46370 RVA: 0x001B0B33 File Offset: 0x001AED33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> ArchiveTasks
		{
			get
			{
				return this.archiveTasks_;
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x0600B523 RID: 46371 RVA: 0x001B0B3B File Offset: 0x001AED3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> PhoneTasks
		{
			get
			{
				return this.phoneTasks_;
			}
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x0600B524 RID: 46372 RVA: 0x001B0B43 File Offset: 0x001AED43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnreadArchives
		{
			get
			{
				return this.unreadArchives_;
			}
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x001B0B4B File Offset: 0x001AED4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLibraryPb);
		}

		// Token: 0x0600B526 RID: 46374 RVA: 0x001B0B5C File Offset: 0x001AED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLibraryPb other)
		{
			return other != null && (other == this || (this.archiveTasks_.Equals(other.archiveTasks_) && this.phoneTasks_.Equals(other.phoneTasks_) && this.unreadArchives_.Equals(other.unreadArchives_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x001B0BC4 File Offset: 0x001AEDC4
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

		// Token: 0x0600B528 RID: 46376 RVA: 0x001B0C14 File Offset: 0x001AEE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B529 RID: 46377 RVA: 0x001B0C21 File Offset: 0x001AEE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B52A RID: 46378 RVA: 0x001B0C2C File Offset: 0x001AEE2C
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

		// Token: 0x0600B52B RID: 46379 RVA: 0x001B0C80 File Offset: 0x001AEE80
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

		// Token: 0x0600B52C RID: 46380 RVA: 0x001B0CE0 File Offset: 0x001AEEE0
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

		// Token: 0x0600B52D RID: 46381 RVA: 0x001B0D3B File Offset: 0x001AEF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B52E RID: 46382 RVA: 0x001B0D44 File Offset: 0x001AEF44
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

		// Token: 0x0400506D RID: 20589
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400506E RID: 20590
		public const int ArchiveTasksFieldNumber = 1;

		// Token: 0x0400506F RID: 20591
		private static readonly FieldCodec<InfrTaskPb> _repeated_archiveTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(10U, InfrTaskPb.Parser);

		// Token: 0x04005070 RID: 20592
		private readonly RepeatedField<InfrTaskPb> archiveTasks_ = new RepeatedField<InfrTaskPb>();

		// Token: 0x04005071 RID: 20593
		public const int PhoneTasksFieldNumber = 2;

		// Token: 0x04005072 RID: 20594
		private static readonly FieldCodec<InfrTaskPb> _repeated_phoneTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(18U, InfrTaskPb.Parser);

		// Token: 0x04005073 RID: 20595
		private readonly RepeatedField<InfrTaskPb> phoneTasks_ = new RepeatedField<InfrTaskPb>();

		// Token: 0x04005074 RID: 20596
		public const int UnreadArchivesFieldNumber = 3;

		// Token: 0x04005075 RID: 20597
		private static readonly FieldCodec<int> _repeated_unreadArchives_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005076 RID: 20598
		private readonly RepeatedField<int> unreadArchives_ = new RepeatedField<int>();
	}
}
