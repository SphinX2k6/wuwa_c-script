using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123D RID: 4669
	public sealed class ShortMessageInfo : IMessage<ShortMessageInfo>, IMessage, IEquatable<ShortMessageInfo>, IDeepCloneable<ShortMessageInfo>, IBufferMessage
	{
		// Token: 0x06018EEF RID: 102127 RVA: 0x003A2681 File Offset: 0x003A0881
		[NullableContext(1)]
		public static ShortMessageInfo Create()
		{
			return new ShortMessageInfo();
		}

		// Token: 0x1700543C RID: 21564
		// (get) Token: 0x06018EF0 RID: 102128 RVA: 0x003A2688 File Offset: 0x003A0888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortMessageInfo> Parser
		{
			get
			{
				return ShortMessageInfo._parser;
			}
		}

		// Token: 0x1700543D RID: 21565
		// (get) Token: 0x06018EF1 RID: 102129 RVA: 0x003A268F File Offset: 0x003A088F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700543E RID: 21566
		// (get) Token: 0x06018EF2 RID: 102130 RVA: 0x003A2692 File Offset: 0x003A0892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageInfo.Descriptor;
			}
		}

		// Token: 0x06018EF3 RID: 102131 RVA: 0x003A2699 File Offset: 0x003A0899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfo()
		{
		}

		// Token: 0x06018EF4 RID: 102132 RVA: 0x003A26AC File Offset: 0x003A08AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfo(ShortMessageInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.lastConfigId_ = other.lastConfigId_;
			this.isRead_ = other.isRead_;
			this.isReceived_ = other.isReceived_;
			this.options_ = other.options_.Clone();
			this.unlockTime_ = other.unlockTime_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EF5 RID: 102133 RVA: 0x003A2729 File Offset: 0x003A0929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfo Clone()
		{
			return new ShortMessageInfo(this);
		}

		// Token: 0x1700543F RID: 21567
		// (get) Token: 0x06018EF6 RID: 102134 RVA: 0x003A2731 File Offset: 0x003A0931
		// (set) Token: 0x06018EF7 RID: 102135 RVA: 0x003A2739 File Offset: 0x003A0939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005440 RID: 21568
		// (get) Token: 0x06018EF8 RID: 102136 RVA: 0x003A2742 File Offset: 0x003A0942
		// (set) Token: 0x06018EF9 RID: 102137 RVA: 0x003A274A File Offset: 0x003A094A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastConfigId
		{
			get
			{
				return this.lastConfigId_;
			}
			set
			{
				this.lastConfigId_ = value;
			}
		}

		// Token: 0x17005441 RID: 21569
		// (get) Token: 0x06018EFA RID: 102138 RVA: 0x003A2753 File Offset: 0x003A0953
		// (set) Token: 0x06018EFB RID: 102139 RVA: 0x003A275B File Offset: 0x003A095B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRead
		{
			get
			{
				return this.isRead_;
			}
			set
			{
				this.isRead_ = value;
			}
		}

		// Token: 0x17005442 RID: 21570
		// (get) Token: 0x06018EFC RID: 102140 RVA: 0x003A2764 File Offset: 0x003A0964
		// (set) Token: 0x06018EFD RID: 102141 RVA: 0x003A276C File Offset: 0x003A096C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceived
		{
			get
			{
				return this.isReceived_;
			}
			set
			{
				this.isReceived_ = value;
			}
		}

		// Token: 0x17005443 RID: 21571
		// (get) Token: 0x06018EFE RID: 102142 RVA: 0x003A2775 File Offset: 0x003A0975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Options
		{
			get
			{
				return this.options_;
			}
		}

		// Token: 0x17005444 RID: 21572
		// (get) Token: 0x06018EFF RID: 102143 RVA: 0x003A277D File Offset: 0x003A097D
		// (set) Token: 0x06018F00 RID: 102144 RVA: 0x003A2785 File Offset: 0x003A0985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17005445 RID: 21573
		// (get) Token: 0x06018F01 RID: 102145 RVA: 0x003A278E File Offset: 0x003A098E
		// (set) Token: 0x06018F02 RID: 102146 RVA: 0x003A2796 File Offset: 0x003A0996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06018F03 RID: 102147 RVA: 0x003A279F File Offset: 0x003A099F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageInfo);
		}

		// Token: 0x06018F04 RID: 102148 RVA: 0x003A27B0 File Offset: 0x003A09B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.LastConfigId == other.LastConfigId && this.IsRead == other.IsRead && this.IsReceived == other.IsReceived && this.Options.Equals(other.Options) && this.UnlockTime == other.UnlockTime && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F05 RID: 102149 RVA: 0x003A2850 File Offset: 0x003A0A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.LastConfigId != 0)
			{
				num ^= this.LastConfigId.GetHashCode();
			}
			if (this.IsRead)
			{
				num ^= this.IsRead.GetHashCode();
			}
			if (this.IsReceived)
			{
				num ^= this.IsReceived.GetHashCode();
			}
			num ^= this.Options.GetHashCode();
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F06 RID: 102150 RVA: 0x003A291A File Offset: 0x003A0B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F07 RID: 102151 RVA: 0x003A2927 File Offset: 0x003A0B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F08 RID: 102152 RVA: 0x003A2930 File Offset: 0x003A0B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.LastConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastConfigId);
			}
			if (this.IsRead)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRead);
			}
			if (this.IsReceived)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsReceived);
			}
			this.options_.WriteTo(ref output, ShortMessageInfo._map_options_codec);
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F09 RID: 102153 RVA: 0x003A2A0C File Offset: 0x003A0C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.LastConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastConfigId);
			}
			if (this.IsRead)
			{
				num += 2;
			}
			if (this.IsReceived)
			{
				num += 2;
			}
			num += this.options_.CalculateSize(ShortMessageInfo._map_options_codec);
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F0A RID: 102154 RVA: 0x003A2AB4 File Offset: 0x003A0CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.LastConfigId != 0)
			{
				this.LastConfigId = other.LastConfigId;
			}
			if (other.IsRead)
			{
				this.IsRead = other.IsRead;
			}
			if (other.IsReceived)
			{
				this.IsReceived = other.IsReceived;
			}
			this.options_.MergeFrom(other.options_);
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F0B RID: 102155 RVA: 0x003A2B65 File Offset: 0x003A0D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F0C RID: 102156 RVA: 0x003A2B70 File Offset: 0x003A0D70
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LastConfigId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsRead = input.ReadBool();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 32U)
					{
						this.IsReceived = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						this.options_.AddEntriesFrom(ref input, ShortMessageInfo._map_options_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040093D7 RID: 37847
		private static readonly MessageParser<ShortMessageInfo> _parser = new MessageParser<ShortMessageInfo>(() => new ShortMessageInfo());

		// Token: 0x040093D8 RID: 37848
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093D9 RID: 37849
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040093DA RID: 37850
		private int configId_;

		// Token: 0x040093DB RID: 37851
		public const int LastConfigIdFieldNumber = 2;

		// Token: 0x040093DC RID: 37852
		private int lastConfigId_;

		// Token: 0x040093DD RID: 37853
		public const int IsReadFieldNumber = 3;

		// Token: 0x040093DE RID: 37854
		private bool isRead_;

		// Token: 0x040093DF RID: 37855
		public const int IsReceivedFieldNumber = 4;

		// Token: 0x040093E0 RID: 37856
		private bool isReceived_;

		// Token: 0x040093E1 RID: 37857
		public const int OptionsFieldNumber = 5;

		// Token: 0x040093E2 RID: 37858
		private static readonly MapField<int, int>.Codec _map_options_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040093E3 RID: 37859
		private readonly MapField<int, int> options_ = new MapField<int, int>();

		// Token: 0x040093E4 RID: 37860
		public const int UnlockTimeFieldNumber = 6;

		// Token: 0x040093E5 RID: 37861
		private long unlockTime_;

		// Token: 0x040093E6 RID: 37862
		public const int IsFinishFieldNumber = 7;

		// Token: 0x040093E7 RID: 37863
		private bool isFinish_;
	}
}
