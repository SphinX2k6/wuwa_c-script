using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103E RID: 4158
	[NetMessage(EMessageId.RogueWeeklyLastInfoResponse)]
	public sealed class RogueWeeklyLastInfoResponse : IMessage<RogueWeeklyLastInfoResponse>, IMessage, IEquatable<RogueWeeklyLastInfoResponse>, IDeepCloneable<RogueWeeklyLastInfoResponse>, IBufferMessage
	{
		// Token: 0x06016386 RID: 91014 RVA: 0x0033A66D File Offset: 0x0033886D
		[NullableContext(1)]
		public static RogueWeeklyLastInfoResponse Create()
		{
			return new RogueWeeklyLastInfoResponse();
		}

		// Token: 0x17004A49 RID: 19017
		// (get) Token: 0x06016387 RID: 91015 RVA: 0x0033A674 File Offset: 0x00338874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A4A RID: 19018
		// (get) Token: 0x06016388 RID: 91016 RVA: 0x0033A677 File Offset: 0x00338877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyLastInfoResponse.Descriptor;
			}
		}

		// Token: 0x06016389 RID: 91017 RVA: 0x0033A67E File Offset: 0x0033887E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoResponse()
		{
		}

		// Token: 0x0601638A RID: 91018 RVA: 0x0033A688 File Offset: 0x00338888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoResponse(RogueWeeklyLastInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueWeeklyLastInfo_ = ((other.rogueWeeklyLastInfo_ != null) ? other.rogueWeeklyLastInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601638B RID: 91019 RVA: 0x0033A6D4 File Offset: 0x003388D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoResponse Clone()
		{
			return new RogueWeeklyLastInfoResponse(this);
		}

		// Token: 0x17004A4B RID: 19019
		// (get) Token: 0x0601638C RID: 91020 RVA: 0x0033A6DC File Offset: 0x003388DC
		// (set) Token: 0x0601638D RID: 91021 RVA: 0x0033A6E4 File Offset: 0x003388E4
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

		// Token: 0x17004A4C RID: 19020
		// (get) Token: 0x0601638E RID: 91022 RVA: 0x0033A6ED File Offset: 0x003388ED
		// (set) Token: 0x0601638F RID: 91023 RVA: 0x0033A6F5 File Offset: 0x003388F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfo RogueWeeklyLastInfo
		{
			get
			{
				return this.rogueWeeklyLastInfo_;
			}
			set
			{
				this.rogueWeeklyLastInfo_ = value;
			}
		}

		// Token: 0x06016390 RID: 91024 RVA: 0x0033A6FE File Offset: 0x003388FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyLastInfoResponse);
		}

		// Token: 0x06016391 RID: 91025 RVA: 0x0033A70C File Offset: 0x0033890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyLastInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueWeeklyLastInfo, other.RogueWeeklyLastInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016392 RID: 91026 RVA: 0x0033A75C File Offset: 0x0033895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rogueWeeklyLastInfo_ != null)
			{
				num ^= this.RogueWeeklyLastInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016393 RID: 91027 RVA: 0x0033A7B7 File Offset: 0x003389B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016394 RID: 91028 RVA: 0x0033A7C4 File Offset: 0x003389C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016395 RID: 91029 RVA: 0x0033A7D0 File Offset: 0x003389D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueWeeklyLastInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RogueWeeklyLastInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016396 RID: 91030 RVA: 0x0033A82C File Offset: 0x00338A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rogueWeeklyLastInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueWeeklyLastInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016397 RID: 91031 RVA: 0x0033A884 File Offset: 0x00338A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyLastInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rogueWeeklyLastInfo_ != null)
			{
				if (this.rogueWeeklyLastInfo_ == null)
				{
					this.RogueWeeklyLastInfo = new RogueWeeklyLastInfo();
				}
				this.RogueWeeklyLastInfo.MergeFrom(other.RogueWeeklyLastInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016398 RID: 91032 RVA: 0x0033A8EC File Offset: 0x00338AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016399 RID: 91033 RVA: 0x0033A8F8 File Offset: 0x00338AF8
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
				if (num != 42U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.rogueWeeklyLastInfo_ == null)
					{
						this.RogueWeeklyLastInfo = new RogueWeeklyLastInfo();
					}
					input.ReadMessage(this.RogueWeeklyLastInfo);
				}
			}
		}

		// Token: 0x040084F6 RID: 34038
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084F7 RID: 34039
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040084F8 RID: 34040
		private ErrorCode errorCode_;

		// Token: 0x040084F9 RID: 34041
		public const int RogueWeeklyLastInfoFieldNumber = 5;

		// Token: 0x040084FA RID: 34042
		private RogueWeeklyLastInfo rogueWeeklyLastInfo_;
	}
}
