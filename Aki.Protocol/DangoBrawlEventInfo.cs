using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000341 RID: 833
	public sealed class DangoBrawlEventInfo : IMessage<DangoBrawlEventInfo>, IMessage, IEquatable<DangoBrawlEventInfo>, IDeepCloneable<DangoBrawlEventInfo>, IBufferMessage
	{
		// Token: 0x06005377 RID: 21367 RVA: 0x000CB8AE File Offset: 0x000C9AAE
		[NullableContext(1)]
		public static DangoBrawlEventInfo Create()
		{
			return new DangoBrawlEventInfo();
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x000CB8B5 File Offset: 0x000C9AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x000CB8B8 File Offset: 0x000C9AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventInfo.Descriptor;
			}
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x000CB8BF File Offset: 0x000C9ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventInfo()
		{
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x000CB8D2 File Offset: 0x000C9AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventInfo(DangoBrawlEventInfo other) : this()
		{
			this.slots_ = other.slots_.Clone();
			this.perSlotRefreshLimit_ = other.perSlotRefreshLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x000CB908 File Offset: 0x000C9B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventInfo Clone()
		{
			return new DangoBrawlEventInfo(this);
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x0600537D RID: 21373 RVA: 0x000CB910 File Offset: 0x000C9B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlEventSlotInfo> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x000CB918 File Offset: 0x000C9B18
		// (set) Token: 0x0600537F RID: 21375 RVA: 0x000CB920 File Offset: 0x000C9B20
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

		// Token: 0x06005380 RID: 21376 RVA: 0x000CB929 File Offset: 0x000C9B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventInfo);
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x000CB938 File Offset: 0x000C9B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventInfo other)
		{
			return other != null && (other == this || (this.slots_.Equals(other.slots_) && this.PerSlotRefreshLimit == other.PerSlotRefreshLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x000CB988 File Offset: 0x000C9B88
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

		// Token: 0x06005383 RID: 21379 RVA: 0x000CB9D5 File Offset: 0x000C9BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x000CB9E2 File Offset: 0x000C9BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x000CB9EC File Offset: 0x000C9BEC
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

		// Token: 0x06005386 RID: 21382 RVA: 0x000CBA3C File Offset: 0x000C9C3C
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

		// Token: 0x06005387 RID: 21383 RVA: 0x000CBA90 File Offset: 0x000C9C90
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

		// Token: 0x06005388 RID: 21384 RVA: 0x000CBADD File Offset: 0x000C9CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x000CBAE8 File Offset: 0x000C9CE8
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

		// Token: 0x0400337F RID: 13183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003380 RID: 13184
		public const int SlotsFieldNumber = 1;

		// Token: 0x04003381 RID: 13185
		private static readonly FieldCodec<DangoBrawlEventSlotInfo> _repeated_slots_codec = FieldCodec.ForMessage<DangoBrawlEventSlotInfo>(10U, DangoBrawlEventSlotInfo.Parser);

		// Token: 0x04003382 RID: 13186
		private readonly RepeatedField<DangoBrawlEventSlotInfo> slots_ = new RepeatedField<DangoBrawlEventSlotInfo>();

		// Token: 0x04003383 RID: 13187
		public const int PerSlotRefreshLimitFieldNumber = 2;

		// Token: 0x04003384 RID: 13188
		private int perSlotRefreshLimit_;
	}
}
