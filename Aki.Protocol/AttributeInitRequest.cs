using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012C RID: 300
	[NetMessage(EMessageId.AttributeInitRequest)]
	public sealed class AttributeInitRequest : IMessage<AttributeInitRequest>, IMessage, IEquatable<AttributeInitRequest>, IDeepCloneable<AttributeInitRequest>, IBufferMessage
	{
		// Token: 0x06002810 RID: 10256 RVA: 0x00069EE4 File Offset: 0x000680E4
		[NullableContext(1)]
		public static AttributeInitRequest Create()
		{
			return new AttributeInitRequest();
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x00069EEB File Offset: 0x000680EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x00069EEE File Offset: 0x000680EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeInitRequest.Descriptor;
			}
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00069EF5 File Offset: 0x000680F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitRequest()
		{
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00069F08 File Offset: 0x00068108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitRequest(AttributeInitRequest other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00069F3E File Offset: 0x0006813E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitRequest Clone()
		{
			return new AttributeInitRequest(this);
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x00069F46 File Offset: 0x00068146
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x00069F4E File Offset: 0x0006814E
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x00069F57 File Offset: 0x00068157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00069F5F File Offset: 0x0006815F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeInitRequest);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00069F70 File Offset: 0x00068170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeInitRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00069FC0 File Offset: 0x000681C0
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

		// Token: 0x0600281C RID: 10268 RVA: 0x0006A00D File Offset: 0x0006820D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0006A01A File Offset: 0x0006821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0006A024 File Offset: 0x00068224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			this.attributes_.WriteTo(ref output, AttributeInitRequest._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x0006A074 File Offset: 0x00068274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.attributes_.CalculateSize(AttributeInitRequest._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0006A0C8 File Offset: 0x000682C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeInitRequest other)
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

		// Token: 0x06002821 RID: 10273 RVA: 0x0006A115 File Offset: 0x00068315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0006A120 File Offset: 0x00068320
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
				if (num != 24U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attributes_.AddEntriesFrom(ref input, AttributeInitRequest._repeated_attributes_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040026DF RID: 9951
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026E0 RID: 9952
		public const int IdFieldNumber = 3;

		// Token: 0x040026E1 RID: 9953
		private long id_;

		// Token: 0x040026E2 RID: 9954
		public const int AttributesFieldNumber = 15;

		// Token: 0x040026E3 RID: 9955
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(122U, GameplayAttributeData.Parser);

		// Token: 0x040026E4 RID: 9956
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
