using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000129 RID: 297
	[NetMessage(EMessageId.AttributeInitRequest)]
	public sealed class AttributeInitRequest : IMessage<AttributeInitRequest>, IMessage, IEquatable<AttributeInitRequest>, IDeepCloneable<AttributeInitRequest>, IBufferMessage
	{
		// Token: 0x06002799 RID: 10137 RVA: 0x00068AC3 File Offset: 0x00066CC3
		[NullableContext(1)]
		public static AttributeInitRequest Create()
		{
			return new AttributeInitRequest();
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x00068ACA File Offset: 0x00066CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x00068ACD File Offset: 0x00066CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeInitRequest.Descriptor;
			}
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00068AD4 File Offset: 0x00066CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitRequest()
		{
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00068AE7 File Offset: 0x00066CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitRequest(AttributeInitRequest other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00068B1D File Offset: 0x00066D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeInitRequest Clone()
		{
			return new AttributeInitRequest(this);
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x00068B25 File Offset: 0x00066D25
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x00068B2D File Offset: 0x00066D2D
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x00068B36 File Offset: 0x00066D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00068B3E File Offset: 0x00066D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeInitRequest);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00068B4C File Offset: 0x00066D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeInitRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00068B9C File Offset: 0x00066D9C
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

		// Token: 0x060027A5 RID: 10149 RVA: 0x00068BE9 File Offset: 0x00066DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00068BF6 File Offset: 0x00066DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00068C00 File Offset: 0x00066E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			this.attributes_.WriteTo(ref output, AttributeInitRequest._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00068C50 File Offset: 0x00066E50
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

		// Token: 0x060027A9 RID: 10153 RVA: 0x00068CA4 File Offset: 0x00066EA4
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

		// Token: 0x060027AA RID: 10154 RVA: 0x00068CF1 File Offset: 0x00066EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00068CFC File Offset: 0x00066EFC
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
				if (num != 56U)
				{
					if (num != 82U)
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

		// Token: 0x0400266B RID: 9835
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400266C RID: 9836
		public const int IdFieldNumber = 7;

		// Token: 0x0400266D RID: 9837
		private long id_;

		// Token: 0x0400266E RID: 9838
		public const int AttributesFieldNumber = 10;

		// Token: 0x0400266F RID: 9839
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(82U, GameplayAttributeData.Parser);

		// Token: 0x04002670 RID: 9840
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
