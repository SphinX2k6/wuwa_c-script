using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001730 RID: 5936
	[NetMessage(EMessageId.AiInformationNotify)]
	public sealed class AiInformationNotify : IMessage<AiInformationNotify>, IMessage, IEquatable<AiInformationNotify>, IDeepCloneable<AiInformationNotify>, IBufferMessage
	{
		// Token: 0x0601DCB4 RID: 122036 RVA: 0x0045E693 File Offset: 0x0045C893
		[NullableContext(1)]
		public static AiInformationNotify Create()
		{
			return new AiInformationNotify();
		}

		// Token: 0x1700656D RID: 25965
		// (get) Token: 0x0601DCB5 RID: 122037 RVA: 0x0045E69A File Offset: 0x0045C89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700656E RID: 25966
		// (get) Token: 0x0601DCB6 RID: 122038 RVA: 0x0045E69D File Offset: 0x0045C89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationNotify.Descriptor;
			}
		}

		// Token: 0x0601DCB7 RID: 122039 RVA: 0x0045E6A4 File Offset: 0x0045C8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationNotify()
		{
		}

		// Token: 0x0601DCB8 RID: 122040 RVA: 0x0045E6B7 File Offset: 0x0045C8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationNotify(AiInformationNotify other) : this()
		{
			this.aiBlackboardCd_ = other.aiBlackboardCd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DCB9 RID: 122041 RVA: 0x0045E6E1 File Offset: 0x0045C8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationNotify Clone()
		{
			return new AiInformationNotify(this);
		}

		// Token: 0x1700656F RID: 25967
		// (get) Token: 0x0601DCBA RID: 122042 RVA: 0x0045E6E9 File Offset: 0x0045C8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCd
		{
			get
			{
				return this.aiBlackboardCd_;
			}
		}

		// Token: 0x0601DCBB RID: 122043 RVA: 0x0045E6F1 File Offset: 0x0045C8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationNotify);
		}

		// Token: 0x0601DCBC RID: 122044 RVA: 0x0045E6FF File Offset: 0x0045C8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationNotify other)
		{
			return other != null && (other == this || (this.aiBlackboardCd_.Equals(other.aiBlackboardCd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DCBD RID: 122045 RVA: 0x0045E734 File Offset: 0x0045C934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCd_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DCBE RID: 122046 RVA: 0x0045E768 File Offset: 0x0045C968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DCBF RID: 122047 RVA: 0x0045E775 File Offset: 0x0045C975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DCC0 RID: 122048 RVA: 0x0045E77E File Offset: 0x0045C97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCd_.WriteTo(ref output, AiInformationNotify._repeated_aiBlackboardCd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DCC1 RID: 122049 RVA: 0x0045E7A8 File Offset: 0x0045C9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCd_.CalculateSize(AiInformationNotify._repeated_aiBlackboardCd_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DCC2 RID: 122050 RVA: 0x0045E7E1 File Offset: 0x0045C9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformationNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCd_.Add(other.aiBlackboardCd_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DCC3 RID: 122051 RVA: 0x0045E80F File Offset: 0x0045CA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DCC4 RID: 122052 RVA: 0x0045E818 File Offset: 0x0045CA18
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aiBlackboardCd_.AddEntriesFrom(ref input, AiInformationNotify._repeated_aiBlackboardCd_codec);
				}
			}
		}

		// Token: 0x0400C988 RID: 51592
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C989 RID: 51593
		public const int AiBlackboardCdFieldNumber = 4;

		// Token: 0x0400C98A RID: 51594
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCd_codec = FieldCodec.ForMessage<Int2Long>(34U, Int2Long.Parser);

		// Token: 0x0400C98B RID: 51595
		private readonly RepeatedField<Int2Long> aiBlackboardCd_ = new RepeatedField<Int2Long>();
	}
}
