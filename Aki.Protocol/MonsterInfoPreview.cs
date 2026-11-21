using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F0 RID: 2544
	public sealed class MonsterInfoPreview : IMessage<MonsterInfoPreview>, IMessage, IEquatable<MonsterInfoPreview>, IDeepCloneable<MonsterInfoPreview>, IBufferMessage
	{
		// Token: 0x0600DF06 RID: 57094 RVA: 0x0020B5FE File Offset: 0x002097FE
		[NullableContext(1)]
		public static MonsterInfoPreview Create()
		{
			return new MonsterInfoPreview();
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0600DF07 RID: 57095 RVA: 0x0020B605 File Offset: 0x00209805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterInfoPreview> Parser
		{
			get
			{
				return MonsterInfoPreview._parser;
			}
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0600DF08 RID: 57096 RVA: 0x0020B60C File Offset: 0x0020980C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x0600DF09 RID: 57097 RVA: 0x0020B60F File Offset: 0x0020980F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterInfoPreview.Descriptor;
			}
		}

		// Token: 0x0600DF0A RID: 57098 RVA: 0x0020B616 File Offset: 0x00209816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfoPreview()
		{
		}

		// Token: 0x0600DF0B RID: 57099 RVA: 0x0020B620 File Offset: 0x00209820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfoPreview(MonsterInfoPreview other) : this()
		{
			this.waveConfigId_ = other.waveConfigId_;
			this.hpPpb_ = other.hpPpb_;
			this.damage_ = other.damage_;
			this.round_ = other.round_;
			this.isDead_ = other.isDead_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF0C RID: 57100 RVA: 0x0020B680 File Offset: 0x00209880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfoPreview Clone()
		{
			return new MonsterInfoPreview(this);
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x0600DF0D RID: 57101 RVA: 0x0020B688 File Offset: 0x00209888
		// (set) Token: 0x0600DF0E RID: 57102 RVA: 0x0020B690 File Offset: 0x00209890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveConfigId
		{
			get
			{
				return this.waveConfigId_;
			}
			set
			{
				this.waveConfigId_ = value;
			}
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0600DF0F RID: 57103 RVA: 0x0020B699 File Offset: 0x00209899
		// (set) Token: 0x0600DF10 RID: 57104 RVA: 0x0020B6A1 File Offset: 0x002098A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HpPpb
		{
			get
			{
				return this.hpPpb_;
			}
			set
			{
				this.hpPpb_ = value;
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0600DF11 RID: 57105 RVA: 0x0020B6AA File Offset: 0x002098AA
		// (set) Token: 0x0600DF12 RID: 57106 RVA: 0x0020B6B2 File Offset: 0x002098B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600DF13 RID: 57107 RVA: 0x0020B6BB File Offset: 0x002098BB
		// (set) Token: 0x0600DF14 RID: 57108 RVA: 0x0020B6C3 File Offset: 0x002098C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Round
		{
			get
			{
				return this.round_;
			}
			set
			{
				this.round_ = value;
			}
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0600DF15 RID: 57109 RVA: 0x0020B6CC File Offset: 0x002098CC
		// (set) Token: 0x0600DF16 RID: 57110 RVA: 0x0020B6D4 File Offset: 0x002098D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDead
		{
			get
			{
				return this.isDead_;
			}
			set
			{
				this.isDead_ = value;
			}
		}

		// Token: 0x0600DF17 RID: 57111 RVA: 0x0020B6DD File Offset: 0x002098DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterInfoPreview);
		}

		// Token: 0x0600DF18 RID: 57112 RVA: 0x0020B6EC File Offset: 0x002098EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterInfoPreview other)
		{
			return other != null && (other == this || (this.WaveConfigId == other.WaveConfigId && this.HpPpb == other.HpPpb && this.Damage == other.Damage && this.Round == other.Round && this.IsDead == other.IsDead && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF19 RID: 57113 RVA: 0x0020B768 File Offset: 0x00209968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveConfigId != 0)
			{
				num ^= this.WaveConfigId.GetHashCode();
			}
			if (this.HpPpb != 0)
			{
				num ^= this.HpPpb.GetHashCode();
			}
			if (this.Damage != 0L)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.Round != 0)
			{
				num ^= this.Round.GetHashCode();
			}
			if (this.IsDead)
			{
				num ^= this.IsDead.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF1A RID: 57114 RVA: 0x0020B80B File Offset: 0x00209A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF1B RID: 57115 RVA: 0x0020B818 File Offset: 0x00209A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF1C RID: 57116 RVA: 0x0020B824 File Offset: 0x00209A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WaveConfigId);
			}
			if (this.HpPpb != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HpPpb);
			}
			if (this.Damage != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Damage);
			}
			if (this.Round != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Round);
			}
			if (this.IsDead)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsDead);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF1D RID: 57117 RVA: 0x0020B8D0 File Offset: 0x00209AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveConfigId);
			}
			if (this.HpPpb != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HpPpb);
			}
			if (this.Damage != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Damage);
			}
			if (this.Round != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Round);
			}
			if (this.IsDead)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x0020B964 File Offset: 0x00209B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterInfoPreview other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveConfigId != 0)
			{
				this.WaveConfigId = other.WaveConfigId;
			}
			if (other.HpPpb != 0)
			{
				this.HpPpb = other.HpPpb;
			}
			if (other.Damage != 0L)
			{
				this.Damage = other.Damage;
			}
			if (other.Round != 0)
			{
				this.Round = other.Round;
			}
			if (other.IsDead)
			{
				this.IsDead = other.IsDead;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF1F RID: 57119 RVA: 0x0020B9F0 File Offset: 0x00209BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF20 RID: 57120 RVA: 0x0020B9FC File Offset: 0x00209BFC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.WaveConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HpPpb = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Damage = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.Round = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsDead = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005C53 RID: 23635
		private static readonly MessageParser<MonsterInfoPreview> _parser = new MessageParser<MonsterInfoPreview>(() => new MonsterInfoPreview());

		// Token: 0x04005C54 RID: 23636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C55 RID: 23637
		public const int WaveConfigIdFieldNumber = 1;

		// Token: 0x04005C56 RID: 23638
		private int waveConfigId_;

		// Token: 0x04005C57 RID: 23639
		public const int HpPpbFieldNumber = 2;

		// Token: 0x04005C58 RID: 23640
		private int hpPpb_;

		// Token: 0x04005C59 RID: 23641
		public const int DamageFieldNumber = 3;

		// Token: 0x04005C5A RID: 23642
		private long damage_;

		// Token: 0x04005C5B RID: 23643
		public const int RoundFieldNumber = 4;

		// Token: 0x04005C5C RID: 23644
		private int round_;

		// Token: 0x04005C5D RID: 23645
		public const int IsDeadFieldNumber = 5;

		// Token: 0x04005C5E RID: 23646
		private bool isDead_;
	}
}
