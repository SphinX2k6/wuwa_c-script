using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B40 RID: 2880
	public sealed class NewTowerTeamRecordPb : IMessage<NewTowerTeamRecordPb>, IMessage, IEquatable<NewTowerTeamRecordPb>, IDeepCloneable<NewTowerTeamRecordPb>, IBufferMessage
	{
		// Token: 0x0600FA13 RID: 64019 RVA: 0x002477A1 File Offset: 0x002459A1
		[NullableContext(1)]
		public static NewTowerTeamRecordPb Create()
		{
			return new NewTowerTeamRecordPb();
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600FA14 RID: 64020 RVA: 0x002477A8 File Offset: 0x002459A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerTeamRecordPb> Parser
		{
			get
			{
				return NewTowerTeamRecordPb._parser;
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600FA15 RID: 64021 RVA: 0x002477AF File Offset: 0x002459AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600FA16 RID: 64022 RVA: 0x002477B2 File Offset: 0x002459B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerTeamRecordPb.Descriptor;
			}
		}

		// Token: 0x0600FA17 RID: 64023 RVA: 0x002477B9 File Offset: 0x002459B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTeamRecordPb()
		{
		}

		// Token: 0x0600FA18 RID: 64024 RVA: 0x002477D8 File Offset: 0x002459D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTeamRecordPb(NewTowerTeamRecordPb other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this.buffs_ = other.buffs_.Clone();
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA19 RID: 64025 RVA: 0x0024782A File Offset: 0x00245A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTeamRecordPb Clone()
		{
			return new NewTowerTeamRecordPb(this);
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600FA1A RID: 64026 RVA: 0x00247832 File Offset: 0x00245A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600FA1B RID: 64027 RVA: 0x0024783A File Offset: 0x00245A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600FA1C RID: 64028 RVA: 0x00247842 File Offset: 0x00245A42
		// (set) Token: 0x0600FA1D RID: 64029 RVA: 0x0024784A File Offset: 0x00245A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0600FA1E RID: 64030 RVA: 0x00247853 File Offset: 0x00245A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerTeamRecordPb);
		}

		// Token: 0x0600FA1F RID: 64031 RVA: 0x00247864 File Offset: 0x00245A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerTeamRecordPb other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && this.buffs_.Equals(other.buffs_) && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA20 RID: 64032 RVA: 0x002478C8 File Offset: 0x00245AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roles_.GetHashCode();
			num ^= this.buffs_.GetHashCode();
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA21 RID: 64033 RVA: 0x00247923 File Offset: 0x00245B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA22 RID: 64034 RVA: 0x00247930 File Offset: 0x00245B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA23 RID: 64035 RVA: 0x0024793C File Offset: 0x00245B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roles_.WriteTo(ref output, NewTowerTeamRecordPb._repeated_roles_codec);
			this.buffs_.WriteTo(ref output, NewTowerTeamRecordPb._repeated_buffs_codec);
			if (this.Score != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA24 RID: 64036 RVA: 0x0024799C File Offset: 0x00245B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roles_.CalculateSize(NewTowerTeamRecordPb._repeated_roles_codec);
			num += this.buffs_.CalculateSize(NewTowerTeamRecordPb._repeated_buffs_codec);
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA25 RID: 64037 RVA: 0x00247A00 File Offset: 0x00245C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerTeamRecordPb other)
		{
			if (other == null)
			{
				return;
			}
			this.roles_.Add(other.roles_);
			this.buffs_.Add(other.buffs_);
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA26 RID: 64038 RVA: 0x00247A5E File Offset: 0x00245C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA27 RID: 64039 RVA: 0x00247A68 File Offset: 0x00245C68
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.roles_.AddEntriesFrom(ref input, NewTowerTeamRecordPb._repeated_roles_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U || num == 18U)
					{
						this.buffs_.AddEntriesFrom(ref input, NewTowerTeamRecordPb._repeated_buffs_codec);
						continue;
					}
					if (num == 24U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006479 RID: 25721
		private static readonly MessageParser<NewTowerTeamRecordPb> _parser = new MessageParser<NewTowerTeamRecordPb>(() => new NewTowerTeamRecordPb());

		// Token: 0x0400647A RID: 25722
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400647B RID: 25723
		public const int RolesFieldNumber = 1;

		// Token: 0x0400647C RID: 25724
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400647D RID: 25725
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x0400647E RID: 25726
		public const int BuffsFieldNumber = 2;

		// Token: 0x0400647F RID: 25727
		private static readonly FieldCodec<int> _repeated_buffs_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006480 RID: 25728
		private readonly RepeatedField<int> buffs_ = new RepeatedField<int>();

		// Token: 0x04006481 RID: 25729
		public const int ScoreFieldNumber = 3;

		// Token: 0x04006482 RID: 25730
		private int score_;
	}
}
