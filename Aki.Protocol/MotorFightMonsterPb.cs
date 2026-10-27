using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4B RID: 2635
	public sealed class MotorFightMonsterPb : IMessage<MotorFightMonsterPb>, IMessage, IEquatable<MotorFightMonsterPb>, IDeepCloneable<MotorFightMonsterPb>, IBufferMessage
	{
		// Token: 0x0600E5FD RID: 58877 RVA: 0x00219D69 File Offset: 0x00217F69
		[NullableContext(1)]
		public static MotorFightMonsterPb Create()
		{
			return new MotorFightMonsterPb();
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x00219D70 File Offset: 0x00217F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightMonsterPb> Parser
		{
			get
			{
				return MotorFightMonsterPb._parser;
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x00219D77 File Offset: 0x00217F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0600E600 RID: 58880 RVA: 0x00219D7A File Offset: 0x00217F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightMonsterPb.Descriptor;
			}
		}

		// Token: 0x0600E601 RID: 58881 RVA: 0x00219D81 File Offset: 0x00217F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterPb()
		{
		}

		// Token: 0x0600E602 RID: 58882 RVA: 0x00219D89 File Offset: 0x00217F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterPb(MotorFightMonsterPb other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E603 RID: 58883 RVA: 0x00219DBA File Offset: 0x00217FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterPb Clone()
		{
			return new MotorFightMonsterPb(this);
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0600E604 RID: 58884 RVA: 0x00219DC2 File Offset: 0x00217FC2
		// (set) Token: 0x0600E605 RID: 58885 RVA: 0x00219DCA File Offset: 0x00217FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0600E606 RID: 58886 RVA: 0x00219DD3 File Offset: 0x00217FD3
		// (set) Token: 0x0600E607 RID: 58887 RVA: 0x00219DDB File Offset: 0x00217FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x0600E608 RID: 58888 RVA: 0x00219DE4 File Offset: 0x00217FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightMonsterPb);
		}

		// Token: 0x0600E609 RID: 58889 RVA: 0x00219DF2 File Offset: 0x00217FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightMonsterPb other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E60A RID: 58890 RVA: 0x00219E30 File Offset: 0x00218030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E60B RID: 58891 RVA: 0x00219E88 File Offset: 0x00218088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E60C RID: 58892 RVA: 0x00219E95 File Offset: 0x00218095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E60D RID: 58893 RVA: 0x00219EA0 File Offset: 0x002180A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MonsterId);
			}
			if (this.WaveId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E60E RID: 58894 RVA: 0x00219EF8 File Offset: 0x002180F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E60F RID: 58895 RVA: 0x00219F50 File Offset: 0x00218150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightMonsterPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E610 RID: 58896 RVA: 0x00219FA0 File Offset: 0x002181A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E611 RID: 58897 RVA: 0x00219FAC File Offset: 0x002181AC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WaveId = input.ReadInt32();
					}
				}
				else
				{
					this.MonsterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005DE8 RID: 24040
		private static readonly MessageParser<MotorFightMonsterPb> _parser = new MessageParser<MotorFightMonsterPb>(() => new MotorFightMonsterPb());

		// Token: 0x04005DE9 RID: 24041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DEA RID: 24042
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04005DEB RID: 24043
		private int monsterId_;

		// Token: 0x04005DEC RID: 24044
		public const int WaveIdFieldNumber = 2;

		// Token: 0x04005DED RID: 24045
		private int waveId_;
	}
}
