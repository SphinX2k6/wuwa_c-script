using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A02 RID: 2562
	[NetMessage(EMessageId.MonsterLevelArrayNotify)]
	public sealed class MonsterLevelArrayNotify : IMessage<MonsterLevelArrayNotify>, IMessage, IEquatable<MonsterLevelArrayNotify>, IDeepCloneable<MonsterLevelArrayNotify>, IBufferMessage
	{
		// Token: 0x0600E03C RID: 57404 RVA: 0x0020DC9E File Offset: 0x0020BE9E
		[NullableContext(1)]
		public static MonsterLevelArrayNotify Create()
		{
			return new MonsterLevelArrayNotify();
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600E03D RID: 57405 RVA: 0x0020DCA5 File Offset: 0x0020BEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0600E03E RID: 57406 RVA: 0x0020DCA8 File Offset: 0x0020BEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterLevelArrayNotify.Descriptor;
			}
		}

		// Token: 0x0600E03F RID: 57407 RVA: 0x0020DCAF File Offset: 0x0020BEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelArrayNotify()
		{
		}

		// Token: 0x0600E040 RID: 57408 RVA: 0x0020DCC2 File Offset: 0x0020BEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelArrayNotify(MonsterLevelArrayNotify other) : this()
		{
			this.monsters_ = other.monsters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E041 RID: 57409 RVA: 0x0020DCEC File Offset: 0x0020BEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelArrayNotify Clone()
		{
			return new MonsterLevelArrayNotify(this);
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x0600E042 RID: 57410 RVA: 0x0020DCF4 File Offset: 0x0020BEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterLevelNotify> Monsters
		{
			get
			{
				return this.monsters_;
			}
		}

		// Token: 0x0600E043 RID: 57411 RVA: 0x0020DCFC File Offset: 0x0020BEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterLevelArrayNotify);
		}

		// Token: 0x0600E044 RID: 57412 RVA: 0x0020DD0A File Offset: 0x0020BF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterLevelArrayNotify other)
		{
			return other != null && (other == this || (this.monsters_.Equals(other.monsters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E045 RID: 57413 RVA: 0x0020DD40 File Offset: 0x0020BF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.monsters_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E046 RID: 57414 RVA: 0x0020DD74 File Offset: 0x0020BF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E047 RID: 57415 RVA: 0x0020DD81 File Offset: 0x0020BF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E048 RID: 57416 RVA: 0x0020DD8A File Offset: 0x0020BF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monsters_.WriteTo(ref output, MonsterLevelArrayNotify._repeated_monsters_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E049 RID: 57417 RVA: 0x0020DDB4 File Offset: 0x0020BFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.monsters_.CalculateSize(MonsterLevelArrayNotify._repeated_monsters_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E04A RID: 57418 RVA: 0x0020DDED File Offset: 0x0020BFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterLevelArrayNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.monsters_.Add(other.monsters_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E04B RID: 57419 RVA: 0x0020DE1B File Offset: 0x0020C01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E04C RID: 57420 RVA: 0x0020DE24 File Offset: 0x0020C024
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.monsters_.AddEntriesFrom(ref input, MonsterLevelArrayNotify._repeated_monsters_codec);
				}
			}
		}

		// Token: 0x04005C56 RID: 23638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C57 RID: 23639
		public const int MonstersFieldNumber = 5;

		// Token: 0x04005C58 RID: 23640
		private static readonly FieldCodec<MonsterLevelNotify> _repeated_monsters_codec = FieldCodec.ForMessage<MonsterLevelNotify>(42U, MonsterLevelNotify.Parser);

		// Token: 0x04005C59 RID: 23641
		private readonly RepeatedField<MonsterLevelNotify> monsters_ = new RepeatedField<MonsterLevelNotify>();
	}
}
