using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5F RID: 2655
	public sealed class MotorFightRoundBuffPb : IMessage<MotorFightRoundBuffPb>, IMessage, IEquatable<MotorFightRoundBuffPb>, IDeepCloneable<MotorFightRoundBuffPb>, IBufferMessage
	{
		// Token: 0x0600E797 RID: 59287 RVA: 0x0021D4D9 File Offset: 0x0021B6D9
		[NullableContext(1)]
		public static MotorFightRoundBuffPb Create()
		{
			return new MotorFightRoundBuffPb();
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0600E798 RID: 59288 RVA: 0x0021D4E0 File Offset: 0x0021B6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightRoundBuffPb> Parser
		{
			get
			{
				return MotorFightRoundBuffPb._parser;
			}
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600E799 RID: 59289 RVA: 0x0021D4E7 File Offset: 0x0021B6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600E79A RID: 59290 RVA: 0x0021D4EA File Offset: 0x0021B6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoundBuffPb.Descriptor;
			}
		}

		// Token: 0x0600E79B RID: 59291 RVA: 0x0021D4F1 File Offset: 0x0021B6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundBuffPb()
		{
		}

		// Token: 0x0600E79C RID: 59292 RVA: 0x0021D4F9 File Offset: 0x0021B6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundBuffPb(MotorFightRoundBuffPb other) : this()
		{
			this.buffId_ = other.buffId_;
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E79D RID: 59293 RVA: 0x0021D536 File Offset: 0x0021B736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundBuffPb Clone()
		{
			return new MotorFightRoundBuffPb(this);
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x0021D53E File Offset: 0x0021B73E
		// (set) Token: 0x0600E79F RID: 59295 RVA: 0x0021D546 File Offset: 0x0021B746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0600E7A0 RID: 59296 RVA: 0x0021D54F File Offset: 0x0021B74F
		// (set) Token: 0x0600E7A1 RID: 59297 RVA: 0x0021D557 File Offset: 0x0021B757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x0021D560 File Offset: 0x0021B760
		// (set) Token: 0x0600E7A3 RID: 59299 RVA: 0x0021D568 File Offset: 0x0021B768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x0600E7A4 RID: 59300 RVA: 0x0021D571 File Offset: 0x0021B771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoundBuffPb);
		}

		// Token: 0x0600E7A5 RID: 59301 RVA: 0x0021D580 File Offset: 0x0021B780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoundBuffPb other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7A6 RID: 59302 RVA: 0x0021D5DC File Offset: 0x0021B7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E7A7 RID: 59303 RVA: 0x0021D64D File Offset: 0x0021B84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x0021D65A File Offset: 0x0021B85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x0021D664 File Offset: 0x0021B864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffId);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7AA RID: 59306 RVA: 0x0021D6D8 File Offset: 0x0021B8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffId);
			}
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x0021D748 File Offset: 0x0021B948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRoundBuffPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0)
			{
				this.BuffId = other.BuffId;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x0021D7AC File Offset: 0x0021B9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7AD RID: 59309 RVA: 0x0021D7B8 File Offset: 0x0021B9B8
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
							this.WaveGroupIndex = input.ReadInt32();
						}
					}
					else
					{
						this.SubLevelIndex = input.ReadInt32();
					}
				}
				else
				{
					this.BuffId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E5B RID: 24155
		private static readonly MessageParser<MotorFightRoundBuffPb> _parser = new MessageParser<MotorFightRoundBuffPb>(() => new MotorFightRoundBuffPb());

		// Token: 0x04005E5C RID: 24156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E5D RID: 24157
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04005E5E RID: 24158
		private int buffId_;

		// Token: 0x04005E5F RID: 24159
		public const int SubLevelIndexFieldNumber = 2;

		// Token: 0x04005E60 RID: 24160
		private int subLevelIndex_;

		// Token: 0x04005E61 RID: 24161
		public const int WaveGroupIndexFieldNumber = 3;

		// Token: 0x04005E62 RID: 24162
		private int waveGroupIndex_;
	}
}
