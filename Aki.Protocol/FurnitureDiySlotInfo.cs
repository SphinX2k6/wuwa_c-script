using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000670 RID: 1648
	public sealed class FurnitureDiySlotInfo : IMessage<FurnitureDiySlotInfo>, IMessage, IEquatable<FurnitureDiySlotInfo>, IDeepCloneable<FurnitureDiySlotInfo>, IBufferMessage
	{
		// Token: 0x06009764 RID: 38756 RVA: 0x0016D47B File Offset: 0x0016B67B
		[NullableContext(1)]
		public static FurnitureDiySlotInfo Create()
		{
			return new FurnitureDiySlotInfo();
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x0016D482 File Offset: 0x0016B682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FurnitureDiySlotInfo> Parser
		{
			get
			{
				return FurnitureDiySlotInfo._parser;
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06009766 RID: 38758 RVA: 0x0016D489 File Offset: 0x0016B689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06009767 RID: 38759 RVA: 0x0016D48C File Offset: 0x0016B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureDiySlotInfo.Descriptor;
			}
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x0016D493 File Offset: 0x0016B693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySlotInfo()
		{
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x0016D4A8 File Offset: 0x0016B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySlotInfo(FurnitureDiySlotInfo other) : this()
		{
			this.slotEntityCfgId_ = other.slotEntityCfgId_;
			this.rootFurnitureId_ = other.rootFurnitureId_;
			this.subFurnitureIds_ = other.subFurnitureIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x0016D4F5 File Offset: 0x0016B6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySlotInfo Clone()
		{
			return new FurnitureDiySlotInfo(this);
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600976B RID: 38763 RVA: 0x0016D4FD File Offset: 0x0016B6FD
		// (set) Token: 0x0600976C RID: 38764 RVA: 0x0016D505 File Offset: 0x0016B705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotEntityCfgId
		{
			get
			{
				return this.slotEntityCfgId_;
			}
			set
			{
				this.slotEntityCfgId_ = value;
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600976D RID: 38765 RVA: 0x0016D50E File Offset: 0x0016B70E
		// (set) Token: 0x0600976E RID: 38766 RVA: 0x0016D516 File Offset: 0x0016B716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RootFurnitureId
		{
			get
			{
				return this.rootFurnitureId_;
			}
			set
			{
				this.rootFurnitureId_ = value;
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600976F RID: 38767 RVA: 0x0016D51F File Offset: 0x0016B71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SubFurnitureIds
		{
			get
			{
				return this.subFurnitureIds_;
			}
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x0016D527 File Offset: 0x0016B727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureDiySlotInfo);
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x0016D538 File Offset: 0x0016B738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureDiySlotInfo other)
		{
			return other != null && (other == this || (this.SlotEntityCfgId == other.SlotEntityCfgId && this.RootFurnitureId == other.RootFurnitureId && this.subFurnitureIds_.Equals(other.subFurnitureIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x0016D598 File Offset: 0x0016B798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotEntityCfgId != 0)
			{
				num ^= this.SlotEntityCfgId.GetHashCode();
			}
			if (this.RootFurnitureId != 0)
			{
				num ^= this.RootFurnitureId.GetHashCode();
			}
			num ^= this.subFurnitureIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x0016D5FE File Offset: 0x0016B7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x0016D60B File Offset: 0x0016B80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x0016D614 File Offset: 0x0016B814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotEntityCfgId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotEntityCfgId);
			}
			if (this.RootFurnitureId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RootFurnitureId);
			}
			this.subFurnitureIds_.WriteTo(ref output, FurnitureDiySlotInfo._repeated_subFurnitureIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x0016D680 File Offset: 0x0016B880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotEntityCfgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotEntityCfgId);
			}
			if (this.RootFurnitureId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RootFurnitureId);
			}
			num += this.subFurnitureIds_.CalculateSize(FurnitureDiySlotInfo._repeated_subFurnitureIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x0016D6EC File Offset: 0x0016B8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureDiySlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotEntityCfgId != 0)
			{
				this.SlotEntityCfgId = other.SlotEntityCfgId;
			}
			if (other.RootFurnitureId != 0)
			{
				this.RootFurnitureId = other.RootFurnitureId;
			}
			this.subFurnitureIds_.Add(other.subFurnitureIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009778 RID: 38776 RVA: 0x0016D74D File Offset: 0x0016B94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x0016D758 File Offset: 0x0016B958
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SlotEntityCfgId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RootFurnitureId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.subFurnitureIds_.AddEntriesFrom(ref input, FurnitureDiySlotInfo._repeated_subFurnitureIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004851 RID: 18513
		private static readonly MessageParser<FurnitureDiySlotInfo> _parser = new MessageParser<FurnitureDiySlotInfo>(() => new FurnitureDiySlotInfo());

		// Token: 0x04004852 RID: 18514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004853 RID: 18515
		public const int SlotEntityCfgIdFieldNumber = 1;

		// Token: 0x04004854 RID: 18516
		private int slotEntityCfgId_;

		// Token: 0x04004855 RID: 18517
		public const int RootFurnitureIdFieldNumber = 2;

		// Token: 0x04004856 RID: 18518
		private int rootFurnitureId_;

		// Token: 0x04004857 RID: 18519
		public const int SubFurnitureIdsFieldNumber = 3;

		// Token: 0x04004858 RID: 18520
		private static readonly FieldCodec<int> _repeated_subFurnitureIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004859 RID: 18521
		private readonly RepeatedField<int> subFurnitureIds_ = new RepeatedField<int>();
	}
}
