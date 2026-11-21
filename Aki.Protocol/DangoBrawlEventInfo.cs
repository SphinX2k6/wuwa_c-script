using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000349 RID: 841
	public sealed class DangoBrawlEventInfo : IMessage<DangoBrawlEventInfo>, IMessage, IEquatable<DangoBrawlEventInfo>, IDeepCloneable<DangoBrawlEventInfo>, IBufferMessage
	{
		// Token: 0x06005464 RID: 21604 RVA: 0x000CDF32 File Offset: 0x000CC132
		[NullableContext(1)]
		public static DangoBrawlEventInfo Create()
		{
			return new DangoBrawlEventInfo();
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x000CDF39 File Offset: 0x000CC139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x000CDF3C File Offset: 0x000CC13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventInfo.Descriptor;
			}
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x000CDF43 File Offset: 0x000CC143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventInfo()
		{
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x000CDF56 File Offset: 0x000CC156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventInfo(DangoBrawlEventInfo other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this.perSlotRefreshLimit_ = other.perSlotRefreshLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x000CDF8C File Offset: 0x000CC18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventInfo Clone()
		{
			return new DangoBrawlEventInfo(this);
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x000CDF94 File Offset: 0x000CC194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlEventSlotInfo> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x000CDF9C File Offset: 0x000CC19C
		// (set) Token: 0x0600546C RID: 21612 RVA: 0x000CDFA4 File Offset: 0x000CC1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PerSlotRefreshLimit
		{
			get
			{
				return this.perSlotRefreshLimit_;
			}
			set
			{
				this.perSlotRefreshLimit_ = value;
			}
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x000CDFAD File Offset: 0x000CC1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventInfo);
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x000CDFBC File Offset: 0x000CC1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventInfo other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && this.PerSlotRefreshLimit == other.PerSlotRefreshLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x000CE00C File Offset: 0x000CC20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.slots_.GetHashCode();
			if (this.PerSlotRefreshLimit != 0)
			{
				num ^= this.PerSlotRefreshLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x000CE059 File Offset: 0x000CC259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x000CE066 File Offset: 0x000CC266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x000CE070 File Offset: 0x000CC270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.slots_.WriteTo(ref output, DangoBrawlEventInfo._repeated_slots_codec);
			if (this.PerSlotRefreshLimit != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PerSlotRefreshLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x000CE0C0 File Offset: 0x000CC2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.slots_.CalculateSize(DangoBrawlEventInfo._repeated_slots_codec);
			if (this.PerSlotRefreshLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PerSlotRefreshLimit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x000CE114 File Offset: 0x000CC314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlEventInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.slots_.Add(other.slots_);
			if (other.PerSlotRefreshLimit != 0)
			{
				this.PerSlotRefreshLimit = other.PerSlotRefreshLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x000CE161 File Offset: 0x000CC361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x000CE16C File Offset: 0x000CC36C
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PerSlotRefreshLimit = input.ReadInt32();
					}
				}
				else
				{
					this.slots_.AddEntriesFrom(ref input, DangoBrawlEventInfo._repeated_slots_codec);
				}
			}
		}

		// Token: 0x0400341B RID: 13339
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400341C RID: 13340
		public const int SlotsFieldNumber = 1;

		// Token: 0x0400341D RID: 13341
		private static readonly FieldCodec<DangoBrawlEventSlotInfo> _repeated_slots_codec = FieldCodec.ForMessage<DangoBrawlEventSlotInfo>(10U, DangoBrawlEventSlotInfo.Parser);

		// Token: 0x0400341E RID: 13342
		private readonly RepeatedField<DangoBrawlEventSlotInfo> slots_ = new RepeatedField<DangoBrawlEventSlotInfo>();

		// Token: 0x0400341F RID: 13343
		public const int PerSlotRefreshLimitFieldNumber = 2;

		// Token: 0x04003420 RID: 13344
		private int perSlotRefreshLimit_;
	}
}
