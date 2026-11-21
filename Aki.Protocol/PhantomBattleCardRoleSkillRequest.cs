using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4B RID: 3147
	[NetMessage(EMessageId.PhantomBattleCardRoleSkillRequest)]
	public sealed class PhantomBattleCardRoleSkillRequest : IMessage<PhantomBattleCardRoleSkillRequest>, IMessage, IEquatable<PhantomBattleCardRoleSkillRequest>, IDeepCloneable<PhantomBattleCardRoleSkillRequest>, IBufferMessage
	{
		// Token: 0x0601115C RID: 69980 RVA: 0x00280CD1 File Offset: 0x0027EED1
		[NullableContext(1)]
		public static PhantomBattleCardRoleSkillRequest Create()
		{
			return new PhantomBattleCardRoleSkillRequest();
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0601115D RID: 69981 RVA: 0x00280CD8 File Offset: 0x0027EED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0601115E RID: 69982 RVA: 0x00280CDB File Offset: 0x0027EEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601115F RID: 69983 RVA: 0x00280CE2 File Offset: 0x0027EEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillRequest()
		{
		}

		// Token: 0x06011160 RID: 69984 RVA: 0x00280CF5 File Offset: 0x0027EEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillRequest(PhantomBattleCardRoleSkillRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011161 RID: 69985 RVA: 0x00280D2B File Offset: 0x0027EF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleSkillRequest Clone()
		{
			return new PhantomBattleCardRoleSkillRequest(this);
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x06011162 RID: 69986 RVA: 0x00280D33 File Offset: 0x0027EF33
		// (set) Token: 0x06011163 RID: 69987 RVA: 0x00280D3B File Offset: 0x0027EF3B
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

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x06011164 RID: 69988 RVA: 0x00280D44 File Offset: 0x0027EF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x06011165 RID: 69989 RVA: 0x00280D4C File Offset: 0x0027EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleSkillRequest);
		}

		// Token: 0x06011166 RID: 69990 RVA: 0x00280D5C File Offset: 0x0027EF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleSkillRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011167 RID: 69991 RVA: 0x00280DAC File Offset: 0x0027EFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.selectFighterUId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011168 RID: 69992 RVA: 0x00280DF9 File Offset: 0x0027EFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011169 RID: 69993 RVA: 0x00280E06 File Offset: 0x0027F006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601116A RID: 69994 RVA: 0x00280E10 File Offset: 0x0027F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleCardRoleSkillRequest._repeated_selectFighterUId_codec);
			if (this.SkillId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601116B RID: 69995 RVA: 0x00280E60 File Offset: 0x0027F060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			num += this.selectFighterUId_.CalculateSize(PhantomBattleCardRoleSkillRequest._repeated_selectFighterUId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601116C RID: 69996 RVA: 0x00280EB4 File Offset: 0x0027F0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRoleSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this.selectFighterUId_.Add(other.selectFighterUId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601116D RID: 69997 RVA: 0x00280F01 File Offset: 0x0027F101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601116E RID: 69998 RVA: 0x00280F0C File Offset: 0x0027F10C
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
				if (num != 24U && num != 26U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillId = input.ReadInt32();
					}
				}
				else
				{
					this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleCardRoleSkillRequest._repeated_selectFighterUId_codec);
				}
			}
		}

		// Token: 0x04006C9A RID: 27802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C9B RID: 27803
		public const int SkillIdFieldNumber = 13;

		// Token: 0x04006C9C RID: 27804
		private int skillId_;

		// Token: 0x04006C9D RID: 27805
		public const int SelectFighterUIdFieldNumber = 3;

		// Token: 0x04006C9E RID: 27806
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006C9F RID: 27807
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();
	}
}
