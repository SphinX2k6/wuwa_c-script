using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F37 RID: 3895
	[NetMessage(EMessageId.RhythmSetRedDotResponse)]
	public sealed class RhythmSetRedDotResponse : IMessage<RhythmSetRedDotResponse>, IMessage, IEquatable<RhythmSetRedDotResponse>, IDeepCloneable<RhythmSetRedDotResponse>, IBufferMessage
	{
		// Token: 0x06014DE6 RID: 85478 RVA: 0x00307BC3 File Offset: 0x00305DC3
		[NullableContext(1)]
		public static RhythmSetRedDotResponse Create()
		{
			return new RhythmSetRedDotResponse();
		}

		// Token: 0x1700456C RID: 17772
		// (get) Token: 0x06014DE7 RID: 85479 RVA: 0x00307BCA File Offset: 0x00305DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700456D RID: 17773
		// (get) Token: 0x06014DE8 RID: 85480 RVA: 0x00307BCD File Offset: 0x00305DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSetRedDotResponse.Descriptor;
			}
		}

		// Token: 0x06014DE9 RID: 85481 RVA: 0x00307BD4 File Offset: 0x00305DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotResponse()
		{
		}

		// Token: 0x06014DEA RID: 85482 RVA: 0x00307BDC File Offset: 0x00305DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotResponse(RhythmSetRedDotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.redDot_ = ((other.redDot_ != null) ? other.redDot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DEB RID: 85483 RVA: 0x00307C28 File Offset: 0x00305E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSetRedDotResponse Clone()
		{
			return new RhythmSetRedDotResponse(this);
		}

		// Token: 0x1700456E RID: 17774
		// (get) Token: 0x06014DEC RID: 85484 RVA: 0x00307C30 File Offset: 0x00305E30
		// (set) Token: 0x06014DED RID: 85485 RVA: 0x00307C38 File Offset: 0x00305E38
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

		// Token: 0x1700456F RID: 17775
		// (get) Token: 0x06014DEE RID: 85486 RVA: 0x00307C41 File Offset: 0x00305E41
		// (set) Token: 0x06014DEF RID: 85487 RVA: 0x00307C49 File Offset: 0x00305E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb RedDot
		{
			get
			{
				return this.redDot_;
			}
			set
			{
				this.redDot_ = value;
			}
		}

		// Token: 0x06014DF0 RID: 85488 RVA: 0x00307C52 File Offset: 0x00305E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSetRedDotResponse);
		}

		// Token: 0x06014DF1 RID: 85489 RVA: 0x00307C60 File Offset: 0x00305E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSetRedDotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RedDot, other.RedDot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DF2 RID: 85490 RVA: 0x00307CB0 File Offset: 0x00305EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.redDot_ != null)
			{
				num ^= this.RedDot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014DF3 RID: 85491 RVA: 0x00307D0B File Offset: 0x00305F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DF4 RID: 85492 RVA: 0x00307D18 File Offset: 0x00305F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DF5 RID: 85493 RVA: 0x00307D24 File Offset: 0x00305F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.redDot_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RedDot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DF6 RID: 85494 RVA: 0x00307D80 File Offset: 0x00305F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.redDot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RedDot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014DF7 RID: 85495 RVA: 0x00307DD8 File Offset: 0x00305FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSetRedDotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.redDot_ != null)
			{
				if (this.redDot_ == null)
				{
					this.RedDot = new RhythmRedDotPb();
				}
				this.RedDot.MergeFrom(other.RedDot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DF8 RID: 85496 RVA: 0x00307E40 File Offset: 0x00306040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DF9 RID: 85497 RVA: 0x00307E4C File Offset: 0x0030604C
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
				if (num != 32U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.redDot_ == null)
						{
							this.RedDot = new RhythmRedDotPb();
						}
						input.ReadMessage(this.RedDot);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E59 RID: 32345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E5A RID: 32346
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007E5B RID: 32347
		private ErrorCode errorCode_;

		// Token: 0x04007E5C RID: 32348
		public const int RedDotFieldNumber = 12;

		// Token: 0x04007E5D RID: 32349
		private RhythmRedDotPb redDot_;
	}
}
