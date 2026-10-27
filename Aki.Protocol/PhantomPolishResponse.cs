using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF1 RID: 3313
	[NetMessage(EMessageId.PhantomPolishResponse)]
	public sealed class PhantomPolishResponse : IMessage<PhantomPolishResponse>, IMessage, IEquatable<PhantomPolishResponse>, IDeepCloneable<PhantomPolishResponse>, IBufferMessage
	{
		// Token: 0x06011EA4 RID: 73380 RVA: 0x0029EA3C File Offset: 0x0029CC3C
		[NullableContext(1)]
		public static PhantomPolishResponse Create()
		{
			return new PhantomPolishResponse();
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x06011EA5 RID: 73381 RVA: 0x0029EA43 File Offset: 0x0029CC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x06011EA6 RID: 73382 RVA: 0x0029EA46 File Offset: 0x0029CC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPolishResponse.Descriptor;
			}
		}

		// Token: 0x06011EA7 RID: 73383 RVA: 0x0029EA4D File Offset: 0x0029CC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishResponse()
		{
		}

		// Token: 0x06011EA8 RID: 73384 RVA: 0x0029EA58 File Offset: 0x0029CC58
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

		// Token: 0x06011EA9 RID: 73385 RVA: 0x0029EADC File Offset: 0x0029CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPolishResponse Clone()
		{
			return new PhantomPolishResponse(this);
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x06011EAA RID: 73386 RVA: 0x0029EAE4 File Offset: 0x0029CCE4
		// (set) Token: 0x06011EAB RID: 73387 RVA: 0x0029EAEC File Offset: 0x0029CCEC
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

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x06011EAC RID: 73388 RVA: 0x0029EAF5 File Offset: 0x0029CCF5
		// (set) Token: 0x06011EAD RID: 73389 RVA: 0x0029EAFD File Offset: 0x0029CCFD
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

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x06011EAE RID: 73390 RVA: 0x0029EB06 File Offset: 0x0029CD06
		// (set) Token: 0x06011EAF RID: 73391 RVA: 0x0029EB0E File Offset: 0x0029CD0E
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

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x06011EB0 RID: 73392 RVA: 0x0029EB17 File Offset: 0x0029CD17
		// (set) Token: 0x06011EB1 RID: 73393 RVA: 0x0029EB1F File Offset: 0x0029CD1F
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

		// Token: 0x06011EB2 RID: 73394 RVA: 0x0029EB28 File Offset: 0x0029CD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPolishResponse);
		}

		// Token: 0x06011EB3 RID: 73395 RVA: 0x0029EB38 File Offset: 0x0029CD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPolishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.UpdateInfo, other.UpdateInfo) && object.Equals(this.StackSplitInfo, other.StackSplitInfo) && object.Equals(this.StackMergeInfos, other.StackMergeInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EB4 RID: 73396 RVA: 0x0029EBB0 File Offset: 0x0029CDB0
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

		// Token: 0x06011EB5 RID: 73397 RVA: 0x0029EC37 File Offset: 0x0029CE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011EB6 RID: 73398 RVA: 0x0029EC44 File Offset: 0x0029CE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011EB7 RID: 73399 RVA: 0x0029EC50 File Offset: 0x0029CE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.stackSplitInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.StackSplitInfo);
			}
			if (this.stackMergeInfos_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.StackMergeInfos);
			}
			if (this.updateInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.UpdateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011EB8 RID: 73400 RVA: 0x0029ECE4 File Offset: 0x0029CEE4
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

		// Token: 0x06011EB9 RID: 73401 RVA: 0x0029ED6C File Offset: 0x0029CF6C
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

		// Token: 0x06011EBA RID: 73402 RVA: 0x0029EE2C File Offset: 0x0029D02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EBB RID: 73403 RVA: 0x0029EE38 File Offset: 0x0029D038
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
				if (num <= 58U)
				{
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						if (this.stackSplitInfo_ == null)
						{
							this.StackSplitInfo = new PhantomStackSplitInfo();
						}
						input.ReadMessage(this.StackSplitInfo);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.stackMergeInfos_ == null)
						{
							this.StackMergeInfos = new PhantomStackMergeInfo();
						}
						input.ReadMessage(this.StackMergeInfos);
						continue;
					}
					if (num == 114U)
					{
						if (this.updateInfo_ == null)
						{
							this.UpdateInfo = new PhantomItem();
						}
						input.ReadMessage(this.UpdateInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007057 RID: 28759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007058 RID: 28760
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007059 RID: 28761
		private ErrorCode errorCode_;

		// Token: 0x0400705A RID: 28762
		public const int UpdateInfoFieldNumber = 14;

		// Token: 0x0400705B RID: 28763
		private PhantomItem updateInfo_;

		// Token: 0x0400705C RID: 28764
		public const int StackSplitInfoFieldNumber = 7;

		// Token: 0x0400705D RID: 28765
		private PhantomStackSplitInfo stackSplitInfo_;

		// Token: 0x0400705E RID: 28766
		public const int StackMergeInfosFieldNumber = 10;

		// Token: 0x0400705F RID: 28767
		private PhantomStackMergeInfo stackMergeInfos_;
	}
}
