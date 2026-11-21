using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000181 RID: 385
	[NetMessage(EMessageId.BattleStateChangePush)]
	public sealed class BattleStateChangePush : IMessage<BattleStateChangePush>, IMessage, IEquatable<BattleStateChangePush>, IDeepCloneable<BattleStateChangePush>, IBufferMessage
	{
		// Token: 0x06002ED4 RID: 11988 RVA: 0x00078AC4 File Offset: 0x00076CC4
		[NullableContext(1)]
		public static BattleStateChangePush Create()
		{
			return new BattleStateChangePush();
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x00078ACB File Offset: 0x00076CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x00078ACE File Offset: 0x00076CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangePush.Descriptor;
			}
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00078AD5 File Offset: 0x00076CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangePush()
		{
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00078ADD File Offset: 0x00076CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangePush(BattleStateChangePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00078B0E File Offset: 0x00076D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangePush Clone()
		{
			return new BattleStateChangePush(this);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00078B16 File Offset: 0x00076D16
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x00078B1E File Offset: 0x00076D1E
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

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x00078B27 File Offset: 0x00076D27
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x00078B2F File Offset: 0x00076D2F
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

		// Token: 0x06002EDE RID: 11998 RVA: 0x00078B38 File Offset: 0x00076D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangePush);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00078B46 File Offset: 0x00076D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x00078B84 File Offset: 0x00076D84
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

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00078BDC File Offset: 0x00076DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00078BE9 File Offset: 0x00076DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00078BF4 File Offset: 0x00076DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.InBattle)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00078C50 File Offset: 0x00076E50
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

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00078C9C File Offset: 0x00076E9C
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

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00078CEC File Offset: 0x00076EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00078CF8 File Offset: 0x00076EF8
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
					if (num != 32U)
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

		// Token: 0x040028E4 RID: 10468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E5 RID: 10469
		public const int EntityIdFieldNumber = 3;

		// Token: 0x040028E6 RID: 10470
		private long entityId_;

		// Token: 0x040028E7 RID: 10471
		public const int InBattleFieldNumber = 4;

		// Token: 0x040028E8 RID: 10472
		private bool inBattle_;
	}
}
