using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000182 RID: 386
	[NetMessage(EMessageId.BattleStateChangeRequest)]
	public sealed class BattleStateChangeRequest : IMessage<BattleStateChangeRequest>, IMessage, IEquatable<BattleStateChangeRequest>, IDeepCloneable<BattleStateChangeRequest>, IBufferMessage
	{
		// Token: 0x06002EE8 RID: 12008 RVA: 0x00078D50 File Offset: 0x00076F50
		[NullableContext(1)]
		public static BattleStateChangeRequest Create()
		{
			return new BattleStateChangeRequest();
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x00078D57 File Offset: 0x00076F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x00078D5A File Offset: 0x00076F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangeRequest.Descriptor;
			}
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00078D61 File Offset: 0x00076F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest()
		{
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00078D69 File Offset: 0x00076F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest(BattleStateChangeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00078D9A File Offset: 0x00076F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest Clone()
		{
			return new BattleStateChangeRequest(this);
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x00078DA2 File Offset: 0x00076FA2
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x00078DAA File Offset: 0x00076FAA
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

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x00078DB3 File Offset: 0x00076FB3
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x00078DBB File Offset: 0x00076FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InBattle
		{
			get
			{
				return this.inBattle_;
			}
			set
			{
				this.inBattle_ = value;
			}
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00078DC4 File Offset: 0x00076FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangeRequest);
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00078DD2 File Offset: 0x00076FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00078E10 File Offset: 0x00077010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.InBattle)
			{
				num ^= this.InBattle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00078E68 File Offset: 0x00077068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00078E75 File Offset: 0x00077075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00078E80 File Offset: 0x00077080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InBattle)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.InBattle);
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

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00078EDC File Offset: 0x000770DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.InBattle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00078F28 File Offset: 0x00077128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleStateChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.InBattle)
			{
				this.InBattle = other.InBattle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00078F78 File Offset: 0x00077178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00078F84 File Offset: 0x00077184
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
				if (num != 64U)
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
					this.InBattle = input.ReadBool();
				}
			}
		}

		// Token: 0x040028E9 RID: 10473
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028EA RID: 10474
		public const int EntityIdFieldNumber = 14;

		// Token: 0x040028EB RID: 10475
		private long entityId_;

		// Token: 0x040028EC RID: 10476
		public const int InBattleFieldNumber = 8;

		// Token: 0x040028ED RID: 10477
		private bool inBattle_;
	}
}
