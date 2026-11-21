using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000411 RID: 1041
	[NetMessage(EMessageId.EdgeRunnerScoreRewardResponse)]
	public sealed class EdgeRunnerScoreRewardResponse : IMessage<EdgeRunnerScoreRewardResponse>, IMessage, IEquatable<EdgeRunnerScoreRewardResponse>, IDeepCloneable<EdgeRunnerScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x060064A5 RID: 25765 RVA: 0x000F2C80 File Offset: 0x000F0E80
		[NullableContext(1)]
		public static EdgeRunnerScoreRewardResponse Create()
		{
			return new EdgeRunnerScoreRewardResponse();
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x000F2C87 File Offset: 0x000F0E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x000F2C8A File Offset: 0x000F0E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x000F2C91 File Offset: 0x000F0E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardResponse()
		{
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x000F2C99 File Offset: 0x000F0E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardResponse(EdgeRunnerScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x000F2CBE File Offset: 0x000F0EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardResponse Clone()
		{
			return new EdgeRunnerScoreRewardResponse(this);
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x000F2CC6 File Offset: 0x000F0EC6
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x000F2CCE File Offset: 0x000F0ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x000F2CD7 File Offset: 0x000F0ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerScoreRewardResponse);
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x000F2CE5 File Offset: 0x000F0EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x000F2D14 File Offset: 0x000F0F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x000F2D59 File Offset: 0x000F0F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x000F2D66 File Offset: 0x000F0F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x000F2D6F File Offset: 0x000F0F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x000F2DA4 File Offset: 0x000F0FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x000F2DE2 File Offset: 0x000F0FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x000F2E13 File Offset: 0x000F1013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x000F2E1C File Offset: 0x000F101C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003903 RID: 14595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003904 RID: 14596
		public const int ErrCodeFieldNumber = 5;

		// Token: 0x04003905 RID: 14597
		private ErrorCode errCode_;
	}
}
