using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129F RID: 4767
	public sealed class SoarLevelPlayInfo : IMessage<SoarLevelPlayInfo>, IMessage, IEquatable<SoarLevelPlayInfo>, IDeepCloneable<SoarLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x06019711 RID: 104209 RVA: 0x003B5CD0 File Offset: 0x003B3ED0
		[NullableContext(1)]
		public static SoarLevelPlayInfo Create()
		{
			return new SoarLevelPlayInfo();
		}

		// Token: 0x1700560F RID: 22031
		// (get) Token: 0x06019712 RID: 104210 RVA: 0x003B5CD7 File Offset: 0x003B3ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SoarLevelPlayInfo> Parser
		{
			get
			{
				return SoarLevelPlayInfo._parser;
			}
		}

		// Token: 0x17005610 RID: 22032
		// (get) Token: 0x06019713 RID: 104211 RVA: 0x003B5CDE File Offset: 0x003B3EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005611 RID: 22033
		// (get) Token: 0x06019714 RID: 104212 RVA: 0x003B5CE1 File Offset: 0x003B3EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SoarLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x06019715 RID: 104213 RVA: 0x003B5CE8 File Offset: 0x003B3EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoarLevelPlayInfo()
		{
		}

		// Token: 0x06019716 RID: 104214 RVA: 0x003B5CFC File Offset: 0x003B3EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoarLevelPlayInfo(SoarLevelPlayInfo other) : this()
		{
			this.soarLevelPlayId_ = other.soarLevelPlayId_;
			this.historySoarScore_ = other.historySoarScore_;
			this.receiveIds_ = other.receiveIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019717 RID: 104215 RVA: 0x003B5D49 File Offset: 0x003B3F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoarLevelPlayInfo Clone()
		{
			return new SoarLevelPlayInfo(this);
		}

		// Token: 0x17005612 RID: 22034
		// (get) Token: 0x06019718 RID: 104216 RVA: 0x003B5D51 File Offset: 0x003B3F51
		// (set) Token: 0x06019719 RID: 104217 RVA: 0x003B5D59 File Offset: 0x003B3F59
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

		// Token: 0x17005613 RID: 22035
		// (get) Token: 0x0601971A RID: 104218 RVA: 0x003B5D62 File Offset: 0x003B3F62
		// (set) Token: 0x0601971B RID: 104219 RVA: 0x003B5D6A File Offset: 0x003B3F6A
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

		// Token: 0x17005614 RID: 22036
		// (get) Token: 0x0601971C RID: 104220 RVA: 0x003B5D73 File Offset: 0x003B3F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReceiveIds
		{
			get
			{
				return this.receiveIds_;
			}
		}

		// Token: 0x0601971D RID: 104221 RVA: 0x003B5D7B File Offset: 0x003B3F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SoarLevelPlayInfo);
		}

		// Token: 0x0601971E RID: 104222 RVA: 0x003B5D8C File Offset: 0x003B3F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SoarLevelPlayInfo other)
		{
			return other != null && (other == this || (this.SoarLevelPlayId == other.SoarLevelPlayId && this.HistorySoarScore == other.HistorySoarScore && this.receiveIds_.Equals(other.receiveIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601971F RID: 104223 RVA: 0x003B5DEC File Offset: 0x003B3FEC
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

		// Token: 0x06019720 RID: 104224 RVA: 0x003B5E52 File Offset: 0x003B4052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019721 RID: 104225 RVA: 0x003B5E5F File Offset: 0x003B405F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019722 RID: 104226 RVA: 0x003B5E68 File Offset: 0x003B4068
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

		// Token: 0x06019723 RID: 104227 RVA: 0x003B5ED4 File Offset: 0x003B40D4
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

		// Token: 0x06019724 RID: 104228 RVA: 0x003B5F40 File Offset: 0x003B4140
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

		// Token: 0x06019725 RID: 104229 RVA: 0x003B5FA1 File Offset: 0x003B41A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019726 RID: 104230 RVA: 0x003B5FAC File Offset: 0x003B41AC
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

		// Token: 0x04009661 RID: 38497
		private static readonly MessageParser<SoarLevelPlayInfo> _parser = new MessageParser<SoarLevelPlayInfo>(() => new SoarLevelPlayInfo());

		// Token: 0x04009662 RID: 38498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009663 RID: 38499
		public const int SoarLevelPlayIdFieldNumber = 1;

		// Token: 0x04009664 RID: 38500
		private int soarLevelPlayId_;

		// Token: 0x04009665 RID: 38501
		public const int HistorySoarScoreFieldNumber = 2;

		// Token: 0x04009666 RID: 38502
		private int historySoarScore_;

		// Token: 0x04009667 RID: 38503
		public const int ReceiveIdsFieldNumber = 3;

		// Token: 0x04009668 RID: 38504
		private static readonly FieldCodec<int> _repeated_receiveIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009669 RID: 38505
		private readonly RepeatedField<int> receiveIds_ = new RepeatedField<int>();
	}
}
