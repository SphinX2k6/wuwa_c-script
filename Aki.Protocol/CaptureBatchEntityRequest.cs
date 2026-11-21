using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023A RID: 570
	[NetMessage(EMessageId.CaptureBatchEntityRequest)]
	public sealed class CaptureBatchEntityRequest : IMessage<CaptureBatchEntityRequest>, IMessage, IEquatable<CaptureBatchEntityRequest>, IDeepCloneable<CaptureBatchEntityRequest>, IBufferMessage
	{
		// Token: 0x06003DB4 RID: 15796 RVA: 0x00099189 File Offset: 0x00097389
		[NullableContext(1)]
		public static CaptureBatchEntityRequest Create()
		{
			return new CaptureBatchEntityRequest();
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00099190 File Offset: 0x00097390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x00099193 File Offset: 0x00097393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureBatchEntityRequest.Descriptor;
			}
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x0009919A File Offset: 0x0009739A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityRequest()
		{
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x000991AD File Offset: 0x000973AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityRequest(CaptureBatchEntityRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x000991E3 File Offset: 0x000973E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityRequest Clone()
		{
			return new CaptureBatchEntityRequest(this);
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x000991EB File Offset: 0x000973EB
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x000991F3 File Offset: 0x000973F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x000991FC File Offset: 0x000973FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00099204 File Offset: 0x00097404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureBatchEntityRequest);
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00099214 File Offset: 0x00097414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureBatchEntityRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00099264 File Offset: 0x00097464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x000992B1 File Offset: 0x000974B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x000992BE File Offset: 0x000974BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x000992C8 File Offset: 0x000974C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InstId);
			}
			this.ids_.WriteTo(ref output, CaptureBatchEntityRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00099318 File Offset: 0x00097518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.ids_.CalculateSize(CaptureBatchEntityRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x0009936C File Offset: 0x0009756C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaptureBatchEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x000993B9 File Offset: 0x000975B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x000993C4 File Offset: 0x000975C4
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
				if (num != 56U)
				{
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, CaptureBatchEntityRequest._repeated_ids_codec);
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D12 RID: 11538
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D13 RID: 11539
		public const int InstIdFieldNumber = 7;

		// Token: 0x04002D14 RID: 11540
		private int instId_;

		// Token: 0x04002D15 RID: 11541
		public const int IdsFieldNumber = 11;

		// Token: 0x04002D16 RID: 11542
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(90U);

		// Token: 0x04002D17 RID: 11543
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}
