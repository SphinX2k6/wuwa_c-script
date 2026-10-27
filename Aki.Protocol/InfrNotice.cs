using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E8 RID: 2024
	public sealed class InfrNotice : IMessage<InfrNotice>, IMessage, IEquatable<InfrNotice>, IDeepCloneable<InfrNotice>, IBufferMessage
	{
		// Token: 0x0600B589 RID: 46473 RVA: 0x001B175D File Offset: 0x001AF95D
		[NullableContext(1)]
		public static InfrNotice Create()
		{
			return new InfrNotice();
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x0600B58A RID: 46474 RVA: 0x001B1764 File Offset: 0x001AF964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrNotice> Parser
		{
			get
			{
				return InfrNotice._parser;
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x0600B58B RID: 46475 RVA: 0x001B176B File Offset: 0x001AF96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x0600B58C RID: 46476 RVA: 0x001B176E File Offset: 0x001AF96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrNotice.Descriptor;
			}
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x001B1775 File Offset: 0x001AF975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrNotice()
		{
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x001B1780 File Offset: 0x001AF980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrNotice(InfrNotice other) : this()
		{
			this.roadId_ = other.roadId_;
			this.passerId_ = other.passerId_;
			this.giftCount_ = other.giftCount_;
			this.createTime_ = other.createTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x001B17D4 File Offset: 0x001AF9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrNotice Clone()
		{
			return new InfrNotice(this);
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x001B17DC File Offset: 0x001AF9DC
		// (set) Token: 0x0600B591 RID: 46481 RVA: 0x001B17E4 File Offset: 0x001AF9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoadId
		{
			get
			{
				return this.roadId_;
			}
			set
			{
				this.roadId_ = value;
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x0600B592 RID: 46482 RVA: 0x001B17ED File Offset: 0x001AF9ED
		// (set) Token: 0x0600B593 RID: 46483 RVA: 0x001B17F5 File Offset: 0x001AF9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PasserId
		{
			get
			{
				return this.passerId_;
			}
			set
			{
				this.passerId_ = value;
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x0600B594 RID: 46484 RVA: 0x001B17FE File Offset: 0x001AF9FE
		// (set) Token: 0x0600B595 RID: 46485 RVA: 0x001B1806 File Offset: 0x001AFA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GiftCount
		{
			get
			{
				return this.giftCount_;
			}
			set
			{
				this.giftCount_ = value;
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x0600B596 RID: 46486 RVA: 0x001B180F File Offset: 0x001AFA0F
		// (set) Token: 0x0600B597 RID: 46487 RVA: 0x001B1817 File Offset: 0x001AFA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x0600B598 RID: 46488 RVA: 0x001B1820 File Offset: 0x001AFA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrNotice);
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x001B1830 File Offset: 0x001AFA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrNotice other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && this.PasserId == other.PasserId && this.GiftCount == other.GiftCount && this.CreateTime == other.CreateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B59A RID: 46490 RVA: 0x001B189C File Offset: 0x001AFA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoadId != 0)
			{
				num ^= this.RoadId.GetHashCode();
			}
			if (this.PasserId != 0)
			{
				num ^= this.PasserId.GetHashCode();
			}
			if (this.GiftCount != 0)
			{
				num ^= this.GiftCount.GetHashCode();
			}
			if (this.CreateTime != 0L)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B59B RID: 46491 RVA: 0x001B1926 File Offset: 0x001AFB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x001B1933 File Offset: 0x001AFB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x001B193C File Offset: 0x001AFB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoadId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoadId);
			}
			if (this.PasserId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PasserId);
			}
			if (this.GiftCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GiftCount);
			}
			if (this.CreateTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B59E RID: 46494 RVA: 0x001B19CC File Offset: 0x001AFBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoadId);
			}
			if (this.PasserId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PasserId);
			}
			if (this.GiftCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftCount);
			}
			if (this.CreateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B59F RID: 46495 RVA: 0x001B1A54 File Offset: 0x001AFC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrNotice other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoadId != 0)
			{
				this.RoadId = other.RoadId;
			}
			if (other.PasserId != 0)
			{
				this.PasserId = other.PasserId;
			}
			if (other.GiftCount != 0)
			{
				this.GiftCount = other.GiftCount;
			}
			if (other.CreateTime != 0L)
			{
				this.CreateTime = other.CreateTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5A0 RID: 46496 RVA: 0x001B1ACC File Offset: 0x001AFCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5A1 RID: 46497 RVA: 0x001B1AD8 File Offset: 0x001AFCD8
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
						this.RoadId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.PasserId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.GiftCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CreateTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005088 RID: 20616
		private static readonly MessageParser<InfrNotice> _parser = new MessageParser<InfrNotice>(() => new InfrNotice());

		// Token: 0x04005089 RID: 20617
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400508A RID: 20618
		public const int RoadIdFieldNumber = 1;

		// Token: 0x0400508B RID: 20619
		private int roadId_;

		// Token: 0x0400508C RID: 20620
		public const int PasserIdFieldNumber = 2;

		// Token: 0x0400508D RID: 20621
		private int passerId_;

		// Token: 0x0400508E RID: 20622
		public const int GiftCountFieldNumber = 3;

		// Token: 0x0400508F RID: 20623
		private int giftCount_;

		// Token: 0x04005090 RID: 20624
		public const int CreateTimeFieldNumber = 4;

		// Token: 0x04005091 RID: 20625
		private long createTime_;
	}
}
