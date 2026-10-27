using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000681 RID: 1665
	public sealed class FurnitureComponentPb : IMessage<FurnitureComponentPb>, IMessage, IEquatable<FurnitureComponentPb>, IDeepCloneable<FurnitureComponentPb>, IBufferMessage
	{
		// Token: 0x0600987A RID: 39034 RVA: 0x0016F588 File Offset: 0x0016D788
		[NullableContext(1)]
		public static FurnitureComponentPb Create()
		{
			return new FurnitureComponentPb();
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x0600987B RID: 39035 RVA: 0x0016F58F File Offset: 0x0016D78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x0600987C RID: 39036 RVA: 0x0016F592 File Offset: 0x0016D792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureComponentPb.Descriptor;
			}
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0016F599 File Offset: 0x0016D799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureComponentPb()
		{
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x0016F5A1 File Offset: 0x0016D7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureComponentPb(FurnitureComponentPb other) : this()
		{
			this.slotId_ = other.slotId_;
			this.furnitureId_ = other.furnitureId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x0016F5D2 File Offset: 0x0016D7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureComponentPb Clone()
		{
			return new FurnitureComponentPb(this);
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06009880 RID: 39040 RVA: 0x0016F5DA File Offset: 0x0016D7DA
		// (set) Token: 0x06009881 RID: 39041 RVA: 0x0016F5E2 File Offset: 0x0016D7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06009882 RID: 39042 RVA: 0x0016F5EB File Offset: 0x0016D7EB
		// (set) Token: 0x06009883 RID: 39043 RVA: 0x0016F5F3 File Offset: 0x0016D7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FurnitureId
		{
			get
			{
				return this.furnitureId_;
			}
			set
			{
				this.furnitureId_ = value;
			}
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x0016F5FC File Offset: 0x0016D7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureComponentPb);
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x0016F60A File Offset: 0x0016D80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureComponentPb other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.FurnitureId == other.FurnitureId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009886 RID: 39046 RVA: 0x0016F648 File Offset: 0x0016D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.FurnitureId != 0)
			{
				num ^= this.FurnitureId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009887 RID: 39047 RVA: 0x0016F6A0 File Offset: 0x0016D8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x0016F6AD File Offset: 0x0016D8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009889 RID: 39049 RVA: 0x0016F6B8 File Offset: 0x0016D8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotId);
			}
			if (this.FurnitureId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FurnitureId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600988A RID: 39050 RVA: 0x0016F710 File Offset: 0x0016D910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.FurnitureId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FurnitureId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600988B RID: 39051 RVA: 0x0016F768 File Offset: 0x0016D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.FurnitureId != 0)
			{
				this.FurnitureId = other.FurnitureId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x0016F7B8 File Offset: 0x0016D9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x0016F7C4 File Offset: 0x0016D9C4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FurnitureId = input.ReadInt32();
					}
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004844 RID: 18500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004845 RID: 18501
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04004846 RID: 18502
		private int slotId_;

		// Token: 0x04004847 RID: 18503
		public const int FurnitureIdFieldNumber = 2;

		// Token: 0x04004848 RID: 18504
		private int furnitureId_;
	}
}
