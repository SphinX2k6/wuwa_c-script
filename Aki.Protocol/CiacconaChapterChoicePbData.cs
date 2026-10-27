using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028F RID: 655
	public sealed class CiacconaChapterChoicePbData : IMessage<CiacconaChapterChoicePbData>, IMessage, IEquatable<CiacconaChapterChoicePbData>, IDeepCloneable<CiacconaChapterChoicePbData>, IBufferMessage
	{
		// Token: 0x06004458 RID: 17496 RVA: 0x000A7B2B File Offset: 0x000A5D2B
		[NullableContext(1)]
		public static CiacconaChapterChoicePbData Create()
		{
			return new CiacconaChapterChoicePbData();
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x000A7B32 File Offset: 0x000A5D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaChapterChoicePbData> Parser
		{
			get
			{
				return CiacconaChapterChoicePbData._parser;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x000A7B39 File Offset: 0x000A5D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x000A7B3C File Offset: 0x000A5D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaChapterChoicePbData.Descriptor;
			}
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x000A7B43 File Offset: 0x000A5D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterChoicePbData()
		{
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x000A7B4B File Offset: 0x000A5D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterChoicePbData(CiacconaChapterChoicePbData other) : this()
		{
			this.choiceId_ = other.choiceId_;
			this.inspirationUnlock_ = other.inspirationUnlock_;
			this.conditionUnlock_ = other.conditionUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x000A7B88 File Offset: 0x000A5D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterChoicePbData Clone()
		{
			return new CiacconaChapterChoicePbData(this);
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x000A7B90 File Offset: 0x000A5D90
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x000A7B98 File Offset: 0x000A5D98
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

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x000A7BA1 File Offset: 0x000A5DA1
		// (set) Token: 0x06004462 RID: 17506 RVA: 0x000A7BA9 File Offset: 0x000A5DA9
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x000A7BB2 File Offset: 0x000A5DB2
		// (set) Token: 0x06004464 RID: 17508 RVA: 0x000A7BBA File Offset: 0x000A5DBA
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

		// Token: 0x06004465 RID: 17509 RVA: 0x000A7BC3 File Offset: 0x000A5DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaChapterChoicePbData);
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x000A7BD4 File Offset: 0x000A5DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaChapterChoicePbData other)
		{
			return other != null && (other == this || (this.ChoiceId == other.ChoiceId && this.InspirationUnlock == other.InspirationUnlock && this.ConditionUnlock == other.ConditionUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x000A7C30 File Offset: 0x000A5E30
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

		// Token: 0x06004468 RID: 17512 RVA: 0x000A7CA1 File Offset: 0x000A5EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x000A7CAE File Offset: 0x000A5EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x000A7CB8 File Offset: 0x000A5EB8
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

		// Token: 0x0600446B RID: 17515 RVA: 0x000A7D2C File Offset: 0x000A5F2C
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

		// Token: 0x0600446C RID: 17516 RVA: 0x000A7D84 File Offset: 0x000A5F84
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

		// Token: 0x0600446D RID: 17517 RVA: 0x000A7DE8 File Offset: 0x000A5FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x000A7DF4 File Offset: 0x000A5FF4
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

		// Token: 0x04002E97 RID: 11927
		private static readonly MessageParser<CiacconaChapterChoicePbData> _parser = new MessageParser<CiacconaChapterChoicePbData>(() => new CiacconaChapterChoicePbData());

		// Token: 0x04002E98 RID: 11928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E99 RID: 11929
		public const int ChoiceIdFieldNumber = 1;

		// Token: 0x04002E9A RID: 11930
		private int choiceId_;

		// Token: 0x04002E9B RID: 11931
		public const int InspirationUnlockFieldNumber = 2;

		// Token: 0x04002E9C RID: 11932
		private bool inspirationUnlock_;

		// Token: 0x04002E9D RID: 11933
		public const int ConditionUnlockFieldNumber = 3;

		// Token: 0x04002E9E RID: 11934
		private bool conditionUnlock_;
	}
}
