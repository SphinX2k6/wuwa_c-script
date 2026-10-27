using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017F RID: 383
	[NetMessage(EMessageId.BattleStateChangeRequest)]
	public sealed class BattleStateChangeRequest : IMessage<BattleStateChangeRequest>, IMessage, IEquatable<BattleStateChangeRequest>, IDeepCloneable<BattleStateChangeRequest>, IBufferMessage
	{
		// Token: 0x06002E71 RID: 11889 RVA: 0x00077924 File Offset: 0x00075B24
		[NullableContext(1)]
		public static BattleStateChangeRequest Create()
		{
			return new BattleStateChangeRequest();
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x0007792B File Offset: 0x00075B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x0007792E File Offset: 0x00075B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleStateChangeRequest.Descriptor;
			}
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x00077935 File Offset: 0x00075B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest()
		{
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0007793D File Offset: 0x00075B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest(BattleStateChangeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x0007796E File Offset: 0x00075B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStateChangeRequest Clone()
		{
			return new BattleStateChangeRequest(this);
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00077976 File Offset: 0x00075B76
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x0007797E File Offset: 0x00075B7E
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00077987 File Offset: 0x00075B87
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x0007798F File Offset: 0x00075B8F
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

		// Token: 0x06002E7B RID: 11899 RVA: 0x00077998 File Offset: 0x00075B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleStateChangeRequest);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000779A6 File Offset: 0x00075BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleStateChangeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000779E4 File Offset: 0x00075BE4
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

		// Token: 0x06002E7E RID: 11902 RVA: 0x00077A3C File Offset: 0x00075C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00077A49 File Offset: 0x00075C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00077A54 File Offset: 0x00075C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.InBattle)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00077AB0 File Offset: 0x00075CB0
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

		// Token: 0x06002E82 RID: 11906 RVA: 0x00077AFC File Offset: 0x00075CFC
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

		// Token: 0x06002E83 RID: 11907 RVA: 0x00077B4C File Offset: 0x00075D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00077B58 File Offset: 0x00075D58
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
				if (num != 16U)
				{
					if (num != 104U)
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

		// Token: 0x04002875 RID: 10357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002876 RID: 10358
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04002877 RID: 10359
		private long entityId_;

		// Token: 0x04002878 RID: 10360
		public const int InBattleFieldNumber = 13;

		// Token: 0x04002879 RID: 10361
		private bool inBattle_;
	}
}
