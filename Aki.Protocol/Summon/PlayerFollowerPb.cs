using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x02001677 RID: 5751
	public sealed class PlayerFollowerPb : IMessage<PlayerFollowerPb>, IMessage, IEquatable<PlayerFollowerPb>, IDeepCloneable<PlayerFollowerPb>, IBufferMessage
	{
		// Token: 0x0601CB0B RID: 117515 RVA: 0x00424314 File Offset: 0x00422514
		[NullableContext(1)]
		public static PlayerFollowerPb Create()
		{
			return new PlayerFollowerPb();
		}

		// Token: 0x170060B2 RID: 24754
		// (get) Token: 0x0601CB0C RID: 117516 RVA: 0x0042431B File Offset: 0x0042251B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerFollowerPb> Parser
		{
			get
			{
				return PlayerFollowerPb._parser;
			}
		}

		// Token: 0x170060B3 RID: 24755
		// (get) Token: 0x0601CB0D RID: 117517 RVA: 0x00424322 File Offset: 0x00422522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060B4 RID: 24756
		// (get) Token: 0x0601CB0E RID: 117518 RVA: 0x00424325 File Offset: 0x00422525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowerPb.Descriptor;
			}
		}

		// Token: 0x0601CB0F RID: 117519 RVA: 0x0042432C File Offset: 0x0042252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerPb()
		{
		}

		// Token: 0x0601CB10 RID: 117520 RVA: 0x00424334 File Offset: 0x00422534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerPb(PlayerFollowerPb other) : this()
		{
			this.type_ = other.type_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CB11 RID: 117521 RVA: 0x00424365 File Offset: 0x00422565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerPb Clone()
		{
			return new PlayerFollowerPb(this);
		}

		// Token: 0x170060B5 RID: 24757
		// (get) Token: 0x0601CB12 RID: 117522 RVA: 0x0042436D File Offset: 0x0042256D
		// (set) Token: 0x0601CB13 RID: 117523 RVA: 0x00424375 File Offset: 0x00422575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EPlayerFollower Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170060B6 RID: 24758
		// (get) Token: 0x0601CB14 RID: 117524 RVA: 0x0042437E File Offset: 0x0042257E
		// (set) Token: 0x0601CB15 RID: 117525 RVA: 0x00424386 File Offset: 0x00422586
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

		// Token: 0x0601CB16 RID: 117526 RVA: 0x0042438F File Offset: 0x0042258F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowerPb);
		}

		// Token: 0x0601CB17 RID: 117527 RVA: 0x0042439D File Offset: 0x0042259D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowerPb other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CB18 RID: 117528 RVA: 0x004243DC File Offset: 0x004225DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != EPlayerFollower.Default)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CB19 RID: 117529 RVA: 0x0042443A File Offset: 0x0042263A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CB1A RID: 117530 RVA: 0x00424447 File Offset: 0x00422647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CB1B RID: 117531 RVA: 0x00424450 File Offset: 0x00422650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != EPlayerFollower.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CB1C RID: 117532 RVA: 0x004244A8 File Offset: 0x004226A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != EPlayerFollower.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CB1D RID: 117533 RVA: 0x00424500 File Offset: 0x00422700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFollowerPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != EPlayerFollower.Default)
			{
				this.Type = other.Type;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CB1E RID: 117534 RVA: 0x00424550 File Offset: 0x00422750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CB1F RID: 117535 RVA: 0x0042455C File Offset: 0x0042275C
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
					if (num != 16U)
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
					this.Type = (EPlayerFollower)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C1D4 RID: 49620
		private static readonly MessageParser<PlayerFollowerPb> _parser = new MessageParser<PlayerFollowerPb>(() => new PlayerFollowerPb());

		// Token: 0x0400C1D5 RID: 49621
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C1D6 RID: 49622
		public const int TypeFieldNumber = 1;

		// Token: 0x0400C1D7 RID: 49623
		private EPlayerFollower type_;

		// Token: 0x0400C1D8 RID: 49624
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400C1D9 RID: 49625
		private long entityId_;
	}
}
