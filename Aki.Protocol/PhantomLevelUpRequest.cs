using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE3 RID: 3299
	[NetMessage(EMessageId.PhantomLevelUpRequest)]
	public sealed class PhantomLevelUpRequest : IMessage<PhantomLevelUpRequest>, IMessage, IEquatable<PhantomLevelUpRequest>, IDeepCloneable<PhantomLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06011D97 RID: 73111 RVA: 0x0029C8DD File Offset: 0x0029AADD
		[NullableContext(1)]
		public static PhantomLevelUpRequest Create()
		{
			return new PhantomLevelUpRequest();
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x06011D98 RID: 73112 RVA: 0x0029C8E4 File Offset: 0x0029AAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x06011D99 RID: 73113 RVA: 0x0029C8E7 File Offset: 0x0029AAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06011D9A RID: 73114 RVA: 0x0029C8EE File Offset: 0x0029AAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpRequest()
		{
		}

		// Token: 0x06011D9B RID: 73115 RVA: 0x0029C904 File Offset: 0x0029AB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpRequest(PhantomLevelUpRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.consumeList_ = other.consumeList_.Clone();
			this.identifyCount_ = other.identifyCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D9C RID: 73116 RVA: 0x0029C951 File Offset: 0x0029AB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomLevelUpRequest Clone()
		{
			return new PhantomLevelUpRequest(this);
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x06011D9D RID: 73117 RVA: 0x0029C959 File Offset: 0x0029AB59
		// (set) Token: 0x06011D9E RID: 73118 RVA: 0x0029C961 File Offset: 0x0029AB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x06011D9F RID: 73119 RVA: 0x0029C96A File Offset: 0x0029AB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomConsumeItem> ConsumeList
		{
			get
			{
				return this.consumeList_;
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x06011DA0 RID: 73120 RVA: 0x0029C972 File Offset: 0x0029AB72
		// (set) Token: 0x06011DA1 RID: 73121 RVA: 0x0029C97A File Offset: 0x0029AB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IdentifyCount
		{
			get
			{
				return this.identifyCount_;
			}
			set
			{
				this.identifyCount_ = value;
			}
		}

		// Token: 0x06011DA2 RID: 73122 RVA: 0x0029C983 File Offset: 0x0029AB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomLevelUpRequest);
		}

		// Token: 0x06011DA3 RID: 73123 RVA: 0x0029C994 File Offset: 0x0029AB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomLevelUpRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.consumeList_.Equals(other.consumeList_) && this.IdentifyCount == other.IdentifyCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DA4 RID: 73124 RVA: 0x0029C9F4 File Offset: 0x0029ABF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.consumeList_.GetHashCode();
			if (this.IdentifyCount != 0)
			{
				num ^= this.IdentifyCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011DA5 RID: 73125 RVA: 0x0029CA5A File Offset: 0x0029AC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DA6 RID: 73126 RVA: 0x0029CA67 File Offset: 0x0029AC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DA7 RID: 73127 RVA: 0x0029CA70 File Offset: 0x0029AC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.consumeList_.WriteTo(ref output, PhantomLevelUpRequest._repeated_consumeList_codec);
			if (this.IdentifyCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IdentifyCount);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DA8 RID: 73128 RVA: 0x0029CADC File Offset: 0x0029ACDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.consumeList_.CalculateSize(PhantomLevelUpRequest._repeated_consumeList_codec);
			if (this.IdentifyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IdentifyCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011DA9 RID: 73129 RVA: 0x0029CB48 File Offset: 0x0029AD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.consumeList_.Add(other.consumeList_);
			if (other.IdentifyCount != 0)
			{
				this.IdentifyCount = other.IdentifyCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011DAA RID: 73130 RVA: 0x0029CBA9 File Offset: 0x0029ADA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DAB RID: 73131 RVA: 0x0029CBB4 File Offset: 0x0029ADB4
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
					if (num != 56U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.IdentifyCount = input.ReadInt32();
					}
				}
				else
				{
					this.consumeList_.AddEntriesFrom(ref input, PhantomLevelUpRequest._repeated_consumeList_codec);
				}
			}
		}

		// Token: 0x04007014 RID: 28692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007015 RID: 28693
		public const int IncIdFieldNumber = 9;

		// Token: 0x04007016 RID: 28694
		private int incId_;

		// Token: 0x04007017 RID: 28695
		public const int ConsumeListFieldNumber = 1;

		// Token: 0x04007018 RID: 28696
		private static readonly FieldCodec<PhantomConsumeItem> _repeated_consumeList_codec = FieldCodec.ForMessage<PhantomConsumeItem>(10U, PhantomConsumeItem.Parser);

		// Token: 0x04007019 RID: 28697
		private readonly RepeatedField<PhantomConsumeItem> consumeList_ = new RepeatedField<PhantomConsumeItem>();

		// Token: 0x0400701A RID: 28698
		public const int IdentifyCountFieldNumber = 7;

		// Token: 0x0400701B RID: 28699
		private int identifyCount_;
	}
}
