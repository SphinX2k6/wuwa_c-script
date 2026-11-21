using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E0 RID: 2528
	[NetMessage(EMessageId.MonsterAttributeArrayNotify)]
	public sealed class MonsterAttributeArrayNotify : IMessage<MonsterAttributeArrayNotify>, IMessage, IEquatable<MonsterAttributeArrayNotify>, IDeepCloneable<MonsterAttributeArrayNotify>, IBufferMessage
	{
		// Token: 0x0600DDCF RID: 56783 RVA: 0x00208F27 File Offset: 0x00207127
		[NullableContext(1)]
		public static MonsterAttributeArrayNotify Create()
		{
			return new MonsterAttributeArrayNotify();
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x0600DDD0 RID: 56784 RVA: 0x00208F2E File Offset: 0x0020712E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x0600DDD1 RID: 56785 RVA: 0x00208F31 File Offset: 0x00207131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterAttributeArrayNotify.Descriptor;
			}
		}

		// Token: 0x0600DDD2 RID: 56786 RVA: 0x00208F38 File Offset: 0x00207138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeArrayNotify()
		{
		}

		// Token: 0x0600DDD3 RID: 56787 RVA: 0x00208F4B File Offset: 0x0020714B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeArrayNotify(MonsterAttributeArrayNotify other) : this()
		{
			this.monsters_ = other.monsters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDD4 RID: 56788 RVA: 0x00208F75 File Offset: 0x00207175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeArrayNotify Clone()
		{
			return new MonsterAttributeArrayNotify(this);
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x0600DDD5 RID: 56789 RVA: 0x00208F7D File Offset: 0x0020717D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterAttributeNotify> Monsters
		{
			get
			{
				return this.monsters_;
			}
		}

		// Token: 0x0600DDD6 RID: 56790 RVA: 0x00208F85 File Offset: 0x00207185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterAttributeArrayNotify);
		}

		// Token: 0x0600DDD7 RID: 56791 RVA: 0x00208F93 File Offset: 0x00207193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterAttributeArrayNotify other)
		{
			return other != null && (other == this || (this.monsters_.Equals(other.monsters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDD8 RID: 56792 RVA: 0x00208FC8 File Offset: 0x002071C8
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

		// Token: 0x0600DDD9 RID: 56793 RVA: 0x00208FFC File Offset: 0x002071FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDDA RID: 56794 RVA: 0x00209009 File Offset: 0x00207209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDDB RID: 56795 RVA: 0x00209012 File Offset: 0x00207212
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

		// Token: 0x0600DDDC RID: 56796 RVA: 0x0020903C File Offset: 0x0020723C
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

		// Token: 0x0600DDDD RID: 56797 RVA: 0x00209075 File Offset: 0x00207275
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

		// Token: 0x0600DDDE RID: 56798 RVA: 0x002090A3 File Offset: 0x002072A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDDF RID: 56799 RVA: 0x002090AC File Offset: 0x002072AC
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.monsters_.AddEntriesFrom(ref input, MonsterAttributeArrayNotify._repeated_monsters_codec);
				}
			}
		}

		// Token: 0x04005C03 RID: 23555
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C04 RID: 23556
		public const int MonstersFieldNumber = 10;

		// Token: 0x04005C05 RID: 23557
		private static readonly FieldCodec<MonsterAttributeNotify> _repeated_monsters_codec = FieldCodec.ForMessage<MonsterAttributeNotify>(82U, MonsterAttributeNotify.Parser);

		// Token: 0x04005C06 RID: 23558
		private readonly RepeatedField<MonsterAttributeNotify> monsters_ = new RepeatedField<MonsterAttributeNotify>();
	}
}
