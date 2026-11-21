using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7D RID: 3197
	public sealed class PhantomBattleGamerFourCTaskInfo : IMessage<PhantomBattleGamerFourCTaskInfo>, IMessage, IEquatable<PhantomBattleGamerFourCTaskInfo>, IDeepCloneable<PhantomBattleGamerFourCTaskInfo>, IBufferMessage
	{
		// Token: 0x060115B1 RID: 71089 RVA: 0x0028BACC File Offset: 0x00289CCC
		[NullableContext(1)]
		public static PhantomBattleGamerFourCTaskInfo Create()
		{
			return new PhantomBattleGamerFourCTaskInfo();
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x060115B2 RID: 71090 RVA: 0x0028BAD3 File Offset: 0x00289CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleGamerFourCTaskInfo> Parser
		{
			get
			{
				return PhantomBattleGamerFourCTaskInfo._parser;
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x060115B3 RID: 71091 RVA: 0x0028BADA File Offset: 0x00289CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x060115B4 RID: 71092 RVA: 0x0028BADD File Offset: 0x00289CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGamerFourCTaskInfo.Descriptor;
			}
		}

		// Token: 0x060115B5 RID: 71093 RVA: 0x0028BAE4 File Offset: 0x00289CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFourCTaskInfo()
		{
		}

		// Token: 0x060115B6 RID: 71094 RVA: 0x0028BAF8 File Offset: 0x00289CF8
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

		// Token: 0x060115B7 RID: 71095 RVA: 0x0028BB51 File Offset: 0x00289D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGamerFourCTaskInfo Clone()
		{
			return new PhantomBattleGamerFourCTaskInfo(this);
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x060115B8 RID: 71096 RVA: 0x0028BB59 File Offset: 0x00289D59
		// (set) Token: 0x060115B9 RID: 71097 RVA: 0x0028BB61 File Offset: 0x00289D61
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

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x060115BA RID: 71098 RVA: 0x0028BB6A File Offset: 0x00289D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFourTaskInfo> PhantomBattleFourTaskInfos
		{
			get
			{
				return this.phantomBattleFourTaskInfos_;
			}
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x060115BB RID: 71099 RVA: 0x0028BB72 File Offset: 0x00289D72
		// (set) Token: 0x060115BC RID: 71100 RVA: 0x0028BB7A File Offset: 0x00289D7A
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

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x060115BD RID: 71101 RVA: 0x0028BB83 File Offset: 0x00289D83
		// (set) Token: 0x060115BE RID: 71102 RVA: 0x0028BB8B File Offset: 0x00289D8B
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

		// Token: 0x060115BF RID: 71103 RVA: 0x0028BB94 File Offset: 0x00289D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGamerFourCTaskInfo);
		}

		// Token: 0x060115C0 RID: 71104 RVA: 0x0028BBA4 File Offset: 0x00289DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGamerFourCTaskInfo other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.phantomBattleFourTaskInfos_.Equals(other.phantomBattleFourTaskInfos_) && this.IsFinish == other.IsFinish && this.CardConfId == other.CardConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115C1 RID: 71105 RVA: 0x0028BC14 File Offset: 0x00289E14
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

		// Token: 0x060115C2 RID: 71106 RVA: 0x0028BC93 File Offset: 0x00289E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115C3 RID: 71107 RVA: 0x0028BCA0 File Offset: 0x00289EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115C4 RID: 71108 RVA: 0x0028BCAC File Offset: 0x00289EAC
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

		// Token: 0x060115C5 RID: 71109 RVA: 0x0028BD34 File Offset: 0x00289F34
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

		// Token: 0x060115C6 RID: 71110 RVA: 0x0028BDAC File Offset: 0x00289FAC
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

		// Token: 0x060115C7 RID: 71111 RVA: 0x0028BE21 File Offset: 0x0028A021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115C8 RID: 71112 RVA: 0x0028BE2C File Offset: 0x0028A02C
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

		// Token: 0x04006E14 RID: 28180
		private static readonly MessageParser<PhantomBattleGamerFourCTaskInfo> _parser = new MessageParser<PhantomBattleGamerFourCTaskInfo>(() => new PhantomBattleGamerFourCTaskInfo());

		// Token: 0x04006E15 RID: 28181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E16 RID: 28182
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006E17 RID: 28183
		private int gamerIndex_;

		// Token: 0x04006E18 RID: 28184
		public const int PhantomBattleFourTaskInfosFieldNumber = 2;

		// Token: 0x04006E19 RID: 28185
		private static readonly FieldCodec<PhantomBattleFourTaskInfo> _repeated_phantomBattleFourTaskInfos_codec = FieldCodec.ForMessage<PhantomBattleFourTaskInfo>(18U, PhantomBattleFourTaskInfo.Parser);

		// Token: 0x04006E1A RID: 28186
		private readonly RepeatedField<PhantomBattleFourTaskInfo> phantomBattleFourTaskInfos_ = new RepeatedField<PhantomBattleFourTaskInfo>();

		// Token: 0x04006E1B RID: 28187
		public const int IsFinishFieldNumber = 3;

		// Token: 0x04006E1C RID: 28188
		private bool isFinish_;

		// Token: 0x04006E1D RID: 28189
		public const int CardConfIdFieldNumber = 4;

		// Token: 0x04006E1E RID: 28190
		private int cardConfId_;
	}
}
