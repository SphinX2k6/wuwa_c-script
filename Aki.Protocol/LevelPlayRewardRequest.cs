using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000907 RID: 2311
	[NetMessage(EMessageId.LevelPlayRewardRequest)]
	public sealed class LevelPlayRewardRequest : IMessage<LevelPlayRewardRequest>, IMessage, IEquatable<LevelPlayRewardRequest>, IDeepCloneable<LevelPlayRewardRequest>, IBufferMessage
	{
		// Token: 0x0600CC10 RID: 52240 RVA: 0x001E1549 File Offset: 0x001DF749
		[NullableContext(1)]
		public static LevelPlayRewardRequest Create()
		{
			return new LevelPlayRewardRequest();
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600CC11 RID: 52241 RVA: 0x001E1550 File Offset: 0x001DF750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600CC12 RID: 52242 RVA: 0x001E1553 File Offset: 0x001DF753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600CC13 RID: 52243 RVA: 0x001E155A File Offset: 0x001DF75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardRequest()
		{
		}

		// Token: 0x0600CC14 RID: 52244 RVA: 0x001E1562 File Offset: 0x001DF762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardRequest(LevelPlayRewardRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.exchangeCount_ = other.exchangeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC15 RID: 52245 RVA: 0x001E1593 File Offset: 0x001DF793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardRequest Clone()
		{
			return new LevelPlayRewardRequest(this);
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600CC16 RID: 52246 RVA: 0x001E159B File Offset: 0x001DF79B
		// (set) Token: 0x0600CC17 RID: 52247 RVA: 0x001E15A3 File Offset: 0x001DF7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600CC18 RID: 52248 RVA: 0x001E15AC File Offset: 0x001DF7AC
		// (set) Token: 0x0600CC19 RID: 52249 RVA: 0x001E15B4 File Offset: 0x001DF7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExchangeCount
		{
			get
			{
				return this.exchangeCount_;
			}
			set
			{
				this.exchangeCount_ = value;
			}
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x001E15BD File Offset: 0x001DF7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardRequest);
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x001E15CB File Offset: 0x001DF7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ExchangeCount == other.ExchangeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC1C RID: 52252 RVA: 0x001E160C File Offset: 0x001DF80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ExchangeCount != 0)
			{
				num ^= this.ExchangeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC1D RID: 52253 RVA: 0x001E1664 File Offset: 0x001DF864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC1E RID: 52254 RVA: 0x001E1671 File Offset: 0x001DF871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC1F RID: 52255 RVA: 0x001E167C File Offset: 0x001DF87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExchangeCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ExchangeCount);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC20 RID: 52256 RVA: 0x001E16D8 File Offset: 0x001DF8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ExchangeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExchangeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC21 RID: 52257 RVA: 0x001E1730 File Offset: 0x001DF930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ExchangeCount != 0)
			{
				this.ExchangeCount = other.ExchangeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC22 RID: 52258 RVA: 0x001E1780 File Offset: 0x001DF980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC23 RID: 52259 RVA: 0x001E178C File Offset: 0x001DF98C
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
				if (num != 48U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.ExchangeCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005690 RID: 22160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005691 RID: 22161
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04005692 RID: 22162
		private long entityId_;

		// Token: 0x04005693 RID: 22163
		public const int ExchangeCountFieldNumber = 6;

		// Token: 0x04005694 RID: 22164
		private int exchangeCount_;
	}
}
