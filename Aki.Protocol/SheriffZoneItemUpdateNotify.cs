using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E9 RID: 4585
	[NetMessage(EMessageId.SheriffZoneItemUpdateNotify)]
	public sealed class SheriffZoneItemUpdateNotify : IMessage<SheriffZoneItemUpdateNotify>, IMessage, IEquatable<SheriffZoneItemUpdateNotify>, IDeepCloneable<SheriffZoneItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018708 RID: 100104 RVA: 0x0038DA24 File Offset: 0x0038BC24
		[NullableContext(1)]
		public static SheriffZoneItemUpdateNotify Create()
		{
			return new SheriffZoneItemUpdateNotify();
		}

		// Token: 0x17005247 RID: 21063
		// (get) Token: 0x06018709 RID: 100105 RVA: 0x0038DA2B File Offset: 0x0038BC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005248 RID: 21064
		// (get) Token: 0x0601870A RID: 100106 RVA: 0x0038DA2E File Offset: 0x0038BC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601870B RID: 100107 RVA: 0x0038DA35 File Offset: 0x0038BC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneItemUpdateNotify()
		{
		}

		// Token: 0x0601870C RID: 100108 RVA: 0x0038DA3D File Offset: 0x0038BC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneItemUpdateNotify(SheriffZoneItemUpdateNotify other) : this()
		{
			this.zoneId_ = other.zoneId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601870D RID: 100109 RVA: 0x0038DA6E File Offset: 0x0038BC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneItemUpdateNotify Clone()
		{
			return new SheriffZoneItemUpdateNotify(this);
		}

		// Token: 0x17005249 RID: 21065
		// (get) Token: 0x0601870E RID: 100110 RVA: 0x0038DA76 File Offset: 0x0038BC76
		// (set) Token: 0x0601870F RID: 100111 RVA: 0x0038DA7E File Offset: 0x0038BC7E
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

		// Token: 0x1700524A RID: 21066
		// (get) Token: 0x06018710 RID: 100112 RVA: 0x0038DA87 File Offset: 0x0038BC87
		// (set) Token: 0x06018711 RID: 100113 RVA: 0x0038DA8F File Offset: 0x0038BC8F
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

		// Token: 0x06018712 RID: 100114 RVA: 0x0038DA98 File Offset: 0x0038BC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneItemUpdateNotify);
		}

		// Token: 0x06018713 RID: 100115 RVA: 0x0038DAA6 File Offset: 0x0038BCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneItemUpdateNotify other)
		{
			return other != null && (other == this || (this.ZoneId == other.ZoneId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018714 RID: 100116 RVA: 0x0038DAE4 File Offset: 0x0038BCE4
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

		// Token: 0x06018715 RID: 100117 RVA: 0x0038DB3C File Offset: 0x0038BD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018716 RID: 100118 RVA: 0x0038DB49 File Offset: 0x0038BD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018717 RID: 100119 RVA: 0x0038DB54 File Offset: 0x0038BD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ZoneId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ZoneId);
			}
			if (this.ItemCount != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018718 RID: 100120 RVA: 0x0038DBB0 File Offset: 0x0038BDB0
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

		// Token: 0x06018719 RID: 100121 RVA: 0x0038DC08 File Offset: 0x0038BE08
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

		// Token: 0x0601871A RID: 100122 RVA: 0x0038DC58 File Offset: 0x0038BE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601871B RID: 100123 RVA: 0x0038DC64 File Offset: 0x0038BE64
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
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemCount = input.ReadInt64();
					}
				}
				else
				{
					this.ZoneId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400907B RID: 36987
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400907C RID: 36988
		public const int ZoneIdFieldNumber = 2;

		// Token: 0x0400907D RID: 36989
		private int zoneId_;

		// Token: 0x0400907E RID: 36990
		public const int ItemCountFieldNumber = 13;

		// Token: 0x0400907F RID: 36991
		private long itemCount_;
	}
}
