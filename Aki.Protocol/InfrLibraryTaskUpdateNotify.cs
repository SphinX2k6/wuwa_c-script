using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E3 RID: 2019
	[NetMessage(EMessageId.InfrLibraryTaskUpdateNotify)]
	public sealed class InfrLibraryTaskUpdateNotify : IMessage<InfrLibraryTaskUpdateNotify>, IMessage, IEquatable<InfrLibraryTaskUpdateNotify>, IDeepCloneable<InfrLibraryTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B530 RID: 46384 RVA: 0x001B0DFA File Offset: 0x001AEFFA
		[NullableContext(1)]
		public static InfrLibraryTaskUpdateNotify Create()
		{
			return new InfrLibraryTaskUpdateNotify();
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x0600B531 RID: 46385 RVA: 0x001B0E01 File Offset: 0x001AF001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x0600B532 RID: 46386 RVA: 0x001B0E04 File Offset: 0x001AF004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLibraryTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x001B0E0B File Offset: 0x001AF00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryTaskUpdateNotify()
		{
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x001B0E29 File Offset: 0x001AF029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryTaskUpdateNotify(InfrLibraryTaskUpdateNotify other) : this()
		{
			this.archiveTasks_ = other.archiveTasks_.Clone();
			this.phoneTasks_ = other.phoneTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B535 RID: 46389 RVA: 0x001B0E64 File Offset: 0x001AF064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLibraryTaskUpdateNotify Clone()
		{
			return new InfrLibraryTaskUpdateNotify(this);
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x0600B536 RID: 46390 RVA: 0x001B0E6C File Offset: 0x001AF06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> ArchiveTasks
		{
			get
			{
				return this.archiveTasks_;
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x0600B537 RID: 46391 RVA: 0x001B0E74 File Offset: 0x001AF074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrTaskPb> PhoneTasks
		{
			get
			{
				return this.phoneTasks_;
			}
		}

		// Token: 0x0600B538 RID: 46392 RVA: 0x001B0E7C File Offset: 0x001AF07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLibraryTaskUpdateNotify);
		}

		// Token: 0x0600B539 RID: 46393 RVA: 0x001B0E8C File Offset: 0x001AF08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLibraryTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.archiveTasks_.Equals(other.archiveTasks_) && this.phoneTasks_.Equals(other.phoneTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B53A RID: 46394 RVA: 0x001B0EE0 File Offset: 0x001AF0E0
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

		// Token: 0x0600B53B RID: 46395 RVA: 0x001B0F22 File Offset: 0x001AF122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B53C RID: 46396 RVA: 0x001B0F2F File Offset: 0x001AF12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x001B0F38 File Offset: 0x001AF138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phoneTasks_.WriteTo(ref output, InfrLibraryTaskUpdateNotify._repeated_phoneTasks_codec);
			this.archiveTasks_.WriteTo(ref output, InfrLibraryTaskUpdateNotify._repeated_archiveTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B53E RID: 46398 RVA: 0x001B0F70 File Offset: 0x001AF170
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

		// Token: 0x0600B53F RID: 46399 RVA: 0x001B0FBC File Offset: 0x001AF1BC
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

		// Token: 0x0600B540 RID: 46400 RVA: 0x001B0FFB File Offset: 0x001AF1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x001B1004 File Offset: 0x001AF204
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.archiveTasks_.AddEntriesFrom(ref input, InfrLibraryTaskUpdateNotify._repeated_archiveTasks_codec);
					}
				}
				else
				{
					this.phoneTasks_.AddEntriesFrom(ref input, InfrLibraryTaskUpdateNotify._repeated_phoneTasks_codec);
				}
			}
		}

		// Token: 0x04005077 RID: 20599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005078 RID: 20600
		public const int ArchiveTasksFieldNumber = 11;

		// Token: 0x04005079 RID: 20601
		private static readonly FieldCodec<InfrTaskPb> _repeated_archiveTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(90U, InfrTaskPb.Parser);

		// Token: 0x0400507A RID: 20602
		private readonly RepeatedField<InfrTaskPb> archiveTasks_ = new RepeatedField<InfrTaskPb>();

		// Token: 0x0400507B RID: 20603
		public const int PhoneTasksFieldNumber = 10;

		// Token: 0x0400507C RID: 20604
		private static readonly FieldCodec<InfrTaskPb> _repeated_phoneTasks_codec = FieldCodec.ForMessage<InfrTaskPb>(82U, InfrTaskPb.Parser);

		// Token: 0x0400507D RID: 20605
		private readonly RepeatedField<InfrTaskPb> phoneTasks_ = new RepeatedField<InfrTaskPb>();
	}
}
