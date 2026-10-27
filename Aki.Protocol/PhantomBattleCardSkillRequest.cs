using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C62 RID: 3170
	[NetMessage(EMessageId.PhantomBattleCardSkillRequest)]
	public sealed class PhantomBattleCardSkillRequest : IMessage<PhantomBattleCardSkillRequest>, IMessage, IEquatable<PhantomBattleCardSkillRequest>, IDeepCloneable<PhantomBattleCardSkillRequest>, IBufferMessage
	{
		// Token: 0x060112EC RID: 70380 RVA: 0x00283E53 File Offset: 0x00282053
		[NullableContext(1)]
		public static PhantomBattleCardSkillRequest Create()
		{
			return new PhantomBattleCardSkillRequest();
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x060112ED RID: 70381 RVA: 0x00283E5A File Offset: 0x0028205A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x060112EE RID: 70382 RVA: 0x00283E5D File Offset: 0x0028205D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardSkillRequest.Descriptor;
			}
		}

		// Token: 0x060112EF RID: 70383 RVA: 0x00283E64 File Offset: 0x00282064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillRequest()
		{
		}

		// Token: 0x060112F0 RID: 70384 RVA: 0x00283E77 File Offset: 0x00282077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillRequest(PhantomBattleCardSkillRequest other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112F1 RID: 70385 RVA: 0x00283EAD File Offset: 0x002820AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillRequest Clone()
		{
			return new PhantomBattleCardSkillRequest(this);
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x060112F2 RID: 70386 RVA: 0x00283EB5 File Offset: 0x002820B5
		// (set) Token: 0x060112F3 RID: 70387 RVA: 0x00283EBD File Offset: 0x002820BD
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

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x060112F4 RID: 70388 RVA: 0x00283EC6 File Offset: 0x002820C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x060112F5 RID: 70389 RVA: 0x00283ECE File Offset: 0x002820CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardSkillRequest);
		}

		// Token: 0x060112F6 RID: 70390 RVA: 0x00283EDC File Offset: 0x002820DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardSkillRequest other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112F7 RID: 70391 RVA: 0x00283F2C File Offset: 0x0028212C
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

		// Token: 0x060112F8 RID: 70392 RVA: 0x00283F79 File Offset: 0x00282179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112F9 RID: 70393 RVA: 0x00283F86 File Offset: 0x00282186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112FA RID: 70394 RVA: 0x00283F90 File Offset: 0x00282190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectFighterUId_.WriteTo(ref output, PhantomBattleCardSkillRequest._repeated_selectFighterUId_codec);
			if (this.CardUId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CardUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060112FB RID: 70395 RVA: 0x00283FE0 File Offset: 0x002821E0
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

		// Token: 0x060112FC RID: 70396 RVA: 0x00284034 File Offset: 0x00282234
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

		// Token: 0x060112FD RID: 70397 RVA: 0x00284081 File Offset: 0x00282281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112FE RID: 70398 RVA: 0x0028408C File Offset: 0x0028228C
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
						this.CardUId = input.ReadInt32();
					}
				}
				else
				{
					this.selectFighterUId_.AddEntriesFrom(ref input, PhantomBattleCardSkillRequest._repeated_selectFighterUId_codec);
				}
			}
		}

		// Token: 0x04006CB2 RID: 27826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CB3 RID: 27827
		public const int CardUIdFieldNumber = 13;

		// Token: 0x04006CB4 RID: 27828
		private int cardUId_;

		// Token: 0x04006CB5 RID: 27829
		public const int SelectFighterUIdFieldNumber = 3;

		// Token: 0x04006CB6 RID: 27830
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006CB7 RID: 27831
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();
	}
}
