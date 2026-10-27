using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DB RID: 475
	[NetMessage(EMessageId.BossRushLevelScoreRewardResponse)]
	public sealed class BossRushLevelScoreRewardResponse : IMessage<BossRushLevelScoreRewardResponse>, IMessage, IEquatable<BossRushLevelScoreRewardResponse>, IDeepCloneable<BossRushLevelScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x060035B7 RID: 13751 RVA: 0x00087208 File Offset: 0x00085408
		[NullableContext(1)]
		public static BossRushLevelScoreRewardResponse Create()
		{
			return new BossRushLevelScoreRewardResponse();
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x0008720F File Offset: 0x0008540F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x00087212 File Offset: 0x00085412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00087219 File Offset: 0x00085419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardResponse()
		{
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00087221 File Offset: 0x00085421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardResponse(BossRushLevelScoreRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00087246 File Offset: 0x00085446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelScoreRewardResponse Clone()
		{
			return new BossRushLevelScoreRewardResponse(this);
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x0008724E File Offset: 0x0008544E
		// (set) Token: 0x060035BE RID: 13758 RVA: 0x00087256 File Offset: 0x00085456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x0008725F File Offset: 0x0008545F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelScoreRewardResponse);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x0008726D File Offset: 0x0008546D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelScoreRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0008729C File Offset: 0x0008549C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x000872E1 File Offset: 0x000854E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x000872EE File Offset: 0x000854EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x000872F7 File Offset: 0x000854F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x0008732C File Offset: 0x0008552C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0008736A File Offset: 0x0008556A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushLevelScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0008739B File Offset: 0x0008559B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x000873A4 File Offset: 0x000855A4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A71 RID: 10865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A72 RID: 10866
		public const int ErrorFieldNumber = 10;

		// Token: 0x04002A73 RID: 10867
		private ErrorCode error_;
	}
}
