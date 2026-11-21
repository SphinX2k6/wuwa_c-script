using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C52 RID: 3154
	[NetMessage(EMessageId.PhantomBattleCardSkillRequest)]
	public sealed class PhantomBattleCardSkillRequest : IMessage<PhantomBattleCardSkillRequest>, IMessage, IEquatable<PhantomBattleCardSkillRequest>, IDeepCloneable<PhantomBattleCardSkillRequest>, IBufferMessage
	{
		// Token: 0x060111EC RID: 70124 RVA: 0x002820E6 File Offset: 0x002802E6
		[NullableContext(1)]
		public static PhantomBattleCardSkillRequest Create()
		{
			return new PhantomBattleCardSkillRequest();
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x060111ED RID: 70125 RVA: 0x002820ED File Offset: 0x002802ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x060111EE RID: 70126 RVA: 0x002820F0 File Offset: 0x002802F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSkillRequest.Descriptor;
			}
		}

		// Token: 0x060111EF RID: 70127 RVA: 0x002820F7 File Offset: 0x002802F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillRequest()
		{
		}

		// Token: 0x060111F0 RID: 70128 RVA: 0x0028210A File Offset: 0x0028030A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillRequest(PhantomBattleCardSkillRequest other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111F1 RID: 70129 RVA: 0x00282140 File Offset: 0x00280340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillRequest Clone()
		{
			return new PhantomBattleCardSkillRequest(this);
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x060111F2 RID: 70130 RVA: 0x00282148 File Offset: 0x00280348
		// (set) Token: 0x060111F3 RID: 70131 RVA: 0x00282150 File Offset: 0x00280350
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

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x060111F4 RID: 70132 RVA: 0x00282159 File Offset: 0x00280359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x060111F5 RID: 70133 RVA: 0x00282161 File Offset: 0x00280361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSkillRequest);
		}

		// Token: 0x060111F6 RID: 70134 RVA: 0x00282170 File Offset: 0x00280370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSkillRequest other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111F7 RID: 70135 RVA: 0x002821C0 File Offset: 0x002803C0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060111F8 RID: 70136 RVA: 0x0028220D File Offset: 0x0028040D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111F9 RID: 70137 RVA: 0x0028221A File Offset: 0x0028041A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111FA RID: 70138 RVA: 0x00282224 File Offset: 0x00280424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CardUId);
			}
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleCardSkillRequest._repeated_selectFighterUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111FB RID: 70139 RVA: 0x00282274 File Offset: 0x00280474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			num += this.selectFighterUId_.CalculateSize(PhantomBattleCardSkillRequest._repeated_selectFighterUId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060111FC RID: 70140 RVA: 0x002822C8 File Offset: 0x002804C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardSkillRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060111FD RID: 70141 RVA: 0x00282315 File Offset: 0x00280515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111FE RID: 70142 RVA: 0x00282320 File Offset: 0x00280520
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
				if (num != 80U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleCardSkillRequest._repeated_selectFighterUId_codec);
					}
				}
				else
				{
					this.CardUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006CC6 RID: 27846
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CC7 RID: 27847
		public const int CardUIdFieldNumber = 10;

		// Token: 0x04006CC8 RID: 27848
		private int cardUId_;

		// Token: 0x04006CC9 RID: 27849
		public const int SelectFighterUIdFieldNumber = 12;

		// Token: 0x04006CCA RID: 27850
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04006CCB RID: 27851
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();
	}
}
