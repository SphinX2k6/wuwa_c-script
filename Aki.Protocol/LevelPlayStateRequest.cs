using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FC RID: 2300
	[NetMessage(EMessageId.LevelPlayStateRequest)]
	public sealed class LevelPlayStateRequest : IMessage<LevelPlayStateRequest>, IMessage, IEquatable<LevelPlayStateRequest>, IDeepCloneable<LevelPlayStateRequest>, IBufferMessage
	{
		// Token: 0x0600CB78 RID: 52088 RVA: 0x001E057F File Offset: 0x001DE77F
		[NullableContext(1)]
		public static LevelPlayStateRequest Create()
		{
			return new LevelPlayStateRequest();
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x001E0586 File Offset: 0x001DE786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x0600CB7A RID: 52090 RVA: 0x001E0589 File Offset: 0x001DE789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayStateRequest.Descriptor;
			}
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x001E0590 File Offset: 0x001DE790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateRequest()
		{
		}

		// Token: 0x0600CB7C RID: 52092 RVA: 0x001E0598 File Offset: 0x001DE798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateRequest(LevelPlayStateRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.arenaId_ = other.arenaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB7D RID: 52093 RVA: 0x001E05C9 File Offset: 0x001DE7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayStateRequest Clone()
		{
			return new LevelPlayStateRequest(this);
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600CB7E RID: 52094 RVA: 0x001E05D1 File Offset: 0x001DE7D1
		// (set) Token: 0x0600CB7F RID: 52095 RVA: 0x001E05D9 File Offset: 0x001DE7D9
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

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600CB80 RID: 52096 RVA: 0x001E05E2 File Offset: 0x001DE7E2
		// (set) Token: 0x0600CB81 RID: 52097 RVA: 0x001E05EA File Offset: 0x001DE7EA
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

		// Token: 0x0600CB82 RID: 52098 RVA: 0x001E05F3 File Offset: 0x001DE7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayStateRequest);
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x001E0601 File Offset: 0x001DE801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayStateRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.ArenaId == other.ArenaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x001E0640 File Offset: 0x001DE840
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

		// Token: 0x0600CB85 RID: 52101 RVA: 0x001E0698 File Offset: 0x001DE898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB86 RID: 52102 RVA: 0x001E06A5 File Offset: 0x001DE8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x001E06B0 File Offset: 0x001DE8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ArenaId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ArenaId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB88 RID: 52104 RVA: 0x001E070C File Offset: 0x001DE90C
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

		// Token: 0x0600CB89 RID: 52105 RVA: 0x001E0764 File Offset: 0x001DE964
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

		// Token: 0x0600CB8A RID: 52106 RVA: 0x001E07B4 File Offset: 0x001DE9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB8B RID: 52107 RVA: 0x001E07C0 File Offset: 0x001DE9C0
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.ArenaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056C2 RID: 22210
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056C3 RID: 22211
		public const int InstIdFieldNumber = 11;

		// Token: 0x040056C4 RID: 22212
		private int instId_;

		// Token: 0x040056C5 RID: 22213
		public const int ArenaIdFieldNumber = 3;

		// Token: 0x040056C6 RID: 22214
		private int arenaId_;
	}
}
