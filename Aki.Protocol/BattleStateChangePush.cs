using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017E RID: 382
	[NetMessage(EMessageId.BattleStateChangePush)]
	public sealed class BattleStateChangePush : IMessage<BattleStateChangePush>, IMessage, IEquatable<BattleStateChangePush>, IDeepCloneable<BattleStateChangePush>, IBufferMessage
	{
		// Token: 0x06002E5D RID: 11869 RVA: 0x00077698 File Offset: 0x00075898
		[NullableContext(1)]
		public static BattleStateChangePush Create()
		{
			return new BattleStateChangePush();
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x0007769F File Offset: 0x0007589F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x000776A2 File Offset: 0x000758A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangePush.Descriptor;
			}
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000776A9 File Offset: 0x000758A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangePush()
		{
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000776B1 File Offset: 0x000758B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangePush(BattleStateChangePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000776E2 File Offset: 0x000758E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangePush Clone()
		{
			return new BattleStateChangePush(this);
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x000776EA File Offset: 0x000758EA
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x000776F2 File Offset: 0x000758F2
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

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x000776FB File Offset: 0x000758FB
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x00077703 File Offset: 0x00075903
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

		// Token: 0x06002E67 RID: 11879 RVA: 0x0007770C File Offset: 0x0007590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangePush);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x0007771A File Offset: 0x0007591A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00077758 File Offset: 0x00075958
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

		// Token: 0x06002E6A RID: 11882 RVA: 0x000777B0 File Offset: 0x000759B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000777BD File Offset: 0x000759BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000777C8 File Offset: 0x000759C8
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
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00077824 File Offset: 0x00075A24
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

		// Token: 0x06002E6E RID: 11886 RVA: 0x00077870 File Offset: 0x00075A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleStateChangePush other)
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

		// Token: 0x06002E6F RID: 11887 RVA: 0x000778C0 File Offset: 0x00075AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000778CC File Offset: 0x00075ACC
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
					if (num != 104U)
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

		// Token: 0x04002870 RID: 10352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002871 RID: 10353
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04002872 RID: 10354
		private long entityId_;

		// Token: 0x04002873 RID: 10355
		public const int InBattleFieldNumber = 8;

		// Token: 0x04002874 RID: 10356
		private bool inBattle_;
	}
}
