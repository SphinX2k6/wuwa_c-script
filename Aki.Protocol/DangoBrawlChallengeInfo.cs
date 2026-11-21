using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000343 RID: 835
	public sealed class DangoBrawlChallengeInfo : IMessage<DangoBrawlChallengeInfo>, IMessage, IEquatable<DangoBrawlChallengeInfo>, IDeepCloneable<DangoBrawlChallengeInfo>, IBufferMessage
	{
		// Token: 0x060053E2 RID: 21474 RVA: 0x000CCD70 File Offset: 0x000CAF70
		[NullableContext(1)]
		public static DangoBrawlChallengeInfo Create()
		{
			return new DangoBrawlChallengeInfo();
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060053E3 RID: 21475 RVA: 0x000CCD77 File Offset: 0x000CAF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlChallengeInfo> Parser
		{
			get
			{
				return DangoBrawlChallengeInfo._parser;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x000CCD7E File Offset: 0x000CAF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x000CCD81 File Offset: 0x000CAF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlChallengeInfo.Descriptor;
			}
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x000CCD88 File Offset: 0x000CAF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeInfo()
		{
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x000CCD90 File Offset: 0x000CAF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeInfo(DangoBrawlChallengeInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.state_ = other.state_;
			this.retryCount_ = other.retryCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x000CCDCD File Offset: 0x000CAFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeInfo Clone()
		{
			return new DangoBrawlChallengeInfo(this);
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x000CCDD5 File Offset: 0x000CAFD5
		// (set) Token: 0x060053EA RID: 21482 RVA: 0x000CCDDD File Offset: 0x000CAFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x060053EB RID: 21483 RVA: 0x000CCDE6 File Offset: 0x000CAFE6
		// (set) Token: 0x060053EC RID: 21484 RVA: 0x000CCDEE File Offset: 0x000CAFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlChallengeState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x060053ED RID: 21485 RVA: 0x000CCDF7 File Offset: 0x000CAFF7
		// (set) Token: 0x060053EE RID: 21486 RVA: 0x000CCDFF File Offset: 0x000CAFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RetryCount
		{
			get
			{
				return this.retryCount_;
			}
			set
			{
				this.retryCount_ = value;
			}
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x000CCE08 File Offset: 0x000CB008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlChallengeInfo);
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x000CCE18 File Offset: 0x000CB018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.State == other.State && this.RetryCount == other.RetryCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x000CCE74 File Offset: 0x000CB074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.State != DangoBrawlChallengeState.Locked)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.RetryCount != 0)
			{
				num ^= this.RetryCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x000CCEEB File Offset: 0x000CB0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x000CCEF8 File Offset: 0x000CB0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x000CCF04 File Offset: 0x000CB104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.State != DangoBrawlChallengeState.Locked)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.RetryCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RetryCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x000CCF78 File Offset: 0x000CB178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.State != DangoBrawlChallengeState.Locked)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.RetryCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RetryCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x000CCFE8 File Offset: 0x000CB1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.State != DangoBrawlChallengeState.Locked)
			{
				this.State = other.State;
			}
			if (other.RetryCount != 0)
			{
				this.RetryCount = other.RetryCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x000CD04C File Offset: 0x000CB24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x000CD058 File Offset: 0x000CB258
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RetryCount = input.ReadInt32();
						}
					}
					else
					{
						this.State = (DangoBrawlChallengeState)input.ReadEnum();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040033F3 RID: 13299
		private static readonly MessageParser<DangoBrawlChallengeInfo> _parser = new MessageParser<DangoBrawlChallengeInfo>(() => new DangoBrawlChallengeInfo());

		// Token: 0x040033F4 RID: 13300
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033F5 RID: 13301
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x040033F6 RID: 13302
		private int challengeId_;

		// Token: 0x040033F7 RID: 13303
		public const int StateFieldNumber = 2;

		// Token: 0x040033F8 RID: 13304
		private DangoBrawlChallengeState state_;

		// Token: 0x040033F9 RID: 13305
		public const int RetryCountFieldNumber = 3;

		// Token: 0x040033FA RID: 13306
		private int retryCount_;
	}
}
