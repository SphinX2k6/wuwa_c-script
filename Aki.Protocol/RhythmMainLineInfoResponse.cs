using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3C RID: 3900
	[NetMessage(EMessageId.RhythmMainLineInfoResponse)]
	public sealed class RhythmMainLineInfoResponse : IMessage<RhythmMainLineInfoResponse>, IMessage, IEquatable<RhythmMainLineInfoResponse>, IDeepCloneable<RhythmMainLineInfoResponse>, IBufferMessage
	{
		// Token: 0x06014DDC RID: 85468 RVA: 0x00306DEA File Offset: 0x00304FEA
		[NullableContext(1)]
		public static RhythmMainLineInfoResponse Create()
		{
			return new RhythmMainLineInfoResponse();
		}

		// Token: 0x1700455F RID: 17759
		// (get) Token: 0x06014DDD RID: 85469 RVA: 0x00306DF1 File Offset: 0x00304FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004560 RID: 17760
		// (get) Token: 0x06014DDE RID: 85470 RVA: 0x00306DF4 File Offset: 0x00304FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmMainLineInfoResponse.Descriptor;
			}
		}

		// Token: 0x06014DDF RID: 85471 RVA: 0x00306DFB File Offset: 0x00304FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoResponse()
		{
		}

		// Token: 0x06014DE0 RID: 85472 RVA: 0x00306E04 File Offset: 0x00305004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoResponse(RhythmMainLineInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rhythmMainLinePb_ = ((other.rhythmMainLinePb_ != null) ? other.rhythmMainLinePb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DE1 RID: 85473 RVA: 0x00306E50 File Offset: 0x00305050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoResponse Clone()
		{
			return new RhythmMainLineInfoResponse(this);
		}

		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x06014DE2 RID: 85474 RVA: 0x00306E58 File Offset: 0x00305058
		// (set) Token: 0x06014DE3 RID: 85475 RVA: 0x00306E60 File Offset: 0x00305060
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

		// Token: 0x17004562 RID: 17762
		// (get) Token: 0x06014DE4 RID: 85476 RVA: 0x00306E69 File Offset: 0x00305069
		// (set) Token: 0x06014DE5 RID: 85477 RVA: 0x00306E71 File Offset: 0x00305071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmActivityPb RhythmMainLinePb
		{
			get
			{
				return this.rhythmMainLinePb_;
			}
			set
			{
				this.rhythmMainLinePb_ = value;
			}
		}

		// Token: 0x06014DE6 RID: 85478 RVA: 0x00306E7A File Offset: 0x0030507A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmMainLineInfoResponse);
		}

		// Token: 0x06014DE7 RID: 85479 RVA: 0x00306E88 File Offset: 0x00305088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmMainLineInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RhythmMainLinePb, other.RhythmMainLinePb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DE8 RID: 85480 RVA: 0x00306ED8 File Offset: 0x003050D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rhythmMainLinePb_ != null)
			{
				num ^= this.RhythmMainLinePb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014DE9 RID: 85481 RVA: 0x00306F33 File Offset: 0x00305133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DEA RID: 85482 RVA: 0x00306F40 File Offset: 0x00305140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DEB RID: 85483 RVA: 0x00306F4C File Offset: 0x0030514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rhythmMainLinePb_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RhythmMainLinePb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DEC RID: 85484 RVA: 0x00306FA8 File Offset: 0x003051A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rhythmMainLinePb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RhythmMainLinePb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014DED RID: 85485 RVA: 0x00307000 File Offset: 0x00305200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmMainLineInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rhythmMainLinePb_ != null)
			{
				if (this.rhythmMainLinePb_ == null)
				{
					this.RhythmMainLinePb = new RhythmActivityPb();
				}
				this.RhythmMainLinePb.MergeFrom(other.RhythmMainLinePb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DEE RID: 85486 RVA: 0x00307068 File Offset: 0x00305268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DEF RID: 85487 RVA: 0x00307074 File Offset: 0x00305274
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rhythmMainLinePb_ == null)
						{
							this.RhythmMainLinePb = new RhythmActivityPb();
						}
						input.ReadMessage(this.RhythmMainLinePb);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007DDD RID: 32221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DDE RID: 32222
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007DDF RID: 32223
		private ErrorCode errorCode_;

		// Token: 0x04007DE0 RID: 32224
		public const int RhythmMainLinePbFieldNumber = 15;

		// Token: 0x04007DE1 RID: 32225
		private RhythmActivityPb rhythmMainLinePb_;
	}
}
