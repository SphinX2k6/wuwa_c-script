using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001262 RID: 4706
	public sealed class SoarLevelPlayInfo : IMessage<SoarLevelPlayInfo>, IMessage, IEquatable<SoarLevelPlayInfo>, IDeepCloneable<SoarLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x06019127 RID: 102695 RVA: 0x003A5D78 File Offset: 0x003A3F78
		[NullableContext(1)]
		public static SoarLevelPlayInfo Create()
		{
			return new SoarLevelPlayInfo();
		}

		// Token: 0x17005490 RID: 21648
		// (get) Token: 0x06019128 RID: 102696 RVA: 0x003A5D7F File Offset: 0x003A3F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SoarLevelPlayInfo> Parser
		{
			get
			{
				return SoarLevelPlayInfo._parser;
			}
		}

		// Token: 0x17005491 RID: 21649
		// (get) Token: 0x06019129 RID: 102697 RVA: 0x003A5D86 File Offset: 0x003A3F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005492 RID: 21650
		// (get) Token: 0x0601912A RID: 102698 RVA: 0x003A5D89 File Offset: 0x003A3F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SoarLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x0601912B RID: 102699 RVA: 0x003A5D90 File Offset: 0x003A3F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoarLevelPlayInfo()
		{
		}

		// Token: 0x0601912C RID: 102700 RVA: 0x003A5DA4 File Offset: 0x003A3FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoarLevelPlayInfo(SoarLevelPlayInfo other) : this()
		{
			this.soarLevelPlayId_ = other.soarLevelPlayId_;
			this.historySoarScore_ = other.historySoarScore_;
			this.receiveIds_ = other.receiveIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601912D RID: 102701 RVA: 0x003A5DF1 File Offset: 0x003A3FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoarLevelPlayInfo Clone()
		{
			return new SoarLevelPlayInfo(this);
		}

		// Token: 0x17005493 RID: 21651
		// (get) Token: 0x0601912E RID: 102702 RVA: 0x003A5DF9 File Offset: 0x003A3FF9
		// (set) Token: 0x0601912F RID: 102703 RVA: 0x003A5E01 File Offset: 0x003A4001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SoarLevelPlayId
		{
			get
			{
				return this.soarLevelPlayId_;
			}
			set
			{
				this.soarLevelPlayId_ = value;
			}
		}

		// Token: 0x17005494 RID: 21652
		// (get) Token: 0x06019130 RID: 102704 RVA: 0x003A5E0A File Offset: 0x003A400A
		// (set) Token: 0x06019131 RID: 102705 RVA: 0x003A5E12 File Offset: 0x003A4012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistorySoarScore
		{
			get
			{
				return this.historySoarScore_;
			}
			set
			{
				this.historySoarScore_ = value;
			}
		}

		// Token: 0x17005495 RID: 21653
		// (get) Token: 0x06019132 RID: 102706 RVA: 0x003A5E1B File Offset: 0x003A401B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceiveIds
		{
			get
			{
				return this.receiveIds_;
			}
		}

		// Token: 0x06019133 RID: 102707 RVA: 0x003A5E23 File Offset: 0x003A4023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SoarLevelPlayInfo);
		}

		// Token: 0x06019134 RID: 102708 RVA: 0x003A5E34 File Offset: 0x003A4034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SoarLevelPlayInfo other)
		{
			return other != null && (other == this || (this.SoarLevelPlayId == other.SoarLevelPlayId && this.HistorySoarScore == other.HistorySoarScore && this.receiveIds_.Equals(other.receiveIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019135 RID: 102709 RVA: 0x003A5E94 File Offset: 0x003A4094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SoarLevelPlayId != 0)
			{
				num ^= this.SoarLevelPlayId.GetHashCode();
			}
			if (this.HistorySoarScore != 0)
			{
				num ^= this.HistorySoarScore.GetHashCode();
			}
			num ^= this.receiveIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019136 RID: 102710 RVA: 0x003A5EFA File Offset: 0x003A40FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019137 RID: 102711 RVA: 0x003A5F07 File Offset: 0x003A4107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019138 RID: 102712 RVA: 0x003A5F10 File Offset: 0x003A4110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SoarLevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SoarLevelPlayId);
			}
			if (this.HistorySoarScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HistorySoarScore);
			}
			this.receiveIds_.WriteTo(ref output, SoarLevelPlayInfo._repeated_receiveIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019139 RID: 102713 RVA: 0x003A5F7C File Offset: 0x003A417C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SoarLevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SoarLevelPlayId);
			}
			if (this.HistorySoarScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistorySoarScore);
			}
			num += this.receiveIds_.CalculateSize(SoarLevelPlayInfo._repeated_receiveIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601913A RID: 102714 RVA: 0x003A5FE8 File Offset: 0x003A41E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SoarLevelPlayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SoarLevelPlayId != 0)
			{
				this.SoarLevelPlayId = other.SoarLevelPlayId;
			}
			if (other.HistorySoarScore != 0)
			{
				this.HistorySoarScore = other.HistorySoarScore;
			}
			this.receiveIds_.Add(other.receiveIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601913B RID: 102715 RVA: 0x003A6049 File Offset: 0x003A4249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601913C RID: 102716 RVA: 0x003A6054 File Offset: 0x003A4254
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SoarLevelPlayId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HistorySoarScore = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.receiveIds_.AddEntriesFrom(ref input, SoarLevelPlayInfo._repeated_receiveIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040093AF RID: 37807
		private static readonly MessageParser<SoarLevelPlayInfo> _parser = new MessageParser<SoarLevelPlayInfo>(() => new SoarLevelPlayInfo());

		// Token: 0x040093B0 RID: 37808
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093B1 RID: 37809
		public const int SoarLevelPlayIdFieldNumber = 1;

		// Token: 0x040093B2 RID: 37810
		private int soarLevelPlayId_;

		// Token: 0x040093B3 RID: 37811
		public const int HistorySoarScoreFieldNumber = 2;

		// Token: 0x040093B4 RID: 37812
		private int historySoarScore_;

		// Token: 0x040093B5 RID: 37813
		public const int ReceiveIdsFieldNumber = 3;

		// Token: 0x040093B6 RID: 37814
		private static readonly FieldCodec<int> _repeated_receiveIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040093B7 RID: 37815
		private readonly RepeatedField<int> receiveIds_ = new RepeatedField<int>();
	}
}
