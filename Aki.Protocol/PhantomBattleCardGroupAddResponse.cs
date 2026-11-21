using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C38 RID: 3128
	[NetMessage(EMessageId.PhantomBattleCardGroupAddResponse)]
	public sealed class PhantomBattleCardGroupAddResponse : IMessage<PhantomBattleCardGroupAddResponse>, IMessage, IEquatable<PhantomBattleCardGroupAddResponse>, IDeepCloneable<PhantomBattleCardGroupAddResponse>, IBufferMessage
	{
		// Token: 0x06010FD5 RID: 69589 RVA: 0x0027D796 File Offset: 0x0027B996
		[NullableContext(1)]
		public static PhantomBattleCardGroupAddResponse Create()
		{
			return new PhantomBattleCardGroupAddResponse();
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x06010FD6 RID: 69590 RVA: 0x0027D79D File Offset: 0x0027B99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x06010FD7 RID: 69591 RVA: 0x0027D7A0 File Offset: 0x0027B9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupAddResponse.Descriptor;
			}
		}

		// Token: 0x06010FD8 RID: 69592 RVA: 0x0027D7A7 File Offset: 0x0027B9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddResponse()
		{
		}

		// Token: 0x06010FD9 RID: 69593 RVA: 0x0027D7B0 File Offset: 0x0027B9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddResponse(PhantomBattleCardGroupAddResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = ((other.phantomBattleCardGroupInfo_ != null) ? other.phantomBattleCardGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FDA RID: 69594 RVA: 0x0027D7FC File Offset: 0x0027B9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddResponse Clone()
		{
			return new PhantomBattleCardGroupAddResponse(this);
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x06010FDB RID: 69595 RVA: 0x0027D804 File Offset: 0x0027BA04
		// (set) Token: 0x06010FDC RID: 69596 RVA: 0x0027D80C File Offset: 0x0027BA0C
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

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x06010FDD RID: 69597 RVA: 0x0027D815 File Offset: 0x0027BA15
		// (set) Token: 0x06010FDE RID: 69598 RVA: 0x0027D81D File Offset: 0x0027BA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo PhantomBattleCardGroupInfo
		{
			get
			{
				return this.phantomBattleCardGroupInfo_;
			}
			set
			{
				this.phantomBattleCardGroupInfo_ = value;
			}
		}

		// Token: 0x06010FDF RID: 69599 RVA: 0x0027D826 File Offset: 0x0027BA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupAddResponse);
		}

		// Token: 0x06010FE0 RID: 69600 RVA: 0x0027D834 File Offset: 0x0027BA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupAddResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleCardGroupInfo, other.PhantomBattleCardGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010FE1 RID: 69601 RVA: 0x0027D884 File Offset: 0x0027BA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num ^= this.PhantomBattleCardGroupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010FE2 RID: 69602 RVA: 0x0027D8DF File Offset: 0x0027BADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FE3 RID: 69603 RVA: 0x0027D8EC File Offset: 0x0027BAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FE4 RID: 69604 RVA: 0x0027D8F8 File Offset: 0x0027BAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PhantomBattleCardGroupInfo);
			}
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

		// Token: 0x06010FE5 RID: 69605 RVA: 0x0027D954 File Offset: 0x0027BB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010FE6 RID: 69606 RVA: 0x0027D9AC File Offset: 0x0027BBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupAddResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleCardGroupInfo_ != null)
			{
				if (this.phantomBattleCardGroupInfo_ == null)
				{
					this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
				}
				this.PhantomBattleCardGroupInfo.MergeFrom(other.PhantomBattleCardGroupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010FE7 RID: 69607 RVA: 0x0027DA14 File Offset: 0x0027BC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FE8 RID: 69608 RVA: 0x0027DA20 File Offset: 0x0027BC20
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
				if (num != 90U)
				{
					if (num != 112U)
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
					if (this.phantomBattleCardGroupInfo_ == null)
					{
						this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
					}
					input.ReadMessage(this.PhantomBattleCardGroupInfo);
				}
			}
		}

		// Token: 0x04006C27 RID: 27687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C28 RID: 27688
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006C29 RID: 27689
		private ErrorCode errorCode_;

		// Token: 0x04006C2A RID: 27690
		public const int PhantomBattleCardGroupInfoFieldNumber = 11;

		// Token: 0x04006C2B RID: 27691
		private PhantomBattleCardGroupInfo phantomBattleCardGroupInfo_;
	}
}
