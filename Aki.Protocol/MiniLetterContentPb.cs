using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C5 RID: 2501
	public sealed class MiniLetterContentPb : IMessage<MiniLetterContentPb>, IMessage, IEquatable<MiniLetterContentPb>, IDeepCloneable<MiniLetterContentPb>, IBufferMessage
	{
		// Token: 0x0600DBB1 RID: 56241 RVA: 0x00204730 File Offset: 0x00202930
		[NullableContext(1)]
		public static MiniLetterContentPb Create()
		{
			return new MiniLetterContentPb();
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x0600DBB2 RID: 56242 RVA: 0x00204737 File Offset: 0x00202937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MiniLetterContentPb> Parser
		{
			get
			{
				return MiniLetterContentPb._parser;
			}
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x0020473E File Offset: 0x0020293E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x0600DBB4 RID: 56244 RVA: 0x00204741 File Offset: 0x00202941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MiniLetterContentPb.Descriptor;
			}
		}

		// Token: 0x0600DBB5 RID: 56245 RVA: 0x00204748 File Offset: 0x00202948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniLetterContentPb()
		{
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x0020475B File Offset: 0x0020295B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniLetterContentPb(MiniLetterContentPb other) : this()
		{
			this.letterId_ = other.letterId_;
			this.contentKey_ = other.contentKey_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBB7 RID: 56247 RVA: 0x00204791 File Offset: 0x00202991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MiniLetterContentPb Clone()
		{
			return new MiniLetterContentPb(this);
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x0600DBB8 RID: 56248 RVA: 0x00204799 File Offset: 0x00202999
		// (set) Token: 0x0600DBB9 RID: 56249 RVA: 0x002047A1 File Offset: 0x002029A1
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

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x0600DBBA RID: 56250 RVA: 0x002047AA File Offset: 0x002029AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ContentKey
		{
			get
			{
				return this.contentKey_;
			}
		}

		// Token: 0x0600DBBB RID: 56251 RVA: 0x002047B2 File Offset: 0x002029B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MiniLetterContentPb);
		}

		// Token: 0x0600DBBC RID: 56252 RVA: 0x002047C0 File Offset: 0x002029C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MiniLetterContentPb other)
		{
			return other != null && (other == this || (this.LetterId == other.LetterId && this.contentKey_.Equals(other.contentKey_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBBD RID: 56253 RVA: 0x00204810 File Offset: 0x00202A10
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

		// Token: 0x0600DBBE RID: 56254 RVA: 0x0020485D File Offset: 0x00202A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBBF RID: 56255 RVA: 0x0020486A File Offset: 0x00202A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x00204874 File Offset: 0x00202A74
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

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x002048C4 File Offset: 0x00202AC4
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

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x00204918 File Offset: 0x00202B18
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

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00204965 File Offset: 0x00202B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBC4 RID: 56260 RVA: 0x00204970 File Offset: 0x00202B70
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

		// Token: 0x04005B73 RID: 23411
		private static readonly MessageParser<MiniLetterContentPb> _parser = new MessageParser<MiniLetterContentPb>(() => new MiniLetterContentPb());

		// Token: 0x04005B74 RID: 23412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B75 RID: 23413
		public const int LetterIdFieldNumber = 1;

		// Token: 0x04005B76 RID: 23414
		private int letterId_;

		// Token: 0x04005B77 RID: 23415
		public const int ContentKeyFieldNumber = 2;

		// Token: 0x04005B78 RID: 23416
		private static readonly FieldCodec<string> _repeated_contentKey_codec = FieldCodec.ForString(18U);

		// Token: 0x04005B79 RID: 23417
		private readonly RepeatedField<string> contentKey_ = new RepeatedField<string>();
	}
}
