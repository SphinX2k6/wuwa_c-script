using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031B RID: 795
	public sealed class CrystalMonsterSlotInfo : IMessage<CrystalMonsterSlotInfo>, IMessage, IEquatable<CrystalMonsterSlotInfo>, IDeepCloneable<CrystalMonsterSlotInfo>, IBufferMessage
	{
		// Token: 0x06005020 RID: 20512 RVA: 0x000C3773 File Offset: 0x000C1973
		[NullableContext(1)]
		public static CrystalMonsterSlotInfo Create()
		{
			return new CrystalMonsterSlotInfo();
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x000C377A File Offset: 0x000C197A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CrystalMonsterSlotInfo> Parser
		{
			get
			{
				return CrystalMonsterSlotInfo._parser;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x000C3781 File Offset: 0x000C1981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x000C3784 File Offset: 0x000C1984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CrystalMonsterSlotInfo.Descriptor;
			}
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x000C378B File Offset: 0x000C198B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterSlotInfo()
		{
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x000C379E File Offset: 0x000C199E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterSlotInfo(CrystalMonsterSlotInfo other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this.monsterType_ = other.monsterType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x000C37D4 File Offset: 0x000C19D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterSlotInfo Clone()
		{
			return new CrystalMonsterSlotInfo(this);
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06005027 RID: 20519 RVA: 0x000C37DC File Offset: 0x000C19DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x000C37E4 File Offset: 0x000C19E4
		// (set) Token: 0x06005029 RID: 20521 RVA: 0x000C37EC File Offset: 0x000C19EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterType
		{
			get
			{
				return this.monsterType_;
			}
			set
			{
				this.monsterType_ = value;
			}
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x000C37F5 File Offset: 0x000C19F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CrystalMonsterSlotInfo);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x000C3804 File Offset: 0x000C1A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CrystalMonsterSlotInfo other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && this.MonsterType == other.MonsterType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x000C3854 File Offset: 0x000C1A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this.MonsterType != 0)
			{
				num ^= this.MonsterType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x000C38A1 File Offset: 0x000C1AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x000C38AE File Offset: 0x000C1AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x000C38B8 File Offset: 0x000C1AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, CrystalMonsterSlotInfo._repeated_entityIds_codec);
			if (this.MonsterType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MonsterType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x000C3908 File Offset: 0x000C1B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(CrystalMonsterSlotInfo._repeated_entityIds_codec);
			if (this.MonsterType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x000C395C File Offset: 0x000C1B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CrystalMonsterSlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			if (other.MonsterType != 0)
			{
				this.MonsterType = other.MonsterType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x000C39A9 File Offset: 0x000C1BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x000C39B4 File Offset: 0x000C1BB4
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
				if (num != 8U && num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MonsterType = input.ReadInt32();
					}
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, CrystalMonsterSlotInfo._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x0400324D RID: 12877
		private static readonly MessageParser<CrystalMonsterSlotInfo> _parser = new MessageParser<CrystalMonsterSlotInfo>(() => new CrystalMonsterSlotInfo());

		// Token: 0x0400324E RID: 12878
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400324F RID: 12879
		public const int EntityIdsFieldNumber = 1;

		// Token: 0x04003250 RID: 12880
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003251 RID: 12881
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();

		// Token: 0x04003252 RID: 12882
		public const int MonsterTypeFieldNumber = 2;

		// Token: 0x04003253 RID: 12883
		private int monsterType_;
	}
}
