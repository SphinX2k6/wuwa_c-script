using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FF RID: 511
	public sealed class BuffEffectCd : IMessage<BuffEffectCd>, IMessage, IEquatable<BuffEffectCd>, IDeepCloneable<BuffEffectCd>, IBufferMessage
	{
		// Token: 0x060038E4 RID: 14564 RVA: 0x0008E643 File Offset: 0x0008C843
		[NullableContext(1)]
		public static BuffEffectCd Create()
		{
			return new BuffEffectCd();
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x0008E64A File Offset: 0x0008C84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuffEffectCd> Parser
		{
			get
			{
				return BuffEffectCd._parser;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x0008E651 File Offset: 0x0008C851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x0008E654 File Offset: 0x0008C854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectCd.Descriptor;
			}
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0008E65B File Offset: 0x0008C85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectCd()
		{
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0008E66E File Offset: 0x0008C86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectCd(BuffEffectCd other) : this()
		{
			this.buffId_ = other.buffId_;
			this.listCdRemaining_ = other.listCdRemaining_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0008E6A4 File Offset: 0x0008C8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectCd Clone()
		{
			return new BuffEffectCd(this);
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x0008E6AC File Offset: 0x0008C8AC
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x0008E6B4 File Offset: 0x0008C8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x0008E6BD File Offset: 0x0008C8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ListCdRemaining
		{
			get
			{
				return this.listCdRemaining_;
			}
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0008E6C5 File Offset: 0x0008C8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectCd);
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0008E6D4 File Offset: 0x0008C8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectCd other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.listCdRemaining_.Equals(other.listCdRemaining_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x0008E724 File Offset: 0x0008C924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			num ^= this.listCdRemaining_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0008E771 File Offset: 0x0008C971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0008E77E File Offset: 0x0008C97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0008E788 File Offset: 0x0008C988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BuffId);
			}
			this.listCdRemaining_.WriteTo(ref output, BuffEffectCd._repeated_listCdRemaining_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0008E7D8 File Offset: 0x0008C9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			num += this.listCdRemaining_.CalculateSize(BuffEffectCd._repeated_listCdRemaining_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x0008E82C File Offset: 0x0008CA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectCd other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			this.listCdRemaining_.Add(other.listCdRemaining_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0008E879 File Offset: 0x0008CA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x0008E884 File Offset: 0x0008CA84
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.listCdRemaining_.AddEntriesFrom(ref input, BuffEffectCd._repeated_listCdRemaining_codec);
					}
				}
				else
				{
					this.BuffId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002BAB RID: 11179
		private static readonly MessageParser<BuffEffectCd> _parser = new MessageParser<BuffEffectCd>(() => new BuffEffectCd());

		// Token: 0x04002BAC RID: 11180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BAD RID: 11181
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04002BAE RID: 11182
		private long buffId_;

		// Token: 0x04002BAF RID: 11183
		public const int ListCdRemainingFieldNumber = 2;

		// Token: 0x04002BB0 RID: 11184
		private static readonly FieldCodec<int> _repeated_listCdRemaining_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04002BB1 RID: 11185
		private readonly RepeatedField<int> listCdRemaining_ = new RepeatedField<int>();
	}
}
