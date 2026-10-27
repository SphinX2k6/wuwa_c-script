using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D6 RID: 2518
	public sealed class MiniLetterContentPb : IMessage<MiniLetterContentPb>, IMessage, IEquatable<MiniLetterContentPb>, IDeepCloneable<MiniLetterContentPb>, IBufferMessage
	{
		// Token: 0x0600DCCB RID: 56523 RVA: 0x0020691B File Offset: 0x00204B1B
		[NullableContext(1)]
		public static MiniLetterContentPb Create()
		{
			return new MiniLetterContentPb();
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x0600DCCC RID: 56524 RVA: 0x00206922 File Offset: 0x00204B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniLetterContentPb> Parser
		{
			get
			{
				return MiniLetterContentPb._parser;
			}
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x0600DCCD RID: 56525 RVA: 0x00206929 File Offset: 0x00204B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0600DCCE RID: 56526 RVA: 0x0020692C File Offset: 0x00204B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniLetterContentPb.Descriptor;
			}
		}

		// Token: 0x0600DCCF RID: 56527 RVA: 0x00206933 File Offset: 0x00204B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniLetterContentPb()
		{
		}

		// Token: 0x0600DCD0 RID: 56528 RVA: 0x00206946 File Offset: 0x00204B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniLetterContentPb(MiniLetterContentPb other) : this()
		{
			this.letterId_ = other.letterId_;
			this.contentKey_ = other.contentKey_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCD1 RID: 56529 RVA: 0x0020697C File Offset: 0x00204B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniLetterContentPb Clone()
		{
			return new MiniLetterContentPb(this);
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0600DCD2 RID: 56530 RVA: 0x00206984 File Offset: 0x00204B84
		// (set) Token: 0x0600DCD3 RID: 56531 RVA: 0x0020698C File Offset: 0x00204B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LetterId
		{
			get
			{
				return this.letterId_;
			}
			set
			{
				this.letterId_ = value;
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0600DCD4 RID: 56532 RVA: 0x00206995 File Offset: 0x00204B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ContentKey
		{
			get
			{
				return this.contentKey_;
			}
		}

		// Token: 0x0600DCD5 RID: 56533 RVA: 0x0020699D File Offset: 0x00204B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniLetterContentPb);
		}

		// Token: 0x0600DCD6 RID: 56534 RVA: 0x002069AC File Offset: 0x00204BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniLetterContentPb other)
		{
			return other != null && (other == this || (this.LetterId == other.LetterId && this.contentKey_.Equals(other.contentKey_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCD7 RID: 56535 RVA: 0x002069FC File Offset: 0x00204BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LetterId != 0)
			{
				num ^= this.LetterId.GetHashCode();
			}
			num ^= this.contentKey_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCD8 RID: 56536 RVA: 0x00206A49 File Offset: 0x00204C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCD9 RID: 56537 RVA: 0x00206A56 File Offset: 0x00204C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCDA RID: 56538 RVA: 0x00206A60 File Offset: 0x00204C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LetterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LetterId);
			}
			this.contentKey_.WriteTo(ref output, MiniLetterContentPb._repeated_contentKey_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCDB RID: 56539 RVA: 0x00206AB0 File Offset: 0x00204CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LetterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LetterId);
			}
			num += this.contentKey_.CalculateSize(MiniLetterContentPb._repeated_contentKey_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCDC RID: 56540 RVA: 0x00206B04 File Offset: 0x00204D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MiniLetterContentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LetterId != 0)
			{
				this.LetterId = other.LetterId;
			}
			this.contentKey_.Add(other.contentKey_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCDD RID: 56541 RVA: 0x00206B51 File Offset: 0x00204D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCDE RID: 56542 RVA: 0x00206B5C File Offset: 0x00204D5C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.contentKey_.AddEntriesFrom(ref input, MiniLetterContentPb._repeated_contentKey_codec);
					}
				}
				else
				{
					this.LetterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B6A RID: 23402
		private static readonly MessageParser<MiniLetterContentPb> _parser = new MessageParser<MiniLetterContentPb>(() => new MiniLetterContentPb());

		// Token: 0x04005B6B RID: 23403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B6C RID: 23404
		public const int LetterIdFieldNumber = 1;

		// Token: 0x04005B6D RID: 23405
		private int letterId_;

		// Token: 0x04005B6E RID: 23406
		public const int ContentKeyFieldNumber = 2;

		// Token: 0x04005B6F RID: 23407
		private static readonly FieldCodec<string> _repeated_contentKey_codec = FieldCodec.ForString(18U);

		// Token: 0x04005B70 RID: 23408
		private readonly RepeatedField<string> contentKey_ = new RepeatedField<string>();
	}
}
