using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E84 RID: 3716
	public sealed class RangeComponentPb : IMessage<RangeComponentPb>, IMessage, IEquatable<RangeComponentPb>, IDeepCloneable<RangeComponentPb>, IBufferMessage
	{
		// Token: 0x06013F4F RID: 81743 RVA: 0x002E7DAF File Offset: 0x002E5FAF
		[NullableContext(1)]
		public static RangeComponentPb Create()
		{
			return new RangeComponentPb();
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x06013F50 RID: 81744 RVA: 0x002E7DB6 File Offset: 0x002E5FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x06013F51 RID: 81745 RVA: 0x002E7DB9 File Offset: 0x002E5FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RangeComponentPb.Descriptor;
			}
		}

		// Token: 0x06013F52 RID: 81746 RVA: 0x002E7DC0 File Offset: 0x002E5FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RangeComponentPb()
		{
		}

		// Token: 0x06013F53 RID: 81747 RVA: 0x002E7DDE File Offset: 0x002E5FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RangeComponentPb(RangeComponentPb other) : this()
		{
			this.inRangePlayers_ = other.inRangePlayers_.Clone();
			this.inRangeEntities_ = other.inRangeEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F54 RID: 81748 RVA: 0x002E7E19 File Offset: 0x002E6019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RangeComponentPb Clone()
		{
			return new RangeComponentPb(this);
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x06013F55 RID: 81749 RVA: 0x002E7E21 File Offset: 0x002E6021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InRangePlayers
		{
			get
			{
				return this.inRangePlayers_;
			}
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x06013F56 RID: 81750 RVA: 0x002E7E29 File Offset: 0x002E6029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InRangeEntities
		{
			get
			{
				return this.inRangeEntities_;
			}
		}

		// Token: 0x06013F57 RID: 81751 RVA: 0x002E7E31 File Offset: 0x002E6031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RangeComponentPb);
		}

		// Token: 0x06013F58 RID: 81752 RVA: 0x002E7E40 File Offset: 0x002E6040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RangeComponentPb other)
		{
			return other != null && (other == this || (this.inRangePlayers_.Equals(other.inRangePlayers_) && this.inRangeEntities_.Equals(other.inRangeEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F59 RID: 81753 RVA: 0x002E7E94 File Offset: 0x002E6094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.inRangePlayers_.GetHashCode();
			num ^= this.inRangeEntities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F5A RID: 81754 RVA: 0x002E7ED6 File Offset: 0x002E60D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F5B RID: 81755 RVA: 0x002E7EE3 File Offset: 0x002E60E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F5C RID: 81756 RVA: 0x002E7EEC File Offset: 0x002E60EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.inRangePlayers_.WriteTo(ref output, RangeComponentPb._repeated_inRangePlayers_codec);
			this.inRangeEntities_.WriteTo(ref output, RangeComponentPb._repeated_inRangeEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F5D RID: 81757 RVA: 0x002E7F24 File Offset: 0x002E6124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.inRangePlayers_.CalculateSize(RangeComponentPb._repeated_inRangePlayers_codec);
			num += this.inRangeEntities_.CalculateSize(RangeComponentPb._repeated_inRangeEntities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F5E RID: 81758 RVA: 0x002E7F70 File Offset: 0x002E6170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RangeComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.inRangePlayers_.Add(other.inRangePlayers_);
			this.inRangeEntities_.Add(other.inRangeEntities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F5F RID: 81759 RVA: 0x002E7FAF File Offset: 0x002E61AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F60 RID: 81760 RVA: 0x002E7FB8 File Offset: 0x002E61B8
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
						this.inRangePlayers_.AddEntriesFrom(ref input, RangeComponentPb._repeated_inRangePlayers_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.inRangeEntities_.AddEntriesFrom(ref input, RangeComponentPb._repeated_inRangeEntities_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040079EA RID: 31210
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079EB RID: 31211
		public const int InRangePlayersFieldNumber = 1;

		// Token: 0x040079EC RID: 31212
		private static readonly FieldCodec<int> _repeated_inRangePlayers_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040079ED RID: 31213
		private readonly RepeatedField<int> inRangePlayers_ = new RepeatedField<int>();

		// Token: 0x040079EE RID: 31214
		public const int InRangeEntitiesFieldNumber = 2;

		// Token: 0x040079EF RID: 31215
		private static readonly FieldCodec<long> _repeated_inRangeEntities_codec = FieldCodec.ForInt64(18U);

		// Token: 0x040079F0 RID: 31216
		private readonly RepeatedField<long> inRangeEntities_ = new RepeatedField<long>();
	}
}
