using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000381 RID: 897
	public sealed class DangoMonopolyBoardRecordPb : IMessage<DangoMonopolyBoardRecordPb>, IMessage, IEquatable<DangoMonopolyBoardRecordPb>, IDeepCloneable<DangoMonopolyBoardRecordPb>, IBufferMessage
	{
		// Token: 0x060058E1 RID: 22753 RVA: 0x000D8A91 File Offset: 0x000D6C91
		[NullableContext(1)]
		public static DangoMonopolyBoardRecordPb Create()
		{
			return new DangoMonopolyBoardRecordPb();
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x000D8A98 File Offset: 0x000D6C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoMonopolyBoardRecordPb> Parser
		{
			get
			{
				return DangoMonopolyBoardRecordPb._parser;
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060058E3 RID: 22755 RVA: 0x000D8A9F File Offset: 0x000D6C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x000D8AA2 File Offset: 0x000D6CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyBoardRecordPb.Descriptor;
			}
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x000D8AA9 File Offset: 0x000D6CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRecordPb()
		{
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x000D8AC8 File Offset: 0x000D6CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRecordPb(DangoMonopolyBoardRecordPb other) : this()
		{
			this.propertyIds_ = other.propertyIds_.Clone();
			this.diceTimes_ = other.diceTimes_;
			this.propertyTriggerTimes_ = other.propertyTriggerTimes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x000D8B1A File Offset: 0x000D6D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyBoardRecordPb Clone()
		{
			return new DangoMonopolyBoardRecordPb(this);
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x000D8B22 File Offset: 0x000D6D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PropertyIds
		{
			get
			{
				return this.propertyIds_;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060058E9 RID: 22761 RVA: 0x000D8B2A File Offset: 0x000D6D2A
		// (set) Token: 0x060058EA RID: 22762 RVA: 0x000D8B32 File Offset: 0x000D6D32
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

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060058EB RID: 22763 RVA: 0x000D8B3B File Offset: 0x000D6D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PropertyTriggerTimes
		{
			get
			{
				return this.propertyTriggerTimes_;
			}
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x000D8B43 File Offset: 0x000D6D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyBoardRecordPb);
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x000D8B54 File Offset: 0x000D6D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyBoardRecordPb other)
		{
			return other != null && (other == this || (this.propertyIds_.Equals(other.propertyIds_) && this.DiceTimes == other.DiceTimes && this.PropertyTriggerTimes.Equals(other.PropertyTriggerTimes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x000D8BB8 File Offset: 0x000D6DB8
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

		// Token: 0x060058EF RID: 22767 RVA: 0x000D8C13 File Offset: 0x000D6E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x000D8C20 File Offset: 0x000D6E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x000D8C2C File Offset: 0x000D6E2C
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

		// Token: 0x060058F2 RID: 22770 RVA: 0x000D8C8C File Offset: 0x000D6E8C
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

		// Token: 0x060058F3 RID: 22771 RVA: 0x000D8CF0 File Offset: 0x000D6EF0
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

		// Token: 0x060058F4 RID: 22772 RVA: 0x000D8D4E File Offset: 0x000D6F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x000D8D58 File Offset: 0x000D6F58
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

		// Token: 0x0400353C RID: 13628
		private static readonly MessageParser<DangoMonopolyBoardRecordPb> _parser = new MessageParser<DangoMonopolyBoardRecordPb>(() => new DangoMonopolyBoardRecordPb());

		// Token: 0x0400353D RID: 13629
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400353E RID: 13630
		public const int PropertyIdsFieldNumber = 1;

		// Token: 0x0400353F RID: 13631
		private static readonly FieldCodec<int> _repeated_propertyIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003540 RID: 13632
		private readonly RepeatedField<int> propertyIds_ = new RepeatedField<int>();

		// Token: 0x04003541 RID: 13633
		public const int DiceTimesFieldNumber = 2;

		// Token: 0x04003542 RID: 13634
		private int diceTimes_;

		// Token: 0x04003543 RID: 13635
		public const int PropertyTriggerTimesFieldNumber = 3;

		// Token: 0x04003544 RID: 13636
		private static readonly MapField<int, int>.Codec _map_propertyTriggerTimes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04003545 RID: 13637
		private readonly MapField<int, int> propertyTriggerTimes_ = new MapField<int, int>();
	}
}
