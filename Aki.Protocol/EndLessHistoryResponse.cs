using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000440 RID: 1088
	[NetMessage(EMessageId.EndLessHistoryResponse)]
	public sealed class EndLessHistoryResponse : IMessage<EndLessHistoryResponse>, IMessage, IEquatable<EndLessHistoryResponse>, IDeepCloneable<EndLessHistoryResponse>, IBufferMessage
	{
		// Token: 0x0600681F RID: 26655 RVA: 0x000F9DCE File Offset: 0x000F7FCE
		[NullableContext(1)]
		public static EndLessHistoryResponse Create()
		{
			return new EndLessHistoryResponse();
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x000F9DD5 File Offset: 0x000F7FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x000F9DD8 File Offset: 0x000F7FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndLessHistoryResponse.Descriptor;
			}
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x000F9DDF File Offset: 0x000F7FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryResponse()
		{
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x000F9DE8 File Offset: 0x000F7FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryResponse(EndLessHistoryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.nowSeasonRecord_ = ((other.nowSeasonRecord_ != null) ? other.nowSeasonRecord_.Clone() : null);
			this.historyRecord_ = ((other.historyRecord_ != null) ? other.historyRecord_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x000F9E50 File Offset: 0x000F8050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryResponse Clone()
		{
			return new EndLessHistoryResponse(this);
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06006825 RID: 26661 RVA: 0x000F9E58 File Offset: 0x000F8058
		// (set) Token: 0x06006826 RID: 26662 RVA: 0x000F9E60 File Offset: 0x000F8060
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

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x000F9E69 File Offset: 0x000F8069
		// (set) Token: 0x06006828 RID: 26664 RVA: 0x000F9E71 File Offset: 0x000F8071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndlessBattleRecord NowSeasonRecord
		{
			get
			{
				return this.nowSeasonRecord_;
			}
			set
			{
				this.nowSeasonRecord_ = value;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x000F9E7A File Offset: 0x000F807A
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x000F9E82 File Offset: 0x000F8082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndlessBattleRecord HistoryRecord
		{
			get
			{
				return this.historyRecord_;
			}
			set
			{
				this.historyRecord_ = value;
			}
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x000F9E8B File Offset: 0x000F808B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndLessHistoryResponse);
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x000F9E9C File Offset: 0x000F809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndLessHistoryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NowSeasonRecord, other.NowSeasonRecord) && object.Equals(this.HistoryRecord, other.HistoryRecord) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x000F9F00 File Offset: 0x000F8100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.nowSeasonRecord_ != null)
			{
				num ^= this.NowSeasonRecord.GetHashCode();
			}
			if (this.historyRecord_ != null)
			{
				num ^= this.HistoryRecord.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x000F9F71 File Offset: 0x000F8171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x000F9F7E File Offset: 0x000F817E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x000F9F88 File Offset: 0x000F8188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nowSeasonRecord_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NowSeasonRecord);
			}
			if (this.historyRecord_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.HistoryRecord);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x000FA000 File Offset: 0x000F8200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.nowSeasonRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NowSeasonRecord);
			}
			if (this.historyRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HistoryRecord);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x000FA070 File Offset: 0x000F8270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndLessHistoryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.nowSeasonRecord_ != null)
			{
				if (this.nowSeasonRecord_ == null)
				{
					this.NowSeasonRecord = new EndlessBattleRecord();
				}
				this.NowSeasonRecord.MergeFrom(other.NowSeasonRecord);
			}
			if (other.historyRecord_ != null)
			{
				if (this.historyRecord_ == null)
				{
					this.HistoryRecord = new EndlessBattleRecord();
				}
				this.HistoryRecord.MergeFrom(other.HistoryRecord);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x000FA104 File Offset: 0x000F8304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x000FA110 File Offset: 0x000F8310
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
					if (num != 26U)
					{
						if (num != 80U)
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
						if (this.historyRecord_ == null)
						{
							this.HistoryRecord = new EndlessBattleRecord();
						}
						input.ReadMessage(this.HistoryRecord);
					}
				}
				else
				{
					if (this.nowSeasonRecord_ == null)
					{
						this.NowSeasonRecord = new EndlessBattleRecord();
					}
					input.ReadMessage(this.NowSeasonRecord);
				}
			}
		}

		// Token: 0x04003995 RID: 14741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003996 RID: 14742
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003997 RID: 14743
		private ErrorCode errorCode_;

		// Token: 0x04003998 RID: 14744
		public const int NowSeasonRecordFieldNumber = 2;

		// Token: 0x04003999 RID: 14745
		private EndlessBattleRecord nowSeasonRecord_;

		// Token: 0x0400399A RID: 14746
		public const int HistoryRecordFieldNumber = 3;

		// Token: 0x0400399B RID: 14747
		private EndlessBattleRecord historyRecord_;
	}
}
