using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AC RID: 1964
	[NetMessage(EMessageId.HonamiStoryUnlockSlotResponse)]
	public sealed class HonamiStoryUnlockSlotResponse : IMessage<HonamiStoryUnlockSlotResponse>, IMessage, IEquatable<HonamiStoryUnlockSlotResponse>, IDeepCloneable<HonamiStoryUnlockSlotResponse>, IBufferMessage
	{
		// Token: 0x0600B0F1 RID: 45297 RVA: 0x001A829C File Offset: 0x001A649C
		[NullableContext(1)]
		public static HonamiStoryUnlockSlotResponse Create()
		{
			return new HonamiStoryUnlockSlotResponse();
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x0600B0F2 RID: 45298 RVA: 0x001A82A3 File Offset: 0x001A64A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x0600B0F3 RID: 45299 RVA: 0x001A82A6 File Offset: 0x001A64A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryUnlockSlotResponse.Descriptor;
			}
		}

		// Token: 0x0600B0F4 RID: 45300 RVA: 0x001A82AD File Offset: 0x001A64AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotResponse()
		{
		}

		// Token: 0x0600B0F5 RID: 45301 RVA: 0x001A82B5 File Offset: 0x001A64B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotResponse(HonamiStoryUnlockSlotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.slotId_ = other.slotId_;
			this.rackIndex_ = other.rackIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0F6 RID: 45302 RVA: 0x001A82F2 File Offset: 0x001A64F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotResponse Clone()
		{
			return new HonamiStoryUnlockSlotResponse(this);
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x001A82FA File Offset: 0x001A64FA
		// (set) Token: 0x0600B0F8 RID: 45304 RVA: 0x001A8302 File Offset: 0x001A6502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x0600B0F9 RID: 45305 RVA: 0x001A830B File Offset: 0x001A650B
		// (set) Token: 0x0600B0FA RID: 45306 RVA: 0x001A8313 File Offset: 0x001A6513
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

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x0600B0FB RID: 45307 RVA: 0x001A831C File Offset: 0x001A651C
		// (set) Token: 0x0600B0FC RID: 45308 RVA: 0x001A8324 File Offset: 0x001A6524
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

		// Token: 0x0600B0FD RID: 45309 RVA: 0x001A832D File Offset: 0x001A652D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryUnlockSlotResponse);
		}

		// Token: 0x0600B0FE RID: 45310 RVA: 0x001A833C File Offset: 0x001A653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryUnlockSlotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SlotId == other.SlotId && this.RackIndex == other.RackIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x001A8398 File Offset: 0x001A6598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
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

		// Token: 0x0600B100 RID: 45312 RVA: 0x001A840F File Offset: 0x001A660F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x001A841C File Offset: 0x001A661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x001A8428 File Offset: 0x001A6628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RackIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x001A849C File Offset: 0x001A669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
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

		// Token: 0x0600B104 RID: 45316 RVA: 0x001A850C File Offset: 0x001A670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryUnlockSlotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
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

		// Token: 0x0600B105 RID: 45317 RVA: 0x001A8570 File Offset: 0x001A6770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B106 RID: 45318 RVA: 0x001A857C File Offset: 0x001A677C
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
					if (num != 40U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RackIndex = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F63 RID: 20323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F64 RID: 20324
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004F65 RID: 20325
		private ErrorCode errorCode_;

		// Token: 0x04004F66 RID: 20326
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04004F67 RID: 20327
		private int slotId_;

		// Token: 0x04004F68 RID: 20328
		public const int RackIndexFieldNumber = 8;

		// Token: 0x04004F69 RID: 20329
		private int rackIndex_;
	}
}
