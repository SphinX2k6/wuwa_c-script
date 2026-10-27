using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090D RID: 2317
	[NetMessage(EMessageId.LevelPlayStateRequest)]
	public sealed class LevelPlayStateRequest : IMessage<LevelPlayStateRequest>, IMessage, IEquatable<LevelPlayStateRequest>, IDeepCloneable<LevelPlayStateRequest>, IBufferMessage
	{
		// Token: 0x0600CC94 RID: 52372 RVA: 0x001E2857 File Offset: 0x001E0A57
		[NullableContext(1)]
		public static LevelPlayStateRequest Create()
		{
			return new LevelPlayStateRequest();
		}

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x0600CC95 RID: 52373 RVA: 0x001E285E File Offset: 0x001E0A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x0600CC96 RID: 52374 RVA: 0x001E2861 File Offset: 0x001E0A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateRequest.Descriptor;
			}
		}

		// Token: 0x0600CC97 RID: 52375 RVA: 0x001E2868 File Offset: 0x001E0A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateRequest()
		{
		}

		// Token: 0x0600CC98 RID: 52376 RVA: 0x001E2870 File Offset: 0x001E0A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateRequest(LevelPlayStateRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.arenaId_ = other.arenaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC99 RID: 52377 RVA: 0x001E28A1 File Offset: 0x001E0AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateRequest Clone()
		{
			return new LevelPlayStateRequest(this);
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x0600CC9A RID: 52378 RVA: 0x001E28A9 File Offset: 0x001E0AA9
		// (set) Token: 0x0600CC9B RID: 52379 RVA: 0x001E28B1 File Offset: 0x001E0AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x0600CC9C RID: 52380 RVA: 0x001E28BA File Offset: 0x001E0ABA
		// (set) Token: 0x0600CC9D RID: 52381 RVA: 0x001E28C2 File Offset: 0x001E0AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ArenaId
		{
			get
			{
				return this.arenaId_;
			}
			set
			{
				this.arenaId_ = value;
			}
		}

		// Token: 0x0600CC9E RID: 52382 RVA: 0x001E28CB File Offset: 0x001E0ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateRequest);
		}

		// Token: 0x0600CC9F RID: 52383 RVA: 0x001E28D9 File Offset: 0x001E0AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ArenaId == other.ArenaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCA0 RID: 52384 RVA: 0x001E2918 File Offset: 0x001E0B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.ArenaId != 0)
			{
				num ^= this.ArenaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCA1 RID: 52385 RVA: 0x001E2970 File Offset: 0x001E0B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x001E297D File Offset: 0x001E0B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCA3 RID: 52387 RVA: 0x001E2988 File Offset: 0x001E0B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.InstId);
			}
			if (this.ArenaId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ArenaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCA4 RID: 52388 RVA: 0x001E29E4 File Offset: 0x001E0BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.ArenaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ArenaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCA5 RID: 52389 RVA: 0x001E2A3C File Offset: 0x001E0C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.ArenaId != 0)
			{
				this.ArenaId = other.ArenaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x001E2A8C File Offset: 0x001E0C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x001E2A98 File Offset: 0x001E0C98
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
				if (num != 80U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ArenaId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056BB RID: 22203
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056BC RID: 22204
		public const int InstIdFieldNumber = 10;

		// Token: 0x040056BD RID: 22205
		private int instId_;

		// Token: 0x040056BE RID: 22206
		public const int ArenaIdFieldNumber = 11;

		// Token: 0x040056BF RID: 22207
		private int arenaId_;
	}
}
