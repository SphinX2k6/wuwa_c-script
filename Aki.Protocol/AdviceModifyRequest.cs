using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CC RID: 204
	[NetMessage(EMessageId.AdviceModifyRequest)]
	public sealed class AdviceModifyRequest : IMessage<AdviceModifyRequest>, IMessage, IEquatable<AdviceModifyRequest>, IDeepCloneable<AdviceModifyRequest>, IBufferMessage
	{
		// Token: 0x06001FEA RID: 8170 RVA: 0x00056B59 File Offset: 0x00054D59
		[NullableContext(1)]
		public static AdviceModifyRequest Create()
		{
			return new AdviceModifyRequest();
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x00056B60 File Offset: 0x00054D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00056B63 File Offset: 0x00054D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceModifyRequest.Descriptor;
			}
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00056B6A File Offset: 0x00054D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyRequest()
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00056B7D File Offset: 0x00054D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyRequest(AdviceModifyRequest other) : this()
		{
			this.id_ = other.id_;
			this.contents_ = other.contents_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00056BB3 File Offset: 0x00054DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyRequest Clone()
		{
			return new AdviceModifyRequest(this);
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x00056BBB File Offset: 0x00054DBB
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x00056BC3 File Offset: 0x00054DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x00056BCC File Offset: 0x00054DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbAdviceContent> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00056BD4 File Offset: 0x00054DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceModifyRequest);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00056BE4 File Offset: 0x00054DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceModifyRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.contents_.Equals(other.contents_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00056C34 File Offset: 0x00054E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.contents_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00056C81 File Offset: 0x00054E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00056C8E File Offset: 0x00054E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00056C98 File Offset: 0x00054E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contents_.WriteTo(ref output, AdviceModifyRequest._repeated_contents_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00056CE8 File Offset: 0x00054EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.contents_.CalculateSize(AdviceModifyRequest._repeated_contents_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00056D3C File Offset: 0x00054F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceModifyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.contents_.Add(other.contents_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00056D89 File Offset: 0x00054F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00056D94 File Offset: 0x00054F94
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
				if (num != 42U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.contents_.AddEntriesFrom(ref input, AdviceModifyRequest._repeated_contents_codec);
				}
			}
		}

		// Token: 0x04002429 RID: 9257
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400242A RID: 9258
		public const int IdFieldNumber = 13;

		// Token: 0x0400242B RID: 9259
		private long id_;

		// Token: 0x0400242C RID: 9260
		public const int ContentsFieldNumber = 5;

		// Token: 0x0400242D RID: 9261
		private static readonly FieldCodec<PbAdviceContent> _repeated_contents_codec = FieldCodec.ForMessage<PbAdviceContent>(42U, PbAdviceContent.Parser);

		// Token: 0x0400242E RID: 9262
		private readonly RepeatedField<PbAdviceContent> contents_ = new RepeatedField<PbAdviceContent>();
	}
}
