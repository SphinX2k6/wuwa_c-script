using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000128 RID: 296
	[NetMessage(EMessageId.AttributeInitNotify)]
	public sealed class AttributeInitNotify : IMessage<AttributeInitNotify>, IMessage, IEquatable<AttributeInitNotify>, IDeepCloneable<AttributeInitNotify>, IBufferMessage
	{
		// Token: 0x06002785 RID: 10117 RVA: 0x00068818 File Offset: 0x00066A18
		[NullableContext(1)]
		public static AttributeInitNotify Create()
		{
			return new AttributeInitNotify();
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x0006881F File Offset: 0x00066A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x00068822 File Offset: 0x00066A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeInitNotify.Descriptor;
			}
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00068829 File Offset: 0x00066A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitNotify()
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0006883C File Offset: 0x00066A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitNotify(AttributeInitNotify other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00068872 File Offset: 0x00066A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitNotify Clone()
		{
			return new AttributeInitNotify(this);
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x0006887A File Offset: 0x00066A7A
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x00068882 File Offset: 0x00066A82
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x0006888B File Offset: 0x00066A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00068893 File Offset: 0x00066A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeInitNotify);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x000688A4 File Offset: 0x00066AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeInitNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000688F4 File Offset: 0x00066AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.attributes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00068941 File Offset: 0x00066B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0006894E File Offset: 0x00066B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00068958 File Offset: 0x00066B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			this.attributes_.WriteTo(ref output, AttributeInitNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000689A8 File Offset: 0x00066BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.attributes_.CalculateSize(AttributeInitNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x000689FC File Offset: 0x00066BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeInitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00068A49 File Offset: 0x00066C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00068A54 File Offset: 0x00066C54
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
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attributes_.AddEntriesFrom(ref input, AttributeInitNotify._repeated_attributes_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002665 RID: 9829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002666 RID: 9830
		public const int IdFieldNumber = 1;

		// Token: 0x04002667 RID: 9831
		private long id_;

		// Token: 0x04002668 RID: 9832
		public const int AttributesFieldNumber = 4;

		// Token: 0x04002669 RID: 9833
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(34U, GameplayAttributeData.Parser);

		// Token: 0x0400266A RID: 9834
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
