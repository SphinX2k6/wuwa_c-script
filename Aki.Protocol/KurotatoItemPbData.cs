using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088A RID: 2186
	public sealed class KurotatoItemPbData : IMessage<KurotatoItemPbData>, IMessage, IEquatable<KurotatoItemPbData>, IDeepCloneable<KurotatoItemPbData>, IBufferMessage
	{
		// Token: 0x0600C2AA RID: 49834 RVA: 0x001CE32D File Offset: 0x001CC52D
		[NullableContext(1)]
		public static KurotatoItemPbData Create()
		{
			return new KurotatoItemPbData();
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x0600C2AB RID: 49835 RVA: 0x001CE334 File Offset: 0x001CC534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoItemPbData> Parser
		{
			get
			{
				return KurotatoItemPbData._parser;
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x0600C2AC RID: 49836 RVA: 0x001CE33B File Offset: 0x001CC53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x0600C2AD RID: 49837 RVA: 0x001CE33E File Offset: 0x001CC53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemPbData.Descriptor;
			}
		}

		// Token: 0x0600C2AE RID: 49838 RVA: 0x001CE345 File Offset: 0x001CC545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPbData()
		{
		}

		// Token: 0x0600C2AF RID: 49839 RVA: 0x001CE34D File Offset: 0x001CC54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPbData(KurotatoItemPbData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.preWaveDealtDamage_ = other.preWaveDealtDamage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2B0 RID: 49840 RVA: 0x001CE38A File Offset: 0x001CC58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPbData Clone()
		{
			return new KurotatoItemPbData(this);
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x0600C2B1 RID: 49841 RVA: 0x001CE392 File Offset: 0x001CC592
		// (set) Token: 0x0600C2B2 RID: 49842 RVA: 0x001CE39A File Offset: 0x001CC59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x0600C2B3 RID: 49843 RVA: 0x001CE3A3 File Offset: 0x001CC5A3
		// (set) Token: 0x0600C2B4 RID: 49844 RVA: 0x001CE3AB File Offset: 0x001CC5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x0600C2B5 RID: 49845 RVA: 0x001CE3B4 File Offset: 0x001CC5B4
		// (set) Token: 0x0600C2B6 RID: 49846 RVA: 0x001CE3BC File Offset: 0x001CC5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreWaveDealtDamage
		{
			get
			{
				return this.preWaveDealtDamage_;
			}
			set
			{
				this.preWaveDealtDamage_ = value;
			}
		}

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x001CE3C5 File Offset: 0x001CC5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemPbData);
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x001CE3D4 File Offset: 0x001CC5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemPbData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.PreWaveDealtDamage == other.PreWaveDealtDamage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2B9 RID: 49849 RVA: 0x001CE430 File Offset: 0x001CC630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.PreWaveDealtDamage != 0)
			{
				num ^= this.PreWaveDealtDamage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2BA RID: 49850 RVA: 0x001CE4A1 File Offset: 0x001CC6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x001CE4AE File Offset: 0x001CC6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2BC RID: 49852 RVA: 0x001CE4B8 File Offset: 0x001CC6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.PreWaveDealtDamage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PreWaveDealtDamage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x001CE52C File Offset: 0x001CC72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.PreWaveDealtDamage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreWaveDealtDamage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2BE RID: 49854 RVA: 0x001CE59C File Offset: 0x001CC79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.PreWaveDealtDamage != 0)
			{
				this.PreWaveDealtDamage = other.PreWaveDealtDamage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2BF RID: 49855 RVA: 0x001CE600 File Offset: 0x001CC800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2C0 RID: 49856 RVA: 0x001CE60C File Offset: 0x001CC80C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PreWaveDealtDamage = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400548F RID: 21647
		private static readonly MessageParser<KurotatoItemPbData> _parser = new MessageParser<KurotatoItemPbData>(() => new KurotatoItemPbData());

		// Token: 0x04005490 RID: 21648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005491 RID: 21649
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04005492 RID: 21650
		private int itemId_;

		// Token: 0x04005493 RID: 21651
		public const int CountFieldNumber = 2;

		// Token: 0x04005494 RID: 21652
		private int count_;

		// Token: 0x04005495 RID: 21653
		public const int PreWaveDealtDamageFieldNumber = 3;

		// Token: 0x04005496 RID: 21654
		private int preWaveDealtDamage_;
	}
}
