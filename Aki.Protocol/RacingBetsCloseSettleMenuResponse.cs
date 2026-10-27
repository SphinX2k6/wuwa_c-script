using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4E RID: 3662
	[NetMessage(EMessageId.RacingBetsCloseSettleMenuResponse)]
	public sealed class RacingBetsCloseSettleMenuResponse : IMessage<RacingBetsCloseSettleMenuResponse>, IMessage, IEquatable<RacingBetsCloseSettleMenuResponse>, IDeepCloneable<RacingBetsCloseSettleMenuResponse>, IBufferMessage
	{
		// Token: 0x06013A98 RID: 80536 RVA: 0x002DBCB0 File Offset: 0x002D9EB0
		[NullableContext(1)]
		public static RacingBetsCloseSettleMenuResponse Create()
		{
			return new RacingBetsCloseSettleMenuResponse();
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x06013A99 RID: 80537 RVA: 0x002DBCB7 File Offset: 0x002D9EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x06013A9A RID: 80538 RVA: 0x002DBCBA File Offset: 0x002D9EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsCloseSettleMenuResponse.Descriptor;
			}
		}

		// Token: 0x06013A9B RID: 80539 RVA: 0x002DBCC1 File Offset: 0x002D9EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuResponse()
		{
		}

		// Token: 0x06013A9C RID: 80540 RVA: 0x002DBCC9 File Offset: 0x002D9EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuResponse(RacingBetsCloseSettleMenuResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A9D RID: 80541 RVA: 0x002DBCEE File Offset: 0x002D9EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsCloseSettleMenuResponse Clone()
		{
			return new RacingBetsCloseSettleMenuResponse(this);
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x06013A9E RID: 80542 RVA: 0x002DBCF6 File Offset: 0x002D9EF6
		// (set) Token: 0x06013A9F RID: 80543 RVA: 0x002DBCFE File Offset: 0x002D9EFE
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

		// Token: 0x06013AA0 RID: 80544 RVA: 0x002DBD07 File Offset: 0x002D9F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsCloseSettleMenuResponse);
		}

		// Token: 0x06013AA1 RID: 80545 RVA: 0x002DBD15 File Offset: 0x002D9F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsCloseSettleMenuResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AA2 RID: 80546 RVA: 0x002DBD44 File Offset: 0x002D9F44
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

		// Token: 0x06013AA3 RID: 80547 RVA: 0x002DBD89 File Offset: 0x002D9F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013AA4 RID: 80548 RVA: 0x002DBD96 File Offset: 0x002D9F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013AA5 RID: 80549 RVA: 0x002DBD9F File Offset: 0x002D9F9F
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

		// Token: 0x06013AA6 RID: 80550 RVA: 0x002DBDD4 File Offset: 0x002D9FD4
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

		// Token: 0x06013AA7 RID: 80551 RVA: 0x002DBE12 File Offset: 0x002DA012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsCloseSettleMenuResponse other)
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

		// Token: 0x06013AA8 RID: 80552 RVA: 0x002DBE43 File Offset: 0x002DA043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013AA9 RID: 80553 RVA: 0x002DBE4C File Offset: 0x002DA04C
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

		// Token: 0x04007855 RID: 30805
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007856 RID: 30806
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007857 RID: 30807
		private ErrorCode errorCode_;
	}
}
