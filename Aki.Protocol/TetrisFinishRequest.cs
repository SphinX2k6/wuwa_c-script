using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001353 RID: 4947
	[NetMessage(EMessageId.TetrisFinishRequest)]
	public sealed class TetrisFinishRequest : IMessage<TetrisFinishRequest>, IMessage, IEquatable<TetrisFinishRequest>, IDeepCloneable<TetrisFinishRequest>, IBufferMessage
	{
		// Token: 0x0601A486 RID: 107654 RVA: 0x003D18D9 File Offset: 0x003CFAD9
		[NullableContext(1)]
		public static TetrisFinishRequest Create()
		{
			return new TetrisFinishRequest();
		}

		// Token: 0x170058AD RID: 22701
		// (get) Token: 0x0601A487 RID: 107655 RVA: 0x003D18E0 File Offset: 0x003CFAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058AE RID: 22702
		// (get) Token: 0x0601A488 RID: 107656 RVA: 0x003D18E3 File Offset: 0x003CFAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601A489 RID: 107657 RVA: 0x003D18EA File Offset: 0x003CFAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishRequest()
		{
		}

		// Token: 0x0601A48A RID: 107658 RVA: 0x003D18F2 File Offset: 0x003CFAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishRequest(TetrisFinishRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A48B RID: 107659 RVA: 0x003D192F File Offset: 0x003CFB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishRequest Clone()
		{
			return new TetrisFinishRequest(this);
		}

		// Token: 0x170058AF RID: 22703
		// (get) Token: 0x0601A48C RID: 107660 RVA: 0x003D1937 File Offset: 0x003CFB37
		// (set) Token: 0x0601A48D RID: 107661 RVA: 0x003D193F File Offset: 0x003CFB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x170058B0 RID: 22704
		// (get) Token: 0x0601A48E RID: 107662 RVA: 0x003D1948 File Offset: 0x003CFB48
		// (set) Token: 0x0601A48F RID: 107663 RVA: 0x003D1950 File Offset: 0x003CFB50
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

		// Token: 0x170058B1 RID: 22705
		// (get) Token: 0x0601A490 RID: 107664 RVA: 0x003D1959 File Offset: 0x003CFB59
		// (set) Token: 0x0601A491 RID: 107665 RVA: 0x003D1961 File Offset: 0x003CFB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0601A492 RID: 107666 RVA: 0x003D196A File Offset: 0x003CFB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisFinishRequest);
		}

		// Token: 0x0601A493 RID: 107667 RVA: 0x003D1978 File Offset: 0x003CFB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisFinishRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A494 RID: 107668 RVA: 0x003D19D4 File Offset: 0x003CFBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A495 RID: 107669 RVA: 0x003D1A45 File Offset: 0x003CFC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A496 RID: 107670 RVA: 0x003D1A52 File Offset: 0x003CFC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A497 RID: 107671 RVA: 0x003D1A5C File Offset: 0x003CFC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A498 RID: 107672 RVA: 0x003D1AD4 File Offset: 0x003CFCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A499 RID: 107673 RVA: 0x003D1B44 File Offset: 0x003CFD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A49A RID: 107674 RVA: 0x003D1BA8 File Offset: 0x003CFDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A49B RID: 107675 RVA: 0x003D1BB4 File Offset: 0x003CFDB4
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
					if (num != 56U)
					{
						if (num != 112U)
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
						this.HostPlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Score = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009947 RID: 39239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009948 RID: 39240
		public const int HostPlayerIdFieldNumber = 7;

		// Token: 0x04009949 RID: 39241
		private int hostPlayerId_;

		// Token: 0x0400994A RID: 39242
		public const int EntityIdFieldNumber = 14;

		// Token: 0x0400994B RID: 39243
		private long entityId_;

		// Token: 0x0400994C RID: 39244
		public const int ScoreFieldNumber = 4;

		// Token: 0x0400994D RID: 39245
		private int score_;
	}
}
