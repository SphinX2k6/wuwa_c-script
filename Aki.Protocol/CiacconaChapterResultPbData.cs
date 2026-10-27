using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000291 RID: 657
	public sealed class CiacconaChapterResultPbData : IMessage<CiacconaChapterResultPbData>, IMessage, IEquatable<CiacconaChapterResultPbData>, IDeepCloneable<CiacconaChapterResultPbData>, IBufferMessage
	{
		// Token: 0x06004488 RID: 17544 RVA: 0x000A828C File Offset: 0x000A648C
		[NullableContext(1)]
		public static CiacconaChapterResultPbData Create()
		{
			return new CiacconaChapterResultPbData();
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x000A8293 File Offset: 0x000A6493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaChapterResultPbData> Parser
		{
			get
			{
				return CiacconaChapterResultPbData._parser;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x0600448A RID: 17546 RVA: 0x000A829A File Offset: 0x000A649A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x000A829D File Offset: 0x000A649D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaChapterResultPbData.Descriptor;
			}
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x000A82A4 File Offset: 0x000A64A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterResultPbData()
		{
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x000A82AC File Offset: 0x000A64AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterResultPbData(CiacconaChapterResultPbData other) : this()
		{
			this.resultId_ = other.resultId_;
			this.finish_ = other.finish_;
			this.takeReward_ = other.takeReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x000A82E9 File Offset: 0x000A64E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterResultPbData Clone()
		{
			return new CiacconaChapterResultPbData(this);
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x000A82F1 File Offset: 0x000A64F1
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x000A82F9 File Offset: 0x000A64F9
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

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x000A8302 File Offset: 0x000A6502
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x000A830A File Offset: 0x000A650A
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

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x000A8313 File Offset: 0x000A6513
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x000A831B File Offset: 0x000A651B
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

		// Token: 0x06004495 RID: 17557 RVA: 0x000A8324 File Offset: 0x000A6524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaChapterResultPbData);
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x000A8334 File Offset: 0x000A6534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaChapterResultPbData other)
		{
			return other != null && (other == this || (this.ResultId == other.ResultId && this.Finish == other.Finish && this.TakeReward == other.TakeReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x000A8390 File Offset: 0x000A6590
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

		// Token: 0x06004498 RID: 17560 RVA: 0x000A8401 File Offset: 0x000A6601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x000A840E File Offset: 0x000A660E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x000A8418 File Offset: 0x000A6618
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

		// Token: 0x0600449B RID: 17563 RVA: 0x000A848C File Offset: 0x000A668C
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

		// Token: 0x0600449C RID: 17564 RVA: 0x000A84E4 File Offset: 0x000A66E4
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

		// Token: 0x0600449D RID: 17565 RVA: 0x000A8548 File Offset: 0x000A6748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x000A8554 File Offset: 0x000A6754
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

		// Token: 0x04002EAB RID: 11947
		private static readonly MessageParser<CiacconaChapterResultPbData> _parser = new MessageParser<CiacconaChapterResultPbData>(() => new CiacconaChapterResultPbData());

		// Token: 0x04002EAC RID: 11948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EAD RID: 11949
		public const int ResultIdFieldNumber = 1;

		// Token: 0x04002EAE RID: 11950
		private int resultId_;

		// Token: 0x04002EAF RID: 11951
		public const int FinishFieldNumber = 2;

		// Token: 0x04002EB0 RID: 11952
		private bool finish_;

		// Token: 0x04002EB1 RID: 11953
		public const int TakeRewardFieldNumber = 3;

		// Token: 0x04002EB2 RID: 11954
		private bool takeReward_;
	}
}
