using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D4 RID: 2004
	public sealed class InfrNotice : IMessage<InfrNotice>, IMessage, IEquatable<InfrNotice>, IDeepCloneable<InfrNotice>, IBufferMessage
	{
		// Token: 0x0600B433 RID: 46131 RVA: 0x001AED29 File Offset: 0x001ACF29
		[NullableContext(1)]
		public static InfrNotice Create()
		{
			return new InfrNotice();
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x0600B434 RID: 46132 RVA: 0x001AED30 File Offset: 0x001ACF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrNotice> Parser
		{
			get
			{
				return InfrNotice._parser;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0600B435 RID: 46133 RVA: 0x001AED37 File Offset: 0x001ACF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x0600B436 RID: 46134 RVA: 0x001AED3A File Offset: 0x001ACF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrNotice.Descriptor;
			}
		}

		// Token: 0x0600B437 RID: 46135 RVA: 0x001AED41 File Offset: 0x001ACF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrNotice()
		{
		}

		// Token: 0x0600B438 RID: 46136 RVA: 0x001AED4C File Offset: 0x001ACF4C
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

		// Token: 0x0600B439 RID: 46137 RVA: 0x001AEDA0 File Offset: 0x001ACFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrNotice Clone()
		{
			return new InfrNotice(this);
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x0600B43A RID: 46138 RVA: 0x001AEDA8 File Offset: 0x001ACFA8
		// (set) Token: 0x0600B43B RID: 46139 RVA: 0x001AEDB0 File Offset: 0x001ACFB0
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

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x0600B43C RID: 46140 RVA: 0x001AEDB9 File Offset: 0x001ACFB9
		// (set) Token: 0x0600B43D RID: 46141 RVA: 0x001AEDC1 File Offset: 0x001ACFC1
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

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x0600B43E RID: 46142 RVA: 0x001AEDCA File Offset: 0x001ACFCA
		// (set) Token: 0x0600B43F RID: 46143 RVA: 0x001AEDD2 File Offset: 0x001ACFD2
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

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x001AEDDB File Offset: 0x001ACFDB
		// (set) Token: 0x0600B441 RID: 46145 RVA: 0x001AEDE3 File Offset: 0x001ACFE3
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

		// Token: 0x0600B442 RID: 46146 RVA: 0x001AEDEC File Offset: 0x001ACFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrNotice);
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x001AEDFC File Offset: 0x001ACFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrNotice other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && this.PasserId == other.PasserId && this.GiftCount == other.GiftCount && this.CreateTime == other.CreateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x001AEE68 File Offset: 0x001AD068
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

		// Token: 0x0600B445 RID: 46149 RVA: 0x001AEEF2 File Offset: 0x001AD0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x001AEEFF File Offset: 0x001AD0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x001AEF08 File Offset: 0x001AD108
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

		// Token: 0x0600B448 RID: 46152 RVA: 0x001AEF98 File Offset: 0x001AD198
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

		// Token: 0x0600B449 RID: 46153 RVA: 0x001AF020 File Offset: 0x001AD220
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

		// Token: 0x0600B44A RID: 46154 RVA: 0x001AF098 File Offset: 0x001AD298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x001AF0A4 File Offset: 0x001AD2A4
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

		// Token: 0x04005081 RID: 20609
		private static readonly MessageParser<InfrNotice> _parser = new MessageParser<InfrNotice>(() => new InfrNotice());

		// Token: 0x04005082 RID: 20610
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005083 RID: 20611
		public const int RoadIdFieldNumber = 1;

		// Token: 0x04005084 RID: 20612
		private int roadId_;

		// Token: 0x04005085 RID: 20613
		public const int PasserIdFieldNumber = 2;

		// Token: 0x04005086 RID: 20614
		private int passerId_;

		// Token: 0x04005087 RID: 20615
		public const int GiftCountFieldNumber = 3;

		// Token: 0x04005088 RID: 20616
		private int giftCount_;

		// Token: 0x04005089 RID: 20617
		public const int CreateTimeFieldNumber = 4;

		// Token: 0x0400508A RID: 20618
		private long createTime_;
	}
}
