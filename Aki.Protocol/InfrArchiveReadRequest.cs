using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D4 RID: 2004
	[NetMessage(EMessageId.InfrArchiveReadRequest)]
	public sealed class InfrArchiveReadRequest : IMessage<InfrArchiveReadRequest>, IMessage, IEquatable<InfrArchiveReadRequest>, IDeepCloneable<InfrArchiveReadRequest>, IBufferMessage
	{
		// Token: 0x0600B41A RID: 46106 RVA: 0x001AED03 File Offset: 0x001ACF03
		[NullableContext(1)]
		public static InfrArchiveReadRequest Create()
		{
			return new InfrArchiveReadRequest();
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x0600B41B RID: 46107 RVA: 0x001AED0A File Offset: 0x001ACF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x0600B41C RID: 46108 RVA: 0x001AED0D File Offset: 0x001ACF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveReadRequest.Descriptor;
			}
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x001AED14 File Offset: 0x001ACF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadRequest()
		{
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x001AED27 File Offset: 0x001ACF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadRequest(InfrArchiveReadRequest other) : this()
		{
			this.archiveId_ = other.archiveId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x001AED51 File Offset: 0x001ACF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadRequest Clone()
		{
			return new InfrArchiveReadRequest(this);
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x0600B420 RID: 46112 RVA: 0x001AED59 File Offset: 0x001ACF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ArchiveId
		{
			get
			{
				return this.archiveId_;
			}
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x001AED61 File Offset: 0x001ACF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveReadRequest);
		}

		// Token: 0x0600B422 RID: 46114 RVA: 0x001AED6F File Offset: 0x001ACF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveReadRequest other)
		{
			return other != null && (other == this || (this.archiveId_.Equals(other.archiveId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x001AEDA4 File Offset: 0x001ACFA4
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

		// Token: 0x0600B424 RID: 46116 RVA: 0x001AEDD8 File Offset: 0x001ACFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x001AEDE5 File Offset: 0x001ACFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x001AEDEE File Offset: 0x001ACFEE
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

		// Token: 0x0600B427 RID: 46119 RVA: 0x001AEE18 File Offset: 0x001AD018
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

		// Token: 0x0600B428 RID: 46120 RVA: 0x001AEE51 File Offset: 0x001AD051
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

		// Token: 0x0600B429 RID: 46121 RVA: 0x001AEE7F File Offset: 0x001AD07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x001AEE88 File Offset: 0x001AD088
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.archiveId_.AddEntriesFrom(ref input, InfrArchiveReadRequest._repeated_archiveId_codec);
				}
			}
		}

		// Token: 0x0400503A RID: 20538
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400503B RID: 20539
		public const int ArchiveIdFieldNumber = 4;

		// Token: 0x0400503C RID: 20540
		private static readonly FieldCodec<int> _repeated_archiveId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400503D RID: 20541
		private readonly RepeatedField<int> archiveId_ = new RepeatedField<int>();
	}
}
