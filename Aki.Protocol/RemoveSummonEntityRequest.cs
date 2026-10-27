using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0A RID: 3850
	[NetMessage(EMessageId.RemoveSummonEntityRequest)]
	public sealed class RemoveSummonEntityRequest : IMessage<RemoveSummonEntityRequest>, IMessage, IEquatable<RemoveSummonEntityRequest>, IDeepCloneable<RemoveSummonEntityRequest>, IBufferMessage
	{
		// Token: 0x060149E2 RID: 84450 RVA: 0x002FE6B5 File Offset: 0x002FC8B5
		[NullableContext(1)]
		public static RemoveSummonEntityRequest Create()
		{
			return new RemoveSummonEntityRequest();
		}

		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x060149E3 RID: 84451 RVA: 0x002FE6BC File Offset: 0x002FC8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x060149E4 RID: 84452 RVA: 0x002FE6BF File Offset: 0x002FC8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveSummonEntityRequest.Descriptor;
			}
		}

		// Token: 0x060149E5 RID: 84453 RVA: 0x002FE6C6 File Offset: 0x002FC8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityRequest()
		{
		}

		// Token: 0x060149E6 RID: 84454 RVA: 0x002FE6DC File Offset: 0x002FC8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityRequest(RemoveSummonEntityRequest other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.skillId_ = other.skillId_;
			this.removeType_ = other.removeType_;
			this.removeEntityIds_ = other.removeEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149E7 RID: 84455 RVA: 0x002FE735 File Offset: 0x002FC935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityRequest Clone()
		{
			return new RemoveSummonEntityRequest(this);
		}

		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x060149E8 RID: 84456 RVA: 0x002FE73D File Offset: 0x002FC93D
		// (set) Token: 0x060149E9 RID: 84457 RVA: 0x002FE745 File Offset: 0x002FC945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerId
		{
			get
			{
				return this.summonerId_;
			}
			set
			{
				this.summonerId_ = value;
			}
		}

		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x060149EA RID: 84458 RVA: 0x002FE74E File Offset: 0x002FC94E
		// (set) Token: 0x060149EB RID: 84459 RVA: 0x002FE756 File Offset: 0x002FC956
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

		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x060149EC RID: 84460 RVA: 0x002FE75F File Offset: 0x002FC95F
		// (set) Token: 0x060149ED RID: 84461 RVA: 0x002FE767 File Offset: 0x002FC967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ERemoveEntityType RemoveType
		{
			get
			{
				return this.removeType_;
			}
			set
			{
				this.removeType_ = value;
			}
		}

		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x060149EE RID: 84462 RVA: 0x002FE770 File Offset: 0x002FC970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> RemoveEntityIds
		{
			get
			{
				return this.removeEntityIds_;
			}
		}

		// Token: 0x060149EF RID: 84463 RVA: 0x002FE778 File Offset: 0x002FC978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveSummonEntityRequest);
		}

		// Token: 0x060149F0 RID: 84464 RVA: 0x002FE788 File Offset: 0x002FC988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveSummonEntityRequest other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.SkillId == other.SkillId && this.RemoveType == other.RemoveType && this.removeEntityIds_.Equals(other.removeEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149F1 RID: 84465 RVA: 0x002FE7F8 File Offset: 0x002FC9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonerId != 0L)
			{
				num ^= this.SummonerId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				num ^= this.RemoveType.GetHashCode();
			}
			num ^= this.removeEntityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060149F2 RID: 84466 RVA: 0x002FE87D File Offset: 0x002FCA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149F3 RID: 84467 RVA: 0x002FE88A File Offset: 0x002FCA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149F4 RID: 84468 RVA: 0x002FE894 File Offset: 0x002FCA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.RemoveType);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkillId);
			}
			this.removeEntityIds_.WriteTo(ref output, RemoveSummonEntityRequest._repeated_removeEntityIds_codec);
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.SummonerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060149F5 RID: 84469 RVA: 0x002FE91C File Offset: 0x002FCB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RemoveType);
			}
			num += this.removeEntityIds_.CalculateSize(RemoveSummonEntityRequest._repeated_removeEntityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060149F6 RID: 84470 RVA: 0x002FE9A0 File Offset: 0x002FCBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveSummonEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonerId != 0L)
			{
				this.SummonerId = other.SummonerId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				this.RemoveType = other.RemoveType;
			}
			this.removeEntityIds_.Add(other.removeEntityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060149F7 RID: 84471 RVA: 0x002FEA15 File Offset: 0x002FCC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149F8 RID: 84472 RVA: 0x002FEA20 File Offset: 0x002FCC20
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
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.RemoveType = (ERemoveEntityType)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.removeEntityIds_.AddEntriesFrom(ref input, RemoveSummonEntityRequest._repeated_removeEntityIds_codec);
						continue;
					}
					if (num == 112U)
					{
						this.SummonerId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007CCA RID: 31946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CCB RID: 31947
		public const int SummonerIdFieldNumber = 14;

		// Token: 0x04007CCC RID: 31948
		private long summonerId_;

		// Token: 0x04007CCD RID: 31949
		public const int SkillIdFieldNumber = 8;

		// Token: 0x04007CCE RID: 31950
		private int skillId_;

		// Token: 0x04007CCF RID: 31951
		public const int RemoveTypeFieldNumber = 1;

		// Token: 0x04007CD0 RID: 31952
		private ERemoveEntityType removeType_;

		// Token: 0x04007CD1 RID: 31953
		public const int RemoveEntityIdsFieldNumber = 9;

		// Token: 0x04007CD2 RID: 31954
		private static readonly FieldCodec<long> _repeated_removeEntityIds_codec = FieldCodec.ForInt64(74U);

		// Token: 0x04007CD3 RID: 31955
		private readonly RepeatedField<long> removeEntityIds_ = new RepeatedField<long>();
	}
}
