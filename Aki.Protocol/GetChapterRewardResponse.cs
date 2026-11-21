using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AE RID: 1710
	[NetMessage(EMessageId.GetChapterRewardResponse)]
	public sealed class GetChapterRewardResponse : IMessage<GetChapterRewardResponse>, IMessage, IEquatable<GetChapterRewardResponse>, IDeepCloneable<GetChapterRewardResponse>, IBufferMessage
	{
		// Token: 0x06009D01 RID: 40193 RVA: 0x0017DB40 File Offset: 0x0017BD40
		[NullableContext(1)]
		public static GetChapterRewardResponse Create()
		{
			return new GetChapterRewardResponse();
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06009D02 RID: 40194 RVA: 0x0017DB47 File Offset: 0x0017BD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06009D03 RID: 40195 RVA: 0x0017DB4A File Offset: 0x0017BD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChapterRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009D04 RID: 40196 RVA: 0x0017DB51 File Offset: 0x0017BD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardResponse()
		{
		}

		// Token: 0x06009D05 RID: 40197 RVA: 0x0017DB59 File Offset: 0x0017BD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardResponse(GetChapterRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.chapter_ = other.chapter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D06 RID: 40198 RVA: 0x0017DB8A File Offset: 0x0017BD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardResponse Clone()
		{
			return new GetChapterRewardResponse(this);
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06009D07 RID: 40199 RVA: 0x0017DB92 File Offset: 0x0017BD92
		// (set) Token: 0x06009D08 RID: 40200 RVA: 0x0017DB9A File Offset: 0x0017BD9A
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

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06009D09 RID: 40201 RVA: 0x0017DBA3 File Offset: 0x0017BDA3
		// (set) Token: 0x06009D0A RID: 40202 RVA: 0x0017DBAB File Offset: 0x0017BDAB
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

		// Token: 0x06009D0B RID: 40203 RVA: 0x0017DBB4 File Offset: 0x0017BDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChapterRewardResponse);
		}

		// Token: 0x06009D0C RID: 40204 RVA: 0x0017DBC2 File Offset: 0x0017BDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChapterRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Chapter == other.Chapter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D0D RID: 40205 RVA: 0x0017DC00 File Offset: 0x0017BE00
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

		// Token: 0x06009D0E RID: 40206 RVA: 0x0017DC5E File Offset: 0x0017BE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D0F RID: 40207 RVA: 0x0017DC6B File Offset: 0x0017BE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D10 RID: 40208 RVA: 0x0017DC74 File Offset: 0x0017BE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Chapter != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Chapter);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D11 RID: 40209 RVA: 0x0017DCD0 File Offset: 0x0017BED0
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

		// Token: 0x06009D12 RID: 40210 RVA: 0x0017DD28 File Offset: 0x0017BF28
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

		// Token: 0x06009D13 RID: 40211 RVA: 0x0017DD78 File Offset: 0x0017BF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x0017DD84 File Offset: 0x0017BF84
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
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.Chapter = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A25 RID: 18981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A26 RID: 18982
		public const int CodeFieldNumber = 14;

		// Token: 0x04004A27 RID: 18983
		private ErrorCode code_;

		// Token: 0x04004A28 RID: 18984
		public const int ChapterFieldNumber = 12;

		// Token: 0x04004A29 RID: 18985
		private int chapter_;
	}
}
