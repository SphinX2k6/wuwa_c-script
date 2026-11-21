using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6D RID: 3949
	[NetMessage(EMessageId.RogueArchiveListResponse)]
	public sealed class RogueArchiveListResponse : IMessage<RogueArchiveListResponse>, IMessage, IEquatable<RogueArchiveListResponse>, IDeepCloneable<RogueArchiveListResponse>, IBufferMessage
	{
		// Token: 0x06015245 RID: 86597 RVA: 0x003116B5 File Offset: 0x0030F8B5
		[NullableContext(1)]
		public static RogueArchiveListResponse Create()
		{
			return new RogueArchiveListResponse();
		}

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x06015246 RID: 86598 RVA: 0x003116BC File Offset: 0x0030F8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x06015247 RID: 86599 RVA: 0x003116BF File Offset: 0x0030F8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveListResponse.Descriptor;
			}
		}

		// Token: 0x06015248 RID: 86600 RVA: 0x003116C6 File Offset: 0x0030F8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListResponse()
		{
		}

		// Token: 0x06015249 RID: 86601 RVA: 0x003116D9 File Offset: 0x0030F8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListResponse(RogueArchiveListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.archiveInfos_ = other.archiveInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601524A RID: 86602 RVA: 0x0031170F File Offset: 0x0030F90F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveListResponse Clone()
		{
			return new RogueArchiveListResponse(this);
		}

		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x0601524B RID: 86603 RVA: 0x00311717 File Offset: 0x0030F917
		// (set) Token: 0x0601524C RID: 86604 RVA: 0x0031171F File Offset: 0x0030F91F
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

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x0601524D RID: 86605 RVA: 0x00311728 File Offset: 0x0030F928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueArchiveInfo> ArchiveInfos
		{
			get
			{
				return this.archiveInfos_;
			}
		}

		// Token: 0x0601524E RID: 86606 RVA: 0x00311730 File Offset: 0x0030F930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveListResponse);
		}

		// Token: 0x0601524F RID: 86607 RVA: 0x00311740 File Offset: 0x0030F940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.archiveInfos_.Equals(other.archiveInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015250 RID: 86608 RVA: 0x00311790 File Offset: 0x0030F990
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

		// Token: 0x06015251 RID: 86609 RVA: 0x003117E3 File Offset: 0x0030F9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015252 RID: 86610 RVA: 0x003117F0 File Offset: 0x0030F9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015253 RID: 86611 RVA: 0x003117FC File Offset: 0x0030F9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.archiveInfos_.WriteTo(ref output, RogueArchiveListResponse._repeated_archiveInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015254 RID: 86612 RVA: 0x0031184C File Offset: 0x0030FA4C
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

		// Token: 0x06015255 RID: 86613 RVA: 0x003118A0 File Offset: 0x0030FAA0
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

		// Token: 0x06015256 RID: 86614 RVA: 0x003118ED File Offset: 0x0030FAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015257 RID: 86615 RVA: 0x003118F8 File Offset: 0x0030FAF8
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
					if (num != 72U)
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
					this.archiveInfos_.AddEntriesFrom(ref input, RogueArchiveListResponse._repeated_archiveInfos_codec);
				}
			}
		}

		// Token: 0x04007FA5 RID: 32677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FA6 RID: 32678
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007FA7 RID: 32679
		private ErrorCode errorCode_;

		// Token: 0x04007FA8 RID: 32680
		public const int ArchiveInfosFieldNumber = 5;

		// Token: 0x04007FA9 RID: 32681
		private static readonly FieldCodec<RogueArchiveInfo> _repeated_archiveInfos_codec = FieldCodec.ForMessage<RogueArchiveInfo>(42U, RogueArchiveInfo.Parser);

		// Token: 0x04007FAA RID: 32682
		private readonly RepeatedField<RogueArchiveInfo> archiveInfos_ = new RepeatedField<RogueArchiveInfo>();
	}
}
