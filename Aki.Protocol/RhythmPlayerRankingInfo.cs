using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3D RID: 3901
	public sealed class RhythmPlayerRankingInfo : IMessage<RhythmPlayerRankingInfo>, IMessage, IEquatable<RhythmPlayerRankingInfo>, IDeepCloneable<RhythmPlayerRankingInfo>, IBufferMessage
	{
		// Token: 0x06014DF0 RID: 85488 RVA: 0x003070DF File Offset: 0x003052DF
		[NullableContext(1)]
		public static RhythmPlayerRankingInfo Create()
		{
			return new RhythmPlayerRankingInfo();
		}

		// Token: 0x17004563 RID: 17763
		// (get) Token: 0x06014DF1 RID: 85489 RVA: 0x003070E6 File Offset: 0x003052E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmPlayerRankingInfo> Parser
		{
			get
			{
				return RhythmPlayerRankingInfo._parser;
			}
		}

		// Token: 0x17004564 RID: 17764
		// (get) Token: 0x06014DF2 RID: 85490 RVA: 0x003070ED File Offset: 0x003052ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x06014DF3 RID: 85491 RVA: 0x003070F0 File Offset: 0x003052F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmPlayerRankingInfo.Descriptor;
			}
		}

		// Token: 0x06014DF4 RID: 85492 RVA: 0x003070F7 File Offset: 0x003052F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo()
		{
		}

		// Token: 0x06014DF5 RID: 85493 RVA: 0x00307118 File Offset: 0x00305318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo(RhythmPlayerRankingInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.subLevelInfo_ = other.subLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DF6 RID: 85494 RVA: 0x00307165 File Offset: 0x00305365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingInfo Clone()
		{
			return new RhythmPlayerRankingInfo(this);
		}

		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x06014DF7 RID: 85495 RVA: 0x0030716D File Offset: 0x0030536D
		// (set) Token: 0x06014DF8 RID: 85496 RVA: 0x00307175 File Offset: 0x00305375
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

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x06014DF9 RID: 85497 RVA: 0x0030717E File Offset: 0x0030537E
		// (set) Token: 0x06014DFA RID: 85498 RVA: 0x00307186 File Offset: 0x00305386
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

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x06014DFB RID: 85499 RVA: 0x00307199 File Offset: 0x00305399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmPlayerRankingSubLevelInfo> SubLevelInfo
		{
			get
			{
				return this.subLevelInfo_;
			}
		}

		// Token: 0x06014DFC RID: 85500 RVA: 0x003071A1 File Offset: 0x003053A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmPlayerRankingInfo);
		}

		// Token: 0x06014DFD RID: 85501 RVA: 0x003071B0 File Offset: 0x003053B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmPlayerRankingInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.subLevelInfo_.Equals(other.subLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DFE RID: 85502 RVA: 0x00307214 File Offset: 0x00305414
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

		// Token: 0x06014DFF RID: 85503 RVA: 0x0030727C File Offset: 0x0030547C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E00 RID: 85504 RVA: 0x00307289 File Offset: 0x00305489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E01 RID: 85505 RVA: 0x00307294 File Offset: 0x00305494
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

		// Token: 0x06014E02 RID: 85506 RVA: 0x00307304 File Offset: 0x00305504
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

		// Token: 0x06014E03 RID: 85507 RVA: 0x00307374 File Offset: 0x00305574
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

		// Token: 0x06014E04 RID: 85508 RVA: 0x003073DA File Offset: 0x003055DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E05 RID: 85509 RVA: 0x003073E4 File Offset: 0x003055E4
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

		// Token: 0x04007DE2 RID: 32226
		private static readonly MessageParser<RhythmPlayerRankingInfo> _parser = new MessageParser<RhythmPlayerRankingInfo>(() => new RhythmPlayerRankingInfo());

		// Token: 0x04007DE3 RID: 32227
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DE4 RID: 32228
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007DE5 RID: 32229
		private int playerId_;

		// Token: 0x04007DE6 RID: 32230
		public const int NameFieldNumber = 2;

		// Token: 0x04007DE7 RID: 32231
		private string name_ = "";

		// Token: 0x04007DE8 RID: 32232
		public const int SubLevelInfoFieldNumber = 3;

		// Token: 0x04007DE9 RID: 32233
		private static readonly FieldCodec<RhythmPlayerRankingSubLevelInfo> _repeated_subLevelInfo_codec = FieldCodec.ForMessage<RhythmPlayerRankingSubLevelInfo>(26U, RhythmPlayerRankingSubLevelInfo.Parser);

		// Token: 0x04007DEA RID: 32234
		private readonly RepeatedField<RhythmPlayerRankingSubLevelInfo> subLevelInfo_ = new RepeatedField<RhythmPlayerRankingSubLevelInfo>();
	}
}
