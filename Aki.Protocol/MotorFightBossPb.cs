using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A29 RID: 2601
	public sealed class MotorFightBossPb : IMessage<MotorFightBossPb>, IMessage, IEquatable<MotorFightBossPb>, IDeepCloneable<MotorFightBossPb>, IBufferMessage
	{
		// Token: 0x0600E37F RID: 58239 RVA: 0x00214C85 File Offset: 0x00212E85
		[NullableContext(1)]
		public static MotorFightBossPb Create()
		{
			return new MotorFightBossPb();
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x0600E380 RID: 58240 RVA: 0x00214C8C File Offset: 0x00212E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightBossPb> Parser
		{
			get
			{
				return MotorFightBossPb._parser;
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x0600E381 RID: 58241 RVA: 0x00214C93 File Offset: 0x00212E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x0600E382 RID: 58242 RVA: 0x00214C96 File Offset: 0x00212E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightBossPb.Descriptor;
			}
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x00214C9D File Offset: 0x00212E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossPb()
		{
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x00214CA5 File Offset: 0x00212EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossPb(MotorFightBossPb other) : this()
		{
			this.bossId_ = other.bossId_;
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E385 RID: 58245 RVA: 0x00214CD6 File Offset: 0x00212ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossPb Clone()
		{
			return new MotorFightBossPb(this);
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600E386 RID: 58246 RVA: 0x00214CDE File Offset: 0x00212EDE
		// (set) Token: 0x0600E387 RID: 58247 RVA: 0x00214CE6 File Offset: 0x00212EE6
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

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600E388 RID: 58248 RVA: 0x00214CEF File Offset: 0x00212EEF
		// (set) Token: 0x0600E389 RID: 58249 RVA: 0x00214CF7 File Offset: 0x00212EF7
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

		// Token: 0x0600E38A RID: 58250 RVA: 0x00214D00 File Offset: 0x00212F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightBossPb);
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x00214D0E File Offset: 0x00212F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightBossPb other)
		{
			return other != null && (other == this || (this.BossId == other.BossId && this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E38C RID: 58252 RVA: 0x00214D4C File Offset: 0x00212F4C
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

		// Token: 0x0600E38D RID: 58253 RVA: 0x00214DA4 File Offset: 0x00212FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E38E RID: 58254 RVA: 0x00214DB1 File Offset: 0x00212FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E38F RID: 58255 RVA: 0x00214DBC File Offset: 0x00212FBC
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

		// Token: 0x0600E390 RID: 58256 RVA: 0x00214E14 File Offset: 0x00213014
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

		// Token: 0x0600E391 RID: 58257 RVA: 0x00214E6C File Offset: 0x0021306C
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

		// Token: 0x0600E392 RID: 58258 RVA: 0x00214EBC File Offset: 0x002130BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E393 RID: 58259 RVA: 0x00214EC8 File Offset: 0x002130C8
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

		// Token: 0x04005D8F RID: 23951
		private static readonly MessageParser<MotorFightBossPb> _parser = new MessageParser<MotorFightBossPb>(() => new MotorFightBossPb());

		// Token: 0x04005D90 RID: 23952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D91 RID: 23953
		public const int BossIdFieldNumber = 1;

		// Token: 0x04005D92 RID: 23954
		private int bossId_;

		// Token: 0x04005D93 RID: 23955
		public const int WaveIdFieldNumber = 2;

		// Token: 0x04005D94 RID: 23956
		private int waveId_;
	}
}
