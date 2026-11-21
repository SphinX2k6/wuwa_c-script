using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000389 RID: 905
	public sealed class DangoMonopolyBoardRecordPb : IMessage<DangoMonopolyBoardRecordPb>, IMessage, IEquatable<DangoMonopolyBoardRecordPb>, IDeepCloneable<DangoMonopolyBoardRecordPb>, IBufferMessage
	{
		// Token: 0x060059CE RID: 22990 RVA: 0x000DB119 File Offset: 0x000D9319
		[NullableContext(1)]
		public static DangoMonopolyBoardRecordPb Create()
		{
			return new DangoMonopolyBoardRecordPb();
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060059CF RID: 22991 RVA: 0x000DB120 File Offset: 0x000D9320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoMonopolyBoardRecordPb> Parser
		{
			get
			{
				return DangoMonopolyBoardRecordPb._parser;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x000DB127 File Offset: 0x000D9327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060059D1 RID: 22993 RVA: 0x000DB12A File Offset: 0x000D932A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyBoardRecordPb.Descriptor;
			}
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x000DB131 File Offset: 0x000D9331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRecordPb()
		{
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x000DB150 File Offset: 0x000D9350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRecordPb(DangoMonopolyBoardRecordPb other) : this()
		{
			this.propertyIds_ = other.propertyIds_.Clone();
			this.diceTimes_ = other.diceTimes_;
			this.propertyTriggerTimes_ = other.propertyTriggerTimes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x000DB1A2 File Offset: 0x000D93A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRecordPb Clone()
		{
			return new DangoMonopolyBoardRecordPb(this);
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060059D5 RID: 22997 RVA: 0x000DB1AA File Offset: 0x000D93AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyIds
		{
			get
			{
				return this.propertyIds_;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x000DB1B2 File Offset: 0x000D93B2
		// (set) Token: 0x060059D7 RID: 22999 RVA: 0x000DB1BA File Offset: 0x000D93BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiceTimes
		{
			get
			{
				return this.diceTimes_;
			}
			set
			{
				this.diceTimes_ = value;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x000DB1C3 File Offset: 0x000D93C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyTriggerTimes
		{
			get
			{
				return this.propertyTriggerTimes_;
			}
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x000DB1CB File Offset: 0x000D93CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyBoardRecordPb);
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x000DB1DC File Offset: 0x000D93DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyBoardRecordPb other)
		{
			return other != null && (other == this || (this.propertyIds_.Equals(other.propertyIds_) && this.DiceTimes == other.DiceTimes && this.PropertyTriggerTimes.Equals(other.PropertyTriggerTimes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x000DB240 File Offset: 0x000D9440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.propertyIds_.GetHashCode();
			if (this.DiceTimes != 0)
			{
				num ^= this.DiceTimes.GetHashCode();
			}
			num ^= this.PropertyTriggerTimes.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x000DB29B File Offset: 0x000D949B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x000DB2A8 File Offset: 0x000D94A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x000DB2B4 File Offset: 0x000D94B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.propertyIds_.WriteTo(ref output, DangoMonopolyBoardRecordPb._repeated_propertyIds_codec);
			if (this.DiceTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DiceTimes);
			}
			this.propertyTriggerTimes_.WriteTo(ref output, DangoMonopolyBoardRecordPb._map_propertyTriggerTimes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x000DB314 File Offset: 0x000D9514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.propertyIds_.CalculateSize(DangoMonopolyBoardRecordPb._repeated_propertyIds_codec);
			if (this.DiceTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiceTimes);
			}
			num += this.propertyTriggerTimes_.CalculateSize(DangoMonopolyBoardRecordPb._map_propertyTriggerTimes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x000DB378 File Offset: 0x000D9578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyBoardRecordPb other)
		{
			if (other == null)
			{
				return;
			}
			this.propertyIds_.Add(other.propertyIds_);
			if (other.DiceTimes != 0)
			{
				this.DiceTimes = other.DiceTimes;
			}
			this.propertyTriggerTimes_.MergeFrom(other.propertyTriggerTimes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x000DB3D6 File Offset: 0x000D95D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x000DB3E0 File Offset: 0x000D95E0
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.propertyIds_.AddEntriesFrom(ref input, DangoMonopolyBoardRecordPb._repeated_propertyIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U)
					{
						this.DiceTimes = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.propertyTriggerTimes_.AddEntriesFrom(ref input, DangoMonopolyBoardRecordPb._map_propertyTriggerTimes_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035D8 RID: 13784
		private static readonly MessageParser<DangoMonopolyBoardRecordPb> _parser = new MessageParser<DangoMonopolyBoardRecordPb>(() => new DangoMonopolyBoardRecordPb());

		// Token: 0x040035D9 RID: 13785
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035DA RID: 13786
		public const int PropertyIdsFieldNumber = 1;

		// Token: 0x040035DB RID: 13787
		private static readonly FieldCodec<int> _repeated_propertyIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040035DC RID: 13788
		private readonly RepeatedField<int> propertyIds_ = new RepeatedField<int>();

		// Token: 0x040035DD RID: 13789
		public const int DiceTimesFieldNumber = 2;

		// Token: 0x040035DE RID: 13790
		private int diceTimes_;

		// Token: 0x040035DF RID: 13791
		public const int PropertyTriggerTimesFieldNumber = 3;

		// Token: 0x040035E0 RID: 13792
		private static readonly MapField<int, int>.Codec _map_propertyTriggerTimes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040035E1 RID: 13793
		private readonly MapField<int, int> propertyTriggerTimes_ = new MapField<int, int>();
	}
}
