using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000276 RID: 630
	public sealed class CharacterBattleStateInfo : IMessage<CharacterBattleStateInfo>, IMessage, IEquatable<CharacterBattleStateInfo>, IDeepCloneable<CharacterBattleStateInfo>, IBufferMessage
	{
		// Token: 0x0600427A RID: 17018 RVA: 0x000A36D5 File Offset: 0x000A18D5
		[NullableContext(1)]
		public static CharacterBattleStateInfo Create()
		{
			return new CharacterBattleStateInfo();
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x000A36DC File Offset: 0x000A18DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterBattleStateInfo> Parser
		{
			get
			{
				return CharacterBattleStateInfo._parser;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600427C RID: 17020 RVA: 0x000A36E3 File Offset: 0x000A18E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x000A36E6 File Offset: 0x000A18E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterBattleStateInfo.Descriptor;
			}
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x000A36ED File Offset: 0x000A18ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateInfo()
		{
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x000A36F5 File Offset: 0x000A18F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateInfo(CharacterBattleStateInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x000A3726 File Offset: 0x000A1926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateInfo Clone()
		{
			return new CharacterBattleStateInfo(this);
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x000A372E File Offset: 0x000A192E
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x000A3736 File Offset: 0x000A1936
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

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x000A373F File Offset: 0x000A193F
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x000A3747 File Offset: 0x000A1947
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

		// Token: 0x06004285 RID: 17029 RVA: 0x000A3750 File Offset: 0x000A1950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterBattleStateInfo);
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x000A375E File Offset: 0x000A195E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterBattleStateInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x000A379C File Offset: 0x000A199C
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

		// Token: 0x06004288 RID: 17032 RVA: 0x000A37F4 File Offset: 0x000A19F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x000A3801 File Offset: 0x000A1A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x000A380C File Offset: 0x000A1A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.InBattle)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.InBattle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x000A3864 File Offset: 0x000A1A64
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

		// Token: 0x0600428C RID: 17036 RVA: 0x000A38B0 File Offset: 0x000A1AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CharacterBattleStateInfo other)
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

		// Token: 0x0600428D RID: 17037 RVA: 0x000A3900 File Offset: 0x000A1B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x000A390C File Offset: 0x000A1B0C
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
						this.InBattle = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002E5B RID: 11867
		private static readonly MessageParser<CharacterBattleStateInfo> _parser = new MessageParser<CharacterBattleStateInfo>(() => new CharacterBattleStateInfo());

		// Token: 0x04002E5C RID: 11868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E5D RID: 11869
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002E5E RID: 11870
		private long entityId_;

		// Token: 0x04002E5F RID: 11871
		public const int InBattleFieldNumber = 2;

		// Token: 0x04002E60 RID: 11872
		private bool inBattle_;
	}
}
