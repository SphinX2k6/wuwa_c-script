using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014C RID: 332
	[NetMessage(EMessageId.BabelTowerDailyTaskRewardResponse)]
	public sealed class BabelTowerDailyTaskRewardResponse : IMessage<BabelTowerDailyTaskRewardResponse>, IMessage, IEquatable<BabelTowerDailyTaskRewardResponse>, IDeepCloneable<BabelTowerDailyTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06002A85 RID: 10885 RVA: 0x0006F795 File Offset: 0x0006D995
		[NullableContext(1)]
		public static BabelTowerDailyTaskRewardResponse Create()
		{
			return new BabelTowerDailyTaskRewardResponse();
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x0006F79C File Offset: 0x0006D99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x0006F79F File Offset: 0x0006D99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerDailyTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x0006F7A6 File Offset: 0x0006D9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardResponse()
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x0006F7AE File Offset: 0x0006D9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardResponse(BabelTowerDailyTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x0006F7D3 File Offset: 0x0006D9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerDailyTaskRewardResponse Clone()
		{
			return new BabelTowerDailyTaskRewardResponse(this);
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x0006F7DB File Offset: 0x0006D9DB
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x0006F7E3 File Offset: 0x0006D9E3
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

		// Token: 0x06002A8D RID: 10893 RVA: 0x0006F7EC File Offset: 0x0006D9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerDailyTaskRewardResponse);
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x0006F7FA File Offset: 0x0006D9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerDailyTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0006F828 File Offset: 0x0006DA28
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

		// Token: 0x06002A90 RID: 10896 RVA: 0x0006F86D File Offset: 0x0006DA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0006F87A File Offset: 0x0006DA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0006F883 File Offset: 0x0006DA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0006F8B8 File Offset: 0x0006DAB8
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

		// Token: 0x06002A94 RID: 10900 RVA: 0x0006F8F6 File Offset: 0x0006DAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerDailyTaskRewardResponse other)
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

		// Token: 0x06002A95 RID: 10901 RVA: 0x0006F927 File Offset: 0x0006DB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x0006F930 File Offset: 0x0006DB30
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400276B RID: 10091
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400276C RID: 10092
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400276D RID: 10093
		private ErrorCode errorCode_;
	}
}
