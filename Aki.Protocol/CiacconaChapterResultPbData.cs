using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000296 RID: 662
	public sealed class CiacconaChapterResultPbData : IMessage<CiacconaChapterResultPbData>, IMessage, IEquatable<CiacconaChapterResultPbData>, IDeepCloneable<CiacconaChapterResultPbData>, IBufferMessage
	{
		// Token: 0x0600452F RID: 17711 RVA: 0x000A9F54 File Offset: 0x000A8154
		[NullableContext(1)]
		public static CiacconaChapterResultPbData Create()
		{
			return new CiacconaChapterResultPbData();
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06004530 RID: 17712 RVA: 0x000A9F5B File Offset: 0x000A815B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaChapterResultPbData> Parser
		{
			get
			{
				return CiacconaChapterResultPbData._parser;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x000A9F62 File Offset: 0x000A8162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06004532 RID: 17714 RVA: 0x000A9F65 File Offset: 0x000A8165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaChapterResultPbData.Descriptor;
			}
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x000A9F6C File Offset: 0x000A816C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterResultPbData()
		{
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x000A9F74 File Offset: 0x000A8174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterResultPbData(CiacconaChapterResultPbData other) : this()
		{
			this.resultId_ = other.resultId_;
			this.finish_ = other.finish_;
			this.takeReward_ = other.takeReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x000A9FB1 File Offset: 0x000A81B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterResultPbData Clone()
		{
			return new CiacconaChapterResultPbData(this);
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x000A9FB9 File Offset: 0x000A81B9
		// (set) Token: 0x06004537 RID: 17719 RVA: 0x000A9FC1 File Offset: 0x000A81C1
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x000A9FCA File Offset: 0x000A81CA
		// (set) Token: 0x06004539 RID: 17721 RVA: 0x000A9FD2 File Offset: 0x000A81D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Finish
		{
			get
			{
				return this.finish_;
			}
			set
			{
				this.finish_ = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x000A9FDB File Offset: 0x000A81DB
		// (set) Token: 0x0600453B RID: 17723 RVA: 0x000A9FE3 File Offset: 0x000A81E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TakeReward
		{
			get
			{
				return this.takeReward_;
			}
			set
			{
				this.takeReward_ = value;
			}
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x000A9FEC File Offset: 0x000A81EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaChapterResultPbData);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x000A9FFC File Offset: 0x000A81FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaChapterResultPbData other)
		{
			return other != null && (other == this || (this.ResultId == other.ResultId && this.Finish == other.Finish && this.TakeReward == other.TakeReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x000AA058 File Offset: 0x000A8258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResultId != 0)
			{
				num ^= this.ResultId.GetHashCode();
			}
			if (this.Finish)
			{
				num ^= this.Finish.GetHashCode();
			}
			if (this.TakeReward)
			{
				num ^= this.TakeReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x000AA0C9 File Offset: 0x000A82C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x000AA0D6 File Offset: 0x000A82D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x000AA0E0 File Offset: 0x000A82E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResultId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ResultId);
			}
			if (this.Finish)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Finish);
			}
			if (this.TakeReward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.TakeReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x000AA154 File Offset: 0x000A8354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResultId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResultId);
			}
			if (this.Finish)
			{
				num += 2;
			}
			if (this.TakeReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x000AA1AC File Offset: 0x000A83AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaChapterResultPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResultId != 0)
			{
				this.ResultId = other.ResultId;
			}
			if (other.Finish)
			{
				this.Finish = other.Finish;
			}
			if (other.TakeReward)
			{
				this.TakeReward = other.TakeReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x000AA210 File Offset: 0x000A8410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x000AA21C File Offset: 0x000A841C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TakeReward = input.ReadBool();
						}
					}
					else
					{
						this.Finish = input.ReadBool();
					}
				}
				else
				{
					this.ResultId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F2F RID: 12079
		private static readonly MessageParser<CiacconaChapterResultPbData> _parser = new MessageParser<CiacconaChapterResultPbData>(() => new CiacconaChapterResultPbData());

		// Token: 0x04002F30 RID: 12080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F31 RID: 12081
		public const int ResultIdFieldNumber = 1;

		// Token: 0x04002F32 RID: 12082
		private int resultId_;

		// Token: 0x04002F33 RID: 12083
		public const int FinishFieldNumber = 2;

		// Token: 0x04002F34 RID: 12084
		private bool finish_;

		// Token: 0x04002F35 RID: 12085
		public const int TakeRewardFieldNumber = 3;

		// Token: 0x04002F36 RID: 12086
		private bool takeReward_;
	}
}
