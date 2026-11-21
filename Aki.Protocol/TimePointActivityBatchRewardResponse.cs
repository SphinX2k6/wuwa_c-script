using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013ED RID: 5101
	[NetMessage(EMessageId.TimePointActivityBatchRewardResponse)]
	public sealed class TimePointActivityBatchRewardResponse : IMessage<TimePointActivityBatchRewardResponse>, IMessage, IEquatable<TimePointActivityBatchRewardResponse>, IDeepCloneable<TimePointActivityBatchRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B218 RID: 111128 RVA: 0x003F2E64 File Offset: 0x003F1064
		[NullableContext(1)]
		public static TimePointActivityBatchRewardResponse Create()
		{
			return new TimePointActivityBatchRewardResponse();
		}

		// Token: 0x17005BDE RID: 23518
		// (get) Token: 0x0601B219 RID: 111129 RVA: 0x003F2E6B File Offset: 0x003F106B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BDF RID: 23519
		// (get) Token: 0x0601B21A RID: 111130 RVA: 0x003F2E6E File Offset: 0x003F106E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityBatchRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B21B RID: 111131 RVA: 0x003F2E75 File Offset: 0x003F1075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardResponse()
		{
		}

		// Token: 0x0601B21C RID: 111132 RVA: 0x003F2E7D File Offset: 0x003F107D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardResponse(TimePointActivityBatchRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B21D RID: 111133 RVA: 0x003F2EA2 File Offset: 0x003F10A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardResponse Clone()
		{
			return new TimePointActivityBatchRewardResponse(this);
		}

		// Token: 0x17005BE0 RID: 23520
		// (get) Token: 0x0601B21E RID: 111134 RVA: 0x003F2EAA File Offset: 0x003F10AA
		// (set) Token: 0x0601B21F RID: 111135 RVA: 0x003F2EB2 File Offset: 0x003F10B2
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

		// Token: 0x0601B220 RID: 111136 RVA: 0x003F2EBB File Offset: 0x003F10BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityBatchRewardResponse);
		}

		// Token: 0x0601B221 RID: 111137 RVA: 0x003F2EC9 File Offset: 0x003F10C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityBatchRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B222 RID: 111138 RVA: 0x003F2EF8 File Offset: 0x003F10F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B223 RID: 111139 RVA: 0x003F2F3D File Offset: 0x003F113D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B224 RID: 111140 RVA: 0x003F2F4A File Offset: 0x003F114A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B225 RID: 111141 RVA: 0x003F2F53 File Offset: 0x003F1153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B226 RID: 111142 RVA: 0x003F2F88 File Offset: 0x003F1188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B227 RID: 111143 RVA: 0x003F2FC6 File Offset: 0x003F11C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityBatchRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B228 RID: 111144 RVA: 0x003F2FF7 File Offset: 0x003F11F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B229 RID: 111145 RVA: 0x003F3000 File Offset: 0x003F1200
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E5A RID: 40538
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E5B RID: 40539
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009E5C RID: 40540
		private ErrorCode errorCode_;
	}
}
