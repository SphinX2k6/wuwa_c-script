using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE1 RID: 3297
	[NetMessage(EMessageId.PhantomPolishResponse)]
	public sealed class PhantomPolishResponse : IMessage<PhantomPolishResponse>, IMessage, IEquatable<PhantomPolishResponse>, IDeepCloneable<PhantomPolishResponse>, IBufferMessage
	{
		// Token: 0x06011DA8 RID: 73128 RVA: 0x0029CE24 File Offset: 0x0029B024
		[NullableContext(1)]
		public static PhantomPolishResponse Create()
		{
			return new PhantomPolishResponse();
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x06011DA9 RID: 73129 RVA: 0x0029CE2B File Offset: 0x0029B02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x06011DAA RID: 73130 RVA: 0x0029CE2E File Offset: 0x0029B02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPolishResponse.Descriptor;
			}
		}

		// Token: 0x06011DAB RID: 73131 RVA: 0x0029CE35 File Offset: 0x0029B035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishResponse()
		{
		}

		// Token: 0x06011DAC RID: 73132 RVA: 0x0029CE40 File Offset: 0x0029B040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishResponse(PhantomPolishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.updateInfo_ = ((other.updateInfo_ != null) ? other.updateInfo_.Clone() : null);
			this.stackSplitInfo_ = ((other.stackSplitInfo_ != null) ? other.stackSplitInfo_.Clone() : null);
			this.stackMergeInfos_ = ((other.stackMergeInfos_ != null) ? other.stackMergeInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011DAD RID: 73133 RVA: 0x0029CEC4 File Offset: 0x0029B0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishResponse Clone()
		{
			return new PhantomPolishResponse(this);
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x06011DAE RID: 73134 RVA: 0x0029CECC File Offset: 0x0029B0CC
		// (set) Token: 0x06011DAF RID: 73135 RVA: 0x0029CED4 File Offset: 0x0029B0D4
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

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x06011DB0 RID: 73136 RVA: 0x0029CEDD File Offset: 0x0029B0DD
		// (set) Token: 0x06011DB1 RID: 73137 RVA: 0x0029CEE5 File Offset: 0x0029B0E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem UpdateInfo
		{
			get
			{
				return this.updateInfo_;
			}
			set
			{
				this.updateInfo_ = value;
			}
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x06011DB2 RID: 73138 RVA: 0x0029CEEE File Offset: 0x0029B0EE
		// (set) Token: 0x06011DB3 RID: 73139 RVA: 0x0029CEF6 File Offset: 0x0029B0F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo StackSplitInfo
		{
			get
			{
				return this.stackSplitInfo_;
			}
			set
			{
				this.stackSplitInfo_ = value;
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x06011DB4 RID: 73140 RVA: 0x0029CEFF File Offset: 0x0029B0FF
		// (set) Token: 0x06011DB5 RID: 73141 RVA: 0x0029CF07 File Offset: 0x0029B107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackMergeInfo StackMergeInfos
		{
			get
			{
				return this.stackMergeInfos_;
			}
			set
			{
				this.stackMergeInfos_ = value;
			}
		}

		// Token: 0x06011DB6 RID: 73142 RVA: 0x0029CF10 File Offset: 0x0029B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPolishResponse);
		}

		// Token: 0x06011DB7 RID: 73143 RVA: 0x0029CF20 File Offset: 0x0029B120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPolishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && object.Equals(this.StackSplitInfo, other.StackSplitInfo) && object.Equals(this.StackMergeInfos, other.StackMergeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DB8 RID: 73144 RVA: 0x0029CF98 File Offset: 0x0029B198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.updateInfo_ != null)
			{
				num ^= this.UpdateInfo.GetHashCode();
			}
			if (this.stackSplitInfo_ != null)
			{
				num ^= this.StackSplitInfo.GetHashCode();
			}
			if (this.stackMergeInfos_ != null)
			{
				num ^= this.StackMergeInfos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011DB9 RID: 73145 RVA: 0x0029D01F File Offset: 0x0029B21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DBA RID: 73146 RVA: 0x0029D02C File Offset: 0x0029B22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DBB RID: 73147 RVA: 0x0029D038 File Offset: 0x0029B238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stackSplitInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.StackSplitInfo);
			}
			if (this.stackMergeInfos_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.StackMergeInfos);
			}
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DBC RID: 73148 RVA: 0x0029D0CC File Offset: 0x0029B2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.updateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateInfo);
			}
			if (this.stackSplitInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StackSplitInfo);
			}
			if (this.stackMergeInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StackMergeInfos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011DBD RID: 73149 RVA: 0x0029D154 File Offset: 0x0029B354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPolishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.updateInfo_ != null)
			{
				if (this.updateInfo_ == null)
				{
					this.UpdateInfo = new PhantomItem();
				}
				this.UpdateInfo.MergeFrom(other.UpdateInfo);
			}
			if (other.stackSplitInfo_ != null)
			{
				if (this.stackSplitInfo_ == null)
				{
					this.StackSplitInfo = new PhantomStackSplitInfo();
				}
				this.StackSplitInfo.MergeFrom(other.StackSplitInfo);
			}
			if (other.stackMergeInfos_ != null)
			{
				if (this.stackMergeInfos_ == null)
				{
					this.StackMergeInfos = new PhantomStackMergeInfo();
				}
				this.StackMergeInfos.MergeFrom(other.StackMergeInfos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011DBE RID: 73150 RVA: 0x0029D214 File Offset: 0x0029B414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DBF RID: 73151 RVA: 0x0029D220 File Offset: 0x0029B420
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
				if (num <= 42U)
				{
					if (num == 18U)
					{
						if (this.stackSplitInfo_ == null)
						{
							this.StackSplitInfo = new PhantomStackSplitInfo();
						}
						input.ReadMessage(this.StackSplitInfo);
						continue;
					}
					if (num == 42U)
					{
						if (this.stackMergeInfos_ == null)
						{
							this.StackMergeInfos = new PhantomStackMergeInfo();
						}
						input.ReadMessage(this.StackMergeInfos);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.updateInfo_ == null)
						{
							this.UpdateInfo = new PhantomItem();
						}
						input.ReadMessage(this.UpdateInfo);
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400706F RID: 28783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007070 RID: 28784
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007071 RID: 28785
		private ErrorCode errorCode_;

		// Token: 0x04007072 RID: 28786
		public const int UpdateInfoFieldNumber = 8;

		// Token: 0x04007073 RID: 28787
		private PhantomItem updateInfo_;

		// Token: 0x04007074 RID: 28788
		public const int StackSplitInfoFieldNumber = 2;

		// Token: 0x04007075 RID: 28789
		private PhantomStackSplitInfo stackSplitInfo_;

		// Token: 0x04007076 RID: 28790
		public const int StackMergeInfosFieldNumber = 5;

		// Token: 0x04007077 RID: 28791
		private PhantomStackMergeInfo stackMergeInfos_;
	}
}
