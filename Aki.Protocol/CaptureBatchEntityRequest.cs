using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000235 RID: 565
	[NetMessage(EMessageId.CaptureBatchEntityRequest)]
	public sealed class CaptureBatchEntityRequest : IMessage<CaptureBatchEntityRequest>, IMessage, IEquatable<CaptureBatchEntityRequest>, IDeepCloneable<CaptureBatchEntityRequest>, IBufferMessage
	{
		// Token: 0x06003D0F RID: 15631 RVA: 0x0009756D File Offset: 0x0009576D
		[NullableContext(1)]
		public static CaptureBatchEntityRequest Create()
		{
			return new CaptureBatchEntityRequest();
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x00097574 File Offset: 0x00095774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x00097577 File Offset: 0x00095777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureBatchEntityRequest.Descriptor;
			}
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x0009757E File Offset: 0x0009577E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityRequest()
		{
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00097591 File Offset: 0x00095791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityRequest(CaptureBatchEntityRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x000975C7 File Offset: 0x000957C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityRequest Clone()
		{
			return new CaptureBatchEntityRequest(this);
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x000975CF File Offset: 0x000957CF
		// (set) Token: 0x06003D16 RID: 15638 RVA: 0x000975D7 File Offset: 0x000957D7
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

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x000975E0 File Offset: 0x000957E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x000975E8 File Offset: 0x000957E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureBatchEntityRequest);
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x000975F8 File Offset: 0x000957F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureBatchEntityRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x00097648 File Offset: 0x00095848
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

		// Token: 0x06003D1B RID: 15643 RVA: 0x00097695 File Offset: 0x00095895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x000976A2 File Offset: 0x000958A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x000976AC File Offset: 0x000958AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			this.ids_.WriteTo(ref output, CaptureBatchEntityRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x000976FC File Offset: 0x000958FC
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

		// Token: 0x06003D1F RID: 15647 RVA: 0x00097750 File Offset: 0x00095950
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

		// Token: 0x06003D20 RID: 15648 RVA: 0x0009779D File Offset: 0x0009599D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x000977A8 File Offset: 0x000959A8
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
				if (num != 32U)
				{
					if (num != 64U && num != 66U)
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

		// Token: 0x04002C90 RID: 11408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C91 RID: 11409
		public const int InstIdFieldNumber = 4;

		// Token: 0x04002C92 RID: 11410
		private int instId_;

		// Token: 0x04002C93 RID: 11411
		public const int IdsFieldNumber = 8;

		// Token: 0x04002C94 RID: 11412
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(66U);

		// Token: 0x04002C95 RID: 11413
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}
