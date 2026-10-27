using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A60 RID: 2656
	public sealed class MotorFightRoundCollectionPb : IMessage<MotorFightRoundCollectionPb>, IMessage, IEquatable<MotorFightRoundCollectionPb>, IDeepCloneable<MotorFightRoundCollectionPb>, IBufferMessage
	{
		// Token: 0x0600E7AF RID: 59311 RVA: 0x0021D83E File Offset: 0x0021BA3E
		[NullableContext(1)]
		public static MotorFightRoundCollectionPb Create()
		{
			return new MotorFightRoundCollectionPb();
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x0021D845 File Offset: 0x0021BA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightRoundCollectionPb> Parser
		{
			get
			{
				return MotorFightRoundCollectionPb._parser;
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0600E7B1 RID: 59313 RVA: 0x0021D84C File Offset: 0x0021BA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600E7B2 RID: 59314 RVA: 0x0021D84F File Offset: 0x0021BA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRoundCollectionPb.Descriptor;
			}
		}

		// Token: 0x0600E7B3 RID: 59315 RVA: 0x0021D856 File Offset: 0x0021BA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundCollectionPb()
		{
		}

		// Token: 0x0600E7B4 RID: 59316 RVA: 0x0021D85E File Offset: 0x0021BA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundCollectionPb(MotorFightRoundCollectionPb other) : this()
		{
			this.collectionId_ = other.collectionId_;
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7B5 RID: 59317 RVA: 0x0021D89B File Offset: 0x0021BA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRoundCollectionPb Clone()
		{
			return new MotorFightRoundCollectionPb(this);
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600E7B6 RID: 59318 RVA: 0x0021D8A3 File Offset: 0x0021BAA3
		// (set) Token: 0x0600E7B7 RID: 59319 RVA: 0x0021D8AB File Offset: 0x0021BAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CollectionId
		{
			get
			{
				return this.collectionId_;
			}
			set
			{
				this.collectionId_ = value;
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600E7B8 RID: 59320 RVA: 0x0021D8B4 File Offset: 0x0021BAB4
		// (set) Token: 0x0600E7B9 RID: 59321 RVA: 0x0021D8BC File Offset: 0x0021BABC
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

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600E7BA RID: 59322 RVA: 0x0021D8C5 File Offset: 0x0021BAC5
		// (set) Token: 0x0600E7BB RID: 59323 RVA: 0x0021D8CD File Offset: 0x0021BACD
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

		// Token: 0x0600E7BC RID: 59324 RVA: 0x0021D8D6 File Offset: 0x0021BAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRoundCollectionPb);
		}

		// Token: 0x0600E7BD RID: 59325 RVA: 0x0021D8E4 File Offset: 0x0021BAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRoundCollectionPb other)
		{
			return other != null && (other == this || (this.CollectionId == other.CollectionId && this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7BE RID: 59326 RVA: 0x0021D940 File Offset: 0x0021BB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CollectionId != 0)
			{
				num ^= this.CollectionId.GetHashCode();
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

		// Token: 0x0600E7BF RID: 59327 RVA: 0x0021D9B1 File Offset: 0x0021BBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x0021D9BE File Offset: 0x0021BBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7C1 RID: 59329 RVA: 0x0021D9C8 File Offset: 0x0021BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CollectionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CollectionId);
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

		// Token: 0x0600E7C2 RID: 59330 RVA: 0x0021DA3C File Offset: 0x0021BC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CollectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CollectionId);
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

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x0021DAAC File Offset: 0x0021BCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRoundCollectionPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CollectionId != 0)
			{
				this.CollectionId = other.CollectionId;
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

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x0021DB10 File Offset: 0x0021BD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7C5 RID: 59333 RVA: 0x0021DB1C File Offset: 0x0021BD1C
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
					this.CollectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E63 RID: 24163
		private static readonly MessageParser<MotorFightRoundCollectionPb> _parser = new MessageParser<MotorFightRoundCollectionPb>(() => new MotorFightRoundCollectionPb());

		// Token: 0x04005E64 RID: 24164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E65 RID: 24165
		public const int CollectionIdFieldNumber = 1;

		// Token: 0x04005E66 RID: 24166
		private int collectionId_;

		// Token: 0x04005E67 RID: 24167
		public const int SubLevelIndexFieldNumber = 2;

		// Token: 0x04005E68 RID: 24168
		private int subLevelIndex_;

		// Token: 0x04005E69 RID: 24169
		public const int WaveGroupIndexFieldNumber = 3;

		// Token: 0x04005E6A RID: 24170
		private int waveGroupIndex_;
	}
}
