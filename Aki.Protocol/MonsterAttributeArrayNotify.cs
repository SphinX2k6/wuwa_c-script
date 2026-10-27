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
	[NetMessage(EMessageId.MonsterAttributeArrayNotify)]
	public sealed class MonsterAttributeArrayNotify : IMessage<MonsterAttributeArrayNotify>, IMessage, IEquatable<MonsterAttributeArrayNotify>, IDeepCloneable<MonsterAttributeArrayNotify>, IBufferMessage
	{
		// Token: 0x0600DEE9 RID: 57065 RVA: 0x0020B113 File Offset: 0x00209313
		[NullableContext(1)]
		public static MonsterAttributeArrayNotify Create()
		{
			return new MonsterAttributeArrayNotify();
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0600DEEA RID: 57066 RVA: 0x0020B11A File Offset: 0x0020931A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x0600DEEB RID: 57067 RVA: 0x0020B11D File Offset: 0x0020931D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterAttributeArrayNotify.Descriptor;
			}
		}

		// Token: 0x0600DEEC RID: 57068 RVA: 0x0020B124 File Offset: 0x00209324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeArrayNotify()
		{
		}

		// Token: 0x0600DEED RID: 57069 RVA: 0x0020B137 File Offset: 0x00209337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeArrayNotify(MonsterAttributeArrayNotify other) : this()
		{
			this.monsters_ = other.monsters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEEE RID: 57070 RVA: 0x0020B161 File Offset: 0x00209361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeArrayNotify Clone()
		{
			return new MonsterAttributeArrayNotify(this);
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x0600DEEF RID: 57071 RVA: 0x0020B169 File Offset: 0x00209369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterAttributeNotify> Monsters
		{
			get
			{
				return this.monsters_;
			}
		}

		// Token: 0x0600DEF0 RID: 57072 RVA: 0x0020B171 File Offset: 0x00209371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterAttributeArrayNotify);
		}

		// Token: 0x0600DEF1 RID: 57073 RVA: 0x0020B17F File Offset: 0x0020937F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterAttributeArrayNotify other)
		{
			return other != null && (other == this || (this.monsters_.Equals(other.monsters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEF2 RID: 57074 RVA: 0x0020B1B4 File Offset: 0x002093B4
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

		// Token: 0x0600DEF3 RID: 57075 RVA: 0x0020B1E8 File Offset: 0x002093E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEF4 RID: 57076 RVA: 0x0020B1F5 File Offset: 0x002093F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEF5 RID: 57077 RVA: 0x0020B1FE File Offset: 0x002093FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monsters_.WriteTo(ref output, MonsterAttributeArrayNotify._repeated_monsters_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEF6 RID: 57078 RVA: 0x0020B228 File Offset: 0x00209428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.monsters_.CalculateSize(MonsterAttributeArrayNotify._repeated_monsters_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DEF7 RID: 57079 RVA: 0x0020B261 File Offset: 0x00209461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterAttributeArrayNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.monsters_.Add(other.monsters_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DEF8 RID: 57080 RVA: 0x0020B28F File Offset: 0x0020948F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEF9 RID: 57081 RVA: 0x0020B298 File Offset: 0x00209498
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.monsters_.AddEntriesFrom(ref input, MonsterAttributeArrayNotify._repeated_monsters_codec);
				}
			}
		}

		// Token: 0x04005BFA RID: 23546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BFB RID: 23547
		public const int MonstersFieldNumber = 15;

		// Token: 0x04005BFC RID: 23548
		private static readonly FieldCodec<MonsterAttributeNotify> _repeated_monsters_codec = FieldCodec.ForMessage<MonsterAttributeNotify>(122U, MonsterAttributeNotify.Parser);

		// Token: 0x04005BFD RID: 23549
		private readonly RepeatedField<MonsterAttributeNotify> monsters_ = new RepeatedField<MonsterAttributeNotify>();
	}
}
