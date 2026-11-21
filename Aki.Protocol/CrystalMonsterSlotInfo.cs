using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000322 RID: 802
	public sealed class CrystalMonsterSlotInfo : IMessage<CrystalMonsterSlotInfo>, IMessage, IEquatable<CrystalMonsterSlotInfo>, IDeepCloneable<CrystalMonsterSlotInfo>, IBufferMessage
	{
		// Token: 0x060050F9 RID: 20729 RVA: 0x000C5B63 File Offset: 0x000C3D63
		[NullableContext(1)]
		public static CrystalMonsterSlotInfo Create()
		{
			return new CrystalMonsterSlotInfo();
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x000C5B6A File Offset: 0x000C3D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CrystalMonsterSlotInfo> Parser
		{
			get
			{
				return CrystalMonsterSlotInfo._parser;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x000C5B71 File Offset: 0x000C3D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x000C5B74 File Offset: 0x000C3D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CrystalMonsterSlotInfo.Descriptor;
			}
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x000C5B7B File Offset: 0x000C3D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterSlotInfo()
		{
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x000C5B8E File Offset: 0x000C3D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterSlotInfo(CrystalMonsterSlotInfo other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this.monsterType_ = other.monsterType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x000C5BC4 File Offset: 0x000C3DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CrystalMonsterSlotInfo Clone()
		{
			return new CrystalMonsterSlotInfo(this);
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x000C5BCC File Offset: 0x000C3DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x000C5BD4 File Offset: 0x000C3DD4
		// (set) Token: 0x06005102 RID: 20738 RVA: 0x000C5BDC File Offset: 0x000C3DDC
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

		// Token: 0x06005103 RID: 20739 RVA: 0x000C5BE5 File Offset: 0x000C3DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CrystalMonsterSlotInfo);
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x000C5BF4 File Offset: 0x000C3DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CrystalMonsterSlotInfo other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && this.MonsterType == other.MonsterType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x000C5C44 File Offset: 0x000C3E44
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

		// Token: 0x06005106 RID: 20742 RVA: 0x000C5C91 File Offset: 0x000C3E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x000C5C9E File Offset: 0x000C3E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x000C5CA8 File Offset: 0x000C3EA8
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

		// Token: 0x06005109 RID: 20745 RVA: 0x000C5CF8 File Offset: 0x000C3EF8
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

		// Token: 0x0600510A RID: 20746 RVA: 0x000C5D4C File Offset: 0x000C3F4C
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

		// Token: 0x0600510B RID: 20747 RVA: 0x000C5D99 File Offset: 0x000C3F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x000C5DA4 File Offset: 0x000C3FA4
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

		// Token: 0x040032E4 RID: 13028
		private static readonly MessageParser<CrystalMonsterSlotInfo> _parser = new MessageParser<CrystalMonsterSlotInfo>(() => new CrystalMonsterSlotInfo());

		// Token: 0x040032E5 RID: 13029
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032E6 RID: 13030
		public const int EntityIdsFieldNumber = 1;

		// Token: 0x040032E7 RID: 13031
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040032E8 RID: 13032
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();

		// Token: 0x040032E9 RID: 13033
		public const int MonsterTypeFieldNumber = 2;

		// Token: 0x040032EA RID: 13034
		private int monsterType_;
	}
}
