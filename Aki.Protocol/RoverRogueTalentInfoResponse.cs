using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112C RID: 4396
	[NetMessage(EMessageId.RoverRogueTalentInfoResponse)]
	public sealed class RoverRogueTalentInfoResponse : IMessage<RoverRogueTalentInfoResponse>, IMessage, IEquatable<RoverRogueTalentInfoResponse>, IDeepCloneable<RoverRogueTalentInfoResponse>, IBufferMessage
	{
		// Token: 0x0601773A RID: 96058 RVA: 0x0036832D File Offset: 0x0036652D
		[NullableContext(1)]
		public static RoverRogueTalentInfoResponse Create()
		{
			return new RoverRogueTalentInfoResponse();
		}

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x0601773B RID: 96059 RVA: 0x00368334 File Offset: 0x00366534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x0601773C RID: 96060 RVA: 0x00368337 File Offset: 0x00366537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601773D RID: 96061 RVA: 0x0036833E File Offset: 0x0036653E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoResponse()
		{
		}

		// Token: 0x0601773E RID: 96062 RVA: 0x00368354 File Offset: 0x00366554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoResponse(RoverRogueTalentInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.talentId_ = other.talentId_.Clone();
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601773F RID: 96063 RVA: 0x003683A1 File Offset: 0x003665A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentInfoResponse Clone()
		{
			return new RoverRogueTalentInfoResponse(this);
		}

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x06017740 RID: 96064 RVA: 0x003683A9 File Offset: 0x003665A9
		// (set) Token: 0x06017741 RID: 96065 RVA: 0x003683B1 File Offset: 0x003665B1
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

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x06017742 RID: 96066 RVA: 0x003683BA File Offset: 0x003665BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TalentId
		{
			get
			{
				return this.talentId_;
			}
		}

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x06017743 RID: 96067 RVA: 0x003683C2 File Offset: 0x003665C2
		// (set) Token: 0x06017744 RID: 96068 RVA: 0x003683CA File Offset: 0x003665CA
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

		// Token: 0x06017745 RID: 96069 RVA: 0x003683D3 File Offset: 0x003665D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentInfoResponse);
		}

		// Token: 0x06017746 RID: 96070 RVA: 0x003683E4 File Offset: 0x003665E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.talentId_.Equals(other.talentId_) && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017747 RID: 96071 RVA: 0x00368444 File Offset: 0x00366644
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

		// Token: 0x06017748 RID: 96072 RVA: 0x003684B0 File Offset: 0x003666B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017749 RID: 96073 RVA: 0x003684BD File Offset: 0x003666BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601774A RID: 96074 RVA: 0x003684C8 File Offset: 0x003666C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talentId_.WriteTo(ref output, RoverRogueTalentInfoResponse._repeated_talentId_codec);
			if (this.Point != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Point);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601774B RID: 96075 RVA: 0x00368534 File Offset: 0x00366734
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

		// Token: 0x0601774C RID: 96076 RVA: 0x003685A0 File Offset: 0x003667A0
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

		// Token: 0x0601774D RID: 96077 RVA: 0x00368601 File Offset: 0x00366801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601774E RID: 96078 RVA: 0x0036860C File Offset: 0x0036680C
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.talentId_.AddEntriesFrom(ref input, RoverRogueTalentInfoResponse._repeated_talentId_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B7B RID: 35707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B7C RID: 35708
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008B7D RID: 35709
		private ErrorCode errorCode_;

		// Token: 0x04008B7E RID: 35710
		public const int TalentIdFieldNumber = 6;

		// Token: 0x04008B7F RID: 35711
		private static readonly FieldCodec<int> _repeated_talentId_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04008B80 RID: 35712
		private readonly RepeatedField<int> talentId_ = new RepeatedField<int>();

		// Token: 0x04008B81 RID: 35713
		public const int PointFieldNumber = 7;

		// Token: 0x04008B82 RID: 35714
		private int point_;
	}
}
