using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F2 RID: 2546
	[NetMessage(EMessageId.MonsterAttributeNotify)]
	public sealed class MonsterAttributeNotify : IMessage<MonsterAttributeNotify>, IMessage, IEquatable<MonsterAttributeNotify>, IDeepCloneable<MonsterAttributeNotify>, IBufferMessage
	{
		// Token: 0x0600DEFB RID: 57083 RVA: 0x0020B2F5 File Offset: 0x002094F5
		[NullableContext(1)]
		public static MonsterAttributeNotify Create()
		{
			return new MonsterAttributeNotify();
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0600DEFC RID: 57084 RVA: 0x0020B2FC File Offset: 0x002094FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterAttributeNotify> Parser
		{
			get
			{
				return MonsterAttributeNotify._parser;
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0600DEFD RID: 57085 RVA: 0x0020B303 File Offset: 0x00209503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600DEFE RID: 57086 RVA: 0x0020B306 File Offset: 0x00209506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterAttributeNotify.Descriptor;
			}
		}

		// Token: 0x0600DEFF RID: 57087 RVA: 0x0020B30D File Offset: 0x0020950D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeNotify()
		{
		}

		// Token: 0x0600DF00 RID: 57088 RVA: 0x0020B320 File Offset: 0x00209520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeNotify(MonsterAttributeNotify other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF01 RID: 57089 RVA: 0x0020B356 File Offset: 0x00209556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeNotify Clone()
		{
			return new MonsterAttributeNotify(this);
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x0600DF02 RID: 57090 RVA: 0x0020B35E File Offset: 0x0020955E
		// (set) Token: 0x0600DF03 RID: 57091 RVA: 0x0020B366 File Offset: 0x00209566
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

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600DF04 RID: 57092 RVA: 0x0020B36F File Offset: 0x0020956F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x0600DF05 RID: 57093 RVA: 0x0020B377 File Offset: 0x00209577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterAttributeNotify);
		}

		// Token: 0x0600DF06 RID: 57094 RVA: 0x0020B388 File Offset: 0x00209588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterAttributeNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Attributes.Equals(other.Attributes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF07 RID: 57095 RVA: 0x0020B3D8 File Offset: 0x002095D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.Attributes.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF08 RID: 57096 RVA: 0x0020B425 File Offset: 0x00209625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF09 RID: 57097 RVA: 0x0020B432 File Offset: 0x00209632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF0A RID: 57098 RVA: 0x0020B43C File Offset: 0x0020963C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			this.attributes_.WriteTo(ref output, MonsterAttributeNotify._map_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF0B RID: 57099 RVA: 0x0020B48C File Offset: 0x0020968C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.attributes_.CalculateSize(MonsterAttributeNotify._map_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF0C RID: 57100 RVA: 0x0020B4E0 File Offset: 0x002096E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterAttributeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.attributes_.MergeFrom(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF0D RID: 57101 RVA: 0x0020B52D File Offset: 0x0020972D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF0E RID: 57102 RVA: 0x0020B538 File Offset: 0x00209738
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attributes_.AddEntriesFrom(ref input, MonsterAttributeNotify._map_attributes_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005BFE RID: 23550
		private static readonly MessageParser<MonsterAttributeNotify> _parser = new MessageParser<MonsterAttributeNotify>(() => new MonsterAttributeNotify());

		// Token: 0x04005BFF RID: 23551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C00 RID: 23552
		public const int IdFieldNumber = 7;

		// Token: 0x04005C01 RID: 23553
		private long id_;

		// Token: 0x04005C02 RID: 23554
		public const int AttributesFieldNumber = 14;

		// Token: 0x04005C03 RID: 23555
		private static readonly MapField<int, int>.Codec _map_attributes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x04005C04 RID: 23556
		private readonly MapField<int, int> attributes_ = new MapField<int, int>();
	}
}
