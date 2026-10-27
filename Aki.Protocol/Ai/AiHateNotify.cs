using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016AF RID: 5807
	[NetMessage(EMessageId.AiHateNotify)]
	public sealed class AiHateNotify : IMessage<AiHateNotify>, IMessage, IEquatable<AiHateNotify>, IDeepCloneable<AiHateNotify>, IBufferMessage
	{
		// Token: 0x0601D189 RID: 119177 RVA: 0x00441E77 File Offset: 0x00440077
		[NullableContext(1)]
		public static AiHateNotify Create()
		{
			return new AiHateNotify();
		}

		// Token: 0x170062B7 RID: 25271
		// (get) Token: 0x0601D18A RID: 119178 RVA: 0x00441E7E File Offset: 0x0044007E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062B8 RID: 25272
		// (get) Token: 0x0601D18B RID: 119179 RVA: 0x00441E81 File Offset: 0x00440081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateNotify.Descriptor;
			}
		}

		// Token: 0x0601D18C RID: 119180 RVA: 0x00441E88 File Offset: 0x00440088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateNotify()
		{
		}

		// Token: 0x0601D18D RID: 119181 RVA: 0x00441E9B File Offset: 0x0044009B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateNotify(AiHateNotify other) : this()
		{
			this.hateList_ = other.hateList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D18E RID: 119182 RVA: 0x00441EC5 File Offset: 0x004400C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateNotify Clone()
		{
			return new AiHateNotify(this);
		}

		// Token: 0x170062B9 RID: 25273
		// (get) Token: 0x0601D18F RID: 119183 RVA: 0x00441ECD File Offset: 0x004400CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x0601D190 RID: 119184 RVA: 0x00441ED5 File Offset: 0x004400D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateNotify);
		}

		// Token: 0x0601D191 RID: 119185 RVA: 0x00441EE3 File Offset: 0x004400E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateNotify other)
		{
			return other != null && (other == this || (this.hateList_.Equals(other.hateList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D192 RID: 119186 RVA: 0x00441F18 File Offset: 0x00440118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hateList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D193 RID: 119187 RVA: 0x00441F4C File Offset: 0x0044014C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D194 RID: 119188 RVA: 0x00441F59 File Offset: 0x00440159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D195 RID: 119189 RVA: 0x00441F62 File Offset: 0x00440162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hateList_.WriteTo(ref output, AiHateNotify._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D196 RID: 119190 RVA: 0x00441F8C File Offset: 0x0044018C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hateList_.CalculateSize(AiHateNotify._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D197 RID: 119191 RVA: 0x00441FC5 File Offset: 0x004401C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.hateList_.Add(other.hateList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D198 RID: 119192 RVA: 0x00441FF3 File Offset: 0x004401F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D199 RID: 119193 RVA: 0x00441FFC File Offset: 0x004401FC
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hateList_.AddEntriesFrom(ref input, AiHateNotify._repeated_hateList_codec);
				}
			}
		}

		// Token: 0x0400C440 RID: 50240
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C441 RID: 50241
		public const int HateListFieldNumber = 6;

		// Token: 0x0400C442 RID: 50242
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(50U, AiHateEntity.Parser);

		// Token: 0x0400C443 RID: 50243
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();
	}
}
