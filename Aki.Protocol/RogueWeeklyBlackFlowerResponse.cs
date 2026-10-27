using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001031 RID: 4145
	[NetMessage(EMessageId.RogueWeeklyBlackFlowerResponse)]
	public sealed class RogueWeeklyBlackFlowerResponse : IMessage<RogueWeeklyBlackFlowerResponse>, IMessage, IEquatable<RogueWeeklyBlackFlowerResponse>, IDeepCloneable<RogueWeeklyBlackFlowerResponse>, IBufferMessage
	{
		// Token: 0x0601626B RID: 90731 RVA: 0x00337CD1 File Offset: 0x00335ED1
		[NullableContext(1)]
		public static RogueWeeklyBlackFlowerResponse Create()
		{
			return new RogueWeeklyBlackFlowerResponse();
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x0601626C RID: 90732 RVA: 0x00337CD8 File Offset: 0x00335ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x0601626D RID: 90733 RVA: 0x00337CDB File Offset: 0x00335EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBlackFlowerResponse.Descriptor;
			}
		}

		// Token: 0x0601626E RID: 90734 RVA: 0x00337CE2 File Offset: 0x00335EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerResponse()
		{
		}

		// Token: 0x0601626F RID: 90735 RVA: 0x00337CEA File Offset: 0x00335EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerResponse(RogueWeeklyBlackFlowerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.useFreeCount_ = other.useFreeCount_;
			this.maxFreeCount_ = other.maxFreeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016270 RID: 90736 RVA: 0x00337D27 File Offset: 0x00335F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerResponse Clone()
		{
			return new RogueWeeklyBlackFlowerResponse(this);
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x06016271 RID: 90737 RVA: 0x00337D2F File Offset: 0x00335F2F
		// (set) Token: 0x06016272 RID: 90738 RVA: 0x00337D37 File Offset: 0x00335F37
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

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x06016273 RID: 90739 RVA: 0x00337D40 File Offset: 0x00335F40
		// (set) Token: 0x06016274 RID: 90740 RVA: 0x00337D48 File Offset: 0x00335F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseFreeCount
		{
			get
			{
				return this.useFreeCount_;
			}
			set
			{
				this.useFreeCount_ = value;
			}
		}

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x06016275 RID: 90741 RVA: 0x00337D51 File Offset: 0x00335F51
		// (set) Token: 0x06016276 RID: 90742 RVA: 0x00337D59 File Offset: 0x00335F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxFreeCount
		{
			get
			{
				return this.maxFreeCount_;
			}
			set
			{
				this.maxFreeCount_ = value;
			}
		}

		// Token: 0x06016277 RID: 90743 RVA: 0x00337D62 File Offset: 0x00335F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBlackFlowerResponse);
		}

		// Token: 0x06016278 RID: 90744 RVA: 0x00337D70 File Offset: 0x00335F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBlackFlowerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.UseFreeCount == other.UseFreeCount && this.MaxFreeCount == other.MaxFreeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016279 RID: 90745 RVA: 0x00337DCC File Offset: 0x00335FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.UseFreeCount != 0)
			{
				num ^= this.UseFreeCount.GetHashCode();
			}
			if (this.MaxFreeCount != 0)
			{
				num ^= this.MaxFreeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601627A RID: 90746 RVA: 0x00337E43 File Offset: 0x00336043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601627B RID: 90747 RVA: 0x00337E50 File Offset: 0x00336050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601627C RID: 90748 RVA: 0x00337E5C File Offset: 0x0033605C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UseFreeCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.UseFreeCount);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.MaxFreeCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.MaxFreeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601627D RID: 90749 RVA: 0x00337ED4 File Offset: 0x003360D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.UseFreeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseFreeCount);
			}
			if (this.MaxFreeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxFreeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601627E RID: 90750 RVA: 0x00337F44 File Offset: 0x00336144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyBlackFlowerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.UseFreeCount != 0)
			{
				this.UseFreeCount = other.UseFreeCount;
			}
			if (other.MaxFreeCount != 0)
			{
				this.MaxFreeCount = other.MaxFreeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601627F RID: 90751 RVA: 0x00337FA8 File Offset: 0x003361A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016280 RID: 90752 RVA: 0x00337FB4 File Offset: 0x003361B4
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
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MaxFreeCount = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.UseFreeCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400849B RID: 33947
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400849C RID: 33948
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400849D RID: 33949
		private ErrorCode errorCode_;

		// Token: 0x0400849E RID: 33950
		public const int UseFreeCountFieldNumber = 5;

		// Token: 0x0400849F RID: 33951
		private int useFreeCount_;

		// Token: 0x040084A0 RID: 33952
		public const int MaxFreeCountFieldNumber = 12;

		// Token: 0x040084A1 RID: 33953
		private int maxFreeCount_;
	}
}
