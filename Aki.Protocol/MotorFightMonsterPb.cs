using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3A RID: 2618
	public sealed class MotorFightMonsterPb : IMessage<MotorFightMonsterPb>, IMessage, IEquatable<MotorFightMonsterPb>, IDeepCloneable<MotorFightMonsterPb>, IBufferMessage
	{
		// Token: 0x0600E4E3 RID: 58595 RVA: 0x00217B75 File Offset: 0x00215D75
		[NullableContext(1)]
		public static MotorFightMonsterPb Create()
		{
			return new MotorFightMonsterPb();
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x00217B7C File Offset: 0x00215D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightMonsterPb> Parser
		{
			get
			{
				return MotorFightMonsterPb._parser;
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0600E4E5 RID: 58597 RVA: 0x00217B83 File Offset: 0x00215D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0600E4E6 RID: 58598 RVA: 0x00217B86 File Offset: 0x00215D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightMonsterPb.Descriptor;
			}
		}

		// Token: 0x0600E4E7 RID: 58599 RVA: 0x00217B8D File Offset: 0x00215D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterPb()
		{
		}

		// Token: 0x0600E4E8 RID: 58600 RVA: 0x00217B95 File Offset: 0x00215D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterPb(MotorFightMonsterPb other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4E9 RID: 58601 RVA: 0x00217BC6 File Offset: 0x00215DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightMonsterPb Clone()
		{
			return new MotorFightMonsterPb(this);
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0600E4EA RID: 58602 RVA: 0x00217BCE File Offset: 0x00215DCE
		// (set) Token: 0x0600E4EB RID: 58603 RVA: 0x00217BD6 File Offset: 0x00215DD6
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

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600E4EC RID: 58604 RVA: 0x00217BDF File Offset: 0x00215DDF
		// (set) Token: 0x0600E4ED RID: 58605 RVA: 0x00217BE7 File Offset: 0x00215DE7
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

		// Token: 0x0600E4EE RID: 58606 RVA: 0x00217BF0 File Offset: 0x00215DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightMonsterPb);
		}

		// Token: 0x0600E4EF RID: 58607 RVA: 0x00217BFE File Offset: 0x00215DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightMonsterPb other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4F0 RID: 58608 RVA: 0x00217C3C File Offset: 0x00215E3C
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

		// Token: 0x0600E4F1 RID: 58609 RVA: 0x00217C94 File Offset: 0x00215E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4F2 RID: 58610 RVA: 0x00217CA1 File Offset: 0x00215EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4F3 RID: 58611 RVA: 0x00217CAC File Offset: 0x00215EAC
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

		// Token: 0x0600E4F4 RID: 58612 RVA: 0x00217D04 File Offset: 0x00215F04
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

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00217D5C File Offset: 0x00215F5C
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

		// Token: 0x0600E4F6 RID: 58614 RVA: 0x00217DAC File Offset: 0x00215FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4F7 RID: 58615 RVA: 0x00217DB8 File Offset: 0x00215FB8
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

		// Token: 0x04005DF1 RID: 24049
		private static readonly MessageParser<MotorFightMonsterPb> _parser = new MessageParser<MotorFightMonsterPb>(() => new MotorFightMonsterPb());

		// Token: 0x04005DF2 RID: 24050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DF3 RID: 24051
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04005DF4 RID: 24052
		private int monsterId_;

		// Token: 0x04005DF5 RID: 24053
		public const int WaveIdFieldNumber = 2;

		// Token: 0x04005DF6 RID: 24054
		private int waveId_;
	}
}
