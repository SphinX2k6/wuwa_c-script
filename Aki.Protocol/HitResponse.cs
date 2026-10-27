using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000756 RID: 1878
	[NetMessage(EMessageId.HitResponse)]
	public sealed class HitResponse : IMessage<HitResponse>, IMessage, IEquatable<HitResponse>, IDeepCloneable<HitResponse>, IBufferMessage
	{
		// Token: 0x0600AA0C RID: 43532 RVA: 0x001992B8 File Offset: 0x001974B8
		[NullableContext(1)]
		public static HitResponse Create()
		{
			return new HitResponse();
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x0600AA0D RID: 43533 RVA: 0x001992BF File Offset: 0x001974BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x0600AA0E RID: 43534 RVA: 0x001992C2 File Offset: 0x001974C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitResponse.Descriptor;
			}
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x001992C9 File Offset: 0x001974C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitResponse()
		{
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x001992D4 File Offset: 0x001974D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitResponse(HitResponse other) : this()
		{
			this.hitInfo_ = ((other.hitInfo_ != null) ? other.hitInfo_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x00199320 File Offset: 0x00197520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitResponse Clone()
		{
			return new HitResponse(this);
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x0600AA12 RID: 43538 RVA: 0x00199328 File Offset: 0x00197528
		// (set) Token: 0x0600AA13 RID: 43539 RVA: 0x00199330 File Offset: 0x00197530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitInformation HitInfo
		{
			get
			{
				return this.hitInfo_;
			}
			set
			{
				this.hitInfo_ = value;
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x0600AA14 RID: 43540 RVA: 0x00199339 File Offset: 0x00197539
		// (set) Token: 0x0600AA15 RID: 43541 RVA: 0x00199341 File Offset: 0x00197541
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

		// Token: 0x0600AA16 RID: 43542 RVA: 0x0019934A File Offset: 0x0019754A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitResponse);
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x00199358 File Offset: 0x00197558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitResponse other)
		{
			return other != null && (other == this || (object.Equals(this.HitInfo, other.HitInfo) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x001993A8 File Offset: 0x001975A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hitInfo_ != null)
			{
				num ^= this.HitInfo.GetHashCode();
			}
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

		// Token: 0x0600AA19 RID: 43545 RVA: 0x00199403 File Offset: 0x00197603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x00199410 File Offset: 0x00197610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x0019941C File Offset: 0x0019761C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hitInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HitInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x00199478 File Offset: 0x00197678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hitInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitInfo);
			}
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

		// Token: 0x0600AA1D RID: 43549 RVA: 0x001994D0 File Offset: 0x001976D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hitInfo_ != null)
			{
				if (this.hitInfo_ == null)
				{
					this.HitInfo = new HitInformation();
				}
				this.HitInfo.MergeFrom(other.HitInfo);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x00199538 File Offset: 0x00197738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x00199544 File Offset: 0x00197744
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
					if (num != 24U)
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
					if (this.hitInfo_ == null)
					{
						this.HitInfo = new HitInformation();
					}
					input.ReadMessage(this.HitInfo);
				}
			}
		}

		// Token: 0x04004D5A RID: 19802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D5B RID: 19803
		public const int HitInfoFieldNumber = 2;

		// Token: 0x04004D5C RID: 19804
		private HitInformation hitInfo_;

		// Token: 0x04004D5D RID: 19805
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004D5E RID: 19806
		private ErrorCode errorCode_;
	}
}
