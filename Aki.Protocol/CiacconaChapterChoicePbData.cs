using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000294 RID: 660
	public sealed class CiacconaChapterChoicePbData : IMessage<CiacconaChapterChoicePbData>, IMessage, IEquatable<CiacconaChapterChoicePbData>, IDeepCloneable<CiacconaChapterChoicePbData>, IBufferMessage
	{
		// Token: 0x060044FF RID: 17663 RVA: 0x000A97F3 File Offset: 0x000A79F3
		[NullableContext(1)]
		public static CiacconaChapterChoicePbData Create()
		{
			return new CiacconaChapterChoicePbData();
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x000A97FA File Offset: 0x000A79FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaChapterChoicePbData> Parser
		{
			get
			{
				return CiacconaChapterChoicePbData._parser;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06004501 RID: 17665 RVA: 0x000A9801 File Offset: 0x000A7A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x000A9804 File Offset: 0x000A7A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaChapterChoicePbData.Descriptor;
			}
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x000A980B File Offset: 0x000A7A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterChoicePbData()
		{
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x000A9813 File Offset: 0x000A7A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterChoicePbData(CiacconaChapterChoicePbData other) : this()
		{
			this.choiceId_ = other.choiceId_;
			this.inspirationUnlock_ = other.inspirationUnlock_;
			this.conditionUnlock_ = other.conditionUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x000A9850 File Offset: 0x000A7A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterChoicePbData Clone()
		{
			return new CiacconaChapterChoicePbData(this);
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x000A9858 File Offset: 0x000A7A58
		// (set) Token: 0x06004507 RID: 17671 RVA: 0x000A9860 File Offset: 0x000A7A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChoiceId
		{
			get
			{
				return this.choiceId_;
			}
			set
			{
				this.choiceId_ = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x000A9869 File Offset: 0x000A7A69
		// (set) Token: 0x06004509 RID: 17673 RVA: 0x000A9871 File Offset: 0x000A7A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InspirationUnlock
		{
			get
			{
				return this.inspirationUnlock_;
			}
			set
			{
				this.inspirationUnlock_ = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x000A987A File Offset: 0x000A7A7A
		// (set) Token: 0x0600450B RID: 17675 RVA: 0x000A9882 File Offset: 0x000A7A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ConditionUnlock
		{
			get
			{
				return this.conditionUnlock_;
			}
			set
			{
				this.conditionUnlock_ = value;
			}
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x000A988B File Offset: 0x000A7A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaChapterChoicePbData);
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x000A989C File Offset: 0x000A7A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaChapterChoicePbData other)
		{
			return other != null && (other == this || (this.ChoiceId == other.ChoiceId && this.InspirationUnlock == other.InspirationUnlock && this.ConditionUnlock == other.ConditionUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x000A98F8 File Offset: 0x000A7AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChoiceId != 0)
			{
				num ^= this.ChoiceId.GetHashCode();
			}
			if (this.InspirationUnlock)
			{
				num ^= this.InspirationUnlock.GetHashCode();
			}
			if (this.ConditionUnlock)
			{
				num ^= this.ConditionUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x000A9969 File Offset: 0x000A7B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x000A9976 File Offset: 0x000A7B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x000A9980 File Offset: 0x000A7B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChoiceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChoiceId);
			}
			if (this.InspirationUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.InspirationUnlock);
			}
			if (this.ConditionUnlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ConditionUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x000A99F4 File Offset: 0x000A7BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChoiceId);
			}
			if (this.InspirationUnlock)
			{
				num += 2;
			}
			if (this.ConditionUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x000A9A4C File Offset: 0x000A7C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaChapterChoicePbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChoiceId != 0)
			{
				this.ChoiceId = other.ChoiceId;
			}
			if (other.InspirationUnlock)
			{
				this.InspirationUnlock = other.InspirationUnlock;
			}
			if (other.ConditionUnlock)
			{
				this.ConditionUnlock = other.ConditionUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x000A9AB0 File Offset: 0x000A7CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x000A9ABC File Offset: 0x000A7CBC
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
							this.ConditionUnlock = input.ReadBool();
						}
					}
					else
					{
						this.InspirationUnlock = input.ReadBool();
					}
				}
				else
				{
					this.ChoiceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F1B RID: 12059
		private static readonly MessageParser<CiacconaChapterChoicePbData> _parser = new MessageParser<CiacconaChapterChoicePbData>(() => new CiacconaChapterChoicePbData());

		// Token: 0x04002F1C RID: 12060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F1D RID: 12061
		public const int ChoiceIdFieldNumber = 1;

		// Token: 0x04002F1E RID: 12062
		private int choiceId_;

		// Token: 0x04002F1F RID: 12063
		public const int InspirationUnlockFieldNumber = 2;

		// Token: 0x04002F20 RID: 12064
		private bool inspirationUnlock_;

		// Token: 0x04002F21 RID: 12065
		public const int ConditionUnlockFieldNumber = 3;

		// Token: 0x04002F22 RID: 12066
		private bool conditionUnlock_;
	}
}
