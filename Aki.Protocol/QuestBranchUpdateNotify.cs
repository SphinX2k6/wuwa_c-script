using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFB RID: 3579
	[NetMessage(EMessageId.QuestBranchUpdateNotify)]
	public sealed class QuestBranchUpdateNotify : IMessage<QuestBranchUpdateNotify>, IMessage, IEquatable<QuestBranchUpdateNotify>, IDeepCloneable<QuestBranchUpdateNotify>, IBufferMessage
	{
		// Token: 0x06013444 RID: 78916 RVA: 0x002CE7F7 File Offset: 0x002CC9F7
		[NullableContext(1)]
		public static QuestBranchUpdateNotify Create()
		{
			return new QuestBranchUpdateNotify();
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x06013445 RID: 78917 RVA: 0x002CE7FE File Offset: 0x002CC9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x06013446 RID: 78918 RVA: 0x002CE801 File Offset: 0x002CCA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06013447 RID: 78919 RVA: 0x002CE808 File Offset: 0x002CCA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchUpdateNotify()
		{
		}

		// Token: 0x06013448 RID: 78920 RVA: 0x002CE810 File Offset: 0x002CCA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchUpdateNotify(QuestBranchUpdateNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.questBranchInfo_ = ((other.questBranchInfo_ != null) ? other.questBranchInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013449 RID: 78921 RVA: 0x002CE85C File Offset: 0x002CCA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchUpdateNotify Clone()
		{
			return new QuestBranchUpdateNotify(this);
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x0601344A RID: 78922 RVA: 0x002CE864 File Offset: 0x002CCA64
		// (set) Token: 0x0601344B RID: 78923 RVA: 0x002CE86C File Offset: 0x002CCA6C
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

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x0601344C RID: 78924 RVA: 0x002CE875 File Offset: 0x002CCA75
		// (set) Token: 0x0601344D RID: 78925 RVA: 0x002CE87D File Offset: 0x002CCA7D
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

		// Token: 0x0601344E RID: 78926 RVA: 0x002CE886 File Offset: 0x002CCA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchUpdateNotify);
		}

		// Token: 0x0601344F RID: 78927 RVA: 0x002CE894 File Offset: 0x002CCA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchUpdateNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.QuestBranchInfo, other.QuestBranchInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013450 RID: 78928 RVA: 0x002CE8E4 File Offset: 0x002CCAE4
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

		// Token: 0x06013451 RID: 78929 RVA: 0x002CE93F File Offset: 0x002CCB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013452 RID: 78930 RVA: 0x002CE94C File Offset: 0x002CCB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013453 RID: 78931 RVA: 0x002CE958 File Offset: 0x002CCB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.questBranchInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.QuestBranchInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013454 RID: 78932 RVA: 0x002CE9B4 File Offset: 0x002CCBB4
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

		// Token: 0x06013455 RID: 78933 RVA: 0x002CEA0C File Offset: 0x002CCC0C
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

		// Token: 0x06013456 RID: 78934 RVA: 0x002CEA74 File Offset: 0x002CCC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013457 RID: 78935 RVA: 0x002CEA80 File Offset: 0x002CCC80
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
				if (num != 10U)
				{
					if (num != 88U)
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

		// Token: 0x040076E1 RID: 30433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076E2 RID: 30434
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040076E3 RID: 30435
		private ErrorCode errorCode_;

		// Token: 0x040076E4 RID: 30436
		public const int QuestBranchInfoFieldNumber = 1;

		// Token: 0x040076E5 RID: 30437
		private QuestBranchInfo questBranchInfo_;
	}
}
