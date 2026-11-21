using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E1 RID: 2529
	[NetMessage(EMessageId.MonsterAttributeNotify)]
	public sealed class MonsterAttributeNotify : IMessage<MonsterAttributeNotify>, IMessage, IEquatable<MonsterAttributeNotify>, IDeepCloneable<MonsterAttributeNotify>, IBufferMessage
	{
		// Token: 0x0600DDE1 RID: 56801 RVA: 0x00209109 File Offset: 0x00207309
		[NullableContext(1)]
		public static MonsterAttributeNotify Create()
		{
			return new MonsterAttributeNotify();
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x0600DDE2 RID: 56802 RVA: 0x00209110 File Offset: 0x00207310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterAttributeNotify> Parser
		{
			get
			{
				return MonsterAttributeNotify._parser;
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0600DDE3 RID: 56803 RVA: 0x00209117 File Offset: 0x00207317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x0600DDE4 RID: 56804 RVA: 0x0020911A File Offset: 0x0020731A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterAttributeNotify.Descriptor;
			}
		}

		// Token: 0x0600DDE5 RID: 56805 RVA: 0x00209121 File Offset: 0x00207321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeNotify()
		{
		}

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x00209134 File Offset: 0x00207334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeNotify(MonsterAttributeNotify other) : this()
		{
			this.id_ = other.id_;
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DDE7 RID: 56807 RVA: 0x0020916A File Offset: 0x0020736A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAttributeNotify Clone()
		{
			return new MonsterAttributeNotify(this);
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x0600DDE8 RID: 56808 RVA: 0x00209172 File Offset: 0x00207372
		// (set) Token: 0x0600DDE9 RID: 56809 RVA: 0x0020917A File Offset: 0x0020737A
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

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x0600DDEA RID: 56810 RVA: 0x00209183 File Offset: 0x00207383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x0600DDEB RID: 56811 RVA: 0x0020918B File Offset: 0x0020738B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterAttributeNotify);
		}

		// Token: 0x0600DDEC RID: 56812 RVA: 0x0020919C File Offset: 0x0020739C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterAttributeNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Attributes.Equals(other.Attributes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DDED RID: 56813 RVA: 0x002091EC File Offset: 0x002073EC
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

		// Token: 0x0600DDEE RID: 56814 RVA: 0x00209239 File Offset: 0x00207439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DDEF RID: 56815 RVA: 0x00209246 File Offset: 0x00207446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DDF0 RID: 56816 RVA: 0x00209250 File Offset: 0x00207450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.Id);
			}
			this.attributes_.WriteTo(ref output, MonsterAttributeNotify._map_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DDF1 RID: 56817 RVA: 0x002092A0 File Offset: 0x002074A0
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

		// Token: 0x0600DDF2 RID: 56818 RVA: 0x002092F4 File Offset: 0x002074F4
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

		// Token: 0x0600DDF3 RID: 56819 RVA: 0x00209341 File Offset: 0x00207541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DDF4 RID: 56820 RVA: 0x0020934C File Offset: 0x0020754C
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
				if (num != 96U)
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

		// Token: 0x04005C07 RID: 23559
		private static readonly MessageParser<MonsterAttributeNotify> _parser = new MessageParser<MonsterAttributeNotify>(() => new MonsterAttributeNotify());

		// Token: 0x04005C08 RID: 23560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C09 RID: 23561
		public const int IdFieldNumber = 12;

		// Token: 0x04005C0A RID: 23562
		private long id_;

		// Token: 0x04005C0B RID: 23563
		public const int AttributesFieldNumber = 14;

		// Token: 0x04005C0C RID: 23564
		private static readonly MapField<int, int>.Codec _map_attributes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x04005C0D RID: 23565
		private readonly MapField<int, int> attributes_ = new MapField<int, int>();
	}
}
