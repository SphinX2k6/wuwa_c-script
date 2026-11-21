using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001166 RID: 4454
	[NetMessage(EMessageId.RoverRogueTalentInfoResponse)]
	public sealed class RoverRogueTalentInfoResponse : IMessage<RoverRogueTalentInfoResponse>, IMessage, IEquatable<RoverRogueTalentInfoResponse>, IDeepCloneable<RoverRogueTalentInfoResponse>, IBufferMessage
	{
		// Token: 0x06017CDB RID: 97499 RVA: 0x00377679 File Offset: 0x00375879
		[NullableContext(1)]
		public static RoverRogueTalentInfoResponse Create()
		{
			return new RoverRogueTalentInfoResponse();
		}

		// Token: 0x17005026 RID: 20518
		// (get) Token: 0x06017CDC RID: 97500 RVA: 0x00377680 File Offset: 0x00375880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005027 RID: 20519
		// (get) Token: 0x06017CDD RID: 97501 RVA: 0x00377683 File Offset: 0x00375883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentInfoResponse.Descriptor;
			}
		}

		// Token: 0x06017CDE RID: 97502 RVA: 0x0037768A File Offset: 0x0037588A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoResponse()
		{
		}

		// Token: 0x06017CDF RID: 97503 RVA: 0x003776A0 File Offset: 0x003758A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoResponse(RoverRogueTalentInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.talentId_ = other.talentId_.Clone();
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CE0 RID: 97504 RVA: 0x003776ED File Offset: 0x003758ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoResponse Clone()
		{
			return new RoverRogueTalentInfoResponse(this);
		}

		// Token: 0x17005028 RID: 20520
		// (get) Token: 0x06017CE1 RID: 97505 RVA: 0x003776F5 File Offset: 0x003758F5
		// (set) Token: 0x06017CE2 RID: 97506 RVA: 0x003776FD File Offset: 0x003758FD
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

		// Token: 0x17005029 RID: 20521
		// (get) Token: 0x06017CE3 RID: 97507 RVA: 0x00377706 File Offset: 0x00375906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TalentId
		{
			get
			{
				return this.talentId_;
			}
		}

		// Token: 0x1700502A RID: 20522
		// (get) Token: 0x06017CE4 RID: 97508 RVA: 0x0037770E File Offset: 0x0037590E
		// (set) Token: 0x06017CE5 RID: 97509 RVA: 0x00377716 File Offset: 0x00375916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x06017CE6 RID: 97510 RVA: 0x0037771F File Offset: 0x0037591F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentInfoResponse);
		}

		// Token: 0x06017CE7 RID: 97511 RVA: 0x00377730 File Offset: 0x00375930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.talentId_.Equals(other.talentId_) && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CE8 RID: 97512 RVA: 0x00377790 File Offset: 0x00375990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.talentId_.GetHashCode();
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017CE9 RID: 97513 RVA: 0x003777FC File Offset: 0x003759FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CEA RID: 97514 RVA: 0x00377809 File Offset: 0x00375A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017CEB RID: 97515 RVA: 0x00377814 File Offset: 0x00375A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Point != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Point);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.talentId_.WriteTo(ref output, RoverRogueTalentInfoResponse._repeated_talentId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017CEC RID: 97516 RVA: 0x00377880 File Offset: 0x00375A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.talentId_.CalculateSize(RoverRogueTalentInfoResponse._repeated_talentId_codec);
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017CED RID: 97517 RVA: 0x003778EC File Offset: 0x00375AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTalentInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.talentId_.Add(other.talentId_);
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017CEE RID: 97518 RVA: 0x0037794D File Offset: 0x00375B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017CEF RID: 97519 RVA: 0x00377958 File Offset: 0x00375B58
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
				if (num <= 96U)
				{
					if (num == 48U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.talentId_.AddEntriesFrom(ref input, RoverRogueTalentInfoResponse._repeated_talentId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008E0E RID: 36366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E0F RID: 36367
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008E10 RID: 36368
		private ErrorCode errorCode_;

		// Token: 0x04008E11 RID: 36369
		public const int TalentIdFieldNumber = 15;

		// Token: 0x04008E12 RID: 36370
		private static readonly FieldCodec<int> _repeated_talentId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008E13 RID: 36371
		private readonly RepeatedField<int> talentId_ = new RepeatedField<int>();

		// Token: 0x04008E14 RID: 36372
		public const int PointFieldNumber = 6;

		// Token: 0x04008E15 RID: 36373
		private int point_;
	}
}
