using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102E RID: 4142
	[NetMessage(EMessageId.RogueWeeklyLastInfoResponse)]
	public sealed class RogueWeeklyLastInfoResponse : IMessage<RogueWeeklyLastInfoResponse>, IMessage, IEquatable<RogueWeeklyLastInfoResponse>, IDeepCloneable<RogueWeeklyLastInfoResponse>, IBufferMessage
	{
		// Token: 0x060162A1 RID: 90785 RVA: 0x00338F9D File Offset: 0x0033719D
		[NullableContext(1)]
		public static RogueWeeklyLastInfoResponse Create()
		{
			return new RogueWeeklyLastInfoResponse();
		}

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x060162A2 RID: 90786 RVA: 0x00338FA4 File Offset: 0x003371A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x060162A3 RID: 90787 RVA: 0x00338FA7 File Offset: 0x003371A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyLastInfoResponse.Descriptor;
			}
		}

		// Token: 0x060162A4 RID: 90788 RVA: 0x00338FAE File Offset: 0x003371AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoResponse()
		{
		}

		// Token: 0x060162A5 RID: 90789 RVA: 0x00338FB8 File Offset: 0x003371B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoResponse(RogueWeeklyLastInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueWeeklyLastInfo_ = ((other.rogueWeeklyLastInfo_ != null) ? other.rogueWeeklyLastInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162A6 RID: 90790 RVA: 0x00339004 File Offset: 0x00337204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfoResponse Clone()
		{
			return new RogueWeeklyLastInfoResponse(this);
		}

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x060162A7 RID: 90791 RVA: 0x0033900C File Offset: 0x0033720C
		// (set) Token: 0x060162A8 RID: 90792 RVA: 0x00339014 File Offset: 0x00337214
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

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x060162A9 RID: 90793 RVA: 0x0033901D File Offset: 0x0033721D
		// (set) Token: 0x060162AA RID: 90794 RVA: 0x00339025 File Offset: 0x00337225
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

		// Token: 0x060162AB RID: 90795 RVA: 0x0033902E File Offset: 0x0033722E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyLastInfoResponse);
		}

		// Token: 0x060162AC RID: 90796 RVA: 0x0033903C File Offset: 0x0033723C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyLastInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueWeeklyLastInfo, other.RogueWeeklyLastInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162AD RID: 90797 RVA: 0x0033908C File Offset: 0x0033728C
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

		// Token: 0x060162AE RID: 90798 RVA: 0x003390E7 File Offset: 0x003372E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162AF RID: 90799 RVA: 0x003390F4 File Offset: 0x003372F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162B0 RID: 90800 RVA: 0x00339100 File Offset: 0x00337300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rogueWeeklyLastInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueWeeklyLastInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060162B1 RID: 90801 RVA: 0x0033915C File Offset: 0x0033735C
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

		// Token: 0x060162B2 RID: 90802 RVA: 0x003391B4 File Offset: 0x003373B4
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

		// Token: 0x060162B3 RID: 90803 RVA: 0x0033921C File Offset: 0x0033741C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162B4 RID: 90804 RVA: 0x00339228 File Offset: 0x00337428
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008520 RID: 34080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008521 RID: 34081
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04008522 RID: 34082
		private ErrorCode errorCode_;

		// Token: 0x04008523 RID: 34083
		public const int RogueWeeklyLastInfoFieldNumber = 15;

		// Token: 0x04008524 RID: 34084
		private RogueWeeklyLastInfo rogueWeeklyLastInfo_;
	}
}
