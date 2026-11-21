using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012B RID: 299
	[NetMessage(EMessageId.AttributeInitNotify)]
	public sealed class AttributeInitNotify : IMessage<AttributeInitNotify>, IMessage, IEquatable<AttributeInitNotify>, IDeepCloneable<AttributeInitNotify>, IBufferMessage
	{
		// Token: 0x060027FC RID: 10236 RVA: 0x00069C38 File Offset: 0x00067E38
		[NullableContext(1)]
		public static AttributeInitNotify Create()
		{
			return new AttributeInitNotify();
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x00069C3F File Offset: 0x00067E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x00069C42 File Offset: 0x00067E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeInitNotify.Descriptor;
			}
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00069C49 File Offset: 0x00067E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitNotify()
		{
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00069C5C File Offset: 0x00067E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitNotify(AttributeInitNotify other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00069C92 File Offset: 0x00067E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitNotify Clone()
		{
			return new AttributeInitNotify(this);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x00069C9A File Offset: 0x00067E9A
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x00069CA2 File Offset: 0x00067EA2
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

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x00069CAB File Offset: 0x00067EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00069CB3 File Offset: 0x00067EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeInitNotify);
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00069CC4 File Offset: 0x00067EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeInitNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00069D14 File Offset: 0x00067F14
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

		// Token: 0x06002808 RID: 10248 RVA: 0x00069D61 File Offset: 0x00067F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00069D6E File Offset: 0x00067F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00069D78 File Offset: 0x00067F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, AttributeInitNotify._repeated_attributes_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00069DC8 File Offset: 0x00067FC8
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

		// Token: 0x0600280C RID: 10252 RVA: 0x00069E1C File Offset: 0x0006801C
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

		// Token: 0x0600280D RID: 10253 RVA: 0x00069E69 File Offset: 0x00068069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00069E74 File Offset: 0x00068074
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
				if (num != 26U)
				{
					if (num != 80U)
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
					this.attributes_.AddEntriesFrom(ref input, AttributeInitNotify._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x040026D9 RID: 9945
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026DA RID: 9946
		public const int IdFieldNumber = 10;

		// Token: 0x040026DB RID: 9947
		private long id_;

		// Token: 0x040026DC RID: 9948
		public const int AttributesFieldNumber = 3;

		// Token: 0x040026DD RID: 9949
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(26U, GameplayAttributeData.Parser);

		// Token: 0x040026DE RID: 9950
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
