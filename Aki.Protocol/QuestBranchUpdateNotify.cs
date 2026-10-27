using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0B RID: 3595
	[NetMessage(EMessageId.QuestBranchUpdateNotify)]
	public sealed class QuestBranchUpdateNotify : IMessage<QuestBranchUpdateNotify>, IMessage, IEquatable<QuestBranchUpdateNotify>, IDeepCloneable<QuestBranchUpdateNotify>, IBufferMessage
	{
		// Token: 0x06013529 RID: 79145 RVA: 0x002CFEB3 File Offset: 0x002CE0B3
		[NullableContext(1)]
		public static QuestBranchUpdateNotify Create()
		{
			return new QuestBranchUpdateNotify();
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x0601352A RID: 79146 RVA: 0x002CFEBA File Offset: 0x002CE0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x0601352B RID: 79147 RVA: 0x002CFEBD File Offset: 0x002CE0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601352C RID: 79148 RVA: 0x002CFEC4 File Offset: 0x002CE0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchUpdateNotify()
		{
		}

		// Token: 0x0601352D RID: 79149 RVA: 0x002CFECC File Offset: 0x002CE0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchUpdateNotify(QuestBranchUpdateNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.questBranchInfo_ = ((other.questBranchInfo_ != null) ? other.questBranchInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601352E RID: 79150 RVA: 0x002CFF18 File Offset: 0x002CE118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchUpdateNotify Clone()
		{
			return new QuestBranchUpdateNotify(this);
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0601352F RID: 79151 RVA: 0x002CFF20 File Offset: 0x002CE120
		// (set) Token: 0x06013530 RID: 79152 RVA: 0x002CFF28 File Offset: 0x002CE128
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

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x06013531 RID: 79153 RVA: 0x002CFF31 File Offset: 0x002CE131
		// (set) Token: 0x06013532 RID: 79154 RVA: 0x002CFF39 File Offset: 0x002CE139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo QuestBranchInfo
		{
			get
			{
				return this.questBranchInfo_;
			}
			set
			{
				this.questBranchInfo_ = value;
			}
		}

		// Token: 0x06013533 RID: 79155 RVA: 0x002CFF42 File Offset: 0x002CE142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchUpdateNotify);
		}

		// Token: 0x06013534 RID: 79156 RVA: 0x002CFF50 File Offset: 0x002CE150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchUpdateNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.QuestBranchInfo, other.QuestBranchInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013535 RID: 79157 RVA: 0x002CFFA0 File Offset: 0x002CE1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.questBranchInfo_ != null)
			{
				num ^= this.QuestBranchInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013536 RID: 79158 RVA: 0x002CFFFB File Offset: 0x002CE1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013537 RID: 79159 RVA: 0x002D0008 File Offset: 0x002CE208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013538 RID: 79160 RVA: 0x002D0014 File Offset: 0x002CE214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.questBranchInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.QuestBranchInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013539 RID: 79161 RVA: 0x002D0070 File Offset: 0x002CE270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.questBranchInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QuestBranchInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601353A RID: 79162 RVA: 0x002D00C8 File Offset: 0x002CE2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.questBranchInfo_ != null)
			{
				if (this.questBranchInfo_ == null)
				{
					this.QuestBranchInfo = new QuestBranchInfo();
				}
				this.QuestBranchInfo.MergeFrom(other.QuestBranchInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601353B RID: 79163 RVA: 0x002D0130 File Offset: 0x002CE330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601353C RID: 79164 RVA: 0x002D013C File Offset: 0x002CE33C
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
				if (num != 42U)
				{
					if (num != 120U)
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
					if (this.questBranchInfo_ == null)
					{
						this.QuestBranchInfo = new QuestBranchInfo();
					}
					input.ReadMessage(this.QuestBranchInfo);
				}
			}
		}

		// Token: 0x040076B7 RID: 30391
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076B8 RID: 30392
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040076B9 RID: 30393
		private ErrorCode errorCode_;

		// Token: 0x040076BA RID: 30394
		public const int QuestBranchInfoFieldNumber = 5;

		// Token: 0x040076BB RID: 30395
		private QuestBranchInfo questBranchInfo_;
	}
}
