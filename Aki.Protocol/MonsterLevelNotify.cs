using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A03 RID: 2563
	[NetMessage(EMessageId.MonsterLevelNotify)]
	public sealed class MonsterLevelNotify : IMessage<MonsterLevelNotify>, IMessage, IEquatable<MonsterLevelNotify>, IDeepCloneable<MonsterLevelNotify>, IBufferMessage
	{
		// Token: 0x0600E04E RID: 57422 RVA: 0x0020DE81 File Offset: 0x0020C081
		[NullableContext(1)]
		public static MonsterLevelNotify Create()
		{
			return new MonsterLevelNotify();
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600E04F RID: 57423 RVA: 0x0020DE88 File Offset: 0x0020C088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterLevelNotify> Parser
		{
			get
			{
				return MonsterLevelNotify._parser;
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600E050 RID: 57424 RVA: 0x0020DE8F File Offset: 0x0020C08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0600E051 RID: 57425 RVA: 0x0020DE92 File Offset: 0x0020C092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x0020DE99 File Offset: 0x0020C099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelNotify()
		{
		}

		// Token: 0x0600E053 RID: 57427 RVA: 0x0020DEA1 File Offset: 0x0020C0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelNotify(MonsterLevelNotify other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E054 RID: 57428 RVA: 0x0020DED2 File Offset: 0x0020C0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelNotify Clone()
		{
			return new MonsterLevelNotify(this);
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600E055 RID: 57429 RVA: 0x0020DEDA File Offset: 0x0020C0DA
		// (set) Token: 0x0600E056 RID: 57430 RVA: 0x0020DEE2 File Offset: 0x0020C0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600E057 RID: 57431 RVA: 0x0020DEEB File Offset: 0x0020C0EB
		// (set) Token: 0x0600E058 RID: 57432 RVA: 0x0020DEF3 File Offset: 0x0020C0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600E059 RID: 57433 RVA: 0x0020DEFC File Offset: 0x0020C0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterLevelNotify);
		}

		// Token: 0x0600E05A RID: 57434 RVA: 0x0020DF0A File Offset: 0x0020C10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterLevelNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E05B RID: 57435 RVA: 0x0020DF48 File Offset: 0x0020C148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E05C RID: 57436 RVA: 0x0020DFA0 File Offset: 0x0020C1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E05D RID: 57437 RVA: 0x0020DFAD File Offset: 0x0020C1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E05E RID: 57438 RVA: 0x0020DFB8 File Offset: 0x0020C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Level);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E05F RID: 57439 RVA: 0x0020E014 File Offset: 0x0020C214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E060 RID: 57440 RVA: 0x0020E06C File Offset: 0x0020C26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E061 RID: 57441 RVA: 0x0020E0BC File Offset: 0x0020C2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E062 RID: 57442 RVA: 0x0020E0C8 File Offset: 0x0020C2C8
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
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C5A RID: 23642
		private static readonly MessageParser<MonsterLevelNotify> _parser = new MessageParser<MonsterLevelNotify>(() => new MonsterLevelNotify());

		// Token: 0x04005C5B RID: 23643
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C5C RID: 23644
		public const int IdFieldNumber = 15;

		// Token: 0x04005C5D RID: 23645
		private long id_;

		// Token: 0x04005C5E RID: 23646
		public const int LevelFieldNumber = 10;

		// Token: 0x04005C5F RID: 23647
		private int level_;
	}
}
