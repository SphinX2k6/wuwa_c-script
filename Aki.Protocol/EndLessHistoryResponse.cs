using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000429 RID: 1065
	[NetMessage(EMessageId.EndLessHistoryResponse)]
	public sealed class EndLessHistoryResponse : IMessage<EndLessHistoryResponse>, IMessage, IEquatable<EndLessHistoryResponse>, IDeepCloneable<EndLessHistoryResponse>, IBufferMessage
	{
		// Token: 0x0600668F RID: 26255 RVA: 0x000F6C52 File Offset: 0x000F4E52
		[NullableContext(1)]
		public static EndLessHistoryResponse Create()
		{
			return new EndLessHistoryResponse();
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x000F6C59 File Offset: 0x000F4E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06006691 RID: 26257 RVA: 0x000F6C5C File Offset: 0x000F4E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndLessHistoryResponse.Descriptor;
			}
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x000F6C63 File Offset: 0x000F4E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryResponse()
		{
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x000F6C6C File Offset: 0x000F4E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryResponse(EndLessHistoryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.nowSeasonRecord_ = ((other.nowSeasonRecord_ != null) ? other.nowSeasonRecord_.Clone() : null);
			this.historyRecord_ = ((other.historyRecord_ != null) ? other.historyRecord_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x000F6CD4 File Offset: 0x000F4ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndLessHistoryResponse Clone()
		{
			return new EndLessHistoryResponse(this);
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06006695 RID: 26261 RVA: 0x000F6CDC File Offset: 0x000F4EDC
		// (set) Token: 0x06006696 RID: 26262 RVA: 0x000F6CE4 File Offset: 0x000F4EE4
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

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06006697 RID: 26263 RVA: 0x000F6CED File Offset: 0x000F4EED
		// (set) Token: 0x06006698 RID: 26264 RVA: 0x000F6CF5 File Offset: 0x000F4EF5
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

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06006699 RID: 26265 RVA: 0x000F6CFE File Offset: 0x000F4EFE
		// (set) Token: 0x0600669A RID: 26266 RVA: 0x000F6D06 File Offset: 0x000F4F06
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

		// Token: 0x0600669B RID: 26267 RVA: 0x000F6D0F File Offset: 0x000F4F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndLessHistoryResponse);
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x000F6D20 File Offset: 0x000F4F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndLessHistoryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.NowSeasonRecord, other.NowSeasonRecord) && object.Equals(this.HistoryRecord, other.HistoryRecord) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x000F6D84 File Offset: 0x000F4F84
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

		// Token: 0x0600669E RID: 26270 RVA: 0x000F6DF5 File Offset: 0x000F4FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x000F6E02 File Offset: 0x000F5002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x000F6E0C File Offset: 0x000F500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nowSeasonRecord_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NowSeasonRecord);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.historyRecord_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.HistoryRecord);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x000F6E84 File Offset: 0x000F5084
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

		// Token: 0x060066A2 RID: 26274 RVA: 0x000F6EF4 File Offset: 0x000F50F4
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

		// Token: 0x060066A3 RID: 26275 RVA: 0x000F6F88 File Offset: 0x000F5188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x000F6F94 File Offset: 0x000F5194
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
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
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

		// Token: 0x04003982 RID: 14722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003983 RID: 14723
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04003984 RID: 14724
		private ErrorCode errorCode_;

		// Token: 0x04003985 RID: 14725
		public const int NowSeasonRecordFieldNumber = 2;

		// Token: 0x04003986 RID: 14726
		private EndlessBattleRecord nowSeasonRecord_;

		// Token: 0x04003987 RID: 14727
		public const int HistoryRecordFieldNumber = 8;

		// Token: 0x04003988 RID: 14728
		private EndlessBattleRecord historyRecord_;
	}
}
