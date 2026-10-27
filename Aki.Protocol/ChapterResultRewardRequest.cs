using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026D RID: 621
	[NetMessage(EMessageId.ChapterResultRewardRequest)]
	public sealed class ChapterResultRewardRequest : IMessage<ChapterResultRewardRequest>, IMessage, IEquatable<ChapterResultRewardRequest>, IDeepCloneable<ChapterResultRewardRequest>, IBufferMessage
	{
		// Token: 0x06004185 RID: 16773 RVA: 0x000A1058 File Offset: 0x0009F258
		[NullableContext(1)]
		public static ChapterResultRewardRequest Create()
		{
			return new ChapterResultRewardRequest();
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x000A105F File Offset: 0x0009F25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x000A1062 File Offset: 0x0009F262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChapterResultRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x000A1069 File Offset: 0x0009F269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardRequest()
		{
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x000A1071 File Offset: 0x0009F271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardRequest(ChapterResultRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.resultId_ = other.resultId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x000A10AE File Offset: 0x0009F2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardRequest Clone()
		{
			return new ChapterResultRewardRequest(this);
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x000A10B6 File Offset: 0x0009F2B6
		// (set) Token: 0x0600418C RID: 16780 RVA: 0x000A10BE File Offset: 0x0009F2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x000A10C7 File Offset: 0x0009F2C7
		// (set) Token: 0x0600418E RID: 16782 RVA: 0x000A10CF File Offset: 0x0009F2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChapterId
		{
			get
			{
				return this.chapterId_;
			}
			set
			{
				this.chapterId_ = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x000A10D8 File Offset: 0x0009F2D8
		// (set) Token: 0x06004190 RID: 16784 RVA: 0x000A10E0 File Offset: 0x0009F2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResultId
		{
			get
			{
				return this.resultId_;
			}
			set
			{
				this.resultId_ = value;
			}
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x000A10E9 File Offset: 0x0009F2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChapterResultRewardRequest);
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x000A10F8 File Offset: 0x0009F2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChapterResultRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.ResultId == other.ResultId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x000A1154 File Offset: 0x0009F354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this.ResultId != 0)
			{
				num ^= this.ResultId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x000A11C5 File Offset: 0x0009F3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x000A11D2 File Offset: 0x0009F3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x000A11DC File Offset: 0x0009F3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChapterId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ResultId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ResultId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000A1250 File Offset: 0x0009F450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this.ResultId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResultId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x000A12C0 File Offset: 0x0009F4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChapterResultRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			if (other.ResultId != 0)
			{
				this.ResultId = other.ResultId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x000A1324 File Offset: 0x0009F524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x000A1330 File Offset: 0x0009F530
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
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ResultId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ChapterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DC3 RID: 11715
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DC4 RID: 11716
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04002DC5 RID: 11717
		private int activityId_;

		// Token: 0x04002DC6 RID: 11718
		public const int ChapterIdFieldNumber = 1;

		// Token: 0x04002DC7 RID: 11719
		private int chapterId_;

		// Token: 0x04002DC8 RID: 11720
		public const int ResultIdFieldNumber = 14;

		// Token: 0x04002DC9 RID: 11721
		private int resultId_;
	}
}
