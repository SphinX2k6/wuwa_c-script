using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000797 RID: 1943
	[NetMessage(EMessageId.HonamiStoryUnlockSlotRequest)]
	public sealed class HonamiStoryUnlockSlotRequest : IMessage<HonamiStoryUnlockSlotRequest>, IMessage, IEquatable<HonamiStoryUnlockSlotRequest>, IDeepCloneable<HonamiStoryUnlockSlotRequest>, IBufferMessage
	{
		// Token: 0x0600AF87 RID: 44935 RVA: 0x001A55D5 File Offset: 0x001A37D5
		[NullableContext(1)]
		public static HonamiStoryUnlockSlotRequest Create()
		{
			return new HonamiStoryUnlockSlotRequest();
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x001A55DC File Offset: 0x001A37DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x0600AF89 RID: 44937 RVA: 0x001A55DF File Offset: 0x001A37DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryUnlockSlotRequest.Descriptor;
			}
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x001A55E6 File Offset: 0x001A37E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotRequest()
		{
		}

		// Token: 0x0600AF8B RID: 44939 RVA: 0x001A55EE File Offset: 0x001A37EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotRequest(HonamiStoryUnlockSlotRequest other) : this()
		{
			this.slotId_ = other.slotId_;
			this.rackIndex_ = other.rackIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF8C RID: 44940 RVA: 0x001A561F File Offset: 0x001A381F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotRequest Clone()
		{
			return new HonamiStoryUnlockSlotRequest(this);
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x0600AF8D RID: 44941 RVA: 0x001A5627 File Offset: 0x001A3827
		// (set) Token: 0x0600AF8E RID: 44942 RVA: 0x001A562F File Offset: 0x001A382F
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

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x0600AF8F RID: 44943 RVA: 0x001A5638 File Offset: 0x001A3838
		// (set) Token: 0x0600AF90 RID: 44944 RVA: 0x001A5640 File Offset: 0x001A3840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RackIndex
		{
			get
			{
				return this.rackIndex_;
			}
			set
			{
				this.rackIndex_ = value;
			}
		}

		// Token: 0x0600AF91 RID: 44945 RVA: 0x001A5649 File Offset: 0x001A3849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryUnlockSlotRequest);
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x001A5657 File Offset: 0x001A3857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryUnlockSlotRequest other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.RackIndex == other.RackIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x001A5698 File Offset: 0x001A3898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.RackIndex != 0)
			{
				num ^= this.RackIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x001A56F0 File Offset: 0x001A38F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF95 RID: 44949 RVA: 0x001A56FD File Offset: 0x001A38FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF96 RID: 44950 RVA: 0x001A5708 File Offset: 0x001A3908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RackIndex);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF97 RID: 44951 RVA: 0x001A5764 File Offset: 0x001A3964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.RackIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RackIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF98 RID: 44952 RVA: 0x001A57BC File Offset: 0x001A39BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryUnlockSlotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.RackIndex != 0)
			{
				this.RackIndex = other.RackIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF99 RID: 44953 RVA: 0x001A580C File Offset: 0x001A3A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x001A5818 File Offset: 0x001A3A18
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
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SlotId = input.ReadInt32();
					}
				}
				else
				{
					this.RackIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F57 RID: 20311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F58 RID: 20312
		public const int SlotIdFieldNumber = 14;

		// Token: 0x04004F59 RID: 20313
		private int slotId_;

		// Token: 0x04004F5A RID: 20314
		public const int RackIndexFieldNumber = 4;

		// Token: 0x04004F5B RID: 20315
		private int rackIndex_;
	}
}
