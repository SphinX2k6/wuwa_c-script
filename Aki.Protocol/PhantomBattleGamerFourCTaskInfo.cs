using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8D RID: 3213
	public sealed class PhantomBattleGamerFourCTaskInfo : IMessage<PhantomBattleGamerFourCTaskInfo>, IMessage, IEquatable<PhantomBattleGamerFourCTaskInfo>, IDeepCloneable<PhantomBattleGamerFourCTaskInfo>, IBufferMessage
	{
		// Token: 0x060116B1 RID: 71345 RVA: 0x0028D838 File Offset: 0x0028BA38
		[NullableContext(1)]
		public static PhantomBattleGamerFourCTaskInfo Create()
		{
			return new PhantomBattleGamerFourCTaskInfo();
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x060116B2 RID: 71346 RVA: 0x0028D83F File Offset: 0x0028BA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleGamerFourCTaskInfo> Parser
		{
			get
			{
				return PhantomBattleGamerFourCTaskInfo._parser;
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x060116B3 RID: 71347 RVA: 0x0028D846 File Offset: 0x0028BA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x060116B4 RID: 71348 RVA: 0x0028D849 File Offset: 0x0028BA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGamerFourCTaskInfo.Descriptor;
			}
		}

		// Token: 0x060116B5 RID: 71349 RVA: 0x0028D850 File Offset: 0x0028BA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFourCTaskInfo()
		{
		}

		// Token: 0x060116B6 RID: 71350 RVA: 0x0028D864 File Offset: 0x0028BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFourCTaskInfo(PhantomBattleGamerFourCTaskInfo other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.phantomBattleFourTaskInfos_ = other.phantomBattleFourTaskInfos_.Clone();
			this.isFinish_ = other.isFinish_;
			this.cardConfId_ = other.cardConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060116B7 RID: 71351 RVA: 0x0028D8BD File Offset: 0x0028BABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFourCTaskInfo Clone()
		{
			return new PhantomBattleGamerFourCTaskInfo(this);
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x060116B8 RID: 71352 RVA: 0x0028D8C5 File Offset: 0x0028BAC5
		// (set) Token: 0x060116B9 RID: 71353 RVA: 0x0028D8CD File Offset: 0x0028BACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x060116BA RID: 71354 RVA: 0x0028D8D6 File Offset: 0x0028BAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFourTaskInfo> PhantomBattleFourTaskInfos
		{
			get
			{
				return this.phantomBattleFourTaskInfos_;
			}
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x060116BB RID: 71355 RVA: 0x0028D8DE File Offset: 0x0028BADE
		// (set) Token: 0x060116BC RID: 71356 RVA: 0x0028D8E6 File Offset: 0x0028BAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x060116BD RID: 71357 RVA: 0x0028D8EF File Offset: 0x0028BAEF
		// (set) Token: 0x060116BE RID: 71358 RVA: 0x0028D8F7 File Offset: 0x0028BAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardConfId
		{
			get
			{
				return this.cardConfId_;
			}
			set
			{
				this.cardConfId_ = value;
			}
		}

		// Token: 0x060116BF RID: 71359 RVA: 0x0028D900 File Offset: 0x0028BB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGamerFourCTaskInfo);
		}

		// Token: 0x060116C0 RID: 71360 RVA: 0x0028D910 File Offset: 0x0028BB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGamerFourCTaskInfo other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.phantomBattleFourTaskInfos_.Equals(other.phantomBattleFourTaskInfos_) && this.IsFinish == other.IsFinish && this.CardConfId == other.CardConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060116C1 RID: 71361 RVA: 0x0028D980 File Offset: 0x0028BB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			num ^= this.phantomBattleFourTaskInfos_.GetHashCode();
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this.CardConfId != 0)
			{
				num ^= this.CardConfId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060116C2 RID: 71362 RVA: 0x0028D9FF File Offset: 0x0028BBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060116C3 RID: 71363 RVA: 0x0028DA0C File Offset: 0x0028BC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060116C4 RID: 71364 RVA: 0x0028DA18 File Offset: 0x0028BC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamerIndex);
			}
			this.phantomBattleFourTaskInfos_.WriteTo(ref output, PhantomBattleGamerFourCTaskInfo._repeated_phantomBattleFourTaskInfos_codec);
			if (this.IsFinish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinish);
			}
			if (this.CardConfId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardConfId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060116C5 RID: 71365 RVA: 0x0028DAA0 File Offset: 0x0028BCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			num += this.phantomBattleFourTaskInfos_.CalculateSize(PhantomBattleGamerFourCTaskInfo._repeated_phantomBattleFourTaskInfos_codec);
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this.CardConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardConfId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060116C6 RID: 71366 RVA: 0x0028DB18 File Offset: 0x0028BD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGamerFourCTaskInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			this.phantomBattleFourTaskInfos_.Add(other.phantomBattleFourTaskInfos_);
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			if (other.CardConfId != 0)
			{
				this.CardConfId = other.CardConfId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060116C7 RID: 71367 RVA: 0x0028DB8D File Offset: 0x0028BD8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060116C8 RID: 71368 RVA: 0x0028DB98 File Offset: 0x0028BD98
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.GamerIndex = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.phantomBattleFourTaskInfos_.AddEntriesFrom(ref input, PhantomBattleGamerFourCTaskInfo._repeated_phantomBattleFourTaskInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.CardConfId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E00 RID: 28160
		private static readonly MessageParser<PhantomBattleGamerFourCTaskInfo> _parser = new MessageParser<PhantomBattleGamerFourCTaskInfo>(() => new PhantomBattleGamerFourCTaskInfo());

		// Token: 0x04006E01 RID: 28161
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E02 RID: 28162
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006E03 RID: 28163
		private int gamerIndex_;

		// Token: 0x04006E04 RID: 28164
		public const int PhantomBattleFourTaskInfosFieldNumber = 2;

		// Token: 0x04006E05 RID: 28165
		private static readonly FieldCodec<PhantomBattleFourTaskInfo> _repeated_phantomBattleFourTaskInfos_codec = FieldCodec.ForMessage<PhantomBattleFourTaskInfo>(18U, PhantomBattleFourTaskInfo.Parser);

		// Token: 0x04006E06 RID: 28166
		private readonly RepeatedField<PhantomBattleFourTaskInfo> phantomBattleFourTaskInfos_ = new RepeatedField<PhantomBattleFourTaskInfo>();

		// Token: 0x04006E07 RID: 28167
		public const int IsFinishFieldNumber = 3;

		// Token: 0x04006E08 RID: 28168
		private bool isFinish_;

		// Token: 0x04006E09 RID: 28169
		public const int CardConfIdFieldNumber = 4;

		// Token: 0x04006E0A RID: 28170
		private int cardConfId_;
	}
}
