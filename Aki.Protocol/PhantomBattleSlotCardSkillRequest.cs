using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA9 RID: 3241
	[NetMessage(EMessageId.PhantomBattleSlotCardSkillRequest)]
	public sealed class PhantomBattleSlotCardSkillRequest : IMessage<PhantomBattleSlotCardSkillRequest>, IMessage, IEquatable<PhantomBattleSlotCardSkillRequest>, IDeepCloneable<PhantomBattleSlotCardSkillRequest>, IBufferMessage
	{
		// Token: 0x06011945 RID: 72005 RVA: 0x00293891 File Offset: 0x00291A91
		[NullableContext(1)]
		public static PhantomBattleSlotCardSkillRequest Create()
		{
			return new PhantomBattleSlotCardSkillRequest();
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x06011946 RID: 72006 RVA: 0x00293898 File Offset: 0x00291A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x06011947 RID: 72007 RVA: 0x0029389B File Offset: 0x00291A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotCardSkillRequest.Descriptor;
			}
		}

		// Token: 0x06011948 RID: 72008 RVA: 0x002938A2 File Offset: 0x00291AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillRequest()
		{
		}

		// Token: 0x06011949 RID: 72009 RVA: 0x002938B8 File Offset: 0x00291AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillRequest(PhantomBattleSlotCardSkillRequest other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601194A RID: 72010 RVA: 0x00293905 File Offset: 0x00291B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotCardSkillRequest Clone()
		{
			return new PhantomBattleSlotCardSkillRequest(this);
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0601194B RID: 72011 RVA: 0x0029390D File Offset: 0x00291B0D
		// (set) Token: 0x0601194C RID: 72012 RVA: 0x00293915 File Offset: 0x00291B15
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

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0601194D RID: 72013 RVA: 0x0029391E File Offset: 0x00291B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0601194E RID: 72014 RVA: 0x00293926 File Offset: 0x00291B26
		// (set) Token: 0x0601194F RID: 72015 RVA: 0x0029392E File Offset: 0x00291B2E
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

		// Token: 0x06011950 RID: 72016 RVA: 0x00293937 File Offset: 0x00291B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotCardSkillRequest);
		}

		// Token: 0x06011951 RID: 72017 RVA: 0x00293948 File Offset: 0x00291B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotCardSkillRequest other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.selectFighterUId_.Equals(other.selectFighterUId_) && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011952 RID: 72018 RVA: 0x002939A8 File Offset: 0x00291BA8
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

		// Token: 0x06011953 RID: 72019 RVA: 0x00293A0E File Offset: 0x00291C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011954 RID: 72020 RVA: 0x00293A1B File Offset: 0x00291C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011955 RID: 72021 RVA: 0x00293A24 File Offset: 0x00291C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleSlotCardSkillRequest._repeated_selectFighterUId_codec);
			if (this.CardUId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CardUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011956 RID: 72022 RVA: 0x00293A90 File Offset: 0x00291C90
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

		// Token: 0x06011957 RID: 72023 RVA: 0x00293AFC File Offset: 0x00291CFC
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

		// Token: 0x06011958 RID: 72024 RVA: 0x00293B5D File Offset: 0x00291D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011959 RID: 72025 RVA: 0x00293B68 File Offset: 0x00291D68
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_45;
					}
					if (num == 40U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleSlotCardSkillRequest._repeated_selectFighterUId_codec);
			}
		}

		// Token: 0x04006F2A RID: 28458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F2B RID: 28459
		public const int CardUIdFieldNumber = 5;

		// Token: 0x04006F2C RID: 28460
		private int cardUId_;

		// Token: 0x04006F2D RID: 28461
		public const int SelectFighterUIdFieldNumber = 3;

		// Token: 0x04006F2E RID: 28462
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006F2F RID: 28463
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006F30 RID: 28464
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04006F31 RID: 28465
		private int skillId_;
	}
}
