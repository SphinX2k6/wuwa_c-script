using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E74 RID: 3700
	public sealed class RangeComponentPb : IMessage<RangeComponentPb>, IMessage, IEquatable<RangeComponentPb>, IDeepCloneable<RangeComponentPb>, IBufferMessage
	{
		// Token: 0x06013E6A RID: 81514 RVA: 0x002E66F3 File Offset: 0x002E48F3
		[NullableContext(1)]
		public static RangeComponentPb Create()
		{
			return new RangeComponentPb();
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x06013E6B RID: 81515 RVA: 0x002E66FA File Offset: 0x002E48FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x06013E6C RID: 81516 RVA: 0x002E66FD File Offset: 0x002E48FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RangeComponentPb.Descriptor;
			}
		}

		// Token: 0x06013E6D RID: 81517 RVA: 0x002E6704 File Offset: 0x002E4904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RangeComponentPb()
		{
		}

		// Token: 0x06013E6E RID: 81518 RVA: 0x002E6722 File Offset: 0x002E4922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RangeComponentPb(RangeComponentPb other) : this()
		{
			this.inRangePlayers_ = other.inRangePlayers_.Clone();
			this.inRangeEntities_ = other.inRangeEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E6F RID: 81519 RVA: 0x002E675D File Offset: 0x002E495D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RangeComponentPb Clone()
		{
			return new RangeComponentPb(this);
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x06013E70 RID: 81520 RVA: 0x002E6765 File Offset: 0x002E4965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InRangePlayers
		{
			get
			{
				return this.inRangePlayers_;
			}
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x06013E71 RID: 81521 RVA: 0x002E676D File Offset: 0x002E496D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> InRangeEntities
		{
			get
			{
				return this.inRangeEntities_;
			}
		}

		// Token: 0x06013E72 RID: 81522 RVA: 0x002E6775 File Offset: 0x002E4975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RangeComponentPb);
		}

		// Token: 0x06013E73 RID: 81523 RVA: 0x002E6784 File Offset: 0x002E4984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RangeComponentPb other)
		{
			return other != null && (other == this || (this.inRangePlayers_.Equals(other.inRangePlayers_) && this.inRangeEntities_.Equals(other.inRangeEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E74 RID: 81524 RVA: 0x002E67D8 File Offset: 0x002E49D8
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

		// Token: 0x06013E75 RID: 81525 RVA: 0x002E681A File Offset: 0x002E4A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E76 RID: 81526 RVA: 0x002E6827 File Offset: 0x002E4A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E77 RID: 81527 RVA: 0x002E6830 File Offset: 0x002E4A30
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

		// Token: 0x06013E78 RID: 81528 RVA: 0x002E6868 File Offset: 0x002E4A68
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

		// Token: 0x06013E79 RID: 81529 RVA: 0x002E68B4 File Offset: 0x002E4AB4
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

		// Token: 0x06013E7A RID: 81530 RVA: 0x002E68F3 File Offset: 0x002E4AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E7B RID: 81531 RVA: 0x002E68FC File Offset: 0x002E4AFC
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

		// Token: 0x04007A14 RID: 31252
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A15 RID: 31253
		public const int InRangePlayersFieldNumber = 1;

		// Token: 0x04007A16 RID: 31254
		private static readonly FieldCodec<int> _repeated_inRangePlayers_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007A17 RID: 31255
		private readonly RepeatedField<int> inRangePlayers_ = new RepeatedField<int>();

		// Token: 0x04007A18 RID: 31256
		public const int InRangeEntitiesFieldNumber = 2;

		// Token: 0x04007A19 RID: 31257
		private static readonly FieldCodec<long> _repeated_inRangeEntities_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04007A1A RID: 31258
		private readonly RepeatedField<long> inRangeEntities_ = new RepeatedField<long>();
	}
}
