using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043C RID: 1084
	[NetMessage(EMessageId.EnterGameResponse)]
	public sealed class EnterGameResponse : IMessage<EnterGameResponse>, IMessage, IEquatable<EnterGameResponse>, IDeepCloneable<EnterGameResponse>, IBufferMessage
	{
		// Token: 0x06006817 RID: 26647 RVA: 0x000FA452 File Offset: 0x000F8652
		[NullableContext(1)]
		public static EnterGameResponse Create()
		{
			return new EnterGameResponse();
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06006818 RID: 26648 RVA: 0x000FA459 File Offset: 0x000F8659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x000FA45C File Offset: 0x000F865C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterGameResponse.Descriptor;
			}
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x000FA463 File Offset: 0x000F8663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameResponse()
		{
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x000FA46C File Offset: 0x000F866C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameResponse(EnterGameResponse other) : this()
		{
			this.code_ = other.code_;
			this.clientWaitingMode_ = other.clientWaitingMode_;
			this.clientWaitingTime_ = other.clientWaitingTime_;
			this.clientAutoInInterval_ = other.clientAutoInInterval_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x000FA4C0 File Offset: 0x000F86C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameResponse Clone()
		{
			return new EnterGameResponse(this);
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600681D RID: 26653 RVA: 0x000FA4C8 File Offset: 0x000F86C8
		// (set) Token: 0x0600681E RID: 26654 RVA: 0x000FA4D0 File Offset: 0x000F86D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600681F RID: 26655 RVA: 0x000FA4D9 File Offset: 0x000F86D9
		// (set) Token: 0x06006820 RID: 26656 RVA: 0x000FA4E1 File Offset: 0x000F86E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientWaitingMode
		{
			get
			{
				return this.clientWaitingMode_;
			}
			set
			{
				this.clientWaitingMode_ = value;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x000FA4EA File Offset: 0x000F86EA
		// (set) Token: 0x06006822 RID: 26658 RVA: 0x000FA4F2 File Offset: 0x000F86F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientWaitingTime
		{
			get
			{
				return this.clientWaitingTime_;
			}
			set
			{
				this.clientWaitingTime_ = value;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06006823 RID: 26659 RVA: 0x000FA4FB File Offset: 0x000F86FB
		// (set) Token: 0x06006824 RID: 26660 RVA: 0x000FA503 File Offset: 0x000F8703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientAutoInInterval
		{
			get
			{
				return this.clientAutoInInterval_;
			}
			set
			{
				this.clientAutoInInterval_ = value;
			}
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x000FA50C File Offset: 0x000F870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterGameResponse);
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x000FA51C File Offset: 0x000F871C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterGameResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.ClientWaitingMode == other.ClientWaitingMode && this.ClientWaitingTime == other.ClientWaitingTime && this.ClientAutoInInterval == other.ClientAutoInInterval && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x000FA588 File Offset: 0x000F8788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.ClientWaitingMode != 0)
			{
				num ^= this.ClientWaitingMode.GetHashCode();
			}
			if (this.ClientWaitingTime != 0)
			{
				num ^= this.ClientWaitingTime.GetHashCode();
			}
			if (this.ClientAutoInInterval != 0)
			{
				num ^= this.ClientAutoInInterval.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x000FA618 File Offset: 0x000F8818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x000FA625 File Offset: 0x000F8825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x000FA630 File Offset: 0x000F8830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.ClientWaitingMode != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ClientWaitingMode);
			}
			if (this.ClientWaitingTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ClientWaitingTime);
			}
			if (this.ClientAutoInInterval != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ClientAutoInInterval);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x000FA6C0 File Offset: 0x000F88C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.ClientWaitingMode != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientWaitingMode);
			}
			if (this.ClientWaitingTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientWaitingTime);
			}
			if (this.ClientAutoInInterval != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientAutoInInterval);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x000FA748 File Offset: 0x000F8948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterGameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.ClientWaitingMode != 0)
			{
				this.ClientWaitingMode = other.ClientWaitingMode;
			}
			if (other.ClientWaitingTime != 0)
			{
				this.ClientWaitingTime = other.ClientWaitingTime;
			}
			if (other.ClientAutoInInterval != 0)
			{
				this.ClientAutoInInterval = other.ClientAutoInInterval;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x000FA7C0 File Offset: 0x000F89C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x000FA7CC File Offset: 0x000F89CC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.ClientWaitingMode = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ClientWaitingTime = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ClientAutoInInterval = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040039EF RID: 14831
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F0 RID: 14832
		public const int CodeFieldNumber = 1;

		// Token: 0x040039F1 RID: 14833
		private ErrorCode code_;

		// Token: 0x040039F2 RID: 14834
		public const int ClientWaitingModeFieldNumber = 2;

		// Token: 0x040039F3 RID: 14835
		private int clientWaitingMode_;

		// Token: 0x040039F4 RID: 14836
		public const int ClientWaitingTimeFieldNumber = 3;

		// Token: 0x040039F5 RID: 14837
		private int clientWaitingTime_;

		// Token: 0x040039F6 RID: 14838
		public const int ClientAutoInIntervalFieldNumber = 4;

		// Token: 0x040039F7 RID: 14839
		private int clientAutoInInterval_;
	}
}
