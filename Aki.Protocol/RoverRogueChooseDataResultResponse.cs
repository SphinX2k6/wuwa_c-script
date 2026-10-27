using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F8 RID: 4344
	[NetMessage(EMessageId.RoverRogueChooseDataResultResponse)]
	public sealed class RoverRogueChooseDataResultResponse : IMessage<RoverRogueChooseDataResultResponse>, IMessage, IEquatable<RoverRogueChooseDataResultResponse>, IDeepCloneable<RoverRogueChooseDataResultResponse>, IBufferMessage
	{
		// Token: 0x060172A7 RID: 94887 RVA: 0x0035CB90 File Offset: 0x0035AD90
		[NullableContext(1)]
		public static RoverRogueChooseDataResultResponse Create()
		{
			return new RoverRogueChooseDataResultResponse();
		}

		// Token: 0x17004D9F RID: 19871
		// (get) Token: 0x060172A8 RID: 94888 RVA: 0x0035CB97 File Offset: 0x0035AD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DA0 RID: 19872
		// (get) Token: 0x060172A9 RID: 94889 RVA: 0x0035CB9A File Offset: 0x0035AD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueChooseDataResultResponse.Descriptor;
			}
		}

		// Token: 0x060172AA RID: 94890 RVA: 0x0035CBA1 File Offset: 0x0035ADA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultResponse()
		{
		}

		// Token: 0x060172AB RID: 94891 RVA: 0x0035CBA9 File Offset: 0x0035ADA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultResponse(RoverRogueChooseDataResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.isSelect_ = other.isSelect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172AC RID: 94892 RVA: 0x0035CBDA File Offset: 0x0035ADDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseDataResultResponse Clone()
		{
			return new RoverRogueChooseDataResultResponse(this);
		}

		// Token: 0x17004DA1 RID: 19873
		// (get) Token: 0x060172AD RID: 94893 RVA: 0x0035CBE2 File Offset: 0x0035ADE2
		// (set) Token: 0x060172AE RID: 94894 RVA: 0x0035CBEA File Offset: 0x0035ADEA
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

		// Token: 0x17004DA2 RID: 19874
		// (get) Token: 0x060172AF RID: 94895 RVA: 0x0035CBF3 File Offset: 0x0035ADF3
		// (set) Token: 0x060172B0 RID: 94896 RVA: 0x0035CBFB File Offset: 0x0035ADFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x060172B1 RID: 94897 RVA: 0x0035CC04 File Offset: 0x0035AE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueChooseDataResultResponse);
		}

		// Token: 0x060172B2 RID: 94898 RVA: 0x0035CC12 File Offset: 0x0035AE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueChooseDataResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IsSelect == other.IsSelect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172B3 RID: 94899 RVA: 0x0035CC50 File Offset: 0x0035AE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060172B4 RID: 94900 RVA: 0x0035CCAE File Offset: 0x0035AEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172B5 RID: 94901 RVA: 0x0035CCBB File Offset: 0x0035AEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172B6 RID: 94902 RVA: 0x0035CCC4 File Offset: 0x0035AEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsSelect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172B7 RID: 94903 RVA: 0x0035CD20 File Offset: 0x0035AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.IsSelect)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060172B8 RID: 94904 RVA: 0x0035CD6C File Offset: 0x0035AF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueChooseDataResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060172B9 RID: 94905 RVA: 0x0035CDBC File Offset: 0x0035AFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172BA RID: 94906 RVA: 0x0035CDC8 File Offset: 0x0035AFC8
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
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsSelect = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040089C9 RID: 35273
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089CA RID: 35274
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040089CB RID: 35275
		private ErrorCode errorCode_;

		// Token: 0x040089CC RID: 35276
		public const int IsSelectFieldNumber = 12;

		// Token: 0x040089CD RID: 35277
		private bool isSelect_;
	}
}
