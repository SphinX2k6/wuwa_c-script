using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4E RID: 2638
	public sealed class MotorFightRoundBuffPb : IMessage<MotorFightRoundBuffPb>, IMessage, IEquatable<MotorFightRoundBuffPb>, IDeepCloneable<MotorFightRoundBuffPb>, IBufferMessage
	{
		// Token: 0x0600E67D RID: 59005 RVA: 0x0021B2E5 File Offset: 0x002194E5
		[NullableContext(1)]
		public static MotorFightRoundBuffPb Create()
		{
			return new MotorFightRoundBuffPb();
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600E67E RID: 59006 RVA: 0x0021B2EC File Offset: 0x002194EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightRoundBuffPb> Parser
		{
			get
			{
				return MotorFightRoundBuffPb._parser;
			}
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600E67F RID: 59007 RVA: 0x0021B2F3 File Offset: 0x002194F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0600E680 RID: 59008 RVA: 0x0021B2F6 File Offset: 0x002194F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoundBuffPb.Descriptor;
			}
		}

		// Token: 0x0600E681 RID: 59009 RVA: 0x0021B2FD File Offset: 0x002194FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundBuffPb()
		{
		}

		// Token: 0x0600E682 RID: 59010 RVA: 0x0021B305 File Offset: 0x00219505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundBuffPb(MotorFightRoundBuffPb other) : this()
		{
			this.buffId_ = other.buffId_;
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E683 RID: 59011 RVA: 0x0021B342 File Offset: 0x00219542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundBuffPb Clone()
		{
			return new MotorFightRoundBuffPb(this);
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0600E684 RID: 59012 RVA: 0x0021B34A File Offset: 0x0021954A
		// (set) Token: 0x0600E685 RID: 59013 RVA: 0x0021B352 File Offset: 0x00219552
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

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0600E686 RID: 59014 RVA: 0x0021B35B File Offset: 0x0021955B
		// (set) Token: 0x0600E687 RID: 59015 RVA: 0x0021B363 File Offset: 0x00219563
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

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600E688 RID: 59016 RVA: 0x0021B36C File Offset: 0x0021956C
		// (set) Token: 0x0600E689 RID: 59017 RVA: 0x0021B374 File Offset: 0x00219574
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

		// Token: 0x0600E68A RID: 59018 RVA: 0x0021B37D File Offset: 0x0021957D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoundBuffPb);
		}

		// Token: 0x0600E68B RID: 59019 RVA: 0x0021B38C File Offset: 0x0021958C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoundBuffPb other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E68C RID: 59020 RVA: 0x0021B3E8 File Offset: 0x002195E8
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

		// Token: 0x0600E68D RID: 59021 RVA: 0x0021B459 File Offset: 0x00219659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E68E RID: 59022 RVA: 0x0021B466 File Offset: 0x00219666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E68F RID: 59023 RVA: 0x0021B470 File Offset: 0x00219670
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

		// Token: 0x0600E690 RID: 59024 RVA: 0x0021B4E4 File Offset: 0x002196E4
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

		// Token: 0x0600E691 RID: 59025 RVA: 0x0021B554 File Offset: 0x00219754
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

		// Token: 0x0600E692 RID: 59026 RVA: 0x0021B5B8 File Offset: 0x002197B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E693 RID: 59027 RVA: 0x0021B5C4 File Offset: 0x002197C4
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

		// Token: 0x04005E64 RID: 24164
		private static readonly MessageParser<MotorFightRoundBuffPb> _parser = new MessageParser<MotorFightRoundBuffPb>(() => new MotorFightRoundBuffPb());

		// Token: 0x04005E65 RID: 24165
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E66 RID: 24166
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04005E67 RID: 24167
		private int buffId_;

		// Token: 0x04005E68 RID: 24168
		public const int SubLevelIndexFieldNumber = 2;

		// Token: 0x04005E69 RID: 24169
		private int subLevelIndex_;

		// Token: 0x04005E6A RID: 24170
		public const int WaveGroupIndexFieldNumber = 3;

		// Token: 0x04005E6B RID: 24171
		private int waveGroupIndex_;
	}
}
