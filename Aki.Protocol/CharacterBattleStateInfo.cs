using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000271 RID: 625
	public sealed class CharacterBattleStateInfo : IMessage<CharacterBattleStateInfo>, IMessage, IEquatable<CharacterBattleStateInfo>, IDeepCloneable<CharacterBattleStateInfo>, IBufferMessage
	{
		// Token: 0x060041D3 RID: 16851 RVA: 0x000A1A09 File Offset: 0x0009FC09
		[NullableContext(1)]
		public static CharacterBattleStateInfo Create()
		{
			return new CharacterBattleStateInfo();
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x000A1A10 File Offset: 0x0009FC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterBattleStateInfo> Parser
		{
			get
			{
				return CharacterBattleStateInfo._parser;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x000A1A17 File Offset: 0x0009FC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x000A1A1A File Offset: 0x0009FC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterBattleStateInfo.Descriptor;
			}
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x000A1A21 File Offset: 0x0009FC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateInfo()
		{
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x000A1A29 File Offset: 0x0009FC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateInfo(CharacterBattleStateInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.inBattle_ = other.inBattle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x000A1A5A File Offset: 0x0009FC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterBattleStateInfo Clone()
		{
			return new CharacterBattleStateInfo(this);
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x000A1A62 File Offset: 0x0009FC62
		// (set) Token: 0x060041DB RID: 16859 RVA: 0x000A1A6A File Offset: 0x0009FC6A
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

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060041DC RID: 16860 RVA: 0x000A1A73 File Offset: 0x0009FC73
		// (set) Token: 0x060041DD RID: 16861 RVA: 0x000A1A7B File Offset: 0x0009FC7B
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

		// Token: 0x060041DE RID: 16862 RVA: 0x000A1A84 File Offset: 0x0009FC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterBattleStateInfo);
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x000A1A92 File Offset: 0x0009FC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CharacterBattleStateInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.InBattle == other.InBattle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x000A1AD0 File Offset: 0x0009FCD0
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

		// Token: 0x060041E1 RID: 16865 RVA: 0x000A1B28 File Offset: 0x0009FD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x000A1B35 File Offset: 0x0009FD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x000A1B40 File Offset: 0x0009FD40
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

		// Token: 0x060041E4 RID: 16868 RVA: 0x000A1B98 File Offset: 0x0009FD98
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

		// Token: 0x060041E5 RID: 16869 RVA: 0x000A1BE4 File Offset: 0x0009FDE4
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

		// Token: 0x060041E6 RID: 16870 RVA: 0x000A1C34 File Offset: 0x0009FE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x000A1C40 File Offset: 0x0009FE40
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

		// Token: 0x04002DD7 RID: 11735
		private static readonly MessageParser<CharacterBattleStateInfo> _parser = new MessageParser<CharacterBattleStateInfo>(() => new CharacterBattleStateInfo());

		// Token: 0x04002DD8 RID: 11736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DD9 RID: 11737
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002DDA RID: 11738
		private long entityId_;

		// Token: 0x04002DDB RID: 11739
		public const int InBattleFieldNumber = 2;

		// Token: 0x04002DDC RID: 11740
		private bool inBattle_;
	}
}
