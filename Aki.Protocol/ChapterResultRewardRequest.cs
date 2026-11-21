using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000272 RID: 626
	[NetMessage(EMessageId.ChapterResultRewardRequest)]
	public sealed class ChapterResultRewardRequest : IMessage<ChapterResultRewardRequest>, IMessage, IEquatable<ChapterResultRewardRequest>, IDeepCloneable<ChapterResultRewardRequest>, IBufferMessage
	{
		// Token: 0x0600422C RID: 16940 RVA: 0x000A2D20 File Offset: 0x000A0F20
		[NullableContext(1)]
		public static ChapterResultRewardRequest Create()
		{
			return new ChapterResultRewardRequest();
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x0600422D RID: 16941 RVA: 0x000A2D27 File Offset: 0x000A0F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x000A2D2A File Offset: 0x000A0F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChapterResultRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x000A2D31 File Offset: 0x000A0F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardRequest()
		{
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x000A2D39 File Offset: 0x000A0F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardRequest(ChapterResultRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.resultId_ = other.resultId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x000A2D76 File Offset: 0x000A0F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterResultRewardRequest Clone()
		{
			return new ChapterResultRewardRequest(this);
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x000A2D7E File Offset: 0x000A0F7E
		// (set) Token: 0x06004233 RID: 16947 RVA: 0x000A2D86 File Offset: 0x000A0F86
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

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x000A2D8F File Offset: 0x000A0F8F
		// (set) Token: 0x06004235 RID: 16949 RVA: 0x000A2D97 File Offset: 0x000A0F97
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

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x000A2DA0 File Offset: 0x000A0FA0
		// (set) Token: 0x06004237 RID: 16951 RVA: 0x000A2DA8 File Offset: 0x000A0FA8
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

		// Token: 0x06004238 RID: 16952 RVA: 0x000A2DB1 File Offset: 0x000A0FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChapterResultRewardRequest);
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x000A2DC0 File Offset: 0x000A0FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChapterResultRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.ResultId == other.ResultId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x000A2E1C File Offset: 0x000A101C
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

		// Token: 0x0600423B RID: 16955 RVA: 0x000A2E8D File Offset: 0x000A108D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x000A2E9A File Offset: 0x000A109A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x000A2EA4 File Offset: 0x000A10A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResultId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ResultId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ChapterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x000A2F1C File Offset: 0x000A111C
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

		// Token: 0x0600423F RID: 16959 RVA: 0x000A2F8C File Offset: 0x000A118C
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

		// Token: 0x06004240 RID: 16960 RVA: 0x000A2FF0 File Offset: 0x000A11F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x000A2FFC File Offset: 0x000A11FC
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
					if (num != 88U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ResultId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002E47 RID: 11847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E48 RID: 11848
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04002E49 RID: 11849
		private int activityId_;

		// Token: 0x04002E4A RID: 11850
		public const int ChapterIdFieldNumber = 13;

		// Token: 0x04002E4B RID: 11851
		private int chapterId_;

		// Token: 0x04002E4C RID: 11852
		public const int ResultIdFieldNumber = 6;

		// Token: 0x04002E4D RID: 11853
		private int resultId_;
	}
}
