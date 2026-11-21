using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000476 RID: 1142
	public sealed class EntityFlySkin : IMessage<EntityFlySkin>, IMessage, IEquatable<EntityFlySkin>, IDeepCloneable<EntityFlySkin>, IBufferMessage
	{
		// Token: 0x06006DDE RID: 28126 RVA: 0x0010E7F9 File Offset: 0x0010C9F9
		[NullableContext(1)]
		public static EntityFlySkin Create()
		{
			return new EntityFlySkin();
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06006DDF RID: 28127 RVA: 0x0010E800 File Offset: 0x0010CA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityFlySkin> Parser
		{
			get
			{
				return EntityFlySkin._parser;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06006DE0 RID: 28128 RVA: 0x0010E807 File Offset: 0x0010CA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06006DE1 RID: 28129 RVA: 0x0010E80A File Offset: 0x0010CA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFlySkin.Descriptor;
			}
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x0010E811 File Offset: 0x0010CA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlySkin()
		{
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x0010E824 File Offset: 0x0010CA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlySkin(EntityFlySkin other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skinInfos_ = other.skinInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x0010E85A File Offset: 0x0010CA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlySkin Clone()
		{
			return new EntityFlySkin(this);
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06006DE5 RID: 28133 RVA: 0x0010E862 File Offset: 0x0010CA62
		// (set) Token: 0x06006DE6 RID: 28134 RVA: 0x0010E86A File Offset: 0x0010CA6A
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

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06006DE7 RID: 28135 RVA: 0x0010E873 File Offset: 0x0010CA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlySkinInfo> SkinInfos
		{
			get
			{
				return this.skinInfos_;
			}
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x0010E87B File Offset: 0x0010CA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFlySkin);
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x0010E88C File Offset: 0x0010CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFlySkin other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.skinInfos_.Equals(other.skinInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x0010E8DC File Offset: 0x0010CADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.skinInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x0010E929 File Offset: 0x0010CB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x0010E936 File Offset: 0x0010CB36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x0010E940 File Offset: 0x0010CB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.skinInfos_.WriteTo(ref output, EntityFlySkin._repeated_skinInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x0010E990 File Offset: 0x0010CB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.skinInfos_.CalculateSize(EntityFlySkin._repeated_skinInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x0010E9E4 File Offset: 0x0010CBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFlySkin other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.skinInfos_.Add(other.skinInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x0010EA31 File Offset: 0x0010CC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x0010EA3C File Offset: 0x0010CC3C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.skinInfos_.AddEntriesFrom(ref input, EntityFlySkin._repeated_skinInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003BD9 RID: 15321
		private static readonly MessageParser<EntityFlySkin> _parser = new MessageParser<EntityFlySkin>(() => new EntityFlySkin());

		// Token: 0x04003BDA RID: 15322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BDB RID: 15323
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003BDC RID: 15324
		private long entityId_;

		// Token: 0x04003BDD RID: 15325
		public const int SkinInfosFieldNumber = 2;

		// Token: 0x04003BDE RID: 15326
		private static readonly FieldCodec<FlySkinInfo> _repeated_skinInfos_codec = FieldCodec.ForMessage<FlySkinInfo>(18U, FlySkinInfo.Parser);

		// Token: 0x04003BDF RID: 15327
		private readonly RepeatedField<FlySkinInfo> skinInfos_ = new RepeatedField<FlySkinInfo>();
	}
}
