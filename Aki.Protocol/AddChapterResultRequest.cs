using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009E RID: 158
	[NetMessage(EMessageId.AddChapterResultRequest)]
	public sealed class AddChapterResultRequest : IMessage<AddChapterResultRequest>, IMessage, IEquatable<AddChapterResultRequest>, IDeepCloneable<AddChapterResultRequest>, IBufferMessage
	{
		// Token: 0x06001C4A RID: 7242 RVA: 0x0004EB03 File Offset: 0x0004CD03
		[NullableContext(1)]
		public static AddChapterResultRequest Create()
		{
			return new AddChapterResultRequest();
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x0004EB0A File Offset: 0x0004CD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0004EB0D File Offset: 0x0004CD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddChapterResultRequest.Descriptor;
			}
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0004EB14 File Offset: 0x0004CD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultRequest()
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultRequest(AddChapterResultRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.resultId_ = other.resultId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0004EB59 File Offset: 0x0004CD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultRequest Clone()
		{
			return new AddChapterResultRequest(this);
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0004EB61 File Offset: 0x0004CD61
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x0004EB69 File Offset: 0x0004CD69
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0004EB72 File Offset: 0x0004CD72
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x0004EB7A File Offset: 0x0004CD7A
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x0004EB83 File Offset: 0x0004CD83
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0004EB8B File Offset: 0x0004CD8B
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

		// Token: 0x06001C56 RID: 7254 RVA: 0x0004EB94 File Offset: 0x0004CD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddChapterResultRequest);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0004EBA4 File Offset: 0x0004CDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddChapterResultRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.ResultId == other.ResultId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0004EC00 File Offset: 0x0004CE00
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

		// Token: 0x06001C59 RID: 7257 RVA: 0x0004EC71 File Offset: 0x0004CE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0004EC7E File Offset: 0x0004CE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0004EC88 File Offset: 0x0004CE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ChapterId);
			}
			if (this.ResultId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ResultId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0004ED00 File Offset: 0x0004CF00
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

		// Token: 0x06001C5D RID: 7261 RVA: 0x0004ED70 File Offset: 0x0004CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddChapterResultRequest other)
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

		// Token: 0x06001C5E RID: 7262 RVA: 0x0004EDD4 File Offset: 0x0004CFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0004EDE0 File Offset: 0x0004CFE0
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						if (num != 88U)
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
						this.ChapterId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002321 RID: 8993
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002322 RID: 8994
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04002323 RID: 8995
		private int activityId_;

		// Token: 0x04002324 RID: 8996
		public const int ChapterIdFieldNumber = 10;

		// Token: 0x04002325 RID: 8997
		private int chapterId_;

		// Token: 0x04002326 RID: 8998
		public const int ResultIdFieldNumber = 11;

		// Token: 0x04002327 RID: 8999
		private int resultId_;
	}
}
