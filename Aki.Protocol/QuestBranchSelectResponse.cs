using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0A RID: 3594
	[NetMessage(EMessageId.QuestBranchSelectResponse)]
	public sealed class QuestBranchSelectResponse : IMessage<QuestBranchSelectResponse>, IMessage, IEquatable<QuestBranchSelectResponse>, IDeepCloneable<QuestBranchSelectResponse>, IBufferMessage
	{
		// Token: 0x06013515 RID: 79125 RVA: 0x002CFBBC File Offset: 0x002CDDBC
		[NullableContext(1)]
		public static QuestBranchSelectResponse Create()
		{
			return new QuestBranchSelectResponse();
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x06013516 RID: 79126 RVA: 0x002CFBC3 File Offset: 0x002CDDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x06013517 RID: 79127 RVA: 0x002CFBC6 File Offset: 0x002CDDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchSelectResponse.Descriptor;
			}
		}

		// Token: 0x06013518 RID: 79128 RVA: 0x002CFBCD File Offset: 0x002CDDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectResponse()
		{
		}

		// Token: 0x06013519 RID: 79129 RVA: 0x002CFBD8 File Offset: 0x002CDDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectResponse(QuestBranchSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.oneQuestBranchPageInfo_ = ((other.oneQuestBranchPageInfo_ != null) ? other.oneQuestBranchPageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601351A RID: 79130 RVA: 0x002CFC24 File Offset: 0x002CDE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchSelectResponse Clone()
		{
			return new QuestBranchSelectResponse(this);
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x0601351B RID: 79131 RVA: 0x002CFC2C File Offset: 0x002CDE2C
		// (set) Token: 0x0601351C RID: 79132 RVA: 0x002CFC34 File Offset: 0x002CDE34
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

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x0601351D RID: 79133 RVA: 0x002CFC3D File Offset: 0x002CDE3D
		// (set) Token: 0x0601351E RID: 79134 RVA: 0x002CFC45 File Offset: 0x002CDE45
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

		// Token: 0x0601351F RID: 79135 RVA: 0x002CFC4E File Offset: 0x002CDE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchSelectResponse);
		}

		// Token: 0x06013520 RID: 79136 RVA: 0x002CFC5C File Offset: 0x002CDE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.OneQuestBranchPageInfo, other.OneQuestBranchPageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013521 RID: 79137 RVA: 0x002CFCAC File Offset: 0x002CDEAC
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

		// Token: 0x06013522 RID: 79138 RVA: 0x002CFD07 File Offset: 0x002CDF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013523 RID: 79139 RVA: 0x002CFD14 File Offset: 0x002CDF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013524 RID: 79140 RVA: 0x002CFD20 File Offset: 0x002CDF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oneQuestBranchPageInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.OneQuestBranchPageInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013525 RID: 79141 RVA: 0x002CFD7C File Offset: 0x002CDF7C
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

		// Token: 0x06013526 RID: 79142 RVA: 0x002CFDD4 File Offset: 0x002CDFD4
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

		// Token: 0x06013527 RID: 79143 RVA: 0x002CFE3C File Offset: 0x002CE03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013528 RID: 79144 RVA: 0x002CFE48 File Offset: 0x002CE048
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
					if (num != 48U)
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
					if (this.oneQuestBranchPageInfo_ == null)
					{
						this.OneQuestBranchPageInfo = new OneQuestBranchPageInfo();
					}
					input.ReadMessage(this.OneQuestBranchPageInfo);
				}
			}
		}

		// Token: 0x040076B2 RID: 30386
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076B3 RID: 30387
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040076B4 RID: 30388
		private ErrorCode errorCode_;

		// Token: 0x040076B5 RID: 30389
		public const int OneQuestBranchPageInfoFieldNumber = 2;

		// Token: 0x040076B6 RID: 30390
		private OneQuestBranchPageInfo oneQuestBranchPageInfo_;
	}
}
