using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A69 RID: 2665
	[NetMessage(EMessageId.MotorFightSettleResponse)]
	public sealed class MotorFightSettleResponse : IMessage<MotorFightSettleResponse>, IMessage, IEquatable<MotorFightSettleResponse>, IDeepCloneable<MotorFightSettleResponse>, IBufferMessage
	{
		// Token: 0x0600E876 RID: 59510 RVA: 0x0021F682 File Offset: 0x0021D882
		[NullableContext(1)]
		public static MotorFightSettleResponse Create()
		{
			return new MotorFightSettleResponse();
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0600E877 RID: 59511 RVA: 0x0021F689 File Offset: 0x0021D889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x0600E878 RID: 59512 RVA: 0x0021F68C File Offset: 0x0021D88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSettleResponse.Descriptor;
			}
		}

		// Token: 0x0600E879 RID: 59513 RVA: 0x0021F693 File Offset: 0x0021D893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleResponse()
		{
		}

		// Token: 0x0600E87A RID: 59514 RVA: 0x0021F69C File Offset: 0x0021D89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleResponse(MotorFightSettleResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.win_ = other.win_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E87B RID: 59515 RVA: 0x0021F6F4 File Offset: 0x0021D8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleResponse Clone()
		{
			return new MotorFightSettleResponse(this);
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0600E87C RID: 59516 RVA: 0x0021F6FC File Offset: 0x0021D8FC
		// (set) Token: 0x0600E87D RID: 59517 RVA: 0x0021F704 File Offset: 0x0021D904
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

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x0600E87E RID: 59518 RVA: 0x0021F70D File Offset: 0x0021D90D
		// (set) Token: 0x0600E87F RID: 59519 RVA: 0x0021F715 File Offset: 0x0021D915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0600E880 RID: 59520 RVA: 0x0021F71E File Offset: 0x0021D91E
		// (set) Token: 0x0600E881 RID: 59521 RVA: 0x0021F726 File Offset: 0x0021D926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0600E882 RID: 59522 RVA: 0x0021F72F File Offset: 0x0021D92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSettleResponse);
		}

		// Token: 0x0600E883 RID: 59523 RVA: 0x0021F740 File Offset: 0x0021D940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSettleResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Win == other.Win && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E884 RID: 59524 RVA: 0x0021F7A0 File Offset: 0x0021D9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E885 RID: 59525 RVA: 0x0021F814 File Offset: 0x0021DA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E886 RID: 59526 RVA: 0x0021F821 File Offset: 0x0021DA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E887 RID: 59527 RVA: 0x0021F82C File Offset: 0x0021DA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Result);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.Win)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Win);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E888 RID: 59528 RVA: 0x0021F8A4 File Offset: 0x0021DAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Win)
			{
				num += 2;
			}
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E889 RID: 59529 RVA: 0x0021F908 File Offset: 0x0021DB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSettleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MotorFightResult();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E88A RID: 59530 RVA: 0x0021F984 File Offset: 0x0021DB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E88B RID: 59531 RVA: 0x0021F990 File Offset: 0x0021DB90
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
				if (num != 18U)
				{
					if (num != 32U)
					{
						if (num != 48U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Win = input.ReadBool();
						}
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.result_ == null)
					{
						this.Result = new MotorFightResult();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x04005EAA RID: 24234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EAB RID: 24235
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04005EAC RID: 24236
		private ErrorCode errCode_;

		// Token: 0x04005EAD RID: 24237
		public const int WinFieldNumber = 6;

		// Token: 0x04005EAE RID: 24238
		private bool win_;

		// Token: 0x04005EAF RID: 24239
		public const int ResultFieldNumber = 2;

		// Token: 0x04005EB0 RID: 24240
		private MotorFightResult result_;
	}
}
