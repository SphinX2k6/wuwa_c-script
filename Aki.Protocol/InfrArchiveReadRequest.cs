using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C0 RID: 1984
	[NetMessage(EMessageId.InfrArchiveReadRequest)]
	public sealed class InfrArchiveReadRequest : IMessage<InfrArchiveReadRequest>, IMessage, IEquatable<InfrArchiveReadRequest>, IDeepCloneable<InfrArchiveReadRequest>, IBufferMessage
	{
		// Token: 0x0600B2C4 RID: 45764 RVA: 0x001AC2CF File Offset: 0x001AA4CF
		[NullableContext(1)]
		public static InfrArchiveReadRequest Create()
		{
			return new InfrArchiveReadRequest();
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x0600B2C5 RID: 45765 RVA: 0x001AC2D6 File Offset: 0x001AA4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x0600B2C6 RID: 45766 RVA: 0x001AC2D9 File Offset: 0x001AA4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveReadRequest.Descriptor;
			}
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x001AC2E0 File Offset: 0x001AA4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadRequest()
		{
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x001AC2F3 File Offset: 0x001AA4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadRequest(InfrArchiveReadRequest other) : this()
		{
			this.archiveId_ = other.archiveId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x001AC31D File Offset: 0x001AA51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadRequest Clone()
		{
			return new InfrArchiveReadRequest(this);
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600B2CA RID: 45770 RVA: 0x001AC325 File Offset: 0x001AA525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ArchiveId
		{
			get
			{
				return this.archiveId_;
			}
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x001AC32D File Offset: 0x001AA52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveReadRequest);
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x001AC33B File Offset: 0x001AA53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveReadRequest other)
		{
			return other != null && (other == this || (this.archiveId_.Equals(other.archiveId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x001AC370 File Offset: 0x001AA570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.archiveId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x001AC3A4 File Offset: 0x001AA5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x001AC3B1 File Offset: 0x001AA5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x001AC3BA File Offset: 0x001AA5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.archiveId_.WriteTo(ref output, InfrArchiveReadRequest._repeated_archiveId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x001AC3E4 File Offset: 0x001AA5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.archiveId_.CalculateSize(InfrArchiveReadRequest._repeated_archiveId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2D2 RID: 45778 RVA: 0x001AC41D File Offset: 0x001AA61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrArchiveReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.archiveId_.Add(other.archiveId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2D3 RID: 45779 RVA: 0x001AC44B File Offset: 0x001AA64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2D4 RID: 45780 RVA: 0x001AC454 File Offset: 0x001AA654
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.archiveId_.AddEntriesFrom(ref input, InfrArchiveReadRequest._repeated_archiveId_codec);
				}
			}
		}

		// Token: 0x04005033 RID: 20531
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005034 RID: 20532
		public const int ArchiveIdFieldNumber = 12;

		// Token: 0x04005035 RID: 20533
		private static readonly FieldCodec<int> _repeated_archiveId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04005036 RID: 20534
		private readonly RepeatedField<int> archiveId_ = new RepeatedField<int>();
	}
}
