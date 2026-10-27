using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000684 RID: 1668
	public sealed class FurnitureDiySlotInfo : IMessage<FurnitureDiySlotInfo>, IMessage, IEquatable<FurnitureDiySlotInfo>, IDeepCloneable<FurnitureDiySlotInfo>, IBufferMessage
	{
		// Token: 0x060098BA RID: 39098 RVA: 0x0016FEB0 File Offset: 0x0016E0B0
		[NullableContext(1)]
		public static FurnitureDiySlotInfo Create()
		{
			return new FurnitureDiySlotInfo();
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x060098BB RID: 39099 RVA: 0x0016FEB7 File Offset: 0x0016E0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FurnitureDiySlotInfo> Parser
		{
			get
			{
				return FurnitureDiySlotInfo._parser;
			}
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x060098BC RID: 39100 RVA: 0x0016FEBE File Offset: 0x0016E0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x060098BD RID: 39101 RVA: 0x0016FEC1 File Offset: 0x0016E0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureDiySlotInfo.Descriptor;
			}
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x0016FEC8 File Offset: 0x0016E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySlotInfo()
		{
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x0016FEDC File Offset: 0x0016E0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySlotInfo(FurnitureDiySlotInfo other) : this()
		{
			this.slotEntityCfgId_ = other.slotEntityCfgId_;
			this.rootFurnitureId_ = other.rootFurnitureId_;
			this.subFurnitureIds_ = other.subFurnitureIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x0016FF29 File Offset: 0x0016E129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureDiySlotInfo Clone()
		{
			return new FurnitureDiySlotInfo(this);
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x060098C1 RID: 39105 RVA: 0x0016FF31 File Offset: 0x0016E131
		// (set) Token: 0x060098C2 RID: 39106 RVA: 0x0016FF39 File Offset: 0x0016E139
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

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x060098C3 RID: 39107 RVA: 0x0016FF42 File Offset: 0x0016E142
		// (set) Token: 0x060098C4 RID: 39108 RVA: 0x0016FF4A File Offset: 0x0016E14A
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

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x060098C5 RID: 39109 RVA: 0x0016FF53 File Offset: 0x0016E153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SubFurnitureIds
		{
			get
			{
				return this.subFurnitureIds_;
			}
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x0016FF5B File Offset: 0x0016E15B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureDiySlotInfo);
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x0016FF6C File Offset: 0x0016E16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureDiySlotInfo other)
		{
			return other != null && (other == this || (this.SlotEntityCfgId == other.SlotEntityCfgId && this.RootFurnitureId == other.RootFurnitureId && this.subFurnitureIds_.Equals(other.subFurnitureIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x0016FFCC File Offset: 0x0016E1CC
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

		// Token: 0x060098C9 RID: 39113 RVA: 0x00170032 File Offset: 0x0016E232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098CA RID: 39114 RVA: 0x0017003F File Offset: 0x0016E23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098CB RID: 39115 RVA: 0x00170048 File Offset: 0x0016E248
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

		// Token: 0x060098CC RID: 39116 RVA: 0x001700B4 File Offset: 0x0016E2B4
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

		// Token: 0x060098CD RID: 39117 RVA: 0x00170120 File Offset: 0x0016E320
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

		// Token: 0x060098CE RID: 39118 RVA: 0x00170181 File Offset: 0x0016E381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x0017018C File Offset: 0x0016E38C
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

		// Token: 0x04004858 RID: 18520
		private static readonly MessageParser<FurnitureDiySlotInfo> _parser = new MessageParser<FurnitureDiySlotInfo>(() => new FurnitureDiySlotInfo());

		// Token: 0x04004859 RID: 18521
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400485A RID: 18522
		public const int SlotEntityCfgIdFieldNumber = 1;

		// Token: 0x0400485B RID: 18523
		private int slotEntityCfgId_;

		// Token: 0x0400485C RID: 18524
		public const int RootFurnitureIdFieldNumber = 2;

		// Token: 0x0400485D RID: 18525
		private int rootFurnitureId_;

		// Token: 0x0400485E RID: 18526
		public const int SubFurnitureIdsFieldNumber = 3;

		// Token: 0x0400485F RID: 18527
		private static readonly FieldCodec<int> _repeated_subFurnitureIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004860 RID: 18528
		private readonly RepeatedField<int> subFurnitureIds_ = new RepeatedField<int>();
	}
}
