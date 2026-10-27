using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3A RID: 2618
	public sealed class MotorFightBossPb : IMessage<MotorFightBossPb>, IMessage, IEquatable<MotorFightBossPb>, IDeepCloneable<MotorFightBossPb>, IBufferMessage
	{
		// Token: 0x0600E499 RID: 58521 RVA: 0x00216E74 File Offset: 0x00215074
		[NullableContext(1)]
		public static MotorFightBossPb Create()
		{
			return new MotorFightBossPb();
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600E49A RID: 58522 RVA: 0x00216E7B File Offset: 0x0021507B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightBossPb> Parser
		{
			get
			{
				return MotorFightBossPb._parser;
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600E49B RID: 58523 RVA: 0x00216E82 File Offset: 0x00215082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0600E49C RID: 58524 RVA: 0x00216E85 File Offset: 0x00215085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightBossPb.Descriptor;
			}
		}

		// Token: 0x0600E49D RID: 58525 RVA: 0x00216E8C File Offset: 0x0021508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossPb()
		{
		}

		// Token: 0x0600E49E RID: 58526 RVA: 0x00216E94 File Offset: 0x00215094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossPb(MotorFightBossPb other) : this()
		{
			this.bossId_ = other.bossId_;
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E49F RID: 58527 RVA: 0x00216EC5 File Offset: 0x002150C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossPb Clone()
		{
			return new MotorFightBossPb(this);
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x00216ECD File Offset: 0x002150CD
		// (set) Token: 0x0600E4A1 RID: 58529 RVA: 0x00216ED5 File Offset: 0x002150D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossId
		{
			get
			{
				return this.bossId_;
			}
			set
			{
				this.bossId_ = value;
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600E4A2 RID: 58530 RVA: 0x00216EDE File Offset: 0x002150DE
		// (set) Token: 0x0600E4A3 RID: 58531 RVA: 0x00216EE6 File Offset: 0x002150E6
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

		// Token: 0x0600E4A4 RID: 58532 RVA: 0x00216EEF File Offset: 0x002150EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightBossPb);
		}

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x00216EFD File Offset: 0x002150FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightBossPb other)
		{
			return other != null && (other == this || (this.BossId == other.BossId && this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4A6 RID: 58534 RVA: 0x00216F3C File Offset: 0x0021513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BossId != 0)
			{
				num ^= this.BossId.GetHashCode();
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

		// Token: 0x0600E4A7 RID: 58535 RVA: 0x00216F94 File Offset: 0x00215194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4A8 RID: 58536 RVA: 0x00216FA1 File Offset: 0x002151A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4A9 RID: 58537 RVA: 0x00216FAC File Offset: 0x002151AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BossId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BossId);
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

		// Token: 0x0600E4AA RID: 58538 RVA: 0x00217004 File Offset: 0x00215204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BossId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossId);
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

		// Token: 0x0600E4AB RID: 58539 RVA: 0x0021705C File Offset: 0x0021525C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightBossPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BossId != 0)
			{
				this.BossId = other.BossId;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4AC RID: 58540 RVA: 0x002170AC File Offset: 0x002152AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4AD RID: 58541 RVA: 0x002170B8 File Offset: 0x002152B8
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
					this.BossId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D86 RID: 23942
		private static readonly MessageParser<MotorFightBossPb> _parser = new MessageParser<MotorFightBossPb>(() => new MotorFightBossPb());

		// Token: 0x04005D87 RID: 23943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D88 RID: 23944
		public const int BossIdFieldNumber = 1;

		// Token: 0x04005D89 RID: 23945
		private int bossId_;

		// Token: 0x04005D8A RID: 23946
		public const int WaveIdFieldNumber = 2;

		// Token: 0x04005D8B RID: 23947
		private int waveId_;
	}
}
