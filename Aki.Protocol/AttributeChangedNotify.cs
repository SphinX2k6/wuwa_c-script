using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000123 RID: 291
	[NetMessage(EMessageId.AttributeChangedNotify)]
	public sealed class AttributeChangedNotify : IMessage<AttributeChangedNotify>, IMessage, IEquatable<AttributeChangedNotify>, IDeepCloneable<AttributeChangedNotify>, IBufferMessage
	{
		// Token: 0x06002725 RID: 10021 RVA: 0x00067C6F File Offset: 0x00065E6F
		[NullableContext(1)]
		public static AttributeChangedNotify Create()
		{
			return new AttributeChangedNotify();
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x00067C76 File Offset: 0x00065E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x00067C79 File Offset: 0x00065E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeChangedNotify.Descriptor;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00067C80 File Offset: 0x00065E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedNotify()
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00067C93 File Offset: 0x00065E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedNotify(AttributeChangedNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00067CBD File Offset: 0x00065EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedNotify Clone()
		{
			return new AttributeChangedNotify(this);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x00067CC5 File Offset: 0x00065EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00067CCD File Offset: 0x00065ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeChangedNotify);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00067CDB File Offset: 0x00065EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeChangedNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00067D10 File Offset: 0x00065F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00067D44 File Offset: 0x00065F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00067D51 File Offset: 0x00065F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00067D5A File Offset: 0x00065F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, AttributeChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00067D84 File Offset: 0x00065F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(AttributeChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00067DBD File Offset: 0x00065FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00067DEB File Offset: 0x00065FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00067DF4 File Offset: 0x00065FF4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.attributes_.AddEntriesFrom(ref input, AttributeChangedNotify._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x0400264C RID: 9804
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400264D RID: 9805
		public const int AttributesFieldNumber = 8;

		// Token: 0x0400264E RID: 9806
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(66U, GameplayAttributeData.Parser);

		// Token: 0x0400264F RID: 9807
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
