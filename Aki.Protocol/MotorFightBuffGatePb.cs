using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2A RID: 2602
	public sealed class MotorFightBuffGatePb : IMessage<MotorFightBuffGatePb>, IMessage, IEquatable<MotorFightBuffGatePb>, IDeepCloneable<MotorFightBuffGatePb>, IBufferMessage
	{
		// Token: 0x0600E395 RID: 58261 RVA: 0x00214F3B File Offset: 0x0021313B
		[NullableContext(1)]
		public static MotorFightBuffGatePb Create()
		{
			return new MotorFightBuffGatePb();
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600E396 RID: 58262 RVA: 0x00214F42 File Offset: 0x00213142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightBuffGatePb> Parser
		{
			get
			{
				return MotorFightBuffGatePb._parser;
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600E397 RID: 58263 RVA: 0x00214F49 File Offset: 0x00213149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x0600E398 RID: 58264 RVA: 0x00214F4C File Offset: 0x0021314C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightBuffGatePb.Descriptor;
			}
		}

		// Token: 0x0600E399 RID: 58265 RVA: 0x00214F53 File Offset: 0x00213153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBuffGatePb()
		{
		}

		// Token: 0x0600E39A RID: 58266 RVA: 0x00214F5B File Offset: 0x0021315B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBuffGatePb(MotorFightBuffGatePb other) : this()
		{
			this.buffGateId_ = other.buffGateId_;
			this.waveId_ = other.waveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E39B RID: 58267 RVA: 0x00214F8C File Offset: 0x0021318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBuffGatePb Clone()
		{
			return new MotorFightBuffGatePb(this);
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x0600E39C RID: 58268 RVA: 0x00214F94 File Offset: 0x00213194
		// (set) Token: 0x0600E39D RID: 58269 RVA: 0x00214F9C File Offset: 0x0021319C
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

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0600E39E RID: 58270 RVA: 0x00214FA5 File Offset: 0x002131A5
		// (set) Token: 0x0600E39F RID: 58271 RVA: 0x00214FAD File Offset: 0x002131AD
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

		// Token: 0x0600E3A0 RID: 58272 RVA: 0x00214FB6 File Offset: 0x002131B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightBuffGatePb);
		}

		// Token: 0x0600E3A1 RID: 58273 RVA: 0x00214FC4 File Offset: 0x002131C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightBuffGatePb other)
		{
			return other != null && (other == this || (this.BuffGateId == other.BuffGateId && this.WaveId == other.WaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00215004 File Offset: 0x00213204
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

		// Token: 0x0600E3A3 RID: 58275 RVA: 0x0021505C File Offset: 0x0021325C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3A4 RID: 58276 RVA: 0x00215069 File Offset: 0x00213269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3A5 RID: 58277 RVA: 0x00215074 File Offset: 0x00213274
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

		// Token: 0x0600E3A6 RID: 58278 RVA: 0x002150CC File Offset: 0x002132CC
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

		// Token: 0x0600E3A7 RID: 58279 RVA: 0x00215124 File Offset: 0x00213324
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

		// Token: 0x0600E3A8 RID: 58280 RVA: 0x00215174 File Offset: 0x00213374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3A9 RID: 58281 RVA: 0x00215180 File Offset: 0x00213380
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

		// Token: 0x04005D95 RID: 23957
		private static readonly MessageParser<MotorFightBuffGatePb> _parser = new MessageParser<MotorFightBuffGatePb>(() => new MotorFightBuffGatePb());

		// Token: 0x04005D96 RID: 23958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D97 RID: 23959
		public const int BuffGateIdFieldNumber = 1;

		// Token: 0x04005D98 RID: 23960
		private int buffGateId_;

		// Token: 0x04005D99 RID: 23961
		public const int WaveIdFieldNumber = 2;

		// Token: 0x04005D9A RID: 23962
		private int waveId_;
	}
}
