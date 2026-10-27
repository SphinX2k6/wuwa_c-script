using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB9 RID: 3257
	[NetMessage(EMessageId.PhantomBattleSlotCardSkillRequest)]
	public sealed class PhantomBattleSlotCardSkillRequest : IMessage<PhantomBattleSlotCardSkillRequest>, IMessage, IEquatable<PhantomBattleSlotCardSkillRequest>, IDeepCloneable<PhantomBattleSlotCardSkillRequest>, IBufferMessage
	{
		// Token: 0x06011A45 RID: 72261 RVA: 0x002955F5 File Offset: 0x002937F5
		[NullableContext(1)]
		public static PhantomBattleSlotCardSkillRequest Create()
		{
			return new PhantomBattleSlotCardSkillRequest();
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x06011A46 RID: 72262 RVA: 0x002955FC File Offset: 0x002937FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x06011A47 RID: 72263 RVA: 0x002955FF File Offset: 0x002937FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotCardSkillRequest.Descriptor;
			}
		}

		// Token: 0x06011A48 RID: 72264 RVA: 0x00295606 File Offset: 0x00293806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillRequest()
		{
		}

		// Token: 0x06011A49 RID: 72265 RVA: 0x0029561C File Offset: 0x0029381C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillRequest(PhantomBattleSlotCardSkillRequest other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A4A RID: 72266 RVA: 0x00295669 File Offset: 0x00293869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillRequest Clone()
		{
			return new PhantomBattleSlotCardSkillRequest(this);
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x06011A4B RID: 72267 RVA: 0x00295671 File Offset: 0x00293871
		// (set) Token: 0x06011A4C RID: 72268 RVA: 0x00295679 File Offset: 0x00293879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x06011A4D RID: 72269 RVA: 0x00295682 File Offset: 0x00293882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x06011A4E RID: 72270 RVA: 0x0029568A File Offset: 0x0029388A
		// (set) Token: 0x06011A4F RID: 72271 RVA: 0x00295692 File Offset: 0x00293892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x06011A50 RID: 72272 RVA: 0x0029569B File Offset: 0x0029389B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotCardSkillRequest);
		}

		// Token: 0x06011A51 RID: 72273 RVA: 0x002956AC File Offset: 0x002938AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotCardSkillRequest other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.selectFighterUId_.Equals(other.selectFighterUId_) && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A52 RID: 72274 RVA: 0x0029570C File Offset: 0x0029390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			num ^= this.selectFighterUId_.GetHashCode();
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A53 RID: 72275 RVA: 0x00295772 File Offset: 0x00293972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A54 RID: 72276 RVA: 0x0029577F File Offset: 0x0029397F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A55 RID: 72277 RVA: 0x00295788 File Offset: 0x00293988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillId);
			}
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleSlotCardSkillRequest._repeated_selectFighterUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A56 RID: 72278 RVA: 0x002957F4 File Offset: 0x002939F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			num += this.selectFighterUId_.CalculateSize(PhantomBattleSlotCardSkillRequest._repeated_selectFighterUId_codec);
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A57 RID: 72279 RVA: 0x00295860 File Offset: 0x00293A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSlotCardSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			this.selectFighterUId_.Add(other.selectFighterUId_);
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A58 RID: 72280 RVA: 0x002958C1 File Offset: 0x00293AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A59 RID: 72281 RVA: 0x002958CC File Offset: 0x00293ACC
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
				if (num <= 104U)
				{
					if (num == 8U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleSlotCardSkillRequest._repeated_selectFighterUId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006F16 RID: 28438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F17 RID: 28439
		public const int CardUIdFieldNumber = 1;

		// Token: 0x04006F18 RID: 28440
		private int cardUId_;

		// Token: 0x04006F19 RID: 28441
		public const int SelectFighterUIdFieldNumber = 14;

		// Token: 0x04006F1A RID: 28442
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04006F1B RID: 28443
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006F1C RID: 28444
		public const int SkillIdFieldNumber = 13;

		// Token: 0x04006F1D RID: 28445
		private int skillId_;
	}
}
