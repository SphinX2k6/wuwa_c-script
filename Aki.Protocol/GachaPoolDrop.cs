using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000698 RID: 1688
	public sealed class GachaPoolDrop : IMessage<GachaPoolDrop>, IMessage, IEquatable<GachaPoolDrop>, IDeepCloneable<GachaPoolDrop>, IBufferMessage
	{
		// Token: 0x06009A89 RID: 39561 RVA: 0x00174BE3 File Offset: 0x00172DE3
		[NullableContext(1)]
		public static GachaPoolDrop Create()
		{
			return new GachaPoolDrop();
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06009A8A RID: 39562 RVA: 0x00174BEA File Offset: 0x00172DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaPoolDrop> Parser
		{
			get
			{
				return GachaPoolDrop._parser;
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06009A8B RID: 39563 RVA: 0x00174BF1 File Offset: 0x00172DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06009A8C RID: 39564 RVA: 0x00174BF4 File Offset: 0x00172DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDrop.Descriptor;
			}
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x00174BFB File Offset: 0x00172DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDrop()
		{
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x00174C03 File Offset: 0x00172E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDrop(GachaPoolDrop other) : this()
		{
			this.itemId_ = other.itemId_;
			this.isUp_ = other.isUp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x00174C34 File Offset: 0x00172E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDrop Clone()
		{
			return new GachaPoolDrop(this);
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06009A90 RID: 39568 RVA: 0x00174C3C File Offset: 0x00172E3C
		// (set) Token: 0x06009A91 RID: 39569 RVA: 0x00174C44 File Offset: 0x00172E44
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

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06009A92 RID: 39570 RVA: 0x00174C4D File Offset: 0x00172E4D
		// (set) Token: 0x06009A93 RID: 39571 RVA: 0x00174C55 File Offset: 0x00172E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUp
		{
			get
			{
				return this.isUp_;
			}
			set
			{
				this.isUp_ = value;
			}
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x00174C5E File Offset: 0x00172E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDrop);
		}

		// Token: 0x06009A95 RID: 39573 RVA: 0x00174C6C File Offset: 0x00172E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDrop other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IsUp == other.IsUp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x00174CAC File Offset: 0x00172EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IsUp)
			{
				num ^= this.IsUp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A97 RID: 39575 RVA: 0x00174D04 File Offset: 0x00172F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x00174D11 File Offset: 0x00172F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x00174D1C File Offset: 0x00172F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.IsUp)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x00174D74 File Offset: 0x00172F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IsUp)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x00174DC0 File Offset: 0x00172FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolDrop other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IsUp)
			{
				this.IsUp = other.IsUp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x00174E10 File Offset: 0x00173010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x00174E1C File Offset: 0x0017301C
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
						this.IsUp = input.ReadBool();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004912 RID: 18706
		private static readonly MessageParser<GachaPoolDrop> _parser = new MessageParser<GachaPoolDrop>(() => new GachaPoolDrop());

		// Token: 0x04004913 RID: 18707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004914 RID: 18708
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004915 RID: 18709
		private int itemId_;

		// Token: 0x04004916 RID: 18710
		public const int IsUpFieldNumber = 2;

		// Token: 0x04004917 RID: 18711
		private bool isUp_;
	}
}
