using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000124 RID: 292
	[NetMessage(EMessageId.AttributeChangedRequest)]
	public sealed class AttributeChangedRequest : IMessage<AttributeChangedRequest>, IMessage, IEquatable<AttributeChangedRequest>, IDeepCloneable<AttributeChangedRequest>, IBufferMessage
	{
		// Token: 0x06002737 RID: 10039 RVA: 0x00067E51 File Offset: 0x00066051
		[NullableContext(1)]
		public static AttributeChangedRequest Create()
		{
			return new AttributeChangedRequest();
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x00067E58 File Offset: 0x00066058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x00067E5B File Offset: 0x0006605B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeChangedRequest.Descriptor;
			}
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00067E62 File Offset: 0x00066062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedRequest()
		{
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00067E75 File Offset: 0x00066075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedRequest(AttributeChangedRequest other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x00067EAB File Offset: 0x000660AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedRequest Clone()
		{
			return new AttributeChangedRequest(this);
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600273D RID: 10045 RVA: 0x00067EB3 File Offset: 0x000660B3
		// (set) Token: 0x0600273E RID: 10046 RVA: 0x00067EBB File Offset: 0x000660BB
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

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x00067EC4 File Offset: 0x000660C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00067ECC File Offset: 0x000660CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeChangedRequest);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00067EDC File Offset: 0x000660DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeChangedRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00067F2C File Offset: 0x0006612C
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

		// Token: 0x06002743 RID: 10051 RVA: 0x00067F79 File Offset: 0x00066179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00067F86 File Offset: 0x00066186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00067F90 File Offset: 0x00066190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			this.attributes_.WriteTo(ref output, AttributeChangedRequest._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00067FE0 File Offset: 0x000661E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.attributes_.CalculateSize(AttributeChangedRequest._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00068034 File Offset: 0x00066234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeChangedRequest other)
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

		// Token: 0x06002748 RID: 10056 RVA: 0x00068081 File Offset: 0x00066281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0006808C File Offset: 0x0006628C
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attributes_.AddEntriesFrom(ref input, AttributeChangedRequest._repeated_attributes_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002650 RID: 9808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002651 RID: 9809
		public const int IdFieldNumber = 1;

		// Token: 0x04002652 RID: 9810
		private long id_;

		// Token: 0x04002653 RID: 9811
		public const int AttributesFieldNumber = 10;

		// Token: 0x04002654 RID: 9812
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(82U, GameplayAttributeData.Parser);

		// Token: 0x04002655 RID: 9813
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
