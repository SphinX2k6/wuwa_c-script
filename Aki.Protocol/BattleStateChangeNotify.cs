using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000180 RID: 384
	[NetMessage(EMessageId.BattleStateChangeNotify)]
	public sealed class BattleStateChangeNotify : IMessage<BattleStateChangeNotify>, IMessage, IEquatable<BattleStateChangeNotify>, IDeepCloneable<BattleStateChangeNotify>, IBufferMessage
	{
		// Token: 0x06002EC0 RID: 11968 RVA: 0x00078838 File Offset: 0x00076A38
		[NullableContext(1)]
		public static BattleStateChangeNotify Create()
		{
			return new BattleStateChangeNotify();
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x0007883F File Offset: 0x00076A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x00078842 File Offset: 0x00076A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangeNotify.Descriptor;
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00078849 File Offset: 0x00076A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeNotify()
		{
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00078851 File Offset: 0x00076A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeNotify(BattleStateChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00078882 File Offset: 0x00076A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeNotify Clone()
		{
			return new BattleStateChangeNotify(this);
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x0007888A File Offset: 0x00076A8A
		// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x00078892 File Offset: 0x00076A92
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

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x0007889B File Offset: 0x00076A9B
		// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x000788A3 File Offset: 0x00076AA3
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

		// Token: 0x06002ECA RID: 11978 RVA: 0x000788AC File Offset: 0x00076AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangeNotify);
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x000788BA File Offset: 0x00076ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x000788F8 File Offset: 0x00076AF8
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

		// Token: 0x06002ECD RID: 11981 RVA: 0x00078950 File Offset: 0x00076B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x0007895D File Offset: 0x00076B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00078968 File Offset: 0x00076B68
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
				output.WriteRawTag(72);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000789C4 File Offset: 0x00076BC4
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

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00078A10 File Offset: 0x00076C10
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

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00078A60 File Offset: 0x00076C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00078A6C File Offset: 0x00076C6C
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

		// Token: 0x040028DF RID: 10463
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E0 RID: 10464
		public const int EntityIdFieldNumber = 7;

		// Token: 0x040028E1 RID: 10465
		private long entityId_;

		// Token: 0x040028E2 RID: 10466
		public const int InBattleFieldNumber = 9;

		// Token: 0x040028E3 RID: 10467
		private bool inBattle_;
	}
}
