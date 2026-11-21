using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001021 RID: 4129
	[NetMessage(EMessageId.RogueWeeklyBlackFlowerResponse)]
	public sealed class RogueWeeklyBlackFlowerResponse : IMessage<RogueWeeklyBlackFlowerResponse>, IMessage, IEquatable<RogueWeeklyBlackFlowerResponse>, IDeepCloneable<RogueWeeklyBlackFlowerResponse>, IBufferMessage
	{
		// Token: 0x06016186 RID: 90502 RVA: 0x0033660C File Offset: 0x0033480C
		[NullableContext(1)]
		public static RogueWeeklyBlackFlowerResponse Create()
		{
			return new RogueWeeklyBlackFlowerResponse();
		}

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x06016187 RID: 90503 RVA: 0x00336613 File Offset: 0x00334813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x06016188 RID: 90504 RVA: 0x00336616 File Offset: 0x00334816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBlackFlowerResponse.Descriptor;
			}
		}

		// Token: 0x06016189 RID: 90505 RVA: 0x0033661D File Offset: 0x0033481D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerResponse()
		{
		}

		// Token: 0x0601618A RID: 90506 RVA: 0x00336625 File Offset: 0x00334825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerResponse(RogueWeeklyBlackFlowerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.useFreeCount_ = other.useFreeCount_;
			this.maxFreeCount_ = other.maxFreeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601618B RID: 90507 RVA: 0x00336662 File Offset: 0x00334862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBlackFlowerResponse Clone()
		{
			return new RogueWeeklyBlackFlowerResponse(this);
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x0601618C RID: 90508 RVA: 0x0033666A File Offset: 0x0033486A
		// (set) Token: 0x0601618D RID: 90509 RVA: 0x00336672 File Offset: 0x00334872
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

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x0601618E RID: 90510 RVA: 0x0033667B File Offset: 0x0033487B
		// (set) Token: 0x0601618F RID: 90511 RVA: 0x00336683 File Offset: 0x00334883
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

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x06016190 RID: 90512 RVA: 0x0033668C File Offset: 0x0033488C
		// (set) Token: 0x06016191 RID: 90513 RVA: 0x00336694 File Offset: 0x00334894
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

		// Token: 0x06016192 RID: 90514 RVA: 0x0033669D File Offset: 0x0033489D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBlackFlowerResponse);
		}

		// Token: 0x06016193 RID: 90515 RVA: 0x003366AC File Offset: 0x003348AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBlackFlowerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.UseFreeCount == other.UseFreeCount && this.MaxFreeCount == other.MaxFreeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016194 RID: 90516 RVA: 0x00336708 File Offset: 0x00334908
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

		// Token: 0x06016195 RID: 90517 RVA: 0x0033677F File Offset: 0x0033497F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016196 RID: 90518 RVA: 0x0033678C File Offset: 0x0033498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016197 RID: 90519 RVA: 0x00336798 File Offset: 0x00334998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.MaxFreeCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MaxFreeCount);
			}
			if (this.UseFreeCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.UseFreeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016198 RID: 90520 RVA: 0x00336810 File Offset: 0x00334A10
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

		// Token: 0x06016199 RID: 90521 RVA: 0x00336880 File Offset: 0x00334A80
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

		// Token: 0x0601619A RID: 90522 RVA: 0x003368E4 File Offset: 0x00334AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601619B RID: 90523 RVA: 0x003368F0 File Offset: 0x00334AF0
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
					if (num != 72U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UseFreeCount = input.ReadInt32();
						}
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
		}

		// Token: 0x040084C5 RID: 33989
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084C6 RID: 33990
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040084C7 RID: 33991
		private ErrorCode errorCode_;

		// Token: 0x040084C8 RID: 33992
		public const int UseFreeCountFieldNumber = 14;

		// Token: 0x040084C9 RID: 33993
		private int useFreeCount_;

		// Token: 0x040084CA RID: 33994
		public const int MaxFreeCountFieldNumber = 9;

		// Token: 0x040084CB RID: 33995
		private int maxFreeCount_;
	}
}
