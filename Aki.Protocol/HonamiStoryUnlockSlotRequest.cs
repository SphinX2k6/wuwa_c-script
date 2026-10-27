using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AB RID: 1963
	[NetMessage(EMessageId.HonamiStoryUnlockSlotRequest)]
	public sealed class HonamiStoryUnlockSlotRequest : IMessage<HonamiStoryUnlockSlotRequest>, IMessage, IEquatable<HonamiStoryUnlockSlotRequest>, IDeepCloneable<HonamiStoryUnlockSlotRequest>, IBufferMessage
	{
		// Token: 0x0600B0DD RID: 45277 RVA: 0x001A8001 File Offset: 0x001A6201
		[NullableContext(1)]
		public static HonamiStoryUnlockSlotRequest Create()
		{
			return new HonamiStoryUnlockSlotRequest();
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x0600B0DE RID: 45278 RVA: 0x001A8008 File Offset: 0x001A6208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x0600B0DF RID: 45279 RVA: 0x001A800B File Offset: 0x001A620B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryUnlockSlotRequest.Descriptor;
			}
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x001A8012 File Offset: 0x001A6212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotRequest()
		{
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x001A801A File Offset: 0x001A621A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotRequest(HonamiStoryUnlockSlotRequest other) : this()
		{
			this.slotId_ = other.slotId_;
			this.rackIndex_ = other.rackIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0E2 RID: 45282 RVA: 0x001A804B File Offset: 0x001A624B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryUnlockSlotRequest Clone()
		{
			return new HonamiStoryUnlockSlotRequest(this);
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x0600B0E3 RID: 45283 RVA: 0x001A8053 File Offset: 0x001A6253
		// (set) Token: 0x0600B0E4 RID: 45284 RVA: 0x001A805B File Offset: 0x001A625B
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

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x0600B0E5 RID: 45285 RVA: 0x001A8064 File Offset: 0x001A6264
		// (set) Token: 0x0600B0E6 RID: 45286 RVA: 0x001A806C File Offset: 0x001A626C
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

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x001A8075 File Offset: 0x001A6275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryUnlockSlotRequest);
		}

		// Token: 0x0600B0E8 RID: 45288 RVA: 0x001A8083 File Offset: 0x001A6283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryUnlockSlotRequest other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.RackIndex == other.RackIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0E9 RID: 45289 RVA: 0x001A80C4 File Offset: 0x001A62C4
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

		// Token: 0x0600B0EA RID: 45290 RVA: 0x001A811C File Offset: 0x001A631C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0EB RID: 45291 RVA: 0x001A8129 File Offset: 0x001A6329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0EC RID: 45292 RVA: 0x001A8134 File Offset: 0x001A6334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RackIndex);
			}
			if (this.SlotId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x001A8190 File Offset: 0x001A6390
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

		// Token: 0x0600B0EE RID: 45294 RVA: 0x001A81E8 File Offset: 0x001A63E8
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

		// Token: 0x0600B0EF RID: 45295 RVA: 0x001A8238 File Offset: 0x001A6438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0F0 RID: 45296 RVA: 0x001A8244 File Offset: 0x001A6444
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
				if (num != 56U)
				{
					if (num != 104U)
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

		// Token: 0x04004F5E RID: 20318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F5F RID: 20319
		public const int SlotIdFieldNumber = 13;

		// Token: 0x04004F60 RID: 20320
		private int slotId_;

		// Token: 0x04004F61 RID: 20321
		public const int RackIndexFieldNumber = 7;

		// Token: 0x04004F62 RID: 20322
		private int rackIndex_;
	}
}
