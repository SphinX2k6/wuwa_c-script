using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C6 RID: 5062
	[NetMessage(EMessageId.TetrisFinishRequest)]
	public sealed class TetrisFinishRequest : IMessage<TetrisFinishRequest>, IMessage, IEquatable<TetrisFinishRequest>, IDeepCloneable<TetrisFinishRequest>, IBufferMessage
	{
		// Token: 0x0601AF0D RID: 110349 RVA: 0x003ECA0D File Offset: 0x003EAC0D
		[NullableContext(1)]
		public static TetrisFinishRequest Create()
		{
			return new TetrisFinishRequest();
		}

		// Token: 0x17005B40 RID: 23360
		// (get) Token: 0x0601AF0E RID: 110350 RVA: 0x003ECA14 File Offset: 0x003EAC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B41 RID: 23361
		// (get) Token: 0x0601AF0F RID: 110351 RVA: 0x003ECA17 File Offset: 0x003EAC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601AF10 RID: 110352 RVA: 0x003ECA1E File Offset: 0x003EAC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishRequest()
		{
		}

		// Token: 0x0601AF11 RID: 110353 RVA: 0x003ECA26 File Offset: 0x003EAC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishRequest(TetrisFinishRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF12 RID: 110354 RVA: 0x003ECA63 File Offset: 0x003EAC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisFinishRequest Clone()
		{
			return new TetrisFinishRequest(this);
		}

		// Token: 0x17005B42 RID: 23362
		// (get) Token: 0x0601AF13 RID: 110355 RVA: 0x003ECA6B File Offset: 0x003EAC6B
		// (set) Token: 0x0601AF14 RID: 110356 RVA: 0x003ECA73 File Offset: 0x003EAC73
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

		// Token: 0x17005B43 RID: 23363
		// (get) Token: 0x0601AF15 RID: 110357 RVA: 0x003ECA7C File Offset: 0x003EAC7C
		// (set) Token: 0x0601AF16 RID: 110358 RVA: 0x003ECA84 File Offset: 0x003EAC84
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

		// Token: 0x17005B44 RID: 23364
		// (get) Token: 0x0601AF17 RID: 110359 RVA: 0x003ECA8D File Offset: 0x003EAC8D
		// (set) Token: 0x0601AF18 RID: 110360 RVA: 0x003ECA95 File Offset: 0x003EAC95
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

		// Token: 0x0601AF19 RID: 110361 RVA: 0x003ECA9E File Offset: 0x003EAC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisFinishRequest);
		}

		// Token: 0x0601AF1A RID: 110362 RVA: 0x003ECAAC File Offset: 0x003EACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisFinishRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF1B RID: 110363 RVA: 0x003ECB08 File Offset: 0x003EAD08
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

		// Token: 0x0601AF1C RID: 110364 RVA: 0x003ECB79 File Offset: 0x003EAD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF1D RID: 110365 RVA: 0x003ECB86 File Offset: 0x003EAD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF1E RID: 110366 RVA: 0x003ECB90 File Offset: 0x003EAD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AF1F RID: 110367 RVA: 0x003ECC08 File Offset: 0x003EAE08
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

		// Token: 0x0601AF20 RID: 110368 RVA: 0x003ECC78 File Offset: 0x003EAE78
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

		// Token: 0x0601AF21 RID: 110369 RVA: 0x003ECCDC File Offset: 0x003EAEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF22 RID: 110370 RVA: 0x003ECCE8 File Offset: 0x003EAEE8
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
					if (num != 72U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Score = input.ReadInt32();
						}
					}
					else
					{
						this.HostPlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009D89 RID: 40329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D8A RID: 40330
		public const int HostPlayerIdFieldNumber = 9;

		// Token: 0x04009D8B RID: 40331
		private int hostPlayerId_;

		// Token: 0x04009D8C RID: 40332
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04009D8D RID: 40333
		private long entityId_;

		// Token: 0x04009D8E RID: 40334
		public const int ScoreFieldNumber = 10;

		// Token: 0x04009D8F RID: 40335
		private int score_;
	}
}
