using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000127 RID: 295
	[NetMessage(EMessageId.AttributeChangedRequest)]
	public sealed class AttributeChangedRequest : IMessage<AttributeChangedRequest>, IMessage, IEquatable<AttributeChangedRequest>, IDeepCloneable<AttributeChangedRequest>, IBufferMessage
	{
		// Token: 0x060027AE RID: 10158 RVA: 0x00069271 File Offset: 0x00067471
		[NullableContext(1)]
		public static AttributeChangedRequest Create()
		{
			return new AttributeChangedRequest();
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x00069278 File Offset: 0x00067478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x0006927B File Offset: 0x0006747B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeChangedRequest.Descriptor;
			}
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00069282 File Offset: 0x00067482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedRequest()
		{
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00069295 File Offset: 0x00067495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedRequest(AttributeChangedRequest other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000692CB File Offset: 0x000674CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedRequest Clone()
		{
			return new AttributeChangedRequest(this);
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000692D3 File Offset: 0x000674D3
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x000692DB File Offset: 0x000674DB
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x000692E4 File Offset: 0x000674E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000692EC File Offset: 0x000674EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeChangedRequest);
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000692FC File Offset: 0x000674FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeChangedRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x0006934C File Offset: 0x0006754C
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

		// Token: 0x060027BA RID: 10170 RVA: 0x00069399 File Offset: 0x00067599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000693A6 File Offset: 0x000675A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000693B0 File Offset: 0x000675B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, AttributeChangedRequest._repeated_attributes_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00069400 File Offset: 0x00067600
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

		// Token: 0x060027BE RID: 10174 RVA: 0x00069454 File Offset: 0x00067654
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

		// Token: 0x060027BF RID: 10175 RVA: 0x000694A1 File Offset: 0x000676A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000694AC File Offset: 0x000676AC
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
				if (num != 10U)
				{
					if (num != 88U)
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
					this.attributes_.AddEntriesFrom(ref input, AttributeChangedRequest._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x040026C4 RID: 9924
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026C5 RID: 9925
		public const int IdFieldNumber = 11;

		// Token: 0x040026C6 RID: 9926
		private long id_;

		// Token: 0x040026C7 RID: 9927
		public const int AttributesFieldNumber = 1;

		// Token: 0x040026C8 RID: 9928
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(10U, GameplayAttributeData.Parser);

		// Token: 0x040026C9 RID: 9929
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
