using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000392 RID: 914
	[NetMessage(EMessageId.DangoMonopolyNextBoardResponse)]
	public sealed class DangoMonopolyNextBoardResponse : IMessage<DangoMonopolyNextBoardResponse>, IMessage, IEquatable<DangoMonopolyNextBoardResponse>, IDeepCloneable<DangoMonopolyNextBoardResponse>, IBufferMessage
	{
		// Token: 0x06005A80 RID: 23168 RVA: 0x000DC819 File Offset: 0x000DAA19
		[NullableContext(1)]
		public static DangoMonopolyNextBoardResponse Create()
		{
			return new DangoMonopolyNextBoardResponse();
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06005A81 RID: 23169 RVA: 0x000DC820 File Offset: 0x000DAA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x000DC823 File Offset: 0x000DAA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyNextBoardResponse.Descriptor;
			}
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x000DC82A File Offset: 0x000DAA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardResponse()
		{
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x000DC840 File Offset: 0x000DAA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardResponse(DangoMonopolyNextBoardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.boardId_ = other.boardId_;
			this.propertyIds_ = other.propertyIds_.Clone();
			this.boardUnlockTime_ = other.boardUnlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x000DC899 File Offset: 0x000DAA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyNextBoardResponse Clone()
		{
			return new DangoMonopolyNextBoardResponse(this);
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x000DC8A1 File Offset: 0x000DAAA1
		// (set) Token: 0x06005A87 RID: 23175 RVA: 0x000DC8A9 File Offset: 0x000DAAA9
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

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06005A88 RID: 23176 RVA: 0x000DC8B2 File Offset: 0x000DAAB2
		// (set) Token: 0x06005A89 RID: 23177 RVA: 0x000DC8BA File Offset: 0x000DAABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoardId
		{
			get
			{
				return this.boardId_;
			}
			set
			{
				this.boardId_ = value;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06005A8A RID: 23178 RVA: 0x000DC8C3 File Offset: 0x000DAAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyIds
		{
			get
			{
				return this.propertyIds_;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06005A8B RID: 23179 RVA: 0x000DC8CB File Offset: 0x000DAACB
		// (set) Token: 0x06005A8C RID: 23180 RVA: 0x000DC8D3 File Offset: 0x000DAAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BoardUnlockTime
		{
			get
			{
				return this.boardUnlockTime_;
			}
			set
			{
				this.boardUnlockTime_ = value;
			}
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x000DC8DC File Offset: 0x000DAADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyNextBoardResponse);
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x000DC8EC File Offset: 0x000DAAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyNextBoardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BoardId == other.BoardId && this.propertyIds_.Equals(other.propertyIds_) && this.BoardUnlockTime == other.BoardUnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x000DC95C File Offset: 0x000DAB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.BoardId != 0)
			{
				num ^= this.BoardId.GetHashCode();
			}
			num ^= this.propertyIds_.GetHashCode();
			if (this.BoardUnlockTime != 0L)
			{
				num ^= this.BoardUnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x000DC9E1 File Offset: 0x000DABE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x000DC9EE File Offset: 0x000DABEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x000DC9F8 File Offset: 0x000DABF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.BoardUnlockTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.BoardUnlockTime);
			}
			this.propertyIds_.WriteTo(ref output, DangoMonopolyNextBoardResponse._repeated_propertyIds_codec);
			if (this.BoardId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.BoardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x000DCA80 File Offset: 0x000DAC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.BoardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoardId);
			}
			num += this.propertyIds_.CalculateSize(DangoMonopolyNextBoardResponse._repeated_propertyIds_codec);
			if (this.BoardUnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BoardUnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x000DCB04 File Offset: 0x000DAD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyNextBoardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.BoardId != 0)
			{
				this.BoardId = other.BoardId;
			}
			this.propertyIds_.Add(other.propertyIds_);
			if (other.BoardUnlockTime != 0L)
			{
				this.BoardUnlockTime = other.BoardUnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x000DCB79 File Offset: 0x000DAD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x000DCB84 File Offset: 0x000DAD84
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.BoardUnlockTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U || num == 82U)
					{
						this.propertyIds_.AddEntriesFrom(ref input, DangoMonopolyNextBoardResponse._repeated_propertyIds_codec);
						continue;
					}
					if (num == 88U)
					{
						this.BoardId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003608 RID: 13832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003609 RID: 13833
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400360A RID: 13834
		private ErrorCode errorCode_;

		// Token: 0x0400360B RID: 13835
		public const int BoardIdFieldNumber = 11;

		// Token: 0x0400360C RID: 13836
		private int boardId_;

		// Token: 0x0400360D RID: 13837
		public const int PropertyIdsFieldNumber = 10;

		// Token: 0x0400360E RID: 13838
		private static readonly FieldCodec<int> _repeated_propertyIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400360F RID: 13839
		private readonly RepeatedField<int> propertyIds_ = new RepeatedField<int>();

		// Token: 0x04003610 RID: 13840
		public const int BoardUnlockTimeFieldNumber = 7;

		// Token: 0x04003611 RID: 13841
		private long boardUnlockTime_;
	}
}
