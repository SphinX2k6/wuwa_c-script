using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F6 RID: 2294
	[NetMessage(EMessageId.LevelPlayRewardRequest)]
	public sealed class LevelPlayRewardRequest : IMessage<LevelPlayRewardRequest>, IMessage, IEquatable<LevelPlayRewardRequest>, IDeepCloneable<LevelPlayRewardRequest>, IBufferMessage
	{
		// Token: 0x0600CAF4 RID: 51956 RVA: 0x001DF271 File Offset: 0x001DD471
		[NullableContext(1)]
		public static LevelPlayRewardRequest Create()
		{
			return new LevelPlayRewardRequest();
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x001DF278 File Offset: 0x001DD478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0600CAF6 RID: 51958 RVA: 0x001DF27B File Offset: 0x001DD47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x001DF282 File Offset: 0x001DD482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardRequest()
		{
		}

		// Token: 0x0600CAF8 RID: 51960 RVA: 0x001DF28A File Offset: 0x001DD48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardRequest(LevelPlayRewardRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.exchangeCount_ = other.exchangeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAF9 RID: 51961 RVA: 0x001DF2BB File Offset: 0x001DD4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardRequest Clone()
		{
			return new LevelPlayRewardRequest(this);
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x0600CAFA RID: 51962 RVA: 0x001DF2C3 File Offset: 0x001DD4C3
		// (set) Token: 0x0600CAFB RID: 51963 RVA: 0x001DF2CB File Offset: 0x001DD4CB
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

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600CAFC RID: 51964 RVA: 0x001DF2D4 File Offset: 0x001DD4D4
		// (set) Token: 0x0600CAFD RID: 51965 RVA: 0x001DF2DC File Offset: 0x001DD4DC
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

		// Token: 0x0600CAFE RID: 51966 RVA: 0x001DF2E5 File Offset: 0x001DD4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardRequest);
		}

		// Token: 0x0600CAFF RID: 51967 RVA: 0x001DF2F3 File Offset: 0x001DD4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ExchangeCount == other.ExchangeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB00 RID: 51968 RVA: 0x001DF334 File Offset: 0x001DD534
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

		// Token: 0x0600CB01 RID: 51969 RVA: 0x001DF38C File Offset: 0x001DD58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x001DF399 File Offset: 0x001DD599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB03 RID: 51971 RVA: 0x001DF3A4 File Offset: 0x001DD5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.ExchangeCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ExchangeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x001DF400 File Offset: 0x001DD600
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

		// Token: 0x0600CB05 RID: 51973 RVA: 0x001DF458 File Offset: 0x001DD658
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

		// Token: 0x0600CB06 RID: 51974 RVA: 0x001DF4A8 File Offset: 0x001DD6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB07 RID: 51975 RVA: 0x001DF4B4 File Offset: 0x001DD6B4
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
				if (num != 88U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExchangeCount = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005697 RID: 22167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005698 RID: 22168
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04005699 RID: 22169
		private long entityId_;

		// Token: 0x0400569A RID: 22170
		public const int ExchangeCountFieldNumber = 13;

		// Token: 0x0400569B RID: 22171
		private int exchangeCount_;
	}
}
