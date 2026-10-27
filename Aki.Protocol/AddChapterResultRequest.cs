using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009D RID: 157
	[NetMessage(EMessageId.AddChapterResultRequest)]
	public sealed class AddChapterResultRequest : IMessage<AddChapterResultRequest>, IMessage, IEquatable<AddChapterResultRequest>, IDeepCloneable<AddChapterResultRequest>, IBufferMessage
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x0004DEF3 File Offset: 0x0004C0F3
		[NullableContext(1)]
		public static AddChapterResultRequest Create()
		{
			return new AddChapterResultRequest();
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0004DEFA File Offset: 0x0004C0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x0004DEFD File Offset: 0x0004C0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddChapterResultRequest.Descriptor;
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0004DF04 File Offset: 0x0004C104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultRequest()
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0004DF0C File Offset: 0x0004C10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultRequest(AddChapterResultRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.resultId_ = other.resultId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0004DF49 File Offset: 0x0004C149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultRequest Clone()
		{
			return new AddChapterResultRequest(this);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0004DF51 File Offset: 0x0004C151
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0004DF59 File Offset: 0x0004C159
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0004DF62 File Offset: 0x0004C162
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x0004DF6A File Offset: 0x0004C16A
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x0004DF73 File Offset: 0x0004C173
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x0004DF7B File Offset: 0x0004C17B
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

		// Token: 0x06001C0F RID: 7183 RVA: 0x0004DF84 File Offset: 0x0004C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddChapterResultRequest);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0004DF94 File Offset: 0x0004C194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddChapterResultRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.ResultId == other.ResultId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0004DFF0 File Offset: 0x0004C1F0
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

		// Token: 0x06001C12 RID: 7186 RVA: 0x0004E061 File Offset: 0x0004C261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0004E06E File Offset: 0x0004C26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0004E078 File Offset: 0x0004C278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChapterId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ResultId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ResultId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0004E0F0 File Offset: 0x0004C2F0
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

		// Token: 0x06001C16 RID: 7190 RVA: 0x0004E160 File Offset: 0x0004C360
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

		// Token: 0x06001C17 RID: 7191 RVA: 0x0004E1C4 File Offset: 0x0004C3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0004E1D0 File Offset: 0x0004C3D0
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 80U)
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

		// Token: 0x040022C0 RID: 8896
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C1 RID: 8897
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040022C2 RID: 8898
		private int activityId_;

		// Token: 0x040022C3 RID: 8899
		public const int ChapterIdFieldNumber = 5;

		// Token: 0x040022C4 RID: 8900
		private int chapterId_;

		// Token: 0x040022C5 RID: 8901
		public const int ResultIdFieldNumber = 10;

		// Token: 0x040022C6 RID: 8902
		private int resultId_;
	}
}
