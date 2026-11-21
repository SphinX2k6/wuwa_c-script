using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CF RID: 1999
	[NetMessage(EMessageId.InfrLibraryTaskUpdateNotify)]
	public sealed class InfrLibraryTaskUpdateNotify : IMessage<InfrLibraryTaskUpdateNotify>, IMessage, IEquatable<InfrLibraryTaskUpdateNotify>, IDeepCloneable<InfrLibraryTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B3DA RID: 46042 RVA: 0x001AE3C6 File Offset: 0x001AC5C6
		[NullableContext(1)]
		public static InfrLibraryTaskUpdateNotify Create()
		{
			return new InfrLibraryTaskUpdateNotify();
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600B3DB RID: 46043 RVA: 0x001AE3CD File Offset: 0x001AC5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x0600B3DC RID: 46044 RVA: 0x001AE3D0 File Offset: 0x001AC5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLibraryTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x001AE3D7 File Offset: 0x001AC5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryTaskUpdateNotify()
		{
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x001AE3F5 File Offset: 0x001AC5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryTaskUpdateNotify(InfrLibraryTaskUpdateNotify other) : this()
		{
			this.archiveTasks_ = other.archiveTasks_.Clone();
			this.phoneTasks_ = other.phoneTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x001AE430 File Offset: 0x001AC630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryTaskUpdateNotify Clone()
		{
			return new InfrLibraryTaskUpdateNotify(this);
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x001AE438 File Offset: 0x001AC638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> ArchiveTasks
		{
			get
			{
				return this.archiveTasks_;
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600B3E1 RID: 46049 RVA: 0x001AE440 File Offset: 0x001AC640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> PhoneTasks
		{
			get
			{
				return this.phoneTasks_;
			}
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x001AE448 File Offset: 0x001AC648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLibraryTaskUpdateNotify);
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x001AE458 File Offset: 0x001AC658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLibraryTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.archiveTasks_.Equals(other.archiveTasks_) && this.phoneTasks_.Equals(other.phoneTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x001AE4AC File Offset: 0x001AC6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.archiveTasks_.GetHashCode();
			num ^= this.phoneTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x001AE4EE File Offset: 0x001AC6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x001AE4FB File Offset: 0x001AC6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x001AE504 File Offset: 0x001AC704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.archiveTasks_.WriteTo(ref output, InfrLibraryTaskUpdateNotify._repeated_archiveTasks_codec);
			this.phoneTasks_.WriteTo(ref output, InfrLibraryTaskUpdateNotify._repeated_phoneTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x001AE53C File Offset: 0x001AC73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.archiveTasks_.CalculateSize(InfrLibraryTaskUpdateNotify._repeated_archiveTasks_codec);
			num += this.phoneTasks_.CalculateSize(InfrLibraryTaskUpdateNotify._repeated_phoneTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x001AE588 File Offset: 0x001AC788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrLibraryTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.archiveTasks_.Add(other.archiveTasks_);
			this.phoneTasks_.Add(other.phoneTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x001AE5C7 File Offset: 0x001AC7C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x001AE5D0 File Offset: 0x001AC7D0
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
				if (num != 82U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phoneTasks_.AddEntriesFrom(ref input, InfrLibraryTaskUpdateNotify._repeated_phoneTasks_codec);
					}
				}
				else
				{
					this.archiveTasks_.AddEntriesFrom(ref input, InfrLibraryTaskUpdateNotify._repeated_archiveTasks_codec);
				}
			}
		}

		// Token: 0x04005070 RID: 20592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005071 RID: 20593
		public const int ArchiveTasksFieldNumber = 10;

		// Token: 0x04005072 RID: 20594
		private static readonly FieldCodec<InfrTaskPb> _repeated_archiveTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(82U, InfrTaskPb.Parser);

		// Token: 0x04005073 RID: 20595
		private readonly RepeatedField<InfrTaskPb> archiveTasks_ = new RepeatedField<InfrTaskPb>();

		// Token: 0x04005074 RID: 20596
		public const int PhoneTasksFieldNumber = 14;

		// Token: 0x04005075 RID: 20597
		private static readonly FieldCodec<InfrTaskPb> _repeated_phoneTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(114U, InfrTaskPb.Parser);

		// Token: 0x04005076 RID: 20598
		private readonly RepeatedField<InfrTaskPb> phoneTasks_ = new RepeatedField<InfrTaskPb>();
	}
}
