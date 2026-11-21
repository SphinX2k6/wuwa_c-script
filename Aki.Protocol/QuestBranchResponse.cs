using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF8 RID: 3576
	[NetMessage(EMessageId.QuestBranchResponse)]
	public sealed class QuestBranchResponse : IMessage<QuestBranchResponse>, IMessage, IEquatable<QuestBranchResponse>, IDeepCloneable<QuestBranchResponse>, IBufferMessage
	{
		// Token: 0x06013408 RID: 78856 RVA: 0x002CDF72 File Offset: 0x002CC172
		[NullableContext(1)]
		public static QuestBranchResponse Create()
		{
			return new QuestBranchResponse();
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x06013409 RID: 78857 RVA: 0x002CDF79 File Offset: 0x002CC179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x0601340A RID: 78858 RVA: 0x002CDF7C File Offset: 0x002CC17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchResponse.Descriptor;
			}
		}

		// Token: 0x0601340B RID: 78859 RVA: 0x002CDF83 File Offset: 0x002CC183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchResponse()
		{
		}

		// Token: 0x0601340C RID: 78860 RVA: 0x002CDF8C File Offset: 0x002CC18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchResponse(QuestBranchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.questBranchInfo_ = ((other.questBranchInfo_ != null) ? other.questBranchInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601340D RID: 78861 RVA: 0x002CDFD8 File Offset: 0x002CC1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchResponse Clone()
		{
			return new QuestBranchResponse(this);
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x0601340E RID: 78862 RVA: 0x002CDFE0 File Offset: 0x002CC1E0
		// (set) Token: 0x0601340F RID: 78863 RVA: 0x002CDFE8 File Offset: 0x002CC1E8
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

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x06013410 RID: 78864 RVA: 0x002CDFF1 File Offset: 0x002CC1F1
		// (set) Token: 0x06013411 RID: 78865 RVA: 0x002CDFF9 File Offset: 0x002CC1F9
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

		// Token: 0x06013412 RID: 78866 RVA: 0x002CE002 File Offset: 0x002CC202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchResponse);
		}

		// Token: 0x06013413 RID: 78867 RVA: 0x002CE010 File Offset: 0x002CC210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.QuestBranchInfo, other.QuestBranchInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013414 RID: 78868 RVA: 0x002CE060 File Offset: 0x002CC260
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

		// Token: 0x06013415 RID: 78869 RVA: 0x002CE0BB File Offset: 0x002CC2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013416 RID: 78870 RVA: 0x002CE0C8 File Offset: 0x002CC2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013417 RID: 78871 RVA: 0x002CE0D4 File Offset: 0x002CC2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.questBranchInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.QuestBranchInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013418 RID: 78872 RVA: 0x002CE130 File Offset: 0x002CC330
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

		// Token: 0x06013419 RID: 78873 RVA: 0x002CE188 File Offset: 0x002CC388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchResponse other)
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

		// Token: 0x0601341A RID: 78874 RVA: 0x002CE1F0 File Offset: 0x002CC3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601341B RID: 78875 RVA: 0x002CE1FC File Offset: 0x002CC3FC
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
				if (num != 48U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040076D2 RID: 30418
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076D3 RID: 30419
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040076D4 RID: 30420
		private ErrorCode errorCode_;

		// Token: 0x040076D5 RID: 30421
		public const int QuestBranchInfoFieldNumber = 9;

		// Token: 0x040076D6 RID: 30422
		private QuestBranchInfo questBranchInfo_;
	}
}
