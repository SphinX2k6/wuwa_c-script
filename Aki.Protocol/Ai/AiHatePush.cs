using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x0200172C RID: 5932
	[NetMessage(EMessageId.AiHatePush)]
	public sealed class AiHatePush : IMessage<AiHatePush>, IMessage, IEquatable<AiHatePush>, IDeepCloneable<AiHatePush>, IBufferMessage
	{
		// Token: 0x0601DC6A RID: 121962 RVA: 0x0045DD99 File Offset: 0x0045BF99
		[NullableContext(1)]
		public static AiHatePush Create()
		{
			return new AiHatePush();
		}

		// Token: 0x1700655F RID: 25951
		// (get) Token: 0x0601DC6B RID: 121963 RVA: 0x0045DDA0 File Offset: 0x0045BFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006560 RID: 25952
		// (get) Token: 0x0601DC6C RID: 121964 RVA: 0x0045DDA3 File Offset: 0x0045BFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHatePush.Descriptor;
			}
		}

		// Token: 0x0601DC6D RID: 121965 RVA: 0x0045DDAA File Offset: 0x0045BFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHatePush()
		{
		}

		// Token: 0x0601DC6E RID: 121966 RVA: 0x0045DDBD File Offset: 0x0045BFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHatePush(AiHatePush other) : this()
		{
			this.hateList_ = other.hateList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC6F RID: 121967 RVA: 0x0045DDE7 File Offset: 0x0045BFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHatePush Clone()
		{
			return new AiHatePush(this);
		}

		// Token: 0x17006561 RID: 25953
		// (get) Token: 0x0601DC70 RID: 121968 RVA: 0x0045DDEF File Offset: 0x0045BFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x0601DC71 RID: 121969 RVA: 0x0045DDF7 File Offset: 0x0045BFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHatePush);
		}

		// Token: 0x0601DC72 RID: 121970 RVA: 0x0045DE05 File Offset: 0x0045C005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHatePush other)
		{
			return other != null && (other == this || (this.hateList_.Equals(other.hateList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC73 RID: 121971 RVA: 0x0045DE38 File Offset: 0x0045C038
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

		// Token: 0x0601DC74 RID: 121972 RVA: 0x0045DE6C File Offset: 0x0045C06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC75 RID: 121973 RVA: 0x0045DE79 File Offset: 0x0045C079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC76 RID: 121974 RVA: 0x0045DE82 File Offset: 0x0045C082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hateList_.WriteTo(ref output, AiHatePush._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DC77 RID: 121975 RVA: 0x0045DEAC File Offset: 0x0045C0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hateList_.CalculateSize(AiHatePush._repeated_hateList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DC78 RID: 121976 RVA: 0x0045DEE5 File Offset: 0x0045C0E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHatePush other)
		{
			if (other == null)
			{
				return;
			}
			this.hateList_.Add(other.hateList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DC79 RID: 121977 RVA: 0x0045DF13 File Offset: 0x0045C113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC7A RID: 121978 RVA: 0x0045DF1C File Offset: 0x0045C11C
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hateList_.AddEntriesFrom(ref input, AiHatePush._repeated_hateList_codec);
				}
			}
		}

		// Token: 0x0400C973 RID: 51571
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C974 RID: 51572
		public const int HateListFieldNumber = 9;

		// Token: 0x0400C975 RID: 51573
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(74U, AiHateEntity.Parser);

		// Token: 0x0400C976 RID: 51574
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();
	}
}
