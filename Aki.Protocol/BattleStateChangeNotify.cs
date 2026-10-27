using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017D RID: 381
	[NetMessage(EMessageId.BattleStateChangeNotify)]
	public sealed class BattleStateChangeNotify : IMessage<BattleStateChangeNotify>, IMessage, IEquatable<BattleStateChangeNotify>, IDeepCloneable<BattleStateChangeNotify>, IBufferMessage
	{
		// Token: 0x06002E49 RID: 11849 RVA: 0x0007740C File Offset: 0x0007560C
		[NullableContext(1)]
		public static BattleStateChangeNotify Create()
		{
			return new BattleStateChangeNotify();
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x00077413 File Offset: 0x00075613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x00077416 File Offset: 0x00075616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x0007741D File Offset: 0x0007561D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeNotify()
		{
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00077425 File Offset: 0x00075625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeNotify(BattleStateChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00077456 File Offset: 0x00075656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeNotify Clone()
		{
			return new BattleStateChangeNotify(this);
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x0007745E File Offset: 0x0007565E
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00077466 File Offset: 0x00075666
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

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x0007746F File Offset: 0x0007566F
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00077477 File Offset: 0x00075677
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

		// Token: 0x06002E53 RID: 11859 RVA: 0x00077480 File Offset: 0x00075680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangeNotify);
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x0007748E File Offset: 0x0007568E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000774CC File Offset: 0x000756CC
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

		// Token: 0x06002E56 RID: 11862 RVA: 0x00077524 File Offset: 0x00075724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00077531 File Offset: 0x00075731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x0007753C File Offset: 0x0007573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.InBattle)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00077598 File Offset: 0x00075798
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

		// Token: 0x06002E5A RID: 11866 RVA: 0x000775E4 File Offset: 0x000757E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleStateChangeNotify other)
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

		// Token: 0x06002E5B RID: 11867 RVA: 0x00077634 File Offset: 0x00075834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00077640 File Offset: 0x00075840
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InBattle = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400286B RID: 10347
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400286C RID: 10348
		public const int EntityIdFieldNumber = 7;

		// Token: 0x0400286D RID: 10349
		private long entityId_;

		// Token: 0x0400286E RID: 10350
		public const int InBattleFieldNumber = 14;

		// Token: 0x0400286F RID: 10351
		private bool inBattle_;
	}
}
