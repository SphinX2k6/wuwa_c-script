using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C2 RID: 1730
	[NetMessage(EMessageId.GetChapterRewardResponse)]
	public sealed class GetChapterRewardResponse : IMessage<GetChapterRewardResponse>, IMessage, IEquatable<GetChapterRewardResponse>, IDeepCloneable<GetChapterRewardResponse>, IBufferMessage
	{
		// Token: 0x06009E57 RID: 40535 RVA: 0x00180571 File Offset: 0x0017E771
		[NullableContext(1)]
		public static GetChapterRewardResponse Create()
		{
			return new GetChapterRewardResponse();
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06009E58 RID: 40536 RVA: 0x00180578 File Offset: 0x0017E778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06009E59 RID: 40537 RVA: 0x0018057B File Offset: 0x0017E77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChapterRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x00180582 File Offset: 0x0017E782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardResponse()
		{
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x0018058A File Offset: 0x0017E78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardResponse(GetChapterRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.chapter_ = other.chapter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x001805BB File Offset: 0x0017E7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardResponse Clone()
		{
			return new GetChapterRewardResponse(this);
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06009E5D RID: 40541 RVA: 0x001805C3 File Offset: 0x0017E7C3
		// (set) Token: 0x06009E5E RID: 40542 RVA: 0x001805CB File Offset: 0x0017E7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06009E5F RID: 40543 RVA: 0x001805D4 File Offset: 0x0017E7D4
		// (set) Token: 0x06009E60 RID: 40544 RVA: 0x001805DC File Offset: 0x0017E7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Chapter
		{
			get
			{
				return this.chapter_;
			}
			set
			{
				this.chapter_ = value;
			}
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x001805E5 File Offset: 0x0017E7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChapterRewardResponse);
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x001805F3 File Offset: 0x0017E7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChapterRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Chapter == other.Chapter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x00180634 File Offset: 0x0017E834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Chapter != 0)
			{
				num ^= this.Chapter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E64 RID: 40548 RVA: 0x00180692 File Offset: 0x0017E892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x0018069F File Offset: 0x0017E89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x001806A8 File Offset: 0x0017E8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this.Chapter != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Chapter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E67 RID: 40551 RVA: 0x00180704 File Offset: 0x0017E904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Chapter != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Chapter);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x0018075C File Offset: 0x0017E95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChapterRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Chapter != 0)
			{
				this.Chapter = other.Chapter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x001807AC File Offset: 0x0017E9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x001807B8 File Offset: 0x0017E9B8
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Chapter = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A2C RID: 18988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A2D RID: 18989
		public const int CodeFieldNumber = 6;

		// Token: 0x04004A2E RID: 18990
		private ErrorCode code_;

		// Token: 0x04004A2F RID: 18991
		public const int ChapterFieldNumber = 10;

		// Token: 0x04004A30 RID: 18992
		private int chapter_;
	}
}
