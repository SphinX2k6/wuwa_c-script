using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000791 RID: 1937
	public sealed class HonamiStorySlotInfo : IMessage<HonamiStorySlotInfo>, IMessage, IEquatable<HonamiStorySlotInfo>, IDeepCloneable<HonamiStorySlotInfo>, IBufferMessage
	{
		// Token: 0x0600AF0D RID: 44813 RVA: 0x001A4757 File Offset: 0x001A2957
		[NullableContext(1)]
		public static HonamiStorySlotInfo Create()
		{
			return new HonamiStorySlotInfo();
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x0600AF0E RID: 44814 RVA: 0x001A475E File Offset: 0x001A295E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStorySlotInfo> Parser
		{
			get
			{
				return HonamiStorySlotInfo._parser;
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x0600AF0F RID: 44815 RVA: 0x001A4765 File Offset: 0x001A2965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x0600AF10 RID: 44816 RVA: 0x001A4768 File Offset: 0x001A2968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySlotInfo.Descriptor;
			}
		}

		// Token: 0x0600AF11 RID: 44817 RVA: 0x001A476F File Offset: 0x001A296F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySlotInfo()
		{
		}

		// Token: 0x0600AF12 RID: 44818 RVA: 0x001A4777 File Offset: 0x001A2977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySlotInfo(HonamiStorySlotInfo other) : this()
		{
			this.slotId_ = other.slotId_;
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF13 RID: 44819 RVA: 0x001A47A8 File Offset: 0x001A29A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySlotInfo Clone()
		{
			return new HonamiStorySlotInfo(this);
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x0600AF14 RID: 44820 RVA: 0x001A47B0 File Offset: 0x001A29B0
		// (set) Token: 0x0600AF15 RID: 44821 RVA: 0x001A47B8 File Offset: 0x001A29B8
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

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x001A47C1 File Offset: 0x001A29C1
		// (set) Token: 0x0600AF17 RID: 44823 RVA: 0x001A47C9 File Offset: 0x001A29C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x0600AF18 RID: 44824 RVA: 0x001A47D2 File Offset: 0x001A29D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySlotInfo);
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x001A47E0 File Offset: 0x001A29E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySlotInfo other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x001A4820 File Offset: 0x001A2A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x001A4878 File Offset: 0x001A2A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF1C RID: 44828 RVA: 0x001A4885 File Offset: 0x001A2A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF1D RID: 44829 RVA: 0x001A4890 File Offset: 0x001A2A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x001A48E8 File Offset: 0x001A2AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x001A4934 File Offset: 0x001A2B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStorySlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF20 RID: 44832 RVA: 0x001A4984 File Offset: 0x001A2B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF21 RID: 44833 RVA: 0x001A4990 File Offset: 0x001A2B90
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
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F38 RID: 20280
		private static readonly MessageParser<HonamiStorySlotInfo> _parser = new MessageParser<HonamiStorySlotInfo>(() => new HonamiStorySlotInfo());

		// Token: 0x04004F39 RID: 20281
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F3A RID: 20282
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04004F3B RID: 20283
		private int slotId_;

		// Token: 0x04004F3C RID: 20284
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04004F3D RID: 20285
		private bool isUnlock_;
	}
}
