using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFA RID: 3578
	[NetMessage(EMessageId.QuestBranchSelectResponse)]
	public sealed class QuestBranchSelectResponse : IMessage<QuestBranchSelectResponse>, IMessage, IEquatable<QuestBranchSelectResponse>, IDeepCloneable<QuestBranchSelectResponse>, IBufferMessage
	{
		// Token: 0x06013430 RID: 78896 RVA: 0x002CE500 File Offset: 0x002CC700
		[NullableContext(1)]
		public static QuestBranchSelectResponse Create()
		{
			return new QuestBranchSelectResponse();
		}

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x06013431 RID: 78897 RVA: 0x002CE507 File Offset: 0x002CC707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x06013432 RID: 78898 RVA: 0x002CE50A File Offset: 0x002CC70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchSelectResponse.Descriptor;
			}
		}

		// Token: 0x06013433 RID: 78899 RVA: 0x002CE511 File Offset: 0x002CC711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectResponse()
		{
		}

		// Token: 0x06013434 RID: 78900 RVA: 0x002CE51C File Offset: 0x002CC71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectResponse(QuestBranchSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.oneQuestBranchPageInfo_ = ((other.oneQuestBranchPageInfo_ != null) ? other.oneQuestBranchPageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013435 RID: 78901 RVA: 0x002CE568 File Offset: 0x002CC768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectResponse Clone()
		{
			return new QuestBranchSelectResponse(this);
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x06013436 RID: 78902 RVA: 0x002CE570 File Offset: 0x002CC770
		// (set) Token: 0x06013437 RID: 78903 RVA: 0x002CE578 File Offset: 0x002CC778
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

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x06013438 RID: 78904 RVA: 0x002CE581 File Offset: 0x002CC781
		// (set) Token: 0x06013439 RID: 78905 RVA: 0x002CE589 File Offset: 0x002CC789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneQuestBranchPageInfo OneQuestBranchPageInfo
		{
			get
			{
				return this.oneQuestBranchPageInfo_;
			}
			set
			{
				this.oneQuestBranchPageInfo_ = value;
			}
		}

		// Token: 0x0601343A RID: 78906 RVA: 0x002CE592 File Offset: 0x002CC792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchSelectResponse);
		}

		// Token: 0x0601343B RID: 78907 RVA: 0x002CE5A0 File Offset: 0x002CC7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.OneQuestBranchPageInfo, other.OneQuestBranchPageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601343C RID: 78908 RVA: 0x002CE5F0 File Offset: 0x002CC7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.oneQuestBranchPageInfo_ != null)
			{
				num ^= this.OneQuestBranchPageInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601343D RID: 78909 RVA: 0x002CE64B File Offset: 0x002CC84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601343E RID: 78910 RVA: 0x002CE658 File Offset: 0x002CC858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601343F RID: 78911 RVA: 0x002CE664 File Offset: 0x002CC864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.oneQuestBranchPageInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.OneQuestBranchPageInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013440 RID: 78912 RVA: 0x002CE6C0 File Offset: 0x002CC8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.oneQuestBranchPageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OneQuestBranchPageInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013441 RID: 78913 RVA: 0x002CE718 File Offset: 0x002CC918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchSelectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.oneQuestBranchPageInfo_ != null)
			{
				if (this.oneQuestBranchPageInfo_ == null)
				{
					this.OneQuestBranchPageInfo = new OneQuestBranchPageInfo();
				}
				this.OneQuestBranchPageInfo.MergeFrom(other.OneQuestBranchPageInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013442 RID: 78914 RVA: 0x002CE780 File Offset: 0x002CC980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013443 RID: 78915 RVA: 0x002CE78C File Offset: 0x002CC98C
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
				if (num != 40U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.oneQuestBranchPageInfo_ == null)
						{
							this.OneQuestBranchPageInfo = new OneQuestBranchPageInfo();
						}
						input.ReadMessage(this.OneQuestBranchPageInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076DC RID: 30428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076DD RID: 30429
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040076DE RID: 30430
		private ErrorCode errorCode_;

		// Token: 0x040076DF RID: 30431
		public const int OneQuestBranchPageInfoFieldNumber = 7;

		// Token: 0x040076E0 RID: 30432
		private OneQuestBranchPageInfo oneQuestBranchPageInfo_;
	}
}
