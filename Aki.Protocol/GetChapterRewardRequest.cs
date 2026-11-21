using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AD RID: 1709
	[NetMessage(EMessageId.GetChapterRewardRequest)]
	public sealed class GetChapterRewardRequest : IMessage<GetChapterRewardRequest>, IMessage, IEquatable<GetChapterRewardRequest>, IDeepCloneable<GetChapterRewardRequest>, IBufferMessage
	{
		// Token: 0x06009CEF RID: 40175 RVA: 0x0017D968 File Offset: 0x0017BB68
		[NullableContext(1)]
		public static GetChapterRewardRequest Create()
		{
			return new GetChapterRewardRequest();
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06009CF0 RID: 40176 RVA: 0x0017D96F File Offset: 0x0017BB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06009CF1 RID: 40177 RVA: 0x0017D972 File Offset: 0x0017BB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChapterRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009CF2 RID: 40178 RVA: 0x0017D979 File Offset: 0x0017BB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardRequest()
		{
		}

		// Token: 0x06009CF3 RID: 40179 RVA: 0x0017D981 File Offset: 0x0017BB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardRequest(GetChapterRewardRequest other) : this()
		{
			this.chapter_ = other.chapter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CF4 RID: 40180 RVA: 0x0017D9A6 File Offset: 0x0017BBA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChapterRewardRequest Clone()
		{
			return new GetChapterRewardRequest(this);
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06009CF5 RID: 40181 RVA: 0x0017D9AE File Offset: 0x0017BBAE
		// (set) Token: 0x06009CF6 RID: 40182 RVA: 0x0017D9B6 File Offset: 0x0017BBB6
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

		// Token: 0x06009CF7 RID: 40183 RVA: 0x0017D9BF File Offset: 0x0017BBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChapterRewardRequest);
		}

		// Token: 0x06009CF8 RID: 40184 RVA: 0x0017D9CD File Offset: 0x0017BBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChapterRewardRequest other)
		{
			return other != null && (other == this || (this.Chapter == other.Chapter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CF9 RID: 40185 RVA: 0x0017D9FC File Offset: 0x0017BBFC
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

		// Token: 0x06009CFA RID: 40186 RVA: 0x0017DA3B File Offset: 0x0017BC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CFB RID: 40187 RVA: 0x0017DA48 File Offset: 0x0017BC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CFC RID: 40188 RVA: 0x0017DA51 File Offset: 0x0017BC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Chapter != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Chapter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CFD RID: 40189 RVA: 0x0017DA84 File Offset: 0x0017BC84
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

		// Token: 0x06009CFE RID: 40190 RVA: 0x0017DAC2 File Offset: 0x0017BCC2
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

		// Token: 0x06009CFF RID: 40191 RVA: 0x0017DAF3 File Offset: 0x0017BCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D00 RID: 40192 RVA: 0x0017DAFC File Offset: 0x0017BCFC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Chapter = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A22 RID: 18978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A23 RID: 18979
		public const int ChapterFieldNumber = 1;

		// Token: 0x04004A24 RID: 18980
		private int chapter_;
	}
}
