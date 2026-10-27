using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B51 RID: 2897
	public sealed class NewTowerTeamRecordPb : IMessage<NewTowerTeamRecordPb>, IMessage, IEquatable<NewTowerTeamRecordPb>, IDeepCloneable<NewTowerTeamRecordPb>, IBufferMessage
	{
		// Token: 0x0600FB2D RID: 64301 RVA: 0x002499B5 File Offset: 0x00247BB5
		[NullableContext(1)]
		public static NewTowerTeamRecordPb Create()
		{
			return new NewTowerTeamRecordPb();
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600FB2E RID: 64302 RVA: 0x002499BC File Offset: 0x00247BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerTeamRecordPb> Parser
		{
			get
			{
				return NewTowerTeamRecordPb._parser;
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600FB2F RID: 64303 RVA: 0x002499C3 File Offset: 0x00247BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600FB30 RID: 64304 RVA: 0x002499C6 File Offset: 0x00247BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerTeamRecordPb.Descriptor;
			}
		}

		// Token: 0x0600FB31 RID: 64305 RVA: 0x002499CD File Offset: 0x00247BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTeamRecordPb()
		{
		}

		// Token: 0x0600FB32 RID: 64306 RVA: 0x002499EC File Offset: 0x00247BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTeamRecordPb(NewTowerTeamRecordPb other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this.buffs_ = other.buffs_.Clone();
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB33 RID: 64307 RVA: 0x00249A3E File Offset: 0x00247C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerTeamRecordPb Clone()
		{
			return new NewTowerTeamRecordPb(this);
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600FB34 RID: 64308 RVA: 0x00249A46 File Offset: 0x00247C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600FB35 RID: 64309 RVA: 0x00249A4E File Offset: 0x00247C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600FB36 RID: 64310 RVA: 0x00249A56 File Offset: 0x00247C56
		// (set) Token: 0x0600FB37 RID: 64311 RVA: 0x00249A5E File Offset: 0x00247C5E
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

		// Token: 0x0600FB38 RID: 64312 RVA: 0x00249A67 File Offset: 0x00247C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerTeamRecordPb);
		}

		// Token: 0x0600FB39 RID: 64313 RVA: 0x00249A78 File Offset: 0x00247C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerTeamRecordPb other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && this.buffs_.Equals(other.buffs_) && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB3A RID: 64314 RVA: 0x00249ADC File Offset: 0x00247CDC
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

		// Token: 0x0600FB3B RID: 64315 RVA: 0x00249B37 File Offset: 0x00247D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB3C RID: 64316 RVA: 0x00249B44 File Offset: 0x00247D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB3D RID: 64317 RVA: 0x00249B50 File Offset: 0x00247D50
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

		// Token: 0x0600FB3E RID: 64318 RVA: 0x00249BB0 File Offset: 0x00247DB0
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

		// Token: 0x0600FB3F RID: 64319 RVA: 0x00249C14 File Offset: 0x00247E14
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

		// Token: 0x0600FB40 RID: 64320 RVA: 0x00249C72 File Offset: 0x00247E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB41 RID: 64321 RVA: 0x00249C7C File Offset: 0x00247E7C
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

		// Token: 0x04006470 RID: 25712
		private static readonly MessageParser<NewTowerTeamRecordPb> _parser = new MessageParser<NewTowerTeamRecordPb>(() => new NewTowerTeamRecordPb());

		// Token: 0x04006471 RID: 25713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006472 RID: 25714
		public const int RolesFieldNumber = 1;

		// Token: 0x04006473 RID: 25715
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006474 RID: 25716
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x04006475 RID: 25717
		public const int BuffsFieldNumber = 2;

		// Token: 0x04006476 RID: 25718
		private static readonly FieldCodec<int> _repeated_buffs_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006477 RID: 25719
		private readonly RepeatedField<int> buffs_ = new RepeatedField<int>();

		// Token: 0x04006478 RID: 25720
		public const int ScoreFieldNumber = 3;

		// Token: 0x04006479 RID: 25721
		private int score_;
	}
}
