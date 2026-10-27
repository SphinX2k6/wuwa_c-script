using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000453 RID: 1107
	[NetMessage(EMessageId.EnterGameResponse)]
	public sealed class EnterGameResponse : IMessage<EnterGameResponse>, IMessage, IEquatable<EnterGameResponse>, IDeepCloneable<EnterGameResponse>, IBufferMessage
	{
		// Token: 0x060069A7 RID: 27047 RVA: 0x000FD5DE File Offset: 0x000FB7DE
		[NullableContext(1)]
		public static EnterGameResponse Create()
		{
			return new EnterGameResponse();
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060069A8 RID: 27048 RVA: 0x000FD5E5 File Offset: 0x000FB7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x000FD5E8 File Offset: 0x000FB7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterGameResponse.Descriptor;
			}
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x000FD5EF File Offset: 0x000FB7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameResponse()
		{
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x000FD5F8 File Offset: 0x000FB7F8
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

		// Token: 0x060069AC RID: 27052 RVA: 0x000FD64C File Offset: 0x000FB84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterGameResponse Clone()
		{
			return new EnterGameResponse(this);
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060069AD RID: 27053 RVA: 0x000FD654 File Offset: 0x000FB854
		// (set) Token: 0x060069AE RID: 27054 RVA: 0x000FD65C File Offset: 0x000FB85C
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

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x000FD665 File Offset: 0x000FB865
		// (set) Token: 0x060069B0 RID: 27056 RVA: 0x000FD66D File Offset: 0x000FB86D
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

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060069B1 RID: 27057 RVA: 0x000FD676 File Offset: 0x000FB876
		// (set) Token: 0x060069B2 RID: 27058 RVA: 0x000FD67E File Offset: 0x000FB87E
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

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060069B3 RID: 27059 RVA: 0x000FD687 File Offset: 0x000FB887
		// (set) Token: 0x060069B4 RID: 27060 RVA: 0x000FD68F File Offset: 0x000FB88F
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

		// Token: 0x060069B5 RID: 27061 RVA: 0x000FD698 File Offset: 0x000FB898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterGameResponse);
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x000FD6A8 File Offset: 0x000FB8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterGameResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.ClientWaitingMode == other.ClientWaitingMode && this.ClientWaitingTime == other.ClientWaitingTime && this.ClientAutoInInterval == other.ClientAutoInInterval && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x000FD714 File Offset: 0x000FB914
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

		// Token: 0x060069B8 RID: 27064 RVA: 0x000FD7A4 File Offset: 0x000FB9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x000FD7B1 File Offset: 0x000FB9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x000FD7BC File Offset: 0x000FB9BC
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

		// Token: 0x060069BB RID: 27067 RVA: 0x000FD84C File Offset: 0x000FBA4C
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

		// Token: 0x060069BC RID: 27068 RVA: 0x000FD8D4 File Offset: 0x000FBAD4
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

		// Token: 0x060069BD RID: 27069 RVA: 0x000FD94C File Offset: 0x000FBB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x000FD958 File Offset: 0x000FBB58
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

		// Token: 0x04003A02 RID: 14850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A03 RID: 14851
		public const int CodeFieldNumber = 1;

		// Token: 0x04003A04 RID: 14852
		private ErrorCode code_;

		// Token: 0x04003A05 RID: 14853
		public const int ClientWaitingModeFieldNumber = 2;

		// Token: 0x04003A06 RID: 14854
		private int clientWaitingMode_;

		// Token: 0x04003A07 RID: 14855
		public const int ClientWaitingTimeFieldNumber = 3;

		// Token: 0x04003A08 RID: 14856
		private int clientWaitingTime_;

		// Token: 0x04003A09 RID: 14857
		public const int ClientAutoInIntervalFieldNumber = 4;

		// Token: 0x04003A0A RID: 14858
		private int clientAutoInInterval_;
	}
}
