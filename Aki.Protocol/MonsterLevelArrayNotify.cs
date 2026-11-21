using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F1 RID: 2545
	[NetMessage(EMessageId.MonsterLevelArrayNotify)]
	public sealed class MonsterLevelArrayNotify : IMessage<MonsterLevelArrayNotify>, IMessage, IEquatable<MonsterLevelArrayNotify>, IDeepCloneable<MonsterLevelArrayNotify>, IBufferMessage
	{
		// Token: 0x0600DF22 RID: 57122 RVA: 0x0020BAB2 File Offset: 0x00209CB2
		[NullableContext(1)]
		public static MonsterLevelArrayNotify Create()
		{
			return new MonsterLevelArrayNotify();
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600DF23 RID: 57123 RVA: 0x0020BAB9 File Offset: 0x00209CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600DF24 RID: 57124 RVA: 0x0020BABC File Offset: 0x00209CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterLevelArrayNotify.Descriptor;
			}
		}

		// Token: 0x0600DF25 RID: 57125 RVA: 0x0020BAC3 File Offset: 0x00209CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelArrayNotify()
		{
		}

		// Token: 0x0600DF26 RID: 57126 RVA: 0x0020BAD6 File Offset: 0x00209CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelArrayNotify(MonsterLevelArrayNotify other) : this()
		{
			this.monsters_ = other.monsters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF27 RID: 57127 RVA: 0x0020BB00 File Offset: 0x00209D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelArrayNotify Clone()
		{
			return new MonsterLevelArrayNotify(this);
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x0020BB08 File Offset: 0x00209D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterLevelNotify> Monsters
		{
			get
			{
				return this.monsters_;
			}
		}

		// Token: 0x0600DF29 RID: 57129 RVA: 0x0020BB10 File Offset: 0x00209D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterLevelArrayNotify);
		}

		// Token: 0x0600DF2A RID: 57130 RVA: 0x0020BB1E File Offset: 0x00209D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterLevelArrayNotify other)
		{
			return other != null && (other == this || (this.monsters_.Equals(other.monsters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF2B RID: 57131 RVA: 0x0020BB54 File Offset: 0x00209D54
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

		// Token: 0x0600DF2C RID: 57132 RVA: 0x0020BB88 File Offset: 0x00209D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF2D RID: 57133 RVA: 0x0020BB95 File Offset: 0x00209D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF2E RID: 57134 RVA: 0x0020BB9E File Offset: 0x00209D9E
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

		// Token: 0x0600DF2F RID: 57135 RVA: 0x0020BBC8 File Offset: 0x00209DC8
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

		// Token: 0x0600DF30 RID: 57136 RVA: 0x0020BC01 File Offset: 0x00209E01
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

		// Token: 0x0600DF31 RID: 57137 RVA: 0x0020BC2F File Offset: 0x00209E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF32 RID: 57138 RVA: 0x0020BC38 File Offset: 0x00209E38
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

		// Token: 0x04005C5F RID: 23647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C60 RID: 23648
		public const int MonstersFieldNumber = 5;

		// Token: 0x04005C61 RID: 23649
		private static readonly FieldCodec<MonsterLevelNotify> _repeated_monsters_codec = FieldCodec.ForMessage<MonsterLevelNotify>(42U, MonsterLevelNotify.Parser);

		// Token: 0x04005C62 RID: 23650
		private readonly RepeatedField<MonsterLevelNotify> monsters_ = new RepeatedField<MonsterLevelNotify>();
	}
}
