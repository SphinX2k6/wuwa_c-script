using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001524 RID: 5412
	[NetMessage(EMessageId.WuWuKujiGachaResponse)]
	public sealed class WuWuKujiGachaResponse : IMessage<WuWuKujiGachaResponse>, IMessage, IEquatable<WuWuKujiGachaResponse>, IDeepCloneable<WuWuKujiGachaResponse>, IBufferMessage
	{
		// Token: 0x0601C9A3 RID: 117155 RVA: 0x004217E1 File Offset: 0x0041F9E1
		[NullableContext(1)]
		public static WuWuKujiGachaResponse Create()
		{
			return new WuWuKujiGachaResponse();
		}

		// Token: 0x17006070 RID: 24688
		// (get) Token: 0x0601C9A4 RID: 117156 RVA: 0x004217E8 File Offset: 0x0041F9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006071 RID: 24689
		// (get) Token: 0x0601C9A5 RID: 117157 RVA: 0x004217EB File Offset: 0x0041F9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuKujiGachaResponse.Descriptor;
			}
		}

		// Token: 0x0601C9A6 RID: 117158 RVA: 0x004217F2 File Offset: 0x0041F9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaResponse()
		{
		}

		// Token: 0x0601C9A7 RID: 117159 RVA: 0x00421808 File Offset: 0x0041FA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaResponse(WuWuKujiGachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.trickType_ = other.trickType_;
			this.awards_ = other.awards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9A8 RID: 117160 RVA: 0x00421855 File Offset: 0x0041FA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaResponse Clone()
		{
			return new WuWuKujiGachaResponse(this);
		}

		// Token: 0x17006072 RID: 24690
		// (get) Token: 0x0601C9A9 RID: 117161 RVA: 0x0042185D File Offset: 0x0041FA5D
		// (set) Token: 0x0601C9AA RID: 117162 RVA: 0x00421865 File Offset: 0x0041FA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17006073 RID: 24691
		// (get) Token: 0x0601C9AB RID: 117163 RVA: 0x0042186E File Offset: 0x0041FA6E
		// (set) Token: 0x0601C9AC RID: 117164 RVA: 0x00421876 File Offset: 0x0041FA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrickType
		{
			get
			{
				return this.trickType_;
			}
			set
			{
				this.trickType_ = value;
			}
		}

		// Token: 0x17006074 RID: 24692
		// (get) Token: 0x0601C9AD RID: 117165 RVA: 0x0042187F File Offset: 0x0041FA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleGachaAwardPb> Awards
		{
			get
			{
				return this.awards_;
			}
		}

		// Token: 0x0601C9AE RID: 117166 RVA: 0x00421887 File Offset: 0x0041FA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuKujiGachaResponse);
		}

		// Token: 0x0601C9AF RID: 117167 RVA: 0x00421898 File Offset: 0x0041FA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuKujiGachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TrickType == other.TrickType && this.awards_.Equals(other.awards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9B0 RID: 117168 RVA: 0x004218F8 File Offset: 0x0041FAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TrickType != 0)
			{
				num ^= this.TrickType.GetHashCode();
			}
			num ^= this.awards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C9B1 RID: 117169 RVA: 0x00421964 File Offset: 0x0041FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9B2 RID: 117170 RVA: 0x00421971 File Offset: 0x0041FB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9B3 RID: 117171 RVA: 0x0042197C File Offset: 0x0041FB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.awards_.WriteTo(ref output, WuWuKujiGachaResponse._repeated_awards_codec);
			if (this.TrickType != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TrickType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9B4 RID: 117172 RVA: 0x004219E8 File Offset: 0x0041FBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TrickType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrickType);
			}
			num += this.awards_.CalculateSize(WuWuKujiGachaResponse._repeated_awards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C9B5 RID: 117173 RVA: 0x00421A54 File Offset: 0x0041FC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuKujiGachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TrickType != 0)
			{
				this.TrickType = other.TrickType;
			}
			this.awards_.Add(other.awards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C9B6 RID: 117174 RVA: 0x00421AB5 File Offset: 0x0041FCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9B7 RID: 117175 RVA: 0x00421AC0 File Offset: 0x0041FCC0
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
					if (num != 98U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TrickType = input.ReadInt32();
						}
					}
					else
					{
						this.awards_.AddEntriesFrom(ref input, WuWuKujiGachaResponse._repeated_awards_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A397 RID: 41879
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A398 RID: 41880
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400A399 RID: 41881
		private ErrorCode errorCode_;

		// Token: 0x0400A39A RID: 41882
		public const int TrickTypeFieldNumber = 15;

		// Token: 0x0400A39B RID: 41883
		private int trickType_;

		// Token: 0x0400A39C RID: 41884
		public const int AwardsFieldNumber = 12;

		// Token: 0x0400A39D RID: 41885
		private static readonly FieldCodec<SingleGachaAwardPb> _repeated_awards_codec = FieldCodec.ForMessage<SingleGachaAwardPb>(98U, SingleGachaAwardPb.Parser);

		// Token: 0x0400A39E RID: 41886
		private readonly RepeatedField<SingleGachaAwardPb> awards_ = new RepeatedField<SingleGachaAwardPb>();
	}
}
