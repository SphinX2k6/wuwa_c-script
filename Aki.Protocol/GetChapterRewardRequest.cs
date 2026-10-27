using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C1 RID: 1729
	[NetMessage(EMessageId.GetChapterRewardRequest)]
	public sealed class GetChapterRewardRequest : IMessage<GetChapterRewardRequest>, IMessage, IEquatable<GetChapterRewardRequest>, IDeepCloneable<GetChapterRewardRequest>, IBufferMessage
	{
		// Token: 0x06009E45 RID: 40517 RVA: 0x00180398 File Offset: 0x0017E598
		[NullableContext(1)]
		public static GetChapterRewardRequest Create()
		{
			return new GetChapterRewardRequest();
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06009E46 RID: 40518 RVA: 0x0018039F File Offset: 0x0017E59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06009E47 RID: 40519 RVA: 0x001803A2 File Offset: 0x0017E5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChapterRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x001803A9 File Offset: 0x0017E5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardRequest()
		{
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x001803B1 File Offset: 0x0017E5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardRequest(GetChapterRewardRequest other) : this()
		{
			this.chapter_ = other.chapter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x001803D6 File Offset: 0x0017E5D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardRequest Clone()
		{
			return new GetChapterRewardRequest(this);
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06009E4B RID: 40523 RVA: 0x001803DE File Offset: 0x0017E5DE
		// (set) Token: 0x06009E4C RID: 40524 RVA: 0x001803E6 File Offset: 0x0017E5E6
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

		// Token: 0x06009E4D RID: 40525 RVA: 0x001803EF File Offset: 0x0017E5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChapterRewardRequest);
		}

		// Token: 0x06009E4E RID: 40526 RVA: 0x001803FD File Offset: 0x0017E5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChapterRewardRequest other)
		{
			return other != null && (other == this || (this.Chapter == other.Chapter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x0018042C File Offset: 0x0017E62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06009E50 RID: 40528 RVA: 0x0018046B File Offset: 0x0017E66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x00180478 File Offset: 0x0017E678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x00180481 File Offset: 0x0017E681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Chapter != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Chapter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x001804B4 File Offset: 0x0017E6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06009E54 RID: 40532 RVA: 0x001804F2 File Offset: 0x0017E6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChapterRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Chapter != 0)
			{
				this.Chapter = other.Chapter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x00180523 File Offset: 0x0017E723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x0018052C File Offset: 0x0017E72C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Chapter = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A29 RID: 18985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A2A RID: 18986
		public const int ChapterFieldNumber = 2;

		// Token: 0x04004A2B RID: 18987
		private int chapter_;
	}
}
