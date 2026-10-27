using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000290 RID: 656
	public sealed class CiacconaChapterPbData : IMessage<CiacconaChapterPbData>, IMessage, IEquatable<CiacconaChapterPbData>, IDeepCloneable<CiacconaChapterPbData>, IBufferMessage
	{
		// Token: 0x06004470 RID: 17520 RVA: 0x000A7E7A File Offset: 0x000A607A
		[NullableContext(1)]
		public static CiacconaChapterPbData Create()
		{
			return new CiacconaChapterPbData();
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x000A7E81 File Offset: 0x000A6081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaChapterPbData> Parser
		{
			get
			{
				return CiacconaChapterPbData._parser;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x000A7E88 File Offset: 0x000A6088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x000A7E8B File Offset: 0x000A608B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaChapterPbData.Descriptor;
			}
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x000A7E92 File Offset: 0x000A6092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterPbData()
		{
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x000A7EB0 File Offset: 0x000A60B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterPbData(CiacconaChapterPbData other) : this()
		{
			this.characterId_ = other.characterId_;
			this.unlock_ = other.unlock_;
			this.resultDatas_ = other.resultDatas_.Clone();
			this.choiceDatas_ = other.choiceDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x000A7F0E File Offset: 0x000A610E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterPbData Clone()
		{
			return new CiacconaChapterPbData(this);
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x000A7F16 File Offset: 0x000A6116
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x000A7F1E File Offset: 0x000A611E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CharacterId
		{
			get
			{
				return this.characterId_;
			}
			set
			{
				this.characterId_ = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x000A7F27 File Offset: 0x000A6127
		// (set) Token: 0x0600447A RID: 17530 RVA: 0x000A7F2F File Offset: 0x000A612F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x000A7F38 File Offset: 0x000A6138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterResultPbData> ResultDatas
		{
			get
			{
				return this.resultDatas_;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x000A7F40 File Offset: 0x000A6140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterChoicePbData> ChoiceDatas
		{
			get
			{
				return this.choiceDatas_;
			}
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x000A7F48 File Offset: 0x000A6148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaChapterPbData);
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x000A7F58 File Offset: 0x000A6158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaChapterPbData other)
		{
			return other != null && (other == this || (this.CharacterId == other.CharacterId && this.Unlock == other.Unlock && this.resultDatas_.Equals(other.resultDatas_) && this.choiceDatas_.Equals(other.choiceDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x000A7FCC File Offset: 0x000A61CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CharacterId != 0)
			{
				num ^= this.CharacterId.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			num ^= this.resultDatas_.GetHashCode();
			num ^= this.choiceDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x000A8040 File Offset: 0x000A6240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x000A804D File Offset: 0x000A624D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x000A8058 File Offset: 0x000A6258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CharacterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CharacterId);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Unlock);
			}
			this.resultDatas_.WriteTo(ref output, CiacconaChapterPbData._repeated_resultDatas_codec);
			this.choiceDatas_.WriteTo(ref output, CiacconaChapterPbData._repeated_choiceDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x000A80D4 File Offset: 0x000A62D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CharacterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CharacterId);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			num += this.resultDatas_.CalculateSize(CiacconaChapterPbData._repeated_resultDatas_codec);
			num += this.choiceDatas_.CalculateSize(CiacconaChapterPbData._repeated_choiceDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x000A8144 File Offset: 0x000A6344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaChapterPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CharacterId != 0)
			{
				this.CharacterId = other.CharacterId;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			this.resultDatas_.Add(other.resultDatas_);
			this.choiceDatas_.Add(other.choiceDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x000A81B6 File Offset: 0x000A63B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x000A81C0 File Offset: 0x000A63C0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.CharacterId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.resultDatas_.AddEntriesFrom(ref input, CiacconaChapterPbData._repeated_resultDatas_codec);
						continue;
					}
					if (num == 34U)
					{
						this.choiceDatas_.AddEntriesFrom(ref input, CiacconaChapterPbData._repeated_choiceDatas_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E9F RID: 11935
		private static readonly MessageParser<CiacconaChapterPbData> _parser = new MessageParser<CiacconaChapterPbData>(() => new CiacconaChapterPbData());

		// Token: 0x04002EA0 RID: 11936
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EA1 RID: 11937
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002EA2 RID: 11938
		private int characterId_;

		// Token: 0x04002EA3 RID: 11939
		public const int UnlockFieldNumber = 2;

		// Token: 0x04002EA4 RID: 11940
		private bool unlock_;

		// Token: 0x04002EA5 RID: 11941
		public const int ResultDatasFieldNumber = 3;

		// Token: 0x04002EA6 RID: 11942
		private static readonly FieldCodec<CiacconaChapterResultPbData> _repeated_resultDatas_codec = FieldCodec.ForMessage<CiacconaChapterResultPbData>(26U, CiacconaChapterResultPbData.Parser);

		// Token: 0x04002EA7 RID: 11943
		private readonly RepeatedField<CiacconaChapterResultPbData> resultDatas_ = new RepeatedField<CiacconaChapterResultPbData>();

		// Token: 0x04002EA8 RID: 11944
		public const int ChoiceDatasFieldNumber = 4;

		// Token: 0x04002EA9 RID: 11945
		private static readonly FieldCodec<CiacconaChapterChoicePbData> _repeated_choiceDatas_codec = FieldCodec.ForMessage<CiacconaChapterChoicePbData>(34U, CiacconaChapterChoicePbData.Parser);

		// Token: 0x04002EAA RID: 11946
		private readonly RepeatedField<CiacconaChapterChoicePbData> choiceDatas_ = new RepeatedField<CiacconaChapterChoicePbData>();
	}
}
