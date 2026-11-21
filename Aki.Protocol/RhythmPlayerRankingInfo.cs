using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2D RID: 3885
	public sealed class RhythmPlayerRankingInfo : IMessage<RhythmPlayerRankingInfo>, IMessage, IEquatable<RhythmPlayerRankingInfo>, IDeepCloneable<RhythmPlayerRankingInfo>, IBufferMessage
	{
		// Token: 0x06014D0B RID: 85259 RVA: 0x00305A23 File Offset: 0x00303C23
		[NullableContext(1)]
		public static RhythmPlayerRankingInfo Create()
		{
			return new RhythmPlayerRankingInfo();
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x06014D0C RID: 85260 RVA: 0x00305A2A File Offset: 0x00303C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmPlayerRankingInfo> Parser
		{
			get
			{
				return RhythmPlayerRankingInfo._parser;
			}
		}

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x06014D0D RID: 85261 RVA: 0x00305A31 File Offset: 0x00303C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x06014D0E RID: 85262 RVA: 0x00305A34 File Offset: 0x00303C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmPlayerRankingInfo.Descriptor;
			}
		}

		// Token: 0x06014D0F RID: 85263 RVA: 0x00305A3B File Offset: 0x00303C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo()
		{
		}

		// Token: 0x06014D10 RID: 85264 RVA: 0x00305A5C File Offset: 0x00303C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo(RhythmPlayerRankingInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.subLevelInfo_ = other.subLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D11 RID: 85265 RVA: 0x00305AA9 File Offset: 0x00303CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo Clone()
		{
			return new RhythmPlayerRankingInfo(this);
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x06014D12 RID: 85266 RVA: 0x00305AB1 File Offset: 0x00303CB1
		// (set) Token: 0x06014D13 RID: 85267 RVA: 0x00305AB9 File Offset: 0x00303CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x06014D14 RID: 85268 RVA: 0x00305AC2 File Offset: 0x00303CC2
		// (set) Token: 0x06014D15 RID: 85269 RVA: 0x00305ACA File Offset: 0x00303CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x06014D16 RID: 85270 RVA: 0x00305ADD File Offset: 0x00303CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmPlayerRankingSubLevelInfo> SubLevelInfo
		{
			get
			{
				return this.subLevelInfo_;
			}
		}

		// Token: 0x06014D17 RID: 85271 RVA: 0x00305AE5 File Offset: 0x00303CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmPlayerRankingInfo);
		}

		// Token: 0x06014D18 RID: 85272 RVA: 0x00305AF4 File Offset: 0x00303CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmPlayerRankingInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.subLevelInfo_.Equals(other.subLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D19 RID: 85273 RVA: 0x00305B58 File Offset: 0x00303D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.subLevelInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014D1A RID: 85274 RVA: 0x00305BC0 File Offset: 0x00303DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D1B RID: 85275 RVA: 0x00305BCD File Offset: 0x00303DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D1C RID: 85276 RVA: 0x00305BD8 File Offset: 0x00303DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			this.subLevelInfo_.WriteTo(ref output, RhythmPlayerRankingInfo._repeated_subLevelInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D1D RID: 85277 RVA: 0x00305C48 File Offset: 0x00303E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.subLevelInfo_.CalculateSize(RhythmPlayerRankingInfo._repeated_subLevelInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014D1E RID: 85278 RVA: 0x00305CB8 File Offset: 0x00303EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmPlayerRankingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this.subLevelInfo_.Add(other.subLevelInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014D1F RID: 85279 RVA: 0x00305D1E File Offset: 0x00303F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D20 RID: 85280 RVA: 0x00305D28 File Offset: 0x00303F28
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.subLevelInfo_.AddEntriesFrom(ref input, RhythmPlayerRankingInfo._repeated_subLevelInfo_codec);
						}
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E0C RID: 32268
		private static readonly MessageParser<RhythmPlayerRankingInfo> _parser = new MessageParser<RhythmPlayerRankingInfo>(() => new RhythmPlayerRankingInfo());

		// Token: 0x04007E0D RID: 32269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E0E RID: 32270
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007E0F RID: 32271
		private int playerId_;

		// Token: 0x04007E10 RID: 32272
		public const int NameFieldNumber = 2;

		// Token: 0x04007E11 RID: 32273
		private string name_ = "";

		// Token: 0x04007E12 RID: 32274
		public const int SubLevelInfoFieldNumber = 3;

		// Token: 0x04007E13 RID: 32275
		private static readonly FieldCodec<RhythmPlayerRankingSubLevelInfo> _repeated_subLevelInfo_codec = FieldCodec.ForMessage<RhythmPlayerRankingSubLevelInfo>(26U, RhythmPlayerRankingSubLevelInfo.Parser);

		// Token: 0x04007E14 RID: 32276
		private readonly RepeatedField<RhythmPlayerRankingSubLevelInfo> subLevelInfo_ = new RepeatedField<RhythmPlayerRankingSubLevelInfo>();
	}
}
