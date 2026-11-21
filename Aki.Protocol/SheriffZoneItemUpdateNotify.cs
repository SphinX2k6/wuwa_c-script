using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001224 RID: 4644
	[NetMessage(EMessageId.SheriffZoneItemUpdateNotify)]
	public sealed class SheriffZoneItemUpdateNotify : IMessage<SheriffZoneItemUpdateNotify>, IMessage, IEquatable<SheriffZoneItemUpdateNotify>, IDeepCloneable<SheriffZoneItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018CCC RID: 101580 RVA: 0x0039D590 File Offset: 0x0039B790
		[NullableContext(1)]
		public static SheriffZoneItemUpdateNotify Create()
		{
			return new SheriffZoneItemUpdateNotify();
		}

		// Token: 0x170053BF RID: 21439
		// (get) Token: 0x06018CCD RID: 101581 RVA: 0x0039D597 File Offset: 0x0039B797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x06018CCE RID: 101582 RVA: 0x0039D59A File Offset: 0x0039B79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018CCF RID: 101583 RVA: 0x0039D5A1 File Offset: 0x0039B7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneItemUpdateNotify()
		{
		}

		// Token: 0x06018CD0 RID: 101584 RVA: 0x0039D5A9 File Offset: 0x0039B7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneItemUpdateNotify(SheriffZoneItemUpdateNotify other) : this()
		{
			this.zoneId_ = other.zoneId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CD1 RID: 101585 RVA: 0x0039D5DA File Offset: 0x0039B7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneItemUpdateNotify Clone()
		{
			return new SheriffZoneItemUpdateNotify(this);
		}

		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x06018CD2 RID: 101586 RVA: 0x0039D5E2 File Offset: 0x0039B7E2
		// (set) Token: 0x06018CD3 RID: 101587 RVA: 0x0039D5EA File Offset: 0x0039B7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ZoneId
		{
			get
			{
				return this.zoneId_;
			}
			set
			{
				this.zoneId_ = value;
			}
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x06018CD4 RID: 101588 RVA: 0x0039D5F3 File Offset: 0x0039B7F3
		// (set) Token: 0x06018CD5 RID: 101589 RVA: 0x0039D5FB File Offset: 0x0039B7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x06018CD6 RID: 101590 RVA: 0x0039D604 File Offset: 0x0039B804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneItemUpdateNotify);
		}

		// Token: 0x06018CD7 RID: 101591 RVA: 0x0039D612 File Offset: 0x0039B812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneItemUpdateNotify other)
		{
			return other != null && (other == this || (this.ZoneId == other.ZoneId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CD8 RID: 101592 RVA: 0x0039D650 File Offset: 0x0039B850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ZoneId != 0)
			{
				num ^= this.ZoneId.GetHashCode();
			}
			if (this.ItemCount != 0L)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CD9 RID: 101593 RVA: 0x0039D6A8 File Offset: 0x0039B8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CDA RID: 101594 RVA: 0x0039D6B5 File Offset: 0x0039B8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CDB RID: 101595 RVA: 0x0039D6C0 File Offset: 0x0039B8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemCount != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ItemCount);
			}
			if (this.ZoneId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ZoneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CDC RID: 101596 RVA: 0x0039D718 File Offset: 0x0039B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ZoneId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ZoneId);
			}
			if (this.ItemCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CDD RID: 101597 RVA: 0x0039D770 File Offset: 0x0039B970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffZoneItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ZoneId != 0)
			{
				this.ZoneId = other.ZoneId;
			}
			if (other.ItemCount != 0L)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CDE RID: 101598 RVA: 0x0039D7C0 File Offset: 0x0039B9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CDF RID: 101599 RVA: 0x0039D7CC File Offset: 0x0039B9CC
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ZoneId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemCount = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009325 RID: 37669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009326 RID: 37670
		public const int ZoneIdFieldNumber = 4;

		// Token: 0x04009327 RID: 37671
		private int zoneId_;

		// Token: 0x04009328 RID: 37672
		public const int ItemCountFieldNumber = 1;

		// Token: 0x04009329 RID: 37673
		private long itemCount_;
	}
}
