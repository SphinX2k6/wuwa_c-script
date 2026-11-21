using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D4 RID: 1492
	public sealed class FloroRanchSubInsRecord : IMessage<FloroRanchSubInsRecord>, IMessage, IEquatable<FloroRanchSubInsRecord>, IDeepCloneable<FloroRanchSubInsRecord>, IBufferMessage
	{
		// Token: 0x06008A98 RID: 35480 RVA: 0x0015000A File Offset: 0x0014E20A
		[NullableContext(1)]
		public static FloroRanchSubInsRecord Create()
		{
			return new FloroRanchSubInsRecord();
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06008A99 RID: 35481 RVA: 0x00150011 File Offset: 0x0014E211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchSubInsRecord> Parser
		{
			get
			{
				return FloroRanchSubInsRecord._parser;
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06008A9A RID: 35482 RVA: 0x00150018 File Offset: 0x0014E218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06008A9B RID: 35483 RVA: 0x0015001B File Offset: 0x0014E21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSubInsRecord.Descriptor;
			}
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x00150022 File Offset: 0x0014E222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsRecord()
		{
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x0015002A File Offset: 0x0014E22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsRecord(FloroRanchSubInsRecord other) : this()
		{
			this.subInsId_ = other.subInsId_;
			this.maxDay_ = other.maxDay_;
			this.maxCoin_ = other.maxCoin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x00150067 File Offset: 0x0014E267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsRecord Clone()
		{
			return new FloroRanchSubInsRecord(this);
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06008A9F RID: 35487 RVA: 0x0015006F File Offset: 0x0014E26F
		// (set) Token: 0x06008AA0 RID: 35488 RVA: 0x00150077 File Offset: 0x0014E277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06008AA1 RID: 35489 RVA: 0x00150080 File Offset: 0x0014E280
		// (set) Token: 0x06008AA2 RID: 35490 RVA: 0x00150088 File Offset: 0x0014E288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxDay
		{
			get
			{
				return this.maxDay_;
			}
			set
			{
				this.maxDay_ = value;
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06008AA3 RID: 35491 RVA: 0x00150091 File Offset: 0x0014E291
		// (set) Token: 0x06008AA4 RID: 35492 RVA: 0x00150099 File Offset: 0x0014E299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MaxCoin
		{
			get
			{
				return this.maxCoin_;
			}
			set
			{
				this.maxCoin_ = value;
			}
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x001500A2 File Offset: 0x0014E2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSubInsRecord);
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x001500B0 File Offset: 0x0014E2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSubInsRecord other)
		{
			return other != null && (other == this || (this.SubInsId == other.SubInsId && this.MaxDay == other.MaxDay && this.MaxCoin == other.MaxCoin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x0015010C File Offset: 0x0014E30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.MaxDay != 0)
			{
				num ^= this.MaxDay.GetHashCode();
			}
			if (this.MaxCoin != 0L)
			{
				num ^= this.MaxCoin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x0015017D File Offset: 0x0014E37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x0015018A File Offset: 0x0014E38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x00150194 File Offset: 0x0014E394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			if (this.MaxDay != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxDay);
			}
			if (this.MaxCoin != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.MaxCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x00150208 File Offset: 0x0014E408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.MaxDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxDay);
			}
			if (this.MaxCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MaxCoin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x00150278 File Offset: 0x0014E478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSubInsRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.MaxDay != 0)
			{
				this.MaxDay = other.MaxDay;
			}
			if (other.MaxCoin != 0L)
			{
				this.MaxCoin = other.MaxCoin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x001502DC File Offset: 0x0014E4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x001502E8 File Offset: 0x0014E4E8
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MaxCoin = input.ReadInt64();
						}
					}
					else
					{
						this.MaxDay = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400448F RID: 17551
		private static readonly MessageParser<FloroRanchSubInsRecord> _parser = new MessageParser<FloroRanchSubInsRecord>(() => new FloroRanchSubInsRecord());

		// Token: 0x04004490 RID: 17552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004491 RID: 17553
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x04004492 RID: 17554
		private int subInsId_;

		// Token: 0x04004493 RID: 17555
		public const int MaxDayFieldNumber = 2;

		// Token: 0x04004494 RID: 17556
		private int maxDay_;

		// Token: 0x04004495 RID: 17557
		public const int MaxCoinFieldNumber = 3;

		// Token: 0x04004496 RID: 17558
		private long maxCoin_;
	}
}
