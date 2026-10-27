using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F42 RID: 3906
	[NetMessage(EMessageId.RhythmRankListSelfDataResponse)]
	public sealed class RhythmRankListSelfDataResponse : IMessage<RhythmRankListSelfDataResponse>, IMessage, IEquatable<RhythmRankListSelfDataResponse>, IDeepCloneable<RhythmRankListSelfDataResponse>, IBufferMessage
	{
		// Token: 0x06014E5B RID: 85595 RVA: 0x00307FE9 File Offset: 0x003061E9
		[NullableContext(1)]
		public static RhythmRankListSelfDataResponse Create()
		{
			return new RhythmRankListSelfDataResponse();
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x06014E5C RID: 85596 RVA: 0x00307FF0 File Offset: 0x003061F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x06014E5D RID: 85597 RVA: 0x00307FF3 File Offset: 0x003061F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListSelfDataResponse.Descriptor;
			}
		}

		// Token: 0x06014E5E RID: 85598 RVA: 0x00307FFA File Offset: 0x003061FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataResponse()
		{
		}

		// Token: 0x06014E5F RID: 85599 RVA: 0x00308004 File Offset: 0x00306204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataResponse(RhythmRankListSelfDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E60 RID: 85600 RVA: 0x00308050 File Offset: 0x00306250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataResponse Clone()
		{
			return new RhythmRankListSelfDataResponse(this);
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x06014E61 RID: 85601 RVA: 0x00308058 File Offset: 0x00306258
		// (set) Token: 0x06014E62 RID: 85602 RVA: 0x00308060 File Offset: 0x00306260
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

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x06014E63 RID: 85603 RVA: 0x00308069 File Offset: 0x00306269
		// (set) Token: 0x06014E64 RID: 85604 RVA: 0x00308071 File Offset: 0x00306271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo SelfData
		{
			get
			{
				return this.selfData_;
			}
			set
			{
				this.selfData_ = value;
			}
		}

		// Token: 0x06014E65 RID: 85605 RVA: 0x0030807A File Offset: 0x0030627A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListSelfDataResponse);
		}

		// Token: 0x06014E66 RID: 85606 RVA: 0x00308088 File Offset: 0x00306288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListSelfDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E67 RID: 85607 RVA: 0x003080D8 File Offset: 0x003062D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.selfData_ != null)
			{
				num ^= this.SelfData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E68 RID: 85608 RVA: 0x00308133 File Offset: 0x00306333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E69 RID: 85609 RVA: 0x00308140 File Offset: 0x00306340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E6A RID: 85610 RVA: 0x0030814C File Offset: 0x0030634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E6B RID: 85611 RVA: 0x003081A8 File Offset: 0x003063A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.selfData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E6C RID: 85612 RVA: 0x00308200 File Offset: 0x00306400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRankListSelfDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.selfData_ != null)
			{
				if (this.selfData_ == null)
				{
					this.SelfData = new RhythmPlayerRankingInfo();
				}
				this.SelfData.MergeFrom(other.SelfData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E6D RID: 85613 RVA: 0x00308268 File Offset: 0x00306468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E6E RID: 85614 RVA: 0x00308274 File Offset: 0x00306474
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
				if (num != 24U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.selfData_ == null)
						{
							this.SelfData = new RhythmPlayerRankingInfo();
						}
						input.ReadMessage(this.SelfData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E03 RID: 32259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E04 RID: 32260
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007E05 RID: 32261
		private ErrorCode errorCode_;

		// Token: 0x04007E06 RID: 32262
		public const int SelfDataFieldNumber = 13;

		// Token: 0x04007E07 RID: 32263
		private RhythmPlayerRankingInfo selfData_;
	}
}
