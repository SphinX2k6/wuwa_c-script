using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A01 RID: 2561
	public sealed class MonsterInfoPreview : IMessage<MonsterInfoPreview>, IMessage, IEquatable<MonsterInfoPreview>, IDeepCloneable<MonsterInfoPreview>, IBufferMessage
	{
		// Token: 0x0600E020 RID: 57376 RVA: 0x0020D7EA File Offset: 0x0020B9EA
		[NullableContext(1)]
		public static MonsterInfoPreview Create()
		{
			return new MonsterInfoPreview();
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x0600E021 RID: 57377 RVA: 0x0020D7F1 File Offset: 0x0020B9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterInfoPreview> Parser
		{
			get
			{
				return MonsterInfoPreview._parser;
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600E022 RID: 57378 RVA: 0x0020D7F8 File Offset: 0x0020B9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0600E023 RID: 57379 RVA: 0x0020D7FB File Offset: 0x0020B9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterInfoPreview.Descriptor;
			}
		}

		// Token: 0x0600E024 RID: 57380 RVA: 0x0020D802 File Offset: 0x0020BA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfoPreview()
		{
		}

		// Token: 0x0600E025 RID: 57381 RVA: 0x0020D80C File Offset: 0x0020BA0C
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

		// Token: 0x0600E026 RID: 57382 RVA: 0x0020D86C File Offset: 0x0020BA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfoPreview Clone()
		{
			return new MonsterInfoPreview(this);
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0600E027 RID: 57383 RVA: 0x0020D874 File Offset: 0x0020BA74
		// (set) Token: 0x0600E028 RID: 57384 RVA: 0x0020D87C File Offset: 0x0020BA7C
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

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0600E029 RID: 57385 RVA: 0x0020D885 File Offset: 0x0020BA85
		// (set) Token: 0x0600E02A RID: 57386 RVA: 0x0020D88D File Offset: 0x0020BA8D
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

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0600E02B RID: 57387 RVA: 0x0020D896 File Offset: 0x0020BA96
		// (set) Token: 0x0600E02C RID: 57388 RVA: 0x0020D89E File Offset: 0x0020BA9E
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

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0600E02D RID: 57389 RVA: 0x0020D8A7 File Offset: 0x0020BAA7
		// (set) Token: 0x0600E02E RID: 57390 RVA: 0x0020D8AF File Offset: 0x0020BAAF
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

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0600E02F RID: 57391 RVA: 0x0020D8B8 File Offset: 0x0020BAB8
		// (set) Token: 0x0600E030 RID: 57392 RVA: 0x0020D8C0 File Offset: 0x0020BAC0
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

		// Token: 0x0600E031 RID: 57393 RVA: 0x0020D8C9 File Offset: 0x0020BAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterInfoPreview);
		}

		// Token: 0x0600E032 RID: 57394 RVA: 0x0020D8D8 File Offset: 0x0020BAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterInfoPreview other)
		{
			return other != null && (other == this || (this.WaveConfigId == other.WaveConfigId && this.HpPpb == other.HpPpb && this.Damage == other.Damage && this.Round == other.Round && this.IsDead == other.IsDead && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E033 RID: 57395 RVA: 0x0020D954 File Offset: 0x0020BB54
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

		// Token: 0x0600E034 RID: 57396 RVA: 0x0020D9F7 File Offset: 0x0020BBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E035 RID: 57397 RVA: 0x0020DA04 File Offset: 0x0020BC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E036 RID: 57398 RVA: 0x0020DA10 File Offset: 0x0020BC10
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

		// Token: 0x0600E037 RID: 57399 RVA: 0x0020DABC File Offset: 0x0020BCBC
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

		// Token: 0x0600E038 RID: 57400 RVA: 0x0020DB50 File Offset: 0x0020BD50
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

		// Token: 0x0600E039 RID: 57401 RVA: 0x0020DBDC File Offset: 0x0020BDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E03A RID: 57402 RVA: 0x0020DBE8 File Offset: 0x0020BDE8
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

		// Token: 0x04005C4A RID: 23626
		private static readonly MessageParser<MonsterInfoPreview> _parser = new MessageParser<MonsterInfoPreview>(() => new MonsterInfoPreview());

		// Token: 0x04005C4B RID: 23627
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C4C RID: 23628
		public const int WaveConfigIdFieldNumber = 1;

		// Token: 0x04005C4D RID: 23629
		private int waveConfigId_;

		// Token: 0x04005C4E RID: 23630
		public const int HpPpbFieldNumber = 2;

		// Token: 0x04005C4F RID: 23631
		private int hpPpb_;

		// Token: 0x04005C50 RID: 23632
		public const int DamageFieldNumber = 3;

		// Token: 0x04005C51 RID: 23633
		private long damage_;

		// Token: 0x04005C52 RID: 23634
		public const int RoundFieldNumber = 4;

		// Token: 0x04005C53 RID: 23635
		private int round_;

		// Token: 0x04005C54 RID: 23636
		public const int IsDeadFieldNumber = 5;

		// Token: 0x04005C55 RID: 23637
		private bool isDead_;
	}
}
