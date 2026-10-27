using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B0 RID: 5808
	[NetMessage(EMessageId.AiHatePush)]
	public sealed class AiHatePush : IMessage<AiHatePush>, IMessage, IEquatable<AiHatePush>, IDeepCloneable<AiHatePush>, IBufferMessage
	{
		// Token: 0x0601D19B RID: 119195 RVA: 0x00442059 File Offset: 0x00440259
		[NullableContext(1)]
		public static AiHatePush Create()
		{
			return new AiHatePush();
		}

		// Token: 0x170062BA RID: 25274
		// (get) Token: 0x0601D19C RID: 119196 RVA: 0x00442060 File Offset: 0x00440260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062BB RID: 25275
		// (get) Token: 0x0601D19D RID: 119197 RVA: 0x00442063 File Offset: 0x00440263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHatePush.Descriptor;
			}
		}

		// Token: 0x0601D19E RID: 119198 RVA: 0x0044206A File Offset: 0x0044026A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHatePush()
		{
		}

		// Token: 0x0601D19F RID: 119199 RVA: 0x0044207D File Offset: 0x0044027D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHatePush(AiHatePush other) : this()
		{
			this.hateList_ = other.hateList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1A0 RID: 119200 RVA: 0x004420A7 File Offset: 0x004402A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHatePush Clone()
		{
			return new AiHatePush(this);
		}

		// Token: 0x170062BC RID: 25276
		// (get) Token: 0x0601D1A1 RID: 119201 RVA: 0x004420AF File Offset: 0x004402AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x0601D1A2 RID: 119202 RVA: 0x004420B7 File Offset: 0x004402B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHatePush);
		}

		// Token: 0x0601D1A3 RID: 119203 RVA: 0x004420C5 File Offset: 0x004402C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHatePush other)
		{
			return other != null && (other == this || (this.hateList_.Equals(other.hateList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1A4 RID: 119204 RVA: 0x004420F8 File Offset: 0x004402F8
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

		// Token: 0x0601D1A5 RID: 119205 RVA: 0x0044212C File Offset: 0x0044032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1A6 RID: 119206 RVA: 0x00442139 File Offset: 0x00440339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1A7 RID: 119207 RVA: 0x00442142 File Offset: 0x00440342
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

		// Token: 0x0601D1A8 RID: 119208 RVA: 0x0044216C File Offset: 0x0044036C
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

		// Token: 0x0601D1A9 RID: 119209 RVA: 0x004421A5 File Offset: 0x004403A5
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

		// Token: 0x0601D1AA RID: 119210 RVA: 0x004421D3 File Offset: 0x004403D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1AB RID: 119211 RVA: 0x004421DC File Offset: 0x004403DC
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hateList_.AddEntriesFrom(ref input, AiHatePush._repeated_hateList_codec);
				}
			}
		}

		// Token: 0x0400C444 RID: 50244
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C445 RID: 50245
		public const int HateListFieldNumber = 5;

		// Token: 0x0400C446 RID: 50246
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(42U, AiHateEntity.Parser);

		// Token: 0x0400C447 RID: 50247
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();
	}
}
