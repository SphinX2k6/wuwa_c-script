using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3B RID: 2619
	public sealed class MotorFightBuffGatePb : IMessage<MotorFightBuffGatePb>, IMessage, IEquatable<MotorFightBuffGatePb>, IDeepCloneable<MotorFightBuffGatePb>, IBufferMessage
	{
		// Token: 0x0600E4AF RID: 58543 RVA: 0x0021712B File Offset: 0x0021532B
		[NullableContext(1)]
		public static MotorFightBuffGatePb Create()
		{
			return new MotorFightBuffGatePb();
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x0600E4B0 RID: 58544 RVA: 0x00217132 File Offset: 0x00215332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightBuffGatePb> Parser
		{
			get
			{
				return MotorFightBuffGatePb._parser;
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x00217139 File Offset: 0x00215339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0600E4B2 RID: 58546 RVA: 0x0021713C File Offset: 0x0021533C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightBuffGatePb.Descriptor;
			}
		}

		// Token: 0x0600E4B3 RID: 58547 RVA: 0x00217143 File Offset: 0x00215343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBuffGatePb()
		{
		}

		// Token: 0x0600E4B4 RID: 58548 RVA: 0x0021714B File Offset: 0x0021534B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBuffGatePb(MotorFightBuffGatePb other) : this()
		{
			this.buffGateId_ = other.buffGateId_;
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4B5 RID: 58549 RVA: 0x0021717C File Offset: 0x0021537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBuffGatePb Clone()
		{
			return new MotorFightBuffGatePb(this);
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x00217184 File Offset: 0x00215384
		// (set) Token: 0x0600E4B7 RID: 58551 RVA: 0x0021718C File Offset: 0x0021538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffGateId
		{
			get
			{
				return this.buffGateId_;
			}
			set
			{
				this.buffGateId_ = value;
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600E4B8 RID: 58552 RVA: 0x00217195 File Offset: 0x00215395
		// (set) Token: 0x0600E4B9 RID: 58553 RVA: 0x0021719D File Offset: 0x0021539D
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

		// Token: 0x0600E4BA RID: 58554 RVA: 0x002171A6 File Offset: 0x002153A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightBuffGatePb);
		}

		// Token: 0x0600E4BB RID: 58555 RVA: 0x002171B4 File Offset: 0x002153B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightBuffGatePb other)
		{
			return other != null && (other == this || (this.BuffGateId == other.BuffGateId && this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4BC RID: 58556 RVA: 0x002171F4 File Offset: 0x002153F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffGateId != 0)
			{
				num ^= this.BuffGateId.GetHashCode();
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

		// Token: 0x0600E4BD RID: 58557 RVA: 0x0021724C File Offset: 0x0021544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4BE RID: 58558 RVA: 0x00217259 File Offset: 0x00215459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4BF RID: 58559 RVA: 0x00217264 File Offset: 0x00215464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffGateId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffGateId);
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

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x002172BC File Offset: 0x002154BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffGateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffGateId);
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

		// Token: 0x0600E4C1 RID: 58561 RVA: 0x00217314 File Offset: 0x00215514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightBuffGatePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffGateId != 0)
			{
				this.BuffGateId = other.BuffGateId;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4C2 RID: 58562 RVA: 0x00217364 File Offset: 0x00215564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4C3 RID: 58563 RVA: 0x00217370 File Offset: 0x00215570
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
					this.BuffGateId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D8C RID: 23948
		private static readonly MessageParser<MotorFightBuffGatePb> _parser = new MessageParser<MotorFightBuffGatePb>(() => new MotorFightBuffGatePb());

		// Token: 0x04005D8D RID: 23949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D8E RID: 23950
		public const int BuffGateIdFieldNumber = 1;

		// Token: 0x04005D8F RID: 23951
		private int buffGateId_;

		// Token: 0x04005D90 RID: 23952
		public const int WaveIdFieldNumber = 2;

		// Token: 0x04005D91 RID: 23953
		private int waveId_;
	}
}
