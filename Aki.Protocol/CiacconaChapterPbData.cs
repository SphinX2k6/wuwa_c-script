using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000295 RID: 661
	public sealed class CiacconaChapterPbData : IMessage<CiacconaChapterPbData>, IMessage, IEquatable<CiacconaChapterPbData>, IDeepCloneable<CiacconaChapterPbData>, IBufferMessage
	{
		// Token: 0x06004517 RID: 17687 RVA: 0x000A9B42 File Offset: 0x000A7D42
		[NullableContext(1)]
		public static CiacconaChapterPbData Create()
		{
			return new CiacconaChapterPbData();
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x000A9B49 File Offset: 0x000A7D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CiacconaChapterPbData> Parser
		{
			get
			{
				return CiacconaChapterPbData._parser;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06004519 RID: 17689 RVA: 0x000A9B50 File Offset: 0x000A7D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x000A9B53 File Offset: 0x000A7D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaChapterPbData.Descriptor;
			}
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x000A9B5A File Offset: 0x000A7D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterPbData()
		{
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x000A9B78 File Offset: 0x000A7D78
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

		// Token: 0x0600451D RID: 17693 RVA: 0x000A9BD6 File Offset: 0x000A7DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaChapterPbData Clone()
		{
			return new CiacconaChapterPbData(this);
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600451E RID: 17694 RVA: 0x000A9BDE File Offset: 0x000A7DDE
		// (set) Token: 0x0600451F RID: 17695 RVA: 0x000A9BE6 File Offset: 0x000A7DE6
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

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x000A9BEF File Offset: 0x000A7DEF
		// (set) Token: 0x06004521 RID: 17697 RVA: 0x000A9BF7 File Offset: 0x000A7DF7
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x000A9C00 File Offset: 0x000A7E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterResultPbData> ResultDatas
		{
			get
			{
				return this.resultDatas_;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06004523 RID: 17699 RVA: 0x000A9C08 File Offset: 0x000A7E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterChoicePbData> ChoiceDatas
		{
			get
			{
				return this.choiceDatas_;
			}
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x000A9C10 File Offset: 0x000A7E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaChapterPbData);
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x000A9C20 File Offset: 0x000A7E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaChapterPbData other)
		{
			return other != null && (other == this || (this.CharacterId == other.CharacterId && this.Unlock == other.Unlock && this.resultDatas_.Equals(other.resultDatas_) && this.choiceDatas_.Equals(other.choiceDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x000A9C94 File Offset: 0x000A7E94
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

		// Token: 0x06004527 RID: 17703 RVA: 0x000A9D08 File Offset: 0x000A7F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x000A9D15 File Offset: 0x000A7F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x000A9D20 File Offset: 0x000A7F20
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

		// Token: 0x0600452A RID: 17706 RVA: 0x000A9D9C File Offset: 0x000A7F9C
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

		// Token: 0x0600452B RID: 17707 RVA: 0x000A9E0C File Offset: 0x000A800C
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

		// Token: 0x0600452C RID: 17708 RVA: 0x000A9E7E File Offset: 0x000A807E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x000A9E88 File Offset: 0x000A8088
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

		// Token: 0x04002F23 RID: 12067
		private static readonly MessageParser<CiacconaChapterPbData> _parser = new MessageParser<CiacconaChapterPbData>(() => new CiacconaChapterPbData());

		// Token: 0x04002F24 RID: 12068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F25 RID: 12069
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002F26 RID: 12070
		private int characterId_;

		// Token: 0x04002F27 RID: 12071
		public const int UnlockFieldNumber = 2;

		// Token: 0x04002F28 RID: 12072
		private bool unlock_;

		// Token: 0x04002F29 RID: 12073
		public const int ResultDatasFieldNumber = 3;

		// Token: 0x04002F2A RID: 12074
		private static readonly FieldCodec<CiacconaChapterResultPbData> _repeated_resultDatas_codec = FieldCodec.ForMessage<CiacconaChapterResultPbData>(26U, CiacconaChapterResultPbData.Parser);

		// Token: 0x04002F2B RID: 12075
		private readonly RepeatedField<CiacconaChapterResultPbData> resultDatas_ = new RepeatedField<CiacconaChapterResultPbData>();

		// Token: 0x04002F2C RID: 12076
		public const int ChoiceDatasFieldNumber = 4;

		// Token: 0x04002F2D RID: 12077
		private static readonly FieldCodec<CiacconaChapterChoicePbData> _repeated_choiceDatas_codec = FieldCodec.ForMessage<CiacconaChapterChoicePbData>(34U, CiacconaChapterChoicePbData.Parser);

		// Token: 0x04002F2E RID: 12078
		private readonly RepeatedField<CiacconaChapterChoicePbData> choiceDatas_ = new RepeatedField<CiacconaChapterChoicePbData>();
	}
}
