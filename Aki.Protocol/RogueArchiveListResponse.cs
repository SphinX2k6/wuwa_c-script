using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7D RID: 3965
	[NetMessage(EMessageId.RogueArchiveListResponse)]
	public sealed class RogueArchiveListResponse : IMessage<RogueArchiveListResponse>, IMessage, IEquatable<RogueArchiveListResponse>, IDeepCloneable<RogueArchiveListResponse>, IBufferMessage
	{
		// Token: 0x0601532A RID: 86826 RVA: 0x00312D61 File Offset: 0x00310F61
		[NullableContext(1)]
		public static RogueArchiveListResponse Create()
		{
			return new RogueArchiveListResponse();
		}

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x0601532B RID: 86827 RVA: 0x00312D68 File Offset: 0x00310F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x0601532C RID: 86828 RVA: 0x00312D6B File Offset: 0x00310F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveListResponse.Descriptor;
			}
		}

		// Token: 0x0601532D RID: 86829 RVA: 0x00312D72 File Offset: 0x00310F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListResponse()
		{
		}

		// Token: 0x0601532E RID: 86830 RVA: 0x00312D85 File Offset: 0x00310F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListResponse(RogueArchiveListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.archiveInfos_ = other.archiveInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601532F RID: 86831 RVA: 0x00312DBB File Offset: 0x00310FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListResponse Clone()
		{
			return new RogueArchiveListResponse(this);
		}

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x06015330 RID: 86832 RVA: 0x00312DC3 File Offset: 0x00310FC3
		// (set) Token: 0x06015331 RID: 86833 RVA: 0x00312DCB File Offset: 0x00310FCB
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

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x06015332 RID: 86834 RVA: 0x00312DD4 File Offset: 0x00310FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueArchiveInfo> ArchiveInfos
		{
			get
			{
				return this.archiveInfos_;
			}
		}

		// Token: 0x06015333 RID: 86835 RVA: 0x00312DDC File Offset: 0x00310FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveListResponse);
		}

		// Token: 0x06015334 RID: 86836 RVA: 0x00312DEC File Offset: 0x00310FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.archiveInfos_.Equals(other.archiveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015335 RID: 86837 RVA: 0x00312E3C File Offset: 0x0031103C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.archiveInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015336 RID: 86838 RVA: 0x00312E8F File Offset: 0x0031108F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015337 RID: 86839 RVA: 0x00312E9C File Offset: 0x0031109C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015338 RID: 86840 RVA: 0x00312EA8 File Offset: 0x003110A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.archiveInfos_.WriteTo(ref output, RogueArchiveListResponse._repeated_archiveInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015339 RID: 86841 RVA: 0x00312EF8 File Offset: 0x003110F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.archiveInfos_.CalculateSize(RogueArchiveListResponse._repeated_archiveInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601533A RID: 86842 RVA: 0x00312F4C File Offset: 0x0031114C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.archiveInfos_.Add(other.archiveInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601533B RID: 86843 RVA: 0x00312F99 File Offset: 0x00311199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601533C RID: 86844 RVA: 0x00312FA4 File Offset: 0x003111A4
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
				if (num != 56U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.archiveInfos_.AddEntriesFrom(ref input, RogueArchiveListResponse._repeated_archiveInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F7B RID: 32635
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F7C RID: 32636
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007F7D RID: 32637
		private ErrorCode errorCode_;

		// Token: 0x04007F7E RID: 32638
		public const int ArchiveInfosFieldNumber = 10;

		// Token: 0x04007F7F RID: 32639
		private static readonly FieldCodec<RogueArchiveInfo> _repeated_archiveInfos_codec = FieldCodec.ForMessage<RogueArchiveInfo>(82U, RogueArchiveInfo.Parser);

		// Token: 0x04007F80 RID: 32640
		private readonly RepeatedField<RogueArchiveInfo> archiveInfos_ = new RepeatedField<RogueArchiveInfo>();
	}
}
